/*CLASE: ro_rol_detalle_x_rubro_acumulado_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 14-04-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_rol_detalle_x_rubro_acumulado_Data
    {

        private string mensaje = "";

        public List<ro_rol_detalle_x_rubro_acumulado_Info> GetListConsultaPorEmpleado(int idEmpresa, decimal idEmpleado, string IdRubro)
        {
            try
            {
                List<ro_rol_detalle_x_rubro_acumulado_Info> oListado = new List<ro_rol_detalle_x_rubro_acumulado_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_Rol_Rubros_Acumulados
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado == idEmpleado
                                 && a.IdRubro==IdRubro
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_rol_detalle_x_rubro_acumulado_Info item = new ro_rol_detalle_x_rubro_acumulado_Info();

                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNomina_Tipo;
                        item.IdNominaTipoLiqui = info.IdNomina_TipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.Valor = info.Valor;
                        item.Estado = info.EstadoAcumulado;

                        //VISTA
                        item.NombreCompleto = info.NombreCompleto;
                        item.CedulaRuc = info.CedulaRuc;
                        item.RubroDescripcion = info.RubroDescripcion;
                        item.Cerrado = info.Cerrado;
                        item.Procesado = info.Procesado;
                        item.Contabilizado = info.Contabilizado;
                        item.pe_anio = info.pe_anio;
                        item.pe_mes = info.pe_mes;
                        item.pe_FechaIni = info.pe_FechaIni;
                        item.pe_FechaFin = info.pe_FechaFin;

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

        public Boolean GetExiste(ro_rol_detalle_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_rol_detalle_x_rubro_acumulado
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

        public Boolean GuardarBD(ro_rol_detalle_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol_detalle_x_rubro_acumulado item = new ro_rol_detalle_x_rubro_acumulado();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdNominaTipo = info.IdNominaTipo;
                    item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdRubro = info.IdRubro;
                    item.Valor = info.Valor;
                    item.Estado = info.Estado;

                    db.ro_rol_detalle_x_rubro_acumulado.Add(item);
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


        public Boolean ModificarBD(ro_rol_detalle_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol_detalle_x_rubro_acumulado item = (from a in db.ro_rol_detalle_x_rubro_acumulado
                                           where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                                            && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                                            && a.IdEmpleado == info.IdEmpleado && a.IdRubro == info.IdRubro
                                           select a).FirstOrDefault();

                    item.Valor = info.Valor;
                    item.Estado = info.Estado;
                   
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


        public Boolean EliminarBD(int idEmpresa, int idNomina, int idNominaLiqui, int idPeriodo, decimal idEmpleado, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_rol_detalle_x_rubro_acumulado where IdEmpresa =" + idEmpresa.ToString()
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




        public List<ro_rol_detalle_x_rubro_acumulado_Info> GetListConsultaPorEmpleado(int idEmpresa,int idNomina_Tipo, decimal idEmpleado)
        {
            try
            {
                List<ro_rol_detalle_x_rubro_acumulado_Info> oListado = new List<ro_rol_detalle_x_rubro_acumulado_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwro_rol_detalle_x_rubro_acumulado
                                 where a.IdEmpresa == idEmpresa 
                                 && a.IdEmpleado == idEmpleado
                                 && a.IdNominaTipo == idNomina_Tipo
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_rol_detalle_x_rubro_acumulado_Info item = new ro_rol_detalle_x_rubro_acumulado_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.pe_anio = info.pe_anio;
                        item.Valor =Convert.ToDouble( info.Valor);                       
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

    }
}
