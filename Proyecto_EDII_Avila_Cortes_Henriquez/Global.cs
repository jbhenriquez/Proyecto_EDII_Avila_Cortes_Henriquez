using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal static class Global
    {
        public static Grafo Ciudad = new Grafo();

        //pendiente de cargar con los datos del trafico
        public static SegmentTree Trafico =
            new SegmentTree();
        
        public static MaxHeap Incidentes =
            new MaxHeap();

        public static bool GrafoCargado = false;
    }
}