using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_presupuesto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_presupuesto_Data data = new in_presupuesto_Data();
        public List<in_presupuesto_Info> ObtenerPresupuestoCAB(int idempresa)
        {
            try
            {
                return data.Get_List_presupuesto(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPresupuestoCAB", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public in_presupuesto_Info ObtieneUnPresupuestoCAB(int idempresa, int idsucursal, decimal idPre)
        {
            try
            {
                return data.Get_Info_presupuesto(idempresa, idsucursal, idPre);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtieneUnPresupuestoCAB", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public Boolean CambiaEstado(int idempresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                return data.CambiaEstado(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "CambiaEstado", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public Boolean GrabarCabeceraDB(int idempresa, in_presupuesto_Info info,List<in_presupuestoDetalle_Info> lmDetalleInfo, ref string msg,ref int idgenerada)
        {
            try
            {
                return data.GrabarDB(idempresa, info, lmDetalleInfo, ref msg,ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarCabeceraDB", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public Boolean ModificarDB(int idempresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public Boolean AnularReactiva(int idempresa, in_presupuesto_Info info, ref string msg)
        {
            try
            {
                return data.AnularReactiva(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularReactiva", ex.Message), ex) { EntityType = typeof(in_presupuesto_Bus) };

            }
        }

        public in_presupuesto_Bus() { }
    }
}
