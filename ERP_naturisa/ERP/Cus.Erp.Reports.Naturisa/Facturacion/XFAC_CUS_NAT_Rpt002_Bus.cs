using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.Facturacion
{
    public class XFAC_CUS_NAT_Rpt002_Bus
    {
        XFAC_CUS_NAT_Rpt002_Data datRpt = new XFAC_CUS_NAT_Rpt002_Data();

        public List<XFAC_CUS_NAT_Rpt002_Info> get_List_Facturas_x_Motivo(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, decimal IdClienteIni, decimal IdClienteFin, int IdMotivo_VtaIni, int IdMotivo_VtaFin, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return datRpt.get_List_Facturas_x_Motivo(IdEmpresa, IdSucursalIni, IdSucursalFin, IdClienteIni, IdClienteFin, IdMotivo_VtaIni, IdMotivo_VtaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_List_Facturas_x_Motivo", ex.Message), ex) { EntityType = typeof(XFAC_CUS_NAT_Rpt002_Bus) };
            }
        }


        public XFAC_CUS_NAT_Rpt002_Bus()
        {

        }
    }
}
