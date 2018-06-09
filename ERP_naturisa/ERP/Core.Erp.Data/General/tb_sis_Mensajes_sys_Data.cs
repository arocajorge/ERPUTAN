using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_Mensajes_sys_Data
    {
        string mensaje = "";
        //CJimenez
        public string getId()
        {
            try
            {
                string Id = "";
                EntitiesGeneral context = new EntitiesGeneral();
                var select = from q in context.vwGe_tb_sis_Mensajes_sys_IdAuto_numeric
                             select q;
                foreach (var item in select)
                {
                    Id = "msj_"+item.IdMensaje;
                }

                return Id;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public List<tb_sis_Mensajes_sys_Info> Get_List_Mensajes_sys()
        {
            try
            {
                List<tb_sis_Mensajes_sys_Info> lst = new List<tb_sis_Mensajes_sys_Info>();

                EntitiesGeneral oEnti = new EntitiesGeneral();

                var tarjetas = from q in oEnti.tb_sis_Mensajes_sys
                               select q;

                foreach (var item in tarjetas)
                {
                    tb_sis_Mensajes_sys_Info info = new tb_sis_Mensajes_sys_Info();
                    info.IdMensaje = item.IdMensaje;
                    info.Mensaje_Esp = item.Mensaje_Esp;
                    info.Mensaje_Englesh = item.Mensaje_Englesh;
                    info.Estado = item.Estado;
                    lst.Add(info);
                }
                return lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        

        public Boolean Guardar(tb_sis_Mensajes_sys_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var sms = new tb_sis_Mensajes_sys();

                sms.IdMensaje = Info.IdMensaje;
                sms.Mensaje_Esp = Info.Mensaje_Esp;
                sms.Mensaje_Englesh = Info.Mensaje_Englesh;
                sms.Estado = Info.Estado;
                context.tb_sis_Mensajes_sys.Add(sms);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
        
        public Boolean Modificar(tb_sis_Mensajes_sys_Info Info)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var sms = context.tb_sis_Mensajes_sys.FirstOrDefault(var => var.IdMensaje == Info.IdMensaje);
                if (sms != null)
                {
                    sms.Mensaje_Esp = Info.Mensaje_Esp;
                    sms.Mensaje_Englesh = Info.Mensaje_Englesh;
                    sms.Estado = Info.Estado;
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarCodigoExiste(string Cod)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();

                var Existe = from q in context.tb_sis_Mensajes_sys
                             where q.IdMensaje == Cod
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
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
            
        }

        public Boolean Anular(string IdMensaje)
        {
            try
            {
                EntitiesGeneral context = new EntitiesGeneral();
                var tarjeta = context.tb_sis_Mensajes_sys.FirstOrDefault(var => var.IdMensaje == IdMensaje);
                if (tarjeta != null)
                {
                    tarjeta.Estado = "I";
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public Boolean ValidarMensaje(string IdMensaje, string Mensaje_Esp)
        {
            try
            {
                using (EntitiesGeneral context = new EntitiesGeneral())
                {

                    var Existe = from q in context.tb_sis_Mensajes_sys
                                 where q.Mensaje_Esp == Mensaje_Esp && q.IdMensaje == IdMensaje
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
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
