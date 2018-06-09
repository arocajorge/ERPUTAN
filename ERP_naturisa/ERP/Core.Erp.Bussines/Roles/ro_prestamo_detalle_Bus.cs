

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;

using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
   public class ro_prestamo_detalle_Bus
    {
       ro_prestamo_detalle_Data oData = new ro_prestamo_detalle_Data();
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
     
       public Boolean GuardarPrestamoDetalle(List<ro_prestamo_detalle_Info> Lst, ref decimal Id, ref string mensaje)
        {
            try
            {
                return oData.GuardarPrestamoDetalle(Lst, ref Id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarPrestamoDetalle", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
            }
           
          
        }

      
       public List<ro_prestamo_detalle_Info> ConsultaxIdPrestamo(int IdEmpresa, decimal IdPrestamo)
       {
           try
           {
               return oData.ConsultaxIdPrestamo(IdEmpresa, IdPrestamo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaxIdPrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
           
          
       }

        public List<ro_prestamo_detalle_Info> GetListConsultaPorEmpleado(int idEmpresa,ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo, decimal idEmpleado)
       {
           try
           {
               return oData.GetListConsultaPorEmpleado(idEmpresa, info_periodo, idEmpleado);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }


        public List<ro_prestamo_detalle_Info> GetListConsultaPorEmpleado(int idEmpresa,  decimal idEmpleado)
        {
            try
            {
                return oData.GetListConsultaPorEmpleado(idEmpresa, idEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorEmpleado", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
            }
        }


 public Boolean EliminarDetallePrestamo(List<ro_prestamo_detalle_Info> detalleHold)
 {
     try
     {
         return oData.EliminarDetallePrestamo(detalleHold);
     }
     catch (Exception ex)
     {
         Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
         throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDetallePrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
     }
 }

      
     

       public Boolean AnularDetallePrestamo(List<ro_prestamo_detalle_Info> prI, ref string mensaje)
       {
           try
           {
               return oData.AnularDetallePrestamo(prI, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDetallePrestamo", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }


      


        public List<ro_prestamo_detalle_Info> GetListConsultaGeneral(int idEmpresa)
       {
           try
           {
               return oData.GetListConsultaGeneral(idEmpresa);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }


        public bool Cambiar_estado_cancelada(int idEmpresa, int idnomina_tipo, DateTime fecha_inicio, DateTime fecha_fin)
        {
            try
            {
                return oData.Cambiar_estado_cancelada(idEmpresa, idnomina_tipo, fecha_inicio,fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
            }
        }


       public Boolean ModificarEstadoCobroDB(ro_prestamo_detalle_Info info)
       {
           try
           {
               return oData.ModificarEstadoCobroDB(info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }


       public double SaldoPendiente(int IdEmpresa, int IdEmpleado)
       {
           try
           {
               return oData.SaldoPendiente(IdEmpresa,IdEmpleado);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }

       public Boolean Abono_Prestamo(List<ro_prestamo_detalle_Info> listadetalle, ref string mensaje)
       {
           try
           {
               return oData.Abono_Prestamo(listadetalle, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }

       public Boolean Eliminar_Cuotas_Pendientes(int IdEmpresa, int IdPrestamo)
       {
           try
           {
               return oData.Eliminar_Cuotas_Pendientes(IdEmpresa, IdPrestamo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }

       public bool Modificar_Cuotas_Forma_Pago(List<ro_prestamo_detalle_Info> listadetalle)
       {
           try
           {
               return oData.Modificar_Cuotas_Forma_Pago(listadetalle);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_prestamo_detalle_Bus) };
           }
       }
      
   }
}
