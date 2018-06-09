using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Roles;

namespace Core.Erp.Data.Roles
{
    public class ro_Salario_Digno_Data
    {
        private string mensaje = "";

        public List<ro_Salario_Digno_Info> GetListConsultaGeneral(int idEmpresa, ref string msg)
        {
            try
            {
                List<ro_Salario_Digno_Info> oListado = new List<ro_Salario_Digno_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_salario_digno
                                 where a.IdEmpresa == idEmpresa
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Salario_Digno_Info item = new ro_Salario_Digno_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;                      
                        item.IdPeriodo = info.IdPeriodo;
                        item.SueldoDigno = info.SueldoDigno;
                        item.Observacion = info.Observacion;
                        item.UtilidadRepartir = info.UtilidadRepartir;
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
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }




        public List<ro_Salario_Digno_Info> GetListConsultaPorNomina(int idEmpresa,int idNominaTipo, int idPeriodo,ref string msg)
        {
            try
            {
                List<ro_Salario_Digno_Info> oListado = new List<ro_Salario_Digno_Info>();

                using (EntitiesRoles db = new EntitiesRoles())
                {
                    var datos = (from a in db.ro_salario_digno
                                 where a.IdEmpresa == idEmpresa
                                 && a.IdNominaTipo == idNominaTipo
                                 && a.IdPeriodo==idPeriodo
                                 select a);

                    foreach (var info in datos)
                    {
                        ro_Salario_Digno_Info item = new ro_Salario_Digno_Info();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdPeriodo = info.IdPeriodo;
                        item.SueldoDigno = info.SueldoDigno;
                        item.Observacion = info.Observacion;
                        item.UtilidadRepartir = info.UtilidadRepartir;
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
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }


        public Boolean GetExiste(ro_Salario_Digno_Info info, ref string msg)
        {
            try
            {
                Boolean valorRetornar = false;
                using (EntitiesRoles db = new EntitiesRoles())
                {
                    int cont = (from a in db.ro_salario_digno
                                where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo
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


        public Boolean GuardarBD(ro_Salario_Digno_Info info, ref string msg)
        {
            try
            {
                using (EntitiesRoles db = new EntitiesRoles())
                {
                        ro_salario_digno item = new ro_salario_digno();
                        item.IdEmpresa = info.IdEmpresa;
                        item.IdNominaTipo = info.IdNominaTipo;
                        item.IdPeriodo = info.IdPeriodo;
                        item.SueldoDigno = info.SueldoDigno;
                        item.Observacion = info.Observacion;
                        item.UtilidadRepartir = info.UtilidadRepartir;
                        item.FechaIngresa = info.FechaIngresa;
                        item.UsuarioIngresa = info.UsuarioIngresa;
                        item.FechaModifica = info.FechaModifica;
                        item.UsuarioModifica = info.UsuarioModifica;

                        db.ro_salario_digno.Add(item);
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


        public Boolean ModificarBD(ro_Salario_Digno_Info info, ref string msg)
        {
            try
            {
                ro_salario_digno item = new ro_salario_digno();
                    
                using (EntitiesRoles db = new EntitiesRoles())
                {

                    item = (from a in db.ro_salario_digno
                            where a.IdEmpresa == info.IdEmpresa && a.IdNominaTipo == info.IdNominaTipo && a.IdPeriodo == info.IdPeriodo
                            select a).FirstOrDefault();

                    item.SueldoDigno = info.SueldoDigno;
                    item.Observacion = info.Observacion;
                    item.UtilidadRepartir = info.UtilidadRepartir;
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
