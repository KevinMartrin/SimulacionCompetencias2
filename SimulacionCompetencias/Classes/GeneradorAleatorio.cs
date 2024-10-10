using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Random aleatorio = new Random();

                Asignacion generador = new Asignacion();
                generador.latitud = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.longitud = aleatorio.Next(limiteInferior, limiteSuperior);
                generador.idPunto = i;
                generador.especie = i.ToString();
                generador.activo = false;

                listaAsignacion.Add(generador);
            }
            return listaAsignacion;
        }
    }
}
