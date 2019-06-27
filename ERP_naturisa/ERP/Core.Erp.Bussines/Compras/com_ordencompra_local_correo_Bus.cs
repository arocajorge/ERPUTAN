using Core.Erp.Data.Compras;
using Core.Erp.Info.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Compras
{
    public class com_ordencompra_local_correo_Bus
    {
        com_ordencompra_local_correo_Data odata = new com_ordencompra_local_correo_Data();

        public com_ordencompra_local_correo_Info GetOC()
        {
            try
            {
                return odata.GetOC();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Modificar(com_ordencompra_local_correo_Info info)
        {
            try
            {
                return odata.Modificar(info);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
