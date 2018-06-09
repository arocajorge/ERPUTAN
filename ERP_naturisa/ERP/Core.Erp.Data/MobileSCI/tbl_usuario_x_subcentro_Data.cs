using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_usuario_x_subcentro_Data
    {
        public List<tbl_usuario_x_subcentro_Info> get_list(string IdUsuarioSCI, bool mostrar_no_asignados)
        {
            try
            {
                List<tbl_usuario_x_subcentro_Info> Lista;

                EntitiesDBConta Context_g = new EntitiesDBConta();
                List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = (from b in Context_g.ct_centro_costo_sub_centro_costo
                                                   join s in Context_g.ct_centro_costo
                                                   on new { b.IdEmpresa, b.IdCentroCosto } equals new { s.IdEmpresa, s.IdCentroCosto }
                                                                             select new ct_centro_costo_sub_centro_costo_Info
                                                                             {
                                                                                 IdEmpresa = b.IdEmpresa,
                                                                                 IdCentroCosto = b.IdCentroCosto,
                                                                                 IdCentroCosto_sub_centro_costo = b.IdCentroCosto_sub_centro_costo,
                                                                                 nom_Centro_costo = s.Centro_costo,
                                                                                 NomSubCentroCosto = b.Centro_costo
                                                                             }).ToList();
                Context_g.Dispose();
                Entities_mobileSCI context_m = new Entities_mobileSCI();

                List<tbl_usuario_x_subcentro_Info> lst_filtro = (from q in context_m.tbl_usuario_x_subcentro
                                                                 join c in context_m.tbl_subcentro
                                                                 on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { c.IdEmpresa, c.IdCentroCosto, c.IdCentroCosto_sub_centro_costo}
                                                                 where q.IdUsuarioSCI == IdUsuarioSCI
                                                                 select new tbl_usuario_x_subcentro_Info
                                                       {
                                                           IdEmpresa = q.IdEmpresa,
                                                           IdCentroCosto = q.IdCentroCosto,
                                                           IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                                       }).ToList();

                List<tbl_subcentro_Info> lst_filtro_config = (from q in context_m.tbl_subcentro                                                       
                                                       select new tbl_subcentro_Info
                                                       {
                                                           IdEmpresa = q.IdEmpresa,
                                                           IdCentroCosto = q.IdCentroCosto,
                                                           IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                                       }).ToList();


                if (mostrar_no_asignados)
                {
                    Lista = (from q in lst_subcentro
                             join f in lst_filtro_config
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { f.IdEmpresa, f.IdCentroCosto, f.IdCentroCosto_sub_centro_costo }
                             join b in lst_filtro
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { b.IdEmpresa, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             select new tbl_usuario_x_subcentro_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 nom_centro = q.nom_Centro_costo,
                                 nom_subcentro = q.NomSubCentroCosto,
                                 seleccionado = p == null ? false : true
                             }).ToList();
                }
                else
                    Lista = (from q in lst_filtro
                             join f in lst_filtro_config
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { f.IdEmpresa, f.IdCentroCosto, f.IdCentroCosto_sub_centro_costo }
                             join b in lst_subcentro
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { b.IdEmpresa, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             select new tbl_usuario_x_subcentro_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 nom_centro = p.nom_Centro_costo,
                                 nom_subcentro = p.NomSubCentroCosto,
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
