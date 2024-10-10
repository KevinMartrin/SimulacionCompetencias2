using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionCompetencias.Classes
{
    public class Asignacion
    {
        public double latitud { get; set; }
        public double longitud { get; set; }
        public int idPunto { get; set; }
        public bool activo { get; set; } //Para ver si hay o no un arbol
        public string especie { get; set; }
        public Asignacion() { }
        public Asignacion(Asignacion a_asignacion)
        {
            latitud = a_asignacion.latitud;
            longitud = a_asignacion.longitud;
            idPunto = a_asignacion.idPunto;
            activo = a_asignacion.activo;
            especie = a_asignacion.especie;
        }
    }
}
