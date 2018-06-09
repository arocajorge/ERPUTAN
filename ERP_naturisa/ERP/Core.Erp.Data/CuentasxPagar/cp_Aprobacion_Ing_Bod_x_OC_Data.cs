using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_Aprobacion_Ing_Bod_x_OC_Data
    {
       cp_Aprobacion_Ing_Bod_x_OC_det_Data data_Det = new cp_Aprobacion_Ing_Bod_x_OC_det_Data();
       string mensaje = "";

       public decimal GetId(int idempresa)
       {
           try
           {
               decimal Id;
               EntitiesCuentasxPagar OECXP = new EntitiesCuentasxPagar();
               var selecte = OECXP.cp_Aprobacion_Ing_Bod_x_OC.Count(q => q.IdEmpresa == idempresa);

               if (selecte == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in OECXP.cp_Aprobacion_Ing_Bod_x_OC
                                    where q.IdEmpresa == idempresa 
                                    select q.IdAprobacion).Max();
                   Id = Convert.ToDecimal(select_em.ToString()) + 1;
               }
               return Id;                           
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }

       
       public Boolean VerificarNumDocumento(int IdEmpresa, string serie1, string serie2, string numDocu,decimal IdProveedor, ref string mensaje)
       {
           try
           {
               Boolean Existe;
               mensaje = "";
               Existe = false;

               EntitiesCuentasxPagar B = new EntitiesCuentasxPagar();

               var select_ = from t in B.cp_Aprobacion_Ing_Bod_x_OC
                             where t.Serie == serie1 
                             && t.Serie2 == serie2
                             && t.num_documento == numDocu 
                             && t.IdEmpresa == IdEmpresa
                             && t.IdProveedor == IdProveedor
                             && t.IdCbteCble_Ogiro!=null
                             select t;


               foreach (var item in select_)
               {
                   mensaje = item.Serie + "-" + item.Serie2 + "-" + item.num_documento + " FP#:" + item.IdCbteCble_Ogiro;
                        Existe = true;
               }

               return Existe;
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

       public Boolean GuardarDB(cp_Aprobacion_Ing_Bod_x_OC_Info Info, ref decimal Id, ref string msg)
       {
           try
           {
               using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
               {

                   cp_Aprobacion_Ing_Bod_x_OC Address = new cp_Aprobacion_Ing_Bod_x_OC();
                                               
                   Address.IdEmpresa = Info.IdEmpresa;
                   Address.IdAprobacion =Id=GetId(Info.IdEmpresa);
                   Address.Fecha_Factura = Convert.ToDateTime(Info.Fecha_Factura.ToShortDateString());
                   Address.Fecha_aprobacion = Convert.ToDateTime(Info.Fecha_Factura.ToShortDateString());
                   Address.IdEmpresa_Ogiro = Info.IdEmpresa_Ogiro;
                   Address.IdCbteCble_Ogiro = Info.IdCbteCble_Ogiro;
                   Address.IdTipoCbte_Ogiro = Info.IdTipoCbte_Ogiro;

                   Address.IdOrden_giro_Tipo = Info.IdOrden_giro_Tipo;
                   Address.IdIden_credito = Info.IdIden_credito;

                   Address.IdProveedor = Info.IdProveedor;
                   Address.Observacion = Info.Observacion;
                   Address.Serie = Info.Serie;
                   Address.Serie2 = Info.Serie2;
                   Address.num_documento = Info.num_documento;
                   Address.num_auto_Proveedor = Info.num_auto_Proveedor;
                   Address.num_auto_Imprenta = Info.num_auto_Imprenta;
                   Address.co_subtotal_iva = Info.co_subtotal_iva;
                   Address.co_subtotal_siniva = Info.co_subtotal_siniva;
                   Address.Descuento = Info.Descuento;
                   Address.co_baseImponible = Info.co_baseImponible;
                   Address.co_Por_iva = Info.co_Por_iva;
                   Address.co_valoriva = Info.co_valoriva;
                   Address.co_total = Info.co_total;
                   Address.co_plazo = Info.co_plazo;
                   Address.co_FechaVctoAutorizacion = Info.co_FechaVctoAutorizacion;
                   CxP.cp_Aprobacion_Ing_Bod_x_OC.Add(Address);
                   CxP.SaveChanges();

                   //grabar detalle

                   foreach (var item in Info.listDetalle)
                   {
                       item.IdEmpresa = Info.IdEmpresa;
                       item.IdAprobacion = Id;
                   }
                   // detalle
                   
                   data_Det.GuardarDB(Info.listDetalle, ref msg);
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
               mensaje = ex.InnerException + " " + ex.Message;
               msg = mensaje;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean ModificarDB(cp_Aprobacion_Ing_Bod_x_OC_Info info, ref string msg)
       {
           try
           {
               Boolean res = false;
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   var contact = context.cp_Aprobacion_Ing_Bod_x_OC.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa  && minfo.IdAprobacion==info.IdAprobacion);
                   if (contact != null)
                   {
                       contact.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
                       contact.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                       contact.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                       context.SaveChanges();
                       res = true;
                   }
               }
               return res;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               msg = mensaje;
               throw new Exception(ex.ToString());
            }
       }

       public Boolean EliminarDB(int IdEmpresa, decimal IdAprobacion, ref string msg)
       {
           try
           {
               bool respuesta = false;
               respuesta = data_Det.EliminarDB(IdEmpresa, IdAprobacion, ref msg);
               if (respuesta)
               {
                   using (EntitiesCuentasxPagar Entity = new EntitiesCuentasxPagar())
                   {
                       int numeroElimindo = Entity.Database.ExecuteSqlCommand("delete cp_Aprobacion_Ing_Bod_x_OC where IdEmpresa = " + IdEmpresa
                           + " and IdAprobacion = " + IdAprobacion);
                   }
                   msg = "Se eliminó la aprobación con exito";
                   return true;
               }
               else
               {
                   msg = "No se puedo eliminar la aprobación, favor comuniquese con sistemas";
                   return false;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               msg = "Error no se guardó " + ex.Message + " ";
               throw new Exception(ex.ToString());
           }
       }

       public List<cp_Aprobacion_Ing_Bod_x_OC_Info> Get_List_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
       {
           List<cp_Aprobacion_Ing_Bod_x_OC_Info> Lst = new List<cp_Aprobacion_Ing_Bod_x_OC_Info>();
           EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar();
           try
           {
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
               
               var Select = from q in CxP.vwcp_Aprobacion_Ing_Bod_x_OC
                            where q.IdEmpresa == IdEmpresa
                           
                            && q.Fecha_aprobacion <= FechaFin
                            && q.Fecha_aprobacion >= FechaIni
                           
                       
                            select q;

               foreach (var item in Select)
               {
                   cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
             
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdAprobacion = item.IdAprobacion;
                   info.Fecha_Factura = item.Fecha_Factura;
                   info.Fecha_aprobacion = item.Fecha_aprobacion;
                   info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                   info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;

                   info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                   info.IdIden_credito = item.IdIden_credito;

                   info.IdProveedor = item.IdProveedor;
                   info.Observacion = item.Observacion;
                   info.Serie = item.Serie;
                   info.Serie2 = item.Serie2;
                   info.num_documento = item.num_documento;
                   info.num_auto_Proveedor = item.num_auto_Proveedor;
                   info.num_auto_Imprenta = item.num_auto_Imprenta;
                   info.co_subtotal_iva = item.co_subtotal_iva;
                   info.co_subtotal_siniva = item.co_subtotal_siniva;
                   info.Descuento = item.Descuento;
                   info.co_baseImponible = item.co_baseImponible;
                   info.co_Por_iva = item.co_Por_iva;
                   info.co_valoriva = item.co_valoriva;
                   info.co_total = item.co_total;
                   info.co_FechaVctoAutorizacion = item.co_FechaVctoAutorizacion;
                   info.nom_proveedor = item.nom_proveedor;
                 
                   Lst.Add(info);

               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public cp_Aprobacion_Ing_Bod_x_OC_Info Get_Info_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, decimal IdAprobacion)
       {
           cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
           EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar();
           try
           {
             
               var Select = from q in CxP.cp_Aprobacion_Ing_Bod_x_OC
                            where q.IdEmpresa == IdEmpresa
                            && q.IdAprobacion == IdAprobacion                         
                            select q;

               foreach (var item in Select)
               {                  
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdAprobacion = item.IdAprobacion;
                   info.Fecha_Factura = item.Fecha_Factura;
                   info.Fecha_aprobacion = item.Fecha_aprobacion;
                   info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                   info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                   info.co_FechaVctoAutorizacion = item.co_FechaVctoAutorizacion;
                   info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                   info.IdIden_credito = item.IdIden_credito;

                   info.IdProveedor = item.IdProveedor;
                   info.Observacion = item.Observacion;
                   info.Serie = item.Serie;

                   info.Serie2 = item.Serie2;

                   info.num_documento = item.num_documento;
                   info.num_auto_Proveedor = item.num_auto_Proveedor;
                   info.num_auto_Imprenta = item.num_auto_Imprenta;
                   info.co_subtotal_iva = item.co_subtotal_iva;
                   info.co_subtotal_siniva = item.co_subtotal_siniva;
                   info.Descuento = item.Descuento;
                   info.co_baseImponible = item.co_baseImponible;
                   info.co_Por_iva = item.co_Por_iva;
                   info.co_valoriva = item.co_valoriva;
                   info.co_total = item.co_total;
            
               }
               return info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public cp_Aprobacion_Ing_Bod_x_OC_Info Get_Info_Aprobacion_Ing_Bod_x_OC(int IdEmpresa, int IdTipoCbte_OG, decimal IdCbteCble_OG)
       {
           cp_Aprobacion_Ing_Bod_x_OC_Info info = new cp_Aprobacion_Ing_Bod_x_OC_Info();
           EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar();
           try
           {

               var Select = from q in CxP.cp_Aprobacion_Ing_Bod_x_OC
                            where q.IdEmpresa == IdEmpresa
                            && q.IdTipoCbte_Ogiro == IdTipoCbte_OG
                            && q.IdCbteCble_Ogiro == IdCbteCble_OG
                            select q;

               foreach (var item in Select)
               {
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdAprobacion = item.IdAprobacion;
                   info.Fecha_Factura = item.Fecha_Factura;
                   info.Fecha_aprobacion = item.Fecha_aprobacion;
                   info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                   info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                   info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;

                   info.IdOrden_giro_Tipo = item.IdOrden_giro_Tipo;
                   info.IdIden_credito = item.IdIden_credito;

                   info.IdProveedor = item.IdProveedor;
                   info.Observacion = item.Observacion;
                   info.Serie = item.Serie;

                   info.Serie2 = item.Serie2;

                   info.num_documento = item.num_documento;
                   info.num_auto_Proveedor = item.num_auto_Proveedor;
                   info.num_auto_Imprenta = item.num_auto_Imprenta;
                   info.co_subtotal_iva = item.co_subtotal_iva;
                   info.co_subtotal_siniva = item.co_subtotal_siniva;
                   info.Descuento = item.Descuento;
                   info.co_baseImponible = item.co_baseImponible;
                   info.co_Por_iva = item.co_Por_iva;
                   info.co_valoriva = item.co_valoriva;
                   info.co_total = item.co_total;
                   info.co_FechaVctoAutorizacion = item.co_FechaVctoAutorizacion;
               }
               return info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public cp_Aprobacion_Ing_Bod_x_OC_Data(){}
    }
}
