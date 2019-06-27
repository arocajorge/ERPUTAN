using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedido_Data
    {
        public List<com_OrdenPedido_Info> GetList(int IdEmpresa, string IdUsuario, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<com_OrdenPedido_Info> Lista;
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
                        Lista = db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdDepartamento == solicitante.IdDepartamento && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
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
                        Lista.AddRange(db.vwcom_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.IdDepartamento != solicitante.IdDepartamento && FechaIni <= q.op_Fecha && q.op_Fecha <= FechaFin).Select(q => new com_OrdenPedido_Info
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
                List<com_OrdenPedido_Info> Lista;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                        Lista = db.vwcom_OrdenPedidoAprobar.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario == IdUsuario && q.IdCatalogoEstado != "EST_OP_CER").Select(q => new com_OrdenPedido_Info
                        {
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
                            nom_punto_cargo = q.nom_punto_cargo
                        }).ToList();

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
                            Secuencia = Secuencia++,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdProducto = item.IdProducto,
                            IdPunto_cargo = item.IdPunto_cargo,
                            IdUnidadMedida = item.IdUnidadMedida,
                            opd_EstadoProceso = item.opd_EstadoProceso = (info.EsCompraUrgente == true ? "A" : "P"),
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_CantidadApro = info.EsCompraUrgente == true ? item.opd_Cantidad : 0,
                            Adjunto = item.Adjunto,
                            NombreArchivo = item.NombreArchivo
                        });
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

        public bool ModificarDB(com_OrdenPedido_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    com_OrdenPedido Entity = db.com_OrdenPedido.Where(q=> q.IdEmpresa == info.IdEmpresa && q.IdOrdenPedido == info.IdOrdenPedido).FirstOrDefault();
                    if(Entity != null)
                    {
                        Entity.op_Codigo = info.op_Codigo;
                        Entity.op_Fecha = info.op_Fecha;
                        Entity.op_Observacion = info.op_Observacion;
                        Entity.IdDepartamento = info.IdDepartamento;
                        Entity.IdSolicitante = info.IdSolicitante;
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
                            opd_EstadoProceso = item.opd_EstadoProceso = "P",
                            pr_descripcion = item.pr_descripcion,
                            opd_Detalle = item.opd_Detalle,
                            opd_Cantidad = item.opd_Cantidad,
                            Adjunto = item.Adjunto,
                            NombreArchivo = item.NombreArchivo
                        });
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
                            IdPunto_cargo = Entity.IdPunto_cargo
                        };
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
                    if (cont == 0)
                    {
                        var pedido = db.com_OrdenPedido.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).FirstOrDefault();
                        if (pedido != null)
                            pedido.IdCatalogoEstado = "EST_OP_CER";

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


        #region SubirArchivos
        public void SubirDocumentos(int IdEmpresa)
        {
            EntitiesCompras db = new EntitiesCompras();
            var param = db.com_parametro.Where(q => q.IdEmpresa == IdEmpresa).FirstOrDefault();


        }
        #endregion
        
    }
}
