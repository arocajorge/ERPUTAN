using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;

namespace Core.Erp.Info.Bancos
{
    public class ba_Conciliacion_Info
    {
        public	int IdEmpresa { get; set; }
        public	decimal IdConciliacion { get; set; }
        public	int IdBanco { get; set; }

        public string ba_descripcion { get; set; }
        public string IdCtaCble { get; set; }
        public string Periodo { get; set; }
        public string Estado_Conciliacion { get; set; }
        public	int IdPeriodo { get; set; }
        public	DateTime co_Fecha { get; set; }
        public	double co_SaldoContable_MesAnt { get; set; }
        public	double co_totalIng { get; set; }
        public	double co_totalEgr { get; set; }
        public	double co_SaldoContable_MesAct { get; set; }
        public	double co_SaldoBanco_EstCta { get; set; }
        public	int co_Cant_Cheque { get; set; }
        public int co_Cant_Deposito { get; set; }
        public int co_Cant_NC { get; set; }
        public int co_Cant_ND { get; set; }
        public int?  co_Cant_OtrosIng { get; set; }
        public int? co_Cant_OtrosEgr { get; set; }
        public	double co_TotalCheque { get; set; }
        public	double co_TotalDepositos { get; set; }
        public	double co_totalNC { get; set; }
        public	double co_TotalND { get; set; }
        public double? co_TotalOtrosIng { get; set; }
        public double? co_TotalOtrosEgr { get; set; }
        public	string Estado{ get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public string co_Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string MotivoAnulacion { get; set; }

        public DateTime? Fecha_Transac { get; set; }
        public DateTime? Fecha_UltMod { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public double co_SaldoBanco_anterior { get; set; }

        public List<vwba_TransaccionesAConciliar_Info> LstConciliadas { get; set; }

        //PARA EL REPORTE
        public tb_Empresa_Info Empresa { get; set; }
        public List<vwba_TransaccionesAConciliar_Info> LstConciliadaRPT { get; set; }
        public List<vwba_TransaccionesAConciliar_Info> LstNoConciliadaRPT { get; set; }

        public string No_Conciliado { get; set; }
        public string CodTipoCbteBan { get; set; }

        public ba_Conciliacion_Info()
        {
            LstConciliadas = new List<vwba_TransaccionesAConciliar_Info>();

            LstNoConciliadaRPT = new List<vwba_TransaccionesAConciliar_Info>();
        }
    }
}
