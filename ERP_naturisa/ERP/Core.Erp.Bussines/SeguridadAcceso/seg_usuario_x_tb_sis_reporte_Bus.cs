using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Data.SeguridadAcceso;


namespace Core.Erp.Business.SeguridadAcceso
{
   public class seg_usuario_x_tb_sis_reporte_Bus
    {
       seg_usuario_x_tb_sis_reporte_Data Odata = new seg_usuario_x_tb_sis_reporte_Data();


        public List<seg_usuario_x_tb_sis_reporte_Info> Get_List_Menu(string IdUsuario)
        {
            try
            {
                return Odata.Get_List_Menu(IdUsuario);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }

        public seg_usuario_x_tb_sis_reporte_Info Get_Info_Menu(string IdUsuario, string CodReporte, ref string MensajeError)
        {
            
            try
            {

                return Odata.Get_Info_Menu(IdUsuario, CodReporte, ref MensajeError);
            }

            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }

        }

        
        public Boolean GrabarDB(seg_usuario_x_tb_sis_reporte_Info info, ref string MensajeError)
        {
            try
            {
                return Odata.GrabarDB(info, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }


        public Boolean GrabarDB(List<seg_usuario_x_tb_sis_reporte_Info> Listinfo, ref string MensajeError)
        {
            try
            {
                return Odata.GrabarDB(Listinfo, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }


        public Boolean EliminarDB(string IdUsuario, ref string MensajeError)
        {
            try
            {
                return Odata.EliminarDB(IdUsuario, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Menu", ex.Message), ex) { EntityType = typeof(seg_Menu_bus) };
            }
        }
        

    }
}
