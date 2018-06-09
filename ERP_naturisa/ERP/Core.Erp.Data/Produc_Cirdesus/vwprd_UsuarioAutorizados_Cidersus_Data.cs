using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//version 16:37 v1 13/09
namespace Core.Erp.Data.Produc_Cirdesus
{
    public class vwprd_UsuarioAutorizados_Cidersus_Data
    {
        string mensaje = "";
        public vwprd_UsuarioAutorizados_Cidersus_Info TraerUsuarioAutorizado(string IdLogin, string contrasena)
        {
            try
            {
                vwprd_UsuarioAutorizados_Cidersus_Info Info = new vwprd_UsuarioAutorizados_Cidersus_Info();
                EntitiesProduccion_Cidersus OeEnt = new EntitiesProduccion_Cidersus();
                var usuario = OeEnt.vwprd_UsuarioAutorizados_Cidersus.FirstOrDefault(A => A.IdLogin == IdLogin && A.Contrasena == contrasena);
                if (usuario != null)
                {
                    Info.Autoriza = usuario.Autoriza;
                    Info.estado = usuario.estado;
                    Info.IdPersona = Convert.ToDecimal(usuario.IdPersona);
                    Info.IdLogin = usuario.IdLogin;
                    Info.Contrasena = usuario.Contrasena;
                }
                return Info;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
