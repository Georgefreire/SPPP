using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNCarrera
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNCarrera.codigo; }
            set { CNCarrera.codigo = value; }
        }
        private static int codFacu;

        public static int CodFacu
        {
            get { return CNCarrera.codFacu; }
            set { CNCarrera.codFacu = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNCarrera.nombre; }
            set { CNCarrera.nombre = value; }
        }
    }
}
