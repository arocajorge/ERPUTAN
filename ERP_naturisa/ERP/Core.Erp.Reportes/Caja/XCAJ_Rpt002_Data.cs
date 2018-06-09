using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Caja
{
    public class XCAJ_Rpt002_Data
    {
        string MensajeError = "";

        public List<XCAJ_Rpt002_Info> Get_List(int IdEmpresa, int IdCajaIni, int IdCajaFin, int IdTipoMoviIni, int IdTipoMoviFin, string TipoIngrEgr, DateTime FechaIni, DateTime FechaFin, decimal IdPersonaIni, decimal IdPersonaFin, decimal IdEntidadIni, decimal IdEntidadFin, int IdTipoFlujoIni, int IdTipoFlujoFin, string IdTipo_Persona)
        {
            try
            {
                List<XCAJ_Rpt002_Info> Lista = new List<XCAJ_Rpt002_Info>();
                using (EntitiesCaja_General context = new EntitiesCaja_General())
                {
                    var contact = from c in context.vwCAJ_Rpt002
                                  where c.IdEmpresa==IdEmpresa 
                                  && c.IdCaja>=IdCajaIni && c.IdCaja<=IdCajaFin
                                  && c.IdTipoMovi>=IdTipoMoviIni && c.IdTipoMovi<=IdTipoMoviFin
                                  && c.cm_Signo.Contains(TipoIngrEgr)
                                  && c.cm_fecha>=FechaIni && c.cm_fecha<=FechaFin
                                  && c.IdPersona>=IdPersonaIni && c.IdPersona<=IdPersonaFin
                                  && c.IdTipo_Persona.Contains(IdTipo_Persona)
                                  && c.IdEntidad>=IdEntidadIni && c.IdEntidad<=IdEntidadFin
                                  && c.IdTipoFlujo>=IdTipoFlujoIni && c.IdTipoFlujo<=IdTipoFlujoFin
                                  select c;

                    foreach (var item in contact)
                    {
                        XCAJ_Rpt002_Info Info = new XCAJ_Rpt002_Info();
                        
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCbteCble = item.IdCbteCble;
                        Info.IdTipocbte = item.IdTipocbte;
                        Info.Tipo_Cbte = item.Tipo_Cbte;
                        Info.cm_fecha = item.cm_fecha;
                        Info.cm_Signo = item.cm_Signo;
                        Info.cm_beneficiario = item.cm_beneficiario;
                        Info.cm_observacion = item.cm_observacion;
                        Info.Estado = item.Estado;
                        Info.IdCaja = item.IdCaja;
                        Info.nom_caja = item.nom_caja;
                        Info.IdSucursal = item.IdSucursal;
                        Info.nom_sucursal = item.nom_sucursal;
                        Info.IdTipoMovi = item.IdTipoMovi;
                        Info.nom_TipoMovi = item.nom_TipoMovi;
                        Info.nom_empresa = item.nom_empresa; 
                        Info.IdCobro_tipo = item.IdCobro_tipo;
                        Info.cr_Valor = item.cr_Valor;
                        Info.cr_NumDocumento = item.cr_NumDocumento;
                        Info.IdTipoFlujo = item.IdTipoFlujo;
                        Info.nom_TipoFlujo = item.nom_TipoFlujo;
                        Info.IdPersona = item.IdPersona;
                        Info.IdTipo_Persona = item.IdTipo_Persona;
                        Info.IdEntidad = item.IdEntidad;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string MensajeError = "";
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Data_Reporte", ex.Message), ex) { EntityType = typeof(XCAJ_Rpt002_Data) };
           }
        }
    }
}
