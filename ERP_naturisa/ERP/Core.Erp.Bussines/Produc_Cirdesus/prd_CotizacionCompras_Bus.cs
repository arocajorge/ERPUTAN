using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Produc_Cirdesus
{
   public class prd_CotizacionCompras_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_CotizacionCompras_Data data = new prd_CotizacionCompras_Data();

        public List<prd_CotizacionCompras_Info> ObtenerListaCotiza(int IdEmpresa)
        {
            try
            {
                return data.ObtenerListaCotizacion(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaCotizacion", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                
            }

        }

        public prd_CotizacionCompras_Info ObtenerUnaCotiza(int IdEmpresa, string CodObra)
        {
            try
            {
                return data.ObtenerUnaCotiza(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerUnaCotiza", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                
            }
        }

        public List<prd_CotizacionCompras_Info> ObtenerListaObraxPP(int IdEmpresa, ref string msg)
        {
            try
            {
                return data.ObtenerListaCotiza(IdEmpresa, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerListaObraxPP", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                
            }
        }

        public Boolean GuardarDB(prd_CotizacionCompras_Info info, ref string msg)
        {
            try
            {
                return data.GuardarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                

            }
        }
        public Boolean ModificarDB(prd_CotizacionCompras_Info info, ref string msg)
        {
            try
            {
                return data.ModificarDB(info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                
            }
        }
        public Boolean VerificarExisteCodigo(string CodCotiza)
        {
            try
            {
                return data.VerificarExisteCodigo(CodCotiza);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarExisteCodigo", ex.Message), ex) { EntityType = typeof(prd_CotizacionCompras_Bus) };
                
            }
        }


     
    }
}
