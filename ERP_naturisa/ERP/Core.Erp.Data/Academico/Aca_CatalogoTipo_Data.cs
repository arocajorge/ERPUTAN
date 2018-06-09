using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Academico
{
   public class Aca_CatalogoTipo_Data
    {
       string mensaje="";
       public List<Aca_CatalogoTipo_Info> Get_List_CatalogoTipo()
       {
           List<Aca_CatalogoTipo_Info> lista = new List<Aca_CatalogoTipo_Info>();

           try
           {
               Entities_Academico Base = new Entities_Academico();
               var q = from C in Base.Aca_CatalogoTipo
                       orderby C.IdTipoCatalogo
                       select C;

               foreach (var item in q)
               {
                   Aca_CatalogoTipo_Info Info= new Aca_CatalogoTipo_Info();

                   Info.Descripcion = item.Descripcion;
                   Info.IdTipoCatalogo = item.IdTipoCatalogo;
                   lista.Add(Info);
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


       public bool GrabarDB(Aca_CatalogoTipo_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   Aca_CatalogoTipo addressCatal = new Aca_CatalogoTipo();
                   
                   addressCatal.IdTipoCatalogo = info.IdTipoCatalogo;
                   addressCatal.Descripcion = info.Descripcion;
                   addressCatal.estado = info.estado;

                   addressCatal.IdUsuario = info.IdUsuario;
                   addressCatal.nom_pc = info.nom_pc;
                   addressCatal.ip = info.ip;

                   addressCatal.FechaUltMod = DateTime.Now;
                   addressCatal.IdUsuarioUltMod = info.IdUsuarioUltMod;
                  
                   Base.Aca_CatalogoTipo.Add(addressCatal);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar el Catálogo #: " + info.IdTipoCatalogo.ToString() + " exitosamente.";
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
               mensaje = "Error no se grabó ";
               throw new Exception(ex.ToString());
           }
       }

       public bool ActualizarDB(Aca_CatalogoTipo_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var vcatalogo = Base.Aca_CatalogoTipo.FirstOrDefault(c => c.IdTipoCatalogo == info.IdTipoCatalogo);
                   if (vcatalogo != null)
                   {
                       vcatalogo.IdTipoCatalogo = info.IdTipoCatalogo;
                       vcatalogo.Descripcion = info.Descripcion;

                       vcatalogo.FechaUltMod = info.FechaUltMod;
                       vcatalogo.IdUsuarioUltMod = info.IdUsuarioUltMod;
                       vcatalogo.estado = info.estado;

                       vcatalogo.IdUsuario = info.IdUsuario;
                       vcatalogo.nom_pc = info.nom_pc;
                       vcatalogo.ip = info.ip;

                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar el Catálogo #: " + info.IdTipoCatalogo.ToString() + " exitosamente.";
                   }
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensaje = "Error no se grabó ";
               throw new Exception(ex.ToString());
           }
       }

       public bool AnularDB(Aca_CatalogoTipo_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var address = Base.Aca_CatalogoTipo.FirstOrDefault(a => a.IdTipoCatalogo == info.IdTipoCatalogo);
                   if (address != null)
                   {
                       address.IdTipoCatalogo = info.IdTipoCatalogo;
                       address.Descripcion = info.Descripcion;
                       Base.SaveChanges();
                       mensaje = "Se ha procedido anular Catálogo #: " + info.IdTipoCatalogo.ToString() + " exitosamente.";
                   }
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               mensaje = "Error no se anulo ";
               throw new Exception(ex.ToString());
           }
       }


    }
}
