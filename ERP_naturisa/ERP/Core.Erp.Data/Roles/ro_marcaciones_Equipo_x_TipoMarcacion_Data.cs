using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_marcaciones_Equipo_x_TipoMarcacion_Data
    {
        string mensaje = "";
        public List<ro_marcaciones_Equipo_x_TipoMarcacion_Info> Get_List_marcaciones_Equipo_x_TipoMarcacion(int id)
        {
            List<ro_marcaciones_Equipo_x_TipoMarcacion_Info> Lst = new List<ro_marcaciones_Equipo_x_TipoMarcacion_Info>();
            try
            {
                
                EntitiesRoles context = new EntitiesRoles();
                var Query = from q in context.vwro_marcaciones_Equipo_x_TipoMarcacion
                            where q.IdEquipoMar == id
                            select q;
                foreach (var item in Query)
                {
                    ro_marcaciones_Equipo_x_TipoMarcacion_Info Info = new ro_marcaciones_Equipo_x_TipoMarcacion_Info();
                    Info.IdEquipoMar = item.IdEquipoMar;
                    Info.IdTipoMarcaciones_sys = item.IdTipoMarcaciones_sys;
                    Info.IdTipoMarcaciones_Biometrico = item.IdTipoMarcaciones_Biometrico;
                    Lst.Add(Info);
                }
                return Lst;
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
       
        public Boolean GuardarDB(ro_marcaciones_Equipo_x_TipoMarcacion_Info Info)
        {
            try
            {
                EntitiesRoles Context = new EntitiesRoles();
                ro_marcaciones_Equipo_x_TipoMarcacion address = new ro_marcaciones_Equipo_x_TipoMarcacion();
                address.IdEquipoMar = Info.IdEquipoMar;
                address.IdTipoMarcaciones_sys = Info.IdTipoMarcaciones_sys;
                address.IdTipoMarcaciones_Biometrico = Info.IdTipoMarcaciones_Biometrico;
                Context.ro_marcaciones_Equipo_x_TipoMarcacion.Add(address);
                Context.SaveChanges();
            
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

        public Boolean ModificarDB(ro_marcaciones_Equipo_x_TipoMarcacion_Info Info)
        {
            try
            {
                EntitiesRoles Context = new EntitiesRoles();
                var contact = Context.ro_marcaciones_Equipo_x_TipoMarcacion.First(var => var.IdEquipoMar == Info.IdEquipoMar && var.IdTipoMarcaciones_sys == Info.IdTipoMarcaciones_sys);
                contact.IdTipoMarcaciones_Biometrico = Info.IdTipoMarcaciones_Biometrico;
                Context.SaveChanges();
                
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

        public Boolean ValidarExiste(int cod, string pIdTipoMarcaciones_sys)
        {
            try
            {
                EntitiesRoles context = new EntitiesRoles();

                var Existe = from q in context.ro_marcaciones_Equipo_x_TipoMarcacion
                             where q.IdEquipoMar == cod && q.IdTipoMarcaciones_sys == pIdTipoMarcaciones_sys
                             select q;

                if (Existe.ToList().Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

