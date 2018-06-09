using Core.Erp.Business.General;
using Core.Erp.Data.Inventario_Fj;
using Core.Erp.Info.Inventario_Fj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario_Fj
{
    public class in_Orden_servicio_x_Activo_fijo_det_Bus
    {
        #region Atributos y variables
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_Orden_servicio_x_Activo_fijo_det_Data Data = new in_Orden_servicio_x_Activo_fijo_det_Data();
        string msg = "";
        #endregion

        public List<in_Orden_servicio_x_Activo_fijo_det_Info> Get_Lista_det_x_Orden_servicio(int idEmpresa, int idSucursal, decimal IdOrdenSer_x_Af, ref string msg) 
        {
            try
            {
                return Data.Get_Lista_det_x_Orden_servicio(idEmpresa, idSucursal, IdOrdenSer_x_Af);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Lista_det_x_Orden_servicio", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_det_Bus) };
            }
        }

        public Boolean GuardarDB(List<in_Orden_servicio_x_Activo_fijo_det_Info> info,ref string msg) 
        {
            try
            {
                return Data.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_det_Bus) };
            }
        }

        public Boolean EliminarDB(in_Orden_servicio_x_Activo_fijo_Info info, ref string msg) 
        {
            try
            {
                return Data.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_Orden_servicio_x_Activo_fijo_det_Bus) };
            }
        }


    }
}
