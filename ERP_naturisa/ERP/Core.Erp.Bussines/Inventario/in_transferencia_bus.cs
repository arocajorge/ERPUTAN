using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_transferencia_bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_transferencia_Data oData_Transferencia = new in_transferencia_Data();
        in_Ing_Egr_Inven_Bus bus_Ing_Egr_Inv = new in_Ing_Egr_Inven_Bus();
        in_Ing_Egr_Inven_Info info_ing_egr = new in_Ing_Egr_Inven_Info();
        in_producto_x_tb_bodega_Costo_Historico_Info info_costo = new in_producto_x_tb_bodega_Costo_Historico_Info();
        in_producto_x_tb_bodega_Costo_Historico_Bus bus_costo = new in_producto_x_tb_bodega_Costo_Historico_Bus();
        List<in_producto_x_tb_bodega_Costo_Historico_Info> list_costo_historico = new List<in_producto_x_tb_bodega_Costo_Historico_Info>();

        public bool GuardarDB(in_transferencia_Info info, ref decimal _idTransferencia)
        {
            try
            {
                Boolean resTran = false;              
                
                if (oData_Transferencia.GuardarDB(info, ref _idTransferencia))
                {
                    resTran = true;

                    if (info.IdEstadoAprobacion_cat == "APRO")
                    {
                        Generar_inventario(info, ref _idTransferencia);
                    }
                }
             return resTran;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarTransferecia", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

                
            }            
        }

        private void Generar_inventario(in_transferencia_Info info, ref decimal _idTransferencia)
        {
            try
            {
                in_Ing_Egr_Inven_Info in_Ing_Egr_Info_Origen = new in_Ing_Egr_Inven_Info();
                in_Ing_Egr_Inven_Info in_Ing_Egr_Info_Destino = new in_Ing_Egr_Inven_Info();
                string mensaje = "";
                decimal IdNumMovi_Egr = 0;
                decimal IdNumMovi_Ing = 0;

                //EGRESO POR TRANSFERENCIA                     
                in_Ing_Egr_Info_Origen = Get_Info_Ing_Egr_Inven(info, "-");
                if (info.IdNumMovi_Ing_Egr_Inven_Origen == null || info.IdNumMovi_Ing_Egr_Inven_Origen == 0)
                    bus_Ing_Egr_Inv.GuardarDB(in_Ing_Egr_Info_Origen, ref IdNumMovi_Egr, ref mensaje);
                else
                {
                    in_Ing_Egr_Info_Origen.IdNumMovi = Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Origen);
                    IdNumMovi_Egr = Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Origen);
                    bus_Ing_Egr_Inv.ModificarDB(in_Ing_Egr_Info_Origen, ref mensaje);
                }
                
                //INGRESO POR TRANSFERENCIA            
                in_Ing_Egr_Info_Destino = Get_Info_Ing_Egr_Inven(info, "+");
                if (info.IdNumMovi_Ing_Egr_Inven_Destino == null || info.IdNumMovi_Ing_Egr_Inven_Destino == 0)
                    bus_Ing_Egr_Inv.GuardarDB(in_Ing_Egr_Info_Destino, ref IdNumMovi_Ing, ref mensaje);
                else
                {
                    in_Ing_Egr_Info_Destino.IdNumMovi = Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Destino);
                    IdNumMovi_Ing = Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Destino);
                    bus_Ing_Egr_Inv.ModificarDB(in_Ing_Egr_Info_Destino, ref mensaje);
                }
                ///actualizando los idde movi inven en cab de transf
                oData_Transferencia.Modificar_IdMovi_Inven_x_Transf(info, in_Ing_Egr_Info_Origen.IdEmpresa, in_Ing_Egr_Info_Origen.IdSucursal,
                        IdNumMovi_Egr, in_Ing_Egr_Info_Destino.IdEmpresa, in_Ing_Egr_Info_Destino.IdSucursal, IdNumMovi_Ing);    
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Generar_inventario", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }   
        }

        private in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven(in_transferencia_Info info, string Signo)
        {
            try
            {
                in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.IdEmpresa = info.IdEmpresa;
                info_IngEgr.IdNumMovi = 0;
                info_IngEgr.CodMoviInven = "0";
                info_IngEgr.cm_fecha = info.tr_fecha;
                info_IngEgr.IdUsuario = info.IdUsuario;
                info_IngEgr.nom_pc = info.nom_pc;
                info_IngEgr.ip = info.ip;
                info_IngEgr.Fecha_Transac = info.tr_fecha;
                info_IngEgr.signo = Signo;


                if (Signo == "-")
                {
                    info_IngEgr.IdSucursal = info.IdSucursalOrigen;
                    info_IngEgr.IdBodega = info.IdBodegaOrigen;
                    info_IngEgr.cm_observacion = "Egreso x Trans. #" + info.IdTransferencia + " Suc.Org.# " + info.IdSucursalOrigen + "Bod.Org.# " + info.IdBodegaOrigen + " Suc.Dest.# " + info.IdSucursalDest + "Bod.Dest.# " + info.IdBodegaDest + ". " + info.tr_Observacion;
                    info_IngEgr.IdMovi_inven_tipo =  info.IdMovi_inven_tipo_SucuOrig == null ? 0 : Convert.ToInt32(info.IdMovi_inven_tipo_SucuOrig);
                    info_IngEgr.IdMotivo_Inv = info.IdMotivo_Inv_SucuOrig;
                }
                else
                {
                    info_IngEgr.IdSucursal = info.IdSucursalDest;
                    info_IngEgr.IdBodega = info.IdBodegaDest;
                    info_IngEgr.cm_observacion = "Ingreso x Trans. #" + info.IdTransferencia + " Suc.Dest.# " + info.IdSucursalDest + "Bod.Dest.# " + info.IdBodegaDest + " Suc.Org.# " + info.IdSucursalOrigen + "Bod.Org.# " + info.IdBodegaOrigen + ". " + info.tr_Observacion;
                    info_IngEgr.IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuDest == null ? 0 : Convert.ToInt32(info.IdMovi_inven_tipo_SucuDest);
                    info_IngEgr.IdMotivo_Inv = info.IdMotivo_Inv_SucuDest;
                }

                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>() ;
                if (Signo == "-")
                    info_IngEgr.listIng_Egr = GetDetalle_Ing_Egr_Inven(info.lista_detalle_transferencia, info.IdSucursalOrigen, info.IdBodegaOrigen, Signo,info_IngEgr.cm_fecha);
                else
                    info_IngEgr.listIng_Egr = GetDetalle_Ing_Egr_Inven(info.lista_detalle_transferencia, info.IdSucursalDest, info.IdBodegaDest, Signo, info_IngEgr.cm_fecha);


                return info_IngEgr;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Ing_Egr_Inven", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }

        private List<in_Ing_Egr_Inven_det_Info> GetDetalle_Ing_Egr_Inven(List<in_transferencia_det_Info> listDetalle, int IdSucursal, int IdBodega, string Signo,DateTime fecha)
        {
            try
            {
                List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();
                foreach (var item in listDetalle)
                {

                    switch (Signo)
                    {
                        case "-":
                            info_costo = bus_costo.get_UltimoCosto_x_Producto_Bodega(item.IdEmpresa, IdSucursal, IdBodega, item.IdProducto,fecha);
                            list_costo_historico.Add(info_costo);
                            break;
                        case "+":
                            info_costo = list_costo_historico.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdProducto == item.IdProducto);
                            break;
                    }
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = IdSucursal;
                    info.IdNumMovi = 0;
                    info.Secuencia = item.dt_secuencia;
                    info.IdBodega = IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = item.dt_cantidad;
                    info.dm_observacion = item.tr_Observacion;

                    info.dm_precio = info_costo == null ? 0 : info_costo.costo;
                    
                    info.mv_costo_sinConversion = info_costo == null ? 0 : info_costo.costo;
                    info.mv_costo = info_costo == null ? 0 : info_costo.costo;

                    info.dm_cantidad_sinConversion = item.dt_cantidad;
                    info.dm_cantidad = item.dt_cantidad;
                    
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                                       
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                    info.pr_descripcion = item.pr_descripcion;                    

                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    
                    list_IngEgrDet.Add(info);
                }
                return list_IngEgrDet;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetDetalle_Ing_Egr_Inven", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }
        }

        public in_transferencia_Info Get_Info_transferencia(in_transferencia_Info info, int idEmpresa)
        {
            try
            {
                return oData_Transferencia.Get_Info_transferencia(info, idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCabecera", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }

        public List<in_transferencia_det_Info> ObtenerDetalle(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {
            try
            {
               return oData_Transferencia.Get_List_transferencia_det(IdEmpresa,IdSucursal,IdBodega,IdTransferencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerDetalle", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }
        
        public bool ModificarDB(in_transferencia_Info info)
        {
            try
            {
                decimal _idTransferencia = 0;
                bool resTran = false;
                if (oData_Transferencia.ModificarDB(info))
                {
                    resTran = true;
                    if (info.IdEstadoAprobacion_cat == "APRO")
                    {
                        Generar_inventario(info, ref _idTransferencia);
                    }
                }
                return resTran;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }

        }

        public List<in_transferencia_Info> ObtenerTransferencias(int idempresa, DateTime FechaIni, DateTime FechaFin, int idSucursal, int idBodega)
        {
            try
            {
                  return oData_Transferencia.Get_List_transferencia(idempresa, FechaIni, FechaFin, idSucursal, idBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferencias", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }

        public List<in_transferencia_Info> ObtenerTransferencias(int idempresa, DateTime FechaIni, DateTime FechaFin, int idSucursalIni,int idSucursalFin, int idBodegaIni, int idBodegaFin)
        {
            try
            {
                return oData_Transferencia.Get_List_transferencia(idempresa, FechaIni, FechaFin, idSucursalIni,idSucursalFin, idBodegaIni,idBodegaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferencias", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }

        public List<in_transferencia_Info> ObtenerTransferencias(int idempresa, DateTime FechaIni, DateTime FechaFin, int idSucursal)
        {
            try
            {
                return oData_Transferencia.Get_List_transferencia(idempresa, FechaIni, FechaFin, idSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferencias", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }
                
        public Boolean Anular(in_transferencia_Info info,DateTime fecha_Anulacion,ref string mensaje)
        {
            try 
            {
                bool res = false;
                in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Bus bus_tras_x_guia_det = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Bus();
                in_transferencia_x_in_Guia_x_traspaso_bodega_Bus bus_trans_x_guia_cab = new in_transferencia_x_in_Guia_x_traspaso_bodega_Bus();
                in_Guia_x_traspaso_bodega_x_in_transferencia_det_Bus bus_guia_x_traspaso = new in_Guia_x_traspaso_bodega_x_in_transferencia_det_Bus();
                
                if (bus_tras_x_guia_det.EliminarDB(info))
                {
                    if (bus_trans_x_guia_cab.EliminarDB(info))
                    {
                        if (oData_Transferencia.Anular(info))
                        {
                            //ANULACION INGRESO
                            info_ing_egr.IdEmpresa = info.IdEmpresa_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToInt32(info.IdEmpresa_Ing_Egr_Inven_Destino);
                            info_ing_egr.IdSucursal = info.IdSucursal_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToInt32(info.IdSucursal_Ing_Egr_Inven_Destino);
                            info_ing_egr.IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuDest == null ? 0 : Convert.ToInt32(info.IdMovi_inven_tipo_SucuDest);
                            info_ing_egr.IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Destino);

                            info_ing_egr = bus_Ing_Egr_Inv.Get_Info_Ing_Egr_Inven(info_ing_egr.IdEmpresa, info_ing_egr.IdSucursal,  info_ing_egr.IdMovi_inven_tipo, info_ing_egr.IdNumMovi);
                            info_ing_egr.IdusuarioUltAnu = info.IdUsuarioUltAnu;
                            info_ing_egr.MotivoAnulacion = info.MotivoAnu;
                            info_ing_egr.Fecha_UltAnu = info.Fecha_UltAnu;
                            res = bus_Ing_Egr_Inv.AnularDB(info_ing_egr, ref mensaje);
                            //ANULACION EGRESO
                            info_ing_egr.IdEmpresa = info.IdEmpresa_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToInt32(info.IdEmpresa_Ing_Egr_Inven_Origen);
                            info_ing_egr.IdSucursal = info.IdSucursal_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToInt32(info.IdSucursal_Ing_Egr_Inven_Origen);
                            info_ing_egr.IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig == null ? 0 : Convert.ToInt32(info.IdMovi_inven_tipo_SucuOrig);
                            info_ing_egr.IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToDecimal(info.IdNumMovi_Ing_Egr_Inven_Origen);

                            info_ing_egr = bus_Ing_Egr_Inv.Get_Info_Ing_Egr_Inven(info_ing_egr.IdEmpresa, info_ing_egr.IdSucursal,  info_ing_egr.IdMovi_inven_tipo, info_ing_egr.IdNumMovi);
                            info_ing_egr.IdusuarioUltAnu = info.IdUsuarioUltAnu;
                            info_ing_egr.MotivoAnulacion = info.MotivoAnu;
                            info_ing_egr.Fecha_UltAnu = info.Fecha_UltAnu;
                            res = bus_Ing_Egr_Inv.AnularDB(info_ing_egr, ref mensaje);

                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }
        }

        public decimal GetId(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                return oData_Transferencia.GetId(IdEmpresa, IdSucursal, IdBodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetId", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }
           
        }
        
        public List<in_transferencia_det_Info> Get_List_transferencia_det(in_transferencia_Info Info, int idEmpresa)
        {
            try
            {
               return oData_Transferencia.Get_List_transferencia_det(Info, idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferenciasDetalle", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };

            }

        }

        public List<in_transferencia_det_Info> Get_List_transferencia_det_sin_Guia(in_transferencia_Info Info, int idEmpresa)
        {
            try
            {
                return oData_Transferencia.Get_List_transferencia_det_sin_Guia(Info, idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferenciasDetalle", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }

        }

        public List<in_transferencia_Info> Get_List_transferencias_para_recosteo(int IdEmpresa, DateTime Fecha_ini)
        {
            try
            {
                return oData_Transferencia.Get_List_transferencias_para_recosteo(IdEmpresa, Fecha_ini);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerTransferenciasDetalle", ex.Message), ex) { EntityType = typeof(in_transferencia_bus) };
            }
        }
    }
}
