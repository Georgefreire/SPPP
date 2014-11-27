using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNCuenta
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNCuenta.codigo; }
            set { CNCuenta.codigo = value; }
        }
        private static int codResp;

        public static int CodResp
        {
            get { return CNCuenta.codResp; }
            set { CNCuenta.codResp = value; }
        }
        private static string usuario;

        public static string Usuario
        {
            get { return CNCuenta.usuario; }
            set { CNCuenta.usuario = value; }
        }
        private static string contraseña;

        public static string Contraseña
        {
            get { return CNCuenta.contraseña; }
            set { CNCuenta.contraseña = value; }
        }
    }
}
