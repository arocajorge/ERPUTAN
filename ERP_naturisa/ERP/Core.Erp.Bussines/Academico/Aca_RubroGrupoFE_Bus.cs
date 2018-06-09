using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.Academico
{
    public class Aca_RubroGrupoFE_Bus
    {
        Aca_RubroGrupoFE_Data oData = new Aca_RubroGrupoFE_Data();
        tb_sis_Log_Error_Vzen_Bus mensaje = new tb_sis_Log_Error_Vzen_Bus();

        public List<Aca_RubroGrupoFE_Info> Get_List_Rubro_Grupo_FE()
        {
            //List<Aca_RubroGrupoFE_Info> lista = new List<Aca_RubroGrupoFE_Info>();

            try
            {
                return oData.Get_List_Rubro_Grupo_FE();

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_RubroGrupoFE_Bus) };
            }
        }

        public Boolean Get_List_Rubro_Grupo_FE_Existe(Aca_RubroGrupoFE_Info Info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = oData.Get_List_Rubro_Grupo_FE_Existe(Info, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_RubroGrupoFE_Bus) };
            }
        }

        public Boolean Eliminar(Aca_RubroGrupoFE_Info Info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = oData.AnularDB(Info,ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(Aca_RubroGrupoFE_Bus) };
            }
        }

        public Boolean Actualizar(Aca_RubroGrupoFE_Info Info, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = oData.ActualizarDB(Info, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_RubroGrupoFE_Bus) };
            }
        }

        public Boolean Grabar(Aca_RubroGrupoFE_Info Info, ref int IdRubroGrupo, ref string mensaje)
        {
            bool resultado = false;
            try
            {
                resultado = oData.GrabarDB(Info, ref IdRubroGrupo, ref mensaje);
                return resultado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Rubro", ex.Message), ex) { EntityType = typeof(Aca_RubroGrupoFE_Bus) };
            }
        }
    }
}
