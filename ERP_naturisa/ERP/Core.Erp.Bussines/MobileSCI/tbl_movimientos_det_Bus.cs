using Core.Erp.Data.MobileSCI;
using Core.Erp.Info.MobileSCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.MobileSCI
{
    public class tbl_movimientos_det_Bus
    {
        tbl_movimientos_det_Data odata = new tbl_movimientos_det_Data();
        public List<tbl_movimientos_det_Info> get_list(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public List<tbl_movimientos_det_Info> get_list_csv(int IdEmpresa, int IdSucursal, int IdBodega, DateTime Fecha_ini, DateTime Fecha_fin)
        {
            try
            {
                return odata.get_list_csv(IdEmpresa, IdSucursal, IdBodega, Fecha_ini, Fecha_fin);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Modificar_estado(List<tbl_movimientos_det_Info> Lista, string Estado)
        {
            try
            {
                return odata.Modificar_estado(Lista, Estado);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool Aprobar(int IdEmpresa, List<tbl_movimientos_det_Info> Lista)
        {
            try
            {
                return odata.Aprobar(IdEmpresa, Lista);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
