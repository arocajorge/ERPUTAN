using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_presupuestoDetalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_presupuestoDetalle_Data data = new in_presupuestoDetalle_Data();
        public List<in_presupuestoDetalle_Info> ObtenerPRDetalle(int IdPresupuesto, int idempresa)
        {
            try
            {
                return data.Get_List_presupuestoDetalle(IdPresupuesto, idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPRDetalle", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };
                
            }
        }

        public Boolean grabarDB(List<in_presupuestoDetalle_Info> lmDetalleInfo, int idempresa, int IdPresupuesto, ref string msg)
        {
            try
            {
                return data.GrabarDB(lmDetalleInfo, idempresa, IdPresupuesto, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarDB", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public Boolean eliminarregistrotabla(List<in_presupuestoDetalle_Info> lmDetalleInfo, int idempresa, int IdPresupuesto, ref string msg)
        {
            try
            {
                return data.eliminarregistrotabla(lmDetalleInfo, idempresa, IdPresupuesto, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public in_presupuestoDetalle_Bus() { }
    }
}
