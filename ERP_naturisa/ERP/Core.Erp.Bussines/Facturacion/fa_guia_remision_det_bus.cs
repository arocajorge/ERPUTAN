using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_guia_remision_det_bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        fa_guia_remision_det_Data oData = new fa_guia_remision_det_Data();

        public List<fa_guia_remision_det_Info> Get_List_guia_remision_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdGuiaRemision)
        {
            try
            {
                return oData.Get_List_guia_remision_det(IdEmpresa, IdSucursal, IdBodega, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_bus) };
            }

        }

        public Boolean GuardarDB(List<fa_guia_remision_det_Info> listDetalle_Guia_Info)
        {
            try
            {
                return oData.GuardarDB(listDetalle_Guia_Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_bus) };
            }
        }

        public Boolean ModificarDB(List<fa_guia_remision_det_Info> listDetalle_Guia_Info)
        {
            try
            {
                return oData.ModificarDB(listDetalle_Guia_Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_bus) };
            }
        }
        public List<fa_guia_remision_det_Info> Get_List_guia_remision_det(int IdEmpresa, int IdSucursal, int IdGuia)
        {
            try
            {
                 return oData.Get_List_guia_remision_det(IdEmpresa,IdSucursal,IdGuia);
            }
            catch (Exception ex)
            {
                
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(fa_guia_remision_det_bus) };
           
            }
        }
    
    }
}
