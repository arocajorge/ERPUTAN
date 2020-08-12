using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Drawing;

namespace Core.Erp.Info.CuentasxPagar
{
    public class cp_reembolso_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public decimal IdReembolso { get; set; }
        public string TipoIdProveedor { get; set; }
        public string IdentificacionProveedor { get; set; }
        public string TipoDoc_CodSRI { get; set; }
        public string Establecimiento { get; set; }
        public string Punto_Emision { get; set; }
        public string Secuencial { get; set; }
        public string Autorizacion { get; set; }
        public System.DateTime Fecha_Emision { get; set; }
        public double TarifaIVAcero { get; set; }
        public double TarifaIVADiferentecero { get; set; }
        public double TarifaNoObjetoIVA { get; set; }
        public double TarifaExcentaDeIVA { get; set; }
        public double TotalBaseImponible { get; set; }
        public double MontoICE { get; set; }
        public double MontoIVA { get; set; }

        public string CodigoTipoIdentificacion { get; set; }
    }
}
