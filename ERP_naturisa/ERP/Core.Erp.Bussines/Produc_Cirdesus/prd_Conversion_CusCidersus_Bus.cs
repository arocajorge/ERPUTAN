using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{/////--------
    public class prd_Conversion_CusCidersus_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_Conversion_CusCidersus_Data Data = new prd_Conversion_CusCidersus_Data();
       
        public Boolean GuardarDB(prd_Conversion_CusCidersus_Info Info, ref Decimal Id, ref String Mensjae)
        {
            try
            {
               return Data.GuardarDB(Info,ref Id, ref Mensjae);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_Conversion_CusCidersus_Bus) };
                
            }

        }
        public List<prd_Conversion_CusCidersus_Info> ConsultaGeneral(int IdEmpresa, DateTime FechaIn, DateTime FechaFin)
        {
            try
            {
                return Data.ConsultaGeneral(IdEmpresa,  FechaIn,FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(prd_Conversion_CusCidersus_Bus) };
                
            }

        }
        public Boolean Anular(prd_Conversion_CusCidersus_Info Info, ref String Mensjae)
        {
            try
            {
                return Data.Anular(Info, ref Mensjae);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(prd_Conversion_CusCidersus_Bus) };
                
            }

        }
    }
}
