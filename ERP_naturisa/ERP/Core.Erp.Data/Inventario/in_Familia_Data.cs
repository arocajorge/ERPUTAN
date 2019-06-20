using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Inventario
{
    public class in_Familia_Data
    {
        public List<in_Familia_Info> GetList(int IdEmpresa)
        {
            try
            {
                List<in_Familia_Info> Lista = new List<in_Familia_Info>();

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    Lista = db.in_Familia.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new in_Familia_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdFamilia = q.IdFamilia,
                        fa_Codigo = q.fa_Codigo,
                        fa_Descripcion = q.fa_Descripcion,
                        Estado = q.Estado                        
                    }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GetId(int IdEmpresa)
        {
            try
            {
                int ID = 1;

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var lst = db.in_Familia.Where(q => q.IdEmpresa == IdEmpresa).Select(q => q.IdFamilia).ToList();
                    if (lst.Count > 0)
                        ID = lst.Max(q => q) + 1;
                }

                return ID;
            }
            catch (Exception)
            { 
                throw;
            }
        }

        public in_Familia_Info GetInfo(int IdEmpresa, int IdFamilia)
        {
            try
            {
                in_Familia_Info info;

                using (EntitiesInventario db = new EntitiesInventario())
                {
                    info = db.in_Familia.Where(q => q.IdEmpresa == IdEmpresa && q.IdFamilia == IdFamilia).Select(q => new in_Familia_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdFamilia = q.IdFamilia,
                        fa_Codigo = q.fa_Codigo,
                        fa_Descripcion = q.fa_Descripcion,
                        Estado = q.Estado
                    }).FirstOrDefault();
                }

                return info;
            }
            catch (Exception)
            {   
                throw;
            }
        }

        public bool GuardarDB(in_Familia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    db.in_Familia.Add(new in_Familia
                    {
                        IdEmpresa = info.IdEmpresa,
                        IdFamilia = info.IdFamilia = GetId(info.IdEmpresa),
                        fa_Codigo = info.fa_Codigo,
                        fa_Descripcion = info.fa_Descripcion,
                        Estado = true
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

        public bool ModificarDB(in_Familia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_Familia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdFamilia == info.IdFamilia).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.fa_Codigo = info.fa_Codigo;
                        Entity.fa_Descripcion = info.fa_Descripcion;
                        
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

        public bool AnularDB(in_Familia_Info info)
        {
            try
            {
                using (EntitiesInventario db = new EntitiesInventario())
                {
                    var Entity = db.in_Familia.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdFamilia == info.IdFamilia).FirstOrDefault();
                    if (Entity != null)
                    {
                        Entity.Estado = false;

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
