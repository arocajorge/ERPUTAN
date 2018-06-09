
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt010_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt010_Info> GetListPorEmpleado(int idEmpresa, decimal IdDepartamento, DateTime fechaInicial, DateTime fechaFinal, ref string msg)
        {
            try
            {
                List<XROL_Rpt010_Info> listado = new List<XROL_Rpt010_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt010
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdDepartamento == IdDepartamento
                                 && a.es_fechaRegistro>= fechaInicial
                                 && a.es_fechaRegistro<=fechaFinal
                                 orderby a.Apellido  ascending
                                // orderby a.es_fechaRegistro descending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt010_Info info = new XROL_Rpt010_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdRegistro = item.IdRegistro;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoMarcaciones = item.IdTipoMarcaciones;
                        info.secuencia = item.secuencia;
                        info.es_Hora = item.es_Hora;
                        info.es_fechaRegistro = item.es_fechaRegistro;
                        info.es_anio = item.es_anio;
                        info.es_mes = item.es_mes;
                        info.es_semana = item.es_semana;
                        info.es_dia = item.es_dia;
                        info.es_sdia = item.es_sdia;
                        info.es_idDia = item.es_idDia;
                        info.es_EsActualizacion = item.es_EsActualizacion;
                        info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                        info.cargo = item.cargo;
                        info.departamento = item.departamento;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.NombreCompleto = item.Apellido+" "+item.Nombre;
                        info.CedulaRuc = item.CedulaRuc;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.DescripcionDivision = item.DescripcionDivision;
                        info.IdDivision = item.IdDivision;
                        info.IdSucursal = item.IdSucursal;
                        info.Sucursal = item.Sucursal;
                        info.Centro_costo = item.Centro_costo;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.Logo = Cbt.em_logo_Image;
                        listado.Add(info);
                    }

                }
                return listado;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                msg = mensaje;
                return new List<XROL_Rpt010_Info>();
            }

        }

    }
}
