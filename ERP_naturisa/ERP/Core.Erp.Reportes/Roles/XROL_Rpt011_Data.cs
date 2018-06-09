
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt011_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt011_Info> GetListPorArchivo(int idEmpresa, int idnomina,int idnominatipo,int idperiodo)




        {
            try
            {
                List<XROL_Rpt011_Info> listado = new List<XROL_Rpt011_Info>();
                int secuencia = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt011
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNomina==idnomina
                                 && a.IdNominaTipo==idnominatipo
                                 && a.IdPeriodo==idperiodo
                                 orderby a.Apellido descending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt011_Info info = new XROL_Rpt011_Info();
                        secuencia = secuencia + 1;
                        info.secuencia = secuencia;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdArchivo = item.IdArchivo;
                        info.Valor = item.Valor;
                        info.NombreCompleto = item.Apellido+" "+item.Nombre;
                        info.Cedula = item.Cedula;
                        info.NoCuenta = item.NoCuenta;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.pagacheque =Convert.ToBoolean( item.pagacheque);
                        if (item.pagacheque == true)
                        {
                            info.TipoCuenta = "CHEQ";
                        }
                        else
                        {
                            info.TipoCuenta = item.TipoCuenta;
                        }
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.IdBancoEmpleado = item.IdBancoEmpleado;
                        info.IdDivisionEmpleado = item.IdDivisionEmpleado;
                        info.IdArea = item.IdArea;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdNomina = item.IdNomina;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdPeriodo = item.IdPeriodo;
                        info.DescripcionNominaTipo = item.DescripcionNominaTipo;
                        info.DescripcionNominaTipoLiqui = item.DescripcionNominaTipoLiqui;
                        info.IdBancoArchivo = item.IdBancoArchivo;
                        info.IdDivisionArchivo = item.IdDivisionArchivo;
                        info.DescripcionBancoEmpleado = item.DescripcionBancoEmpleado;
                        info.FechaInicial = item.FechaInicial;
                        info.FechaFinal = item.FechaFinal;
                        info.pagacheque =Convert.ToBoolean( item.pagacheque);
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
              
                return new List<XROL_Rpt011_Info>();
            }

        }

         public List<XROL_Rpt011_Info> GetListPorArchivo(int idEmpresa, int idnomina,int idnominatipo,int idperiodo, int iddivision)
        {
            try
            {
                List<XROL_Rpt011_Info> listado = new List<XROL_Rpt011_Info>();
                int secuencia = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt011
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNomina==idnomina
                                 && a.IdNominaTipo==idnominatipo
                                 && a.IdPeriodo==idperiodo
                                 && a.IdDivisionEmpleado==iddivision
                                 orderby a.Apellido descending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt011_Info info = new XROL_Rpt011_Info();
                        secuencia = secuencia + 1;
                        info.secuencia = secuencia;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdArchivo = item.IdArchivo;
                        info.Valor = item.Valor;
                        info.NombreCompleto = item.Apellido+" "+item.Nombre;
                        info.Cedula = item.Cedula;
                        info.NoCuenta = item.NoCuenta;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.pagacheque =Convert.ToBoolean( item.pagacheque);
                        if (item.pagacheque == true)
                        {
                            info.TipoCuenta = "CHEQ";
                        }
                        else
                        {
                            info.TipoCuenta = item.TipoCuenta;
                        }
                        info.em_SeAcreditaBanco = item.em_SeAcreditaBanco;
                        info.EstadoEmpleado = item.EstadoEmpleado;
                        info.IdBancoEmpleado = item.IdBancoEmpleado;
                        info.IdDivisionEmpleado = item.IdDivisionEmpleado;
                        info.IdArea = item.IdArea;
                        info.StatusEmpleado = item.StatusEmpleado;
                        info.IdNomina = item.IdNomina;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdPeriodo = item.IdPeriodo;
                        info.DescripcionNominaTipo = item.DescripcionNominaTipo;
                        info.DescripcionNominaTipoLiqui = item.DescripcionNominaTipoLiqui;
                        info.IdBancoArchivo = item.IdBancoArchivo;
                        info.IdDivisionArchivo = item.IdDivisionArchivo;
                        info.DescripcionBancoEmpleado = item.DescripcionBancoEmpleado;
                        info.FechaInicial = item.FechaInicial;
                        info.FechaFinal = item.FechaFinal;
                        info.pagacheque =Convert.ToBoolean( item.pagacheque);
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
              
                return new List<XROL_Rpt011_Info>();
            }

        }

    }

    }

