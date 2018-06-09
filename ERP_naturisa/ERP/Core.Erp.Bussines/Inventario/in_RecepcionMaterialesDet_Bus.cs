using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Inventario
{
    public class in_RecepcionMaterialesDet_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog=new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        in_RecepcionMaterialesDet_Data data = new in_RecepcionMaterialesDet_Data();

        public List<in_RecepcionMaterialesDet_Info> ObtenerListaRecepcionDet(int idempresa, int idsucursal, decimal IdRecepcionMaterial)
        {
            try
            {
                return data.Get_List_RecepcionMaterialesDet(idempresa, idsucursal, IdRecepcionMaterial);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaRecepcionDet", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesDet_Bus) };

            }
        }

        public List<in_RecepcionMaterialesDet_Info> ObtenerLstRecepcionDet_x_OC(int idempresa, int idsucursal, decimal IdOC)
        {
            try
            {
                return data.Get_List_RecepcionMaterialesDet_x_OC(idempresa, idsucursal, IdOC);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLstRecepcionDet_x_OC", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesDet_Bus) };

            }
        }
        public Boolean grabarDB(List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, int idempresa, decimal IdRecepcionMaterial, ref string msgd)
        {
            try
            {
                return data.GrabarDB(lmDetalleInfo, idempresa, IdRecepcionMaterial, ref msgd);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "grabarDB", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesDet_Bus) };

            }
        }

        public Boolean eliminarregistrotabla(List<in_RecepcionMaterialesDet_Info> lmDetalleInfo, int idempresa, decimal IdRecepcionMaterial, ref string msg)
        {
            try
            {
                return data.EliminarDB(lmDetalleInfo, idempresa, IdRecepcionMaterial, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarregistrotabla", ex.Message), ex) { EntityType = typeof(in_RecepcionMaterialesDet_Bus) };

            }
        }

        public in_RecepcionMaterialesDet_Bus() { }
    }
}
