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
   public class Aca_Documento_Bancario_x_Rep_Economico_Data
   {
       string mensaje="";
       public List<Aca_Documento_Bancario_x_Rep_Economico_Info> Get_List_Matricula_Tipo_Documento(int IdInstitucion, int idfamiliar)
       {
           List<Aca_Documento_Bancario_x_Rep_Economico_Info> lista = new List<Aca_Documento_Bancario_x_Rep_Economico_Info>();
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var Lista = from q in Base.Aca_Documento_Bancario_x_Rep_Economico
                             where q.IdInstitucion == IdInstitucion
                             && q.IdFamiliar==idfamiliar
                             group q by new { q.IdInstitucion, q.IdFamiliar, q.IdParentesco_cat, q.IdDocumento_Bancario, q.Id_tipo_meca_pago, q.Id_tb_banco_x_mgbanco, q.Observacion, q.Fecha_Expiracion, q.Numero_Documento}
                                 into grouping
                                 select new { grouping.Key };
                 
                   foreach (var item in Lista)
                   {         
                       Aca_Documento_Bancario_x_Rep_Economico_Info matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico_Info();                      
                       matriTipoDoc.IdInstitucion = item.Key.IdInstitucion;
                       matriTipoDoc.IdFamiliar = item.Key.IdFamiliar;
                       matriTipoDoc.IdParentesco_cat = item.Key.IdParentesco_cat;
                       matriTipoDoc.IdDocumento_Bancario = item.Key.IdDocumento_Bancario;
                       matriTipoDoc.Id_tipo_meca_pago = item.Key.Id_tipo_meca_pago;
                       matriTipoDoc.Id_tb_banco_x_mgbanco = item.Key.Id_tb_banco_x_mgbanco;                     
                       matriTipoDoc.Numero_Documento = item.Key.Numero_Documento;
                       matriTipoDoc.Observacion = item.Key.Observacion;                    
                       matriTipoDoc.Fecha_Expiracion = item.Key.Fecha_Expiracion;
                       matriTipoDoc.eliminar = true;
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

       public Aca_Documento_Bancario_x_Rep_Economico_Info Get_Info_Documento_Bancario_x_Rep_Economico(int IdInstitucion, int idfamiliar)
       {
           Aca_Documento_Bancario_x_Rep_Economico_Info matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico_Info();
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var matriculaTipoDoc = (from t in Base.Aca_Documento_Bancario_x_Rep_Economico
                                           where t.IdInstitucion == IdInstitucion
                                           && t.IdFamiliar == idfamiliar
                                           select t.Id_tipo_meca_pago).Distinct();
                   foreach (var item in matriculaTipoDoc)
                   {
                       var InfoFa = Base.Aca_Documento_Bancario_x_Rep_Economico.First(p => p.Id_tipo_meca_pago == item);
                       
                       if (InfoFa != null)
                       {
                           matriTipoDoc.IdInstitucion = InfoFa.IdInstitucion;
                           matriTipoDoc.IdFamiliar = InfoFa.IdFamiliar;
                           matriTipoDoc.IdParentesco_cat = InfoFa.IdParentesco_cat;
                           matriTipoDoc.IdDocumento_Bancario = InfoFa.IdDocumento_Bancario;
                           matriTipoDoc.Id_tipo_meca_pago = InfoFa.Id_tipo_meca_pago;
                           matriTipoDoc.Id_tb_banco_x_mgbanco = InfoFa.Id_tb_banco_x_mgbanco;
                           //matriTipoDoc.IdBanco = info.IdBanco;
                           matriTipoDoc.Tipo_documento_cat = InfoFa.Tipo_documento_cat;
                           matriTipoDoc.Numero_Documento = InfoFa.Numero_Documento;
                           matriTipoDoc.Observacion = InfoFa.Observacion;
                           matriTipoDoc.IdUsuario = InfoFa.IdUsuario;
                           matriTipoDoc.Fecha_Expiracion = InfoFa.Fecha_Expiracion;
                           matriTipoDoc.Fecha_Transac = DateTime.Now;
                           matriTipoDoc.eliminar = true;
                           
                       }

                   }
               }
               return matriTipoDoc;
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


       public bool GrabarDB(List< Aca_Documento_Bancario_x_Rep_Economico_Info> lista, ref int IdDocumentoBancario, ref string mensaje)
       {
           try
           {
               Eliminar(lista.FirstOrDefault(),ref mensaje);
              
               using (Entities_Academico Base = new Entities_Academico())
               {
                   foreach (var info in lista)
                   {
                       
                   Aca_Documento_Bancario_x_Rep_Economico matriTipoDoc = new Aca_Documento_Bancario_x_Rep_Economico();
                   matriTipoDoc.IdDocumento_Bancario = getId(info.IdInstitucion);
                   IdDocumentoBancario = matriTipoDoc.IdDocumento_Bancario;
                   matriTipoDoc.IdInstitucion = info.IdInstitucion;
                   matriTipoDoc.IdFamiliar = info.IdFamiliar;
                   matriTipoDoc.IdParentesco_cat = info.IdParentesco_cat;                   
                   matriTipoDoc.Id_tb_banco_x_mgbanco = info.Id_tb_banco_x_mgbanco;
                   matriTipoDoc.Id_tipo_meca_pago = info.Id_tipo_meca_pago;
                   matriTipoDoc.IdBanco = info.IdBanco;
                   matriTipoDoc.Tipo_documento_cat = info.Tipo_documento_cat;
                   matriTipoDoc.Numero_Documento = info.Numero_Documento;
                   matriTipoDoc.Observacion = info.Observacion;
                   matriTipoDoc.IdUsuario = info.IdUsuario;
                   matriTipoDoc.Fecha_Expiracion = info.Fecha_Expiracion;
                   matriTipoDoc.Fecha_Transac = DateTime.Now;
                   matriTipoDoc.Estado = true;                   
                   Base.Aca_Documento_Bancario_x_Rep_Economico.Add(matriTipoDoc);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar   exitosamente.";
                   
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

    
       public bool Eliminar(Aca_Documento_Bancario_x_Rep_Economico_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   context.Database.ExecuteSqlCommand("delete Aca_Documento_Bancario_x_Rep_Economico  where IdInstitucion='" + info.IdInstitucion + "' and IdFamiliar='"+info.IdFamiliar+"'");
                 
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

       public int getId(int IdInstitucion)
       {
           int Id = 0;
           try
           {
               Entities_Academico Base = new Entities_Academico();
               int select = (from q in Base.Aca_Documento_Bancario_x_Rep_Economico
                             where q.IdInstitucion == IdInstitucion
                             select q).Count();

               if (select == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_as = (from q in Base.Aca_Documento_Bancario_x_Rep_Economico
                                    where q.IdInstitucion == IdInstitucion
                                    select q.IdDocumento_Bancario).Max();
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
               throw new Exception(ex.InnerException.ToString());
           }

       }

       public bool ActualizarDB(Aca_Documento_Bancario_x_Rep_Economico_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var Documento_Bancario = Base.Aca_Documento_Bancario_x_Rep_Economico.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdDocumento_Bancario == info.IdDocumento_Bancario);

                   if (Documento_Bancario != null)
                   {
                       Documento_Bancario.Id_tb_banco_x_mgbanco = info.Id_tb_banco_x_mgbanco;
                       Documento_Bancario.Id_tipo_meca_pago = info.Id_tipo_meca_pago;
                       Documento_Bancario.IdBanco = info.IdBanco;
                       Documento_Bancario.Tipo_documento_cat = info.Tipo_documento_cat;
                       Documento_Bancario.Numero_Documento = info.Numero_Documento;
                       Documento_Bancario.Observacion = info.Observacion;
                       Documento_Bancario.IdUsuarioUltMod = info.IdUsuarioUltMod;
                       Documento_Bancario.Fecha_Expiracion = info.Fecha_Expiracion;
                       Documento_Bancario.Fecha_UltMod = DateTime.Now;                                         
                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar Documento Bancario #: " + info.IdDocumento_Bancario.ToString() + " exitosamente.";
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
               mensaje = ex.InnerException + " " + ex.Message;
               //saca la exceopción controlada a la proxima capa
               throw new Exception(ex.InnerException.ToString());
           }
       }
    }
}
