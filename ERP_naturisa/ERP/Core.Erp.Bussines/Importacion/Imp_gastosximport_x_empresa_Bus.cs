using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Importacion;
using Core.Erp.Data.Importacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Importacion
{
    public class imp_gastosximport_x_empresa_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        imp_gastosximport_x_empresa_Data odata = new imp_gastosximport_x_empresa_Data();

        public List<imp_gastosximport_x_empresa_Info> Consulta(int IdEmpresa)
        {
            try
            {
                return odata.Get_List_gastosximport_x_empresa(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_gastosximport_x_empresa_Bus) };
            
            }

        
        }
        public Boolean Guardar(imp_gastosximport_x_empresa_Info Info)
        {
            try
            {
                Info.debcre_DebBanco = Info.debcre_DebBanco[0].ToString();
                Info.debCre_Provicion = Info.debCre_Provicion[0].ToString();
                return odata.GuardarDB(Info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Guardar", ex.Message), ex) { EntityType = typeof(imp_gastosximport_x_empresa_Bus) };
            
            }

        
        }

        public List<imp_gastosximport_x_empresa_Info> Get_List_gastosximport_x_empresa()
        {
            try
            {
                  return odata.Get_List_gastosximport_x_empresa();
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Consulta", ex.Message), ex) { EntityType = typeof(imp_gastosximport_x_empresa_Bus) };
            
            }

        }

        public Boolean Actualizar(List<imp_gastosximport_x_empresa_Info> lst)
        {

            try
            {
                    lst.ForEach(var =>
                     {
                        var.debcre_DebBanco = var.debcre_DebBanco[0].ToString();
                        var.debCre_Provicion = var.debCre_Provicion[0].ToString();
                    });

                        return odata.ModificarDB(lst);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Actualizar", ex.Message), ex) { EntityType = typeof(imp_gastosximport_x_empresa_Bus) };
            
            }


          
        }
    }
}
