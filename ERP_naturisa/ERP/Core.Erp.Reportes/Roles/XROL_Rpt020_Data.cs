
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Roles
{
  public  class XROL_Rpt020_Data
  {
      string mensaje = "";
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();
      public List<XROL_Rpt020_Info> GetListConsultaGeneral(int idEmpresa, int IdDepartamento, int idnomina_tipo, DateTime fi, DateTime ff)
      {
            try
            {
                List<XROL_Rpt020_Info> listado = new List<XROL_Rpt020_Info>();
                int secuencia = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.spROL_Rpt020(idEmpresa, idnomina_tipo, 7, 8, 9, fi,ff)
                                 where 
                                 
                                 a.IdDepartamento == IdDepartamento

                                 orderby a.Nombre ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt020_Info info = new XROL_Rpt020_Info();
                        secuencia = secuencia + 1;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina = item.IdNomina;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Cedula = item.Cedula;
                        info.Nombre = item.Nombre ;
                        info.Num_horas25 = item.Num_horas25;
                        info.Valor_hora_25 = item.Valor_hora_25;
                        info.Num_horas50 = item.Num_horas50;
                        info.Valor_hora_50 = item.Valor_hora_50;
                        info.Num_horas100 = item.Num_horas100;
                        info.Valor_hora_100 = item.Valor_hora_100;
                        info.Departamento = item.Departamento;

                        info.Logo = Cbt.em_logo_Image;
                        info.RazonSocial = Cbt.RazonSocial;
                        info.NombreComercial = Cbt.NombreComercial;
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
                return new List<XROL_Rpt020_Info>();
            }

        }

        public List<XROL_Rpt020_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, DateTime fi, DateTime ff)
        {
            try
            {
                List<XROL_Rpt020_Info> listado = new List<XROL_Rpt020_Info>();
                int secuencia = 0;
                DateTime fecha_inicio = Convert.ToDateTime(fi.ToShortDateString());
                DateTime fecha_fin = Convert.ToDateTime(ff.ToShortDateString());
                using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
                {
                    var datos = (from a in db.spROL_Rpt020(idEmpresa, idNominaTipo, 7, 8, 9, fi, ff)
                                 
                                 orderby a.Nombre ascending
                                 select a);

                    Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                    foreach (var item in datos)
                    {
                        XROL_Rpt020_Info info = new XROL_Rpt020_Info();
                        secuencia = secuencia + 1;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdNomina = item.IdNomina;
                        info.IdDepartamento = item.IdDepartamento;
                        info.Cedula = item.Cedula;
                        info.Nombre = item.Nombre;
                        info.Num_horas25 = item.Num_horas25;
                        info.Valor_hora_25 = item.Valor_hora_25;
                        info.Num_horas50 = item.Num_horas50;
                        info.Valor_hora_50 = item.Valor_hora_50;
                        info.Num_horas100 = item.Num_horas100;
                        info.Valor_hora_100 = item.Valor_hora_100;
                        info.Departamento = item.Departamento;
                        info.Nomina = item.Nomina;
                        info.Logo = Cbt.em_logo_Image;
                        info.RazonSocial = Cbt.RazonSocial;
                        info.NombreComercial = Cbt.NombreComercial;
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
                return new List<XROL_Rpt020_Info>();
            }
        }

    }
}
