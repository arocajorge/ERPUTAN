
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Empleado_Novedad_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Empleado_Novedad_Data oData = new ro_Empleado_Novedad_Data();
        ro_Empleado_Novedad_Det_Bus novedad_detalle_bus = new ro_Empleado_Novedad_Det_Bus();
        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa,DateTime fi,DateTime ff)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa,fi,ff);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }



        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public List<ro_Empleado_Novedad_Info> Get_List_Novedades_Cambiar_estado_Canceladas(int IdEmpresa, int idnomina, int idnomina_tipo, DateTime fecha_incion, DateTime fecha_fin)
        {
            try
            {
                return oData.Get_List_Novedades_Cambiar_estado_Canceladas(IdEmpresa, idnomina, idnomina_tipo, fecha_incion, fecha_fin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public List<ro_Empleado_Novedad_Info> Get_List_Empleado_Novedad_Cab(int IdEmpresa, string IdCalendario, string IdRubro)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Cab(IdEmpresa  ,IdCalendario ,IdRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab_x_Rubro(int IdEmpresa, decimal idNovedades, string idrubro, decimal IdEmpleado)
        {
            try
            {
                return oData.Get_Info_Empleado_Novedad_Cab_x_Rubro(IdEmpresa, idNovedades, idrubro,IdEmpleado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_Novedad_Cab_x_Rubro", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public ro_Empleado_Novedad_Info Get_Info_Empleado_Novedad_Cab(int IdEmpresa, decimal idNovedades, string idrubro)
        {
            try
            {
                return oData.Get_Info_Empleado_Novedad_Cab(IdEmpresa, idNovedades, idrubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public Boolean GrabarDB(ro_Empleado_Novedad_Info info,ref decimal id, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(info,ref id, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public Boolean ModificarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje, decimal idTransaccion)
        {
            try
            {
                return oData.ModificarDB(ro_info, ref mensaje, idTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }
        public Boolean GrabarDB(ro_Empleado_Novedad_Info ro_info, ref string mensaje, ref decimal idNovedad,ref decimal idTransaccion)
        {
            try
            {
                return oData.GrabarDB(ro_info, ref mensaje, ref  idNovedad, ref idTransaccion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }
           
        public Boolean AnularDB(ro_Empleado_Novedad_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }

        public Boolean Modificar_Nov(ro_Empleado_Novedad_Info info)
        {
            try
            {
                return oData.Modificar_Nov(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarSueldo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }
        }
        

      

       public Boolean EliminarDB(int IdEmpresa, decimal IdNovedad,decimal IdEmpleado ,int IdNominaTipo, int IdNominaTipoLiqui, ref string msg)
       {
          try{
                 return oData.EliminarBD(IdEmpresa, IdNovedad, IdEmpleado, IdNominaTipo, IdNominaTipoLiqui, ref msg);
            }catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
            }

        }

       public Boolean ModificarDB(ro_Empleado_Novedad_Info ro_info)
       {

           try
           {
               return oData.ModificarDB(ro_info);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
           }
       }


       public Boolean GrabarDB(ro_Empleado_Novedad_Info info, ref decimal IdNovedad )
       {
           try
           {

               string msg="";
               int secu = 0;
               if (oData.GrabarDB(info, ref  IdNovedad))
               {
                   if (info.LstDetalle.Count()==0)
                   {
                       info.InfoNovedadDet.IdNovedad = IdNovedad;
                       info.InfoNovedadDet.IdEmpresa = info.IdEmpresa;
                       info.InfoNovedadDet.IdNomina = info.IdNomina_Tipo;
                       info.InfoNovedadDet.IdNominaLiqui = info.IdNomina_TipoLiqui;
                       novedad_detalle_bus.GrabarDB(info.InfoNovedadDet, ref msg);
                   }
                   if (info.LstDetalle.Count() > 0)
                   {
                       foreach (var item in info.LstDetalle)
                       {
                           secu++;
                           item.IdNovedad = IdNovedad;
                           item.Secuencia = secu;
                           novedad_detalle_bus.GrabarDB(item, ref msg);

                       }
                   }
                   
               }

               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
           }
       }


       public bool Get_ExisteNovedad(int IdEmpresa, int idnomina, int idnomina_tipo, decimal IdEmpleado, string IdCalendario, string IdRubro)
       {


           try
           {

               return oData.Get_ExisteNovedad(IdEmpresa, idnomina, idnomina_tipo, IdEmpleado, IdCalendario, IdRubro);
           }
           catch (Exception ex)
           {
               
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
        
           }
       }


       public Boolean GrabarDB_SaldosNegativos(ro_Empleado_Novedad_Info info, ref decimal IdNovedad)
       {
           try
           {

               string msg = "";
               int secu = 0;
               info.TotalValor = info.TotalValor * -1;
               if (oData.GrabarDB(info, ref  IdNovedad))
               {

                   ro_Empleado_Novedad_Det_Info item = new ro_Empleado_Novedad_Det_Info();
                           item.IdNovedad = IdNovedad;
                           item.Secuencia = 1;
                           item.IdNovedad = IdNovedad;
                           item.IdEmpresa = info.IdEmpresa;
                           item.IdEmpleado = info.IdEmpleado;
                           item.IdNomina = info.IdNomina_Tipo;
                           item.IdNominaLiqui = info.IdNomina_TipoLiqui;
                           item.IdRubro = info.IdRubro;
                           item.EstadoCobro = "PEN";
                           item.Estado = "A";
                           item.Observacion = "Esta novedad fue generada por saldo negativo";
                           item.FechaPago = info.Fecha_PrimerPago;
                           item.Fecha = DateTime.Now;
                           item.IdCalendario = info.IdCalendario;
                           item.Fecha = info.Fecha;
                           item.Valor = info.TotalValor;
                           novedad_detalle_bus.GrabarDB(item, ref msg);


               }

               return true;
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
           }
       }

       public bool EliminarNovedadSaldoNegativos(int idempresa, int idnomina, string idcalendario)
       {
           try
           {
              return oData.EliminarNovedadSaldoNegativos( idempresa, idnomina, idcalendario);
           }
           catch (Exception ex)
           {
               
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Bus) };
       
           }
       }
   
        // Novedad agregada por pantalla desde descuento Transgandia


       public ro_Empleado_Novedad_Bus() { }


    }
}
