using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_ConvenioPreciosPorProducto_Data
    {
        public List<com_ConvenioPreciosPorProducto_Info> GetList(int IdEmpresa)
        {
            try
            {
                List<com_ConvenioPreciosPorProducto_Info> Lista;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_ConvenioPreciosPorProducto.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new com_ConvenioPreciosPorProducto_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdProducto = q.IdProducto,
                        IdProveedor = q.IdProveedor,
                        IdComprador = q.IdComprador,
                        IdTerminoPago = q.IdTerminoPago,
                        IdUnidadMedida = q.IdUnidadMedida,
                        PrecioUnitario = q.PrecioUnitario,
                        PorDescuento = q.PorDescuento,
                        Descuento = q.Descuento,
                        PrecioFinal = q.PrecioFinal,
                        TiempoEntrega = q.TiempoEntrega,
                        FechaFin = q.FechaFin,
                        SaltaPaso2 = q.SaltaPaso2,
                        SaltaPaso3 = q.SaltaPaso3,
                        SaltoPaso4 = q.SaltoPaso4,
                        SaltoPaso5 = q.SaltoPaso5,
                        Producto = q.Producto,
                        pe_nombreCompleto = q.pe_nombreCompleto,
                        TerminoPago = q.TerminoPago
                    }).ToList();
                }
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public com_ConvenioPreciosPorProducto_Info GetInfo(int IdEmpresa, decimal IdProducto)
        {
            try
            {
                com_ConvenioPreciosPorProducto_Info info;
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    info = db.com_ConvenioPreciosPorProducto.Where(q => q.IdEmpresa == IdEmpresa && q.IdProducto == IdProducto).Select(q => new com_ConvenioPreciosPorProducto_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdProducto = q.IdProducto,
                        IdProveedor = q.IdProveedor,
                        IdComprador = q.IdComprador,
                        IdTerminoPago = q.IdTerminoPago,
                        IdUnidadMedida = q.IdUnidadMedida,
                        PrecioUnitario = q.PrecioUnitario,
                        PorDescuento = q.PorDescuento,
                        Descuento = q.Descuento,
                        PrecioFinal = q.PrecioFinal,
                        TiempoEntrega = q.TiempoEntrega,
                        FechaFin = q.FechaFin,
                        SaltaPaso2 = q.SaltaPaso2,
                        SaltaPaso3 = q.SaltaPaso3,
                        SaltoPaso4 = q.SaltoPaso4,
                        SaltoPaso5 = q.SaltoPaso5
                    }).FirstOrDefault();
                }
                return info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(com_ConvenioPreciosPorProducto_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_ConvenioPreciosPorProducto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == info.IdProducto).FirstOrDefault();
                    if (Entity != null)
                        return ModificarDB(info);

                    db.com_ConvenioPreciosPorProducto.Add(new com_ConvenioPreciosPorProducto
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdProducto = info.IdProducto,
                        IdProveedor = info.IdProveedor,
                        IdComprador = info.IdComprador,
                        IdTerminoPago = info.IdTerminoPago,
                        IdUnidadMedida = info.IdUnidadMedida,
                        PrecioUnitario = info.PrecioUnitario,
                        PorDescuento = info.PorDescuento,
                        Descuento = info.Descuento,
                        PrecioFinal = info.PrecioFinal,
                        TiempoEntrega = info.TiempoEntrega,
                        FechaFin = info.FechaFin,
                        SaltaPaso2 = info.SaltaPaso2,
                        SaltaPaso3 = info.SaltaPaso3,
                        SaltoPaso4 = info.SaltoPaso4,
                        SaltoPaso5 = info.SaltoPaso5
                    });
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool ModificarDB(com_ConvenioPreciosPorProducto_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    var Entity = db.com_ConvenioPreciosPorProducto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == info.IdProducto).FirstOrDefault();
                    if (Entity == null)
                        return false;
                    Entity.IdProveedor = info.IdProveedor;
                    Entity.IdComprador = info.IdComprador;
                    Entity.IdTerminoPago = info.IdTerminoPago;
                    Entity.IdUnidadMedida = info.IdUnidadMedida;
                    Entity.PrecioUnitario = info.PrecioUnitario;
                    Entity.PorDescuento = info.PorDescuento;
                    Entity.Descuento = info.Descuento;
                    Entity.PrecioFinal = info.PrecioFinal;
                    Entity.TiempoEntrega = info.TiempoEntrega;
                    Entity.FechaFin = info.FechaFin;
                    Entity.SaltaPaso2 = info.SaltaPaso2;
                    Entity.SaltaPaso3 = info.SaltaPaso3;
                    Entity.SaltoPaso4 = info.SaltoPaso4;
                    Entity.SaltoPaso5 = info.SaltoPaso5;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarDB(com_ConvenioPreciosPorProducto_Info info)
        {
            try
            {
                using (EntitiesCompras db = new EntitiesCompras())
                {
                    db.com_ConvenioPreciosPorProducto.Remove(db.com_ConvenioPreciosPorProducto.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdProducto == info.IdProducto).FirstOrDefault());                    
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
