using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Venta_Activo_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdVtaActivo { get; set; }
        public string Cod_VtaActivo { get; set; }
        public int IdActivoFijo { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Tot_Bajas { get; set; }
        public double Valor_Tot_Mejora { get; set; }
        public double Valor_Depre_Acu { get; set; }
        public double Valor_Neto { get; set; }
        public double Valor_Venta { get; set; }
        public double Valor_Perdi_Gana { get; set; }
        public string NumComprobante { get; set; }
        public string Concepto_Vta { get; set; }
        public DateTime Fecha_Venta { get; set; }
        public string IdUsuario { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public DateTime Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public DateTime Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }

        public string Af_Nombre { get; set; }
        public string Encargado { get; set; }
        public int IdTipoCbte_Rev { get; set; }
        public Af_Venta_Activo_Info()
        {

        }

    }
}
