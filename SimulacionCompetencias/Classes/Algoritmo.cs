using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
            //int col5;
            for (int i = 0; i < 10; i++)
            {
                int col2 = col1 * col1;
                string col2_2 = Convert.ToString(col2);
                string col2_3 = col2_2.Remove(0, col2_2.Length - 1);
                int col3 = Convert.ToInt32(col2_3);
                if (Convert.ToString(col3).Length <= n)
                {
                    col4 = col3;
                    //col5 = 0; 
                }
                else
                {
                    col4 = Convert.ToInt32(Convert.ToString(col3).Substring(0, Convert.ToString(col3).Length - 2));
                    //col5 = Convert.ToInt32(Convert.ToString(col3).Substring(1, Convert.ToString(col3).Length-1));
                }

                lista.Add(col4);
                //lista.Add(col5);
                //if (col4 != 0 && col5 != 0){
                //    int[] cols = new int[] { col4, col5 };
                //    Random rand = new Random();
                //     int indice = rand.Next(cols.Length);
                //   int col_elegida = cols[indice];

                // col1 = col_elegida;
                // }
                //else
                // {
                //  col1 = col4;
                //}     

                col1 = col4;
                c++;
            }
            return col1;
        }

    }
}

