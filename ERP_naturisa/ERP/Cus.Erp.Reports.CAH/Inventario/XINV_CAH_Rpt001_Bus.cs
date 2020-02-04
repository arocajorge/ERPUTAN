using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.CAH.Inventario
{
    public class XINV_CAH_Rpt001_Bus
    {
        XINV_CAH_Rpt001_Data Odata = new XINV_CAH_Rpt001_Data();

        public List<XINV_CAH_Rpt001_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin, DateTime fecha_corte, ref String MensajeError)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdBodega, IdBodegaFin, IdSucursal, IdSucursalFin, fecha_corte, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_CAH_Rpt001_Info>();
            }
        }

        public List<XINV_CAH_Rpt001_Info> Get_data(int IdEmpresa, int IdSucursal, int IdBodega, string IdCategoria, int IdLinea, Boolean Registro_Cero, DateTime Fecha_corte, ref String MensajeError)
        {
            try
            {
                return Odata.Get_data(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Registro_Cero, Fecha_corte, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_CAH_Rpt001_Info>();
            }
        }

    }
}
