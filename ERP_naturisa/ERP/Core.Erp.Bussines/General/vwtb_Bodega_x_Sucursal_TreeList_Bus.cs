using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Business.General
{
    public class vwtb_Bodega_x_Sucursal_TreeList_Bus
    {
        vwtb_Bodega_x_Sucursal_TreeList_Data dataInfo = new vwtb_Bodega_x_Sucursal_TreeList_Data();

        public List<vwtb_Bodega_x_Sucursal_TreeList_Info> Get_List_Bodega_x_Sucursal(int IdEmpresa)
        {
            try
            {
                return dataInfo.Get_List_Bodega_x_Sucursal(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "get_Bodega_x_Sucursal", ex.Message), ex) { EntityType = typeof(vwtb_Bodega_x_Sucursal_TreeList_Bus) };
           
            }
        }


        public vwtb_Bodega_x_Sucursal_TreeList_Bus()
        {

        }
    }
}
