using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles
{
  public  class ro_tipo_gastos_personales_tabla_valores_x_anio_Bus
    {
      ro_tipo_gastos_personales_tabla_valores_x_anio_Data Data = new ro_tipo_gastos_personales_tabla_valores_x_anio_Data();
      string msg = "";

        public Boolean GuardarDB(List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> List_Info, ref string msg)
        {
            try
            {
                return Data.GuardarDB(List_Info, ref msg);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_tipo_gastos_personales_tabla_valores_x_anio_Bus) };
            }


           
        }


        public bool SiExiste(int Anio)
        {
            try
            {
                return Data.SiExiste(Anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "SiExiste", ex.Message), ex) { EntityType = typeof(ro_tipo_gastos_personales_tabla_valores_x_anio_Bus) };
            }

        }
        public List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> ConsultaGeneral(int Anio)
        {
            try
            {
                return Data.Get_List_tipo_gastos_personales_tabla_valores_x_anio(Anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_tipo_gastos_personales_tabla_valores_x_anio_Bus) };
            }
        }

        public Boolean ModificarDB(List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> List_Info, ref string msg)
        {
            try
            {
                return Data.ModificarDB(List_Info, ref msg);
                

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_tipo_gastos_personales_tabla_valores_x_anio_Bus) };
            }


        }


        public Boolean Anular(List<ro_tipo_gastos_personales_tabla_valores_x_anio_Info> List_Info, ref string msg)
        {
            try
            {
                return Data.Anular(List_Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(ro_tipo_gastos_personales_tabla_valores_x_anio_Bus) };
            }
        }
    }
}
