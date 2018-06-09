using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Data.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;


namespace Core.Erp.Business.CuentasxCobrar
{
   public class cxc_cobro_tipo_motivo_Bus
    {
       cxc_cobro_tipo_motivo_Data Odata = new cxc_cobro_tipo_motivo_Data();

        
        public List<cxc_cobro_tipo_motivo_Info> Get_List_cobro_tipo_motivo()
        {
            try
            {
                List<cxc_cobro_tipo_motivo_Info> lista = new List<cxc_cobro_tipo_motivo_Info>();
                lista=Odata.Get_List_cobro_tipo_motivo();
                return lista;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_Cobro_Tipo", ex.Message), ex) { EntityType = typeof(cxc_cobro_tipo_Bus) };
            }

        }
    

    }
}
