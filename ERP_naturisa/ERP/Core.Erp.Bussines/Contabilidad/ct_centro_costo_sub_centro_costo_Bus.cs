using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_centro_costo_sub_centro_costo_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_centro_costo_sub_centro_costo_Data data = new ct_centro_costo_sub_centro_costo_Data();


        public List<ct_centro_costo_sub_centro_costo_Info> Get_list_centro_costo_sub_centro_costo(int IdEmpresa) 
        {
            try
            {
                  return data.Get_list_centro_costo_sub_centro_costo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_centro_costo_sub_centro_costo", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }
 
        }

        public List<ct_centro_costo_sub_centro_costo_Info> Get_list_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto) 
        {
            try
            {
               return data.Get_list_centro_costo_sub_centro_costo(IdEmpresa, IdCentroCosto);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_centro_costo_sub_centro_costo", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }

        }

        public ct_centro_costo_sub_centro_costo_Info Get_Info_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto, string IdCentroCosto_sub_centro_costo)
        {
            try
            {
                return data.Get_Info_centro_costo_sub_centro_costo( IdEmpresa,  IdCentroCosto, IdCentroCosto_sub_centro_costo);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_centro_costo_sub_centro_costo", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }
        }

        public ct_centro_costo_sub_centro_costo_Info Get_Info_centro_costo_sub_centro_costo(int IdEmpresa, string IdCentroCosto_sub_centro_costo)
        {
            try
            {
                return data.Get_Info_centro_costo_sub_centro_costo(IdEmpresa, IdCentroCosto_sub_centro_costo);

            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_centro_costo_sub_centro_costo", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_centro_costo_sub_centro_costo_Info info)
        {
            try
            {
                return data.GrabarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }

        }

        public Boolean ModificarDB(ct_centro_costo_sub_centro_costo_Info info)
        {

            try
            {
                return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }

        }

        public Boolean Mover_Subcentro_costo(ct_centro_costo_sub_centro_costo_Info info)
        {

            try
            {
                return data.Mover_Subcentro_costo(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Mover_Subcentro_costo", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }

        }

        public Boolean AnularDB(ct_centro_costo_sub_centro_costo_Info _Info)
        {

            try
            {
                return data.AnularDB(_Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }

        }


        public String GetIdSubCentroCosto(int idEmpresa)
        {
            try
            {
                return data.GetIdSubCentroCosto(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetIdSubCentroCosto", ex.Message), ex) { EntityType = typeof(ct_centro_costo_sub_centro_costo_Bus) };
            }
        }

        

    }
}
