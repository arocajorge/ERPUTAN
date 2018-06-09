using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
namespace Core.Erp.Data.Roles
{
  public  class ro_Novedad_Subida_Bach_Data
    {
      string mensaje = "";
      public bool SiArchivoFueSubido(int IdEmpresa, string IdCalendario, string IdRubro)
      {
          try
          {
              using (EntitiesRoles ent=new EntitiesRoles())
              {
                  var sresult = from A in ent.ro_Novedad_Subida_Bach
                                where A.IdCalendario == IdCalendario
                                && A.IdRubro == IdRubro
                                && A.IdEmpresa==IdEmpresa
                                && A.Estado=="A"
                                select A;
                  if (sresult.Count() > 0)
                  {
                      return true;
                  }
                  else
                  {
                      return false;
                  }
                  
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


      public bool GrabarDB(int IdEmpresa, string IdCalendario, string IdRubro, DateTime Fecha)
      {
          try
          {
              using (EntitiesRoles ent = new EntitiesRoles())
              {
                  ro_Novedad_Subida_Bach add = new ro_Novedad_Subida_Bach();
                  add.IdCarga = getIdCarga(IdEmpresa);
                  add.IdEmpresa = IdEmpresa;
                  add.IdCalendario = IdCalendario;
                  add.IdRubro = IdRubro;
                  add.Fecha = Fecha;
                  add.Estado = "A";
                  ent.ro_Novedad_Subida_Bach.Add(add);
                  ent.SaveChanges();
                  return true;

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


      public Boolean AnularDB(ro_Novedad_Subida_Bach_Info info)
      {
          try
          {
              using (EntitiesRoles context = new EntitiesRoles())
              {
                  var contact = context.ro_Novedad_Subida_Bach.First(A => A.IdEmpresa==info.IdEmpresa && A.IdCalendario==info.IdCalendario && A.IdRubro==info.IdRubro && A.IdCarga==info.IdCarga);
                  contact.Estado = "I";               
                  context.SaveChanges();
              }
              return true;

          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<ro_Novedad_Subida_Bach_Info> ConsultaGeneral(int IdEmpresa)
      {
          List<ro_Novedad_Subida_Bach_Info> Lst = new List<ro_Novedad_Subida_Bach_Info>();
          try
          {
              EntitiesRoles oEnti = new EntitiesRoles();
              var Query = from q in oEnti.vwRo_Novedades_Batch 
                          where q.IdEmpresa == IdEmpresa
                          && q.Estado=="A"
                          select q;

              foreach (var item in Query)
              {
                  ro_Novedad_Subida_Bach_Info Obj = new ro_Novedad_Subida_Bach_Info();
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdCalendario = item.IdCalendario;
                  Obj.IdRubro = item.IdRubro;
                  Obj.Estado = item.Estado;
                  Obj.ru_descripcion = item.ru_descripcion;
                  Obj.NombreCorto = item.NombreCorto;
                  Obj.Fecha = item.Fecha;
                  Obj.IdCarga = item.IdCarga;
                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.InnerException.ToString());
          }
      }


      public int getIdCarga(int idempresa)
      {

          try
          {

              int Id;
              EntitiesRoles OECbtecble = new EntitiesRoles();



              var q = from C in OECbtecble.ro_Novedad_Subida_Bach
                      where C.IdEmpresa == idempresa
                      select C;
              if (q.ToList().Count == 0)
              {
                  return 1;
              }
              else
              {

                  var select_ = (from t in OECbtecble.ro_Novedad_Subida_Bach
                                 where t.IdEmpresa == idempresa
                                 select t.IdCarga).Max();
                  Id = Convert.ToInt32(select_.ToString()) + 1;
                  return Id;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.InnerException.ToString());
          }
      }



    }
}
