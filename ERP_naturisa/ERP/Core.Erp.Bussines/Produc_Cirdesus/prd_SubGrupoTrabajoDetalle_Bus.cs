using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;
//version 24062013....

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_SubGrupoTrabajoDetalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_SubGrupoTrabajoDetalle_Data data = new prd_SubGrupoTrabajoDetalle_Data();

        public List<prd_SubGrupoTrabajoDetalle_Info> ObtenerGrupoTrabDetalle(  decimal IdGrupoTrabajo, int idempresa, int IdSucursal)
        {
            try
            {
                return data.ObtenerGrupoTrabDetalle( IdGrupoTrabajo, idempresa,IdSucursal);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGrupoTrabDetalle", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajoDetalle_Bus) };
              
            }
        }

        public List<prd_SubGrupoTrabajoDetalle_Info> ObtenerGrupoTrabDetalle(int IdEtapa, int IdProcesoProductivo)
        {
            try
            {
                return data.ObtenerGrupoTrabDetalle(IdEtapa, IdProcesoProductivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGrupoTrabDetalle", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajoDetalle_Bus) };
              
            }

        }



        public Boolean grabarDB(List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdGrupoTrabajo, ref string msg)
        {
            try
            {
                return data.grabarDB(lmDetalleInfo, idempresa, IdGrupoTrabajo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarDB", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajoDetalle_Bus) };
              
            }
        }

        public Boolean eliminarregistrotabla(List<prd_SubGrupoTrabajoDetalle_Info> lmDetalleInfo, int idempresa, decimal IdGrupoTrabajo, ref string msg)
        {
            try
            {
                return data.eliminarregistrotabla(lmDetalleInfo, idempresa, IdGrupoTrabajo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(prd_SubGrupoTrabajoDetalle_Bus) };
              
            }
        }
    }
}
