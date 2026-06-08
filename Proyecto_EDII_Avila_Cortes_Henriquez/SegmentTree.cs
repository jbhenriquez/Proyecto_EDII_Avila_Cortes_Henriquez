using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    class SegmentTree
    {
        private int[] tree;
        private int n;

        public SegmentTree(int[] arr)
        {
            n = arr.Length;
            tree = new int[4 * n];
            Construir(arr, 1, 0, n - 1);
        }

        private void Construir(int[] arr, int nodo, int inicio, int fin)
        {
            if (inicio == fin)
            {
                tree[nodo] = arr[inicio];
            }
            else
            {
                int mitad = (inicio + fin) / 2;
                Construir(arr, 2 * nodo, inicio, mitad);
                Construir(arr, 2 * nodo + 1, mitad + 1, fin);
                tree[nodo] = Math.Max(tree[2 * nodo], tree[2 * nodo + 1]);
            }
        }// fin Construir

        public void Actualizar(int indice, int valor)
        {
            Actualizar(1, 0, n - 1, indice, valor);
        }

        private void Actualizar(int nodo, int inicio, int fin, int indice, int valor)
        {
            if (inicio == fin)
            {
                tree[nodo] = valor;
            }
            else
            {
                int mitad = (inicio + fin) / 2;
                if (indice <= mitad)
                {
                    Actualizar(2 * nodo, inicio, mitad, indice, valor);
                }
                else
                {
                    Actualizar(2 * nodo + 1, mitad + 1, fin, indice, valor);
                }
                tree[nodo] = Math.Max(tree[2 * nodo], tree[2 * nodo + 1]);
            }
        }// fin Actualizar

        public int Consultar(int izquierda, int derecha)
        {
            return Consultar(1, 0, n - 1, izquierda, derecha);
        }

        private int Consultar(int nodo, int inicio, int fin, int izquierda, int derecha)
        {
            if (derecha < inicio || fin < izquierda)
            {
                return int.MinValue;
            }

            if (izquierda <= inicio && fin <= derecha)
            {
                return tree[nodo];
            }

            int mitad = (inicio + fin) / 2;
            int izq = Consultar(2 * nodo, inicio, mitad, izquierda, derecha);
            int der = Consultar(2 * nodo + 1, mitad + 1, fin, izquierda, derecha);
            return Math.Max(izq, der);
        }// fin Consultar
    }// fin SegmentTree
}
