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
   public class Aca_InstitucionFinanciera_x_cod_establecimiento_Data
    {
       string mensaje = "";
       public Aca_InstitucionFinanciera_x_cod_establecimiento_Data() { }

     public bool ExisteEstablecimiento(int idInstitucion, string cargaFinanciera) {
         try
         {
             using (Entities_Academico Base= new Entities_Academico())
             {
                 int existe = (from c in Base.Aca_Establecimiento_InstitucionFinanciera
                               where c.IdIntitucionFinanciera == idInstitucion && c.IdCodigoFee_catalogo == cargaFinanciera 
                              select c).Count();
                 if (existe > 0)
                 {
                     return true;
                 }
                 else { return false; }
             }
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

     public List<Aca_InstitucionFinanciera_x_cod_establecimiento_Info> Get_List_Establecimiento()
     {
         List<Aca_InstitucionFinanciera_x_cod_establecimiento_Info> lista = new List<Aca_InstitucionFinanciera_x_cod_establecimiento_Info>();
         Aca_InstitucionFinanciera_x_cod_establecimiento_Info establecimientoInfo;
         try
         {
             using (Entities_Academico Base=new Entities_Academico())
             {
                 var vEstablecimiento=from e in Base.Aca_Establecimiento_InstitucionFinanciera                                      
                                      select e;
                 foreach (var item in vEstablecimiento)
	                {
                        establecimientoInfo = new Aca_InstitucionFinanciera_x_cod_establecimiento_Info();
                      establecimientoInfo.IdCodigoFee_catalogo = item.IdCodigoFee_catalogo;
                      establecimientoInfo.IdInstitucionFinanciera = item.IdIntitucionFinanciera;
                      establecimientoInfo.NumeroEstablecimiento = item.Numero_establecimiento;
                      establecimientoInfo.Estado = item.Estado;
                     
                     var vinstitutcion = Base.Aca_InstitucionFinanciera.FirstOrDefault(l=>l.IdInstitucionFinaciera==item.IdIntitucionFinanciera );
                     establecimientoInfo.InstitucionFinaciera_Info.IdInstitucionFinanciera = vinstitutcion.IdInstitucionFinaciera;
                     establecimientoInfo.InstitucionFinaciera_Info.NombreInstitucion = vinstitutcion.NombreInstitucion;
                     establecimientoInfo.InstitucionFinaciera_Info.Porc_comision = vinstitutcion.Porc_comision;                     

                      lista.Add(establecimientoInfo);
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

     public bool GrabarDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje)
     {
         try
         {
             using (Entities_Academico Base=new Entities_Academico())
             {
                 Aca_Establecimiento_InstitucionFinanciera estab = new Aca_Establecimiento_InstitucionFinanciera();
                 estab.IdCodigoFee_catalogo = info.IdCodigoFee_catalogo;
                 estab.IdIntitucionFinanciera = info.IdInstitucionFinanciera;
                 estab.Numero_establecimiento = info.NumeroEstablecimiento;
                 estab.Estado = info.Estado;
                 estab.UsuarioCreacion = info.UsuarioCreacion;
                 estab.FechaCreacion = DateTime.Now;
                 Base.Aca_Establecimiento_InstitucionFinanciera.Add(estab);
                 Base.SaveChanges();
                 mensaje = "Se ha procedido a grabar el Establecimiento " + estab.Numero_establecimiento+" de la Institución Financiera " + info.IdInstitucionFinanciera  + " exitosamente.";
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
             throw new Exception(ex.ToString());
         }
     }

     public bool ActualizarDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje)
     {
         try
         {   
             using (Entities_Academico Base=new Entities_Academico()){
                 var vEstablecimiento = Base.Aca_Establecimiento_InstitucionFinanciera.FirstOrDefault(e=>e.IdIntitucionFinanciera==info.IdInstitucionFinanciera && e.IdCodigoFee_catalogo==info.IdCodigoFee_catalogo);

                 if (vEstablecimiento != null)
                 {
                     vEstablecimiento.Numero_establecimiento = info.NumeroEstablecimiento;
                     vEstablecimiento.FechaModificacion = DateTime.Now;
                     vEstablecimiento.UsuarioModificacion = info.UsuarioModificacion;
                     vEstablecimiento.Estado = info.Estado;
                     Base.SaveChanges();
                     mensaje = "Se ha procedido actualizar el establecimiento de la Institución Financiera " + info.IdInstitucionFinanciera.ToString() + " exitosamente.";
                 }
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
             throw new Exception(ex.ToString());
         }
     }

     public bool AnularDB(Aca_InstitucionFinanciera_x_cod_establecimiento_Info info, ref string mensaje) 
     {
         try
         {
             using (Entities_Academico Base=new Entities_Academico())
             {
                 var vEstablecimiento = Base.Aca_Establecimiento_InstitucionFinanciera.FirstOrDefault(e => e.IdIntitucionFinanciera == info.IdInstitucionFinanciera && e.IdCodigoFee_catalogo == info.IdCodigoFee_catalogo);
                 if (vEstablecimiento != null)
                 {
                     vEstablecimiento.Estado = "I";
                     vEstablecimiento.UsuarioAnulacion = info.UsuarioAnulacion;
                     vEstablecimiento.FechaAnulacion = DateTime.Now;
                     vEstablecimiento.MotivoAnulacion = info.MotivoAnulacion;
                     Base.SaveChanges();
                     mensaje = "Se ha procedido anular el número de estableciento " + info.NumeroEstablecimiento + " exitosamente.";
                 }
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
             throw new Exception(ex.ToString());
         }
     }
    }
}
