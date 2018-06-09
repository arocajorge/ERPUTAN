using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_AjusteFisico_Detalle_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_AjusteFisico_Detalle_Data oDat = new in_AjusteFisico_Detalle_Data();

        public Boolean GuardarDB(List<in_AjusteFisico_Detalle_Info> Lista)
        {
            try
            {
                 return  oDat.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBase", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Detalle_Bus) };
            }
        }

        public List<in_AjusteFisico_Detalle_Info> Get_List_AjusteFisico_Detalle(int IdEmpresa, decimal IdAjusteFisico)
        {
            try
            {
               return oDat.Get_List_AjusteFisico_Detalle(IdEmpresa,  IdAjusteFisico);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDetalleAjuste", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Detalle_Bus) };

            }

        }

        public Boolean EliminarDB(int IdEmpresa, decimal IdAjusteFisico)
        {
            try
            {
             return oDat.EliminarDB(IdEmpresa, IdAjusteFisico);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(in_AjusteFisico_Detalle_Bus) };
            }
        }
    }
}
