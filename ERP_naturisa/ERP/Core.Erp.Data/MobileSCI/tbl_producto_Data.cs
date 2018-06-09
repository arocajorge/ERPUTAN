using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_producto_Data
    {
        public List<tbl_producto_Info> get_list(int IdEmpresa, bool mostrar_no_asignados)
        {
            try
            {
                List<tbl_producto_Info> Lista;

                EntitiesInventario Context_g = new EntitiesInventario();
                List<in_Producto_Info> lst_producto = (from p in Context_g.in_Producto
                                                       join c in Context_g.in_categorias
                                                       on new { p.IdEmpresa, p.IdCategoria } equals new { c.IdEmpresa, c.IdCategoria }
                                                       join l in Context_g.in_linea
                                                       on new { p.IdEmpresa, p.IdCategoria, p.IdLinea } equals new { l.IdEmpresa, l.IdCategoria, l.IdLinea}
                                                       where p.IdEmpresa == IdEmpresa
                                                       select new in_Producto_Info
                                                                            {
                                                                                IdEmpresa = p.IdEmpresa,
                                                                                IdProducto = p.IdProducto,
                                                                                pr_descripcion = p.pr_descripcion,
                                                                                nom_Categoria = c.ca_Categoria,
                                                                                nom_Linea = l.nom_linea
                                                                            }).ToList();
                Context_g.Dispose();
                Entities_mobileSCI context_m = new Entities_mobileSCI();

                List<tbl_producto_Info> lst_filtro = (from q in context_m.tbl_producto
                                                       where q.IdEmpresaSCI == IdEmpresa
                                                       select new tbl_producto_Info
                                                       {
                                                           IdEmpresa = q.IdEmpresa,
                                                           IdProducto = q.IdProducto,
                                                       }).ToList();

                

                if (mostrar_no_asignados)
                {
                    Lista = (from q in lst_producto
                             join b in lst_filtro
                             on new { q.IdEmpresa, q.IdProducto } equals new { b.IdEmpresa, b.IdProducto }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_producto_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdProducto = q.IdProducto,
                                 nom_producto = q.pr_descripcion,
                                 seleccionado = p == null ? false : true,
                                 nom_categoria = q.nom_Categoria,
                                 nom_linea = q.nom_Linea

                             }).ToList();
                }else
                    Lista = (from q in lst_filtro
                             join b in lst_producto
                             on new { q.IdEmpresa, q.IdProducto } equals new { b.IdEmpresa, b.IdProducto }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_producto_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdProducto = q.IdProducto,
                                 nom_producto = p.pr_descripcion,
                                 seleccionado = true,
                                 nom_categoria = p.nom_Categoria,
                                 nom_linea = p.nom_Linea
                             }).ToList();

                context_m.Dispose();
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool eliminarDB(int IdEmpresa)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    Context.Database.ExecuteSqlCommand("delete mobileSCI.tbl_producto where IdEmpresaSCI = " + IdEmpresa);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool guardarDB(List<tbl_producto_Info> Lista)
        {
            try
            {
                int IdSCI = 1;
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    foreach (var item in Lista)
                    {
                        tbl_producto Entity = new tbl_producto
                        {
                            IdEmpresaSCI = item.IdEmpresaSCI,
                            IdSCI = IdSCI++,
                            IdEmpresa = item.IdEmpresa,
                            IdProducto = item.IdProducto
                        };
                        Context.tbl_producto.Add(Entity);
                    }
                    Context.SaveChanges();
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
