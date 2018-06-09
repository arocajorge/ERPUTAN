using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.Inventario;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_moviInventario_x_GestionProdLaminados_Cus_Talme_Data oData = new in_moviInventario_x_GestionProdLaminados_Cus_Talme_Data();
        public Boolean GuardarDB(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info)
        {
            try
            {
             return oData.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus) };

            }

        }
        public in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Get_Info_moviInventario_x_GestionProdLaminados_Cus_Talme(int IdEmpresa, Decimal IdGestion)
        {
            try
            {
                return oData.Get_Info_moviInventario_x_GestionProdLaminados_Cus_Talme(IdEmpresa, IdGestion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarObjeto", ex.Message), ex) { EntityType = typeof(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus) };

            }

        }
        public Boolean Eliminar(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Info Info)
        {
            try
            {
                return oData.Eliminar(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar", ex.Message), ex) { EntityType = typeof(in_moviInventario_x_GestionProdLaminados_Cus_Talme_Bus) };

            }

        }
    }
}
