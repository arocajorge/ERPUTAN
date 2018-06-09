using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Business.Inventario
{
    public class in_transferencia_x_in_Guia_x_traspaso_bodega_Bus
    {
        in_transferencia_x_in_Guia_x_traspaso_bodega_Data Data = new in_transferencia_x_in_Guia_x_traspaso_bodega_Data();

        public Boolean VerificacionGuia_x_transferencia(int IdEmpresa_Guia, decimal IdGuia)
        {
            try
            {
                return Data.VerificacionGuia_x_transferencia(IdEmpresa_Guia, IdGuia);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificacionGuia_x_transferencia", ex.Message), ex) { EntityType = typeof(in_transferencia_x_in_Guia_x_traspaso_bodega_Bus) };
            }

        }

        public Boolean EliminarDB(in_transferencia_Info InfoTrans)
        {
            try
            {
                return Data.EliminarDB(InfoTrans);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_transferencia_x_in_Guia_x_traspaso_bodega_Bus) };
            }
        }

        public Boolean GuardarDB(in_transferencia_x_in_Guia_x_traspaso_bodega_Info InfoGuia, ref string msjError)
        {
            try
            {
                return Data.GuardarDB(InfoGuia, ref msjError);                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(in_transferencia_x_in_Guia_x_traspaso_bodega_Bus) };

            }
        }

        public in_transferencia_x_in_Guia_x_traspaso_bodega_Bus()
        {

        }

    }
}
