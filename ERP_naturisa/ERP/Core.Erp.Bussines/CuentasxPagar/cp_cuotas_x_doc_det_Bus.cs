using Core.Erp.Business.General;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_cuotas_x_doc_det_Bus
    {
        cp_cuotas_x_doc_det_Data oData = new cp_cuotas_x_doc_det_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<cp_cuotas_x_doc_det_Info> Get_list_cuotas_x_doc_det(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                return oData.Get_list_cuotas_x_doc_det(IdEmpresa,IdCuota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_det_Bus) };
            }
        }

        public bool EliminarDB(int IdEmpresa, decimal IdCuota)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdCuota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_det_Bus) };
            }
        }

        public bool GuardarDB(List<cp_cuotas_x_doc_det_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_det_Bus) };
            }
        }

        public bool ModificarDB_campos_op(cp_cuotas_x_doc_det_Info info)
        {
            try
            {
                return oData.ModificarDB_campos_op(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_cuotas_x_doc", ex.Message), ex) { EntityType = typeof(cp_cuotas_x_doc_det_Bus) };
            }
        }
    }
}
