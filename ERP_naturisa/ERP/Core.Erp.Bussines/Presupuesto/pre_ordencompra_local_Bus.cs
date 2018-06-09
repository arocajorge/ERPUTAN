using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Presupuesto
{
    public class pre_ordencompra_local_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        pre_ordencompra_local_Data data = new pre_ordencompra_local_Data();

        public Boolean GrabarDB(pre_ordencompra_local_Info Info, ref decimal IdOrdenCompra)
        {
            try
            {
                  return data.GrabarDB(Info, ref IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_Bus) };

            }

        }

        public List<pre_ordencompra_local_Info> ObtenerList(int IdEmpresa, int IdSucursal)
        {
            try
            {
               return data.ObtenerList(IdEmpresa,IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_Bus) };

            }

        }

        public Boolean ModificarDB(pre_ordencompra_local_Info Info)
        {
            try
            {
                 return data.ModificarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_Bus) };

            }

        }

        public Boolean AnularDB(pre_ordencompra_local_Info info)
        {
            try
            {
                 return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_Bus) };


            }

        }

        public pre_ordencompra_local_Bus(){
            try
            {

            }
            catch (Exception  ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pre_ordencompra_local_Bus", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_Bus) };


            }
        }
    }
}
