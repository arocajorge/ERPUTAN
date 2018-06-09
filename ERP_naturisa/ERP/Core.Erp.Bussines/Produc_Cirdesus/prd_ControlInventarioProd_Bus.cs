using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Produc_Cirdesus
{
    public class prd_ControlInventarioProd_Bus
    {        
        ////////////////
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        prd_ControlInventarioProd_Data data = new prd_ControlInventarioProd_Data();

        public prd_ControlInventarioProd_Info TraerSaldo(int idempresa, int idsucursal, string idcentrocosto, int idOT, int idET)
        {
            try
            {
                return data.Get_Info_TraerSaldo(idempresa, idsucursal, idcentrocosto, idOT, idET);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerSaldo", ex.Message), ex) { EntityType = typeof(prd_ControlInventarioProd_Bus) };
                
            }


        }

    }
}
