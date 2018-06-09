using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.ActivoFijo
{
  public  class Af_Activo_fijo_x_Af_Activo_fijo_Data
    {
      tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      string mensaje = "";
      public bool GuardarDB(List< Af_Activo_fijo_x_Af_Activo_fijo_Info> lista)
      {
          try
          {
              using (EntitiesActivoFijo DBase = new EntitiesActivoFijo())
              {
                  
                  foreach (var item in lista)
                  {
                       Af_Activo_fijo_x_Af_Activo_fijo address = new Af_Activo_fijo_x_Af_Activo_fijo();
                  address.IdActivoFijo_padre = item.IdActivoFijo_padre;
                  address.IdActivoFijo_hijo = item.IdActivoFijo_hijo;
                  address.IdEmpresa = item.IdEmpresa;
                  DBase.Af_Activo_fijo_x_Af_Activo_fijo.Add(address);
                  DBase.SaveChanges();
                  }
                  return true;
              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              //saca la excepción controlada a la proxima capa
              throw new Exception(ex.InnerException.ToString());
          }

      }

      public bool EliminarDB(int idempresa,int idactivo_padre)
      {
          try
          {
              using (EntitiesActivoFijo DBase = new EntitiesActivoFijo())
              {
                  string SQL = "delete Af_Activo_fijo_x_Af_Activo_fijo where IdEmpresa ='" + idempresa + "' and IdActivoFijo_hijo='" + idactivo_padre + "'";
                  DBase.Database.ExecuteSqlCommand(SQL);
                  return true;
              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              //saca la excepción controlada a la proxima capa
              throw new Exception(ex.InnerException.ToString());
          }

      }

      public List<Af_Activo_fijo_x_Af_Activo_fijo_Info> Get_List_activos_relacionados(int idempresa,int idactivo_hijo)
      {
          try
          {
              List<Af_Activo_fijo_x_Af_Activo_fijo_Info> LISTA = new List<Af_Activo_fijo_x_Af_Activo_fijo_Info>();
              using (EntitiesActivoFijo db= new EntitiesActivoFijo())
              {
                  var query = (from t in db.Af_Activo_fijo_x_Af_Activo_fijo
                               where t.IdEmpresa==idempresa
                               && t.IdActivoFijo_hijo == idactivo_hijo
                               select t);
                  foreach (var item in query)
                  {
                      Af_Activo_fijo_x_Af_Activo_fijo_Info INFO= new Af_Activo_fijo_x_Af_Activo_fijo_Info();
                      INFO.IdEmpresa=item.IdEmpresa;
                      INFO.IdActivoFijo_padre=item.IdActivoFijo_padre;
                      INFO.IdActivoFijo_hijo=INFO.IdActivoFijo_hijo;
                      LISTA.Add(INFO);
                      
                  }

                  return LISTA;
                  
              }
          }
          catch (Exception ex)
          {
              
               string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              //saca la excepción controlada a la proxima capa
              throw new Exception(ex.InnerException.ToString());
          }

      }

    }
}
