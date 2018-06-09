using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes;

namespace Core.Erp.Reportes.Contabilidad
{
   public  class XCONTA_Rpt006_Data
    {


       public List<XCONTA_Rpt006_Info> Get_Data_Reporte(int IdEmpresa, string IdCtaCble,string IdCentro_Costo,
           DateTime FechaIni, DateTime FechaFin,int IdGrupo_Punto_Cargo,int IdPunto_Cargo,Boolean Mostrar_Asiento_cierre,  ref string MensajeError)
       {
           try
           {
               List<XCONTA_Rpt006_Info> lstRpt = new List<XCONTA_Rpt006_Info>();

               double? Saldo = 0;
               Boolean PrimerRegistro = true;

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               using (EntitiesContabilidadRptGeneral listado = new EntitiesContabilidadRptGeneral())
               {
                   var select = from q in listado.spCONTA_Rpt006(IdEmpresa, IdCtaCble, IdCentro_Costo, FechaIni, FechaFin, IdGrupo_Punto_Cargo, IdPunto_Cargo, Mostrar_Asiento_cierre)
                                select q;

                   foreach (var item in select)
                   {

                       if (PrimerRegistro)
                       {
                           Saldo = (item.SaldoInicial == null) ? 0 : Convert.ToDouble(item.SaldoInicial);
                           PrimerRegistro = false;
                       }

                       XCONTA_Rpt006_Info infoRpt = new XCONTA_Rpt006_Info();
                       infoRpt.IdEmpresa = item.IdEmpresa;
                       infoRpt.IdCbteCble = item.IdCbteCble;
                       infoRpt.CodCbteCble = item.IdCbteCble + "/" + item.IdTipoCbte;

                       infoRpt.IdTipocbte = item.IdTipoCbte;
                       infoRpt.sTipocbte = item.sTipocbte;
                       infoRpt.IdPeriodo = item.IdPeriodo;
                       infoRpt.FechaCbte = item.FechaCbte;
                       infoRpt.IdCtaCble = item.IdCtaCble;
                       infoRpt.nom_cuenta = item.nom_cuenta;
                       infoRpt.Debito = item.Debito;
                       infoRpt.Credito = item.Credito;
                       infoRpt.Concepto = item.Concepto;
                       infoRpt.ruc_empresa = item.ruc_empresa;
                       infoRpt.nom_empresa = item.nom_empresa;
                       infoRpt.SaldoInicial = item.SaldoInicial;
                       infoRpt.SaldoFinal = item.SaldoFinal;
                       infoRpt.nom_grupo_punto_cargo = item.nom_grupo_punto_cargo;
                       infoRpt.nom_punto_cargo = item.nom_punto_cargo;
                       infoRpt.Icono_Cbte_externo = Core.Erp.Reportes.Properties.Resources.comprobante_32x32;
                       infoRpt.IdCentro_Costo = item.IdCentro_Costo;
                       infoRpt.nom_centro_costo = item.nom_centro_costo;
                       infoRpt.pc_clave_corta = item.pc_clave_corta;

                       Saldo = Saldo + ((item.Debito > 0) ? item.Debito : item.Credito * -1);

                       infoRpt.Saldo = Saldo;



                       lstRpt.Add(infoRpt);
                   }

               }

               return lstRpt;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.InnerException.ToString());
           }
       }


       

    }
}
