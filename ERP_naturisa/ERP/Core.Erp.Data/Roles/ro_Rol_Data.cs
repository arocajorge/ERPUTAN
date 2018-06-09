/*CLASE: ro_Rol_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 *
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles
{


    public class ro_Rol_Data
    {
        private string mensaje = "";

        public List<ro_Rol_Info> GetListConsultaGeneral(int idEmpresa, ref string msg) {
            try {
                List<ro_Rol_Info> oListado = new List<ro_Rol_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos =(from a in db.ro_rol
                                where a.IdEmpresa==idEmpresa
                                select a);

                    foreach(var info in datos ){
                        ro_Rol_Info item = new ro_Rol_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.Descripcion = info.Descripcion;
                        item.Observacion = info.Observacion;
                        item.Cerrado = info.Cerrado;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;
                        item.FechaAnula = info.FechaAnula;
                        item.UsuarioAnula = info.UsuarioAnula;
                        item.MotivoAnula = info.MotivoAnula;
                        item.UsuarioCierre = info.UsuarioCierre;
                        item.FechaCierre = info.FechaCierre;

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

        public ro_Rol_Info GetInfoConsultaPorRol(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui,int idPeriodo, ref string msg)
        {
            try
            {
               
                ro_Rol_Info item = new ro_Rol_Info();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var Query = (from a in db.ro_rol
                                 where a.IdEmpresa == idEmpresa && a.IdNominaTipo==idNominaTipo 
                                 && a.IdNominaTipoLiqui==idNominaTipoLiqui
                                 && a.IdPeriodo==idPeriodo
                                 select a);
                    foreach (var info in Query)
                    {
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                        item.IdPeriodo = info.IdPeriodo;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.Descripcion = info.Descripcion;
                        item.Observacion = info.Observacion;
                        item.Cerrado = info.Cerrado;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;
                        item.FechaAnula = info.FechaAnula;
                        item.UsuarioAnula = info.UsuarioAnula;
                        item.MotivoAnula = info.MotivoAnula;
                        item.UsuarioCierre = info.UsuarioCierre;
                        item.FechaCierre = info.FechaCierre;
                        break;
                    }
                        
                    
                }
                return item;
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



        public Boolean GetExiste(ro_Rol_Info info, ref string msg)
        {
            try {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles()){
                    int cont = (from a in db.ro_rol
                                   where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
                                   && a.IdNominaTipoLiqui == info.IdNominaTipoLiqui && a.IdPeriodo == info.IdPeriodo
                                   select a).Count();

                    if (cont > 0) { valorRetornar = true; }
                    else{valorRetornar=false;}
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
            


        public Boolean GuardarBD(ro_Rol_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol item = new ro_rol();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdNominaTipo = info.IdNominaTipo;
                    item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdCentroCosto = info.IdCentroCosto;
                    item.Descripcion = info.Descripcion;
                    item.Observacion = info.Observacion;
                    item.Cerrado = info.Cerrado;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;
                    item.FechaAnula = info.FechaAnula;
                    item.UsuarioAnula = info.UsuarioAnula;
                    item.MotivoAnula = info.MotivoAnula;
                    item.UsuarioCierre = info.UsuarioCierre;
                    item.FechaCierre = info.FechaCierre;

                    db.ro_rol.Add(item);
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

        public Boolean ModificarBD(ro_Rol_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_rol item = (from a in db.ro_rol
                                    where a.IdEmpresa==info.IdEmpresa && a.IdNominaTipo==info.IdNominaTipo 
                                    && a.IdNominaTipoLiqui==info.IdNominaTipoLiqui && a.IdPeriodo==info.IdPeriodo 
                                    select a).FirstOrDefault();
                    
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdNominaTipo = info.IdNominaTipo;
                    item.IdNominaTipoLiqui = info.IdNominaTipoLiqui;
                    item.IdPeriodo = info.IdPeriodo;
                    item.IdCentroCosto = info.IdCentroCosto;
                    item.Descripcion = info.Descripcion;
                    item.Observacion = info.Observacion;
                    //item.Cerrado = info.Cerrado;
                    //item.FechaIngresa = info.FechaIngresa;
                    // item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;
                    item.FechaAnula = info.FechaAnula;
                    item.UsuarioAnula = info.UsuarioAnula;
                    item.MotivoAnula = info.MotivoAnula;
                    item.UsuarioCierre = info.UsuarioCierre;
                    item.FechaCierre = info.FechaCierre;

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
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_Ing_Egre_x_Empleado where IdEmpresa =" + idEmpresa.ToString()
                       + " AND IdNomina_Tipo=" + idNomina.ToString()
                       + " AND IdNomina_TipoLiqui=" + idNominaLiqui.ToString()
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
    }
}
