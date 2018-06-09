using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Compras
{
    public class XCOMP_Rpt007_Bus
    {
        XCOMP_Rpt007_Data Data = new XCOMP_Rpt007_Data();

        public List<XCOMP_Rpt007_Info> Get_Lista(int _IdEmpresa, int _IdSucursal, int _IdSucursalFin, DateTime FechaCorte, int _Alerta, int _AlertaFin)
        {
            try
            {
                return Data.Get_Lista(_IdEmpresa, _IdSucursal, _IdSucursalFin, FechaCorte, _Alerta, _AlertaFin);
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
