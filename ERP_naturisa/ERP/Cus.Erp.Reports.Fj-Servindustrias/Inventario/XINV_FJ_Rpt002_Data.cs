using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Cus.Erp.Reports.FJ.Inventario
{

    public class XINV_FJ_Rpt002_Data
    {
        //tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        //tb_Empresa_Info infoEmp = new tb_Empresa_Info();

        public List<XINV_FJ_Rpt002_Info> consultar_data(int IdEmpresa, int IdBodegaIni, 
            int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni,
            decimal IdProductoFin, DateTime FechaIni, DateTime FechaFin,
            string IdCentroCosto,string IdSubCentroCosto,
            ref String MensajeError)
        {
            try
            {
                List<XINV_FJ_Rpt002_Info> listadedatos = new List<XINV_FJ_Rpt002_Info>();
                List<XINV_FJ_Rpt002_Info> lstCant_x_Fecha = new List<XINV_FJ_Rpt002_Info>();

                lstCant_x_Fecha = get_Cantidades_x_Fecha(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin, IdCentroCosto,IdSubCentroCosto, FechaIni);

                using (EntitiesInventario_FJ_Rpt DBEnti_Inven = new EntitiesInventario_FJ_Rpt())
                {
                    double SaldoInicial = 0;
                    double Saldo = 0;
 
                    var select = from h in DBEnti_Inven.vwINV_FJ_Rpt002
                                 where h.IdEmpresa == IdEmpresa
                                 && h.IdBodega >= IdBodegaIni && h.IdBodega <= IdBodegaFin
                                 && h.IdSucursal >= IdSucursalIni && h.IdSucursal <= IdSucursalFin
                                 && h.IdProducto >= IdProductoIni && h.IdProducto <= IdProductoFin
                                 && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                                 && h.IdCentroCosto.Contains(IdCentroCosto)
                                 && h.IdSubCentro_costo.Contains(IdSubCentroCosto)
                                 select h;

                    

                    foreach (var item in select)
                    {
                        XINV_FJ_Rpt002_Info itemInfo = new XINV_FJ_Rpt002_Info();

                        foreach (var itemSaldo in lstCant_x_Fecha)
                        {
                            if (itemSaldo.IdBodega == item.IdBodega && itemSaldo.IdSucursal == item.IdSucursal && itemSaldo.IdProducto == item.IdProducto)
                            {
                                SaldoInicial = Convert.ToDouble(itemSaldo.SaldoInicial);
                                itemSaldo.Saldo_x_Unidades = itemSaldo.Saldo_x_Unidades + item.CantiIngreso - ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);
                                Saldo = Convert.ToDouble(itemSaldo.Saldo_x_Unidades);
                            }
                        }

                        if (lstCant_x_Fecha.Where(q => q.IdBodega == item.IdBodega && q.IdSucursal == item.IdSucursal && q.IdProducto == item.IdProducto).Count() == 0)
                        {
                            XINV_FJ_Rpt002_Info InfoCant = new XINV_FJ_Rpt002_Info();
                            Saldo = 0;
                            InfoCant.IdBodega = item.IdBodega;
                            InfoCant.IdSucursal = item.IdSucursal;
                            InfoCant.IdProducto = item.IdProducto;
                            InfoCant.SaldoInicial = 0;
                            InfoCant.Saldo_x_Unidades = Saldo + item.CantiIngreso - ((item.CantiEgreso < 0)? (item.CantiEgreso * -1): item.CantiEgreso) ;
                            Saldo = InfoCant.Saldo_x_Unidades;
                            lstCant_x_Fecha.Add(InfoCant);
                        }

                        itemInfo.SaldoInicial = SaldoInicial;
                        itemInfo.Saldo_x_Unidades = Saldo;
                        itemInfo.ingresos = item.CantiIngreso;
                        itemInfo.egresos = ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);
                        itemInfo.cod_Movi_Inven_tipo = item.cod_Movi_Inven_tipo;
                        itemInfo.Cod_producto = item.Cod_producto;
                        itemInfo.Fecha = item.Fecha;
                        itemInfo.IdBodega = item.IdBodega;
                        itemInfo.IdEmpresa = item.IdEmpresa;
                        itemInfo.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                        itemInfo.IdNumMovi = item.IdNumMovi;
                        itemInfo.CodMoviInven = item.CodMoviInven;
                        itemInfo.IdProducto = item.IdProducto;
                        itemInfo.IdSucursal = item.IdSucursal;
                        itemInfo.mv_tipo_movi = item.mv_tipo_movi;
                        itemInfo.nom_bodega = item.nom_bodega;
                        itemInfo.nom_Movi_Inven_tipo = item.nom_Movi_Inven_tipo;
                        itemInfo.nom_producto = item.nom_producto;
                        itemInfo.nom_sucursal = item.nom_sucursal;
                        itemInfo.NumDocumentoRelacionado = item.NumDocumentoRelacionado;
                        itemInfo.NumFactura = item.NumFactura;
                        itemInfo.Observacion = item.Observacion;

                        itemInfo.IdCentroCosto = item.IdCentroCosto;
                        itemInfo.nom_Centro_costo = item.nom_Centro_costo;
                        itemInfo.IdSubCentro_costo = item.IdSubCentro_costo;
                        itemInfo.nom_SubCentro_costo = item.nom_SubCentro_costo;
                        
                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }


        public List<XINV_FJ_Rpt002_Info> get_Cantidades_x_Fecha(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin,string IdCentro_costo, string IdSubCentro_costo, DateTime FechaIni)
        {
            try
            {
                List<XINV_FJ_Rpt002_Info> lstInfo = new List<XINV_FJ_Rpt002_Info>();
                using (EntitiesInventario_FJ_Rpt listado = new EntitiesInventario_FJ_Rpt())
                {
                    var selectProce = from q in listado.spINV_FJ_Rpt002(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, IdCentro_costo, IdSubCentro_costo)
                                      select q;

                    foreach (var item in selectProce)
                    {
                        XINV_FJ_Rpt002_Info InfoPrueba = new XINV_FJ_Rpt002_Info();
                        InfoPrueba.IdBodega = item.IdBodega;
                        InfoPrueba.IdSucursal = item.IdSucursal;
                        InfoPrueba.IdProducto = item.IdProducto;
                        InfoPrueba.SaldoInicial = Convert.ToDouble(item.Saldo_x_Fecha);
                        InfoPrueba.Saldo_x_Unidades = Convert.ToDouble(item.Saldo_x_Fecha_Acum);
                        lstInfo.Add(InfoPrueba);
                    }
                }
                return lstInfo;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

    }
}
