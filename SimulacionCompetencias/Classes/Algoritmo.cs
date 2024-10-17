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
        public int CuadradoMedio(int min, int max, Random numero_aleatorio)
        {
            List<int> lista = new List<int>();

            int num_aleatorio = numero_aleatorio.Next(min, max);
            int col1 = num_aleatorio;
            int n = Convert.ToString(col1).Length;
            int c = 0;
            int col4 = col1;
            while (c < 1000 && !(col4 >= min && col4 <= max))
            {
                int col2 = col1 * col1;
                if (Convert.ToString(col2).Length <= 2)
                {
                    col4 = col2;
                }
                else
                {
                    int col3 = Convert.ToInt32(Convert.ToString(col2).Substring(1, Convert.ToString(col2).Length - 1));
                    if (Convert.ToString(col3).Length <= 1)
                    {
                        col4 = col3;
                    }
                    else
                    {
                        col4 = Convert.ToInt32(Convert.ToString(col3).Substring(0, Convert.ToString(col3).Length - 1));
                    }
                }

                lista.Add(col4);

                col1 = col4;
                c++;
            }

            int numerito = num_aleatorio;
            foreach (int i in lista)
            {
                if (i >= min && i <= max)
                {
                    numerito = i;
                }
            }

            return numerito;
        }

        public double CongruencialLineal(int p_semilla, int min, int max)
        {
            int x0 = p_semilla;
            int a = 7;
            Random rand = new Random(p_semilla);
            int m = rand.Next(p_semilla, 3 * p_semilla + 20);
            int c = 21;

            List<int> lista = new List<int>();

            int x_nueva = 0;
            for (int i = 0; i <= 15; i++)
            {
                x_nueva = (a * x0 + c) % m;
                lista.Add(x_nueva);
                x0 = x_nueva;
            }

            //int ale = 0;
            //for (int i = 0; i < lista.Count; i++)
            //{
                //if (lista[lista.Count - 1 - i] != 0)
                //{
                    //ale = lista[lista.Count - 1 - i];
                    //break;
                //}
            //}

            int ale = lista[lista.Count - 1];
            double ale_norm = ale / m;
            double ale_final = min + ale_norm * (max-min);
            return ale_norm;
        }

    }
}
