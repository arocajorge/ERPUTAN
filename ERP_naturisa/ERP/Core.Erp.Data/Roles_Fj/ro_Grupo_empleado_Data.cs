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
  public  class ro_Grupo_empleado_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(ro_Grupo_empleado_Info info, ref int idgrupo)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  ro_Grupo_empleado add = new ro_Grupo_empleado();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdGrupo = GetId(info.IdEmpresa);
                  add.Nombre_Grupo = info.Nombre_Grupo;
                  add.IdRubro_Alim = info.IdRubro_Alim;
                  add.IdRubro_Trans = info.IdRubro_Trans;
                  add.Valor_Alimen = info.Valor_Alimen;
                  add.Valor_Transp = info.Valor_Transp;
                  add.Max_num_horas_sab_dom = info.Max_num_horas_sab_dom;
                  add.Calculo_Horas_extras_Sobre = info.Calculo_Horas_extras_Sobre;
                  add.Valor_bono = info.Valor_bono;
                  add.IdUsuario = info.IdUsuario;
                  add.Fecha_Transac = DateTime.Now;
                  add.Estado = "A";
                  db.ro_Grupo_empleado.Add(add);
                  db.SaveChanges();
                  idgrupo = add.IdGrupo;
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


      public bool Modificar_DB(ro_Grupo_empleado_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_Grupo_empleado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdGrupo == info.IdGrupo);

                  add.Nombre_Grupo = info.Nombre_Grupo;
                  add.Max_num_horas_sab_dom = info.Max_num_horas_sab_dom;
                  add.Calculo_Horas_extras_Sobre = info.Calculo_Horas_extras_Sobre;
                  add.Valor_bono = info.Valor_bono;
                  add.Fecha_UltMod = DateTime.Now;
                  add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                  add.IdRubro_Alim = info.IdRubro_Alim;
                  add.IdRubro_Trans = info.IdRubro_Trans;
                  add.Valor_Alimen = info.Valor_Alimen;
                  add.Valor_Transp = info.Valor_Transp;
                  db.SaveChanges();
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

    

      public bool Anular_DB(ro_Grupo_empleado_Info info)
      {
          try
          {
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var add = db.ro_Grupo_empleado.FirstOrDefault(v => v.IdEmpresa == info.IdEmpresa && v.IdGrupo == info.IdGrupo);

                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.MotiAnula = info.MotiAnula;
                  add.Estado = "I";
                  db.SaveChanges();
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




      public List<ro_Grupo_empleado_Info> listado_Grupos(int IdEmpresa)
      {
          try
          {
              List<ro_Grupo_empleado_Info> lista = new List<ro_Grupo_empleado_Info>();
              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  var query = from q in db.ro_Grupo_empleado
                              where
                              q.IdEmpresa == IdEmpresa
                             
                              select q;

                  foreach (var item in query)
                  {
                      ro_Grupo_empleado_Info info = new ro_Grupo_empleado_Info();

                      info.Nombre_Grupo = item.Nombre_Grupo;
                      info.Estado = item.Estado;
                      info.IdGrupo = item.IdGrupo;
                      info.IdEmpresa = item.IdEmpresa;
                      info.Max_num_horas_sab_dom = item.Max_num_horas_sab_dom;
                      info.Calculo_Horas_extras_Sobre = item.Calculo_Horas_extras_Sobre;
                      info.Fecha_Transac = item.Fecha_Transac;
                      info.IdRubro_Alim = item.IdRubro_Alim;
                      info.IdRubro_Trans = item.IdRubro_Trans;
                      info.Valor_Alimen = item.Valor_Alimen;
                      info.Valor_Transp = item.Valor_Transp;
                      info.Valor_bono = item.Valor_bono;

                      lista.Add(info);
                  }
              }

              return lista;
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

     
     


      public int GetId(int IdEmpresa)
      {
          try
          {
              using (EntityRoles_FJ database = new EntityRoles_FJ())
              {

                  var query = (from i in database.ro_Grupo_empleado
                               where i.IdEmpresa == IdEmpresa
                               select i);

                  if (query.Count() == 0)
                  {
                      return 1;
                  }
                  else
                  {
                      var query_ = (from i in database.ro_Grupo_empleado
                                    where i.IdEmpresa == IdEmpresa
                                    select i.IdGrupo).Count();
                      return query.Count() + 1;
                  }

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


      public double Get_valor_bono(int IdEmpresa, int IdGrupo)
      {
          double valor = 0;
          try
          {
              using (EntityRoles_FJ database = new EntityRoles_FJ())
              {

                  var query = (from i in database.ro_Grupo_empleado
                               where i.IdEmpresa == IdEmpresa
                               && i.IdGrupo==IdGrupo
                               select i);

                  if (query.Count() > 0)
                  {
                      valor = query.FirstOrDefault().Valor_bono;
                  }
                  

              }
              return valor;
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

       
    }
}
