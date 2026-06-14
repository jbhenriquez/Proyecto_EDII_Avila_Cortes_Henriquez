using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal static class Global
    {
        public static Grafo Ciudad = new Grafo();

        /*
        public static SegmentTree Trafico =
            new SegmentTree(new int[] { 20, 80, 50, 90, 40 });
        */
        public static MaxHeap Incidentes =
            new MaxHeap();

        public static bool GrafoCargado = false;
    }
}