using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion
{
    public class fa_factura_det_subcentro_Bus
    {
        fa_factura_det_subcentro_Data odata = new fa_factura_det_subcentro_Data();

        public List<fa_factura_det_subcentro_Info> GetList(int IdEmpresa,int IdSucursal,int IdBodega,decimal IdCbteVta)
        {
            try
            {
                return odata.GetList(IdEmpresa, IdSucursal, IdBodega, IdCbteVta);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
