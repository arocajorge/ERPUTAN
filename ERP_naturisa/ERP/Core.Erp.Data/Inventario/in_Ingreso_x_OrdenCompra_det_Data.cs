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

        public List<in_Ing_Egr_Inven_det_Info> Get_List_Ingreso_x_OrdenCompra_det_x_proveedor(int IdEmpresa, decimal IdProveedor)
      {
          try
          {
              decimal IdProveedorIni = 0;
              decimal IdProveedorFin = 0;

              IdProveedorIni = (IdProveedor == 0) ? 1 : IdProveedor;
              IdProveedorFin = (IdProveedor == 0) ? 9999999 : IdProveedor;


              List<in_Ing_Egr_Inven_det_Info> Lst = new List<in_Ing_Egr_Inven_det_Info>();            
              EntitiesInventario oEnti = new EntitiesInventario();
           
              var Consulta = oEnti.vwin_Ing_Egr_Inven_det_PorIngresar.Where(q=> q.IdEmpresa == IdEmpresa
                             && q.IdProveedor >= IdProveedorIni
                             && q.IdProveedor <= IdProveedorFin).ToList();


              foreach (var item in Consulta)
              {
                  Lst.Add(new in_Ing_Egr_Inven_det_Info
                  {
                      IdEmpresa = item.IdEmpresa,
                      IdSucursal = item.IdSucursal,
                      IdEmpresa_oc = item.IdEmpresa,
                      IdSucursal_oc = item.IdSucursal,
                      IdOrdenCompra = item.IdOrdenCompra,
                      Secuencia_oc = item.Secuencia,
                      nom_sucu = item.Su_Descripcion,
                      IdProveedor = item.IdProveedor,
                      nom_proveedor = item.pe_nombreCompleto,
                      oc_fecha = item.oc_fecha,
                      oc_observacion = item.oc_observacion,
                      cod_producto = item.pr_codigo,
                      nom_producto = item.pr_descripcion,
                      IdProducto = item.IdProducto,
                      dm_cantidad = 0,
                      oc_NumDocumento = item.oc_NumDocumento,
                      dm_precio = item.do_precioFinal,
                      mv_costo = item.do_precioFinal,

                      cantidad_pedida_OC = item.do_Cantidad,
                      Saldo_x_Ing_OC = item.Saldo,
                      Saldo_x_Ing_OC_AUX = item.Saldo,
                      dm_stock_ante = 0,
                      dm_stock_actu = 0,
                      IdCentroCosto = item.IdCentroCosto,
                      IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo,

                      IdPunto_cargo_grupo = item.IdPunto_cargo_grupo,
                      IdPunto_cargo = item.IdPunto_cargo,
                      IdUnidadMedida = item.IdUnidadMedida,
                      cantidad_ingresada = item.CantidadIngresada,
                      IdEstado_cierre = item.IdEstado_cierre,
                      Ref_OC = item.RefOC,
                      IdUnidadMedida_Consumo = item.IdUnidadMedida_Consumo,
                      Nomsub_centro_costo = item.IdCentroCosto + "-" + item.IdCentroCosto_sub_centro_costo,
                      SucursalDestino = item.SucursalDestino
                  });

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
