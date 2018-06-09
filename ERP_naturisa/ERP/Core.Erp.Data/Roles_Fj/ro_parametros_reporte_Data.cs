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
  public  class ro_parametros_reporte_Data
  {
      string MensajeError = "";
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      public bool Guardar_DB(int IdEmpresa,  List< ro_parametros_reporte_Info> info)
      {
          try
          {

              using (EntityRoles_FJ db = new EntityRoles_FJ())
              {
                  db.Database.ExecuteSqlCommand("delete Fj_servindustrias.ro_parametros_reporte where IdEmpresa='" + IdEmpresa + "' and Id_catalogo_repor='" + info.FirstOrDefault().Id_catalogo_repor+ "'");

                  foreach (var item in info)
                  {
                      if (item.IdNomina_Tipo != null && item.IdNomina_tipo_Liq != null && item.IdRubro != null && item.Id_Catalogo!=null)
                      {
                          ro_parametros_reporte add = new ro_parametros_reporte();
                          add.IdEmpresa = item.IdEmpresa;
                          add.IdNomina_Tipo = item.IdNomina_Tipo;
                          add.IdNomina_tipo_Liq = item.IdNomina_tipo_Liq;
                          add.IdRubro = item.IdRubro;
                          add.Id_Catalogo = item.Id_Catalogo;
                          add.Orden = item.Orden;
                          add.Descripcion = item.Descripcion;
                          add.Id_catalogo_repor = item.Id_catalogo_repor;
                          db.ro_parametros_reporte.Add(add);
                          db.SaveChanges();
                      }
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
      public List<ro_parametros_reporte_Info> Get_list_parametro(int IdEmpresa)
      {
          try
          {
              List<ro_parametros_reporte_Info> lista = new List<ro_parametros_reporte_Info>();

              int idperio = 0;

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  var sel = (from s in Context.ro_parametros_reporte
                             where s.IdEmpresa == IdEmpresa

                             select s);

                  foreach (var item in sel)
                  {
                      ro_parametros_reporte_Info add = new ro_parametros_reporte_Info();
                  add.IdEmpresa = item.IdEmpresa;
                  add.IdNomina_Tipo = item.IdNomina_Tipo;
                  add.IdNomina_tipo_Liq = item.IdNomina_tipo_Liq;
                  add.IdRubro = item.IdRubro;
                  add.Id_Catalogo = item.Id_Catalogo;
                  add.Orden = item.Orden;
                  add.eliminar = true;
                  add.Descripcion = item.Descripcion;
                  add.Id_catalogo_repor = item.Id_catalogo_repor;

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

      public List<ro_parametros_reporte_Info> Get_list_parametro(int IdEmpresa, string Codtipo)
      {
          try
          {
              List<ro_parametros_reporte_Info> lista = new List<ro_parametros_reporte_Info>();

              int idperio = 0;

              using (EntityRoles_FJ Context = new EntityRoles_FJ())
              {
                  var sel = (from s in Context.ro_parametros_reporte
                             where s.IdEmpresa == IdEmpresa
                             && s.Id_catalogo_repor == Codtipo

                             select s);

                  foreach (var item in sel)
                  {
                      ro_parametros_reporte_Info add = new ro_parametros_reporte_Info();
                      add.IdEmpresa = item.IdEmpresa;
                      add.IdNomina_Tipo = item.IdNomina_Tipo;
                      add.IdNomina_tipo_Liq = item.IdNomina_tipo_Liq;
                      add.IdRubro = item.IdRubro;
                      add.Id_Catalogo = item.Id_Catalogo;
                      add.Orden = item.Orden;
                      add.eliminar = true;
                      add.Descripcion = item.Descripcion;
                      add.Id_catalogo_repor = item.Id_catalogo_repor;

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
