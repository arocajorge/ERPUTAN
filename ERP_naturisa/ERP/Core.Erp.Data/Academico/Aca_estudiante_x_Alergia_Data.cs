using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_estudiante_x_Alergia_Data
  {

      string mensaje = "";
      #region "Get"
      public List<Aca_Estudiante_x_Alergia_Info> Get_List_estudiante_x_Alergia(int IdInstitucion, decimal idEstudiante)
      {
          List<Aca_Estudiante_x_Alergia_Info> lstEstAlergia = new List<Aca_Estudiante_x_Alergia_Info>();
          Aca_Estudiante_x_Alergia_Info estAlergiaInfo;
          try
          {
              using (Entities_Academico db = new Entities_Academico())
              {
                  var estudiante_alergia = from e in db.vwAca_estudiante_x_Alergia
                                           orderby e.Orden
                                           where e.IdInstitucion == IdInstitucion && e.IdEstudiante == idEstudiante
                                           select e;
                  foreach (var item in estudiante_alergia)
                  {
                      estAlergiaInfo = new Aca_Estudiante_x_Alergia_Info();
                      estAlergiaInfo.IdAlergiaCatalogo = item.IdAlergia_catalogo;
                      estAlergiaInfo.IdInstitucion = item.IdInstitucion;
                      estAlergiaInfo.IdEstudiante = item.IdEstudiante;
                      estAlergiaInfo.NombreAlergia = item.Nom_Alergia;
                      estAlergiaInfo.Comentario = item.Comentario;
                      estAlergiaInfo.Activo = Convert.ToBoolean(item.activo);
                      estAlergiaInfo.Esta_en_Base = item.Esta_en_Base;
                      lstEstAlergia.Add(estAlergiaInfo);
                  }
              }
              return lstEstAlergia;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              //saca la exceopción controlada a la proxima capa
              throw new Exception(ex.ToString());
          }
          
      }
      #endregion

      #region "Grabar,Actualizar"
      public bool GrabarDB(List<Aca_Estudiante_x_Alergia_Info> lstAlergia,decimal idEstudiante,int IdInstitucion, ref string msj) {
          try
          {
              Aca_estudiante_x_Alergia addressAlergia = new Aca_estudiante_x_Alergia();
              using (Entities_Academico Base = new Entities_Academico())
              {
                  foreach (var item in lstAlergia)
                  {
                      if (item.Activo==true)
                      {  
                          addressAlergia = new Aca_estudiante_x_Alergia();
                          addressAlergia.IdInstitucion = IdInstitucion;
                          addressAlergia.IdEstudiante = idEstudiante;
                          addressAlergia.IdAlergia_catalogo = item.IdAlergiaCatalogo;
                          addressAlergia.descripcion = item.Comentario;
                          addressAlergia.activo = item.Activo;
                          Base.Aca_estudiante_x_Alergia.Add(addressAlergia);
                          Base.SaveChanges();
                      }
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      

      public bool ActualizarDB(List<Aca_Estudiante_x_Alergia_Info> lstAlergia, ref string msj)
      {
          try
          {
              using(Entities_Academico Base=new Entities_Academico())
              {
                  foreach (var item in lstAlergia)
                  {
                      var vwalergia  = Base.vwAca_estudiante_x_Alergia.FirstOrDefault(a => a.IdInstitucion == item.IdInstitucion &&
                                                                    a.IdEstudiante == item.IdEstudiante &&
                                                                    a.IdAlergia_catalogo == item.IdAlergiaCatalogo);
                      if (item.Esta_en_Base == "S")
                      {// Actualizar vwalergia
                          var alergia = Base.Aca_estudiante_x_Alergia.FirstOrDefault(a => a.IdInstitucion == item.IdInstitucion &&
                                                                            a.IdEstudiante == item.IdEstudiante &&
                                                                            a.IdAlergia_catalogo == item.IdAlergiaCatalogo);
                          alergia.activo = item.Activo;
                          alergia.descripcion = item.Comentario;
                          Base.SaveChanges();
                      }
                      else { 
                      // Insertar
                          if (item.Activo==true)
                          {
                              Aca_estudiante_x_Alergia estAlergia = new Aca_estudiante_x_Alergia();
                              estAlergia.IdInstitucion = item.IdInstitucion;
                              estAlergia.IdEstudiante = item.IdEstudiante;
                              estAlergia.descripcion = item.Comentario;
                              estAlergia.activo = item.Activo;
                              estAlergia.IdAlergia_catalogo = item.IdAlergiaCatalogo;
                              Base.Aca_estudiante_x_Alergia.Add(estAlergia);
                              Base.SaveChanges();                              
                          }
                      }
                  }
              }
              return true;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      #endregion
  
  
  }
}
