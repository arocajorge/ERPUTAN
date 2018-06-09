using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt027_Data
    {
        string MensajeError = "";

        public List<XINV_Rpt027_Info> Get_List(DateTime Fecha_desde, DateTime Fecha_hasta, int IdEmpresa, int IdSucursal, List<int> lst_bodega, decimal IdProducto, string idUsuario, bool No_mostrar_valores_en_0, bool Mostrar_detallado)
        {
            try
            {
                Fecha_desde = Fecha_desde.Date;
                Fecha_hasta = Fecha_hasta.Date;

                int IdSucursal_ini = IdSucursal == 0 ? 1 : IdSucursal;
                int IdSucursal_fin = IdSucursal == 0 ? 9999 : IdSucursal;

                decimal IdProducto_ini = IdProducto == 0 ? 1 : IdProducto;
                decimal IdProducto_fin = IdProducto == 0 ? 99999 : IdProducto;

                List<XINV_Rpt027_Info> List = new List<XINV_Rpt027_Info>();

                using (Entities_Inventario_General context = new Entities_Inventario_General())
                {
                    context.SetCommandTimeOut(30000);

                    foreach (var item_bodega in lst_bodega)
                    {
                        var lst = from q in context.spINV_Rpt027(IdEmpresa, IdSucursal_ini, IdSucursal_fin, item_bodega, item_bodega, IdProducto_ini, IdProducto_fin, Fecha_desde, Fecha_hasta, idUsuario, No_mostrar_valores_en_0, Mostrar_detallado)
                                  select q;
                        foreach (var item in lst)
                        {

                            XINV_Rpt027_Info info = new XINV_Rpt027_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdSucursal = item.IdSucursal;
                            info.IdBodega = item.IdBodega;
                            info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                            info.IdNumMovi = item.IdNumMovi;
                            info.Secuencia = item.Secuencia;
                            info.IdProducto = item.IdProducto;
                            info.Saldo_ini_cant = item.Saldo_ini_cant;
                            info.Cost_prom_ini = item.Cost_prom_ini;
                            info.Saldo_ini_cost = item.Saldo_ini_cost;
                            info.cant_ing = item.cant_ing;
                            info.cost_ing = item.cost_ing;
                            info.total_ing = item.total_ing;
                            info.cant_egr = item.cant_egr;
                            info.cost_egr = item.cost_egr;
                            info.total_egr = item.total_egr;
                            info.Saldo_cant = item.Saldo_cant;
                            info.Saldo_cost_prom = item.Saldo_cost_prom;
                            info.Saldo_cost = item.Saldo_cost;
                            info.Saldo_fin_cant = item.Saldo_fin_cant;
                            info.Cost_prom_fin = item.Cost_prom_fin;
                            info.Saldo_fin_cost = item.Saldo_fin_cost;
                            info.IdUsuario = item.IdUsuario;
                            info.dm_observacion = item.dm_observacion;
                            info.cm_fecha = item.cm_fecha;
                            info.tipo_movi = item.tipo_movi;
                            info.cod_bodega = item.cod_bodega;
                            info.nom_bodega = item.nom_bodega;
                            info.cod_sucursal = item.cod_sucursal;
                            info.nom_sucursal = item.nom_sucursal;
                            info.IdEmpresa_oc = item.IdEmpresa_oc;
                            info.IdSucursal_oc = item.IdSucursal_oc;
                            info.IdOrdenCompra = item.IdOrdenCompra;
                            info.num_factura = item.num_factura;
                            info.nom_proveedor = item.nom_proveedor;
                            info.pr_codigo = item.pr_codigo;
                            info.pr_descripcion = item.pr_descripcion;
                            info.IdUnidadMedida = item.IdUnidadMedida;
                            info.nom_unidad_consumo = item.nom_unidad_consumo;
                            info.cod_unidad_consumo = item.cod_unidad_consumo;
                            List.Add(info);
                        }
                    }
                }

                return List;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
