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
        public List<Asignacion> CrearListaOrigen(int puntosTotales, int limiteInferior, int limiteSuperior)
        {
            List <Asignacion > listaAsignacion = new List<Asignacion>();
            for (int i = 0; i < puntosTotales; i++)
            {
                Asignacion generador = new Asignacion();
                Algoritmo aleatorio = new Algoritmo();
                generador.latitud = aleatorio.CuadradoMedio(limiteInferior, limiteSuperior);
                generador.longitud = aleatorio.CuadradoMedio(limiteInferior, limiteSuperior);
                generador.idPunto = i;
                generador.especie = aleatorio.CuadradoMedio(1, 11); ;
                generador.activo = false;

                listaAsignacion.Add(generador);
            }
            return listaAsignacion;
        }
    }
}
