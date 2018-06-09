using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Caja;
namespace Core.Erp.Business.CuentasxPagar
{
   public class cp_conciliacion_Caja_det_x_ValeCaja_Bus
    {

       cp_conciliacion_Caja_det_x_ValeCaja_Data odata = new cp_conciliacion_Caja_det_x_ValeCaja_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public Boolean GrabarDB(List<cp_conciliacion_Caja_det_x_ValeCaja_Info> lista, ref string mensaje)
        {
            try
            {
                return odata.GrabarDB(lista, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }


        }

        public Boolean GrabarDB(cp_conciliacion_Caja_det_x_ValeCaja_Info info, ref string mensaje)
        {

            try
            {
                return odata.GrabarDB(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }

        public List<caj_Caja_Movimiento_Info> Get_List_Conciliacion_Caja_Det_ValeCaja(int IdEmpresa, decimal IdConciliacion_caja)
        {

            try
            {
                return odata.Get_List_Conciliacion_Caja_Det_ValeCaja(IdEmpresa, IdConciliacion_caja);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Conciliacion_Caja_Det_ValeCaja", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }

        }

        public Boolean ModificarDB(cp_conciliacion_Caja_det_x_ValeCaja_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(cp_conciliacion_Caja_det_x_ValeCaja_Bus) };
            }
        }

    }
}
