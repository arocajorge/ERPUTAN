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
    public class Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Data
   {
       string mensaje = "";
       public List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar, decimal IdEstudiante)
       {
           List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> lista = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var matriculaTipoDoc = from t in Base.vwAca_DocumBanc_x_Rep_Econx_estudi_x_Matri
                                          where t.IdInstitucion == IdInstitucion
                                          && t.IdFamiliar == idfamiliar
                                          select t;
                   foreach (var info in matriculaTipoDoc)
                   {
                       Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
                       matriTipoDoc.IdInstitucion = info.IdInstitucion;
                       matriTipoDoc.IdFamiliar = info.IdFamiliar;
                       matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;
                       matriTipoDoc.IdDocumento_Bancario = info.IdDocumento_Bancario;
                       matriTipoDoc.IdMatricula = info.IdMatricula;
                       matriTipoDoc.IdEstudiante = info.IdEstudiante;
                       //matriTipoDoc.IdBanco = info.IdBanco;
                       matriTipoDoc.Id_tb_banco_x_mgbanco = info.Id_tb_banco_x_mgbanco;
                       matriTipoDoc.Id_tipo_meca_pago = info.Id_tipo_meca_pago;
                       matriTipoDoc.Fecha_Expiracion = info.Fecha_Expiracion;
                       matriTipoDoc.Numero_Documento = info.Numero_Documento;
                       matriTipoDoc.Observacion = info.Observacion;
                       matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;
                       matriTipoDoc.Tipo_documento_cat = info.Tipo_documento_cat;
                       lista.Add(matriTipoDoc);
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

       public List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar)
       {
           List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info> lista = new List<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info>();
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var matriculaTipoDoc = from t in Base.Aca_Documento_Bancario_x_Rep_Economico
                                          where t.IdInstitucion == IdInstitucion
                                          && t.IdFamiliar == idfamiliar
                                          select t;
                   foreach (var info in matriculaTipoDoc)
                   {
                       Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info();
                       matriTipoDoc.IdInstitucion = info.IdInstitucion;
                       matriTipoDoc.IdFamiliar = info.IdFamiliar;
                       matriTipoDoc.IdBanco = info.IdBanco;
                       matriTipoDoc.Id_tb_banco_x_mgbanco = info.Id_tb_banco_x_mgbanco;
                       matriTipoDoc.Id_tipo_meca_pago = info.Id_tipo_meca_pago;
                       matriTipoDoc.Numero_Documento = info.Numero_Documento;
                       matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;
                       matriTipoDoc.IdDocumento_Bancario = info.IdDocumento_Bancario;
                       matriTipoDoc.Fecha_Expiracion = info.Fecha_Expiracion;
                       matriTipoDoc.Observacion = info.Observacion;
                       matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;
                       matriTipoDoc.Tipo_documento_cat = info.Tipo_documento_cat;
                       lista.Add(matriTipoDoc);
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




       public bool GrabarDB(Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info info, ref string mensaje)
       {
           try
           {
               Eliminar(info, ref mensaje);
               using (Entities_Academico Base = new Entities_Academico())
               {
                   Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula();
                       matriTipoDoc.IdInstitucion = info.IdInstitucion;
                       matriTipoDoc.IdFamiliar = info.IdFamiliar;
                       matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;
                       matriTipoDoc.IdDocumento_Bancario = info.IdDocumento_Bancario;
                       matriTipoDoc.Id_tb_banco_x_mgbanco = info.Id_tb_banco_x_mgbanco;
                       matriTipoDoc.Id_tipo_meca_pago = info.Id_tipo_meca_pago;
                       matriTipoDoc.IdMatricula = info.IdMatricula;
                       matriTipoDoc.IdEstudiante = info.IdEstudiante;
                       matriTipoDoc.Observacion = info.Observacion;
                       Base.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula.Add(matriTipoDoc);
                       Base.SaveChanges();
                       mensaje = "Se ha procedido a grabar   exitosamente.";
                   
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


       public bool Eliminar(Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   context.Database.ExecuteSqlCommand("delete Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula  where IdInstitucion='" + info.IdInstitucion + "' and IdFamiliar='" + info.IdFamiliar + "' and IdEstudiante='" + info.IdEstudiante + "' ");
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
