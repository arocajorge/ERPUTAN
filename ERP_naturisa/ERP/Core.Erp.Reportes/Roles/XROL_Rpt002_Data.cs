
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Reportes.Roles
{
   public class XROL_Rpt002_Data
    {

       string mensaje = "";
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
       {
           try {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();

               using(EntitiesRolesRptGeneral db =new EntitiesRolesRptGeneral()){
                var datos=(from a in db.vwROL_Rpt002
                               where a.IdEmpresa==idEmpresa
                               select a);
                Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach(var item in datos){
                       XROL_Rpt002_Info info=new XROL_Rpt002_Info();

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
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;

                       info.Logo = Cbt.em_logo_Image;


                       listado.Add(info);
                   }

               }
               return listado;
           }catch (Exception ex){
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               msg = mensaje;
               return new List<XROL_Rpt002_Info>();
           }     
       
       }



       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa,int idNominaTipo, int idNominaLiqui,int idPeriodo,int iddepartamento, ref string msg)
       {
           try
           {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();
               int secuencia = 0;
               int id_empleado = 0;
               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   var datos = (from a in db.vwROL_Rpt002
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo==idNominaTipo
                                && a.IdNominaTipoLiqui==idNominaLiqui
                                && a.IdPeriodo==idPeriodo
                                && a.rub_visible_reporte==true
                                && a.IdDepartamento==iddepartamento
                                orderby a.pe_apellido ascending
                                select a);

                   Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach (var item in datos)
                   {
                       XROL_Rpt002_Info info = new XROL_Rpt002_Info();
                       if (id_empleado != item.IdEmpleado)
                       {
                           secuencia = secuencia + 1;
                       } 
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado=item.IdEmpleado;
                       info.Ruc=item.pe_cedulaRuc;
                       info.IdRubro=item.IdRubro;
                       info.Tag=item.ru_codRolGen;
                       info.Empleado = item.pe_apellido+" "+item.pe_nombre;
                       info.DescRubroLargo = item.ru_descripcion;
                       info.DescNombreRubroCorto=item.ru_descripcion;
                       info.rub_visible_reporte = item.rub_visible_reporte;
                       info.Orden=item.Orden;
                       info.Valor=item.Valor;
                       info.NominaLiqui=item.DescripcionProcesoNomina;
                       info.Nomina=item.Nomina;
                       info.FechaIni=item.pe_FechaIni;
                       info.FechaFin=item.pe_FechaFin;
                       info.IdEmpresa=item.IdEmpresa;
                       info.EstadoPeriodo=item.pe_estado;
                       info.Departamento=item.de_descripcion;
                       info.IdNominaTipo=item.IdNominaTipo;
                       info.IdNominaTipoLiqui=item.IdNominaTipoLiqui;
                       info.IdPeriodo=item.IdPeriodo;
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;
                       info.Logo = Cbt.em_logo_Image;
                       info.RazonSocial = item.RazonSocial;
                       id_empleado =(int) item.IdEmpleado;
                       info.secuencia = secuencia;
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
               return new List<XROL_Rpt002_Info>();
           }

       }

       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo, ref string msg)
       {
           try
           {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();
               int secuencia = 0;
               int id_empleado = 0;
               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   var datos = (from a in db.vwROL_Rpt002
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaLiqui
                                && a.IdPeriodo == idPeriodo
                                && a.rub_visible_reporte == true
                                orderby a.pe_apellido ascending
                                select a);

                   Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach (var item in datos)
                   {
                       XROL_Rpt002_Info info = new XROL_Rpt002_Info();
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
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;
                       info.Logo = Cbt.em_logo_Image;
                       info.RazonSocial = item.RazonSocial;
                       info.NombreComercial = item.NombreComercial; 
                       id_empleado = (int)item.IdEmpleado;
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
               return new List<XROL_Rpt002_Info>();
           }

       }

       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo,int IdDivision)
       {
           try
           {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();
               int secuencia = 0;
               int id_empleado = 0;
               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   var datos = (from a in db.vwROL_Rpt002
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaLiqui
                                && a.IdPeriodo == idPeriodo
                                &&a.IdDivision==IdDivision
                                && a.rub_visible_reporte == true
                                orderby a.pe_apellido ascending
                                select a);

                   Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach (var item in datos)
                   {
                       XROL_Rpt002_Info info = new XROL_Rpt002_Info();
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
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;
                       info.Logo = Cbt.em_logo_Image;
                       info.RazonSocial = item.RazonSocial;
                       info.NombreComercial = item.NombreComercial;
                       id_empleado = (int)item.IdEmpleado;
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
               return new List<XROL_Rpt002_Info>();
           }

       }
       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo)
       {
           try
           {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();
               int secuencia = 0;
               int id_empleado = 0;
               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   var datos = (from a in db.vwROL_Rpt002
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaLiqui
                                && a.IdPeriodo == idPeriodo
                                && a.rub_visible_reporte == true
                                orderby a.pe_apellido ascending
                                select a);

                   Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach (var item in datos)
                   {
                       XROL_Rpt002_Info info = new XROL_Rpt002_Info();
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
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;
                       info.Logo = Cbt.em_logo_Image;
                       info.RazonSocial = item.RazonSocial;
                       info.NombreComercial = item.NombreComercial;
                       id_empleado = (int)item.IdEmpleado;
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
               return new List<XROL_Rpt002_Info>();
           }

       }


       public List<XROL_Rpt002_Info> GetListConsultaGeneral(int idEmpresa, int idNominaTipo, int idNominaLiqui, int idPeriodo,int IdDivision, int iddepartamento, ref string msg)
       {
           try
           {
               List<XROL_Rpt002_Info> listado = new List<XROL_Rpt002_Info>();
               int secuencia = 0;
               int id_empleado = 0;
               using (EntitiesRolesRptGeneral db = new EntitiesRolesRptGeneral())
               {
                   var datos = (from a in db.vwROL_Rpt002
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaLiqui
                                && a.IdPeriodo == idPeriodo
                                && a.rub_visible_reporte == true
                                && a.IdDepartamento == iddepartamento
                                && a.IdDivision==IdDivision
                                orderby a.pe_apellido ascending
                                select a);

                   Cbt = empresaData.Get_Info_Empresa(idEmpresa);

                   foreach (var item in datos)
                   {
                       XROL_Rpt002_Info info = new XROL_Rpt002_Info();
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
                       info.CentroCosto = item.Centro_costo;
                       info.Sucursal = item.Su_Descripcion;
                       info.Division = item.Division;
                       info.IdDivision = item.IdDivision;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.CodigoEmpleado = item.em_codigo;
                       info.IdDepartamento = item.IdDepartamento;
                       info.IdArea = item.IdArea;
                       info.DescripcionArea = item.Area;
                       info.Logo = Cbt.em_logo_Image;
                       info.RazonSocial = item.RazonSocial;
                       id_empleado = (int)item.IdEmpleado;
                       info.secuencia = secuencia;
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
               return new List<XROL_Rpt002_Info>();
           }

       }

    }
}
