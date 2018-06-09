/*CLASE: ro_Ing_Egre_x_Empleado_Data
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
   public class ro_Ing_Egre_x_Empleado_Data
    {
       string mensaje = "";

       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int idEmpresa, decimal idEmpleado, int IDtipo_nomina1, int IDproceso1, int IDperiodo1)
       {
               List<vwRo_Ing_Egr_x_Empleado_Info> lM = new List<vwRo_Ing_Egr_x_Empleado_Info>();

               EntitiesRoles OERol_Empleado = new EntitiesRoles();
           try
           {
               var select = from A in OERol_Empleado.vwRo_Ing_Egr_x_Empleado
                            where A.IdEmpresa == idEmpresa && A.IdEmpleado==idEmpleado && A.IngEgr =="I"
                            && A.IdNomina_Tipo==IDtipo_nomina1 && A.IdNomina_TipoLiqui==IDproceso1 && A.IdPeriodo==IDperiodo1
                            && A.Unid_Medida=="$$$"
                            select A;

               foreach (var item in select)
               {
                   vwRo_Ing_Egr_x_Empleado_Info info = new vwRo_Ing_Egr_x_Empleado_Info();

                   info.IdRubro = item.IdRubro;                                     
                   info.ru_descripcion = item.ru_descripcion;                  
                   info.ru_tipo = item.ru_tipo;
                   info.IdPeriodo = item.IdPeriodo;
                   info.IdNomina_Tipo = item.IdNomina_Tipo;
                   info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.IdNovedad = Convert.ToDecimal(item.IdNovedad);
                   info.SecuenciaNovedad = item.SecuenciaNovedad;
                   info.IdPrestamo = item.IdPrestamo;
                   info.NunCouta = item.NunCouta;
                   info.IngEgr = item.IngEgr;
                   info.Valor = item.Valor;
                   info.iAnio = item.iAnio;
                   info.iMes = item.iMes;
                   info.cerrado = item.cerrado;
                   info.TipoRegistro = item.TipoRegistro;
                   info.observacionesSys = item.observacionesSys;
                   info.Unidad_Medida = item.Unid_Medida;                               
                 
                  lM.Add(info);
                  
               }
               return (lM);
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



       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ing_Egr_x_Empleado_x_Egresos(int IdEmpresa, decimal IdEmpleado, int Idtipo_nomina, int IdProceso, int IdPeriodo)
       {

               List<vwRo_Ing_Egr_x_Empleado_Info> lM = new List<vwRo_Ing_Egr_x_Empleado_Info>();

               EntitiesRoles OERol_Empleado = new EntitiesRoles();
           try
           {
               var select = from A in OERol_Empleado.vwRo_Ing_Egr_x_Empleado

                            where A.IdEmpresa == IdEmpresa && A.IdEmpleado == IdEmpleado && A.IngEgr == "E"
                             && A.IdNomina_Tipo == Idtipo_nomina && A.IdNomina_TipoLiqui == IdProceso && A.IdPeriodo == IdPeriodo
                             && A.Unid_Medida == "$$$"
                            select A;

               foreach (var item in select)
               {
                   //ro_Ing_Egre_x_Empleado_Info info = new ro_Ing_Egre_x_Empleado_Info(); si
                   vwRo_Ing_Egr_x_Empleado_Info info = new vwRo_Ing_Egr_x_Empleado_Info();


                   info.IdRubro = item.IdRubro;
                   
                       info.ru_descripcion = item.ru_descripcion.Trim();
                   

                   info.ru_tipo = item.ru_tipo;
                   info.IdPeriodo = item.IdPeriodo;
                   info.IdNomina_Tipo = item.IdNomina_Tipo;
                   info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.IdNovedad = Convert.ToDecimal(item.IdNovedad);
                   info.SecuenciaNovedad = item.SecuenciaNovedad;
                   info.IdPrestamo = item.IdPrestamo;
                   info.NunCouta = item.NunCouta;
                   info.IngEgr = item.IngEgr;


//                   info.Valor = item.Valor *-1;
                   info.Valor = item.Valor;


                   info.iAnio = item.iAnio;
                   info.iMes = item.iMes;
                   info.cerrado = item.cerrado;
                   info.TipoRegistro = item.TipoRegistro;
                   info.observacionesSys = item.observacionesSys;
                   info.Unidad_Medida = item.Unid_Medida;



                   

             
                   lM.Add(info);

               }
               return (lM);
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


//haac 29/11/2013
       public List<ro_Ing_Egre_x_Empleado_Info> Get_List_PagoBancoEmpleados(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo, decimal IdEmpleado)
       {
               List<ro_Ing_Egre_x_Empleado_Info> lista = new List<ro_Ing_Egre_x_Empleado_Info>();
               EntitiesRoles oEnt = new EntitiesRoles();
           try
           {
               var listado = from C in oEnt.vwRo_Pago_Banco_Empleado

                             where C.IdEmpresa == IdEmpresa && C.IdNomina_Tipo == IdNomina_Tipo && C.IdNomina_TipoLiqui == IdNomina_TipoLiqui && C.IdPeriodo == IdPeriodo

                             && C.IdEmpleado==IdEmpleado

                             select C;

               foreach (var item in listado)
               {
                   ro_Ing_Egre_x_Empleado_Info info = new ro_Ing_Egre_x_Empleado_Info();
                 
                   info.IdEmpresa = IdEmpresa;
                   info.IdEmpleado = IdEmpleado;
                   info.IdNomina_Tipo = IdNomina_Tipo;
                   info.IdNomina_TipoLiqui = IdNomina_TipoLiqui;
                   info.IdPeriodo = IdPeriodo;

                   info.pe_cedulaRuc = item.pe_cedulaRuc;
                   info.pe_nombreCompleto = item.pe_nombreCompleto;
                   info.neto_pagar = Convert.ToDouble(item.neto_pagar);
              
                  lista.Add(info);
               }

               return lista;
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



       public List<vwRo_Ing_Egr_x_Empleado_Info> Get_List_Ro_Ing_Egr_x_Empleado(int IdEmpresa, int IdTipo_nomina, int IdProceso, int IdPeriodo)
       {
               List<vwRo_Ing_Egr_x_Empleado_Info> lM = new List<vwRo_Ing_Egr_x_Empleado_Info>();
           try
           {
               EntitiesRoles OERol_Empleado = new EntitiesRoles();
               var select = from A in OERol_Empleado.vwRo_Total_IngEgr_x_Empleado
                        
                            where A.IdEmpresa == IdEmpresa  && A.totNeto < 0
                            && A.IdNomina_Tipo == IdTipo_nomina && A.IdNomina_TipoLiqui == IdProceso && A.IdPeriodo == IdPeriodo
                            select A;

               foreach (var item in select)
               {
                   vwRo_Ing_Egr_x_Empleado_Info info = new vwRo_Ing_Egr_x_Empleado_Info();

                   info.IdEmpresa = IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.IdNomina_Tipo = IdTipo_nomina;
                   info.IdNomina_TipoLiqui = IdPeriodo;
                   info.IdPeriodo = item.IdPeriodo;
                  
                   info.totIng = Convert.ToDouble(item.totIng);
                   info.totEgr = Convert.ToDouble(item.totEgr);
                   info.totNeto = Convert.ToDouble(item.totNeto);
                   info.NomCompleto = item.NomCompleto;
                   info.cargo = item.cargo;
                   info.departamento = item.departamento;
                   info.em_codigo = item.em_codigo;
                   info.pe_cedulaRuc = item.pe_cedulaRuc;

                   lM.Add(info);

               }
               return (lM);
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



       public List<ro_Ing_Egre_x_Empleado_Info> Get_List_Ing_Egre_x_Empleado(int IdEmpresa, int IdTipo_nomina, int IdProceso, int IdPeriodo)
       {
               List<ro_Ing_Egre_x_Empleado_Info> lM = new List<ro_Ing_Egre_x_Empleado_Info>();
               EntitiesRoles OERol_Empleado = new EntitiesRoles();
           try
           {
               var select = from A in OERol_Empleado.ro_Ing_Egre_x_Empleado

                            where A.IdEmpresa == IdEmpresa && A.IdNomina_Tipo == IdTipo_nomina && A.IdNomina_TipoLiqui == IdProceso && A.IdPeriodo == IdPeriodo
                            select A;

               foreach (var item in select)
               {
                   ro_Ing_Egre_x_Empleado_Info info = new ro_Ing_Egre_x_Empleado_Info();

                 
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.IdNomina_Tipo = item.IdNomina_Tipo;
                   info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   info.IdPeriodo = item.IdPeriodo;

                   info.IdRubro = item.IdRubro;
                   info.IdNovedad = item.IdNovedad;
                   info.SecuenciaNovedad = item.SecuenciaNovedad;
                   info.IdPrestamo = item.IdPrestamo;
                   info.NunCouta = item.NunCouta;                  
                 
                   info.cerrado = item.cerrado;
              
                   lM.Add(info);
               }

               return (lM);
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




       public Boolean GuardarBD(ro_Ing_Egre_x_Empleado_Info info, ref string msg)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   ro_Ing_Egre_x_Empleado item = new ro_Ing_Egre_x_Empleado();
                   item.IdEmpresa = info.IdEmpresa;
                   item.IdEmpleado = info.IdEmpleado;
                   item.IdNomina_Tipo = info.IdNomina_Tipo;
                   item.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                   item.IdPeriodo = info.IdPeriodo;
                   item.IdRubro = info.IdRubro;
                   item.IdNovedad = info.IdNovedad;
                   item.SecuenciaNovedad = info.SecuenciaNovedad;
                   item.IdPrestamo = info.IdPrestamo;
                   item.NunCouta = info.NunCouta;
                   item.IngEgr = info.IngEgr;
                   item.Valor = info.Valor;
                   item.iAnio = info.iAnio;
                   item.iMes = info.iMes;
                   item.cerrado = info.cerrado;
                   item.observacionesSys = info.observacionesSys;
                   item.TipoRegistro = info.TipoRegistro;
                   item.Unid_Medida = info.Unid_Medida;
        

                   db.ro_Ing_Egre_x_Empleado.Add(item);
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
                   db.Database.ExecuteSqlCommand("delete from dbo.ro_Ing_Egre_x_Empleado where IdEmpresa =" + idEmpresa.ToString()
                      + " AND IdNomina_Tipo=" + idNomina.ToString()
                      + " AND IdNomina_TipoLiqui=" + idNominaLiqui.ToString()
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
    }
}
