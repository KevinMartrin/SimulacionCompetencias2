using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionCompetencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Paso 0: Condicion de vacio
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("Los numeros tienen que ser mayor que 0, no vacios");
                return;
            }

            //Paso 1: Inicializacion de parametros
            int puntosTotales = Convert.ToInt32(textBox1.Text);
            int minimo = Convert.ToInt32(textBox2.Text);
            int maximo = Convert.ToInt32(textBox3.Text);

            //Paso 2: Llamar al algoritmo
            GeneradorAleatorio generador = new GeneradorAleatorio();
        }
    }
}
