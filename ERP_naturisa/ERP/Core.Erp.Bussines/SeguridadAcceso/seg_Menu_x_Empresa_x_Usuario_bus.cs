using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;

namespace Core.Erp.Business.SeguridadAcceso
{
   public  class seg_Menu_x_Empresa_x_Usuario_bus
    {

        public seg_Menu_x_Empresa_x_Usuario_info Get_Info_Menu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario,string Name_Formunalrio, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_x_Usuario_data data = new seg_Menu_x_Empresa_x_Usuario_data();
                return data.Get_Info_Menu_x_Empresa_x_Usuario(idEmpresa, idUsuario, Name_Formunalrio, ref MensajeError);



            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new seg_Menu_x_Empresa_x_Usuario_info();
            }
        }

        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_x_Usuario_data data = new seg_Menu_x_Empresa_x_Usuario_data();
                return data.Get_List_DescripcionMenu_x_Empresa_x_Usuario(idEmpresa, idUsuario, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }

        public List<seg_Menu_x_Empresa_x_Usuario_info> Get_No_List_DescripcionMenu_x_Empresa_x_Usuario(int idEmpresa, string idUsuario, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_x_Usuario_info> returnValue = new List<seg_Menu_x_Empresa_x_Usuario_info>();
                seg_Menu_x_Empresa_x_Usuario_data data = new seg_Menu_x_Empresa_x_Usuario_data();
                returnValue = data.Get_No_List_DescripcionMenu_x_Empresa_x_Usuario(idEmpresa, idUsuario, ref MensajeError);
                return returnValue;             
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_x_Usuario_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_x_Usuario_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_x_Usuario_data data = new seg_Menu_x_Empresa_x_Usuario_data();
                bool grabo = data.GrabarDB(listaMenu_x_Empresa_Modificada, ref MensajeError);
                return grabo;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }
    }
}
