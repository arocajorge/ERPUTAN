using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
   public class fa_factura_aca_Bus
    {
       fa_factura_aca_Data da = new fa_factura_aca_Data();
        public bool GrabarDB(fa_factura_aca_Info info, ref string mensaje)
        {
            try
            {
               
                return  da.Grabar(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_factura_aca_Bus) };
            }

        }

        public bool ActualizarDB(fa_factura_aca_Info info, ref string mensaje)
        {
            try
            {
                
                return da.Actualizar(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(fa_factura_aca_Bus) };
            }

        }

        public List<fa_factura_aca_Info> Get_list(int IdInstitucion, int InAnio_Lectivo, int idPeriodo, ref string mensaje)
        {
            try
            {

                return da.Get_list(IdInstitucion, InAnio_Lectivo, idPeriodo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list", ex.Message), ex) { EntityType = typeof(fa_factura_aca_Bus) };
            }
        }

        public fa_factura_aca_Info Get_Info(decimal Idfactura, ref string mensaje)
        {
            try
            {

                return da.Get_Info(Idfactura, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info", ex.Message), ex) { EntityType = typeof(fa_factura_aca_Bus) };
            }
        }
    }
}
