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

        public void Dijkstra(string inicio, string destino)
        {

        }
    }
}
