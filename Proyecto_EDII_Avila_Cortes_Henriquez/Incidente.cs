using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    class Incidente
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; }
        public Incidente(string descripcion, DateTime fecha, string ubicacion)
        {
            Descripcion = descripcion;
            Fecha = fecha;
            Ubicacion = ubicacion;
        }
        public override string ToString()
        {
            return $"Incidente: {Descripcion}, Fecha: {Fecha}, Ubicación: {Ubicacion}";
        }
    }
}
