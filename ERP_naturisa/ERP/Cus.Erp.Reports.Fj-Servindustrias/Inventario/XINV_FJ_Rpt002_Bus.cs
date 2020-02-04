using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Inventario
{
    class XINV_FJ_Rpt002_Bus
    {
        XINV_FJ_Rpt002_Data Odata = new XINV_FJ_Rpt002_Data();

        public List<XINV_FJ_Rpt002_Info> consultar_data(int IdEmpresa, int IdBodegaIni, int IdBodegaFin,  int IdSucursalIni, 
            int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin,  DateTime FechaIni, DateTime FechaFin
            ,string IdCentroCosto,string IdSubCentroCosto,
            ref String MensajeError)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin,
                    IdProductoIni, IdProductoFin, FechaIni, FechaFin, IdCentroCosto, IdSubCentroCosto, ref MensajeError);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultar_data", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt002_Bus) };
            }

        }



        public XINV_FJ_Rpt002_Bus()
        {

        }
    }
}
