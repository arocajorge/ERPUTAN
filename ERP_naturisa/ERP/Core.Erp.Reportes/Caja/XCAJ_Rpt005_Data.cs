using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Caja
{
   public class XCAJ_Rpt005_Data
   {
       public List<XCAJ_Rpt005_Info> Get_List(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_Fin)
       {
           try
           {
             
               List<XCAJ_Rpt005_Info> Lista = new List<XCAJ_Rpt005_Info>();
               /*
               using (EntitiesCaja_General Context = new EntitiesCaja_General())
               {
                   var contact = from c in Context.vwCAJ_Rpt005
                                 where c.IdEmpresa == IdEmpresa
                                 && c.cm_fecha>=Fecha_Inicio
                                 &&c.cm_fecha<=Fecha_Fin
                                 select c;
                   foreach (var item in contact)
                   {
                       XCAJ_Rpt005_Info info = new XCAJ_Rpt005_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.em_nombre = item.em_nombre;
                       info.IdSucursal = item.IdSucursal;
                       info.Su_Descripcion = item.Su_Descripcion;
                       info.IdCaja = item.IdCaja;
                       info.ca_Descripcion = item.ca_Descripcion;
                       info.IdTipoMovi = item.IdTipoMovi;
                       info.tm_descripcion = item.tm_descripcion;
                       info.cm_fecha = item.cm_fecha;
                       info.IdUsuario = item.IdUsuario;
                       info.IdCobro_tipo = item.IdCobro_tipo;
                       info.tc_descripcion = item.tc_descripcion;
                       info.IdCbteCble = item.IdCbteCble;
                       info.IdTipocbte = item.IdTipocbte;
                       info.cr_Banco = item.cr_Banco;
                       info.cr_cuenta = item.cr_cuenta;
                       info.cr_NumDocumento = item.cr_NumDocumento;
                       info.cr_Valor = item.cr_Valor;
                       info.cm_Signo = item.cm_Signo;
                       if (item.cm_Signo == "-")
                           info.Ingreso_Egreso = "EGRESOS";
                       else
                           info.Ingreso_Egreso = "INGRESOS";


                       Lista.Add(info);
                   }
               }
                * */
               return Lista;
           }
           catch (Exception ex)
           {

               string MensajeError = "";
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt005_Data) };
           }
       }
       public List<XCAJ_Rpt005_Info> Get_List(int IdEmpresa,int iDcAJA, DateTime Fecha_Inicio, DateTime Fecha_Fin)
       {
           try
           {
               List<XCAJ_Rpt005_Info> Lista = new List<XCAJ_Rpt005_Info>();
               /*
               using (EntitiesCaja_General Context = new EntitiesCaja_General())
               {
                   var contact = from c in Context.vwCAJ_Rpt005
                                 where c.IdEmpresa == IdEmpresa
                                 &&c.IdCaja==iDcAJA
                                 && c.cm_fecha >= Fecha_Inicio
                                 && c.cm_fecha <= Fecha_Fin
                                 select c;
                   foreach (var item in contact)
                   {
                       XCAJ_Rpt005_Info info = new XCAJ_Rpt005_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.em_nombre = item.em_nombre;
                       info.IdSucursal = item.IdSucursal;
                       info.Su_Descripcion = item.Su_Descripcion;
                       info.IdCaja = item.IdCaja;
                       info.ca_Descripcion = item.ca_Descripcion;
                       info.IdTipoMovi = item.IdTipoMovi;
                       info.tm_descripcion = item.tm_descripcion;
                       info.cm_fecha = item.cm_fecha;
                       info.IdUsuario = item.IdUsuario;
                       info.IdCobro_tipo = item.IdCobro_tipo;
                       info.tc_descripcion = item.tc_descripcion;
                       info.IdCbteCble = item.IdCbteCble;
                       info.IdTipocbte = item.IdTipocbte;
                       info.cr_Banco = item.cr_Banco;
                       info.cr_cuenta = item.cr_cuenta;
                       info.cr_NumDocumento = item.cr_NumDocumento;
                       info.cr_Valor = item.cr_Valor;
                       info.cm_Signo = item.cm_Signo;
                       if (item.cm_Signo == "-")
                           info.Ingreso_Egreso = "EGRESOS";
                       else
                           info.Ingreso_Egreso = "INGRESOS";


                       Lista.Add(info);
                   }
               }*/
               return Lista;
           }
           catch (Exception ex)
           {

               string MensajeError = "";
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt005_Data) };
           }
       }
  
    }
}
