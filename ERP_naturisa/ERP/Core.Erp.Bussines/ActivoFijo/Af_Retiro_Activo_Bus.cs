using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Retiro_Activo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_Retiro_Activo_Data dataRet = new Af_Retiro_Activo_Data();
        Af_Activo_fijo_Data dataActFijo = new Af_Activo_fijo_Data();
        Af_Activo_fijo_Data activoData = new Af_Activo_fijo_Data();
        ct_Cbtecble_Bus busCbteCble = new ct_Cbtecble_Bus();
        Af_TipoTransac_x_Cta_CbteCble_Bus busTranCta = new Af_TipoTransac_x_Cta_CbteCble_Bus();

        public Boolean GuardarDB(Af_Retiro_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdRetiroActivo, ref decimal IdCbteCble, ref string msjError)
        {
            try
            {
                if (dataRet.GuardarDB(InfoAf, ref IdRetiroActivo, ref msjError))
                {
                    dataActFijo.ModificarEstadoProceso(InfoAf.IdEmpresa, InfoAf.IdActivoFijo, Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_RETIRO.ToString());
                    InfoAf.IdRetiroActivo = IdRetiroActivo;
                    if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                    {
                        busCbteCble.GrabarDB(CbteCbleInfo, ref IdCbteCble, ref msjError);
                        CbteCbleInfo.IdCbteCble = IdCbteCble;
                        return busTranCta.GuardarTran_x_CbteCble(Get_Info_TipoTran_x_CtaCble(InfoAf, CbteCbleInfo), ref msjError);
                    }
                    else
                        return false;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PeriodoDepreciacion", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        private Af_TipoTransac_x_Cta_CbteCble_Info Get_Info_TipoTran_x_CtaCble(Af_Retiro_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo)
        {
            try
            {
                Af_TipoTransac_x_Cta_CbteCble_Info infoTranCtaCble = new Af_TipoTransac_x_Cta_CbteCble_Info();
                infoTranCtaCble.IdEmpresa = InfoAf.IdEmpresa;
                infoTranCtaCble.IdTipTransActivoFijo = InfoAf.IdRetiroActivo;
                infoTranCtaCble.IdCatalogo = Cl_Enumeradores.eTipoActivoFijo.Retiro_Acti.ToString();
                infoTranCtaCble.ct_IdEmpresa = CbteCbleInfo.IdEmpresa;
                infoTranCtaCble.ct_IdCbteCble = CbteCbleInfo.IdCbteCble;
                infoTranCtaCble.ct_IdTipoCbte = CbteCbleInfo.IdTipoCbte;
                return infoTranCtaCble;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getTipoTran_x_CtaCble", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        public Boolean ModificarDB(Af_Retiro_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref string msjError)
        {
            try
            {
                if (dataRet.ModificarDB(InfoAf, ref msjError))
                {
                    if (busCbteCble.ValidarObjeto(CbteCbleInfo, ref msjError))
                        return busCbteCble.ModificarDB(CbteCbleInfo, ref msjError);
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        public Boolean AnularDB(Af_Retiro_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdCbteCble_Rev, ref string msjError)
        {
            try
            {
                if (dataRet.AnularDB(InfoAf, ref msjError))
                {
                    dataActFijo.ModificarEstadoProceso(InfoAf.IdEmpresa, InfoAf.IdActivoFijo, Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString());
                    return busCbteCble.ReversoCbteCble(CbteCbleInfo.IdEmpresa, CbteCbleInfo.IdCbteCble, CbteCbleInfo.IdTipoCbte, InfoAf.IdTipoCbte_Rev, ref IdCbteCble_Rev, ref msjError, InfoAf.IdUsuarioUltAnu, InfoAf.MotivoAnula);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        public List<Af_Retiro_Activo_Info> Get_List_Retiro_Activo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataRet.Get_List_Retiro_Activo(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Retiro_Activo", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        public Af_Retiro_Activo_Info Get_Info_Retiro_Activo(int IdEmpresa, decimal IdRetiroActivo)
        {
            try
            {
                return dataRet.Get_Info_Retiro_Activo(IdEmpresa, IdRetiroActivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Retiro_Activo", ex.Message), ex) { EntityType = typeof(Af_Retiro_Activo_Bus) };
            }
        }

        public Af_Retiro_Activo_Bus()
        {

        }
    }
}
