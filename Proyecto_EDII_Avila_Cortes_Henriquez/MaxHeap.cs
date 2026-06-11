using System.Collections.Generic;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    class MaxHeap
    {
        private List<Incidente> heap = new List<Incidente>();

        public void Insertar(Incidente incidente)
        {
            heap.Add(incidente);
            heap.Sort((a, b) =>
                b.Prioridad.CompareTo(a.Prioridad));
        }

        public Incidente ExtraerMax()
        {
            if (heap.Count == 0)
                return null;

            Incidente incidente = heap[0];
            heap.RemoveAt(0);

            return incidente;
        }
    }
}