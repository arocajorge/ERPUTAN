using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Nomina_Tipoliqui_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Nomina_Tipoliqui_Data data = new ro_Nomina_Tipoliqui_Data();
        public ro_Nomina_Tipoliqui_Info Get_Info_Nomina_Tipoliqui(int idempresa, int IdNomina_Tipo, int IdNomina_TipoLiqui)
        {
            try
            {

                return data.Get_Info_Nomina_Tipoliqui(idempresa, IdNomina_Tipo,IdNomina_TipoLiqui);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Nomina_Tipoliqui", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }

        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(int idempresa, int IdNomina_Tipo)
        {
            try
            {

                return data.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(idempresa, IdNomina_Tipo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Nomina_Tipoliqui_x_Nomina_Tipo", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }
        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui(int idempresa, int IdNomina)
        {
            try
            {
                return data.Get_List_Nomina_Tipoliqui(idempresa, IdNomina);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nomina_tipo_liqui_orden", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }


        public List<ro_Nomina_Tipoliqui_Info> Get_List_Nomina_Tipoliqui(int idempresa)
        {
            try
            {
                return data.Get_List_Nomina_Tipoliqui(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_nomina_tipo_liqui_orden", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }
        public Boolean GrabarDB(ro_Nomina_Tipoliqui_Info Info, ref int idtipo, ref  string msg)
        {
            try
            {
                return data.GrabarDB(Info, ref idtipo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }


        }
        public Boolean AnularDB(ro_Nomina_Tipoliqui_Info Info, ref  string msg)
        {
            try
            {
                return data.AnularDB(Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }
        public Boolean ModificaDB(ro_Nomina_Tipoliqui_Info Info, ref  string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                valorRetornar= data.ModificaDB(Info, ref msg);
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificaDB", ex.Message), ex) { EntityType = typeof(ro_Nomina_Tipoliqui_Bus) };
            }

        }
    

    }
}
