using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_comprador_familia_Bus
    {
        com_comprador_familia_Data odata = new com_comprador_familia_Data();

        public List<com_comprador_familia_Info> GetList(int IdEmpresa, decimal IdComprador)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdComprador);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
