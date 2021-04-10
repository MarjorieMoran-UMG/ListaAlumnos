using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27._04._2021.Clases
{
    class ClsArchivo
    {
        private object p;

        public ClsArchivo()
        {
        }

        public ClsArchivo(object p)
        {
            this.p = p;
        }

        public string[] LeerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo,Encoding.Default);
            return Lineas;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;

            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }
    }
}
