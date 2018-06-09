using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Inventario
{
    public class vwIn_VistaParaContabilizarInventario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        vwIn_VistaParaContabilizarInventario_Data data = new vwIn_VistaParaContabilizarInventario_Data();

        public List<vwIn_VistaParaContabilizarInventario_Info> Get_List_VistaParaContabilizarInventario
            (int IdEmpresa, List<int> Bodegas, List<int> Sucursales, string tipoMovi, List<int> TiposMovimientosInvenario, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_VistaParaContabilizarInventario(IdEmpresa, Bodegas, Sucursales, tipoMovi, TiposMovimientosInvenario, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar", ex.Message), ex) { EntityType = typeof(vwIn_VistaParaContabilizarInventario_Bus) };

            }

        }


        public List<vwIn_VistaParaContabilizarInventario_Info> Get_List_VistaParaContabilizarInventario
        (int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo ,decimal IdNumMovi )
        {
            try
            {
                return data.Get_List_VistaParaContabilizarInventario(IdEmpresa, IdSucursal, IdBodega, IdMovi_inven_tipo, IdNumMovi);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consultar_x_MoviInve", ex.Message), ex) { EntityType = typeof(vwIn_VistaParaContabilizarInventario_Bus) };

            }
            
        }



    }
}
