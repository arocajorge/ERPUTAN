using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Business.Inventario
{
    public class in_UnidadMedida_Equiv_conversion_Bus
    {

        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        in_UnidadMedida_Equiv_conversion_Data OData = new in_UnidadMedida_Equiv_conversion_Data();


        public List<in_UnidadMedida_Equiv_conversion_Info> Get_List_in_UnidadMedida_Equiv_conversion(string IdUnidadMedida)
        {
            try
            {

                List<in_UnidadMedida_Equiv_conversion_Info> lM = new List<in_UnidadMedida_Equiv_conversion_Info>();

                lM = OData.Get_List_in_UnidadMedida_Equiv_conversion(IdUnidadMedida);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListUnidadMedida_Equiv_conversion", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };

            }

        }

        public Boolean GrabarDB(in_UnidadMedida_Equiv_conversion_Info prI, ref string mensaje)
        {
            try
            {

                return OData.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };

            }
        }

        public Boolean ModificarDB(in_UnidadMedida_Equiv_conversion_Info prI, ref string mensaje)
        {
            try
            {
                return OData.ModificarDB(prI, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };

            }
        }

        public Boolean GuardarListDB(List<in_UnidadMedida_Equiv_conversion_Info> Lista,ref string mensaje)
        {
            try
            {
                return OData.GuardarListDB(Lista, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarListDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };

            }
        }

        public Boolean EliminarDB(string IdUnidadMedida,ref string mensaje)
        {
            try
            {
              return OData.EliminarDB(IdUnidadMedida, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };
              
            }
        }

        public in_UnidadMedida_Equiv_conversion_Info Get_Info_in_UnidadMedida_Equiv_conversion(string IdUnidadMedida, string IdUnidadMedida_equiva)
        {
            try
            {
               return OData.Get_Info_in_UnidadMedida_Equiv_conversion(IdUnidadMedida, IdUnidadMedida_equiva);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Info_ValorConversion", ex.Message), ex) { EntityType = typeof(in_UnidadMedida_Equiv_conversion_Bus) };

            }
        }

        
        public in_UnidadMedida_Equiv_conversion_Bus()
        {

        }
    }
}
