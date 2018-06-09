using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
    public class in_transferencia_Data
    {
        public decimal _idEgresoMOvi { get; set; }
        public decimal _idIngreso { get; set; }
        in_movi_inve_Data idData = new in_movi_inve_Data();
        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data odata_trans_x_guia = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data();
        string mensaje = "";

        List<in_movi_inve_detalle_Info> listDetalleMoviInvenEgreso = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_Info> listDetalleMoviInvenIngreso = new List<in_movi_inve_detalle_Info>();
        in_producto_x_tb_bodega_Data oProxBodData = new in_producto_x_tb_bodega_Data();

        public decimal GetId(int idEmpresa, int idSucursal, int idBodega)
        {
            try
            {
                decimal id;
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    EntitiesInventario oEInventario = new EntitiesInventario();

                    var Select = from q in oEInventario.in_transferencia
                                 where q.IdEmpresa == idEmpresa && q.IdSucursalOrigen == idSucursal && q.IdBodegaOrigen == idBodega                                 
                                 select q;
                    if (Select.ToList().Count == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        var qmax = (from q in oEInventario.in_transferencia
                                    where q.IdEmpresa == idEmpresa && q.IdSucursalOrigen == idSucursal && q.IdBodegaOrigen == idBodega
                                    select q.IdTransferencia).Max();

                        id = Convert.ToInt32(qmax.ToString()) + 1;
                        return id;
                    }
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
        
        public bool GuardarDB(in_transferencia_Info info, ref decimal _idTransferencia)
        {
            try
            {
                try
                {
                    using (EntitiesInventario contex = new EntitiesInventario())
                    {
                        #region Cabecera
                        EntitiesInventario oInventario = new EntitiesInventario();
                        var address = new in_transferencia();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdSucursalOrigen = info.IdSucursalOrigen;
                        address.IdBodegaOrigen = info.IdBodegaOrigen;
                        address.IdTransferencia = info.IdTransferencia = _idTransferencia = GetId(info.IdEmpresa, info.IdSucursalOrigen, info.IdBodegaOrigen);
                        address.IdSucursalDest = info.IdSucursalDest;
                        address.IdBodegaDest = info.IdBodegaDest;
                        address.tr_Observacion = info.tr_Observacion;
                        address.IdMovi_inven_tipo_SucuOrig = info.IdMovi_inven_tipo_SucuOrig;
                        address.IdMovi_inven_tipo_SucuDest = info.IdMovi_inven_tipo_SucuDest;
                        address.tr_fecha = Convert.ToDateTime(info.tr_fecha.ToShortDateString());
                        address.Estado = "A";
                        address.IdUsuario = (info.IdUsuario == null) ? "" : info.IdUsuario;
                        address.ip = (info.ip == null) ? "" : info.ip;
                        address.nom_pc = (info.nom_pc == null) ? "" : info.nom_pc;
                        address.IdEstadoAprobacion_cat = info.IdEstadoAprobacion_cat;
                        address.Codigo = info.Codigo;
                        contex.in_transferencia.Add(address);
                        contex.SaveChanges();
                        #endregion
                        #region DetalleTransferencia
                        //GRABAR EL DETALLE DE LA TRANSFERENCIA
                        int c = 1;

                        using (EntitiesInventario contexDeta = new EntitiesInventario())
                        {
                            foreach (var item in info.lista_detalle_transferencia)
                            {
                                var addressDeta = new in_transferencia_det();
                                addressDeta.IdEmpresa = info.IdEmpresa;
                                addressDeta.IdSucursalOrigen = info.IdSucursalOrigen;
                                addressDeta.IdTransferencia = info.IdTransferencia;
                                addressDeta.IdBodegaOrigen = info.IdBodegaOrigen;
                                addressDeta.IdProducto = item.IdProducto;
                                addressDeta.dt_cantidad = item.dt_cantidad;
                                addressDeta.IdUnidadMedida = item.IdUnidadMedida;
                                addressDeta.tr_Observacion = item.tr_Observacion;
                                addressDeta.IdCentroCosto = item.IdCentroCosto;
                                addressDeta.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                                addressDeta.IdPunto_cargo = item.IdPunto_cargo;
                                addressDeta.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo == "" ? null : item.IdCentroCosto_sub_centro_costo;
                                addressDeta.dt_secuencia = item.dt_secuencia = c;
                                c++;
                                contexDeta.in_transferencia_det.Add(addressDeta);
                                contexDeta.SaveChanges();
                            }
                        }
                        #endregion
                        #region DetalleTransferencia_x_guia
                        foreach (var item in info.lista_detalle_transferencia)
                        {
                            if (item.Info_Guia_x_traspaso_bodega_det.IdEmpresa!=0)
                            {
                                in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info info_det_trans_x_guia = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info();
                                info_det_trans_x_guia.IdEmpresa_trans = info.IdEmpresa;
                                info_det_trans_x_guia.IdSucursalOrigen_trans = info.IdSucursalOrigen;
                                info_det_trans_x_guia.IdBodegaOrigen_trans = info.IdBodegaOrigen;
                                info_det_trans_x_guia.IdTransferencia_trans = info.IdTransferencia;
                                info_det_trans_x_guia.Secuencia_trans = item.dt_secuencia;

                                info_det_trans_x_guia.IdEmpresa_guia = item.Info_Guia_x_traspaso_bodega_det.IdEmpresa;
                                info_det_trans_x_guia.IdGuia_guia = item.Info_Guia_x_traspaso_bodega_det.IdGuia;
                                info_det_trans_x_guia.Secuencia_guia = item.Info_Guia_x_traspaso_bodega_det.secuencia;
                                odata_trans_x_guia.GuardarDB(info_det_trans_x_guia);
                            }
                            
                        }
                        #endregion
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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

        public List<in_transferencia_det_Info> Get_List_transferencia_det(in_transferencia_Info Info, int idEmpresa)
        {
            try
            {
                List<in_transferencia_det_Info> lst = new List<in_transferencia_det_Info>();

                EntitiesInventario Oentities = new EntitiesInventario();
                var select = from q in Oentities.in_transferencia_det
                             where q.IdEmpresa == idEmpresa 
                             && q.IdTransferencia == Info.IdTransferencia
                             && q.IdBodegaOrigen == Info.IdBodegaOrigen 
                             && q.IdSucursalOrigen == Info.IdSucursalOrigen
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_det_Info info = new in_transferencia_det_Info();

                    info.IdProducto = item.IdProducto;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdTransferencia = item.IdTransferencia;
                    
                    info.tr_Observacion = item.tr_Observacion;
                    
                    lst.Add(info); ;
                }

                return lst;
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
        
        public in_transferencia_Info Get_Info_transferencia(in_transferencia_Info info, int idEmpresa)
        {
            try
            {
                in_transferencia_Info Info = new in_transferencia_Info();

                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.vwin_Transferencia_x_Ing_Egr_Inven
                             where q.IdTransferencia == info.IdTransferencia 
                             && q.IdEmpresa == idEmpresa
                             && q.IdBodegaOrigen == info.IdBodegaOrigen 
                             && q.IdSucursalOrigen == info.IdSucursalOrigen                             
                             select q;
                foreach (var item in select)
                {
                    Info.IdEmpresa = item.IdEmpresa;
                    Info.IdSucursalOrigen = item.IdSucursalOrigen;
                    Info.IdBodegaOrigen = item.IdBodegaOrigen;
                    Info.IdTransferencia = item.IdTransferencia;
                    Info.IdSucursalDest = item.IdSucursalDest;
                    Info.IdBodegaDest = item.IdBodegaDest;
                    Info.tr_Observacion = item.tr_Observacion;
                    Info.tr_fecha = item.tr_fecha;
                    Info.Estado = item.Estado;
                    Info.IdEmpresa_Ing_Egr_Inven_Origen = Convert.ToInt32((item.IdEmpresa_Ing_Egr_Inven_Origen == null) ? 0 : item.IdEmpresa_Ing_Egr_Inven_Origen);
                    Info.IdSucursal_Ing_Egr_Inven_Origen = Convert.ToInt32((item.IdSucursal_Ing_Egr_Inven_Origen == null) ? 0 : item.IdSucursal_Ing_Egr_Inven_Origen);
                    Info.IdNumMovi_Ing_Egr_Inven_Origen = Convert.ToDecimal((item.IdNumMovi_Ing_Egr_Inven_Origen == null) ? 0 : item.IdNumMovi_Ing_Egr_Inven_Origen);
                    Info.IdEmpresa_Ing_Egr_Inven_Destino = Convert.ToInt32((item.IdEmpresa_Ing_Egr_Inven_Destino == null) ? 0 : item.IdEmpresa_Ing_Egr_Inven_Destino);
                    Info.IdSucursal_Ing_Egr_Inven_Destino = Convert.ToInt32((item.IdSucursal_Ing_Egr_Inven_Destino == null) ? 0 : item.IdSucursal_Ing_Egr_Inven_Destino);
                    Info.IdNumMovi_Ing_Egr_Inven_Destino = Convert.ToDecimal((item.IdNumMovi_Ing_Egr_Inven_Destino == null) ? 0 : item.IdNumMovi_Ing_Egr_Inven_Destino);
                    
                    Info.IdMovi_inven_tipo_SucuOrig = item.IdMovi_inven_tipo_Origen;
                    Info.IdMovi_inven_tipo_SucuDest = item.IdMovi_inven_tipo_Destino;
                    Info.IdMotivo_Inv_SucuOrig = Convert.ToInt32(item.IdMotivo_Inv_Origen);
                    Info.IdMotivo_Inv_SucuDest = Convert.ToInt32(item.IdMotivo_Inv_Destino);
                    info.Codigo = item.Codigo;
                    

                    //info.IdUsuario = item.IdUsuario;
                }
                return Info;
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

        public List<in_transferencia_det_Info> Get_List_transferencia_det(int idEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {

            try
            {
                List<in_transferencia_det_Info> dats = new List<in_transferencia_det_Info>();
                EntitiesInventario OEntInventario = new EntitiesInventario();


                var select = from q in OEntInventario.in_transferencia_det
                             where q.IdEmpresa == idEmpresa 
                             && q.IdSucursalOrigen == IdSucursal
                             && q.IdBodegaOrigen == IdBodega
                             && q.IdTransferencia == IdTransferencia
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_det_Info info = new in_transferencia_det_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdTransferencia = item.IdTransferencia;
                    info.dt_secuencia = item.dt_secuencia;
                    info.IdProducto = item.IdProducto;
                    info.dt_cantidad = item.dt_cantidad;
                    info.tr_Observacion = item.tr_Observacion;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                    info.IdPunto_cargo = item.IdPunto_cargo;
                    dats.Add(info);
                }

                return dats;
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

        public bool ModificarDB(in_transferencia_Info info)
        {
            try
            {
                try
                {                
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var contac = Contex.in_transferencia.FirstOrDefault(Obj => Obj.IdTransferencia == info.IdTransferencia && Obj.IdSucursalOrigen == info.IdSucursalOrigen && Obj.IdBodegaOrigen == info.IdBodegaOrigen && Obj.IdEmpresa == info.IdEmpresa);
                    if (contac != null)
                    {
                        contac.tr_Observacion = info.tr_Observacion;
                        contac.Codigo = info.Codigo;
                        contac.IdBodegaDest = info.IdBodegaDest;
                        contac.IdSucursalDest = info.IdSucursalDest;
                        contac.tr_fecha = info.tr_fecha;
                        contac.IdEstadoAprobacion_cat = info.IdEstadoAprobacion_cat;

                        Contex.SaveChanges();

                        #region DetalleTransferencia
                        //GRABAR EL DETALLE DE LA TRANSFERENCIA
                        int c = 1;
                        odata_trans_x_guia.EliminarDB(info);
                        EliminarDetalle(info);
                        foreach (var item in info.lista_detalle_transferencia)
                        {
                            var addressDeta = new in_transferencia_det();
                            addressDeta.IdEmpresa = info.IdEmpresa;
                            addressDeta.IdSucursalOrigen = info.IdSucursalOrigen;
                            addressDeta.IdTransferencia = info.IdTransferencia;
                            addressDeta.IdBodegaOrigen = info.IdBodegaOrigen;
                            addressDeta.IdProducto = item.IdProducto;
                            addressDeta.dt_cantidad = item.dt_cantidad;
                            addressDeta.IdUnidadMedida = item.IdUnidadMedida;
                            addressDeta.tr_Observacion = item.tr_Observacion;
                            addressDeta.IdCentroCosto = item.IdCentroCosto;
                            addressDeta.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            addressDeta.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            addressDeta.IdPunto_cargo = item.IdPunto_cargo;
                            addressDeta.dt_secuencia = item.dt_secuencia = c;
                            c++;
                            Contex.in_transferencia_det.Add(addressDeta);
                            Contex.SaveChanges();
                        }
                        foreach (var item in info.lista_detalle_transferencia)
                        {
                            if (item.Info_Guia_x_traspaso_bodega_det.IdEmpresa != 0)
                            {
                                in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info info_det_trans_x_guia = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Info();
                                info_det_trans_x_guia.IdEmpresa_trans = info.IdEmpresa;
                                info_det_trans_x_guia.IdSucursalOrigen_trans = info.IdSucursalOrigen;
                                info_det_trans_x_guia.IdBodegaOrigen_trans = info.IdBodegaOrigen;
                                info_det_trans_x_guia.IdTransferencia_trans = info.IdTransferencia;
                                info_det_trans_x_guia.Secuencia_trans = item.dt_secuencia;

                                info_det_trans_x_guia.IdEmpresa_guia = item.Info_Guia_x_traspaso_bodega_det.IdEmpresa;
                                info_det_trans_x_guia.IdGuia_guia = item.Info_Guia_x_traspaso_bodega_det.IdGuia;
                                info_det_trans_x_guia.Secuencia_guia = item.Info_Guia_x_traspaso_bodega_det.secuencia;
                                odata_trans_x_guia.GuardarDB(info_det_trans_x_guia);
                            }
                        }
                        #endregion
                    }
                }

                return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        foreach (var item_validaciones in item.ValidationErrors)
                        {
                            mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                        }
                    }
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    throw new Exception(mensaje);
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
        
        public Boolean Actualizardetalle(List<in_transferencia_det_Info> listDetalle, in_transferencia_Info info)
        {
            try
            {

                int c = 1;
                using (EntitiesInventario contexDeta = new EntitiesInventario())
                {
                    foreach (var item in listDetalle)
                    {
                        var addressDeta = new in_transferencia_det();

                        addressDeta.IdEmpresa = item.IdEmpresa;
                        
                        addressDeta.IdSucursalOrigen = info.IdSucursalOrigen;
                        addressDeta.IdTransferencia = info.IdTransferencia;
                        addressDeta.IdBodegaOrigen = info.IdBodegaOrigen;
                        addressDeta.IdProducto = item.IdProducto;
                        
                        addressDeta.dt_cantidad = item.dt_cantidad;
                        addressDeta.IdCentroCosto = item.IdCentroCosto;
                        addressDeta.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        addressDeta.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        addressDeta.IdPunto_cargo = item.IdPunto_cargo;
                        addressDeta.tr_Observacion = item.tr_Observacion;
                        addressDeta.dt_secuencia = c;
                        c++;
                        contexDeta.in_transferencia_det.Add(addressDeta);
                        contexDeta.SaveChanges();
                    }
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
        
        public void EliminarDetalle(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    string comando = "DELETE in_transferencia_det WHERE IdEmpresa = "+info.IdEmpresa+" and IdSucursalOrigen = "+info.IdSucursalOrigen+" and IdBodegaOrigen = "+info.IdBodegaOrigen+" and IdTransferencia = "+info.IdTransferencia;
                    Contex.Database.ExecuteSqlCommand(comando);
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

        public List<in_transferencia_Info> Get_List_transferencia(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursal, int IdBodega)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();

                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.vwin_Transferencias
                             where q.IdEmpresa == IdEmpresa && q.IdSucursalOrigen == IdSucursal && q.IdBodegaOrigen == IdBodega
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin
                             orderby q.IdEmpresa,q.tr_fecha
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_Info info = new in_transferencia_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTransferencia = item.IdTransferencia;
                    info.tr_fecha = item.tr_fecha;
                    info.Estado = item.Estado;
                    info.Bodega_Destino = item.BodegDest;
                    info.Bodega_Origen = item.BodegaORIG;
                    info.Sucursal_Destino = item.SucuDEST;
                    info.Sucursal_Origen = item.SucuOrigen;
                    info.tr_fechaAnulacion = item.tr_fechaAnulacion;
                    info.tr_Observacion = item.tr_Observacion;
                    info.IdBodegaDest = item.IdBodegaDest;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdSucursalDest = item.IdSucursalDest;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.Codigo = item.Codigo;
                    info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    info.EstadoAprobacion_cat = item.EstadoAprobacion_cat;
                    info.IdMovi_inven_tipo_SucuDest = Convert.ToInt32(item.IdMovi_inven_tipo_SucuDest);
                    info.IdMovi_inven_tipo_SucuOrig = Convert.ToInt32(item.IdMovi_inven_tipo_SucuOrig);
                    lst.Add(info);
                }

                return lst;
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
        
        public Boolean Anular(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var contac = Contex.in_transferencia.FirstOrDefault(Obj => Obj.IdTransferencia == info.IdTransferencia && Obj.IdEmpresa == info.IdEmpresa && Obj.IdBodegaOrigen == info.IdBodegaOrigen && Obj.IdSucursalOrigen == info.IdSucursalOrigen);
                    if (contac != null)
                    {
                        contac.Estado = "I";
                        contac.tr_fechaAnulacion = DateTime.Now;
                        contac.tr_userAnulo = info.tr_userAnulo;
                        contac.motivo_anula = info.MotivoAnu;
                        contac.nom_pc = info.nom_pc;
                        contac.ip = info.ip;
                        contac.IdEstadoAprobacion_cat = "REP";
                        contac.tr_Observacion = "**Anulado**" + contac.tr_Observacion;
                        Contex.SaveChanges();
                    }
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

        public decimal Get_Id_NumMoviInven(int idEmpresa, int idSucursal, int Idbodega, int idtipomovi)
        {
            try
            {
                decimal id;
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    EntitiesInventario oEInventario = new EntitiesInventario();

                    var select = from q in oEInventario.in_movi_inve
                                 where q.IdEmpresa == idEmpresa 
                                 && q.IdBodega == Idbodega
                                 && q.IdSucursal == idSucursal
                                 && q.IdMovi_inven_tipo == idtipomovi
                                 select q;

                    if (select.ToList().Count == 0)
                    {
                        return 1;
                    }

                    var max = (from q in oEInventario.in_movi_inve
                               where q.IdEmpresa == idEmpresa 
                               && q.IdBodega == Idbodega
                               && q.IdSucursal == idSucursal 
                               && q.IdMovi_inven_tipo == idtipomovi
                               select q).Max();
                    id = Convert.ToDecimal(max.ToString()) + 1;
                    return id;
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
        
        public bool Modificar_IdMovi_Inven_x_Transf(in_transferencia_Info info_transferencia, int IdEmpresa_Ing_Egr_Inven_Origen, int IdSucursal_Ing_Egr_Inven_Origen, decimal IdNumMovi_Ing_Egr_Inven_Origen
            , int IdEmpresa_Ing_Egr_Inven_Destino, int IdSucursal_Ing_Egr_Inven_Destino, decimal IdNumMovi_Ing_Egr_Inven_Destino)
        {
            try
            {
                using (EntitiesInventario Contex = new EntitiesInventario())
                {
                    var contac = Contex.in_transferencia.FirstOrDefault(q => q.IdEmpresa == info_transferencia.IdEmpresa && q.IdSucursalOrigen == info_transferencia.IdSucursalOrigen && q.IdBodegaOrigen == info_transferencia.IdBodegaOrigen && q.IdTransferencia == info_transferencia.IdTransferencia);
                    if (contac != null)
                    {
                        contac.IdEmpresa_Ing_Egr_Inven_Origen = IdEmpresa_Ing_Egr_Inven_Origen;
                        contac.IdSucursal_Ing_Egr_Inven_Origen = IdSucursal_Ing_Egr_Inven_Origen;
                        contac.IdNumMovi_Ing_Egr_Inven_Origen = IdNumMovi_Ing_Egr_Inven_Origen;
                        contac.IdEmpresa_Ing_Egr_Inven_Destino = IdEmpresa_Ing_Egr_Inven_Destino;
                        contac.IdSucursal_Ing_Egr_Inven_Destino = IdSucursal_Ing_Egr_Inven_Destino;
                        contac.IdNumMovi_Ing_Egr_Inven_Destino = IdNumMovi_Ing_Egr_Inven_Destino;
                        Contex.SaveChanges();
                    }
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

        public List<in_transferencia_Info> Get_List_transferencia(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursalIni,int idSucursalFin, int IdBodegaIni, int idBodegaFin)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();

                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.vwin_Transferencias
                             where q.IdEmpresa == IdEmpresa 
                             && IdSucursalIni<= q.IdSucursalOrigen && q.IdSucursalOrigen <= idSucursalFin
                             && IdBodegaIni <= q.IdBodegaOrigen && q.IdBodegaOrigen<=idBodegaFin
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin
                             orderby q.IdEmpresa, q.tr_fecha
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_Info info = new in_transferencia_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTransferencia = item.IdTransferencia;
                    info.tr_fecha = item.tr_fecha;
                    info.Estado = item.Estado;
                    info.Bodega_Destino = item.BodegDest;
                    info.Bodega_Origen = item.BodegaORIG;
                    info.Sucursal_Destino = item.SucuDEST;
                    info.Sucursal_Origen = item.SucuOrigen;
                    info.tr_fechaAnulacion = item.tr_fechaAnulacion;
                    info.tr_Observacion = item.tr_Observacion;
                    info.IdBodegaDest = item.IdBodegaDest;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdSucursalDest = item.IdSucursalDest;                    
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.Codigo = item.Codigo;
                    info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    info.EstadoAprobacion_cat = item.EstadoAprobacion_cat;
                    info.IdEmpresa_Ing_Egr_Inven_Destino = item.IdEmpresa_Ing_Egr_Inven_Destino;
                    info.IdEmpresa_Ing_Egr_Inven_Origen = item.IdEmpresa_Ing_Egr_Inven_Origen;
                    info.IdSucursal_Ing_Egr_Inven_Destino = item.IdSucursal_Ing_Egr_Inven_Destino;
                    info.IdSucursal_Ing_Egr_Inven_Origen = item.IdSucursal_Ing_Egr_Inven_Origen;
                    info.IdMovi_inven_tipo_SucuDest = Convert.ToInt32(item.IdMovi_inven_tipo_SucuDest);
                    info.IdMovi_inven_tipo_SucuOrig = Convert.ToInt32(item.IdMovi_inven_tipo_SucuOrig);
                    info.IdNumMovi_Ing_Egr_Inven_Destino = item.IdNumMovi_Ing_Egr_Inven_Destino;
                    info.IdNumMovi_Ing_Egr_Inven_Origen = item.IdNumMovi_Ing_Egr_Inven_Origen;
                    info.IdEstadoAproba_egr = item.IdEstadoAproba_egr;
                    info.IdEstadoAproba_ing = item.IdEstadoAproba_ing;
                    lst.Add(info);
                }

                return lst;
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
        
        public List<in_transferencia_Info> Get_List_transferencia(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursal)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();

                EntitiesInventario OEInventario = new EntitiesInventario();
                var select = from q in OEInventario.vwin_Transferencias
                             where q.IdEmpresa == IdEmpresa 
                             && q.IdSucursalOrigen == IdSucursal
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin
                             orderby q.IdEmpresa, q.tr_fecha
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_Info info = new in_transferencia_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdTransferencia = item.IdTransferencia;
                    info.tr_fecha = item.tr_fecha;
                    info.Estado = item.Estado;
                    info.Bodega_Destino = item.BodegDest;
                    info.Bodega_Origen = item.BodegaORIG;
                    info.Sucursal_Destino = item.SucuDEST;
                    info.Sucursal_Origen = item.SucuOrigen;
                    info.tr_fechaAnulacion = item.tr_fechaAnulacion;
                    info.tr_Observacion = item.tr_Observacion;
                    info.IdBodegaDest = item.IdBodegaDest;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdSucursalDest = item.IdSucursalDest;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.Codigo = item.Codigo;
                    info.IdEstadoAprobacion_cat = item.IdEstadoAprobacion_cat;
                    info.EstadoAprobacion_cat = item.EstadoAprobacion_cat;
                    info.IdMovi_inven_tipo_SucuDest = Convert.ToInt32(item.IdMovi_inven_tipo_SucuDest);
                    info.IdMovi_inven_tipo_SucuOrig = Convert.ToInt32(item.IdMovi_inven_tipo_SucuOrig);
                    lst.Add(info);
                }

                return lst;
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
        
        public List<in_transferencia_det_Info> Get_List_transferencia_det_sin_Guia(in_transferencia_Info Info, int idEmpresa)
        {
            try
            {
                List<in_transferencia_det_Info> lst = new List<in_transferencia_det_Info>();

                EntitiesInventario Oentities = new EntitiesInventario();
                var select = from q in Oentities.vwin_Transferencia_sin_guia
                             where q.IdEmpresa == idEmpresa
                             && q.IdTransferencia == Info.IdTransferencia
                             && q.IdBodegaOrigen == Info.IdBodegaOrigen
                             && q.IdSucursalOrigen == Info.IdSucursalOrigen
                             select q;

                foreach (var item in select)
                {
                    in_transferencia_det_Info info = new in_transferencia_det_Info();

                    info.IdProducto = item.IdProducto;
                    info.IdProducto = item.IdProducto;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdTransferencia = item.IdTransferencia;
                    info.tr_Observacion = item.tr_Observacion;
                    info.dt_secuencia = item.dt_secuencia;
                    info.dt_cantidad = item.dt_cantidad;
                    info.pr_descripcion = item.pr_descripcion;
                    info.IdBodegaOrigen = item.IdBodegaOrigen;
                    info.IdSucursalOrigen = item.IdSucursalOrigen;
                 
                    lst.Add(info); 
                }

                return lst;
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

        public List<in_transferencia_Info> Get_List_transferencias_para_recosteo(int IdEmpresa, DateTime Fecha_ini)
        {
            try
            {
                List<in_transferencia_Info> Lista = new List<in_transferencia_Info>();

                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    var lst = from q in Context.vwin_transferencia_x_in_movi_inve_agrupada_para_recosteo
                              where q.IdEmpresa == IdEmpresa
                              && q.tr_fecha >= Fecha_ini
                              group q by new { q.IdEmpresa, q.IdSucursalOrigen, q.cod_sucursal, q.nom_sucursal , q.IdBodegaOrigen, q.cod_bodega, q.nom_bodega, q.tr_fecha }
                                  into Lista_agrupada
                                  orderby Lista_agrupada.Key.IdEmpresa, Lista_agrupada.Key.tr_fecha, Lista_agrupada.Key.IdSucursalOrigen, Lista_agrupada.Key.IdBodegaOrigen
                                  select new
                                  {
                                      Lista_agrupada.Key.IdEmpresa,
                                      Lista_agrupada.Key.IdSucursalOrigen,
                                      Lista_agrupada.Key.cod_sucursal,
                                      Lista_agrupada.Key.nom_sucursal,
                                      Lista_agrupada.Key.IdBodegaOrigen,
                                      Lista_agrupada.Key.cod_bodega,
                                      Lista_agrupada.Key.nom_bodega,
                                      Lista_agrupada.Key.tr_fecha
                                  };

                    foreach (var item in lst)
                    {
                        in_transferencia_Info info = new in_transferencia_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursalOrigen = item.IdSucursalOrigen;
                        info.Sucursal_Origen = "["+item.cod_sucursal+"] "+item.nom_sucursal;
                        info.IdBodegaOrigen = item.IdBodegaOrigen;
                        info.Bodega_Origen = "[" + item.cod_bodega + "] " + item.nom_bodega;
                        info.tr_fecha = item.tr_fecha;

                        Lista.Add(info);
                    }
                }

                return Lista;
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
