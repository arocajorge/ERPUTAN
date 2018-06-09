using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt017_Data
    {
        public List<XINV_Rpt017_Info> Get_List(int IdEmpresa,int IdSucursal_origen, int IdBodega_origen, decimal IdTransferencia, ref string msg)
        {
            try
            {
                List<XINV_Rpt017_Info> Lista = new List<XINV_Rpt017_Info>();
                using (Entities_Inventario_General context= new Entities_Inventario_General())
                {
                    var selec = from q in context.vwINV_Rpt017
                                where q.IdEmpresa == IdEmpresa
                                && q.IdSucursalOrigen == IdSucursal_origen
                                && q.IdBodegaOrigen == IdBodega_origen
                                && q.IdTransferencia == IdTransferencia
                                select q;

                    foreach (var item in selec)
                    {
                        XINV_Rpt017_Info Info = new XINV_Rpt017_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursalOrigen = item.IdSucursalOrigen;
                        Info.IdBodegaOrigen = item.IdBodegaOrigen;
                        Info.IdTransferencia = item.IdTransferencia;
                        Info.dt_secuencia = item.dt_secuencia;
                        Info.IdProducto = item.IdProducto;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.dt_cantidad = item.dt_cantidad;
                        Info.IdUnidadMedida = item.IdUnidadMedida;
                        Info.nom_unidad_medida = item.nom_unidad_medida;
                        Info.cod_sucursal_origen = item.cod_sucursal_origen;
                        Info.nom_sucursal_origen = item.nom_sucursal_origen;
                        Info.cod_bodega_origen = item.cod_bodega_origen;
                        Info.nom_bodega_origen = item.nom_bodega_origen;
                        Info.cod_sucursal_destino = item.cod_sucursal_destino;
                        Info.nom_sucursal_destino = item.nom_sucursal_destino;
                        Info.cod_bodega_destino = item.cod_bodega_destino;
                        Info.nom_bodega_destino = item.nom_bodega_destino;
                        Info.tr_fecha = item.tr_fecha;
                        Info.tr_Observacion = item.tr_Observacion;
                        Info.Estado = item.Estado;
                        Info.Codigo = item.Codigo;
                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt017_Info>();
            }
        }
    }
}
