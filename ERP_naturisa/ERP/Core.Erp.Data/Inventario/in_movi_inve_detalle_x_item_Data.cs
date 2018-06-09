using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_movi_inve_detalle_x_item_Data
    {
        public Boolean GuardarDB(in_movi_inve_detalle_x_item_Info info,ref string mensaje)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_movi_inve_detalle_x_item Entity = new in_movi_inve_detalle_x_item();
                    Entity.IdEmpresa = info.IdEmpresa;
                    Entity.IdSucursal = info.IdSucursal;
                    Entity.IdBodega = info.IdBodega;
                    Entity.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                    Entity.IdNumMovi = info.IdNumMovi;
                    Entity.Secuencia = info.Secuencia;
                    Entity.Secuencia_reg = info.Secuencia_reg;
                    Entity.codigo_reg = info.codigo_reg;
                    Entity.cantidad = info.cantidad;
                    Context.in_movi_inve_detalle_x_item.Add(Entity);
                    Context.SaveChanges();
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
                throw new Exception(mensaje);
            }
        }

        public Boolean EliminarDB(List<in_movi_inve_detalle_Info> lista)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    foreach (var item in lista)
                    {
                        Context.Database.ExecuteSqlCommand("delete in_movi_inve_detalle_x_item where IdEmpresa = " + item.IdEmpresa + " and IdSucursal = " + item.IdSucursal + " and IdBodega = " + item.IdBodega
                            + " and IdMovi_inven_tipo = " + item.IdMovi_inven_tipo + " and IdNumMovi = " + item.IdNumMovi + " and Secuencia = " + item.Secuencia);    
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }

        public in_movi_inve_detalle_x_item_Info Get_info_disponible(in_movi_inve_detalle_x_item_Info Movi)
        {
            try
            {
                in_movi_inve_detalle_x_item_Info info = new in_movi_inve_detalle_x_item_Info();
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var Entity = Context.vwin_movi_inve_detalle_x_item_disponibles.OrderBy(q=>q.cm_fecha).FirstOrDefault(q => q.IdEmpresa == Movi.IdEmpresa && q.IdSucursal == Movi.IdSucursal
                        && q.IdBodega == Movi.IdBodega && q.IdProducto == Movi.IdProducto);
                    if (Entity!=null)
                    {
                        info.IdEmpresa = Entity.IdEmpresa;
                        info.IdSucursal = Entity.IdSucursal;
                        info.IdBodega = Entity.IdBodega;
                        info.IdProducto = Entity.IdProducto;                        
                        info.codigo_reg = Entity.codigo_reg;
                        info.cantidad = Entity.cantidad == null ? 0 : (double)Entity.cantidad;
                    }
                }
                return info;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    }
}
