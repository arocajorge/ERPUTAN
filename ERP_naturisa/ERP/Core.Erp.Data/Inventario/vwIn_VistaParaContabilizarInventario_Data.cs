using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
    public class vwIn_VistaParaContabilizarInventario_Data
    {
        string mensaje = "";
        public List<vwIn_VistaParaContabilizarInventario_Info> Get_List_VistaParaContabilizarInventario
       (int IdEmpresa, List<int> Bodegas, List<int> Sucursales, string tipoMovi,List<int> TiposMovimientosInvenario, DateTime FechaIni ,DateTime FechaFin) 
        {
            try
            {
                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                    FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                    IQueryable<vwIn_VistaParaContabilizarInventario_Info> Consulta =
                                from q in Entity.vwin_VistaParaContabilizarInventario
                                where q.IdEmpresa == IdEmpresa && Sucursales.Contains(q.IdSucursal) && Bodegas.Contains(q.IdBodega)
                                && q.mv_tipo_movi == tipoMovi && TiposMovimientosInvenario.Contains(q.IdMovi_inven_tipo)
                                && q.cm_fecha > FechaIni && q.cm_fecha < FechaFin
                        select ( new vwIn_VistaParaContabilizarInventario_Info
                        {
                            IdEmpresa = q.IdEmpresa,IdSucursal = q.IdSucursal,IdBodega = q.IdBodega,IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                            IdNumMovi = q.IdNumMovi,Secuencia = q.Secuencia,mv_tipo_movi = q.mv_tipo_movi,IdProducto = q.IdProducto,
                            dm_cantidad = q.dm_cantidad,dm_stock_ante = q.dm_stock_ante,dm_stock_actu = q.dm_stock_actu,dm_observacion = q.dm_observacion,
                            mv_costo = q.mv_costo,dm_peso = q.dm_peso,IdCtaCble_Inven = q.IdCtaCble_Inven,IdCtaCble_Costo = q.IdCtaCble_Costo,
                            IdCentro_Costo_Inventario = q.IdCentro_Costo_Inventario,IdCentro_Costo_Costo = q.IdCentro_Costo_Costo,cm_fecha = q.cm_fecha,
                            IdTipoCbte = q.IdTipoCbte,pr_descripcion = q.pr_descripcion,tm_descripcion = q.tm_descripcion,tc_TipoCbte = q.tc_TipoCbte,
                            Sucursal = q.Su_Descripcion,
                            Bodega = q.bo_Descripcion,
                            pr_codigo= q.pr_codigo
                        } 
                               );

                    return Consulta.ToList();
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


        public List<vwIn_VistaParaContabilizarInventario_Info> Get_List_VistaParaContabilizarInventario
        (int IdEmpresa, int idSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        {

            try
            {
                using (EntitiesInventario Entity = new EntitiesInventario())
                {
                    IQueryable<vwIn_VistaParaContabilizarInventario_Info> Consulta =
                                from q in Entity.vwin_VistaParaContabilizarInventario
                                where q.IdEmpresa == IdEmpresa && q.IdSucursal==idSucursal
                                && q.IdBodega == IdBodega && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                                && q.IdNumMovi == IdNumMovi
                                

                                select (new vwIn_VistaParaContabilizarInventario_Info
                                {
                                    IdEmpresa = q.IdEmpresa,
                                    IdSucursal = q.IdSucursal,
                                    IdBodega = q.IdBodega,
                                    IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                    IdNumMovi = q.IdNumMovi,
                                    Secuencia = q.Secuencia,
                                    mv_tipo_movi = q.mv_tipo_movi,
                                    IdProducto = q.IdProducto,
                                    dm_cantidad = q.dm_cantidad,
                                    dm_stock_ante = q.dm_stock_ante,
                                    dm_stock_actu = q.dm_stock_actu,
                                    dm_observacion = q.dm_observacion,                                    
                                    mv_costo = q.mv_costo,
                                    dm_peso = q.dm_peso,
                                    IdCtaCble_Inven = q.IdCtaCble_Inven,
                                    IdCtaCble_Costo = q.IdCtaCble_Costo,
                                    IdCentro_Costo_Inventario = q.IdCentro_Costo_Inventario,
                                    IdCentro_Costo_Costo = q.IdCentro_Costo_Costo,
                                    cm_fecha = q.cm_fecha,
                                    IdTipoCbte = q.IdTipoCbte,
                                    pr_descripcion = q.pr_descripcion,
                                    tm_descripcion = q.tm_descripcion,
                                    tc_TipoCbte = q.tc_TipoCbte,
                                    Sucursal = q.Su_Descripcion,
                                    Bodega = q.bo_Descripcion,
                                    pr_codigo = q.pr_codigo,
                                    IdPunto_Cargo = q.IdPunto_cargo,
                                    IdPunto_cargo_grupo = q.IdPunto_cargo_grupo,
                                    IdMotivo_inven = q.IdMotivo_Inv,
                                    IdCtaCble_Costo_Motivo = q.IdCtaCble_Costo_Motivo,
                                    IdCtaCble_Inven_Motivo =q.IdCtaCble_Inven_Motivo
                                }
                            );
                    return Consulta.ToList();
                }
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
    }
}
