using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Business.Inventario;
using Cus.Erp.Reports.Talme.Facturacion;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Pedido_Mant : Form
    {
        #region Declaración de variables
        //Delegados
        public delegate void delegate_frmFA_Pedido_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Pedido_Mant_FormClosing Event_frmFA_Pedido_Mant_FormClosing;

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_pedido_det_Bus busdeta = new fa_pedido_det_Bus();
        fa_TerminoPago_Bus FterminopagoBus = new fa_TerminoPago_Bus();
        fa_pedido_Bus bus = new fa_pedido_Bus();
        in_producto_Bus BusProd = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //Listas
        List<fa_Combo_Info> Lista_Tipo_Pago = new List<fa_Combo_Info>();
        List<fa_pedido_estadoAprobacion_Info> Lista_Estado_Aprobacion = new List<fa_pedido_estadoAprobacion_Info>();
        List<tb_Sucursal_Info> ListaSucursal = new List<tb_Sucursal_Info>();
        List<fa_Cliente_Info> Lista_Clientes = new List<fa_Cliente_Info>();
        List<tb_Bodega_Info> ListaBodega = new List<tb_Bodega_Info>();
        List<fa_pedido_det_Info> lista_producto_detalle = new List<fa_pedido_det_Info>();
        List<fa_orden_Desp_det_Info> ListaOrdenDEspachoxPedido = new List<fa_orden_Desp_det_Info>();

        // Infos
        tb_Bodega_Info bodega_info = new tb_Bodega_Info();
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        tb_Bodega_Info info_bodega = new tb_Bodega_Info();
        fa_pedido_Info info = new fa_pedido_Info();
        fa_Cliente_Info info_cliente = new fa_Cliente_Info();

        //Variables
        decimal id = 0;
        string msg = "";
        public int idbodega { get; set; }
        public int idsucursal { get; set; }

        //UCFa_Grid_detalle_totales UC_grid_totales = new UCFa_Grid_detalle_totales();
        public Cl_Enumeradores.eTipo_action Accion { get; set; }
        Funciones Funciones = new Info.General.Funciones();

        //UCFa_Grid_ProductosDetalles UC_grid_producto = new UCFa_Grid_ProductosDetalles(false, false, false, false, true);
        public List<fa_pedido_Info> lista_pedido { get; set; }
        Boolean CambioFecha;
        Boolean CambioCantidad;
        Boolean banderaCombo = false;
        List<fa_pedido_det_Info> listTablaAux = new List<fa_pedido_det_Info>();
        List<fa_pedido_det_Info> listTabla = new List<fa_pedido_det_Info>();
        List<fa_TerminoPago_Info> list_TerminoPago = new List<fa_TerminoPago_Info>();
        List<fa_pedido_x_formaPago_Info> ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
        public fa_pedido_Info obj { get; set; }
        BindingList<fa_pedido_x_formaPago_Info> DataSource_PedForPag = new BindingList<fa_pedido_x_formaPago_Info>();
        fa_pedido_x_formaPago_Bus Bus_PedidoFormaPago = new fa_pedido_x_formaPago_Bus();
        List<fa_pedido_Info> listPedidosNoDespachados = new List<fa_pedido_Info>();
        fa_pedido_det_Info infoTPD = new fa_pedido_det_Info();
        tb_Calendario_Bus BusCalendario = new tb_Calendario_Bus();
        List<fa_TerminoPago_Distribucion_Info> ListPagoDistri = new List<fa_TerminoPago_Distribucion_Info>();
        List<fa_factura_x_fa_TerminoPago_Info> List = new List<fa_factura_x_fa_TerminoPago_Info>();
        BindingList<fa_factura_x_fa_TerminoPago_Info> DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>();
        fa_TerminoPago_Distribucion_Bus BusPagoDistri = new fa_TerminoPago_Distribucion_Bus();
        double SumValForPag = 0;
        double SumPorDist = 0;
        #endregion

        public frmFa_Pedido_Mant(int id_sucursal, int id_bodega):this()
        {
            try
            {                
                idbodega = id_bodega;
                idsucursal = id_sucursal;
                Accion = Cl_Enumeradores.eTipo_action.actualizar;
                TipoPago();
                EstadoAprobacion();
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
              
        public void LoadProductos()
        {
            try
            {
                UCFAModuloFacturacion.Clear_Ugrid();
                info_bodega = UC_Sucursal_Bodega.get_bodega();
                info_sucursal =UC_Sucursal_Bodega.get_sucursal();                   
                UCFAModuloFacturacion.load_Producto(param.IdEmpresa, info_sucursal.IdSucursal, info_bodega.IdBodega);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            } 
        }
        
        public frmFa_Pedido_Mant()
        {
            try
            {
                InitializeComponent();              
                UC_Sucursal_Bodega.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(UC_Sucursal_Bodega_Event_cmb_bodega_SelectionChangeCommitted);
                UC_Sucursal_Bodega.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UC_Sucursal_Bodega_Event_cmb_sucursal_SelectionChangeCommitted);
                UCFAModuloFacturacion.Event_ultraGrid_AfterCellUpdate += new UCFa_GridFactura.delegate_ultraGrid_AfterCellUpdate(UCFAModuloFacturacion_Event_ultraGrid_AfterCellUpdate);
                UCFAModuloFacturacion.Evente_ultraGrid_PreviewKeyDown += new UCFa_GridFactura.Delegate_ultraGrid_PreviewKeyDown(UCFAModuloFacturacion_Evente_ultraGrid_PreviewKeyDown);
                UCFAModuloFacturacion.Event_ultraGrid_ClickCell += new UCFa_GridFactura.delegate_ultraGrid_ClickCell(UCFAModuloFacturacion_Event_ultraGrid_ClickCell);
              //  UC_Cliente.Event_cmb_cliente_RowSelected += new UCFa_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(UC_Cliente_Event_cmb_cliente_RowSelected);
                UC_Cliente.Event_cmb_cliente_EditValueChanged += UC_Cliente_Event_cmb_cliente_EditValueChanged;
                Accion = Cl_Enumeradores.eTipo_action.actualizar;
                TipoPago();
                EstadoAprobacion();
                //UC_grid_producto.idSucursal = idsucursal;
                //UC_grid_producto.idBodega = idbodega;
                cmb_estado_aprobacion.Enabled = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UC_Cliente_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var Item = (fa_Cliente_Info)UC_Cliente.searchLookUpEdit1View.GetFocusedRow();

                if (Item.cl_Cupo == 0)
                { return; }


                txt_cupo_maximo.Text = Item.cl_Cupo.ToString();
                banderaCombo = true;
                if (Convert.ToDecimal(txtTotal.EditValue) > Convert.ToDecimal(txt_cupo_maximo.Text))
                {
                    cmb_estado_aprobacion.SelectedValue = "N";
                }
                else
                {
                    cmb_estado_aprobacion.SelectedValue = "A";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }     
        }
    
        void UCFAModuloFacturacion_Evente_ultraGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void EditRowOrdendespacho()
        {
            try
            {
                //foreach (var item in UCFAModuloFacturacion.DataSource)
                //{                                                    
                //    var q = from t in ListaOrdenDEspachoxPedido
                //        where t.IdProducto == item.
                //        select t.IdProducto;               
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }
       
        void UCFAModuloFacturacion_Evente_ultraGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                fa_pedido_det_Info infoTablaPedido = new fa_pedido_det_Info();

                infoTablaPedido = UCFAModuloFacturacion.gridView.GetFocusedRow() as fa_pedido_det_Info;
                                        
                var a = infoTablaPedido.IdProducto;
                decimal idpro = Convert.ToDecimal(a);
                var q = from t in ListaOrdenDEspachoxPedido
                        where t.IdProducto== idpro
                        select t.IdProducto;
                if (q.ToList().Count == 0)
                {
                   
                    //listTablaAux = UCFAModuloFacturacion.get_Tabla_detalle();
                    listTabla = new List<fa_pedido_det_Info>();

                    foreach (var item in listTablaAux)
                        {
                            fa_pedido_det_Info info = new fa_pedido_det_Info();
                          
                            if (item.IdProducto == infoTablaPedido.IdProducto)
                            {
                                info.IdProducto = 0;
                                info.dp_cantidad = 0;
                                info.Peso = 0;
                                info.dp_precio = 0;
                                info.dp_PorDescuento = 0;
                                info.dp_desUni = 0;
                                info.dp_PrecioFinal = 0;
                                info.Subtotal = 0;
                                info.dp_iva = 0;
                                info.dp_total = 0;
                                //info.sto = 0;
                                info.dp_detallexItems = "";
                                //info.idpu = 0;
                                //info.precio = 0;

                                listTabla.Add(info);
                            }

                            else
                            {
                                info.IdProducto = item.IdProducto;
                                info.dp_cantidad = item.dp_cantidad;
                                info.Peso = item.Peso;
                                info.dp_precio = item.dp_precio;
                                info.dp_PorDescuento = item.dp_PorDescuento;
                                info.dp_desUni = item.dp_desUni;
                                info.dp_PrecioFinal = item.dp_PrecioFinal;
                                info.Subtotal = item.Subtotal;
                                info.dp_iva = item.dp_iva;
                                info.dp_pagaIva = item.dp_pagaIva;
                                info.dp_total = item.dp_total;
                                info.dp_detallexItems = item.dp_detallexItems;
                                info.Secuencial = item.Secuencial;

                                listTabla.Add(info);                                                       
                            }

                        }
                    //UCFAModuloFacturacion.carga_Grid(listTabla);
                    this.CalcularTotales();                                                     
                }
                else
                {                  
                    if (e.KeyValue.ToString() == "46")
                    {                      
                        MessageBox.Show("El Registro seleccionado tiene una orden de despacho activa");
                    }
                    else 
                    {}
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCFAModuloFacturacion_Event_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCFAModuloFacturacion_Event_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        int Valida_IdSucursal = 0;

        void UC_Sucursal_Bodega_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {                                       
                LoadProductos();              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UC_Sucursal_Bodega_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        #region Load Combos
        private void TipoPago()
        {
            try
            {
                fa_Combo_Info combo_tipo = new fa_Combo_Info();
                combo_tipo.IdCombo = "CRE";
                combo_tipo.Descripcion = "CREDITO";
                Lista_Tipo_Pago.Add(combo_tipo);

                combo_tipo = new fa_Combo_Info();
                combo_tipo.IdCombo = "CON";
                combo_tipo.Descripcion = "CONTADO";
                Lista_Tipo_Pago.Add(combo_tipo);
             
                list_TerminoPago=FterminopagoBus.Get_List_TerminoPago(Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString());
                cmbTerminoPago.Properties.DataSource = list_TerminoPago;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void EstadoAprobacion()
        {
            try
            {
                fa_parametro_Bus busParametro = new fa_parametro_Bus();
                fa_parametro_info info = new fa_parametro_info();

                info = busParametro.Get_Info_parametro(param.IdEmpresa);
                                                                         
                fa_pedido_estadoAprobacion_Bus bus_aprobacion = new fa_pedido_estadoAprobacion_Bus();
                Lista_Estado_Aprobacion = bus_aprobacion.Get_List_EstadoAprobacion();
                this.cmb_estado_aprobacion.DataSource = Lista_Estado_Aprobacion;
                this.cmb_estado_aprobacion.DisplayMember = "Descripcion";
                this.cmb_estado_aprobacion.ValueMember = "IdEstadoAprobacion";

                cmb_estado_aprobacion.SelectedValue = info.IdEstadoAprobacion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion
       
        public void Get_TerminoPago()
        {
            try
            {
                //haac 02/06/2014 Guarda Forma Pago                               
                ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
                foreach (var item in List)
                {
                    fa_pedido_x_formaPago_Info infoFormaPago = new fa_pedido_x_formaPago_Info();

                    infoFormaPago.IdEmpresa = param.IdEmpresa;
                    infoFormaPago.IdBodega = Convert.ToInt32(UC_Sucursal_Bodega.cmb_bodega.EditValue);
                    infoFormaPago.IdSucursal = Convert.ToInt32(UC_Sucursal_Bodega.cmb_sucursal.EditValue);
                    infoFormaPago.IdTipoFormaPago = Convert.ToString(this.cmbTerminoPago.EditValue);
                    infoFormaPago.Fecha = dtFecha.Value;
                    infoFormaPago.Fecha_vtc = item.Fecha_vct;
                    infoFormaPago.Dias_Plazo = item.Dias_Plazo;
                    infoFormaPago.Por_Distribucion = item.Por_Distribucion;
                    infoFormaPago.Valor = item.Valor;

                    ListaFormaPago.Add(infoFormaPago);
                }
                   info.DetformaPago_list = ListaFormaPago;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                           
        }
               
        private fa_pedido_Info get_Pedido()
        {
            try
            {
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS LA CABECERA DEL PEDIDO--------------------
                //---------------------------------------------------------------------
                info = new fa_pedido_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.CodPedido = txtCodigo.Text;
                info_sucursal = new tb_Sucursal_Info();
                //Obtenemos el objeto info de la sucursal del control
                info_sucursal = UC_Sucursal_Bodega.get_sucursal();
                info_bodega = new tb_Bodega_Info();
                info.CodPedido = txtCodigo.Text;
                //Obtenemos el objeto info de la bodega del control
                info_bodega = UC_Sucursal_Bodega.get_bodega();
                info.Trasnporte = Convert.ToDouble(txtTransporte.EditValue);
                info.Otro1 = Convert.ToDouble(txtOtro1.EditValue);
                info.Otro2 = Convert.ToDouble(txtOtro2.EditValue);
                info.Estado = (lbl_Estado.Visible == true) ? "I" : "A";
                info.IdSucursal = info_sucursal.IdSucursal;
                info.Sucursal = info_sucursal.Su_Descripcion;
                info.IdBodega = (info_bodega.IdBodega != 0) ? info_bodega.IdBodega : 0;
                info.Bodega = info_bodega.bo_Descripcion;
                info.IdPedido = (this.txt_pedido.Text != "") ? Convert.ToDecimal(this.txt_pedido.Text) : 0;
                info_cliente = new fa_Cliente_Info();
                //Obtenemos el objeto info del Cliente del control
              
                info.IdCliente = Convert.ToDecimal((UC_Cliente.cmb_cliente.EditValue == null) ? 0 : UC_Cliente.cmb_cliente.EditValue);
                info_cliente.IdVendedor = Convert.ToInt16(UC_Cliente.cmb_vendedor.EditValue);
                info.Cliente = info_cliente.Nombre_Cliente;
                info.IdVendedor = info_cliente.IdVendedor;
                //Obtenemos los demas datos que van a la cabecera del pedido 
                info.cp_fecha = this.dtFecha.Value;
                info.cp_diasPlazo = (this.txt_plazo.Text != "") ? Convert.ToInt32(this.txt_plazo.Text) : 0;
                info.cp_fechaVencimiento = this.dtFechaVenc.Value;
                info.cp_observacion = (this.txt_observacion.Text!="")?this.txt_observacion.Text: " ";        
                info.cp_tipopago = "CON";

                info.IdEstadoAprobacion= this.cmb_estado_aprobacion.SelectedValue.ToString();

                info.EstadoAprobacion = this.cmb_estado_aprobacion.Text;
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.Entregado = (cbxEntrega.Checked == true) ? "S" : "N";
                ///////////////////////////////////////////////////////////////
                info.IdEstadoProduccion = cmbEstadoProduccion.SelectedValue.ToString();
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS DETALLES DE LOS PRODUCTOS-----------------
                //---------------------------------------------------------------------
                lista_producto_detalle = new List<fa_pedido_det_Info>();
                //lista_producto_detalle = this.UCFAModuloFacturacion.get_Tabla_detalle();
                List<fa_pedido_det_Info> lm = new List<fa_pedido_det_Info>();
                         
                foreach (var item in lista_producto_detalle)
                {
                    fa_pedido_det_Info pedido_det = new fa_pedido_det_Info();
                    pedido_det.IdEmpresa = info.IdEmpresa;
                    pedido_det.IdSucursal = info.IdSucursal;
                    pedido_det.IdBodega = info.IdBodega;
                    pedido_det.IdPedido = info.IdPedido;           
                    pedido_det.Secuencial = item.Secuencial;
                    pedido_det.Peso = item.Peso;
                    pedido_det.IdProducto = item.IdProducto;
                    pedido_det.DesProduct = BusProd.Get_Descripcion_Producto(param.IdEmpresa,item.IdProducto);
                    pedido_det.dp_cantidad = item.dp_cantidad;
                    pedido_det.dp_precio = item.dp_precio;
                    pedido_det.dp_PorDescuento = item.dp_PorDescuento;
                    pedido_det.dp_desUni = item.dp_desUni;
                    pedido_det.dp_PrecioFinal = item.dp_PrecioFinal;
                    pedido_det.dp_subtotal = item.Subtotal;
                    pedido_det.dp_iva = item.dp_iva;
                    pedido_det.dp_total = item.dp_total;
                    pedido_det.dp_pagaIva = (item.Paga_Iva==true)?"S": "N";
                    pedido_det.dp_detallexItems = item.dp_detallexItems;

                 
                    lm.Add(pedido_det);
                }
                info.lista_detalle = lm;
                //---------------------------------------------------------------------
                //-----------------OBTENEMOS VALORES TOTALES DEL PEDIDO----------------
                //---------------------------------------------------------------------
                List<fa_pedido_valor_Info> lm_totales = new List<fa_pedido_valor_Info>();
                List<tb_sis_tipoDocumento_tipoValor_Info> lista_totales = new List<tb_sis_tipoDocumento_tipoValor_Info>();
                //lista_totales=UC_grid_totales.get_lista_detalle();
                foreach (var item1 in lista_totales)
                {
                    fa_pedido_valor_Info total_det = new fa_pedido_valor_Info();
                    total_det.IdEmpresa = info.IdEmpresa;
                    total_det.IdSucursal = info.IdSucursal;
                    total_det.IdBodega = info.IdBodega;
                    total_det.IdPedido = info.IdPedido;
                    total_det.IdTipoValor = item1.IdTipoValor;
                    total_det.signo = 1;
                    total_det.valor = item1.Valor;
                    lm_totales.Add(total_det);
                }
                info.lista_valores = lm_totales;
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_pedido_Info();
            }
        }
        
        public void set_Pedidos()
        {
            try
            {           
                info = new fa_pedido_Info();
                info_bodega = new tb_Bodega_Info();
                info_sucursal = new tb_Sucursal_Info();
                info.CodPedido = obj.CodPedido;
                info.Estado = obj.Estado;
                info.Bodega = obj.Bodega;
                info.Sucursal = obj.Sucursal;
                info.Vendedor = obj.Vendedor;
                info.Cliente = obj.Cliente;
                info.IdPedido = obj.IdPedido;
                info.IdSucursal = obj.IdSucursal;
                info.IdBodega = obj.IdBodega;
                info.IdCliente = obj.IdCliente;
                info.cp_diasPlazo = obj.cp_diasPlazo;
                info.cp_observacion = obj.cp_observacion;
                info.Otro1 = obj.Otro1;
                info.Otro2 = obj.Otro2;
                info.Trasnporte = obj.Trasnporte;
                info.Interes = obj.Interes;
                info.cp_fecha = obj.cp_fecha;
                txtCodigo.Text = obj.CodPedido;
                this.txt_pedido.Text = info.IdPedido.ToString();
                info.IdSucursal = info.IdSucursal;
                info_sucursal.IdSucursal = info.IdSucursal;
                info.IdBodega = info.IdBodega;
                info_bodega.IdSucursal = info.IdSucursal;
                info_bodega.IdBodega = info.IdBodega;
                UC_Cliente.cmb_cliente.EditValue = info.IdCliente;
                UC_Cliente.cmb_vendedor.Text = info.Vendedor;
                this.UC_Sucursal_Bodega.set_sucursal(info_sucursal);
                this.UC_Sucursal_Bodega.set_bodega(info_bodega);

                info.lista_detalle = obj.lista_detalle;

                dtFecha.Value = obj.cp_fecha;
                dtFechaVenc.Value = obj.cp_fechaVencimiento;
                txt_plazo.Text = obj.cp_diasPlazo.ToString();
                cmbEstadoProduccion.SelectedValue = obj.IdEstadoProduccion;
                      
                //consulta forma pago pedido
                ListaFormaPago = new List<fa_pedido_x_formaPago_Info>();
                ListaFormaPago = Bus_PedidoFormaPago.Get_List_pedido_x_formaPago(param.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdPedido);
                DataSource_PedForPag = new BindingList<fa_pedido_x_formaPago_Info>(ListaFormaPago);
                gridControlFormaPag.DataSource = DataSource_PedForPag;

                 string IdTipoFormaPago = "";
                 SumValForPag=0;
                 SumPorDist=0;
                
                foreach (var item1 in list_TerminoPago)
                {
                    foreach (var item2 in ListaFormaPago)
                    {
                        if (item1.IdTerminoPago == item2.IdTipoFormaPago)
                        {
                            IdTipoFormaPago = item1.IdTerminoPago;

                            SumPorDist = SumPorDist + item2.Por_Distribucion;
                            SumValForPag = SumValForPag + item2.Valor;
                        }
                    }
                }

                cmbTerminoPago.EditValue = IdTipoFormaPago;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
                //consulta forma pago pedido   
                    
                cmb_estado_aprobacion.SelectedValue= obj.IdEstadoAprobacion;
                txt_observacion.Text = obj.cp_observacion;
                cbxEntrega.Checked = (obj.Entregado=="S")?true:false;

                foreach (var item in info.lista_detalle)
                {
                    fa_pedido_det_Info tabla_pedido = new fa_pedido_det_Info();
                    //tabla_pedido.Codigo_Producto = item.CodProducto;
                    tabla_pedido.IdProducto = item.IdProducto;
                    tabla_pedido.dp_cantidad = item.dp_cantidad;
                    tabla_pedido.dp_PorDescuento = item.dp_PorDescuento;
                    tabla_pedido.dp_desUni = item.dp_desUni;
                    tabla_pedido.Peso = item.Peso;
                    tabla_pedido.dp_precio = item.dp_precio;
                    tabla_pedido.dp_PrecioFinal = item.dp_PrecioFinal;
                    tabla_pedido.Subtotal = item.dp_subtotal;
                    tabla_pedido.dp_total = item.dp_total;
                    tabla_pedido.dp_iva = item.dp_iva;
                    tabla_pedido.Paga_Iva = (item.dp_pagaIva=="S")?true:false;
                    tabla_pedido.dp_detallexItems = item.dp_detallexItems;
                    tabla_pedido.Secuencial = item.Secuencial;

                    lista_producto_detalle.Add(tabla_pedido);
                }
                
                //UCFAModuloFacturacion.set_grid_detalle(lista_producto_detalle);

                

                txtInteres.EditValue = obj.Interes;
                txtTransporte.EditValue = obj.Trasnporte;
                txtOtro1.EditValue = obj.Otro1;
                txtOtro2.EditValue = obj.Otro2;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }
    
        private void frmFA_Pedido_Mant_Load(object sender, EventArgs e)
        {            
            try
            {
                TipoPago();
                listPedidosNoDespachados = bus.Get_List_pedido(param.IdEmpresa);
                
                UCFAModuloFacturacion.ocultarIva();
                           
                Event_frmFA_Pedido_Mant_FormClosing += new delegate_frmFA_Pedido_Mant_FormClosing(frmFA_Pedido_Mant_Event_frmFA_Pedido_Mant_FormClosing);
                txt_plazo.Text = "3";
                dtFechaVenc.Value = dtFecha.Value.AddDays(3);
                UC_Cliente.CargarCombos();
               
                fa_catalogo_Bus busCatal = new fa_catalogo_Bus();
                cmbEstadoProduccion.DataSource = busCatal.Get_List_catalogo(1);
                          
                UC_Sucursal_Bodega.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;              
                UC_Cliente.txt_Direccion.Visible = false;
                UC_Cliente.txt_Ruc.Visible = false;
                UC_Cliente.txt_Telefonos.Visible = false;
                UC_Cliente.lbltelefono.Visible = false;
                UC_Cliente.llblRuc.Visible = false;
                UC_Cliente.lblDireccion.Visible = false;

                UCFAModuloFacturacion.Dock = DockStyle.Fill;
                UCFAModuloFacturacion.load_Producto(param.IdEmpresa, idsucursal, idbodega);
              
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.btn_grabar.Text = "Grabar Pedido";

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_Pedidos();
                        cargarGridOrdDesXpedi();
                        
                        UC_Cliente.cmb_cliente.Enabled = false;
                        this.btn_grabar.Text = "Actualizar Pedido";
                        txtCodigo.Enabled = false;
                        txt_pedido.Enabled = false;
                        

                         var q = from t in ListaOrdenDEspachoxPedido
                                 where t.IdPedido == obj.IdPedido
                                select t.IdProducto;
                         if (q.ToList().Count == 0)
                         { }
                         else
                         { }                      
                        UC_Sucursal_Bodega.Bloquerar_Combos();
                    
                        CalcularTotales();
                    
                        if (obj.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;                    
                        }
                                            
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_Pedidos();
                        cargarGridOrdDesXpedi();
                        this.btn_grabar.Text = "Anular Pedido";
                        if (obj.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;
                            btnLimpiar.Enabled = false;                     
                        }
                         btn_grabar.Enabled = false;                
                         btn_guardarSalir.Enabled = false;                  
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_Pedidos();
                        cargarGridOrdDesXpedi();
                        if (obj.Estado == "I")
                        {
                            lbl_Estado.Visible = true;
                            btn_grabar.Enabled = false;
                            btn_guardarSalir.Enabled = false;
                            btnLimpiar.Enabled = false;                     
                        }
                  
                        BtnAnular.Enabled = false;
                        btn_grabar.Enabled = false;
                        btn_guardarSalir.Enabled = false;
                        this.btn_grabar.Text = "Grabar";
                        CalcularTotales();
                        break;                                     
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void cargarGridOrdDesXpedi()
        {
            try
            {
                get_Pedido();
                fa_OrdenDespachoDet_bus busOrdeDesp = new fa_OrdenDespachoDet_bus();
                in_producto_Bus busprod = new in_producto_Bus();

                ListaOrdenDEspachoxPedido = busOrdeDesp.Get_List_orden_Desp_x_Pedido(obj);
                ListaOrdenDEspachoxPedido.ForEach(var => var.producto = busprod.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                gridControlOrdDesXpedi.DataSource = ListaOrdenDEspachoxPedido;
                gridViewOrddesXPedi.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
        
        void frmFA_Pedido_Mant_Event_frmFA_Pedido_Mant_FormClosing(object sender, EventArgs e){}
       
        public void CalcularTotales() 
        {
            try
            {
            double base0 = 0;
            double base12 = 0;
            double iva = 0;
            lista_producto_detalle = new List<fa_pedido_det_Info>();
            
            foreach (var item in lista_producto_detalle)
            {
                if (item.Paga_Iva == true)
                {
                    base12 += (item.Subtotal == null) ? 0 : item.Subtotal;
                }
                else
                {
                    base0 += (item.dp_total == null) ? 0 : item.dp_total;
                }
                iva += (item.dp_iva==null)?0:item.dp_iva;
            }
            txt_Base0.EditValue = (decimal)base0;
            txtBase12.EditValue = (decimal)base12;
            txtSubTotal.EditValue = (decimal)base0 + (decimal)base12;
            txtIva.EditValue = (decimal)iva;
            decimal otros;
            otros = Convert.ToDecimal(txtTransporte.EditValue)  + Convert.ToDecimal(txtInteres.EditValue) + Convert.ToDecimal(txtOtro1.EditValue) + Convert.ToDecimal(txtOtro2.EditValue);
            txtTotal.EditValue = Convert.ToDecimal(txtSubTotal.EditValue) + Convert.ToDecimal(txtIva.EditValue) + otros;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }                   
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (info.lista_detalle.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un producto para el pedido ", "Sistema ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
        private void Guardar()
        {
            try
            {
                Get_TerminoPago();

                if (bus.GrabarDB(info, ref id, ref msg))
                {
                    info.IdPedido = id;
                    info.Vendedor = UC_Cliente.cmb_vendedor.Text;

                    if (MessageBox.Show("Pedido # " + id + " Ingresada con éxito." + "\n" + "¿Desea Imprimir el Pedido N° " + id + "?", "Imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        toolStripButton1_Click(new Object(), new EventArgs());
                    }
                    else {}

                    txt_pedido.Text = id.ToString();
                    if (info.CodPedido == "")
                    {
                        txtCodigo.Text = "PED" + id;
                    }
                    else { txtCodigo.Text = info.CodPedido; }
                }
                else
                { MessageBox.Show(msg); }

            btn_grabar.Enabled = false;
            btn_guardarSalir.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private void Actualizar() 
        {
            try
            {
                info.IdUsuarioUltMod = param.IdUsuario;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                
                if (bus.ModificarDB(info, ref msg))
                {
                    MessageBox.Show(msg, "SISTEMA ERP");
                    btn_grabar.Enabled = false;
                    btn_guardarSalir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private void Accion_botton()
        {
            try
            {
                  switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                   
                    Guardar();
                    btn_grabar.Enabled = false;
                    btn_guardarSalir.Enabled = false;                 
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                                
                    frmFa_CausalesdeModificacio_Anulacion ofrm = new frmFa_CausalesdeModificacio_Anulacion();
                    ofrm.RetornodelId += ofrm_RetornodelId;
                    ofrm.ShowDialog();
                   
                    if (busdeta.VerificarOrdenDespacho(info))
                    {                                              
                        this.Actualizar();                                              
                    }
                    else
                    {                                          
                        var ListaPedidoDet = lista_producto_detalle.GroupBy(v => v.IdProducto).Select(g => new
                           {
                               Key = g.Key,
                               pe_cantidad = g.Sum(s=>s.dp_cantidad),
                               pe_IdProducto=g.First().IdProducto
                           });
                                                                                                                              
                        var ListaOrdDespPedido = ListaOrdenDEspachoxPedido.GroupBy(v => v.IdProducto).Select(g => new
                        {
                            Key = g.Key,
                            desp_cantidad = g.Sum(s => s.od_cantidad),
                            desp_IdProducto = g.First().IdProducto,
                            desp_pr_descripcion=g.First().pr_descripcion,
                            desp_IdOrdenDespacho=g.First().IdOrdenDespacho
                           
                        });
                
                        foreach (var itemLPD in ListaPedidoDet)
                        {                         
                            foreach (var itemLODP in ListaOrdDespPedido)
                            {
                                if (itemLPD.pe_IdProducto == itemLODP.desp_IdProducto)
                                {
                                    if (itemLODP.desp_cantidad <= itemLPD.pe_cantidad)
                                    { }
                                    else
                                    {
                                        MessageBox.Show("La cantidad a modificar del producto : [" + itemLPD.pe_IdProducto + "] - " + itemLODP.desp_pr_descripcion + ", del pedido #: " + info.IdPedido + " , no se puede modificar ya que dicha cantidad es menor al total de la cantidad de los items despachados en el despacho #:  " + itemLODP.desp_IdOrdenDespacho + "", "Sistemas");
                                                                                                                                                      
                                        // carga nuevamente el detalle de productos a su estado inicial
                                        UCFAModuloFacturacion.Clear_Ugrid();
                                        info.lista_detalle = obj.lista_detalle;

                                        lista_producto_detalle = new List<fa_pedido_det_Info>();

                                        foreach (var item1 in info.lista_detalle)
                                        {
                                            fa_pedido_det_Info tabla_pedido = new fa_pedido_det_Info();

                                            //tabla_pedido.Codigo_Producto = item1.CodProducto;
                                            tabla_pedido.IdProducto = item1.IdProducto;
                                            tabla_pedido.dp_cantidad = item1.dp_cantidad;
                                            tabla_pedido.dp_PorDescuento = item1.dp_PorDescuento;
                                            tabla_pedido.dp_desUni = item1.dp_desUni;
                                            tabla_pedido.Peso = item1.Peso;
                                            tabla_pedido.dp_precio = item1.dp_precio;
                                            tabla_pedido.dp_PrecioFinal = item1.dp_PrecioFinal;
                                            tabla_pedido.Subtotal = item1.dp_subtotal;
                                            tabla_pedido.dp_total = item1.dp_total;
                                            tabla_pedido.dp_iva = item1.dp_iva;
                                            tabla_pedido.Paga_Iva = (item1.dp_pagaIva == "S") ? true : false;
                                            tabla_pedido.dp_detallexItems  = item1.dp_detallexItems;
                                            lista_producto_detalle.Add(tabla_pedido);
                                        }
                                        
                                        CalcularTotales();
                                        return;
                                    } 
                                }
                            }
                        }
                
                        this.Actualizar();                           
                    }                 
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:

                    break;
            }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        void ofrm_RetornodelId(string TipoAnulacion)
        {
            info.MotivoAnulacion = TipoAnulacion;                
        }
        
        public Boolean Validar()
        {
            try
                {
                   Valida_IdSucursal = param.IdSucursal;

                   if (Valida_IdSucursal != info_sucursal.IdSucursal)
                    {
                        MessageBox.Show("El usuario : " + param.IdUsuario + " , no tiene asignada la bodega : " + info_sucursal.Su_Descripcion + "");
                        return false;
                    }
                                            
                if (info.IdCliente == 0)
                {
                    MessageBox.Show("Por Favor Seleccione un cliente");
                    return false;
                }
                if (info.IdVendedor == 0 )
                {
                    MessageBox.Show("Por Favor Seleccione un vendedor");
                    return false;           
                }

                if (this.cmbTerminoPago.EditValue == null || cmbTerminoPago.EditValue == "")
                {
                    MessageBox.Show("Ingrese el Término de Pago ", "Sistemas");
                    return false;
                }
                if (info.lista_detalle.Count() == 0)
                {
                    MessageBox.Show("Por Favor Seleccione Al Menos un producto");
                    return false;
                }
                else 
                {
                    foreach (var item in info.lista_detalle)
                    {
                        if (item.dp_cantidad == 0 && item.IdProducto != 0)
                        {
                            MessageBox.Show("Por Favor Ingrese cantidad a/los Productos");
                            return false;
                        }

                        if (item.dp_precio == 0 && item.IdProducto != 0)
                        {
                            MessageBox.Show("Por Favor Ingrese precio a/los Productos");
                            return false;
                        }
                    }
                }

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (bus.VerificarCodigo(info.CodPedido))
                    {
                        MessageBox.Show("El Código Ingresado ya existe por favor ingrese uno diferente");
                        return false;
                    }
                }                  
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }
       
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {                           
                txt_observacion.Focus();                             
                get_Pedido();

                if (Validar())
                {
                  Accion_botton();                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }         
        }

        private void btn_guardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    btn_grabar_Click(sender, e);
                    this.Close();
                }              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());              
            }
        }
      
        private void txtTransporte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }          
        }

        private void txtInteres_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtOtro1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }

        private void txtOtro2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        void ofrm_RetornodelId2(string TipoAnulacion)
        {
            try
            {
            if (busdeta.VerificarOrdenDespacho(info))
                {

                    info.IdEmpresa = param.IdEmpresa;
                    info.IdUsuarioUltAnu = param.IdUsuario;
                    info.Fecha_UltAnu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    info.MotivoAnulacion = TipoAnulacion;
                    if (MessageBox.Show("¿Está seguro que desea anular el pedido #" + txt_pedido.Text + " ?", "Anulación de Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensej = "";
                        if (bus.AnularDB(info, ref mensej))
                        {
                            MessageBox.Show("Anulado con éxito el pedido # " + info.IdPedido);
                            lbl_Estado.Visible = true;
                            btn_guardarSalir.Enabled = false;
                            btn_grabar.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede anular el pedido #: " + txt_pedido.Text + "  ya que tiene una Orden de despacho Activa");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }
        
        private void BtnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                frmFa_CausalesdeModificacio_Anulacion ofrm = new frmFa_CausalesdeModificacio_Anulacion();
                ofrm.RetornodelId += ofrm_RetornodelId2;
                ofrm.Show();                        
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void txt_plazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                 if (Funciones.ValidaNumero(e.KeyChar))
                    {
                    e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }
       
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

                XFAC_CUS_TAL_Rpt001_rpt REPORTE = new XFAC_CUS_TAL_Rpt001_rpt();

               
                int idSucursal=0;
                int idBodega=0;
                decimal idpedido=0;

                idSucursal = UC_Sucursal_Bodega.get_sucursal().IdSucursal;
                idBodega = UC_Sucursal_Bodega.get_bodega().IdBodega;
                idpedido = Convert.ToDecimal(txt_pedido.Text);

                REPORTE.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                REPORTE.Parameters["IdSucursal"].Value = idSucursal;
                REPORTE.Parameters["IdBodega"].Value = idBodega;
                REPORTE.Parameters["IdPedido"].Value = idpedido;


                REPORTE.RequestParameters = false;// para q no me obligue a pedir parametros 
                ReportPrintTool pt = new ReportPrintTool(REPORTE);
                pt.AutoShowParametersPanel = false;


                               
                REPORTE.ShowPreview();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtFechaVenc_ValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }
       
        private void dtFechaVenc_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(dtFecha.Value.ToShortDateString()) > Convert.ToDateTime(dtFechaVenc.Value.ToShortDateString()))
                {
                    dtFechaVenc.Value = dtFecha.Value.AddDays(+1);               
                }

                if (CambioFecha)
                {
                    CambioFecha = false;
                    txt_plazo.Text = Math.Round((dtFechaVenc.Value - dtFecha.Value).TotalDays).ToString();
                }
                else
                {
                    CambioFecha = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());           
            }
        }

        private void frmFA_Pedido_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 Event_frmFA_Pedido_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {                
            info = new fa_pedido_Info();
            UC_Cliente.cmb_cliente.Enabled = true;
            txt_Base0.EditValue = 0;
            txt_cupo_maximo.Text = "";
            txt_observacion.Text = "";
            txt_pedido.Text = "";
            txt_plazo.Text = "";
            txtBase12.EditValue = 0;
            txtInteres.EditValue = 0;
            txtIva.EditValue = 0;
            txtOtro1.EditValue = 0;
            txtOtro2.EditValue = 0;
            txtSubTotal.EditValue = 0;
            txtTotal.EditValue = 0;
            txtTransporte.EditValue = 0;
            UC_Cliente.cmb_cliente.EditValue = "";
            UC_Cliente.cmb_vendedor.EditValue = "";
            txtCodigo.Text = "";
            btn_grabar.Enabled = true;
            btn_guardarSalir.Enabled = true;
           
            UCFAModuloFacturacion.Clear_Ugrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());              
            }
        }

        private void txtTotal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (banderaCombo)
                    {
                        if (Convert.ToInt32(txt_cupo_maximo.Text) == 0)
                        {
                        }
                        else
                        {
                            double Total_NoDespachado = 0;                           
                            var item = listPedidosNoDespachados.FirstOrDefault(r => r.IdCliente ==Convert.ToDecimal(UC_Cliente.cmb_cliente.EditValue));

                            if (item == null)
                            {
                                Total_NoDespachado = 0;                               
                            }
                            else
                            {
                                Total_NoDespachado = item.dp_total;
                            }

                            double Total_Disponible = Convert.ToDouble(txtTotal.EditValue) + Total_NoDespachado;
                        
                            if (Convert.ToDecimal(Total_Disponible) > Convert.ToDecimal(txt_cupo_maximo.Text))
                            {
                                MessageBox.Show("El valor del pedido ha exedido el cupo del Cliente este se guardara en estado de negociacion ");
                                cmb_estado_aprobacion.SelectedValue = "N";
                            }
                            else
                            {
                                cmb_estado_aprobacion.SelectedValue = "A";
                            }
                        }
                        banderaCombo = false;
                    }
            
                fa_TerminoPago_Info objCmb = new fa_TerminoPago_Info();
                objCmb.IdTerminoPago = Convert.ToString(cmbTerminoPago.EditValue);
                         
                ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                    return;
                }

                List = new List<fa_factura_x_fa_TerminoPago_Info>();
                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in ListPagoDistri)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Secuencia = item.Secuencia;
                    info.Por_Distribucion = item.Por_distribucion;
                    DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                    info.Fecha_vct = fecha;
                    info.Dias_Plazo = item.Num_Dias_Vcto;
                    info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                    info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;

                    List.Add(info);
                }

                DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info >(List);
                gridControlFormaPag.DataSource = DataSource_ForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }
  
        private void txt_plazo_Leave(object sender, EventArgs e)
        {
            try
            {
                var Consulta = BusCalendario.Get_List_DiasSinFeriadoNiSabadosNiDomingos(dtFecha.Value, Convert.ToInt32(txt_plazo.Text));             
                    CambioCantidad = false;
                    dtFechaVenc.Value = Consulta.Last().fecha;              
                    CambioCantidad = true;             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void cmbTerminoPago_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                fa_TerminoPago_Info objCmb = (fa_TerminoPago_Info)cmbTerminoPago.Properties.View.GetFocusedRow();
                ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                    return;
                }

                List = new List<fa_factura_x_fa_TerminoPago_Info>();
                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in ListPagoDistri)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Secuencia = item.Secuencia;
                    info.Por_Distribucion = item.Por_distribucion;
                    DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                    info.Fecha_vct = fecha;
                    info.Dias_Plazo = item.Num_Dias_Vcto;
                    info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                    info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;

                    List.Add(info);
                }

                DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                gridControlFormaPag.DataSource = DataSource_ForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        private void txtTotal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (banderaCombo)
                {
                    if (Convert.ToInt32(txt_cupo_maximo.Text) == 0)
                    {
                    }
                    else
                    {
                        double Total_NoDespachado = 0;
                        var item = listPedidosNoDespachados.FirstOrDefault(r => r.IdCliente == Convert.ToDecimal(UC_Cliente.cmb_cliente.EditValue));

                        if (item == null)
                        {
                            Total_NoDespachado = 0;
                        }
                        else
                        {
                            Total_NoDespachado = item.dp_total;
                        }

                        double Total_Disponible = Convert.ToDouble(txtTotal.EditValue) + Total_NoDespachado;

                        if (Convert.ToDecimal(Total_Disponible) > Convert.ToDecimal(txt_cupo_maximo.Text))
                        {
                            MessageBox.Show("El valor del pedido ha exedido el cupo del Cliente este se guardara en estado de negociacion ");
                            cmb_estado_aprobacion.SelectedValue = "N";
                        }
                        else
                        {
                            cmb_estado_aprobacion.SelectedValue = "A";
                        }
                    }
                    banderaCombo = false;
                }

                fa_TerminoPago_Info objCmb = new fa_TerminoPago_Info();
                objCmb.IdTerminoPago = Convert.ToString(cmbTerminoPago.EditValue);

                ListPagoDistri = BusPagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);

                if (Convert.ToDouble(this.txtTotal.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese el valor total de la factura .", "Sistemas");
                    return;
                }

                List = new List<fa_factura_x_fa_TerminoPago_Info>();
                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in ListPagoDistri)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Secuencia = item.Secuencia;
                    info.Por_Distribucion = item.Por_distribucion;
                    DateTime fecha = dtFecha.Value.AddDays(item.Num_Dias_Vcto);
                    info.Fecha_vct = fecha;
                    info.Dias_Plazo = item.Num_Dias_Vcto;
                    info.Valor = Convert.ToDouble(txtTotal.EditValue) * (item.Por_distribucion / 100);
                    info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;

                    List.Add(info);
                }

                DataSource_ForPag = new BindingList<fa_factura_x_fa_TerminoPago_Info>(List);
                gridControlFormaPag.DataSource = DataSource_ForPag;

                txtValForPag.Text = Convert.ToString(SumValForPag);
                txtPorDist.Text = Convert.ToString(SumPorDist);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }

        private void txtTransporte_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        private void txtInteres_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtOtro1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }  
        }

        private void txtOtro2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
    }
}
