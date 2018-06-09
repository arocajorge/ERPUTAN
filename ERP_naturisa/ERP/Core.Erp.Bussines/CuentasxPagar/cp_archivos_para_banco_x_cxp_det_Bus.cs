using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar.Archivos_Pagos_Bancos;
namespace Core.Erp.Business.CuentasxPagar
{
  public  class cp_archivos_para_banco_x_cxp_det_Bus
    {

        string mensaje = "";

        cp_archivos_para_banco_x_cxp_det_Data data = new cp_archivos_para_banco_x_cxp_det_Data();
        public Boolean GuardaDB(List<cp_archivos_para_banco_x_cxp_det_Info> listaGrabar, ref string mensaje)
        {
            try
            {
               
                return data.GuardaDB(listaGrabar,ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardaDB", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_det_Bus) };
            }
        }



        public Boolean AnularDB(List<cp_archivos_para_banco_x_cxp_det_Info> listaAnular)
        {
            try
            {

                return data.AnularDB(listaAnular);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDB", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_det_Bus) };
            }
        }

        public bool Eliminar_Detalle(int IdEmpresa, decimal idArchivo, ref string mensaje)
        {
            try
            {


               return data.Eliminar_Detalle(IdEmpresa, idArchivo, ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Eliminar_Detalle", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_det_Bus) };
            }
        }


        public List<cp_archivos_para_banco_x_cxp_det_Info> Get_List_Pagos_x_Archivos(int IdEmpresa, int IdArchivo, ref string mensaje)
        {
            try
            {

                return data.Get_List_Pagos_x_Archivos(IdEmpresa,IdArchivo , ref mensaje);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Pagos_x_Archivos", ex.Message), ex) { EntityType = typeof(cp_archivos_para_banco_x_cxp_det_Bus) };
            }
        }


    }
}
