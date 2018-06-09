using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.ActivoFijo
{
    public class XACTF_Rpt014_Bus
    {
        XACTF_Rpt014_Data oData = new XACTF_Rpt014_Data();

        public List<XACTF_Rpt014_Info> Consultar_Data(int IdEmpresa, int IdSucursal, int IdActijoFijoTipo, int IdCategoria, DateTime Fecha_corte, string IdUsuario, ref string mensaje)
        {
            try
            {
                return oData.Consultar_Data(IdEmpresa, IdSucursal, IdActijoFijoTipo, IdCategoria,Fecha_corte,IdUsuario, ref mensaje);
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
