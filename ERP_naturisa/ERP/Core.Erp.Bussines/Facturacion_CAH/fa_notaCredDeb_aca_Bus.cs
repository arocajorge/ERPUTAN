using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Facturacion_CAH;
using Core.Erp.Info.Factuarcion_CAH;

namespace Core.Erp.Business.Facturacion_CAH
{
    public class fa_notaCredDeb_aca_Bus
    {
        fa_notaCredDeb_aca_Data da = new fa_notaCredDeb_aca_Data();
        public bool GrabarDB(fa_notaCredDeb_aca_Info info, ref string mensaje)
        {
            try
            {

                return da.Grabar(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_aca_Bus) };
            }

        }

        public bool ActualizarDB(fa_notaCredDeb_aca_Info info, ref string mensaje)
        {
            try
            {

                return da.Actualizar(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_aca_Bus) };
            }

        }

        public List<fa_notaCredDeb_aca_Info> Get_list(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNotaCredDeb, ref string mensaje)
        {
            try
            {

                return da.Get_list(IdEmpresa, IdSucursal, IdBodega,IdNotaCredDeb, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_aca_Bus) };
            }
        }

        public fa_notaCredDeb_aca_Info Get_Info(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNotaCredDeb)
        {
            try
            {

                return da.Get_Info(IdEmpresa, IdSucursal, IdBodega, IdNotaCredDeb);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(fa_notaCredDeb_aca_Bus) };
            }
        }
    }
}
