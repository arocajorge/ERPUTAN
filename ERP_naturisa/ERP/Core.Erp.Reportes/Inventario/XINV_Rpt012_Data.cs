using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt012_Data
    {
        string mensaje = "";
        tb_Empresa_Bus busEmpresa = new tb_Empresa_Bus();
        tb_Empresa_Info Cbt = new tb_Empresa_Info();


        public List<XINV_Rpt012_Info> get_List_MoviInveMatriz(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdProducto, string mv_tipo_movi, DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XINV_Rpt012_Info> lstRpt = new List<XINV_Rpt012_Info>();
                using (Entities_Inventario_General listado = new Entities_Inventario_General())
                {
                    var select = from q in listado.vwINV_Rpt012
                                 where q.IdEmpresa == IdEmpresa
                                 && q.cm_fecha >= FechaIni && q.cm_fecha <= FechaFin
                                 select q;

                    if (IdSucursal != 0)
                        select = select.Where(q => q.IdSucursal == IdSucursal);

                    if (IdBodega != 0)
                        select = select.Where(q => q.IdBodega == IdBodega);

                    if (IdMovi_inven_tipo != 0)
                        select = select.Where(q => q.IdMovi_inven_tipo == IdMovi_inven_tipo);

                    if (IdProducto != 0)
                        select = select.Where(q => q.IdProducto == IdProducto);

                    if (mv_tipo_movi != "")
                        select = select.Where(q => q.mv_tipo_movi == mv_tipo_movi);

                    foreach (var item in select)
                    {
                        XINV_Rpt012_Info infoRpt = new XINV_Rpt012_Info();
                        infoRpt.IdEmpresa = item.IdEmpresa;
                        infoRpt.IdSucursal = item.IdSucursal;
                        infoRpt.IdBodega = item.IdBodega;
                        infoRpt.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        infoRpt.IdNumMovi = item.IdNumMovi;
                        infoRpt.Su_Descripcion = item.Su_Descripcion;
                        infoRpt.bo_Descripcion = item.bo_Descripcion;
                        infoRpt.tm_descripcion = item.tm_descripcion;
                        infoRpt.CodMoviInven = item.CodMoviInven;
                        infoRpt.cm_observacion = item.cm_observacion;
                        infoRpt.cm_fecha = item.cm_fecha;
                        infoRpt.IdUsuario = item.IdUsuario;
                        infoRpt.IdProducto = item.IdProducto;
                        infoRpt.pr_descripcion = item.pr_descripcion;
                        infoRpt.mv_tipo_movi = item.mv_tipo_movi;
                        infoRpt.dm_cantidad = item.dm_cantidad;
                        infoRpt.dm_stock_actu = item.dm_stock_actu;
                        infoRpt.dm_stock_ante = item.dm_stock_ante;
                        infoRpt.dm_observacion = item.dm_observacion;                        
                        infoRpt.mv_costo = item.mv_costo;
                        infoRpt.dm_peso = Convert.ToDouble(item.dm_peso);
                        infoRpt.IdCategoria = item.IdCategoria;
                        infoRpt.ca_Categoria = item.ca_Categoria;
                        infoRpt.IdMarca = item.IdMarca;
                        infoRpt.Descripcion = item.Descripcion;
                        infoRpt.Id_Ing_Egr = item.Id_Ing_Egr;
                        infoRpt.nomUnidadMedida = item.nomUnidadMedida;
                        infoRpt.IdUnidadMedida = item.IdUnidadMedida;
                        infoRpt.total_costo = item.total_costo;
                        infoRpt.total_precio = item.total_precio;
                        infoRpt.dm_precio = item.dm_precio;
                        infoRpt.Cod_ing_egr = item.Cod_ing_egr;
                        lstRpt.Add(infoRpt);
                    }

                }
                return lstRpt;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);  
                return new List<XINV_Rpt012_Info>();
            }
        }

    }
}
