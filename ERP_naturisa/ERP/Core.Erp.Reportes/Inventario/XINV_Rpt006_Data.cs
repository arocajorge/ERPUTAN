using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt006_Data
    {
        public List<XINV_Rpt006_Info> Obtener_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMoviInvenTipo) 
        {
            try
            {
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    var Data_Report = from q in conexion.vwINV_Rpt006
                                      where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal &&
                                            q.IdBodega == IdBodega && q.IdNumMovi == IdNumMovi &&
                                            q.IdMovi_inven_tipo == IdMoviInvenTipo
                                      select new XINV_Rpt006_Info()
                                      {
                                          IdEmpresa = q.IdEmpresa,
                                          IdSucursal = q.IdSucursal,
                                          IdBodega = q.IdBodega,
                                          IdNumMovi = q.IdNumMovi,
                                          signo = q.signo,
                                          IdMovi_inven_tipo = q.IdMovi_inven_tipo,
                                          CodMoviInven = q.CodMoviInven,
                                          IdProducto = q.IdProducto,
                                          pr_descripcion = q.pr_descripcion,
                                          pr_codigo = q.pr_codigo,
                                          dm_cantidad = q.dm_cantidad,
                                          dm_peso = q.dm_peso,
                                          dm_stock_actu = q.dm_stock_actu,
                                          dm_stock_ante = q.dm_stock_ante,
                                          IdUsuario = q.IdUsuario
                                      };
                    return Data_Report.ToList();
                }
            }
            catch (Exception)
            {

                return new List<XINV_Rpt006_Info>();
            }
        }
    }
}
