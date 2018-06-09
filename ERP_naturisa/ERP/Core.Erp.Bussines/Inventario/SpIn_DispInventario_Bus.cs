using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class SpIn_DispInventario_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        SpIn_DispInventario_Data data = new SpIn_DispInventario_Data();
        public List<SpIn_DispInventario_Info> Get_List_In_DispInventario(Nullable<DateTime> Fecha, Nullable<int> IdSucursal, Nullable<int> IdBodega, int IdEmpresa, string Categorias, string IdUsuario)
        {
            try
            {
            return data.Get_List_In_DispInventario(Fecha, IdSucursal, IdBodega, IdEmpresa, Categorias, IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(SpIn_DispInventario_Bus) };

            }
          
        }
    }
}
