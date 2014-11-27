using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNDocumento
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNDocumento.codigo; }
            set { CNDocumento.codigo = value; }
        }
        private static int codTipo;

        public static int CodTipo
        {
            get { return CNDocumento.codTipo; }
            set { CNDocumento.codTipo = value; }
        }
        private static int codPrac;

        public static int CodPrac
        {
            get { return CNDocumento.codPrac; }
            set { CNDocumento.codPrac = value; }
        }
        private static string fecha;

        public static string Fecha
        {
            get { return CNDocumento.fecha; }
            set { CNDocumento.fecha = value; }
        }
    }
}
