using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Npgsql;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Matricula_Data
    {
      string mensaje = "";

      public bool ValidaEstudiante(decimal idEstudiante, int IdAnioLectivo)
      {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  int existe = (from m in Base.Aca_matricula
                                where m.IdEstudiante == idEstudiante && m.IdAnioLectivo == IdAnioLectivo
                                select m).Count();

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

      public List<Aca_Matricula_Info> Get_List_Matricula(int IdInstitucion) {
          List<Aca_Matricula_Info> lstMatricula = new List<Aca_Matricula_Info>();
          Aca_Matricula_Info matriculaInfo;
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vmatricula= from m in Base.vwAca_matricula
                                  where m.IdInstitucion == IdInstitucion
                                  orderby m.IdMatricula
                                  select m;

                  foreach (var item in vmatricula )
                  {
                      matriculaInfo = new Aca_Matricula_Info();
                      matriculaInfo.IdInstitucion = item.IdInstitucion;
                      matriculaInfo.IdMatricula = item.IdMatricula;
                      matriculaInfo.CodMatricula = item.CodMatricula;
                      matriculaInfo.IdEstudiante = item.IdEstudiante;
                      matriculaInfo.IdFamiliar_repre_econ = item.IdFamiliar_repre_econ;
                      matriculaInfo.IdFamiliar_repre_legal = item.IdFamiliar_repre_legal;      
                
                      //matriculaInfo.IdPeriodoLectivo = item.IdPeriodoLectivo;
                      matriculaInfo.IdAnioLectivo = item.IdAnioLectivo;

                      matriculaInfo.Observacion = item.Observacion;
                      matriculaInfo.IdEstudiante = item.IdEstudiante;                      
                      matriculaInfo.estudianteInfo.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                      matriculaInfo.estudianteInfo.Persona_Info.pe_nombre = item.pe_nombre;
                      matriculaInfo.estudianteInfo.Persona_Info.pe_apellido = item.pe_apellido;
                      matriculaInfo.IdParalelo = item.IdParalelo;
                      matriculaInfo.IdCurso = item.IdCurso;
                      matriculaInfo.IdJornada = item.IdJornada;
                      matriculaInfo.IdSeccion = item.IdSeccion;
                      matriculaInfo.IdSede = item.IdSede;
                      matriculaInfo.Si_estoy_deacuerdo_foto = item.Si_estoy_deacuerdo_foto;
                      matriculaInfo.No_estoy_deacuerdo_foto = item.No_estoy_deacuerdo_foto;
                      matriculaInfo.Cod_convivencia_doy_fe = item.Cod_convivencia_doy_fe;
                      matriculaInfo.Fecha_matricula = item.Fecha_matricula;
                      matriculaInfo.Estado = item.estado;
                      //matriculaInfo.estado_matricula_con_contrato = item.estado_matricula_con_contrato;
                      lstMatricula.Add(matriculaInfo);
	                }
              }
              return lstMatricula;
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

      public Aca_Matricula_Info Get_Info(decimal IdMatricula)
      {
          List<Aca_Matricula_Info> lstMatricula = new List<Aca_Matricula_Info>();
          Aca_Matricula_Info matriculaInfo;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var vmatricula = from m in Base.vwAca_matricula
                                   where m.IdMatricula == IdMatricula
                                   orderby m.IdMatricula
                                   select m;

                  if (vmatricula.ToList().Count > 0)
                  {
                      matriculaInfo = new Aca_Matricula_Info();
                      foreach (var item in vmatricula)
                      {
                          matriculaInfo = new Aca_Matricula_Info();
                          matriculaInfo.IdInstitucion = item.IdInstitucion;
                          matriculaInfo.IdMatricula = item.IdMatricula;
                          matriculaInfo.CodMatricula = item.CodMatricula;
                          matriculaInfo.IdEstudiante = item.IdEstudiante;
                          matriculaInfo.IdFamiliar_repre_econ = item.IdFamiliar_repre_econ;
                          matriculaInfo.IdFamiliar_repre_legal = item.IdFamiliar_repre_legal;

                          //matriculaInfo.IdPeriodoLectivo = item.IdPeriodoLectivo;
                          matriculaInfo.IdAnioLectivo = item.IdAnioLectivo;

                          matriculaInfo.Observacion = item.Observacion;
                          matriculaInfo.IdEstudiante = item.IdEstudiante;
                          matriculaInfo.estudianteInfo.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                          matriculaInfo.estudianteInfo.Persona_Info.pe_nombre = item.pe_nombre;
                          matriculaInfo.estudianteInfo.Persona_Info.pe_apellido = item.pe_apellido;
                          matriculaInfo.IdParalelo = item.IdParalelo;
                          matriculaInfo.IdCurso = item.IdCurso;
                          matriculaInfo.IdJornada = item.IdJornada;
                          matriculaInfo.IdSeccion = item.IdSeccion;
                          matriculaInfo.IdSede = item.IdSede;
                          matriculaInfo.Si_estoy_deacuerdo_foto = item.Si_estoy_deacuerdo_foto;
                          matriculaInfo.No_estoy_deacuerdo_foto = item.No_estoy_deacuerdo_foto;
                          matriculaInfo.Cod_convivencia_doy_fe = item.Cod_convivencia_doy_fe;
                          matriculaInfo.Fecha_matricula = item.Fecha_matricula;
                          matriculaInfo.Estado = item.estado;

                      }
                      return matriculaInfo;
                  }
                  else
                      return new Aca_Matricula_Info();
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



      public List<Aca_Matricula_Info> Get_List_Estudiante_Matricula_Con_y_Sin_Contrato(int IdInstitucion, int IdSede)
      {
          try
          {


              List<Aca_Matricula_Info> lista = new List<Aca_Matricula_Info>();
              using (Entities_Academico Base = new Entities_Academico())
              {
                  var context = from c in Base.vwAca_Estudiante_Matricula_Con_y_Sin_Contrato
                                where c.IdInstitucion == IdInstitucion
                                      && c.IdSede == IdSede
                                select c;
                  if (context != null)
                  {
                      foreach (var item in context)
                      {
                          Aca_Matricula_Info Matricula_x_Estudiante_Info = new Aca_Matricula_Info();
                          Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;

                          Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                          Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                          Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                          Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                          Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                          Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                          Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;

                          //Matricula_x_Estudiante_Info.IdPeriodoLectivo = item.IdPeriodoLectivo;

                          Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                          Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                          Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                          Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                          Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                          Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                          Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                          Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                          Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                          Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                          Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;

                          Matricula_x_Estudiante_Info.nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                          Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                          Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                          Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                          Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
                          Matricula_x_Estudiante_Info.Fecha_matricula = item.FechaMatricula;
                          Matricula_x_Estudiante_Info.FechaCreacionEstudiante = Convert.ToDateTime(item.FechaCreacionEstudiante);

                          Matricula_x_Estudiante_Info.IdContrato = Convert.ToDecimal(item.IdContrato == 0 ? null : item.IdContrato);

                          //Matricula_x_Estudiante_Info.estado_matricula_con_contrato = item.estado_matricula_con_contrato;

                          lista.Add(Matricula_x_Estudiante_Info);
                      }
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
              throw new Exception(ex.InnerException.ToString());
          }
      }


      public decimal GetId(int IdInstitucion, int IdSede)
      {
          decimal Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_matricula
                            select q).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_matricula
                                   where q.IdInstitucion==IdInstitucion
                                      && q.IdSede==IdSede                                   
                                   select q.IdMatricula).Max();
                  if (select_as.ToString() != null) 
                  {
                      Id = Convert.ToInt32(select_as.ToString()) + 1;
                  }
                  else
                  {
                      Id = 0;
                  }
                  
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              string MensajeError = string.Empty;
              Core.Erp.Data.General.tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public bool GrabarDB(Aca_Matricula_Info info,ref decimal IdMatricula, ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  Aca_matricula matricula = new Aca_matricula();
                  matricula.IdInstitucion = info.IdInstitucion;
                  matricula.IdSede = info.IdSede;
                  IdMatricula = GetId(info.IdInstitucion, info.IdSede);
                  matricula.IdMatricula = IdMatricula;
                  matricula.CodMatricula = string.IsNullOrEmpty(info.CodMatricula) ? IdMatricula.ToString() : info.CodMatricula;

                  //matricula.IdAnioLectivo = Convert.ToString(info.IdPeriodoLectivo);  //El Info trae el IdPeriodoLectivo                
                  matricula.IdAnioLectivo = info.IdAnioLectivo;
                  
                  matricula.IdEstudiante = info.IdEstudiante;
                  matricula.IdFamiliar_repre_econ = info.IdFamiliar_repre_econ==0?null:info.IdFamiliar_repre_econ;
                  matricula.IdFamiliar_repre_legal = info.IdFamiliar_repre_legal==0?null:info.IdFamiliar_repre_legal;
                  matricula.IdParalelo = info.IdParalelo;
                  matricula.Observacion = info.Observacion;
                  matricula.estado = info.Estado;
                  matricula.UsuarioCreacion = info.UsuarioCreacion;
                  matricula.Fecha_matricula = info.Fecha_matricula;
                  matricula.FechaCreacion = DateTime.Now;
                  matricula.Si_estoy_deacuerdo_foto = info.Si_estoy_deacuerdo_foto;
                  matricula.No_estoy_deacuerdo_foto = info.No_estoy_deacuerdo_foto;
                  matricula.Cod_convivencia_doy_fe = info.Cod_convivencia_doy_fe;

                  Base.Aca_matricula.Add(matricula);
                  Base.SaveChanges(); 
                  mensaje = "Se ha procedido a grabar la Matricula #: " + IdMatricula.ToString() + " exitosamente.";
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

      public bool ActualizarDB(Aca_Matricula_Info info, ref string mensaje) {
          try
          {
              using (Entities_Academico Base=new Entities_Academico())
              {
                  var vmatricula = Base.Aca_matricula.FirstOrDefault(m=>m.IdInstitucion==info.IdInstitucion && m.IdSede==info.IdSede && m.IdMatricula==info.IdMatricula);
                  if (vmatricula != null)
                  {
                      vmatricula.CodMatricula = info.CodMatricula;
                      vmatricula.IdFamiliar_repre_legal = info.IdFamiliar_repre_legal == 0 ? null : info.IdFamiliar_repre_legal;
                      vmatricula.IdFamiliar_repre_econ = info.IdFamiliar_repre_econ == 0 ? null : info.IdFamiliar_repre_econ;
                      vmatricula.Observacion = info.Observacion;
                      vmatricula.Fecha_matricula = info.Fecha_matricula;
                      vmatricula.FechaModificacion = DateTime.Now;
                      vmatricula.UsuarioModificacion = info.UsuarioModificacion;
                      vmatricula.Si_estoy_deacuerdo_foto = info.Si_estoy_deacuerdo_foto;
                      vmatricula.No_estoy_deacuerdo_foto = info.No_estoy_deacuerdo_foto;
                      vmatricula.Cod_convivencia_doy_fe = info.Cod_convivencia_doy_fe;
                      vmatricula.IdParalelo = info.IdParalelo;
                      vmatricula.estado = info.Estado;
                      //vmatricula.estado_matricula_con_contrato = info.estado_matricula_con_contrato;
                      Base.SaveChanges();
                      mensaje = "Se ha procedido actualizar la Matricula #: " + info.IdMatricula.ToString() + " exitosamente.";
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

      public Boolean AnularDB(Aca_Matricula_Info info, ref string msg)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_matricula.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdSede==info.IdSede && a.IdMatricula==info.IdMatricula);

                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      context.SaveChanges();
                      msg = "Se ha procedido anular la Matricula #: " + info.IdMatricula.ToString() + " exitosamente.";
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


      public Boolean actualizar_Estado_Matricula_Postgres(Aca_Matricula_Info matricula, ref string msg)
      {
        
          try
          {
              string Estado = "EST_MATRI_MATRICULADO";
               Coneccion_Postgres_Data conex = new Coneccion_Postgres_Data();
                NpgsqlConnection cone = new NpgsqlConnection();
                cone = conex.conectar();
              //string sql = "exec sp_actualizar_estado_matricula("+ matricula.Estado+ "," +matricula.IdMatricula+","+ matricula.IdAnioLectivo +")";
                string sql = "UPDATE matricula SET estado='" + Estado + "', fecha_modificacion = current_timestamp WHERE id=" + matricula.IdMatricula +" and id_anio_lectivo=" + Convert.ToDecimal(matricula.IdAnioLectivo);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, cone);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                cone.Close();
                msg = "Se ha procedido actualizar el estado de la Matricula #: " + matricula.IdMatricula.ToString() + " exitosamente.";
                return true;
              
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


      public decimal Busca_Matricula(decimal idEstudiante)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  decimal idMatricula = (from m in Base.Aca_matricula
                                where m.IdEstudiante == idEstudiante 
                                select m.IdMatricula).FirstOrDefault();

                  return idMatricula;
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
    }
}
