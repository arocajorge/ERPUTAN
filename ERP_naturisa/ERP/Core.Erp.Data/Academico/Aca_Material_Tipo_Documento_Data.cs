
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
   public class Aca_Material_Tipo_Documento_Data
    {
       public int GetId()
       {
           int Id = 0;
           try
           {
               Entities_Academico Base = new Entities_Academico();
               int select = (from q in Base.Aca_matricula_Tipo_documento                             
                             select q).Count();
               if (select == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_as = (from q in Base.Aca_matricula_Tipo_documento                                    
                                    select q.IdTipoDocumento).Max();
                   Id = Convert.ToInt32(select_as.ToString()) + 1;
               }
               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               string MensajeError = string.Empty;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.ToString());
           }
       }

       public List<Aca_Matricula_Tipo_Documento_Info> Get_List_Matricula_Tipo_Documento() {
           List<Aca_Matricula_Tipo_Documento_Info> lista = new List<Aca_Matricula_Tipo_Documento_Info>();
           Aca_Matricula_Tipo_Documento_Info info;
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var matriculaTipoDoc = from t in Base.Aca_matricula_Tipo_documento
                                          select t;
                   foreach (var item in matriculaTipoDoc)
                   {
                       info = new Aca_Matricula_Tipo_Documento_Info();
                       info.IdTipoDocumento = item.IdTipoDocumento;
                       info.CodTipoDocumento = item.codTipoDocumento;
                       info.Descripcion = item.descripcion;
                       info.FechaCreacion = item.FechaCreacion;
                       info.FechaModificacion = item.FechaModificacion;
                       info.FechaAnulacion = item.FechaAnulacion;                       
                       info.UsuarioCreacion = item.UsuarioCreacion;
                       info.UsuarioModificacion = item.UsuarioModificacion;
                       info.UsuarioAnulacion = item.UsuarioAnulacion;
                       info.Estado = item.Estado;
                       lista.Add(info);
                   }
               }
               return lista;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               string MensajeError = string.Empty;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.ToString());
           }
       }


       public bool GrabarDB(Aca_Matricula_Tipo_Documento_Info info,ref int IdTipoDocumento,ref string mensaje) {
           try
           { 
               using (Entities_Academico Base=new Entities_Academico())
               {
                   Aca_matricula_Tipo_documento matriTipoDoc = new Aca_matricula_Tipo_documento();
                   IdTipoDocumento = GetId();
                   matriTipoDoc.IdTipoDocumento = IdTipoDocumento;
                   matriTipoDoc.codTipoDocumento = string.IsNullOrEmpty(info.CodTipoDocumento) ? IdTipoDocumento.ToString() : info.CodTipoDocumento;
                   matriTipoDoc.descripcion = info.Descripcion;
                   matriTipoDoc.Archivo = info.Archivo;
                   matriTipoDoc.FechaCreacion = DateTime.Now;                   
                   matriTipoDoc.UsuarioCreacion = info.UsuarioCreacion;
                   matriTipoDoc.FechaModificacion = DateTime.Now;
                   matriTipoDoc.UsuarioModificacion = info.UsuarioModificacion;
                   matriTipoDoc.Estado = info.Estado;
                   Base.Aca_matricula_Tipo_documento.Add(matriTipoDoc);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar tipo documento #: " + IdTipoDocumento.ToString() + " exitosamente.";
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }       
       }

       public bool ActualizarDB(Aca_Matricula_Tipo_Documento_Info info,ref string mensaje) {
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var matTipoDocu=Base.Aca_matricula_Tipo_documento.FirstOrDefault(m=>m.IdTipoDocumento==info.IdTipoDocumento);
                   if (matTipoDocu != null)
                   {
                       matTipoDocu.codTipoDocumento = info.CodTipoDocumento;
                       matTipoDocu.descripcion = info.Descripcion;
                       matTipoDocu.Archivo = info.Archivo;
                       matTipoDocu.UsuarioModificacion = info.UsuarioModificacion;
                       matTipoDocu.UsuarioAnulacion = info.UsuarioAnulacion;
                       matTipoDocu.FechaModificacion = DateTime.Now;
                       matTipoDocu.FechaAnulacion = info.FechaAnulacion;
                       matTipoDocu.Estado = info.Estado;
                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar tipo documento #: " + info.IdTipoDocumento.ToString() + " exitosamente.";
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public bool AnularDB(Aca_Matricula_Tipo_Documento_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_matricula_Tipo_documento.FirstOrDefault(a => a.IdTipoDocumento == info.IdTipoDocumento);
                   if (address != null)
                   {
                       address.Estado = "I";
                       address.FechaAnulacion = DateTime.Now;
                       address.UsuarioAnulacion = info.UsuarioAnulacion;
                       address.MotivoAnulacion = info.MotivoAnulacion;
                       context.SaveChanges();
                       mensaje = "Se ha procedido anular el tipo de documento #: " + info.IdTipoDocumento.ToString() + " exitosamente.";
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
