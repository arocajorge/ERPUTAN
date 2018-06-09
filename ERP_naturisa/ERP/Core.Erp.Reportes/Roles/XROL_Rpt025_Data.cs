
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt025_Data
    {
        string mensaje = "";
        tb_Empresa_Info Cbt = new tb_Empresa_Info();
        tb_Empresa_Data empresaData = new tb_Empresa_Data();


        public List<XROL_Rpt025_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal,int idempleado,int iddepartamento,string IdRubro, ref string msg)
        {
            try
            {
                List<XROL_Rpt025_Info> listado = new List<XROL_Rpt025_Info>();
                int secuencia = 0;
                decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt025
                                 where a.IdEmpresa == idEmpresa
                                 && (( a.FechaPago>=fechaInicial) 
                                 && (a.FechaPago<=fechaFinal))
                                 && a.IdEmpleado==idempleado
                                 && a.IdDepartamento==iddepartamento
                                 && a.IdRubro==IdRubro
                                 orderby a.pe_apellido ascending
                                 select a);
                    
                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt025_Info info = new XROL_Rpt025_Info();
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
                        info.Departamento = item.Departamento;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        info.em_nombre = Cbt.em_nombre;
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
                return new List<XROL_Rpt025_Info>();
            }

        }

        public List<XROL_Rpt025_Info> GetListConsultaPorFecha(int idEmpresa, DateTime fechaInicial, DateTime fechaFinal, int iddepartamento, string IdRubro, ref string msg)
        {
            try
            {
                List<XROL_Rpt025_Info> listado = new List<XROL_Rpt025_Info>();
                int secuencia = 0;
                decimal id_empleado = 0;
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.vwROL_Rpt025
                                 where a.IdEmpresa == idEmpresa
                                 && ((a.FechaPago >= fechaInicial)
                                 && (a.FechaPago <= fechaFinal))
                                 && a.IdDepartamento == iddepartamento
                                 && a.IdRubro==IdRubro
                                 orderby a.pe_apellido ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt025_Info info = new XROL_Rpt025_Info();
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
                        info.Departamento = item.Departamento;
                        info.IdDivision = item.IdDivision;
                        info.CodigoEmpleado = item.CodigoEmpleado;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Logo = Cbt.em_logo_Image;
                        info.em_nombre = Cbt.em_nombre;

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
                return new List<XROL_Rpt025_Info>();
            }

        }

       
    }
}
