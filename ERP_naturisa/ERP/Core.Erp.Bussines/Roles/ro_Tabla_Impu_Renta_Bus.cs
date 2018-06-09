using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;

//Tabla Impuestos a la renta
//Derek Mejía Soria
//ultima modificacion : 08/01/2014
namespace Core.Erp.Business.Roles
{
    public class ro_Tabla_Impu_Renta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Tabla_Impu_Renta_Data data = new ro_Tabla_Impu_Renta_Data();

        public List<ro_tabla_Impu_Renta_Info> ConsultaTablaImpu()
        {
            try
            {
               return data.Get_List_tabla_Impu_Renta();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaTablaImpu", ex.Message), ex) { EntityType = typeof(ro_Tabla_Impu_Renta_Bus) };
            }

        }

        public List<ro_tabla_Impu_Renta_Info> ConsultaTablaImpuAnio(int anio)
        {
            try
            {
               return data.Get_List_tabla_Impu_Renta(anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaTablaImpuAnio", ex.Message), ex) { EntityType = typeof(ro_Tabla_Impu_Renta_Bus) };
            }

        }

        public Boolean GrabarTablaImpu(ro_tabla_Impu_Renta_Info info)
        {
            try
            {
               return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarTablaImpu", ex.Message), ex) { EntityType = typeof(ro_Tabla_Impu_Renta_Bus) };
            }

        }

        public int GETSECUENCIA()
        {
            try
            {
                return data.GetSecuencia();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GETSECUENCIA", ex.Message), ex) { EntityType = typeof(ro_Tabla_Impu_Renta_Bus) };
            }

        }

        public ro_tabla_Impu_Renta_Info GetInfoFraccionBasica(int anio, ref string msg)
      {
          try
            {
                return data.Get_Info_FraccionBasica(anio, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoFraccionBasica", ex.Message), ex) { EntityType = typeof(ro_Tabla_Impu_Renta_Bus) };
            }

        }





    }
}
