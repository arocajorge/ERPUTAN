using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_DistribucionDetDistribuido_Bus
    {
        ct_DistribucionDetDistribuido_Data odata = new ct_DistribucionDetDistribuido_Data();
        public List<ct_DistribucionDetDistribuido_Info> GetList(int IdEmpresa, decimal IdDistribucion)
        {
            return odata.GetList(IdEmpresa, IdDistribucion);
        }
    }
}
