using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public  class XINV_FJ_Rpt003_Bus
    {
        XINV_FJ_Rpt003_Data Data = new XINV_FJ_Rpt003_Data();
        public List<XINV_FJ_Rpt003_Info> consultar_data(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin, string idCentro_costo, string idSubCentro_costo, DateTime FechaIni, DateTime FechaFin, ref String MensajeError)
        {
            try
            {
                return Data.consultar_data(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,idCentro_costo,idSubCentro_costo, FechaIni, FechaFin, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultar_data", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt003_Bus) };
            }
        }
    }
}
