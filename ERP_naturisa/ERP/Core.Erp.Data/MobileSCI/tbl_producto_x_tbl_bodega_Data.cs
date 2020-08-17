using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_producto_x_tbl_bodega_Data
    {
        public List<tbl_producto_x_tbl_bodega_Info> GetList(int IdEmpresa, int IdSucursal, int IdBodega)
        {
            try
            {
                List<tbl_producto_x_tbl_bodega_Info> Lista = new List<tbl_producto_x_tbl_bodega_Info>();

                using (Entities_mobileSCI db = new Entities_mobileSCI())
                {
                    #region Productos asignados
                    var lst = db.vwtbl_producto_x_tbl_bodega.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega).ToList();
                    foreach (var item in lst)
                    {
                        Lista.Add(new tbl_producto_x_tbl_bodega_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdBodega = item.IdBodega,
                            IdProducto = item.IdProducto,
                            Su_Descripcion = item.Su_Descripcion,
                            bo_Descripcion = item.bo_Descripcion,
                            pr_descripcion = item.pr_descripcion,
                            pr_codigo = item.pr_codigo,
                            ca_Categoria = item.ca_Categoria,
                            nom_linea = item.nom_linea,
                            EnBase = true
                        });
                    }
                    #endregion

                    #region Productos no asignados
                    var lstNo = (from a in db.vwtbl_producto
                                 where a.IdEmpresa == IdEmpresa && !db.tbl_producto_x_tbl_bodega.Any(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdProducto == a.IdProducto)
                                 select new
                                 {
                                     a.IdEmpresa,
                                     a.IdProducto,
                                     a.pr_codigo,
                                     a.pr_descripcion,
                                     a.nom_linea,
                                     a.ca_Categoria
                                 }).ToList();

                    foreach (var item in lstNo)
                    {
                        Lista.Add(new tbl_producto_x_tbl_bodega_Info
                        {
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = IdSucursal,
                            IdBodega = IdBodega,
                            IdProducto = item.IdProducto,
                            pr_codigo = item.pr_codigo,
                            pr_descripcion = item.pr_descripcion,
                            ca_Categoria = item.ca_Categoria,
                            nom_linea = item.nom_linea,
                            EnBase = false
                        });
                    }
                    #endregion
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Guardar(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {
                using (Entities_mobileSCI db = new Entities_mobileSCI())
                {
                    var Entity = db.tbl_producto_x_tbl_bodega.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdProducto == IdProducto).FirstOrDefault();
                    if (Entity == null)
                    {
                        db.tbl_producto_x_tbl_bodega.Add(new tbl_producto_x_tbl_bodega
                        {
                            IdEmpresa = IdEmpresa,
                            IdSucursal = IdSucursal,
                            IdBodega = IdBodega,
                            IdProducto = IdProducto
                        });
                        db.SaveChanges();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Anular(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdProducto)
        {
            try
            {
                using (Entities_mobileSCI db = new Entities_mobileSCI())
                {
                    var Entity = db.tbl_producto_x_tbl_bodega.Where(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdProducto == IdProducto).FirstOrDefault();
                    if (Entity != null)
                    {
                        db.tbl_producto_x_tbl_bodega.Remove(Entity);
                        db.SaveChanges();
                    }
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
