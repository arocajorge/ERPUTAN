using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Bancos
{
    public class vwba_TransaccionesAConciliar_Info : IEquatable< vwba_TransaccionesAConciliar_Info >
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string  CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string CodTipoCbteBan { get; set; }
        public string Descripcion { get; set; }
        public int IdPeriodo { get; set; }
        public DateTime cb_Fecha { get; set; }
        public DateTime? fechaConciliacion { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Cheque { get; set; }
        public DateTime? cb_FechaCheque { get; set; }
        public string ba_descripcion { get; set; }
        public string dc_Observacion { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public double dc_Valor { get; set; }
        public string Estado { get; set; }
        public string IdEstado_Concil_Cat { get; set; }
        public int SecuenciaCbteCble { get; set; }
        public int secuencia { get; set; }
        public int ecuencia { get; set; }
        public Boolean chk { get; set; }
        public string ReferenciaCbte { get; set; }
        public string TEMP { get; set; }
        public int IdBanco { get; set; }
        //COMPOS DE LOS CONCILIADOS 
        public decimal IdConciliacion { get; set; }
        public int SecuenciaConciliacion { get; set; }
        public string tipo_IngEgr { get; set; }
        public int IdTipoNota { get; set; }
        public string IdCentroCosto { get; set; }
        public string No_Conciliado { get; set; }
        public string nom_IdTipoCbte { get; set; }
        public int SecuenciaRelacionado { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string MotivoAnulacion { get; set; }

        public vwba_TransaccionesAConciliar_Info()
        {
            Orden = 10000;
        }
        public double co_SaldoBanco_anterior { get; set; }
        public string Tipo { get; set; }

        public string IdHASH { get; set; }
        public int  Orden { get; set; }


        public bool Equals(vwba_TransaccionesAConciliar_Info other)
        {
            if (this.dc_Valor != other.dc_Valor) 
            {
                return false;
            }
            if (this.CodTipoCbteBan != other.CodTipoCbteBan) 
            {
                
                return false;
            }

            if (this.CodTipoCbteBan == "CHEQ") 
            {
                if (this.cb_Cheque != other.cb_Cheque) 
                {
                    return false;
                }
            }
       

            return true;
        }

        public string Conciliado { get; set; }
    }
}
