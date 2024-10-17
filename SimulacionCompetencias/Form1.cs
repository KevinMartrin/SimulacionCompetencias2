using SimulacionCompetencias.Classes;
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

        // ------------Funciones-------------
        public void llenarGrid(List<Asignacion> lista)
        {
            //Paso 0: Numero de columnas
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";

            //Paso 1: Determinar la cantidad de columnas
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Latitud");
            dataGridView1.Columns.Add(numeroColumna3, "Longitud");
            dataGridView1.Columns.Add(numeroColumna4, "Especie");

            //Paso 2: Recorrer el grid para cada fila y llenar de valores esperados
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = lista[i].idPunto.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].latitud.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i].longitud.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = lista[i].especie.ToString();
            }
        }
        public void descargarExcel(DataGridView data)
        {
            //Paso 0: Instalar complemento de Excel
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);
            int indiceColumna = 0;

            //Paso 1: Contruir columnas y los nombres de las cabeceras
            foreach (DataGridViewColumn columna in data.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.HeaderText;
            }

            //Paso 2: Construir filas y llenar valores
            int indiceFilas = 0;
            foreach (DataGridViewRow fila in data.Rows)
            {
                indiceFilas++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in data.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFilas + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }

            //Paso 3: Visibilidad
            exportarExcel.Visible = true;
        }

        // -----------Objetos en el form----------

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
            int semilla = Convert.ToInt32(textBox4.Text);
            int minimo = Convert.ToInt32(textBox2.Text);
            int maximo = Convert.ToInt32(textBox3.Text);

            //Paso 2: Llamar al algoritmo
            GeneradorAleatorio generador = new GeneradorAleatorio();

            //Paso 3: LLamar metodo principal
            List<Asignacion> listaSalida = generador.CrearListaOrigen(puntosTotales, semilla, minimo, maximo);

            //Paso 4: Llenar grid
            llenarGrid(listaSalida);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descargarExcel(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
