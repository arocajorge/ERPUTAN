using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_tarjeta_parametro_Info
    {
        public int IdEmpresa { get; set; }
        public int IdTarjeta { get; set; }
        public string IdCtaCble_Comision { get; set; }
        public double Porcetaje_Comision { get; set; }
        public string IdCobro_tipo_x_Tarj { get; set; }
        public string IdCobro_tipo_x_RetFu { get; set; }
        public string IdCobro_tipo_x_RetIva { get; set; }
        public string IdCtaCble_Tarj { get; set; }

        public tb_tarjeta_parametro_Info(){ }
   
    }
}
