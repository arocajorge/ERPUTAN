using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad ;

namespace Core.Erp.Business.Bancos
{
    public class ba_transferencia_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ba_transferencia_Data data = new ba_transferencia_Data();


        public Boolean GrabarDB(ba_transferencia_Info info, ref decimal IdTranf)
        {
            try
            {
                 return data.GrabarDB(info,ref IdTranf);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ba_transferencia_Bus) };
            }

        }

        public Boolean ModificarDB(ba_transferencia_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ba_transferencia_Bus) };
            }

        }
        public Boolean AnularDB(ba_transferencia_Info info, ref string msg)
        {
            Boolean res = true;
            try
            {
                ct_Cbtecble_Bus busCbte = new ct_Cbtecble_Bus();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info parametros = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus busParam = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

                if (info != null)
                {
                    decimal rev = 0;
                    parametros = busParam.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(info.IdEmpresa_origen).First(q => q.CodTipoCbteBan == "NDBA");
                    if (busCbte.ReversoCbteCble(info.IdEmpresa_origen, info.IdCbteCble_origen, info.IdTipocbte_origen, parametros.IdTipoCbteCble_Anu
                        , ref rev, ref msg, info.IdUsuario_Anu, info.tr_MotivoAnulacion))
                    {
                        parametros = busParam.Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(info.IdEmpresa_destino).First(q => q.CodTipoCbteBan == "NCBA");

                        if (busCbte.ReversoCbteCble(info.IdEmpresa_destino, info.IdCbteCble_destino, info.IdTipocbte_destino, parametros.IdTipoCbteCble_Anu
                        , ref rev, ref msg, info.IdUsuario_Anu, info.tr_MotivoAnulacion))
                        {
                            if (data.AnularDB(info, ref msg))
                                return true;
                            else return false;
                        }
                        else return false;
                    }
                    else return false;
                }
                else { msg = "No existe el registro a anular.."; }
                return res;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ba_transferencia_Bus) };
            }
            
        }


        public List<ba_transferencia_Info> Get_List_transferencia(int IdEmpresa)
        {
            try
            {
              return data.Get_List_transferencia(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_transferencia", ex.Message), ex) { EntityType = typeof(ba_transferencia_Bus) };
            }

        }

        public ba_rpt_transferencia_Info Get_Info_rpt_transferencia(int IdEmpresa, int idtransferencia)
        {
            try
            {
                 return data.Get_Info_rpt_transferencia(IdEmpresa, idtransferencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTable_a_Info", ex.Message), ex) { EntityType = typeof(ba_transferencia_Bus) };
            }

        }

        public ba_transferencia_Bus()
        {
            
        }
    }
}
