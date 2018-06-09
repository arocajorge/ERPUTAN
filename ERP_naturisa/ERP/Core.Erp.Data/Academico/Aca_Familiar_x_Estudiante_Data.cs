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
    public class Aca_Familiar_x_Estudiante_Data
    {
        string MensajeError = "";

        public bool ExisteFamiliar(Aca_Familiar_x_Estudiante_Info infoFamiliar)
        {
            try
            {
                int contarFamiliar = 0;
                using (Entities_Academico Base = new Entities_Academico())
                {

                        contarFamiliar = (from f in Base.Aca_Familiar_x_Estudiante
                                          where f.IdInstitucion == infoFamiliar.IdInstitucion &&
                                          f.IdEstudiante == infoFamiliar.IdEstudiante &&
                                          f.IdFamiliar == infoFamiliar.IdFamiliar

                                          select f).Count();
                        if (contarFamiliar > 0)
                        {
                            return true;
                        }
                        else
                        {
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

        public int GetIdFamiliar(int IdInstitucion, decimal IdEstudiante)
        {
            int Id = 0;
            try
            {
                Entities_Academico OEEstudiante = new Entities_Academico();
                int select = (from q in OEEstudiante.Aca_Familiar
                              where q.IdInstitucion == IdInstitucion
                              select q.IdFamiliar).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_fam = (from q in OEEstudiante.Aca_Familiar_x_Estudiante
                                      where q.IdInstitucion == IdInstitucion && q.IdEstudiante == IdEstudiante
                                      select q.IdFamiliar).Max();
                    Id = Convert.ToInt32(select_fam.ToString()) + 1;
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

        public bool GrabarDB(Aca_Familiar_x_Estudiante_Info info, ref string msj, bool actualizarPersona)
        {
            bool resultado = false;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_Familiar_x_Estudiante infoFamiliar = new Aca_Familiar_x_Estudiante();
                    infoFamiliar.IdInstitucion = info.IdInstitucion;
                    infoFamiliar.IdEstudiante = info.IdEstudiante;
                    infoFamiliar.IdFamiliar = info.IdFamiliar;
                    infoFamiliar.IdParentesco_cat = info.IdParentesco_cat;
                    infoFamiliar.activo = info.activo;
                    infoFamiliar.esta_autorizado_ret_alum = info.esta_autorizado_ret_alum;
                    infoFamiliar.esta_autorizado_recibir_not_mail = info.esta_autorizado_recibir_not_mail;
                    infoFamiliar.Vive_con_el_estudiante = info.Vive_con_el_estudiante;
                    infoFamiliar.UsuarioCreacion = info.UsuarioCreacion;
                    infoFamiliar.porcentaje_dual = info.porcentaje_dual;
                    infoFamiliar.FechaCreacion = DateTime.Now;
                    Base.Aca_Familiar_x_Estudiante.Add(infoFamiliar);
                    Base.SaveChanges();
                    msj = "Se ha procedido a grabar el registro del Representante Economico del Sistema Dual #: " + info.IdFamiliar.ToString() + " exitosamente.";
                    resultado = true;
                }
                return resultado;
            }
            //catch (Exception ex)
            //{
            //    string arreglo = ToString();
            //    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
            //    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            //    msj = ex.InnerException + " " + ex.Message;
            //    oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
            //    throw new Exception(ex.ToString());
            //}
            catch (DbEntityValidationException ex)
            {
                string arreglo = ToString();
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item_validaciones in item.ValidationErrors)
                    {
                        MensajeError = "Propiedad: " + item_validaciones.PropertyName + " Mensaje: " + item_validaciones.ErrorMessage + "\n";
                    }
                }
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(MensajeError, "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(MensajeError);
            }
        }

        public bool ActualizarDB(Aca_Familiar_x_Estudiante_Info info, ref string msj)
        {
            bool resultado = false;
            bool accion_actualizarPersona = false;
            
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var familiarEst = Base.Aca_Familiar_x_Estudiante.FirstOrDefault(f => f.IdInstitucion == info.IdInstitucion 
                        && f.IdEstudiante == info.IdEstudiante && f.IdFamiliar == info.IdFamiliar && f.IdParentesco_cat == info.IdParentesco_cat);

                    if (familiarEst != null)
                    {
                        familiarEst.IdInstitucion = info.IdInstitucion;
                        familiarEst.IdEstudiante = info.IdEstudiante;
                        familiarEst.IdFamiliar = info.IdFamiliar;
                        familiarEst.IdParentesco_cat = info.IdParentesco_cat;
                        familiarEst.activo = info.activo;
                        familiarEst.esta_autorizado_ret_alum = info.esta_autorizado_ret_alum;
                        familiarEst.esta_autorizado_recibir_not_mail = info.esta_autorizado_recibir_not_mail;
                        familiarEst.Vive_con_el_estudiante = info.Vive_con_el_estudiante;
                        familiarEst.FechaModificacion = DateTime.Now;
                        familiarEst.UsuarioModificacion = info.UsuarioModificacion;
                        familiarEst.porcentaje_dual = info.porcentaje_dual;
                        Base.SaveChanges();
                    }
                    else
                        resultado = GrabarDB(info, ref msj, accion_actualizarPersona);
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

        public List<Aca_Familiar_x_Estudiante_Info> Get_list_familiar_x_estudiante(int IdInstitucion, decimal IdEstudiante)
        {
            try
            {
                List<Aca_Familiar_x_Estudiante_Info> Lista = new List<Aca_Familiar_x_Estudiante_Info>();

                using (Entities_Academico Context = new Entities_Academico())
                {
                    var lst = from q in Context.vwAca_Familiar_x_Estudiante
                              where q.IdInstitucion == IdInstitucion
                              && q.IdEstudiante == IdEstudiante
                              select q;
                     
                    foreach (var item in lst)
                    {
                        Aca_Familiar_x_Estudiante_Info info = new Aca_Familiar_x_Estudiante_Info();
                        info.IdInstitucion = item.IdInstitucion;
                        info.IdFamiliar = item.IdFamiliar;
                        info.IdParentesco_cat = item.IdParentesco_cat;
                        info.IdEstudiante = item.IdEstudiante;
                        info.activo = item.activo == null ? false : Convert.ToBoolean(item.activo);

                        info.Persona_Info.IdPersona = item.IdPersona;
                        info.Persona_Info.pe_nombre = item.pe_nombre;
                        info.Persona_Info.pe_apellido = item.pe_apellido;
                        info.Persona_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.Persona_Info.pe_direccion = item.pe_direccion;
                        info.Persona_Info.pe_fechaNacimiento = item.pe_fechaNacimiento;
                        info.Persona_Info.IdEstadoCivil = item.IdEstadoCivil;
                        info.Familiar_Info.IdNivelEducativo = (item.IdNivelEducativo_cat == "") ? "SIN_EDU" : item.IdNivelEducativo_cat;
                        info.Familiar_Info.Titulo = item.Titulo;
                        info.Familiar_Info.EmpresaDireccion = item.empresa_direccion;
                        info.Familiar_Info.EmpresaDondeTrabaja = item.empresa_donde_trabaja;
                        info.Familiar_Info.EmpresaEmail = item.empresa_email;
                        info.Familiar_Info.EmpresaTelefono = item.empresa_telefono;
                        info.Familiar_Info.Calle_Principal = item.Calle_Principal;
                        info.Familiar_Info.Calle_Secundaria = item.Calle_Secundaria;
                        info.Familiar_Info.Fallecido = Convert.ToBoolean(item.Fallecido);
                        info.Familiar_Info.FueExAlumnoGraduado = Convert.ToBoolean(item.FueExAlumnoGraduado);
                        info.Familiar_Info.IdCatalogoIdiomaNativo = item.IdCatalogoIdiomaNativo;
                        info.Familiar_Info.IdCatalogoReligion = item.IdCatalogoReligion;
                        info.Familiar_Info.IdCatalogoTipoSangre = item.IdCatalogoTipoSangre;
                        info.Familiar_Info.PoseeDiscapacidad = Convert.ToBoolean(item.PoseeDiscapacidad);
                        info.Familiar_Info.Sector_Urbanizacion = item.Sector_Urbanizacion;
                        info.Familiar_Info.ViveFueraDelPais = Convert.ToBoolean(item.ViveFueraDelPais);
                        info.Familiar_Info.IdCiudad = item.IdCiudad;
                        Lista.Add(info);
                    }
                }

                return Lista;
            }
            catch (Exception ex)
            {
                string msj = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msj = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                throw new Exception(ex.ToString());
            }
        }

        public bool AnularDB(List<Aca_Familiar_Info> listaFamiliar, Aca_Estudiante_Info infoEstudiante, ref string msj)
        {
           
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    foreach (var item in listaFamiliar)
                    {
                       
                        var familiarEst = Base.Aca_Familiar_x_Estudiante.FirstOrDefault(f => f.IdInstitucion == infoEstudiante.IdInstitucion
                       && f.IdEstudiante == infoEstudiante.IdEstudiante && f.IdFamiliar == item.IdFamiliar && f.IdParentesco_cat == item.IdParentesco_cat);

                        if (familiarEst != null)
                        {

                            familiarEst.activo = false;

                            familiarEst.FechaModificacion = DateTime.Now;

                            familiarEst.UsuarioModificacion = infoEstudiante.UsuarioModificacion;
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
    }
}
