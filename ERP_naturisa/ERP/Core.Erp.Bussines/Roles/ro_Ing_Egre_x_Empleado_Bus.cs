using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public class ro_Ing_Egre_x_Empleado_Bus
    {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       ro_Ing_Egre_x_Empleado_Data oData = new ro_Ing_Egre_x_Empleado_Data();


       //BUS
       ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();

       //INFO
       List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();



       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int IdEmpresa, decimal IdEmpleado, int IdTipo_nomina, int IdProceso, int IdPeriodo)
       {
           try
           {
               return oData.Get_List_Ing_Egr_x_Empleado_x_Ingresos(IdEmpresa, IdEmpleado, IdTipo_nomina, IdProceso, IdPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
          
       }


       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ing_Egr_x_Empleado_x_Egresos(int idEmpresa, decimal idEmpleado, int IDtipo_nomina1, int IDproceso1, int IDperiodo1)
       {

           try
           {
               return oData.Get_List_Ing_Egr_x_Empleado_x_Egresos(idEmpresa, idEmpleado, IDtipo_nomina1, IDproceso1, IDperiodo1);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Egresos", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
           
       }


       public List<ro_Ing_Egre_x_Empleado_Info> Get_List_PagoBancoEmpleados(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo, decimal IdEmpleado)
       {
           try
           {
               return oData.Get_List_PagoBancoEmpleados(IdEmpresa, IdNomina_Tipo, IdNomina_TipoLiqui, IdPeriodo, IdEmpleado);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_PagoBancoEmpleados", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
          
       }


       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ro_Ing_Egr_x_Empleado(int IdEmpresa, int IdTipo_nomina, int IdProceso, int IdPeriodo)
       {
           try
           {
               return oData.Get_List_Ro_Ing_Egr_x_Empleado(IdEmpresa, IdTipo_nomina, IdProceso, IdPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ro_Ing_Egr_x_Empleado", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
          
       }


       public List<ro_Ing_Egre_x_Empleado_Info> Get_List_Ing_Egre_x_Empleado(int idEmpresa, int IDtipo_nomina1, int IDproceso1, int IDperiodo1)
       {

           try
           {
               List<ro_Ing_Egre_x_Empleado_Info> lM = new List<ro_Ing_Egre_x_Empleado_Info>();
               ro_Ing_Egre_x_Empleado_Data data = new ro_Ing_Egre_x_Empleado_Data();
               lM = data.Get_List_Ing_Egre_x_Empleado(idEmpresa, IDtipo_nomina1, IDproceso1, IDperiodo1);
               return (lM);                           
              
           }
           catch (Exception ex) 
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egre_x_Empleado", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
       }


       public Boolean GuardarBD(ro_Ing_Egre_x_Empleado_Info info, ref string msg)
       {
           try
           {
               return oData.GuardarBD(info,ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
       }


       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg) {
           try
           {
               return oData.EliminarBD(idEmpresa,  idNomina,  idNominaLiqui,  idPeriodo,  idEmpleado, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Ing_Egre_x_Empleado_Bus) };
           }
       
       }






    }
}
