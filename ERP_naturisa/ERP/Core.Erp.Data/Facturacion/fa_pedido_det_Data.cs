using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_pedido_det_Data
    {
        string mensaje = "";

        public List<fa_pedido_det_Info> Get_List_pedido_det(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido)
        {
            try
            {
                List<fa_pedido_det_Info> lM = new List<fa_pedido_det_Info>();
                EntitiesFacturacion OEPPedido = new EntitiesFacturacion();
                var select_pedido_det = from A in OEPPedido.vwfa_pedido_detalle   
                                        where A.IdEmpresa == IdEmpresa && A.IdSucursal == IdSucursal && A.IdBodega == IdBodega && A.IdPedido == IdPedido
                                        select A;

                in_Producto_data data = new in_Producto_data();
                foreach (var item in select_pedido_det)
                {
                    fa_pedido_det_Info info = new fa_pedido_det_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdPedido = item.IdPedido;
                    info.Secuencial = item.Secuencial;
                    info.IdProducto = item.IdProducto;
                    info.CodProducto = data.Get_Codigo_Producto(item.IdEmpresa, item.IdProducto);
                    info.DesProduct = data.Get_Descripcion_Producto(item.IdEmpresa, item.IdProducto);
                    info.dp_cantidad = item.dp_cantidad;
                    info.dp_precio = item.dp_precio;
                    info.dp_PorDescuento = item.dp_PorDescuento;
                    info.dp_desUni = item.cp_desUni;
                    info.dp_PrecioFinal = item.cp_PrecioFinal;
                    info.dp_subtotal = item.dp_subtotal;
                    info.dp_iva = item.dp_iva;
                    info.dp_total = item.dp_total;
                    info.dp_pagaIva = item.dp_pagaIva;
                    info.dp_detallexItems = item.dp_detallexItems;
                    info.Peso = (double)item.dp_peso;

                    info.Tiene_Despacho = item.Tiene_Despacho;
                    info.Esta_en_Base = item.Esta_en_Base;
                   
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public int GetIdPedido(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido)
        {
            try
            {
                int IdSecuencial = 0;
                EntitiesFacturacion OEpedDet = new EntitiesFacturacion();
                OEpedDet = new EntitiesFacturacion();
                var select = (from q in OEpedDet.fa_pedido_det
                                        where q.IdEmpresa == IdEmpresa
                                        && q.IdSucursal == IdSucursal
                                        && q.IdBodega==IdBodega
                                        && q.IdPedido==IdPedido
                                        select q.Secuencial).Max();

                IdSecuencial = Convert.ToInt32(select.ToString());
                return IdSecuencial;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString();
                throw new Exception(ex.ToString());
            }
        }

        public List<fa_pedido_det_Info> Get_List_pedido_det_x_Producto(int IdEmpresa, int IdSucursal, int IdBodega, decimal IdPedido, decimal IdProducto)
        {
            try
            {
                List<fa_pedido_det_Info> lM = new List<fa_pedido_det_Info>();
                EntitiesFacturacion OEPPedido = new EntitiesFacturacion();
                var select_pedido_det = from A in OEPPedido.vwfa_pedido_detalle

                                        where A.IdEmpresa == IdEmpresa && A.IdSucursal == IdSucursal && A.IdBodega == IdBodega && A.IdPedido == IdPedido
                                        && A.IdProducto == IdProducto
                                        select A;
                in_Producto_data data = new in_Producto_data();
                foreach (var item in select_pedido_det)
                {
                    fa_pedido_det_Info info = new fa_pedido_det_Info();
                    info.IdEmpresa = item.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdPedido = item.IdPedido;
                    info.Secuencial = item.Secuencial;
                    info.IdProducto = item.IdProducto;
                    info.CodProducto = data.Get_Codigo_Producto(item.IdEmpresa, item.IdProducto);
                    info.DesProduct = data.Get_Descripcion_Producto(item.IdEmpresa, item.IdProducto);
                    info.dp_cantidad = item.dp_cantidad;
                    info.dp_precio = item.dp_precio;
                    info.dp_PorDescuento = item.dp_PorDescuento;
                    info.dp_desUni = item.cp_desUni;
                    info.dp_PrecioFinal = item.cp_PrecioFinal;
                    info.dp_subtotal = item.dp_subtotal;
                    info.dp_iva = item.dp_iva;
                    info.dp_total = item.dp_total;
                    info.dp_pagaIva = item.dp_pagaIva;
                    info.dp_detallexItems = item.dp_detallexItems;
                    info.Peso = (double)item.dp_peso;

                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean GrabarDB(fa_pedido_det_Info info, ref string msg)
        {
            try
            {
                
                    using (EntitiesFacturacion context = new EntitiesFacturacion())
                    {


                        var address = new fa_pedido_det();
                        address.IdEmpresa = info.IdEmpresa;
                        address.IdSucursal = info.IdSucursal;
                        address.IdBodega = info.IdBodega;
                        address.IdPedido = info.IdPedido;
                        address.Secuencial = info.Secuencial;
                        address.IdProducto = info.IdProducto;
                        address.dp_cantidad = info.dp_cantidad;
                        address.dp_precio = info.dp_precio;
                        address.dp_PorDescuento = info.dp_PorDescuento;
                        address.cp_desUni = info.dp_desUni;
                        address.cp_PrecioFinal = info.dp_PrecioFinal;
                        address.dp_subtotal = info.dp_subtotal;
                        address.dp_iva = info.dp_iva;
                        address.dp_total = info.dp_total;
                        address.dp_pagaIva = info.dp_pagaIva;
                        address.dp_detallexItems = string.IsNullOrEmpty(info.dp_detallexItems) ? "" : info.dp_detallexItems;
                        address.dp_peso = info.Peso;
                        context.fa_pedido_det.Add(address);
                        context.SaveChanges();
                    }
                    return true;
               
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean EliminarDB(fa_pedido_det_Info info, ref  string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {                                
                        var contact = context.fa_pedido_det.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdPedido == info.IdPedido && obj.Secuencial == info.Secuencial);
                        if (contact != null)
                        {
                            context.fa_pedido_det.Remove(contact);
                            context.SaveChanges();
                            context.Dispose();
                        }
                }
                return true;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                msg = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
                throw new Exception(ex.ToString());
            }
        }

        public Boolean VerificarOrdenDespacho(fa_pedido_Info info) 
        {
            try
            {
                int cont = 0;
                
                
                info.ListaDetalle= Get_List_pedido_det(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);

                foreach (var item in info.ListaDetalle)
                {

                    EntitiesFacturacion oEnti = new EntitiesFacturacion();

                    var verifi = from q in oEnti.fa_orden_Desp_det_x_fa_pedido_det
                                 from cab in oEnti.fa_orden_Desp
                                 where q.pe_IdBodega == item.IdBodega && 
                                 q.pe_IdEmpresa == item.IdEmpresa && 
                                 q.pe_IdPedido == item.IdPedido && 
                                 q.pe_IdProducto == item.IdProducto && 
                                 q.pe_IdSucursal == item.IdSucursal && 
                                 q.pe_Secuencia == item.Secuencial
                                 && 
                                 cab.IdEmpresa == item.IdEmpresa && 
                                 cab.IdSucursal == item.IdSucursal && 
                                 cab.IdBodega == item.IdBodega &&
                                 cab.IdOrdenDespacho == q.od_IdOrdenDespacho &&
                                 cab.Estado == "A"
                                 select new
                                 {
                                     q.od_IdOrdenDespacho ,
                                     q.od_IdSucursal ,
                                     cab.Estado

                                 };

                    if (verifi.ToList().Count() == 0)
                    {                                             
                       // return true;
                    }
                    else 
                    {
                        cont = cont + 1;                       
                       // return false;
                    }
                }


                if (cont >= 1)
                { return false; }
                else
                { return true; }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }

        public fa_pedido_det_Data() { }
    }
}
