using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.CuentasxPagar
{
  public  class cp_archivos_para_banco_x_cxp_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public int IdBanco { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Cod_Empresa { get; set; }
        public string Tipo { get; set; }
        public string Nom_Archivo { get; set; }
        public byte[] archivo { get; set; }
        public string estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string observacion { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Motivo_anulacion { get; set; }

        public List <cp_archivos_para_banco_x_cxp_det_Info> cp_archivos_para_banco_x_cxp_det { get; set; }

        public cp_archivos_para_banco_x_cxp_Info()
        {
            this.cp_archivos_para_banco_x_cxp_det = new List<cp_archivos_para_banco_x_cxp_det_Info>();
        }

    }
}
