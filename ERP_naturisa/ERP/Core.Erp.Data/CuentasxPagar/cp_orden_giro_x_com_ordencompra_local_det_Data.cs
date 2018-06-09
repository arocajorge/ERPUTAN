using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxPagar
{
   public class cp_orden_giro_x_com_ordencompra_local_det_Data
    {

       string mensaje = "";
       
       public Boolean GrabarDB(cp_orden_giro_x_com_ordencompra_local_det_Info info, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   EntitiesCuentasxPagar EDB = new EntitiesCuentasxPagar();
              
                   var address = new cp_orden_giro_x_com_ordencompra_local_det();

                   address.IdEmpresa_Ogiro = info.IdEmpresa_Ogiro;
                   address.IdCbteCble_Ogiro = info.IdCbteCble_Ogiro;
                   address.IdTipoCbte_Ogiro = info.IdTipoCbte_Ogiro;
                   address.IdEmpresa_OC= info.IdEmpresa_OC;
                   address.IdSucursal_OC = info.IdSucursal_OC;
                   address.IdOrdenCompra = info.IdOrdenCompra;
                   address.Secuencia_OC = info.Secuencia_OC;
                   address.Observacion = info.Observacion == null ? "" : info.Observacion;
                   address.Secuencia_reg = info.Secuencia_reg;
                   context.cp_orden_giro_x_com_ordencompra_local_det.Add(address);
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

       public Boolean VerificarRegistro(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int secuencia)
       {
           try
           {
               EntitiesCuentasxPagar oen = new EntitiesCuentasxPagar();
               var select = from q in oen.cp_orden_giro_x_com_ordencompra_local_det
                            where q.IdEmpresa_OC == IdEmpresa

                            && q.IdSucursal_OC == IdSucursal
                            && q.IdOrdenCompra == IdOrdenCompra
                            && q.Secuencia_OC == secuencia
                            select q;

               if (select.ToList().Count() >= 1)
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
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int secuencia, ref string mensaje)
       {
           try
           {
               using (EntitiesCuentasxPagar context = new EntitiesCuentasxPagar())
               {
                   var contact = context.cp_orden_giro_x_com_ordencompra_local_det.FirstOrDefault(cp => cp.IdEmpresa_OC == IdEmpresa && cp.IdSucursal_OC == IdSucursal && cp.IdOrdenCompra == IdOrdenCompra && cp.Secuencia_OC==secuencia);
                   if (contact != null)
                   {
                       context.cp_orden_giro_x_com_ordencompra_local_det.Remove(contact);
                       context.SaveChanges();
                       context.Dispose();
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

       public List<cp_orden_giro_x_com_ordencompra_local_det_Info> Get_List_orden_giro_x_com_ordencompra_local_det(int IdEmpresa_Ogiro, decimal IdCbteCble_Ogiro, int IdTipoCbte_Ogiro, ref string mensaje)
       {
           try
           {
               List<cp_orden_giro_x_com_ordencompra_local_det_Info> lista = new List<cp_orden_giro_x_com_ordencompra_local_det_Info>();

               using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
               {
                   var Consulta = from q in CxP.vwcp_orden_giro_x_com_ordencompra_local_det_consulta
                                  where q.IdEmpresa_Ogiro == IdEmpresa_Ogiro
                                  && q.IdCbteCble_Ogiro == IdCbteCble_Ogiro
                                  && q.IdTipoCbte_Ogiro == IdTipoCbte_Ogiro
                                  select q;

                   foreach (var item in Consulta)
                   {
                       cp_orden_giro_x_com_ordencompra_local_det_Info info = new cp_orden_giro_x_com_ordencompra_local_det_Info();

                       info.IdEmpresa_Ogiro = item.IdEmpresa_Ogiro;
                       info.IdCbteCble_Ogiro = item.IdCbteCble_Ogiro;
                       info.IdTipoCbte_Ogiro = item.IdTipoCbte_Ogiro;
                       info.IdEmpresa_OC = item.IdEmpresa;
                       info.IdSucursal_OC = item.IdSucursal;
                       info.IdOrdenCompra = item.IdOrdenCompra;
                       info.Secuencia_OC = item.Secuencia;
                       info.Observacion = item.Observacion;

                       info.IdProducto = item.IdProducto;
                       info.do_Cantidad = item.do_Cantidad;
                       info.do_precioCompra = item.do_precioCompra;
                       info.do_porc_des = item.do_porc_des;
                       info.do_descuento = item.do_descuento;
                       info.do_subtotal = item.do_subtotal;
                       info.do_iva = item.do_iva;
                       info.do_total = item.do_total;
                       info.producto = item.pr_descripcion;
                       info.nom_medida = item.nom_medida;

                       lista.Add(info);
                   }

               }

               return lista;
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
