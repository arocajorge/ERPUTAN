/*CLASE: tb_persona_data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 24-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.General
{

    public class tb_persona_data
    {
        string mensaje = "";

        public List<tb_persona_Info> Get_List_Persona_x_Tipo(int IdTipoPersona)
        {
            try
            {
                List<tb_persona_Info> lst = new List<tb_persona_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectPersona = from C in OEselecEmpresa.tb_persona
                                    where C.IdTipoPersona == IdTipoPersona
                                    select C;



                foreach (var item in selectPersona)
                {

                    tb_persona_Info Cbt = new tb_persona_Info();
                    Cbt.IdPersona = item.IdPersona;
                    Cbt.IdEstadoCivil = item.IdEstadoCivil.Trim();
                    Cbt.CodPersona = item.CodPersona;
                    Cbt.IdTipoPersona = item.IdTipoPersona;
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
                    Cbt.pe_nombreCompleto = item.pe_nombreCompleto.Trim();
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

                    lst.Add(Cbt);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public List<tb_persona_Info> Get_List_Persona()
        {
            try
            {

                List<tb_persona_Info> lM = new List<tb_persona_Info>();
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectPersona = from C in OEselecEmpresa.tb_persona
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
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Persona(decimal IdPersona)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.tb_persona
                                    where C.IdPersona == IdPersona
                                    select C;


                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in selectEmpresa)
                {
                    Cbt.IdPersona = item.IdPersona;
                    Cbt.IdEstadoCivil = item.IdEstadoCivil.Trim();
                    Cbt.CodPersona = item.CodPersona.Trim();
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
                    
                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public tb_persona_Info Get_Info_Persona(string Cedula)
        {

            try
            {

                
                EntitiesGeneral base_ = new EntitiesGeneral();
                var select_ = from C in base_.tb_persona
                                    where C.pe_cedulaRuc==Cedula
                                    select C;


                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in select_)
                {


                    Cbt.IdPersona = item.IdPersona;
                    Cbt.IdEstadoCivil = item.IdEstadoCivil.Trim();
                    Cbt.CodPersona = item.CodPersona.Trim();
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_casilla = item.pe_casilla;
                    Cbt.pe_cedulaRuc = item.pe_cedulaRuc;

                    Cbt.pe_celular = item.pe_celular;
                    Cbt.pe_celularSecundario = item.pe_celularSecundario;

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
                    
                    Cbt.pe_Naturaleza = item.pe_Naturaleza;

                    Cbt.pe_correo_secundario1 = item.pe_correo_secundario1;
                    Cbt.pe_correo_secundario2 = item.pe_correo_secundario2;

                    Cbt.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                    Cbt.num_cta_acreditacion = item.num_cta_acreditacion;
                    Cbt.IdBanco_acreditacion = item.IdBanco_acreditacion;
                    
                }

                return (Cbt);
            }



            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificarDB(tb_persona_Info info, ref string msgError)
        {
            try
            {
                try
                {
                    using (EntitiesGeneral context = new EntitiesGeneral())
                    {
                        var address = context.tb_persona.FirstOrDefault(minfo => minfo.IdPersona == info.IdPersona);
                        if (address != null)
                        {
                            if (info.CodPersona == string.Empty || info.CodPersona == null)
                            { info.CodPersona = info.IdPersona.ToString(); }
                            address.IdPersona = info.IdPersona;
                            address.CodPersona = (info.CodPersona == null)? null : info.CodPersona.Trim();
                            address.pe_Naturaleza = (info.pe_Naturaleza == null) ? address.pe_Naturaleza : info.pe_Naturaleza.Trim();
                            address.pe_nombreCompleto = info.pe_nombre.Trim() + " " + info.pe_apellido.Trim();
                            address.pe_razonSocial = (info.pe_razonSocial == null)? null : info.pe_razonSocial.Trim();
                            address.pe_apellido = (info.pe_apellido == null)? null :info.pe_apellido.Trim();
                            address.pe_nombre = (info.pe_nombre == null)? null : info.pe_nombre.Trim();
                            address.IdTipoPersona = info.IdTipoPersona;
                            address.IdTipoDocumento = info.IdTipoDocumento;
                            address.pe_cedulaRuc = (info.pe_cedulaRuc == null)? null : info.pe_cedulaRuc.Trim();

                            address.pe_direccion = (info.pe_direccion == null) ? null : info.pe_direccion.Trim();
                            address.pe_telefonoCasa = (info.pe_telefonoCasa == null)? null : info.pe_telefonoCasa.Trim();
                            address.pe_telefonoInter = (info.pe_telefonoInter == null)? null : info.pe_telefonoInter.Trim();
                            address.pe_telefonoOfic = (info.pe_telefonoOfic == null)? null : info.pe_telefonoOfic.Trim();
                            address.pe_telfono_Contacto = (info.pe_telfono_Contacto == null)? null : info.pe_telfono_Contacto.Trim();
                            address.pe_celular = (info.pe_celular == null)? address.pe_celular : info.pe_celular.Trim();
                            address.pe_celularSecundario = (info.pe_celularSecundario == null)? null : info.pe_celularSecundario.Trim();

                            address.pe_correo = info.pe_correo == null ? address.pe_correo : info.pe_correo.Trim();
                            address.pe_fax = (info.pe_fax == null)? null : info.pe_fax.Trim();
                            address.pe_casilla = (info.pe_casilla == null)? null : info.pe_casilla.Trim();
                            address.pe_sexo = (info.pe_sexo == null)? null : info.pe_sexo.Trim();
                            address.IdEstadoCivil = info.IdEstadoCivil;
                            address.pe_fechaNacimiento = info.pe_fechaNacimiento;
                            //address.pe_estado = (info.pe_estado == null) ? "A" : info.pe_estado;
                            //address.pe_fechaCreacion = (info.pe_fechaCreacion == null) ? DateTime.Now : info.pe_fechaCreacion;
                            address.pe_fechaModificacion = (info.pe_fechaModificacion == null) ? DateTime.Now : info.pe_fechaModificacion;
                            address.pe_UltUsuarioModi = info.IdUsuario ;

                            address.pe_correo_secundario1 = (info.pe_correo_secundario1 == null || info.pe_correo_secundario1 == "")? null : info.pe_correo_secundario1.Trim();
                            address.pe_correo_secundario2 = (info.pe_correo_secundario2 == null || info.pe_correo_secundario2 == "")? null : info.pe_correo_secundario2.Trim();

                            address.IdTipoCta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                            address.num_cta_acreditacion = info.num_cta_acreditacion;
                            address.IdBanco_acreditacion = (info.IdBanco_acreditacion == 0) ? null : info.IdBanco_acreditacion;


                            context.SaveChanges();
                        }
                    }
                    return true;
                }
                catch (DbEntityValidationException ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                    mensaje = ex.ToString() + " " + ex.Message;
                    mensaje = "Error al Grabar" + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean ModificaPersEmpl(tb_persona_Info info)
        {

            try
            {
                 using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_persona.FirstOrDefault(minfo => minfo.IdPersona == info.IdPersona);
                    if (contact != null)
                    {

                        if (info.CodPersona == string.Empty || info.CodPersona == null)
                        { info.CodPersona = info.IdPersona.ToString(); }
                        contact.CodPersona = info.CodPersona;
                        contact.IdEstadoCivil = info.IdEstadoCivil.Trim();
                        contact.pe_apellido = info.pe_apellido;
                        contact.pe_nombre = info.pe_nombre;
                        contact.pe_cedulaRuc = info.pe_cedulaRuc;
                        contact.pe_celular = info.pe_celular;
                        contact.pe_celularSecundario = info.pe_celularSecundario;

                        contact.pe_direccion = info.pe_direccion;
                        contact.pe_estado = info.pe_estado;
                        contact.pe_fechaModificacion = DateTime.Now;
                        contact.pe_fechaNacimiento = info.pe_fechaNacimiento;
                        contact.pe_Naturaleza = info.pe_Naturaleza.Trim();
                        contact.pe_nombreCompleto = info.pe_nombreCompleto.Trim();
                        contact.pe_sexo = info.pe_sexo.Trim();
                        contact.pe_telfono_Contacto = info.pe_telfono_Contacto;
                        
                        contact.IdTipoDocumento = info.IdTipoDocumento.Trim();
                        contact.pe_UltUsuarioModi = info.pe_UltUsuarioModi;

                        
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean GrabarDB(tb_persona_Info info, ref decimal idPersonaOut, ref string msgError)
        {
            try
            {
                decimal idPersona = 0;

                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    EntitiesGeneral EDB = new EntitiesGeneral();
                    var Q = from per in EDB.tb_persona
                            where per.IdPersona == info.IdPersona 
                            
                            select per;
                    if (Q.ToList().Count == 0)
                    {

                        idPersona = idPersonaOut = getIdPersona();

                        tb_persona address = new tb_persona();

                        if (info.CodPersona == string.Empty || (info.CodPersona == null))
                        {
                            info.CodPersona = idPersona.ToString();
                        }

                        address.IdPersona = idPersona;
                        address.CodPersona = (info.CodPersona == null)? null :info.CodPersona.Trim();
                        address.pe_Naturaleza = (info.pe_Naturaleza == null)? null : info.pe_Naturaleza.Trim();
                        address.pe_nombreCompleto = info.pe_nombre.Trim() + " " + info.pe_apellido.Trim();
                        address.pe_razonSocial = (info.pe_razonSocial == null)? null :info.pe_razonSocial.Trim();
                        address.pe_apellido = (info.pe_apellido == null)? null : info.pe_apellido.Trim();
                        address.pe_nombre = (info.pe_nombre == null)? null : info.pe_nombre.Trim();
                        address.IdTipoPersona = info.IdTipoPersona;
                        address.IdTipoDocumento = info.IdTipoDocumento;
                        address.pe_cedulaRuc = (info.pe_cedulaRuc == null)? null : info.pe_cedulaRuc.Trim();
                        address.pe_direccion = (info.pe_direccion == null)? null : info.pe_direccion.Trim();

                        address.pe_telefonoCasa = (info.pe_telefonoCasa == null)? null : info.pe_telefonoCasa.Trim();
                        address.pe_telefonoInter = (info.pe_telefonoInter == null)? null : info.pe_telefonoInter.Trim();
                        address.pe_telefonoOfic = (info.pe_telefonoOfic == null)? null : info.pe_telefonoOfic.Trim();
                        address.pe_telfono_Contacto = (info.pe_telfono_Contacto == null)? null : info.pe_telfono_Contacto.Trim();
                        address.pe_celular = (info.pe_celular == null)? null : info.pe_celular.Trim();
                        address.pe_celularSecundario = (info.pe_celularSecundario == null) ? null : info.pe_celularSecundario.Trim();

                        address.pe_correo = info.pe_correo == null ? "" : info.pe_correo.Trim();
                        address.pe_fax = (info.pe_fax == null)? null : info.pe_fax.Trim();
                        address.pe_casilla = (info.pe_casilla == null)? null : info.pe_casilla.Trim();
                        address.pe_sexo = (info.pe_sexo == null)? null : info.pe_sexo.Trim();// "SEXO_MAS";
                        address.IdEstadoCivil = info.IdEstadoCivil;
                        address.pe_fechaNacimiento = info.pe_fechaNacimiento;
                        address.pe_estado = "A";
                        address.pe_fechaCreacion = DateTime.Now;
                        //address.pe_fechaModificacion = DateTime.Now;
                        address.pe_UltUsuarioModi = info.pe_UltUsuarioModi;
                        
                        address.pe_correo_secundario1 = (info.pe_correo_secundario1 == null || info.pe_correo_secundario1 == "")? null : info.pe_correo_secundario1.Trim();
                        address.pe_correo_secundario2 = (info.pe_correo_secundario2 == null || info.pe_correo_secundario2 == "")? null : info.pe_correo_secundario2.Trim();

                        address.IdTipoCta_acreditacion_cat = (info.IdTipoCta_acreditacion_cat == "") ? null : info.IdTipoCta_acreditacion_cat;
                        address.num_cta_acreditacion = info.num_cta_acreditacion;
                        address.IdBanco_acreditacion = (info.IdBanco_acreditacion == 0) ? null : info.IdBanco_acreditacion;

                        
                        context.tb_persona.Add(address);

                        context.SaveChanges();
                    }
                    else
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                mensaje = "Error al Grabar" + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
       
        
        
        public decimal getIdPersona()
        {
            try
            {
                     decimal IdPersona;

                    
                    EntitiesGeneral OECbtecble = new EntitiesGeneral();

                    var selectCbtecble = (from CbtCble in OECbtecble.tb_persona
                                          select CbtCble.IdPersona);
                    if (selectCbtecble.Count() == 0)
                    {
                        IdPersona = 1;

                    }
                    else
                    {
                        var selectCbtecble_ = (from CbtCble in OECbtecble.tb_persona
                                              select CbtCble.IdPersona).Max()+1;
                        IdPersona = selectCbtecble_;

                    }

                    return IdPersona;
                   
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean AnularDB(tb_persona_Info info, ref string msgError)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {
                    var contact = context.tb_persona.FirstOrDefault(minfo => minfo.IdPersona == info.IdPersona);
                    if (contact != null)
                    {
                        contact.pe_estado = "I";
                        contact.Fecha_UltAnu = DateTime.Now;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
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
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ExisteCedula(string cedula, ref string mensaje)
        {
            try
            {
                    Boolean Existe;

                    string scedula;

                    scedula=cedula.Trim();
                    mensaje = "";
                    Existe = false;

                    EntitiesGeneral OECbtecble = new EntitiesGeneral();

                    var selectCbtecble = from CbtCble in OECbtecble.tb_persona
                                         where CbtCble.pe_cedulaRuc == scedula
                                         select CbtCble;

                       foreach (var item in selectCbtecble)
                       {
                           mensaje = mensaje + " " +item.pe_apellido + " " + item.pe_nombre;
                           Existe = true;
                       }

                       return Existe;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public tb_persona_data() { }

        public Boolean GetExiste(tb_persona_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesGeneral db = new EntitiesGeneral())
                {
                    int cont = (from a in db.tb_persona
                                where a.IdPersona==info.IdPersona
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = msg = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public tb_persona_Info Get_Info_Beneficiario_OP(int IdEmpresa, string  IdTipoPersona,int IdPersona,int IdEntidad)
        {
            try
            {
                EntitiesGeneral OEselecEmpresa = new EntitiesGeneral();
                var selectEmpresa = from C in OEselecEmpresa.vwtb_persona_beneficiario_por_Banco_Acreditacion
                                    where C.IdTipo_Persona == IdTipoPersona
                                    && C.IdEntidad==IdEntidad
                                    && C.IdPersona==IdPersona
                                    && C.IdEmpresa==IdEmpresa
                                    select C;


                tb_persona_Info Cbt = new tb_persona_Info();

                foreach (var item in selectEmpresa)
                {
                    Cbt.IdPersona = item.IdPersona;
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.pe_cedulaRuc = item.pe_cedulaRuc;
                    Cbt.pe_celular = item.pe_celular;

                    Cbt.pe_correo = item.pe_correo;
                    Cbt.pe_direccion = item.pe_direccion;

                    Cbt.pe_Naturaleza = item.pe_Naturaleza.Trim();
                    Cbt.pe_nombreCompleto = item.pe_nombreCompleto;
                    Cbt.pe_razonSocial = item.pe_razonSocial;
                    Cbt.pe_apellido = item.pe_apellido;
                    Cbt.pe_nombre = item.pe_nombre;
                    Cbt.IdTipoDocumento = item.IdTipoDocumento;
   
                    

                      Cbt.IdTipoCta_acreditacion_cat = item.IdTipoCta_acreditacion_cat;
                        Cbt. num_cta_acreditacion = item.num_cta_acreditacion;
                       Cbt. IdBanco_acreditacion = item.IdBanco_acreditacion;

                       Cbt. CodigoLegal = item.CodigoLegal;
                }
                return (Cbt);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

      
    }
}
