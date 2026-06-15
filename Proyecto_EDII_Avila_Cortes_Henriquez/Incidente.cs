using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    class Incidente
    {
        // algunas propiedades estan comentadas para simplificar el proyecto, pero se pueden reactivar.
        public string Descripcion { get; set; }
        /*
        public DateTime Fecha { get; set; }
        public string Ubicacion { get; set; } */
        public int Prioridad { get; set; }

        public Incidente(string descripcion, /* DateTime fecha, string ubicacion,*/ int prioridad)
        {
            Descripcion = descripcion;
            /*Fecha = fecha;
            Ubicacion = ubicacion;*/
            Prioridad = prioridad;
        }
        public override string ToString()
        {
            return $"[{Prioridad}] {Descripcion}";
        }
    }
}
