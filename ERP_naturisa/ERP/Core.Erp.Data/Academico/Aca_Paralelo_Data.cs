using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;

namespace Core.Erp.Data.Academico
{
   public class Aca_Paralelo_Data
    {
       string mensaje = "";
       public int GetId(int IdInstitucion)
       {
           int Id = 0;
           try
           {
               Entities_Academico Base = new Entities_Academico();
               int select = (from q in Base.Aca_Paralelo
                             join cu in Base.Aca_curso on q.IdCurso equals cu.IdCurso
                             join sec in Base.Aca_Seccion on cu.IdSeccion equals sec.IdSeccion
                             join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                             join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                             where sed.IdInstitucion== IdInstitucion
                             select q).Count();

               if (select == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_as = (from q in Base.Aca_Paralelo
                                    join cu in Base.Aca_curso on q.IdCurso equals cu.IdCurso
                                    join sec in Base.Aca_Seccion on cu.IdSeccion equals sec.IdSeccion
                                    join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                                    join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                                    where sed.IdInstitucion == IdInstitucion
                                    select q.IdParalelo).Max();
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

       public List<Aca_Paralelo_Info> Get_List_Paralelo(int IdCurso) {
           List<Aca_Paralelo_Info> listaParalelo = new List<Aca_Paralelo_Info>();
           try
           {
               Aca_Paralelo_Info paraleloInfo;
               using(Entities_Academico Base=new Entities_Academico())
	            {
                    var vParalelo = from p in Base.Aca_Paralelo
                                    where p.IdCurso == IdCurso
                                    select p;
                    foreach (var item in vParalelo)
                    {
                        paraleloInfo = new Aca_Paralelo_Info();
                        paraleloInfo.CodParalelo = item.CodParalelo;
                        paraleloInfo.CodAlterno = item.CodAlterno;
                        paraleloInfo.IdParalelo = item.IdParalelo;
                        paraleloInfo.IdCurso = item.IdCurso;
                        paraleloInfo.DescripcionParalelo = item.Descripcion_paralelo;
                        paraleloInfo.Estado = item.Estado;  
                      
                        listaParalelo.Add(paraleloInfo);
                    }
	            }
               return listaParalelo;
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

       public bool GrabarDB(Aca_Paralelo_Info info, ref int idParalelo, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   Aca_Paralelo addressPara = new Aca_Paralelo();                   
                   idParalelo = GetId(info.IdInstitucion);
                   addressPara.IdParalelo = idParalelo;
                   addressPara.Descripcion_paralelo = info.DescripcionParalelo;
                   addressPara.CodParalelo = (info.CodParalelo == "0" || string.IsNullOrEmpty(info.CodParalelo) == true) ? idParalelo.ToString() : info.CodParalelo;
                   addressPara.CodAlterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno;
                   addressPara.IdCurso = info.IdCurso;
                   addressPara.Estado = info.Estado;
                   addressPara.FechaCreacion = DateTime.Now;
                   addressPara.FechaModificacion = DateTime.Now;
                   addressPara.UsuarioCreacion = info.UsuarioCreacion;                   
                   addressPara.UsuarioModificacion = info.UsuarioModificacion;

                   Base.Aca_Paralelo.Add(addressPara);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar la Jornada #: " + idParalelo.ToString() + " exitosamente.";
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

       public bool ActualizarDB(Aca_Paralelo_Info info, ref string mensaje)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var vparalelo = Base.Aca_Paralelo.FirstOrDefault(j => j.IdParalelo == info.IdParalelo);
                   if (vparalelo != null)
                   {
                       vparalelo.Descripcion_paralelo = info.DescripcionParalelo;
                       vparalelo.CodParalelo = string.IsNullOrEmpty(info.CodParalelo) ? info.IdParalelo.ToString() : info.CodParalelo;
                       vparalelo.CodAlterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno;
                       vparalelo.IdCurso = info.IdCurso;
                       vparalelo.Estado = info.Estado;
                       vparalelo.FechaModificacion = DateTime.Now;
                       vparalelo.UsuarioModificacion = info.UsuarioModificacion;

                       Base.SaveChanges();
                       mensaje = "Se ha procedido actualizar el Paralelo #: " + info.IdParalelo.ToString() + " exitosamente.";
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

       public Boolean AnularDB(Aca_Paralelo_Info info, ref string msg)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_Paralelo.FirstOrDefault(a => a.IdParalelo == info.IdParalelo);

                   if (address != null)
                   {
                       address.Estado = "I";
                       address.FechaAnulacion = DateTime.Now;
                       address.UsuarioAnulacion = info.UsuarioAnulacion;
                       address.MotivoAnulacion = info.MotivoAnulacion;
                       context.SaveChanges();
                       msg = "Se ha procedido anular Paralelo #: " + info.IdParalelo.ToString() + " exitosamente.";
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
