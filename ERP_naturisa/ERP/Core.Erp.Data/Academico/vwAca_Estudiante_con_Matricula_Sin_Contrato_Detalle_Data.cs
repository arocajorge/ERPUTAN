using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Academico;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Data.Academico;
using System.ComponentModel;

namespace Core.Erp.Data.Academico
{
    public class vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Data
    {
        public List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle_x_Estudiante(int IdInstitucion, int IdAnioLectivo, decimal IdEstudiante)
        {
            try
            {


                List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> lista = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
                                  where c.IdInstitucion == IdInstitucion && c.IdAnioLectivo_Rubro_x_Periodo == IdAnioLectivo && c.IdEstudiante == IdEstudiante
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info Matricula_x_Estudiante_Info = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();

                            Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                            Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                            Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                            Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                            Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                            Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                            //Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                            Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;

                            //Matricula_x_Estudiante_Info.IdContrato = Convert.ToDecimal(item.IdContrato);

                            Matricula_x_Estudiante_Info.IdRubro = (int)item.IdRubro;
                            Matricula_x_Estudiante_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            Matricula_x_Estudiante_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            Matricula_x_Estudiante_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;


                            Matricula_x_Estudiante_Info.Sede = item.Sede;
                            Matricula_x_Estudiante_Info.Jornada = item.Jornada;
                            Matricula_x_Estudiante_Info.Seccion = item.Seccion;
                            Matricula_x_Estudiante_Info.Curso = item.Curso;
                            Matricula_x_Estudiante_Info.Paralelo = item.Paralelo;
                            Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                            Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;
                            //Matricula_x_Estudiante_Info.pe_nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                            Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                            Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                            Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
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




        public List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(int IdInstitucion)
        {
            try
            {


                List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> lista = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
                                  where c.IdInstitucion == IdInstitucion
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info Matricula_x_Estudiante_Info = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();

                            Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                            Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                            Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                            Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                            Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                            Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                            //Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                            Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;

                            Matricula_x_Estudiante_Info.IdRubro = (int)item.IdRubro;
                            Matricula_x_Estudiante_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            Matricula_x_Estudiante_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            Matricula_x_Estudiante_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;


                            Matricula_x_Estudiante_Info.Sede = item.Sede;
                            Matricula_x_Estudiante_Info.Jornada = item.Jornada;
                            Matricula_x_Estudiante_Info.Seccion = item.Seccion;
                            Matricula_x_Estudiante_Info.Curso = item.Curso;
                            Matricula_x_Estudiante_Info.Paralelo = item.Paralelo;
                            Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                            Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;
                            //Matricula_x_Estudiante_Info.pe_nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                            Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                            Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                            Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
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


        public List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(int IdInstitucion, int IdSede)
        {
            try
            {


                List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> lista = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info Matricula_x_Estudiante_Info = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();

                            Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                            Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                            Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                            Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                            Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                            Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                            //Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                            Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;

                            //Matricula_x_Estudiante_Info.IdContrato = Convert.ToDecimal(item.IdContrato);

                            Matricula_x_Estudiante_Info.IdRubro = (int)item.IdRubro;
                            Matricula_x_Estudiante_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            Matricula_x_Estudiante_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            Matricula_x_Estudiante_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;


                            Matricula_x_Estudiante_Info.Sede = item.Sede;
                            Matricula_x_Estudiante_Info.Jornada = item.Jornada;
                            Matricula_x_Estudiante_Info.Seccion = item.Seccion;
                            Matricula_x_Estudiante_Info.Curso = item.Curso;
                            Matricula_x_Estudiante_Info.Paralelo = item.Paralelo;
                            Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                            Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;
                            //Matricula_x_Estudiante_Info.pe_nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                            Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                            Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                            Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
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

        public List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(int IdInstitucion, int IdSede, int IdJornada)
        {
            try
            {


                List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> lista = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                        && c.IdJornada == IdJornada
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info Matricula_x_Estudiante_Info = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();

                            Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                            Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                            Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                            Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                            Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                            Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                            //Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                            Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;

                            Matricula_x_Estudiante_Info.IdRubro = (int)item.IdRubro;
                            Matricula_x_Estudiante_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            Matricula_x_Estudiante_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            Matricula_x_Estudiante_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;


                            Matricula_x_Estudiante_Info.Sede = item.Sede;
                            Matricula_x_Estudiante_Info.Jornada = item.Jornada;
                            Matricula_x_Estudiante_Info.Seccion = item.Seccion;
                            Matricula_x_Estudiante_Info.Curso = item.Curso;
                            Matricula_x_Estudiante_Info.Paralelo = item.Paralelo;
                            Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                            Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;
                            //Matricula_x_Estudiante_Info.pe_nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                            Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                            Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                            Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
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

        public List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> Get_List_Estudiante_con_Matricula_Sin_Contrato_Detalle(int IdInstitucion, int IdSede, int IdJornada, int IdSeccion)
        {
            try
            {


                List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info> lista = new List<vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info>();
                using (Entities_Academico Base = new Entities_Academico())
                {
                    var context = from c in Base.vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle
                                  where c.IdInstitucion == IdInstitucion
                                        && c.IdSede == IdSede
                                        && c.IdJornada == IdJornada
                                        && c.IdSeccion == IdSeccion
                                  select c;
                    if (context != null)
                    {
                        foreach (var item in context)
                        {
                            vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info Matricula_x_Estudiante_Info = new vwAca_Estudiante_con_Matricula_Sin_Contrato_Detalle_Info();

                            Matricula_x_Estudiante_Info.IdInstitucion = item.IdInstitucion;
                            Matricula_x_Estudiante_Info.IdSede = item.IdSede;
                            Matricula_x_Estudiante_Info.IdParalelo = item.IdParalelo;
                            Matricula_x_Estudiante_Info.IdCurso = item.IdCurso;
                            Matricula_x_Estudiante_Info.IdSeccion = item.IdSeccion;
                            Matricula_x_Estudiante_Info.IdJornada = item.IdJornada;
                            //Matricula_x_Estudiante_Info.IdAnioLectivo = item.IdAnioLectivo;
                            Matricula_x_Estudiante_Info.IdMatricula = item.IdMatricula;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;
                            Matricula_x_Estudiante_Info.cod_estudiante = item.cod_estudiante;
                            Matricula_x_Estudiante_Info.IdEstudiante = item.IdEstudiante;

                            Matricula_x_Estudiante_Info.IdRubro = (int)item.IdRubro;
                            Matricula_x_Estudiante_Info.IdInstitucion_per = (int)item.IdInstitucion_per;
                            Matricula_x_Estudiante_Info.IdAnioLectivo_Rubro_x_Periodo = (int)item.IdAnioLectivo_Rubro_x_Periodo;
                            Matricula_x_Estudiante_Info.IdPeriodo_Per = (int)item.IdPeriodo_Per;


                            Matricula_x_Estudiante_Info.Sede = item.Sede;
                            Matricula_x_Estudiante_Info.Jornada = item.Jornada;
                            Matricula_x_Estudiante_Info.Seccion = item.Seccion;
                            Matricula_x_Estudiante_Info.Curso = item.Curso;
                            Matricula_x_Estudiante_Info.Paralelo = item.Paralelo;
                            Matricula_x_Estudiante_Info.pe_nombre = item.pe_nombre;
                            Matricula_x_Estudiante_Info.pe_apellido = item.pe_apellido;
                            //Matricula_x_Estudiante_Info.pe_nombreCompleto = item.pe_nombre + ' ' + item.pe_apellido;

                            Matricula_x_Estudiante_Info.pe_cedulaRuc = item.pe_cedulaRuc;
                            Matricula_x_Estudiante_Info.pe_direccion = item.pe_direccion;
                            Matricula_x_Estudiante_Info.pe_telefonoCasa = item.pe_telefonoCasa;
                            Matricula_x_Estudiante_Info.pe_telefonoOfic = item.pe_telefonoOfic;
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



    }
}
