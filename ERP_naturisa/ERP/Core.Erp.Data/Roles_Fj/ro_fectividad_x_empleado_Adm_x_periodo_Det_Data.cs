using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles_Fj
{
   public class ro_fectividad_x_empleado_Adm_x_periodo_Det_Data
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       public bool Guardar_DB(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista)
       {
           try
           {
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   foreach (var info in lista)
                   {
                       ro_fectividad_x_empleado_Adm_x_periodo_Det add = new ro_fectividad_x_empleado_Adm_x_periodo_Det();
                       add.IdEmpresa = info.IdEmpresa;
                       add.IdNomina_Tipo = info.IdNomina_Tipo;
                       add.IdEmpleado = info.IdEmpleado;
                       add.IdNomina_Tipo_Liq = info.IdNomina_Tipo_Liq;
                       add.IdPeriodo = info.IdPeriodo;
                       add.cod_Pago_Variable = info.cod_Pago_Variable;
                       add.Meta = info.Meta;
                       add.Real = info.Real;
                       add.Cumplimiento = info.Cumplimiento;
                       add.Variable_porcentaje_prorrateado = info.Variable_porcentaje_prorrateado;
                       db.ro_fectividad_x_empleado_Adm_x_periodo_Det.Add(add);
                       db.SaveChanges();
                   }
                   return true;





               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public bool Modificar_DB(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista)
       {
           try
           {
               int secuencia = 0;
               using (EntityRoles_FJ db = new EntityRoles_FJ())
               {
                   foreach (var info in lista)
                   {
                       if(secuencia==0)
                       db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_fectividad_x_empleado_Adm_x_periodo_Det where IdEmpresa='" + info.IdEmpresa + "' and IdNomina_Tipo='" + info.IdNomina_Tipo + "'  and IdPeriodo='" + info.IdPeriodo + "' and IdNomina_Tipo_Liq='" + info.IdNomina_Tipo_Liq + "' ");
                       ro_fectividad_x_empleado_Adm_x_periodo_Det add = new ro_fectividad_x_empleado_Adm_x_periodo_Det();
                       add.IdEmpresa = info.IdEmpresa;
                       add.IdNomina_Tipo = info.IdNomina_Tipo;
                       add.IdNomina_Tipo_Liq = info.IdNomina_Tipo_Liq;
                       add.IdEmpleado = info.IdEmpleado;
                       add.IdPeriodo = info.IdPeriodo;
                       add.cod_Pago_Variable = info.cod_Pago_Variable;
                       add.Meta = info.Meta;
                       add.Real = info.Real;
                       add.Cumplimiento = info.Cumplimiento;

                       add.Variable_porcentaje_prorrateado = info.Variable_porcentaje_prorrateado;
                       db.ro_fectividad_x_empleado_Adm_x_periodo_Det.Add(add);
                       db.SaveChanges();
                       secuencia++;
                   }
                   return true;





               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_Efectividad_x_empleado_x_periodod(int IdEmpresa, int idnomina_tipo, int IdNominaTipo_Liq, int IdPeriodo)
       {
           try
           {
               List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista = new List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>();


               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {

                   var contact = from q in Context.vwro_fectividad_x_empleado_Adm_x_periodo_Det
                                 where q.IdEmpresa == IdEmpresa
                                 && q.IdNomina_Tipo == idnomina_tipo
                                 && q.IdNomina_Tipo_Liq == IdNominaTipo_Liq
                                 && q.IdPeriodo == IdPeriodo

                                 select q;

                   foreach (var item in contact)
                   {
                       ro_fectividad_x_empleado_Adm_x_periodo_Det_Info Info = new ro_fectividad_x_empleado_Adm_x_periodo_Det_Info();
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdNomina_Tipo = item.IdNomina_Tipo;
                       Info.IdNomina_Tipo_Liq = item.IdNomina_Tipo_Liq;
                       Info.IdEmpleado = item.IdEmpleado;
                       Info.IdPeriodo = item.IdPeriodo;
                       Info.cod_Pago_Variable = item.cod_Pago_Variable;
                       Info.Meta = item.Meta;
                       Info.Real = item.Real;
                       Info.Cumplimiento = item.Cumplimiento;
                       Info.Variable_porcentaje_prorrateado = item.Variable_porcentaje_prorrateado;


                       Info.Variable_porcentaje_prorrateado = item.Variable_porcentaje_prorrateado;
                       Info.Valor_bono = item.Valor_bono;
                       Info.ru_descripcion = item.ru_descripcion;
                       Info.pe_nombre = item.pe_nombre;
                       Info.pe_apellido = item.pe_apellido;
                       Info.pe_NombreCompleto = item.pe_apellido + " " + item.pe_nombre;

                       Info.cod_Pago_Variable_enum = (ero_parametro_x_pago_variable_tipo)Enum.Parse(typeof(ero_parametro_x_pago_variable_tipo), item.cod_Pago_Variable);



                       lista.Add(Info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       public List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista_Efectividad_x_empleado_x_periodod(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodod)
       {
           try
           {
               List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista = new List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info>();


               using (EntityRoles_FJ Context = new EntityRoles_FJ())
               {

                   var contact = from q in Context.spro_calculo_pocentajes_pago_variable_Adm(info_periodod.IdEmpresa,info_periodod.pe_FechaIni,info_periodod.pe_FechaFin,info_periodod.IdNomina_Tipo,info_periodod.IdPeriodo)                                 

                                 select q;

                   foreach (var item in contact)
                   {
                       ro_fectividad_x_empleado_Adm_x_periodo_Det_Info Info = new ro_fectividad_x_empleado_Adm_x_periodo_Det_Info();
                       Info.IdEmpresa = item.Idempresa;
                       Info.IdNomina_Tipo = item.IdNomina_Tipo;
                       Info.IdEmpleado = item.IdEmpleado;
                       Info.cod_Pago_Variable = item.cod_Pago_Variable;
                       Info.Meta = item.Meta;
         
                       Info.Variable_porcentaje_prorrateado = item.Variable_porcentaje_prorrateado;
                       Info.Valor_bono = item.Valor_bono;
                       Info.ru_descripcion = item.ru_descripcion;
                       Info.pe_nombre = item.pe_nombre;
                       Info.pe_apellido = item.pe_apellido;
                       Info.IdRubro = item.IdRubro;

                       Info.cod_Pago_Variable_enum = (ero_parametro_x_pago_variable_tipo)Enum.Parse(typeof(ero_parametro_x_pago_variable_tipo), item.cod_Pago_Variable);

                       Info.pe_NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                       Info.cantidad_empleados_nuevos = item.cantidad_empleados_nuevos;
                       Info.cantidad_empleados_salieron = item.cantidad_empleados_salieron;
                       Info.cantidad_empleados_activos = item.cantidad_empleados_activos;
                       Info.Total_Faltas = item.Total_Faltas;
                       Info.Total_Asistencia = item.Total_Asistencia;
                       Info.efectividad_entrega = item.efectividad_entrega;
                       Info.efectividad_volumen = item.efectividad_volumen;
                       Info.recuperacion_cartera = item.recuperacion_cartera;                   
                    
                       lista.Add(Info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

    }
}
