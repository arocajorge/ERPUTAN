using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Cus.Erp.Reports.FJ.Inventario
{
     public class XINV_FJ_Rpt003_Data
    {
        //tb_Empresa_Data dataEmp = new tb_Empresa_Data();
        //tb_Empresa_Info infoEmp = new tb_Empresa_Info();
        XINV_FJ_Rpt002_Data dataCant = new XINV_FJ_Rpt002_Data();

        public List<XINV_FJ_Rpt003_Info> consultar_data(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, 
            int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin, 
            string idCentro_costo, string idSubCentro_costo, DateTime FechaIni, DateTime FechaFin, ref String MensajeError)
        {
         try
         {
             List<XINV_FJ_Rpt003_Info> lista_datos = new List<XINV_FJ_Rpt003_Info>();
             List<XINV_FJ_Rpt002_Info> lstCant_x_Fecha = new List<XINV_FJ_Rpt002_Info>();
             List<XINV_FJ_Rpt003_Info> lstCosto_x_Fecha = new List<XINV_FJ_Rpt003_Info>();

             lstCant_x_Fecha = dataCant.get_Cantidades_x_Fecha(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,idCentro_costo,idSubCentro_costo, FechaIni);
             lstCosto_x_Fecha = get_Costos_x_Fecha(IdEmpresa, IdBodegaIni, IdBodegaFin, IdSucursalIni, IdSucursalFin, IdProductoIni, IdProductoFin,idCentro_costo,idSubCentro_costo, FechaIni);

             using (EntitiesInventario_FJ_Rpt kardexCostos = new EntitiesInventario_FJ_Rpt())
             {
                 double SaldoInicial = 0;
                 double Saldo = 0;
                 double CostoInicial = 0;
                 double Costo = 0;

                 Costo = SaldoInicial * CostoInicial;

                 var select = from h in kardexCostos.vwINV_FJ_Rpt003
                              where h.IdEmpresa == IdEmpresa
                              && h.IdBodega >= IdBodegaIni && h.IdBodega <= IdBodegaFin
                              && h.IdSucursal >= IdSucursalIni && h.IdSucursal <= IdSucursalFin
                              && h.IdProducto >= IdProductoIni && h.IdProducto <= IdProductoFin
                              && h.Fecha >= FechaIni && h.Fecha <= FechaFin
                              && h.idCentro_costo.Contains(idCentro_costo)
                              && h.idSubCentro_costo.Contains(idSubCentro_costo)
                              select h;

                 //infoEmp = dataEmp.Get_Info_Empresa(IdEmpresa);

                 foreach (var item in select)
                 {
                     XINV_FJ_Rpt003_Info itemInfo = new XINV_FJ_Rpt003_Info();
                     
                     ///Sacar las cantidades iniciales
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
                         InfoCant.Saldo_x_Unidades = Saldo + item.CantiIngreso - ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);
                         Saldo = InfoCant.Saldo_x_Unidades;
                         lstCant_x_Fecha.Add(InfoCant);
                     }

                     //sacar los costos iniciales
                     foreach (var itemCosto in lstCosto_x_Fecha)
                     {
                         if (itemCosto.IdBodega == item.IdBodega && itemCosto.IdSucursal == item.IdSucursal && itemCosto.IdProducto == item.IdProducto)
                         {
                             CostoInicial = Convert.ToDouble(itemCosto.CostoInicial);
                             itemCosto.Costo_x_Unidades = itemCosto.Costo_x_Unidades + (item.CantiIngreso * item.Costo) - (((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.Costo);
                             Costo = Convert.ToDouble(itemCosto.Costo_x_Unidades);
                         }
                     }

                     if (lstCosto_x_Fecha.Where(q => q.IdBodega == item.IdBodega && q.IdSucursal == item.IdSucursal && q.IdProducto == item.IdProducto).Count() == 0)
                     {
                         XINV_FJ_Rpt003_Info InfoCant = new XINV_FJ_Rpt003_Info();
                         Costo = 0;
                         InfoCant.IdBodega = item.IdBodega;
                         InfoCant.IdSucursal = item.IdSucursal;
                         InfoCant.IdProducto = item.IdProducto;
                         InfoCant.CostoInicial = 0;
                         InfoCant.Costo_x_Unidades = Costo + (item.CantiIngreso * item.Costo) - (((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.Costo);
                         Costo = InfoCant.Costo_x_Unidades;
                         lstCosto_x_Fecha.Add(InfoCant);
                     }

                     itemInfo.Costo = item.Costo;
                     
                     itemInfo.SaldoInicial = SaldoInicial;
                     itemInfo.Saldo_x_Unidades = Saldo;
                     itemInfo.CantiIngreso = item.CantiIngreso;
                     itemInfo.CantiEgreso = ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso);

                     itemInfo.CostoInicial = CostoInicial;
                     itemInfo.CostoIngreso = item.CantiIngreso * item.Costo;
                     itemInfo.CostoEgreso = ((item.CantiEgreso < 0) ? (item.CantiEgreso * -1) : item.CantiEgreso) * item.Costo;
                     //Costo = Costo + itemInfo.CostoIngreso - itemInfo.CostoEgreso;
                     itemInfo.Costo_x_Unidades = Costo;

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
                     //itemInfo.Logo = infoEmp.em_logo_Image;
                     //itemInfo.Empresa = infoEmp.em_nombre;
                     itemInfo.nom_Centro_costo = item.nom_Centro_costo;
                     itemInfo.nom_subCentro_costo = item.nom_subCentro_costo;
                     itemInfo.idCentro_costo = item.idCentro_costo;
                     itemInfo.idSubCentro_costo = item.idSubCentro_costo;
                     lista_datos.Add(itemInfo);
                 }

             }
             return lista_datos;

         }
         catch (Exception ex)
         {

             return new List<XINV_FJ_Rpt003_Info>();
         }
	}

        public List<XINV_FJ_Rpt003_Info> get_Costos_x_Fecha(int IdEmpresa, int IdBodegaIni, int IdBodegaFin, int IdSucursalIni, int IdSucursalFin, decimal IdProductoIni, decimal IdProductoFin,string idCentro_costo,string idSubCentro_costo, DateTime FechaIni)
        {
            try
            {
                List<XINV_FJ_Rpt003_Info> lstInfo = new List<XINV_FJ_Rpt003_Info>();
                using (EntitiesInventario_FJ_Rpt listado = new EntitiesInventario_FJ_Rpt())
                {
                    var selectProce = from q in listado.spINV_FJ_Rpt003(IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, FechaIni, idCentro_costo,idSubCentro_costo)
                                      select q;

                    foreach (var item in selectProce)
                    {
                        XINV_FJ_Rpt003_Info InfoPrueba = new XINV_FJ_Rpt003_Info();
                        InfoPrueba.IdBodega = item.IdBodega;
                        InfoPrueba.IdSucursal = item.IdSucursal;
                        InfoPrueba.IdProducto = item.IdProducto;
                        InfoPrueba.CostoInicial = Convert.ToDouble(item.Costo_Inicial);
                        InfoPrueba.Costo_x_Unidades = Convert.ToDouble(item.Costo_Inicial_Acum);
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
