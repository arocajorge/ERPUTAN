using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
   public  class vwcp_Cbte_x_pagar_OG_Data
   {
       string mensaje = "";
       public List<vwcp_Cbte_x_pagar_OG_Info> Get_List_Cbte_x_pagar_OG(int IdEmpresa, decimal IdProveedor,string TipoReg)
       {
           try
           {
               List<vwcp_Cbte_x_pagar_OG_Info> lM = new List<vwcp_Cbte_x_pagar_OG_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var Cbte_x_pagar_OG = from selec in ECXP.vwcp_Cbte_x_pagar_OG
                               where selec.IdEmpresa == IdEmpresa && selec.IdProveedor == IdProveedor && selec.SaldoPendiente>0
                               && selec.TipoReg == TipoReg

                               select selec;

               foreach (var item in Cbte_x_pagar_OG)
               {
                   vwcp_Cbte_x_pagar_OG_Info info = new vwcp_Cbte_x_pagar_OG_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.em_nombre = item.em_nombre;
                   info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                   info.IdProveedor = item.IdProveedor;
                   info.NomProveedor = item.NomProveedor;
                   info.co_fechaOg = item.co_fechaOg;
                   info.co_factura = item.co_factura;
                   info.co_observacion = item.co_observacion;
                   info.co_serie = item.co_serie;
                   info.co_total = Convert.ToDouble(item.co_total);
                   info.co_Valorpagar = Convert.ToDouble(item.co_valorpagar);
                //   info.Valor_Respaldado = item.Valor_Respaldado;
                   info.Valor_Respaldado = 0;
                   info.SaldoPendiente = Convert.ToDouble(item.SaldoPendiente);

                   info.SaldoAUX = Convert.ToDouble(item.SaldoPendiente);
                 //  info.check = false;
      
                   info.TipoReg = item.TipoReg;
                   info.Descripcion = item.Descripcion;
                   info.CodTipoDocumento = item.CodTipoDocumento;
                   info.Referencia = item.Referencia;

                   info.Total_Retencion = item.Total_Retencion;
              
                   lM.Add(info);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public List<vwcp_Cbte_x_pagar_OG_Info> Get_List_Cbte_x_pagar_OG(int IdEmpresa, decimal IdOrdenPago)
       {
           try
           {
               List<vwcp_Cbte_x_pagar_OG_Info> lM = new List<vwcp_Cbte_x_pagar_OG_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               
                   var Cbte_x_pagar_OG = from selec in ECXP.vwcp_orden_pago_det
                                         where selec.IdEmpresa == IdEmpresa && selec.IdOrdenPago == IdOrdenPago


                                         select selec;

                   foreach (var item in Cbte_x_pagar_OG)
                   {
                       vwcp_Cbte_x_pagar_OG_Info info = new vwcp_Cbte_x_pagar_OG_Info();
                       info.IdEmpresa = IdEmpresa;
                       info.IdOrdenPago = IdOrdenPago;
                       info.Observacion = item.Observacion;
                       info.IdTipo_op = item.IdTipo_op;
                       info.IdTipo_Persona = item.IdTipo_Persona;
                       info.IdPersona = item.IdPersona;
                       info.Fecha = item.Fecha;
                       info.Estado = Convert.ToChar(item.Estado);
                       info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       info.Secuencia = item.Secuencia;
                     //  info.referencia = item.referencia;
                       info.Referencia = item.referencia;
                       info.Total_a_Pagar = Convert.ToDouble(item.Total_a_Pagar);
                       info.Total_a_pagar_OP = item.Total_a_pagar_OP;

                       info.Valor_Respaldado = Convert.ToDouble(item.Total_a_Pagar);

                       info.IdCbteCble_Ogiro = Convert.ToDecimal(item.IdCbteCble_cxp);
                       info.IdTipoCbte_Ogiro = Convert.ToInt32(item.IdTipoCbte_cxp);

                      // info.SaldoPendiente = Convert.ToDouble(item.SaldoPendiente);

                       //prueba
                       //info.SaldoAUX = Convert.ToDouble(item.SaldoPendiente);
                       //info.TipoReg = item.IdTipo_op;
                       //info.co_fechaOg = item.Fecha;
                       //info.co_total = Convert.ToDouble(item.Total_a_Pagar);
                       //info.Valor_Respaldado = item.Total_a_pagar_OP;
                       //info.Referencia = item.Referencia_op_det;
                       lM.Add(info);
                   }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
