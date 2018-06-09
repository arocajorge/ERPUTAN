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
  public  class Aca_Familiar_Data
  {
      string MensajeError = "";

      #region "Get"
      public bool ExisteFamiliar(Aca_Familiar_Info infoFamiliar) {
          try
          {
              int contarFamiliar = 0;
              using (Entities_Academico Base=new Entities_Academico())
              {
                  
                  contarFamiliar = (from f in Base.Aca_Familiar
                                        where f.IdInstitucion == infoFamiliar.IdInstitucion &&
                                              //f.IdEstudiante == infoFamiliar.IdEstudiante &&
                                              f.IdPersona == infoFamiliar.Persona_Info.IdPersona
                                        select f).Count();               

                  if (contarFamiliar > 0)
                  {
                      return true;
                  }
                  else
                  {
                      //contarFamiliar = (from f in Base.Aca_Familiar_x_Estudiante
                      //                  where f.IdInstitucion == infoFamiliar.IdInstitucion //&&
                      //                       //f.IdPersona == infoFamiliar.Persona_Info.IdPersona
                      //                  select f).Count();
                      //if (contarFamiliar > 0)
                      //{
                      //    return true;
                      //}
                      //else
                      //{
                      //    return false;
                      //}
                      return false;
                  }
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public int GetIdFamiliar(int IdInstitucion, decimal IdPersona, ref string msj)
      {
          int Id = 0;
          try
          {
              Entities_Academico OEEstudiante = new Entities_Academico();
              var select = (from q in OEEstudiante.Aca_Familiar
                            where q.IdInstitucion == IdInstitucion
                            && q.IdPersona == IdPersona
                            select q).FirstOrDefault();
              if (select == null)
              {
                  int select_id = (from q in OEEstudiante.Aca_Familiar
                                   where q.IdInstitucion == IdInstitucion
                                   select q.IdFamiliar).Count();

                  if (select_id == 0)
                  {
                      Id = 1;
                  }
                  else
                  {
                      var select_fam = (from q in OEEstudiante.Aca_Familiar
                                        where q.IdInstitucion == IdInstitucion
                                        select q.IdFamiliar).Max();
                      Id = Convert.ToInt32(select_fam.ToString()) + 1;
                  }

              }
              else
              {
                  
                  msj = "ExisteFamiliar";
                  Id = Convert.ToInt16( select.IdFamiliar);
              }
              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public decimal GetIdFamiliarxIdPersona(int IdInstitucion, decimal IdPersona)
      {
          int Id = 0;
          decimal idFamiliar;
          try
          {
              Entities_Academico OEEstudiante = new Entities_Academico();
              var select = (from q in OEEstudiante.Aca_Familiar
                            where q.IdInstitucion == IdInstitucion && q.IdPersona == IdPersona
                            select q.IdFamiliar).FirstOrDefault();
              if (select == null || select == 0)
              {
                  idFamiliar = 0;
              }
              else
              {
                  idFamiliar = Convert.ToDecimal(select.ToString());
              }
              return idFamiliar;

            
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      //revisar ya que esto es una vista y las tablas ya se modificaron
      public Aca_Familiar_Info GetFamiliar_x_Estudiante(string cedulaRuc, ref bool existePersona)
      {
          Aca_Familiar_Info infoFami = new Aca_Familiar_Info();
          string msj = string.Empty;
          existePersona = false;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  vwAca_Familiar_x_Estudiante familiar = Base.vwAca_Familiar_x_Estudiante.FirstOrDefault(o => o.pe_cedulaRuc == cedulaRuc);
                  if (familiar != null)
                  {
                      infoFami.Persona_Info.IdPersona = Convert.ToDecimal(familiar.IdPersona);
                      infoFami.Persona_Info.pe_nombre = familiar.pe_nombre;
                      infoFami.Persona_Info.pe_apellido = familiar.pe_apellido;
                      infoFami.Persona_Info.pe_cedulaRuc = familiar.pe_cedulaRuc;
                      infoFami.Persona_Info.pe_direccion = familiar.pe_direccion;
                      infoFami.Persona_Info.pe_fechaNacimiento = familiar.pe_fechaNacimiento;
                      infoFami.Persona_Info.IdEstadoCivil = familiar.IdEstadoCivil;
                      infoFami.IdNivelEducativo = (familiar.IdNivelEducativo_cat == "") ? "SIN_EDU" : familiar.IdNivelEducativo_cat;
                      infoFami.Titulo = familiar.Titulo;
                      infoFami.EmpresaDireccion = familiar.empresa_direccion;
                      infoFami.EmpresaDondeTrabaja = familiar.empresa_donde_trabaja;
                      infoFami.EmpresaEmail = familiar.empresa_email;
                      infoFami.EmpresaTelefono = familiar.empresa_telefono;
                      infoFami.Persona_Info.pe_telefonoCasa = familiar.pe_telefonoCasa;
                      infoFami.Calle_Principal = familiar.Calle_Principal;
                      infoFami.Calle_Secundaria = familiar.Calle_Secundaria;
                      infoFami.Fallecido = Convert.ToBoolean(familiar.Fallecido);
                      infoFami.FueExAlumnoGraduado = Convert.ToBoolean(familiar.FueExAlumnoGraduado);
                      infoFami.IdCatalogoIdiomaNativo = familiar.IdCatalogoIdiomaNativo;
                      infoFami.IdCatalogoReligion = familiar.IdCatalogoReligion;
                      infoFami.IdCatalogoTipoSangre = familiar.IdCatalogoTipoSangre;
                      infoFami.PoseeDiscapacidad = Convert.ToBoolean(familiar.PoseeDiscapacidad);
                      infoFami.Sector_Urbanizacion = familiar.Sector_Urbanizacion;
                      infoFami.ViveFueraDelPais = Convert.ToBoolean(familiar.ViveFueraDelPais);
                      infoFami.IdCiudad = familiar.IdCiudad;
                      
                      existePersona = true;
                  }
                      return infoFami;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }

      //revisar ya que esto es una vista y las tablas ya se modificaron
      public Aca_Familiar_Info GetFamiliar_x_Estudiante(decimal IdEstudiante, string cedulaRucFamiliar, ref bool existePersona)
      {
          Aca_Familiar_Info infoFami = new Aca_Familiar_Info();
          string msj = string.Empty;
          existePersona = false;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  vwAca_Familiar_x_Estudiante familiar = Base.vwAca_Familiar_x_Estudiante.FirstOrDefault(o => o.IdEstudiante==IdEstudiante && o.pe_cedulaRuc == cedulaRucFamiliar && o.activo == true);
                  if (familiar!=null)
                  {
                      infoFami.IdFamiliar = familiar.IdFamiliar;
                      infoFami.Persona_Info.IdPersona = Convert.ToDecimal(familiar.IdPersona);
                      infoFami.Persona_Info.pe_nombre = familiar.pe_nombre;
                      infoFami.Persona_Info.pe_apellido = familiar.pe_apellido;
                      infoFami.Persona_Info.pe_cedulaRuc = familiar.pe_cedulaRuc;
                      infoFami.Persona_Info.pe_direccion = familiar.pe_direccion;
                      infoFami.Persona_Info.pe_fechaNacimiento = familiar.pe_fechaNacimiento;
                      infoFami.Persona_Info.IdEstadoCivil = familiar.IdEstadoCivil;
                      infoFami.IdNivelEducativo = (familiar.IdNivelEducativo_cat == "") ? "SIN_EDU" : familiar.IdNivelEducativo_cat;
                      infoFami.Titulo = familiar.Titulo;
                      infoFami.EmpresaDireccion = familiar.empresa_direccion;
                      infoFami.EmpresaDondeTrabaja = familiar.empresa_donde_trabaja;
                      infoFami.EmpresaEmail = familiar.empresa_email;
                      infoFami.EmpresaTelefono = familiar.empresa_telefono;
                      infoFami.Calle_Principal = familiar.Calle_Principal;
                      infoFami.Calle_Secundaria = familiar.Calle_Secundaria;
                      infoFami.Fallecido = Convert.ToBoolean(familiar.Fallecido);
                      infoFami.FueExAlumnoGraduado = Convert.ToBoolean(familiar.FueExAlumnoGraduado);
                      infoFami.IdCatalogoIdiomaNativo = familiar.IdCatalogoIdiomaNativo;
                      infoFami.IdCatalogoReligion = familiar.IdCatalogoReligion;
                      infoFami.IdCatalogoTipoSangre = familiar.IdCatalogoTipoSangre;
                      infoFami.PoseeDiscapacidad = Convert.ToBoolean(familiar.PoseeDiscapacidad);
                      infoFami.Sector_Urbanizacion = familiar.Sector_Urbanizacion;
                      infoFami.ViveFueraDelPais = Convert.ToBoolean(familiar.ViveFueraDelPais);
                      infoFami.IdCiudad = familiar.IdCiudad;
                      infoFami.ViveConEl = Convert.ToBoolean(familiar.Vive_con_el_estudiante);
                      infoFami.EstaAutorizadoRecAlumn = Convert.ToBoolean(familiar.esta_autorizado_recibir_not_mail);
                      infoFami.EstaAutorizadoRetAlum = Convert.ToBoolean(familiar.esta_autorizado_ret_alum);
                      infoFami.IdParentesco_cat = familiar.IdParentesco_cat;
                      infoFami.activo = Convert.ToBoolean(familiar.activo);


                      existePersona = true;    
                  }
                  
                  return infoFami;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }


      public Aca_Familiar_Info GetInfo_Familiar_x_IdPersona(decimal IdPersona, string cedulaRucFamiliar /*, ref bool existePersona*/)
      {
          Aca_Familiar_Info infoFami = new Aca_Familiar_Info();
          string msj = string.Empty;
          //existePersona = false;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  Aca_Familiar familiar = Base.Aca_Familiar.FirstOrDefault(o => o.IdPersona == IdPersona);
                  if (familiar != null)
                  {
                      infoFami.IdFamiliar = familiar.IdFamiliar;
                      infoFami.Persona_Info.IdPersona = Convert.ToDecimal(familiar.IdPersona);
                      //infoFami.Persona_Info.pe_nombre = familiar.pe_nombre;
                      //infoFami.Persona_Info.pe_apellido = familiar.pe_apellido;
                      //infoFami.Persona_Info.pe_cedulaRuc = familiar.pe_cedulaRuc;
                      //infoFami.Persona_Info.pe_direccion = familiar.pe_direccion;
                      //infoFami.Persona_Info.pe_fechaNacimiento = familiar.pe_fechaNacimiento;
                      //infoFami.Persona_Info.IdEstadoCivil = familiar.IdEstadoCivil;
                      infoFami.IdNivelEducativo = (familiar.IdNivelEducativo_cat == "") ? "SIN_EDU" : familiar.IdNivelEducativo_cat;
                      infoFami.Titulo = familiar.Titulo;
                      infoFami.EmpresaDireccion = familiar.empresa_direccion;
                      infoFami.EmpresaDondeTrabaja = familiar.empresa_donde_trabaja;
                      infoFami.EmpresaEmail = familiar.empresa_email;
                      infoFami.EmpresaTelefono = familiar.empresa_telefono;
                      infoFami.Calle_Principal = familiar.Calle_Principal;
                      infoFami.Calle_Secundaria = familiar.Calle_Secundaria;
                      infoFami.Fallecido = Convert.ToBoolean(familiar.Fallecido);
                      infoFami.FueExAlumnoGraduado = Convert.ToBoolean(familiar.FueExAlumnoGraduado);
                      infoFami.IdCatalogoIdiomaNativo = familiar.IdCatalogoIdiomaNativo;
                      infoFami.IdCatalogoReligion = familiar.IdCatalogoReligion;
                      infoFami.IdCatalogoTipoSangre = familiar.IdCatalogoTipoSangre;
                      infoFami.PoseeDiscapacidad = Convert.ToBoolean(familiar.PoseeDiscapacidad);
                      infoFami.Sector_Urbanizacion = familiar.Sector_Urbanizacion;
                      infoFami.ViveFueraDelPais = Convert.ToBoolean(familiar.ViveFueraDelPais);
                      infoFami.IdCiudad = familiar.IdCiudad;
                      //infoFami.ViveConEl = Convert.ToBoolean(familiar.Vive_con_el_estudiante);
                      //infoFami.EstaAutorizadoRecAlumn = Convert.ToBoolean(familiar.esta_autorizado_recibir_not_mail);
                      //infoFami.EstaAutorizadoRetAlum = Convert.ToBoolean(familiar.esta_autorizado_ret_alum);
                      //infoFami.IdParentesco_cat = familiar.IdParentesco_cat;
                      //infoFami.activo = Convert.ToBoolean(familiar.activo);


                      //existePersona = true;
                  }

                  return infoFami;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }


      public Aca_Familiar_Info GetRepre_Economico_x_Estudiante(int IdInstitucion, decimal IdEstudiante)
      {
          Aca_Familiar_Info infoFami = new Aca_Familiar_Info();
          string msj = string.Empty;
          try
          {
              using (Entities_Academico Base = new Entities_Academico())
              {
                  vwAca_Familiar_x_Estudiante_RepEco familiar = Base.vwAca_Familiar_x_Estudiante_RepEco.FirstOrDefault(o => o.IdEstudiante == IdEstudiante && o.activo == true && o.IdInstitucion == IdInstitucion);

                  if (familiar != null)
                  {
                      infoFami.IdInstitucion = familiar.IdInstitucion;
                      infoFami.IdEstudiante = familiar.IdEstudiante;
                      infoFami.IdFamiliar = familiar.IdFamiliar;
                      infoFami.Persona_Info.pe_apellido = familiar.Apellido;
                      infoFami.Persona_Info.pe_nombre = familiar.Nombre;
                      infoFami.Persona_Info.pe_cedulaRuc = familiar.Cedula;
                      infoFami.IdParentesco_cat = familiar.IdParentesco_cat;
                      infoFami.Persona_Info.IdPersona = Convert.ToDecimal(familiar.IdPersona);
                      infoFami.Titulo = familiar.Titulo;
                      infoFami.EmpresaTelefono = familiar.empresa_telefono;
                      infoFami.EmpresaDondeTrabaja = familiar.empresa_donde_trabaja;
                      infoFami.EmpresaDireccion = familiar.empresa_direccion;
                      infoFami.IdNivelEducativo = (familiar.IdNivelEducativo_cat == "") ? "SIN_EDU" : familiar.IdNivelEducativo_cat;
                      infoFami.activo = familiar.activo;
                  }

                  return infoFami;
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }


      public List<Aca_Familiar_Info> Get_List_Familiar_x_Estudiante(int IdInstitucion, decimal IdEstudiante)
      {
          List<Aca_Familiar_Info> lM = new List<Aca_Familiar_Info>();
          try
          {
              Entities_Academico db = new Entities_Academico();
              var select = from A in db.vwAca_Lista_Familiar_x_Estudiante
                           where A.IdInstitucion == IdInstitucion
                           && A.IdEstudiante == IdEstudiante
                           select A;

              foreach (var item in select)
              {
                  Aca_Familiar_Info info = new Aca_Familiar_Info();
                  info.IdInstitucion = item.IdInstitucion;
                  //info.IdEstudiante = item.IdEstudiante;
                  info.IdFamiliar = item.IdFamiliar;
                  info.CodFamiliar = item.cod_familiar;
                  info.EmpresaDondeTrabaja = item.empresa_donde_trabaja;
                  info.EmpresaDireccion = item.empresa_direccion;
                  info.EmpresaEmail = item.empresa_email;
                  info.EmpresaTelefono = item.empresa_telefono;
                  info.EstaAutorizadoRecAlumn = item.esta_autorizado_recibir_not_mail;
                  info.EstaAutorizadoRetAlum = item.esta_autorizado_ret_alum;
                  info.ViveConEl = item.Vive_con_el_estudiante;                  
                  info.IdNivelEducativo = item.IdNivelEducativo_cat;
                  info.IdParentescoCat = item.IdParentesco_cat;
                  info.OcupacionLaboral = item.OcupacionLaboral;
                  info.Titulo = item.Titulo;
                  info.Calle_Principal = item.Calle_Principal;
                  info.Calle_Secundaria = item.Calle_Secundaria;
                  info.Fallecido = Convert.ToBoolean(item.Fallecido);
                  info.FueExAlumnoGraduado = Convert.ToBoolean(item.FueExAlumnoGraduado);
                  info.IdCatalogoIdiomaNativo = item.IdCatalogoIdiomaNativo;
                  info.IdCatalogoReligion =  item.IdCatalogoReligion==null?"":item.IdCatalogoReligion.Trim();
                  info.IdCatalogoTipoSangre = item.IdCatalogoTipoSangre;
                  info.PoseeDiscapacidad = Convert.ToBoolean(item.PoseeDiscapacidad);
                  info.Sector_Urbanizacion = item.Sector_Urbanizacion;
                  info.ViveFueraDelPais = Convert.ToBoolean(item.ViveFueraDelPais);
                  info.IdCiudad = item.IdCiudad;
                  info.porcentaje_dual = item.porcentaje_dual;

                  using (EntitiesGeneral dbGe = new EntitiesGeneral())
                  {
                      var personaInfo = dbGe.tb_persona.First(p => p.IdPersona == item.IdPersona);
                      info.Persona_Info.IdPersona = personaInfo.IdPersona;
                      info.Persona_Info.pe_nombre = personaInfo.pe_nombre;
                      info.Persona_Info.pe_apellido = personaInfo.pe_apellido;
                      info.Persona_Info.pe_fechaNacimiento = personaInfo.pe_fechaNacimiento;
                      info.Persona_Info.pe_direccion = personaInfo.pe_direccion;
                      info.Persona_Info.pe_cedulaRuc = personaInfo.pe_cedulaRuc;
                      info.Persona_Info.pe_correo = personaInfo.pe_correo;
                      info.Persona_Info.pe_sexo = personaInfo.pe_sexo;
                      info.Persona_Info.pe_telefonoCasa = personaInfo.pe_telefonoCasa;
                      info.Persona_Info.pe_telefonoOfic = personaInfo.pe_telefonoOfic;
                      info.Persona_Info.IdTipoDocumento = personaInfo.IdTipoDocumento;
                      info.Persona_Info.IdEstadoCivil = personaInfo.IdEstadoCivil;
                      info.Persona_Info.pe_celular = personaInfo.pe_celular;
                  }


                  lM.Add(info);
              }
              return lM;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public List<tb_persona_Info> Get_List_Persona_Por_Estudiante_()
      {
          try
          {

              List<tb_persona_Info> lM = new List<tb_persona_Info>();
              Entities_Academico OEselecEmpresa = new Entities_Academico();
              var selectPersona = from C in OEselecEmpresa.vwAca_Familiar_no_Regis_Como_cliente
                                  select C;

              foreach (var item in selectPersona)
              {

                  tb_persona_Info Cbt = new tb_persona_Info();
                  Cbt.IdPersona = item.IdPersona;
                  Cbt.IdEstadoCivil = item.IdEstadoCivil.Trim();
                  Cbt.pe_apellido = item.pe_apellido;
                  Cbt.pe_nombre = item.pe_nombre;
                  Cbt.pe_casilla = item.pe_casilla;
                  Cbt.pe_cedulaRuc = item.pe_cedulaRuc;
                  Cbt.pe_celular = item.pe_celular;
                  Cbt.pe_correo = item.pe_correo;
                  Cbt.pe_direccion = item.pe_direccion;
                  Cbt.pe_estado = item.pe_estado.Trim();
                  Cbt.pe_fax = item.pe_fax;
                  Cbt.pe_fechaCreacion = item.pe_fechaCreacion;
                  Cbt.pe_fechaModificacion = item.pe_fechaModificacion;
                  Cbt.pe_fechaNacimiento = item.pe_fechaNacimiento;
                  Cbt.pe_Naturaleza = item.pe_Naturaleza.Trim();
                  Cbt.pe_nombreCompleto = item.pe_nombreCompleto;
                  Cbt.pe_razonSocial = item.pe_razonSocial;
                  Cbt.pe_sexo = item.pe_sexo.Trim();
                  Cbt.pe_telefonoCasa = item.pe_telefonoCasa;
                  Cbt.pe_telefonoInter = item.pe_telefonoInter;
                  Cbt.pe_telefonoOfic = item.pe_telefonoOfic;
                  Cbt.pe_telfono_Contacto = item.pe_telfono_Contacto;
                  Cbt.IdTipoDocumento = item.IdTipoDocumento.Trim();
                  Cbt.pe_UltUsuarioModi = item.pe_UltUsuarioModi;
                  Cbt.pe_celularSecundario = item.pe_celularSecundario;

                  Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                  Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;

                  Cbt.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                  Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                  Cbt.IdBanco_acreditacion = item.IdBanco_acreditacion;
                  
                  

                  lM.Add(Cbt);
              }

              return (lM);
          }

          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public List<Aca_Familiar_Info> Get_List_Familiar_x_Estudiante(int IdInstitucion)
      {
          List<Aca_Familiar_Info> lM = new List<Aca_Familiar_Info>();
          try
          {
              Entities_Academico db = new Entities_Academico();
              var select = from A in db.vwAca_Lista_Familiar_x_Estudiante
                           where A.IdInstitucion == IdInstitucion
                           && A.IdParentesco_cat == "REP_ECO"
                           select A;
             
              foreach (var item in select)
              {
                  Aca_Familiar_Info info = new Aca_Familiar_Info();
                  info.IdInstitucion = item.IdInstitucion;
                  info.IdFamiliar = item.IdFamiliar;
                  info.CodFamiliar = item.cod_familiar;
                  info.EmpresaDondeTrabaja = item.empresa_donde_trabaja;
                  info.EmpresaDireccion = item.empresa_direccion;
                  info.EmpresaEmail = item.empresa_email;
                  info.EmpresaTelefono = item.empresa_telefono;
                  info.EstaAutorizadoRecAlumn = item.esta_autorizado_recibir_not_mail;
                  info.EstaAutorizadoRetAlum = item.esta_autorizado_ret_alum;
                  info.ViveConEl = item.Vive_con_el_estudiante;
                  info.IdNivelEducativo = item.IdNivelEducativo_cat;
                  info.IdParentescoCat = item.IdParentesco_cat;
                  info.OcupacionLaboral = item.OcupacionLaboral;
                  info.Titulo = item.Titulo;
                  info.Calle_Principal = item.Calle_Principal;
                  info.Calle_Secundaria = item.Calle_Secundaria;
                  info.Fallecido = Convert.ToBoolean(item.Fallecido);
                  info.FueExAlumnoGraduado = Convert.ToBoolean(item.FueExAlumnoGraduado);
                  info.IdCatalogoIdiomaNativo = item.IdCatalogoIdiomaNativo;
                  info.IdCatalogoReligion = item.IdCatalogoReligion == null ? "" : item.IdCatalogoReligion.Trim();
                  info.IdCatalogoTipoSangre = item.IdCatalogoTipoSangre;
                  info.PoseeDiscapacidad = Convert.ToBoolean(item.PoseeDiscapacidad);
                  info.Sector_Urbanizacion = item.Sector_Urbanizacion;
                  info.ViveFueraDelPais = Convert.ToBoolean(item.ViveFueraDelPais);
                  info.IdCiudad = item.IdCiudad;
                  info.IdParentesco_cat = item.IdParentesco_cat;
                  using (EntitiesGeneral dbGe = new EntitiesGeneral())
                  {
                      var personaInfo = dbGe.tb_persona.First(p => p.IdPersona == item.IdPersona);
                      info.Persona_Info.IdPersona = personaInfo.IdPersona;
                      info.Persona_Info.pe_nombre = personaInfo.pe_nombre;
                      info.Persona_Info.pe_apellido = personaInfo.pe_apellido;
                      info.Persona_Info.pe_fechaNacimiento = personaInfo.pe_fechaNacimiento;
                      info.Persona_Info.pe_direccion = personaInfo.pe_direccion;
                      info.Persona_Info.pe_cedulaRuc = personaInfo.pe_cedulaRuc;
                      info.Persona_Info.pe_correo = personaInfo.pe_correo;
                      info.Persona_Info.pe_sexo = personaInfo.pe_sexo;
                      info.Persona_Info.pe_telefonoCasa = personaInfo.pe_telefonoCasa;
                      info.Persona_Info.pe_telefonoOfic = personaInfo.pe_telefonoOfic;
                      info.Persona_Info.IdTipoDocumento = personaInfo.IdTipoDocumento;
                      info.Persona_Info.IdEstadoCivil = personaInfo.IdEstadoCivil;
                      info.Persona_Info.pe_celular = personaInfo.pe_celular;
                  }

                  info.Nombres = info.Persona_Info.pe_apellido + " " + info.Persona_Info.pe_nombre;
                  info.check = false;
                  lM.Add(info);
              }
              return lM;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }

      public List<Aca_Familiar_Info> Get_List_RepreEco_x_Estudiante(int IdInstitucion)
      {
          List<Aca_Familiar_Info> lM = new List<Aca_Familiar_Info>();
          try
          {
              Entities_Academico db = new Entities_Academico();
             

              var lst = from q in db.vwAca_Lista_Familiar_x_Estudiante
                        where q.IdInstitucion == IdInstitucion &&
                        q.IdParentesco_cat == "REP_ECO"
                        group q by new { q.IdPersona, q.pe_apellido, q.pe_nombre, q.IdInstitucion, q.IdFamiliar, q.IdParentesco_cat }
                            into grouping
                            select new { grouping.Key };

              foreach (var item in lst)
              {

                  Aca_Familiar_Info info = new Aca_Familiar_Info();
                  info.IdPersona = item.Key.IdPersona;
                  info.Persona_Info.pe_apellido = item.Key.pe_apellido;
                  info.Persona_Info.pe_nombre = item.Key.pe_nombre;
                  info.IdInstitucion = item.Key.IdInstitucion;
                  info.IdFamiliar = item.Key.IdFamiliar;
                  info.Nombres = info.Persona_Info.pe_apellido + " " + info.Persona_Info.pe_nombre;
                  info.IdParentesco_cat = item.Key.IdParentesco_cat;
                  info.check = false;
                  lM.Add(info);
              }
              return lM;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              MensajeError = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              throw new Exception(ex.ToString());
          }
      }


      #endregion

      #region "Grabar,Actualizar"
      public bool GrabarDB(Aca_Familiar_Info info,bool actualizarPersona,ref string msj, ref decimal IdFam)
      {    bool resultado =false;
          try
          {
              tb_persona_data Persona_Data = new tb_persona_data();
              tb_persona_Info Info_Persona= new tb_persona_Info();

              Aca_Estudiante_Data daEstudiante = new Aca_Estudiante_Data();
              decimal idPersona = 0;


              if (info.Persona_Info.IdPersona == 0)
              {
                  // la persona si no existe se la crea
                  if (Persona_Data.ExisteCedula(info.Persona_Info.pe_cedulaRuc, ref msj) == false)
                  {
                      resultado = Persona_Data.GrabarDB(info.Persona_Info, ref idPersona, ref msj);
                  }
                  else
                  {
                      Info_Persona=Persona_Data.Get_Info_Persona(info.Persona_Info.pe_cedulaRuc);
                      idPersona = Info_Persona.IdPersona;

                      resultado = true;
                  }
                                

              }
              else 
              {
                  if (actualizarPersona)
                  {
                      resultado = Persona_Data.ModificarDB(info.Persona_Info, ref msj);
                  }
                  else { resultado = true; }
                  idPersona = info.Persona_Info.IdPersona;
              }
              
              if (resultado)
              {
                  using (Entities_Academico Base = new Entities_Academico())
                  {
                      string mensaje = string.Empty;
                      Aca_Familiar infoFamiliar = new Aca_Familiar();
                      infoFamiliar.IdInstitucion = info.IdInstitucion;                      
                      if (info.Persona_Info.IdPersona != 0)
                      {
                          IdFam = GetIdFamiliar(info.IdInstitucion, info.Persona_Info.IdPersona , ref mensaje);
                      }
                      else
                      {
                          IdFam = GetIdFamiliar(info.IdInstitucion, idPersona,ref mensaje);

                      }
                      if (mensaje != "ExisteFamiliar")
                      {
                          infoFamiliar.IdFamiliar = IdFam;
                          infoFamiliar.cod_familiar = infoFamiliar.IdFamiliar.ToString();
                          infoFamiliar.IdNivelEducativo_cat = info.IdNivelEducativo;
                          infoFamiliar.IdPersona = idPersona;
                          infoFamiliar.empresa_donde_trabaja = (info.EmpresaDondeTrabaja == null) ? "" : info.EmpresaDondeTrabaja;
                          infoFamiliar.empresa_direccion = (info.EmpresaDireccion == null) ? "" : info.EmpresaDireccion;
                          infoFamiliar.empresa_email = (info.EmpresaEmail == null) ? "" : info.EmpresaEmail;
                          infoFamiliar.empresa_telefono = (info.EmpresaTelefono == null) ? "" : info.EmpresaTelefono;
                          infoFamiliar.OcupacionLaboral = (info.OcupacionLaboral == null) ? "" : info.OcupacionLaboral;
                          infoFamiliar.Titulo = (info.Titulo == null) ? "" : info.Titulo;
                          infoFamiliar.UsuarioCreacion = info.UsuarioCreacion;
                          infoFamiliar.FechaCreacion = DateTime.Now;
                          infoFamiliar.Calle_Principal = (info.Calle_Principal == null) ? "" : info.Calle_Principal;
                          infoFamiliar.Calle_Secundaria = (info.Calle_Secundaria == null) ? "" : info.Calle_Secundaria;
                          infoFamiliar.Sector_Urbanizacion = (info.Sector_Urbanizacion == null) ? "" : info.Sector_Urbanizacion;
                          infoFamiliar.IdCiudad = info.IdCiudad;
                          infoFamiliar.PoseeDiscapacidad = info.PoseeDiscapacidad;
                          infoFamiliar.ViveFueraDelPais = info.ViveFueraDelPais;
                          infoFamiliar.Fallecido = info.Fallecido;
                          infoFamiliar.IdCatalogoIdiomaNativo = info.IdCatalogoIdiomaNativo;
                          infoFamiliar.IdCatalogoReligion = info.IdCatalogoReligion;
                          infoFamiliar.IdCatalogoTipoSangre = info.IdCatalogoTipoSangre;
                          infoFamiliar.FueExAlumnoGraduado = info.FueExAlumnoGraduado;

                          Base.Aca_Familiar.Add(infoFamiliar);
                          Base.SaveChanges();
                      }
                      
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }

      public bool ActualizarDB(Aca_Familiar_Info info, ref string msj)
      {
          bool resultado = false;
          bool accion_actualizarPersona = false;
          bool accion_actualizaFamiliar = false;
          decimal idFam = 0;
          try
          {
              Aca_Estudiante_Data da = new Aca_Estudiante_Data();
              tb_persona_data Persona_Data = new tb_persona_data();

              decimal idPersona = 0;
              if (info.Persona_Info.IdPersona == 0)
              {
                  if (Persona_Data.ExisteCedula(info.Persona_Info.pe_cedulaRuc , ref msj) == false)
                  {
                      resultado = Persona_Data.GrabarDB(info.Persona_Info, ref idPersona, ref msj);
                  }

                  info.Persona_Info.IdPersona = idPersona;
              }
              else
              {
                  resultado = Persona_Data.ModificarDB(info.Persona_Info, ref msj);
                  idPersona = info.Persona_Info.IdPersona;
                  accion_actualizaFamiliar = true;
              }

              if (info.IdFamiliar != 0 && accion_actualizaFamiliar)
              {
                  using (Entities_Academico Base = new Entities_Academico())
                  {
                      try
                      {
                          var familiarEst = Base.Aca_Familiar.FirstOrDefault(f => f.IdInstitucion == info.IdInstitucion &&
                                                                               //f.IdEstudiante == info.IdEstudiante &&
                                                                               f.IdFamiliar == info.IdFamiliar);

                          if (familiarEst != null)
                          {
                              familiarEst.IdPersona = idPersona;
                              familiarEst.OcupacionLaboral = info.OcupacionLaboral;
                              familiarEst.Titulo = info.Titulo;
                              familiarEst.UsuarioModificacion = info.UsuarioModificacion;                            

                              familiarEst.IdNivelEducativo_cat = info.IdNivelEducativo;
                              familiarEst.FechaModificacion = DateTime.Now;                             
                              familiarEst.empresa_donde_trabaja = info.EmpresaDondeTrabaja;
                              familiarEst.empresa_direccion = info.EmpresaDireccion;
                              familiarEst.empresa_email = info.EmpresaEmail;
                              familiarEst.empresa_telefono = info.EmpresaTelefono;
                              familiarEst.ViveFueraDelPais = info.ViveFueraDelPais;
                              familiarEst.Sector_Urbanizacion = info.Sector_Urbanizacion;
                              familiarEst.PoseeDiscapacidad = info.PoseeDiscapacidad;
                              familiarEst.IdCatalogoTipoSangre = info.IdCatalogoTipoSangre;
                              familiarEst.IdCatalogoReligion = info.IdCatalogoReligion;
                              familiarEst.IdCatalogoIdiomaNativo = info.IdCatalogoIdiomaNativo;
                              familiarEst.FueExAlumnoGraduado = info.FueExAlumnoGraduado;
                              familiarEst.Fallecido = info.Fallecido;
                              familiarEst.Calle_Secundaria = info.Calle_Secundaria;
                              familiarEst.Calle_Principal = info.Calle_Principal;
                              familiarEst.IdCiudad = info.IdCiudad;

                              Base.SaveChanges();
                          }

                      }
                      catch (Exception)
                      {  // Cuando no existe el familiar en la tabla 
                          //resultado = GrabarDB(info, ref msj, accion_actualizarPersona, ref idFamiliar);
                      }
                     
                  }
              }
              else
              {
                  // Inserto
                  resultado = GrabarDB(info,  accion_actualizarPersona,ref msj, ref idFam);
              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msj = ex.InnerException + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
              throw new Exception(ex.ToString());
          }
      }
      #endregion
  }
}
