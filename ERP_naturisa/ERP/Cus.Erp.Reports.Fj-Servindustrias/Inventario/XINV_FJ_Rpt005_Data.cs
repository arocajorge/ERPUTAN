using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public class XINV_FJ_Rpt005_Data
    {
        tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_FJ_Rpt005_Info> get_Kardex_Resumido(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni,
            int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin, string IdCentro_costo, string IdSubCentro_Costo,DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                List<XINV_FJ_Rpt005_Info> lista_datos = new List<XINV_FJ_Rpt005_Info>();
                List<XINV_FJ_Rpt002_Info> lstCant_x_Fecha = new List<XINV_FJ_Rpt002_Info>();
                List<XINV_FJ_Rpt003_Info> lstCosto_x_Fecha = new List<XINV_FJ_Rpt003_Info>();
                XINV_FJ_Rpt002_Data dataCant = new XINV_FJ_Rpt002_Data();
                XINV_FJ_Rpt003_Data dataCosto = new XINV_FJ_Rpt003_Data();

                lstCant_x_Fecha = dataCant.get_Cantidades_x_Fecha(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,IdCentro_costo,IdSubCentro_Costo, FechaIni);
                lstCosto_x_Fecha = dataCosto.get_Costos_x_Fecha(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,IdCentro_costo,IdSubCentro_Costo, FechaIni);

                using (EntitiesInventario_FJ_Rpt kardexCostos = new EntitiesInventario_FJ_Rpt())
                {
                    double SaldoInicial = 0;
                    double Saldo = 0;
                    double CostoInicial = 0;
                    double Costo = 0;
                    double Costo_x_IngEgr = 0;

                    Costo = SaldoInicial * CostoInicial;

                    var select_Items = from h in kardexCostos.vwINV_FJ_Rpt005
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdBodega >= IdBodegaIni && h.IdBodega <= IdBodegaFin
                                 && h.IdSucursal >= IdSucursalIni && h.IdSucursal <= IdSucursalFin
                                 && h.IdProducto >= IdProductoIni && h.IdProducto <= IdProductoFin
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin

                                 
                                 select h;

                    var select = from q in select_Items
                                 group q by new
                                 {
                                     q.IdEmpresa,
                                     q.IdSucursal,
                                     q.IdBodega,
                                     q.IdProducto,
                                     q.nom_sucursal,
                                     q.nom_bodega,
                                     q.nom_producto,
                                     q.Cod_producto
                                 } into
                                 grouping
                                 select new
                                 {
                                    
                                     grouping.Key,
                                     CantiIngreso = grouping.Sum(p => p.CantiIngreso),
                                     CantiEgreso = grouping.Sum(p => p.CantiEgreso),
                                     CostoUniIngreso = grouping.Sum(p => p.CostoUniIngreso),
                                     CostoUniEgreso = grouping.Sum(p => p.CostoUniEgreso)
                                 };

                    infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);
                     
                    foreach (var item in select)
                    {
                        XINV_FJ_Rpt005_Info itemInfo = new XINV_FJ_Rpt005_Info();

                        ///Sacar las cantidades iniciales
                        foreach (var itemSaldo in lstCant_x_Fecha)
                        {
                            if (itemSaldo.IdBodega == item.Key.IdBodega && itemSaldo.IdSucursal == item.Key.IdSucursal && itemSaldo.IdProducto == item.Key.IdProducto)
                            {
                                SaldoInicial = Convert.ToDouble(itemSaldo.SaldoInicial);
                                itemSaldo.Saldo_x_Unidades = itemSaldo.Saldo_x_Unidades + item.CantiIngreso - ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);
                                Saldo = Convert.ToDouble(itemSaldo.Saldo_x_Unidades);
                                
                            }
                        }


                        if (lstCant_x_Fecha.Where(q => q.IdBodega == item.Key.IdBodega && q.IdSucursal == item.Key.IdSucursal && q.IdProducto == item.Key.IdProducto).Count() == 0)
                        {
                            XINV_FJ_Rpt002_Info InfoCant = new XINV_FJ_Rpt002_Info();
                            Saldo = 0;
                            InfoCant.IdBodega = item.Key.IdBodega;
                            InfoCant.IdSucursal = item.Key.IdSucursal;
                            InfoCant.IdProducto = item.Key.IdProducto;
                            InfoCant.SaldoInicial = 0;
                            InfoCant.Saldo_x_Unidades = Saldo + item.CantiIngreso - ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);
                            Saldo = InfoCant.Saldo_x_Unidades;
                            lstCant_x_Fecha.Add(InfoCant);
                        }

                        //sacar los costos iniciales
                        foreach (var itemCosto in lstCosto_x_Fecha)
                        {
                            if (itemCosto.IdBodega == item.Key.IdBodega && itemCosto.IdSucursal == item.Key.IdSucursal && itemCosto.IdProducto == item.Key.IdProducto)
                            {
                                CostoInicial = Convert.ToDouble(itemCosto.CostoInicial);
                                itemCosto.Costo_x_Unidades = itemCosto.Costo_x_Unidades + (item.CantiIngreso * item.CostoUniIngreso) - (((item.CantiEgreso > 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.CostoUniEgreso);
                                Costo = Convert.ToDouble(itemCosto.Costo_x_Unidades);
                                itemCosto.Costo_x_IngEgr = itemCosto.Costo_x_IngEgr + (item.CostoUniIngreso - ((item.CostoUniEgreso < 0) ? (item.CostoUniEgreso * -1) : item.CostoUniEgreso));
                                Costo_x_IngEgr = itemCosto.Costo_x_IngEgr;
                            }
                        }

                        if (lstCosto_x_Fecha.Where(q => q.IdBodega == item.Key.IdBodega && q.IdSucursal == item.Key.IdSucursal && q.IdProducto == item.Key.IdProducto).Count() == 0)
                        {
                            XINV_FJ_Rpt003_Info InfoCant = new XINV_FJ_Rpt003_Info();
                            Costo = 0;
                            Costo_x_IngEgr = 0;
                            InfoCant.IdBodega = item.Key.IdBodega;
                            InfoCant.IdSucursal = item.Key.IdSucursal;
                            InfoCant.IdProducto = item.Key.IdProducto;
                            
                            InfoCant.CostoInicial = 0;
                            InfoCant.Costo_x_Unidades = Costo + (item.CantiIngreso * item.CostoUniIngreso) - (((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.CostoUniEgreso);
                            InfoCant.Costo_x_IngEgr = InfoCant.Costo_x_IngEgr + (item.CostoUniIngreso - ((item.CostoUniEgreso < 0) ? (item.CostoUniEgreso * -1) : item.CostoUniEgreso));
                            Costo = InfoCant.Costo_x_Unidades;
                            Costo_x_IngEgr = InfoCant.Costo_x_IngEgr;
                            lstCosto_x_Fecha.Add(InfoCant);
                        }


                        itemInfo.CostoUniEgreso = ((item.CostoUniEgreso < 0) ? (item.CostoUniEgreso * -1) : item.CostoUniEgreso);
                        itemInfo.CostoUniIngreso = item.CostoUniIngreso;

                        itemInfo.SaldoInicial = SaldoInicial;
                        itemInfo.Saldo_x_Unidades = Saldo;
                        itemInfo.CantiIngreso = item.CantiIngreso;
                        itemInfo.CantiEgreso = ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);

                        itemInfo.CostoInicial = CostoInicial;
                        itemInfo.CostoIngreso = item.CantiIngreso * item.CostoUniIngreso;
                        itemInfo.CostoEgreso = ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.CostoUniEgreso;

                        itemInfo.Costo_x_Unidades = Costo;

                        itemInfo.Cod_producto = item.Key.Cod_producto;
                        itemInfo.IdBodega = item.Key.IdBodega;
                        itemInfo.IdEmpresa = item.Key.IdEmpresa;
                        itemInfo.IdProducto = item.Key.IdProducto;
                        itemInfo.IdSucursal = item.Key.IdSucursal;
                        itemInfo.nom_bodega = item.Key.nom_bodega;
                        itemInfo.nom_producto = item.Key.nom_producto;
                        itemInfo.nom_sucursal = item.Key.nom_sucursal;
       
                        itemInfo.Logo = infoEmp.em_logo_Image;
                        itemInfo.Empresa = infoEmp.em_nombre;
                        

                       // itemInfo.IdCentroCosto = 
  
                        lista_datos.Add(itemInfo);
                    }

                }
                return lista_datos;

            }
            catch (Exception ex)
            {

                return new List<XINV_FJ_Rpt005_Info>();
            }
        }


    }
}
