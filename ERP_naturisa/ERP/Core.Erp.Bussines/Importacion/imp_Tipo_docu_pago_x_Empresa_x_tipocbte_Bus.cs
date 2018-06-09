using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info_Data odata = new imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info_Data();

        public List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> Get_List_Tipo_docu_pago_x_Empresa_x_tipocbte(int IdEmpresa)
        {
            try
            {
                    return odata.Get_List_Tipo_docu_pago_x_Empresa_x_tipocbte(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerLista", ex.Message), ex) { EntityType = typeof(imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus) };
            
            }

        
        }

        public Boolean ModificarDB(List<imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Info> Lst)
        {
            try
            {
               return odata.ModificarDB(Lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar", ex.Message), ex) { EntityType = typeof(imp_Tipo_docu_pago_x_Empresa_x_tipocbte_Bus) };
            
            }

        }

    }

}
