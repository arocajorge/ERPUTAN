using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt009_Bus
    {
        XINV_Rpt009_Data Odata = new XINV_Rpt009_Data();

        public List<XINV_Rpt009_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin, DateTime fecha_corte,decimal IdProducto, ref String MensajeError)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdBodega, IdBodegaFin, IdSucursal, IdSucursalFin,fecha_corte,IdProducto, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt009_Info>();
            }
        }

        public List<XINV_Rpt009_Info> Get_data(int IdEmpresa, int IdSucursal, int IdBodega, string IdCategoria, int IdLinea, Boolean Registro_Cero, DateTime Fecha_corte, decimal IdProducto, ref String MensajeError)
        {
            try
            {
                return Odata.Get_data(IdEmpresa, IdSucursal, IdBodega, IdCategoria, IdLinea, Registro_Cero,Fecha_corte,IdProducto, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt009_Info>();
            }
        }

        public XINV_Rpt009_Bus()
        {

        }
    }
}
