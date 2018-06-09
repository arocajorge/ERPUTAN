using Core.Erp.Data.MobileSCI;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_producto_Bus
    {
        tbl_producto_Data odata = new tbl_producto_Data();
        public List<tbl_producto_Info> get_list(int IdEmpresa, bool mostrar_no_asignados)
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

        public bool guardarDB(List<tbl_producto_Info> Lista)
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
