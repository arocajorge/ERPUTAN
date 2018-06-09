using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;

using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;



namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_liquidacion_gastos_Bus
    {
        fa_liquidacion_gastos_Data oData = new fa_liquidacion_gastos_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public List<fa_liquidacion_gastos_Info> Get_List_Liquidacion_Gastos(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, ref string mensaje)
        {
            try
            {
                return oData.Get_List_Liquidacion_Gastos(IdEmpresa, FechaIni, FechaFin, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public fa_liquidacion_gastos_Info Get_Info_Liquidacion_Gastos(int IdEmpresa, decimal IdLiquidacion_Gastos, ref string mensaje)
        {
            try
            {
                return oData.Get_Info_Liquidacion_Gastos(IdEmpresa, IdLiquidacion_Gastos, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }

        }

        public bool GuardarDB(fa_liquidacion_gastos_Info Info, ref decimal IdLiquidacion, ref string mensaje)
        {
            try
            {
                return oData.GuardarDB(Info, ref IdLiquidacion, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool ModificarDB(fa_liquidacion_gastos_Info Info, ref string mensaje)
        {
            try
            {
                return oData.ModificarDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public bool AnularDB(fa_liquidacion_gastos_Info Info, ref string mensaje)
        {
            try
            {
                return oData.AnularDB(Info, ref mensaje);
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(mensaje);
            }
        }

        public List<fa_liquidacion_gastos_Info> Get_List_Liquidacion_Gastos_x_periodo(int IdEmpresa, int idperiodo)
        {
            try
            {
                return oData.Get_List_Liquidacion_Gastos_x_periodo(IdEmpresa, idperiodo);
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                throw new Exception();
            }
        }

        public bool Convert_Liquidacion_a_Factura(int IdEmpresa,decimal IdLiquidacion_gastos ,ref decimal IdCbteVta ,ref string mensaje)
        {
            try
            {
                bool respuesta = false;
                fa_liquidacion_gastos_Bus Bus_liqu_gastos = new fa_liquidacion_gastos_Bus();
                fa_liquidacion_gastos_Info InfoLiqui_Gasto = new fa_liquidacion_gastos_Info();
                fa_pre_facturacion_Parametro_Info Info_Pre_fac_param = new fa_pre_facturacion_Parametro_Info();
                fa_pre_facturacion_Parametro_Bus Bus_Pre_fac_param = new fa_pre_facturacion_Parametro_Bus();

                Info_Pre_fac_param = Bus_Pre_fac_param.Get_Info(IdEmpresa);
                
                if (Info_Pre_fac_param.IdSucursal_para_facturar == 0 || Info_Pre_fac_param.IdBodega_para_facturar == 0)
                {
                    mensaje = "no hay IdSucursal o idbodega para factura en parametros de Liquidacion verifique y configure";
                    throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "no hay IdSucursal o idbodega para factura en parametros de Liquidacion verifique y configure ", mensaje)) { EntityType = typeof(fa_liquidacion_gastos_Bus) };
                }
                
                InfoLiqui_Gasto  = Bus_liqu_gastos.Get_Info_Liquidacion_Gastos(IdEmpresa, IdLiquidacion_gastos, ref mensaje);

                if (InfoLiqui_Gasto.Lis_Detalle.Count() == 0)
                {
                    mensaje = "Liquidacion no tiene detalle";
                    return false; 
                }

                fa_factura_Bus Bus_factura = new fa_factura_Bus();
                fa_factura_Info Info_Factura = new fa_factura_Info();

                

                Info_Factura.IdEmpresa = InfoLiqui_Gasto.IdEmpresa;
                Info_Factura.IdSucursal = Info_Pre_fac_param.IdSucursal_para_facturar;
                Info_Factura.IdBodega = Info_Pre_fac_param.IdBodega_para_facturar;
                Info_Factura.vt_tipoDoc = "FACT";
                Info_Factura.IdCliente = InfoLiqui_Gasto.IdCliente;
                Info_Factura.IdVendedor = 1;
                Info_Factura.vt_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Info_Factura.vt_fech_venc = Info_Factura.vt_fecha;
                Info_Factura.vt_plazo = 0;
                Info_Factura.vt_tipo_venta = "CON";
                Info_Factura.vt_Observacion = "Fact x Liqui : " + InfoLiqui_Gasto.Observacion;
                Info_Factura.IdPeriodo=((Info_Factura.vt_fecha.Year)*100)+Info_Factura.vt_fecha.Month;
                Info_Factura.vt_anio = Info_Factura.vt_fecha.Year;
                Info_Factura.vt_mes = Info_Factura.vt_fecha.Month;
                Info_Factura.Estado = "A";
                Info_Factura.IdCaja = 1;


                List<fa_factura_det_info> list_det_factura= new List<fa_factura_det_info>();


                foreach (fa_liquidacion_gastos_det_Info  item_det in InfoLiqui_Gasto.Lis_Detalle)
                {
                    fa_factura_det_info Info_det_factura = new fa_factura_det_info();

                    Info_det_factura.IdEmpresa = Info_Factura.IdEmpresa;
                    Info_det_factura.IdSucursal = Info_Factura.IdSucursal;
                    Info_det_factura.IdBodega = Info_Factura.IdBodega;
                    Info_det_factura.IdCbteVta = 0;
                    Info_det_factura.Secuencia = item_det.secuencia;
                    Info_det_factura.IdProducto = item_det.IdProducto;
                    Info_det_factura.vt_cantidad = item_det.cantidad;
                    Info_det_factura.vt_Precio = item_det.precio;
                    Info_det_factura.vt_PrecioFinal = item_det.precio;
                    Info_det_factura.vt_Subtotal = item_det.subtotal;
                    Info_det_factura.vt_iva = item_det.valor_iva;
                    Info_det_factura.vt_por_iva = item_det.por_iva;
                    Info_det_factura.vt_total = item_det.Total_liq;
                    Info_det_factura.vt_estado = "A";
                    Info_det_factura.IdCod_Impuesto_Iva = param.iva.IdCod_Impuesto;
                    Info_det_factura.vt_detallexItems = item_det.detalle_x_producto;
                    Info_det_factura.IdPunto_cargo = null;
                    list_det_factura.Add(Info_det_factura);


                }

                Info_Factura.DetFactura_List = list_det_factura;

                string num_doc_x_fac="";
                string mensaje_dupli="";

               respuesta= Bus_factura.GuardarDB(Info_Factura, ref IdCbteVta, ref num_doc_x_fac,ref mensaje, ref mensaje_dupli);

                return respuesta;
            }
            catch (Exception ex)
            {
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", "", "", "", "", "", "", DateTime.Now);
                throw new Exception();
            }
        }
    }
}

