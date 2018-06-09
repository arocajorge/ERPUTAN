/*CLASE: XROL_Rpt004_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 13-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt004_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,string idrubro,int idempleado,int iddepartamento, ref string msg)
        {
            try
            {
                List<XROL_Rpt004_Info> listado = new List<XROL_Rpt004_Info>();
                int secuencia = 0;
                decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 && (( a.FechaPago>=fechaInicial) 
                                 && (a.FechaPago<=fechaFinal))
                                 && a.IdEmpleado==idempleado
                                 && a.IdRubro==idrubro
                                 && a.IdDepartamento==iddepartamento
                                 orderby a.pe_apellido ascending
                                 select a);
                    
                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt004_Info info = new XROL_Rpt004_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }
                        id_empleado = item.IdEmpleado; 



                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.pe_apellido+" "+item.pe_nombre;
                        info.IdRubro = item.IdRubro;
                        info.FechaPago = item.FechaPago;
                        info.Valor = item.Valor;
                        info.EstadoCobro = item.EstadoCobro;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.Division = item.Division;
                        info.CentroCosto = item.CentroCosto;
                        info.Departamento = item.Departamento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        if (item.Num_Horas > 0)
                        {
                            info.Num_Horas = Math.Round(Convert.ToDouble(item.Num_Horas), 2);
                        }
                        else
                        {
                            info.Num_Horas = 0;


                        }
                        info.secuencia = secuencia;
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
                return new List<XROL_Rpt004_Info>();
            }

        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, string idrubro, int iddepartamento, ref string msg)
        {
            try
            {
                List<XROL_Rpt004_Info> listado = new List<XROL_Rpt004_Info>();
                int secuencia = 0;
                decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 && ((a.FechaPago >= fechaInicial)
                                 && (a.FechaPago <= fechaFinal))
                                 && a.IdRubro == idrubro
                                 && a.IdDepartamento == iddepartamento
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt004_Info info = new XROL_Rpt004_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }
                        id_empleado = item.IdEmpleado;

                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.IdRubro = item.IdRubro;
                        info.FechaPago = item.FechaPago;
                        info.Valor = item.Valor;
                        info.EstadoCobro = item.EstadoCobro;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.Division = item.Division;
                        info.CentroCosto = item.CentroCosto;
                        info.Departamento = item.Departamento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        if (item.Num_Horas > 0)
                        {
                            info.Num_Horas = Math.Round(Convert.ToDouble(item.Num_Horas), 2);
                        }
                        else
                        {
                            info.Num_Horas = 0;


                        }
                        info.secuencia = secuencia;
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
                return new List<XROL_Rpt004_Info>();
            }

        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int iddepartamento, ref string msg)
        {
            try
            {
                List<XROL_Rpt004_Info> listado = new List<XROL_Rpt004_Info>();
                int secuencia = 0; decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 && ((a.FechaPago >= fechaInicial)
                                 && (a.FechaPago <= fechaFinal))
                                 && a.IdDepartamento == iddepartamento
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt004_Info info = new XROL_Rpt004_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }
                        id_empleado = item.IdEmpleado;




                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.IdRubro = item.IdRubro;
                        info.FechaPago = item.FechaPago;
                        info.Valor = item.Valor;
                        info.EstadoCobro = item.EstadoCobro;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.Division = item.Division;
                        info.CentroCosto = item.CentroCosto;
                        info.Departamento = item.Departamento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        if (item.Num_Horas > 0)
                        {
                            info.Num_Horas = Math.Round(Convert.ToDouble(item.Num_Horas), 2);
                        }
                        else
                        {
                            info.Num_Horas = 0;


                        }
                        info.secuencia = secuencia;
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
                return new List<XROL_Rpt004_Info>();
            }

        }
        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, ref string msg)
        {
            try
            {
                List<XROL_Rpt004_Info> listado = new List<XROL_Rpt004_Info>();
                int secuencia = 0;decimal id_empleado=0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 && ((a.FechaPago >= fechaInicial)
                                 && (a.FechaPago <= fechaFinal))
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt004_Info info = new XROL_Rpt004_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }
                        id_empleado = item.IdEmpleado;


                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.IdRubro = item.IdRubro;
                        info.FechaPago = item.FechaPago;
                        info.Valor = item.Valor;
                        info.EstadoCobro = item.EstadoCobro;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.Division = item.Division;
                        info.CentroCosto = item.CentroCosto;
                        info.Departamento = item.Departamento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        if (item.Num_Horas > 0)
                        {
                            info.Num_Horas = Math.Round(Convert.ToDouble(item.Num_Horas), 2);
                        }
                        else
                        {
                            info.Num_Horas = 0;


                        }
                        info.secuencia = secuencia;
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
                return new List<XROL_Rpt004_Info>();
            }

        }

        public List<XROL_Rpt004_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,string idrubro, ref string msg)
        {
            try
            {
                List<XROL_Rpt004_Info> listado = new List<XROL_Rpt004_Info>();
                int secuencia = 0; decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt004
                                 where a.IdEmpresa == idEmpresa
                                 && ((a.FechaPago >= fechaInicial)
                                 && (a.FechaPago <= fechaFinal))
                                 && a.IdRubro==idrubro
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt004_Info info = new XROL_Rpt004_Info();
                        if (id_empleado != item.IdEmpleado)
                        {
                            secuencia = secuencia + 1;
                        }

                        id_empleado = item.IdEmpleado;


                        info.IdEmpleado = item.IdEmpleado;
                        info.CedulaRuc = item.CedulaRuc;
                        info.NombreCompleto = item.pe_apellido + " " + item.pe_nombre;
                        info.IdRubro = item.IdRubro;
                        info.FechaPago = item.FechaPago;
                        info.Valor = item.Valor;
                        info.EstadoCobro = item.EstadoCobro;
                        info.RubroDescripcion = item.RubroDescripcion;
                        info.Division = item.Division;
                        info.CentroCosto = item.CentroCosto;
                        info.Departamento = item.Departamento;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        if (item.Num_Horas > 0)
                        {
                            info.Num_Horas = Math.Round(Convert.ToDouble(item.Num_Horas), 2);
                        }
                        else
                        {
                            info.Num_Horas = 0;


                        }
                        info.secuencia = secuencia;
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
                return new List<XROL_Rpt004_Info>();
            }

        }

    }
}
