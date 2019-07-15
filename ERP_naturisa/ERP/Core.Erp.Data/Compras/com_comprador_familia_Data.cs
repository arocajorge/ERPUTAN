using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Compras
{
    public class com_comprador_familia_Data
    {
        public List<com_comprador_familia_Info> GetList(int IdEmpresa, decimal IdComprador)
        {
            try
            {
                List<com_comprador_familia_Info> Lista = new List<com_comprador_familia_Info>();

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.com_comprador_familia.Where(q => q.IdEmpresa == IdEmpresa && q.IdComprador == IdComprador).Select(q => new com_comprador_familia_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdComprador = q.IdComprador,
                        Secuencia = q.Secuencia,
                        IdFamilia = q.IdFamilia
                    }).ToList();
                }

                return Lista;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<com_comprador_familia_Info> GetListPorPedido(int IdEmpresa, decimal IdOrdenPedido)
        {
            try
            {
                List<com_comprador_familia_Info> Lista;

                using (EntitiesCompras db = new EntitiesCompras())
                {
                    Lista = db.vwcom_OrdenPedidoDet_FamiliaComprador.Where(q => q.IdEmpresa == IdEmpresa && q.IdOrdenPedido == IdOrdenPedido).Select(q=> new com_comprador_familia_Info{
                      IdEmpresa = q.IdEmpresa,
                      IdOrdenPedido = q.IdOrdenPedido,
                      Familia = q.Familia,
                      Comprador = q.Comprador
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
