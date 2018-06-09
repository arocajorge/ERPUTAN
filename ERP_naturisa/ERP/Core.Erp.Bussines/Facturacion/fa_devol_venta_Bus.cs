using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.CuentasxCobrar;

using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Business.Facturacion
{
    public class fa_devol_venta_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new General.tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_devol_venta_Data data = new fa_devol_venta_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public List<fa_devol_venta_Info> Get_List_devol_venta(int idEmpresa, int idSucursalIni, int idSucursalFin, int idBodegaIni, int idBodegaFin
            , DateTime FechaIni, DateTime FechaFin)
        {
            try
            {
                return data.Get_List_devol_venta(idEmpresa, idSucursalIni, idSucursalFin, idBodegaIni, idBodegaFin, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaDevVenta", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }

        }

        public Boolean GuardarDB(fa_devol_venta_Info Info, ref string msg)         
        {
            try
            {
                // nota de credito                
                fa_notaCredDeb_Bus BusBNotaDB = new fa_notaCredDeb_Bus();
                in_movi_inve_Info invCabInfo = new in_movi_inve_Info();
                in_movi_inve_Bus inBus = new in_movi_inve_Bus();
                cxc_cobro_Info Cobro = new cxc_cobro_Info();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                string mensaje_cbte_cble = "";
                decimal idNota = 0;
                string codigoNota = "";
                string mensajeDocumentoDupli = "";
                string mensajeError = "";
                string numDocumento = "";


                if (BusBNotaDB.GuardarDB(Info.InfoNotaCreDeb, ref idNota,  ref mensajeDocumentoDupli, ref mensajeError))
                {
                    Info.IdNota = idNota;
                    data.GuardarDB(Info, ref msg);
                   invCabInfo = setInventarioMovi(Info);
                   inBus.GrabarDB(invCabInfo, ref idNota, ref mensaje_cbte_cble, ref msg);
                }
                

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }
          
        }


        public in_movi_inve_Info setInventarioMovi(fa_devol_venta_Info Info)
        {
            try
            {                           
                in_movi_inve_Info invCabInfo = new in_movi_inve_Info();
                fa_parametro_info inf = new fa_parametro_info();
                fa_parametro_Bus FaPaBus = new fa_parametro_Bus();
                invCabInfo.cm_anio = DateTime.Now.Year;
                invCabInfo.IdEmpresa = Info.IdEmpresa;
                invCabInfo.IdBodega = Info.IdBodega;
                invCabInfo.IdSucursal = Info.IdSucursal;
                invCabInfo.IdNumMovi = Info.IdDevolucion;

                inf = FaPaBus.Get_Info_parametro(param.IdEmpresa);
                invCabInfo.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta;
                invCabInfo.cm_tipo = "+";
                invCabInfo.CodMoviInven = "DEV" + Info.IdDevolucion;                
                invCabInfo.cm_observacion = "DEV VTA " + Info.IdDevolucion + " A LA FAC # " + Info.IdCbteVta + "/" + Info.IdCbteVta + " Al Cliente: " + Info.IdCliente + " por el monto de: " + Info.totalDev;
                invCabInfo.cm_fecha = Info.dv_fecha;
                invCabInfo.cm_anio = Info.dv_fecha.Year;
                invCabInfo.cm_mes = Info.dv_fecha.Month;
                invCabInfo.Estado = Info.Estado;
                invCabInfo.ip = param.ip;
                invCabInfo.IdUsuario = Info.IdUsuario;
                invCabInfo.nom_pc = param.nom_pc;

                //detalle movimiento inventario
                List<in_movi_inve_detalle_Info> invList = new List<in_movi_inve_detalle_Info>();

                int secuencia = 0;
                foreach (var item in Info.DetalleDeVta)
                {
                    in_movi_inve_detalle_Info info = new in_movi_inve_detalle_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdBodega = item.IdBodega;
                    info.IdSucursal = item.IdSucursal;
                    info.IdNumMovi = invCabInfo.IdNumMovi;
                    info.IdMovi_inven_tipo = inf.IdMovi_inven_tipo_Dev_Vta;
                    //info.IdNumMovi = item.IdCbteVta;
                    secuencia += 1;
                    info.Secuencia += secuencia;
                    info.mv_tipo_movi = "+";
                    info.IdProducto = item.IdProducto;
                    info.dm_cantidad = +item.dv_cantidad;
                    info.dm_stock_ante = 0;
                    //info.dm_stock_actu = item.IdSucursal;
                    info.dm_observacion = invCabInfo.cm_observacion;
                    info.dm_precio = item.dv_valor;
                    info.mv_costo = item.dv_costo;
                    invList.Add(info);
                }
                invCabInfo.listmovi_inve_detalle_Info = invList;
                return invCabInfo;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "setInventarioMovi", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }

        }


        public fa_devol_venta_Info Get_Info_devol_vent(int idEmpresa, int idSucursal, int idBodega, decimal idCbtevta, ref string msg)
        {
            try
            {
                return data.Get_Info_devol_venta( idEmpresa, idSucursal, idBodega, idCbtevta, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaCabecera", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }        
        }



        public Boolean ModificarDB(fa_devol_venta_Info info, ref string msgs)
        {
            try
            {
             return data.ModificarDB(info, ref msgs);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarCabecera", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }

        }

        public Boolean AnularDevolucion(int idEmpresa, int idSucursal, int idBodega, decimal idDevolucion,DateTime Fecha_Anulacion, string motivo ,ref  string mensageError) 
        {

            try
            {
                in_movi_inve_Bus MoviInve_Bus = new in_movi_inve_Bus();
                in_movi_inve_Info InfoMoviAnu = new in_movi_inve_Info();
                fa_devol_venta_Bus DevVtaBus= new fa_devol_venta_Bus();
                fa_devol_venta_Info DevVta_info= new fa_devol_venta_Info();
                fa_notaCredDeb_Bus BusBNotaDB = new fa_notaCredDeb_Bus();
                fa_notaCreDeb_Info InfoNotaCre = new fa_notaCreDeb_Info();
                Boolean resAnuMoviInv ;
                Boolean resAnuDevVta;
                string MensajeError="";



                Fecha_Anulacion = Convert.ToDateTime(Fecha_Anulacion.ToShortDateString());

                #region "validaciones"
                ct_Periodo_Bus Perbus = new ct_Periodo_Bus();
               

                if (Perbus.Get_Periodo_Esta_Cerrado(idEmpresa, Fecha_Anulacion,ref MensajeError))
                {
                    mensageError = "no se puede anular por q el periodo esta cerrardo para esta fecha de anulacion";
                    return false;
                }

                #endregion


                DevVta_info =DevVtaBus.Get_Info_devol_vent(idEmpresa,idSucursal,idBodega,idDevolucion,ref mensageError);

                ///////// optengo el movimiento de inventario q se genero por la devolcuion en vta
                InfoMoviAnu = MoviInve_Bus.Get_Info_Movi_inven
                    (DevVta_info.mvInv_IdEmpresa, DevVta_info.mvInv_IdSucursal, DevVta_info.mvInv_IdBodega, DevVta_info.mvInv_IdMovi_inven_tipo, DevVta_info.mvInv_IdNumMovi);
                ///////////////

                InfoMoviAnu.MotivoAnulacion = motivo;
                InfoMoviAnu.IdusuarioUltAnu = param.IdUsuario;

                //////////// anula el movimiento de inventario /////////////////////////
                resAnuMoviInv=MoviInve_Bus.AnularDB(InfoMoviAnu, Fecha_Anulacion, ref mensageError);
                //////////// anula el movimiento de inventario /////////////////////////

                //////////// anula el la cabecera de dev vat
                resAnuDevVta=data.AnularDB(idEmpresa, idSucursal, idBodega, idDevolucion, motivo);
                //////////// anula el la cabecera de dev vat

                //////////// anula la nota de credito 
                InfoNotaCre = BusBNotaDB.Get_Info_notaCreDeb_x_ND(idEmpresa, idSucursal, idBodega, DevVta_info.IdNota);
                InfoNotaCre.MotiAnula = motivo;
                InfoNotaCre.IdUsuarioUltAnu = param.IdUsuario;
                InfoNotaCre.Fecha_UltAnu = Fecha_Anulacion;
                BusBNotaDB.AnularDB(InfoNotaCre, ref mensageError);               
                //////////// anula la nota de credito

                ///modifica la devolucion
                
                ///

                return (resAnuMoviInv && resAnuDevVta);

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AnularDevolucion", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
                
            }
           
        }

        public Boolean consultaDevolucionFactura(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta)
        {
            try
            {
                 return data.consultaDevolucionFactura(IdEmpresa,  IdSucursal,  IdBodega,  IdCteVta);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "consultaDevolucionFactura", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }

        }

        public List<vwFa_FacturasConDevolucionxItemSaldos_Info> Get_List_Fa_FacturasConDevolucionxItemSaldos(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta)
        {
            try
            {
                 return data.Get_List_Fa_FacturasConDevolucionxItemSaldos(IdEmpresa, IdSucursal, IdBodega, IdCteVta);
            }
            catch ( Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaFacConDev", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }
            
        }


        public List<vwFa_FacturasConDevolucionxItemSaldos_Info> Get_List_Fa_FacturasConDevolucionxItemSaldos(int IdEmpresa, int IdSucursal, int IdBodega, Decimal IdCteVta, decimal IdDevolucion)
        {
            try
            {
                return data.Get_List_Fa_FacturasConDevolucionxItemSaldos(IdEmpresa, IdSucursal, IdBodega, IdCteVta, IdDevolucion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaFacConsultaIdDevolucion", ex.Message), ex) { EntityType = typeof(fa_devol_venta_Bus) };
            }

        }
    }
}
