using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using System.Data.Entity.Validation;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Roles_Fj
{
  public  class ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Data
    {
      string mensaje = "";
      public bool GuardarDB(ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info info)
      {
          try
          {


              using (EntityRoles_FJ db= new EntityRoles_FJ())
              {

                  ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar add = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar();
                  add.IdEmpleado = info.IdEmpleado;
                  add.IdNomina_Tipo = info.IdNomina;
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdRegistro = info.IdRegistro;
                  add.IdRubro = info.IdRubro;
                  add.es_fecha_registro = info.es_fecha_registro;
                  add.Num_horasExtras = info.Num_horasExtras;
                  add.Observacion = info.Observacion;
                  add.Estado_aprobacion = false;
                  db.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.Add(add);
                  db.SaveChanges();
                  return true;
              }

          }
          catch (DbEntityValidationException ex)
          {

              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> Get_lista_horas_extras_x_aproba(int IdEmpresa, DateTime Fechainicio, DateTime FechaFin)
      {
          try
          {
              List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> lista = new List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info>();

              using (EntityRoles_FJ db= new EntityRoles_FJ())
              {
                  var query = from q in db.vwro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar
                              where q.IdEmpresa==IdEmpresa
                              && q.es_fecha_registro>=Fechainicio
                              && q.es_fecha_registro<=FechaFin
                              && q.Estado_aprobacion==false
                              select q;


                  foreach (var item in query)
                  {
                      ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info info = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info();
                      info.IdEmpresa=item.IdEmpresa;
                      info.IdEmpleado = item.IdEmpleado;
                      info.es_fecha_registro = item.es_fecha_registro;
                      info.IdRegistro = item.IdRegistro;
                      info.IdRubro = item.IdRubro;
                      info.Observacion = item.Observacion;
                      info.Estado_aprobacion = item.Estado_aprobacion;
                      info.Num_horasExtras = item.Num_horasExtras;

                      info.ru_descripcion =item.ru_descripcion;
                      info. ca_descripcion=item.ca_descripcion;
                      info.de_descripcion =item.de_descripcion;
                      info.pe_apellido = item.pe_apellido;
                      info.pe_nombre =item.pe_nombre;
                      info. pe_cedulaRuc =item.pe_cedulaRuc;
                      info.Calculo_Horas_extras_Sobre = item.Calculo_Horas_extras_Sobre;
                      info.Max_num_horas_sab_dom = item.Max_num_horas_sab_dom;
                      info.SueldoActual = item.SueldoActual;
                      info.IdTipoNomina = item.IdTipoNomina;
                      lista.Add(info);

                  }
              }

              return lista;
          }
          catch (DbEntityValidationException ex)
          {
              
             string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public bool ModificarDB(List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db= new EntityRoles_FJ())
              {

                  foreach (var item in lista)
                  {
                      var modifi = db.ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar.FirstOrDefault(v => v.IdEmpresa == item.IdEmpresa && v.IdEmpleado == item.IdEmpleado && v.IdRegistro == item.IdRegistro);
                      if (modifi != null)
                      {
                          modifi.Estado_aprobacion = true;
                          db.SaveChanges();
                      }
                  }

              }

              return true;
             
          }
          catch (DbEntityValidationException ex)
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
