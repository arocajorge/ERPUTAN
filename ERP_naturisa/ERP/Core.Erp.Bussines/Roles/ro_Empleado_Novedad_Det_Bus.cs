using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using System.Data;



namespace Core.Erp.Business.Roles
{
    public class ro_Empleado_Novedad_Det_Bus
    {
        public ro_Empleado_Novedad_Det_Bus()
        {

        }

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        ro_Empleado_Novedad_Det_Data oData = new ro_Empleado_Novedad_Det_Data();       

        public Boolean GrabarDB(ro_Empleado_Novedad_Det_Info prI, ref string mensaje)
        {
            try
            {
                return oData.GrabarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }





        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_Rubro(int IdEmpresa, decimal idTransaccion, string idRubro)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Det_x_Rubro(IdEmpresa, idTransaccion, idRubro);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Det_x_Rubro", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det(int IdEmpresa, decimal IdEmpleado, decimal idNovedad, decimal Secuencia)
        {
            try
            {

                return oData.Get_List_Empleado_Novedad_Det(IdEmpresa, IdEmpleado, idNovedad, Secuencia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Det", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> ProcesarDataTableAInfo_Prestamo_Quirografario(DataTable ds, int idempresa, DateTime fecha, ref string msg)
        {
            try
            {
                return oData.ProcesarDataTableAInfo_Prestamo_Quirografario(ds, idempresa, fecha, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ProcesarDataTableAInfo_Prestamo_Quirografario", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }

        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_x_Nomina(int IdEmpresa, decimal IdEmpleado, int IdNomina, int IdNominaLiqui, string idRubro, DateTime fechaIni, DateTime fechaFin, ref string msg)
        {
            try
            {
                return oData.Get_List_Novedad_x_Nomina(IdEmpresa, IdEmpleado, IdNomina, IdNominaLiqui, idRubro, fechaIni, fechaFin, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Novedad_x_Nomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public double GetValorAcumuladoNovedadPorNomina(int idEmpresa, decimal idEmpleado, int idNomina, int idNominaLiqui, string idRubro, DateTime fechaIni, DateTime fechaFin, ref string msg)
        {
            try
            {
                double valorRetornar = 0;
                valorRetornar = Convert.ToDouble((from a in Get_List_Novedad_x_Nomina(idEmpresa, idEmpleado, idNomina, idNominaLiqui, idRubro, fechaIni, fechaFin, ref msg)
                                                  where a.Estado == "A" && a.EstadoCobro == "PEN"
                                                  select a.Valor).Sum());

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetValorAcumuladoNovedadPorNomina", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_det_x_Period(int idEmpresa, decimal idEmpleado, int idNominaTipo, int idNominaTipoLiqui, DateTime fechaInicio, DateTime fechaFinal, ref string msg)
        {
            try
            {
                return oData.Get_List_Novedad_det_x_Periodo(idEmpresa, idEmpleado, idNominaTipo, idNominaTipoLiqui, fechaInicio, fechaFinal, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Novedad_det_x_Periodo", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_Period(int IdEmpresa, decimal IdEmpleado, int IdNominaTipo, int IdNominaTipoLiqui, string IdRubro, DateTime fechaInicio, DateTime fechaFinal, ref string msg)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Det_x_Periodo(IdEmpresa, IdEmpleado, IdNominaTipo, IdNominaTipoLiqui, IdRubro, fechaInicio, fechaFinal, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Empleado_Novedad_Det_x_RubroPendiente(int idEmpresa, decimal idEmpleado, DateTime fechaIni, ref string msg)
        {
            try
            {
                return oData.Get_List_Empleado_Novedad_Det_x_RubroPendiente(idEmpresa, idEmpleado, fechaIni, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Det_x_RubroPendiente", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public ro_Empleado_Novedad_Det_Info Get_Info_Novedad_det(int idEmpresa, decimal idEmpleado, string idRubro, DateTime fecha, ref string msg)
        {
            try
            {
                return oData.Get_Info_Novedad_det(idEmpresa, idEmpleado, idRubro, fecha, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Empleado_Novedad_Cab", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public Boolean ModificarEstadoCobroDB(int IdEmpresa, int idNominaTipo, int idNominaTipoLiqui, DateTime pe_FechaIni, DateTime pe_FechaFin)
        {
            try
            {
                return oData.ModificarEstadoCobroDB(IdEmpresa, idNominaTipo, idNominaTipoLiqui, pe_FechaIni, pe_FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public List<ro_Empleado_Novedad_Det_Info> Get_List_Novedad_x_Periodo(int idEmpresa, int idNomina, int idNominaLiqui, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.Get_List_Novedad_x_Periodo(idEmpresa, idNomina, idNominaLiqui, fechaFin, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public decimal get_Valor_Novedad_Periodo(int idEmpresa, int idNomina, int idNominaLiqui, int IdEmpleado, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return oData.get_Valor_Novedad_Periodo(idEmpresa, idNomina, idNominaLiqui, IdEmpleado, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }








        public Boolean EliminarDB(ro_Empleado_Novedad_Det_Info prI, ref string mensaje)
        {
            try
            {
                return oData.EliminarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public Boolean EliminarDB(int IdEmpresa, decimal IdNovedad, decimal IdEmpleado, ref string mensaje)
        {
            try
            {
                return oData.EliminarDB(IdEmpresa, IdNovedad, IdEmpleado, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public Boolean EliminarDB(int idEmpresa, int IdNomina_Tipo, decimal idEmpleado, decimal idNovedad)
        {
            try
            {
                return oData.EliminarDB(idEmpresa, IdNomina_Tipo, idEmpleado, idNovedad);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public Boolean EliminarDB(int idEmpresa, decimal idEmpleado, decimal idNovedad, int secuencia, ref string msg)
        {
            try
            {
                return oData.EliminarDB(idEmpresa, idEmpleado, idNovedad, secuencia, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }

        public Boolean ModificarDB(ro_Empleado_Novedad_Det_Info prI, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(prI, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
    






        public Boolean AnularDB(ro_Empleado_Novedad_Det_Info info)
        {
            try
            {
                return oData.AnularDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }
        public Boolean AnularDB(decimal IdEmpresa, string IdCalendario, string IdRubro, decimal IdEmpleado, decimal IdNovedad, decimal Secuancia)
        {
            try
            {
                return oData.AnularDB(IdEmpresa, IdCalendario, IdRubro, IdEmpleado, IdNovedad, Secuancia);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
            }
        }


            #region novedades por procesos FJ 
      public Boolean ModificarDB_POR_ID_CALENDARIO(ro_Empleado_Novedad_Det_Info info)
      {
          try
          {
              return oData.ModificarDB_POR_ID_CALENDARIO(info);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
          }
      }

      public ro_Empleado_Novedad_Det_Info get_si_existe_novedad(int idEmpresa, decimal idEmpleado, string idRubro, string idcalendario)
      {
          try
          {
              return oData.get_si_existe_novedad(idEmpresa, idEmpleado, idRubro, idcalendario);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
          }
      }


      public double Get_valor_rebaja_Desahucio(int idEmpresa, decimal idEmpleado, string idRubro)
      {
          try
          {
              return oData.Get_valor_rebaja_Desahucio(idEmpresa, idEmpleado, idRubro);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarEstadoCobroDB", ex.Message), ex) { EntityType = typeof(ro_Empleado_Novedad_Det_Bus) };
          }
      }
#endregion 
    }
}
