using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
    public class tb_contacto_Data
    {
        string msj = " ";

        public List<tb_contacto_Info>Get_Contanto_x_cedula(int IdEmpresa, string Cedula)
        {
            List<tb_contacto_Info> listaCon = new List<tb_contacto_Info>();
            try
            {                
                using (EntitiesGeneral Base = new EntitiesGeneral())
                {                   
                        var select = from A in Base.vwtb_contacto
                                     where A.IdEmpresa == IdEmpresa
                                     && A.pe_cedulaRuc == Cedula
                                     select A;

                        foreach (var item in select)
                        {
                            tb_contacto_Info info = new tb_contacto_Info();
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdContacto = item.IdContacto;
                            info.IdPersona = item.IdPersona;
                            info.CodContacto = item.CodContacto;
                            info.Organizacion = item.Organizacion;
                            info.Cargo = item.Cargo;
                            info.Mostrar_como = item.Mostrar_como;
                            info.Fecha_alta = item.Fecha_alta;
                            info.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                            info.IdNacionalidad = item.IdNacionalidad;
                            info.Notas = item.Notas;
                            info.Pagina_Web = item.Pagina_Web;
                            info.Codigo_postal = item.Codigo_postal;
                            info.Estado = item.Estado;                            

                            tb_persona_Info personaInfo = new tb_persona_Info();
                            personaInfo.IdPersona = item.IdPersona;
                            personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                            personaInfo.pe_apellido = item.pe_apellido;
                            personaInfo.pe_nombre = item.pe_nombre;
                            personaInfo.pe_nombreCompleto = item.pe_nombre + item.pe_apellido;
                            personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                            personaInfo.pe_correo = item.pe_correo;
                            personaInfo.pe_celular = item.pe_celular;
                            personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                            personaInfo.pe_direccion = item.pe_direccion;
                            personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;
                            personaInfo.pe_razonSocial = item.pe_razonSocial;
                            personaInfo.pe_Naturaleza = item.pe_Naturaleza;
                            info.Persona_Info = personaInfo;

                            tb_pais_Info paisInfo = new tb_pais_Info();
                            paisInfo.IdPais = item.IdPais;
                            info.IdPais = paisInfo.IdPais;
                            paisInfo.Nacionalidad = item.Nacionalidad;
                            //info.IdNacionalidad = Convert.ToInt32(paisInfo.IdPais);

                            tb_ciudad_Info ciudadInfo = new tb_ciudad_Info();
                            ciudadInfo.IdCiudad = item.IdCiudad;
                            info.IdCiudad = ciudadInfo.IdCiudad;
                            //info.Ciudad_Info = ciudadInfo;

                            tb_provincia_Info ProvInfo = new tb_provincia_Info();
                            ProvInfo.IdProvincia = item.IdProvincia;
                            info.IdProvincia = ProvInfo.IdProvincia;
                            //info.Provi_Info = ProvInfo;


                            listaCon.Add(info);
                        }
                    return listaCon;                  
                }
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

        public bool ExisteContacto(int IdEmpresa, decimal idContacto, decimal idPersona, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Base = new EntitiesGeneral())
                {
                    if (idContacto == 0)
                    {
                        int existe = (from e in Base.tb_contacto
                                      where e.IdEmpresa == IdEmpresa
                                      && e.IdPersona == idPersona
                                      select e).Count();

                        if (existe != 0)
                        {
                            mensaje = "Contacto ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                    else
                    {
                        var contacto = Base.tb_contacto.First(p => p.IdEmpresa == IdEmpresa && p.IdPersona == idPersona);
                        if (contacto.IdContacto == idContacto)
                        {
                            mensaje = "Contacto ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                }
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

        public List<tb_contacto_Info> Get_List_Contacto(int IdEmpresa)
        {
            List<tb_contacto_Info> listaCon = new List<tb_contacto_Info>();
            try
            {
                EntitiesGeneral Base = new EntitiesGeneral();
                var select = from A in Base.vwtb_contacto
                             where A.IdEmpresa == IdEmpresa
                             orderby A.IdContacto
                             select A;

                foreach (var item in select)
                {
                    tb_contacto_Info info = new tb_contacto_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdContacto = item.IdContacto;
                    info.IdPersona = item.IdPersona;
                    info.CodContacto = item.CodContacto;
                    info.Organizacion = item.Organizacion;
                    info.Cargo = item.Cargo;
                    info.Mostrar_como = item.Mostrar_como;
                    info.Fecha_alta = item.Fecha_alta;
                    info.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                    info.IdNacionalidad = item.IdNacionalidad;
                    info.Notas = item.Notas;
                    info.Pagina_Web = item.Pagina_Web;
                    info.Codigo_postal = item.Codigo_postal;
                    info.Estado = item.Estado;
                    info.Pais_Info.IdPais = item.IdPais;
                    info.Ciudad_Info.IdCiudad = item.IdCiudad;
                    info.Provi_Info.IdProvincia = item.IdProvincia;
                    info.IdNacionalidad = item.IdNacionalidad;

                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.IdPersona = item.IdPersona;
                    personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                    personaInfo.pe_apellido = item.pe_apellido;
                    personaInfo.pe_nombre = item.pe_nombre;
                    personaInfo.pe_nombreCompleto = item.pe_nombre + item.pe_apellido;
                    personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                    personaInfo.pe_correo = item.pe_correo;
                    personaInfo.pe_celular = item.pe_celular;
                    personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                    personaInfo.pe_direccion = item.pe_direccion;
                    personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;
                    personaInfo.pe_razonSocial = item.pe_razonSocial;
                    personaInfo.pe_Naturaleza = item.pe_Naturaleza;
                    info.Persona_Info = personaInfo;

                    tb_pais_Info paisInfo = new tb_pais_Info();
                    paisInfo.IdPais = item.IdPais;
                    info.IdPais = paisInfo.IdPais;
                    paisInfo.Nacionalidad = item.Nacionalidad;
                    

                    tb_ciudad_Info ciudadInfo = new tb_ciudad_Info();
                    ciudadInfo.IdCiudad = item.IdCiudad;
                    info.IdCiudad = ciudadInfo.IdCiudad;
                    

                    tb_provincia_Info ProvInfo = new tb_provincia_Info();
                    ProvInfo.IdProvincia = item.IdProvincia;
                    info.IdProvincia = ProvInfo.IdProvincia;
                    


                    listaCon.Add(info);
                }
                return listaCon;
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

        #region "Get"
        public int getId(int IdEmpresa)
        {
            int Id = 0;
            try
            {
                EntitiesGeneral Base = new EntitiesGeneral();
                var select = (from q in Base.tb_contacto
                              where q.IdEmpresa == IdEmpresa
                              select q).Count();

                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.tb_contacto
                                     where q.IdEmpresa == IdEmpresa
                                     select q.IdContacto).Max();
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
        #endregion
        #region "Guardar, Modificar,Anular"
        public bool GuardarContacto(tb_contacto_Info Info, decimal idContacto, ref string mensaje)
        {
            try
            {
                bool resultado;
                EntitiesGeneral Conexion = new EntitiesGeneral();
                {
                    try
                    {
                        tb_contacto Base = new tb_contacto();
                        if (idContacto == 0)
                        {
                            idContacto = getId(Info.IdEmpresa);
                            Info.IdContacto = idContacto;
                        }
                        decimal idPersona = 0;
                        if (Info.Persona_Info.IdPersona == 0)
                        {
                            resultado = GrabarPersonaDB(Info.Persona_Info, ref idPersona);
                        }
                        else
                        {
                            ActualizarPersonaDB(Info.Persona_Info, ref mensaje);
                            idPersona = Info.Persona_Info.IdPersona;
                            resultado = true;
                        }


                        if (resultado)
                        {
                            Base.IdEmpresa = Info.IdEmpresa;
                            Base.IdContacto = Info.IdContacto;
                            Base.IdPersona = idPersona;
                            Base.CodContacto = (string.IsNullOrEmpty(Info.CodContacto) || Info.CodContacto == "0") ? idContacto.ToString() : Info.CodContacto;
                            Base.Organizacion = Info.Organizacion;
                            Base.Cargo = Info.Cargo;
                            Base.Mostrar_como = Info.Mostrar_como;
                            Base.Fecha_alta = Info.Fecha_alta;
                            Base.Fecha_Ult_Contacto = Info.Fecha_Ult_Contacto;
                            Base.IdPais = Info.IdPais;
                            Base.IdProvincia = Info.IdProvincia;
                            Base.IdCiudad = Info.IdCiudad;
                            Base.IdNacionalidad = Info.IdNacionalidad;
                            Base.Notas = Info.Notas;
                            Base.Pagina_Web = Info.Pagina_Web;
                            Base.foto = Info.foto;
                            Base.Codigo_postal = Info.Codigo_postal;
                            Base.FechaCreacion = DateTime.Now;
                            Base.UsuarioCreacion = Info.UsuarioCreacion;
                            Base.Estado = Info.Estado;
                            Conexion.tb_contacto.Add(Base);
                            Conexion.SaveChanges();
                            mensaje = "Se ha Guardado el contacto #: " + idContacto.ToString() + " exitosamente.";
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
                        throw new Exception(ex.InnerException.ToString());
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                String MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());

            }
        }


        public Boolean ActualizarContacto(tb_contacto_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Conexion = new EntitiesGeneral())
                {
                    decimal idPersona = 0;
                    bool resultado = false;
                    var Contacto = Conexion.tb_contacto.FirstOrDefault(q => q.IdContacto == Info.IdContacto && q.IdEmpresa == Info.IdEmpresa && q.IdPersona == Info.IdPersona);
                    if (Contacto != null)
                    {
                        if (Contacto.IdPersona != 0)
                        {
                            ActualizarPersonaDB(Info.Persona_Info, ref mensaje);
                            idPersona = Info.Persona_Info.IdPersona;
                            resultado = true;
                        }
                        if (resultado)
                        {
                            decimal idContacto = Info.IdContacto;
                            Contacto.IdPersona = idPersona;
                            Contacto.CodContacto = Info.CodContacto;
                            Contacto.Cargo = Info.Cargo;
                            Contacto.Organizacion = Info.Organizacion;
                            Contacto.Cargo = Info.Cargo;
                            Contacto.Mostrar_como = Info.Mostrar_como;
                            Contacto.Fecha_alta = Info.Fecha_alta;
                            Contacto.Fecha_Ult_Contacto = Info.Fecha_Ult_Contacto;
                            Contacto.IdPais = Info.IdPais;
                            Contacto.IdProvincia = Info.IdProvincia;
                            Contacto.IdCiudad = Info.IdCiudad;
                            Contacto.IdNacionalidad = Info.IdNacionalidad;
                            Contacto.Notas = Info.Notas;
                            Contacto.Pagina_Web = Info.Pagina_Web;
                            Contacto.foto = Info.foto;
                            Contacto.Codigo_postal = Info.Codigo_postal;
                            Contacto.FechaModificacion = DateTime.Now;
                            Contacto.UsuarioModificacion = Info.UsuarioModificacion;
                            Contacto.Estado = Info.Estado;
                            Conexion.SaveChanges();
                            mensaje = "Se ha Actulizado el contacto #: " + idContacto.ToString() + " exitosamente.";
                        }
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                String MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());

            }
        }


        public Boolean AnularContacto(tb_contacto_Info Info, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral conexion = new EntitiesGeneral())
                {
                    var Contacto = conexion.tb_contacto.FirstOrDefault(q => q.IdContacto == Info.IdContacto && q.IdEmpresa == Info.IdEmpresa);
                    if (Contacto != null)
                    {
                        Contacto.Estado = "I";
                        Contacto.FechaAnulacion = DateTime.Now;
                        Contacto.UsuarioAnulacion = Info.UsuarioAnulacion;
                        Contacto.MotivoAnulacion = Info.MotivoAnulacion;
                        conexion.SaveChanges();
                        mensaje = "Se ha Anulado el contacto #: " + Info.CodContacto + " exitosamente.";
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                String MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        public int GetIdPersona()
        {
            int Id = 0;
            try
            {
                EntitiesGeneral enPersona = new EntitiesGeneral();
                int select = (from q in enPersona.tb_persona
                              select q).Count();
                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_em = (from q in enPersona.tb_persona
                                     select q.IdPersona).Max();
                    Id = Convert.ToInt32(select_em.ToString()) + 1;
                }
                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                msj = ex.InnerException + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }
        public Boolean GrabarPersonaDB(tb_persona_Info info, ref decimal idPersona)
        {
            try
            {
                tb_persona addressPer = new tb_persona();
                using (EntitiesGeneral contextGen = new EntitiesGeneral())
                {
                    idPersona = GetIdPersona();
                    addressPer.IdPersona = idPersona;
                    addressPer.CodPersona = (info.CodPersona == null || info.CodPersona == "" || info.CodPersona == "0") ? idPersona.ToString() : info.CodPersona;
                    addressPer.pe_nombre = info.pe_nombre;
                    addressPer.pe_nombreCompleto = info.pe_nombreCompleto;
                    addressPer.pe_apellido = info.pe_apellido;
                    addressPer.IdTipoDocumento = info.IdTipoDocumento;
                    addressPer.IdTipoPersona = info.IdTipoPersona;
                    addressPer.pe_cedulaRuc = info.pe_cedulaRuc;
                    addressPer.pe_Naturaleza = info.pe_Naturaleza;
                    addressPer.pe_razonSocial = info.pe_razonSocial;
                    addressPer.IdEstadoCivil = info.IdEstadoCivil;
                    addressPer.pe_celular = info.pe_celular;
                    addressPer.pe_celularSecundario = info.pe_celularSecundario;
                    addressPer.pe_direccion = info.pe_direccion;
                    addressPer.pe_correo = info.pe_correo;
                    addressPer.pe_fechaCreacion = DateTime.Now;
                    addressPer.pe_fechaModificacion = DateTime.Now;
                    addressPer.pe_fechaNacimiento = info.pe_fechaNacimiento;
                    addressPer.pe_sexo = info.pe_sexo;
                    addressPer.pe_telefonoCasa = info.pe_telefonoCasa;
                    addressPer.pe_telefonoInter = info.pe_telefonoInter;
                    addressPer.pe_telefonoOfic = info.pe_telefonoOfic;
                    addressPer.pe_UltUsuarioModi = info.pe_UltUsuarioModi;

                    addressPer.pe_estado = info.pe_estado;
                    contextGen.tb_persona.Add(addressPer);
                    contextGen.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msj);
                msj = ex.InnerException + " " + ex.Message;
                //saca la exceopción controlada a la proxima capa
                throw new Exception(ex.ToString());
            }
        }
        public bool ActualizarPersonaDB(tb_persona_Info info, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral contextPersona = new EntitiesGeneral())
                {
                    var persona = contextPersona.tb_persona.FirstOrDefault(obj => obj.IdPersona == info.IdPersona);
                    if (persona != null)
                    {
                        persona.IdPersona = info.IdPersona;
                        persona.pe_nombre = info.pe_nombre;
                        persona.pe_apellido = info.pe_apellido;
                        persona.pe_nombreCompleto = info.pe_nombreCompleto;
                        persona.IdEstadoCivil = info.IdEstadoCivil;
                        persona.pe_fechaNacimiento = info.pe_fechaNacimiento;
                        persona.IdTipoDocumento = info.IdTipoDocumento;
                        persona.pe_cedulaRuc = info.pe_cedulaRuc;
                        persona.pe_celular = info.pe_celular;
                        persona.pe_telefonoCasa = info.pe_telefonoCasa;
                        persona.pe_Naturaleza = info.pe_Naturaleza;
                        persona.pe_razonSocial = info.pe_razonSocial;
                        persona.pe_sexo = info.pe_sexo;
                        persona.IdTipoPersona = info.IdTipoPersona;
                        persona.pe_direccion = info.pe_direccion;
                        persona.pe_estado = info.pe_estado;
                        persona.pe_fechaModificacion = DateTime.Now;
                        persona.pe_UltUsuarioModi = info.pe_UltUsuarioModi;
                        persona.CodPersona = (info.IdPersona).ToString();
                        contextPersona.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                mensaje = "Se ha producido el siguiente error: " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_contacto_Info Get_Info_contacto(int IdEmpresa, decimal IdContacto, ref string msj)
        {

            try
            {

                EntitiesGeneral Base = new EntitiesGeneral();
                var select_ = from C in Base.tb_contacto
                              where C.IdContacto == IdContacto
                              && C.IdEmpresa == IdEmpresa
                              select C;



                tb_contacto_Info info_cont = new tb_contacto_Info();

                foreach (var item in select_)
                {
                    info_cont.IdContacto = item.IdContacto;
                    info_cont.Persona_Info.IdPersona = item.IdPersona;
                    info_cont.CodContacto = item.CodContacto;
                    info_cont.IdEmpresa = item.IdEmpresa;
                    info_cont.Organizacion = item.Organizacion;
                    info_cont.Cargo = item.Cargo;
                    info_cont.Mostrar_como = item.Mostrar_como;
                    info_cont.Fecha_alta = item.Fecha_alta;
                    info_cont.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                    info_cont.IdNacionalidad = item.IdNacionalidad;
                    info_cont.Notas = item.Notas;
                    info_cont.Pagina_Web = item.Pagina_Web;
                    info_cont.Codigo_postal = item.Codigo_postal;
                    info_cont.Estado = item.Estado;
                    info_cont.IdPais = item.IdPais;
                    info_cont.IdCiudad = item.IdCiudad;
                    info_cont.IdProvincia = item.IdProvincia;
                    info_cont.IdNacionalidad = item.IdNacionalidad;
                    info_cont.foto = item.foto;
                }

                return (info_cont);
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

        public tb_contacto_Info Get_Info_contacto_x_Persona(int IdEmpresa, decimal IdPersona, ref string msj)
        {

            try
            {

                EntitiesGeneral Base = new EntitiesGeneral();
                var select_ = from C in Base.tb_contacto
                              where C.IdPersona == IdPersona
                              && C.IdEmpresa == IdEmpresa
                              select C;



                tb_contacto_Info info_cont = new tb_contacto_Info();

                foreach (var item in select_)
                {
                    info_cont.IdContacto = item.IdContacto;
                    info_cont.Persona_Info.IdPersona = item.IdPersona;
                    info_cont.CodContacto = item.CodContacto;
                    info_cont.IdEmpresa = item.IdEmpresa;
                    info_cont.Organizacion = item.Organizacion;
                    info_cont.Cargo = item.Cargo;
                    info_cont.Mostrar_como = item.Mostrar_como;
                    info_cont.Fecha_alta = item.Fecha_alta;
                    info_cont.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                    info_cont.IdNacionalidad = item.IdNacionalidad;
                    info_cont.Notas = item.Notas;
                    info_cont.Pagina_Web = item.Pagina_Web;
                    info_cont.Codigo_postal = item.Codigo_postal;
                    info_cont.Estado = item.Estado;
                    info_cont.IdPais = item.IdPais;
                    info_cont.IdCiudad = item.IdCiudad;
                    info_cont.IdProvincia = item.IdProvincia;
                    info_cont.IdNacionalidad = item.IdNacionalidad;
                    //info_cont.foto = item.foto;
                }

                return (info_cont);
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


        public byte[] Get_Image_x_contacto(int IdEmpresa, decimal IdContacto, ref string msj)
        {

            try
            {
                byte[] Foto = null;

                EntitiesGeneral Base = new EntitiesGeneral();
                var select_ = from C in Base.tb_contacto
                              where C.IdContacto == IdContacto
                              && C.IdEmpresa == IdEmpresa
                              select C;

                foreach (var item in select_)
                {
                    Foto = item.foto;
                }

                return (Foto);
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

        public Boolean GrabarDB_Lista_Contacto(List<tb_contacto_Info> Lst, ref string mensaje)
        {
            try
            {
                using (EntitiesGeneral Base = new EntitiesGeneral())
                {

                    foreach (var item in Lst)        
                    {                       
                        var select_ = from C in Base.tb_contacto
                                      where C.IdContacto == item.IdContacto
                                      && C.IdEmpresa == item.IdEmpresa
                                      select C;

                        if (select_.Count() == 0)
                        {
                            tb_contacto info_cont = new tb_contacto();
                            info_cont.IdContacto = item.IdContacto;
                            info_cont.IdPersona = item.IdPersona;
                            info_cont.CodContacto = item.CodContacto;
                            info_cont.IdEmpresa = item.IdEmpresa;
                            info_cont.Organizacion = item.Organizacion;
                            info_cont.Cargo = item.Cargo;
                            info_cont.Mostrar_como = item.Mostrar_como;
                            info_cont.Fecha_alta = item.Fecha_alta;
                            info_cont.Fecha_Ult_Contacto = item.Fecha_Ult_Contacto;
                            info_cont.IdNacionalidad = item.IdNacionalidad;
                            info_cont.Notas = item.Notas;
                            info_cont.Pagina_Web = item.Pagina_Web;
                            info_cont.Codigo_postal = item.Codigo_postal;
                            info_cont.Estado = item.Estado;
                            info_cont.IdPais = item.IdPais;
                            info_cont.IdCiudad = item.IdCiudad;
                            info_cont.IdProvincia = item.IdProvincia;
                            info_cont.IdNacionalidad = item.IdNacionalidad;
                            info_cont.foto = item.foto;

                            Base.tb_contacto.Add(info_cont);
                            Base.SaveChanges();

                        }

                        else
                        {
                            mensaje = "Error en el ingreso; código Existente";
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
