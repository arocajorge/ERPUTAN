using Core.Erp.Info.General;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_usuario_x_bodega_Data
    {
        public List<tbl_usuario_x_bodega_Info> get_list(string IdUsuarioSCI, bool mostrar_no_asignados)
        {
            try
            {
                List<tbl_usuario_x_bodega_Info> Lista;

                EntitiesGeneral Context_g = new EntitiesGeneral();
                List<tb_Bodega_Info> lst_bodega = (from b in Context_g.tb_bodega
                                                   join s in Context_g.tb_sucursal
                                                   on new { b.IdEmpresa, b.IdSucursal } equals new { s.IdEmpresa, s.IdSucursal }                                                   
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

                List<tbl_usuario_x_bodega_Info> lst_filtro = (from q in context_m.tbl_usuario_x_bodega
                                                              join c in context_m.tbl_bodega
                                                              on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { c.IdEmpresa, c.IdSucursal, c.IdBodega}
                                                              where q.IdUsuarioSCI == IdUsuarioSCI
                                                              select new tbl_usuario_x_bodega_Info
                                                    {
                                                        IdEmpresa = q.IdEmpresa,
                                                        IdSucursal = q.IdSucursal,
                                                        IdBodega = q.IdBodega,
                                                    }).ToList();

                List<tbl_bodega_Info> lst_filtro_config = (from q in context_m.tbl_bodega                                                    
                                                    select new tbl_bodega_Info
                                                    {
                                                        IdEmpresa = q.IdEmpresa,
                                                        IdSucursal = q.IdSucursal,
                                                        IdBodega = q.IdBodega,
                                                    }).ToList();

                if (mostrar_no_asignados)
                {
                    Lista = (from q in lst_bodega
                             join f in lst_filtro_config
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { f.IdEmpresa, f.IdSucursal, f.IdBodega}
                             join b in lst_filtro
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { b.IdEmpresa, b.IdSucursal, b.IdBodega }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             select new tbl_usuario_x_bodega_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 nom_sucursal = q.NomSucursal,
                                 nom_bodega = q.bo_Descripcion,
                                 seleccionado = p == null ? false : true
                             }).ToList();
                }
                else
                    Lista = (from q in lst_filtro
                             join f in lst_filtro_config
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { f.IdEmpresa, f.IdSucursal, f.IdBodega }
                             join b in lst_bodega
                             on new { q.IdEmpresa, q.IdSucursal, q.IdBodega } equals new { b.IdEmpresa, b.IdSucursal, b.IdBodega }
                             select new tbl_usuario_x_bodega_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdSucursal = q.IdSucursal,
                                 IdBodega = q.IdBodega,
                                 nom_sucursal = b.NomSucursal,
                                 nom_bodega = b.bo_Descripcion,
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
    }
}
