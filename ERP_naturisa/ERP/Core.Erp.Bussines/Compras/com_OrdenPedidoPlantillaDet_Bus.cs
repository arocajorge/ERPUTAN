using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_OrdenPedidoPlantillaDet_Bus
    {
        com_OrdenPedidoPlantillaDet_Data odata = new com_OrdenPedidoPlantillaDet_Data();

        public List<com_OrdenPedidoPlantillaDet_Info> GetList(int IdEmpresa, decimal IdPlantilla)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdPlantilla);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
