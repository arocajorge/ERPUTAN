using Core.Erp.Data.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.MobileSCI;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_bodega_Bus
    {
        tbl_bodega_Data odata = new tbl_bodega_Data();
        public List<tbl_bodega_Info> get_list(int IdEmpresa, bool mostrar_no_asignados)
        {
            try
            {
                return odata.get_list(IdEmpresa, mostrar_no_asignados);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public bool eliminarDB(int IdEmpresa)
        {
            try
            {
                return odata.eliminarDB(IdEmpresa);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool guardarDB(List<tbl_bodega_Info> Lista)
        {
            try
            {
                return odata.guardarDB(Lista);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
