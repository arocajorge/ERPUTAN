using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Roles;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_fectividad_x_empleado_Adm_x_periodo_Det_Bus
   {
       string mensaje = "";
       ro_fectividad_x_empleado_Adm_x_periodo_Det_Data data = new ro_fectividad_x_empleado_Adm_x_periodo_Det_Data();
       public bool Guardar_DB(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista)
       {
           try
           {
               return data.Guardar_DB(lista);
           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
               
               
           }
       }
       
       public bool Modificar_DB(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista)
       {
           try
           {

               return data.Modificar_DB(lista);
               
           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
               
              
           }
       }

       public List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_Efectividad_x_empleado_x_periodod(int IdEmpresa, int idnomina_tipo, int IdNominaTipo_Liq, int IdPeriodo)
       {
           try
           {
               return data.lista_Efectividad_x_empleado_x_periodod(IdEmpresa, idnomina_tipo, IdNominaTipo_Liq, IdPeriodo);

           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
               
           }
       }
       public List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_Efectividad_x_empleado_x_periodod(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo)
       {
           try
           {
               return Calcular(data.lista_Efectividad_x_empleado_x_periodod(info_periodo),info_periodo);
           }
           catch (Exception ex)
           {
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);

           }
       }


       private int Get_Dias_efectivos(DateTime fecha_inicio, DateTime fecha_fin)
       {
           try
           {
               int dias_efectivos = 0;
               while (fecha_inicio<=fecha_fin)
               {

                   if (fecha_inicio.DayOfWeek != 0)
                       dias_efectivos ++;
                 fecha_inicio=  fecha_inicio.AddDays(1);
               }

               return dias_efectivos;
           }
           catch (Exception ex)
           {
               
              mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }


       public List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> Calcular(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista, ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo)
       {
           try
           {
               List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_tmp = new List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>();
               // cargo todos los porcentales de recuperacion de cartera, efectividad entrega, efectividad de volumen de los APP, VPP
               ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus bus_fectividad_entrega = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus();
               List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_entrega = new List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info>();
               lista_efectividad_entrega = bus_fectividad_entrega.lista_efectividad_x_periodo_x_empleado_pagos_Adm(info_periodo.IdEmpresa, info_periodo.IdNomina_Tipo, info_periodo.IdPeriodo);

               //cargo los empleados que tienen zonas asignadas para el calculo de la variable
               ro_empleado_x_rutas_asignadas_Det_Bus bus_emplado_x_zona = new ro_empleado_x_rutas_asignadas_Det_Bus();
               List<ro_empleado_x_rutas_asignadas_Det_Info> lista_empleados_x_zonas = new List<ro_empleado_x_rutas_asignadas_Det_Info>();
               lista_empleados_x_zonas = bus_emplado_x_zona.lista_paramatrso_x_empleados(info_periodo.IdEmpresa, info_periodo.IdNomina_Tipo);

               lista_tmp = lista;
               foreach (var item in lista_tmp)
               {
                   double valor = 0;





                   #region calculo para el pago de variable del Jefe RR AUS_LABOR,ROT_PERSO,REV_NOM
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.AUS_LABOR)//AUSENTISMO LABORAL
                   {
                       if (item.Total_Faltas == 0)
                       {
                           item.valor_ganado = Convert.ToDecimal(item.Variable_porcentaje_prorrateado * item.Valor_bono);
                           item.Cumplimiento = 1;
                           item.Real = 1;
                       }
                       else
                       {

                           valor = Convert.ToDouble(item.Total_Faltas / (item.cantidad_empleados_activos * Get_Dias_efectivos(info_periodo.pe_FechaIni, info_periodo.pe_FechaFin)));
                           item.Cumplimiento = item.Meta / valor;
                       }
                   }

                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.ROT_PERSO)// ROTACION DE PERSONAL
                   {
                       item.Real = (item.cantidad_empleados_salieron - item.cantidad_empleados_nuevos) / item.cantidad_empleados_activos;
                       if (item.Real == 0)
                       {
                           item.Real = 1;
                           item.Cumplimiento = 1;
                           item.valor_ganado = Convert.ToDecimal(item.Variable_porcentaje_prorrateado * item.Valor_bono);
                       }
                       else
                       {
                           item.Cumplimiento = (item.Real / item.Meta) * 100;
                           item.valor_ganado = Convert.ToDecimal(item.Variable_porcentaje_prorrateado * item.Valor_bono);
                       }
                   }
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.REV_NOM)//  REVISION DE NOMINA AL CIERRE
                   {
                       item.valor_ganado = Convert.ToDecimal(item.Variable_porcentaje_prorrateado * item.Valor_bono);
                       item.Cumplimiento = 1;
                       item.Real = 1;
                   }
                   #endregion








                   #region calculo para el pago de variable EFEC_ENTRE
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.EFEC_ENTRE)
                   {
                       foreach (var item_emp_x_zona in lista_empleados_x_zonas.Where(v=>v.IdNomina_Tipo==item.IdNomina_Tipo&& v.IdEmpleado==item.IdEmpleado))
                       {
                           if (item.IdEmpleado == item_emp_x_zona.IdEmpleado && item_emp_x_zona.IdNomina_Tipo == item.IdNomina_Tipo)
                           {
                              // item.Real = 0;
                             //  item.Real = item.Real + lista_efectividad_entrega.Where(v => v.IdZona==item_emp_x_zona.id_ruta).Sum(v => v.Efectividad_Entrega);
                           }
                       }

                       item.Cumplimiento = item.Real / item.Meta;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }
                   #endregion


                   #region calculo para el pago de variable EFEC_VOL
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.EFEC_VOL)
                   {
                       foreach (var item_emp_x_zona in lista_empleados_x_zonas.Where(v => v.IdNomina_Tipo == item.IdNomina_Tipo && v.IdEmpleado == item.IdEmpleado))
                       {
                           if (item.IdEmpleado == item_emp_x_zona.IdEmpleado && item_emp_x_zona.IdNomina_Tipo == item.IdNomina_Tipo)
                           {
                              // item.Real = 0;
                              // item.Real = item.Real + lista_efectividad_entrega.Where(v => v.IdZona == item_emp_x_zona.id_ruta).Sum(v => v.Efectividad_Volumen);
                           }
                       }

                       item.Cumplimiento = item.Real / item.Meta;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }

                   #endregion


                   #region calculo para el pago de variable REC_CAR
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.REC_CAR)
                   {
                       foreach (var item_emp_x_zona in lista_empleados_x_zonas.Where(v => v.IdNomina_Tipo == item.IdNomina_Tipo && v.IdEmpleado == item.IdEmpleado))
                       {
                           if (item.IdEmpleado == item_emp_x_zona.IdEmpleado && item_emp_x_zona.IdNomina_Tipo == item.IdNomina_Tipo)
                           {
                              // item.Real = 0;
                              // item.Real = item.Real + lista_efectividad_entrega.Where(v => v.IdZona == item_emp_x_zona.id_ruta).Sum(v => v.Recuperacion_cartera);
                           }
                       }

                       item.Cumplimiento = item.Real / item.Meta;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }




                   

                   #endregion



                   #region calculo para el pago de variable SER_CLI
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.SER_CLI)
                   {
                      
                       item.Cumplimiento = item.Real / item.Meta;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }
                   #endregion
                   #region calculo para el pago de variable RENDI_COMB
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.RENDI_COMB)
                   {

                       if (item.Meta > item.Real)
                       {
                           item.Cumplimiento = 1 - ((item.Real / item.Meta) -1);
                       }
                       else
                           item.Cumplimiento = 1;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }

                   #endregion





                   #region calculo para el pago de variable COST_MANT
                   if (item.cod_Pago_Variable_enum == ero_parametro_x_pago_variable_tipo.COST_MANT)
                   {

                       if (item.Meta > item.Real)
                       {
                           item.Cumplimiento = 1 - ((item.Real / item.Meta) - 1);
                       }
                       else
                        item.Cumplimiento = 1;
                       item.valor_ganado = Convert.ToDecimal(item.Valor_bono * item.Variable_porcentaje_prorrateado * item.Real);

                   }

                   #endregion

               }











               return lista_tmp;

           }
           catch (Exception ex)
           {

               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
    }
}
