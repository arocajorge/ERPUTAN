using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.MobileSCI
{
    public class tbl_usuario_Data
    {
        public List<tbl_usuario_Info> get_list()
        {
            try
            {
                List<tbl_usuario_Info> Lista;

                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    Lista = (from q in Context.tbl_usuario
                            select new tbl_usuario_Info
                            {
                                IdUsuarioSCI = q.IdUsuarioSCI,
                                clave = q.clave,
                                nom_usuario = q.nom_usuario,
                                estado = q.estado
                            }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool validar_existe_usuario(string IdUsuarioSCI)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    var Entity = Context.tbl_usuario.Where(q => q.IdUsuarioSCI == IdUsuarioSCI).FirstOrDefault();
                    if (Entity == null)
                        return false;
                    return true;
                }
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool guardarDB(tbl_usuario_Info info)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    tbl_usuario Entity = new tbl_usuario
                    {
                        IdUsuarioSCI = info.IdUsuarioSCI,
                        clave = info.clave,
                        nom_usuario = info.nom_usuario,
                        estado = info.estado = true
                    };
                    Context.tbl_usuario.Add(Entity);
                    int sec = 1;
                    foreach (var item in info.lst_usuario_x_bodega)
                    {
                        tbl_usuario_x_bodega EntityB = new tbl_usuario_x_bodega
                        {
                            IdUsuarioSCI = info.IdUsuarioSCI,
                            IdSCI = sec++,
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdBodega = item.IdBodega,
                        };
                        Context.tbl_usuario_x_bodega.Add(EntityB);
                    }
                    sec = 1;
                    foreach (var item in info.lst_usuario_x_subcentro)
                    {
                        tbl_usuario_x_subcentro EntityS = new tbl_usuario_x_subcentro
                        {
                            IdUsuarioSCI = info.IdUsuarioSCI,
                            IdSCI = sec++,
                            IdEmpresa = item.IdEmpresa,
                            IdCentroCosto = item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo
                        };
                        Context.tbl_usuario_x_subcentro.Add(EntityS);
                    }

                    Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool modificarDB(tbl_usuario_Info info)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    tbl_usuario Entity = Context.tbl_usuario.Where(q=>q.IdUsuarioSCI == info.IdUsuarioSCI).FirstOrDefault();
                    if(Entity == null)
                        return false;
                        Entity.clave = info.clave;
                        Entity.nom_usuario = info.nom_usuario;
                        Context.Database.ExecuteSqlCommand("DELETE mobileSCI.tbl_usuario_x_bodega WHERE IdUsuarioSCI = '" + info.IdUsuarioSCI + "'");
                    int sec = 1;
                    foreach (var item in info.lst_usuario_x_bodega)
                    {
                        tbl_usuario_x_bodega EntityB = new tbl_usuario_x_bodega
                        {
                            IdUsuarioSCI = info.IdUsuarioSCI,
                            IdSCI = sec++,
                            IdEmpresa = item.IdEmpresa,
                            IdSucursal = item.IdSucursal,
                            IdBodega = item.IdBodega,
                        };
                        Context.tbl_usuario_x_bodega.Add(EntityB);
                    }
                    Context.Database.ExecuteSqlCommand("DELETE mobileSCI.tbl_usuario_x_subcentro WHERE IdUsuarioSCI = '" + info.IdUsuarioSCI + "'");
                    sec = 1;
                    foreach (var item in info.lst_usuario_x_subcentro)
                    {
                        tbl_usuario_x_subcentro EntityS = new tbl_usuario_x_subcentro
                        {
                            IdUsuarioSCI = info.IdUsuarioSCI,
                            IdSCI = sec++,
                            IdEmpresa = item.IdEmpresa,
                            IdCentroCosto = item.IdCentroCosto,
                            IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo
                        };
                        Context.tbl_usuario_x_subcentro.Add(EntityS);
                    }
                    Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool anularDB(tbl_usuario_Info info)
        {
            try
            {
                using (Entities_mobileSCI Context = new Entities_mobileSCI())
                {
                    tbl_usuario Entity = Context.tbl_usuario.Where(q => q.IdUsuarioSCI == info.IdUsuarioSCI).FirstOrDefault();
                    if (Entity == null)
                        return false;
                    Entity.estado = false;
                    Context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
