using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.ActivoFijo;
using Core.Erp.Info.ActivoFijo;

namespace Core.Erp.Business.ActivoFijo
{
    public class Af_CambioUbicacion_Activo_Bus
    {
        Af_CambioUbicacion_Activo_Data dataCambio = new Af_CambioUbicacion_Activo_Data();
        Af_Activo_fijo_Data dataActivo = new Af_Activo_fijo_Data();

        public Boolean GuardarDB(Af_CambioUbicacion_Activo_Info Info , ref int IdCambioUbicacion, ref string msjError)
        {
            try
            {
                if (dataCambio.GuardarDB(Info, ref IdCambioUbicacion, ref  msjError))
                    return dataActivo.ModificarUbicacion(Info, ref msjError);
                else
                    return false;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarData", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
            }
        }

        public Af_CambioUbicacion_Activo_Info Get_Info_CambioUbicacion(int IdEmpresa, int IdCambioUbicacion)
        {
            try
            {
                return dataCambio.Get_Info_CambioUbicacion(IdEmpresa, IdCambioUbicacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_CambioUbicacion", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
            }
        }

        public List<vwAf_CambioUbicacion_Info> Get_List_CambioUbicacion(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try 
	        {
                return dataCambio.Get_List_CambioUbicacion(IdEmpresa, FechaIni, FechaFin);
	        }
	        catch (Exception ex)
	        {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_ListaCambioUbicacion", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
	        }
        }
        public List<vwAf_CambioUbicacion_Info> Get_List_CambioUbicacion(int IdEmpresa, int IdActivofijo)
        {
            try
            {
                return dataCambio.Get_List_CambioUbicacion(IdEmpresa,IdActivofijo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_ListaCambioUbicacion", ex.Message), ex) { EntityType = typeof(Af_CambioUbicacion_Activo_Bus) };
            }
        }

        public Af_CambioUbicacion_Activo_Bus()
        {

        }
    }
}
