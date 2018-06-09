using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.Compras
{
  public   class vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_Data
    {
        string mensaje = "";
        public List<in_movi_inve_detalle_Info> Get_List_movi_inve_detalle(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
                List<in_movi_inve_detalle_Info> Lst = new List<in_movi_inve_detalle_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                var Query = from q in oEnti.vwcom_ordencompra_local_det_con_saldo_x_ing_a_inven_con_saldo
                            where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdOrdenCompra == IdOrdenCompra
                            select q;
                foreach (var item in Query)
                {
                    in_movi_inve_detalle_Info Obj = new in_movi_inve_detalle_Info();
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
                    Obj.oc_precio = Convert.ToDouble(item.oc_precio);
                    Obj.cantidad_pedida_OC = Convert.ToDouble(item.cantidad_pedida_OC);
                    Obj.cantidad_ing_a_Inven = Convert.ToDouble(item.cantidad_ing_a_Inven);
                    Obj.Saldo_x_Ing_OC = Convert.ToDouble(item.Saldo_OC_x_Ing);
                    Obj.Saldo_x_Ing_OC_AUX = Convert.ToDouble(item.Saldo_OC_x_Ing);
                    Obj.pr_stock = Convert.ToDouble(item.pr_stock);
                    Obj.pr_peso = Convert.ToDouble(item.pr_peso);
                    Obj.CostoProducto = Convert.ToDouble(item.CostoProducto);
                    Obj.Estado = item.Estado;
                    Obj.IdEstadoAprobacion = item.IdEstadoAprobacion_cat;
                    Obj.IdEstadoRecepcion= item.IdEstadoRecepcion;
                    Obj.cantidad_ingresada = Convert.ToDouble(item.cantidad_ingresada);                                                                       
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
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }
    }
}
