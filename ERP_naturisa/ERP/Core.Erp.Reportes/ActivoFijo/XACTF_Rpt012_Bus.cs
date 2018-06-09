using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt012_Bus
    {
        XACTF_Rpt012_Data Odata = new XACTF_Rpt012_Data();

        public List<XACTF_Rpt012_Info> Consultar_Data(int IdEmpresa, int IdActivoFijo, int IdCategoria, int IdSucursal, int IdDepartamento, DateTime FechaCorte, string IdUsuario, ref string mensaje)
        {
            try
            {
                return Odata.Consultar_Data(IdEmpresa, IdActivoFijo, IdCategoria, IdSucursal, IdDepartamento, FechaCorte,IdUsuario, ref mensaje);
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
