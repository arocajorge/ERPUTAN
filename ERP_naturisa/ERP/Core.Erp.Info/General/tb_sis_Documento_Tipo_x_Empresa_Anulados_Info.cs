using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.General
{
    public class tb_sis_Documento_Tipo_x_Empresa_Anulados_Info
    {

        public int IdEmpresa { get; set; }
        public string codDocumentoTipo { get; set; }
        public decimal IdTipoDocAnu { get; set; }
        public DateTime Fecha { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string Documento { get; set; }
        public string DocumentoFin { get; set; }
        public string Autorizacion { get; set; }
        public int IdMotivoAnu { get; set; }
        public string MotivoAnu { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<DateTime> Fecha_UltMod { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<DateTime> Fecha_UltAnu { get; set; }

        //variables vista
        public string  Serie { get; set; }
        public string Docu_IniFin { get; set; }
        public string nom_DocuTipo { get; set; }
        public string nom_MotivoAnu { get; set; }
       


        public tb_sis_Documento_Tipo_x_Empresa_Anulados_Info(){}
    }
}
