using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace Core.Erp.Data.Inventario
{
    public class in_transferencia_Data
    {
        public decimal _idEgresoMOvi { get; set; }
        public decimal _idIngreso { get; set; }
        in_movi_inve_Data idData = new in_movi_inve_Data();
        in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data odata_trans_x_guia = new in_transferencia_det_x_in_Guia_x_traspaso_bodega_det_Data();
        string mensaje = "";
        in_Guia_x_traspaso_bodega_Data odataGuia = new in_Guia_x_traspaso_bodega_Data();
        tb_sis_Documento_Tipo_Talonario_Data odataTalonario = new tb_sis_Documento_Tipo_Talonario_Data();
        List<in_movi_inve_detalle_Info> listDetalleMoviInvenEgreso = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_Info> listDetalleMoviInvenIngreso = new List<in_movi_inve_detalle_Info>();
        in_producto_x_tb_bodega_Data oProxBodData = new in_producto_x_tb_bodega_Data();
        in_Ing_Egr_Inven_Data odataIngEgr = new in_Ing_Egr_Inven_Data();
        in_UnidadMedida_Data odataUnidadMedida = new in_UnidadMedida_Data();

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

        public in_transferencia_Info Get_Info_transferencia(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdTransferencia)
        {
            try
            {
                in_transferencia_Info Info = new in_transferencia_Info();

                EntitiesInventario OEInventario = new EntitiesInventario();
                var Entity = OEInventario.in_transferencia.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursalOrigen == IdSucursal && q.IdBodegaOrigen == IdBodega && q.IdTransferencia == IdTransferencia).FirstOrDefault();

                Info = new in_transferencia_Info
                {
                    IdEmpresa = Entity.IdEmpresa,
                    IdSucursalOrigen = Entity.IdSucursalOrigen,
                    IdBodegaOrigen = Entity.IdBodegaOrigen,
                    IdTransferencia = Entity.IdTransferencia,
                    IdSucursalDest = Entity.IdSucursalDest,
                    IdBodegaDest = Entity.IdBodegaDest,
                    tr_Observacion = Entity.tr_Observacion,
                    tr_fecha = Entity.tr_fecha,
                    Estado = Entity.Estado,
                    IdEmpresa_Ing_Egr_Inven_Origen = Entity.IdEmpresa_Ing_Egr_Inven_Origen,
                    IdSucursal_Ing_Egr_Inven_Origen = Entity.IdSucursal_Ing_Egr_Inven_Origen,
                    IdMovi_inven_tipo_SucuOrig = Entity.IdMovi_inven_tipo_SucuOrig,
                    IdNumMovi_Ing_Egr_Inven_Origen = Entity.IdNumMovi_Ing_Egr_Inven_Origen,

                    IdEmpresa_Ing_Egr_Inven_Destino = Entity.IdEmpresa_Ing_Egr_Inven_Destino,
                    IdMovi_inven_tipo_SucuDest = Entity.IdMovi_inven_tipo_SucuDest,
                    IdSucursal_Ing_Egr_Inven_Destino = Entity.IdSucursal_Ing_Egr_Inven_Destino,
                    IdNumMovi_Ing_Egr_Inven_Destino = Entity.IdNumMovi_Ing_Egr_Inven_Destino,

                    Codigo = Entity.Codigo,
                    IdGuia = Entity.IdGuia,
                    EstadoRevision = Entity.EstadoRevision
                };

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
                    string comando = "DELETE in_transferencia_det WHERE IdEmpresa = " + info.IdEmpresa + " and IdSucursalOrigen = " + info.IdSucursalOrigen + " and IdBodegaOrigen = " + info.IdBodegaOrigen + " and IdTransferencia = " + info.IdTransferencia;
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
                var select = OEInventario.vwin_Transferencias.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursalOrigen == IdSucursal && q.IdBodegaOrigen == IdBodega
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin).OrderBy(q => q.IdEmpresa).ThenBy(q => q.tr_fecha).ToList();

                foreach (var item in select)
                {
                    in_transferencia_Info info = new in_transferencia_Info
                    {
                        IdEmpresa = item.IdEmpresa,
                        IdTransferencia = item.IdTransferencia,
                        tr_fecha = item.tr_fecha,
                        Estado = item.Estado,
                        Bodega_Destino = item.BodegDest,
                        Bodega_Origen = item.BodegaORIG,
                        Sucursal_Destino = item.SucuDEST,
                        Sucursal_Origen = item.SucuOrigen,
                        tr_fechaAnulacion = item.tr_fechaAnulacion,
                        tr_Observacion = item.tr_Observacion,
                        IdBodegaDest = item.IdBodegaDest,
                        IdBodegaOrigen = item.IdBodegaOrigen,
                        IdSucursalDest = item.IdSucursalDest,
                        IdSucursalOrigen = item.IdSucursalOrigen,
                        Codigo = item.Codigo,
                        IdMovi_inven_tipo_SucuDest = item.IdMovi_inven_tipo_SucuDest,
                        IdMovi_inven_tipo_SucuOrig = item.IdMovi_inven_tipo_SucuOrig,
                        EstadoRevision = item.EstadoRevision,
                    };
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

        public List<in_transferencia_Info> Get_List_transferencia(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int IdSucursalIni, int idSucursalFin, int IdBodegaIni, int idBodegaFin)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT        so.Su_Descripcion AS SucuOrigen, bo.bo_Descripcion AS BodegaORIG, sd.Su_Descripcion AS SucuDEST, bd.bo_Descripcion AS BodegDest, t.IdEmpresa, t.IdSucursalOrigen, t.IdBodegaOrigen, t.IdTransferencia, "
                                + " t.IdSucursalDest, t.IdBodegaDest, t.tr_Observacion, t.tr_fecha, t.Estado, t.IdUsuario, t.IdEmpresa_Ing_Egr_Inven_Origen, t.IdSucursal_Ing_Egr_Inven_Origen, t.IdNumMovi_Ing_Egr_Inven_Origen, "
                                + " t.IdEmpresa_Ing_Egr_Inven_Destino, t.IdSucursal_Ing_Egr_Inven_Destino, t.IdNumMovi_Ing_Egr_Inven_Destino, t.tr_fechaAnulacion, t.tr_userAnulo, t.Codigo, t.IdMovi_inven_tipo_SucuOrig, t.IdMovi_inven_tipo_SucuDest, "
                                + " MIN(id.IdEstadoAproba) AS IdEstadoAproba_ing, MIN(ED.IdEstadoAproba) AS IdEstadoAproba_egr, t.IdGuia, t.EstadoRevision, t.IdUsuarioRevision, t.FechaRevision, isnull(t.TuvoError, cast(0 as bit)) TuvoError, isnull(t.TuvoErrorDespacho,cast(0 as bit))TuvoErrorDespacho"
                                + " FROM            dbo.in_Ing_Egr_Inven_det AS ED INNER JOIN"
                                + " dbo.in_Ing_Egr_Inven AS e ON ED.IdEmpresa = e.IdEmpresa AND ED.IdSucursal = e.IdSucursal AND ED.IdMovi_inven_tipo = e.IdMovi_inven_tipo AND ED.IdNumMovi = e.IdNumMovi RIGHT OUTER JOIN"
                                + " dbo.in_Ing_Egr_Inven AS i INNER JOIN"
                                + " dbo.in_Ing_Egr_Inven_det AS id ON i.IdEmpresa = id.IdEmpresa AND i.IdSucursal = id.IdSucursal AND i.IdMovi_inven_tipo = id.IdMovi_inven_tipo AND i.IdNumMovi = id.IdNumMovi RIGHT OUTER JOIN"
                                + " dbo.tb_bodega AS bd INNER JOIN"
                                + " dbo.tb_sucursal AS sd ON bd.IdEmpresa = sd.IdEmpresa AND bd.IdSucursal = sd.IdSucursal INNER JOIN"
                                + " dbo.in_transferencia AS t INNER JOIN"
                                + " dbo.tb_bodega AS bo ON t.IdEmpresa = bo.IdEmpresa AND t.IdBodegaOrigen = bo.IdBodega AND t.IdSucursalOrigen = bo.IdSucursal INNER JOIN"
                                + " dbo.tb_sucursal AS so ON bo.IdEmpresa = so.IdEmpresa AND bo.IdSucursal = so.IdSucursal ON bd.IdEmpresa = t.IdEmpresa AND bd.IdBodega = t.IdBodegaDest AND bd.IdSucursal = t.IdSucursalDest ON "
                                + " i.IdEmpresa = t.IdEmpresa_Ing_Egr_Inven_Destino AND i.IdSucursal = t.IdSucursal_Ing_Egr_Inven_Destino AND i.IdMovi_inven_tipo = t.IdMovi_inven_tipo_SucuDest AND i.IdNumMovi = t.IdNumMovi_Ing_Egr_Inven_Destino ON"
                                + " e.IdEmpresa = t.IdEmpresa_Ing_Egr_Inven_Origen AND e.IdSucursal = t.IdSucursal_Ing_Egr_Inven_Origen AND e.IdMovi_inven_tipo = t.IdMovi_inven_tipo_SucuOrig AND "
                                + " e.IdNumMovi = t.IdNumMovi_Ing_Egr_Inven_Origen"
                                + " where t.IdEmpresa = " + IdEmpresa.ToString() + " and t.IdSucursalOrigen = " + idSucursalFin.ToString()
                                + " and t.tr_fecha between DATEFROMPARTS(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ")  AND DATEFROMPARTS(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ")"
                                + " GROUP BY so.Su_Descripcion, bo.bo_Descripcion, sd.Su_Descripcion, bd.bo_Descripcion, t.IdEmpresa, t.IdSucursalOrigen, t.IdBodegaOrigen, t.IdTransferencia, t.IdSucursalDest, t.IdBodegaDest, t.tr_Observacion, t.tr_fecha, t.Estado, "
                                + " t.IdUsuario, t.IdEmpresa_Ing_Egr_Inven_Origen, t.IdSucursal_Ing_Egr_Inven_Origen, t.IdNumMovi_Ing_Egr_Inven_Origen, t.IdEmpresa_Ing_Egr_Inven_Destino, t.IdSucursal_Ing_Egr_Inven_Destino, "
                                + " t.IdNumMovi_Ing_Egr_Inven_Destino, t.tr_fechaAnulacion, t.tr_userAnulo, t.Codigo, t.IdMovi_inven_tipo_SucuOrig, t.IdMovi_inven_tipo_SucuDest, t.IdGuia, t.EstadoRevision, t.IdUsuarioRevision, t.FechaRevision, t.TuvoError, "
                                + " t.TuvoErrorDespacho";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lst.Add(new in_transferencia_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdTransferencia = Convert.ToDecimal(reader["IdTransferencia"]),
                            tr_fecha = Convert.ToDateTime(reader["tr_fecha"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            Bodega_Destino = Convert.ToString(reader["BodegDest"]),
                            Bodega_Origen = Convert.ToString(reader["BodegaORIG"]),
                            Sucursal_Destino = Convert.ToString(reader["SucuDEST"]),
                            Sucursal_Origen = Convert.ToString(reader["SucuOrigen"]),
                            tr_Observacion = Convert.ToString(reader["tr_Observacion"]),
                            IdBodegaDest = Convert.ToInt32(reader["IdBodegaDest"]),
                            IdBodegaOrigen = Convert.ToInt32(reader["IdBodegaOrigen"]),
                            IdSucursalDest = Convert.ToInt32(reader["IdSucursalDest"]),
                            IdSucursalOrigen = Convert.ToInt32(reader["IdSucursalOrigen"]),
                            Codigo = Convert.ToString(reader["Codigo"]),
                            IdEmpresa_Ing_Egr_Inven_Destino = string.IsNullOrEmpty(reader["IdEmpresa_Ing_Egr_Inven_Destino"].ToString()) ? null : (int?)(reader["IdEmpresa_Ing_Egr_Inven_Destino"]),
                            IdEmpresa_Ing_Egr_Inven_Origen = string.IsNullOrEmpty(reader["IdEmpresa_Ing_Egr_Inven_Origen"].ToString()) ? null : (int?)(reader["IdEmpresa_Ing_Egr_Inven_Origen"]),
                            IdSucursal_Ing_Egr_Inven_Destino = string.IsNullOrEmpty(reader["IdSucursal_Ing_Egr_Inven_Destino"].ToString()) ? null : (int?)(reader["IdSucursal_Ing_Egr_Inven_Destino"]),
                            IdSucursal_Ing_Egr_Inven_Origen = string.IsNullOrEmpty(reader["IdSucursal_Ing_Egr_Inven_Origen"].ToString()) ? null : (int?)(reader["IdSucursal_Ing_Egr_Inven_Origen"]),
                            IdMovi_inven_tipo_SucuDest = string.IsNullOrEmpty(reader["IdMovi_inven_tipo_SucuDest"].ToString()) ? null : (int?)(reader["IdMovi_inven_tipo_SucuDest"]),
                            IdMovi_inven_tipo_SucuOrig = string.IsNullOrEmpty(reader["IdMovi_inven_tipo_SucuOrig"].ToString()) ? null : (int?)(reader["IdMovi_inven_tipo_SucuOrig"]),
                            IdNumMovi_Ing_Egr_Inven_Destino = string.IsNullOrEmpty(reader["IdNumMovi_Ing_Egr_Inven_Destino"].ToString()) ? null : (decimal?)(reader["IdNumMovi_Ing_Egr_Inven_Destino"]),
                            IdNumMovi_Ing_Egr_Inven_Origen = string.IsNullOrEmpty(reader["IdNumMovi_Ing_Egr_Inven_Origen"].ToString()) ? null : (decimal?)(reader["IdNumMovi_Ing_Egr_Inven_Origen"]),
                            IdEstadoAproba_egr = Convert.ToString(reader["IdEstadoAproba_egr"]),
                            IdEstadoAproba_ing = Convert.ToString(reader["IdEstadoAproba_ing"]),
                            IdUsuario = Convert.ToString(reader["IdUsuario"]),
                            IdGuia = string.IsNullOrEmpty(reader["IdGuia"].ToString()) ? null : (decimal?)(reader["IdGuia"]),
                            EstadoRevision = Convert.ToString(reader["EstadoRevision"]),
                            TuvoError = Convert.ToBoolean(reader["TuvoError"]),
                            TuvoErrorDespacho = Convert.ToBoolean(reader["TuvoErrorDespacho"])
                        });
                    }
                    reader.Close();
                }
                /*
                EntitiesInventario OEInventario = new EntitiesInventario();


                var lstX = OEInventario.vwin_Transferencias.Where(q => q.IdEmpresa == IdEmpresa
                             && IdSucursalIni <= q.IdSucursalOrigen && q.IdSucursalOrigen <= idSucursalFin
                             && IdBodegaIni <= q.IdBodegaOrigen && q.IdBodegaOrigen <= idBodegaFin
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin).OrderBy(
                             q => q.tr_fecha).ToList();
                foreach (var q in lstX)
                {
                    lst.Add(new in_transferencia_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdTransferencia = q.IdTransferencia,
                        tr_fecha = q.tr_fecha,
                        Estado = q.Estado,
                        Bodega_Destino = q.BodegDest,
                        Bodega_Origen = q.BodegaORIG,
                        Sucursal_Destino = q.SucuDEST,
                        Sucursal_Origen = q.SucuOrigen,
                        tr_fechaAnulacion = q.tr_fechaAnulacion,
                        tr_Observacion = q.tr_Observacion,
                        IdBodegaDest = q.IdBodegaDest,
                        IdBodegaOrigen = q.IdBodegaOrigen,
                        IdSucursalDest = q.IdSucursalDest,
                        IdSucursalOrigen = q.IdSucursalOrigen,
                        Codigo = q.Codigo,
                        IdEmpresa_Ing_Egr_Inven_Destino = q.IdEmpresa_Ing_Egr_Inven_Destino,
                        IdEmpresa_Ing_Egr_Inven_Origen = q.IdEmpresa_Ing_Egr_Inven_Origen,
                        IdSucursal_Ing_Egr_Inven_Destino = q.IdSucursal_Ing_Egr_Inven_Destino,
                        IdSucursal_Ing_Egr_Inven_Origen = q.IdSucursal_Ing_Egr_Inven_Origen,
                        IdMovi_inven_tipo_SucuDest = q.IdMovi_inven_tipo_SucuDest,
                        IdMovi_inven_tipo_SucuOrig = q.IdMovi_inven_tipo_SucuOrig,
                        IdNumMovi_Ing_Egr_Inven_Destino = q.IdNumMovi_Ing_Egr_Inven_Destino,
                        IdNumMovi_Ing_Egr_Inven_Origen = q.IdNumMovi_Ing_Egr_Inven_Origen,
                        IdEstadoAproba_egr = q.IdEstadoAproba_egr,
                        IdEstadoAproba_ing = q.IdEstadoAproba_ing,
                        IdUsuario = q.IdUsuario,
                        IdGuia = q.IdGuia,
                        EstadoRevision = q.EstadoRevision,
                        TuvoError = q.TuvoError ?? false,
                        TuvoErrorDespacho = q.TuvoErrorDespacho ?? false
                    });
                }
                

                */
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

        public List<in_transferencia_Info> Get_List_transferenciaParaRevision(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string EstadoRevision)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                EntitiesInventario OEInventario = new EntitiesInventario();
                lst = OEInventario.vwin_Transferencias_ParaProcesar.Where(q => q.IdEmpresa == IdEmpresa
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin && q.EstadoRevision == EstadoRevision).OrderBy(
                             q => q.tr_fecha).Select(q => new in_transferencia_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTransferencia = q.IdTransferencia,
                                 tr_fecha = q.tr_fecha,
                                 Estado = q.Estado,
                                 Bodega_Destino = q.BodegDest,
                                 Bodega_Origen = q.BodegaORIG,
                                 Sucursal_Destino = q.SucuDEST,
                                 Sucursal_Origen = q.SucuOrigen,
                                 tr_fechaAnulacion = q.tr_fechaAnulacion,
                                 tr_Observacion = q.tr_Observacion,
                                 IdBodegaDest = q.IdBodegaDest,
                                 IdBodegaOrigen = q.IdBodegaOrigen,
                                 IdSucursalDest = q.IdSucursalDest,
                                 IdSucursalOrigen = q.IdSucursalOrigen,
                                 Codigo = q.Codigo,
                                 IdEmpresa_Ing_Egr_Inven_Destino = q.IdEmpresa_Ing_Egr_Inven_Destino,
                                 IdEmpresa_Ing_Egr_Inven_Origen = q.IdEmpresa_Ing_Egr_Inven_Origen,
                                 IdSucursal_Ing_Egr_Inven_Destino = q.IdSucursal_Ing_Egr_Inven_Destino,
                                 IdSucursal_Ing_Egr_Inven_Origen = q.IdSucursal_Ing_Egr_Inven_Origen,
                                 IdMovi_inven_tipo_SucuDest = q.IdMovi_inven_tipo_SucuDest,
                                 IdMovi_inven_tipo_SucuOrig = q.IdMovi_inven_tipo_SucuOrig,
                                 IdNumMovi_Ing_Egr_Inven_Destino = q.IdNumMovi_Ing_Egr_Inven_Destino,
                                 IdNumMovi_Ing_Egr_Inven_Origen = q.IdNumMovi_Ing_Egr_Inven_Origen,
                                 IdEstadoAproba_egr = q.IdEstadoAproba_egr,
                                 IdEstadoAproba_ing = q.IdEstadoAproba_ing,
                                 IdUsuario = q.IdUsuario,
                                 IdGuia = q.IdGuia,
                                 EstadoRevision = q.EstadoRevision
                             }).ToList();


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

        public List<in_transferencia_Info> Get_List_transferenciaRevisar(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_transferencia_Info> lst = new List<in_transferencia_Info>();
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                EntitiesInventario OEInventario = new EntitiesInventario();
                lst = OEInventario.vwin_Transferencias.Where(q => q.IdEmpresa == IdEmpresa
                             && q.tr_fecha >= FechaIni && q.tr_fecha <= FechaFin).OrderBy(
                             q => q.tr_fecha).Select(q => new in_transferencia_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTransferencia = q.IdTransferencia,
                                 tr_fecha = q.tr_fecha,
                                 Estado = q.Estado,
                                 Bodega_Destino = q.BodegDest,
                                 Bodega_Origen = q.BodegaORIG,
                                 Sucursal_Destino = q.SucuDEST,
                                 Sucursal_Origen = q.SucuOrigen,
                                 tr_fechaAnulacion = q.tr_fechaAnulacion,
                                 tr_Observacion = q.tr_Observacion,
                                 IdBodegaDest = q.IdBodegaDest,
                                 IdBodegaOrigen = q.IdBodegaOrigen,
                                 IdSucursalDest = q.IdSucursalDest,
                                 IdSucursalOrigen = q.IdSucursalOrigen,
                                 Codigo = q.Codigo,
                                 IdEmpresa_Ing_Egr_Inven_Destino = q.IdEmpresa_Ing_Egr_Inven_Destino,
                                 IdEmpresa_Ing_Egr_Inven_Origen = q.IdEmpresa_Ing_Egr_Inven_Origen,
                                 IdSucursal_Ing_Egr_Inven_Destino = q.IdSucursal_Ing_Egr_Inven_Destino,
                                 IdSucursal_Ing_Egr_Inven_Origen = q.IdSucursal_Ing_Egr_Inven_Origen,
                                 IdMovi_inven_tipo_SucuDest = q.IdMovi_inven_tipo_SucuDest,
                                 IdMovi_inven_tipo_SucuOrig = q.IdMovi_inven_tipo_SucuOrig,
                                 IdNumMovi_Ing_Egr_Inven_Destino = q.IdNumMovi_Ing_Egr_Inven_Destino,
                                 IdNumMovi_Ing_Egr_Inven_Origen = q.IdNumMovi_Ing_Egr_Inven_Origen,
                                 IdEstadoAproba_egr = q.IdEstadoAproba_egr,
                                 IdEstadoAproba_ing = q.IdEstadoAproba_ing,
                                 IdUsuario = q.IdUsuario,
                                 IdGuia = q.IdGuia,
                                 EstadoRevision = q.EstadoRevision
                             }).ToList();


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
                              group q by new { q.IdEmpresa, q.IdSucursalOrigen, q.cod_sucursal, q.nom_sucursal, q.IdBodegaOrigen, q.cod_bodega, q.nom_bodega, q.tr_fecha }
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
                        info.Sucursal_Origen = "[" + item.cod_sucursal + "] " + item.nom_sucursal;
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

        public bool Guardar(in_transferencia_Info info)
        {
            try
            {


                try
                {
                    using (EntitiesInventario db = new EntitiesInventario())
                    {
                        #region Transferencia
                        in_transferencia Entity = new in_transferencia
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSucursalOrigen = info.IdSucursalOrigen,
                            IdBodegaOrigen = info.IdBodegaOrigen,
                            IdTransferencia = info.IdTransferencia = GetId(info.IdEmpresa, info.IdSucursalOrigen, info.IdBodegaOrigen),
                            Codigo = info.Codigo,
                            IdSucursalDest = info.IdSucursalDest,
                            IdBodegaDest = info.IdBodegaDest,
                            tr_Observacion = info.tr_Observacion ?? "",
                            tr_fecha = info.tr_fecha.Date,
                            IdEmpresa_Ing_Egr_Inven_Origen = info.IdEmpresa_Ing_Egr_Inven_Origen,
                            IdSucursal_Ing_Egr_Inven_Origen = info.IdSucursal_Ing_Egr_Inven_Origen,
                            IdMovi_inven_tipo_SucuOrig = info.IdMovi_inven_tipo_SucuOrig,
                            IdNumMovi_Ing_Egr_Inven_Origen = info.IdNumMovi_Ing_Egr_Inven_Origen,

                            IdEmpresa_Ing_Egr_Inven_Destino = info.IdEmpresa_Ing_Egr_Inven_Destino,
                            IdSucursal_Ing_Egr_Inven_Destino = info.IdSucursal_Ing_Egr_Inven_Destino,
                            IdMovi_inven_tipo_SucuDest = info.IdMovi_inven_tipo_SucuDest,
                            IdNumMovi_Ing_Egr_Inven_Destino = info.IdNumMovi_Ing_Egr_Inven_Destino,
                            IdUsuario = info.IdUsuario,
                            Estado = "A",
                            tr_fecha_transaccion = DateTime.Now,
                            IdGuia = null,
                            EstadoRevision = "P",
                            TuvoError = false
                        };

                        int Secuencia = 1;
                        foreach (var item in info.lista_detalle_transferencia)
                        {
                            db.in_transferencia_det.Add(new in_transferencia_det
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursalOrigen = info.IdSucursalOrigen,
                                IdBodegaOrigen = info.IdBodegaOrigen,
                                IdTransferencia = info.IdTransferencia,
                                dt_secuencia = item.dt_secuencia = Secuencia++,
                                IdProducto = item.IdProducto,
                                pr_descripcion = item.pr_descripcion,
                                dt_cantidad = item.dt_cantidad,
                                dt_cantidadPreDespacho = item.dt_cantidad,
                                tr_Observacion = item.tr_Observacion,
                                IdUnidadMedida = item.IdUnidadMedida,
                                EnviarEnGuia = item.EnviarEnGuia,
                                IdSucursal_oc = item.IdSucursal_oc,
                                IdOrdenCompra = item.IdOrdenCompra,
                                Secuencia_oc = item.Secuencia_oc
                            });
                        }
                        #endregion

                        #region Egreso de inventario
                        info.IdNumMovi_Ing_Egr_Inven_Origen = odataIngEgr.GetId(info.IdEmpresa, info.IdSucursal_Ing_Egr_Inven_Origen ?? 0, info.IdMovi_inven_tipo_SucuOrig ?? 0);
                        var MotivoEgr = db.in_Motivo_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.Tipo_Ing_Egr == "EGR" && q.Genera_Movi_Inven == "S").FirstOrDefault();
                        if (MotivoEgr != null)
                        {
                            db.in_Ing_Egr_Inven.Add(new in_Ing_Egr_Inven
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursal_Ing_Egr_Inven_Origen ?? 0,
                                IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                IdBodega = info.IdBodegaOrigen,
                                signo = "-",
                                CodMoviInven = "TR" + info.IdTransferencia.ToString(),
                                cm_observacion = "TR" + info.IdTransferencia.ToString() + " - " + info.tr_Observacion,
                                cm_fecha = info.tr_fecha,
                                IdUsuario = info.IdUsuario,
                                Fecha_Transac = DateTime.Now,
                                Estado = "A",
                                IdMotivo_Inv = MotivoEgr.IdMotivo_Inv
                            });

                            var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null).ToList();
                            foreach (var item in lstEgr)
                            {
                                db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursalOrigen,
                                    IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                    IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                    Secuencia = item.dt_secuencia,
                                    IdBodega = info.IdBodegaOrigen,
                                    IdProducto = item.IdProducto ?? 0,

                                    dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (item.dt_cantidad)) * -1,
                                    mv_costo = 0,
                                    IdUnidadMedida = item.IdUnidadMedida,

                                    dm_cantidad_sinConversion = (item.dt_cantidad * -1),
                                    mv_costo_sinConversion = 0,
                                    IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                    IdEstadoAproba = "PEND",
                                    dm_precio = 0,
                                    dm_observacion = item.tr_Observacion ?? ""
                                });
                            }
                            Entity.IdNumMovi_Ing_Egr_Inven_Origen = info.IdNumMovi_Ing_Egr_Inven_Origen;
                        }

                        #endregion

                        if (info.InfoGuia != null)
                        {
                            #region Guia
                            info.IdGuia = odataGuia.GetIdGuia(info.IdEmpresa);
                            var talonario = odataTalonario.GetDocumentoElectronicoUpdateUsado(info.IdEmpresa, info.InfoGuia.CodDocumentoTipo, info.InfoGuia.IdEstablecimiento, info.InfoGuia.IdPuntoEmision);
                            if (talonario != null)
                            {
                                info.InfoGuia.NumDocumento_Guia = talonario.NumDocumento;
                            }
                            db.in_Guia_x_traspaso_bodega.Add(new in_Guia_x_traspaso_bodega
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdGuia = info.IdGuia ?? 0,
                                IdSucursal_Partida = info.InfoGuia.IdSucursal_Partida,
                                IdSucursal_Llegada = info.InfoGuia.IdSucursal_Llegada,
                                Direc_sucu_Partida = info.InfoGuia.Direc_sucu_Partida,
                                Direc_sucu_Llegada = info.InfoGuia.Direc_sucu_Llegada,
                                IdTransportista = info.InfoGuia.IdTransportista,
                                Fecha = info.tr_fecha,
                                Fecha_llegada = DateTime.Now.Date,
                                Fecha_Traslado = DateTime.Now.Date,
                                Fecha_Transac = DateTime.Now,
                                IdMotivo_Traslado = info.InfoGuia.IdMotivo_Traslado,
                                IdUsuario = info.IdUsuario,
                                Estado = "A",
                                CodDocumentoTipo = info.InfoGuia.CodDocumentoTipo,
                                IdEstablecimiento = info.InfoGuia.IdEstablecimiento,
                                IdPuntoEmision = info.InfoGuia.IdPuntoEmision,
                                NumDocumento_Guia = info.InfoGuia.NumDocumento_Guia,
                                NombreDestinatario = info.InfoGuia.NombreDestinatario,
                                IdentificacionDestinatario = info.InfoGuia.IdentificacionDestinatario,
                                Placa = info.InfoGuia.Placa
                            });

                            var lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra != null).ToList();
                            foreach (var item in lstGuiaOC)
                            {
                                db.in_Guia_x_traspaso_bodega_det.Add(new in_Guia_x_traspaso_bodega_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdGuia = info.IdGuia ?? 0,
                                    secuencia = item.dt_secuencia,
                                    IdEmpresa_OC = info.IdEmpresa,
                                    IdSucursal_OC = item.IdSucursal_oc,
                                    IdOrdenCompra_OC = item.IdOrdenCompra,
                                    Secuencia_OC = item.Secuencia_oc,
                                    observacion = item.tr_Observacion ?? "",
                                    Cantidad_enviar = item.dt_cantidad,
                                    Referencia = item.IdOrdenCompra.ToString()
                                });
                            }
                            lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra == null).ToList();
                            foreach (var item in lstGuiaOC)
                            {
                                db.in_Guia_x_traspaso_bodega_det_sin_oc.Add(new in_Guia_x_traspaso_bodega_det_sin_oc
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdGuia = info.IdGuia ?? 0,
                                    secuencia = item.dt_secuencia,
                                    Num_Fact = "",
                                    IdProveedor = null,
                                    Cantidad_enviar = item.dt_cantidad,
                                    nom_proveedor = "Transferencia # " + info.IdTransferencia,

                                    IdProducto = item.IdProducto,
                                    nom_producto = item.pr_descripcion,
                                    observacion = item.tr_Observacion ?? "",
                                });
                            }
                            Entity.IdGuia = info.IdGuia;
                            #endregion
                        }

                        db.in_transferencia.Add(Entity);
                        db.SaveChanges();
                    }

                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public bool Modificar(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    in_transferencia Entity = db.in_transferencia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    #region Transferencia
                    if (info.IdNumMovi_Ing_Egr_Inven_Destino != null)
                    {
                        Entity.IdSucursal_Ing_Egr_Inven_Destino = info.IdSucursal_Ing_Egr_Inven_Destino;
                        Entity.IdSucursalDest = info.IdSucursalDest;
                        Entity.IdBodegaDest = info.IdBodegaDest;
                    }

                    //Entity.tr_fecha = info.tr_fecha;
                    Entity.tr_Observacion = info.tr_Observacion ?? "";
                    Entity.IdUsuarioUltMod = info.IdUsuario;
                    Entity.Fecha_UltMod = DateTime.Now;

                    var lstDet = db.in_transferencia_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia);
                    foreach (var item in lstDet)
                    {
                        db.in_transferencia_det.Remove(item);
                    }

                    int Secuencia = 1;
                    foreach (var item in info.lista_detalle_transferencia)
                    {
                        db.in_transferencia_det.Add(new in_transferencia_det
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSucursalOrigen = info.IdSucursalOrigen,
                            IdBodegaOrigen = info.IdBodegaOrigen,
                            IdTransferencia = info.IdTransferencia,
                            dt_secuencia = item.dt_secuencia = Secuencia++,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            dt_cantidadPreDespacho = item.dt_cantidad,
                            dt_cantidad = item.dt_cantidad,
                            tr_Observacion = item.tr_Observacion,
                            IdUnidadMedida = item.IdUnidadMedida,
                            EnviarEnGuia = item.EnviarEnGuia,
                            IdSucursal_oc = item.IdSucursal_oc,
                            IdOrdenCompra = item.IdOrdenCompra,
                            Secuencia_oc = item.Secuencia_oc
                        });
                    }
                    #endregion

                    if (info.IdNumMovi_Ing_Egr_Inven_Origen == null)
                    {
                        #region Nuevo egreso de inventario
                        info.IdNumMovi_Ing_Egr_Inven_Origen = odataIngEgr.GetId(info.IdEmpresa, info.IdSucursal_Ing_Egr_Inven_Origen ?? 0, info.IdMovi_inven_tipo_SucuOrig ?? 0);
                        var MotivoEgr = db.in_Motivo_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.Tipo_Ing_Egr == "EGR" && q.Genera_Movi_Inven == "S").FirstOrDefault();
                        if (MotivoEgr != null)
                        {
                            db.in_Ing_Egr_Inven.Add(new in_Ing_Egr_Inven
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursal_Ing_Egr_Inven_Origen ?? 0,
                                IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                IdBodega = info.IdBodegaOrigen,
                                signo = "-",
                                CodMoviInven = "TR" + info.IdTransferencia.ToString(),
                                cm_observacion = "TR" + info.IdTransferencia.ToString() + " - " + info.tr_Observacion,
                                cm_fecha = DateTime.Now.Date,//info.tr_fecha,
                                IdUsuario = info.IdUsuario,
                                Fecha_Transac = DateTime.Now,
                                Estado = "A",
                                IdMotivo_Inv = MotivoEgr.IdMotivo_Inv
                            });

                            var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null).ToList();
                            foreach (var item in lstEgr)
                            {
                                db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursalOrigen,
                                    IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                    IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                    Secuencia = item.dt_secuencia,
                                    IdBodega = info.IdBodegaOrigen,
                                    IdProducto = item.IdProducto ?? 0,

                                    dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (Math.Abs(item.dt_cantidad))) * -1,
                                    mv_costo = 0,
                                    IdUnidadMedida = item.IdUnidadMedida,

                                    dm_cantidad_sinConversion = Math.Abs(item.dt_cantidad) * -1,
                                    mv_costo_sinConversion = 0,
                                    IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                    IdEstadoAproba = "PEND",
                                    dm_precio = 0,
                                    dm_observacion = item.tr_Observacion ?? ""
                                });
                            }
                            Entity.IdNumMovi_Ing_Egr_Inven_Origen = info.IdNumMovi_Ing_Egr_Inven_Origen;
                        }

                        #endregion
                    }
                    else
                    {
                        #region Modifcar egreso de inventario
                        var EntityInv = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal_Ing_Egr_Inven_Origen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).FirstOrDefault();
                        if (EntityInv != null)
                        {
                            EntityInv.IdUsuarioUltModi = info.IdUsuario;
                            EntityInv.Fecha_UltMod = DateTime.Now;

                            var lstEgrD = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalOrigen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).ToList();
                            foreach (var item in lstEgrD)
                            {
                                db.in_Ing_Egr_Inven_det.Remove(item);
                            }

                            var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null).ToList();
                            foreach (var item in lstEgr)
                            {
                                db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                                {
                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursalOrigen,
                                    IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                    IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                    Secuencia = item.dt_secuencia,
                                    IdBodega = info.IdBodegaOrigen,
                                    IdProducto = item.IdProducto ?? 0,

                                    dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, Math.Abs(item.dt_cantidad)) * -1,
                                    mv_costo = 0,
                                    IdUnidadMedida = item.IdUnidadMedida,

                                    dm_cantidad_sinConversion = Math.Abs(item.dt_cantidad) * -1,
                                    mv_costo_sinConversion = 0,
                                    IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                    IdEstadoAproba = "PEND",
                                    dm_precio = 0,
                                    dm_observacion = item.tr_Observacion ?? ""
                                });
                            }
                        }
                        #endregion
                    }

                    if (info.InfoGuia != null && info.InfoGuia.IdGuia == 0)
                    {
                        #region Nueva Guia
                        info.IdGuia = odataGuia.GetIdGuia(info.IdEmpresa);
                        var talonario = odataTalonario.GetDocumentoElectronicoUpdateUsado(info.IdEmpresa, info.InfoGuia.CodDocumentoTipo, info.InfoGuia.IdEstablecimiento, info.InfoGuia.IdPuntoEmision);
                        if (talonario != null)
                        {
                            info.InfoGuia.NumDocumento_Guia = talonario.NumDocumento;
                        }
                        db.in_Guia_x_traspaso_bodega.Add(new in_Guia_x_traspaso_bodega
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdGuia = info.IdGuia ?? 0,
                            IdSucursal_Partida = info.InfoGuia.IdSucursal_Partida,
                            IdSucursal_Llegada = info.InfoGuia.IdSucursal_Llegada,
                            Direc_sucu_Partida = info.InfoGuia.Direc_sucu_Partida,
                            Direc_sucu_Llegada = info.InfoGuia.Direc_sucu_Llegada,
                            IdTransportista = info.InfoGuia.IdTransportista,
                            Fecha = DateTime.Now.Date,
                            Fecha_llegada = info.tr_fecha,
                            Fecha_Traslado = info.tr_fecha,
                            Fecha_Transac = DateTime.Now,
                            IdMotivo_Traslado = info.InfoGuia.IdMotivo_Traslado,
                            IdUsuario = info.IdUsuario,
                            Estado = "A",
                            CodDocumentoTipo = info.InfoGuia.CodDocumentoTipo,
                            IdEstablecimiento = info.InfoGuia.IdEstablecimiento,
                            IdPuntoEmision = info.InfoGuia.IdPuntoEmision,
                            NumDocumento_Guia = info.InfoGuia.NumDocumento_Guia,
                            NombreDestinatario = info.InfoGuia.NombreDestinatario,
                            IdentificacionDestinatario = info.InfoGuia.IdentificacionDestinatario,
                            Placa = info.InfoGuia.Placa
                        });

                        var lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra != null).ToList();
                        foreach (var item in lstGuiaOC)
                        {
                            db.in_Guia_x_traspaso_bodega_det.Add(new in_Guia_x_traspaso_bodega_det
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdGuia = info.IdGuia ?? 0,
                                secuencia = item.dt_secuencia,
                                IdEmpresa_OC = info.IdEmpresa,
                                IdSucursal_OC = item.IdSucursal_oc,
                                IdOrdenCompra_OC = item.IdOrdenCompra,
                                Secuencia_OC = item.Secuencia_oc,
                                observacion = item.tr_Observacion ?? "",
                                Cantidad_enviar = item.dt_cantidad,
                                Referencia = item.IdOrdenCompra.ToString()
                            });
                        }
                        lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra == null).ToList();
                        foreach (var item in lstGuiaOC)
                        {
                            db.in_Guia_x_traspaso_bodega_det_sin_oc.Add(new in_Guia_x_traspaso_bodega_det_sin_oc
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdGuia = info.IdGuia ?? 0,
                                secuencia = item.dt_secuencia,
                                Num_Fact = "",
                                IdProveedor = null,
                                Cantidad_enviar = item.dt_cantidad,
                                nom_proveedor = "Transferencia # " + info.IdTransferencia,

                                IdProducto = item.IdProducto,
                                nom_producto = item.pr_descripcion,
                                observacion = item.tr_Observacion ?? "",
                            });
                        }
                        Entity.IdGuia = info.IdGuia;
                        #endregion
                    }
                    else
                        if (info.InfoGuia != null && info.InfoGuia.IdGuia != 0)
                        {
                            #region Modificar Guia
                            var EntityGuia = db.in_Guia_x_traspaso_bodega.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == info.IdGuia).FirstOrDefault();
                            if (EntityGuia != null)
                            {
                                var lstDetGuia = db.in_Guia_x_traspaso_bodega_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == (info.IdGuia ?? 0)).ToList();
                                foreach (var item in lstDetGuia)
                                {
                                    db.in_Guia_x_traspaso_bodega_det.Remove(item);
                                }
                                var lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra != null).ToList();
                                foreach (var item in lstGuiaOC)
                                {
                                    db.in_Guia_x_traspaso_bodega_det.Add(new in_Guia_x_traspaso_bodega_det
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdGuia = info.IdGuia ?? 0,
                                        secuencia = item.dt_secuencia,
                                        IdEmpresa_OC = info.IdEmpresa,
                                        IdSucursal_OC = item.IdSucursal_oc,
                                        IdOrdenCompra_OC = item.IdOrdenCompra,
                                        Secuencia_OC = item.Secuencia_oc,
                                        observacion = item.tr_Observacion ?? "",
                                        Cantidad_enviar = item.dt_cantidad,
                                        Referencia = item.IdOrdenCompra.ToString()
                                    });
                                }
                                var lstDetGuiaSinOc = db.in_Guia_x_traspaso_bodega_det_sin_oc.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == (info.IdGuia ?? 0)).ToList();
                                foreach (var item in lstDetGuiaSinOc)
                                {
                                    db.in_Guia_x_traspaso_bodega_det_sin_oc.Remove(item);
                                }
                                lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra == null).ToList();
                                foreach (var item in lstGuiaOC)
                                {
                                    db.in_Guia_x_traspaso_bodega_det_sin_oc.Add(new in_Guia_x_traspaso_bodega_det_sin_oc
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdGuia = info.IdGuia ?? 0,
                                        secuencia = item.dt_secuencia,
                                        Num_Fact = "",
                                        IdProveedor = null,
                                        Cantidad_enviar = item.dt_cantidad,
                                        nom_proveedor = "Transferencia # " + info.IdTransferencia,

                                        IdProducto = item.IdProducto,
                                        nom_producto = item.pr_descripcion,
                                        observacion = item.tr_Observacion ?? "",
                                    });
                                }
                            }
                            #endregion
                        }

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AnularDB(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var EntityT = db.in_transferencia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).FirstOrDefault();
                    if (EntityT != null)
                    {
                        EntityT.Estado = "I";
                        EntityT.tr_userAnulo = info.IdUsuario;
                        EntityT.tr_fechaAnulacion = DateTime.Now;
                    }

                    var EntityG = db.in_Guia_x_traspaso_bodega.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == (info.IdGuia ?? 0)).FirstOrDefault();
                    if (EntityG != null)
                    {
                        EntityG.Estado = "I";
                        EntityG.IdUsuarioUltAnu = info.IdUsuario;
                        EntityG.Fecha_UltAnu = DateTime.Now;
                    }

                    var EntityE = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalOrigen && q.IdMovi_inven_tipo == (info.IdMovi_inven_tipo_SucuOrig ?? 0) && q.IdNumMovi == (info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0)).FirstOrDefault();
                    if (EntityE != null)
                    {
                        int ContE = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == EntityE.IdEmpresa && q.IdSucursal == EntityE.IdSucursal && q.IdMovi_inven_tipo == EntityE.IdMovi_inven_tipo && q.IdNumMovi == EntityE.IdNumMovi && q.IdNumMovi_inv != null).Count();
                        if (ContE != 0)
                            return false;

                        EntityE.Estado = "I";
                        EntityE.IdusuarioUltAnu = info.IdUsuario;
                        EntityE.Fecha_UltAnu = DateTime.Now;
                    }

                    var EntityI = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalDest && q.IdMovi_inven_tipo == (info.IdMovi_inven_tipo_SucuDest ?? 0) && q.IdNumMovi == (info.IdNumMovi_Ing_Egr_Inven_Destino ?? 0)).FirstOrDefault();
                    if (EntityI != null)
                    {
                        int ContI = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == EntityE.IdEmpresa && q.IdSucursal == EntityI.IdSucursal && q.IdMovi_inven_tipo == EntityI.IdMovi_inven_tipo && q.IdNumMovi == EntityI.IdNumMovi && q.IdNumMovi_inv != null).Count();
                        if (ContI != 0)
                            return false;

                        EntityI.Estado = "I";
                        EntityI.IdusuarioUltAnu = info.IdUsuario;
                        EntityI.Fecha_UltAnu = DateTime.Now;
                    }

                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Revisar(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_transferencia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.EstadoRevision = info.EstadoRevision;
                        Entity.FechaRevision = DateTime.Now;
                        Entity.IdUsuarioRevision = info.IdUsuario;


                        #region Modifcar egreso de inventario
                        var EntityInv = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal_Ing_Egr_Inven_Origen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).FirstOrDefault();
                        if (EntityInv != null)
                        {
                            EntityInv.IdUsuarioUltModi = info.IdUsuario;
                            EntityInv.Fecha_UltMod = DateTime.Now;

                            var lstEgrD = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalOrigen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).ToList();
                            foreach (var item in lstEgrD)
                            {
                                db.in_Ing_Egr_Inven_det.Remove(item);
                            }

                            var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null).ToList();
                            foreach (var item in lstEgr)
                            {
                                if (item.dt_cantidad > 0)
                                {
                                    db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdSucursal = info.IdSucursalOrigen,
                                        IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                        IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                        Secuencia = item.dt_secuencia,
                                        IdBodega = info.IdBodegaOrigen,
                                        IdProducto = item.IdProducto ?? 0,

                                        dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (item.dt_cantidad)) * -1,
                                        mv_costo = 0,
                                        IdUnidadMedida = item.IdUnidadMedida,

                                        dm_cantidad_sinConversion = item.dt_cantidad * -1,
                                        mv_costo_sinConversion = 0,
                                        IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                        IdEstadoAproba = "PEND",
                                        dm_precio = 0,
                                        dm_observacion = item.tr_Observacion ?? ""
                                    });
                                }

                                if (item.dt_cantidad != item.dt_cantidadPreDespacho)
                                {
                                    Entity.TuvoErrorDespacho = true;
                                }

                                var det = db.in_transferencia_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia && q.dt_secuencia == item.dt_secuencia).FirstOrDefault();
                                if (det != null)
                                {
                                    det.dt_cantidad = item.dt_cantidad;
                                }
                            }
                        }
                        db.SaveChanges();
                        #endregion

                        if (Entity.IdGuia != 0)
                        {
                            #region Modificar Guia
                            var EntityGuia = db.in_Guia_x_traspaso_bodega.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == info.IdGuia).FirstOrDefault();
                            if (EntityGuia != null)
                            {
                                var lstDetGuia = db.in_Guia_x_traspaso_bodega_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == (info.IdGuia ?? 0)).ToList();
                                foreach (var item in lstDetGuia)
                                {
                                    db.in_Guia_x_traspaso_bodega_det.Remove(item);
                                }
                                var lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra != null).ToList();
                                foreach (var item in lstGuiaOC)
                                {
                                    db.in_Guia_x_traspaso_bodega_det.Add(new in_Guia_x_traspaso_bodega_det
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdGuia = info.IdGuia ?? 0,
                                        secuencia = item.dt_secuencia,
                                        IdEmpresa_OC = info.IdEmpresa,
                                        IdSucursal_OC = item.IdSucursal_oc,
                                        IdOrdenCompra_OC = item.IdOrdenCompra,
                                        Secuencia_OC = item.Secuencia_oc,
                                        observacion = item.tr_Observacion ?? "",
                                        Cantidad_enviar = item.dt_cantidad,
                                        Referencia = item.IdOrdenCompra.ToString()
                                    });
                                }
                                var lstDetGuiaSinOc = db.in_Guia_x_traspaso_bodega_det_sin_oc.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdGuia == (info.IdGuia ?? 0)).ToList();
                                foreach (var item in lstDetGuiaSinOc)
                                {
                                    db.in_Guia_x_traspaso_bodega_det_sin_oc.Remove(item);
                                }
                                lstGuiaOC = info.lista_detalle_transferencia.Where(q => q.EnviarEnGuia == true && q.IdOrdenCompra == null).ToList();
                                foreach (var item in lstGuiaOC)
                                {
                                    db.in_Guia_x_traspaso_bodega_det_sin_oc.Add(new in_Guia_x_traspaso_bodega_det_sin_oc
                                    {
                                        IdEmpresa = info.IdEmpresa,
                                        IdGuia = info.IdGuia ?? 0,
                                        secuencia = item.dt_secuencia,
                                        Num_Fact = "",
                                        IdProveedor = null,
                                        Cantidad_enviar = item.dt_cantidad,
                                        nom_proveedor = "Transferencia # " + info.IdTransferencia,

                                        IdProducto = item.IdProducto,
                                        nom_producto = item.pr_descripcion,
                                        observacion = item.tr_Observacion ?? "",
                                    });
                                }
                            }
                            #endregion
                        }
                    }
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Aprobar(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_transferencia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    if (Entity.EstadoRevision != "A")
                        return true;

                    #region Modifcar egreso de inventario
                    var EntityInv = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal_Ing_Egr_Inven_Origen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).FirstOrDefault();
                    if (EntityInv != null)
                    {
                        EntityInv.IdUsuarioUltModi = info.IdUsuario;
                        EntityInv.Fecha_UltMod = DateTime.Now;

                        var lstEgrD = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalOrigen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).ToList();
                        foreach (var item in lstEgrD)
                        {
                            db.in_Ing_Egr_Inven_det.Remove(item);
                        }

                        var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null && q.cantidad_enviar > 0).ToList();
                        foreach (var item in lstEgr)
                        {
                            db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursalOrigen,
                                IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                Secuencia = item.dt_secuencia,
                                IdBodega = info.IdBodegaOrigen,
                                IdProducto = item.IdProducto ?? 0,

                                dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (item.cantidad_enviar)) * -1,
                                mv_costo = 0,
                                IdUnidadMedida = item.IdUnidadMedida,

                                dm_cantidad_sinConversion = item.cantidad_enviar * -1,
                                mv_costo_sinConversion = 0,
                                IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                IdEstadoAproba = "PEND",
                                dm_precio = 0,
                                dm_observacion = item.tr_Observacion ?? ""
                            });
                        }
                    }

                    #endregion

                    #region Ingreso de inventario
                    info.IdNumMovi_Ing_Egr_Inven_Destino = Entity.IdNumMovi_Ing_Egr_Inven_Destino = odataIngEgr.GetId(Entity.IdEmpresa, Entity.IdSucursalDest, Entity.IdMovi_inven_tipo_SucuDest ?? 0);
                    var MotivoEgr = db.in_Motivo_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.Tipo_Ing_Egr == "ING" && q.Genera_Movi_Inven == "S").FirstOrDefault();
                    if (MotivoEgr != null)
                    {
                        db.in_Ing_Egr_Inven.Add(new in_Ing_Egr_Inven
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSucursal = info.IdSucursal_Ing_Egr_Inven_Destino ?? 0,
                            IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuDest ?? 0,
                            IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Destino ?? 0,
                            IdBodega = info.IdBodegaDest,
                            signo = "+",
                            CodMoviInven = "TR" + info.IdTransferencia.ToString(),
                            cm_observacion = "TR" + info.IdTransferencia.ToString() + " - " + (info.tr_Observacion ?? ""),
                            cm_fecha = DateTime.Now.Date, //info.tr_fecha,
                            IdUsuario = info.IdUsuario,
                            Fecha_Transac = DateTime.Now,
                            Estado = "A",
                            IdMotivo_Inv = MotivoEgr.IdMotivo_Inv
                        });


                        foreach (var item in info.lista_detalle_transferencia)
                        {
                            if (item.IdProducto != null && item.cantidad_enviar > 0)
                            {
                                db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                                {

                                    IdEmpresa = info.IdEmpresa,
                                    IdSucursal = info.IdSucursalDest,
                                    IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuDest ?? 0,
                                    IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Destino ?? 0,
                                    Secuencia = item.dt_secuencia,
                                    IdBodega = info.IdBodegaDest,
                                    IdProducto = item.IdProducto ?? 0,

                                    dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (item.cantidad_enviar)),
                                    mv_costo = 0,
                                    IdUnidadMedida = item.IdUnidadMedida,

                                    dm_cantidad_sinConversion = item.cantidad_enviar,
                                    mv_costo_sinConversion = 0,
                                    IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                    IdEstadoAproba = "PEND",
                                    dm_precio = 0,
                                    dm_observacion = item.tr_Observacion ?? ""
                                });
                            }
                            var det = db.in_transferencia_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia && q.dt_secuencia == item.dt_secuencia).FirstOrDefault();
                            if (det != null)
                            {
                                det.dt_cantidadApro = item.cantidad_enviar;
                                det.dt_cantidadFinal = Math.Round(det.dt_cantidad - item.cantidad_enviar, 2, MidpointRounding.AwayFromZero);
                                det.MotivoParcial = item.MotivoParcial;
                            }
                        }

                        Entity.IdNumMovi_Ing_Egr_Inven_Destino = info.IdNumMovi_Ing_Egr_Inven_Destino;
                        if (info.lista_detalle_transferencia.Where(q => q.cantidad_enviar != q.dt_cantidad).Count() > 0)
                            Entity.TuvoError = true;

                        Entity.EstadoRevision = "R";
                        Entity.IdUsuarioUltMod = info.IdUsuario;
                        Entity.Fecha_UltMod = DateTime.Now;
                        db.SaveChanges();
                    }

                    in_movi_inve_Data odataMovInve = new in_movi_inve_Data();
                    if (odataMovInve.AprobarData(Entity.IdEmpresa, Entity.IdSucursalOrigen, Entity.IdMovi_inven_tipo_SucuOrig ?? 0, Entity.IdNumMovi_Ing_Egr_Inven_Origen ?? 0, "-", info.IdUsuario ?? "", ref mensaje))
                    {
                        if (odataMovInve.AprobarData(Entity.IdEmpresa, Entity.IdSucursalDest, Entity.IdMovi_inven_tipo_SucuDest ?? 0, Entity.IdNumMovi_Ing_Egr_Inven_Destino ?? 0, "+", info.IdUsuario ?? "", ref mensaje))
                        {

                        }
                    }
                    #endregion
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Corregir(in_transferencia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    in_transferencia Entity = db.in_transferencia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    #region Transferencia

                    Entity.IdUsuarioUltMod = info.IdUsuario;
                    Entity.Fecha_UltMod = DateTime.Now;
                    Entity.EstadoRevision = "R";

                    foreach (var item in info.lista_detalle_transferencia)
                    {
                        var det = db.in_transferencia_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursalOrigen == info.IdSucursalOrigen && q.IdBodegaOrigen == info.IdBodegaOrigen && q.IdTransferencia == info.IdTransferencia && q.dt_secuencia == item.dt_secuencia).FirstOrDefault();
                        if (det != null)
                        {
                            det.dt_cantidadFinal = item.dt_cantidadFinal;
                        }
                    }
                    #endregion

                    #region Modifcar egreso de inventario
                    var EntityInv = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal_Ing_Egr_Inven_Origen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).FirstOrDefault();
                    if (EntityInv != null)
                    {
                        EntityInv.IdUsuarioUltModi = info.IdUsuario;
                        EntityInv.Fecha_UltMod = DateTime.Now;

                        var lstEgrD = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursalOrigen && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo_SucuOrig && q.IdNumMovi == info.IdNumMovi_Ing_Egr_Inven_Origen).ToList();
                        foreach (var item in lstEgrD)
                        {
                            db.in_Ing_Egr_Inven_det.Remove(item);
                        }

                        var lstEgr = info.lista_detalle_transferencia.Where(q => q.IdProducto != null && q.dt_cantidadApro > 0).ToList();
                        foreach (var item in lstEgr)
                        {
                            db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                            {
                                IdEmpresa = info.IdEmpresa,
                                IdSucursal = info.IdSucursalOrigen,
                                IdMovi_inven_tipo = info.IdMovi_inven_tipo_SucuOrig ?? 0,
                                IdNumMovi = info.IdNumMovi_Ing_Egr_Inven_Origen ?? 0,
                                Secuencia = item.dt_secuencia,
                                IdBodega = info.IdBodegaOrigen,
                                IdProducto = item.IdProducto ?? 0,

                                dm_cantidad = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto ?? 0, item.IdUnidadMedida, (item.dt_cantidadApro)) * -1,
                                mv_costo = 0,
                                IdUnidadMedida = item.IdUnidadMedida,

                                dm_cantidad_sinConversion = item.dt_cantidadApro * -1,
                                mv_costo_sinConversion = 0,
                                IdUnidadMedida_sinConversion = item.IdUnidadMedida,

                                IdEstadoAproba = "PEND",
                                dm_precio = 0,
                                dm_observacion = item.tr_Observacion ?? ""
                            });
                        }

                    #endregion
                    }

                    db.SaveChanges();

                    in_movi_inve_Data odataMovInve = new in_movi_inve_Data();
                    if (odataMovInve.AprobarData(Entity.IdEmpresa, Entity.IdSucursalOrigen, Entity.IdMovi_inven_tipo_SucuOrig ?? 0, Entity.IdNumMovi_Ing_Egr_Inven_Origen ?? 0, "-", info.IdUsuario ?? "", ref mensaje))
                    {
                        if (odataMovInve.AprobarData(Entity.IdEmpresa, Entity.IdSucursalDest, Entity.IdMovi_inven_tipo_SucuDest ?? 0, Entity.IdNumMovi_Ing_Egr_Inven_Destino ?? 0, "+", info.IdUsuario ?? "", ref mensaje))
                        {

                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public in_transferencia_Info GetInfoCambioFecha(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
        {
            try
            {
                in_transferencia_Info info = new in_transferencia_Info();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select top 1 a.IdEmpresa, a.IdSucursalOrigen, a.IdBodegaOrigen, a.IdTransferencia, "
                                        + " a.IdSucursal_Ing_Egr_Inven_Origen, a.IdMovi_inven_tipo_SucuOrig, a.IdNumMovi_Ing_Egr_Inven_Origen,"
                                        + " a.IdSucursal_Ing_Egr_Inven_Destino, a.IdMovi_inven_tipo_SucuDest, a.IdNumMovi_Ing_Egr_Inven_Destino,"
                                        + " a.tr_Observacion, a.tr_fecha, b.cm_fecha as FechaEgreso, c.cm_fecha as FechaIngreso"
                                        + " from in_transferencia as a left join"
                                        + " in_Ing_Egr_Inven as b on a.IdEmpresa_Ing_Egr_Inven_Origen = b.IdEmpresa and a.IdSucursal_Ing_Egr_Inven_Origen = b.IdSucursal and a.IdMovi_inven_tipo_SucuOrig = b.IdMovi_inven_tipo and a.IdNumMovi_Ing_Egr_Inven_Origen = b.IdNumMovi left join"
                                        + " in_Ing_Egr_Inven as c on a.IdEmpresa_Ing_Egr_Inven_Destino = c.IdEmpresa and a.IdSucursal_Ing_Egr_Inven_Destino = c.IdSucursal and a.IdMovi_inven_tipo_SucuDest = c.IdMovi_inven_tipo and a.IdNumMovi_Ing_Egr_Inven_Destino = c.IdNumMovi"
                                        + " where a.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdSucursalOrigen = " + IdSucursalOrigen.ToString() + " and a.IdBodegaOrigen = " + IdBodegaOrigen.ToString() + " and a.IdTransferencia = " + IdTransferencia.ToString() + " and a.Estado = 'A'";
                    var ResultValue = command.ExecuteScalar();
                    if (ResultValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new in_transferencia_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursalOrigen = Convert.ToInt32(reader["IdSucursalOrigen"]),
                            IdBodegaOrigen = Convert.ToInt32(reader["IdBodegaOrigen"]),
                            IdTransferencia = Convert.ToDecimal(reader["IdTransferencia"]),

                            IdSucursal_Ing_Egr_Inven_Origen = reader["IdSucursal_Ing_Egr_Inven_Origen"] == DBNull.Value ? null : (int?)reader["IdSucursal_Ing_Egr_Inven_Origen"],
                            IdMovi_inven_tipo_SucuOrig = reader["IdMovi_inven_tipo_SucuOrig"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_SucuOrig"],
                            IdNumMovi_Ing_Egr_Inven_Origen = reader["IdNumMovi_Ing_Egr_Inven_Origen"] == DBNull.Value ? null : (decimal?)reader["IdNumMovi_Ing_Egr_Inven_Origen"],

                            IdSucursal_Ing_Egr_Inven_Destino = reader["IdSucursal_Ing_Egr_Inven_Destino"] == DBNull.Value ? null : (int?)reader["IdSucursal_Ing_Egr_Inven_Destino"],
                            IdMovi_inven_tipo_SucuDest = reader["IdMovi_inven_tipo_SucuDest"] == DBNull.Value ? null : (int?)reader["IdMovi_inven_tipo_SucuDest"],
                            IdNumMovi_Ing_Egr_Inven_Destino = reader["IdNumMovi_Ing_Egr_Inven_Destino"] == DBNull.Value ? null : (decimal?)reader["IdNumMovi_Ing_Egr_Inven_Destino"],

                            tr_Observacion = Convert.ToString(reader["tr_Observacion"]),
                            tr_fecha = Convert.ToDateTime(reader["tr_fecha"]),
                            FechaEgreso = reader["FechaEgreso"] == DBNull.Value ? null : (DateTime?)(reader["FechaEgreso"]),
                            FechaIngreso = reader["FechaIngreso"] == DBNull.Value ? null : (DateTime?)reader["FechaIngreso"]
                        };
                    }
                    reader.Close();
                }

                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ModificarFecha(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia, DateTime Fecha)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update in_transferencia set tr_fecha = DATEFROMPARTS(" + Fecha.Year.ToString() + "," + Fecha.Month.ToString() + "," + Fecha.Day.ToString() + ") where IdEmpresa = " + IdEmpresa.ToString() + " and IdSucursalOrigen = " + IdSucursalOrigen.ToString() + " and IdBodegaOrigen = " + IdBodegaOrigen.ToString() + " and IdTransferencia = " + IdTransferencia.ToString();
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Eliminar(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
        {
            using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DECLARE @IdEmpresa int = " + IdEmpresa.ToString() + ","
                + " @IdSucursalOrigen int = " + IdSucursalOrigen.ToString() + ","
                + " @IdBodegaOrigen int = " + IdBodegaOrigen.ToString() + ","
                + " @IdTransferencia numeric = " + IdTransferencia.ToString()

                + " DECLARE @IdSucursalEgr int,"
                + " @IdMovi_inven_tipoEgr int,"
                + " @IdNumMoviEgr numeric,"
                + " @IdSucursalIng int,"
                + " @IdMovi_inven_tipoIng int,"
                + " @IdNumMoviIng numeric"

                + " select @IdSucursalEgr = IdSucursal_Ing_Egr_Inven_Origen, @IdMovi_inven_tipoEgr = IdMovi_inven_tipo_SucuOrig, @IdNumMoviEgr = IdNumMovi_Ing_Egr_Inven_Origen,"
                + " @IdSucursalIng = IdSucursal_Ing_Egr_Inven_Destino, @IdMovi_inven_tipoIng = IdMovi_inven_tipo_SucuDest, @IdNumMoviIng = IdNumMovi_Ing_Egr_Inven_Destino"
                + " from in_transferencia where IdEmpresa = @IdEmpresa and IdSucursalOrigen = @IdSucursalOrigen and IdBodegaOrigen = @IdBodegaOrigen and IdTransferencia = @IdTransferencia"

                + " select @IdEmpresa, @IdSucursalOrigen, @IdBodegaOrigen, @IdTransferencia, @IdSucursalEgr, @IdMovi_inven_tipoEgr, @IdNumMoviEgr, @IdSucursalIng, @IdMovi_inven_tipoIng, @IdNumMoviIng "
                + " delete in_transferencia_det where IdEmpresa = @IdEmpresa and IdSucursalOrigen = @IdSucursalOrigen and IdBodegaOrigen = @IdBodegaOrigen and IdTransferencia = @IdTransferencia"
                + " delete in_transferencia where IdEmpresa = @IdEmpresa and IdSucursalOrigen = @IdSucursalOrigen and IdBodegaOrigen = @IdBodegaOrigen and IdTransferencia = @IdTransferencia"

                + " EXEC [dbo].[spSys_in_Eliminar_movimiento_inventario] @IdEmpresa,@IdSucursalEgr,@IdMovi_inven_tipoEgr,@IdNumMoviEgr,1"
                + " EXEC [dbo].[spSys_in_Eliminar_movimiento_inventario] @IdEmpresa,@IdSucursalIng,@IdMovi_inven_tipoIng,@IdNumMoviIng,1";
                command.ExecuteNonQuery();
                return true;
            }
        }
    }
}
