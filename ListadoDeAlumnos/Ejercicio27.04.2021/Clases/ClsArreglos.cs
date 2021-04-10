using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27._04._2021.Clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private string[] datos;
        private int i, j, datoTemporal;
        private int tamanoArreglo = 0;
        private string[] arreglo, arreglo1, arreglosuma;

        public int GetTamanoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(string[] arregloParametro)
        {
            datos = arregloParametro;
            tamanoArreglo = datos.Length;
        }

        public ClsArreglos(string v)
        {
        }

        public string[] MetodoBurbuja()
        {
            string[] ArregloTemporal = {};
            arreglo = new string[datos.Length];
            arreglo1 = new string[datos.Length];
            arreglosuma = new string[arreglo.Length + arreglo1.Length];

            arreglo.CopyTo(arreglosuma, 0);
            arreglo1.CopyTo(arreglosuma, arreglo.Length);

            for (int i = 0; i < arreglosuma.Length; i++)
            {
                for (int j = 0; j < arreglosuma.Length; j++)
                {
                   if(i < arreglosuma.Length -1)
                   {

                   }
                }
            }
            return arreglosuma;
        }
    }
}
