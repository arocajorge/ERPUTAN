using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.SqlClient;
namespace Core.Erp.Data.Roles_Fj
{
  public  class ro_parametro_x_pago_variable_Det_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(List<ro_parametro_x_pago_variable_Det_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var info in lista)
                  {
                      ro_parametro_x_pago_variable_Det add = new ro_parametro_x_pago_variable_Det();
                      add.Idempresa = info.Idempresa;
                      add.IdNomina_Tipo = info.IdNomina_Tipo;
                      add.Id_Tipo_Pago_Variable = info.Id_Tipo_Pago_Variable;
                      add.Meta = info.Meta;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Variable_porcentaje_prorrateado = info.Variable_porcentaje_prorrateado;
                      db.ro_parametro_x_pago_variable_Det.Add(add);
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

      public bool Modificar_DB(List<ro_parametro_x_pago_variable_Det_Info> lista)
      {
          try
          {
              int sec = 0;
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {

                  foreach (var info in lista)
                  {
                      if (sec == 0)
                          db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_parametro_x_pago_variable_Det where IdEmpresa='" + info.Idempresa + "' and Id_Tipo_Pago_Variable='" + info.Id_Tipo_Pago_Variable + "' and IdNomina_Tipo='"+info.IdNomina_Tipo+"'");
                      sec++;
                      ro_parametro_x_pago_variable_Det add = new ro_parametro_x_pago_variable_Det();
                      add.Idempresa = info.Idempresa;
                      add.IdNomina_Tipo = info.IdNomina_Tipo;
                      add.Id_Tipo_Pago_Variable = info.Id_Tipo_Pago_Variable;
                      add.Meta = info.Meta;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Variable_porcentaje_prorrateado = info.Variable_porcentaje_prorrateado;
                      db.ro_parametro_x_pago_variable_Det.Add(add);
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

      public List<ro_parametro_x_pago_variable_Det_Info> Get_lista_oaram_pago_variable(int IdEmpresa, int IdNomina_tipo, int Id_Tipo_Pago_Variable)
      {
          try
          {
              List<ro_parametro_x_pago_variable_Det_Info> lista = new List<ro_parametro_x_pago_variable_Det_Info>();

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {

                  var contact = from q in Context.ro_parametro_x_pago_variable_Det
                                where q.Idempresa == IdEmpresa
                                && q.Id_Tipo_Pago_Variable == Id_Tipo_Pago_Variable
                                && q.IdNomina_Tipo==IdNomina_tipo
                                select q;

                  foreach (var info in contact)
                  {
                      ro_parametro_x_pago_variable_Det_Info add = new ro_parametro_x_pago_variable_Det_Info();
                      add.Idempresa = info.Idempresa;
                      add.IdNomina_Tipo = info.IdNomina_Tipo;
                      add.Id_Tipo_Pago_Variable = info.Id_Tipo_Pago_Variable;
                      add.Meta = Convert.ToDouble(info.Meta);
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Variable_porcentaje_prorrateado = Convert.ToDouble(info.Variable_porcentaje_prorrateado);
                      add.icono_eliminar = true;
                      lista.Add(add);
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
