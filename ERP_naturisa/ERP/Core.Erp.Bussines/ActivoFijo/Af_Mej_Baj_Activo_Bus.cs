using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Mej_Baj_Activo_Bus
    {
        Af_Mej_Baj_Activo_Data dataAf = new Af_Mej_Baj_Activo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_Cbtecble_Bus busCbteCble = new ct_Cbtecble_Bus();
        Af_TipoTransac_x_Cta_CbteCble_Bus busTranCta = new Af_TipoTransac_x_Cta_CbteCble_Bus();

        public Boolean GuardarDB(Af_Mej_Baj_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdMejoraBaja, ref decimal IdCbteCble, ref string msjError)
        {
            try
            {
                if (dataAf.GuardarDB(InfoAf, ref IdMejoraBaja, ref msjError))
                {
                    InfoAf.Id_Mejora_Baja_Activo = IdMejoraBaja;
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDataDB", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        private Af_TipoTransac_x_Cta_CbteCble_Info Get_Info_TipoTran_x_CtaCble(Af_Mej_Baj_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo)
        {
            try
            {
                Af_TipoTransac_x_Cta_CbteCble_Info infoTranCtaCble = new Af_TipoTransac_x_Cta_CbteCble_Info();
                infoTranCtaCble.IdEmpresa = InfoAf.IdEmpresa;
                infoTranCtaCble.IdTipTransActivoFijo = InfoAf.Id_Mejora_Baja_Activo;
                infoTranCtaCble.IdCatalogo = InfoAf.Id_Tipo;
                infoTranCtaCble.ct_IdEmpresa = CbteCbleInfo.IdEmpresa;
                infoTranCtaCble.ct_IdCbteCble = CbteCbleInfo.IdCbteCble;
                infoTranCtaCble.ct_IdTipoCbte = CbteCbleInfo.IdTipoCbte;
                return infoTranCtaCble;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getTipoTran_x_CtaCble", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public Boolean ModificarDB(Af_Mej_Baj_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref string msjError)
        {
            try
            {
                if (dataAf.ModificarDB(InfoAf, ref msjError))
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDataDB", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public Boolean AnularDB(Af_Mej_Baj_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdCbteCble_Rev, ref string msjError)
        {
            try
            {
                if (dataAf.AnularDB(InfoAf, ref msjError))
                    return busCbteCble.ReversoCbteCble(CbteCbleInfo.IdEmpresa, CbteCbleInfo.IdCbteCble, CbteCbleInfo.IdTipoCbte, InfoAf.IdTipoCbte_Rev, ref IdCbteCble_Rev, ref msjError, InfoAf.IdUsuarioUltAnu, InfoAf.MotivoAnula);
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDataDB", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public Af_Mej_Baj_Activo_Info Get_Info_Mej_Baj_Activo(int IdEmpresa, decimal Id_Mej_Baj_Activo, string Id_Tipo)
        {
            try
            {
                return dataAf.Get_Info_Mej_Baj_Activo(IdEmpresa, Id_Mej_Baj_Activo, Id_Tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Mej_Baj_Activo", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public List<Af_Mej_Baj_Activo_Info> Get_List_Sum_Valor_Mej_Baj_Activo(int IdEmpresa, decimal IdActivoFijo)
        {
            try
            {
                return dataAf.Get_List_Sum_Valor_Mej_Baj_Activo(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Sum_Valor_Mej_Baj_Activo", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public List<Af_Mej_Baj_Activo_Info> Get_List_Mej_Baj_Activo(int IdEmpresa, string IdTipo, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataAf.Get_List_Mej_Baj_Activo(IdEmpresa, IdTipo, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Mej_Baj_Activo", ex.Message), ex) { EntityType = typeof(Af_Mej_Baj_Activo_Bus) };
            }
        }


        public Af_Mej_Baj_Activo_Bus()
        {

        }
    }
}
