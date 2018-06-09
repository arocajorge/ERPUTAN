using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Facturacion
{
   public class fa_formaPago_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_formaPago_Data Data = new fa_formaPago_Data();



        public List<fa_formaPago_Info> Get_List_fa_formaPago()
        {
            try
            {

                return Data.Get_List_fa_formaPago();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
                
            }
        }

        public Boolean GuardarDB(fa_formaPago_Info Info, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
            }
        }

        public bool ModificarDB(fa_formaPago_Info info, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(fa_formaPago_Bus) };
            }
        }


    }
}
