using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras
{
    public class com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       
        com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Data data = new com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Data();

        public Boolean GrabarDB(List<com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info> Lst, ref string msg)
        {
            try
            {
                return data.GrabarDB(Lst, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus) };
            }
        
        }
        public Boolean GrabarxitemDB(com_GenerOCompraDet_Info GO, com_ordencompra_local_det_Info OC, ref string msg)
        {
            try
            {
                return data.GrabarxitemDB(GO, OC, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarxitemDB", ex.Message), ex) { EntityType = typeof(com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus) };
            }

        }

        public com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Info Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider(com_ordencompra_local_det_Info OC, ref string msg)
        {
            try
            {
                return data.Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider(OC, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider", ex.Message), ex) { EntityType = typeof(com_GenerOCompra_Det_x_com_ordencompra_local_det_CusCider_Bus) };
            }
        
        }

    }
}
