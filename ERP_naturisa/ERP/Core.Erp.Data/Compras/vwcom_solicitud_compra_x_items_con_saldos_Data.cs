using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity;


namespace Core.Erp.Data.Compras
{


    

   public class vwcom_solicitud_compra_x_items_con_saldos_Data
    {
       string mensaje = "";
       public List<vwcom_solicitud_compra_x_items_con_saldos_Info> Get_List_SoliComxItemSaldos(int IdEmpresa,DateTime FechaIni,DateTime FechaFin,
           string IdEstadoAprobacion,string IdEstadoPreAprobacion ,int IdSucursal
        , decimal IdComprador)
       {


           List<vwcom_solicitud_compra_x_items_con_saldos_Info> Lst = new List<vwcom_solicitud_compra_x_items_con_saldos_Info>();
           try
           {
               FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
               FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

               int IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
               int IdSucursalFin = (IdSucursal == 0) ? 9999999 : IdSucursal;

               
               decimal IdCompradorIni = (IdComprador == 0) ? 0 : IdComprador;
               decimal IdCompradorFin = (IdComprador == 0) ? 9999999 : IdComprador;

               



               IdEstadoAprobacion = (IdEstadoAprobacion == "TODOS") ? "" : IdEstadoAprobacion;
               IdEstadoPreAprobacion = (IdEstadoPreAprobacion == "TODOS") ? "" : IdEstadoPreAprobacion;

                             
               EntitiesCompras oEnti = new EntitiesCompras();

               var Query2 = from q in oEnti.vwcom_solicitud_compra_x_items_con_saldos
                       where q.IdEmpresa == IdEmpresa
                        && q.fecha <= FechaFin
                        && q.fecha >= FechaIni
                        && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                        && q.IdComprador >= IdCompradorIni && q.IdComprador <= IdCompradorFin
                        && q.IdEstadoAprobacion.Contains(IdEstadoAprobacion)
                        && q.IdEstadoPreAprobacion.Contains(IdEstadoPreAprobacion)
                       select q;


               foreach (var item in Query2)
                   {
                       vwcom_solicitud_compra_x_items_con_saldos_Info Obj = new vwcom_solicitud_compra_x_items_con_saldos_Info();

                       Obj.IdEmpresa = item.IdEmpresa;
                       Obj.IdSucursal = item.IdSucursal;
                       Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                       Obj.NumDocumento = item.NumDocumento;
                       Obj.IdPersona_Solicita = Convert.ToDecimal(item.IdPersona_Solicita);
                       Obj.IdComprador = item.IdComprador;
                       Obj.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                       Obj.fecha = item.fecha;
                       Obj.plazo = item.plazo;
                       Obj.fecha_vtc = item.fecha_vtc;
                       Obj.observacion = item.observacion;
                       Obj.Estado = item.Estado;
                       Obj.Sucursal = item.Sucursal;
                       Obj.Solicitante = item.Solicitante;
                       Obj.Comprador = item.Comprador;
                       Obj.departamento = item.departamento;
                       Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;
                       Obj.nom_EstadoAprobacion = item.nom_EstadoAprobacion;
                       Obj.IdUsuarioAprobo = item.IdUsuarioAprobo;
                       Obj.MotivoAprobacion = item.MotivoAprobacion;
                       Obj.FechaHoraAprobacion = Convert.ToDateTime(item.FechaHoraAprobacion);
                       Obj.Secuencia = item.Secuencia;
                       Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                       Obj.cant_solicitada = item.cant_solicitada;
                       Obj.NomProducto = item.NomProducto;
                       Obj.cod_producto = item.cod_producto;
                       Obj.nom_producto = item.nom_producto;
                       Obj.IdCentroCosto = item.IdCentroCosto;
                       Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       Obj.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                       Obj.cant_aprobada_OC = item.cant_aprobada_OC;
                       Obj.Saldo_cant_SolCom = item.Saldo_can_SolCom;
                       Obj.Saldo_cant_SolCom_AUX = item.Saldo_can_SolCom;
                       Obj.cant_aprobada_OC_AUX = item.cant_aprobada_OC;
                       Obj.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion;
                       Obj.IdProveedor = Convert.ToDecimal(item.IdProveedor_SC);
                       Obj.Cantidad_aprobada = Convert.ToDouble(item.Cantidad_aprobada);
                       Obj.observacion_Aprob = item.observacion_Aprob;
                       Obj.IdUsuarioAprueba = item.IdUsuarioAprueba;
                       Obj.IdMotivo = Convert.ToInt32(item.IdMotivo);
                       Obj.IdUnidadMedida = item.IdUnidadMedida;
                       Obj.Stock = item.Stock;
                       Obj.do_precioCompra = Convert.ToDouble(item.do_precioCompra);
                       Obj.do_porc_des = Convert.ToDouble(item.do_porc_des);
                       Obj.do_descuento = Convert.ToDouble(item.do_descuento);
                       Obj.do_subtotal = Convert.ToDouble(item.do_subtotal);
                       Obj.do_iva = Convert.ToDouble(item.do_iva);
                       Obj.do_total = Convert.ToDouble(item.do_total);
                       Obj.do_observacion = item.do_observacion;

                       Obj.ocd_IdEmpresa = item.ocd_IdEmpresa;
                       Obj.ocd_IdSucursal = item.ocd_IdSucursal;
                       Obj.ocd_IdOrdenCompra = item.ocd_IdOrdenCompra;

                       Obj.Tiene_OC = (item.ocd_IdOrdenCompra != null) ? true : false;
                       Obj.Stock = item.Stock;
                       


                       Obj.cant_ing_SolCom = Convert.ToDouble(item.Cantidad_aprobada);
                       Obj.cant_ing_SolCom_AUX = Obj.cant_ing_SolCom;

                                         
                       if (item.IdCentroCosto_sub_centro_costo != null)
                       {
                           Obj.Nomsub_centro_costo = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Nomsub_centro_costo.Trim();
                       }

                       if (item.IdCentroCosto != null && item.Nom_Centro_costo!=null)
                       {
                           Obj.Nom_Centro_costo = "[" + item.IdCentroCosto.Trim() + "] - " + item.Nom_Centro_costo.Trim();
                       }


                       Obj.Referencia = "Sucursal : " + item.Sucursal + " con Solicitud #: " + item.IdSolicitudCompra + " , Fecha: " + item.fecha + " y Comprador: " + item.Comprador + " , Observación: " + item.observacion + "";

                       Obj.IdEstadoPreAprobacion = item.IdEstadoPreAprobacion;
                       //Obj.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                  
                       Lst.Add(Obj);
                   }
           

             
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
    }
}
