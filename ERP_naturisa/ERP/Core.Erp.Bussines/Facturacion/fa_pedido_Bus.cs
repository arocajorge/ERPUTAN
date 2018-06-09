using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.Facturacion;
using Core.Erp.Business.General;

using Core.Erp.Data.Inventario;

namespace Core.Erp.Business.Facturacion
{
    public class fa_pedido_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        fa_pedido_Data data = new fa_pedido_Data();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public List<fa_pedido_Info> Get_List_pedido(int idempresa, DateTime fecha_ini, DateTime fecha_fin, int idsucursal, int idbodega)
        {
            try
            {
             
                List<fa_pedido_Info> lM = new List<fa_pedido_Info>();
                return data.Get_List_pedido(idempresa, fecha_ini, fecha_fin, idsucursal, idbodega);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedido", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            }
        }

        public List<fa_pedido_Info> Get_List_pedido(int IdEmpresa)
        {

            try
            {
                return data.Get_List_pedido(IdEmpresa);
            }
            catch (Exception ex)
            {

                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerPedidosNoDespachadosxClientes", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }

        public Boolean VerificarCodigo(string Codigo)
        {
            try
            {
                return data.VerificarCodigo(Codigo);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "VerificarCodigo", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        
        }

        public Boolean ModificarDB(fa_pedido_Info info, ref string msg)
        {
            try
            {                             
                fa_pedido_det_Data pedido_data = new fa_pedido_det_Data();                 
                List<fa_pedido_det_Info> listaAux = new List<fa_pedido_det_Info>();

                listaAux = pedido_data.Get_List_pedido_det(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);
                                    
                #region variables List para verificar ordenes despacho
                List<fa_orden_Desp_det_x_fa_pedido_det_Info> ListaOrdenDEspachoxPedido = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
                List<fa_orden_Desp_det_x_fa_pedido_det_Info> lstemporal = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
                #endregion
                            
                    #region verificar ordenes de despacho para Talme
                  
                    fa_orden_Desp_det_x_fa_pedido_det_Data odata = new fa_orden_Desp_det_x_fa_pedido_det_Data();
                    fa_orden_Desp_Info infoPedido = new fa_orden_Desp_Info();

                    infoPedido.IdEmpresa = info.IdEmpresa;
                    infoPedido.IdBodega = info.IdBodega;
                    infoPedido.IdSucursal = info.IdSucursal;
                    infoPedido.IdPedido = info.IdPedido;
               
                    ListaOrdenDEspachoxPedido = odata.Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Pedido(infoPedido);

                    if (ListaOrdenDEspachoxPedido.Count() == 0)
                    {                        
                        return data.ModificarDB(info, ref msg);
                    }
                    else
                    {
                        foreach (var itemODP in ListaOrdenDEspachoxPedido)
                        {
                            fa_orden_Desp_det_x_fa_pedido_det_Info temp = new fa_orden_Desp_det_x_fa_pedido_det_Info();

                            temp.od_cantidad = itemODP.od_cantidad;
                            temp.od_IdBodega = itemODP.od_IdBodega;
                            temp.od_IdEmpresa = itemODP.od_IdEmpresa;
                            temp.od_IdOrdenDespacho = itemODP.od_IdOrdenDespacho;
                            temp.od_IdProducto = itemODP.od_IdProducto;
                            temp.od_IdSucursal = itemODP.od_IdSucursal;
                            temp.od_Secuencia = itemODP.od_Secuencia;
                            temp.pe_IdBodega = itemODP.pe_IdBodega;
                            temp.pe_IdEmpresa = itemODP.pe_IdEmpresa;
                            temp.pe_IdPedido = itemODP.pe_IdPedido;
                            temp.pe_IdProducto = itemODP.pe_IdProducto;
                            temp.pe_IdSucursal = itemODP.pe_IdSucursal;

                            temp.pe_Secuencia = itemODP.pe_Secuencia;

                            lstemporal.Add(temp);
                        }
                     
                            #region Elimina los datos de la tabla  "fa_orden_Desp_det_x_fa_pedido_det"
                        fa_orden_Desp_det_x_fa_pedido_det_Data odata1 = new fa_orden_Desp_det_x_fa_pedido_det_Data();
                        fa_orden_Desp_Info info1 = new fa_orden_Desp_Info();

                        info1.ListaAuxiliar = ListaOrdenDEspachoxPedido;
                        odata1.EliminarDB(info1);
                        #endregion
                                     
                            #region asigno el valor de las columnas "Esta_en_Base" y "Tiene_Despacho"
                            foreach (var item1 in listaAux)
                            {
                                foreach (var item2 in info.lista_detalle)
                                {
                                    if (item1.IdProducto == item2.IdProducto && item1.Secuencial == item2.Secuencial)
                                    {
                                        item2.Tiene_Despacho = item1.Tiene_Despacho;
                                        item2.Esta_en_Base = item1.Esta_en_Base;
                                    }
                                }
                            }
                            #endregion
                       
                            #region buscar max secuencia detalle pedido
                            fa_pedido_det_Data odatape = new fa_pedido_det_Data();
                            int SecuenciaMax = 0;
                            SecuenciaMax = odatape.GetIdPedido(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);
                            #endregion
                          
                            #region asigno el nuevo secuencial al nuevo item en detalle pedido
                            foreach (var item2 in info.lista_detalle)
                            {
                                if (item2.IdProducto != 0)
                                {
                                    if (item2.Esta_en_Base == "N" || item2.Esta_en_Base == null)
                                    {
                                        SecuenciaMax = SecuenciaMax + 1;
                                        item2.Secuencial = SecuenciaMax;                                       
                                    }
                                }
                            }
                            #endregion
                       
                            #region Grabo el nuevo detalle pedido
                            in_producto_x_tb_bodega_Data data_producto_bodega = new in_producto_x_tb_bodega_Data();

                            (from q in listaAux select q).ToList().ForEach(q => q.dp_cantidad = q.dp_cantidad * -1);

                            data_producto_bodega.ModificarDB(listaAux);

                            foreach (var item in listaAux)
                            {
                                pedido_data.EliminarDB(item, ref msg);
                            }

                            data_producto_bodega.ModificarDB(info.lista_detalle);

                            foreach (var item in info.lista_detalle)
                            {
                                if (item.IdProducto != 0)
                                {
                                    pedido_data.GrabarDB(item, ref msg);
                                }
                            }
                            msg = "Se ha procedido actualizar el registro del Pedido #: " + info.IdPedido.ToString() + " exitosamente";

                            #endregion                                       

                            #region guardo en tabla "fa_orden_Desp_det_x_fa_pedido_det"
                            fa_orden_Desp_det_x_fa_pedido_det_Data odataOD = new fa_orden_Desp_det_x_fa_pedido_det_Data();
                            fa_orden_Desp_Info Info_OD = new fa_orden_Desp_Info();

                            foreach (var item in lstemporal)
                            {
                                fa_orden_Desp_det_Info Infotemp = new fa_orden_Desp_det_Info();

                                Infotemp.IdEmpresa = item.pe_IdEmpresa;
                                Infotemp.IdSucursal = item.pe_IdSucursal;
                                Infotemp.IdBodega = item.pe_IdBodega;
                                Infotemp.IdProducto = item.pe_IdProducto;
                                Infotemp.IdOrdenDespacho = item.od_IdOrdenDespacho;
                                Infotemp.Secuencia = item.od_Secuencia;
                                Infotemp.SecuenciaPedido = item.pe_Secuencia;
                                Infotemp.IdPedido = item.pe_IdPedido;
                                Infotemp.od_cantidad = item.od_cantidad;
                                Info_OD.ListaDetalle.Add(Infotemp);
                            }

                            odataOD.GuardarDB(Info_OD);
                            #endregion
                    }
             
                    #endregion                                  
                                      
                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ModificarDB", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }

        public Boolean validarObjeto(fa_pedido_Info info,ref string mensajeE)
        {
            try 
            {

                if (info.IdEmpresa == 0 || info.IdSucursal == 0 || info.IdBodega == 0)
                {
                    mensajeE = "Uno de los Pk de Pedidos esta en cero IdEmpresa=" + info.IdEmpresa + " IdSucursal=" + info.IdSucursal + " idbodega=" + info.IdBodega;
                    return false;
                }



                if (info.IdCliente == 0 || info.IdVendedor==0)
                {
                    mensajeE = "Un de los IdCliente o IdVendedor esta en cero IdCliente=" + info.IdCliente + " IdVendedor=" + info.IdVendedor;
                    return false;
                }

                info.cp_fecha = Convert.ToDateTime( info.cp_fecha.ToShortDateString());
                info.cp_fechaVencimiento = Convert.ToDateTime(info.cp_fechaVencimiento.ToShortDateString());
                info.cp_observacion = (info.cp_observacion == null) ? "" : info.cp_observacion;
                info.cp_tipopago = (info.cp_tipopago == null) ? "CON" : info.cp_tipopago;
                info.Entregado= (info.Entregado== null) ? "N" : info.Entregado;
                info.Estado = (info.Estado== null) ? "A" : info.Estado;

                if (info.IdEstadoAprobacion == null)
                {
                    fa_pedido_estadoAprobacion_Bus PedEstA = new fa_pedido_estadoAprobacion_Bus();
                    List<fa_pedido_estadoAprobacion_Info> ListEstaApro = new List<fa_pedido_estadoAprobacion_Info>();

                    ListEstaApro = PedEstA.Get_List_EstadoAprobacion();
                }

                return true;
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "validarObjeto", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }

        public Boolean GrabarDB(fa_pedido_Info info, ref decimal id, ref string msg)
        {
            try
            {

                if (Validar_y_corregir_objeto_Pedido(ref info, ref  msg))
                {

                    return data.GrabarDB(info, ref id, ref msg);
                
                }

                return false;
                
              
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarDB", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }

        private Boolean verificarrepetidos(decimal idempleado, Boolean eliminar, int tipo, fa_pedido_Info Pedido_info)
        {
            try
            {
                var cont = from C in Pedido_info.lista_detalle
                           where C.IdProducto== idempleado
                           select C;
                if (cont.Count() == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                       // gridViewNovxEmp.DeleteRow(gridViewNovxEmp.FocusedRowHandle);
                      //  MessageBox.Show("El código ya se encuentra ingresado. Se procederá con su eliminación.");


                    }
                    else
                    {

                       // MessageBox.Show("El código ya se encuentra ingresado.");
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "verificarrepetidos", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }

        }



        private Boolean Validar_y_corregir_objeto_Pedido(ref fa_pedido_Info Pedido_info, ref string msg)
        {
            try
            {
                #region 'Validaciones'
                /*--- validaciones */

                if (Pedido_info.IdEmpresa <= 0 && Pedido_info.IdSucursal <= 0 && Pedido_info.IdBodega <= 0)
                {
                    msg = "Erro en la cabecera de pedido uno de los PK es <=0";
                    return false;
                }

                if (Pedido_info.IdCliente <= 0 && Pedido_info.IdVendedor <= 0)
                {
                    msg = "Erro en la cabecera de pedido idcliente o idvendedor es <=0";
                    return false;
                }

                if (Pedido_info.IdEstadoAprobacion == null || Pedido_info.IdEstadoAprobacion == "")
                {
                    msg = "Erro en la cabecera de pedido el estado aprobación es obligatorio o está en blanco";
                    return false;
                }

                //if (string.IsNullOrEmpty(Factura_info.IdTipoFormaPago) == true)
                //{
                //    msg = "Erro en la cabecera de idformaPago es obligatoria o esta en blanco ";
                //    return false;
                //}

                if (Pedido_info.lista_detalle.Count == 0)
                {
                    msg = "el pedido no tiene detalle ";
                    return false;
                }


                foreach (var item in Pedido_info.lista_detalle)
                {

                    if (item.dp_cantidad == 0 && item.IdProducto !=0)
                    {
                        msg = "el producto id:" + item.IdProducto + " tiene cantidad cero ";
                        return false;
                    }

                    if (item.dp_subtotal == 0 && item.IdProducto != 0)
                    {
                        msg = "el producto id:" + item.IdProducto + " tiene subtotal cero ";
                        return false;
                    }
                }


                // verifica precios repetidos               
                foreach (var item in Pedido_info.lista_detalle)
                {
                   if(item.IdProducto !=0)
                   {
                    
                    var cont = from C in Pedido_info.lista_detalle
                               where C.IdProducto == item.IdProducto && C.dp_precio==item.dp_precio
                               select C;
                    if (cont.Count() > 1)
                    {                       
                        msg = "el producto : " + item.DesProduct + " ,tiene precios iguales";
                        return false;
                    }
                    else
                    { }  
                   }
                }
            
                /*--- Fin validaciones */

                /*--- corrigiendo data */

                Pedido_info.Estado = (string.IsNullOrEmpty(Pedido_info.Estado) == true) ? "A" : Pedido_info.Estado;
                Pedido_info.cp_fecha = Convert.ToDateTime(Pedido_info.cp_fecha.ToShortDateString());
                Pedido_info.cp_fechaVencimiento = Convert.ToDateTime(Pedido_info.cp_fechaVencimiento.ToShortDateString());
                Pedido_info.cp_observacion = (string.IsNullOrEmpty(Pedido_info.cp_observacion) == true) ? "" : Pedido_info.cp_observacion;
                Pedido_info.cp_tipopago = (string.IsNullOrEmpty(Pedido_info.cp_tipopago) == true) ? "CON" : Pedido_info.cp_tipopago;       
                Pedido_info.IdUsuario = (string.IsNullOrEmpty(Pedido_info.IdUsuario) == true) ? param.IdUsuario : Pedido_info.IdUsuario;
                Pedido_info.Fecha_Transac = (Pedido_info.Fecha_Transac == null) ? param.Fecha_Transac : Pedido_info.Fecha_Transac;             
                Pedido_info.ip = (string.IsNullOrEmpty(Pedido_info.ip) == true) ? param.ip : Pedido_info.ip;

                if (Pedido_info.cp_diasPlazo <= 0)
                {
                    Pedido_info.cp_diasPlazo = (Pedido_info.cp_fechaVencimiento - Pedido_info.cp_fecha).Days;
                }
                else
                { Pedido_info.cp_diasPlazo = Pedido_info.cp_diasPlazo; }
               
                //foreach (var item in Factura_info.DetFactura_List)
                //{
                //    item.IdEmpresa = Factura_info.IdEmpresa;
                //    item.IdSucursal = Factura_info.IdSucursal;
                //    item.IdBodega = Factura_info.IdBodega;
                //}


                if (Pedido_info.DetformaPago_list.Count == 0)
                {
                    /// no hay forma de pago le inserto un contado 
                    /// 
                    List<fa_pedido_x_formaPago_Info> listFormaPago = new List<fa_pedido_x_formaPago_Info>();
                    fa_pedido_x_formaPago_Info ItemFormaPago = new fa_pedido_x_formaPago_Info();

                    ItemFormaPago.IdEmpresa = Pedido_info.IdEmpresa;
                    ItemFormaPago.IdSucursal = Pedido_info.IdSucursal;
                    ItemFormaPago.IdBodega = Pedido_info.IdBodega;
                    ItemFormaPago.IdPedido = Pedido_info.IdPedido;
                    ItemFormaPago.Secuencia = 1;
                    ItemFormaPago.Fecha = Pedido_info.cp_fecha;
                    ItemFormaPago.Fecha_vtc = Pedido_info.cp_fechaVencimiento;
                    ItemFormaPago.Dias_Plazo = (Pedido_info.cp_fechaVencimiento - Pedido_info.cp_fecha).Days;
                    ItemFormaPago.Por_Distribucion = 100;
                    ItemFormaPago.Valor = Pedido_info.dp_total;
                    ItemFormaPago.IdTipoFormaPago = "CON";//quemado porq no escogio nada y el sistemas por default graba contado
                }

                foreach (var item in Pedido_info.DetformaPago_list)
                {
                    item.Fecha = Convert.ToDateTime(item.Fecha.ToShortDateString());
                    item.Fecha_vtc = Convert.ToDateTime(item.Fecha_vtc.ToShortDateString());

                }

                /*--- corrigiendo data */

                #endregion

                return true;

            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Validar_y_corregir_objeto_Pedido", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            

            }
        }


        public Boolean AnularDB(fa_pedido_Info info, ref string msg)
        {
            try
            {
                return data.AnularDB(info, ref msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Anular", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }


        public List<fa_pedido_det_Info> ObtenerOrdenDespachoxCliente(fa_orden_Desp_Info info)
        {
            try
            {
                return new List<fa_pedido_det_Info>();
            }
            catch (Exception ex)
            {
                  Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ObtenerOrdenDespachoxCliente", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }

        }
      
        public Boolean ActualizarEstadoApro(List<fa_pedido_Info> Lst, string IdEstadoAprobacion)
        {
            try
            {
                return data.ActualizarEstadoApro(Lst, IdEstadoAprobacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstadoApro", ex.Message), ex) { EntityType = typeof(fa_pedido_Bus) };
            
            }
        }

        public fa_pedido_Bus() { }
    }
}
