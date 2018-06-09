using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ControlProduccionObrero_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ControlProduccionObrero_Data data = new prd_ControlProduccionObrero_Data();

        public List<prd_ControlProduccionObrero_Info> ObtenerCrtlPrdObreroCab(int idempresa, int IdGrupoT, DateTime Fi, DateTime Ff)
        {
            try
            {
                return data.Get_List_ControlProduccionObrero(idempresa,IdGrupoT,Fi,Ff);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerCrtlPrdObreroCab", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObrero_Bus) };
                
            }
        }
       
        public prd_ControlProduccionObrero_Info ObtenerGT(int idempresa, int idsucursal, decimal codGT, string c_costo, decimal codCPO)
        {
            try
            {
                return data.Get_Info_ControlProduccionObrero(idempresa, idsucursal, codGT, c_costo, codCPO );
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerGT", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObrero_Bus) };
                
            }
        }
        
        public Boolean GrabarCabeceraDB(int idempresa, prd_ControlProduccionObrero_Info info, List<prd_ControlProduccionObreroDetalle_Info> lmDetalleInfo, ref string msg, ref decimal idgenerada)
        {
            try
            {
                return data.GrabarDB(idempresa, info, lmDetalleInfo,ref msg,ref idgenerada);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarCabeceraDB", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObrero_Bus) };
                
            }
        }

        public Boolean ModificarDB(int idempresa, prd_ControlProduccionObrero_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(idempresa, info,ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObrero_Bus) };
                
            }
        }

        public Boolean AnularReactiva(int idempresa, prd_ControlProduccionObrero_Info info, ref string msg)
        {
            try
            {
                return data.AnularDB(idempresa, info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularReactiva", ex.Message), ex) { EntityType = typeof(prd_ControlProduccionObrero_Bus) };
                
            }
        }

    }
}
