using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;


namespace Core.Erp.Business.ActivoFijo
{
    public class Af_Depreciacion_Det_Bus
    {
        Af_Depreciacion_Det_Data dataAF = new Af_Depreciacion_Det_Data();

        public Boolean GuardarDB(List<Af_Depreciacion_Det_Info> lstInfo, decimal IdDepreciacion, int IdTipoDepreciacion, ref string msjError)
        {
            try
            {
                return dataAF.GuardarDB(lstInfo, IdDepreciacion, IdTipoDepreciacion, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
        }

        public List<Af_Depreciacion_Det_Info> Get_List_Depreciacion_Det(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {

                return dataAF.Get_List_Depreciacion_Det(IdEmpresa, IdDepreciacion, IdTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Depreciacion_Det", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
            
        }

        public List<vwAf_ActivoFijo_Info> Get_List_DepreciacionDetalle(int IdEmpresa, decimal IdDepreciacion, int IdTipoDepreciacion)
        {
            try
            {

                return dataAF.Get_List_Depreciacion_Detalle(IdEmpresa, IdDepreciacion, IdTipoDepreciacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_DepreciacionDetalle", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
        }

        public Boolean Guardar_HistoricoDB(List<Af_Depreciacion_Det_Info> lstInfo, int IdHisDepreciacion, decimal IdDepreciacion, int IdTipoDepreciacion, ref string msjError)
        {
            try
            {

                return dataAF.Guardar_HistoricoDB(lstInfo, IdHisDepreciacion, IdDepreciacion,IdTipoDepreciacion, ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar_HistoricoDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
        }

        public Boolean EliminarDB(List<Af_Depreciacion_Det_Info> lstInfo, ref string msjError)
        {
            try
            {

                return dataAF.EliminarDB(lstInfo,  ref msjError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
        }

        public double Get_DepreAcum_x_Activo(int IdEmpresa, int IdActivoFijo)
        {
            try
            {
                return dataAF.Get_DepreAcum_x_Activo(IdEmpresa, IdActivoFijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_DepreAcum_x_Activo", ex.Message), ex) { EntityType = typeof(Af_Depreciacion_Det_Bus) };
            }
        }
        
        public Af_Depreciacion_Det_Bus()
        {

        }
    }
}
