/*CLASE: XROL_Rpt008_Data
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
   public  class XROL_Rpt008_Data
    {

        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt008_Info> GetListPorIdPeriodo(int idEmpresa, int idPeriodoFiscal, ref string msg)
        {
            try
            {
                List<XROL_Rpt008_Info> listado = new List<XROL_Rpt008_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt008
                                 where a.IdEmpresa == idEmpresa && a.IdPeriodo==idPeriodoFiscal
                                 orderby a.NombreCompleto
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt008_Info info = new XROL_Rpt008_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.UtilidadDerechoIndividual = item.UtilidadDerechoIndividual;
                        info.UtilidadCargaFamiliar = item.UtilidadCargaFamiliar;
                        info.LimiteDistribucionUtilidad = item.LimiteDistribucionUtilidad;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.DiasTrabajados = item.DiasTrabajados;
                        info.CargasFamiliares = item.CargasFamiliares;
                        info.ValorIndividual = item.ValorIndividual;
                        info.ValorCargaFamiliar = item.ValorCargaFamiliar;
                        info.ValorExedenteIESS = item.ValorExedenteIESS;
                        info.ValorTotal = item.ValorTotal;
                        info.cargo = item.cargo;
                        info.departamento = item.departamento;
                        info.NombreCompleto = item.NombreCompleto;
                        info.CedulaRuc = item.CedulaRuc;
                        info.StatusEmpleado = item.StatusEmpleado;
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
                return new List<XROL_Rpt008_Info>();
            }

        }


    }
}
