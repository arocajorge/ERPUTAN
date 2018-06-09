
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Business.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;

namespace Core.Erp.Business.Roles
{
    public class ro_Rol_Detalle_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        ro_Rol_Detalle_Data oData = new ro_Rol_Detalle_Data();


        public List<ro_Rol_Detalle_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {

            try
            {
                return oData.GetListConsultaGeneral(idEmpresa, idNominaTipo,idNominaTipoLiqui,idPeriodo,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneral", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

        public List<ro_Rol_Detalle_Info> GetListConsultaPorRolEmpleado(int idEmpresa,decimal idEmpleado ,int idNominaTipo, int idNominaTipoLiqui, int idPeriodo,ref string msg)
        {

            try
            {
                return oData.GetListConsultaPorRolEmpleado(idEmpresa,idEmpleado, idNominaTipo, idNominaTipoLiqui, idPeriodo,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRolEmpleado", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }


     public List<ro_Rol_Detalle_Info> GetListConsultaPorRol(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {

            try
            {
                return oData.GetListConsultaPorRol(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }


     public List<ro_Rol_Detalle_Info> GetListConsultaPorNominaRubro(int idEmpresa, int idEmpleado, int idNominaTipo, string idRubro, ref string msg)
        {

            try{
                return oData.GetListConsultaPorNominaRubro(idEmpresa, idEmpleado, idNominaTipo, idRubro, ref mensaje);
            }
            catch (Exception ex){
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorNominaRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

        public double GetAcumuladoPorRubro(int idEmpresa, int idEmpleado, int idNominaTipo, string idRubro, ref string msg)
        {
            try
            {
                double valorRetornar = 0;

                valorRetornar = (from a in oData.GetListConsultaPorNominaRubro(idEmpresa, idEmpleado, idNominaTipo, idRubro, ref mensaje)
                                select a.Valor).Sum();
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetAcumuladoPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }


        public double GetValorAcumuladoPorRubro(int idEmpresa, decimal idEmpleado, int idNominaTipo, string idRubro, DateTime fechaIni, DateTime fechaFin,ref string msg)
        {
            try
            {
                double valorRetornar = 0;

                valorRetornar = oData.GetValorAcumuladoPorRubro(idEmpresa, idEmpleado, idNominaTipo, idRubro, fechaIni, fechaFin, ref mensaje);

                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetValorAcumuladoPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

       
        
        public Boolean GetExiste(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {
                return oData.GetExiste(info, ref mensaje);
            }catch (Exception ex){
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetExiste", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

        public Boolean GuardarBD(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                //MODIFICA DETALLE
                if (oData.GetExiste(info, ref mensaje))
                {
                    valorRetornar = oData.ModificarBD(info, ref mensaje);
                }
                else
                {//ACTUALIZA DETALLE
                    valorRetornar = oData.GuardarBD(info, ref mensaje);
                }
                return valorRetornar;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

        public Boolean GrabarBD(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;

                valorRetornar = oData.GuardarBD(info, ref mensaje);
                
                return valorRetornar;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }

        
        
        public Boolean ModificarBD(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {
                return oData.ModificarBD(info, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
            }
        }


       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui,int idPeriodo, decimal idEmpleado, ref string msg) {
           try
           {
               return oData.EliminarBD(idEmpresa,idNomina,idNominaLiqui,idPeriodo,idEmpleado, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }


      


       public List<ro_Rol_Detalle_Info> GetListConsultaPorRubroPendiente(int idEmpresa, decimal idEmpleado, string idRubro,DateTime fechaIngreso, DateTime FechaSalida, ref string msg) {
           try
           {
               return oData.GetListConsultaPorRubroPendiente(idEmpresa, idEmpleado, idRubro,fechaIngreso,FechaSalida, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRubroPendiente", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       
       }


       public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo,int IdDivision, string idRubro, List<string> Bancos, List<string> Cuentas, ref string msg)
       {
           try
           {
               return oData.GetListConsultaGeneralPorRubro(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo,IdDivision, idRubro,Bancos,Cuentas, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneralPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       
       
       }



       public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, string idRubro, List<string> Bancos, List<string> Cuentas, ref string msg)
       {
           try
           {
               return oData.GetListConsultaGeneralPorRubro(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, idRubro, Bancos, Cuentas, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneralPorRubro", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }


       }

       public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubroDivision(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, string idRubro, int idDivision,ref string msg)
       {
           try
           {
               return oData.GetListConsultaGeneralPorRubroDivision(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, idRubro,idDivision, ref msg);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneralPorRubroDivision", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }


       }

       public List<ro_Rol_Detalle_Info> GetList_InformeIESS(int idEmpresa, decimal idEmpleado, int IdPeriodo)
       {
           try
           {
               return oData.GetList_InformeIESS(idEmpresa, idEmpleado, IdPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaGeneralPorRubroDivision", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }


       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo)
       {
           try
           {
               return oData.EliminarBD(idEmpresa, idNomina, idNominaLiqui, idPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }


       public decimal Get_Valor_Impuesto_Renta(int idempresa, int idempleado, int Anio_Fiscal)
       {
           try
           {
               return oData.Get_Valor_Impuesto_Renta(idempresa, idempleado, Anio_Fiscal);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarBD", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }

       public List<ro_Rol_Detalle_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int idEmpresa, int IdNomina_Tipo, int Id_Nomina_Tipo_liq, int IdPeriodo)
       {
           try
           {
               return oData.Get_List_Ing_Egr_x_Empleado_x_Ingresos(idEmpresa, IdNomina_Tipo, Id_Nomina_Tipo_liq, IdPeriodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }



       public List<ro_Rol_Detalle_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int idEmpresa, int IdNomina_Tipo, int Id_Nomina_Tipo_liq, int IdPeriodo, int IdEmpleado)
       {
           try
           {
               return oData.Get_List_Ing_Egr_x_Empleado_x_Ingresos(idEmpresa, IdNomina_Tipo, Id_Nomina_Tipo_liq, IdPeriodo, IdEmpleado);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }




       public double Get_Valor_Fondo_Reserva_x_periodo_x_nomina(int idempresa, int idnomina_tipo,int IdNomina_tipo_Liq, int idempleado, int idperiodo)
       {

           try
           {
               return oData.Get_Valor_Fondo_Reserva_x_periodo_x_nomina(idempresa, idnomina_tipo,IdNomina_tipo_Liq, idempleado, idperiodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }
       public double Get_Valor_Anticipo(int idempresa, int idnomina_tipo, int IdNomina_tipo_Liq, int idempleado, int idperiodo)
       {
           try
           {
               return oData.Get_Valor_Anticipo(idempresa, idnomina_tipo, IdNomina_tipo_Liq, idempleado, idperiodo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }



       public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, int IdArchivo)
       {
           try
           {
               return oData.GetListConsultaGeneralPorRubro(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, IdArchivo);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Ing_Egr_x_Empleado_x_Ingresos", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }



       public List<ro_Rol_Detalle_Info> Get_lista_rol_Provisiones(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
       {

           try
           {
               return oData.Get_lista_rol_Provisiones(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo, ref mensaje);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }

       public double Get_Decimo_Acumulados(int idempresa, int idnomina_tipo, int idempleado, string IdRubro)
       {
           try
           {
               return oData.Get_Decimo_Acumulados(idempresa, idnomina_tipo, idempleado, IdRubro);
           }
           catch (Exception ex)
           {
               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
           }
       }

       public double Get_Decimotcuarta(int idempresa, DateTime fi, DateTime ff, decimal idempleado)
       {
           try
           {
               return oData.Get_Decimotcuarta(idempresa, fi, ff, idempleado);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };

           }
       }

       public double Get_Decimoterceo(int idempresa, DateTime fi, DateTime ff, decimal idempleado)
       {
           try
           {
               return oData.Get_Decimoterceo(idempresa, fi, ff, idempleado);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GetListConsultaPorRol", ex.Message), ex) { EntityType = typeof(ro_Rol_Detalle_Bus) };
         
           }
       }


    }
}
