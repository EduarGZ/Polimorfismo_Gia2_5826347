using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo_Gia2_5826347
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //objeto de la clase Promedio Programación
            PromedioProgramacion objP = new PromedioProgramacion();

            //Enviando los valores a la clase
            objP.estudiante = txtEstudiante.Text;
            objP.evaluacion1 = int.Parse(txtEva1.Text);
            objP.evaluacion2 = int.Parse(txtEva2.Text);
            objP.evaluacion3 = int.Parse(txtEva3.Text);
            objP.actitudinal = int.Parse(txtActitudinal.Text);

            //Calculando el promedio
            double promedio = objP.calculaPromedio();
            string condicion = objP.determinaCondicion();

            //Imprimir en la lista
            ListViewItem fila = new ListViewItem(objP.estudiante);
            fila.SubItems.Add(objP.evaluacion1.ToString("0.00"));
            fila.SubItems.Add(objP.evaluacion2.ToString("0.00"));
            fila.SubItems.Add(objP.evaluacion3.ToString("0.00"));
            fila.SubItems.Add(objP.actitudinal.ToString("0.00"));
            fila.SubItems.Add(objP.calculaPromedio().ToString("0.00"));
            fila.SubItems.Add(objP.determinaCondicion());
            lvlnformacion.Items.Add(fila);

            //Imprimir las estadisticas
            estadisticas();
        }
        //Metodo que determina la suma de todos los promedios
        double sumaPromedio()
        {
            double suma = 0;
            for(int i = 0;i< lvlnformacion.Items.Count; i++)
            {
                suma += double.Parse(lvlnformacion.Items[i].SubItems[5].Text);
            }
            return suma;
        }
        //Método que determina cual es el promedio mas alto
        double promedioMasAlto()
        {
            double mayor = 0;
            for(int i = 0; i< lvlnformacion.Items.Count; i++)
            {
                if (double.Parse(lvlnformacion.Items[i].SubItems[5].Text) > mayor)
                {
                    mayor = double.Parse(lvlnformacion.Items[i].SubItems[5].Text);
                }
            }
            return mayor;
        }

        double promedioMasBajo()
        {
            double menor = int.MaxValue;
            for (int i = 0; i < lvlnformacion.Items.Count; i++)
            {
                if (double.Parse(lvlnformacion.Items[i].SubItems[5].Text) < menor)
                {
                    menor = double.Parse(lvlnformacion.Items[i].SubItems[5].Text);
                }
            }
            return menor;
        }

        //Método que determina el total de aprobados
        int totalAprobados()
        {
            int cAprobados = 0;
            for(int i = 0; i < lvlnformacion.Items.Count; i++)
            {
                if(double.Parse(lvlnformacion.Items[i].SubItems[5].Text) > 10)
                {
                    cAprobados++;
                }
            }
            return cAprobados;
        }
        //Método que determina el total de desaprobados
        int totalDesaprobados()
        {
            int cDesaprobados = 0;
            for(int i = 0; i < lvlnformacion.Items.Count; i++)
            {
                if (double.Parse(lvlnformacion.Items[i].SubItems[5].Text) <= 10)
                {
                    cDesaprobados++;
                }
            }
            return cDesaprobados;
        }

        void estadisticas()
        {
            lbResumen.Items.Clear();
            lbResumen.Items.Add("Suma de promedios: " + sumaPromedio().ToString("0.00"));
            lbResumen.Items.Add("Promedio mas alto: " + promedioMasAlto().ToString("0.00"));
            lbResumen.Items.Add("Promedio mas bajo: " + promedioMasBajo().ToString("0.00"));
            lbResumen.Items.Add("Total de aprobados: " + totalAprobados().ToString("0.00"));
            lbResumen.Items.Add("Total de desaprobados: " + totalDesaprobados().ToString("0.00"));

        }

        private void btnNuevoDato_Click(object sender, EventArgs e)
        {
            txtEstudiante.Text = "";
            txtEva1.Clear();
            txtEva2.Clear();
            txtEva3.Clear();
            txtActitudinal.Text = "";
        }
    }
}
