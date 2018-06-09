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
    public class Aca_Contrato_x_Estudiante_Data
    {
        public int GetId()
        {
            int Id = 0;
            try
            {
                Entities_Academico Base = new Entities_Academico();
                int select = (from q in Base.Aca_Contrato_x_Estudiante
                              select q).Count();
                if (select == 0)
                {
                    Id = 1;
                }
                else
                {
                    var select_as = (from q in Base.Aca_Contrato_x_Estudiante
                                     select q.IdContrato).Max();
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

        public List<Aca_Contrato_x_Estudiante_Info> Get_Lista_Contrato_x_Estudiante(int IdInstitucion)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            Aca_Contrato_x_Estudiante_Info Contrato_x_EstudianteInfo;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vContrato_x_Estudiante = from c in Base.Aca_Contrato_x_Estudiante
                                 join matri in Base.Aca_matricula on c.IdMatricula equals matri.IdMatricula
                                 join paralelo in Base.Aca_Paralelo on matri.IdParalelo equals paralelo.IdParalelo
                                 join cur in Base.Aca_curso on paralelo.IdCurso equals cur.IdCurso
                                 join sec in Base.Aca_Seccion on cur.IdSeccion equals sec.IdSeccion
                                 join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                                 join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                                 where sed.IdInstitucion == IdInstitucion
                                 select c;
                    foreach (var item in vContrato_x_Estudiante)
                    {
                        Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_Info();
                        
                        Contrato_x_EstudianteInfo.IdContrato = item.IdContrato;
                        //Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                        Contrato_x_EstudianteInfo.IdMatricula = item.IdMatricula;
                        //Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                        Contrato_x_EstudianteInfo.IdAnioLectivo = item.IdAnioLectivo;
                        Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                        //Contrato_x_EstudianteInfo.FechaCreacion = item.FechaCreacion;
                        Contrato_x_EstudianteInfo.observacion = item.observacion;

                        lista.Add(Contrato_x_EstudianteInfo);
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
        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Contrato_x_Estudiante(int IdInstitucion, int IdSede)
        {
            List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();
            Aca_Contrato_x_Estudiante_Info Contrato_x_EstudianteInfo;
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {

                    var vContrato_x_Estudiante = from c in Base.Aca_Contrato_x_Estudiante
                                                 join matri in Base.Aca_matricula on c.IdMatricula equals matri.IdMatricula
                                                 join paralelo in Base.Aca_Paralelo on matri.IdParalelo equals paralelo.IdParalelo
                                                 join cur in Base.Aca_curso on paralelo.IdCurso equals cur.IdCurso
                                                 join sec in Base.Aca_Seccion on cur.IdSeccion equals sec.IdSeccion
                                                 join jor in Base.Aca_Jornada on sec.IdJornada equals jor.IdJornada
                                                 join sed in Base.Aca_Sede on jor.IdSede equals sed.IdSede
                                                 where sed.IdInstitucion == IdInstitucion && sed.IdSede == IdSede
                                                 select c;
            
                    foreach (var item in vContrato_x_Estudiante)
                    {
                        Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_Info();
                        Contrato_x_EstudianteInfo.IdContrato = item.IdContrato;
                        //Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                        Contrato_x_EstudianteInfo.IdMatricula = item.IdMatricula;
                        //Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                        Contrato_x_EstudianteInfo.IdAnioLectivo = item.IdAnioLectivo;
                        Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                        Contrato_x_EstudianteInfo.FechaCreacion = Convert.ToDateTime(item.FechaCreacion);
                        Contrato_x_EstudianteInfo.observacion = item.observacion;
                        lista.Add(Contrato_x_EstudianteInfo);
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

        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Estudiante_con_Contrato(int IdInstitucion, int IdSede)
        {
            try
            {


                List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();

                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Contrato_Preparacion_x_Estudiante
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            Aca_Contrato_x_Estudiante_Info Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_Info();
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;

                            Contrato_x_EstudianteInfo.IdInstitucion = item.IdInstitucion;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdAnioLectivo = item.IdAnioLectivo;

                            //Contrato_x_EstudianteInfo.IdPeriodoLectivo = item.IdPeriodoLectivo;

                            Contrato_x_EstudianteInfo.IdMatricula = item.IdMatricula;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.cod_estudiante = item.cod_estudiante;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.pe_nombre = item.pe_nombre;
                            Contrato_x_EstudianteInfo.pe_apellido = item.pe_apellido;

                            Contrato_x_EstudianteInfo.nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Contrato_x_EstudianteInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                            Contrato_x_EstudianteInfo.pe_direccion = item.pe_direccion;
                            Contrato_x_EstudianteInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                            Contrato_x_EstudianteInfo.pe_telefonoOfic = item.pe_telefonoOfic;
                            Contrato_x_EstudianteInfo.Fecha_matricula = item.FechaMatricula;
                            Contrato_x_EstudianteInfo.FechaCreacionEstudiante = Convert.ToDateTime(item.FechaCreacionEstudiante);

                            Contrato_x_EstudianteInfo.Sede = item.Sede;
                            Contrato_x_EstudianteInfo.Jornada = item.Jornada;
                            Contrato_x_EstudianteInfo.Seccion = item.Seccion;
                            Contrato_x_EstudianteInfo.Curso = item.Curso;
                            Contrato_x_EstudianteInfo.Paralelo = item.Paralelo;
                            Contrato_x_EstudianteInfo.estado_contrato_pago_garantizado = item.estado_contrato_pago_garantizado;
                            //Contrato_x_EstudianteInfo.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                            //Contrato_x_EstudianteInfo.IdPeriodo_Per = item.IdPeriodo_Per;
                            //Contrato_x_EstudianteInfo.IdRubro = item.IdRubro;
                            //Contrato_x_EstudianteInfo.Descripcion_rubro = item.Descripcion_rubro;
                            //Contrato_x_EstudianteInfo.Valor = item.Valor;
                            //Contrato_x_EstudianteInfo.nom_beca = item.nom_beca;
                            //Contrato_x_EstudianteInfo.TieneBeca = item.TieneBeca;

                            Contrato_x_EstudianteInfo.IdContrato = Convert.ToDecimal(item.IdContrato == 0 ? 0 : item.IdContrato);

                            //Contrato_x_EstudianteInfo.estado_matricula_con_contrato = item.estado_matricula_con_contrato;

                            lista.Add(Contrato_x_EstudianteInfo);
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


        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Contrato_Preparacion_x_Estudiante(int IdInstitucion, int IdSede)
        {
            try
            {


                List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();

                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Contrato_Preparacion_x_Estudiante
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            Aca_Contrato_x_Estudiante_Info Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_Info();
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;

                            Contrato_x_EstudianteInfo.IdInstitucion = item.IdInstitucion;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdAnioLectivo = item.IdAnioLectivo;

                            //Contrato_x_EstudianteInfo.IdPeriodoLectivo = item.IdPeriodoLectivo;

                            Contrato_x_EstudianteInfo.IdMatricula = item.IdMatricula;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.cod_estudiante = item.cod_estudiante;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.pe_nombre = item.pe_nombre;
                            Contrato_x_EstudianteInfo.pe_apellido = item.pe_apellido;

                            Contrato_x_EstudianteInfo.nombreCompleto = item.pe_apellido + ' ' + item.pe_nombre;

                            Contrato_x_EstudianteInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                            Contrato_x_EstudianteInfo.pe_direccion = item.pe_direccion;
                            Contrato_x_EstudianteInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                            Contrato_x_EstudianteInfo.pe_telefonoOfic = item.pe_telefonoOfic;
                            Contrato_x_EstudianteInfo.Fecha_matricula = item.FechaMatricula;
                            Contrato_x_EstudianteInfo.FechaCreacionEstudiante = Convert.ToDateTime(item.FechaCreacionEstudiante);

                            Contrato_x_EstudianteInfo.Sede = item.Sede;
                            Contrato_x_EstudianteInfo.Jornada = item.Jornada;
                            Contrato_x_EstudianteInfo.Seccion = item.Seccion;
                            Contrato_x_EstudianteInfo.Curso = item.Curso;
                            Contrato_x_EstudianteInfo.Paralelo = item.Paralelo;
                            Contrato_x_EstudianteInfo.estado_contrato_pago_garantizado = item.estado_contrato_pago_garantizado;
                            //Contrato_x_EstudianteInfo.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                            //Contrato_x_EstudianteInfo.IdPeriodo_Per = item.IdPeriodo_Per;
                            //Contrato_x_EstudianteInfo.IdRubro = item.IdRubro;
                            //Contrato_x_EstudianteInfo.Descripcion_rubro = item.Descripcion_rubro;
                            //Contrato_x_EstudianteInfo.Valor = item.Valor;
                            //Contrato_x_EstudianteInfo.nom_beca = item.nom_beca;
                            //Contrato_x_EstudianteInfo.TieneBeca = item.TieneBeca;
                            Contrato_x_EstudianteInfo.estado = item.estado;
                            Contrato_x_EstudianteInfo.IdContrato = Convert.ToDecimal(item.IdContrato == 0 ? 0 : item.IdContrato);

                            //Contrato_x_EstudianteInfo.estado_matricula_con_contrato = item.estado_matricula_con_contrato;

                            lista.Add(Contrato_x_EstudianteInfo);
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

        public List<Aca_Contrato_x_Estudiante_Info> Get_List_Estudiante_con_Contrato_x_Periodo(int IdInstitucion, int IdSede, int IdPeriodo)
        {
            try
            {


                List<Aca_Contrato_x_Estudiante_Info> lista = new List<Aca_Contrato_x_Estudiante_Info>();

                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Contrato_Preparacion_x_Estudiante
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                        //&& c.IdPeriodo_Per == IdPeriodo
                                        orderby c.cod_estudiante ascending
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            Aca_Contrato_x_Estudiante_Info Contrato_x_EstudianteInfo = new Aca_Contrato_x_Estudiante_Info();
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;

                            Contrato_x_EstudianteInfo.IdInstitucion = item.IdInstitucion;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdAnioLectivo = item.IdAnioLectivo;

                            //Contrato_x_EstudianteInfo.IdPeriodoLectivo = item.IdPeriodoLectivo;

                            Contrato_x_EstudianteInfo.IdMatricula = item.IdMatricula;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.cod_estudiante = item.cod_estudiante;
                            Contrato_x_EstudianteInfo.IdEstudiante = item.IdEstudiante;
                            Contrato_x_EstudianteInfo.IdSede = item.IdSede;
                            Contrato_x_EstudianteInfo.IdJornada = item.IdJornada;
                            Contrato_x_EstudianteInfo.IdSeccion = item.IdSeccion;
                            Contrato_x_EstudianteInfo.IdCurso = item.IdCurso;
                            Contrato_x_EstudianteInfo.IdParalelo = item.IdParalelo;
                            Contrato_x_EstudianteInfo.pe_nombre = item.pe_nombre;
                            Contrato_x_EstudianteInfo.pe_apellido = item.pe_apellido;

                            Contrato_x_EstudianteInfo.nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Contrato_x_EstudianteInfo.pe_cedulaRuc = item.pe_cedulaRuc;
                            Contrato_x_EstudianteInfo.pe_direccion = item.pe_direccion;
                            Contrato_x_EstudianteInfo.pe_telefonoCasa = item.pe_telefonoCasa;
                            Contrato_x_EstudianteInfo.pe_telefonoOfic = item.pe_telefonoOfic;
                            Contrato_x_EstudianteInfo.Fecha_matricula = item.FechaMatricula;
                            Contrato_x_EstudianteInfo.FechaCreacionEstudiante = Convert.ToDateTime(item.FechaCreacionEstudiante);

                            Contrato_x_EstudianteInfo.Sede = item.Sede;
                            Contrato_x_EstudianteInfo.Jornada = item.Jornada;
                            Contrato_x_EstudianteInfo.Seccion = item.Seccion;
                            Contrato_x_EstudianteInfo.Curso = item.Curso;
                            Contrato_x_EstudianteInfo.Paralelo = item.Paralelo;
                            Contrato_x_EstudianteInfo.estado_contrato_pago_garantizado = item.estado_contrato_pago_garantizado;
                            //Contrato_x_EstudianteInfo.IdAnioLectivo_Per = item.IdAnioLectivo_Per;
                            //Contrato_x_EstudianteInfo.IdPeriodo_Per = item.IdPeriodo_Per;
                            //Contrato_x_EstudianteInfo.IdRubro = item.IdRubro;
                            //Contrato_x_EstudianteInfo.Descripcion_rubro = item.Descripcion_rubro;
                            //Contrato_x_EstudianteInfo.Valor = item.Valor;
                            //Contrato_x_EstudianteInfo.nom_beca = item.nom_beca;
                            //Contrato_x_EstudianteInfo.TieneBeca = item.TieneBeca;

                            Contrato_x_EstudianteInfo.IdContrato = Convert.ToDecimal(item.IdContrato == 0 ? 0 : item.IdContrato);

                            //Contrato_x_EstudianteInfo.estado_matricula_con_contrato = item.estado_matricula_con_contrato;

                            lista.Add(Contrato_x_EstudianteInfo);
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

        public bool GrabarDB(Aca_Contrato_x_Estudiante_Info info, ref int IdContrato_x_Estudiante, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    Aca_Contrato_x_Estudiante Contrato_x_Estudiante = new Aca_Contrato_x_Estudiante();
                    Contrato_x_Estudiante.IdInstitucion = info.IdInstitucion;
                    IdContrato_x_Estudiante = GetId();
                    Contrato_x_Estudiante.IdContrato = IdContrato_x_Estudiante;
                    Contrato_x_Estudiante.IdMatricula = info.IdMatricula;
                    Contrato_x_Estudiante.IdSede = info.IdSede;
                    Contrato_x_Estudiante.IdAnioLectivo = info.IdAnioLectivo;
                    Contrato_x_Estudiante.IdEstudiante = info.IdEstudiante;
                    Contrato_x_Estudiante.FechaCreacion = DateTime.Now;
                    Contrato_x_Estudiante.observacion = info.observacion;
                    Contrato_x_Estudiante.estado = true;
                    Contrato_x_Estudiante.UsuarioCreacion = info.UsuarioCreacion;
                    //Contrato_x_Estudiante.UsuarioModificacion = info.UsuarioModificacion;

                    Base.Aca_Contrato_x_Estudiante.Add(Contrato_x_Estudiante);
                    Base.SaveChanges();
                    mensaje = "Se ha procedido a grabar el Contrato_x_Estudiante #: " + IdContrato_x_Estudiante.ToString() + " exitosamente.";
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

        public bool ActualizarDB(Aca_Contrato_x_Estudiante_Info info, ref string mensaje)
        {
            try
            {
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var vSeccion = Base.Aca_Contrato_x_Estudiante.FirstOrDefault(j => j.IdContrato == info.IdContrato);
                    if (vSeccion != null)
                    {
                        //vSeccion.IdSede = info.IdSede;
                        //vSeccion.CodContrato_x_Estudiante = string.IsNullOrEmpty(info.CodContrato_x_Estudiante) ? info.IdContrato_x_Estudiante.ToString() : info.CodContrato_x_Estudiante;
                        //vSeccion.CodAlternoCur = string.IsNullOrEmpty(info.CodAlternoContrato_x_Estudiante) ? "" : info.CodAlternoContrato_x_Estudiante;
                        //vSeccion.Descripcion_cur = info.DescripcionContrato_x_Estudiante;
                        //vSeccion.estado = info.Estado;
                        //vSeccion.FechaModificacion = DateTime.Now;
                        //vSeccion.UsuarioModificacion = info.UsuarioModificacion;

                        Base.SaveChanges();
                        mensaje = "Se ha procedido actualizar el Contrato_x_Estudiante #: " + info.IdContrato.ToString() + " exitosamente.";
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


        public Boolean AnularDB(Aca_Contrato_x_Estudiante_Info info, ref string msg)
        {
            try
            {
                using (Entities_Academico context = new Entities_Academico())
                {
                    var address = context.Aca_Contrato_x_Estudiante.FirstOrDefault(a => a.IdContrato == info.IdContrato);
                    if (address != null)
                    {
                        address.estado = false;
                        address.FechaAnulacion = DateTime.Now;
                        address.UsuarioAnulacion = info.UsuarioAnulacion;
                        address.MotivoAnulacion = info.MotivoAnulacion;
                        context.SaveChanges();
                        msg = "Se ha procedido anular Contrato_x_Estudiante #: " + info.IdContrato.ToString() + " exitosamente.";
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
