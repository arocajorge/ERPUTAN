using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt029_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_Rpt029_Info> consultar_data(int IdEmpresa, int IdBodega, int IdBodegaFin, int IdSucursal, int IdSucursalFin,DateTime fecha_corte, ref String MensajeError)
        {
            try
            {
                List<XINV_Rpt029_Info> listadedatos = new List<XINV_Rpt029_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    var select = from h in BalanceGeneral.spINV_Rpt029(IdEmpresa,IdSucursal,IdSucursalFin, IdBodega,IdBodegaFin,fecha_corte)
                                 select h;
                    foreach (var item in select)
                    {
                        XINV_Rpt029_Info itemInfo = new XINV_Rpt029_Info();
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
                        itemInfo.costo_total = Convert.ToDouble(item.costo_total);
                        itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                return new List<XINV_Rpt029_Info>();
            }
        }

        public List<XINV_Rpt029_Info> Get_data(int IdEmpresa, int IdSucursal, List<int> lst_bod, Boolean Registro_Cero,DateTime Fecha_corte, ref String MensajeError)
        {
            try
            {
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;

                //Sucursal
                IdSucursalIni = (IdSucursal == 0) ? 0 : IdSucursal;
                IdSucursalFin = (IdSucursal == 0) ? 999999 : IdSucursal;
                Fecha_corte = Fecha_corte.Date;
                List<XINV_Rpt029_Info> listadedatos = new List<XINV_Rpt029_Info>();

                using (Entities_Inventario_General BalanceGeneral = new Entities_Inventario_General())
                {
                    foreach (var item_bod in lst_bod)
                    {
                        var select = from h in BalanceGeneral.spINV_Rpt029(IdEmpresa, IdSucursalIni, IdSucursalFin, item_bod, item_bod, Fecha_corte)
                                     select h;

                        if (Registro_Cero == false)
                            select = select.Where(v => Math.Round(v.Stock, 2) != 0);

                        foreach (var item in select)
                        {
                            XINV_Rpt029_Info itemInfo = new XINV_Rpt029_Info();
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
                            itemInfo.costo_total = Convert.ToDouble(item.costo_total);
                            itemInfo.IdCategoria = item.IdCategoria;
                            itemInfo.ca_Categoria = item.ca_Categoria;
                            itemInfo.IdLinea = item.IdLinea;
                            itemInfo.nom_linea = item.nom_linea;
                            itemInfo.nom_UnidadMedida = item.nom_UnidadMedida;
                            listadedatos.Add(itemInfo);
                        }
                    }
                    
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                
                return new List<XINV_Rpt029_Info>();
            }
        }
    }
}
