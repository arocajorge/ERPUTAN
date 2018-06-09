using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Produc_Cirdesus
{
    
    public class prd_Ensamblado_Det_CusCider_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Ensamblado_Det_CusCider_Data Data = new prd_Ensamblado_Det_CusCider_Data();

        public Boolean GuardarDB(List<prd_Ensamblado_Det_CusCider_Info> Info, ref string msg)
        {
            try
            {
                return Data.GuardarDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_Det_CusCider_Bus) };
                
            }
        }

        public List<prd_Ensamblado_Det_CusCider_Info> ConsultaEnsamblado(int Idempresa, int IdSucursal, decimal  IdEnsamblado, ref string msg)
        {
            try
            {
                return Data.ConsultaEnsamblado(Idempresa, IdSucursal, IdEnsamblado, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaEnsamblado", ex.Message), ex) { EntityType = typeof(prd_Ensamblado_Det_CusCider_Bus) };
                
            }
        }

    }
}
