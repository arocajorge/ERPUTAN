
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt006_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt006_Info> GetListPorNominaPeriodo(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui,int idPeriodo, ref string msg)
        {
            try
            {
                List<XROL_Rpt006_Info> listado = new List<XROL_Rpt006_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt006
                                 where a.IdEmpresa == idEmpresa && a.IdNominaTipo == idNominaTipo 
                                 && a.IdNominaTipoLiqui==idNominaTipoLiqui && a.IdPeriodo==idPeriodo
                                 orderby a.NombreCompleto ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt006_Info info = new XROL_Rpt006_Info();

                        //info.NombreCompleto = item.CedulaRuc.Trim() + " - " + item.NombreCompleto.Trim();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.FechaRegistro = item.FechaRegistro;
                        info.hora_extra25 = item.hora_extra25;
                        info.hora_extra50 = item.hora_extra50;
                        info.hora_extra100 = item.hora_extra100;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;
                        info.cargo = item.cargo;
                        info.departamento = item.departamento;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.NombreCompleto = item.Apellido + " " + item.Nombre;
                        info.CedulaRuc = item.CedulaRuc;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdCalendario = item.IdCalendario;
                        info.hora_atraso = item.hora_atraso;
                        info.hora_temprano = item.hora_temprano;
                        info.time_entrada1 = item.time_entrada1;
                        info.time_entrada2 = item.time_entrada2;
                        info.time_salida1 = item.time_salida1;
                        info.time_salida2 = item.time_salida2;
                        info.hora_trabajada = item.hora_trabajada;
                        info.IdTurno =Convert.ToInt32( item.IdTurno);
                        info.IdHorario = item.IdHorario;
                        info.DescripcionHorario = item.DescripcionHorario;
                        info.IdDivision = item.IdDivision;
                        info.DescripcionDivision = item.DescripcionDivision;
                        info.DescripcionCentroCosto = item.DescripcionCentroCosto;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.DescripcionNominaTipo = item.DescripcionNominaTipo;
                        info.DescripcionNominaTipoLiqui = item.DescripcionNominaTipoLiqui;
                        info.FechaInicial = item.FechaInicial;
                        info.FechaFinal = item.FechaFinal;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.iddepartamento = item.IdDepartamento;
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
                return new List<XROL_Rpt006_Info>();
            }

        }






    }
}
