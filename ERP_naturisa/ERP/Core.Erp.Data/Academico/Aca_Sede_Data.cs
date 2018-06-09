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
   public class Aca_Sede_Data
    {
       string mensaje = "";


       public int GetIdSede(int IdJornada) 
       {
           int IdSede = 0;
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var jornada = from s in Base.Aca_Jornada
                              where s.IdJornada == IdJornada
                              select s;
                   foreach (var item in jornada)
                   {
                       IdSede = item.IdSede;
                   }
               }
               return IdSede;
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

       public int GetId(int IdInstitucion)
       {
           int Id = 0;
           try
           {
               Entities_Academico Base = new Entities_Academico();
               int select = (from q in Base.Aca_Sede
                             where q.IdInstitucion == IdInstitucion
                             select q).Count();

               if (select == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_as = (from q in Base.Aca_Sede
                                    where q.IdInstitucion == IdInstitucion
                                    select q.IdSede).Max();
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

       public List<Aca_Sede_Info> Get_List_Sede(int IdInstitucion)
       {
           List<Aca_Sede_Info> listaSede = new List<Aca_Sede_Info>();
           Aca_Sede_Info infoSede;
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var vSede = from s in Base.vwAca_Sede_Sucursal
                               where s.IdInstitucion == IdInstitucion
                               select s;


                   foreach (var item in vSede)
                   {
                       infoSede = new Aca_Sede_Info();
                       infoSede.IdInstitucion = item.IdInstitucion;
                       infoSede.IdSede = item.IdSede;
                       infoSede.DescripcionSede = item.Descripcion_sede;
                       infoSede.CodAlterno = item.CodAlterno;
                       infoSede.Estado = item.estado;
                       infoSede.IdEmpresa = item.IdEmpresa;
                       infoSede.IdSucursal = item.IdSucursal;
                       infoSede.Su_Descripcion = item.Su_Descripcion;
                       infoSede.Su_CodigoEstablecimiento = item.Su_CodigoEstablecimiento;
                       listaSede.Add(infoSede);
                   }
               }
               return listaSede;
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

       public bool GrabarDB(Aca_Sede_Info info, ref int IdSede, ref string mensaje)
       {
           try
           { 
               using (Entities_Academico Base = new Entities_Academico())
               {
                   Aca_Sede addressSede = new Aca_Sede();               
                   IdSede = GetId(info.IdInstitucion);
                   addressSede.IdSede = IdSede;
                   addressSede.IdInstitucion = info.IdInstitucion;
                   addressSede.CodSede = string.IsNullOrEmpty(info.CodSede) ? IdSede.ToString() : info.CodSede=="0"?IdSede.ToString():info.CodSede;                   
                   addressSede.CodAlterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno;
                   addressSede.Descripcion_sede = info.DescripcionSede.Trim();
                   addressSede.estado = info.Estado.Trim();
                   addressSede.FechaCreacion = DateTime.Now;
                   addressSede.FechaModificacion = DateTime.Now;
                   addressSede.UsuarioCreacion = info.UsuarioCreacion.Trim();
                   addressSede.UsuarioModificacion = info.UsuarioModificacion.Trim();
                   addressSede.IdEmpresa = info.IdEmpresa;
                   addressSede.IdSucursal = info.IdSucursal;

                   Base.Aca_Sede.Add(addressSede);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar la Sede #: " + IdSede.ToString() + " exitosamente.";
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

       public bool ActualizarDB(Aca_Sede_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var vSede = Base.Aca_Sede.FirstOrDefault(j => j.IdInstitucion == info.IdInstitucion && j.IdSede == info.IdSede);

                   if (vSede != null)
                   {
                       vSede.CodSede = string.IsNullOrEmpty(info.CodSede) ? info.IdSede.ToString() : info.CodSede.Trim();
                       vSede.CodAlterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno.Trim();
                       vSede.Descripcion_sede = info.DescripcionSede.Trim();
                       vSede.estado = info.Estado.Trim();
                       vSede.FechaModificacion = DateTime.Now;
                       vSede.UsuarioModificacion = info.UsuarioModificacion;
                       vSede.IdEmpresa = info.IdEmpresa;
                       vSede.IdSucursal = info.IdSucursal;

                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar la Sede #: " + info.IdSede.ToString() + " exitosamente.";
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
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean AnularDB(Aca_Sede_Info info, ref string msg)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_Sede.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdSede == info.IdSede);

                   if (address != null)
                   {
                       address.estado = "I";
                       address.FechaAnulacion = DateTime.Now;
                       address.UsuarioAnulacion = info.UsuarioAnulacion;
                       address.MotivoAnulacion = info.MotivoAnulacion;
                       context.SaveChanges();
                       msg = "Se ha procedido anular la Sede #: " + info.IdSede.ToString() + " exitosamente.";
                   }
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               msg = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
               msg = "Se ha producido el siguiente error: " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
    }
}
