using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_solicitante_aprobador_Data
    {
        public List<com_solicitante_aprobador_Info> GetList(int IdEmpresa, decimal IdSolicitante)
        {
            try
            {
                List<com_solicitante_aprobador_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_solicitante_aprobador.Where(q => q.IdEmpresa == IdEmpresa && q.IdSolicitante == IdSolicitante).Select(q => new com_solicitante_aprobador_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdSolicitante = q.IdSolicitante,
                        IdDepartamento = q.IdDepartamento,
                        IdUsuario = q.IdUsuario,
                        Secuencia = q.Secuencia
                    }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
