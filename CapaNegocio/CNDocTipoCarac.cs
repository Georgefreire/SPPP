using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNDocTipoCarac
    {
        private static int codig;

        public static int Codig
        {
            get { return CNDocTipoCarac.codig; }
            set { CNDocTipoCarac.codig = value; }
        }
        private static int codTipo;

        public static int CodTipo
        {
            get { return CNDocTipoCarac.codTipo; }
            set { CNDocTipoCarac.codTipo = value; }
        }
        private static string nombre;

        public static string Nombre
        {
            get { return CNDocTipoCarac.nombre; }
            set { CNDocTipoCarac.nombre = value; }
        }
    }
}
