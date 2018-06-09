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
  public  class ro_planificacion_x_ruta_x_empleado_det_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(List< ro_planificacion_x_ruta_x_empleado_det_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  foreach (var info in lista)
                  {
                  ro_planificacion_x_ruta_x_empleado_det add = new ro_planificacion_x_ruta_x_empleado_det();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdNomina_Tipo = info.IdNomina_Tipo;
                  add.IdNomina_Tipo_Liq = info.IdNomina_Tipo_Liq;
                  add.IdEmpleado = info.IdEmpleado;
                  add.IdPeriodo = info.IdPeriodo;
                  if (info.IdPlaca == 0)

                      add.IdPlaca = null;
                  else
                      add.IdPlaca = info.IdPlaca;
                      if(info.IdRuta==0)
                  add.IdRuta = null;
                      else
                          add.IdRuta = info.IdRuta;
                    if(info.IdFuerza==0)
                  add.IdFuerza = null;
                      else
                        add.IdFuerza = info.IdFuerza;
                      if(info.IdZona==0)
                  add.IdZona = null;
                      else
                          add.IdZona = info.IdZona;
                if(info.IdDisco==0)
                  add.IdDisco = null;
                      else
                 add.IdDisco = info.IdDisco;

                  add.Observacion = info.Observacion;
                  db.ro_planificacion_x_ruta_x_empleado_det.Add(add);
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

      public bool Modificar_DB(List<ro_planificacion_x_ruta_x_empleado_det_Info> lista)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {


                  foreach (var info in lista)
                  {

                      db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_planificacion_x_ruta_x_empleado_det where IdEmpresa='" + info.IdEmpresa + "' and IdNomina_Tipo='" + info.IdNomina_Tipo + "' and IdEmpleado='" + info.IdEmpleado + "' and IdPeriodo='" + info.IdPeriodo + "' and IdNomina_Tipo_Liq='"+info.IdNomina_Tipo_Liq+"' ");
                      ro_planificacion_x_ruta_x_empleado_det add = new ro_planificacion_x_ruta_x_empleado_det();
                      add.IdEmpresa = info.IdEmpresa;
                      add.IdNomina_Tipo = info.IdNomina_Tipo;
                      add.IdNomina_Tipo_Liq = info.IdNomina_Tipo_Liq;
                      add.IdEmpleado = info.IdEmpleado;
                      add.IdPeriodo = info.IdPeriodo;
                      add.IdPlaca = info.IdPlaca;
                      add.IdRuta = info.IdRuta;
                      add.IdFuerza = info.IdFuerza;
                      add.IdZona = info.IdZona;
                      add.IdDisco = info.IdDisco;
                      add.Observacion = info.Observacion;
                      db.ro_planificacion_x_ruta_x_empleado_det.Add(add);
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

      public List<ro_planificacion_x_ruta_x_empleado_det_Info> get_lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
      {
          try
          {
              List<ro_planificacion_x_ruta_x_empleado_det_Info> lista = new List<ro_planificacion_x_ruta_x_empleado_det_Info>();

              int idperio =0;

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
               var sel= (from s in Context.ro_planificacion_x_ruta_x_empleado
                           where s.IdEmpresa == IdEmpresa
                              && s.IdNomina_Tipo == idnomina_tipo
                           select s.IdPeriodo);
               if (sel.Count() > 0)
                   idperio = sel.Max();
              }


              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  IQueryable<vwro_planificacion_x_ruta_entrega_x_empleado> contact;

                  if (idperio > 0)
                  {
                      contact = from q in Context.vwro_planificacion_x_ruta_entrega_x_empleado
                                where q.IdEmpresa == IdEmpresa
                                && q.IdTipoNomina == idnomina_tipo
                                && q.IdPeriodo == idperio
                                select q;
                  }

                  else
                  {
                      contact = from q in Context.vwro_planificacion_x_ruta_entrega_x_empleado
                                where q.IdEmpresa == IdEmpresa
                                && q.IdTipoNomina == idnomina_tipo
                                select q;
                  }


                  foreach (var item in contact)
                  {
                      ro_planificacion_x_ruta_x_empleado_det_Info Info = new ro_planificacion_x_ruta_x_empleado_det_Info();
                      Info.IdEmpresa =Convert.ToInt32( item.IdEmpresa);
                      Info.IdNomina_Tipo = Convert.ToInt32(item.IdTipoNomina);
                      Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                      if (item.IdPeriodo != null)
                          Info.IdPeriodo =Convert.ToInt32( item.IdPeriodo);
                      if (item.IdFuerza != null)
                          Info.IdFuerza = Convert.ToInt32(item.IdFuerza);
                      if (item.IdZona != null)
                          Info.IdZona = Convert.ToInt32(item.IdZona);
                      if (item.IdPlaca != null)
                          Info.IdPlaca = Convert.ToInt32(item.IdPlaca);
                      if (item.IdDisco != null)
                          Info.IdDisco = Convert.ToInt32(item.IdDisco);
                      if (item.IdPeriodo != null)
                          Info.IdRuta = Convert.ToInt32(item.IdRuta);
                      Info.pe_nombreCompleto = item.pe_nombreCompleto;
                      Info.de_descripcion = item.de_descripcion;
                      Info.ca_descripcion = item.ca_descripcion;


                      Info.icono_eliminar = true;
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
      public List<ro_planificacion_x_ruta_x_empleado_det_Info> lista_planificacion(int IdEmpresa, int idnomina_tipo, int IdPeriodo)
      {
          try
          {
              List<ro_planificacion_x_ruta_x_empleado_det_Info> lista = new List<ro_planificacion_x_ruta_x_empleado_det_Info>();

             
              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  
                   var   contact = from q in Context.vwro_planificacion_x_ruta_entrega_x_empleado
                                where q.IdEmpresa == IdEmpresa
                                && q.IdTipoNomina == idnomina_tipo
                                && q.IdPeriodo==IdPeriodo
                                select q;
                  
                  foreach (var item in contact)
                  {
                      ro_planificacion_x_ruta_x_empleado_det_Info Info = new ro_planificacion_x_ruta_x_empleado_det_Info();
                      Info.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                      Info.IdNomina_Tipo = Convert.ToInt32(item.IdTipoNomina);
                      Info.IdEmpleado = Convert.ToInt32(item.IdEmpleado);
                      if (item.IdPeriodo != null)
                          Info.IdPeriodo = Convert.ToInt32(item.IdPeriodo);
                      if (item.IdFuerza != null)
                          Info.IdFuerza = Convert.ToInt32(item.IdFuerza);
                      if (item.IdZona != null)
                          Info.IdZona = Convert.ToInt32(item.IdZona);
                      if (item.IdPlaca != null)
                          Info.IdPlaca = Convert.ToInt32(item.IdPlaca);
                      if (item.IdDisco != null)
                          Info.IdDisco = Convert.ToInt32(item.IdDisco);
                      if (item.IdRuta != null)
                          Info.IdRuta = Convert.ToInt32(item.IdRuta);
                      Info.pe_nombreCompleto = item.pe_nombreCompleto;
                      Info.de_descripcion = item.de_descripcion;
                      Info.ca_descripcion = item.ca_descripcion;


                      Info.icono_eliminar = true;
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
