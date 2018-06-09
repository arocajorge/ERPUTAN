using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_subcentro_Data
    {
        public List<tbl_subcentro_Info> get_list(int IdEmpresa, bool mostrar_no_asignados)
        {
            try
            {
                List<tbl_subcentro_Info> Lista;

                EntitiesDBConta Context_g = new EntitiesDBConta();
                List<ct_centro_costo_sub_centro_costo_Info> lst_subcentro = (from b in Context_g.ct_centro_costo_sub_centro_costo
                                                                             join s in Context_g.ct_centro_costo
                                                                             on new { b.IdEmpresa, b.IdCentroCosto } equals new { s.IdEmpresa, s.IdCentroCosto }
                                                                             where b.IdEmpresa == IdEmpresa
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

                List<tbl_subcentro_Info> lst_filtro = (from q in context_m.tbl_subcentro
                                                    where q.IdEmpresaSCI == IdEmpresa
                                                    select new tbl_subcentro_Info
                                                    {
                                                        IdEmpresa = q.IdEmpresa,
                                                        IdCentroCosto = q.IdCentroCosto,
                                                        IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                                    }).ToList();

                

                if (mostrar_no_asignados)
                {
                    Lista = (from q in lst_subcentro
                             join b in lst_filtro
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { b.IdEmpresa, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_subcentro_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo,
                                 nom_centro = q.nom_Centro_costo,
                                 nom_subcentro = q.NomSubCentroCosto,
                                 seleccionado = p == null ? false : true
                             }).ToList();
                }else
                    Lista = (from q in lst_filtro
                             join b in lst_subcentro
                             on new { q.IdEmpresa, q.IdCentroCosto, q.IdCentroCosto_sub_centro_costo } equals new { b.IdEmpresa, b.IdCentroCosto, b.IdCentroCosto_sub_centro_costo }
                             into gr
                             from p in gr.DefaultIfEmpty()
                             where q.IdEmpresa == IdEmpresa
                             select new tbl_subcentro_Info
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
        public bool eliminarDB(int IdEmpresa)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    Context.Database.ExecuteSqlCommand("delete mobileSCI.tbl_subcentro where IdEmpresaSCI = " + IdEmpresa);
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool guardarDB(List<tbl_subcentro_Info> Lista)
        {
            try
            {
                int IdSCI = 1;
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    foreach (var item in Lista)
                    {
                        tbl_subcentro Entity = new tbl_subcentro
                        {
                            IdEmpresaSCI = item.IdEmpresaSCI,
                            IdSCI = IdSCI++,
                            IdEmpresa = item.IdEmpresa,
                            IdCentroCosto = item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo,
                        };
                        Context.tbl_subcentro.Add(Entity);
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
