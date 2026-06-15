using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal class Grafo
    {
        private Dictionary<string, List<Arista>> grafo = new Dictionary<string, List<Arista>>();

        // Diccionario para guardar cada nodo y su lista de nodos conectados con ciudades conectadas (adyacencias)
        private Dictionary<string, List<string>> adyacencias = new Dictionary<string, List<string>>();

        
        
        // asignamos un indice a cada nodo para poder usarlo como indice en el arreglo del Segment Tree
        private Dictionary<string, int> indiceNodo = new Dictionary<string, int>(); // para mapear cada nodo a un indice único
        private List<string> indiceANodo = new List<string>(); // para mapear de vuelta el indice a su nodo correspondiente
        private int[] nodeValues = Array.Empty<int>();  // arreglo para almacenar la métrica de cada nodo (ejemplo: peso máximo incidente)
        private SegmentTree segmentTree = Global.Trafico; // referencia al Segment Tree global para actualizarlo con las métricas de los nodos


        //Lista de visitados despues de ejecutar Dijkstra
        public List<string> UltimosVisitados { get; private set; } = new List<string>();

        public void AgregarCalle(string origen, string destino, int peso)
        {
            if (!grafo.ContainsKey(origen)) grafo[origen] = new List<Arista>();
            if (!grafo.ContainsKey(destino)) grafo[destino] = new List<Arista>();

            // Añadir la arista al grafo (bidireccional)
            grafo[origen].Add(new Arista(destino, peso));
            grafo[destino].Add(new Arista(origen, peso));

            // Para mantener adyacencias.
            AgregarConexion(origen, destino);
            AgregarConexion(destino, origen);

            // Asegurar mapeo e actualizar métricas en el Segment Tree
            AsegurarNodoExiste(origen);
            AsegurarNodoExiste(destino);
            ActualizarMetricaNodo(origen);
            ActualizarMetricaNodo(destino);
        }
        public Dictionary<string, List<Arista>> ObtenerGrafo()
        {
            return grafo;
        }


        public void EliminarCalle(string origen, string destino)
        {
            if (grafo.ContainsKey(origen))
                grafo[origen].RemoveAll(a => a.Destino == destino);
            if (grafo.ContainsKey(destino))
                grafo[destino].RemoveAll(a => a.Destino == origen);
        }

        public int MostrarPesoCalle(string origen, string destino, out int peso)
        {  if (grafo.ContainsKey(origen))
            {
                var arista = grafo[origen].Find(a => a.Destino == destino);
                if (arista != null)
                {
                    peso = arista.Peso;
                    return peso;
                }
            }
            peso = -1; // Indica que no se encontró la calle
            return peso;
        }
        public void ModificarCalle(string origen, string destino, int nuevoPeso)
        {
            if (grafo.ContainsKey(origen))
            {
                var arista = grafo[origen].Find(a => a.Destino == destino);
                if (arista != null) arista.Peso = nuevoPeso;
            }
            if (grafo.ContainsKey(destino))
            {
                var arista = grafo[destino].Find(a => a.Destino == origen);
                if (arista != null) arista.Peso = nuevoPeso;
            }
        }

        public int Dijkstra(string inicio, string destino)
        {
            Dictionary<string, int> distancia = new Dictionary<string, int>();
            HashSet<string> visitados = new HashSet<string>();

            foreach (var nodo in grafo.Keys)
                distancia[nodo] = int.MaxValue;

            distancia[inicio] = 0;

            while (visitados.Count < grafo.Count)
            {
                string actual = null;
                int menor = int.MaxValue;

                foreach (var nodo in distancia)
                {
                    if (!visitados.Contains(nodo.Key) &&
                        nodo.Value < menor)
                    {
                        menor = nodo.Value;
                        actual = nodo.Key;
                    }
                }

                if (actual == null)
                    break;

                visitados.Add(actual);

                foreach (var vecino in grafo[actual])
                {
                    int nueva = distancia[actual] + vecino.Peso;

                    if (nueva < distancia[vecino.Destino])
                        distancia[vecino.Destino] = nueva;
                }
            }

            return distancia[destino];
        }// fin Dijkstra
               
        

        // Método para agregar una conexión (arista) entre origen y destino
        public void AgregarConexion(string origen, string destino)
        {
            if (!adyacencias.ContainsKey(origen))
                adyacencias[origen] = new List<string>();

            if (!adyacencias.ContainsKey(destino))
                adyacencias[destino] = new List<string>();

            // Si el grafo es bidireccional (no dirigido), descomenta la línea de abajo
            // adyacencias[destino].Add(origen); 

            adyacencias[origen].Add(destino);
        }

        // Método para obtener los nodos conectados a un nodo específico
        public List<string> ObtenerConexiones(string nodo)
        {
            if (adyacencias.ContainsKey(nodo))
                return adyacencias[nodo];

            return new List<string>();
        }

        // Asegura existencia del nodo en el mapeo; si es nuevo, reconstruye el segment tree
        private void AsegurarNodoExiste(string nodo)
        {
            if (indiceNodo.ContainsKey(nodo)) return;

            int newIndex = indiceANodo.Count;
            indiceNodo[nodo] = newIndex;
            indiceANodo.Add(nodo);

            // Reconstruir nodeValues con la métrica actual (peso máximo incidente)
            int n = indiceANodo.Count;
            var arr = new int[n];
            for (int i = 0; i < n - 1; i++) // copiar valores anteriores si existían
                arr[i] = (i < nodeValues.Length) ? nodeValues[i] : 0;
            arr[n - 1] = CalcularMetricaNodo(nodo);
            nodeValues = arr;
            Global.Trafico = new SegmentTree(nodeValues); // Reconstruir el Segment Tree con los nuevos valores

        }

        // Calcula la métrica de ejemplo: peso máximo de las aristas incidentes en 'nodo'
        private int CalcularMetricaNodo(string nodo)
        {
            if (!grafo.ContainsKey(nodo) || grafo[nodo].Count == 0) return 0;
            int maxPeso = int.MinValue;
            foreach (var a in grafo[nodo])
                if (a.Peso > maxPeso) maxPeso = a.Peso;
            return maxPeso;
        }

        // Método auxiliar para actualizar el segment tree para un nodo existente
        private void ActualizarMetricaNodo(string nodo)
        {
            if (!indiceNodo.TryGetValue(nodo, out int idx)) return;
            int valor = CalcularMetricaNodo(nodo);
            nodeValues[idx] = valor;
            if (segmentTree != null)
                segmentTree.Actualizar(idx, valor);
        }
    }
}
