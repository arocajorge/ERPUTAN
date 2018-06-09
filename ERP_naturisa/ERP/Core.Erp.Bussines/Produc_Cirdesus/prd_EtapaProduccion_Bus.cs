using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_EtapaProduccion_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        public List<prd_EtapaProduccion_Info> ObtenerListaEtapas(int idempresa, int idProcesoProductivo)
        {
            try
            {

                List<prd_EtapaProduccion_Info> lM = new List<prd_EtapaProduccion_Info>();
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                lM = data.ObtenerListaEtapas(idempresa, idProcesoProductivo);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "prd_EtapaProduccion_Bus", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }
        }

        public List<prd_EtapaProduccion_Info> ObtenerListaEtapas(int idempresa)
        {
            try
            {

                List<prd_EtapaProduccion_Info> lM = new List<prd_EtapaProduccion_Info>();
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                lM = data.ObtenerListaEtapas(idempresa);
                return (lM);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaEtapas", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }
        }

        public Boolean GrabarListaEtapas(List<prd_EtapaProduccion_Info> ListInfo, int IdEmpresa, int IdModeloProductivo, ref string msg)
        {
            try
            {
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                return data.GrabarListaEtapas(ListInfo, IdEmpresa, IdModeloProductivo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarListaEtapas", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }
        }

        public Boolean eliminarLisEtapas(List<prd_EtapaProduccion_Info> ListInfo, int IdEmpresa, int IdModeloProductivo, ref string msg)
        {
            try
            {
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                return data.eliminarLisEtapas(ListInfo, IdEmpresa, IdModeloProductivo, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "eliminarLisEtapas", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }
        }
       
        public prd_EtapaProduccion_Info ObtenerEtapa(int IdEmpresa, int IdEtapa, int IdProcesoProductivo)
        {
            try
            {
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                return data.ObtenerEtapa(IdEmpresa, IdEtapa, IdProcesoProductivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEtapa", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }

        }


        public prd_EtapaProduccion_Info ObtenerEtapaAnterior(int IdEmpresa, int IdPosicion, int IdProcesoProductivo)
        {
            try
            {
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                return data.ObtenerEtapaAnterior(IdEmpresa, IdPosicion, IdProcesoProductivo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEtapaAnterior", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }

        }

        public List<prd_EtapaProduccion_Info> EtapaMaxObra(string CodObra, ref string msg)
        {
            try
            {
                prd_EtapaProduccion_Data data = new prd_EtapaProduccion_Data();
                return data.EtapaMaxObra(CodObra, ref   msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerEtapaAnterior", ex.Message), ex) { EntityType = typeof(prd_EtapaProduccion_Bus) };
                
            }

        }
    }
}
