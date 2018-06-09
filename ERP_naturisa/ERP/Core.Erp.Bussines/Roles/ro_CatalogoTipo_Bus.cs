using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_CatalogoTipo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje="";
        ro_CatalogoTipo_Data odata = new ro_CatalogoTipo_Data();
        public Boolean GuardarDB(ref ro_CatalogoTipo_Info Info)
        {
            try
            {
               return odata.GuardarDB(ref Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_CatalogoTipo_Bus) };

            }

        }
        public List<ro_CatalogoTipo_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_CatalogoTipo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_CatalogoTipo_Bus) };

            }

        }
        public Boolean Modificar(ro_CatalogoTipo_Info Info, string msj)
        {
            try
            {
                return odata.ModificarDB(Info, msj);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(ro_CatalogoTipo_Bus) };

            }

        }
        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                return odata.ValidarCodigoExiste(Cod);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(ro_CatalogoTipo_Bus) };

            }

        }
    }
}
