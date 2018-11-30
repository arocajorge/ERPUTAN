using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt023_Data
    {
        public List<XCONTA_Rpt023_Info> GetList(int IdEmpresa, string IdCentroCosto, int Nivel, DateTime FechaFin, string IdUsuario, string Balance, bool MostrarSaldo0)
        {
            try
            {
                using (EntitiesContabilidadRptGeneral db = new EntitiesContabilidadRptGeneral())
                {
                    return db.spCONTA_Rpt023(IdEmpresa, IdCentroCosto, Nivel, FechaFin, IdUsuario, Balance, MostrarSaldo0).Select(q => new XCONTA_Rpt023_Info
                    {
                        IdEmpresa = q.IdEmpresa,
                        IdCtaCble = q.IdCtaCble,
                        IdCentroCosto = q.IdCentroCosto,
                        IdUsuario = q.IdUsuario,
                        IdCtaCblePadre = q.IdCtaCblePadre,
                        Naturaleza = q.Naturaleza,
                        NombreCuenta = q.NombreCuenta,
                        NombreCentroCosto = q.NombreCentroCosto,
                        EsCuentaMovimiento = q.EsCuentaMovimiento,
                        NivelCuenta = q.NivelCuenta,
                        Saldo = q.Saldo,
                        SaldoNaturaleza = q.SaldoNaturaleza,
                        TipoCuenta = q.EsCuentaMovimiento == true ? "Cta Movimiento" : "Cta Padre"
                    }).ToList();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
