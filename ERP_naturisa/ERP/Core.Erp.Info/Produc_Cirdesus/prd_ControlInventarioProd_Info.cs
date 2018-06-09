using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Produc_Cirdesus
{
    public class prd_ControlInventarioProd_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string CodObra { get; set; }
        public int IdRegistro { get; set; }
        public int IdEtapa { get; set; }
        public int IdOrdenTrabajo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoMov { get; set; }
        public double Kilos { get; set; }
        public double Unidades { get; set; }
        public string  Observacion { get; set; }


        public prd_ControlInventarioProd_Info() { }




    }
}
