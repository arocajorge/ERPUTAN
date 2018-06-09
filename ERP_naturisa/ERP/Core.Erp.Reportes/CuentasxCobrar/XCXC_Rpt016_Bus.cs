using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.CuentasxCobrar
{
   public class XCXC_Rpt016_Bus
    {
       XCXC_Rpt016_Data Odata = new XCXC_Rpt016_Data();

       public List<XCXC_Rpt016_Info> Get_Data_Reporte(int IdEmpresa, int IdSucursal, int IdBodega_Cbte, decimal IdCbte_vta_nota, string CodDocumentoTipo)
       {
           try
           {
               return Odata.Get_Data_Reporte(IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, CodDocumentoTipo);
           }
           catch (Exception ex)
           {
               tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
               oLog.Log_Error(ex.ToString());
               throw new Exception(ex.ToString());

           }

       }
    }
}
