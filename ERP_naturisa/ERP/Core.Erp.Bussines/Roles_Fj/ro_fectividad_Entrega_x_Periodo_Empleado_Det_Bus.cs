using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.Roles_Fj
{
   public class ro_fectividad_Entrega_x_Periodo_Empleado_Det_Bus
   {
       string MensajeError = "";
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       ro_fectividad_Entrega_x_Periodo_Empleado_Det_Data data = new ro_fectividad_Entrega_x_Periodo_Empleado_Det_Data();
       public bool Guardar_DB(List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista)
       {
           try
           {

               return data.Guardar_DB(lista);
              
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

       public bool Modificar_DB(List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista)
       {
           try
           {
               return data.Modificar_DB(lista);

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

       public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado(int IdEmpresa, int idnomina_tipo, int IdPeriodo,int idefectividad)
       {
           try
           {
               return data.lista_efectividad_x_periodo_x_empleado(IdEmpresa, idnomina_tipo, IdPeriodo, idefectividad);
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

       public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
       {
           try
           {
               return data.lista_efectividad_x_periodo_x_empleado(IdEmpresa, idnomina_tipo, IdPeriodo);
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

       public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_planificada(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
       {
           try
           {
               return data.lista_planificada(IdEmpresa, idnomina_tipo, IdPeriodo);  
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
       public List<ro_fectividad_Entrega_x_Periodo_Empleado_Det_Info> lista_efectividad_x_periodo_x_empleado_pagos_Adm(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
       {
           try
           {
               return data.lista_efectividad_x_periodo_x_empleado_pagos_Adm(IdEmpresa, idnomina_tipo, IdPeriodo);
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
