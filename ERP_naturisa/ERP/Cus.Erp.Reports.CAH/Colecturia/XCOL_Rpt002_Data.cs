using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Colecturia
{
    public class XCOL_Rpt002_Data
    {

        public List<XCOL_Rpt002_Info> consultar_data(int idSede)
        {
            try
            {
                List<XCOL_Rpt002_Info> listadatos = new List<XCOL_Rpt002_Info>();

                using (EntitiesColecturia_CAH_Rpt ECompras = new EntitiesColecturia_CAH_Rpt())
                {
                    var select = from q in ECompras.vwCOL_Rpt002
                                 where q.IdSede == idSede
                                 //&& q.IdSucursal == idsucursal
                                 select q;

                    foreach (var item in select)
                    {
                        XCOL_Rpt002_Info itemInfo = new XCOL_Rpt002_Info();


                        itemInfo.IdInstitucion= item.IdInstitucion;
                        itemInfo.IdSede = item.IdSede;
                        itemInfo.IdParalelo = item.IdParalelo;
                        itemInfo.IdCurso = item.IdCurso;
                        itemInfo.IdSeccion = item.IdSeccion;
                        itemInfo.IdJornada = item.IdJornada;
                        itemInfo.IdAnioLectivo = item.IdAnioLectivo;
                        itemInfo.IdMatricula = item.IdMatricula;
                        itemInfo.IdEstudiante = item.IdEstudiante;
                        itemInfo.Institucion = item.Institucion;
                        itemInfo.Sede = item.Sede;
                        itemInfo.Jornada = item.Jornada;
                        itemInfo.Seccion = item.Seccion;
                        itemInfo.Curso = item.Curso;
                        itemInfo.Paralelo = item.Paralelo;
                        itemInfo.nombre_estudiante = item.nombre_estudiante;
                        itemInfo.apellido_estudiante = item.apellido_estudiante;
                        itemInfo.cedula_estudiante = item.cedula_estudiante;
                        itemInfo.direccion_estudiante = item.direccion_estudiante;
                        itemInfo.telefono_casa_estudiante = item.telefono_casa_estudiante;
                        itemInfo.telefono_oficina_estudiante = item.telefono_oficina_estudiante;
                        itemInfo.cod_estudiante = item.cod_estudiante;
                        itemInfo.FechaMatricula = item.FechaMatricula;
                        itemInfo.Fecha_Ingreso_estudiante = item.Fecha_Ingreso_estudiante;
                        itemInfo.sexo_estudiante = item.sexo_estudiante;
                        itemInfo.fecha_nacimiento_estudiante = item.fecha_nacimiento_estudiante;
                        itemInfo.correo_estudiante = item.correo_estudiante;
                        itemInfo.CodCurso = item.CodCurso;
                        itemInfo.estado_matricula = item.estado_matricula;
                        itemInfo.nacionalidad_estudiante = item.nacionalidad_estudiante;
                        itemInfo.lugar_estudiante = item.lugar_estudiante;
                        itemInfo.sector = item.sector;
                        itemInfo.Si_estoy_deacuerdo_foto = item.Si_estoy_deacuerdo_foto;
                        itemInfo.No_estoy_deacuerdo_foto = item.No_estoy_deacuerdo_foto;
                        itemInfo.Cod_convivencia_doy_fe = item.Cod_convivencia_doy_fe;
                        itemInfo.nombre_familiar = item.nombre_familiar;
                        itemInfo.apellido_familiar = item.apellido_familiar;
                        itemInfo.cedula_familiar = item.cedula_familiar;
                        itemInfo.direccion_familiar = item.direccion_familiar;
                        itemInfo.telefonoCasa_familiar = item.telefonoCasa_familiar;
                        itemInfo.telefonoOficina_familiar = item.telefonoOficina_familiar;
                        itemInfo.celular_familiar = item.celular_familiar;
                        itemInfo.correo_familiar = item.correo_familiar;
                        itemInfo.profesion_familiar = item.profesion_familiar;
                        itemInfo.ocupacion_laboral_familiar = item.ocupacion_laboral_familiar;
                        itemInfo.empresa_familiar = item.empresa_familiar;
                        itemInfo.direccion_empresa_familiar = item.direccion_empresa_familiar;
                        itemInfo.nacionalidad_familiar = item.nacionalidad_familiar;
                        itemInfo.IdParentesco_cat = item.IdParentesco_cat;
                        itemInfo.activo = item.activo;

                        listadatos.Add(itemInfo);
                    }
                }
                return listadatos;
            }
            catch (Exception ex)
            {
                return new List<XCOL_Rpt002_Info>();
            }
        }

    }
}
