using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNResponsable
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNResponsable.codigo; }
            set { CNResponsable.codigo = value; }
        }
        private static int codCargo;

        public static int CodCargo
        {
            get { return CNResponsable.codCargo; }
            set { CNResponsable.codCargo = value; }
        }
        private static string cedula;

        public static string Cedula
        {
            get { return CNResponsable.cedula; }
            set { CNResponsable.cedula = value; }
        }
        private static string nombres;

        public static string Nombres
        {
            get { return CNResponsable.nombres; }
            set { CNResponsable.nombres = value; }
        }
        private static string apellidos;

        public static string Apellidos
        {
            get { return CNResponsable.apellidos; }
            set { CNResponsable.apellidos = value; }
        }
        private static string sexo;

        public static string Sexo
        {
            get { return CNResponsable.sexo; }
            set { CNResponsable.sexo = value; }
        }
        private static string movil;

        public static string Movil
        {
            get { return CNResponsable.movil; }
            set { CNResponsable.movil = value; }
        }
        private static string correo;

        public static string Correo
        {
            get { return CNResponsable.correo; }
            set { CNResponsable.correo = value; }
        }
        private static string titulo;

        public static string Titulo
        {
            get { return CNResponsable.titulo; }
            set { CNResponsable.titulo = value; }
        }
    }
}
