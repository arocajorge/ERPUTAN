using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_ProvisionIngresosPorOCDet_Bus
    {
        in_ProvisionIngresosPorOCDet_Data odata = new in_ProvisionIngresosPorOCDet_Data();

        public List<in_ProvisionIngresosPorOCDet_Info> GetList(int IdEmpresa, decimal IdProvision)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdProvision);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<in_ProvisionIngresosPorOCDet_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return odata.GetList(IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
