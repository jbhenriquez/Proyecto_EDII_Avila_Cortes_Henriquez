using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal class Grafo
    {
        private Dictionary<string, List<Arista>> grafo = new Dictionary<string, List<Arista>>();

        public void AgregarCalle(string origen, string destino, int peso)
        {
            if (!grafo.ContainsKey(origen)) grafo[origen] = new List<Arista>();
            if (!grafo.ContainsKey(destino)) grafo[destino] = new List<Arista>();
            grafo[origen].Add(new Arista(destino, peso));
            grafo[destino].Add(new Arista(origen, peso));
        }
        public Dictionary<string, List<Arista>> ObtenerGrafo()
        {
            return grafo;
        }

        public void Mostrar()
        { // Hay que adecuarlo para mostrarlo en el DataGridView
            foreach (var nodo in grafo) // Recorre cada nodo del grafo
            {
                Console.Write($"{nodo.Key}: ");
                foreach (var arista in nodo.Value)
                {
                    Console.Write($"({arista.Destino}, {arista.Peso}) ");
                }
                Console.WriteLine();
            }
        } // fin Mostrar

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
    }
}
