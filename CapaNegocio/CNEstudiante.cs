using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNEstudiante
    {
        private static int codcarr;

        public static int Codcarr
        {
            get { return CNEstudiante.codcarr; }
            set { CNEstudiante.codcarr = value; }
        }
        private static int codigo;

        public static int Codigo
        {
            get { return CNEstudiante.codigo; }
            set { CNEstudiante.codigo = value; }
        }
        private static string cedula;

        public static string Cedula
        {
            get { return CNEstudiante.cedula; }
            set { CNEstudiante.cedula = value; }
        }
        private static string nombres;

        public static string Nombres
        {
            get { return CNEstudiante.nombres; }
            set { CNEstudiante.nombres = value; }
        }
        private static string apellidos;

        public static string Apellidos
        {
            get { return CNEstudiante.apellidos; }
            set { CNEstudiante.apellidos = value; }
        }
        private static string sexo;

        public static string Sexo
        {
            get { return CNEstudiante.sexo; }
            set { CNEstudiante.sexo = value; }
        }
        private static string convencional;

        public static string Convencional
        {
            get { return CNEstudiante.convencional; }
            set { CNEstudiante.convencional = value; }
        }
        private static string movil;

        public static string Movil
        {
            get { return CNEstudiante.movil; }
            set { CNEstudiante.movil = value; }
        }
        private static string correo;

        public static string Correo
        {
            get { return CNEstudiante.correo; }
            set { CNEstudiante.correo = value; }
        }
        private static int creditos;

        public static int Creditos
        {
            get { return CNEstudiante.creditos; }
            set { CNEstudiante.creditos = value; }
        }
    }
}
