using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Business.Contabilidad
{
   public class ct_periodo_x_tb_modulo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_periodo_x_tb_modulo_Data OData = new ct_periodo_x_tb_modulo_Data();



        public List<ct_periodo_x_tb_modulo_Info> Get_List_Periodo(int IdEmpresa, ref string MensajeError)
        {
            try
            {
                List<ct_periodo_x_tb_modulo_Info> lM = new List<ct_periodo_x_tb_modulo_Info>();
                lM = OData.Get_List_Periodo(IdEmpresa, ref MensajeError);
                
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public List<ct_periodo_x_tb_modulo_Info> Get_List_Periodo(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                List<ct_periodo_x_tb_modulo_Info> lM = new List<ct_periodo_x_tb_modulo_Info>();
                lM = OData.Get_List_Periodo(IdEmpresa,IdPeriodo, ref MensajeError);

                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public bool Esta_modulo_cerrado_x_periodo(int IdEmpresa, Cl_Enumeradores.eModulos IdModulo, int IdPeriodo)
        {
            try
            {
                return OData.Esta_modulo_cerrado_x_periodo(IdEmpresa, IdModulo, IdPeriodo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Esta_modulo_cerrado_x_periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public ct_periodo_x_tb_modulo_Info Get_Info_Periodo(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                ct_periodo_x_tb_modulo_Info _PeriodoInfo = new ct_periodo_x_tb_modulo_Info();
                _PeriodoInfo =OData.Get_Info_Periodo(IdEmpresa, IdPeriodo, ref   MensajeError);
                return _PeriodoInfo;
     
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }


        public Boolean ModificarDB(List<ct_periodo_x_tb_modulo_Info> Listinfo, ref string MensajeError)
        {
            try
            {
                return OData.ModificarDB(Listinfo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        
        }

        public Boolean ModificarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                return OData.ModificarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean GrabarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                return OData.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean GrabarDB(List<ct_periodo_x_tb_modulo_Info> Listinfo, ref string MensajeError)
        {
            try
            {
                return OData.GrabarDB(Listinfo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Periodo", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

        public Boolean EliminarDB(ct_periodo_x_tb_modulo_Info info, ref string MensajeError)
        {
            try
            {
                return OData.EliminarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }

       public Boolean EliminarDB(int IdEmpresa, int IdPeriodo, ref string MensajeError)
        {
            try
            {
                return OData.EliminarDB(IdEmpresa, IdPeriodo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ct_Periodo_Bus) };
            }
        }
    }
}
