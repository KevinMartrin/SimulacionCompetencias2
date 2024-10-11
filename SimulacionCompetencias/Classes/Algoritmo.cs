using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionCompetencias.Classes
{
    public class Algoritmo
    {
        public Algoritmo() { }
        public int CuadradoMedio(int min, int max)
        {
            Random aleatorio = new Random();

            List<int> lista = new List<int>();

            int col1 = aleatorio.Next(min, max);
            int n = Convert.ToString(col1).Length;
            int c = 0;
            int col4;
            for (int i = 0; i < 10; i++)
            {
                int col2 = col1 * col1;
                int col3 = Convert.ToInt32(Convert.ToString(col2).Substring(1, Convert.ToString(col2).Length - 1));
                if (Convert.ToString(col3).Length <= n)
                {
                    col4 = col3;
                }
                else
                {
                    col4 = Convert.ToInt32(Convert.ToString(col3).Substring(0, Convert.ToString(col3).Length-1));
                }

                lista.Add(col4);

                col1 = col4;
                c++;
            }
            return lista[c / 2];
        }

    }
}
