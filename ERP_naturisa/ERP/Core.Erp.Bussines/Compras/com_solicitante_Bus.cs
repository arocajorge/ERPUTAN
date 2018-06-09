using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Compras;
using Core.Erp.Data.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Compras
{
  public  class com_solicitante_Bus
    {



      com_solicitante_Data odata = new com_solicitante_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
      

        public Boolean VericarCedulaExiste(int IdEmpresa, string cedula, ref string mensaje)
        {
            try
            {
                return odata.VericarCedulaExiste(IdEmpresa, cedula, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            }
        }

        public Boolean VerificarNombre(int IdEmpresa, string nombre, ref string mensaje)
        {
            try
            {
                return odata.VerificarNombre(IdEmpresa, nombre, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            }
        }

        public decimal getIdSolicitante(int IdEmpresa, ref string mensaje)
        {
            decimal Id = 0;
            try
            {
                return odata.GetIdSolicitante(IdEmpresa, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            }
        }

        public Boolean GuardarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                return odata.GuardarDB(info, ref mensaje);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            }
        }

        public Boolean ModificarDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                return odata.ModificarDB(info, ref mensaje);   
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
            }
        }

        public Boolean AnularDB(com_solicitante_Info info, ref string mensaje)
        {
            try
            {
                return odata.AnularDB(info, ref mensaje);
                
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };
                
            }
        }


        public List<com_solicitante_Info> Get_List_Solicitante(int IdEmpresa)
        {
            List<com_solicitante_Info> Lst = new List<com_solicitante_Info>();
            try
            {
                return odata.Get_List_Solicitante(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarCedulaExiste", ex.Message), ex) { EntityType = typeof(com_comprador_Bus) };   
            }
        }


        


    }
}
