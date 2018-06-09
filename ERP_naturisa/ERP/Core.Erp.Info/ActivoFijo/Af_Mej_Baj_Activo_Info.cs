using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.ActivoFijo
{
    public class Af_Mej_Baj_Activo_Info
    {

        public int IdEmpresa { get; set; }
        public decimal Id_Mejora_Baja_Activo { get; set; }
        public string Id_Tipo { get; set; }
        public int IdActivoFijo { get; set; }
        public decimal IdProveedor { get; set; }
        public string Cod_Mej_Baj_Activo { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Mej_Baj_Activo { get; set; }
        public string Compr_Mej_Baj { get; set; }
        public string DescripcionTecnica { get; set; }
        public string Motivo { get; set; }
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
        public string pr_nombre { get; set; }
        public int IdTipoCbte_Rev { get; set; }

        public Af_Mej_Baj_Activo_Info()
        {
                
        }
    }
}
