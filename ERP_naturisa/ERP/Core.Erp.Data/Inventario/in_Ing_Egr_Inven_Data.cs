using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Erp.Data.Inventario
{
    public class in_Ing_Egr_Inven_Data
    {
        
        string mensaje = "";
        in_UnidadMedida_Data odataUnidadMedida = new in_UnidadMedida_Data();
        public decimal GetId(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo)
        {
            decimal Id = 0;
            try
            {

                EntitiesInventario contex = new EntitiesInventario();
                var selecte = contex.in_Ing_Egr_Inven.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inven_tipo);

                if (selecte == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in contex.in_Ing_Egr_Inven
                                     where q.IdEmpresa == IdEmpresa
                                     && q.IdSucursal == IdSucursal
                                     && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                                     select q.IdNumMovi).Max();
                    Id = Convert.ToDecimal(select_em.ToString()) + 1;
                }

                return Id;
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

        public Boolean GuardarDB(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
        {
            try
            {
                try
                {
                    using (EntitiesInventario Context = new EntitiesInventario())
                    {
                        var Address = new in_Ing_Egr_Inven();

                        Address.IdEmpresa = info.IdEmpresa;
                        Address.IdSucursal = info.IdSucursal;
                        Address.IdBodega = info.IdBodega;
                        Address.IdNumMovi = info.IdNumMovi = GetId(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo);
                        Address.signo = info.signo;
                        Address.IdMotivo_oc = info.IdMotivo_oc == 0 ? null : info.IdMotivo_oc;
                        Address.IdMotivo_Inv = info.IdMotivo_Inv == 0 ? null : info.IdMotivo_Inv;
                        IdNumMovi = info.IdNumMovi;
                        Address.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                        Address.CodMoviInven = (info.CodMoviInven == "" || info.CodMoviInven == null) ? IdNumMovi.ToString() : info.CodMoviInven;
                        Address.cm_observacion = (info.cm_observacion == "") ? "" : info.cm_observacion;
                        Address.cm_fecha = info.cm_fecha == null ? DateTime.Now : info.cm_fecha.Date;
                        Address.IdUsuario = info.IdUsuario;
                        Address.Fecha_Transac = DateTime.Now;
                        Address.nom_pc = info.nom_pc;
                        Address.ip = info.ip;
                        Address.Estado = "A";
                        Address.IdCentroCosto = info.IdCentroCosto;
                        Address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        Address.IdResponsable = info.IdResponsable;
                        Context.in_Ing_Egr_Inven.Add(Address);
                        Context.SaveChanges();

                        //Graba Detalle  in_Ing_Egr_Inven_det
                        if (info.listIng_Egr.Count() != 0)
                        {
                            int sec = 0;

                            foreach (var item in info.listIng_Egr)
                            {
                                sec = sec + 1;
                                item.IdEmpresa = info.IdEmpresa;
                                item.IdSucursal = info.IdSucursal;
                                item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;

                                if (item.IdBodega == null || item.IdBodega == 0)
                                {
                                    item.IdBodega = Convert.ToInt32(info.IdBodega);
                                }

                                item.IdNumMovi = IdNumMovi;
                                item.Secuencia = sec;
                            }


                            in_Ing_Egr_Inven_det_Data odata = new in_Ing_Egr_Inven_det_Data();
                            odata.GuardarDB(info.listIng_Egr);
                        }

                        mensaje = "Grabación ok..";
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
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

        public Boolean ModificarDB(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                        && q.IdSucursal == info.IdSucursal && q.IdNumMovi == info.IdNumMovi && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo);
                    if (contact != null)
                    {
                        contact.CodMoviInven = info.CodMoviInven;
                        //contact.cm_fecha = info.cm_fecha == null ? DateTime.Now : info.cm_fecha.Date; 
                        contact.cm_observacion = info.cm_observacion;
                        contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                        contact.Fecha_UltMod = DateTime.Now;
                        context.SaveChanges();
                        msgs = "Se ha procedido a modificar el registro de Egreso Varios  #: " + info.IdNumMovi.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

                msgs = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal
                        && q.IdNumMovi == info.IdNumMovi && info.IdMovi_inven_tipo == q.IdMovi_inven_tipo);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.IdusuarioUltAnu = info.IdusuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        contact.cm_observacion = "**Anulado**" + info.cm_observacion;
                        context.SaveChanges();
                        msgs = "Se ha procedido a anular el registro Egreso varios  #: " + info.IdNumMovi.ToString() + " exitosamente";
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

                msgs = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarCabecera_IdMovi_Inven_x_IngEgr(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario context = new EntitiesInventario())
                {
                    var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal
                        && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                    if (contact != null)
                    {
                        //contact.IdEmpresa_inv = info.IdEmpresa_inv;
                        //contact.IdSucursal_inv = info.IdSucursal_inv;
                        //contact.IdBodega_inv = info.IdBodega_inv;
                        //contact.IdMovi_inven_tipo_inv = info.IdMovi_inven_tipo_inv;
                        //contact.IdNumMovi_inv = info.IdNumMovi_inv;
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msgs = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
             int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, int IdMovi_inven_tipo)
        {
            List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                EntitiesInventario oEnti = new EntitiesInventario();
                oEnti.SetCommandTimeOut(5000);

                if (IdBodegaIni == 0)
                {
                    var Query1 = oEnti.vwin_Ing_Egr_Inven.
                                Where(q => q.IdEmpresa == IdEmpresa
                                && q.cm_fecha >= FechaIni
                                && q.cm_fecha <= FechaFin
                                && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                                && q.IdSucursal >= IdSucursalIni
                                && q.IdSucursal <= IdSucursalFin
                                && q.IdBodega >= IdBodegaIni
                                && q.IdBodega <= IdBodegaFin
                                || q.IdBodega == null).ToList();

                    Query1.ForEach(q =>
                    {
                        Lst.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdSucursal = q.IdSucursal,
                            IdBodega = q.IdBodega,
                            IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                            IdNumMovi = q.IdNumMovi,
                            CodMoviInven = q.CodMoviInven,
                            cm_observacion = q.cm_observacion,
                            cm_fecha = q.cm_fecha,
                            Estado = q.Estado,
                            IdCentroCosto = q.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                            signo = q.signo,
                            IdMotivo_oc = Convert.ToInt32(q.IdMotivo_oc),
                            nom_bodega = q.nom_bodega,
                            nom_sucursal = q.nom_sucursal,
                            Desc_mov_inv = q.Desc_mov_inv,
                            nom_tipo_inv = q.nom_tipo_inv,
                            cod_tipo_inv = q.cod_tipo_inv,
                            signo_tipo_inv = q.signo_tipo_inv,
                            IdOrdenCompra = q.IdOrdenCompra,
                            IdMotivo_Inv = q.IdMotivo_Inv,
                            IdResponsable = q.IdResponsable,
                            IdEstadoAproba = q.IdEstadoAproba,
                            nom_EstadoAproba = q.nom_EstadoAproba,
                            IdEstadoDespacho_cat = q.IdEstadoDespacho_cat,
                            Fecha_registro = q.Fecha_registro,
                            co_factura = q.co_factura,
                            nom_proveedor = q.pr_nombre,
                            nom_estado_cierre_oc = q.Descripcion,
                            IdEstadoCierre_oc = q.IdEstado_cierre,
                            IdUsuario = q.IdUsuario
                        });
                    });
                }
                else
                {
                    var Query = oEnti.vwin_Ing_Egr_Inven.
                              Where(q => q.IdEmpresa == IdEmpresa
                              && q.IdSucursal >= IdSucursalIni
                              && q.IdSucursal <= IdSucursalFin
                              && q.IdBodega >= IdBodegaIni
                              && q.IdBodega <= IdBodegaFin
                              && q.cm_fecha >= FechaIni
                              && q.cm_fecha <= FechaFin
                              && q.IdMovi_inven_tipo == IdMovi_inven_tipo).ToList();

                    Query.ForEach(q =>
                    {
                        Lst.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdSucursal = q.IdSucursal,
                            IdBodega = q.IdBodega,
                            IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                            IdNumMovi = q.IdNumMovi,
                            CodMoviInven = q.CodMoviInven,
                            cm_observacion = q.cm_observacion,
                            cm_fecha = q.cm_fecha,
                            Estado = q.Estado,
                            IdCentroCosto = q.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                            signo = q.signo,
                            IdMotivo_oc = Convert.ToInt32(q.IdMotivo_oc),
                            nom_bodega = q.nom_bodega,
                            nom_sucursal = q.nom_sucursal,
                            Desc_mov_inv = q.Desc_mov_inv,
                            nom_tipo_inv = q.nom_tipo_inv,
                            cod_tipo_inv = q.cod_tipo_inv,
                            signo_tipo_inv = q.signo_tipo_inv,
                            IdOrdenCompra = q.IdOrdenCompra,
                            IdMotivo_Inv = q.IdMotivo_Inv,
                            IdResponsable = q.IdResponsable,
                            IdEstadoAproba = q.IdEstadoAproba,
                            nom_EstadoAproba = q.nom_EstadoAproba,
                            IdEstadoDespacho_cat = q.IdEstadoDespacho_cat,
                            Fecha_registro = q.Fecha_registro,
                            co_factura = q.co_factura,
                            nom_proveedor = q.pr_nombre,
                            nom_estado_cierre_oc = q.Descripcion,
                            IdEstadoCierre_oc = q.IdEstado_cierre,
                            IdUsuario = q.IdUsuario
                        });
                    });
                }
                return Lst;
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

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
            int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
        {
            List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdMovi_inven_tipo, a.IdNumMovi, a.CodMoviInven, a.cm_observacion, a.Estado, a.signo, a.IdMotivo_oc, c.bo_Descripcion as nom_bodega, "
                                + " d.Su_Descripcion as nom_sucursal, e.Desc_mov_inv, f.tm_descripcion as nom_tipo_inv, f.Codigo as cod_tipo_inv, f.cm_tipo_movi as signo_tipo_inv, a.IdMotivo_Inv, max(b.IdEstadoAproba) IdEstadoAproba,"
                                + " a.IdUsuario, a.cm_fecha"
                                + " from in_Ing_Egr_Inven as a inner join"
                                + " in_Ing_Egr_Inven_det as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi left join"
                                + " tb_bodega as c on a.IdEmpresa = c.IdEmpresa and a.IdSucursal = c.IdSucursal and a.IdBodega = c.IdBodega left join"
                                + " tb_sucursal as d on a.IdEmpresa = d.IdEmpresa and a.IdSucursal = d.IdSucursal left join"
                                + " in_Motivo_Inven as e on a.IdEmpresa = e.IdEmpresa and a.IdMotivo_Inv = e.IdMotivo_Inv left join"
                                + " in_movi_inven_tipo as f on a.IdEmpresa = f.IdEmpresa and a.IdMovi_inven_tipo = f.IdMovi_inven_tipo"
                                + " where A.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdBodega is not null "
                                + " and a.cm_fecha between datefromparts(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and datefromparts(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ") "
                                + " and a.IdSucursal between " + IdSucursalIni.ToString() + " and " + IdSucursalFin.ToString() + " and a.signo = '"+Tipo_ing_egr+"'"
                                + " and a.IdBodega between " + IdBodegaIni.ToString() + " and " + IdBodegaFin.ToString()
                                + " group by a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdMovi_inven_tipo, a.IdNumMovi, a.CodMoviInven, a.cm_observacion, a.Estado, a.signo, a.IdMotivo_oc, c.bo_Descripcion, d.Su_Descripcion, e.Desc_mov_inv, f.tm_descripcion, f.Codigo, f.cm_tipo_movi, a.IdMotivo_Inv, a.IdUsuario, a.cm_fecha";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lst.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdBodega = Convert.ToInt32(reader["IdBodega"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            CodMoviInven = Convert.ToString(reader["CodMoviInven"]),
                            cm_observacion = Convert.ToString(reader["cm_observacion"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            signo = Convert.ToString(reader["signo"]),
                            IdMotivo_oc = string.IsNullOrEmpty(reader["IdMotivo_oc"].ToString()) ? null : (int?)(reader["IdMotivo_oc"]),
                            nom_bodega = Convert.ToString(reader["nom_bodega"]),
                            nom_sucursal = Convert.ToString(reader["nom_sucursal"]),
                            Desc_mov_inv = Convert.ToString(reader["Desc_mov_inv"]),
                            nom_tipo_inv = Convert.ToString(reader["nom_tipo_inv"]),
                            cod_tipo_inv = Convert.ToString(reader["cod_tipo_inv"]),
                            signo_tipo_inv = Convert.ToString(reader["signo_tipo_inv"]),
                            IdMotivo_Inv = string.IsNullOrEmpty(reader["IdMotivo_Inv"].ToString()) ? null : (int?)reader["IdMotivo_Inv"],
                            IdEstadoAproba = Convert.ToString(reader["IdEstadoAproba"]),
                            IdUsuario = Convert.ToString(reader["IdUsuario"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            nom_EstadoAproba = Convert.ToString(reader["IdEstadoAproba"])
                        });
                    }
                    reader.Close();
                }

                return Lst;
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

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
        {
            List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.vwin_Ing_Egr_Inven_x_in_movi_inve
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.cm_fecha >= FechaIni
                            && q.cm_fecha <= FechaFin
                            && q.signo.Contains(Tipo_ing_egr)
                            select q;

                foreach (var item in Query)
                {
                    in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.signo = item.signo;
                    Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                    Obj.Desc_mov_inv = item.Desc_mov_inv;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.cm_descripcionCorta = item.cm_descripcionCorta;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.Genera_Movi_Inven = item.Genera_Movi_Inven;


                    Lst.Add(Obj);
                }
                return Lst;
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

        public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi)
        {
            try
            {
                in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                EntitiesInventario oEnti = new EntitiesInventario();

                var Query = from q in oEnti.vwin_Ing_Egr_Inven_x_in_movi_inve
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            && q.IdMovi_inven_tipo == IdMovi_inve_tipo
                            && q.IdNumMovi == IdNumMovi
                            select q;

                foreach (var item in Query)
                {
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.signo = item.signo;
                    Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                    Obj.Desc_mov_inv = item.Desc_mov_inv;
                    Obj.tm_descripcion = item.tm_descripcion;
                    Obj.cm_descripcionCorta = item.cm_descripcionCorta;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                }
                return Obj;
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

        public bool ReversarAprobacion(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi)
        {
            EntitiesInventario db_i = new EntitiesInventario();
            EntitiesDBConta db_ct = new EntitiesDBConta();
            try
            {
                db_i.SetCommandTimeOut(3000);
                db_ct.SetCommandTimeOut(3000);
                var lst_det = db_i.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inve_tipo && q.IdNumMovi == IdNumMovi).ToList();
                if (lst_det.Where(q => q.IdNumMovi_inv == null).Count() == 0)
                {
                    var lst_PK_movi = lst_det.GroupBy(q => new { q.IdEmpresa_inv, q.IdSucursal_inv, q.IdBodega_inv, q.IdMovi_inven_tipo_inv, q.IdNumMovi_inv}).Select(q=> new {
                        IdEmpresa_inv = q.Key.IdEmpresa_inv,
                        IdSucursal_inv = q.Key.IdSucursal_inv,
                        IdBodega_inv = q.Key.IdBodega_inv,
                        IdMovi_inven_tipo_inv = q.Key.IdMovi_inven_tipo_inv,
                        IdNumMovi_inv = q.Key.IdNumMovi_inv
                    }).ToList();

                    foreach (var PK_movi in lst_PK_movi)
                    {
                        #region Elimino detalle de movi inve
                        var lst_movi_d = db_i.in_movi_inve_detalle.Where(q => q.IdEmpresa == PK_movi.IdEmpresa_inv
                                        && q.IdSucursal == PK_movi.IdSucursal_inv
                                        && q.IdBodega == PK_movi.IdBodega_inv
                                        && q.IdMovi_inven_tipo == PK_movi.IdMovi_inven_tipo_inv
                                        && q.IdNumMovi == PK_movi.IdNumMovi_inv
                                        ).ToList();

                        foreach (var item in lst_movi_d)
                        {
                            db_i.in_movi_inve_detalle.Remove(item);
                        }
                        #endregion

                        #region Elimino cabecera
                        var movi = db_i.in_movi_inve.Where(q => q.IdEmpresa == PK_movi.IdEmpresa_inv
                                   && q.IdSucursal == PK_movi.IdSucursal_inv
                                   && q.IdBodega == PK_movi.IdBodega_inv
                                   && q.IdMovi_inven_tipo == PK_movi.IdMovi_inven_tipo_inv
                                   && q.IdNumMovi == PK_movi.IdNumMovi_inv).FirstOrDefault();

                        db_i.in_movi_inve.Remove(movi);
                        #endregion

                        #region Obtengo relacion contable y la elimino
                        var PK_conta = db_i.in_movi_inve_x_ct_cbteCble.Where(q => q.IdEmpresa == PK_movi.IdEmpresa_inv
                                        && q.IdSucursal == PK_movi.IdSucursal_inv
                                        && q.IdBodega == PK_movi.IdBodega_inv
                                        && q.IdMovi_inven_tipo == PK_movi.IdMovi_inven_tipo_inv
                                        && q.IdNumMovi == PK_movi.IdNumMovi_inv
                                        ).FirstOrDefault();
                        #endregion

                        if (PK_conta != null)
                        {
                            #region Elimino diario contable
                            var lst_rel_det = db_i.in_movi_inve_detalle_x_ct_cbtecble_det.Where(q => q.IdEmpresa_inv == PK_movi.IdEmpresa_inv
                                        && q.IdSucursal_inv == PK_movi.IdSucursal_inv
                                        && q.IdBodega_inv == PK_movi.IdBodega_inv
                                        && q.IdMovi_inven_tipo_inv == PK_movi.IdMovi_inven_tipo_inv
                                        && q.IdNumMovi_inv == PK_movi.IdNumMovi_inv).ToList();

                            foreach (var item in lst_rel_det)
                            {
                                db_i.in_movi_inve_detalle_x_ct_cbtecble_det.Remove(item);
                            }


                            var lst_conta = db_ct.ct_cbtecble_det.Where(q => q.IdEmpresa == PK_conta.IdEmpresa_ct
                                            && q.IdTipoCbte == PK_conta.IdTipoCbte
                                            && q.IdCbteCble == PK_conta.IdCbteCble
                                            ).ToList();

                            foreach (var item in lst_conta)
                            {
                                db_ct.ct_cbtecble_det.Remove(item);
                            }


                            var Conta = db_ct.ct_cbtecble.Where(q => q.IdEmpresa == PK_conta.IdEmpresa
                                        && q.IdTipoCbte == PK_conta.IdTipoCbte
                                        && q.IdCbteCble == PK_conta.IdCbteCble
                                        ).FirstOrDefault();
                            db_ct.ct_cbtecble.Remove(Conta);
                            #endregion
                            db_i.in_movi_inve_x_ct_cbteCble.Remove(PK_conta);
                        }
                    }
                }
                #region Seteo campos de aprobacion en null
                lst_det.ForEach(q =>
                {
                    q.IdEmpresa_inv = null;
                    q.IdSucursal_inv = null;
                    q.IdBodega_inv = null;
                    q.IdMovi_inven_tipo_inv = null;
                    q.IdNumMovi_inv = null;
                    q.secuencia_inv = null;
                    q.IdEstadoAproba = "PEND";
                });
                #endregion

                db_i.SaveChanges();
                db_ct.SaveChanges();

                db_ct.Dispose();
                db_i.Dispose();
                return true;
            }
            catch (Exception)
            {
                db_ct.Dispose();
                db_i.Dispose();
                throw;
            }
        }

        public Boolean Reversar_Aprobacion(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi, string Genera_movi_inven)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    if (Genera_movi_inven == "S")
                    {
                        Context.spSys_inv_Reversar_aprobacion(IdEmpresa, IdSucursal, IdMovi_inve_tipo, IdNumMovi, true);
                    }
                    else
                    {
                        string comando = "update in_Ing_Egr_Inven_det set IdEstadoAproba = 'PEND' where IdEmpresa = " + IdEmpresa + " and IdSucursal = " + IdSucursal + " and IdMovi_inven_tipo = " + IdMovi_inve_tipo + " and IdNumMovi = " + IdNumMovi;
                        Context.Database.ExecuteSqlCommand(comando);
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
                throw new Exception(ex.ToString());
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_multi_bodega(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
           DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
        {
            List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdMovi_inven_tipo, a.IdNumMovi, a.CodMoviInven, a.cm_observacion, a.Estado, a.signo, a.IdMotivo_oc, c.bo_Descripcion as nom_bodega, "
                                +" d.Su_Descripcion as nom_sucursal, e.Desc_mov_inv, f.tm_descripcion as nom_tipo_inv, f.Codigo as cod_tipo_inv, f.cm_tipo_movi as signo_tipo_inv, a.IdMotivo_Inv, max(b.IdEstadoAproba) IdEstadoAproba,"
                                +" a.IdUsuario, a.cm_fecha"
                                +" from in_Ing_Egr_Inven as a inner join"
                                +" in_Ing_Egr_Inven_det as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi left join"
                                +" tb_bodega as c on a.IdEmpresa = c.IdEmpresa and a.IdSucursal = c.IdSucursal and a.IdBodega = c.IdBodega left join"
                                +" tb_sucursal as d on a.IdEmpresa = d.IdEmpresa and a.IdSucursal = d.IdSucursal left join"
                                +" in_Motivo_Inven as e on a.IdEmpresa = e.IdEmpresa and a.IdMotivo_Inv = e.IdMotivo_Inv left join"
                                +" in_movi_inven_tipo as f on a.IdEmpresa = f.IdEmpresa and a.IdMovi_inven_tipo = f.IdMovi_inven_tipo"
                                + " where A.IdEmpresa = " + IdEmpresa.ToString() + " and a.IdBodega is null "
                                +" and a.cm_fecha between datefromparts(" + FechaIni.Year.ToString() + "," + FechaIni.Month.ToString() + "," + FechaIni.Day.ToString() + ") and datefromparts(" + FechaFin.Year.ToString() + "," + FechaFin.Month.ToString() + "," + FechaFin.Day.ToString() + ") "
                                +" and a.IdSucursal between " + IdSucursalIni.ToString() + " and " + IdSucursalFin.ToString() + " and a.signo = '-'"
                                + " group by a.IdEmpresa, a.IdSucursal, a.IdBodega, a.IdMovi_inven_tipo, a.IdNumMovi, a.CodMoviInven, a.cm_observacion, a.Estado, a.signo, a.IdMotivo_oc, c.bo_Descripcion, d.Su_Descripcion, e.Desc_mov_inv, f.tm_descripcion, f.Codigo, f.cm_tipo_movi, a.IdMotivo_Inv, a.IdUsuario, a.cm_fecha";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Lst.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdBodega = string.IsNullOrEmpty(reader["IdBodega"].ToString()) ? null : (int?)(reader["IdBodega"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            CodMoviInven = Convert.ToString(reader["CodMoviInven"]),
                            cm_observacion = Convert.ToString(reader["cm_observacion"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            signo = Convert.ToString(reader["signo"]),
                            IdMotivo_oc = string.IsNullOrEmpty(reader["IdMotivo_oc"].ToString()) ? null : (int?)(reader["IdMotivo_oc"]),
                            nom_bodega = Convert.ToString(reader["nom_bodega"]),
                            nom_sucursal = Convert.ToString(reader["nom_sucursal"]),
                            Desc_mov_inv = Convert.ToString(reader["Desc_mov_inv"]),
                            nom_tipo_inv = Convert.ToString(reader["nom_tipo_inv"]),
                            cod_tipo_inv = Convert.ToString(reader["cod_tipo_inv"]),
                            signo_tipo_inv = Convert.ToString(reader["signo_tipo_inv"]),
                            IdMotivo_Inv = string.IsNullOrEmpty(reader["IdMotivo_Inv"].ToString()) ? null : (int?)reader["IdMotivo_Inv"],
                            IdEstadoAproba = Convert.ToString(reader["IdEstadoAproba"]),
                            IdUsuario = Convert.ToString(reader["IdUsuario"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                        });
                    }
                    reader.Close();
                }

                return Lst;

                return Lst;
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

        public List<in_Ing_Egr_Inven_Info> Get_List_aprobacion_x_transaccion(int IdEmpresa, int IdSucursal, string Tipo_ing_egr, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<in_Ing_Egr_Inven_Info> Lista;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    Lista = (from q in Context.vwin_Ing_Egr_Inven_aprobacion_x_transaccion
                             where q.IdEmpresa == IdEmpresa
                             && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                             && q.signo == Tipo_ing_egr
                             && q.IdSucursal == IdSucursal
                             select new in_Ing_Egr_Inven_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                 IdNumMovi = q.IdNumMovi,
                                 signo = q.signo,
                                 cm_observacion = q.cm_observacion,
                                 cm_fecha = q.cm_fecha,
                                 nom_sucursal = q.Su_Descripcion,
                                 nom_tipo_inv = q.tm_descripcion,
                                 CodMoviInven = q.CodMoviInven,
                                 Bodega1 = q.Bodega1,
                                 Bodega2 = q.Bodega2
                             }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdBodega, int IdTipoMovi, string Tipo_ing_egr)
        {
            try
            {
                List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
                int IdSucursalIni = IdSucursal;
                int IdSucursalFin = IdSucursal == 0 ? 9999 : IdSucursal;
                int IdBodegaIni = IdBodega;
                int IdBodegaFin = IdBodega == 0 ? 9999 : IdBodega;
                int IdTipoMovi_Ini = IdTipoMovi;
                int IdTipoMovi_Fin = IdTipoMovi == 0 ? 9999 : IdTipoMovi;

                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var Query = from q in oEnti.vwin_Ing_Egr_Inven
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal >= IdSucursalIni
                                && q.IdSucursal <= IdSucursalFin
                                    && q.IdBodega >= IdBodegaIni
                                    && q.IdBodega <= IdBodegaFin
                                    && IdTipoMovi_Ini <= q.IdMovi_inven_tipo
                                    && q.IdMovi_inven_tipo <= IdTipoMovi_Fin
                                && q.signo_tipo_inv.Contains(Tipo_ing_egr)
                                && q.IdEstadoAproba.Equals("PEND")
                                select q;

                    foreach (var item in Query)
                    {
                        in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdSucursal = item.IdSucursal;
                        Obj.IdBodega = item.IdBodega;
                        Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Obj.IdNumMovi = item.IdNumMovi;
                        Obj.CodMoviInven = item.CodMoviInven;
                        Obj.cm_observacion = item.cm_observacion;
                        Obj.cm_fecha = item.cm_fecha;
                        Obj.Estado = item.Estado;
                        Obj.IdCentroCosto = item.IdCentroCosto;
                        Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        Obj.signo = item.signo;
                        Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                        Obj.nom_bodega = item.nom_bodega;
                        Obj.nom_sucursal = item.nom_sucursal;
                        Obj.Desc_mov_inv = item.Desc_mov_inv;
                        Obj.nom_tipo_inv = item.nom_tipo_inv;
                        Obj.cod_tipo_inv = item.cod_tipo_inv;
                        Obj.signo_tipo_inv = item.signo_tipo_inv;

                        Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                        Obj.IdEstadoAproba = item.IdEstadoAproba;
                        Obj.nom_EstadoAproba = item.nom_EstadoAproba;
                        Obj.Checked = false;
                        Obj.Fecha_registro = item.Fecha_registro;
                        Obj.co_factura = item.co_factura;
                        Lst.Add(Obj);
                    }
                }

                return Lst;
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

        public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_para_devolucion(int IdEmpresa, int IdSucursal, int IdTipoMovi, string signo, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
                int IdSucursalIni = IdSucursal;
                int IdSucursalFin = IdSucursal == 0 ? 9999 : IdSucursal;
                int IdTipoMovi_Ini = IdTipoMovi;
                int IdTipoMovi_Fin = IdTipoMovi == 0 ? 9999 : IdTipoMovi;
                Fecha_ini = Fecha_ini.Date;
                Fecha_fin = Fecha_fin.Date;

                using (EntitiesInventario oEnti = new EntitiesInventario())
                {

                    var Query = from q in oEnti.vwin_Ing_Egr_Inven_para_devolucion
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursal >= IdSucursalIni
                                && q.IdSucursal <= IdSucursalFin
                                    && IdTipoMovi_Ini <= q.IdMovi_inven_tipo
                                    && q.IdMovi_inven_tipo <= IdTipoMovi_Fin
                                    && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                                && q.signo.Contains(signo)
                                select q;

                    foreach (var item in Query)
                    {
                        in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                        Obj.IdEmpresa = item.IdEmpresa;
                        Obj.IdSucursal = item.IdSucursal;
                        Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Obj.IdNumMovi = item.IdNumMovi;
                        Obj.cm_observacion = item.cm_observacion;
                        Obj.cm_fecha = item.cm_fecha;
                        Obj.signo = item.signo;
                        Obj.nom_sucursal = item.Su_Descripcion;
                        Obj.nom_tipo_inv = item.tm_descripcion;
                        Obj.CodMoviInven = item.CodMoviInven;

                        Lst.Add(Obj);
                    }
                }

                return Lst;
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

        public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();
                EntitiesInventario oEnti = new EntitiesInventario();
                IQueryable<vwin_Ing_Egr_Inven> Querry;

                Querry = from q in oEnti.vwin_Ing_Egr_Inven
                         where q.IdEmpresa == IdEmpresa
                         && q.IdSucursal == IdSucursal
                         && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                         && q.IdNumMovi == IdNumMovi
                         select q;


                foreach (var item in Querry)
                {

                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdSucursal = item.IdSucursal;
                    Obj.IdBodega = item.IdBodega;
                    Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    Obj.IdNumMovi = item.IdNumMovi;
                    Obj.CodMoviInven = item.CodMoviInven;
                    Obj.cm_observacion = item.cm_observacion;
                    Obj.cm_fecha = item.cm_fecha;
                    Obj.Estado = item.Estado;
                    Obj.IdCentroCosto = item.IdCentroCosto;
                    Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                    Obj.signo = item.signo;
                    Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                    Obj.nom_bodega = item.nom_bodega;
                    Obj.nom_sucursal = item.nom_sucursal;
                    Obj.nom_motivo = item.nom_motivo;
                    Obj.nom_tipo_inv = item.nom_tipo_inv;
                    Obj.cod_tipo_inv = item.cod_tipo_inv;
                    Obj.signo_tipo_inv = item.signo_tipo_inv;
                    Obj.co_factura = item.co_factura;
                    Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                }

                return Obj;
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

        public Boolean ModificarDB_desde_transferencia(in_Ing_Egr_Inven_Info info)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_Ing_Egr_Inven Entity = Context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);

                    if (Entity != null)
                    {
                        Entity.cm_fecha = info.cm_fecha;
                        Entity.cm_observacion = info.cm_observacion;
                        Context.SaveChanges();
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
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB_proceso_cerrado(in_Ing_Egr_Inven_Info info, ref string msgs)
        {
            try
            {
                using (EntitiesInventario Context = new EntitiesInventario())
                {
                    in_Ing_Egr_Inven Entity = Context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                    if (Entity != null)
                    {
                        Entity.cm_observacion = info.cm_observacion;
                        //Entity.cm_fecha = info.cm_fecha.Date;
                        Entity.CodMoviInven = info.CodMoviInven;
                        Entity.IdMotivo_Inv = info.IdMotivo_Inv;

                        Context.SaveChanges();
                        foreach (var item in info.listIng_Egr)
                        {
                            if (item.IdEmpresa_inv != null)
                            {
                                in_movi_inve_Info info_movi = new in_movi_inve_Info();
                                info_movi.IdEmpresa = Convert.ToInt32(item.IdEmpresa_inv);
                                info_movi.IdSucursal = Convert.ToInt32(item.IdSucursal_inv);
                                info_movi.IdBodega = Convert.ToInt32(item.IdBodega_inv);
                                info_movi.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
                                info_movi.IdNumMovi = Convert.ToDecimal(item.IdNumMovi_inv);
                                info_movi.cm_observacion = info.cm_observacion;
                                //info_movi.cm_fecha = info.cm_fecha;
                                info_movi.CodMoviInven = info.CodMoviInven;

                                in_movi_inve_Data data_movi = new in_movi_inve_Data();
                                data_movi.ModificarDB_proceso_cerrado(info_movi, ref msgs);
                            }
                            else
                            {
                                /*
                                in_Ing_Egr_Inven_det_Data odata = new in_Ing_Egr_Inven_det_Data();

                                if (info.IdBodega != null)
                                {
                                    item.IdBodega = info.IdBodega;
                                    odata.ModificarDB_proceso_cerrado(item);
                                    Entity.IdBodega = info.IdBodega;
                                    Context.SaveChanges();
                                }*/

                                msgs = "Se actualizó la transacción exitosamente.";
                            }
                        }
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
                throw new Exception(ex.ToString());
            }
        }

        public bool ValidarEstaAprobado(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var cont = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inven_tipo && q.IdNumMovi == IdNumMovi && q.IdNumMovi_inv != null).Count();
                    if (cont > 0)
                        return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ReversarContabilizacion(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                EntitiesInventario dbInv = new EntitiesInventario();
                EntitiesDBConta dbConta = new EntitiesDBConta();
                dbInv.SetCommandTimeOut(3000);
                dbConta.SetCommandTimeOut(3000);
                var lstMovi = dbInv.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inven_tipo && q.IdNumMovi == IdNumMovi && q.IdNumMovi_inv != null).ToList();
                if (lstMovi.Count > 0)
                {
                    var ListaPKMovi_inven = lstMovi.GroupBy(q => new { q.IdEmpresa_inv, q.IdSucursal_inv, q.IdBodega_inv, q.IdMovi_inven_tipo_inv, q.IdNumMovi_inv }).ToList();
                    foreach (var item in ListaPKMovi_inven)
                    {
                        var lstRelCab = dbInv.in_movi_inve_x_ct_cbteCble.Where(q =>
                            q.IdEmpresa == item.Key.IdEmpresa_inv &&
                            q.IdSucursal == item.Key.IdSucursal_inv &&
                            q.IdBodega == item.Key.IdBodega_inv &&
                            q.IdMovi_inven_tipo == item.Key.IdMovi_inven_tipo_inv &&
                            q.IdNumMovi == item.Key.IdNumMovi_inv).ToList();

                        foreach (var relCab in lstRelCab)
                        {
                            dbInv.in_movi_inve_x_ct_cbteCble.Remove(relCab);

                            var lstCtDet = dbConta.ct_cbtecble_det.Where(q => q.IdEmpresa == relCab.IdEmpresa_ct && q.IdTipoCbte == relCab.IdTipoCbte && q.IdCbteCble == relCab.IdCbteCble).ToList();
                            foreach (var CtDet in lstCtDet)
                            {
                                dbConta.ct_cbtecble_det.Remove(CtDet);
                            }

                            var CtCab = dbConta.ct_cbtecble.Where(q => q.IdEmpresa == relCab.IdEmpresa_ct && q.IdTipoCbte == relCab.IdTipoCbte && q.IdCbteCble == relCab.IdCbteCble).FirstOrDefault();
                            dbConta.ct_cbtecble.Remove(CtCab);
                        }

                        var lstRelDet = dbInv.in_movi_inve_detalle_x_ct_cbtecble_det.Where(q =>
                            q.IdEmpresa_inv == item.Key.IdEmpresa_inv &&
                            q.IdSucursal_inv == item.Key.IdSucursal_inv &&
                            q.IdBodega_inv == item.Key.IdBodega_inv &&
                            q.IdMovi_inven_tipo_inv == item.Key.IdMovi_inven_tipo_inv &&
                            q.IdNumMovi_inv == item.Key.IdNumMovi_inv).ToList();

                        foreach (var relDet in lstRelDet)
                        {
                            dbInv.in_movi_inve_detalle_x_ct_cbtecble_det.Remove(relDet);
                        }
                    }
                    dbInv.SaveChanges();
                    dbConta.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<in_Ing_Egr_Inven_Info> GetListDiferenciasContable(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_Ing_Egr_Inven_Info> Lista = new List<in_Ing_Egr_Inven_Info>();

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.SetCommandTimeOut(3000);
                    var lst = db.SPINV_GetMovimientosPorContabilizar(IdEmpresa, FechaIni, FechaFin);
                    foreach (var item in lst)
                    {
                        Lista.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdMovi_inven_tipo = item.IdMovi_inven_tipo,
                            IdNumMovi = item.IdNumMovi,
                            nom_sucursal = item.Su_Descripcion,
                            cm_fecha = item.cm_fecha,
                            cm_observacion = item.cm_observacion,
                            signo = item.signo,
                            tm_descripcion = item.tm_descripcion,
                            TotalInventario = item.TotalInventario,
                            TotalContabilidad = item.TotalContabilidad,
                            Diferencia = item.Diferencia,
                        });
                    }
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool NuevoGuardar(in_Ing_Egr_Inven_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.in_Ing_Egr_Inven.Add(new in_Ing_Egr_Inven
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdSucursal = info.IdSucursal,
                        IdBodega = info.IdBodega,
                        IdNumMovi = info.IdNumMovi = GetId(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo),
                        signo = info.signo,
                        IdMotivo_oc = info.IdMotivo_oc == 0 ? null : info.IdMotivo_oc,
                        IdMotivo_Inv = info.IdMotivo_Inv == 0 ? null : info.IdMotivo_Inv,
                        IdMovi_inven_tipo = info.IdMovi_inven_tipo,
                        CodMoviInven = (info.CodMoviInven == "" || info.CodMoviInven == null) ? info.IdNumMovi.ToString() : info.CodMoviInven,
                        cm_observacion = (info.cm_observacion == "") ? "" : info.cm_observacion,
                        cm_fecha = info.cm_fecha == null ? DateTime.Now : info.cm_fecha.Date,
                        IdUsuario = info.IdUsuario,
                        Fecha_Transac = DateTime.Now,
                        Estado = "A"
                    });
                    int Secuencia = 1;
                    double CantidadConvertida = 0;
                    var lstEgr = info.listIng_Egr.Where(q => q.IdProducto != null && Math.Abs(q.dm_cantidad_sinConversion) > 0).ToList();
                    foreach (var item in lstEgr)
                    {
                        var producto = db.in_Producto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == item.IdProducto).FirstOrDefault();
                        if (producto == null)
                            return false;
                        if (info.signo == "-")
                        {
                            var costo_historico = db.in_producto_x_tb_bodega_Costo_Historico.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto).OrderByDescending(q => q.fecha).ThenByDescending(q=> q.Secuencia).FirstOrDefault();
                            if (costo_historico != null)
                            {
                                item.mv_costo_sinConversion = costo_historico == null ? 0 : costo_historico.costo;
                                item.mv_costo = costo_historico == null ? 0 : costo_historico.costo;        
                            }
                            
                        }

                        db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSucursal = info.IdSucursal,
                            IdMovi_inven_tipo = info.IdMovi_inven_tipo,
                            IdNumMovi = info.IdNumMovi,
                            Secuencia = Secuencia++,
                            IdBodega = item.IdBodega ?? (info.IdBodega ?? 0),
                            IdProducto = item.IdProducto,

                            dm_cantidad = CantidadConvertida = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto, item.IdUnidadMedida_sinConversion, Math.Abs(item.dm_cantidad_sinConversion)) * (info.signo == "+" ? 1 : -1),
                            mv_costo = info.signo == "+" ? ((Math.Abs(item.dm_cantidad_sinConversion) * item.mv_costo_sinConversion) / (CantidadConvertida == 0 ? 1 : CantidadConvertida)) : (item.mv_costo),
                            IdUnidadMedida = producto.IdUnidadMedida_Consumo,

                            dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion) * (info.signo == "+" ? 1 : -1),
                            mv_costo_sinConversion = item.mv_costo_sinConversion,
                            IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion,
                            
                            IdSucursal_oc = item.IdSucursal_oc,
                            IdEmpresa_oc = item.IdEmpresa_oc,
                            IdOrdenCompra = item.IdOrdenCompra,
                            Secuencia_oc = item.Secuencia_oc,

                            IdEstadoAproba = "PEND",
                            dm_precio = 0,
                            dm_observacion = item.dm_observacion ?? "",

                            IdCentroCosto = item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo
                        });
                    }
                    db.SaveChanges();

                    var param = db.in_parametro.Where(q => q.IdEmpresa == info.IdEmpresa).FirstOrDefault();
                    if (param != null && (info.signo == "-" ? param.IdEstadoAproba_x_Egr  : param.IdEstadoAproba_x_Ing) == "APRO")
                    {
                        in_movi_inve_Data odataMoviInven = new in_movi_inve_Data();
                        if (!odataMoviInven.AprobarData(info.IdEmpresa,info.IdSucursal,info.IdMovi_inven_tipo,info.IdNumMovi,info.signo,info.IdUsuario,ref mensaje))
                        {
                            return false;
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

        public bool NuevoModificar(in_Ing_Egr_Inven_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    #region Cabecera
                    //Entity.IdMotivo_oc = info.IdMotivo_oc;
                    Entity.CodMoviInven = info.CodMoviInven;
                    Entity.cm_observacion = info.cm_observacion ?? "";
                    //Entity.cm_fecha = info.cm_fecha;
                    Entity.IdUsuarioUltModi = info.IdUsuario;
                    Entity.Fecha_UltMod = DateTime.Now;
                    #endregion

                    #region Detalle
                    var lst = db.in_Ing_Egr_Inven_det.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi).ToList();
                    foreach (var item in lst)
                    {
                        db.in_Ing_Egr_Inven_det.Remove(item);
                    }
                    int Secuencia = 1;
                    double CantidadConvertida = 0;
                    var lstEgr = info.listIng_Egr.Where(q => q.IdProducto != null && Math.Abs(q.dm_cantidad_sinConversion) > 0).ToList();
                    foreach (var item in lstEgr)
                    {
                        var producto = db.in_Producto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == item.IdProducto).FirstOrDefault();
                        if (producto == null)
                            return false;

                        db.in_Ing_Egr_Inven_det.Add(new in_Ing_Egr_Inven_det
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdSucursal = info.IdSucursal,
                            IdMovi_inven_tipo = info.IdMovi_inven_tipo,
                            IdNumMovi = info.IdNumMovi,
                            Secuencia = Secuencia++,
                            IdBodega = item.IdBodega ?? (info.IdBodega ?? 0),
                            IdProducto = item.IdProducto,

                            dm_cantidad = CantidadConvertida = odataUnidadMedida.GetCantidadConvertida(info.IdEmpresa, item.IdProducto, item.IdUnidadMedida_sinConversion, Math.Abs(item.dm_cantidad_sinConversion)) * (info.signo == "+" ? 1 : -1),
                            mv_costo = (Math.Abs(item.dm_cantidad_sinConversion) * item.mv_costo_sinConversion) / (CantidadConvertida == 0 ? 1 : CantidadConvertida),
                            IdUnidadMedida = producto.IdUnidadMedida_Consumo,

                            dm_cantidad_sinConversion = Math.Abs(item.dm_cantidad_sinConversion) * (info.signo == "+" ? 1 : -1),
                            mv_costo_sinConversion = item.mv_costo_sinConversion,
                            IdUnidadMedida_sinConversion = item.IdUnidadMedida_sinConversion,

                            IdSucursal_oc = item.IdSucursal_oc,
                            IdEmpresa_oc = item.IdEmpresa_oc,
                            IdOrdenCompra = item.IdOrdenCompra,
                            Secuencia_oc = item.Secuencia_oc,

                            IdEstadoAproba = "PEND",
                            dm_precio = 0,
                            dm_observacion = item.dm_observacion ?? "",

                            IdCentroCosto = item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo
                        });
                    }
                    #endregion
                    
                    db.SaveChanges();

                    var param = db.in_parametro.Where(q => q.IdEmpresa == info.IdEmpresa).FirstOrDefault();
                    if (param != null && (info.signo == "-" ? param.IdEstadoAproba_x_Egr : param.IdEstadoAproba_x_Ing) == "APRO")
                    {
                        in_movi_inve_Data odataMoviInven = new in_movi_inve_Data();
                        if (!odataMoviInven.AprobarData(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo, info.IdNumMovi, info.signo, info.IdUsuario, ref mensaje))
                        {
                            return false;
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

        public bool CambiarFecha(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi, DateTime Fecha, string IdUsuario)
        {
            try
            {
                Fecha = Fecha.Date;
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.SPINV_CambiarFechaMovimiento(IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi, Fecha);

                    var Entity = db.in_Ing_Egr_Inven.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inven_tipo && q.IdNumMovi == IdNumMovi).FirstOrDefault();
                    if (Entity == null)
                        return false;


                    Entity.IdUsuarioUltModi = IdUsuario;
                    Entity.Fecha_UltMod = DateTime.Now;
                    db.SaveChanges();
                        
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_Ing_Egr_Inven_Info> GetListIngresoOc(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<in_Ing_Egr_Inven_Info> Lista = new List<in_Ing_Egr_Inven_Info>();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    string query = "select a.IdEmpresa, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi, d.Su_Descripcion, e.bo_Descripcion, a.cm_fecha, a.cm_observacion, a.IdMotivo_Inv, f.Desc_mov_inv, "
                                +" min(b.IdEstadoAproba) IdEstadoAproba, max(g.codigo+'-'+cast(b.IdOrdenCompra as varchar)) as CodigoOC, a.Estado, /*max(h.num_documento) num_documento,*/ max(l.pe_nombreCompleto) pe_nombreCompleto, max(j.IdEstado_cierre) IdEstado_cierre, a.IdUsuario"
                                +" from in_Ing_Egr_Inven as a inner join"
                                +" in_Ing_Egr_Inven_det as b on a.IdEmpresa = b.IdEmpresa and a.IdSucursal = b.IdSucursal and a.IdMovi_inven_tipo = b.IdMovi_inven_tipo and a.IdNumMovi = b.IdNumMovi inner join"
                                +" com_parametro as c on a.IdEmpresa = c.IdEmpresa and c.IdMovi_inven_tipo_OC = a.IdMovi_inven_tipo left join"
                                +" tb_sucursal as d on a.IdEmpresa = d.IdEmpresa and a.IdSucursal = d.IdSucursal left join"
                                +" tb_bodega as e on a.IdEmpresa = e.IdEmpresa and a.IdSucursal = e.IdSucursal and a.IdBodega = e.IdBodega left join"
                                +" in_Motivo_Inven as f on a.IdEmpresa = f.IdEmpresa and a.IdMotivo_Inv = f.IdMotivo_Inv left join "
                                +" tb_sucursal as g on b.IdEmpresa_oc = g.IdEmpresa and b.IdSucursal_oc = g.IdSucursal left join"
                                +" ("
                                +" select x1.IdEmpresa, x1.Serie+'-'+x1.Serie2+'-'+ x1.num_documento num_documento, x2.IdSucursal_Ing_Egr_Inv, x2.IdMovi_inven_tipo_Ing_Egr_Inv, x2.IdNumMovi_Ing_Egr_Inv, x2.Secuencia_Ing_Egr_Inv "
                                +" from cp_Aprobacion_Ing_Bod_x_OC AS x1 inner join"
                                +" cp_Aprobacion_Ing_Bod_x_OC_det as x2 on x1.IdEmpresa = x2.IdEmpresa and x1.IdAprobacion = x2.IdAprobacion inner join "
                                +" in_Ing_Egr_Inven as x3 on x2.IdEmpresa = x3.IdEmpresa and x2.IdSucursal_Ing_Egr_Inv = x3.IdSucursal and x2.IdMovi_inven_tipo_Ing_Egr_Inv = x3.IdMovi_inven_tipo and x2.IdNumMovi_Ing_Egr_Inv = x3.IdNumMovi"
                                + " where x1.IdEmpresa = " + IdEmpresa.ToString() + " and x1.IdCbteCble_Ogiro is not null and x3.cm_Fecha between DATEFROMPARTS("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+") and DATEFROMPARTS("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+") "
                                + (IdSucursal == 0 ? "" : " AND x3.IdSucursal = "+IdSucursal.ToString())
                                +" ) as h on b.IdEmpresa = h.IdEmpresa and b.IdSucursal = h.IdSucursal_Ing_Egr_Inv and b.IdMovi_inven_tipo = h.IdMovi_inven_tipo_Ing_Egr_Inv and b.IdNumMovi = h.IdNumMovi_Ing_Egr_Inv and b.Secuencia = h.Secuencia_Ing_Egr_Inv left join"
                                +" com_ordencompra_local_det as i on b.IdEmpresa_oc = i.IdEmpresa and b.IdSucursal_oc = i.IdSucursal and b.IdOrdenCompra = i.IdOrdenCompra and b.Secuencia_oc = i.Secuencia left join"
                                +" com_ordencompra_local as j on i.IdEmpresa = j.IdEmpresa and i.IdSucursal = j.IdSucursal and i.IdOrdenCompra = j.IdOrdenCompra left join"
                                +" cp_proveedor as k on k.IdEmpresa = j.IdEmpresa and k.IdProveedor = j.IdProveedor left join"
                                +" tb_persona as l on k.IdPersona = l.IdPersona"
                                +" where a.IdEmpresa = "+IdEmpresa.ToString()+" and a.cm_fecha between DATEFROMPARTS("+FechaIni.Year.ToString()+","+FechaIni.Month.ToString()+","+FechaIni.Day.ToString()+") and DATEFROMPARTS("+FechaFin.Year.ToString()+","+FechaFin.Month.ToString()+","+FechaFin.Day.ToString()+") "
                                + (IdSucursal == 0 ? "" : " AND a.IdSucursal = "+IdSucursal.ToString())
                                + (IdBodega == 0 ? "" : " AND a.IdBodega = " + IdBodega.ToString())
                                +" group by a.IdEmpresa, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi, d.Su_Descripcion, e.bo_Descripcion, a.cm_fecha, a.cm_observacion, a.IdMotivo_Inv, f.Desc_mov_inv, a.Estado, a.IdUsuario"
                                + " order by a.IdEmpresa, a.IdSucursal, a.IdMovi_inven_tipo, a.IdNumMovi desc";

                    SqlCommand command = new SqlCommand(query,connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Lista.Add(new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            nom_sucursal = Convert.ToString(reader["Su_Descripcion"]),
                            nom_bodega = Convert.ToString(reader["bo_Descripcion"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            cm_observacion = Convert.ToString(reader["cm_observacion"]),
                            IdMotivo_Inv = Convert.ToInt32(reader["IdMotivo_Inv"]),
                            Desc_mov_inv = Convert.ToString(reader["Desc_mov_inv"]),
                            IdEstadoAproba = Convert.ToString(reader["IdEstadoAproba"]),
                            CodigoOC = Convert.ToString(reader["CodigoOC"]),
                            Estado = Convert.ToString(reader["Estado"]),
                            //co_factura = Convert.ToString(reader["num_documento"]),
                            nom_proveedor = Convert.ToString(reader["pe_nombreCompleto"]),
                            nom_estado_cierre_oc = Convert.ToString(reader["IdEstado_cierre"]),
                            IdUsuario = Convert.ToString(reader["IdUsuario"])
                        });
                    }
                    reader.Close();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public in_Ing_Egr_Inven_Info GetInfo(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                in_Ing_Egr_Inven_Info info = new in_Ing_Egr_Inven_Info();

                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();

                    string query = "select IdEmpresa,IdSucursal,IdMovi_inven_tipo,IdNumMovi,IdBodega,signo,CodMoviInven,cm_observacion,cm_fecha,IdUsuario,Estado,IdCentroCosto,IdCentroCosto_sub_centro_costo,IdMotivo_oc,IdMotivo_Inv,IdResponsable, Estado "
                                + " from in_Ing_Egr_Inven"
                                + " where IdEmpresa = "+IdEmpresa.ToString()+" and IdSucursal = "+IdSucursal.ToString()+" and IdMovi_inven_tipo = "+IdMovi_inven_tipo.ToString()+" and IdNumMovi = "+IdNumMovi.ToString();
                    SqlCommand command = new SqlCommand(query,connection);
                    var ValidateValue = command.ExecuteScalar();
                    if (ValidateValue == null)
                        return null;

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        info = new in_Ing_Egr_Inven_Info
                        {
                            IdEmpresa = Convert.ToInt32(reader["IdEmpresa"]),
                            IdSucursal = Convert.ToInt32(reader["IdSucursal"]),
                            IdMovi_inven_tipo = Convert.ToInt32(reader["IdMovi_inven_tipo"]),
                            IdNumMovi = Convert.ToDecimal(reader["IdNumMovi"]),
                            IdBodega = string.IsNullOrEmpty(reader["IdBodega"].ToString()) ? null : (int?)(reader["IdBodega"]),
                            signo = Convert.ToString(reader["signo"]),
                            CodMoviInven = Convert.ToString(reader["CodMoviInven"]),
                            cm_observacion = Convert.ToString(reader["cm_observacion"]),
                            cm_fecha = Convert.ToDateTime(reader["cm_fecha"]),
                            IdUsuario = Convert.ToString(reader["IdUsuario"]),
                            IdCentroCosto = Convert.ToString(reader["IdCentroCosto"]),
                            IdCentroCosto_sub_centro_costo = Convert.ToString(reader["IdCentroCosto_sub_centro_costo"]),
                            IdMotivo_Inv = string.IsNullOrEmpty(reader["IdMotivo_Inv"].ToString()) ? null : (int?)(reader["IdMotivo_Inv"]),
                            IdMotivo_oc = string.IsNullOrEmpty(reader["IdMotivo_oc"].ToString()) ? null : (int?)(reader["IdMotivo_oc"]),
                            IdResponsable = string.IsNullOrEmpty(reader["IdResponsable"].ToString()) ? null : (decimal?)(reader["IdResponsable"]),
                            Estado  = Convert.ToString(reader["Estado"]),
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

        public bool ValidarTieneFactura(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionERP.GetConnectionString()))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "select a.idempresa from cp_Aprobacion_ing_bod_X_oc as a inner join"
                                        +" cp_Aprobacion_ing_bod_X_oc_DeT as b on a.idempresa = b.idempresa and a.idaprobacion = b.idaprobacion"
                                        +" where b.IdEmpresa_Ing_Egr_Inv = "+IdEmpresa.ToString()+" and IdSucursal_Ing_Egr_Inv = "+IdSucursal.ToString()+" and IdNumMovi_Ing_Egr_Inv = "+IdNumMovi.ToString()+" and IdMovi_inven_tipo_Ing_Egr_Inv = "+IdMovi_inven_tipo.ToString();
                    var ResultValue = command.ExecuteScalar();
                    if (ResultValue == null)
                        return false;
                }

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
