using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNEntidad
    {
        private static string ruc;

        public static string Ruc
        {
            get { return CNEntidad.ruc; }
            set { CNEntidad.ruc = value; }
        }
        private static int codigo;
        
        public static int Codigo
        {
            get { return CNEntidad.codigo; }
            set { CNEntidad.codigo = value; }
        }
        private static string nombreEnt;

        public static string NombreEnt
        {
            get { return CNEntidad.nombreEnt; }
            set { CNEntidad.nombreEnt = value; }
        }
        private static string tipoEnt;

        public static string TipoEnt
        {
            get { return CNEntidad.tipoEnt; }
            set { CNEntidad.tipoEnt = value; }
        }
        private static string direccionEnt;

        public static string DireccionEnt
        {
            get { return CNEntidad.direccionEnt; }
            set { CNEntidad.direccionEnt = value; }
        }
        private static string telefonoEnt;

        public static string TelefonoEnt
        {
            get { return CNEntidad.telefonoEnt; }
            set { CNEntidad.telefonoEnt = value; }
        }
        private static string correoEnt;

        public static string CorreoEnt
        {
            get { return CNEntidad.correoEnt; }
            set { CNEntidad.correoEnt = value; }
        }
        private static string representanteEnt;

        public static string RepresentanteEnt
        {
            get { return CNEntidad.representanteEnt; }
            set { CNEntidad.representanteEnt = value; }
        }
        private static string tituloRep;

        public static string TituloRep
        {
            get { return CNEntidad.tituloRep; }
            set { CNEntidad.tituloRep = value; }
        }
        private static string cargoRep;

        public static string CargoRep
        {
            get { return CNEntidad.cargoRep; }
            set { CNEntidad.cargoRep = value; }
        }
        private static string telefonoRep;

        public static string TelefonoRep
        {
            get { return CNEntidad.telefonoRep; }
            set { CNEntidad.telefonoRep = value; }
        }
        private static string correoRep;

        public static string CorreoRep
        {
            get { return CNEntidad.correoRep; }
            set { CNEntidad.correoRep = value; }
        }
        
    }
}
