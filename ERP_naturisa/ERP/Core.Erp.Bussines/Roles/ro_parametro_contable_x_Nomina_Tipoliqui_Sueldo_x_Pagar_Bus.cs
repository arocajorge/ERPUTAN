using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
  public  class ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Bus
    {
        string mensaje = "";
        ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Data data = new ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Data();
        public List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> Get_List(int IdEmpresa)
        {
            List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> lista = new List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info>();
            try
            {

                return data.Get_List(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerDatos", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };
            }
        }

        public Boolean Eliminar(int IdEmpresa)
        {
            try
            {
                return data.Eliminar(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerDatos", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };
            }
        }

        public Boolean Grabar(List<ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info> ListaGrabar)
        {
            try
            {
                return data.Grabar(ListaGrabar);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerDatos", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };

            }
        }


        public ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar_Info Get_Info(int IdEmpresa, int IdNomina, int IdNominaTipo)
        {
            try
            {

                return data.Get_Info(IdEmpresa,IdNomina,IdNominaTipo);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerDatos", ex.Message), ex) { EntityType = typeof(ro_Config_SueldoBasico_x_anio_Bus) };

            }
        }


    }
}
