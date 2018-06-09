using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_orden_pago_Data
    {

       string mensaje = "";
       cp_orden_pago_det_Data odataDet = new cp_orden_pago_det_Data();

       public decimal GetIdOrdenPago(int IdEmpresa)
       {
           try
           {
               decimal Id;
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var select = ECXP.cp_orden_pago.Count(q => q.IdEmpresa == IdEmpresa);
               if (select == 0)
               {
                   return Id = 1;
               }

               else
               {
                   var select_ = (from t in ECXP.cp_orden_pago
                                  where t.IdEmpresa == IdEmpresa
                                  select t.IdOrdenPago).Max();
                   Id = Convert.ToDecimal(select_.ToString()) + 1;
                   return Id;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GuardaDB(cp_orden_pago_Info Item, ref decimal Id, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                  cp_orden_pago Cabe = new cp_orden_pago();
                  Cabe.IdEmpresa = Item.IdEmpresa;
                  Cabe.IdOrdenPago = Id = GetIdOrdenPago(Item.IdEmpresa);
                  Item.IdOrdenPago = Id;
                   Cabe.Observacion = Item.Observacion;
                   Cabe.IdTipo_op = Item.IdTipo_op;
                   Cabe.Fecha = Convert.ToDateTime(Item.Fecha.ToShortDateString());
                   Cabe.IdFormaPago = Item.IdFormaPago;
                   Cabe.Fecha_Pago = Convert.ToDateTime(Item.Fecha_Pago.ToShortDateString());
                   Cabe.IdBanco = Item.IdBanco == 0 ? null : Item.IdBanco;
                   Cabe.IdEstadoAprobacion = Item.IdEstadoAprobacion;
                   Cabe.Estado = "A";
                   Cabe.IdPersona = Item.IdPersona;
                   Cabe.IdTipo_Persona = Convert.ToString(Item.IdTipo_Persona);
                   Cabe.IdEntidad = Item.IdEntidad;
                   Cabe.IdUsuario = Item.IdUsuario == null ? "" : Item.IdUsuario;
                   Cabe.nom_pc = Item.nom_pc;
                   Cabe.ip = Item.ip;
                   Cabe.IdTipoFlujo = Item.IdTipoFlujo;
                   Cabe.Fecha_Transac = DateTime.Now;


                   Context.cp_orden_pago.Add(Cabe);
                   Context.SaveChanges();
                                                                                
                   if (Item.Detalle != null)
                   {
                       decimal detalle = Id;
                       string msg = "";
                       odataDet.GuardarDB(Item.Detalle, ref detalle, ref msg);
                   }
               }
               return true;
           }
           catch (Exception ex)
           {             
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(cp_orden_pago_Info Info, ref string msg)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   var contact = context.cp_orden_pago.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa && obj.IdOrdenPago == Info.IdOrdenPago);
                   if (contact != null)
                   {
                       contact.Fecha = Info.Fecha;
                       contact.IdFormaPago = Info.IdFormaPago;
                       contact.Fecha_Pago = Info.Fecha_Pago;
                       contact.Observacion = Info.Observacion;
                       contact.IdBanco = Info.IdBanco == 0 ? null : Info.IdBanco;
                       contact.IdTipoFlujo = Info.IdTipoFlujo;
                       contact.IdTipo_op = Info.IdTipo_op;
                       context.SaveChanges();

                       if (Info.Detalle != null)
                       {
                           foreach (var item in Info.Detalle)
                           {
                               odataDet.ModificarDB_Valor_a_Pagar(item);
                           }
                       }
                   }        
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean AnularDB(cp_orden_pago_Info Info)
       {
           try
           {
               using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
               {
                   cp_orden_pago cab_Ordpag = Entity.cp_orden_pago.FirstOrDefault(v => v.IdEmpresa == Info.IdEmpresa && v.IdOrdenPago == Info.IdOrdenPago);
                   if (cab_Ordpag != null)
                   {
                       cab_Ordpag.Observacion = Info.Observacion;
                       cab_Ordpag.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                       cab_Ordpag.Fecha_UltAnu = Info.Fecha_UltAnu;
                       cab_Ordpag.MotivoAnu = Info.MotiAnula;
                       cab_Ordpag.Estado = "I";
                       Entity.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public bool Eliminar_OrdenPago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                   Context.Database.ExecuteSqlCommand("delete cp_orden_pago_det where IdEmpresa = " + IdEmpresa + " and IdOrdenPago = " + IdOrdenPago);
                   
                   Context.Database.ExecuteSqlCommand("delete cp_orden_pago where IdEmpresa = " + IdEmpresa + " and IdOrdenPago = " + IdOrdenPago );
               }

               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public cp_orden_pago_Info Get_Info_orden_pago(int IdEmpresa, decimal IdOrdenPago, ref string mensaje)
       {
           try
           {
               cp_orden_pago_Info info = new cp_orden_pago_Info();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();
               var Orden_Pago = from selec in ECXP.cp_orden_pago
                                where selec.IdEmpresa == IdEmpresa
                                       && selec.IdOrdenPago == IdOrdenPago
                                select selec;

               foreach (var item in Orden_Pago)
               {


                   info.IdEmpresa = item.IdEmpresa;
                   info.IdOrdenPago = item.IdOrdenPago;

                   info.Observacion = item.Observacion;
                   info.IdTipo_op = item.IdTipo_op;

                   info.Fecha = item.Fecha;
                   info.IdFormaPago = item.IdFormaPago;
                   info.Fecha_Pago = item.Fecha_Pago;
                   info.IdBanco = item.IdBanco;
                   info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                   info.Estado = item.Estado;
                   info.IdPersona = item.IdPersona;
                   info.IdTipo_Persona = item.IdTipo_Persona;
                   info.IdEntidad = Convert.ToDecimal(item.IdEntidad);
                   info.IdUsuario = item.IdUsuario;
                   info.nom_pc = item.nom_pc;
                   info.ip = item.ip;

                   info.IdTipoFlujo = item.IdTipoFlujo;

                   
               }
               return (info);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<cp_orden_pago_Info> Get_List_orden_pago(int IdEmpresa,DateTime FechaIni, DateTime FechaFin,ref string mensaje)
       {
           try
           {

               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());

               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());


               List<cp_orden_pago_Info> lM = new List<cp_orden_pago_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var Orden_Pago = from selec in ECXP.vwcp_orden_pago
                                     where selec.IdEmpresa == IdEmpresa
                                            && selec.Fecha >= FechaIni && selec.Fecha <= FechaFin
                                     select selec;

               foreach (var item in Orden_Pago)
               {
                   
                   cp_orden_pago_Info info = new cp_orden_pago_Info();
                   info.IdEmpresa=item.IdEmpresa;         
                   info.IdOrdenPago=item.IdOrdenPago;
                   info.Observacion = item.Observacion;
                   info.IdTipo_op = item.IdTipo_op;
                   info.IdEntidad = Convert.ToDecimal (item.IdEntidad);
                   info.Fecha = item.Fecha;
                   info.IdEstadoAprobacion = item.IdEstadoAprobacion;
                   info.IdFormaPago = item.IdFormaPago;
                   info.Fecha_Pago = item.Fecha_Pago;
                   info.IdBanco = Convert.ToInt32(item.IdBanco);
                   info.Estado = item.Estado;
                   info.IdPersona = item.IdPersona;
                   info.IdTipo_Persona = item.IdTipo_Persona;
                   info.pe_nombreCompleto = item.pe_nombreCompleto;
                   info.Total_OP = Convert.ToDecimal(item.Total_OP);
                   info.Total_cancelado = Convert.ToDecimal(item.Total_cancelado);
                   info.Saldo = Convert.ToDecimal(item.Saldo);
                   info.IdTipoFlujo = item.IdTipoFlujo;
                   
                   info.EstadoCancelacion = item.EstadoCancelacion;
                   info.Descripcion = item.Descripcion;
                   lM.Add(info);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List<vwcp_Anticipos_x_NotaCred_Saldo_Info> Get_List_Orden_Pago_Anticipos_con_Saldos_Pagados(int IdEmpresa, decimal IdProveedor, ref string mensaje)
       {
           try
           {

               List<vwcp_Anticipos_x_NotaCred_Saldo_Info> lM = new List<vwcp_Anticipos_x_NotaCred_Saldo_Info>();
               EntitiesCuentasxPagar ECXP = new EntitiesCuentasxPagar();

               var Orden_Pago = from selec in ECXP.vwcp_Anticipos_x_NotaCred_Saldo
                                where selec.IdEmpresa == IdEmpresa
                                       && selec.IdEntidad == IdProveedor
                                       && selec.valor_saldo_cbte >0.004
                                select selec;

               foreach (var item in Orden_Pago)
               {
                   vwcp_Anticipos_x_NotaCred_Saldo_Info info = new vwcp_Anticipos_x_NotaCred_Saldo_Info();

                   info.IdEmpresa = item.IdEmpresa;
                   info.IdCbteCble = item.IdCbteCble;
                   info.Observacion = item.Observacion;
                   info.IdTipoCbte = item.IdTipoCbte;
                   info.IdEntidad = item.IdEntidad;
                   info.Fecha = item.Fecha;
                   info.Referencia = item.Referencia;
                   info.tc_TipoCbte = item.tc_TipoCbte;
                   info.Valor_cbte = item.Valor_cbte;
                   info.valor_cancelado =item.valor_cancelado;
                   info.valor_saldo_cbte = item.valor_saldo_cbte;
                   info.Tipo = item.Tipo;
                   info.IdEmpresaOP = item.IdEmpresaOP;
                   info.IdOrdenPagoOP = item.IdOrdenPagoOP;
                   info.SecuenciaOP = item.SecuenciaOP;
                   info.IdCtaCble = item.IdCtaCble;
                   info.IdCtaCble_Anticipo = item.IdCtaCble_Anticipo;

                   info.Beneficiario = item.Beneficiario;

                   lM.Add(info);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public bool Modificar_tipo_flujo(int IdEmpresa, decimal IdOrdenPago, Nullable<decimal> IdTipoFlujo)
       {
           try
           {
               using (EntitiesCuentasxPagar Context = new EntitiesCuentasxPagar())
               {
                   cp_orden_pago Entity = Context.cp_orden_pago.FirstOrDefault(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPago == IdOrdenPago);
                   if (Entity != null)
                   {
                       Entity.IdTipoFlujo = IdTipoFlujo;
                       Context.SaveChanges();    
                   }
               }

               return true;
           }
           catch (Exception ex)
           {
               string mensaje = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(int IdEmpresa, int IdOrdenPago, string EstadoAprovacion)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   var contact = context.cp_orden_pago.FirstOrDefault(obj => obj.IdEmpresa == IdEmpresa && obj.IdOrdenPago == IdOrdenPago);
                   if (contact != null)
                   {
                       contact.IdEstadoAprobacion = EstadoAprovacion;
                       context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

    }
}