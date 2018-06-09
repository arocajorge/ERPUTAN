using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class vwIn_Movi_Inven_x_Ing_x_OC_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        vwIn_Movi_Inven_x_Ing_x_OC_Data OData = new vwIn_Movi_Inven_x_Ing_x_OC_Data();

        public List<vwIn_Movi_Inven_x_Ing_x_OC_Info> Get_List_Movi_Inven_x_Ing_x_OC(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {

                return OData.Get_List_Movi_Inven_x_Ing_x_OC(IdEmpresa, IdSucursal, IdBodega, FechaIni, FechaFin);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Movi_Inven_x_Ing_x_OC", ex.Message), ex) { EntityType = typeof(vwIn_Movi_Inven_x_Ing_x_OC_Bus) };



            }

            
        }

        public vwIn_Movi_Inven_x_Ing_x_OC_Bus()
        {

        }
    }
}
