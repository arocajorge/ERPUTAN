using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_RutaPorEmpresaPorUsuario_Data
    {
        public cp_RutaPorEmpresaPorUsuario_Info GetInfo(int IdEmpresa, string IdUsuario)
        {
            try
            {
                cp_RutaPorEmpresaPorUsuario_Info info = new cp_RutaPorEmpresaPorUsuario_Info();
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var Entity = db.cp_RutaPorEmpresaPorUsuario.Where(q => q.IdEmpresa == IdEmpresa && q.IdUsuario.ToLower() == IdUsuario.ToLower()).FirstOrDefault();
                    if (Entity == null)
                        return null;

                    info = new cp_RutaPorEmpresaPorUsuario_Info
                    {
                        IdUsuario = Entity.IdUsuario,
                        IdEmpresa = Entity.IdEmpresa,
                        RutaXML = Entity.RutaXML
                    };
                }
                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool GuardarDB(cp_RutaPorEmpresaPorUsuario_Info info)
        {
            try
            {
                using (EntitiesCuentasxPagar db = new EntitiesCuentasxPagar())
                {
                    var Entity = db.cp_RutaPorEmpresaPorUsuario.Where(q => q.IdEmpresa == info.IdEmpresa && q.IdUsuario.ToLower() == info.IdUsuario.ToLower()).FirstOrDefault();
                    if (Entity == null)
                    {
                        db.cp_RutaPorEmpresaPorUsuario.Add(new cp_RutaPorEmpresaPorUsuario
                        {
                            IdUsuario = info.IdUsuario,
                            IdEmpresa = info.IdEmpresa,
                            RutaXML = info.RutaXML
                        });
                    }
                    else
                        Entity.RutaXML = info.RutaXML;
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
