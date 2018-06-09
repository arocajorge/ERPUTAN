
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Roles;



namespace Core.Erp.Data.Roles
{
    public class ro_Rol_Detalle_Data
    {
        private string mensaje = "";

        public List<ro_Rol_Detalle_Info> GetListConsultaGeneral(int idEmpresa,int idNominaTipo,int idNominaTipoLiqui,int idPeriodo, ref string msg)
        { 
        
                    try {
                        List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos =(from a in db.ro_rol_detalle
                                where a.IdEmpresa == idEmpresa && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaTipoLiqui && a.IdPeriodo == idPeriodo
                                select a);

                    foreach(var info in datos ){
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                                                item.pe_apellido=item.pe_apellido;


                        oListado.Add(item);
                    }
                }
                return oListado;
                    }
                    catch (Exception ex)
                    {
                        string array = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }       
        }


        public List<ro_Rol_Detalle_Info> GetListConsultaPorRubro(int idEmpresa,decimal idEmpleado, string idRubro , ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rol_Detalle
                                 where a.IdEmpresa == idEmpresa && a.IdEmpleado==idEmpleado
                                 //&& a.IdNominaTipo==idNominaTipo
                                 && a.IdRubro==idRubro
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.TipoMovimiento = info.TipoMovimiento;
                                  item.pe_apellido=item.pe_apellido;

                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Rol_Detalle_Info> GetListConsultaPorNominaRubro(int idEmpresa, decimal idEmpleado, int idNominaTipo, string idRubro, ref string msg)
        {
            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rol_Detalle
                                 where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdRubro == idRubro
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.TipoMovimiento = info.TipoMovimiento;
                                                item.pe_apellido=item.pe_apellido;

                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }





        public List<ro_Rol_Detalle_Info> GetListConsultaPorRolEmpleado(int idEmpresa,decimal idEmpleado ,int idNominaTipo, int idNominaTipoLiqui, int idPeriodo,ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rol_Detalle
                                 where a.IdEmpresa == idEmpresa && a.IdEmpleado==idEmpleado
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaTipoLiqui && a.IdPeriodo == idPeriodo
                                 orderby a.Orden ascending
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                                                item.pe_apellido=item.pe_apellido;

                        //VISTA
                        item.CedulaRuc = info.Ruc;
                        item.NombreCompleto = info.Empleado;
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.rub_grupo = info.rub_grupo;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public List<ro_Rol_Detalle_Info> GetListConsultaPorRol(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rol_Detalle
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaTipoLiqui
                                 && a.IdPeriodo == idPeriodo
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                                                item.pe_apellido=item.pe_apellido;

                        item.CedulaRuc = info.Ruc;
                        item.NombreCompleto = info.pe_apellido+" "+info.pe_nombre;
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;

                        item.IdSucursal = info.IdSucursal;
                        item.IdDepartamento = info.IdDepartamento;
                        item.IdDivision = info.IdDivision;
                        item.IdArea = info.IdArea;
                        item.StatusEmpleado = info.StatusEmpleado;
                        item.EstadoEmpleado = info.EstadoEmpleado;
                        

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo,int IdDivisioan, string idRubro, List<string> Bancos, List<string> Cuentas, ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.spROL_Valor_Pendiente_pago(idEmpresa,idNominaTipo,idNominaTipoLiqui,idPeriodo)
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdDivision == IdDivisioan

                                 && a.PendientePago>0
                                 && Cuentas.Contains(a.TipoCuenta)
                                 &&Bancos.Contains(a.ba_descripcion)
                                 orderby a.pe_apellido ascending
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                        item.pe_apellido=item.pe_apellido;
                        item.CedulaRuc = info.CedulaRuc;
                        item.NombreCompleto = info.pe_apellido+" "+info.pe_nombre;
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;

                        item.TipoCuenta = info.TipoCuenta;
                        item.NumCuenta = info.NumCuenta;
                        item.IdBanco = info.IdBanco;
                        item.IdBanco = info.IdBanco;
                        item.TipoIdentificacion = info.TipoIdentificacion;
                        item.IdDivision = info.IdDivision;
                        item.Division = info.DivisionDescripcion;
                        item.check = true;
                        if (info.NumCuenta == "" || info.NumCuenta == null)
                            info.NumCuenta = "0";
                        if (info.TipoCuenta == "CHE")
                        {
                            item.pagacheque = true;
                        }
                        else
                        {

                            item.pagacheque = false;
                            
                        }
                        item.CodigoLegal = info.CodigoLegal;
                        item.IdDepartamento = info.IdDepartamento;
                        item.ba_descripcion = info.ba_descripcion;

                        item.ValorCancelado = info.ValorCancelado;
                        item.PendientePago = info.PendientePago;
                        if (info.CodigoLegal == "34")
                            item.CodigoLegal = "37";
                        else
                            item.CodigoLegal = info.CodigoLegal;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, string idRubro, List<string> Bancos, List<string> Cuentas, ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.spROL_Valor_Pendiente_pago(idEmpresa, idNominaTipo, idNominaTipoLiqui, idPeriodo)
                                 where a.IdEmpresa == idEmpresa

                                 && a.PendientePago > 0
                                 && Cuentas.Contains(a.TipoCuenta)
                                 && Bancos.Contains(a.ba_descripcion)
                                 orderby a.pe_apellido descending
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                        item.pe_apellido=item.pe_apellido;
                        item.CedulaRuc = info.CedulaRuc;
                        item.NombreCompleto = info.pe_apellido + " " + info.pe_nombre;
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;

                        item.TipoCuenta = info.TipoCuenta;
                        item.NumCuenta = info.NumCuenta;
                        item.IdBanco = info.IdBanco;
                        item.IdBanco = info.IdBanco;
                        item.TipoIdentificacion = info.TipoIdentificacion;
                        item.IdDivision = info.IdDivision;
                        item.Division = info.DivisionDescripcion;
                        item.check = true;
                        if (info.NumCuenta == "" || info.NumCuenta == null)
                            info.NumCuenta = "0";
                        if (info.TipoCuenta == "CHE")
                        {
                            item.pagacheque = true;
                        }
                        else
                        {

                            item.pagacheque = false;

                        }
                        item.CodigoLegal = info.CodigoLegal;
                        item.IdDepartamento = info.IdDepartamento;
                        item.ba_descripcion = info.ba_descripcion;

                        item.ValorCancelado = info.ValorCancelado;
                        item.PendientePago = info.PendientePago;
                        if (info.CodigoLegal == "34")
                            item.CodigoLegal = "37";
                        else
                            item.CodigoLegal = info.CodigoLegal;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubroDivision(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, string idRubro, int idDivision,ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Empleado_Rol_Detalle
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdNominaTipoLiqui == idNominaTipoLiqui 
                                 && a.IdPeriodo == idPeriodo
                                 && a.IdRubro == idRubro 
                                 && a.IdDivision==idDivision
                                 && a.Valor > 0
                                 orderby a.NombreCompleto ascending
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;
                        item.CedulaRuc = info.CedulaRuc;
                        item.NombreCompleto = info.pe_apellido +" " + info.pe_nombre;
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;
                        if (info.NumCuenta == "" || info.NumCuenta == null)
                            info.NumCuenta = "0";
                        if (info.NumCuenta == "" || info.NumCuenta == null)
                            info.NumCuenta = "0";
                        if (info.TipoCuenta == "CHE")
                        {
                            item.pagacheque = true;
                        }
                        else
                        {

                            item.pagacheque = false;

                        }
                        item.TipoCuenta = info.TipoCuenta;
                        item.NumCuenta = info.NumCuenta;
                        item.IdBanco = info.IdBanco;
                        item.IdBanco = info.IdBanco;
                        item.TipoIdentificacion = info.TipoIdentificacion;
                        item.IdDivision = info.IdDivision;
                        item.Division = info.DivisionDescripcion;
                        item.check = true;
                        item.CodigoLegal = info.CodigoLegal;
                        item.pe_apellido=item.pe_apellido;
                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public List<ro_Rol_Detalle_Info> GetListConsultaPorRubroPendiente(int idEmpresa, decimal idEmpleado, string idRubro ,DateTime FechaIngreso, DateTime FechaSalida, ref string msg)
        {

            try
            {
                List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.spROL_Valor_Pendiente_pago_x_Empleado_Acta_Finiquito(idEmpresa, 1,idEmpleado, FechaIngreso, FechaSalida)
                                 where a.IdEmpresa == idEmpresa 
                                 && a.PendientePago >0
                                 
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Orden = info.Orden;
                        item.Valor = info.Valor;
                        item.rub_visible_reporte = info.rub_visible_reporte;
                        item.Observacion = info.Observacion;
                        item.TipoMovimiento = info.TipoMovimiento;

                        //VISTA
                        
                        item.Departamento = info.Departamento;
                        item.DescRubroLargo = info.DescRubroLargo;
                        item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                        item.NominaLiqui = info.NominaLiqui;
                        item.Nomina = info.Nomina;
                        item.Empresa = info.Empresa;
                        item.FechaIni = info.FechaIni;
                        item.FechaFin = info.FechaFin;
                        item.Tag = info.Tag;
                        item.Cerrado = info.Cerrado;
                        item.Contabilizado = info.Contabilizado;
                        item.Procesado = info.Procesado;
                        item.EstadoRol = info.EstadoRol;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;
                        item.pe_apellido=item.pe_apellido;

                        oListado.Add(item);
                    }
                }
                return oListado;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }





        public double GetValorAcumuladoPorRubro(int idEmpresa, decimal idEmpleado, int idNominaTipo, string idRubro, DateTime fechaIni, DateTime fechaFin,ref string msg)
        {

            try
            {
                double? valor=0;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    valor = (from a in db.vwRo_Generar_Decimo
                                 where a.IdEmpresa == idEmpresa && a.IdEmpleado == idEmpleado
                                 && a.ru_tipo == "I"
                                 && a.IdRubro==idRubro
                                 && a.Valor > 0
                                 && ((a.FechaIngresa >= fechaIni) && (a.FechaIngresa <= fechaFin))    
                                 select a.Valor).Sum();

                 
                }
                return (double) valor;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }



        public Boolean GetExiste(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_rol_detalle
                                where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                                && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                                && a.IdEmpleado == info.IdEmpleado && a.IdRubro == info.IdRubro
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }




        public Boolean GuardarBD(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol_detalle item = new ro_rol_detalle();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdNominaTipo = info.IdNominaTipo;
                    item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdRubro = info.IdRubro;
                    item.Orden = info.Orden;
                    
                    //item.Valor = info.Valor;                  
                   // item.Valor = Math.Round(info.Valor, 4,MidpointRounding.AwayFromZero);
                    item.Valor = Math.Round(info.Valor, 2);

                    item.rub_visible_reporte = info.rub_visible_reporte;
                    item.Observacion = info.Observacion;
                    item.TipoMovimiento = info.TipoMovimiento;

                    db.ro_rol_detalle.Add(item);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }




        public Boolean ModificarBD(ro_Rol_Detalle_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol_detalle item = (from a in db.ro_rol_detalle
                                           where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                                            && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                                            && a.IdEmpleado == info.IdEmpleado && a.IdRubro == info.IdRubro
                                   select a).FirstOrDefault();

                    //NO ES RECOMENDABLE MODIFICAR LA CLAVE PRIMARIA
                    /*item.IdEmpresa = info.IdEmpresa;
                    item.IdNominaTipo = info.IdNominaTipo;
                    item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdRubro = info.IdRubro;
                    */
                    
                    item.Orden = info.Orden;
                    item.Valor = info.Valor;
                    item.rub_visible_reporte = info.rub_visible_reporte;
                    item.Observacion = info.Observacion;
                    item.TipoMovimiento = info.TipoMovimiento;

                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }

        }

       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui,int idPeriodo, decimal idEmpleado, ref string msg) 
        {
            try{

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_rol_detalle where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNominaTipo=" + idNomina.ToString()
                       + " AND IdNominaTipoLiqui=" + idNominaLiqui.ToString()
                       + " AND IdPeriodo=" + idPeriodo.ToString()
                       + " AND IdEmpleado=" + idEmpleado.ToString()
                       );
                }

                return true;
         }
         catch (Exception ex)
         {
             string array = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
             mensaje = ex.InnerException + " " + ex.Message;
             throw new Exception(ex.InnerException.ToString());
         }
        }




       public List<ro_Rol_Detalle_Info> GetList_InformeIESS(int idEmpresa, decimal idEmpleado,int IdPeriodo)
       {
           try
           {
               List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();
              

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.vwRo_Rol_Detalle
                                where a.IdEmpresa == idEmpresa
                                && a.IdEmpleado == idEmpleado
                                && a.IdPeriodo==IdPeriodo
                                orderby a.Orden ascending
                                select a);

                   foreach (var info in datos)
                   {
                       ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNominaTipo = info.IdNominaTipo;
                       item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                       item.IdPeriodo = info.IdPeriodo;
                       item.IdEmpleado = info.IdEmpleado;
                       item.IdRubro = info.IdRubro;
                       item.Orden = info.Orden;
                       item.Valor = info.Valor;
                       item.rub_visible_reporte = info.rub_visible_reporte;
                       item.Observacion = info.Observacion;
                       item.TipoMovimiento = info.TipoMovimiento;
                       //VISTA
                       item.CedulaRuc = info.Ruc;
                       item.NombreCompleto = info.Empleado;
                       item.Departamento = info.Departamento;
                       item.DescRubroLargo = info.DescRubroLargo;
                       item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                       item.NominaLiqui = info.NominaLiqui;
                       item.Nomina = info.Nomina;
                       item.Empresa = info.Empresa;
                       item.FechaIni = info.FechaIni;
                       item.FechaFin = info.FechaFin;
                       item.Tag = info.Tag;
                       item.Cerrado = info.Cerrado;
                       item.Contabilizado = info.Contabilizado;
                       item.Procesado = info.Procesado;
                       item.EstadoRol = info.EstadoRol;
                       item.rub_grupo = info.rub_grupo;
                       oListado.Add(item);
                   }
               }
               return oListado;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }




       public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo)
       {
           try
           {

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   db.Database.ExecuteSqlCommand("delete from dbo.ro_rol_detalle where IdEmpresa =" + idEmpresa.ToString()
                      + " AND IdNominaTipo=" + idNomina.ToString()
                      + " AND IdNominaTipoLiqui=" + idNominaLiqui.ToString()
                      + " AND IdPeriodo=" + idPeriodo.ToString()
                   
                      );
               }

               return true;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public decimal Get_Valor_Impuesto_Renta(int idempresa, int idempleado, int Anio_Fiscal)
       {
           try
           {
               decimal valor_=0;
                try 
                {
                    using (EntitiesRoles db = new EntitiesRoles())
                    {
                        var datos = (from a in db.vwRo_Rol_Detalle
                                     where a.IdEmpresa == idempresa
                                     && a.IdEmpleado == idempleado
                                     && a.pe_anio == Anio_Fiscal
                                     && a.rub_aplica_IESS==true

                                     
                                     select a);
                        if(datos.Count()>0)
                        {

                        valor_=(decimal) datos.Sum(v=>v.Valor);
                        }
                    }

                    return valor_;
                    }
                    catch (Exception ex)
                    {
                        string array = ToString();
                        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                        mensaje = ex.InnerException + " " + ex.Message;
                        throw new Exception(ex.InnerException.ToString());
                    }       
           }
           catch (Exception ex)
           {
               
             string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public List<ro_Rol_Detalle_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int idEmpresa, int IdNomina_Tipo, int Id_Nomina_Tipo_liq, int IdPeriodo)
       {
           List<ro_Rol_Detalle_Info> lM = new List<ro_Rol_Detalle_Info>();

           EntitiesRoles OERol_Empleado = new EntitiesRoles();
           try
           {
              
               OERol_Empleado.spROL_General_RolIndividual(idEmpresa, IdNomina_Tipo, Id_Nomina_Tipo_liq, IdPeriodo);

               var select = (from a in OERol_Empleado.vwRo_Rol_Detalle
                             where a.IdEmpresa == idEmpresa
                            && a.IdNominaTipo == IdNomina_Tipo
                            && a.IdNominaTipoLiqui == Id_Nomina_Tipo_liq
                            && a.IdPeriodo == IdPeriodo
                            && (a.ru_tipo == "I" || a.ru_tipo == "E")
                            && a.Valor>0


                            select a);

               foreach (var item in select)
               {
                   ro_Rol_Detalle_Info info = new ro_Rol_Detalle_Info();

                   info.IdRubro = item.IdRubro;
                   info.DescRubroLargo = item.DescRubroLargo;
                   info.IdPeriodo = item.IdPeriodo;
                   info.IdNominaTipo = item.IdNominaTipo;
                   info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.ru_tipo = item.ru_tipo;
                   info.Valor = item.Valor;
                   lM.Add(info);

               }
               return (lM);
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<ro_Rol_Detalle_Info> Get_List_Ing_Egr_x_Empleado_x_Ingresos(int idEmpresa, int IdNomina_Tipo, int Id_Nomina_Tipo_liq, int IdPeriodo, int IdEmpleado)
       {
           List<ro_Rol_Detalle_Info> lM = new List<ro_Rol_Detalle_Info>();

           EntitiesRoles OERol_Empleado = new EntitiesRoles();
           try
           {

               OERol_Empleado.spROL_General_RolIndividual(idEmpresa, IdNomina_Tipo, Id_Nomina_Tipo_liq, IdPeriodo);

               var select = (from a in OERol_Empleado.vwRo_Rol_Detalle
                             where a.IdEmpresa == idEmpresa
                            && a.IdNominaTipo == IdNomina_Tipo
                            && a.IdNominaTipoLiqui == Id_Nomina_Tipo_liq
                            && a.IdPeriodo == IdPeriodo
                            && (a.ru_tipo == "I" || a.ru_tipo == "E")
                            && a.Valor > 0
                            && a.IdEmpleado == IdEmpleado


                             select a);

               foreach (var item in select)
               {
                   ro_Rol_Detalle_Info info = new ro_Rol_Detalle_Info();

                   info.IdRubro = item.IdRubro;
                   info.DescRubroLargo = item.DescRubroLargo;
                   info.IdPeriodo = item.IdPeriodo;
                   info.IdNominaTipo = item.IdNominaTipo;
                   info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdEmpleado = item.IdEmpleado;
                   info.ru_tipo = item.ru_tipo;
                   info.Valor = item.Valor;
                   lM.Add(info);

               }
               return (lM);
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public double Get_Valor_Fondo_Reserva_x_periodo_x_nomina(int idempresa, int idnomina_tipo,int IdNomina_tipo_Liq, int idempleado, int idperiodo)
       {
           try
           {
               double valor_ = 0;
               try
               {
                   using (EntitiesRoles db = new EntitiesRoles())
                   {
                       var datos = (from a in db.vwRo_Rol_Detalle
                                    where a.IdEmpresa == idempresa
                                    && a.IdEmpleado == idempleado
                                    &&a.IdNominaTipo==idnomina_tipo
                                    && a.IdPeriodo == idperiodo
                                    && a.IdNominaTipoLiqui != IdNomina_tipo_Liq
                                    && a.IdRubro == "296"


                                    select a);
                       if (datos.Count() > 0)
                       {

                           valor_ = (double)datos.Sum(v => v.Valor);
                       }
                   }

                   return valor_;
               }
               catch (Exception ex)
               {
                   string array = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.InnerException + " " + ex.Message;
                   throw new Exception(ex.InnerException.ToString());
               }
           }
           catch (Exception ex)
           {

               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public double Get_Valor_Anticipo(int idempresa, int idnomina_tipo, int IdNomina_tipo_Liq, int idempleado, int idperiodo)
       {
           try
           {
               double valor_ = 0;
               try
               {
                   using (EntitiesRoles db = new EntitiesRoles())
                   {
                       var datos = (from a in db.ro_rol_detalle
                                    where a.IdEmpresa == idempresa
                                    && a.IdEmpleado == idempleado
                                    && a.IdNominaTipo == idnomina_tipo
                                    && a.IdPeriodo == idperiodo
                                    && a.IdNominaTipoLiqui == IdNomina_tipo_Liq
                                    && a.IdRubro == "294"


                                    select a);
                       if (datos.Count() > 0)
                       {

                           valor_ = (double)datos.Sum(v => v.Valor);
                       }
                   }

                   return valor_;
               }
               catch (Exception ex)
               {
                   string array = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.InnerException + " " + ex.Message;
                   throw new Exception(ex.InnerException.ToString());
               }
           }
           catch (Exception ex)
           {

               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<ro_Rol_Detalle_Info> GetListConsultaGeneralPorRubro(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, int IdArchivo)
       {

           try
           {
               List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.vwRo_Archivos_Bancos_Generacion_det
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo==idNominaTipo 
                               &&a.IdNominaTipoLiqui == idNominaTipoLiqui
                               &&a.IdArchivo==IdArchivo
                               && a.IdRubro=="950"
                               && a.Valor>0
                                orderby a.NombreCompleto ascending
                                select a);

                   foreach (var info in datos)
                   {
                       ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNominaTipo = info.IdNominaTipo;
                       item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                       item.IdPeriodo = info.IdPeriodo;
                       item.IdEmpleado = info.IdEmpleado;
                       item.IdRubro = info.IdRubro;
                       item.Orden = info.Orden;
                       item.Valor = info.Valor;
                       item.rub_visible_reporte = info.rub_visible_reporte;
                       item.Observacion = info.Observacion;
                       item.TipoMovimiento = info.TipoMovimiento;

                       item.CedulaRuc = info.CedulaRuc;
                       item.NombreCompleto = info.pe_apellido + " " + info.pe_nombre;
                       item.Departamento = info.Departamento;
                       item.DescRubroLargo = info.DescRubroLargo;
                       item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                       item.NominaLiqui = info.NominaLiqui;
                       item.Nomina = info.Nomina;
                       item.Empresa = info.Empresa;
                       item.FechaIni = info.FechaIni;
                       item.FechaFin = info.FechaFin;
                       item.Tag = info.Tag;
                       item.Cerrado = info.Cerrado;
                       item.Contabilizado = info.Contabilizado;
                       item.Procesado = info.Procesado;
                       item.EstadoRol = info.EstadoRol;
                       item.pe_anio = info.pe_anio;
                       item.pe_mes = info.pe_mes;

                       item.TipoCuenta = info.TipoCuenta;
                       item.NumCuenta = info.NumCuenta;
                       item.IdBanco = info.IdBanco;
                       item.IdBanco = info.IdBanco;
                       item.TipoIdentificacion = info.TipoIdentificacion;
                       item.IdDivision = info.IdDivision;
                       item.Division = info.DivisionDescripcion;
                       item.check = true;
                       if (info.NumCuenta == "" || info.NumCuenta == null)
                           info.NumCuenta = "0";
                       if (info.TipoCuenta == "CHE")
                       {
                           item.pagacheque = true;
                       }
                       else
                       {

                           item.pagacheque = false;

                       }
                       item.CodigoLegal = info.CodigoLegal;
                       item.IdDepartamento = info.IdDepartamento;
                       item.ba_descripcion = info.ba_descripcion;

                       item.ValorCancelado = info.ValorCancelado;
                       item.PendientePago = info.PendientePago;
                       if (info.CodigoLegal == "34")
                           item.CodigoLegal = "37";
                       else
                           item.CodigoLegal = info.CodigoLegal;

                       oListado.Add(item);
                   }
               }
               return oListado;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public List<ro_Rol_Detalle_Info> Get_lista_rol_Provisiones(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo, ref string msg)
       {

           try
           {
               List<ro_Rol_Detalle_Info> oListado = new List<ro_Rol_Detalle_Info>();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.vwRo_Rol_Detalle
                                where a.IdEmpresa == idEmpresa
                                && a.IdNominaTipo == idNominaTipo
                                && a.IdNominaTipoLiqui == idNominaTipoLiqui
                                && a.IdPeriodo == idPeriodo
                                && a.Valor > 0
                                && a.rub_provision==true
                                select a);

                   foreach (var info in datos)
                   {
                       ro_Rol_Detalle_Info item = new ro_Rol_Detalle_Info();
                       item.IdEmpresa = info.IdEmpresa;
                       item.IdNominaTipo = info.IdNominaTipo;
                       item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                       item.IdPeriodo = info.IdPeriodo;
                       item.IdEmpleado = info.IdEmpleado;
                       item.IdRubro = info.IdRubro;
                       item.Orden = info.Orden;
                       item.Valor = info.Valor;
                       item.rub_visible_reporte = info.rub_visible_reporte;
                       item.Observacion = info.Observacion;
                       item.TipoMovimiento = info.TipoMovimiento;

                       item.CedulaRuc = info.Ruc;
                       item.NombreCompleto = info.pe_apellido + " " + info.pe_nombre;
                       item.Departamento = info.Departamento;
                       item.DescRubroLargo = info.DescRubroLargo;
                       item.DescNombreRubroCorto = info.DescNombreRubroCorto;
                       item.NominaLiqui = info.NominaLiqui;
                       item.Nomina = info.Nomina;
                       item.Empresa = info.Empresa;
                       item.FechaIni = info.FechaIni;
                       item.FechaFin = info.FechaFin;
                       item.Tag = info.Tag;
                       item.Cerrado = info.Cerrado;
                       item.Contabilizado = info.Contabilizado;
                       item.Procesado = info.Procesado;
                       item.EstadoRol = info.EstadoRol;
                       item.pe_anio = info.pe_anio;
                       item.pe_mes = info.pe_mes;

                       item.IdSucursal = info.IdSucursal;
                       item.IdDepartamento = info.IdDepartamento;
                       item.IdDivision = info.IdDivision;
                       item.IdArea = info.IdArea;
                       item.StatusEmpleado = info.StatusEmpleado;
                       item.EstadoEmpleado = info.EstadoEmpleado;


                       oListado.Add(item);
                   }
               }
               return oListado;
           }
           catch (Exception ex)
           {
               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public double Get_Decimo_Acumulados(int idempresa, int idnomina_tipo, int idempleado, string IdRubro)
       {
           try
           {
               double valor_ = 0;
               try
               {
                   using (EntitiesRoles db = new EntitiesRoles())
                   {
                       var datos = (from a in db.vwRo_Rol_Detalle
                                    where a.IdEmpresa == idempresa
                                    && a.IdEmpleado == idempleado
                                    && a.IdNominaTipo == idnomina_tipo
                                    && a.IdRubro == IdRubro


                                    select a);
                       if (datos.Count() > 0)
                       {

                           valor_ = (double)datos.Sum(v => v.Valor);
                       }
                   }

                   return valor_;
               }
               catch (Exception ex)
               {
                   string array = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.InnerException + " " + ex.Message;
                   throw new Exception(ex.InnerException.ToString());
               }
           }
           catch (Exception ex)
           {

               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }


       public double Get_Decimotcuarta(int idempresa, DateTime fi, DateTime ff, decimal idempleado)
       {
           try
           {
              
               double valor_ = 0;

               List<ro_Rol_Detalle_Info> lista = new List<ro_Rol_Detalle_Info>(); 
                using (EntitiesRoles db = new EntitiesRoles())
                   {
                       var datos = (from a in db.spROL_DecimoCuarto(idempresa, fi,ff)
                                    where a.IdEmpresa == idempresa
                                    && a.IdEmpleado == idempleado
                                    select a);
                          foreach (var item in datos)
	                        {
                                valor_ = valor_ +Convert.ToDouble( item.Valor);
	                        }

                                  
                      
                   }

                   return valor_;
             
           }
           catch (Exception ex)
           {

               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public double Get_Decimoterceo(int idempresa, DateTime fi, DateTime ff, decimal idempleado)
       {
           try
           {
               double valor_ = 0;
              
                   using (EntitiesRoles db = new EntitiesRoles())
                   {
                       var datos = (from a in db.spROL_DecimoTercero(idempresa, fi, ff)
                                    where a.IdEmpresa == idempresa
                                    && a.IdEmpleado == idempleado



                                    select a);
                       if (datos.Count() > 0)
                       {

                           valor_ = (double)datos.Sum(v => v.Valor);
                       }
                   }

                   return valor_;
               
           }
           catch (Exception ex)
           {

               string array = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}
