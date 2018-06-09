
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt019_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();

        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                List<XROL_Rpt019_Info> listado = new List<XROL_Rpt019_Info>();

                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt019
                                 where a.IdEmpresa == idEmpresa
                                 select a);
                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt019_Info info = new XROL_Rpt019_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Ruc = item.pe_cedulaRuc;
                        info.IdRubro = item.IdRubro;
                        info.Tag = item.ru_codRolGen;
                        info.Empleado = item.pe_apellido + " " + item.pe_nombre;
                        info.DescRubroLargo = item.ru_descripcion;
                        info.DescNombreRubroCorto = item.ru_descripcion;
                        info.rub_visible_reporte = item.rub_visible_reporte;
                        info.Orden = item.Orden;
                        info.Valor = item.Valor;
                        info.NominaLiqui = item.DescripcionProcesoNomina;
                        info.Nomina = item.Nomina;
                        info.FechaIni = item.pe_FechaIni;
                        info.FechaFin = item.pe_FechaFin;
                        //info.Empresa=item.Empresa;
                        info.IdEmpresa = item.IdEmpresa;
                        info.EstadoPeriodo = item.pe_estado;
                        info.Departamento = item.de_descripcion;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                       // info.CentroCosto = item.Centro_costo;
                        info.Sucursal = item.Su_Descripcion;
                        info.Division = item.Division;
                        info.IdDivision = item.IdDivision;
                       // info.IdCentroCosto = item.IdCentroCosto;
                        info.CodigoEmpleado = item.em_codigo;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdArea = item.IdArea;
                        info.DescripcionArea = item.Area;

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
                return new List<XROL_Rpt019_Info>();
            }

        }



        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, DateTime fi,DateTime ff, int iddepartamento, ref string msg)
        {
            try
            {
                List<XROL_Rpt019_Info> listado = new List<XROL_Rpt019_Info>();
                int secuencia = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt019
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaLiqui
                                 && a.pe_FechaIni >=fecha_inicio
                                 && a.pe_FechaIni <= fecha_fin
                                 && a.rub_visible_reporte == true
                                 && a.IdDepartamento == iddepartamento
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt019_Info info = new XROL_Rpt019_Info();
                        secuencia = secuencia + 1;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Ruc = item.pe_cedulaRuc;
                        info.IdRubro = item.IdRubro;
                        info.Tag = item.ru_codRolGen;
                        info.Empleado = item.pe_apellido + " " + item.pe_nombre;
                        info.DescRubroLargo = item.ru_descripcion;
                        info.DescNombreRubroCorto = item.ru_descripcion;
                        info.rub_visible_reporte = item.rub_visible_reporte;
                        info.Orden = item.Orden;
                        info.Valor = item.Valor;
                        info.NominaLiqui = item.DescripcionProcesoNomina;
                        info.Nomina = item.Nomina;
                        info.FechaIni = item.pe_FechaIni;
                        info.FechaFin = item.pe_FechaFin;
                        info.IdEmpresa = item.IdEmpresa;
                        info.EstadoPeriodo = item.pe_estado;
                        info.Departamento = item.de_descripcion;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                       // info.CentroCosto = item.Centro_costo;
                        info.Sucursal = item.Su_Descripcion;
                        info.Division = item.Division;
                        info.IdDivision = item.IdDivision;
                      //  info.IdCentroCosto = item.IdCentroCosto;
                        info.CodigoEmpleado = item.em_codigo;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdArea = item.IdArea;
                        info.DescripcionArea = item.Area;
                        info.Logo = Cbt.em_logo_Image;
                        info.RazonSocial = item.RazonSocial;
                        info.NombreComercial = item.NombreComercial; listado.Add(info);

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
                return new List<XROL_Rpt019_Info>();
            }

        }

        public List<XROL_Rpt019_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, DateTime fi,DateTime ff, ref string msg)
        {
            try
            {
                List<XROL_Rpt019_Info> listado = new List<XROL_Rpt019_Info>();
                int secuencia = 0;
                int id_empleado = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt019
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaLiqui
                                 && a.pe_FechaIni >= fecha_inicio
                                 && a.pe_FechaIni <= fecha_fin 
                                 && a.rub_visible_reporte == true
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt019_Info info = new XROL_Rpt019_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.Ruc = item.pe_cedulaRuc;
                        info.IdRubro = item.IdRubro;
                        info.Tag = item.ru_codRolGen;
                        info.Empleado = item.pe_apellido + " " + item.pe_nombre;
                        info.DescRubroLargo = item.ru_descripcion;
                        info.DescNombreRubroCorto = item.ru_descripcion;
                        info.rub_visible_reporte = item.rub_visible_reporte;
                        info.Orden = item.Orden;
                        info.Valor = item.Valor;
                        info.NominaLiqui = item.DescripcionProcesoNomina;
                        info.Nomina = item.Nomina;
                        info.FechaIni = item.pe_FechaIni;
                        info.FechaFin = item.pe_FechaFin;
                        info.IdEmpresa = item.IdEmpresa;
                        info.EstadoPeriodo = item.pe_estado;
                        info.Departamento = item.de_descripcion;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                       // info.CentroCosto = item.Centro_costo;
                        info.Sucursal = item.Su_Descripcion;
                        info.Division = item.Division;
                        info.IdDivision = item.IdDivision;
                       // info.IdCentroCosto = item.IdCentroCosto;
                        info.CodigoEmpleado = item.em_codigo;
                        info.IdDepartamento = item.IdDepartamento;
                        info.IdArea = item.IdArea;
                        info.DescripcionArea = item.Area;
                        info.Logo = Cbt.em_logo_Image;
                        info.RazonSocial = item.RazonSocial;
                        info.NombreComercial = item.NombreComercial;
                        id_empleado = (int)item.IdEmpleado;
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
                return new List<XROL_Rpt019_Info>();
            }

        }

    }
}
