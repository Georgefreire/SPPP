using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public static class CNPracticas
    {

        private static int codigo;

        public static int Codigo
        {
            get { return CNPracticas.codigo; }
            set { CNPracticas.codigo = value; }
        }
        private static int codPasantia;

        public static int CodPasantia
        {
            get { return CNPracticas.codPasantia; }
            set { CNPracticas.codPasantia = value; }
        }
        private static int codEntidad;

        public static int CodEntidad
        {
            get { return CNPracticas.codEntidad; }
            set { CNPracticas.codEntidad = value; }
        }
        private static int cod_resp;

     public static int Cod_resp
        {
           get { return CNPracticas.cod_resp; }
          set { CNPracticas.cod_resp = value; }
        }
        private static int cod_per;

        public static int Cod_per
        {
          get { return CNPracticas.cod_per; }
          set { CNPracticas.cod_per = value; }
        }

        private static string fechaIni;

        public static string FechaIni
        {
            get { return CNPracticas.fechaIni; }
            set { CNPracticas.fechaIni = value; }
        }
        private static string fechaFin;

        public static string FechaFin
        {
            get { return CNPracticas.fechaFin; }
            set { CNPracticas.fechaFin = value; }
        }
        private static int numHoras;

        public static int NumHoras
        {
            get { return CNPracticas.numHoras; }
            set { CNPracticas.numHoras = value; }
        }
        private static string estadoPra;

        public static string EstadoPra
        {
            get { return CNPracticas.estadoPra; }
            set { CNPracticas.estadoPra = value; }
        }




    }
}
