using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_orden_pago_formapago_Data
    {
       string mensaje = "";
       public List<cp_orden_pago_formapago_Info> Get_List_orden_pago_formapago()
       {
           try
           {
               List<cp_orden_pago_formapago_Info> lM = new List<cp_orden_pago_formapago_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var FormaPago = from selec in ECXP.cp_orden_pago_formapago
                                  
                                   select selec;

               foreach (var item in FormaPago)
               {
                   cp_orden_pago_formapago_Info info = new cp_orden_pago_formapago_Info();
                   info.IdFormaPago = item.IdFormaPago;
                   info.descripcion = item.descripcion;
                   info.IdTipoTransaccion= item.IdTipoTransaccion;
                   info.CodModulo = item.CodModulo;
                   info.IdTipoMovi_caj = item.IdTipoMovi_caj;

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
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ValidarCodigoExiste(string Cod)
       {
           try
           {
               EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();

               var Existe = from q in context.cp_orden_pago_formapago
                            where q.IdFormaPago == Cod
                            select q;
               if (Existe.ToList().Count() > 0)
               {
                   return true;
               }
               else
               {
                   return false;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(List<cp_orden_pago_formapago_Info> lst)
       {
           try
           {
               foreach (cp_orden_pago_formapago_Info item in lst)
               {
                   if (ValidarCodigoExiste(item.IdFormaPago))
                   {
                       ModificarDB(item);
                   }
                   else
                   {
                      GuardarDB(item);
                   }
               }
               return true;

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }    

       public Boolean GuardarDB(cp_orden_pago_formapago_Info Info)
       {
           try
           {
                EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

                var FormaPago = new cp_orden_pago_formapago();

                FormaPago.IdFormaPago = Info.IdFormaPago;
                FormaPago.descripcion = Info.descripcion;
                FormaPago.IdTipoTransaccion = Info.IdTipoTransaccion;
                FormaPago.CodModulo = Info.CodModulo;
                FormaPago.IdTipoMovi_caj = Info.IdTipoMovi_caj;
                ECXP.cp_orden_pago_formapago.Add(FormaPago);
                ECXP.SaveChanges();
                return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(cp_orden_pago_formapago_Info Info)
       {
           try
           {
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var FormaPago = ECXP.cp_orden_pago_formapago.FirstOrDefault(var => var.IdFormaPago == Info.IdFormaPago);
               if (FormaPago != null)
               {
                   FormaPago.descripcion = Info.descripcion;
                   FormaPago.IdTipoTransaccion = Info.IdTipoTransaccion;
                   FormaPago.CodModulo = Info.CodModulo;
                   FormaPago.IdTipoMovi_caj = Info.IdTipoMovi_caj;
                   ECXP.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
    }
}
