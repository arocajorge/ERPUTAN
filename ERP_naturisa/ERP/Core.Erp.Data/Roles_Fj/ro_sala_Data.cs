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
  public  class ro_sala_Data
  {
      string mensaje = "";

      public List<ro_sala_Info> Get_List_sala(int IdEmpresa)
      {
          List<ro_sala_Info> list_Ruta = new List<ro_sala_Info>();
          try
          {
              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  var contact = from q in Context.ro_sala
                                where q.IdEmpresa == IdEmpresa
                                select q;

                  foreach (var item in contact)
                  {
                      ro_sala_Info Info = new ro_sala_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdSala = item.IdSala;
                      Info.Sala = item.Sala;
                      Info.Estado = item.Estado;
                     
                      list_Ruta.Add(Info);
                  }
              }
              return list_Ruta;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<ro_sala_Info> Get_List_sala(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
      {
          try
          {
              DateTime Fecha_Ini = Convert.ToDateTime(FechaIni.ToShortDateString());
              DateTime Fecha_Fin = Convert.ToDateTime(FechaFin.ToShortDateString());
              List<ro_sala_Info> list_Ruta = new List<ro_sala_Info>();

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  var lst = from q in Context.ro_sala
                            where q.IdEmpresa == IdEmpresa
                            && q.Fecha_Transaccion >= Fecha_Ini
                            && q.Fecha_Transaccion <= Fecha_Fin
                            select q;

                  foreach (var item in lst)
                  {
                      ro_sala_Info Info = new ro_sala_Info();
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdSala = item.IdSala;
                      Info.Sala = item.Sala;
                      Info.Estado = item.Estado;
                      list_Ruta.Add(Info);
                  }
              }
              return list_Ruta;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public ro_sala_Info Get_Info_sala(int IdEmpresa, int idsala)
      {
          try
          {
              ro_sala_Info Info = new ro_sala_Info();
              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  var contact = from q in Context.ro_sala
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSala == idsala
                                select q;

                  foreach (var item in contact)
                  {
                      Info.IdEmpresa = item.IdEmpresa;
                      Info.IdSala = item.IdSala;
                      Info.Sala = item.Sala;
                      Info.Estado = item.Estado;
                      Info.ip = item.ip;
                  }
              }
              return Info;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public int Get_Id(int IdEmpresa)
      {
          try
          {
              int Id;
              EntityRoles_FJ db = new EntityRoles_FJ();
              var selecte = db.ro_sala.Count(q => q.IdEmpresa == IdEmpresa);
              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in db.ro_sala
                                   where q.IdEmpresa == IdEmpresa
                                   select q.IdSala).Max();
                  Id = Convert.ToInt32(select_em.ToString()) + 1;
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool GuardarDB(ro_sala_Info Info, ref int IdRuta, ref string mensaje)
      {
          try
          {
              IdRuta = Get_Id(Info.IdEmpresa);

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  ro_sala contact = new ro_sala();

                  contact.IdEmpresa = Info.IdEmpresa;
                  contact.IdSala = Get_Id(Info.IdEmpresa);
                  contact.Sala = Info.Sala;
                  contact.Estado = Info.Estado;
                  contact.IdUsuario = Info.IdUsuario;
                  contact.Fecha_Transaccion = Info.Fecha_Transaccion;
                  contact.nom_pc = Info.nom_pc;
                  contact.ip = Info.ip;

                  Context.ro_sala.Add(contact);
                  Context.SaveChanges();
              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool ModificarDB(ro_sala_Info Info, ref string mensaje)
      {
          try
          {
              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  ro_sala contact = Context.ro_sala.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdSala == Info.IdSala);
                  if (contact != null)
                  {
                      contact.Sala = Info.Sala;
                      contact.IdUsuarioUltModi = Info.IdUsuarioUltModi;
                      contact.Fecha_UltMod = DateTime.Now;
                      contact.nom_pc = Info.nom_pc;
                      contact.ip = Info.ip;
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool AnularDB(ro_sala_Info Info, ref string mensaje)
      {
          try
          {
              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  ro_sala contact = Context.ro_sala.FirstOrDefault(q => q.IdEmpresa == Info.IdEmpresa && q.IdSala == Info.IdSala);
                  if (contact != null)
                  {
                      contact.IdUsuarioUltAnu = Info.IdUsuarioUltAnu;
                      contact.Fecha_UltAnu = Info.Fecha_UltAnu;
                      contact.MotivoAnulacion = Info.MotivoAnulacion;
                      contact.Estado = false;
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
