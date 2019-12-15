using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedido_Data
    {
        Funciones Fx = new Funciones();

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista = new List<com_OrdenPedido_Info>();
                FechaIni = FechaIni.Date;
                FechaFin = FechaFin.Date;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var solicitante = db.com_solicitante.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario).FirstOrDefault();
                    if (solicitante == null)
                        return new List<com_OrdenPedido_Info>();

                    if (!solicitante.ConsultaDepartamento)
                        Lista = db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdOrdenPedido = q.IdOrdenPedido,
                            op_Codigo = q.op_Codigo,
                            op_Fecha = q.op_Fecha,
                            op_Observacion = q.op_Observacion,

                            nom_departamento = q.nom_departamento,
                            nom_solicitante = q.nom_solicitante,
                            Estado = q.Estado,
                            CatalogoEstado = q.CatalogoEstado,
                            IdCatalogoEstado = q.IdCatalogoEstado,
                            EsCompraUrgente = q.EsCompraUrgente ?? false,
                            nom_punto_cargo = q.nom_punto_cargo
                        }).ToList();
                    else
                    {
                        var lst_Dep = db.com_solicitante_x_com_departamento.Where(q => q.IdEmpresa == solicitante.IdEmpresa && q.IdSolicitante == solicitante.IdSolicitante).ToList();
                        foreach (var item in lst_Dep)
                        {
                            Lista.AddRange(db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdDepartamento == item.IdDepartamento && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin && q.IdUsuario != IdUsuario).Select(q => new com_OrdenPedido_Info
                            {
                                IdEmpresa = q.IdEmpresa,
                                IdOrdenPedido = q.IdOrdenPedido,
                                op_Codigo = q.op_Codigo,
                                op_Fecha = q.op_Fecha,
                                op_Observacion = q.op_Observacion,

                                nom_departamento = q.nom_departamento,
                                nom_solicitante = q.nom_solicitante,
                                Estado = q.Estado,
                                CatalogoEstado = q.CatalogoEstado,
                                IdCatalogoEstado = q.IdCatalogoEstado,
                                EsCompraUrgente = q.EsCompraUrgente ?? false,
                                nom_punto_cargo = q.nom_punto_cargo
                            }).ToList());
                        }
                        Lista.AddRange(db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
                        {
                            IdEmpresa = q.IdEmpresa,
                            IdOrdenPedido = q.IdOrdenPedido,
                            op_Codigo = q.op_Codigo,
                            op_Fecha = q.op_Fecha,
                            op_Observacion = q.op_Observacion,

                            nom_departamento = q.nom_departamento,
                            nom_solicitante = q.nom_solicitante,
                            Estado = q.Estado,
                            CatalogoEstado = q.CatalogoEstado,
                            IdCatalogoEstado = q.IdCatalogoEstado,
                            EsCompraUrgente = q.EsCompraUrgente ?? false,
                            nom_punto_cargo = q.nom_punto_cargo
                        }).ToList());
                    }
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista = new List<com_OrdenPedido_Info>();
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.SetCommandTimeOut(3000);


                    string sql = "select IdEmpresa,IdOrdenPedido,EsCompraUrgente,op_Codigo,op_Fecha,op_Observacion,IdDepartamento,IdSolicitante,IdCatalogoEstado,Estado,IdPunto_cargo,IdUsuario,nom_punto_cargo,nom_departamento,nom_solicitante,cd_total ";
                    sql += "from vwcom_ordenpedidoaprobar where idempresa = "+IdEmpresa.ToString()+" and IdUsuario = '"+IdUsuario+"'";
                    var result = db.Database.SqlQuery<com_OrdenPedido_Info>(sql).ToList();
                    Lista = result;
                    /*
                    var lst = db.vwcom_OrdenPedidoAprobar.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario.Equals(IdUsuario)).ToList();

                    Lista.AddRange(lst.Select(q=> new com_OrdenPedido_Info{
                        IdEmpresa = q.IdEmpresa,
                        IdOrdenPedido = q.IdOrdenPedido,
                        op_Codigo = q.op_Codigo,
                        op_Fecha = q.op_Fecha,
                        op_Observacion = q.op_Observacion,

                        nom_departamento = q.nom_departamento,
                        nom_solicitante = q.nom_solicitante,
                        Estado = q.Estado,
                        IdCatalogoEstado = q.IdCatalogoEstado,
                        EsCompraUrgente = q.EsCompraUrgente ?? false,
                        nom_punto_cargo = q.nom_punto_cargo,
                        cd_total = q.cd_total
                    }).ToList());
                     * */
                }

                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private decimal GetId(int IdEmpresa)
        {
            try
            {
                decimal ID = 1;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa).Select(q => q.IdOrdenPedido).ToList();
                    if (lst.Count != 0)
                        ID = lst.Max() + 1;
                }

                return ID;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool GuardarDB(com_OrdenPedido_Info info)
        {
            try
            {
                com_parametro_Info param = new com_parametro_Data().Get_Info_parametro(info.IdEmpresa);
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_OrdenPedido.Add(new com_OrdenPedido
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdOrdenPedido = info.IdOrdenPedido = GetId(info.IdEmpresa),
                        op_Codigo = info.op_Codigo,
                        op_Fecha = info.op_Fecha,
                        op_Observacion = info.op_Observacion,
                        IdDepartamento = info.IdDepartamento,
                        IdSolicitante = info.IdSolicitante,
                        IdCatalogoEstado = info.IdCatalogoEstado = (info.EsCompraUrgente == true ? "EST_OP_PRO" : "EST_OP_ABI"),
                        Estado = true,
                        IdUsuarioCreacion = info.IdUsuarioCreacion,
                        FechaCreacion = DateTime.Now,
                        EsCompraUrgente = info.EsCompraUrgente,
                        IdPunto_cargo = info.IdPunto_cargo
                    });
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoDet.Add(new com_OrdenPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdOrdenPedido = info.IdOrdenPedido,
                            Secuencia = item.Secuencia = Secuencia++,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = item.opd_EstadoProceso = (info.EsCompraUrgente == true ? "A" : "P"),
                            FechaCantidad = (info.EsCompraUrgente == true ? DateTime.Now : (Nullable<DateTime>)null),
                            IdUsuarioCantidad = (info.EsCompraUrgente == true ? info.IdUsuarioCreacion : null),
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = info.EsCompraUrgente == true ? item.opd_Cantidad : 0,
                            Adjunto = item.Adjunto,
                            NombreArchivo = !string.IsNullOrEmpty(item.NombreArchivo) ? Path.GetFileName(item.NombreArchivo) : item.NombreArchivo
                        });
                    }
                    db.SaveChanges();

                    if (SaltarPaso2(info.IdEmpresa, info.IdOrdenPedido, info.IdUsuarioCreacion))
                    {
                        ValidarProceso(info.IdEmpresa, info.IdOrdenPedido);
                    }
                }
                try
                {
                    #region Adjuntos
                    var lst_adjuntos = info.ListaDetalle.Where(q => q.Adjunto == true).ToList();
                    
                    if (param != null && !string.IsNullOrEmpty(param.UbicacionArchivosPedido))
                    {
                        string Comando = "/c Net Use " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                        Directory.CreateDirectory(param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString());
                        foreach (var item in lst_adjuntos)
                        {
                            var ext = Path.GetFileName(item.NombreArchivo);
                            System.IO.File.Copy(item.NombreArchivo, param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString() + @"\" + ext, true);
                        }

                        Comando = "/c Net Use /DELETE " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                    }
                    #endregion
                }
                catch (Exception)
                {

                }

                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }

        public bool ModificarDB(com_OrdenPedido_Info info)
        {
            try
            {
                com_parametro_Info param = new com_parametro_Data().Get_Info_parametro(info.IdEmpresa);
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_OrdenPedido Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.op_Codigo = info.op_Codigo;
                        Entity.op_Fecha = info.op_Fecha;
                        Entity.op_Observacion = info.op_Observacion;
                        Entity.IdDepartamento = info.IdDepartamento;
                        Entity.IdUsuarioUltModi = info.IdUsuarioCreacion;
                        Entity.FechaUltModi = DateTime.Now;
                        Entity.IdPunto_cargo = info.IdPunto_cargo;
                    }
                    var lst = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).ToList();
                    foreach (var item in lst)
                    {
                        db.com_OrdenPedidoDet.Remove(item);
                    }
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoDet.Add(new com_OrdenPedidoDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdOrdenPedido = info.IdOrdenPedido,
                            Secuencia = Secuencia++,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = item.opd_EstadoProceso = (info.EsCompraUrgente == true ? "A" : "P"),
                            FechaCantidad = (info.EsCompraUrgente == true ? DateTime.Now : (Nullable<DateTime>)null),
                            IdUsuarioCantidad = (info.EsCompraUrgente == true ? info.IdUsuarioCreacion : null),
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = info.EsCompraUrgente == true ? item.opd_Cantidad : 0,
                            Adjunto = !string.IsNullOrEmpty(item.NombreArchivo) ? true : false,
                            NombreArchivo = item.NuevoAdjunto ? Path.GetFileName(item.NombreArchivo) : item.NombreArchivo
                        });
                    }
                    db.SaveChanges();

                    if (SaltarPaso2(info.IdEmpresa, info.IdOrdenPedido, info.IdUsuarioCreacion))
                    {
                        ValidarProceso(info.IdEmpresa, info.IdOrdenPedido);
                    }
                }
                try
                {
                    #region Adjuntos
                    var lst_adjuntos = info.ListaDetalle.Where(q => q.NuevoAdjunto == true).ToList();
                    if (param != null && !string.IsNullOrEmpty(param.UbicacionArchivosPedido))
                    {
                        string Comando = "/c Net Use " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                        Directory.CreateDirectory(param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString());
                        foreach (var item in lst_adjuntos)
                        {
                            var ext = Path.GetFileName(item.NombreArchivo);
                            System.IO.File.Copy(item.NombreArchivo, param.UbicacionArchivosPedido + @"\" + info.IdOrdenPedido.ToString() + @"\" + ext, true);
                        }

                        Comando = "/c Net Use /DELETE " + param.FileDominio + " /USER:" + param.FileUsuario + " " + param.FileContrasenia;
                        Fx.ExecuteCommand(@"" + Comando);
                    }
                    #endregion
                }
                catch (Exception)
                {
                    
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AnularDB(com_OrdenPedido_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_OrdenPedido Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.Estado = false;
                        Entity.IdUsuarioAnu = info.IdUsuarioCreacion;
                        Entity.FechaUltAnu = DateTime.Now;
                        Entity.MotivoAnu = info.MotivoAnu;
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

        public com_OrdenPedido_Info GetInfo(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                com_OrdenPedido_Info info = new com_OrdenPedido_Info();
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                    if (Entity != null)
                    {
                        info = new com_OrdenPedido_Info
                        {
                            IdEmpresa = Entity.IdEmpresa,
                            IdOrdenPedido = Entity.IdOrdenPedido,
                            op_Fecha = Entity.op_Fecha,
                            op_Observacion = Entity.op_Observacion,
                            op_Codigo = Entity.op_Codigo,
                            IdDepartamento = Entity.IdDepartamento,
                            IdSolicitante = Entity.IdSolicitante,
                            IdCatalogoEstado = Entity.IdCatalogoEstado,
                            Estado = Entity.Estado,
                            EsCompraUrgente = Entity.EsCompraUrgente ?? false,
                            IdPunto_cargo = Entity.IdPunto_cargo,
                            ObservacionGA = Entity.ObservacionGA,
                            IdUsuarioAprobacion = Entity.IdUsuarioAprobacion
                        };
                        info.ObservacionGA = (info.IdUsuarioAprobacion ?? "") +".- "+ (info.ObservacionGA ?? "");
                        return info;
                    }
                }
                return info;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool ValidarProceso(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var cont = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && (q.opd_EstadoProceso == "A" || q.opd_EstadoProceso == "AC" || q.opd_EstadoProceso == "AJC")).Count();
                    var contR = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && (q.opd_EstadoProceso == "RA" || q.opd_EstadoProceso == "RC" || q.opd_EstadoProceso == "RGA")).Count();
                    var contT = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).Count();
                    var contP = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "P").Count();


                    if (cont == 0 && contR != contT)
                    {
                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                        if (pedido != null)
                            pedido.IdCatalogoEstado = "EST_OP_CER";

                        db.SaveChanges();
                    }

                    if (cont == 0 && contR == contT)
                    {
                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                        if (pedido != null)
                            pedido.IdCatalogoEstado = "EST_OP_REC";

                        db.SaveChanges();
                    }

                    if ((cont > 0 || contR > 0) && contR != contT)
                    {
                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                        if (pedido != null)
                            pedido.IdCatalogoEstado = "EST_OP_PRO";

                        db.SaveChanges();
                    }

                    if (contP == contT)
                    {
                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                        if (pedido != null)
                            pedido.IdCatalogoEstado = "EST_OP_ABI";

                        db.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ValidarProceso(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra, int Secuencia)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var lst = db.vwcom_OrdenPedidoDet_PorOC.Where(q => q.IdEmpresa_oc == IdEmpresa && q.IdSucursal_oc == IdSucursal && q.IdOrdenCompra == IdOrdenCompra && q.Secuencia_oc == Secuencia).ToList();

                    var lsg = lst.GroupBy(q => new { q.IdEmpresa_oc, q.IdOrdenPedido, q.Secuencia_pd }).Select(q => new
                    {
                        IdEmpresa = q.Key.IdEmpresa_oc,
                        IdOrdenPedido = q.Key.IdOrdenPedido,
                        Secuencoia = q.Key.Secuencia_pd,
                        Contador = q.Count()
                    }).FirstOrDefault();

                    var pedido = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == lsg.IdEmpresa && q.IdOrdenPedido == lsg.IdOrdenPedido && q.Secuencia == lsg.Secuencoia).FirstOrDefault();
                    if (pedido != null)
                    {
                        int ContadorT = db.vwcom_OrdenPedidoDet_PorTR.Where(q => q.IdEmpresa_oc == IdEmpresa && q.IdSucursal_oc == IdSucursal && q.IdOrdenCompra == IdOrdenCompra && q.Secuencia_oc == Secuencia).Count();

                        pedido.opd_EstadoProceso = ContadorT > 0 ? "T" : (lsg.Contador > 0 ? "I" : "C");
                        db.SaveChanges();
                    }

                    
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaltarPaso2(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_OrdenPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "P" && q.SaltaPaso2).ToList();
                    foreach (var item in Lista)
                    {
                        var Entity = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdOrdenPedido == item.IdOrdenPedido && q.Secuencia == item.Secuencia).FirstOrDefault();
                        if (Entity != null)
                        {
                            Entity.opd_EstadoProceso = "A";
                            Entity.FechaCantidad = DateTime.Now;
                            Entity.IdUsuarioCantidad = IdUsuario;
                            Entity.opd_CantidadApro = Entity.opd_Cantidad;
                        }
                    }
                    db.SaveChanges();
                }

                if (SaltarPaso3(IdEmpresa,IdOrdenPedido,IdUsuario))
                {
                    
                }

                if (ValidarProceso(IdEmpresa,IdOrdenPedido))
                {
                    
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaltarPaso3(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                cp_proveedor_Data data_prov = new cp_proveedor_Data();
                com_CotizacionPedido_Data data_cot = new com_CotizacionPedido_Data();
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_OrdenPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido && q.opd_EstadoProceso == "A" && q.SaltaPaso3).ToList();
                   
                    var ListaAgrupada = Lista.GroupBy(q => new { q.IdProveedor, q.IdDepartamento, q.IdSolicitante, q.IdSucursalOrigen, q.IdComprador, q.IdOrdenPedido, q.IdSucursalDestino, q.IdTerminoPago, q.TiempoEntrega, q.SaltoPaso4 }).Select(q => new
                    {
                        q.Key.IdSolicitante,
                        q.Key.IdDepartamento,
                        q.Key.IdProveedor,
                        q.Key.IdSucursalOrigen,
                        q.Key.IdComprador,
                        q.Key.IdOrdenPedido,
                        q.Key.IdSucursalDestino,
                        q.Key.IdTerminoPago,
                        q.Key.TiempoEntrega,
                        q.Key.SaltoPaso4
                    }).ToList();


                    var lst_termino = db.com_TerminoPago.Where(q => q.Estado == "A").ToList();
                    foreach (var item in ListaAgrupada)
                    {
                        var proveedor = data_prov.Get_Info_Proveedor(IdEmpresa, item.IdProveedor);
                        if (proveedor == null)
                            return false;
                        var Pedido = Lista.Where(q => q.IdOrdenPedido == item.IdOrdenPedido).FirstOrDefault();
                        string Observacion = (Pedido != null ? Pedido.op_Observacion : string.Empty);
                        com_CotizacionPedido_Info cab = new com_CotizacionPedido_Info
                        {
                            IdEmpresa = IdEmpresa,
                            IdSucursal = item.IdSucursalOrigen,
                            IdProveedor = item.IdProveedor,
                            cp_Fecha = DateTime.Now.Date,
                            cp_Observacion = Observacion,
                            IdDepartamento = item.IdDepartamento,
                            IdSolicitante = item.IdSolicitante,
                            IdComprador = item.IdComprador,
                            IdTerminoPago = item.IdTerminoPago,
                            cp_Plazo = lst_termino.Where(q=> q.IdTerminoPago == item.IdTerminoPago).FirstOrDefault().Dias,
                            pe_correo = proveedor.Persona_Info.pe_correo_secundario1,
                            IdPersona = proveedor.IdPersona,                            
                            IdUsuario = IdUsuario,
                            IdOrdenPedido = item.IdOrdenPedido,
                            cp_PlazoEntrega = item.TiempoEntrega,
                            ListaDetalle = new List<com_CotizacionPedidoDet_Info>()
                        };

                        cab.ListaDetalle = Lista.Where(q => q.IdProveedor == item.IdProveedor 
                            && q.IdDepartamento == item.IdDepartamento 
                            && q.IdSolicitante == item.IdSolicitante 
                            && q.IdSucursalOrigen == item.IdSucursalOrigen 
                            && q.IdOrdenPedido == item.IdOrdenPedido
                            && q.IdSucursalDestino == item.IdSucursalDestino
                            && q.IdTerminoPago == item.IdTerminoPago
                            && q.TiempoEntrega == item.TiempoEntrega
                            && q.SaltoPaso4 == item.SaltoPaso4).Select(q => new com_CotizacionPedidoDet_Info
                        {
                            IdEmpresa = IdEmpresa,
                            opd_IdEmpresa = q.IdEmpresa,
                            opd_IdOrdenPedido = q.IdOrdenPedido,
                            opd_Secuencia = q.Secuencia,
                            IdProducto = q.IdProducto ?? 0,
                            cd_Cantidad = q.opd_CantidadApro,
                            cd_precioCompra = q.PrecioUnitario,
                            cd_porc_des = q.PorDescuento,
                            cd_descuento = q.Descuento,
                            cd_precioFinal = q.PrecioFinal,
                            cd_subtotal = q.Subtotal,
                            IdCod_Impuesto = q.IdCod_Impuesto_Iva,
                            Por_Iva = q.porcentaje,
                            cd_iva = q.Iva,
                            cd_total = q.Total,
                            IdUnidadMedida = q.IdUnidadMedida,
                            IdPunto_cargo = q.IdPunto_cargo,
                            cd_DetallePorItem = q.opd_Detalle,
                            IdSucursalDestino = q.IdSucursalDestino,
                            IdSucursalOrigen = q.IdSucursalOrigen
                        }).ToList();

                        data_cot.GuardarDB(cab);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SaltarPaso4(int IdEmpresa, decimal IdOrdenPedido, string IdUsuario)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Lista = db.vwcom_CotizacionPedidoConvenioPrecios.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).ToList();
                    foreach (var item in Lista)
                    {
                        var cab = db.com_CotizacionPedido.Where(q => q.IdEmpresa == item.IdEmpresa && q.IdCotizacion == item.IdCotizacion).FirstOrDefault();
                        if (cab != null)
                        {
                            cab.IdUsuarioJC = IdUsuario;
                            cab.FechaJC = DateTime.Now;
                            cab.EstadoJC = "A";

                            var ListaDet = db.com_CotizacionPedidoDet.Where(q => q.IdEmpresa == cab.IdEmpresa && q.IdCotizacion == cab.IdCotizacion).ToList();
                            foreach (var det in ListaDet)
                            {
                                det.EstadoJC = true;

                                var detOP = db.com_OrdenPedidoDet.Where(q => q.IdEmpresa == det.opd_IdEmpresa && q.IdOrdenPedido == det.opd_IdOrdenPedido && q.Secuencia == det.opd_Secuencia).FirstOrDefault();
                                if (detOP != null)
                                {
                                    detOP.opd_EstadoProceso = "AJC";
                                }
                            }
                        }
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
    }
}
