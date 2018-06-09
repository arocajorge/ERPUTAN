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
    public class Aca_Profesor_Data
    {
        string mensaje = "";
        public int GetId(int IdInstitucion)
        {
            int Id = 0;
            try
            {
                Entities_Academico Base = new Entities_Academico();
                int select = (from q in Base.Aca_Profesor                           
                              where q.IdInstitucion == IdInstitucion
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.Aca_Profesor                                  
                                     where q.IdInstitucion == IdInstitucion
                                     select q.IdProfesor).Max();
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

        public Aca_Profesor_Info Get_Profesor_Info(string cedula)
        {
            Aca_Profesor_Info profesorInfo;
            try
            {
                using (Entities_Academico Base=new Entities_Academico())
                {
                    var vProfesor = Base.vwAca_profesor.FirstOrDefault(p=>p.pe_cedulaRuc==cedula);
                    profesorInfo = new Aca_Profesor_Info();
                    profesorInfo.IdPersona = vProfesor.IdPersona;
                    profesorInfo.IdProfesor = vProfesor.IdProfesor;
                    profesorInfo.CodProfesor = vProfesor.CodProfesor;                    
                    profesorInfo.estado = vProfesor.estado;
                    profesorInfo.IdInstitucion = vProfesor.IdInstitucion;
                    profesorInfo.Persona_Info.IdPersona = vProfesor.IdPersona;
                    profesorInfo.Persona_Info.pe_cedulaRuc = vProfesor.pe_cedulaRuc;
                    profesorInfo.Persona_Info.pe_nombre = vProfesor.pe_nombre;
                    profesorInfo.Persona_Info.pe_apellido = vProfesor.pe_apellido;
                    profesorInfo.Persona_Info.pe_nombreCompleto = vProfesor.pe_nombreCompleto;
                    profesorInfo.Persona_Info.pe_sexo = vProfesor.pe_sexo;
                    profesorInfo.Base = vProfesor.Base;
                }
                return profesorInfo;
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

        public List<Aca_Profesor_Info> Get_list_Profesor(int IdInstitucion)
        {
            List<Aca_Profesor_Info> listaProfesor= new List<Aca_Profesor_Info>();
            Aca_Profesor_Info profesorInfo;
                      
            try
            {

                using (Entities_Academico Base=new Entities_Academico())
                {
                    var profesor = from p in Base.Aca_Profesor
                                   where p.IdInstitucion == IdInstitucion
                                   select p;
                    foreach (var item in profesor)
                    {
                        profesorInfo = new Aca_Profesor_Info();
                        profesorInfo.IdInstitucion = item.IdInstitucion;
                        profesorInfo.IdProfesor = item.IdProfesor;
                        profesorInfo.Persona_Info.IdPersona = item.IdPersona;
                        profesorInfo.CodProfesor = item.CodProfesor;

                        using (EntitiesGeneral BaseG=new EntitiesGeneral())
                        {
                            var persona = BaseG.tb_persona.FirstOrDefault(p=>p.IdPersona==item.IdPersona);
                            profesorInfo.Persona_Info.IdTipoDocumento = persona.IdTipoDocumento;
                            profesorInfo.Persona_Info.pe_cedulaRuc = persona.pe_cedulaRuc;
                            profesorInfo.Persona_Info.pe_nombre = persona.pe_nombre;
                            profesorInfo.Persona_Info.pe_apellido = persona.pe_apellido;                            
                            profesorInfo.Persona_Info.pe_nombreCompleto = persona.pe_nombreCompleto;
                            profesorInfo.Persona_Info.pe_sexo = persona.pe_sexo;
                        }

                        profesorInfo.estado = item.estado;
                        profesorInfo.FechaCreacion = item.FechaCreacion;
                        listaProfesor.Add(profesorInfo);
                    }
                }
                return listaProfesor;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }

        public bool GrabarDB(Aca_Profesor_Info info, ref decimal idProfesor, ref string mensaje)
        {
            try
            {
                bool resultado = false;
                using (Entities_Academico Base = new Entities_Academico())
                {
                    decimal idPersona = 0;
                    Aca_Estudiante_Data daEstudiante = new Aca_Estudiante_Data();
                    tb_persona_data Persona_data = new tb_persona_data();

                    
                    switch(info.Base)
                    {
                        case null:
                            if (Persona_data.ExisteCedula(info.Persona_Info.pe_cedulaRuc, ref mensaje) == false)
                            {
                                resultado = Persona_data.GrabarDB(info.Persona_Info, ref idPersona, ref mensaje);
                            }
                                   info.Base ="N"; 
                                   break;
                        case "N": resultado = true; idPersona = info.IdPersona; break;
                    }

                    if (resultado == true && info.Base == "N")
                    {
                        Aca_Profesor addressProf = new Aca_Profesor();
                        addressProf.IdInstitucion = info.IdInstitucion;
                        idProfesor = GetId(info.IdInstitucion);
                        addressProf.IdProfesor = idProfesor;
                        addressProf.CodProfesor = string.IsNullOrEmpty(info.CodProfesor) ? idProfesor.ToString() : info.CodProfesor == "0" ? idProfesor.ToString() : info.CodProfesor;
                        addressProf.IdPersona = idPersona;
                        addressProf.estado = info.estado;
                        addressProf.FechaCreacion = DateTime.Now;
                        addressProf.UsuarioCreacion = info.UsuarioCreacion;
                        Base.Aca_Profesor.Add(addressProf);
                        Base.SaveChanges();
                        mensaje = "Se ha procedido a grabar el Profesor #: " + idProfesor.ToString() + " exitosamente.";
                    }
                    else {
                        mensaje = "El Profesor " + idProfesor.ToString() + " ya se encuentra ingresado."; 
                        return false;
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

        public bool ActualizarDB(Aca_Profesor_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_Estudiante_Data daEstudiante = new Aca_Estudiante_Data();
                    tb_persona_data Persona_Data = new tb_persona_data();

                    bool resultado = Persona_Data.ModificarDB(info.Persona_Info, ref mensaje);

                    if (resultado)
                    {
                        var vProfesor = Base.Aca_Profesor.FirstOrDefault(j => j.IdInstitucion == info.IdInstitucion && j.IdProfesor == info.IdProfesor);
                        if (vProfesor != null)
                        {
                            vProfesor.CodProfesor = string.IsNullOrEmpty(info.CodProfesor) ? info.IdProfesor.ToString() : info.CodProfesor == "0" ? info.IdProfesor.ToString() : info.CodProfesor;
                            vProfesor.IdPersona = info.Persona_Info.IdPersona;
                            vProfesor.estado = info.estado;
                            vProfesor.FechaModificacion = DateTime.Now;
                            vProfesor.UsuarioModificacion = info.UsuarioModificacion;
                            Base.SaveChanges();
                            mensaje = "Se ha procedido actualizar el Profesor #: " + info.IdProfesor.ToString() + " exitosamente.";
                        }
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

        public Boolean AnularDB(Aca_Profesor_Info info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Profesor.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdProfesor==info.IdProfesor);
                    if (address != null)
                    {
                        address.estado = "I";
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        context.SaveChanges();
                        msg = "Se ha procedido anular el Profesor #: " + info.IdProfesor.ToString() + " exitosamente.";
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
