using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionCompetencias.Classes
{
    public class Arco
    {
        public int idInicio { get; set; }
        public int idFinal { get; set; }
        public double distancia { get; set; }
        public double competitividad { get; set; }

        public Arco() { }
        public Arco(Arco a_arco)
        {
            idInicio = a_arco.idInicio;
            idFinal = a_arco.idFinal;
            distancia = a_arco.distancia;
            competitividad = a_arco.competitividad;
        }
    }
}
