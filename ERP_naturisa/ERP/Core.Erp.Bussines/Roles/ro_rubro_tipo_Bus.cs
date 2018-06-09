using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_rubro_tipo_Bus
    {
        string mensaje = "";

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        
        ro_rubro_tipo_Data odata = new ro_rubro_tipo_Data();

        public Boolean GuardarDB(ref ro_rubro_tipo_Info Info, ref string msg)
        {
            try
            {
                return odata.GuardarDB(ref  Info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
            
        }

        public List<ro_rubro_tipo_Info> Get_List_Rubros_Acumulados(int idEmpresa)
        {
            try
            {
                return odata.Get_List_Rubros_Acumulados(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }      
        }
        public List<ro_rubro_tipo_Info> ConsultaGeneral(int IdEmpresa)
        {
            try
            {
                return odata.ConsultaGeneral(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }           
        }

        public List<ro_rubro_tipo_Info> Get_lista_rubros_x_nomina_tipo_liq(int idEmpresa, int IdNominaTipo, int IdNominaTipoLiqui)
        {
            try
            {
                return odata.Get_lista_rubros_x_nomina_tipo_liq(idEmpresa, IdNominaTipo, IdNominaTipoLiqui);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista_rubros_x_nomina_tipo_liq", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }


        public List<ro_rubro_tipo_Info> Get_List_Formulas(int idEmpresa)
        {
            try
            {
                return odata.Get_List_Formulas(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista_rubros_x_nomina_tipo_liq", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }
        public List<ro_rubro_tipo_Info> ConsultaGeneralPorEmpresa(int idEmpresa)
        {
            try
            {
                return odata.ConsultaGeneralPorEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista_rubros_x_nomina_tipo_liq", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }

        public List<ro_rubro_tipo_Info> Get_listarubro_provisiones(int idEmpresa)
        {
            try
            {
                return odata.Get_listarubro_provisiones(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lista_rubros_x_nomina_tipo_liq", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }
        public List<ro_rubro_tipo_Info> Get_list_rubros_concepto(int idEmpresa)
        {
            try
            {
                return odata.Get_list_rubros_concepto(idEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaGeneralPorEmpresa", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
        }
        public List<ro_rubro_tipo_Info> ConsultaRubrosPrestamo(int IdEmpresa)
        {

            try
            {
                return odata.ConsultaRubrosPrestamo(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaRubrosPrestamo", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
        
        }

        public List<ro_rubro_tipo_Info> ConsultaEspecifica(String IdRubro)
        {
            try
            {
                return odata.ConsultaEspecifica(IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaEspecifica", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }

        public ro_rubro_tipo_Info GetInfoConsultaPorId(int IdEmpresa,string IdRubro)
        {
            try
            {
                return odata.GetInfoConsultaPorId(IdEmpresa,IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoConsultaPorId", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
            
        }

        public ro_rubro_tipo_Info GetInfoConsultaPorCodigoRol(int IdEmpresa, string id)
        {
            try
            {
                return odata.GetInfoConsultaPorCodigoRol(IdEmpresa,id);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetInfoConsultaPorCodigoRol", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }

        }
        
        public Boolean ModificarDB(ro_rubro_tipo_Info info)
        {
            try
            {
                return odata.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
            
        }

        public Boolean AnularDB(ro_rubro_tipo_Info info)
        {
            try
            {
                return odata.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
            
        }

        public Boolean VericarCodigoExiste(int IdEmpresa,string codigo, ref string mensaje)
        {
            try
            {
                ro_rubro_tipo_Data data = new ro_rubro_tipo_Data();
                return data.VericarCodigoExiste(IdEmpresa,codigo, ref mensaje);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCodigoExiste", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
        }

        public int getId(int IdRubro)
        {
            try
            {
                ro_rubro_tipo_Data data = new ro_rubro_tipo_Data();
                return data.getId(IdRubro);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };

            }
        }

    
        public List<ro_rubro_tipo_Info> ConsultaIngreso(int IdEmpresa) {
                try
            {
                return odata.ConsultaIngreso(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaIngreso", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
        }

        public List<ro_rubro_tipo_Info> ConsultaEgreso(int IdEmpresa)
        { 
        
          try
            {
                return odata.ConsultaEgreso(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaEgreso", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
            }
        }

        public List<ro_rubro_tipo_Info> Get_List_rubros_Ing_Egr(int idEmpresa, string ingr, string egr)
        {
            try
            {
                return odata.Get_List_rubros_Ing_Egr(idEmpresa, ingr, egr);
            }
            catch (Exception ex)
            {
                
                 Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_rubros_Ing_Egr", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };
        
            }
        }

        public List<ro_rubro_tipo_Info> Get_List_Rubros_Horas_Extras(int idEmpresa)
        {
            try
            {
                return odata.Get_List_Rubros_Horas_Extras(idEmpresa);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_rubros_Ing_Egr", ex.Message), ex) { EntityType = typeof(ro_rubro_tipo_Bus) };

            }
        }
    }
}
