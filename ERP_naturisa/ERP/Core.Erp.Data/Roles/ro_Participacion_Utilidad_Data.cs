/*CLASE: ro_Participacion_Utilidad_Data
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
    public class ro_Participacion_Utilidad_Data
    {
        private string mensaje = "";

        public List<ro_Participacion_Utilidad_Info> GetListGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                List<ro_Participacion_Utilidad_Info> oListado = new List<ro_Participacion_Utilidad_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_participacion_utilidad
                                 where a.IdEmpresa == idEmpresa                               
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Participacion_Utilidad_Info item = new ro_Participacion_Utilidad_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPeriodo = info.IdPeriodo;
                        item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                        item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                        item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.Observacion = info.Observacion;
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


        public ro_Participacion_Utilidad_Info GetInfoPorIdPeriodo(int idEmpresa, int idPeriodo, ref string msg)
        {
            try
            {
                ro_Participacion_Utilidad_Info item = new ro_Participacion_Utilidad_Info();
              
                using (EntitiesRoles db = new EntitiesRoles())
                {
                       ro_participacion_utilidad info = (from a in db.ro_participacion_utilidad
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdPeriodo == idPeriodo
                                 select a).FirstOrDefault();

                  
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdPeriodo = info.IdPeriodo;
                        item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                        item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                        item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                  
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


        public Boolean GetExiste(ro_Participacion_Utilidad_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_participacion_utilidad
                                where a.IdEmpresa == info.IdEmpresa
                                && a.IdPeriodo == info.IdPeriodo
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



        public Boolean GuardarBD(ro_Participacion_Utilidad_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad item = new ro_participacion_utilidad();
                    item.IdEmpresa = info.IdEmpresa;
                    item.IdPeriodo = info.IdPeriodo;
                    item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                    item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                    item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;

                    db.ro_participacion_utilidad.Add(item);
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



        public Boolean ModificarBD(ro_Participacion_Utilidad_Info info, ref string msg)
        {
            try
            {

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    ro_participacion_utilidad item = (from a in db.ro_participacion_utilidad
                                                          where a.IdEmpresa==info.IdEmpresa
                                                          && a.IdPeriodo==info.IdPeriodo
                                                          select a).FirstOrDefault();
               
                    item.UtilidadDerechoIndividual = info.UtilidadDerechoIndividual;
                    item.UtilidadCargaFamiliar = info.UtilidadCargaFamiliar;
                    item.LimiteDistribucionUtilidad = info.LimiteDistribucionUtilidad;
                    item.FechaIngresa = info.FechaIngresa;
                    item.UsuarioIngresa = info.UsuarioIngresa;

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
    }
}
