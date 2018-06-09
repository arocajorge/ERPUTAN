using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Caja
{
    public class vwcaj_MovCaja_x_Cobro_Anticipo_Info
    {

        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public int IdCaja { get; set; }
        public string IdCtaCble_TipoCobro { get; set; }
        public string IdCtaCble_ban { get; set; }
        public decimal IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public double dc_ValorPago { get; set; }
        public string Documento_Cobrado { get; set; }
        public string nCliente { get; set; }
        public string nSucursal { get; set; }
        public int IdPeriodo_Caja { get; set; }
        public DateTime  cr_fecha { get; set; }
        public string cr_NumDocumento { get; set; }
        public DateTime cr_fechaDocu { get; set; }
        public double cr_TotalCobro { get; set; }
        public double cm_valor { get; set; }
        public vwcaj_MovCaja_x_Cobro_Anticipo_Info()
        {

        }

    }
}
