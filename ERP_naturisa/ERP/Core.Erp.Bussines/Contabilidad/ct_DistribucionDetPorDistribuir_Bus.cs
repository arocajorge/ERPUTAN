using Core.Erp.Data.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Contabilidad
{
    public class ct_DistribucionDetPorDistribuir_Bus
    {
        ct_DistribucionDetPorDistribuir_Data oada = new ct_DistribucionDetPorDistribuir_Data();

        public List<ct_DistribucionDetPorDistribuir_Info> GetList(int IdEmpresa, decimal IdDistribucion)
        {
            return oada.GetList(IdEmpresa, IdDistribucion);
        }
    }
}
