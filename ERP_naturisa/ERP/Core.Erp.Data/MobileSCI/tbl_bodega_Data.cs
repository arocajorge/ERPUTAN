using Core.Erp.Info.General;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_bodega_Data
    {
        public List<tbl_bodega_Info> get_list(int IdEmpresa, bool mostrar_no_asignados)
        {
            try
            {
                List<tbl_bodega_Info> Lista;

                EntitiesGeneral Context_g = new EntitiesGeneral();
                List<tb_Bodega_Info> lst_bodega = (from b in Context_g.tb_bodega
                                                   join s in Context_g.tb_sucursal
                                                   on new { b.IdEmpresa, b.IdSucursal } equals new { s.IdEmpresa, s.IdSucursal }
                                                   where b.IdEmpresa == IdEmpresa
                                                   select new tb_Bodega_Info
                                                   {
                                                       IdEmpresa = b.IdEmpresa,
                                                       IdSucursal = b.IdSucursal,
                                                       IdBodega = b.IdBodega,
                                                       NomSucursal = s.Su_Descripcion,
                                                       bo_Descripcion = b.bo_Descripcion
                                                   }).ToList();
                Context_g.Dispose();
                Entities_mobileSCI context_m = new Entities_mobileSCI();
                
                List<tbl_bodega_Info> lst_filtro = (from q in context_m.tbl_bodega
                                                    where q.IdEmpresaSCI == IdEmpresa
                                                    select new tbl_bodega_Info
                                                    {
                                                        IdEmpresa = q.IdEmpresa,
                                                        IdSucursal = q.IdSucursal,
                                                        IdBodega = q.IdBodega,
                                                    }).ToList();

                
                
                if (mostrar_no_asignados)
                {
                    Lista = (from q in lst_bodega
                             join b in lst_filtro
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { b.IdEmpresa, b.IdSucursal, b.IdBodega }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_bodega_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 nom_sucursal = q.NomSucursal,
                                 nom_bodega = q.bo_Descripcion,
                                 seleccionado = p == null ? false : true
                             }).ToList();
                }else
                    Lista = (from q in lst_filtro
                             join b in lst_bodega
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { b.IdEmpresa, b.IdSucursal, b.IdBodega }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_bodega_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 nom_sucursal = p.NomSucursal,
                                 nom_bodega = p.bo_Descripcion,
                                 seleccionado = true
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
                    Context.Database.ExecuteSqlCommand("delete mobileSCI.tbl_bodega where IdEmpresaSCI = "+IdEmpresa);
                }
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public bool guardarDB(List<tbl_bodega_Info> Lista)
        {
            try
            {
                int IdSCI = 1;
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    foreach (var item in Lista)
                    {
                        tbl_bodega Entity = new tbl_bodega
                        {
                            IdEmpresaSCI = item.IdEmpresaSCI,
                            IdSCI = IdSCI++,
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdBodega = item.IdBodega,
                        };
                        Context.tbl_bodega.Add(Entity);
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
