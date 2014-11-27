using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNDocCarac
    {
        private static int codigo;

        public static int Codigo
        {
            get { return CNDocCarac.codigo; }
            set { CNDocCarac.codigo = value; }
        }
        private static int codDoc;

        public static int CodDoc
        {
            get { return CNDocCarac.codDoc; }
            set { CNDocCarac.codDoc = value; }
        }
        private static int codCarac;

        public static int CodCarac
        {
            get { return CNDocCarac.codCarac; }
            set { CNDocCarac.codCarac = value; }
        }
        private static string descripcion;

        public static string Descripcion
        {
            get { return CNDocCarac.descripcion; }
            set { CNDocCarac.descripcion = value; }
        }
    }
}
