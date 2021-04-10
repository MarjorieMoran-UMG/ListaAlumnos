using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio27._04._2021.Clases;

namespace Ejercicio27._04._2021
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Por favor selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Marjorie\Desktop\Ejercicio27Lista";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String rnombres = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                listBoxNombres.Text = rnombres;
            }else
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String rcorrelativo = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                listBoxCorrelativo.Text = rcorrelativo;
            }else
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String rparcial1 = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                listBoxParcial1.Text = rparcial1;
            }else
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String rparcial2 = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                listBoxParcial2.Text = rparcial2;
            }else
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String rparcial3 = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                listBoxParcial3.Text = rparcial3;
            }

        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            foreach(string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxNombres.Items.Add(datosUnitarios[1]);
            }
        }

        private void buttonCorrelativo_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxCorrelativo.Items.Add(datosUnitarios[0]);
            }
        }

        private void buttonParcial1_Click(object sender, EventArgs e)
        { 
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxParcial1.Items.Add(datosUnitarios[2]);
            }

        }

        private void buttonParcial2_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxParcial2.Items.Add(datosUnitarios[3]);
            }
        }

        private void buttonParcial3_Click(object sender, EventArgs e)
        {
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                listBoxParcial3.Items.Add(datosUnitarios[4]);
            }
        }

        private void buttonPromedioAlumno_Click(object sender, EventArgs e)
        {
            double Parcial1, Parcial2, Parcial3, PromedioAlumno;

            foreach (string respuesta in ArregloNotas)
            {
                string[] rpromalumno = respuesta.Split(';');

                Parcial1 = Convert.ToDouble(rpromalumno[2]);
                Parcial2 = Convert.ToDouble(rpromalumno[3]);
                Parcial3 = Convert.ToDouble(rpromalumno[4]);
                PromedioAlumno = (Parcial1 + Parcial2 + Parcial3) / 3;

                listBoxPromedioAlumno.Items.Add($"{rpromalumno[1]}  =  {PromedioAlumno}");
            }


        }

        private void buttonPromedioParcial1_Click(object sender, EventArgs e)
        {
            double Parcial1, Suma = 0, Promedio = 0;

            foreach (string respuesta in ArregloNotas)
            {
                string[] promp1 = respuesta.Split(';');
                Parcial1 = Convert.ToDouble(promp1[2]);

                Suma += Parcial1;

            }
            Promedio = Suma / 60;
            listBoxPromedioParcial1.Items.Add($"{Promedio}");
        }

        private void buttonPromedioParcial2_Click(object sender, EventArgs e)
        {
            double Parcial2, Suma = 0, Promedio = 0;

            foreach (string respuesta in ArregloNotas)
            {
                string[] promp2 = respuesta.Split(';');
                Parcial2 = Convert.ToDouble(promp2[3]);

                Suma += Parcial2;

            }
            Promedio = Suma / 60;
            listBoxPromedioParcial2.Items.Add($"{Promedio}");
        }

        private void buttonPromedioParcial3_Click(object sender, EventArgs e)
        {
            double Parcial3, Suma = 0, Promedio = 0;

            foreach (string respuesta in ArregloNotas)
            {
                string[] promp3 = respuesta.Split(';');
                Parcial3 = Convert.ToDouble(promp3[4]);

                Suma += Parcial3;

            }
            Promedio = Suma / 60;
            listBoxPromedioParcial3.Items.Add($"{Promedio}");
        }

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            string[] arreglosuma = new string[59];

            ClsArreglos ObjetoArreglo = new ClsArreglos(arreglosuma[1]);
            string[] res = ObjetoArreglo.MetodoBurbuja();
            foreach (string r in res)
            {
                listBoxNombres.Items.Add(r);
            }
        }

        private void buttonNOTAS_Click(object sender, EventArgs e)
        {
            int Parcial1, Parcial2, Parcial3, PromedioAlumno;
            int NotaMasAlta, NotaMasBaja;

            foreach (string respuesta in ArregloNotas)
            {
                string[] rpromalumno = respuesta.Split(';');

                Parcial1 = Convert.ToInt32(rpromalumno[2]);
                Parcial2 = Convert.ToInt32(rpromalumno[3]);
                Parcial3 = Convert.ToInt32(rpromalumno[4]);
                PromedioAlumno = (Parcial1 + Parcial2 + Parcial3) / 3;

                if (PromedioAlumno>21)
                {
                    NotaMasAlta = PromedioAlumno;
                    listBoxNotaMasAlta.Items.Add($"{rpromalumno[1]} Nota:{NotaMasAlta}");
                }
                if (PromedioAlumno <3)
                    {
                    NotaMasBaja = PromedioAlumno;
                    listBoxNotaMasBaja.Items.Add($"{rpromalumno[1]} Nota:{NotaMasBaja}");
                }
            }
        }
    }
}
