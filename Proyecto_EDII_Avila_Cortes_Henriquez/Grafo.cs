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

        //Lista de visitados despues de ejecutar Dijkstra
        public List<string> UltimosVisitados { get; private set; } = new List<string>();
        public void AgregarCalle(string origen, string destino, int peso)
        {
            if (!grafo.ContainsKey(origen)) grafo[origen] = new List<Arista>();
            if (!grafo.ContainsKey(destino)) grafo[destino] = new List<Arista>();
            grafo[origen].Add(new Arista(destino, peso));
            grafo[destino].Add(new Arista(origen, peso));
            AgregarConexion(origen, destino);
            AgregarConexion(destino, origen); // Por lo fuertemente conexo
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
    }
}
