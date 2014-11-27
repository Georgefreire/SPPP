using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNActividad
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNActividad.codigo; }
            set { CNActividad.codigo = value; }
        }
        private static int codPerfil;

        public static int CodPerfil
        {
            get { return CNActividad.codPerfil; }
            set { CNActividad.codPerfil = value; }
        }
        private static int codPrac;

        public static int CodPrac
        {
            get { return CNActividad.codPrac; }
            set { CNActividad.codPrac = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNActividad.nombre; }
            set { CNActividad.nombre = value; }
        }
    }
}
