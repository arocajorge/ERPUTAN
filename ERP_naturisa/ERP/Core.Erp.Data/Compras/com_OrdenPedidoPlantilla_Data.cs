using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Erp.Data.Compras
{
    public class com_OrdenPedidoPlantilla_Data
    {
        public List<com_OrdenPedidoPlantilla_Info> GetList(int IdEmpresa, bool MostrarAnulados)
        {
            try
            {
                List<com_OrdenPedidoPlantilla_Info> Lista;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_OrdenPedidoPlantilla.Where(q => q.IdEmpresa == IdEmpresa && q.Estado == (MostrarAnulados == true ? q.Estado : true)).Select(q => new com_OrdenPedidoPlantilla_Info
                    {
                        IdEmpresa =q.IdEmpresa,
                        IdPlantilla = q.IdPlantilla,
                        op_Codigo = q.op_Codigo,
                        op_Observacion = q.op_Observacion,
                        Estado = q.Estado,
                        EsCompraUrgente = q.EsCompraUrgente ?? false,
                        IdPunto_cargo = q.IdPunto_cargo
                    }).ToList();
                }
                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public com_OrdenPedidoPlantilla_Info GetInfo(int IdEmpresa, decimal IdPlantilla)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedidoPlantilla.Where(q => q.IdEmpresa == IdEmpresa && q.IdPlantilla == IdPlantilla).Select(q => new com_OrdenPedidoPlantilla_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdPlantilla = q.IdPlantilla,
                        op_Codigo = q.op_Codigo,
                        op_Observacion = q.op_Observacion,
                        EsCompraUrgente = q.EsCompraUrgente ?? false,
                        Estado = q.Estado,
                        IdPunto_cargo = q.IdPunto_cargo
                    }).FirstOrDefault();
                    return Entity;
                }
                
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
                    var lst = db.com_OrdenPedidoPlantilla.Where(q=> q.IdEmpresa == IdEmpresa).ToList();
                    if (lst.Count > 0)
                        ID = lst.Max(q => q.IdPlantilla) + 1;
                }
                return ID;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_OrdenPedidoPlantilla.Add(new com_OrdenPedidoPlantilla
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdPlantilla = info.IdPlantilla = GetId(info.IdEmpresa),
                        op_Codigo = info.op_Codigo,
                        op_Observacion = info.op_Observacion,
                        Estado = true,
                        IdUsuarioCreacion = info.IdUsuarioCreacion,
                        FechaCreacion = DateTime.Now,
                        EsCompraUrgente = info.EsCompraUrgente,
                        IdPunto_cargo = info.IdPunto_cargo,
                    });
                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoPlantillaDet.Add(new com_OrdenPedidoPlantillaDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdPlantilla = info.IdPlantilla,
                            Secuencia = Secuencia++,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            IdUnidadMedida = item.IdUnidadMedida,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdPunto_cargo = item.IdPunto_cargo,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_Detalle = item.opd_Detalle
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

        public bool ModificarDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedidoPlantilla.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdPlantilla == info.IdPlantilla).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    Entity.op_Codigo = info.op_Codigo;
                    Entity.op_Observacion = info.op_Observacion;
                    Entity.EsCompraUrgente = info.EsCompraUrgente;
                    Entity.IdPunto_cargo = info.IdPunto_cargo;
                    Entity.FechaUltModi = DateTime.Now;
                    Entity.IdUsuarioUltModi = info.IdUsuarioCreacion;

                    var lst = db.com_OrdenPedidoPlantillaDet.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdPlantilla == info.IdPlantilla).ToList();
                    foreach (var item in lst)
                    {
                        db.com_OrdenPedidoPlantillaDet.Remove(item);
                    }

                    int Secuencia = 1;
                    foreach (var item in info.ListaDetalle)
                    {
                        db.com_OrdenPedidoPlantillaDet.Add(new com_OrdenPedidoPlantillaDet
                        {
                            IdEmpresa = info.IdEmpresa,
                            IdPlantilla = info.IdPlantilla,
                            Secuencia = Secuencia++,
                            IdProducto = item.IdProducto,
                            pr_descripcion = item.pr_descripcion,
                            IdUnidadMedida = item.IdUnidadMedida,
                            IdSucursalDestino = item.IdSucursalDestino,
                            IdSucursalOrigen = item.IdSucursalOrigen,
                            IdPunto_cargo = item.IdPunto_cargo,
                            opd_Cantidad = item.opd_Cantidad,
                            opd_Detalle = item.opd_Detalle
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

        public bool AnularDB(com_OrdenPedidoPlantilla_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_OrdenPedidoPlantilla.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdPlantilla == info.IdPlantilla).FirstOrDefault();
                    if (Entity == null)
                        return false;

                    Entity.Estado = false;
                    Entity.FechaUltAnu = DateTime.Now;
                    Entity.IdUsuarioAnu = info.IdUsuarioCreacion;
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
