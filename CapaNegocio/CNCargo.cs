using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNCargo
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNCargo.codigo; }
            set { CNCargo.codigo = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNCargo.nombre; }
            set { CNCargo.nombre = value; }
        }
        private static string descripcion;

        public static string Descripcion
        {
            get { return CNCargo.descripcion; }
            set { CNCargo.descripcion = value; }
        }
    }
}
