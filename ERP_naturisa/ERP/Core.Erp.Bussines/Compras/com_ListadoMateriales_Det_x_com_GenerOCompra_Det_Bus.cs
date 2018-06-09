using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
    
        com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Data Data = new com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Data();

        public Boolean GrabarDB(com_ListadoMateriales_Det_Info GO, com_ListadoMateriales_Det_Info LM, ref string msg)
        {
            try
            {
                return Data.GrabarDB(GO, LM, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Bus", ex.Message), ex) { EntityType = typeof(com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Bus) };
            }
        }

        public com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Info Get_Info_ListadoMateriales_Det_x_com_GenerOCompra_Det(com_ListadoMateriales_Det_Info GO, ref string msg)
        {
            try
            {
                return Data.Get_Info_ListadoMateriales_Det_x_com_GenerOCompra_Det(GO, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_ListadoMateriales_Det_x_com_GenerOCompra_Det", ex.Message), ex) { EntityType = typeof(com_ListadoMateriales_Det_x_com_GenerOCompra_Det_Bus) };
            }
        }
    }
}
