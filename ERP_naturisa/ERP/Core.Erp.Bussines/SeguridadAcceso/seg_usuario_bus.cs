using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using System.Security.Cryptography;


namespace Core.Erp.Business.SeguridadAcceso
{
    public class seg_usuario_bus
    {

        public List<seg_usuario_info> Get_List_Usuario(ref string MensajeError)
        {
            List<seg_usuario_info> lm = new List<seg_usuario_info>();
            seg_usuario_data data = new seg_usuario_data();
            try
            {
                lm = data.Get_List_Usuario(ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                //oLog.Log_Error(ex.ToString());
                MensajeError = "Error al Obtener Usuarios .." + ex.Message;

                return (lm);
            }
        }

        public List<seg_usuario_info> Get_List_Usuario_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            List<seg_usuario_info> lm = new List<seg_usuario_info>();
            seg_usuario_data data = new seg_usuario_data();
            try
            {
                lm = data.Get_List_Usuario_x_Empresa(idEmpresa, ref MensajeError);
                return (lm);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al Obtener Usuarios .." + ex.Message;
                return (lm);
            }
        }

        public seg_usuario_info Get_Info_Usuario(string IdUsuario, ref string MensajeError)
        {
            seg_usuario_info user_info = new seg_usuario_info();
            try
            {
                seg_usuario_data data = new seg_usuario_data();
               user_info= data.Get_Info_Usuario(IdUsuario, ref MensajeError);
                return (user_info);
            }
            catch (Exception ex)
            {

                return new seg_usuario_info();
            }
        }

        public Boolean Get_Estado_Usuario(string IdUsuario, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                return data.Get_Estado_Usuario(IdUsuario, ref MensajeError);
            }
            catch (Exception ex)
            {
                //oLog.Log_Error(ex.ToString());
                MensajeError = "Error al Status Usuario .." + ex.Message;

                return false;
            }


        }

        public Boolean Update_only_userData(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                return data.Update_only_user(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al Modificar .." + ex.Message;
                return false;
            }
        }

        public Boolean Update_usuario_referencias(seg_usuario_info user, List<tb_Empresa_Info> lEmpresa, ref string MensajeError)
        {
            try
            {
                return new seg_usuario_data().Update_usuario_referencias(user, lEmpresa, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean Existe_Usuario(string IdUsuario, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                return data.Existe_Usuario(IdUsuario, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public Boolean EliminarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                return data.EliminarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al Eliminar .." + ex.Message;
                return false;
            }
        }

        public Boolean Anular(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                return data.Anular(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al Eliminar .." + ex.Message;
                return false;
            }
        }

        public Boolean GrabarDB(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                info.Contrasena = GetMd5Hash(info.Contrasena);
                return data.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                //oLog.Log_Error(ex.ToString());
                MensajeError = "Error al Grabar .." + ex.Message;

                return false;
            }
        }
        public Boolean GrabarUser_x_Empresa(seg_usuario_info info, List<int> idEmpresas, ref string MensajeError)
        {
            try
            {
                info.Contrasena = GetMd5Hash(info.Contrasena);
                return new seg_usuario_data().GrabarUser_x_Empresa(info, idEmpresas, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
        public Boolean Validar_Credenciales(seg_usuario_info Info_Usuario, ref string MensajeError)
        {
            try
            {
                seg_usuario_data oUserD = new seg_usuario_data();

                Info_Usuario.Contrasena = GetMd5Hash(Info_Usuario.Contrasena);

                return (oUserD.Validar_Credenciales(Info_Usuario, ref MensajeError));
            }
            catch (Exception ex)
            {
                //oLog.Log_Error(ex.ToString());
                MensajeError = "Error al Validar Credenciales .." + ex.Message;
                return (false);
            }
        }


        public Boolean Validar_Directiva_Contrasena(seg_usuario_info Info_Usuario, ref string MensajeError)
        {
            try
            {
                seg_usuario_data oUserD = new seg_usuario_data();
                return (oUserD.Validar_Directiva_Contrasena(Info_Usuario, ref MensajeError));
            }
            catch (Exception ex)
            {
                //oLog.Log_Error(ex.ToString());
                MensajeError = "Error al Validar Credenciales .." + ex.Message;
                return (false);
            }
        }

        static string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
           
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public Boolean Actualizar_Password(seg_usuario_info info, ref string MensajeError)
        {
            try
            {
                seg_usuario_data data = new seg_usuario_data();
                info.Contrasena = GetMd5Hash(info.Contrasena);
                return data.Actualizar_Password(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al validar Actualizacion del password ... " + ex.Message;
                return false;
            }
        }

        public Boolean Validar_IngresoUsuarioXEmpresa(string IdLogin, int IdEmpresa, string clave, ref string MensajeError)
        {
            try
            {
                seg_usuario_data oUserD = new seg_usuario_data();
                clave = GetMd5Hash(clave);
                return oUserD.Validar_IngresoUsuarioXEmpresa(IdLogin, IdEmpresa, clave, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = "Error al Validar Ingreso .." + ex.Message;

                return false;
            }
        }

    }
}
