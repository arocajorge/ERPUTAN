using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion_Grafinpren;
using Core.Erp.Data.Produccion_Edehsa;

using Core.Erp.Info.Produccion_Edehsa;

using Core.Erp.Info.class_sri.GuiaRemision;
using Core.Erp.Info.class_sri.FacturaV2;
using Core.Erp.Info.class_sri;



namespace Core.Erp.Data.Facturacion
{
    public class fa_guia_remision_Data
    {
        string mensaje = "";
        fa_guia_remision_det_Data DataDetalle = new fa_guia_remision_det_Data();

        public List<fa_guia_remision_Info> Get_List_guia_remision(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                List<fa_guia_remision_Info> lM = new List<fa_guia_remision_Info>();
                EntitiesFacturacion OEFacturacion = new EntitiesFacturacion();

                var select_tipo_nota = from A in OEFacturacion.fa_guia_remision
                                       where A.IdEmpresa == IdEmpresa
                                       && A.IdSucursal==IdSucursal
                                       && A.IdBodega==IdBodega
                                       select A;


                foreach (var item in select_tipo_nota)
                {
                    fa_guia_remision_Info info = new fa_guia_remision_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdCliente = item.IdCliente;
                    
                    info.Estado = item.Estado;
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ModificarDB(fa_guia_remision_Info info, ref string msg)
        {
            try
            {
                Boolean res = false;


                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_guia_remision.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega== info.IdBodega&& obj.IdGuiaRemision == info.IdGuiaRemision);

                    if (contact != null)
                    {
                        contact.gi_fecha = info.gi_fecha;
                        contact.gi_fech_venc = info.gi_fech_venc;
                        contact.gi_FechaIniTraslado = info.gi_FecIniTraslado;
                        contact.gi_FechaFinTraslado = info.gi_FecFinTraslado;
                        contact.gi_Observacion = info.gi_Observacion;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.Direccion_Origen = info.Direccion_Origen;
                        contact.placa = info.placa;
                        contact.ruta = info.ruta;
                        contact.Direccion_Destino = info.Direccion_Destino;
                        context.SaveChanges();

                        foreach (var item in info.ListaDetalle)
                        {
                            item.IdEmpresa = info.IdEmpresa;
                            item.IdBodega = info.IdBodega;
                            item.IdSucursal = info.IdSucursal;
                            item.IdGuiaRemision = info.IdGuiaRemision;
                        }

                        if (DataDetalle.ModificarDB(info.ListaDetalle))
                        {
                            res= true;
                        }
                        else
                        {
                            res= false;
                        }
                    }
                }

                return res;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public decimal GetId(int IdEmpresa,int IdSucursal, int IdBodega)
        {
            try
            {
                decimal Id;
                EntitiesFacturacion OEFacturacion = new EntitiesFacturacion();
                var select = from q in OEFacturacion.fa_guia_remision
                             where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_IdGuiaRemision = (from q in OEFacturacion.fa_guia_remision
                                          where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                                          select q.IdGuiaRemision).Max();
                    Id = Convert.ToInt32(select_IdGuiaRemision.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(fa_guia_remision_Info info, ref decimal id, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var address = new fa_guia_remision();

                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdGuiaRemision = info.IdGuiaRemision = id = GetId(info.IdEmpresa,info.IdSucursal,info.IdBodega);
                    address.CodGuiaRemision = (info.CodGuiaRemision == "") ? "GUIA-" + id : info.CodGuiaRemision;
                    address.CodDocumentoTipo = info.CodDocumentoTipo;
                    address.Serie1 = info.Serie1;
                    address.Serie2 = info.Serie2;                   
                    address.NumGuia_Preimpresa = info.NumGuia_Preimpresa;
                    address.NUAutorizacion = info.NumAutorizacion;
                    address.IdCliente = info.IdCliente;
                    address.IdVendedor = info.IdVendedor;
                    address.IdTransportista = info.IdTransportista;
                    address.gi_fecha = info.gi_fecha;
                    address.gi_fech_venc = info.gi_fech_venc;
                    address.gi_Observacion = info.gi_Observacion;
                    address.gi_TotalKilos = info.gi_TotalKilos;
                    address.gi_TotalQuintales = info.gi_TotalQuintales;
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Impreso = "N";
                    address.Estado ="A";
                    address.IdPeriodo = info.IdPeriodo; 
                    address.gi_flete = info.gi_flete;
                    address.gi_interes = info.gi_interes;
                    address.gi_seguro = info.gi_seguro;
                    address.gi_OtroValor1 = info.gi_OtroValor1;
                    address.gi_OtroValor2 = info.gi_OtroValor2;

                    address.gi_FechaIniTraslado = info.gi_FecIniTraslado;
                    address.gi_FechaFinTraslado = info.gi_FecFinTraslado;

                    address.Direccion_Origen = info.Direccion_Origen;
                    address.placa = info.placa;
                    address.ruta = info.ruta == "" ? null : info.ruta;
                    address.Direccion_Destino = info.Direccion_Destino;

                    address.idMotivo_traslado = info.idMotivo_traslado;

                    context.fa_guia_remision.Add(address);
                    context.SaveChanges();
                    info.ListaDetalle.ForEach(var => { var.IdEmpresa = address.IdEmpresa; var.IdGuiaRemision = address.IdGuiaRemision; var.IdBodega = address.IdBodega; var.IdSucursal = address.IdSucursal;});
                    info.CodGuiaRemision = address.CodGuiaRemision;

                   

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_guia_remision_Info info, ref  string msg)
        {
            try
            {
                EntitiesFacturacion OEFacturacion = new EntitiesFacturacion();
                var select = from q in OEFacturacion.fa_cliente
                             where q.IdEmpresa == info.IdEmpresa && q.IdCliente == info.IdCliente
                             select q;

                if (select.ToList().Count > 0)
                {
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {
                        var contact = context.fa_cliente.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdCliente == info.IdCliente );
                        if (contact != null)
                        {
                            contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                            contact.Fecha_UltAnu = info.Fecha_UltAnu;
                            contact.Estado = "I";
                            context.SaveChanges();
                            msg = "Se ha procedido anular el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                        }
                    }

                    return true;
                }
                else
                {
                    msg = "No es posible anular el registro del Cliente #: " + info.IdCliente.ToString() + " debido a que ya se encuentra anulado.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_guia_remision_Info> Get_List_guia_remision(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin
            , DateTime FechaIni, DateTime FechaFin) 
        {
            try
            {
                List<fa_guia_remision_Info> lst = new List<fa_guia_remision_Info>();

                EntitiesFacturacion OEnti = new EntitiesFacturacion();

                if (IdSucursalFin == 0)
                {
                    IdSucursalIni = 0;
                    IdSucursalFin = 5000;
                }

                if (IdBodegaFin == 0)
                {
                    IdBodegaIni = 0;
                    IdBodegaFin = 5000;
                }

                var selectGuia = from q in OEnti.vwfa_Guia_Remision
                             where q.IdEmpresa == IdEmpresa
                                      && q.IdBodega >= IdBodegaIni && q.IdBodega <= IdBodegaFin
                                      && q.IdSucursal >= IdSucursalIni && q.IdSucursal <= IdSucursalFin
                                      && q.gi_fecha >= FechaIni && q.gi_fecha <= FechaFin
                             select q;

                  var CabeceraGuia = from cab in selectGuia
                                    group cab by new
                                    { cab.IdEmpresa,
                                        cab.CodGuiaRemision,
                                        cab.IdBodega,
                                        cab.IdSucursal,
                                        cab.Serie1,
                                        cab.Serie2,
                                        cab.NumGuia_Preimpresa,
                                        cab.Impreso,
                                       cab.IdCliente,
                                       cab.gi_TotalKilos,
                                       cab.gi_TotalQuintales,
                                        cab.bo_Descripcion,
                                        cab.Su_Descripcion,
                                        cab.Ve_Vendedor,
                                        cab.pe_apellido,
                                        cab.pe_nombre,
                                        cab.IdGuiaRemision,
                                        cab.Estado,
                                        cab.gi_Observacion,
                                        cab.IdTransportista,
                                        cab.gi_fecha,
                                        cab.gi_fech_venc,
                                        cab.gi_plazo,
                                        cab.IdPeriodo ,
                                        cab.gi_flete,
                                        cab.gi_interes,
                                        cab.gi_seguro,
                                        cab.gi_OtroValor1,
                                        cab.gi_OtroValor2,
                                        cab.CodDocumentoTipo,
                                        cab.gi_FechaIniTraslado,
                                        cab.gi_FechaFinTraslado
                                    }
                                          into grouping
                                          select new { grouping.Key, Subototal = grouping.Sum(p => p.gi_Subtotal), Iva = grouping.Sum(p => p.gi_iva), Total = grouping.Sum(p => p.gi_total) };


                  foreach (var item in CabeceraGuia)
                  {
                      fa_guia_remision_Info info = new fa_guia_remision_Info();
                      info.CodGuiaRemision = item.Key.CodGuiaRemision;
                      info.IdEmpresa = item.Key.IdEmpresa;
                      info.IdSucursal = item.Key.IdSucursal;
                      info.IdBodega = item.Key.IdBodega;
                      info.Bodega = item.Key.bo_Descripcion;
                      info.IdCliente = item.Key.IdCliente;
                      info.gi_TotalKilos = item.Key.gi_TotalKilos;
                      info.gi_TotalQuintales = item.Key.gi_TotalQuintales;
                      info.Sucursal = item.Key.Su_Descripcion;
                      info.Vendedor = item.Key.Ve_Vendedor;
                      info.Cliente = item.Key.pe_nombre + " " + item.Key.pe_apellido;
                      info.Estado = item.Key.Estado;
                      info.Subtotal = Convert.ToDecimal(item.Subototal);
                      info.Total = item.Total;
                      info.Iva = item.Iva;
                      info.IdGuiaRemision = item.Key.IdGuiaRemision;
                      info.gi_Observacion = item.Key.gi_Observacion;
                      info.IdTransportista = item.Key.IdTransportista;
                      info.gi_fecha = item.Key.gi_fecha;
                      info.gi_plazo = item.Key.gi_plazo;
                      info.gi_fech_venc = Convert.ToDateTime(item.Key.gi_fech_venc);
                      info.CodDocumentoTipo = item.Key.CodDocumentoTipo;
                      info.Serie1 = item.Key.Serie1;
                      info.Serie2 = item.Key.Serie2;
                      info.NumGuia_Preimpresa = item.Key.NumGuia_Preimpresa;
                      info.Impreso = item.Key.Impreso;


                      info.IdPeriodo = item.Key.IdPeriodo;
                      info.gi_flete = item.Key.gi_flete;
                      info.gi_interes= item.Key.gi_interes;
                      info.gi_seguro= item.Key.gi_seguro;
                      info.gi_OtroValor1= item.Key.gi_OtroValor1;
                      info.gi_OtroValor2= item.Key.gi_OtroValor2;

                      info.gi_FecIniTraslado = item.Key.gi_FechaIniTraslado;
                      info.gi_FecFinTraslado = item.Key.gi_FechaFinTraslado;


                      lst.Add(info);


                  }

                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ActualizarEstado(int IdEmpresa, fa_guia_remision_Info oGuia)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_guia_remision.FirstOrDefault(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdGuiaRemision == oGuia.IdGuiaRemision);
                    if (contact != null)
                    {
                        contact.MotiAnula = oGuia.MotivoAnu;
                        contact.ip = oGuia.ip;
                        contact.nom_pc = oGuia.nom_pc;
                        contact.Fecha_UltAnu = oGuia.Fecha_UltAnu;
                        contact.IdUsuarioUltAnu = oGuia.IdUsuarioUltAnu;
                        contact.Estado = "I";
                        context.SaveChanges();
                    }


                    context.Database.ExecuteSqlCommand("delete from fa_guia_remision_det_x_fa_orden_Desp_det where gi_IdGuiaRemision =" + oGuia.IdGuiaRemision + 
                                                " and gi_IdSucursal = " + oGuia.IdSucursal + "and gi_IdBodega = " + oGuia.IdBodega + "and gi_IdEmpresa =" +oGuia.IdEmpresa);

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarCodigo(string Codigo, int idempresa)
        {
            try
            {
                EntitiesFacturacion oen = new EntitiesFacturacion();

                var select = from q in oen.fa_guia_remision
                             where q.CodGuiaRemision == Codigo && q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean Imprimir(fa_guia_remision_Info info, ref  string msg)
        {
            try
            {

                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_guia_remision.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdGuiaRemision == info.IdGuiaRemision);
                    if (contact != null)
                    {
                        contact.CodDocumentoTipo = info.CodDocumentoTipo;
                        contact.Serie1 = info.Serie1;
                        contact.Serie2 = info.Serie2;
                        contact.NUAutorizacion = info.NumAutorizacion;
                        contact.NumGuia_Preimpresa = info.NumGuia_Preimpresa;
                        contact.Impreso = "S";

                        context.SaveChanges();
                        msg = "Se ha procedido anular el registro del Cliente #: " + info.IdCliente.ToString() + " exitosamente";
                    }
                }
                    return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarNumguia(fa_guia_remision_Info info)
        {
            try
            {
                EntitiesFacturacion Context = new EntitiesFacturacion();
                var Verfi = Context.fa_guia_remision.FirstOrDefault(var => var.Serie1 == info.Serie1 
            && var.Serie2 == info.Serie2 && var.NumGuia_Preimpresa == info.NumGuia_Preimpresa && var.IdEmpresa == info.IdEmpresa);

                if (Verfi == null)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_guia_remision_Info Get_Info_guia_remision(fa_orden_Desp_Info Info)
        {
            try
            {
                fa_guia_remision_Info obj = new fa_guia_remision_Info();

                EntitiesFacturacion oen = new EntitiesFacturacion();

                var temp = oen.fa_guia_remision_det_x_fa_orden_Desp_det.FirstOrDefault(q => q.od_IdOrdenDespacho == Info.IdOrdenDespacho && q.od_IdEmpresa == Info.IdEmpresa && q.od_IdSucursal == Info.IdSucursal && q.od_IdBodega == Info.IdBodega);

                var data = oen.fa_guia_remision.FirstOrDefault(var => var.IdGuiaRemision == temp.gi_IdGuiaRemision && var.IdEmpresa == temp.gi_IdEmpresa && var.IdSucursal == temp.gi_IdSucursal && var.IdBodega == temp.gi_IdBodega);

                obj.IdGuiaRemision = data.IdGuiaRemision;
                obj.gi_Observacion = data.gi_Observacion;
                obj.gi_fecha = data.gi_fecha;

                return obj;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public fa_guia_remision_Info Get_Info_guia_remision(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdGuia)
        {
            try
            {
                List<fa_guia_remision_Info> lst = new List<fa_guia_remision_Info>();

                EntitiesFacturacion OEnti = new EntitiesFacturacion();


                var selectGuia = from q in OEnti.vwfa_Guia_Remision
                                 where q.IdEmpresa == IdEmpresa
                                          && q.IdBodega == IdBodega && q.IdSucursal == IdSucursal && q.IdGuiaRemision == IdGuia
                                 select q;

                var CabeceraGuia = from cab in selectGuia
                                   group cab by new
                                   {
                                       cab.IdEmpresa,
                                       cab.IdBodega,
                                       cab.IdSucursal,
                                       cab.bo_Descripcion,
                                       cab.Su_Descripcion,
                                       cab.Ve_Vendedor,
                                       cab.pe_apellido,
                                       cab.pe_nombre,
                                       cab.IdGuiaRemision,
                                       cab.Estado,
                                       cab.gi_Observacion,
                                       cab.IdVendedor,
                                       cab.IdCliente,
                                       cab.IdTransportista,
                                       cab.gi_fecha,
                                       cab.gi_fech_venc,
                                       cab.gi_plazo,
                                       cab.Serie1,
                                       cab.Serie2,
                                       cab.CodDocumentoTipo,
                                       cab.NumGuia_Preimpresa
                                   }
                                       into grouping
                                       select new { grouping.Key, Subototal = grouping.Sum(p => p.gi_Subtotal), Iva = grouping.Sum(p => p.gi_iva), Total = grouping.Sum(p => p.gi_total) };

                fa_guia_remision_Info info = new fa_guia_remision_Info();
                foreach (var item in CabeceraGuia)
                {
                    //
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.IdCliente = item.Key.IdCliente;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Cliente = item.Key.pe_nombre + " " + item.Key.pe_apellido;
                    info.Estado = item.Key.Estado;
                    info.Subtotal = Convert.ToDecimal(item.Subototal);
                    info.Total = item.Total;
                    info.Iva = item.Iva;
                    info.IdGuiaRemision = item.Key.IdGuiaRemision;
                    info.gi_Observacion = item.Key.gi_Observacion;
                    info.IdTransportista = item.Key.IdTransportista;
                    info.gi_fecha = item.Key.gi_fecha;
                    info.gi_plazo = Convert.ToDecimal(item.Key.gi_plazo);
                    info.gi_fech_venc = Convert.ToDateTime(item.Key.gi_fech_venc);
                    info.Serie1 = item.Key.Serie1;
                    info.Serie2 = item.Key.Serie2;
                    info.NumGuia_Preimpresa = item.Key.NumGuia_Preimpresa;
                    info.CodDocumentoTipo = item.Key.CodDocumentoTipo;

                    lst.Add(info);

                }

                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }        
        }

        public List<fa_guia_remision_Info> Get_List_guia_remision(int idEmpresa, int idSucursal, int idBodega, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                List<fa_guia_remision_Info> lst = new List<fa_guia_remision_Info>();

                EntitiesFacturacion OEnti = new EntitiesFacturacion();


                var selectGuia = from q in OEnti.vwfa_Guia_Remision
                                 where q.IdEmpresa == idEmpresa && q.Estado == "A"
                                 && q.IdSucursal == idSucursal && q.IdBodega == idBodega && q.gi_fecha >= fechaIni && q.gi_fecha <= fechaFin
                                 select q;
                var TablaInte = from q in OEnti.fa_factura_x_fa_guia_remision
                                where q.fa_IdEmpresa == idEmpresa && q.fa_IdSucursal == idSucursal && q.fa_IdBodega == idBodega
                                select q;

                var CabeceraGuia = from cab in selectGuia

                                   group cab by new
                                   {
                                       cab.IdEmpresa,
                                       cab.IdBodega,
                                       cab.IdSucursal,
                                       cab.bo_Descripcion,
                                       cab.Su_Descripcion,
                                       cab.Ve_Vendedor,
                                       cab.pe_apellido,
                                       cab.pe_nombre,
                                       cab.IdGuiaRemision,
                                       cab.Estado,
                                       cab.gi_Observacion,
                                       cab.IdTransportista,
                                       cab.gi_fecha,
                                       cab.gi_fech_venc,
                                       cab.gi_plazo,
                                       cab.Serie1,
                                       cab.Serie2,
                                       cab.CodGuiaRemision,
                                       cab.NumGuia_Preimpresa,
                                       cab.CodDocumentoTipo,

                                   }
                                       into grouping
                                       select new { grouping.Key, Subototal = grouping.Sum(p => p.gi_Subtotal), Iva = grouping.Sum(p => p.gi_iva), Total = grouping.Sum(p => p.gi_total) };

                foreach (var item in CabeceraGuia)
                {
                    fa_guia_remision_Info info = new fa_guia_remision_Info();

                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdBodega = item.Key.IdBodega;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.Bodega = item.Key.bo_Descripcion;
                    info.Sucursal = item.Key.Su_Descripcion;
                    info.Vendedor = item.Key.Ve_Vendedor;
                    info.Cliente = item.Key.pe_nombre + " " + item.Key.pe_apellido;
                    info.Estado = item.Key.Estado;
                    info.Subtotal = Convert.ToDecimal(item.Subototal);
                    info.Total = item.Total;
                    info.Iva = item.Iva;
                    info.IdGuiaRemision = item.Key.IdGuiaRemision;
                    info.gi_Observacion = item.Key.gi_Observacion;
                    info.IdTransportista = item.Key.IdTransportista;
                    info.gi_fecha = item.Key.gi_fecha;
                    info.gi_plazo = Convert.ToDecimal((item.Key.gi_plazo == null) ? 0 : item.Key.gi_plazo);
                    info.gi_fech_venc = Convert.ToDateTime(item.Key.gi_fech_venc);

                    info.Serie1 = item.Key.Serie1;
                    info.Serie2 = item.Key.Serie2;
                    info.NumGuia_Preimpresa = item.Key.NumGuia_Preimpresa;
                    info.CodDocumentoTipo = item.Key.CodDocumentoTipo;

                    var ww = (from q in TablaInte
                              where q.gi_IdGuiaRemision == item.Key.IdGuiaRemision
                              select q).Count();
                    if (Convert.ToInt32(ww) == 0)
                    {
                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }


       



        public fa_guia_remision_Data() { }
    }
}
