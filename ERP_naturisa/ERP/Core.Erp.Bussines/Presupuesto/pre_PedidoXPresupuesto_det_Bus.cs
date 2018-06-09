using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;

//8-5-2013
namespace Core.Erp.Business.Presupuesto
{
    public class pre_PedidoXPresupuesto_det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        pre_PedidoXPresupuesto_det_Data data = new pre_PedidoXPresupuesto_det_Data();

        public Boolean GrabarDB(pre_PedidoXPresupuesto_det_Info Info)
        {
            try
            {
                return data.GrabarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }

        }

        public List<pre_PedidoXPresupuesto_det_Info> ObtenerList(int IdEmpresa, decimal IdPedidoXPre)
        {
            try
            {
              return data.ObtenerList(IdEmpresa, IdPedidoXPre);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerList", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }

        }

        public List<pre_PedidoXPresupuesto_det_Info> ObtenerListFiltro(int IdEmpresa, DateTime fechaIni, DateTime fechaFin, string CodAprobacion = "T")
        {
            try
            {
                return data.ObtenerListFiltro(IdEmpresa, fechaIni, fechaFin, CodAprobacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListFiltro", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }

        }

        public Boolean ModificarDBEstadoAprobacionLst(List<pre_PedidoXPresupuesto_det_Info> lst)
        {
            try
            {
             return data.ModificarDBEstadoAprobacionLst(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDBEstadoAprobacionLst", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }

        }

        public List<pre_PedidoXPresupuesto_det_Info> ObtenerListPedidoDet(int IdEmpresa, string CodAprobacion = "T",string join="N")
        {
            try
            {
                 return data.ObtenerListPedidoDet(IdEmpresa, CodAprobacion,join);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListPedidoDet", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }

        }

        public pre_PedidoXPresupuesto_det_Bus()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pre_PedidoXPresupuesto_det_Bus", ex.Message), ex) { EntityType = typeof(pre_PedidoXPresupuesto_det_Bus) };

            }
        }
    }
}
