/*CLASE: ro_empleado_x_Proyeccion_Gastos_Personales_Data
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 04-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
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
    public class ro_empleado_x_Proyeccion_Gastos_Personales_Data
    {
        string mensaje = "";


        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> Get_List_empleado_x_Proyeccion_Gastos_Personales(int IdEmpresa, decimal IdEmpleado, int AnioFiscal) 
        {
        List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> lst = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
            try
            {
              
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from a in rol.vwRo_empleado_x_Proyeccion_Gastos_Personales
                                   where a.IdEmpresa==IdEmpresa
                                   && a.IdEmpleado == IdEmpleado
                                   && a.AnioFiscal==AnioFiscal
                                   select a;

                    foreach (var item in Consulta)
                    {
                        ro_empleado_x_Proyeccion_Gastos_Personales_Info info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoGasto = item.IdTipoGasto;
                        info.AnioFiscal = item.AnioFiscal;
                        info.Valor = item.Valor;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;
                        info.nom_tipo_gasto = item.nom_tipo_gasto;
                        info.Monto_max =(int) item.Monto_max;

                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }      
        }

        public ro_empleado_x_Proyeccion_Gastos_Personales_Info Get_Info_empleado_x_Proyeccion_Gastos_Personales(int IdEmpresa, decimal IdEmpleado, string IdTipoGasto, int AnioFiscal)
        {
            
            try
            {
                ro_empleado_x_Proyeccion_Gastos_Personales_Info info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    
                    var Query= from a in rol.ro_empleado_x_Proyeccion_Gastos_Personales
                                   where a.IdEmpresa == IdEmpresa
                                   && a.IdEmpleado == IdEmpleado
                                   && a.IdTipoGasto==IdTipoGasto
                                   && a.AnioFiscal==AnioFiscal
                                   select a;

                    foreach (var item in Query)
                    {
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoGasto = item.IdTipoGasto;
                        info.AnioFiscal = item.AnioFiscal;
                        info.Valor = item.Valor;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;
                    }
                       
                }
                return info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> Get_List_empleado_x_Proyeccion_Gastos_Personales(int IdEmpresa, int anioFiscal)
        {
            List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> lst = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
            try
            {                
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from a in rol.vwRo_empleado_x_Proyeccion_Gastos_Personales
                                   where a.IdEmpresa == IdEmpresa && a.AnioFiscal == anioFiscal
                                   select a;

                    foreach (var item in Consulta)
                    {
                        ro_empleado_x_Proyeccion_Gastos_Personales_Info info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdEmpleado = item.IdEmpleado;
                        info.IdTipoGasto = item.IdTipoGasto;
                        info.AnioFiscal = item.AnioFiscal;
                        info.Valor = item.Valor;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;
                        info.nom_tipo_gasto = item.nom_tipo_gasto;        

                        lst.Add(info);
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }        
        }

        public Boolean EliminarPGP(List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> InfoPGP) {
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    foreach (var item in InfoPGP)
                    {
                        ro_empleado_x_Proyeccion_Gastos_Personales pgpData = rol.ro_empleado_x_Proyeccion_Gastos_Personales.First(v => v.IdEmpresa==item.IdEmpresa && v.AnioFiscal == item.AnioFiscal);
                        rol.ro_empleado_x_Proyeccion_Gastos_Personales.Remove(pgpData);
                        rol.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GetExiste(ro_empleado_x_Proyeccion_Gastos_Personales_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_empleado_x_Proyeccion_Gastos_Personales
                                where a.IdEmpresa==info.IdEmpresa
                                && a.IdEmpleado==info.IdEmpleado
                                && a.IdTipoGasto==info.IdTipoGasto
                                && a.AnioFiscal==info.AnioFiscal
                                select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else { valorRetornar = false; }
                }
                return valorRetornar;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean GrabarBD(ro_empleado_x_Proyeccion_Gastos_Personales_Info info, ref string msg) {
            try
            {
             
                using (EntitiesRoles db = new EntitiesRoles())
                {
                   
                        ro_empleado_x_Proyeccion_Gastos_Personales item = new ro_empleado_x_Proyeccion_Gastos_Personales();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdTipoGasto = info.IdTipoGasto;
                        item.AnioFiscal = info.AnioFiscal;
                        item.Valor = info.Valor;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;
                      
                        db.ro_empleado_x_Proyeccion_Gastos_Personales.Add(item);
                        db.SaveChanges();
                    
                } 
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public Boolean ModificarBD(ro_empleado_x_Proyeccion_Gastos_Personales_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {

                    ro_empleado_x_Proyeccion_Gastos_Personales item = (from a in db.ro_empleado_x_Proyeccion_Gastos_Personales
                                                                       where a.IdEmpresa==info.IdEmpresa
                                                                       && a.IdEmpleado==info.IdEmpleado
                                                                       && a.IdTipoGasto == info.IdTipoGasto
                                                                       && a.AnioFiscal==info.AnioFiscal
                                                                       select a).FirstOrDefault();
                  
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdTipoGasto = info.IdTipoGasto;
                    item.AnioFiscal = info.AnioFiscal;
                    item.Valor = info.Valor;
                    //item.FechaIngresa = info.FechaIngresa;
                    //item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;

                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }

        public decimal Get_Proyeccion_Anual(int IdEmpresa, int IdEmpleado, int Anio_Fiscal)
        {
            try
            {
                decimal valor = 0;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_empleado_x_Proyeccion_Gastos_Personales
                                where a.IdEmpresa == IdEmpresa
                                && a.IdEmpleado == IdEmpleado
                                && a.AnioFiscal == Anio_Fiscal
                                select a);

                    if (datos.Count() > 0)
                    {
                        valor =(decimal) datos.Sum(v=>v.Valor);
                    }
                }

                return valor;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }


    }
}
