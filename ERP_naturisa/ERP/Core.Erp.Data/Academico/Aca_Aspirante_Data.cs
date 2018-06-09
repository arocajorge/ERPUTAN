using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Academico
{
  public  class Aca_Aspirante_Data
  {
      string mensaje = "";
      #region "Get"

      public int getId(int IdInstitucion)
      {
          int Id = 0;
          try
          {
              Entities_Academico Base = new Entities_Academico();
              int select = (from q in Base.Aca_Aspirante
                            where q.IdInstitucion == IdInstitucion
                           select q ).Count();

              if (select == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_as = (from q in Base.Aca_Aspirante
                                   where q.IdInstitucion == IdInstitucion
                                   select q.IdAspirante).Max();
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

      public List<Aca_Aspirante_Info> Get_List_Aspirante(int IdInstitucion) {
          List<Aca_Aspirante_Info> lstAspirante = new List<Aca_Aspirante_Info>();
          try
          {
              using(Entities_Academico Base=new Entities_Academico())
              {
                  var vaspirante =  from a in Base.vwAca_aspirante
                                    where a.IdInstitucion == IdInstitucion
                                    orderby a.IdAspirante
                                    select a;

                  foreach (var item in vaspirante)
                  {
                      Aca_Aspirante_Info info = new Aca_Aspirante_Info();
                      info.IdInstitucion = item.IdInstitucion;
                      info.IdAspirante = item.IdAspirante;
                      info.CodAspirante = item.cod_aspirante;
                      info.CodAlterno = item.cod_alterno;                      
                      info.Lugar = item.lugar;
                      info.Barrio = item.barrio;                      
                      info.Estado = item.estado;

                      tb_persona_Info personaInfo = new tb_persona_Info();
                      personaInfo.IdPersona = item.IdPersona;
                      personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                      personaInfo.pe_apellido = item.pe_apellido;
                      personaInfo.pe_nombre = item.pe_nombre;
                      personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                      personaInfo.pe_correo = item.pe_correo;
                      personaInfo.pe_celular = item.pe_celular;
                      personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                      personaInfo.pe_estado = item.estado;
                      personaInfo.pe_direccion = item.pe_direccion;
                      personaInfo.pe_sexo = item.pe_sexo;
                      personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;
                      info.Persona_Info = personaInfo;

                      tb_pais_Info paisInfo = new tb_pais_Info();
                      paisInfo.IdPais = item.IdPais_Nacionalidad;
                      paisInfo.Nacionalidad = item.Nacionalidad;
                      info.Pais_Info = paisInfo;

                      lstAspirante.Add(info);                      
                  }
              
              }
              return lstAspirante;
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
      #endregion

      #region "Insert,update, delete"
      public bool GrabarDB(Aca_Aspirante_Info info,ref decimal idAspirante,ref string msj) {
          try
          {
              Aca_Estudiante_Data daEstudiante = new Aca_Estudiante_Data();
              tb_persona_data Person_Data = new tb_persona_data();


               using (Entities_Academico context = new Entities_Academico())
                    {
                            try{
                                bool resultado=true;
                                Aca_Aspirante addressAspirante = new Aca_Aspirante();
                             
                                info.IdAspirante = idAspirante = getId(info.IdInstitucion);
                                decimal idPersona = 0;
                                if (info.Persona_Info.IdPersona == 0)
                                {
                                    if (Person_Data.ExisteCedula(info.Persona_Info.pe_cedulaRuc , ref msj) == false)
                                    {
                                        resultado = Person_Data.GrabarDB(info.Persona_Info, ref idPersona, ref msj);
                                    }
                                }
                                else {
                                    resultado = Person_Data.ModificarDB(info.Persona_Info, ref msj);
                                    idPersona = info.Persona_Info.IdPersona; 
                                }
                                
                                if (resultado)
                                {
                                    addressAspirante.IdInstitucion = info.IdInstitucion;
                                    addressAspirante.IdAspirante = info.IdAspirante;
                                    addressAspirante.IdPersona = idPersona;
                                    addressAspirante.cod_aspirante = (info.CodAspirante == null || info.CodAspirante.Trim() == "" || info.CodAspirante.Trim() == "0") ? info.IdAspirante.ToString() : info.CodAspirante;
                                    addressAspirante.lugar = info.Lugar;
                                    addressAspirante.barrio = info.Barrio;
                                    addressAspirante.foto = info.Foto;
                                    addressAspirante.cod_alterno = info.CodAlterno;
                                    addressAspirante.IdPais_Nacionalidad = info.Pais_Info.IdPais;
                                    addressAspirante.estado = info.Estado;
                                    addressAspirante.FechaCreacion = DateTime.Now;
                                    addressAspirante.UsuarioCreacion = info.UsuarioCreacion;
                                    context.Aca_Aspirante.Add(addressAspirante);
                                    context.SaveChanges();
                                    msj = "Se ha procedido a grabar el Aspirante #: " + idAspirante.ToString() + " exitosamente.";
                                }

                                return true;
                            }
                            //catch(Exception ex)
                            //{
                            //    string arreglo = ToString();
                            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                            //                        "", "", "", "", DateTime.Now);
                            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                            //    msj = ex.InnerException + " " + ex.Message;
                            //    return false;                
                            //}   
                            catch (DbEntityValidationException ex)
                            {
                                string arreglo = ToString();
                                foreach (var item in ex.EntityValidationErrors)
                                {
                                    foreach (var item_validaciones in item.ValidationErrors)
                                    {
                                        mensaje = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                                    }
                                }
                                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(mensaje, "", arreglo, "", "", "", "", "", DateTime.Now);
                                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                                throw new Exception(mensaje);
                            }
                      }          
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Boolean ActualizarDB(Aca_Aspirante_Info info, ref string msj)
      {
          try
          {
              Aca_Estudiante_Data daEstudiante = new Aca_Estudiante_Data();
              using (Entities_Academico context = new Entities_Academico())
              {
                  var estudiante = context.Aca_Aspirante.FirstOrDefault(obj => obj.IdInstitucion == info.IdInstitucion && obj.IdAspirante == info.IdAspirante);
                  if (estudiante != null)
                  {
                      decimal idAspirante = info.IdAspirante;
                      estudiante.cod_aspirante = string.IsNullOrEmpty(info.CodAspirante) ? info.IdAspirante.ToString() : info.CodAspirante;
                      estudiante.IdPersona = info.Persona_Info.IdPersona;
                      estudiante.IdPais_Nacionalidad = info.Pais_Info.IdPais;
                      estudiante.lugar = (info.Lugar == null) ? "" : info.Lugar;
                      estudiante.FechaModificacion = DateTime.Now;
                      estudiante.UsuarioModificacion = info.UsuarioModificacion;
                      estudiante.foto = info.Foto;
                      estudiante.estado = info.Estado;
                      estudiante.barrio = (info.Barrio == null) ? "" : info.Barrio;

                      context.SaveChanges();
                      tb_persona_data Persona_Data = new tb_persona_data();
                      Persona_Data.ModificarDB (info.Persona_Info, ref msj);

                      msj = "Se ha procedido actualizar el Aspirante #: " + idAspirante.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }


      public Boolean AnularDB(Aca_Aspirante_Info info, ref string msj)
      {
          try
          {
              using (Entities_Academico context = new Entities_Academico())
              {
                  var address = context.Aca_Aspirante.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdAspirante == info.IdAspirante);
                  if (address != null)
                  {
                      address.estado = "I";
                      address.FechaAnulacion = DateTime.Now;
                      address.MotivoAnulacion = info.MotivoAnulacion;
                      address.UsuarioAnulacion = info.UsuarioAnulacion;
                      context.SaveChanges();
                      msj = "Se ha procedido anular al Aspirante #: " + info.IdAspirante.ToString() + " exitosamente.";
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }
      #endregion


      public bool ExisteCedula(int IdInstitucion, decimal IdAspirante, string cedulaRuc, ref string msj)
      {
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  if (IdAspirante == 0)
                  {
                      int existe = (from e in Base.vwAca_aspirante
                                    where e.IdInstitucion == IdInstitucion && e.pe_cedulaRuc == cedulaRuc
                                    select e).Count();

                      if (existe != 0)
                      {
                          msj = "Cédula o Ruc ya se encuentra ingresado.";
                          return true;
                      }
                      else { return false; }
                  }
                  else
                  {
                      var estudiante = Base.vwAca_aspirante.First(o => o.IdInstitucion == IdInstitucion && o.pe_cedulaRuc == cedulaRuc);
                      if (estudiante.IdAspirante != IdAspirante)
                      {
                          msj = "Cédula o Ruc ya se encuentra ingresado.";
                          return true;
                      }
                      else { return false; }
                  }
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public Aca_Aspirante_Info Get_Info_Aspirante(decimal IdPersona, ref string msj)
      {

          try
          {

              Entities_Academico Base = new Entities_Academico();
              var select_ = from C in Base.Aca_Aspirante
                            where C.IdPersona == IdPersona
                            select C;


              Aca_Aspirante_Info AspInfo = new Aca_Aspirante_Info();

              foreach (var item in select_)
              {
                  AspInfo.IdAspirante = item.IdAspirante;
                  AspInfo.Persona_Info.IdPersona = item.IdPersona;
                  AspInfo.CodAspirante = item.cod_aspirante;
              }

              return (AspInfo);
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              msj = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

  }
}
