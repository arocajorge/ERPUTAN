using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;



namespace Core.Erp.Data.Inventario
{
  public  class in_Ingreso_x_OrdenCompra_det_Data
    {

        string mensaje = "";

        public List<in_Ingreso_x_OrdenCompra_det_Info> Get_List_Ingreso_x_OrdenCompra_det(int Idempresa, decimal IdIngreso_x_oc)
        {
            List<in_Ingreso_x_OrdenCompra_det_Info> lM = new List<in_Ingreso_x_OrdenCompra_det_Info>();             

            try
            {
                //EntitiesInventario OEInventario = new EntitiesInventario();


                //var select = from C in OEInventario.vwin_Ingreso_x_OrdenCompra_det
                //             where C.IdEmpresa == Idempresa && C.IdIngreso_x_oc == IdIngreso_x_oc
                //             orderby C.Secuencia ascending
                //             select C;

                //foreach (var item in select)
                //{
                //    in_Ingreso_x_OrdenCompra_det_Info info = new in_Ingreso_x_OrdenCompra_det_Info();

                //    info.IdEmpresa = item.IdEmpresa;
                //    info.IdIngreso_x_oc = item.IdIngreso_x_oc;
                //    info.Secuencia = item.Secuencia;
                //    info.IdProducto = item.IdProducto;
                //    info.Cant = item.Cant;
                //    info.Cant_a_recibir = item.Cant_a_recibir;
                //    info.IdEmpresa_oc = Convert.ToInt32(item.IdEmpresa_oc);
                //    info.IdSucursal_oc = Convert.ToInt32(item.IdSucursal_oc);
                //    info.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                //    info.Secuencia_oc = Convert.ToInt32(item.Secuencia_oc);

                //    info.IdCentroCosto = item.IdCentroCosto;
                //    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                //    info.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);

                //    info.nom_sucu = item.nom_sucursal;
                //    info.nom_producto = item.nom_producto;

                //    info.cantidad_pedida_OC = item.Cant;
                //    info.cantidad_ing_a_Inven = item.Cant_a_recibir;
                //    info.IdUnidadMedida = item.IdUnidadMedida;



                //    lM.Add(info);
                //}
                return lM;
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

      public List<in_Ingreso_x_OrdenCompra_det_Info> Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(int IdEmpresa, decimal IdProveedor)
      {
          try
          {
              decimal IdProveedorIni = 0;
              decimal IdProveedorFin = 0;

              IdProveedorIni = (IdProveedor == 0) ? 1 : IdProveedor;
              IdProveedorFin = (IdProveedor == 0) ? 9999999 : IdProveedor;


              List<in_Ingreso_x_OrdenCompra_det_Info> Lst = new List<in_Ingreso_x_OrdenCompra_det_Info>();            
              EntitiesCompras oEnti = new EntitiesCompras();
           
              var Consulta = from q in oEnti.vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo
                             where q.IdEmpresa == IdEmpresa
                             && q.IdProveedor >= IdProveedorIni
                             && q.IdProveedor <= IdProveedorFin
                             && q.Estado == "A" 
                             && q.IdEstadoAprobacion_cat == "APRO" 
                             && q.IdEstado_cierre != "CERR"
                             && q.Saldo_OC_x_Ing > 0
                             select q;


              foreach (var item in Consulta)
              {
                  in_Ingreso_x_OrdenCompra_det_Info Obj = new in_Ingreso_x_OrdenCompra_det_Info();
                  Obj.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                  Obj.IdSucursal = Convert.ToInt32(item.IdSucursal);
                  Obj.IdOrdenCompra = Convert.ToDecimal(item.IdOrdenCompra);
                  Obj.secuencia_oc_det = Convert.ToInt32(item.secuencia_oc_det);
                  Obj.nom_sucu = item.nom_sucu;
                  Obj.IdProveedor = Convert.ToDecimal(item.IdProveedor);
                  Obj.nom_proveedor = item.nom_proveedor;
                  Obj.Tipo = item.Tipo;
                  Obj.oc_fecha = Convert.ToDateTime(item.oc_fecha);
                  Obj.oc_observacion = item.oc_observacion;
                  Obj.cod_producto = item.cod_producto;
                  Obj.nom_producto = item.nom_producto;
                  Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                  Obj.cantidad_ing_a_Inven = 0;
                  Obj.Estado = item.Estado;
                  Obj.IdEstadoAprobacion = item.IdEstadoAprobacion_cat;
                  Obj.oc_NumDocumento = item.oc_NumDocumento;
                  Obj.oc_precio = Convert.ToDouble(item.oc_precio);

                  Obj.cantidad_pedida_OC = Convert.ToDouble(item.cantidad_pedida_OC);
                  Obj.Saldo_x_Ing_OC = Convert.ToDouble(item.Saldo_OC_x_Ing);
                  Obj.Saldo_x_Ing_OC_AUX = Convert.ToDouble(item.Saldo_OC_x_Ing);
                  Obj.pr_stock = Convert.ToDouble(item.pr_stock);
                  Obj.pr_peso = Convert.ToDouble(item.pr_peso);
                  Obj.CostoProducto = Convert.ToDouble(item.CostoProducto);
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.IdPunto_cargo = Convert.ToInt32(item.IdPunto_cargo);
                  Obj.IdUnidadMedida = item.IdUnidadMedida;
                  Obj.IdMotivo_OC = Convert.ToInt32(item.IdMotivo_oc);
                  Obj.Nom_Motivo = item.Nom_Motivo;
                  Obj.cantidad_ingresada = Convert.ToDouble(item.cantidad_ingresada);
                  Obj.IdEstado_cierre = item.IdEstado_cierre;
                  Obj.nom_estado_cierre = item.nom_estado_cierre;
                  Obj.Ref_OC = "OC.# " + Convert.ToDecimal(item.IdOrdenCompra) + " Fecha:" + Convert.ToDateTime(item.oc_fecha) + " Proveedor:" + item.nom_proveedor.Trim();
                  Obj.do_descuento = Convert.ToDouble(item.do_descuento);
                  Obj.do_subtotal = Convert.ToDouble(item.do_subtotal);
                  Obj.do_iva = Convert.ToDouble(item.do_iva);
                  Obj.do_total = Convert.ToDouble(item.do_total);

                  Obj.Descripcion = item.Descripcion;
                  Obj.IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo;
                  
                  if (item.IdCentroCosto_sub_centro_costo != null)
                  {
                      Obj.Nomsub_centro_costo = item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo;
                      
                  }
                  Obj.oc_NumDocumento = item.oc_NumDocumento;

                  Lst.Add(Obj);
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
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
