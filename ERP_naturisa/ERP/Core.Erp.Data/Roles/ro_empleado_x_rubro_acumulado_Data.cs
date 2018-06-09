/*CLASE: ro_empleado_x_rubro_acumulado_Data
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
    public  class ro_empleado_x_rubro_acumulado_Data
    {

        private string mensaje = "";

        public List<ro_empleado_x_rubro_acumulado_Info> Get_List_empleado_x_rubro_acumulado(int IdEmpresa, decimal IdEmpleado)
        {
            try
            {
                List<ro_empleado_x_rubro_acumulado_Info> oListado = new List<ro_empleado_x_rubro_acumulado_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_empleado_x_rubro_acumulado
                                 where a.IdEmpresa == IdEmpresa && a.IdEmpleado==IdEmpleado
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_empleado_x_rubro_acumulado_Info item = new ro_empleado_x_rubro_acumulado_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdRubro = info.IdRubro;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;

                        oListado.Add(item);
                    }
                }
                return oListado;
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


        public Boolean GrabarBD(ro_empleado_x_rubro_acumulado_Info info, ref string msg)
        { 
            try{
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_empleado_x_rubro_acumulado item = new ro_empleado_x_rubro_acumulado();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdRubro = info.IdRubro;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;
                    item.Fec_Inicio_Acumulacion = info.Fec_Inicio_Acumulacion;
                    item.Fec_Fin_Acumulacion = info.Fec_Fin_Acumulacion;
                    db.ro_empleado_x_rubro_acumulado.Add(item);
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

              public Boolean EliminarBD(ro_empleado_x_rubro_acumulado_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles()){
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_rubro_acumulado where IdEmpresa =" +info.IdEmpresa.ToString()
                                            + " AND IdEmpleado=" + info.IdEmpleado.ToString()
                                            + " AND IdRubro=" + info.IdRubro.ToString()
                                            );
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


              public Boolean EliminarBD(int idEmpresa,decimal idEmpleado, ref string msg)
              {
                  try
                  {
                      using (EntitiesRoles db = new EntitiesRoles())
                      {
                          db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_rubro_acumulado where IdEmpresa =" + idEmpresa.ToString()
                                                  + " AND IdEmpleado=" + idEmpleado.ToString()
                                                 );
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
    }
}
