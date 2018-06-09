using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt009_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt009_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin,DateTime fecha_corte, decimal IdProducto, ref String MensajeError)
        {
            try
            {
                decimal IdProducto_ini = 0;
                decimal IdProducto_fin = 0;
                IdProducto_ini = IdProducto;
                IdProducto_fin = IdProducto == 0 ? 999999 : IdProducto;
                List<XINV_Rpt009_Info> listadedatos = new List<XINV_Rpt009_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    var select = from h in BalanceGeneral.spINV_Rpt009(IdEmpresa,IdSucursal,IdSucursalFin, IdBodega,IdBodegaFin,IdProducto_ini,IdProducto_fin,fecha_corte)
                                 select h;
                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XINV_Rpt009_Info itemInfo = new XINV_Rpt009_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.pr_codigo = item.pr_codigo;
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.pr_observacion = item.pr_observacion;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.Stock = item.Stock;
                        itemInfo.costo = Convert.ToDouble(item.mv_costo);
                        itemInfo.costo_total = item.costo_total;
                        itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt009_Info>();
            }
        }

        public List<XINV_Rpt009_Info> Get_data(int IdEmpresa, int IdSucursal, int IdBodega, string IdCategoria, int IdLinea, Boolean Registro_Cero,DateTime Fecha_corte,decimal IdProducto, ref String MensajeError)
        {
            try
            {
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                int IdLineaIni = 0;
                int IdLineafin = 0;
                decimal IdProducto_ini = 0;
                decimal IdProducto_fin = 0;
                //Sucursal
                IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;
                //bodega
                IdBodegaIni = (IdBodega == 0) ? 0 : IdBodega;
                IdBodegaFin = (IdBodega == 0) ? 999999 : IdBodega;
                //linea
                IdLineaIni = (IdLinea == 0) ? 0 : IdLinea;
                IdLineafin = (IdLinea == 0) ? 999999 : IdLinea;
                Fecha_corte = Fecha_corte.Date;

                //Producto
                IdProducto_ini = IdProducto;
                IdProducto_fin = IdProducto == 0 ? 999999 : IdProducto;
                
                List<XINV_Rpt009_Info> listadedatos = new List<XINV_Rpt009_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    var select = from h in BalanceGeneral.spINV_Rpt009(IdEmpresa,IdSucursalIni,IdSucursalFin,IdBodegaIni,IdBodegaFin,IdProducto_ini,IdProducto_fin,Fecha_corte)
                                 where h.IdCategoria.Contains(IdCategoria)
                                 && h.IdLinea >= IdLineaIni
                                 && h.IdLinea <= IdLineafin
                                 select h;

                    if (Registro_Cero == false)
                    {
                        if(IdCategoria != "")
                            select = select.Where(v => Math.Round(v.Stock, 2) != 0 && v.IdCategoria == IdCategoria);
                        else
                            select = select.Where(v => Math.Round(v.Stock,2) != 0);
                    }
                    else
                        if (IdCategoria != "")
                            select = select.Where(v => v.IdCategoria == IdCategoria);

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                    foreach (var item in select)
                    {
                        XINV_Rpt009_Info itemInfo = new XINV_Rpt009_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.pr_codigo = item.pr_codigo;
                        itemInfo.pr_descripcion = item.pr_descripcion;
                        itemInfo.pr_observacion = item.pr_observacion;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.Stock = item.Stock;
                        itemInfo.costo = Convert.ToDouble(item.mv_costo);
                        itemInfo.costo_total = item.costo_total;
                        itemInfo.IdCategoria = item.IdCategoria;
                        itemInfo.ca_Categoria = item.ca_Categoria;
                        itemInfo.IdLinea = item.IdLinea;
                        itemInfo.nom_linea = item.nom_linea;
                        itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                
                return new List<XINV_Rpt009_Info>();
            }
        }
    }
}
