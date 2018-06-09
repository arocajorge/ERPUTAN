using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Inventario
{
    public class in_transferencia_x_fa_guia_remision_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_transferencia_x_fa_guia_remision_data Data = new in_transferencia_x_fa_guia_remision_data();
        public Boolean GuardarDB(in_transferencia_x_fa_guia_remision_Info Info)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_transferencia_x_fa_guia_remision_Bus) };

            }
            return Data.GuardarDB(Info);
        }
        public in_transferencia_x_fa_guia_remision_Info Get_Info_transferencia_x_fa_guia_remision(int IdEmpresa, int IdSucursalOrigen, int IdBodegaOrigen, decimal IdTransferencia)
        {
            try
            {
                return Data.Get_Info_transferencia_x_fa_guia_remision(IdEmpresa, IdSucursalOrigen, IdBodegaOrigen, IdTransferencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(in_transferencia_x_fa_guia_remision_Bus) };

            }

        }
        public Boolean VerificacionAsociacionGuiaVStransferencia(int IdEmpresa_Guia, int IdSucursal_Guia, int IdBodega_Guia, decimal IdGuiaRemision)
        {
            try
            {
                return Data.VerificacionAsociacionGuiaVStransferencia(IdEmpresa_Guia, IdSucursal_Guia, IdBodega_Guia, IdGuiaRemision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificacionAsociacionGuiaVStransferencia", ex.Message), ex) { EntityType = typeof(in_transferencia_x_fa_guia_remision_Bus) };

            }
           
        }
    }
}
