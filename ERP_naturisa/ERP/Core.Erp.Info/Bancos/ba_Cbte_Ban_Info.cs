using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Info.Bancos
{
    public class ba_Cbte_Ban_Info
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cod_Cbtecble { get; set; }
        public int IdPeriodo { get; set; }
        public int IdBanco { get; set; }
        public DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public decimal cb_secuencia { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Cheque { get; set; }
        public string cb_ChequeAux { get; set; }
        public string cb_ChequeImpreso { get; set; }
        public DateTime? cb_FechaCheque { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public DateTime Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion{ get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string cb_ciudadChq { get; set; }
        public string cb_giradoA { get; set; }
        public string Banco { get; set; }
        public string Tipo { get; set; }
        public decimal? IdCbteCble_Anulacion { get; set; }
        public int? IdTipoCbte_Anulacion { get; set; }
        public decimal? IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Por_Anticipo { get; set; }
        public decimal? IdTipoFlujo { get; set; }
        public bool chek { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public string NomTipoNota { get; set; }
        public string PosFechado { get; set; }
        public string _Error { get; set; }
        public int IdSucursal { get; set; }
        public string IdEstado_Cbte_Ban_cat { get; set; }
        public Bitmap btnCons { get; set; }
        public decimal ? IdPersona_Girado_a { get; set; }
        public string ValorEnLetras { get; set; }
        public eEstado_Cheque IdEstado_cheque_cat { get; set; }
        public string ba_descripcion { get; set; }
        public string nom_Estado_Cbte_Ban { get; set; }
        public string CodTipoCbteBan { get; set; }
        public string tc_TipoCbte { get; set; }
        public Boolean Modificado { get; set; }
        public string Estado_Conciliacion { get; set; }
        public eEstado_Preaviso_Cheque IdEstado_Preaviso_ch_cat { get; set; }

        public string Beneficiario { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }

        
        
        public bool Cheked { get; set; }
        public ct_Cbtecble_Info info_Cbtecble { get; set; }

        public ba_Cbte_Ban_Info()
        {
            info_Cbtecble = new ct_Cbtecble_Info();
        }

        public string IdTransaccion { get; set; }
    }
}
