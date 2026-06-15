using System.Collections.Generic;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    class MaxHeap
    {
        private List<Incidente> heap = new List<Incidente>();

        public void Insertar(Incidente incidente)
        {
            heap.Add(incidente);
        }

        public Incidente ExtraerMax()
        {
            HeapSort(heap);
            if (heap.Count == 0)
                return null;
            Incidente max = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count -1);
            Heapify(0);

            return max;
        }

        // HeapSort adaptado para trabajar con Incidente (ordena por Prioridad, descendente)
        public void HeapSort(List<Incidente> arr)
        {
            int n = arr.Count;

            // Construir el Max Heap
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(i);

            // Extraer elementos del heap uno por uno
            for (int i = n - 1; i > 0; i--)
            {
                // Mover la raíz actual al final
                Incidente temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(0);
            }
        }

        // Heapify adaptado para trabajar con Incidente (usa Prioridad)
        private void Heapify(int i)
        {
            int mayor = i; // Inicializar el más grande como raíz
            int izquierda = 2 * i + 1; // Hijo izquierdo
            int derecha = 2 * i + 2; // Hijo derecho

            // Si el hijo izquierdo es más grande que la raíz (comparando Prioridad)
            if (izquierda < heap.Count && heap[izquierda].Prioridad > heap[mayor].Prioridad)
                mayor = izquierda;
            // Si el hijo derecho es más grande que el más grande hasta ahora
            if (derecha < heap.Count && heap[derecha].Prioridad > heap[mayor].Prioridad)
                mayor = derecha;
            // Si el más grande no es la raíz
            if (mayor != i)
            {
                Incidente temp = heap[i];
                heap[i] = heap[mayor];
                heap[mayor] = temp;
                // Recursivamente heapificar la subraíz afectada
                Heapify(mayor);
            }
        }

    }
}