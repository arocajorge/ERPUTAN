using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Data.CuentasxPagar
{
   public  class cp_orden_pago_det_Data
    {
       string mensaje = "";
       public int GetSecuencia(int IdEmpresa,decimal IdOrdenPago)
       {
           try
           {
               int Id;
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var select = ECXP.cp_orden_pago_det.Count(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPago == IdOrdenPago);
               if (select == 0)
               {
                   return Id = 1;
               }

               else
               {
                   var select_ = (from t in ECXP.cp_orden_pago_det
                                  where t.IdEmpresa == IdEmpresa && t.IdOrdenPago == IdOrdenPago
                                  select t.Secuencia).Max();
                   Id = Convert.ToInt32(select_.ToString()) + 1;
                   return Id;
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

       public List<cp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
       {
           try
           {
               List<cp_orden_pago_det_Info> lista = new List<cp_orden_pago_det_Info>();

                   using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                   {
                       var consulta = from T in Context.cp_orden_pago_det
                                      where T.IdEmpresa == IdEmpresa && T.IdOrdenPago == IdOrdenPago
                                      
                                      select T;
                       foreach (var item in consulta)
                       {

                           cp_orden_pago_det_Info Deta = new cp_orden_pago_det_Info();

                       Deta.IdEmpresa = item.IdEmpresa;
                       Deta.IdOrdenPago = item.IdOrdenPago;
                       Deta.Secuencia = item.Secuencia;

                       Deta.IdEmpresa_cxp = item.IdEmpresa;
                       Deta.IdCbteCble_cxp = item.IdCbteCble_cxp ;
                       Deta.IdTipoCbte_cxp = item.IdTipoCbte_cxp ;
                       Deta.Idbanco = item.IdBanco ;
                       Deta.Valor_a_pagar = item.Valor_a_pagar;
                       Deta.Referencia = item.Referencia;
                       Deta.IdFormaPago = item.IdFormaPago;
                       Deta.Fecha_Pago = item.Fecha_Pago;
                       Deta.IdEstadoAprobacion = item.IdEstadoAprobacion;

                       lista.Add(Deta);
                   
                   }
               }
                   return lista;
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

       public List<cp_orden_pago_det_Info> Get_List_OrdenPagoDetalle(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
       {
           try
           {
               List<cp_orden_pago_det_Info> lista = new List<cp_orden_pago_det_Info>();

               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                   var consulta = from T in Context.cp_orden_pago_det
                                  where T.IdEmpresa_cxp == IdEmpresa_Ogiro 
                                  && T.IdCbteCble_cxp == IdCbteCble_Ogiro 
                                  && T.IdTipoCbte_cxp == IdTipoCbte_Ogiro

                                  select T;
                   foreach (var item in consulta)
                   {

                       cp_orden_pago_det_Info Deta = new cp_orden_pago_det_Info();

                       Deta.IdEmpresa = item.IdEmpresa;
                       Deta.IdOrdenPago = item.IdOrdenPago;
                       Deta.Secuencia = item.Secuencia;

                       Deta.IdEmpresa_cxp = item.IdEmpresa;
                       Deta.IdCbteCble_cxp = item.IdCbteCble_cxp;
                       Deta.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                       Deta.Idbanco = item.IdBanco;
                       Deta.Valor_a_pagar = item.Valor_a_pagar;
                       Deta.Referencia = item.Referencia;
                       Deta.IdFormaPago = item.IdFormaPago;
                       Deta.Fecha_Pago = item.Fecha_Pago;
                       Deta.IdEstadoAprobacion = item.IdEstadoAprobacion;

                       lista.Add(Deta);

                   }
               }
               return lista;
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
 
       public Boolean GuardarDB(List<cp_orden_pago_det_Info> Lst, ref decimal Id, ref string mensaje)
       {
           try
           {            
               foreach (var Item in Lst)
               {
                   using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
                   {
                       cp_orden_pago_det Deta = new cp_orden_pago_det();
                    
                       Deta.IdEmpresa = Item.IdEmpresa;
                       Deta.IdOrdenPago = Id;
                       Deta.Secuencia = Item.Secuencia = GetSecuencia(Item.IdEmpresa, Convert.ToDecimal(Deta.IdOrdenPago));
                       Item.Secuencia = Deta.Secuencia;
                       Deta.IdEmpresa_cxp = Item.IdEmpresa;
                       Deta.IdCbteCble_cxp = Item.IdCbteCble_cxp == 0 ? null : Item.IdCbteCble_cxp;
                       Deta.IdTipoCbte_cxp = Item.IdTipoCbte_cxp == 0 ? null : Item.IdTipoCbte_cxp;
                       Deta.IdBanco = Item.Idbanco == 0 ? null : Item.Idbanco;
                       Deta.Valor_a_pagar = Item.Valor_a_pagar;
                       Deta.Referencia = Item.Referencia;
                       Deta.IdFormaPago = Item.IdFormaPago;
                       Deta.Fecha_Pago = Item.Fecha_Pago;
                       Deta.IdEstadoAprobacion = Item.IdEstadoAprobacion;
                       Context.cp_orden_pago_det.Add(Deta);
                       Context.SaveChanges();
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

       public Boolean ModificarDB(cp_orden_pago_det_Info Info)
       {
           try
           {
               EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
               var address = context.cp_orden_pago_det.FirstOrDefault(var => var.IdOrdenPago == Info.IdOrdenPago && var.IdEmpresa == Info.IdEmpresa && var.Secuencia==Info.Secuencia);
               if (address != null)
               {
                   address.IdFormaPago = Info.IdFormaPago;
                   address.Fecha_Pago = Info.Fecha_Pago;
                   address.IdEstadoAprobacion = Info.IdEstadoAprobacion;
                   address.IdUsuario_Aprobacion = Info.IdUsuario_Aproba;
                   address.fecha_hora_Aproba = Info.fecha_hora_Aproba;
                   address.Motivo_aproba = "";

                   context.SaveChanges();

                   cp_orden_pago_Data data = new cp_orden_pago_Data();
                   data.ModificarDB(Info.IdEmpresa,Convert.ToInt32( Info.IdOrdenPago),"APRO");

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

       public Boolean ModificarDB_Valor_a_Pagar(cp_orden_pago_det_Info Info)
       {
           try
           {
               EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
               var address = context.cp_orden_pago_det.FirstOrDefault(var => var.IdOrdenPago == Info.IdOrdenPago && var.IdEmpresa == Info.IdEmpresa && var.Secuencia == Info.Secuencia);
               if (address != null)
               {
                   address.Valor_a_pagar = Info.Valor_a_pagar;
                   context.SaveChanges();
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

       public Boolean ModificarDB_Forma_Pago(List<cp_orden_pago_det_Info> Info_Detalle)
       {
           try
           {
               foreach (var item in Info_Detalle)
               {
                   EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
                   var address = context.cp_orden_pago_det.FirstOrDefault(var => var.IdOrdenPago == item.IdOrdenPago && var.IdEmpresa == item.IdEmpresa && var.Secuencia == item.Secuencia);
                   if (address != null)
                   {
                       address.IdFormaPago = item.IdFormaPago;
                       address.Fecha_Pago = item.Fecha_Pago;
                       address.IdBanco = item.Idbanco == 0 ? null : item.Idbanco;
                       context.SaveChanges();
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

       public Boolean ModificarDB(int IdEmpresa,decimal IdOrdenPago,int secuencia)
       {
           try
           {
               EntitiesCuentasxPagar context = new EntitiesCuentasxPagar();
               var address = context.cp_orden_pago_det.FirstOrDefault(var => var.IdOrdenPago == IdOrdenPago && var.IdEmpresa == IdEmpresa && var.Secuencia == secuencia);
               if (address != null)
               {
                   address.IdEmpresa_cxp = null;
                   address.IdCbteCble_cxp = null;
                   address.IdTipoCbte_cxp = null;
                   context.SaveChanges();

                   //Si la op tiene cuotas y es anulada entonces la cuota queda libre nuevamente
                   var Entity = context.cp_cuotas_x_doc_det.FirstOrDefault(q => q.IdEmpresa_op == IdEmpresa && q.IdOrdenPago == IdOrdenPago && q.Secuencia_op == secuencia);
                   if (Entity!=null)
                   {
                       Entity.IdEmpresa_op = null;
                       Entity.IdOrdenPago = null;
                       Entity.Secuencia_op = null;
                       Entity.Estado = false;
                       context.SaveChanges();
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

       public Boolean ModificarDB(cp_orden_pago_det_Info Info, ref decimal Id, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
               {             
                   cp_orden_pago_det ordenPagoDet = Entity.cp_orden_pago_det.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdOrdenPago == Info.IdOrdenPago);
                   if (ordenPagoDet != null)
                   {
                       ordenPagoDet.IdEmpresa_cxp = Info.IdEmpresa_cxp;
                       ordenPagoDet.IdTipoCbte_cxp = Info.IdTipoCbte_cxp;
                       ordenPagoDet.IdCbteCble_cxp = Info.IdCbteCble_cxp;
                       //ordenPagoDet.Valor_a_pagar = Info.Valor_a_pagar;
                       Entity.SaveChanges();
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

       public cp_orden_pago_det_Info Get_Info_orden_pago(int IdEmpresa,decimal IdOrdenPago)
       {
           try
           {
               List<cp_orden_pago_Info> lM = new List<cp_orden_pago_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var Orden_Pago = from selec in ECXP.cp_orden_pago_det
                                where selec.IdEmpresa == IdEmpresa && selec.IdOrdenPago == IdOrdenPago


                                select selec;
               cp_orden_pago_det_Info info = new cp_orden_pago_det_Info();

               foreach (var item in Orden_Pago)
               {
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdOrdenPago = item.IdOrdenPago;
                   info.IdEmpresa_cxp = Convert.ToInt32(item.IdEmpresa_cxp);
                   info.IdCbteCble_cxp = Convert.ToDecimal(item.IdCbteCble_cxp);
                   info.IdTipoCbte_cxp = Convert.ToInt32(item.IdTipoCbte_cxp);
               }             
               return (info);
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

       public List<cp_orden_pago_det_Info> Get_list_orden_pago_con_cta_acreedora(int IdEmpresa, List<decimal> list_op)
       {
           try
           {
               List<cp_orden_pago_det_Info> Lista = new List<cp_orden_pago_det_Info>();

               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {

                   Context.SetCommandTimeOut(5000);
                   foreach (var item_op in list_op)
                   {
                       var lst = from q in Context.vwcp_orden_pago_det_con_cta_acreedora
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdOrdenPago == item_op
                                 select q;

                       foreach (var item in lst)
                       {
                           cp_orden_pago_det_Info info = new cp_orden_pago_det_Info();

                           info.IdEmpresa = item.IdEmpresa;
                           info.IdOrdenPago = item.IdOrdenPago == null ? 0 : Convert.ToDecimal(item.IdOrdenPago);
                           info.Secuencia = item.Secuencia == null ? 0 : Convert.ToInt32(item.Secuencia);
                           info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                           info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                           info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                           info.Valor_a_pagar = item.Valor_a_pagar;
                           info.Referencia = item.Referencia;
                           info.IdFormaPago = item.IdFormaPago;
                           info.Fecha_Pago = item.Fecha_Pago == null ? DateTime.Now.Date : Convert.ToDateTime(item.Fecha_Pago);
                           info.pr_nombre = item.Nombre;
                           info.IdCtaCble_Acreedora = item.IdCtaCble_Acreedora;
                           info.Observacion = item.Observacion;
                           info.IdTipo_op = item.IdTipo_op;
                           info.IdTipo_Persona = item.IdTipo_Persona;
                           info.IdPersona = item.IdPersona;
                           info.IdEntidad = item.IdEntidad == null ? 0 : Convert.ToDecimal(item.IdEntidad);

                           Lista.Add(info);
                       }
                   }
                   
               }

               return Lista;
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

       public List<cp_orden_pago_det_Info> Get_info_orden_pago_con_cta_acreedora(int IdEmpresa, decimal IdOrdenPago)
       {
           try
           {
               List<cp_orden_pago_det_Info> Lista = new List<cp_orden_pago_det_Info>();

               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {

                   Context.SetCommandTimeOut(5000);

                   var lst = from q in Context.vwcp_orden_pago_det_con_cta_acreedora
                             where q.IdEmpresa == IdEmpresa
                             && q.IdOrdenPago == IdOrdenPago
                             select q;

                   foreach (var item in lst)
                   {
                       cp_orden_pago_det_Info info = new cp_orden_pago_det_Info();

                       info.IdEmpresa = item.IdEmpresa;
                       info.IdOrdenPago = item.IdOrdenPago == null ? 0 : Convert.ToDecimal(item.IdOrdenPago);
                       info.Secuencia = item.Secuencia == null ? 0 : Convert.ToInt32(item.Secuencia);
                       info.IdEmpresa_cxp = item.IdEmpresa_cxp;
                       info.IdCbteCble_cxp = item.IdCbteCble_cxp;
                       info.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                       info.Valor_a_pagar = item.Valor_a_pagar;
                       info.Referencia = item.Referencia;
                       info.IdFormaPago = item.IdFormaPago;
                       info.Fecha_Pago = item.Fecha_Pago == null ? DateTime.Now.Date : Convert.ToDateTime(item.Fecha_Pago);
                       info.pr_nombre = item.Nombre;
                       info.IdCtaCble_Acreedora = item.IdCtaCble_Acreedora;
                       info.Observacion = item.Observacion;
                       info.IdTipo_op = item.IdTipo_op;
                       info.IdTipo_Persona = item.IdTipo_Persona;
                       info.IdPersona = item.IdPersona;
                       info.IdEntidad = item.IdEntidad == null ? 0 : Convert.ToDecimal(item.IdEntidad);

                       Lista.Add(info);
                   }
               }

               return Lista;
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
