using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt029_Bus
    {
        XINV_Rpt029_Data Odata = new XINV_Rpt029_Data();

        public List<XINV_Rpt029_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin, DateTime fecha_corte, ref String MensajeError)
        {
            try
            {
                return Odata.consultar_data(IdEmpresa, IdBodega, IdBodegaFin, IdSucursal, IdSucursalFin,fecha_corte, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt029_Info>();
            }
        }

        public List<XINV_Rpt029_Info> Get_data(int IdEmpresa, int IdSucursal, List<int> lst_bod, Boolean Registro_Cero, DateTime Fecha_corte, ref String MensajeError)
        {
            try
            {
                return Odata.Get_data(IdEmpresa, IdSucursal, lst_bod, Registro_Cero, Fecha_corte, ref MensajeError);
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt029_Info>();
            }
        }

        public XINV_Rpt029_Bus()
        {

        }
    }
}
