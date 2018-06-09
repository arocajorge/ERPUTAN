using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Presupuesto
{
    public class pre_ordencompra_local_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        pre_ordencompra_local_det_Data data = new pre_ordencompra_local_det_Data();

        public Boolean GrabarLstDB(List<pre_ordencompra_local_det_Info> Lst)
        {
            try
            {
              return data.GrabarLstDB(Lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarLstDB", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_det_Bus) };

            }

        }

        public List<pre_ordencompra_local_det_Info> ObtenerLst(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {
            try
            {
             return data.ObtenerLst(IdEmpresa, IdSucursal, IdOrdenCompra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLst", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_det_Bus) };

            }

        }

        public pre_ordencompra_local_det_Bus()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pre_ordencompra_local_det_Bus", ex.Message), ex) { EntityType = typeof(pre_ordencompra_local_det_Bus) };


            }
        }
    }
}
