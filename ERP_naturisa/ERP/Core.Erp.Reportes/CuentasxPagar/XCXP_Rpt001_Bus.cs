using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.CuentasxPagar
{
    public class XCXP_Rpt001_Bus
    {
        XCXP_Rpt001_Data estadodata = new XCXP_Rpt001_Data();


        public List<XCXP_Rpt001_Info> consultar_data
            (int IdEmpresa, Decimal IdProveedor, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin, eFiltro_Estado_Pago TipoPago,
           eFiltro_Mostrar_Pagos MostrarPago, ref String mensaje)
        {
            try
            {
                return estadodata.consultar_data(IdEmpresa, IdProveedor
                    , co_fechaOg_Ini, co_fechaOg_Fin, TipoPago, MostrarPago, ref  mensaje);

            }
            catch (Exception ex)
            {

                return new List<XCXP_Rpt001_Info>();
            }
        }

        public XCXP_Rpt001_Bus()
        {
        }
    }
}
