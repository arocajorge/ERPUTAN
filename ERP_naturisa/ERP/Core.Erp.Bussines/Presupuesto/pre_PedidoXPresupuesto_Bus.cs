using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Business.General;
//8-5-2013
namespace Core.Erp.Business.Presupuesto
{
    public class pre_PedidoXPresupuesto_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        pre_PedidoXPresupuesto_Data data = new pre_PedidoXPresupuesto_Data();

        public Boolean GrabarDB(pre_PedidoXPresupuesto_Info Info,ref decimal IdPedidoXPre)
        {
            try
            {
                 return data.GrabarDB(Info, ref IdPedidoXPre); 
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }

        }

        public List<pre_PedidoXPresupuesto_Info> ObtenerList(int IdEmpresa)
        {
            try
            {
                  return data.ObtenerList(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }

        }

        public Boolean ModificarDB(pre_PedidoXPresupuesto_Info info)
        {
            try
            {
              return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }

        }

        public Boolean AnularDB(pre_PedidoXPresupuesto_Info info)
        {
            try
            {
               return data.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }

        }

        public pre_rpt_PedidoXPresupuesto_Info ObtenerListRpt(int IdEmpresa, decimal IdPedidoXPre)
        {
            try
            {
                return data.ObtenerListRpt(IdEmpresa, IdPedidoXPre);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListRpt", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }

        }

        public pre_PedidoXPresupuesto_Bus(){
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pre_PedidoXPresupuesto_Bus", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_Bus) };

            }
        }
    }
}
