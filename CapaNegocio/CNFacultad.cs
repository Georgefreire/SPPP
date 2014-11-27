using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNFacultad
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNFacultad.codigo; }
            set { CNFacultad.codigo = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNFacultad.nombre; }
            set { CNFacultad.nombre = value; }
        }
    }
}
