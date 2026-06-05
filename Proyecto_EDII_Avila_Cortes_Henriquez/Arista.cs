using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal class Arista
    {
        public string Destino;
        public int Peso;

        public Arista(string destino, int peso)
        {
            Destino = destino;
            Peso = peso;
        }
    }
}
