using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
   public class ro_empresa_x_TipoLiqui_data
   {
       string mensaje = "";
        List<ro_empresa_x_TipoLiqui_Info> lista = new List<ro_empresa_x_TipoLiqui_Info>();

        public Boolean GrabarDB(ro_empresa_x_TipoLiqui_Info ro_info, ref string mensaje)
        {
            try
            {
                int Secuencia;
                using (EntitiesRoles context = new EntitiesRoles())
                {

                    EntitiesRoles EDB = new EntitiesRoles();

                    Secuencia = GetSecuencia(ro_info.IdEmpresa);

                    ro_info.Secuencia = Secuencia;

                    var Q = from per in EDB.ro_empresa_x_TipoLiqui_Rol
                            where per.IdTipoLiqui_Rol == ro_info.IdTipoLiqui_Rol && per.IdEmpresa == ro_info.IdEmpresa
                            select per;

                        var address = new ro_empresa_x_TipoLiqui_Rol();

                        address.IdEmpresa = ro_info.IdEmpresa;
                        address.IdTipoLiqui_Rol = (ro_info.IdTipoLiqui_Rol + GetSecuencia(ro_info.IdEmpresa));
                        address.Secuencia = GetSecuencia(ro_info.IdEmpresa);
                        address.PorcSueldo = ro_info.PorcSueldo;

                        context.ro_empresa_x_TipoLiqui_Rol.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";
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

        public Boolean ModificarDB(ro_empresa_x_TipoLiqui_Info prI, ref string mensaje)
        {
            try
            {
                using (EntitiesRoles context = new EntitiesRoles())
                {
                    var contact = context.ro_empresa_x_TipoLiqui_Rol.First(VProdu => VProdu.IdEmpresa == prI.IdEmpresa && VProdu.IdTipoLiqui_Rol == prI.IdTipoLiqui_Rol && prI.Secuencia==VProdu.Secuencia);

                    contact.PorcSueldo = prI.PorcSueldo;
                    

                    context.SaveChanges();

                    mensaje = "Grabacion ok...";
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

        private int GetSecuencia(int IdEmpresa)
        {
            try
            {

                int Id;
                EntitiesRoles OECbtecble = new EntitiesRoles();



                var q = from C in OECbtecble.ro_empresa_x_TipoLiqui_Rol
                        where C.IdEmpresa == IdEmpresa
                        select C;
                if (q.ToList().Count == 0)
                    return 1;
                else
                {

                    var select_ = (from t in OECbtecble.ro_empresa_x_TipoLiqui_Rol
                                   where t.IdEmpresa == IdEmpresa
                                   select t.Secuencia).Max();
                    Id = Convert.ToInt32(select_.ToString()) + 1;
                    return Id;
                }
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

        public List<ro_empresa_x_TipoLiqui_Info> Get_List_empresa_x_TipoLiqui(int IdEmpresa)
        {
                List<ro_empresa_x_TipoLiqui_Info> lM = new List<ro_empresa_x_TipoLiqui_Info>();
                EntitiesRoles OERol_Empleado = new EntitiesRoles();
            try
            {
                return lM;
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
