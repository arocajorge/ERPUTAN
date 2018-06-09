/*CLASE: XROL_Rpt009_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt009_Data
    {

        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt009_Info> GetListPorIdPeriodo(int idEmpresa,int idNominaTipo, int idPeriodoFiscal, ref string msg)
        {
            try
            {
                List<XROL_Rpt009_Info> listado = new List<XROL_Rpt009_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt009
                                 where a.IdEmpresa == idEmpresa && a.IdNominaTipo==idNominaTipo
                                 && a.IdPeriodo == idPeriodoFiscal
                                 orderby a.NombreCompleto
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt009_Info info = new XROL_Rpt009_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdPeriodo = item.IdPeriodo;
                        info.SueldoDigno = item.SueldoDigno;
                        info.Observacion = item.Observacion;
                        info.UtilidadRepartir = item.UtilidadRepartir;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Valor = item.Valor;
                        info.Cargo = item.cargo;
                        info.Departamento = item.departamento;
                        info.NombreCompleto = item.NombreCompleto;
                        info.CedulaRuc = item.CedulaRuc;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdDivision = item.IdDivision;
                        info.EstadoEmpleado = item.EstadoEmpleado;
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
                return new List<XROL_Rpt009_Info>();
            }

        }
    }
}
