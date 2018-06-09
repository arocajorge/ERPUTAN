using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Facturacion
{
    public class fa_notaCreDeb_x_ct_cbtecble_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_notaCreDeb_x_ct_cbtecble_Data oData = new fa_notaCreDeb_x_ct_cbtecble_Data();

        public Boolean GuardarDB(fa_notaCreDeb_x_ct_cbtecble_Info info)
        {
            try
            {
                return oData.GuardarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_ct_cbtecble_Bus) };
            }
        }

        public fa_notaCreDeb_x_ct_cbtecble_Info Get_Info_fa_notaCreDeb_x_ct_cbtecble(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNota)
        {
            try
            {
                return oData.Get_Info_fa_notaCreDeb_x_ct_cbtecble( IdEmpresa, IdSucursal, IdBodega, IdNota);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_Info_fa_notaCreDeb_x_ct_cbtecble", ex.Message), ex) { EntityType = typeof(fa_notaCreDeb_x_ct_cbtecble_Bus) };
           
            }

        }
    }
}
