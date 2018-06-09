/*CLASE: ro_empleado_x_centro_costo_Data
 *CREADO POR: ALBERTO MENA
 *FECHA: 21-04-2015
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
    public class ro_empleado_x_centro_costo_Data
    {
        private string mensaje = "";

        public List<ro_empleado_x_centro_costo_Info> Get_List_CentroCosto_X_empleado(int IdEmpresa, decimal IdEmpleado, ref string msg)
        { 
        try {
             List<ro_empleado_x_centro_costo_Info> oListado = new List<ro_empleado_x_centro_costo_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_CentroCostoXEmpleado
                                 where a.IdEmpresa == IdEmpresa && a.IdEmpleado==IdEmpleado
                                 select a);


                    foreach (var info in datos)
                    {
                        ro_empleado_x_centro_costo_Info item = new ro_empleado_x_centro_costo_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;

                        item.Centro_costo = info.Centro_costo;

                        //item.FechaModifica = info.FechaModifica;
                        //item.UsuarioModifica = info.UsuarioModifica;
                        
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



        public List<ro_empleado_x_centro_costo_Info> Get_List_empleado_x_centro_costo(int IdEmpresa, ref string msg)
        {
            try
            {
                List<ro_empleado_x_centro_costo_Info> oListado = new List<ro_empleado_x_centro_costo_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.vwRo_CentroCostoXEmpresa
                                 where a.IdEmpresa == IdEmpresa 
                                 select a);


                    foreach (var info in datos)
                    {
                        ro_empleado_x_centro_costo_Info item = new ro_empleado_x_centro_costo_Info();
                        item.IdEmpresa = info.IdEmpresa;
                      //  item.IdEmpleado = info.IdEmpleado;
                        item.IdCentroCosto = info.IdCentroCostoPadre;
                        item.IdCentroCosto_sub_centro_costo = info.IdCentroCosto;
                        item.FechaIngresa = DateTime.Now;
                      //  item.UsuarioIngresa = info.UsuarioIngresa;

                        item.Centro_costo = info.Centro_costo;

                        //item.FechaModifica = info.FechaModifica;
                        //item.UsuarioModifica = info.UsuarioModifica;

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





        public Boolean GuardarBD(ro_empleado_x_centro_costo_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_empleado_x_centro_costo item = new ro_empleado_x_centro_costo();

                    item.IdEmpresa = info.IdEmpresa;
                    item.IdEmpleado = info.IdEmpleado;
                    item.IdCentroCosto = info.IdCentroCosto;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;
                    item.FechaModifica = info.FechaModifica;
                    item.UsuarioModifica = info.UsuarioModifica;

                    db.ro_empleado_x_centro_costo.Add(item);
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




        public Boolean EliminarBD(int idEmpresa, decimal idEmpleado, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    db.Database.ExecuteSqlCommand("delete from dbo.ro_empleado_x_centro_costo where IdEmpresa =" + idEmpresa.ToString()
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


        public Boolean GuardarBD(ro_empleado_x_centro_costo_Info info)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {


                    var datos = (from a in db.ro_empleado_x_centro_costo
                                 where a.IdEmpresa == info.IdEmpresa
                                 && a.IdEmpleado==info.IdEmpleado
                                 select a);

                    if (datos.Count() == 0)
                    {
                        ro_empleado_x_centro_costo item = new ro_empleado_x_centro_costo();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdEmpleado = info.IdEmpleado;
                        item.IdCentroCosto = info.IdCentroCosto;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;

                        db.ro_empleado_x_centro_costo.Add(item);
                        db.SaveChanges();
                    }
                    else
                    {
                        var contact = db.ro_empleado_x_centro_costo.First(obj => obj.IdEmpresa == info.IdEmpresa &&
                            obj.IdEmpleado == info.IdEmpleado);
                        if (contact != null)
                        {
                            contact.IdCentroCosto = info.IdCentroCosto;
                            contact.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                            db.SaveChanges();
                        }
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


    }
}
