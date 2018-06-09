using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt018_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info InfoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt018_Info> Get_List(int IdEmpresa, int IdSucursalIni, int IdSucursalFin, int IdBodegaIni, int IdBodegaFin, int IdProductoIni, int IdProductoFin, DateTime FechaIni, DateTime FechaFin, int dias_stock, Boolean Mostrar_reg_en_cero, ref string Mensaje)
        {
            try
            {
                List<XINV_Rpt018_Info> ListInfo = new List<XINV_Rpt018_Info>();
                using (Entities_Inventario_General context = new Entities_Inventario_General())
                {
                    var q = from c in context.spINV_Rpt018(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, FechaFin, dias_stock, Mostrar_reg_en_cero)
                            select c;

                    InfoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);

                    foreach (var item in q)
                    {
                        XINV_Rpt018_Info Info = new XINV_Rpt018_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdSucursal = item.IdSucursal;
                        Info.IdBodega = item.IdBodega;
                        Info.Idproducto = item.Idproducto;
                        Info.cod_producto = item.cod_producto;
                        Info.nom_producto = item.nom_producto;
                        Info.nom_sucursal = item.nom_sucursal;
                        Info.nom_bodega = item.nom_bodega;
                        Info.egresos = item.egresos;
                        Info.stock_fecha_desde = item.stock_fecha_desde;
                        Info.stock_fecha_hasta = item.stock_fecha_hasta;
                        Info.promedio = item.promedio;
                        Info.indice = item.indice;
                        Info.stock_minimo = item.stock_minimo;
                        Info.stock_hoy = item.stock_hoy;
                        Info.cant_a_comprar = item.cant_a_comprar;
                        Info.nom_empresa = InfoEmp.em_nombre;
                        ListInfo.Add(Info);
                    }
                }
                return ListInfo;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt018_Info>();
            }
        }
    }
}
