using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Data.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_GrupoEmpresarial_grupocble_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        ct_GrupoEmpresarial_grupocble_Data data = new ct_GrupoEmpresarial_grupocble_Data();


        public Boolean GuardarDB(ct_GrupoEmpresarial_grupocble_Info Info)
        {
            try
            {
              return data.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_grupocble_Bus) };
            }

        }

        public List<ct_GrupoEmpresarial_grupocble_Info> Get_list_GrupoEmpresarial_grupocble()
        {
            try
            {
               return data.Get_list_GrupoEmpresarial_grupocble();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_list_GrupoEmpresarial_grupocble", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_grupocble_Bus) };
            }

        }
        
        public Boolean VericarExisteIdString(string codigo, ref string mensaje)
        {
            try
            {
                  return data.VericarExisteIdString(codigo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VericarExisteIdString", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_grupocble_Bus) };
            }

        }
        
        public Boolean ModificarDB(ct_GrupoEmpresarial_grupocble_Info info)
        {
            try
            {
               return data.ModificarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ct_GrupoEmpresarial_grupocble_Bus) };
            }

        }
        
        public  ct_GrupoEmpresarial_grupocble_Bus(){
            
        }
    }
}
