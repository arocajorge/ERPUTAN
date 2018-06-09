using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Business.General
{
    public class tb_sis_Mensajes_sys_Bus
    {
        string mensaje = "";
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        tb_sis_Mensajes_sys_Data CD = new tb_sis_Mensajes_sys_Data();


        public List<tb_sis_Mensajes_sys_Info> Get_List_sis_Mensajes_sys()
        {
            try
            {
                return CD.Get_List_Mensajes_sys(); 
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ListaMensaje", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }

        public Boolean GuardarDB(tb_sis_Mensajes_sys_Info Info)
        {
            try
            { 
                return CD.Guardar(Info); 
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }

       



        public Boolean CompararEnum_vs_DB()
        {
            try
            {
                List<tb_sis_Mensajes_sys_Info> ListInfo = new List<tb_sis_Mensajes_sys_Info>();
                tb_sis_Mensajes_sys_Bus BusMsj= new tb_sis_Mensajes_sys_Bus();

                ListInfo = BusMsj.Get_List_sis_Mensajes_sys();

                foreach (var item_enum_msg in Enum.GetNames(typeof(enum_Mensajes_sys) ))
                {
                    var Existe= ListInfo.FirstOrDefault(v => v.IdMensaje == item_enum_msg);

                    if (Existe == null)//no existe en base hay q insertarlo
                    { 
                        tb_sis_Mensajes_sys_Info InfoMsg_a_Guardar= new tb_sis_Mensajes_sys_Info();

                        InfoMsg_a_Guardar.IdMensaje = item_enum_msg;
                        InfoMsg_a_Guardar.Mensaje_Esp = item_enum_msg;
                        InfoMsg_a_Guardar.Mensaje_Englesh = "";
                        InfoMsg_a_Guardar.Estado = "A";
                        BusMsj.GuardarDB(InfoMsg_a_Guardar);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };

            }
        }

        public Boolean ValidarCodigoExiste(string cod)
        {
            try 
            {
                return CD.ValidarCodigoExiste(cod);
            }
            catch (Exception ex) 
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarCodigoExiste", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }

        public Boolean ModificarDB(tb_sis_Mensajes_sys_Info Info)
        {
            try 
            { 
                return CD.Modificar(Info); 
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Modificar", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }

        public Boolean AnularDB(string IdMensaje )
        {
            try
            { 
                return CD.Anular(IdMensaje);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }

        public Boolean ValidarDescripcion(string IdMensaje, string Mensaje_Esp)
        {
            try 
            { 
                return CD.ValidarMensaje(IdMensaje, Mensaje_Esp);
            }
            catch (Exception ex) 
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ValidarDescripcion", ex.Message), ex) { EntityType = typeof(tb_sis_Mensajes_sys_Bus) };
         
            }
        }
    }
}
