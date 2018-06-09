using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt025_Data
    {
        public List<XCXP_Rpt025_Info> Get_Lista_Reporte(int idEmpresa, string idCentroCosto, string idSubcentroCosto, DateTime fechaIni, DateTime FechaFin)
        {
            try
            {
                List<XCXP_Rpt025_Info> Lista = new List<XCXP_Rpt025_Info>();

                using (EntitiesCXP_General Conexion = new EntitiesCXP_General())
                {
                    Lista = (from q in Conexion.vwCXP_Rpt025
                             where q.IdEmpresa == idEmpresa
                             && q.IdCentroCosto.Contains(idCentroCosto)
                             && q.IdSubCentro_Costo.Contains(idSubcentroCosto)
                             && fechaIni<= q.Fecha_Fa_Prov && q.Fecha_Fa_Prov <= FechaFin
                             select new XCXP_Rpt025_Info
                             {
                                 nom_Centro_costo = q.nom_Centro_costo,
                                 nom_subCentro_costo = q.nom_subCentro_costo,
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipo_op = q.IdTipo_op,
                                 Referencia = q.Referencia,
                                 Referencia2 = q.Referencia2,
                                 IdOrdenPago = q.IdOrdenPago,
                                 Secuencia_OP = q.Secuencia_OP,
                                 IdTipoPersona = q.IdTipoPersona,
                                 IdPersona = q.IdPersona,
                                 Nom_Beneficiario = q.Nom_Beneficiario,
                                 Fecha_Fa_Prov = q.Fecha_Fa_Prov,
                                 Observacion = q.Observacion,
                                 Valor_a_pagar = q.Valor_a_pagar,
                                 Saldo_x_Pagar_OP = q.Saldo_x_Pagar_OP,
                                 IdEstadoAprobacion = q.IdEstadoAprobacion,
                                 IdCentroCosto = q.IdCentroCosto,
                                 IdSubCentro_Costo = q.IdSubCentro_Costo,
                                 IdFormaPago = q.IdFormaPago

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
