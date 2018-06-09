using Core.Erp.Data.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.MobileSCI;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_usuario_x_bodega_Bus
    {
        tbl_usuario_x_bodega_Data odata = new tbl_usuario_x_bodega_Data();

        public List<tbl_usuario_x_bodega_Info> get_list(string IdUsuarioSCI, bool mostrar_no_asignados)
        {
            try
            {
                return odata.get_list(IdUsuarioSCI, mostrar_no_asignados);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
