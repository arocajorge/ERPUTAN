/*CLASE: ro_Novedad_x_Empleado_Bus
 *CREADA POR: ALBERTO MENA
 *FECHA CREACION: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Roles
{
    public class ro_Novedad_x_Empleado_Bus
    {
        private ro_Novedad_x_Empleado_Data oData = new ro_Novedad_x_Empleado_Data();

        public List<ro_Novedad_x_Empleado_Info> Get_List_Novedad_x_Empleado(int idEmpresa)
        {
            try
            {
                return oData.Get_List_Novedad_x_Empleado(idEmpresa);       
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Novedad_x_Empleado", ex.Message), ex) { EntityType = typeof(ro_Novedad_x_Empleado_Bus) };
            }
        }

        public ro_Novedad_x_Empleado_Info Get_Info_Novedad_x_Empleado_x_IdTransaccion(int idEmpresa, decimal id)
        {
            try
            {
                return oData.Get_Info_Novedad_x_Empleado_x_IdTransaccion(idEmpresa, id);              
            }
            catch (Exception ex)
            {
                
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Novedad_x_Empleado_x_IdTransaccion", ex.Message), ex) { EntityType = typeof(ro_Novedad_x_Empleado_Bus) };
            }
            
        }


        public Boolean GuardarDB(ro_Novedad_x_Empleado_Info info, decimal id,  string msg)
        {
            try
            {
                if (info.IdTransaccion != null)
                {
                    return oData.GrabarDB(info, id, ref msg);
                }
                else
                {
                    oData.ModificarDB(info, ref  msg);
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(ro_Novedad_x_Empleado_Bus) };   
                
            }
        
            
        }

        public decimal getId(int idEmpresa) 
        {
            try
            {
                return oData.getId(idEmpresa);       
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "getId", ex.Message), ex) { EntityType = typeof(ro_Novedad_x_Empleado_Bus) };
            }
            
        }
    


    }
}
