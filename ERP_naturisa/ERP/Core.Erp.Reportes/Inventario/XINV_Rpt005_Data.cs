using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt005_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt005_Info> Consultar_Data(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdNumMovi, int IdMoviInvenTipo) 
        {
            try
            {
                List<XINV_Rpt005_Info> lstInfo = new List<XINV_Rpt005_Info>();
                using (Entities_Inventario_General conexion = new Entities_Inventario_General())
                {
                    
                    var select = from q in conexion.vwINV_Rpt005
                               where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega
                                && q.IdNumMovi == IdNumMovi && q.IdMovi_inven_tipo == IdMoviInvenTipo
                               select q;

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in select)
	                {
                        XINV_Rpt005_Info Info = new XINV_Rpt005_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdProducto = item.IdProducto;
                        Info.pr_codigo = item.pr_codigo;
                        Info.pr_descripcion = item.pr_descripcion;
                        Info.IdBodega = Convert.ToInt32(item.IdBodega);
                        Info.IdSucursal = item.IdSucursal;
                        Info.dm_stock_ante = item.dm_stock_ante;
                        Info.dm_cantidad = item.dm_cantidad;
                        Info.dm_stock_actu = item.dm_stock_actu;
                        Info.pr_costo_promedio = item.mv_costo;
                        Info.IdNumMovi = item.IdNumMovi;
                        Info.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        Info.TipoMovimiento = item.TipoMovimiento;
                        Info.Logo = infoEmp.em_logo_Image;
                        Info.Empresa = infoEmp.em_nombre;

                        if (item.signo == "+")
                        {
                            Info.dm_cantidad = item.dm_cantidad_sinConversion;
                            Info.IdUnidadMedida = item.IdUnidadMedida_sinConversion;
                        }
                        else
                        {
                            Info.dm_cantidad = item.dm_cantidad;
                            Info.IdUnidadMedida = item.IdUnidadMedida;
                        }

                        lstInfo.Add(Info);
	                }
                               
                    return lstInfo;
                }
            }
            catch (Exception ex)
            {

                return new List<XINV_Rpt005_Info>();
            }
        }
    }
}
