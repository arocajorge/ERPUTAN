using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt022_Data
    {
        public List<XINV_Rpt022_Info> Get_List(int IdEmpresa, decimal IdDev_Inven, ref string msg)
        {
            List<XINV_Rpt022_Info> Lista = new List<XINV_Rpt022_Info>();
            try
            {
                using (Entities_Inventario_General context = new Entities_Inventario_General())
                {
                    var contact = from q in context.vwINV_Rpt022
                                  where q.IdEmpresa == IdEmpresa
                                  && q.IdDev_Inven == IdDev_Inven
                                  select q;

                    foreach (var item in contact)
                    {
                        XINV_Rpt022_Info Info = new XINV_Rpt022_Info();

                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdDev_Inven = item.IdDev_Inven;
                        Info.cod_Dev_Inven = item.cod_Dev_Inven;
                        Info.Fecha = item.Fecha;
                        Info.estado = item.estado;
                        Info.cm_tipo = item.cm_tipo;
                        Info.observacion_inven = item.observacion_inven;
                        Info.IdEmpresa_movi_inv = item.IdEmpresa_movi_inv;
                        Info.IdSucursal_movi_inv = item.IdSucursal_movi_inv;
                        Info.IdBodega_movi_inv = item.IdBodega_movi_inv;
                        Info.IdMovi_inven_tipo_movi_inv = item.IdMovi_inven_tipo_movi_inv;
                        Info.IdNumMovi_movi_inv = item.IdNumMovi_movi_inv;
                        Info.Secuencia_movi_inv = item.Secuencia_movi_inv;
                        Info.IdProducto = item.IdProducto;
                        Info.Cantidad_Inv = item.Cantidad_Inv;
                        Info.cantidad_devuelta = item.cantidad_devuelta;
                        Info.mv_costo = item.mv_costo;
                        Info.cod_producto = item.cod_producto;
                        Info.nom_producto = item.nom_producto;
                        Info.nom_tipo_movi_inv = item.nom_tipo_movi_inv;
                        Info.nom_bodega = item.nom_bodega;
                        Info.nom_sucursal = item.nom_sucursal;
                        Info.nom_empresa = item.nom_empresa;
                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt022_Info>();
            }
        }
    }
}
