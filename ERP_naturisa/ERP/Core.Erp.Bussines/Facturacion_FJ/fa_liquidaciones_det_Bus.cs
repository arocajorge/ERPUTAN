using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Facturacion_Fj;
namespace Core.Erp.Business.Facturacion_FJ
{
  public  class fa_liquidaciones_det_Bus
    {
      fa_liquidaciones_det_Data data = new fa_liquidaciones_det_Data();
        public bool GuardarDB(List<fa_liquidaciones_det_Info> lista)
        {
            try
            {
                return data.GuardarDB(lista);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_det_Bus) };
  
               
            }
        }



        public bool EliminarDB(int IdEmpresa, int IdLiquidaciones)
        {
            try
            {
                return data.EliminarDB(IdEmpresa, IdLiquidaciones);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_liquidaciones_det_Bus) };
  
               
            }
        }
    }
}
