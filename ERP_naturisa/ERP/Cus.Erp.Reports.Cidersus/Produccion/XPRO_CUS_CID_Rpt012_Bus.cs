using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Cidersus.Produccion
{
    public class XPRO_CUS_CID_Rpt012_Bus
    {
        XPRO_CUS_CID_Rpt012_Data OCdata = new XPRO_CUS_CID_Rpt012_Data();


        public List<XPRO_CUS_CID_Rpt012_Info> consultar_data_x_Obra(int IdEmpresa, int IdSucursal, string CodObra)
        {
            try
            {
                return OCdata.consultar_data_x_Obra(IdEmpresa, IdSucursal, CodObra);
            }
            catch (Exception ex)
            {
                return new List<XPRO_CUS_CID_Rpt012_Info>();
            }
        }
        public List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info> Dimensiones_Elementos_Ensamblados(int IdEmpresa, int IdSucursal, string CodObra)
        {
            try
            {
                return OCdata.Dimensiones_Elementos_Ensamblados(IdEmpresa, IdSucursal, CodObra);
            }
            catch (Exception ex)
            {
                return new List<vwPRO_CUS_CID_Dimensiones_Elementos_Ensamblados_Info>();
            }
        }
    }
}
