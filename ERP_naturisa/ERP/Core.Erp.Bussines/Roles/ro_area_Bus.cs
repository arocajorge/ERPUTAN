using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_area_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_area_Data odata = new ro_area_Data();

        public Boolean GuardarDB(ref ro_area_Info Info)
        {
            try
            {
                 return odata.GuardarDB(ref  Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };

            }
            
        }


        public List<ro_area_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_area(IdEmpresa);
            }
            catch (Exception ex )
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };

            }
            
        }
        public ro_area_Info ObtenerObjeto(int IdEmpresa, int IdDivision, int IdArea)
        {
            try
            {
                return odata.Get_Info_area(IdEmpresa, IdDivision, IdArea);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };

            }
            
        }
        public Boolean ModificarDB(ro_area_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };

            }
            
        }
        public Boolean AnularDB(ro_area_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex )
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };

            }
            
        }

        //Derek 12/12/2013
        public List<ro_area_Info> ConsultaPorDivision(int IdEmpresa, int IdDivision)
        {
            try
            {
               return odata.Get_List_area(IdEmpresa,IdDivision);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaPorDivision", ex.Message), ex) { EntityType = typeof(ro_area_Bus) };


            }

        }
        //
    
    }
}
