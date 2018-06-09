using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Roles
{
    //Parametros Generales
    //Derek Mejía Soria
    //ultima modificacion : 08/01/2014
    public class ro_Config_Rubros_ParametrosGenerales_Info
    {
        public string IdTipoParametro { get; set; }
        public string Descripcion { get; set; }
        public string IdRubro { get; set; }
        public Nullable<int> IdMesPago { get; set; }
        public string Formula { get; set; }
        public double Porcentaje { get; set; }
        public int Orden { get; set; }
        public string ru_tipo { get; set; }

        //Derek 28/12/2013
        public byte[] File { get; set; }

        //haac 10/01/2014
        public Nullable<DateTime> FechaIni { get; set; }
        public Nullable<DateTime> FechaFin { get; set; }


        public ro_Config_Rubros_ParametrosGenerales_Info() { }
    }
}
