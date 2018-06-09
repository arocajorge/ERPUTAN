using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Core.Erp.Reportes.Facturacion
{
    public class XFAC_Rpt001_Bus
    {
        XFAC_Rpt001_Data dataReport = new XFAC_Rpt001_Data();

        public List<XFAC_Rpt001_Info> getDatosDocumentos(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, string IdTipoDocumento, DateTime fechaIni, DateTime fechaFin )
        {
            try
            {
                return dataReport.getDatosDocumentos(IdEmpresa, IdSucursalIni, IdSucursalFin, IdTipoDocumento, fechaIni, fechaFin);
            }
            catch (Exception ex)
            {
                return new List<XFAC_Rpt001_Info>();
            }

        }


        public XFAC_Rpt001_Bus()
        {

        }
    }
}
