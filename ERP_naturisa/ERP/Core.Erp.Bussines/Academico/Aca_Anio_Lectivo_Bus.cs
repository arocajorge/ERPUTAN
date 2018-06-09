using Core.Erp.Data.Academico;
using Core.Erp.Info.Academico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Academico
{
    public class Aca_Anio_Lectivo_Bus
    {
        Aca_Anio_Lectivo_Data da;

        public List<Aca_Anio_Lectivo_Info> Get_List_Anio_Lectivo(int IdInstitucion)
        {
            List<Aca_Anio_Lectivo_Info> lstAnioLec = new List<Aca_Anio_Lectivo_Info>();
            try
            {
                da = new Aca_Anio_Lectivo_Data();
                lstAnioLec = da.Get_List_Anio_Lectivo(IdInstitucion);
                return lstAnioLec;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Anio_Lectivo", ex.Message), ex) { EntityType = typeof(Aca_Anio_Lectivo_Bus) };
            }

        }
        //public string Get_IdAnio_Lectivo_Activo(int IdInstitucion)
        public int Get_IdAnio_Lectivo_Activo(int IdInstitucion)
        {
            //string IdAnio_Lectivo_Activo = "";
            int IdAnio_Lectivo_Activo = 0;

            try
            {
                da = new Aca_Anio_Lectivo_Data();
                IdAnio_Lectivo_Activo = da.Get_IdAnio_Lectivo_Activo(IdInstitucion);
                return IdAnio_Lectivo_Activo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Anio_Lectivo", ex.Message), ex) { EntityType = typeof(Aca_Anio_Lectivo_Bus) };
            }

        }


        public bool GrabarDB(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                da = new Aca_Anio_Lectivo_Data();
                resultado = da.Grabar(info, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(Aca_Anio_Lectivo_Bus) };
            }

        }

        public bool ActualizarDB(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                da = new Aca_Anio_Lectivo_Data();
                resultado = da.Actualizar(info, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarDB", ex.Message), ex) { EntityType = typeof(Aca_Anio_Lectivo_Bus) };
            }

        }

        public bool EliminarDB(Aca_Anio_Lectivo_Info info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                da = new Aca_Anio_Lectivo_Data();
                resultado = da.AnularDB(info, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(Aca_Anio_Lectivo_Bus) };
            }

        }
    }
}
