using Core.Erp.Data.Inventario;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Inventario
{
    public class in_ProvisionIngresosPorOC_Bus
    {
        in_ProvisionIngresosPorOC_Data odata = new in_ProvisionIngresosPorOC_Data();

        public List<in_ProvisionIngresosPorOC_Info> GetList(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
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

        public in_ProvisionIngresosPorOC_Info GetInfo(int IdEmpresa, decimal IdProvision)
        {
            try
            {
                return odata.GetInfo(IdEmpresa, IdProvision);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool GuardarDB(in_ProvisionIngresosPorOC_Info info)
        {
            try
            {
                return odata.GuardarDB(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
