using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNDocTipo
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNDocTipo.codigo; }
            set { CNDocTipo.codigo = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNDocTipo.nombre; }
            set { CNDocTipo.nombre = value; }
        }
    }
}
