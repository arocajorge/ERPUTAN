using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Inventario
{
   public class vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Data data = new vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Data();


       public List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles
       (int IdEmpresa, int IdSucursal , int IdBodega,  string tipoMovi, int IdMovi_inven_tipo, DateTime FechaIni, DateTime FechaFin)
       {
            try
            {
                return data.Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles(IdEmpresa, IdSucursal, IdBodega, tipoMovi, IdMovi_inven_tipo, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus) };

            }

        }


        public List<vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Info> Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles
        (int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
        {
            try
            {
                return data.Get_List_movi_inve_detalle_x_Contabilizar_x_ctacbles(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar_x_MoviInve", ex.Message), ex) { EntityType = typeof(vwin_movi_inve_detalle_x_Contabilizar_x_ctacbles_Bus) };

            }

        }


    }
}
