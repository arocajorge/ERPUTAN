using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_AjusteFisico_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_ajusteFisico_Data oDat = new in_ajusteFisico_Data();
        in_AjusteFisico_Detalle_Bus bus_Detalle = new in_AjusteFisico_Detalle_Bus();
        in_producto_x_tb_bodega_Costo_Historico_Bus bus_costo_historico = new in_producto_x_tb_bodega_Costo_Historico_Bus();
        in_producto_x_tb_bodega_Costo_Historico_Info info_costo_historico = new in_producto_x_tb_bodega_Costo_Historico_Info();
        in_Ing_Egr_Inven_Bus bus_ing_egr = new in_Ing_Egr_Inven_Bus();

        public Boolean GuardarDB(in_ajusteFisico_Info Info,ref decimal  idAjuste,ref decimal  idEgressoMovi,ref decimal  idIngresoMovi)
        {
            try
            {
                //Grabo cabecera
                if (oDat.GuardarDB(Info, ref idAjuste, ref idEgressoMovi, ref idIngresoMovi))
                {
                    foreach (var item in Info.list_det_AjusteFisico)
                    {
                        item.IdAjusteFisico = idAjuste;
                    }
                    //Grabo detalle
                    if (bus_Detalle.GuardarDB(Info.list_det_AjusteFisico))
                    {
                        if (Info.IdEstadoAprobacion == "XAPRO") return true;//Si no se aprueba no se crean los movimientos de inventario
                        //Genero movimiento de inventario
                        if (Generar_info_ing_egr(Info, ref idIngresoMovi, ref idEgressoMovi))
                        {
                            //Modifico numeros de ingreso y egreso
                            if (oDat.ModificarDB(Info.IdEmpresa, Info.IdAjusteFisico, Info.IdEstadoAprobacion, idEgressoMovi, idIngresoMovi))
                                return true;
                        }
                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarAjusteFisico", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }          
        }

        public Boolean ModificarDB(in_ajusteFisico_Info Info, ref decimal idAjuste, ref decimal idEgressoMovi, ref decimal idIngresoMovi)
        {
            try
            {
                //Modifico cabecera
                if (oDat.ModificarDB(Info))
                {
                    foreach (var item in Info.list_det_AjusteFisico)
                    {
                        idAjuste = Info.IdAjusteFisico;
                        item.IdAjusteFisico = Info.IdAjusteFisico;
                    }
                    //Grabo detalle
                    if (bus_Detalle.EliminarDB(Info.IdEmpresa, Info.IdAjusteFisico))
                        if (bus_Detalle.GuardarDB(Info.list_det_AjusteFisico))
                        {
                            if (Info.IdEstadoAprobacion == "APRO")
                            {
                                //Genero movimiento de inventario
                                if (Generar_info_ing_egr(Info, ref idIngresoMovi, ref idEgressoMovi))
                                {
                                    //Modifico numero de ingreso y egreso
                                    if (oDat.ModificarDB(Info.IdEmpresa, Info.IdAjusteFisico, Info.IdEstadoAprobacion, idEgressoMovi, idIngresoMovi))
                                        return true;
                                }
                            }
                        }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }  
        }

        private bool Generar_info_ing_egr(in_ajusteFisico_Info info_ajuste, ref decimal IdNumMovi_ing,ref decimal IdNumMovi_egr)
        {
            try
            {
                in_Ing_Egr_Inven_Info info_ing_egr = new in_Ing_Egr_Inven_Info();

                bool HayIngresos = false;
                bool HayEgresos = false;

                    var TIngreso = (from q in info_ajuste.list_det_AjusteFisico
                                    where q.CantidadAjustada > 0
                                    select q).Count();


                    var TEgresos = (from q in info_ajuste.list_det_AjusteFisico
                                    where q.CantidadAjustada < 0
                                    select q).Count();


                    HayIngresos = (Convert.ToDouble(TIngreso) > 0) ? true : false;

                    #region HayIngreso

                    if (HayIngresos == true)
                    {
                        info_ing_egr = new in_Ing_Egr_Inven_Info();

                        info_ing_egr.IdEmpresa = info_ajuste.IdEmpresa;
                        info_ing_egr.IdSucursal = info_ajuste.IdSucursal;
                        info_ing_egr.IdBodega = info_ajuste.IdBodega;
                        info_ing_egr.IdMovi_inven_tipo = info_ajuste.IdMovi_inven_tipo_Ing;
                        info_ing_egr.signo = "+";
                        info_ing_egr.cm_observacion = info_ajuste.Observacion;
                        info_ing_egr.IdUsuario = info_ajuste.IdUsuario;
                        info_ing_egr.nom_pc = info_ajuste.nom_pc;
                        info_ing_egr.ip = info_ajuste.ip;
                        info_ing_egr.Estado = "A";
                        info_ing_egr.cm_fecha = info_ajuste.Fecha;
                        info_ing_egr.CodMoviInven = "AJU";
                        info_ing_egr.IdMotivo_Inv = 1;

                        /// obteniendo el detalle del movimiento de invetario 
                        var SelectDetMoviIng = from q in info_ajuste.list_det_AjusteFisico
                                               where q.CantidadAjustada > 0
                                               select q;
                        int c = 1;
                        foreach (var item in SelectDetMoviIng)
                        {
                            info_costo_historico = bus_costo_historico.get_UltimoCosto_x_Producto_Bodega(info_ajuste.IdEmpresa, info_ajuste.IdSucursal, info_ajuste.IdBodega, item.IdProducto, info_ing_egr.cm_fecha);


                            in_Ing_Egr_Inven_det_Info detMovInfo = new in_Ing_Egr_Inven_det_Info();
                            //detMovInfo.dm_peso = item.p;
                            detMovInfo.dm_stock_ante = item.StockFisico;
                            detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                            detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada);
                            detMovInfo.dm_cantidad_sinConversion = Convert.ToDouble(item.CantidadAjustada);
                            detMovInfo.IdProducto = item.IdProducto;
                            detMovInfo.Secuencia = c;
                            detMovInfo.IdEmpresa = info_ajuste.IdEmpresa;
                            detMovInfo.IdBodega = info_ing_egr.IdBodega;
                            detMovInfo.IdSucursal = info_ing_egr.IdSucursal;
                            detMovInfo.IdMovi_inven_tipo = info_ing_egr.IdMovi_inven_tipo;
                            detMovInfo.IdNumMovi = 0;//Nuevo
                            detMovInfo.signo = info_ing_egr.signo;
                            detMovInfo.dm_observacion = info_ajuste.Observacion;
                            //Costo historico
                            detMovInfo.dm_precio = info_costo_historico.costo;
                            detMovInfo.mv_costo = info_costo_historico.costo;
                            detMovInfo.mv_costo_sinConversion = info_costo_historico.costo;
                            detMovInfo.IdCentroCosto = item.IdCentroCosto;
                            info_ing_egr.listIng_Egr.Add(detMovInfo);
                            c++;
                        }
                        bus_ing_egr.GuardarDB(info_ing_egr, ref IdNumMovi_ing, ref mensaje);
                    }


                    #endregion
                    #region HayEgreso
                    HayEgresos = (Convert.ToDouble(TEgresos) > 0) ? true : false;

                    if (HayEgresos == true)
                    {
                        info_ing_egr = new in_Ing_Egr_Inven_Info();

                        info_ing_egr.IdEmpresa = info_ajuste.IdEmpresa;
                        info_ing_egr.IdSucursal = info_ajuste.IdSucursal;
                        info_ing_egr.IdBodega = info_ajuste.IdBodega;
                        info_ing_egr.IdMovi_inven_tipo = info_ajuste.IdMovi_inven_tipo_Egr;
                        info_ing_egr.signo = "-";
                        info_ing_egr.cm_observacion = info_ajuste.Observacion;
                        info_ing_egr.IdUsuario = info_ajuste.IdUsuario;
                        info_ing_egr.nom_pc = info_ajuste.nom_pc;
                        info_ing_egr.ip = info_ajuste.ip;
                        info_ing_egr.Estado = "A";
                        info_ing_egr.cm_fecha = info_ajuste.Fecha;
                        info_ing_egr.CodMoviInven = "AJU";
                        info_ing_egr.IdMotivo_Inv = 1;
                        /// encontrando el detalle de inventario 
                        /// 
                        var SelectDetMoviEgre = from q in info_ajuste.list_det_AjusteFisico
                                                where q.CantidadAjustada < 0
                                                select q;

                        int c = 1;

                        foreach (var item in SelectDetMoviEgre)
                        {
                            info_costo_historico = bus_costo_historico.get_UltimoCosto_x_Producto_Bodega(info_ajuste.IdEmpresa, info_ajuste.IdSucursal, info_ajuste.IdBodega, item.IdProducto, info_ing_egr.cm_fecha);

                            in_Ing_Egr_Inven_det_Info detMovInfo = new in_Ing_Egr_Inven_det_Info();
                            detMovInfo.IdEmpresa = info_ing_egr.IdEmpresa;
                            detMovInfo.IdBodega = info_ing_egr.IdBodega;
                            detMovInfo.IdSucursal = info_ing_egr.IdSucursal;
                            detMovInfo.IdMovi_inven_tipo = info_ing_egr.IdMovi_inven_tipo;
                            detMovInfo.IdNumMovi = 0;//Nuevo
                            //detMovInfo.peso = item.pr_peso;
                            detMovInfo.Secuencia = c;
                            c++;
                            detMovInfo.signo = info_ing_egr.signo;
                            detMovInfo.IdProducto = item.IdProducto;
                            detMovInfo.dm_cantidad = Convert.ToDouble(item.CantidadAjustada) * -1;
                            detMovInfo.dm_cantidad_sinConversion = Convert.ToDouble(item.CantidadAjustada) * -1;
                            detMovInfo.dm_stock_actu = Convert.ToDouble(item.StockFisico);
                            detMovInfo.dm_stock_ante = item.StockFisico;
                            detMovInfo.dm_observacion = info_ing_egr.cm_observacion;
                            //Costo historico
                            detMovInfo.dm_precio = info_costo_historico.costo;
                            detMovInfo.mv_costo = info_costo_historico.costo;
                            detMovInfo.mv_costo_sinConversion = info_costo_historico.costo;
                            detMovInfo.IdCentroCosto = item.IdCentroCosto;

                            info_ing_egr.listIng_Egr.Add(detMovInfo);
                        }
                        bus_ing_egr.GuardarDB(info_ing_egr, ref IdNumMovi_egr, ref mensaje);
                    }
                    #endregion  
              
                    return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Armar_info_ing_egr", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            }   
        }

        public in_ajusteFisico_Info Get_info_ajuste_fisico(int IdEmpresa, decimal IdAjsute_fisico)
        {
            try
            {
                return oDat.Get_info_ajuste_fisico(IdEmpresa, IdAjsute_fisico);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Armar_info_ing_egr", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };
            } 
        }

        public List<in_ajusteFisico_Info> Get_List_ajusteFisico(int idEmpresa, int IdSucursal, int idBodga, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
               return oDat.Get_List_ajusteFisico(idEmpresa,IdSucursal,idBodga,FechaIni,FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGenera", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };

            }

        }

        public List<in_ajusteFisico_Info> Get_List_ajusteFisico(int idEmpresa, int IdSucursalIni,int idSucursalFin, int idBodgaIni, int idBodegaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return oDat.Get_List_ajusteFisico(idEmpresa, IdSucursalIni,idSucursalFin, idBodgaIni,idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGenera", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };

            }

        }

        public Boolean AnularDB(in_ajusteFisico_Info info)
        {
            try
            {
                return oDat.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };

            }

        }

        public Boolean ModificarDB(int IdEmpresa, decimal IdAjusteFisico, string IdEstadoAproba, decimal IdNumMovi_Egr, decimal IdNumMovi_Ing)
        {
            try
            {
            return oDat.ModificarDB(IdEmpresa, IdAjusteFisico, IdEstadoAproba,IdNumMovi_Egr,IdNumMovi_Ing );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };

            }
            
        }

        public List<in_Producto_Info> Get_List_Productos_en_ajuste_fisico_a_fecha(int IdEmpresa, List<in_Producto_Info> listadoProducto_a_buscar, DateTime FechaAjuste, ref string mensaje)
        {
            try
            {
                return oDat.Get_List_Productos_en_ajuste_fisico_a_fecha(IdEmpresa, listadoProducto_a_buscar, FechaAjuste, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Listado_Productos_en_ajuste_fisico_a_fecha", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Bus) };

               
            }

        }



    }
}
