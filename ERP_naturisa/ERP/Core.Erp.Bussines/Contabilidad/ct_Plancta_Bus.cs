using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_Plancta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();

        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Plancta_Info> lm = new List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {
                lm = data.Get_List_Plancta(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Plancta", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public List<ct_Plancta_Info> ProcesarDataTableCt_Plancta_Info(DataTable ds, int idempresa, ref string MensajeError)
        {
            try
            {

            ct_Plancta_Data data = new ct_Plancta_Data();
            return data.ProcesarDataTableCt_Plancta_Info(ds, idempresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTableCt_Plancta_Info", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }

        }
        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, string idctaini, string idctafin, ref string MensajeError)
        {
            List<ct_Plancta_Info> lm = new List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {
                lm = data.Get_List_Plancta(IdEmpresa, idctaini, idctafin, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_PlanCta", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public List<ct_Plancta_Info> Get_List_Plancta_x_ctas_Movimiento(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Plancta_Info> lm = new List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {

                ct_Parametro_Bus BusParam_conta = new ct_Parametro_Bus();
                ct_Parametro_Info InfoParam_conta = new ct_Parametro_Info();
                Boolean P_Se_Muestra_Todas_las_ctas_en_combos=false;

                InfoParam_conta=BusParam_conta.Get_Info_Parametro(IdEmpresa);

                P_Se_Muestra_Todas_las_ctas_en_combos = (InfoParam_conta.P_Se_Muestra_Todas_las_ctas_en_combos == null) ? false : Convert.ToBoolean(InfoParam_conta.P_Se_Muestra_Todas_las_ctas_en_combos);

                lm = data.Get_List_Plancta_x_ctas_Movimiento(IdEmpresa, ref MensajeError, P_Se_Muestra_Todas_las_ctas_en_combos);


                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Cuentas_de_Movimiento", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public List<ct_Plancta_Info> Get_List_PlanctaUltNivel(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.Get_List_PlanctaUltNivel(IdEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_PlanctaUltNivel", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }

        }
        public List<ct_Plancta_Info> Get_List_Plan_ctaPadre(int IdEmpresa, ref string MensajeError)
        {
            List<ct_Plancta_Info> lm = new List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {
                lm = data.Get_List_Plan_ctaPadre(IdEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Plan_ctaPadre", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public string Get_Id(int IdEmpresa,string IdCuenta_padre, ref string MensajeError)
        {
            ct_Plancta_Data data = new ct_Plancta_Data();
            string @W_idEncontrado = "";
            try
            {
                @W_idEncontrado = data.Get_Id(IdEmpresa, IdCuenta_padre, ref MensajeError);
                return @W_idEncontrado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Id", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }

        }
        public Boolean ModificarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.ModificarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public Boolean AnularDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.AnularDB(info, ref MensajeError);
            } 
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public Boolean GrabarDB(ct_Plancta_Info info, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.GrabarDB(info,ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public Boolean EliminarDB(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.EliminarDB(IdEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public Boolean VerificaNivel(int idnivel, int idempresa, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.VerificaNivel(idnivel, idempresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificaNivel", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public Boolean ValidaIdCtaCble(int idempresa, string IdCuenta, ref string MensajeError)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.ValidaIdCtaCble(idempresa, IdCuenta, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidaIdCtaCble", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public List<ct_Plancta_Info> Get_List_Plancta(int IdEmpresa, int IdNivel)
        {
            List<ct_Plancta_Info> lm = new  List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {
                lm = data.Get_List_Plancta(IdEmpresa, IdNivel);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_plancta", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }
        public List<ct_Plancta_Info> Get_List_Plancta_para_asiento_cierre(int IdEmpresa, int Anio)
        {
            try
            {
                ct_Plancta_Data data = new ct_Plancta_Data();
                return data.Get_List_Plancta_para_asiento_cierre(IdEmpresa, Anio);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_info_plancta", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }

        public List<ct_Plancta_Info> Get_Plancta_x_Grupo(int IdEmpresa, string IdGrupoCble)
        {
            List<ct_Plancta_Info> lm = new List<ct_Plancta_Info>();
            ct_Plancta_Data data = new ct_Plancta_Data();
            try
            {
                lm = data.Get_List_Plancta_x_Grupo(IdEmpresa, IdGrupoCble);
                return (lm);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Plancta_x_Grupo", ex.Message), ex) { EntityType = typeof(ct_Plancta_Bus) };
            }
        }

        public ct_Plancta_Bus()
        {
          
        }
    }
}
