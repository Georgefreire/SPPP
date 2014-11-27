using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNPasantia        
    {
        private static string Ci_Est;

        public static string Ci_Est1
        {
            get { return CNPasantia.Ci_Est; }
            set { CNPasantia.Ci_Est = value; }
        }
      

        private static int codigo;

        public static int Codigo
        {
            get { return CNPasantia.codigo; }
            set { CNPasantia.codigo = value; }
        }
    
       
        private static int codEstud;

        public static int CodEstud
        {
            get { return CNPasantia.codEstud; }
            set { CNPasantia.codEstud = value; }
        }
        private static string fechaIni;

        public static string FechaIni
        {
            get { return CNPasantia.fechaIni; }
            set { CNPasantia.fechaIni = value; }
        }
        private static string fechaFin;

        public static string FechaFin
        {
            get { return CNPasantia.fechaFin; }
            set { CNPasantia.fechaFin = value; }
        }
        private static int total_pas;

        public static int Total_pas
        {
            get { return CNPasantia.total_pas; }
            set { CNPasantia.total_pas = value; }
        }

        private static string fechaapro;

        public static string Fechaapro
        {
            get { return fechaapro; }
            set { fechaapro = value; }
        }


        private static string _Numero_Resolucion;

        public static string Numero_Resolucion
        {
            get { return CNPasantia._Numero_Resolucion; }
            set { CNPasantia._Numero_Resolucion = value; }
        }

       

        
    }
}
