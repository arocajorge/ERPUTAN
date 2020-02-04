using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt002_Bus
    {
        XFAC_FJ_Rpt002_Data oData = new XFAC_FJ_Rpt002_Data();

        public List<XFAC_FJ_Rpt002_Info> Get_List_Liquidacion(int idEmpresa, decimal IdLiquidacion)
        {
            try
            {
                return oData.Get_List_Liquidacion(idEmpresa, IdLiquidacion);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);

            }
        }
    }
}
