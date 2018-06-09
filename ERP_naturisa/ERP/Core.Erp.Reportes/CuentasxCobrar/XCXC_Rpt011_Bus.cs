using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public class XCXC_Rpt011_Bus
    {
        XCXC_Rpt011_Data dataRpt = new XCXC_Rpt011_Data();

        public List<XCXC_Rpt011_Info> get_List_EstadoCtaResumido(int IdEmpresa, int IdSucursal, decimal IdClienteIni, decimal IdClienteFin, DateTime FechaCorte, int Idtipo_cliente)
        {
            try
            {
                return dataRpt.get_List_EstadoCtaResumido(IdEmpresa, IdSucursal, IdClienteIni, IdClienteFin, FechaCorte, Idtipo_cliente);
            }
            catch (Exception)
            {
                return new List<XCXC_Rpt011_Info>();
            }
        }



        public XCXC_Rpt011_Bus()
        {

        }
    }
}
