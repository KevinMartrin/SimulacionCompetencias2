using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimulacionCompetencias;

namespace SimulacionCompetencias.Classes
{
    public class GeneradorAleatorio
    {
        public GeneradorAleatorio() { }
        public List<Asignacion> CrearListaOrigen(int puntosTotales, int semilla, int limiteInferior, int limiteSuperior)
        {
            List <Asignacion > listaAsignacion = new List<Asignacion>();
            for (int i = 0; i < puntosTotales; i++)
            {
                Asignacion generador = new Asignacion();
                Algoritmo aleatorio = new Algoritmo();
                generador.latitud = aleatorio.CongruencialLineal(semilla,limiteInferior,limiteSuperior);
                generador.longitud = aleatorio.CongruencialLineal(semilla+1, limiteInferior, limiteSuperior);
                generador.idPunto = i;
                generador.activo = false;

                listaAsignacion.Add(generador);
            }
            return listaAsignacion;
        }
    }
}
