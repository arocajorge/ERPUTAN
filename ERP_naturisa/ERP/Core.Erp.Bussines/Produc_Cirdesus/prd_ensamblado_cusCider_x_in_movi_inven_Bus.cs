using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ensamblado_cusCider_x_in_movi_inven_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ensamblado_cusCider_x_in_movi_inven_Data Data = new prd_ensamblado_cusCider_x_in_movi_inven_Data();
        public Boolean GuardarDB(prd_ensamblado_cusCider_x_in_movi_inven_Info Info, ref string msg)
        {
            try
            {
                return Data.GuardarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_ensamblado_cusCider_x_in_movi_inven_Bus) };
                
            }


        }
        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> ConsultaGeneral(int idempresa, ref string msg)
        {
            try
            {
                return Data.ConsultaGeneral(idempresa , ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_ensamblado_cusCider_x_in_movi_inven_Bus) };
                
            }

        }

        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> LstTI_x_Ensamblado(prd_Ensamblado_CusCider_Info Ens, ref string msg)
        {
            try
            {
                return Data.LstTI_x_Ensamblado(Ens, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "LstTI_x_Ensamblado", ex.Message), ex) { EntityType = typeof(prd_ensamblado_cusCider_x_in_movi_inven_Bus) };
                
            }
        }

        public List<prd_ensamblado_cusCider_x_in_movi_inven_Info> TraerUnInfoTI(in_movi_inve_Info mov, ref string msg)
        {
            try
            {
                return Data.LstTI_x_Movimiento(mov, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerUnInfoTI", ex.Message), ex) { EntityType = typeof(prd_ensamblado_cusCider_x_in_movi_inven_Bus) };
                
            }
        }
    }
}
