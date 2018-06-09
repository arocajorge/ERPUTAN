using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Inventario
{
  public  class vwin_movi_inve_x_cbteCble_Datos_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        vwin_movi_inve_x_cbteCble_Datos_Data odata = new vwin_movi_inve_x_cbteCble_Datos_Data();

        public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos
            (int IdEmpresa, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr, string Tipo_Contabilizado)
        {
            try
            {
                return odata.Get_List_vwin_movi_inve_x_cbteCble_Datos(IdEmpresa, FechaIni, FechaFin, Tipo_ing_egr, Tipo_Contabilizado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarInfo", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

            }
        }

        public List<vwin_movi_inve_x_cbteCble_Datos_Info> Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,
            string Tipo_ing_egr)
        {
            {
                try
                {
                    return odata.Get_List_vwin_movi_inve_x_cbteCble_Datos_No_Contabilizados(IdEmpresa, FechaIni, FechaFin, Tipo_ing_egr);
                }
                catch (Exception ex)
                {
                    Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarInfo", ex.Message), ex) { EntityType = typeof(in_Ing_Egr_Inven_Bus) };

                }
            }
        }
    }
}
