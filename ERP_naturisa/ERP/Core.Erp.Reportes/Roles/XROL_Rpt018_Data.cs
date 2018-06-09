using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt018_Data
    {
        string mensaje = "";
        tb_Empresa_Data empresa_data = new tb_Empresa_Data();
        tb_Empresa_Info info_empresa = new tb_Empresa_Info();
        public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int idDepartamento, int idrubro, DateTime fi, DateTime ff)
        {
            try
            {
                List<XROL_Rpt018_Info> Listado = new List<XROL_Rpt018_Info>();
                info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
                int idempleado = 0;
                int sec = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin= Convert.ToDateTime(ff.ToShortDateString());
                string idrubro_ = Convert.ToString(idrubro);
                using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
                {
                    var select = from a in enti.vwROL_Rpt018
                                 where
                                  a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNomina
                                 && a.IdDepartamento == idDepartamento
                                 && a.IdRubro == idrubro_
                                 &&a.pe_FechaIni>=fecha_inicio
                                 &&a.pe_FechaIni<=fecha_fin
                                  && a.Valor > 0
                                 orderby a.pe_apellido ascending
                                 select a;

                    foreach (var item in select)
                    {
                        XROL_Rpt018_Info info = new XROL_Rpt018_Info();
                        if (idempleado != item.IdEmpleado)
                        {
                            sec = sec + 1;
                        }
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdRubro = item.IdRubro;
                        info.IdDepartamento = item.IdDepartamento;
                        info.pe_anio = item.pe_anio;
                        info.pe_FechaIni = item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.ru_descripcion = item.ru_descripcion;
                        info.Valor = item.Valor;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.NombreComercial;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.Descripcion = item.Descripcion;
                        info.de_descripcion = item.de_descripcion;




                        info.secuencia = sec;
                        idempleado = Convert.ToInt32(item.IdEmpleado);

                        Listado.Add(info);
                    }

                    return Listado;
                }



            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt018_Info>();
            }
        }

        public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdDepartamento, int IdEmpleado, int idRubro, DateTime fi, DateTime ff)
        {
            try
            {
                List<XROL_Rpt018_Info> Listado = new List<XROL_Rpt018_Info>();
                info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
                int idempleado = 0;
                int sec = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
               string idRubro_ = Convert.ToString(idRubro);
                using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
                {
                    var select = from a in enti.vwROL_Rpt018
                                 where
                                 a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNomina
                                 && a.IdEmpleado == IdEmpleado
                                 && a.IdDepartamento == IdDepartamento
                                 && a.IdRubro == idRubro_
                                 && a.pe_FechaIni >= fecha_inicio
                                 && a.pe_FechaIni <= fecha_fin
                                  && a.Valor > 0
                                 orderby a.pe_apellido ascending
                                 select a;

                    foreach (var item in select)
                    {
                        XROL_Rpt018_Info info = new XROL_Rpt018_Info();
                        if (idempleado != item.IdEmpleado)
                        {
                            sec = sec + 1;
                        }
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdRubro = item.IdRubro;
                        info.IdDepartamento = item.IdDepartamento;
                        info.pe_anio = item.pe_anio;
                        info.pe_FechaIni = item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.ru_descripcion = item.ru_descripcion;
                        info.Valor = item.Valor;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.NombreComercial;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.Descripcion = item.Descripcion;
                        info.de_descripcion = item.de_descripcion;




                        info.secuencia = sec;
                        idempleado = Convert.ToInt32(item.IdEmpleado);
                        Listado.Add(info);
                    }

                    return Listado;
                }



            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt018_Info>();
            }
        }

        public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdDepartamento, decimal IdEmpleado, DateTime fi, DateTime ff)
        {
            try
            {
                List<XROL_Rpt018_Info> Listado = new List<XROL_Rpt018_Info>();
                info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
                int idempleado_cont = 0;
                int sec = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());

                using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
                {
                    var select = from a in enti.vwROL_Rpt018
                                 where
                                  a.IdEmpresa == idEmpresa
                                  && a.IdNominaTipo == idNomina
                                  && a.IdDepartamento == IdDepartamento
                                  && a.IdEmpleado == IdEmpleado
                                  && a.pe_FechaIni >= fecha_inicio
                                  && a.pe_FechaIni <= fecha_fin
                                  &&a.Valor>0
                                 orderby a.pe_apellido ascending
                                 select a;

                    foreach (var item in select)
                    {
                        XROL_Rpt018_Info info = new XROL_Rpt018_Info();
                        if (idempleado_cont != item.IdEmpleado)
                        {
                            sec = sec + 1;
                        }
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdRubro = item.IdRubro;
                        info.IdDepartamento = item.IdDepartamento;
                        info.pe_anio = item.pe_anio;
                        info.pe_FechaIni = item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.ru_descripcion = item.ru_descripcion;
                        info.Valor = item.Valor;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.NombreComercial;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.Descripcion = item.Descripcion;
                        info.de_descripcion = item.de_descripcion;


                        info.secuencia = sec;
                        idempleado_cont = Convert.ToInt32(item.IdEmpleado);
                        Listado.Add(info);
                    }

                    return Listado;
                }



            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt018_Info>();
            }
        }



        public List<XROL_Rpt018_Info> Get_Ingreso_Egreso_Empleado(int idEmpresa, int idNomina, int IdRubro, DateTime fi, DateTime ff)
        {
            try
            {
                List<XROL_Rpt018_Info> Listado = new List<XROL_Rpt018_Info>();
                info_empresa = empresa_data.Get_Info_Empresa(idEmpresa);
                int idempleado_cont = 0;
                int sec = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
                string idrubro_ = Convert.ToString(IdRubro);

                using (EntitiesRolesRptGeneral enti = new EntitiesRolesRptGeneral())
                {
                    var select = from a in enti.vwROL_Rpt018
                                 where
                                  a.IdEmpresa == idEmpresa
                                  && a.IdNominaTipo == idNomina
                                  && a.IdRubro == idrubro_
                                  && a.pe_FechaIni >= fecha_inicio
                                  && a.pe_FechaIni <= fecha_fin
                                  && a.Valor > 0
                                 orderby a.pe_apellido ascending
                                 select a;

                    foreach (var item in select)
                    {
                        XROL_Rpt018_Info info = new XROL_Rpt018_Info();
                        if (idempleado_cont != item.IdEmpleado)
                        {
                            sec = sec + 1;
                        }
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.IdPeriodo = item.IdPeriodo;
                        info.IdRubro = item.IdRubro;
                        info.IdDepartamento = item.IdDepartamento;
                        info.pe_anio = item.pe_anio;
                        info.pe_FechaIni = item.pe_FechaIni;
                        info.pe_FechaFin = item.pe_FechaFin;
                        info.pe_cedulaRuc = item.pe_cedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.ru_descripcion = item.ru_descripcion;
                        info.Valor = item.Valor;
                        info.em_logo = info_empresa.em_logo;
                        info.NombreComercial = info_empresa.NombreComercial;
                        info.RazonSocial = info_empresa.RazonSocial;
                        info.Descripcion = item.Descripcion;
                        info.de_descripcion = item.de_descripcion;


                        info.secuencia = sec;
                        idempleado_cont = Convert.ToInt32(item.IdEmpleado);
                        Listado.Add(info);
                    }

                    return Listado;
                }



            }
            catch (Exception ex)
            {

                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                return new List<XROL_Rpt018_Info>();
            }
        }
  
    }
}
