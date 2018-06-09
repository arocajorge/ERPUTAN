using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles_Fj
{
  public  class ro_Grupo_empleado_det_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(List<ro_Grupo_empleado_det_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var item in lista)
                  {
                    ro_Grupo_empleado_det add = new ro_Grupo_empleado_det();
                  add.IdEmpresa = item.IdEmpresa;
                  add.IdGrupo =item.IdGrupo;
                  add.cod_Pago_Variable = item.cod_Pago_Variable;
                  //add.Valor = item.Valor;
                //  add.Observacion = item.Observacion;
                  db.ro_Grupo_empleado_det.Add(add);
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
     

      public bool eliminarDB(int IdEmpresa, int IdGrupo)
      {
          try
          {
              using (EntityRoles_FJ db= new EntityRoles_FJ())
              {
                  db.Database.ExecuteSqlCommand("Delete Fj_servindustrias.ro_Grupo_empleado_det where IdEmpresa='" + IdEmpresa + "' and IdGrupo='" + IdGrupo + "'");
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
      public bool Modificar_DB(List<ro_Grupo_empleado_det_Info> lista)
      {
          try
          {
              int sec = 0;
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {

                  foreach (var info in lista)
                  {
                      if (sec == 0)
                          db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_Grupo_empleado_det where IdEmpresa='" + info.IdEmpresa + "' and IdGrupo='" + info.IdGrupo + "' ");
                      sec++;
                      ro_Grupo_empleado_det add = new ro_Grupo_empleado_det();
                      add.IdEmpresa = info.IdEmpresa;
                      add.IdGrupo = info.IdGrupo;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Porcentaje_calculo = info.Porcentaje_calculo;
                      db.ro_Grupo_empleado_det.Add(add);
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



      public List<ro_Grupo_empleado_det_Info> Get_lista(int IdEmpresa, int IdGrupo)
      {
          try
          {
              List<ro_Grupo_empleado_det_Info> lista = new List<ro_Grupo_empleado_det_Info>();

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {

                  var contact = from q in Context.ro_Grupo_empleado_det
                                where q.IdEmpresa == IdEmpresa
                                && q.IdGrupo == IdGrupo
                                select q;

                  foreach (var info in contact)
                  {
                      ro_Grupo_empleado_det_Info add = new ro_Grupo_empleado_det_Info();
                      add.IdEmpresa = info.IdEmpresa;
                      add.IdGrupo = info.IdGrupo;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Porcentaje_calculo = info.Porcentaje_calculo;
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

      public List<ro_Grupo_empleado_det_Info> Get_lista(int IdEmpresa)
      {
          try
          {
              List<ro_Grupo_empleado_det_Info> lista = new List<ro_Grupo_empleado_det_Info>();

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {

                  var contact = from q in Context.vwro_Grupo_empleado_det
                                where q.IdEmpresa == IdEmpresa
                                select q;

                  foreach (var info in contact)
                  {
                      ro_Grupo_empleado_det_Info add = new ro_Grupo_empleado_det_Info();
                      add.IdEmpresa = info.IdEmpresa;
                      add.IdGrupo = info.IdGrupo;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.Porcentaje_calculo = info.Porcentaje_calculo;
                      add.cod_Pago_Variable = info.cod_Pago_Variable;
                      add.cod_Pago_Variable_enum = (ero_parametro_x_pago_variable_tipo)Enum.Parse(typeof(ero_parametro_x_pago_variable_tipo), info.cod_Pago_Variable);
                      add.Valor_bono = info.Valor_bono;
                      add.IdRubro=info.IdRubro;
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

