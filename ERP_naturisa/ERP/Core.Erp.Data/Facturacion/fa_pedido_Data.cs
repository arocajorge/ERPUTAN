using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Facturacion
{
    public class fa_pedido_Data
    {
        string mensaje = "";
        fa_pedido_det_Data pedido_data = new fa_pedido_det_Data(); 
        in_Producto_data data_producto = new in_Producto_data();
        in_producto_x_tb_bodega_Data data_producto_bodega = new in_producto_x_tb_bodega_Data();

        public List<fa_pedido_Info> Get_List_pedido(int IdEmpresa, DateTime FechaIni, DateTime FechaFin, int idsucursal, int idbodega)
        {
            try
            {
                List<fa_pedido_Info> lM = new List<fa_pedido_Info>();

                EntitiesFacturacion OEPPedido = new EntitiesFacturacion();

                FechaIni = Convert.ToDateTime( FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime( FechaFin.ToShortDateString());
                

                var cabeceraPedido = from ped in OEPPedido.vwfa_pedido_detalle
                                     where ped.IdEmpresa == IdEmpresa && ped.IdSucursal == idsucursal && ped.IdBodega == idbodega
                              && ped.cp_fecha >= FechaIni && ped.cp_fecha <= FechaFin
                              group ped by new {ped.IdEstadoProduccion ,ped.Entregado,ped.CodPedido,ped.cp_fecha,ped.cp_fechaVencimiento,ped.cp_diasPlazo, ped.interes, ped.transporte,ped.otro1,ped.otro2,ped.IdEmpresa, ped.IdSucursal, ped.IdBodega, ped.IdPedido ,ped.IdVendedor,ped.IdCliente, ped.pe_apellido, ped.pe_nombre , ped.pe_nombreCompleto , ped.bo_Descripcion, ped.Su_Descripcion, ped.Ve_Vendedor, ped.cp_observacion, ped.cp_tipopago,ped.Estado , ped.IdEstadoAprobacion,ped.Descripcion  }
                                  into grouping
                                         select new { grouping.Key, subtotal = grouping.Sum(p => p.dp_subtotal), total = grouping.Sum(p => p.dp_total) };
                

                foreach (var item in cabeceraPedido)
                {
                    fa_pedido_Info info = new fa_pedido_Info();
                    info.CodPedido = item.Key.CodPedido;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.cp_fecha = item.Key.cp_fecha;
                    info.cp_fechaVencimiento = item.Key.cp_fechaVencimiento;
                    info.cp_diasPlazo = item.Key.cp_diasPlazo;
                    info.cp_observacion = item.Key.cp_observacion;
                    info.IdEmpresa = item.Key.IdEmpresa;
                    info.IdSucursal = item.Key.IdSucursal;
                    info.IdBodega = item.Key.IdBodega;
                    info.IdPedido = item.Key.IdPedido;
                    info.IdCliente = item.Key.IdCliente;
                    info.IdVendedor = item.Key.IdVendedor;
                    info.Vendedor = item.Key.Ve_Vendedor.Trim();
                    info.IdCliente = item.Key.IdCliente;
                    info.Cliente = item.Key.pe_nombreCompleto.Trim();
                    info.IdBodega = item.Key.IdBodega;
                    info.Bodega = item.Key.bo_Descripcion.Trim();
                    info.IdSucursal = item.Key.IdSucursal;
                    info.Sucursal = item.Key.Su_Descripcion.Trim();
                    info.Subtotal = item.subtotal;
                    info.Entregado = item.Key.Entregado;
                    info.Estado = item.Key.Estado;
                    info.IdEstadoAprobacion = item.Key.IdEstadoAprobacion;
                    info.EstadoAprobacion = item.Key.Descripcion.Trim();
                    info.cp_tipopago = item.Key.cp_tipopago.Trim();
                    info.Trasnporte = item.Key.transporte;
                    info.Interes = item.Key.interes;
                    info.Otro1 = item.Key.otro1;
                    info.Otro2 = item.Key.otro2;
                    info.IdEstadoProduccion = item.Key.IdEstadoProduccion;
                    info.TOTAL = item.total;
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

        public List<fa_pedido_Info> Get_List_pedido(int IdEmpresa)
        {
            try
            {
                List<fa_pedido_Info> lM = new List<fa_pedido_Info>();

                EntitiesFacturacion OEPPedido = new EntitiesFacturacion();

                var consulta = from q in OEPPedido.vwFa_Total_pedidos_x_cliente_No_despachados
                               where q.IdEmpresa == IdEmpresa
                               select q;

                foreach (var item in consulta)
                {
                    fa_pedido_Info info = new fa_pedido_Info();
                    info.IdEmpresa = IdEmpresa;
                    info.IdCliente = item.IdCliente;
                    info.dp_total =Convert.ToDouble(item.dp_total);


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

        public decimal GetId(int idempresa)
        {
            try
            {
                decimal Id;
                EntitiesFacturacion OEP_Pedido = new EntitiesFacturacion();
                var select = from q in OEP_Pedido.fa_pedido
                             where q.IdEmpresa == idempresa
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    EntitiesFacturacion OEP_Pedido_getId = new EntitiesFacturacion();
                    var select_pv = (from A in OEP_Pedido_getId.fa_pedido
                                     where A.IdEmpresa == idempresa
                                     select A.IdPedido).Max();
                    Id = Convert.ToDecimal(select_pv.ToString()) + 1;
                }
                return Id;
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

        public Boolean GrabarDB( fa_pedido_Info info, ref decimal id, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                   
                    var address = new fa_pedido();
                    decimal idpv = GetId(info.IdEmpresa);
                    id = idpv;
                    address.CodPedido = (info.CodPedido == "") ? "PED"+idpv.ToString() : info.CodPedido;
                    address.IdEmpresa = info.IdEmpresa;
                    address.IdSucursal = info.IdSucursal;
                    address.IdBodega = info.IdBodega;
                    address.IdPedido = idpv;
                    address.IdCliente = info.IdCliente;
                    address.IdVendedor = info.IdVendedor;
                    address.cp_fecha = Convert.ToDateTime(info.cp_fecha.ToShortDateString());
                    address.cp_diasPlazo = info.cp_diasPlazo;
                    address.cp_fechaVencimiento = Convert.ToDateTime(info.cp_fechaVencimiento.ToShortDateString());
                    address.cp_observacion = info.cp_observacion;
                    address.cp_tipopago = info.cp_tipopago;
                    address.IdEstadoAprobacion = info.IdEstadoAprobacion;
                    address.transporte = info.Trasnporte;
                    address.interes = info.Interes;
                    address.otro1 = info.Otro1;
                    address.otro2 = info.Otro2;
                    address.Entregado = info.Entregado; 
                    //campos de auditoria
                    address.IdUsuario = info.IdUsuario;
                    address.Fecha_Transac = info.Fecha_Transac;
                    address.nom_pc = info.nom_pc;
                    address.ip = info.ip;
                    address.Estado = "A";
                    address.IdEstadoProduccion = info.IdEstadoProduccion;
                    context.fa_pedido.Add(address);
                    context.SaveChanges();
                    msg = "Se ha procedido a grabar el registro del Pedido #: " + id.ToString() + " exitosamente.";


                    data_producto.ModificarDB(info.lista_detalle, ref msg);
                    data_producto_bodega.ModificarDB(info.lista_detalle);
                    
                 
                    string mensaje="";
                    int i = 0;
                    foreach (var item in info.lista_detalle)
                    {

                        if(item.IdProducto!=0)
                        {
                            i = i + 1;
                            fa_pedido_det_Info pedido_info = new Info.Facturacion.fa_pedido_det_Info();
                            pedido_info.IdEmpresa = item.IdEmpresa;
                            pedido_info.IdSucursal = item.IdSucursal;
                            pedido_info.IdBodega = item.IdBodega;
                            pedido_info.IdPedido = id;
                            pedido_info.Peso = item.Peso;

                            pedido_info.Secuencial = i;

                            //pedido_info.Secuencial = item.Secuencial;
                            pedido_info.IdProducto = item.IdProducto;
                            pedido_info.dp_cantidad = item.dp_cantidad;
                            pedido_info.dp_precio = item.dp_precio;
                            pedido_info.dp_PorDescuento = item.dp_PorDescuento;
                            pedido_info.dp_desUni = item.dp_desUni;
                            pedido_info.dp_PrecioFinal = item.dp_PrecioFinal;
                            pedido_info.dp_subtotal = item.dp_subtotal;
                            pedido_info.dp_iva = item.dp_iva;
                            pedido_info.dp_total = item.dp_total;
                            pedido_info.dp_pagaIva = item.dp_pagaIva;
                            pedido_info.dp_detallexItems = item.dp_detallexItems;
                            //grabo detalle de los items 
                            pedido_data.GrabarDB(pedido_info, ref mensaje);
                        }
                       
                        
                      
                    }


                    #region 'guardando la forma de pago '
                    // guardando la forma de pago 
                    fa_pedido_x_formaPago_Data odata = new fa_pedido_x_formaPago_Data();


                    foreach (var item in info.DetformaPago_list)
                    {
                        item.IdPedido = id;
                    }

                    odata.GuardarDB(info.DetformaPago_list, ref msg);

                   // FormPago_bus.GuardarDB(Factura_info.DetformaPago_list, ref msg);
                    //----------------------------------------------------------------------


                    #endregion
                   
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

        public Boolean VerificarCodigo(string Codigo) 
        {
            try
            {
                EntitiesFacturacion oen = new EntitiesFacturacion();

                var select = from q in oen.fa_pedido
                             where q.CodPedido == Codigo
                             select q;

                if (select.ToList().Count() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }                
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

        public Boolean ModificarDB(fa_pedido_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_pedido.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal==info.IdSucursal && obj.IdBodega== info.IdBodega&& obj.IdPedido == info.IdPedido );
                    if (contact != null)
                    {
                        contact.transporte = info.Trasnporte;
                        contact.IdVendedor = info.IdVendedor;
                        contact.cp_fecha = info.cp_fecha;

                        contact.interes = info.Interes;
                        contact.otro1 = info.Otro1;
                        contact.otro2 = info.Otro2;
                        contact.cp_diasPlazo = info.cp_diasPlazo;
                        contact.cp_fechaVencimiento = info.cp_fechaVencimiento;
                        contact.cp_observacion = info.cp_observacion;
                        contact.cp_tipopago = info.cp_tipopago;
                        contact.IdEstadoAprobacion = info.IdEstadoAprobacion;
                        contact.Estado = info.Estado;
                        contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                        contact.Fecha_UltMod = DateTime.Now;
                        contact.Entregado = info.Entregado;
                        contact.IdEstadoProduccion = info.IdEstadoProduccion;

                        List<fa_pedido_det_Info> listaAux = new List<fa_pedido_det_Info>();

                        listaAux = pedido_data.Get_List_pedido_det(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);


                        (from q in listaAux select q).ToList().ForEach(q => q.dp_cantidad = q.dp_cantidad * -1);

                        data_producto_bodega.ModificarDB(listaAux);


                        foreach (var item in listaAux)
                        {
                            pedido_data.EliminarDB(item, ref msg);
                        }

                        data_producto_bodega.ModificarDB(info.lista_detalle);

                        int sec = 0;
                        foreach (var item in info.lista_detalle)
                        {

                            if (item.IdProducto != 0)
                            {
                                sec = sec + 1;
                                item.Secuencial = sec;
                                pedido_data.GrabarDB(item, ref msg);
                            }
                        }
                        context.SaveChanges();

                        msg = "Se ha procedido actualizar el registro del Pedido #: " + info.IdPedido.ToString() + " exitosamente";
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

        public Boolean AnularDB(fa_pedido_Info info, ref string msg)
        {
            try
            {
                using (EntitiesFacturacion context = new EntitiesFacturacion())
                {
                    var contact = context.fa_pedido.FirstOrDefault(obj => obj.IdEmpresa == info.IdEmpresa && obj.IdSucursal == info.IdSucursal && obj.IdBodega == info.IdBodega && obj.IdPedido == info.IdPedido);
                    if (contact != null)
                    {
                        contact.Estado = "I";
                        contact.cp_observacion = "**Anulado**" + contact.cp_observacion;
                        contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                        contact.Fecha_UltAnu = DateTime.Now;
                        List<fa_pedido_det_Info> listaAux = new List<fa_pedido_det_Info>();
                        listaAux = pedido_data.Get_List_pedido_det(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);

                        (from q in listaAux select q).ToList().ForEach(q => q.dp_cantidad = q.dp_cantidad * -1);

                        data_producto_bodega.ModificarDB(listaAux);

                        context.SaveChanges();
                        msg = "Se ha procedido Anular el registro del Pedido #: " + info.IdPedido.ToString() + " exitosamente";
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

        public Boolean ActualizarEstadoApro(List<fa_pedido_Info> Lst , string IdEstadoAprobacion) 
        {
            try
            {
                foreach (var item in Lst)
                {
                    EntitiesFacturacion Context = new EntitiesFacturacion();
                    var Contact = Context.fa_pedido.FirstOrDefault(var => var.IdEmpresa == item.IdEmpresa && var.IdSucursal == item.IdSucursal && var.IdBodega == item.IdBodega && var.IdPedido == item.IdPedido);
                    if (Contact != null)
                    {
                        Contact.IdEstadoAprobacion = IdEstadoAprobacion;
                        Context.SaveChanges();
                        Context.Dispose();
                    }
                }
                return true;

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


        public fa_pedido_Data() { }
    }
}
