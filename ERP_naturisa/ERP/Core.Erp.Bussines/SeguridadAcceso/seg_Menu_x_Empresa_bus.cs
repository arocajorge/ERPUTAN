using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;

namespace Core.Erp.Business.SeguridadAcceso
{
   public  class seg_Menu_x_Empresa_bus
    {
        public List<seg_Menu_x_Empresa_info> Get_List_Menu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_info> returnValue = new seg_Menu_x_Empresa_data().Get_List_DescripcionMenu_x_Empresa(idEmpresa, ref MensajeError);
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public List<seg_Menu_x_Empresa_info> Get_No_List_DescripcionMenu_x_Empresa(int idEmpresa, ref string MensajeError)
        {
            try
            {
                List<seg_Menu_x_Empresa_info> returnValue = new seg_Menu_x_Empresa_data().Get_No_List_DescripcionMenu_x_Empresa(idEmpresa, ref MensajeError);
                return returnValue;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return new List<seg_Menu_x_Empresa_info>();
            }
        }

        public bool GrabarDB(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_Modificada, ref string MensajeError)
        {
            try
            {
                seg_Menu_x_Empresa_data data = new seg_Menu_x_Empresa_data();
                return data.GrabarDB(listaMenu_x_Empresa_Modificada, ref MensajeError);
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return false;
            }
        }

        public bool ExisteRelacion(List<seg_Menu_x_Empresa_info> listaMenu_x_Empresa_x_Modificar, ref string MensajeError)
        {
            try
            {
                bool existe = false;
                seg_Menu_x_Empresa_data data = new seg_Menu_x_Empresa_data();
                existe = data.ExisteRelacion(listaMenu_x_Empresa_x_Modificar, ref MensajeError);
                return existe;
            }
            catch (Exception ex)
            {
                MensajeError = ex.Message;
                return true;
            }
        }
    }
}
