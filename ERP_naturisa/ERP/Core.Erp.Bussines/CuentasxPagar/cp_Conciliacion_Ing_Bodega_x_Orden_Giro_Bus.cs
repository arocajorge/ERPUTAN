using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;

namespace Core.Erp.Business.CuentasxPagar
{
    public class cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus
    {
        cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Data dataConci = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Data();
        cp_Aprobacion_Ing_Bod_x_OC_Bus Bus_Aprob = new cp_Aprobacion_Ing_Bod_x_OC_Bus();

        public Boolean GuardarDB(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info, ref decimal IdConciliacion, ref decimal IdIdAprobacion, ref string msjError)
        {
            try
            {
                if (Bus_Aprob.GuardarDB(Info.cp_Aprobacion_Ing_Bod_x_OC, ref  IdIdAprobacion, ref msjError))
                {
                    Info.IdEmpresa_Apro_Ing = Info.cp_Aprobacion_Ing_Bod_x_OC.IdEmpresa;
                    Info.IdAprobacion_Apro_Ing = IdIdAprobacion;
                    return dataConci.GuardarDB(Info, ref IdConciliacion, ref msjError);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public Boolean AnularDB(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info, ref string msjError)
        {
            try
            {
                return dataConci.AnularDB(Info, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Get_Info_Conciliacion_Ing(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return dataConci.Get_Info_Conciliacion_Ing(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Conciliacion_Ing", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info> Get_List_Conciliacion(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return dataConci.Get_List_Conciliacion(IdEmpresa, FechaIni, FechaFin );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> Get_List_OG_Pendiente_Conciliar(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                return dataConci.Get_List_OG_Pendiente_Conciliar( IdEmpresa,  IdProveedor);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OG_Pendiente_Conciliar", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public List<vwcp_Orden_Giro_Pendiente_Conciliar_Info> Get_List_OG_Facturas_Conciliadas(int IdEmpresa, decimal IdConciliacion)
        {
            try
            {
                return dataConci.Get_List_OG_Facturas_Conciliadas(IdEmpresa, IdConciliacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_OG_Facturas_Conciliadas", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }
        }


        public List<cp_Aprobacion_Ing_Bod_x_OC_det_Info> Get_List_Ing_Bod_x_OC_Conciliadas(int IdEmpresa, decimal IdConcilacion)
        {
            try
            {
                return dataConci.Get_List_Ing_Bod_x_OC_Conciliadas(IdEmpresa, IdConcilacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Bod_x_OC_Conciliadas", ex.Message), ex) { EntityType = typeof(cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus) };
            }

        }



        public cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus()
        {

        }
    }
}
