/*CLASE: ro_nomina_tipo_liqui_orden_Data
 *CREADA POR: ALBERTO MENA
 *FECHA: 17-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
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
    public class ro_nomina_tipo_liqui_orden_Data
    {
        string mensaje = "";

        public List<ro_nomina_tipo_liqui_orden_Info> Get_List_nomina_tipo_liqui_orden(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, ref string msg)
        {
            List<ro_nomina_tipo_liqui_orden_Info> listado = new List<ro_nomina_tipo_liqui_orden_Info>();

            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
   //                 var datos = (from a in db.ro_nomina_tipo_liqui_orden
                    var datos = (from a in db.vwRo_NominaTipoLiquiOrdenXRubro
                                 where a.IdEmpresa == idEmpresa && a.IdNominaTipo == idNominaTipo && a.IdNominaTipoLiqui == idNominaTipoLiqui
                                 orderby a.Orden ascending
                                 select a);

                    foreach (var item in datos)
                    {
                        ro_nomina_tipo_liqui_orden_Info info = new ro_nomina_tipo_liqui_orden_Info();

                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.Orden = item.Orden;
                        info.IdRubro = item.IdRubro;
                        info.Descripcion = item.Descripcion;
                        info.Formula = item.Formula;
                        info.EsVisible = item.EsVisible;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;

                        //DATOS DE LA VISTA
                        info.ru_codRolGen = item.ru_codRolGen;
                        info.ru_descripcion = item.ru_descripcion;
                        info.ru_tipo = item.ru_tipo;
                        info.ru_estado = item.ru_estado;
                        info.rub_concep = item.rub_concep;
                        info.rub_tipcal = item.rub_tipcal;
                        info.rub_formul = item.rub_formul;
                        info.rub_valfij = item.rub_valfij;
                        info.rub_guarda_rol = item.rub_guarda_rol;

                        listado.Add(info);
                    }

                }

                return listado;
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

        public Boolean GrabarDB(ro_nomina_tipo_liqui_orden_Info item, ref string msg)
        {
            try
            {
                ro_nomina_tipo_liqui_orden info = new ro_nomina_tipo_liqui_orden();
                
                using(EntitiesRoles db =new EntitiesRoles()){

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdNominaTipo = item.IdNominaTipo;
                    info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                    info.Orden = item.Orden;
                    info.IdRubro = item.IdRubro;
                    info.Descripcion = item.Descripcion;
                    info.Formula = item.Formula;
                    info.EsVisible = item.EsVisible;
                    info.FechaIngresa = item.FechaIngresa;
                    info.UsuarioIngresa = item.UsuarioIngresa;
                    info.FechaModifica = item.FechaModifica;
                    info.UsuarioModifica = item.UsuarioModifica;

                    db.ro_nomina_tipo_liqui_orden.Add(info);
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


        public Boolean ModificarDB(ro_nomina_tipo_liqui_orden_Info item, ref string msg)
        {
            try
            {
               using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_nomina_tipo_liqui_orden info = (from a in db.ro_nomina_tipo_liqui_orden
                                                         where a.IdEmpresa == item.IdEmpresa
                                                         && a.IdNominaTipo == item.IdNominaTipo
                                                         && a.IdNominaTipoLiqui == item.IdNominaTipoLiqui
                                                         && a.Orden == item.Orden
                                                         select a).FirstOrDefault();
                   
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdNominaTipo = item.IdNominaTipo;
                        info.IdNominaTipoLiqui = item.IdNominaTipoLiqui;
                        info.Orden = item.Orden;
                        info.IdRubro = item.IdRubro;
                        info.Descripcion = item.Descripcion;
                        info.Formula = item.Formula;
                        info.EsVisible = item.EsVisible;
                        info.FechaIngresa = item.FechaIngresa;
                        info.UsuarioIngresa = item.UsuarioIngresa;
                        info.FechaModifica = item.FechaModifica;
                        info.UsuarioModifica = item.UsuarioModifica;

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


        public Boolean EliminarDB(int idEmpresa,int idNominaTipo,int idNominaTipoLiqui)
            {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var S = context.Database.ExecuteSqlCommand("Delete from dbo.ro_nomina_tipo_liqui_orden where IdEmpresa =" + idEmpresa.ToString() + "AND IdNominaTipo=" + idNominaTipo.ToString() + "AND IdNominaTipoLiqui=" + idNominaTipoLiqui.ToString() );

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
