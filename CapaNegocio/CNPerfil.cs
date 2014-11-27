using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNPerfil
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNPerfil.codigo; }
            set { CNPerfil.codigo = value; }
        }
        private static int codCarr;

        public static int CodCarr
        {
            get { return CNPerfil.codCarr; }
            set { CNPerfil.codCarr = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNPerfil.nombre; }
            set { CNPerfil.nombre = value; }
        }
    }
}
