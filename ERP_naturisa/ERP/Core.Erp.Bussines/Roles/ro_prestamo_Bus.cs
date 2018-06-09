using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public  class ro_prestamo_Bus
    {
       ro_prestamo_Data oData = new ro_prestamo_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";

       public Boolean Guardar_DB(ro_prestamo_Info Item, ref decimal Id, ref string mensaje)

       {
           try
           {
               return oData.Guardar_DB(Item, ref Id, ref  mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarCabPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           }
       }


       public List<ro_prestamo_Info> ConsultarCabeceraPrestamo(int IdEmpresa, DateTime FechaInci, DateTime FechaFin)
       {
           try
           {
               return oData.ConsultarCabeceraPrestamo(IdEmpresa, FechaInci, FechaFin);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarCabeceraPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           }
           
          
         
       }


       // haac 22/11/2013 para consulta prestamo info

       public ro_prestamo_Info ObtenerObjeto(int IdEmpresa, decimal IdPrestamo, decimal IdEmpleado)
       {
           try
           {
               return oData.ObtenerPrestamo(IdEmpresa, IdPrestamo, IdEmpleado);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerObjeto", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           }
       }



       public List<ro_prestamo_Info> ConsultarCabeceraPrestamoxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
       {

           try
           {
               return oData.ConsultarCabeceraPrestamoxIdPrestamo(IdEmpresa, IdPrestamo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultarCabeceraPrestamoxIdPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           }
           
       }

       public Boolean ModificarCabeceraPrestamo(ro_prestamo_Info Info)
       {
           try
           {
               return oData.ModificarCabeceraPrestamo(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarCabeceraPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           }
                     
       }




       public Boolean AnularPrestamo(ro_prestamo_Info Info)
       {

           try
           {
               return oData.AnularPrestamo(Info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_Bus) };
           } 
       }
    }
}
