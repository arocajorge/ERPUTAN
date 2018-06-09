/*CLASE: ro_rol_individual_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 04-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles
{
   public class ro_rol_individual_Data
    {
       private string mensaje = "";

       public List<ro_rol_individual_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
       {

           try
           {
               List<ro_rol_individual_Info> oListado = new List<ro_rol_individual_Info>();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_rol_individual
                                where a.IdEmpresa == idEmpresa && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaTipoLiqui && a.IdPeriodo == idPeriodo
                                select a);

                   foreach (var info in datos)
                   {
                       ro_rol_individual_Info item = new ro_rol_individual_Info();
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNominaTipo = info.IdNominaTipo;
                       item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                       item.IdPeriodo = info.IdPeriodo;
                       item.IdEmpleado = info.IdEmpleado;
                       item.IdRubro = info.IdRubro;
                       item.Orden = info.Orden;
                       item.Ingreso = info.Ingreso;
                       item.Egreso = info.Egreso;

                       oListado.Add(item);
                   }
               }
               return oListado;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }



       public Boolean GuardarBD(ro_rol_individual_Info info, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   ro_rol_individual item = new ro_rol_individual();
                   item.IdEmpresa = info.IdEmpresa;
                   item.IdNominaTipo = info.IdNominaTipo;
                   item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                   item.IdPeriodo = info.IdPeriodo;
                   item.IdEmpleado = info.IdEmpleado;
                   item.IdRubro = info.IdRubro;
                   item.Orden = info.Orden;
                   item.Ingreso = info.Ingreso;
                   item.Egreso = info.Egreso;
                   item.FechaPago = info.FechaPago;
                   db.ro_rol_individual.Add(item);
                   db.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }


       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   db.Database.ExecuteSqlCommand("delete from dbo.ro_rol_individual where IdEmpresa =" + idEmpresa.ToString()
                      + " AND IdNominaTipo=" + idNomina.ToString()
                      + " AND IdNominaTipoLiqui=" + idNominaLiqui.ToString()
                      + " AND IdPeriodo=" + idPeriodo.ToString()
                      + " AND IdEmpleado=" + idEmpleado.ToString()
                      );
               }

               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }



       public Boolean GetExiste(ro_rol_individual_Info info, ref string msg)
       {
           try
           {
               Boolean valorRetornar = false;
               using (EntitiesRoles db = new EntitiesRoles())
               {
                   int cont = (from a in db.ro_rol_individual
                               where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                               && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                               && a.IdEmpleado == info.IdEmpleado && a.IdRubro == info.IdRubro && a.IdPeriodo==info.IdPeriodo
                               select a).Count();

                   if (cont > 0) { valorRetornar = true; }
                   else { valorRetornar = false; }
               }
               return valorRetornar;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }


       public Boolean ModificarBD(ro_rol_individual_Info info, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   ro_rol_individual item = (from a in db.ro_rol_individual
                                             where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                                              && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                                              && a.IdEmpleado == info.IdEmpleado && a.IdRubro == info.IdRubro
                                             select a).FirstOrDefault();

                   item.Orden = info.Orden;
                   item.Egreso = info.Egreso;
                   item.Ingreso = info.Ingreso;

                   db.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }

       }
    }
}
