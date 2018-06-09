using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Venta_Activo_Bus
    {
        Af_Venta_Activo_Data dataAf = new Af_Venta_Activo_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        Af_Activo_fijo_Data activoData = new Af_Activo_fijo_Data();
        ct_Cbtecble_Bus busCbteCble = new ct_Cbtecble_Bus();
        Af_TipoTransac_x_Cta_CbteCble_Bus busTranCta = new Af_TipoTransac_x_Cta_CbteCble_Bus();

        public Boolean GuardarDB(Af_Venta_Activo_Info InfoAf ,  ct_Cbtecble_Info CbteCbleInfo, ref decimal IdVtaActivo, ref decimal IdCbteCble, ref string msjError)
        {
            try
            {
                if (dataAf.GuardarDB(InfoAf, ref IdVtaActivo, ref msjError))
                {
                    activoData.ModificarEstadoProceso(InfoAf.IdEmpresa, InfoAf.IdActivoFijo, Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_VENTA.ToString());
                    InfoAf.IdVtaActivo = IdVtaActivo;
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }


        private Af_TipoTransac_x_Cta_CbteCble_Info Get_Info_TipoTran_x_CtaCble(Af_Venta_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo)
        {
            try
            {
                Af_TipoTransac_x_Cta_CbteCble_Info infoTranCtaCble = new Af_TipoTransac_x_Cta_CbteCble_Info();
                infoTranCtaCble.IdEmpresa = InfoAf.IdEmpresa;
                infoTranCtaCble.IdTipTransActivoFijo = InfoAf.IdVtaActivo;
                infoTranCtaCble.IdCatalogo = Cl_Enumeradores.eTipoActivoFijo.Venta_Acti.ToString();
                infoTranCtaCble.ct_IdEmpresa = CbteCbleInfo.IdEmpresa;
                infoTranCtaCble.ct_IdCbteCble = CbteCbleInfo.IdCbteCble;
                infoTranCtaCble.ct_IdTipoCbte = CbteCbleInfo.IdTipoCbte;
                return infoTranCtaCble;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getTipoTran_x_CtaCble", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }


        public Boolean ModificarDB(Af_Venta_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref string msjError)
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
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }

        public Boolean AnularDB(Af_Venta_Activo_Info InfoAf, ct_Cbtecble_Info CbteCbleInfo, ref decimal IdCbteCble_Rev, ref string msjError)
        {
            try
            {
                if (dataAf.AnularDB(InfoAf, ref msjError))
                {
                    activoData.ModificarEstadoProceso(InfoAf.IdEmpresa, InfoAf.IdActivoFijo, Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString());
                    return busCbteCble.ReversoCbteCble(CbteCbleInfo.IdEmpresa, CbteCbleInfo.IdCbteCble, CbteCbleInfo.IdTipoCbte, InfoAf.IdTipoCbte_Rev, ref IdCbteCble_Rev, ref msjError, InfoAf.IdUsuarioUltAnu, InfoAf.MotivoAnula);
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }


        public List<Af_Venta_Activo_Info> Get_List_Venta_Activo(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataAf.Get_List_Venta_Activo(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Venta_Activo", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }

        public Af_Venta_Activo_Info Get_Info_Venta_Activo(int IdEmpresa, decimal IdVtaActivo)
        {
            try
            {
                return dataAf.Get_Info_Venta_Activo(IdEmpresa, IdVtaActivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Venta_Activo", ex.Message), ex) { EntityType = typeof(Af_Venta_Activo_Bus) };
            }
        }

        public Af_Venta_Activo_Bus()
        {
                
        }
    }
}
