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
   public class Aca_Admision_Data
   {

       #region "Get"

       public int getId(int IdInstitucion)
       {
           int Id = 0;
           try
           {
               Entities_Academico Base = new Entities_Academico();
               int select = (from q in Base.Aca_Admision
                             where q.IdInstitucion == IdInstitucion
                             select q).Count();

               if (select == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_as = (from q in Base.Aca_Admision
                                    where q.IdInstitucion == IdInstitucion
                                    select q.IdAdmision).Max();
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

       public List<Aca_Admision_Info> Get_List_Admision(int IdInstitucion)
       {
           List<Aca_Admision_Info> lista = new List<Aca_Admision_Info>();
           Aca_Admision_Info admisionInfo;
           Aca_Aspirante_Info aspiranteInfo;
           tb_pais_Info paisInfo;
           tb_persona_Info personInfo;
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var vAdmision = from a in Base.Aca_Admision
                                   join c in Base.Aca_curso on a.IdCurso equals c.IdCurso
                                   join sec in Base.Aca_Seccion on c.IdSeccion equals sec.IdSeccion
                                   join j in Base.Aca_Jornada on sec.IdJornada equals j.IdJornada
                                   where a.IdInstitucion == IdInstitucion
                                   orderby a.IdAdmision
                                   select new { a,c,sec,j}
                                   ;

                   foreach (var item in vAdmision)
                   {
                       admisionInfo = new Aca_Admision_Info();
                       admisionInfo.IdInstitucion = item.a.IdInstitucion;
                       admisionInfo.IdAdmision = item.a.IdAdmision;
                       admisionInfo.CodAdmision = item.a.cod_Admision;
                       admisionInfo.IdAspirante = item.a.IdAspirante;      
              
                       //admisionInfo.IdPeriodoLectivo = item.IdAnioLectivo;
                       admisionInfo.IdAnioLectivo = item.a.IdAnioLectivo;   

                       admisionInfo.IdCurso = item.a.IdCurso;
                       admisionInfo.IdSeccion = item.sec.IdSeccion;
                       admisionInfo.IdJornada = item.j.IdJornada;
                       admisionInfo.IdSede = item.j.IdSede;
                       admisionInfo.PoseeDiscapacidad = Convert.ToBoolean( item.a.Posee_Discapacidad);
                       admisionInfo.TelefonoEmergente = item.a.Telefono_Emer;
                       admisionInfo.TieneHermanosEnOtrosColegios = item.a.Tiene_Her_otros_cole;
                       admisionInfo.TieneHermanoEnNuestroColegio = item.a.Tiene_Her_nuestro_cole;
                       admisionInfo.UsuarioAnulacion = item.a.UsuarioAnulacion;
                       admisionInfo.UsuarioCreacion = item.a.UsuarioCreacion;
                       admisionInfo.UsuarioModificacion = item.a.UsuarioModificacion;
                       admisionInfo.FechaAnulacion = item.a.FechaAnulacion;
                       admisionInfo.FechaCreacion = item.a.FechaCreacion;
                       admisionInfo.FechaModificacion = item.a.FechaModificacion;
                       admisionInfo.IdCatalogoGrupoFamiliarConviviencia = item.a.IdCatalogo_Grupo_Fami_convivencia;
                       admisionInfo.IdCatalogoIdiomaNativo = item.a.IdCatalogo_Idioma_Nati;
                       admisionInfo.IdCatalogoTipoReligion = item.a.IdCatalogo_Tipo_Religion;
                       admisionInfo.IdCatalogoTipoSangre = item.a.IdCatalogo_Tipo_Sangre;
                       admisionInfo.ActualAsisteEstableEducativo = item.a.Actu_Asis_Estable_Edu;
                       admisionInfo.EnQueGradoTieneHermanos = item.a.En_q_grado_tiene_her;
                       admisionInfo.EstablecimientoEducativoDondeAsiste = item.a.Estable_Edu_donde_asis;
                       admisionInfo.HijoProfeDelColegio = item.a.Hijo_de_prof_del_coleg;
                       admisionInfo.HijoUnico = item.a.Hijo_unico;
                       admisionInfo.Estado = item.a.Estado;

                       aspiranteInfo = new Aca_Aspirante_Info();
                       var vaspirante = Base.Aca_Aspirante.FirstOrDefault(a => a.IdInstitucion == item.a.IdInstitucion && a.IdAspirante == item.a.IdAspirante);
                       aspiranteInfo.IdInstitucion = vaspirante.IdInstitucion;
                       aspiranteInfo.IdAspirante = vaspirante.IdAspirante;
                       aspiranteInfo.CodAspirante = vaspirante.cod_aspirante;
                       aspiranteInfo.Persona_Info.IdPersona = vaspirante.IdPersona;
                       aspiranteInfo.Lugar = vaspirante.lugar;
                       aspiranteInfo.Barrio = vaspirante.barrio;
                       // Persona

                       using (EntitiesGeneral BaseGe=new EntitiesGeneral())
                       {
                           var vpais = BaseGe.tb_pais.FirstOrDefault(p=>p.IdPais==vaspirante.IdPais_Nacionalidad);
                           paisInfo = new tb_pais_Info();
                           paisInfo.IdPais = vpais.IdPais;
                           paisInfo.Nacionalidad = vpais.Nacionalidad;

                           var vpersona = BaseGe.tb_persona.FirstOrDefault(pe=>pe.IdPersona==aspiranteInfo.Persona_Info.IdPersona);
                           
                           aspiranteInfo.Persona_Info.IdPersona = vpersona.IdPersona;
                           aspiranteInfo.Persona_Info.CodPersona = vpersona.CodPersona;
                           aspiranteInfo.Persona_Info.IdTipoDocumento = vpersona.IdTipoDocumento;
                           aspiranteInfo.Persona_Info.IdTipoPersona = vpersona.IdTipoPersona;
                           aspiranteInfo.Persona_Info.pe_cedulaRuc = vpersona.pe_cedulaRuc;
                           aspiranteInfo.Persona_Info.pe_nombre = vpersona.pe_nombre;
                           aspiranteInfo.Persona_Info.pe_apellido = vpersona.pe_apellido;
                           aspiranteInfo.Persona_Info.pe_nombreCompleto = vpersona.pe_nombreCompleto;
                           aspiranteInfo.Persona_Info.pe_correo = vpersona.pe_correo;
                           aspiranteInfo.Persona_Info.pe_telefonoCasa = vpersona.pe_telefonoCasa;
                           aspiranteInfo.Persona_Info.pe_telfono_Contacto = vpersona.pe_telfono_Contacto;
                           aspiranteInfo.Persona_Info.pe_sexo = vpersona.pe_sexo;
                           aspiranteInfo.Persona_Info.pe_fechaNacimiento = vpersona.pe_fechaNacimiento;
                           aspiranteInfo.Persona_Info.pe_direccion = vpersona.pe_direccion;
                       }

                       aspiranteInfo.Pais_Info = paisInfo;                       
                       admisionInfo.aspiranteInfo = aspiranteInfo;                       
                       lista.Add(admisionInfo);
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

       public Aca_Admision_Info GetAdmision_x_Persona(string cedula, ref string estadoRegistroCedula, ref string mensaje)
       {
           Aca_Admision_Info admisionInfo;          
           try
           {
               using (Entities_Academico Base= new Entities_Academico())
               {
                   vwAca_admision vwadmision = Base.vwAca_admision.FirstOrDefault(v=> v.pe_cedulaRuc==cedula); 
                   admisionInfo = new Aca_Admision_Info();
                   if (vwadmision != null)
                   {
                       admisionInfo.IdInstitucion = vwadmision.IdInstitucion;
                       admisionInfo.IdAdmision = vwadmision.IdAdmision;
                       admisionInfo.CodAdmision = vwadmision.cod_Admision;
                       admisionInfo.IdAspirante = vwadmision.IdAspirante;
                       admisionInfo.IdCatalogoGrupoFamiliarConviviencia = vwadmision.IdCatalogo_Grupo_Fami_convivencia;
                       admisionInfo.IdCatalogoIdiomaNativo = vwadmision.IdCatalogo_Idioma_Nati;
                       admisionInfo.IdCatalogoTipoReligion = vwadmision.IdCatalogo_Tipo_Religion;
                       admisionInfo.IdCatalogoTipoSangre = vwadmision.IdCatalogo_Tipo_Sangre;

                       //admisionInfo.IdPeriodoLectivo = item.IdAnioLectivo;
                       admisionInfo.IdAnioLectivo = vwadmision.IdAnioLectivo;   

                       admisionInfo.IdCurso = vwadmision.IdCurso;
                       admisionInfo.PoseeDiscapacidad = Convert.ToBoolean(vwadmision.Posee_Discapacidad);
                       admisionInfo.TelefonoEmergente = vwadmision.Telefono_Emer;
                       admisionInfo.TieneHermanoEnNuestroColegio = Convert.ToBoolean(vwadmision.Tiene_Her_nuestro_cole);
                       admisionInfo.TieneHermanosEnOtrosColegios = Convert.ToBoolean(vwadmision.Tiene_Her_otros_cole);
                       admisionInfo.HijoUnico = Convert.ToBoolean(vwadmision.Hijo_unico);
                       admisionInfo.HijoProfeDelColegio = Convert.ToBoolean(vwadmision.Hijo_de_prof_del_coleg);
                       admisionInfo.EnQueGradoTieneHermanos = vwadmision.En_q_grado_tiene_her;
                       admisionInfo.ActualAsisteEstableEducativo = Convert.ToBoolean(vwadmision.Actu_Asis_Estable_Edu);
                       admisionInfo.EstablecimientoEducativoDondeAsiste = vwadmision.Estable_Edu_donde_asis;
                       admisionInfo.Estado = vwadmision.Estado;
                       // Aspirante
                       admisionInfo.aspiranteInfo.IdAspirante = vwadmision.IdAspirante;
                       admisionInfo.aspiranteInfo.Lugar = vwadmision.lugar;
                       admisionInfo.aspiranteInfo.Barrio = vwadmision.barrio;
                       admisionInfo.aspiranteInfo.IdInstitucion = vwadmision.IdInstitucion;
                       admisionInfo.aspiranteInfo.Pais_Info.IdPais = vwadmision.IdPais_Nacionalidad;
                       // Persona
                       admisionInfo.aspiranteInfo.Persona_Info.IdPersona = vwadmision.IdPersona == null ? 0 : Convert.ToDecimal(vwadmision.IdPersona);
                       admisionInfo.aspiranteInfo.Persona_Info.IdTipoDocumento = vwadmision.IdTipoDocumento;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_cedulaRuc = vwadmision.pe_cedulaRuc;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_apellido = vwadmision.pe_apellido;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_nombre = vwadmision.pe_nombre;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_fechaNacimiento = vwadmision.pe_fechaNacimiento;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_sexo = vwadmision.pe_sexo;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_telfono_Contacto = vwadmision.pe_telfono_Contacto;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_telefonoCasa = vwadmision.pe_telefonoCasa;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_correo = vwadmision.pe_correo;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_direccion = vwadmision.pe_direccion;
                       admisionInfo.aspiranteInfo.Persona_Info.pe_estado = vwadmision.pe_estado;
                       admisionInfo.Base = vwadmision.Base;

                       //// A: Admision
                       //// P: Persona
                       //// NULL no existe en tabla persona ni admision, no esta registrado en la base
                       switch (admisionInfo.Base)
                       {
                           case "A": estadoRegistroCedula = "N"; mensaje = "Cédula ya se encuentra registrado en el sistema"; break;
                           case "P": estadoRegistroCedula = "S"; break;
                           default: estadoRegistroCedula = "S";
                               break;
                       }
                   }
               }
               return admisionInfo;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();               
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = "";
               throw new Exception(ex.InnerException.ToString());
           }
       }
       #endregion

       #region "Grabar,Actualizar,Eliminar"
       public bool GrabarDB(Aca_Admision_Info info,ref decimal idAdmision,ref string mensaje) {
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   Aca_Aspirante_Data daAspirante = new Aca_Aspirante_Data();
                   decimal idAspirante=0;
                   
                   bool resultado = daAspirante.GrabarDB(info.aspiranteInfo, ref idAspirante, ref mensaje);

                   Aca_Admision address = new Aca_Admision();
                   address.IdInstitucion = info.IdInstitucion;
                   idAdmision = getId(info.IdInstitucion);
                   address.IdAdmision = idAdmision;
                   address.cod_Admision = (string.IsNullOrEmpty( info.CodAdmision)|| info.CodAdmision=="0")?idAdmision.ToString():info.CodAdmision;
                   address.cod_Alterno = string.IsNullOrEmpty( info.CodAlterno)?"":info.CodAlterno;
                   address.IdAspirante = idAspirante;
                   address.IdCatalogo_Grupo_Fami_convivencia = info.IdCatalogoGrupoFamiliarConviviencia;
                   address.IdCatalogo_Idioma_Nati=info.IdCatalogoIdiomaNativo;
                   address.IdCatalogo_Tipo_Religion = info.IdCatalogoTipoReligion;
                   address.IdCatalogo_Tipo_Sangre = info.IdCatalogoTipoSangre;
                   address.IdCurso = info.IdCurso;

                   //address.IdPeriodoLectivo = item.IdAnioLectivo;
                   address.IdAnioLectivo = info.IdAnioLectivo;   
                 
                   address.Posee_Discapacidad = info.PoseeDiscapacidad;
                   address.Telefono_Emer = info.TelefonoEmergente;
                   address.Tiene_Her_otros_cole = info.TieneHermanosEnOtrosColegios;
                   address.Hijo_de_prof_del_coleg = info.HijoProfeDelColegio;
                   address.Hijo_unico = info.HijoUnico;
                   address.Actu_Asis_Estable_Edu = info.ActualAsisteEstableEducativo;
                   address.Estable_Edu_donde_asis = info.EstablecimientoEducativoDondeAsiste;
                   address.Tiene_Her_nuestro_cole = info.TieneHermanoEnNuestroColegio;
                   address.En_q_grado_tiene_her = info.EnQueGradoTieneHermanos;
                   address.Hijo_de_prof_del_coleg = info.HijoProfeDelColegio;
                   address.UsuarioCreacion = info.UsuarioCreacion;                   
                   address.FechaCreacion = DateTime.Now;                   
                   address.Estado = info.Estado;                   
                   
                   Base.Aca_Admision.Add(address);
                   Base.SaveChanges();
                   mensaje = "Se ha procedido a grabar la Admisión #: " + idAdmision.ToString() + " exitosamente.";

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

       public bool ActualizarDB(Aca_Admision_Info info,ref string mensaje) {
           try
           {
               using (Entities_Academico Base=new Entities_Academico())
               {
                   var vAdmision = Base.Aca_Admision.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdAdmision == info.IdAdmision);

                   if (vAdmision != null)
                   {
                       vAdmision.cod_Admision = (string.IsNullOrEmpty(info.CodAdmision) || info.CodAdmision == "0") ? info.IdAdmision.ToString() : info.CodAdmision;
                       vAdmision.cod_Alterno = string.IsNullOrEmpty(info.CodAlterno) ? "" : info.CodAlterno;
                       vAdmision.IdCatalogo_Grupo_Fami_convivencia = info.IdCatalogoGrupoFamiliarConviviencia;
                       vAdmision.IdCatalogo_Idioma_Nati = info.IdCatalogoIdiomaNativo;
                       vAdmision.IdCatalogo_Tipo_Religion = info.IdCatalogoTipoReligion;
                       vAdmision.IdCatalogo_Tipo_Sangre = info.IdCatalogoTipoSangre;
                       vAdmision.IdCurso = info.IdCurso;

                       //vAdmision.IdAnioLectivo = info.IdPeriodoLectivo;
                       vAdmision.IdAnioLectivo = info.IdAnioLectivo;

                       vAdmision.Actu_Asis_Estable_Edu = info.ActualAsisteEstableEducativo;
                       vAdmision.Tiene_Her_nuestro_cole = info.TieneHermanoEnNuestroColegio;
                       vAdmision.En_q_grado_tiene_her = info.EnQueGradoTieneHermanos;
                       vAdmision.Estable_Edu_donde_asis = info.EstablecimientoEducativoDondeAsiste;
                       vAdmision.Posee_Discapacidad = info.PoseeDiscapacidad;
                       vAdmision.Telefono_Emer = info.TelefonoEmergente;
                       vAdmision.Tiene_Her_otros_cole = info.TieneHermanosEnOtrosColegios;
                       vAdmision.Hijo_de_prof_del_coleg = info.HijoProfeDelColegio;
                       vAdmision.Hijo_unico = info.HijoUnico;
                       vAdmision.UsuarioModificacion = info.UsuarioModificacion;
                       vAdmision.FechaModificacion = DateTime.Now;
                       vAdmision.Estado = info.Estado;

                       Aca_Aspirante_Data daAspirante = new Aca_Aspirante_Data();
                       bool resultado = daAspirante.ActualizarDB(info.aspiranteInfo, ref mensaje);

                       if (resultado)
                       {
                           Base.SaveChanges();
                       }

                       mensaje = "Se ha procedido actualizar Admisión #: " + info.IdAdmision.ToString() + " exitosamente.";
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

       public bool AnularDB(Aca_Admision_Info info,ref string mensaje) {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_Admision.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdAdmision == info.IdAdmision);
                   if (address != null)
                   {
                       address.Estado = "I";
                       address.FechaAnulacion = DateTime.Now;
                       address.UsuarioAnulacion = info.UsuarioAnulacion;
                       address.MotivoAnulacion = info.MotivoAnulacion;
                       context.SaveChanges();
                       mensaje = "Se ha procedido anular Admisión #: " + info.IdAdmision.ToString() + " exitosamente.";
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
               throw new Exception(ex.InnerException.ToString());
           }
       }
       #endregion  
       public bool ExisteCedula(int IdInstitucion, decimal IdAdmision, string cedulaRuc, ref string msj)
       {
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   if (IdAdmision == 0)
                   {
                       int existe = (from e in Base.vwAca_admision
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
                       var Admision = Base.vwAca_admision.First(o => o.IdInstitucion == IdInstitucion && o.pe_cedulaRuc == cedulaRuc);
                       if (Admision.IdAdmision != IdAdmision)
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
   }
}
