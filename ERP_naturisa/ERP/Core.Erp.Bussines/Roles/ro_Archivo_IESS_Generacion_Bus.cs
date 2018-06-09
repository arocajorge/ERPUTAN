
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Business.Roles
{
    public class ro_Archivo_IESS_Generacion_Bus
    {

        ro_Archivo_IESS_Generacion_Data oData = new ro_Archivo_IESS_Generacion_Data();
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
   
        string mensaje = "";



        //INFO
        ro_periodo_x_ro_Nomina_TipoLiqui_Info oRo_PeriodoInfo = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
  
        //BUS
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus oRo_periodo_x_ro_Nomina_TipoLiqui_Bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();
        ro_Empleado_Bus oRo_Empleado_Bus = new ro_Empleado_Bus();
        tb_Empresa_Bus oTb_Empresa_Bus = new tb_Empresa_Bus();
        ro_Rol_Detalle_Bus oRo_Rol_Detalle_Bus = new ro_Rol_Detalle_Bus();                

        public Boolean GrabarBD(ro_Archivo_IESS_Generacion_Info info, string nombreArchivo, string carSeparador, ref string msg)
        {
            try
            {
                return oData.GrabarBD(info, nombreArchivo,carSeparador,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Archivo_IESS_Generacion_Bus) };

            }
        }



        public List<ro_Archivo_IESS_Generacion_Info> pu_GenerarBatch(int idEmpresa, ro_periodo_x_ro_Nomina_TipoLiqui_Info infoPeriodo, string idTipoNovedad, string codigoSucursal)
        {

            try
            {
                List<ro_Empleado_Info> oListRo_Empleado_Info = new List<ro_Empleado_Info>();
                List<ro_Rol_Detalle_Info> oListRo_Rol_Detalle_Info = new List<ro_Rol_Detalle_Info>();
                List<ro_Archivo_IESS_Generacion_Info> Listado = new List<ro_Archivo_IESS_Generacion_Info>();
                //OBTENER LOS DATOS DE LA EMPRESA
                tb_Empresa_Info oTb_Empresa_Info = new tb_Empresa_Info();
                oTb_Empresa_Info = oTb_Empresa_Bus.Get_Info_Empresa(idEmpresa);
                

                //OBTENER EL PERIODO
                oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(idEmpresa).Where(v => v.em_estado == "A").ToList();
     
              
                switch (idTipoNovedad)
                {
                
                    case "ENT":

                        //OBTENGO LOS EMPLEADOS ACTIVOS EN EL PERIODO CORRESPONDIENTE
                        oListRo_Empleado_Info = oRo_Empleado_Bus.GetListPorNovedadAvisoEntrada(idEmpresa, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin).Where(v=>v.em_estado=="A" && v.em_status=="EST_ACT").ToList();

                        if (oListRo_Empleado_Info.Count > 0)
                        {
                            foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                            {
                                ro_Archivo_IESS_Generacion_Info info = new ro_Archivo_IESS_Generacion_Info();
                                info.Ruc = oTb_Empresa_Info.em_ruc;
                                info.CodigoSucursal = codigoSucursal;
                                info.AnioActual = Convert.ToString(infoPeriodo.pe_FechaIni.Year);
                                info.MesActual = Convert.ToString(infoPeriodo.pe_FechaIni.Month);
                                info.TipoMovimiento = idTipoNovedad;
                                info.NoCedula = item.InfoPersona.pe_cedulaRuc.Trim();
                                info.FechaIngresoEmpresa = Convert.ToDateTime(item.em_fecha_ingreso);
                                info.FechaIngresoIESS = Convert.ToDateTime(item.em_fechaIngaRol);
                                info.Jornada = "1"; 
                                info.CodigoSeguroSocial = "R"; 
                                info.CodigoTipoEmpleador = "2";
                                info.RelacionTrabajo = "06"; 
                                info.Cargo = item.cargo_Descripcion;
                                info.CodigoActividaSectorial = item.CodigoSectorialIESS;
                                info.Sueldo = item.SueldoActual;
                                info.OrigenPago = "P";


                                info.nombre = item.pe_apellido + " " + item.pe_nombre;
                                info.nomina = item.Nomina;
                                info.departamento = item.departamento;
                                Listado.Add(info);
                            }
                        }
                        
                        break;

                    case "SAL":
                        //OBTENGO LOS EMPLEADOS LIQUIDADOS EN EL PERIODO CORRESPONDIENTE
                        oListRo_Empleado_Info = oRo_Empleado_Bus.GetListPorNovedadAvisoSalida(idEmpresa, oRo_PeriodoInfo.pe_FechaIni, oRo_PeriodoInfo.pe_FechaFin).Where(v => v.em_estado == "I" && v.em_status == "EST_LIQ").ToList();

                        if (oListRo_Empleado_Info.Count > 0)
                        {
                            foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                            {
                                ro_Archivo_IESS_Generacion_Info info = new ro_Archivo_IESS_Generacion_Info();
                                info.Ruc = oTb_Empresa_Info.em_ruc;
                                info.CodigoSucursal = codigoSucursal;
                                info.AnioActual = Convert.ToString(infoPeriodo.pe_FechaIni.Year);
                                info.MesActual = Convert.ToString(infoPeriodo.pe_FechaIni.Month);
                                info.TipoMovimiento = idTipoNovedad;
                                info.NoCedula = item.InfoPersona.pe_cedulaRuc.Trim();
                                info.FechaSalida = Convert.ToDateTime(item.em_fechaSalida);
                                info.Causa = "A"; 
                                info.FechaFallecimiento = "00000000";   


                                info.nombre = item.pe_apellido + " " + item.pe_nombre;
                                info.nomina = item.Nomina;
                                info.departamento = item.departamento;

                                Listado.Add(info);
                            }
                        }
                        
                        break;

                    case "MSU":
                        //OBTENGO LOS EMPLEADOS DONDE LOS SUELDOS HAYAN SIDO MODIFICADOS EN EL PERIODO CORRESPONDIENTE
                        oListRo_Empleado_Info = oRo_Empleado_Bus.GetListPorNovedadAvisoNuevoSueldo(idEmpresa, infoPeriodo.pe_FechaIni, infoPeriodo.pe_FechaFin).Where(v => v.em_estado == "A").ToList();

                        if (oListRo_Empleado_Info.Count > 0)
                        {
                            foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                            {
                                ro_Archivo_IESS_Generacion_Info info = new ro_Archivo_IESS_Generacion_Info();
                                info.Ruc = oTb_Empresa_Info.em_ruc;
                                info.CodigoSucursal = codigoSucursal;
                                info.AnioActual = Convert.ToString(infoPeriodo.pe_FechaIni.Year);
                                info.MesActual = Convert.ToString(infoPeriodo.pe_FechaIni.Month);
                                info.TipoMovimiento = idTipoNovedad;
                                info.NoCedula = item.InfoPersona.pe_cedulaRuc.Trim();
                                info.ValorExtra = item.SueldoActual;
                                info.Causa = "0";
                                info.nombre = item.InfoPersona.pe_nombreCompleto;
                                info.nomina = item.Nomina;
                                info.departamento = item.de_descripcion;
                                Listado.Add(info);
                            }
                        }
                      
                        break;

                    case "INS":

                        //OBTENGO LOS EMPLEADOS ACTVIOS DE LA NOMINA SELECCIONADA
                        oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(idEmpresa).Where(v => v.em_estado == "A").ToList();

                            if (oListRo_Empleado_Info.Count > 0)
                            {
                                foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                                {
                                    double valorExtra = 0;
                                    //OBTENGO LA SUMATORIA DE LOS RUBROS QUE QUE PERTENECEN AL GRUPO COMPONENTE SALARIAL (HORAS EXTRAS, COMISIONES, ETC)
                                    //EN EL PERIODO CORRESPONDIENTE
                                    valorExtra = oRo_Rol_Detalle_Bus.GetList_InformeIESS(idEmpresa, item.IdEmpleado, infoPeriodo.IdPeriodo).Where(v => v.rub_grupo == 62).Sum(v => v.Valor);

                                    if (valorExtra > 0)
                                    {
                                        ro_Archivo_IESS_Generacion_Info info = new ro_Archivo_IESS_Generacion_Info();
                                        info.Ruc = oTb_Empresa_Info.em_ruc;
                                        info.CodigoSucursal = codigoSucursal;
                                        info.AnioActual = Convert.ToString(infoPeriodo.pe_FechaIni.Year);
                                        info.MesActual = Convert.ToString(infoPeriodo.pe_FechaIni.Month);
                                        info.TipoMovimiento = idTipoNovedad;
                                        info.NoCedula = item.InfoPersona.pe_cedulaRuc.Trim();
                                        info.ValorExtra = valorExtra;
                                        info.Causa = "O";
                                        info.nombre=item.InfoPersona.pe_nombreCompleto;
                                        info.nomina = item.Nomina;
                                        info.departamento = item.de_descripcion;
                                        Listado.Add(info);
                                    }
                                }
                            }
                           
                        break;

                    case "PFR":

                        break;

                    case "PFM":

                        //OBTENGO LOS EMPLEADOS ACTIVOS DE LA NOMINA SELECCIONADA
                        oListRo_Empleado_Info = oRo_Empleado_Bus.Get_List_Empleado_(idEmpresa).Where(v => v.em_estado == "A").ToList();

                        if (oListRo_Empleado_Info.Count > 0)
                        {
                            foreach (ro_Empleado_Info item in oListRo_Empleado_Info)
                            {
                                double valorTotal = 0;
                                //OBTENGO LA SUMATORIA DEL RUBRO  DE FONDO DE RESERVA EN EL PERIODO CORRESPONDIENTE
                                valorTotal = oRo_Rol_Detalle_Bus.GetList_InformeIESS(idEmpresa, item.IdEmpleado,infoPeriodo.IdPeriodo).Where(v => v.IdRubro == "296").Sum(v => v.Valor);

                                if (valorTotal > 0)
                                {
                                    ro_Archivo_IESS_Generacion_Info info = new ro_Archivo_IESS_Generacion_Info();
                                    info.Ruc = oTb_Empresa_Info.em_ruc;
                                    info.CodigoSucursal = codigoSucursal;
                                    info.AnioActual = Convert.ToString(infoPeriodo.pe_FechaIni.Year);
                                    info.MesActual = Convert.ToString(infoPeriodo.pe_FechaIni.Month);
                                    info.TipoMovimiento = idTipoNovedad;
                                    info.NoCedula = item.InfoPersona.pe_cedulaRuc.Trim();
                                    info.SueldoTotal = valorTotal;
                                    info.Periodo = info.AnioActual + "-" + info.MesActual + " A " + info.AnioActual + "-" + info.MesActual;
                                    info.NoMesesLaborados = "01";
                                    info.TipoPeriodo="G";


                                    info.nombre = item.pe_apellido + " " + item.pe_nombre;
                                    info.nomina = item.Nomina;
                                    info.departamento = item.departamento;

                                    Listado.Add(info);
                                }
                            }
                        }
                       

                        break;

                    case "PPF":

                        break;
                    case "PFN":

                        break;
                    case "MND":

                        break;

                    case "RRT":

                        break;

                }

                return Listado;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarBatch", ex.Message), ex) { EntityType = typeof(ro_Archivo_IESS_Generacion_Bus) };

            }
        
        
        }








    }
}
