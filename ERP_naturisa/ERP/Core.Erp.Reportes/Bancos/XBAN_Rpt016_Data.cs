using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Bancos
{
    public class XBAN_Rpt016_Data
    {
        public List<XBAN_Rpt016_Info> Get_Lista_Reporte(int idEmpresa, int idPersonaIni, int idPersonaFin, int idBancoIni, int idBancoFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XBAN_Rpt016_Info> Lista = new List<XBAN_Rpt016_Info>();

                using (EntitiesBancos_Reporte_Ge Conexion = new EntitiesBancos_Reporte_Ge())
                {
                    Lista = (from q in Conexion.vwBAN_Rpt016
                             where idEmpresa == q.IdEmpresa
                             && idPersonaIni <= q.IdPersona_Girado_a && q.IdPersona_Girado_a <= idPersonaFin
                             && idBancoIni <= q.IdBanco && q.IdBanco <= idBancoFin
                             && FechaIni <= q.cb_Fecha && q.cb_Fecha <= FechaFin
                             select new XBAN_Rpt016_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdCbteCble = q.IdCbteCble,
                                 IdTipocbte = q.IdTipocbte,
                                 Cod_Cbtecble = q.Cod_Cbtecble,
                                 IdPeriodo = q.IdPeriodo,
                                 IdBanco = q.IdBanco,
                                 IdProveedor = q.IdProveedor,
                                 cb_Fecha = q.cb_Fecha,
                                 cb_Observacion = q.cb_Observacion,
                                 cb_secuencia = q.cb_secuencia,
                                 cb_Valor = q.cb_Valor,
                                 cb_Cheque = q.cb_Cheque,
                                 cb_ChequeImpreso = q.cb_ChequeImpreso,
                                 cb_FechaCheque = q.cb_FechaCheque,
                                 IdUsuario = q.IdUsuario,
                                 IdUsuario_Anu = q.IdUsuario_Anu,
                                 FechaAnulacion = q.FechaAnulacion,
                                 Fecha_Transac = q.Fecha_Transac,
                                 Fecha_UltMod = q.Fecha_UltMod,
                                 IdUsuarioUltMod = q.IdUsuarioUltMod,
                                 Estado = q.Estado,
                                 MotivoAnulacion = q.MotivoAnulacion,
                                 ip = q.ip,
                                 nom_pc = q.nom_pc,
                                 IdPersona_Girado_a = q.IdPersona_Girado_a,
                                 cb_giradoA = q.cb_giradoA,
                                 cb_ciudadChq = q.cb_ciudadChq,
                                 IdCbteCble_Anulacion = q.IdCbteCble_Anulacion,
                                 IdTipoCbte_Anulacion = q.IdTipoCbte_Anulacion,
                                 IdTipoFlujo = q.IdTipoFlujo,
                                 IdTipoNota = q.IdTipoNota,
                                 IdTransaccion = q.IdTransaccion,
                                 Por_Anticipo = q.Por_Anticipo,
                                 PosFechado = q.PosFechado,
                                 ValorEnLetras = q.ValorEnLetras,
                                 IdSucursal = q.IdSucursal,
                                 Tipo_Conciliacion = q.Tipo_Conciliacion,
                                 ba_descripcion = q.ba_descripcion
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
