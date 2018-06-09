using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
  public  class ro_Pago_decimos_x_Empleado_Data
  {
      string mensaje = "";
      public List<ro_Pago_decimos_x_Empleado_Info> GetLisDecimo(int IdEmpresa, int IdRubro, DateTime FechaI, DateTime FechaF)
      {
          try
          {
              List<ro_Pago_decimos_x_Empleado_Info> ListaDecimos = new List<ro_Pago_decimos_x_Empleado_Info>();

         

              using (EntitiesRoles context = new EntitiesRoles())
              {
                  EntitiesRoles Entitie = new EntitiesRoles();


                  var select = from A in Entitie.spROL_Archivo_MTE(IdEmpresa,FechaI,FechaF,IdRubro )
                            
                             select A;
                  foreach (var item in select)
                  {
                  ro_Pago_decimos_x_Empleado_Info info = new ro_Pago_decimos_x_Empleado_Info();
                  info.IdEmpresa = item.IdEmpresa;
                  info.IdEmpleado = item.IdEmpleado;
                  info.apellidos = item.pe_apellido;
                  info.nombres = item.pe_nombre;
                  info.cedula = item.pe_cedulaRuc;
                  info.TipoPago="";
                  info.diasLaborados =(int) item.DiasA_considerar_Decimo;
                  info.retencion_Pago_Directo = "";
                  info.ocupacion = item.ca_descripcion;
                  info.codigoIESS = item.CodigoSectorial;
                  info.Total_ganado = Math.Round(Convert.ToDouble(  item.Valor),2);
                  info.DiasFaltados = item.TotalDiasF;
                  if (item.pe_sexo == "SEXO_MAS")
                  {
                      info.genero = "M";
                  }
                  else
                  {
                      info.genero = "F";
                  }
                  info.TipoPago = "P";

                  ListaDecimos.Add(info);
              }
                  return ListaDecimos;
              }

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
