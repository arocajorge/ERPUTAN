using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt001_Bus
    {
        XCXC_Rpt001_Data RptData = new XCXC_Rpt001_Data();

        public List<XCXC_Rpt001_Info> getDatosCobros(int IdEmpresa, int IdSucursal, DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                return RptData.getDatosCobros(IdEmpresa, IdSucursal, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                return new List<XCXC_Rpt001_Info>();
            }
        }

    }
}
