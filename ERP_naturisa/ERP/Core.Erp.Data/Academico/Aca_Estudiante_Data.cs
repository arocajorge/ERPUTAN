using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data;
using System.Data.SqlClient;

namespace Core.Erp.Data.Academico
{
    
    public class Aca_Estudiante_Data
    {
        string MensajeError = "";
        string mensaje="";
        public bool ExisteCedula(int IdInstitucion, decimal idEstudiante, string cedulaRuc, ref string mensaje)
        {            
            try
            {
                using (Entities_Academico Base = new Entities_Academico()) {
                    if (idEstudiante == 0)
                    {
                        int existe = (from e in Base.vwAca_estudiante
                                      where e.IdInstitucion == IdInstitucion && e.pe_cedulaRuc == cedulaRuc
                                      select e).Count();

                        if (existe != 0)
                        {
                            mensaje = "Cédula o Ruc ya se encuentra ingresado.";
                            return true;
                        }
                        else { return false; }
                    }
                    else {
                        var estudiante = Base.vwAca_estudiante.First(o => o.IdInstitucion == IdInstitucion && o.pe_cedulaRuc == cedulaRuc);
                        if (estudiante.IdEstudiante != idEstudiante)
                        {
                            mensaje = "Cédula o Ruc ya se encuentra ingresado.";
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
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }        
        }

        #region "Get"


        public Aca_Estudiante_Info Get_Info_Estudiante_x_Codigo2(int IdInstitucion,string Codigo2_Estudiante)
        {
            
            try
            {
                Aca_Estudiante_Info info = new Aca_Estudiante_Info();

                Entities_Academico db = new Entities_Academico();
                var select = from A in db.vwAca_estudiante
                             where A.IdInstitucion == IdInstitucion
                             && A.cod_estudiante2 == Codigo2_Estudiante
                             select A;


                foreach (var item in select)
                {
                    
                    info.IdInstitucion = item.IdInstitucion;
                    info.IdEstudiante = item.IdEstudiante;
                    info.cod_estudiante = item.cod_estudiante;
                    info.cod_estudiante2 = item.cod_estudiante2;
                    info.lugar = item.lugar;
                    info.barrio = item.barrio;
                    info.foto = item.foto;
                    info.cod_alterno = item.cod_alterno;
                    info.estado = item.estado;


                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.IdPersona = item.IdPersona;
                    personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                    personaInfo.pe_apellido = item.pe_apellido;
                    personaInfo.pe_nombre = item.pe_nombre;
                    personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                    personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                    personaInfo.pe_correo = item.pe_correo;
                    personaInfo.pe_celular = item.pe_celular;
                    personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                    personaInfo.pe_estado = item.estado;
                    personaInfo.pe_direccion = item.pe_direccion;
                    personaInfo.pe_sexo = item.pe_sexo;
                    personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;

                    Aca_Familiar_Data Data_Familiar = new Aca_Familiar_Data();


                    info.Info_Familiar_Repre_Econo = Data_Familiar.GetRepre_Economico_x_Estudiante(info.IdInstitucion, info.IdEstudiante);
                    info.IdPersona_RepEco = info.Info_Familiar_Repre_Econo.IdPersona;
                  


                    info.Persona_Info = personaInfo;

                
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Aca_Estudiante_Info Get_Info_Estudiante_x_IdPersona(int IdInstitucion,decimal IdPersona)
        {
            
            try
            {
                Aca_Estudiante_Info info = new Aca_Estudiante_Info();

                Entities_Academico db = new Entities_Academico();
                var select = from A in db.vwAca_estudiante
                             where A.IdInstitucion == IdInstitucion
                             && A.IdPersona == IdPersona
                             select A;


                foreach (var item in select)
                {
                    
                    info.IdInstitucion = item.IdInstitucion;
                    info.IdEstudiante = item.IdEstudiante;
                    info.cod_estudiante = item.cod_estudiante;
                    info.cod_estudiante2 = item.cod_estudiante2;
                    info.lugar = item.lugar;
                    info.barrio = item.barrio;
                    info.foto = item.foto;
                    info.cod_alterno = item.cod_alterno;
                    info.estado = item.estado;


                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.IdPersona = item.IdPersona;
                    personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                    personaInfo.pe_apellido = item.pe_apellido;
                    personaInfo.pe_nombre = item.pe_nombre;
                    personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                    personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                    personaInfo.pe_correo = item.pe_correo;
                    personaInfo.pe_celular = item.pe_celular;
                    personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                    personaInfo.pe_estado = item.estado;
                    personaInfo.pe_direccion = item.pe_direccion;
                    personaInfo.pe_sexo = item.pe_sexo;
                    personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;

                    Aca_Familiar_Data Data_Familiar = new Aca_Familiar_Data();


                    info.Info_Familiar_Repre_Econo = Data_Familiar.GetRepre_Economico_x_Estudiante(info.IdInstitucion, info.IdEstudiante);
                    info.IdPersona_RepEco = info.Info_Familiar_Repre_Econo.IdPersona;
                  


                    info.Persona_Info = personaInfo;

                
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Aca_Estudiante_Info> Get_List_Estudiantes(int IdInstitucion)
                {
                    List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
                    try
                    {
                        Entities_Academico db = new Entities_Academico();
                        var select = from A in db.vwAca_Estudiante_Matricula_Con_y_Sin_Contrato
                                     where A.IdInstitucion == IdInstitucion
                                     orderby A.IdEstudiante
                                     select A;

                        foreach (var item in select)
                        {
                            Aca_Estudiante_Info info = new Aca_Estudiante_Info();
                            //info.IdInstitucion = item.IdInstitucion;
                            info.IdEstudiante = item.IdEstudiante;
                            //info.cod_estudiante = item.cod_estudiante;
                            //info.lugar = item.lugar;
                            //info.barrio = item.barrio;
                            //info.foto = item.foto;
                            //info.cod_alterno = item.cod_alterno;
                           // info.estado = item.estado;
                           

                            tb_persona_Info personaInfo = new tb_persona_Info();
                            //personaInfo.IdPersona = item.IdPersona;
                            //personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                            //personaInfo.pe_apellido = item.pe_apellido;
                            //personaInfo.pe_nombre = item.pe_nombre;
                            personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                            info.NombreCompleto = item.pe_apellido+ " " +item.pe_nombre;
                            //personaInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                            //personaInfo.pe_correo = item.pe_correo;
                            //personaInfo.pe_celular = item.pe_celular;
                            //personaInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                            //personaInfo.pe_estado = item.estado;
                            //personaInfo.pe_direccion = item.pe_direccion;
                            //personaInfo.pe_sexo = item.pe_sexo;
                            //personaInfo.pe_fechaNacimiento = item.pe_fechaNacimiento;
                            info.Persona_Info = personaInfo;

                            tb_pais_Info paisInfo = new tb_pais_Info();
                            //tb_pais_Info paisInfo2 = new tb_pais_Info();
                            //tb_pais_Info paisInfo3 = new tb_pais_Info();
                            
                            paisInfo.IdPais = item.IdPais_Nacionalidad;
                            paisInfo.Nacionalidad = item.Nacionalidad;
                            info.Pais_Info = paisInfo;

                            info.IdSede = item.IdSede;
                            info.IdJornada = item.IdJornada;
                            info.IdSeccion = item.IdSeccion;
                            info.IdCurso = item.IdCurso;
                            info.IdParalelo = item.IdParalelo;

                            info.Sede = item.Sede;
                            info.Jornada = item.Jornada;
                            info.Seccion = item.Seccion;
                            info.Curso = item.Curso;
                            //info.IdPersona_RepEco = GetId_RepresentateEconomico_x_Estudiante(item.IdEstudiante);
                            info.Paralelo = item.Paralelo;

                           
                            //paisInfo2.IdPais = item.IdPais_Nacionalidad;
                            //paisInfo2.Nacionalidad = item.Nacionalidad;
                            //info.Pais_Info2 = paisInfo2;

                            //paisInfo3.IdPais = item.IdPais_Nacionalidad;
                            //paisInfo3.Nacionalidad = item.Nacionalidad;
                            //info.Pais_Info3 = paisInfo3;

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
                        throw new Exception(ex.InnerException.ToString());
                    }
                }

        public List<Aca_Estudiante_Info> Get_List_Estudiantes_Sin_Matricula(int IdInstitucion)
        {
            List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
            try
            {
                Entities_Academico db = new Entities_Academico();
                var select = from A in db.vwAca_Estudiante_Sin_Matricula_Con_y_Sin_Contrato
                             where A.IdInstitucion == IdInstitucion
                             orderby A.IdEstudiante
                             select A;

                foreach (var item in select)
                {
                    Aca_Estudiante_Info info = new Aca_Estudiante_Info();
                    info.IdInstitucion = Convert.ToInt32(item.IdInstitucion);
                    info.IdEstudiante = Convert.ToDecimal(item.IdEstudiante);
                    info.cod_estudiante = item.cod_estudiante;

                    info.cod_estudiante2 = item.cod_estudiante2;

                    info.lugar = item.lugar;
                    info.barrio = item.barrio;
                    info.foto = item.foto;
                    info.cod_alterno = item.cod_alterno;
                    info.estado = item.estado;


                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.IdPersona = item.IdPersona;
                    personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                    personaInfo.pe_apellido = item.pe_apellido;
                    personaInfo.pe_nombre = item.pe_nombre;
                    personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.NombreCompleto = item.pe_nombreCompleto;
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
                    //tb_pais_Info paisInfo2 = new tb_pais_Info();
                    //tb_pais_Info paisInfo3 = new tb_pais_Info();

                    paisInfo.IdPais = item.IdPais_Nacionalidad;
                    paisInfo.Nacionalidad = item.Nacionalidad;
                    info.Pais_Info = paisInfo;

                    //info.IdSede = Convert.ToInt16(item.IdSede);
                    //info.IdJornada = Convert.ToInt16(item.IdJornada);
                    //info.IdSeccion = Convert.ToInt16(item.IdSeccion);
                    //info.IdCurso = Convert.ToInt16(item.IdCurso);
                    //info.IdParalelo = Convert.ToInt16(item.IdParalelo);

                    //info.Sede = item.Sede;
                    //info.Jornada = item.Jornada;
                    //info.Seccion = item.Seccion;
                    //info.Curso = item.Curso;
                    //info.Paralelo = item.Paralelo;

                    //SE COMENTA NO ES NECESARIO BUSCAR EL REPECO X ESTUDIANTE.
                    //info.IdPersona_RepEco = GetId_RepresentateEconomico_x_Estudiante(Convert.ToDecimal(item.IdEstudiante));

                    //paisInfo2.IdPais = item.IdPais_Nacionalidad;
                    //paisInfo2.Nacionalidad = item.Nacionalidad;
                    //info.Pais_Info2 = paisInfo2;

                    //paisInfo3.IdPais = item.IdPais_Nacionalidad;
                    //paisInfo3.Nacionalidad = item.Nacionalidad;
                    //info.Pais_Info3 = paisInfo3;

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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<Aca_Estudiante_Info> GetListEstudiante_x_RepresentateEconomico(int IdInstitucion, decimal IdPersona)
        {
            List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
            try
            {
                Entities_Academico db = new Entities_Academico();
                var select = from A in db.vwAca_Estudiante_Matricula_Con_y_Sin_Contrato
                             join F in db.vwAca_Familiar_x_Estudiante_RepEco on A.IdEstudiante equals F.IdEstudiante
                             where A.IdInstitucion == IdInstitucion && F.IdPersona == IdPersona && F.activo == true
                             orderby A.IdEstudiante
                             select A;

                foreach (var item in select)
                {
                    Aca_Estudiante_Info info = new Aca_Estudiante_Info();
                    info.IdInstitucion = item.IdInstitucion;
                    info.IdEstudiante = item.IdEstudiante;
                    info.cod_estudiante = item.cod_estudiante;
                    info.lugar = item.lugar;
                    info.barrio = item.barrio;
                    info.foto = item.foto;
                    info.cod_alterno = item.cod_alterno;
                    info.estado = item.estado;


                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.IdPersona = item.IdPersona;
                    personaInfo.IdTipoDocumento = item.IdTipoDocumento;
                    personaInfo.pe_apellido = item.pe_apellido;
                    personaInfo.pe_nombre = item.pe_nombre;
                    personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                    info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
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
                    //tb_pais_Info paisInfo2 = new tb_pais_Info();
                    //tb_pais_Info paisInfo3 = new tb_pais_Info();

                    paisInfo.IdPais = item.IdPais_Nacionalidad;
                    paisInfo.Nacionalidad = item.Nacionalidad;
                    info.Pais_Info = paisInfo;

                    info.IdSede = item.IdSede;
                    info.IdJornada = item.IdJornada;
                    info.IdSeccion = item.IdSeccion;
                    info.IdCurso = item.IdCurso;
                    info.IdParalelo = item.IdParalelo;

                    info.Sede = item.Sede;
                    info.Jornada = item.Jornada;
                    info.Seccion = item.Seccion;
                    info.Curso = item.Curso;
                    info.Paralelo = item.Paralelo;

                    //paisInfo2.IdPais = item.IdPais_Nacionalidad;
                    //paisInfo2.Nacionalidad = item.Nacionalidad;
                    //info.Pais_Info2 = paisInfo2;

                    //paisInfo3.IdPais = item.IdPais_Nacionalidad;
                    //paisInfo3.Nacionalidad = item.Nacionalidad;
                    //info.Pais_Info3 = paisInfo3;

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
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal GetId_RepresentateEconomico_x_Estudiante(decimal IdEstudiante)
        {
            decimal IdPersona_RepEco=0;

            try
            {
                Entities_Academico db = new Entities_Academico();
                var select = (from F in db.vwAca_Familiar_x_Estudiante_RepEco
                             where F.IdEstudiante == IdEstudiante && F.activo == true
                             orderby F.IdEstudiante
                             select new { F.IdPersona }).SingleOrDefault();
                if (select != null)
                {
                    IdPersona_RepEco = Convert.ToDecimal(select.IdPersona);
                }
                return IdPersona_RepEco;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public int getId(int IdInstitucion)
                {
                    int Id = 0;
                    try
                    {
                        Entities_Academico OEEstudiante = new Entities_Academico();
                        int select = ( from q in OEEstudiante.Aca_estudiante
                                       where q.IdInstitucion == IdInstitucion
                                     select q).Count();

                        if (select == 0)
                        {
                            Id = 1;
                        }
                        else
                        {
                            var select_em = (from q in OEEstudiante.Aca_estudiante
                                             where q.IdInstitucion == IdInstitucion
                                             select q.IdEstudiante).Max();
                            Id = Convert.ToInt32(select_em.ToString()) + 1;
                        }
                        return Id;
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

        public List<Aca_Estudiante_Info> Get_List_Estudiantes_Sin_Matricula_Dual(int IdInstitucion)
        {
            List<Aca_Estudiante_Info> lM = new List<Aca_Estudiante_Info>();
            try
            {
                Entities_Academico db = new Entities_Academico();
                var select = from A in db.vwAca_Estudiante_Sin_Maticula
                             where A.IdInstitucion == IdInstitucion
                             orderby A.IdEstudiante
                             select A;

                foreach (var item in select)
                {
                    Aca_Estudiante_Info info = new Aca_Estudiante_Info();
                    info.IdInstitucion = item.IdInstitucion;
                    info.IdEstudiante = item.IdEstudiante;



                    tb_persona_Info personaInfo = new tb_persona_Info();
                    personaInfo.pe_nombreCompleto = item.pe_nombreCompleto;
                    personaInfo.IdPersona = item.IdEstudiante;
                    info.Persona_Info = personaInfo;

                    tb_pais_Info paisInfo = new tb_pais_Info();

                    paisInfo.IdPais = item.IdPais_Nacionalidad;
                    paisInfo.Nacionalidad = item.Nacionalidad;
                    info.Pais_Info = paisInfo;

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
                throw new Exception(ex.InnerException.ToString());
            }
        }
        

        #endregion

        #region "Insert,Update,Delete"
            public Boolean ActualizarDB(Aca_Estudiante_Info info,ref string msj) 
            {
                try { 
                    using(Entities_Academico context =new Entities_Academico()){
                        var estudiante = context.Aca_estudiante.FirstOrDefault(obj => obj.IdInstitucion == info.IdInstitucion && obj.IdEstudiante == info.IdEstudiante);
                        if (estudiante != null)
                        {
                            decimal idEstudiante = info.IdEstudiante;
                            estudiante.cod_estudiante = info.cod_estudiante;
                            estudiante.IdPersona = info.Persona_Info.IdPersona;
                            estudiante.IdPais_Nacionalidad = info.Pais_Info.IdPais;
                            estudiante.IdPais_Nacionalidad2 = info.Pais_Info2.IdPais;
                            estudiante.IdPais_Nacionalidad3 = info.Pais_Info3.IdPais;
                            estudiante.lugar = (info.lugar == null) ? "" : info.lugar;
                            estudiante.FechaModificacion = DateTime.Now;
                            estudiante.UsuarioModificacion = info.UsuarioModificacion;
                            estudiante.foto = info.foto;
                            estudiante.estado = info.estado;
                            estudiante.barrio = (info.barrio == null) ? "" : info.barrio;

                            context.SaveChanges();


                            tb_persona_data Persona_Data = new tb_persona_data();

                            Persona_Data.ModificarDB(info.Persona_Info, ref msj);

                            msj = "Se ha procedido actualizar el Estudiante #: " + idEstudiante.ToString() + " exitosamente.";
                        }

                    return true;
                    }            
                }
                catch(Exception ex)
                {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    MensajeError = ex.InnerException + " " + ex.Message;
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                    msj = "Se ha producido el siguiente error: " + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }

            public Boolean GrabarDB(Aca_Estudiante_Info info, ref decimal id, ref string msg)
            {
                try
                {
                    using (Entities_Academico context = new Entities_Academico())
                    {
                            try{
                                 bool resultado=false;
                                Aca_estudiante addressEstudiante = new Aca_estudiante();
                                tb_persona_data Persona_Data = new tb_persona_data();

                             
                                info.IdEstudiante = id = getId(info.IdInstitucion);
                                decimal idPersona = 0;

                                if (info.Persona_Info.IdPersona == 0)
                                {
                                    if (Persona_Data.ExisteCedula(info.Persona_Info.pe_cedulaRuc, ref msg) == false)
                                    {
                                        resultado = Persona_Data.GrabarDB(info.Persona_Info, ref idPersona, ref msg);
                                    }
                                   
                                }
                                else 
                                {
                                  Persona_Data.ModificarDB(info.Persona_Info, ref msg);                                
                                  idPersona = info.Persona_Info.IdPersona;
                                  resultado = true; 
                                }
                                
                                if (resultado)
                                {
                                    addressEstudiante.IdInstitucion = info.IdInstitucion;
                                    addressEstudiante.IdEstudiante = info.IdEstudiante;
                                    addressEstudiante.IdPersona = idPersona;
                                    addressEstudiante.cod_estudiante = (info.cod_estudiante == null || info.cod_estudiante.Trim() == "" || info.cod_estudiante.Trim()=="0") ? info.IdEstudiante.ToString() : info.cod_estudiante;
                                    addressEstudiante.cod_estudiante2 = (info.cod_estudiante2 == null) ? addressEstudiante.cod_estudiante : info.cod_estudiante2;
                                    addressEstudiante.lugar = (info.lugar == null) ? "" : info.lugar;
                                    addressEstudiante.barrio = (info.barrio == null) ? "" : info.barrio;
                                    addressEstudiante.foto = info.foto;
                                    addressEstudiante.cod_alterno = (info.cod_alterno == null) ? addressEstudiante.cod_estudiante : info.cod_alterno;
                                    addressEstudiante.IdPais_Nacionalidad = (info.Pais_Info.IdPais == null) ? "1" :  info.Pais_Info.IdPais.ToString();
                                    addressEstudiante.IdPais_Nacionalidad2 = (info.Pais_Info2.IdPais == null) ? "1" : info.Pais_Info2.IdPais.ToString();
                                    addressEstudiante.IdPais_Nacionalidad3 = (info.Pais_Info3.IdPais == null) ? "1" : info.Pais_Info3.IdPais.ToString();
                                    addressEstudiante.estado = (info.estado == null) ? "A" : info.estado;
                                    addressEstudiante.FechaCreacion = DateTime.Now;
                                    addressEstudiante.UsuarioCreacion = info.UsuarioCreacion;
                                    context.Aca_estudiante.Add(addressEstudiante);
                                    context.SaveChanges();
                                    msg = "Se ha procedido a grabar el Estudiante #: " + id.ToString() + " exitosamente.";
                                }

                                return true;
                            }
                            catch(Exception ex)
                            {
                                string arreglo = ToString();
                                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                                    "", "", "", "", DateTime.Now);
                                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                                msg = ex.InnerException + " " + ex.Message;
                                throw new Exception(ex.InnerException.ToString());
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
                    msg = "Se ha producido el siguiente error: " + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }

            public Boolean AnularDB(Aca_Estudiante_Info info, ref string msg)
            {                
                try { 
                 using (Entities_Academico context=new Entities_Academico())
                 {
                     var address = context.Aca_estudiante.FirstOrDefault(a => a.IdInstitucion == info.IdInstitucion && a.IdEstudiante == info.IdEstudiante);
                     if (address != null)
                     {
                         address.estado = "I";
                         address.FechaAnulacion = DateTime.Now;
                         address.UsuarioAnulacion = info.UsuarioAnulacion;
                         address.MotivoAnulacion = info.MotivoAnulacion;
                         context.SaveChanges();
                         msg = "Se ha procedido anular al Estudiante #: " + info.IdEstudiante.ToString() + " exitosamente.";
                     }
                     return true;
                 }                
                }            
                catch (Exception ex) {
                    string arreglo = ToString();
                    tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                    tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                    oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                    msg = "Se ha producido el siguiente error: " + ex.Message;
                    throw new Exception(ex.ToString());
                }
            }

        #endregion
          
        public Aca_Estudiante_Data()
        {

        }
    }
}