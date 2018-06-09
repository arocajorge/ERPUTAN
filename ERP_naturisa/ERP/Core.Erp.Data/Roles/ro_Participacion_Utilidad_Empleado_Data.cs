/*CLASE: ro_Participacion_Utilidad_Empleado_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 28-05-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_Participacion_Utilidad_Empleado_Data
    {
        private string mensaje = "";

        public List<ro_Participacion_Utilidad_Empleado_Info> GetListPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                List<ro_Participacion_Utilidad_Empleado_Info> oListado = new List<ro_Participacion_Utilidad_Empleado_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_participacion_utilidad_empleado
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdPeriodo == idPeriodo
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Participacion_Utilidad_Empleado_Info item = new ro_Participacion_Utilidad_Empleado_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.DiasTrabajados = info.DiasTrabajados;
                        item.CargasFamiliares = info.CargasFamiliares;
                        item.ValorIndividual = info.ValorIndividual;
                        item.ValorCargaFamiliar = info.ValorCargaFamiliar;
                        item.ValorExedenteIESS = info.ValorExedenteIESS;
                        item.ValorTotal = info.ValorTotal;
                                             
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


        public List<ro_Participacion_Utilidad_Empleado_Info> GetListPorIdEmpleado(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                List<ro_Participacion_Utilidad_Empleado_Info> oListado = new List<ro_Participacion_Utilidad_Empleado_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_participacion_utilidad_empleado
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdEmpleado == idEmpleado
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Participacion_Utilidad_Empleado_Info item = new ro_Participacion_Utilidad_Empleado_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdEmpleado = info.IdEmpleado;
                        item.DiasTrabajados = info.DiasTrabajados;
                        item.CargasFamiliares = info.CargasFamiliares;
                        item.ValorIndividual = info.ValorIndividual;
                        item.ValorCargaFamiliar = info.ValorCargaFamiliar;
                        item.ValorExedenteIESS = info.ValorExedenteIESS;
                        item.ValorTotal = info.ValorTotal;

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


        public Boolean GetExiste(ro_Participacion_Utilidad_Empleado_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_participacion_utilidad_empleado
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdPeriodo == info.IdPeriodo
                                && a.IdEmpleado==info.IdEmpleado
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

        public Boolean GuardarBD(ro_Participacion_Utilidad_Empleado_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad_empleado item = new ro_participacion_utilidad_empleado();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdEmpleado = info.IdEmpleado;
                    item.DiasTrabajados = info.DiasTrabajados;
                    item.CargasFamiliares = info.CargasFamiliares;

                    item.ValorIndividual = info.ValorIndividual;
                    item.ValorCargaFamiliar = info.ValorCargaFamiliar;
                    item.ValorExedenteIESS = info.ValorExedenteIESS;
                    item.ValorTotal = info.ValorTotal;
                   
                    //item.ValorIndividual = Math.Round(info.ValorIndividual, 5, MidpointRounding.AwayFromZero);
                    //item.ValorCargaFamiliar = Math.Round(info.ValorCargaFamiliar, 5, MidpointRounding.AwayFromZero);
                    //item.ValorExedenteIESS = Math.Round(info.ValorExedenteIESS, 5, MidpointRounding.AwayFromZero);
                    //item.ValorTotal = Math.Round(info.ValorTotal, 5, MidpointRounding.AwayFromZero);
                
                    db.ro_participacion_utilidad_empleado.Add(item);
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

        public Boolean ModificarBD(ro_Participacion_Utilidad_Empleado_Info info, ref string msg)
        {
            try
            {
               
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad_empleado item = (from a in db.ro_participacion_utilidad_empleado
                                                      where a.IdEmpresa == info.IdEmpresa
                                                      && a.IdPeriodo == info.IdPeriodo
                                                      && a.IdEmpleado==info.IdEmpleado
                                                      select a).FirstOrDefault();
                    
                    item.DiasTrabajados = info.DiasTrabajados;
                    item.CargasFamiliares = info.CargasFamiliares;
                    item.ValorIndividual = info.ValorIndividual;
                    item.ValorCargaFamiliar = info.ValorCargaFamiliar;
                    item.ValorExedenteIESS = info.ValorExedenteIESS;
                    item.ValorTotal = info.ValorTotal;

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


        public Boolean EliminarBD(int idEmpresa, int idPeriodo,  ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_participacion_utilidad_empleado where IdEmpresa =" + idEmpresa.ToString()
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
    }
}
