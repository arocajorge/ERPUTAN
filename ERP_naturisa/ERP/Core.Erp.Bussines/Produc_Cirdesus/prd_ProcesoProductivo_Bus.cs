using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ProcesoProductivo_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ProcesoProductivo_Data data = new prd_ProcesoProductivo_Data();

        public List<prd_ProcesoProductivo_Info> ObtenerProcesProductivo(int idempresa)
        {
            try
            {//
                return data.ObtenerProcesProductivo(idempresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProcesProductivo", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
               
            }
        }


        public List<prd_ProcesoProductivo_Info> ObtenerProcesProductivo(int idempresa, int IdProcesProductivo)
        {
            try
            {
                return data.ObtenerProcesProductivo(idempresa, IdProcesProductivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerProcesProductivo", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
               
            }
        }



        public Boolean GrabarItem(prd_ProcesoProductivo_Info info, ref int idpp, ref string msg)
        {
            try
            {
                return data.GrabarItem(info, ref idpp, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarItem", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
               
            }
        }

        public Boolean GrabarModelo_x_Obra(prd_ProcesoProductivo_Info infoMP, prd_Obra_Info InfoOBra)
        {
            try
            {
                return data.GrabarModelo_x_Obra(infoMP, InfoOBra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarModelo_x_Obra", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
               
            }
        }

        public Boolean ModificarItem(prd_ProcesoProductivo_Info info, ref string msg)
        {
            try
            {
                return data.ModificarItem(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarItem", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
              
            }
        }

        public Boolean AnularItem(prd_ProcesoProductivo_Info info, ref string msg)
        {
            try
            {
                return data.AnularItem(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularItem", ex.Message), ex) { EntityType = typeof(prd_ProcesoProductivo_Bus) };
              
            }
        }
    }
}
