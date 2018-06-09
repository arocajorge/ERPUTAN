using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Material_x_Documento_Data
    {
      string mensaje = "";
      public List<Aca_Matricula_x_Documento_Info> Get_List_Matricula_x_Documento(Aca_Matricula_x_Documento_Info info)
      {
          List<Aca_Matricula_x_Documento_Info> lista = new List<Aca_Matricula_x_Documento_Info>();
          Aca_Matricula_x_Documento_Info maDocInfo;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var matriculadocumento = from m in Base.vwAca_matricula_documento
                                           where m.IdInstitucion == info.IdInstitucion &&
                                                 m.IdSede == info.IdSede &&
                                                 m.IdMatricula == info.IdMatricula
                                           select m;

                  foreach (var item in matriculadocumento)
                  {
                      maDocInfo = new Aca_Matricula_x_Documento_Info();
                      maDocInfo.IdInstitucion = item.IdInstitucion;
                      maDocInfo.IdMatricula = item.IdMatricula;
                      maDocInfo.IdSede = item.IdSede;
                      maDocInfo.IdTipoDocumento = item.IdTipoDocumento;
                      maDocInfo.Observacion = item.descripcion;
                      maDocInfo.Archivo = item.Archivo;
                      maDocInfo.sLink = "Descargar";
                      maDocInfo.Estado = item.Estado;
                      maDocInfo.Existe_en_Base = item.Existe_en_Base==null?0:Convert.ToInt16(item.Existe_en_Base);
                      lista.Add(maDocInfo);
                  }
              }
              return lista;
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

      public bool GrabarDB(Aca_Matricula_x_Documento_Info info,Aca_Matricula_Info infoMatricula,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  Aca_matricula_x_documento matriculaDoc = new Aca_matricula_x_documento();
                  matriculaDoc.IdInstitucion = info.IdInstitucion==0?infoMatricula.IdInstitucion:info.IdInstitucion;
                  matriculaDoc.IdMatricula = info.IdMatricula==0?infoMatricula.IdMatricula:info.IdMatricula;
                  matriculaDoc.IdSede = info.IdSede==0?infoMatricula.IdSede:info.IdSede;
                  matriculaDoc.IdTipoDocumento = info.IdTipoDocumento;
                  matriculaDoc.Observacion = info.Observacion;
                  matriculaDoc.UsuarioCreacion = infoMatricula.UsuarioCreacion;
                  matriculaDoc.FechaCreacion = DateTime.Now;
                  matriculaDoc.Estado = info.Estado;
                  Base.Aca_matricula_x_documento.Add(matriculaDoc);
                  Base.SaveChanges();
              }
              return true;
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

      public bool ActualizarDB(Aca_Matricula_x_Documento_Info info,ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var matriculaDoc = Base.Aca_matricula_x_documento.FirstOrDefault(m=>m.IdInstitucion==info.IdInstitucion && 
                                                                                   m.IdMatricula==info.IdMatricula && 
                                                                                   m.IdSede==info.IdSede && 
                                                                                   m.IdTipoDocumento==info.IdTipoDocumento);
                  if (matriculaDoc != null)
                  {
                      matriculaDoc.Archivo = info.Archivo;
                      matriculaDoc.Observacion = info.Observacion;
                      matriculaDoc.UsuarioModificacion = info.UsuarioModificacion;
                      matriculaDoc.FechaModificacion = DateTime.Now;
                      Base.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public bool AnularDB(Aca_Matricula_x_Documento_Info info,ref string mensaje) {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var matriculaDoc = Base.Aca_matricula_x_documento.FirstOrDefault(m => m.IdInstitucion == info.IdInstitucion &&
                                                                                   m.IdMatricula == info.IdMatricula && 
                                                                                   m.IdSede == info.IdSede &&
                                                                                   m.IdTipoDocumento == info.IdTipoDocumento);
                  if (matriculaDoc != null)
                  {
                      matriculaDoc.Estado = "I";
                      matriculaDoc.FechaAnulacion = DateTime.Now;
                      matriculaDoc.UsuarioAnulacion = info.UsuarioAnulacion;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido anular documento de la matricula #: " + info.IdMatricula.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
    }
}
