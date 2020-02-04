using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Orden_Despacho_Mant : Form
    {
        #region variables
        
        // Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_orden_Desp_Bus Bus = new fa_orden_Desp_Bus();
        fa_guia_remision_Bus BusGuia = new fa_guia_remision_Bus();
        fa_OrdenDespachoDet_bus busDetalle = new fa_OrdenDespachoDet_bus();
        fa_guia_remision_det_x_orden_despacho_det_bus busGuia = new fa_guia_remision_det_x_orden_despacho_det_bus();
              
        // List       
        List<fa_orden_Desp_det_Info> ListaGrid = new List<fa_orden_Desp_det_Info>();
        List<fa_pedido_det_Info> ListItemsPedidosChekeados = new List<fa_pedido_det_Info>();
        List<fa_pedido_det_Info> ListItemsPedidosUnChekeados = new List<fa_pedido_det_Info>();                
        List<fa_orden_Desp_det_x_fa_pedido_det_Info> Auxiliar = new List<fa_orden_Desp_det_x_fa_pedido_det_Info>();
        List<fa_pedido_det_Info> listapedido = new List<fa_pedido_det_Info>();
        List<fa_guia_remision_det_x_fa_orden_Desp_det_Info> listaGuia = new List<fa_guia_remision_det_x_fa_orden_Desp_det_Info>();

        // Info
        fa_guia_remision_Info consult = new fa_guia_remision_Info();
        List<fa_guia_remision_Info> ListGuia = new List<fa_guia_remision_Info>();

        private Cl_Enumeradores.eTipo_action _Accion;
        public delegate void Delegate_frmFA_OrdenDespacho_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmFA_OrdenDespacho_Mant_FormClosing Event_frmFA_OrdenDespacho_Mant_FormClosing;

        UCFa_Cliente_Facturacion ctrl_Cliente;
        UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_Producto_Info> lst = new List<in_Producto_Info>();
        List<fa_orden_Desp_det_Info> listaGridPedido = new List<fa_orden_Desp_det_Info>();
        in_Producto_Info detalleOrden = new in_Producto_Info();
        fa_orden_Desp_Info _Info = new fa_orden_Desp_Info();
        public fa_orden_Desp_Info SetInfo { get; set; }


        #endregion
           
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public frmFa_Orden_Despacho_Mant()
        {
            try
            {
             InitializeComponent();
             ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
             ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
             ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
             ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
             ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
             ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ctrl_Cliente = new UCFa_Cliente_Facturacion();
              //  ctrl_Cliente.Envent_cmb_cliente_SelectionChangeCommitted += new UCFa_Cliente_Facturacion.delegate_cmb_cliente_SelectionChangeCommitted(ctrl_Cliente_Envent_cmb_cliente_SelectionChangeCommitted);
              //  ctrl_Cliente.Event_cmb_cliente_RowSelected += new UCFa_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(ctrl_Cliente_Event_cmb_cliente_RowSelected);
                ctrl_SucBod.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted);
                ctrl_SucBod.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted);

                ctrl_Cliente.Event_cmb_cliente_EditValueChanged += ctrl_Cliente_Event_cmb_cliente_EditValueChanged;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ctrl_Cliente_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                VaciarGrid();
                cargarpedidoxCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                ultraComboEditorTransportista.EditValue = 0;
                ctrl_Cliente.cmb_cliente.EditValue = 0;
                txtCodigo.Text = "";
                txtIdOrdenDespacho.Text = "";
                txtKilos.EditValue = 0;
                txtObservacion.Text = "";
                // txtPlazo.Value = 0;
                txtquintales.EditValue = 0;
                _Info = new fa_orden_Desp_Info();
                VaciarGrid();
                cargarpedidoxCliente();

                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                this.Text = "Orden Despacho Mantenimiento";
                ctrl_Cliente.Enabled = true;
                ctrl_SucBod.Enabled = true;
                lblAnulado.Visible = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                //XRpt_fa_orden_Despachi xprt = new XRpt_fa_orden_Despachi();
                fa_rpt_orden_Desp_Info InfoReport = new fa_rpt_orden_Desp_Info();

                List<fa_rpt_orden_Desp_Info> lstReport = new List<fa_rpt_orden_Desp_Info>();
                _Info.Vendedor = ctrl_Cliente.cmb_vendedor.Text;
                _Info.Cliente = ctrl_Cliente.cmb_cliente.Text;
                _Info.Sucursal = ctrl_SucBod.cmb_sucursal.Text;
                _Info.Bodega = ctrl_SucBod.cmb_bodega.Text;
                List<fa_orden_Desp_det_Info> lsttmp = new List<fa_orden_Desp_det_Info>();
                lsttmp = busDetalle.Get_List_orden_Desp_det(_Info);
                lsttmp.ForEach(var => var.pr_descripcion = obtnerDesProd(var.IdProducto));
                _Info.ListaDetalle = lsttmp;
                InfoReport.info = _Info;
                InfoReport.ListDetalle = _Info.ListaDetalle;
                InfoReport.empresainfo = param.InfoEmpresa;
                //InfoReport.info.TOTAL = (double)txtTotal.Value;
                lstReport.Add(InfoReport);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    _Info = new fa_orden_Desp_Info();
                    _Info.Estado = "A";
                }
                else
                {
                    _Info.Estado = SetInfo.Estado;
                }
                //xprt.loadData(lstReport.ToArray(), _Info.Estado);
                //xprt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                txtCodigo.Focus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
                cargarpedidoxCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (consult.IdGuiaRemision != 0)
                {
                    ListGuia.Add(consult);
                    MessageBox.Show("No se puede Modificar Orden despacho ya que tiene una Guia de Remision Activa");
                    return;
                }

                Get();
                fa_orden_Desp_det_x_fa_pedido_det_Bus busaux = new fa_orden_Desp_det_x_fa_pedido_det_Bus();

                _Info.ListaAuxiliar = busaux.Get_List_fa_orden_Desp_det_x_fa_pedido_det_x_Pedido(_Info);
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                if (_Info.IdOrdenDespacho == 0)
                { return; }
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("No se puede anular orden de despacho por que ya se encuentra anulada", "Sistema Erp");
                    return;
                }
                if (MessageBox.Show("¿Está seguro que desea anular la orden de despacho ?", "Anulación de orden de despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    _Info.MotivoAnu = ofrm.motivoAnulacion;
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Fecha_UltAnu = DateTime.Now;
                    if (ofrm.cerrado == "N")
                    {
                        Bus.ActualizarEstado(param.IdEmpresa, _Info);
                        MessageBox.Show("Se procedio anular la Orden de Despacho # :" + txtIdOrdenDespacho.Text + "Exitosamente", "Sistema Erp");
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                loadGridProductos();
                ctrl_Cliente.CargarCombosXsucurlsa(Convert.ToInt32(ctrl_SucBod.cmb_sucursal.EditValue));
                cargarpedidoxCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    loadGridProductos();
                    cargarpedidoxCliente();
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                }               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
      
        }

        public void VaciarGrid() 
        {
            try
            {
                List<fa_orden_Desp_det_Info> vaciar = new List<fa_orden_Desp_det_Info>();
                gridControlOrdenDespacho.DataSource = null;
                gridControlOrdenDespacho.DataSource = vaciar;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void cargarpedidoxCliente() 
        {
            try
            {
                fa_pedido_Bus bus = new fa_pedido_Bus();
                fa_orden_Desp_Info ordenInfo = new fa_orden_Desp_Info();
                ordenInfo.IdCliente = Convert.ToDecimal(ctrl_Cliente.cmb_cliente.EditValue);
                ordenInfo.IdBodega = Convert.ToInt32(ctrl_SucBod.cmb_bodega.EditValue);
                ordenInfo.IdSucursal = Convert.ToInt32(ctrl_SucBod.cmb_sucursal.EditValue);
                ordenInfo.IdEmpresa = param.IdEmpresa;

                listapedido = bus.ObtenerOrdenDespachoxCliente(ordenInfo);
                listapedido.ForEach(id => id.DesProduct = obtnerDesProd(id.IdProducto));

                var listado = from q in listapedido
                              where q.IdSucursal == ordenInfo.IdSucursal && q.IdBodega == ordenInfo.IdBodega
                              select q;

                gridControlPedido.DataSource = listado.ToList();
                gridViewPedido.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void cargarTransportistas() 
        {
            try
            {
                tb_transportista_Bus Bustransportista = new tb_transportista_Bus();
                ultraComboEditorTransportista.Properties.DataSource = Bustransportista.Get_List_transportista(param.IdEmpresa);
                ultraComboEditorTransportista.Properties.DisplayMember = "Nombre";
                ultraComboEditorTransportista.Properties.ValueMember = "IdTransportista";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        public string obtnerDesProd(decimal idproducto) 
        {             
           try
            {
                var desc = lst.First(var => var.IdProducto == idproducto);

                return desc.pr_descripcion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return "";
            }       
        }
       
        public void cargarControles() 
        {
            try
            {
                ctrl_Cliente.Dock = DockStyle.Fill;
                ctrl_Cliente.llblRuc.Visible = false;
                ctrl_Cliente.lbltelefono.Visible = false;
                ctrl_Cliente.txt_Ruc.Visible = false;
                ctrl_Cliente.txt_Telefonos.Visible = false;
                ctrl_Cliente.cmb_vendedor.Visible = false;
                ctrl_Cliente.lblVendedor.Visible = false;
                ctrl_Cliente.txt_Direccion.Visible = false;
                ctrl_Cliente.lblDireccion.Visible = false;
                pnlCliente.Controls.Add(ctrl_Cliente);
                ctrl_SucBod.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                ctrl_SucBod.Dock = DockStyle.Fill;
                pnlSucBod.Controls.Add(ctrl_SucBod);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void loadGridProductos()
        {
            try
            {
                in_producto_busqueda_Bus ob = new in_producto_busqueda_Bus();
                List<in_categorias_Info> LstCate_I = new List<in_categorias_Info>();
                lst = ob.obtenerListProducto(LstCate_I, param.IdEmpresa, Convert.ToInt32(ctrl_SucBod.cmb_sucursal.EditValue), Convert.ToInt32(ctrl_SucBod.cmb_bodega.EditValue));
                gridControlProductos.DataSource = lst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmFA_OrdenDespacho_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cargarTransportistas();
                cargarControles();
                loadGridProductos();
                ctrl_Cliente.CargarCombosXsucurlsa(Convert.ToInt32(ctrl_SucBod.cmb_sucursal.EditValue));
                Event_frmFA_OrdenDespacho_Mant_FormClosing += new Delegate_frmFA_OrdenDespacho_Mant_FormClosing(frmFA_OrdenDespacho_Mant_Event_frmFA_OrdenDespacho_Mant_FormClosing);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        if (SetInfo.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }                      

                        ctrl_SucBod.Enabled = false;
                        ctrl_Cliente.Enabled = false;
                        
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;                     
                        ckbDespacho.Enabled = false;
                                                
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        if (SetInfo.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        panelPedidosYProductos.Enabled = false;
                        ctrl_SucBod.Enabled = false;
                        ctrl_Cliente.Enabled = false;                     
                        

                        Inhabitar_Campos();
                        this.od_cantidad.OptionsColumn.AllowEdit = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        if (SetInfo.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        panelPedidosYProductos.Enabled = false;
                        ctrl_SucBod.Enabled = false;
                        ctrl_Cliente.Enabled = false;  
                        
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                       

                        gridViewOrdenDesapacho.OptionsBehavior.Editable = false;


                        Inhabitar_Campos();

                        this.od_cantidad.OptionsColumn.AllowEdit = false;
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

        void frmFA_OrdenDespacho_Mant_Event_frmFA_OrdenDespacho_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        void Inhabitar_Campos()
        {
            try
            {
                this.txtCodigo.Enabled = false;
                this.txtCodigo.BackColor = System.Drawing.Color.White;
                this.txtCodigo.ForeColor = System.Drawing.Color.Black;
                dateFecha.Enabled = false;
                this.dateFecha.BackColor = System.Drawing.Color.White;
                this.dateFecha.ForeColor = System.Drawing.Color.Black;
                this.ultraComboEditorTransportista.Enabled = false;
                this.txtKilos.Enabled = false;
                this.txtKilos.BackColor = System.Drawing.Color.White;
                this.txtKilos.ForeColor = System.Drawing.Color.Black;
                this.txtquintales.Enabled = false;
                this.txtquintales.BackColor = System.Drawing.Color.White;
                this.txtquintales.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {               
                  Log_Error_bus.Log_Error(ex.ToString());
            }                       
        }

        private void ckbDespacho_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    TabPage page2 = tabControl.TabPages[0];
                    TabPage page1 = tabControl.TabPages[1];
                    if (ckbDespacho.Checked == true)
                    {
                        tabControl.SelectedTab = page1;
                        loadGridProductos();
                        VaciarGrid();
                    }
                    else
                    {
                        tabControl.SelectedTab = page2;
                        cargarpedidoxCliente();
                        VaciarGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TabPage page2 = tabControl.TabPages[0];
                TabPage page1 = tabControl.TabPages[1];

                if (tabControl.SelectedTab == page2)
                {
                    ckbDespacho.Checked = false;
                    loadGridProductos();
                    VaciarGrid();
                }
                else
                {
                    ckbDespacho.Checked = true;
                    cargarpedidoxCliente();
                    VaciarGrid();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private in_Producto_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (in_Producto_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_Producto_Info();
            }
        }

        public void setproduct(fa_orden_Desp_det_Info set, in_Producto_Info ItemChek) 
        {
            try
            {
                set.IdProducto = ItemChek.IdProducto;
                set.pr_descripcion = ItemChek.pr_descripcion;
                set.od_tieneIVA = ItemChek.pr_ManejaIva;
                set.od_Precio = (float)ItemChek.pr_precio_publico;
                set.od_PrecioFinal = (float)ItemChek.pr_precio_publico;
                set.od_Subtotal = 0;
                set.od_DescUnitario = 0;
                set.od_PorDescUnitario = 0;
                set.od_cantidad = 0;
                set.cantidaajus = 0;
                set.Saldo = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void llenarGriddetalle()
        {
            try
            {
                List<in_Producto_Info> ListaProduactos = new List<in_Producto_Info>();
                ListaProduactos = (List<in_Producto_Info>)gridViewProductos.DataSource;

                List<fa_orden_Desp_det_Info> ListaItemsCheck = new List<fa_orden_Desp_det_Info>();
                ListaGrid = new List<fa_orden_Desp_det_Info>();

                foreach (var item in ListaProduactos)
                {
                    if (item.Cheked == true)
                    {
                        fa_orden_Desp_det_Info set = new fa_orden_Desp_det_Info();
                        set.IdProducto = item.IdProducto;
                        set.pr_descripcion = item.pr_descripcion;
                        set.od_tieneIVA = item.pr_ManejaIva;
                        set.od_Precio = (float)item.pr_precio_publico;
                        set.od_PrecioFinal = (float)item.pr_precio_publico;
                        set.od_Subtotal = 0;
                        set.od_DescUnitario = 0;
                        set.od_PorDescUnitario = 0;
                        set.od_cantidad = 0;
                        set.cantidaajus = 0;
                        set.Saldo = 0;

                        ListaItemsCheck.Add(set);
                    }
                }
                gridControlOrdenDespacho.DataSource = ListaGrid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void gridViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {            
            try
            {
                in_Producto_Info ItemChek = new in_Producto_Info();
                if (gridControlOrdenDespacho.DataSource == null)
                {
                    gridControlOrdenDespacho.DataSource = new List<fa_orden_Desp_det_Info>();
                }
                ListaGrid = new List<fa_orden_Desp_det_Info>();
                ListaGrid = (List<fa_orden_Desp_det_Info>)gridControlOrdenDespacho.DataSource;
                ItemChek = (in_Producto_Info)gridViewProductos.GetRow(gridViewProductos.FocusedRowHandle);

                fa_orden_Desp_det_Info set = new fa_orden_Desp_det_Info();

                if ((Boolean)gridViewProductos.GetFocusedRowCellValue(Cheked)) 
                {
                    gridViewProductos.SetFocusedRowCellValue(Cheked, false);
                    setproduct(set, ItemChek);

                    fa_orden_Desp_det_Info remo = ListaGrid.Find(var => var.IdProducto == set.IdProducto );
                    ListaGrid.Remove(remo);               
                }
                else
                {
                    gridViewProductos.SetFocusedRowCellValue(Cheked, true);
                    setproduct(set, ItemChek);
                    ListaGrid.Add(set);
                }

                List<fa_orden_Desp_det_Info> NULLA = new List<fa_orden_Desp_det_Info>();
                gridControlOrdenDespacho.DataSource = NULLA;
                gridControlOrdenDespacho.DataSource = ListaGrid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
        private void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               llenarGriddetalle();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void llenarinfo(ref fa_pedido_det_Info ItemChek, ref fa_orden_Desp_det_Info set) 
        {
            try
            {
                set.IdProducto = ItemChek.IdProducto;
                set.pr_descripcion = ItemChek.DesProduct;
                set.IdPedido = ItemChek.IdPedido;
                set.od_pedido = (decimal)ItemChek.dp_saldo;
                set.od_cantidad = 0;
                set.od_total = (float)ItemChek.dp_total;
                set.od_tieneIVA = ItemChek.dp_pagaIva;
                set.od_Subtotal = (float)ItemChek.dp_subtotal;
                set.od_PorDescUnitario = (float)ItemChek.dp_PorDescuento;
                set.od_DescUnitario = (float)ItemChek.dp_desUni;
                set.od_detallexItems = ItemChek.dp_detallexItems;
                set.od_iva = (float)ItemChek.dp_iva;
                set.cantidaajus = 0;
                set.Saldo = 0;
                set.od_Precio = (float)ItemChek.dp_precio;
                set.od_PrecioFinal = (float)ItemChek.dp_PrecioFinal;
                set.SecuenciaPedido = ItemChek.Secuencial;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
        
        private void gridViewPedido_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                fa_pedido_det_Info ItemChek = new fa_pedido_det_Info();
                if (gridControlOrdenDespacho.DataSource == null)
                { 
                    gridControlOrdenDespacho.DataSource= new List<fa_orden_Desp_det_Info>();
                }
                ListaGrid = new List<fa_orden_Desp_det_Info>();
                ListaGrid = (List<fa_orden_Desp_det_Info>)gridControlOrdenDespacho.DataSource;
                ItemChek = (fa_pedido_det_Info)gridViewPedido.GetRow(gridViewPedido.FocusedRowHandle);
                fa_orden_Desp_det_Info set = new fa_orden_Desp_det_Info();
                if ((Boolean)gridViewPedido.GetFocusedRowCellValue(Checked))  
                {
                    gridViewPedido.SetFocusedRowCellValue(Checked, false); 
                    llenarinfo(ref ItemChek, ref set);
                    fa_orden_Desp_det_Info remo = ListaGrid.Find(var => var.IdProducto == set.IdProducto&& var.IdEmpresa == set.IdEmpresa && var.IdPedido == set.IdPedido && var.IdSucursal == set.IdSucursal && var.Secuencia == set.Secuencia && var.IdBodega == set.IdBodega);
                    ListaGrid.Remove(remo);
                }
                else
                {
                    gridViewPedido.SetFocusedRowCellValue(Checked, true); // cheked
                    llenarinfo(ref ItemChek, ref set);
                    ListaGrid.Add(set);

                }
                List<fa_orden_Desp_det_Info> NULLA = new List<fa_orden_Desp_det_Info>();
                gridControlOrdenDespacho.DataSource = NULLA;
                gridControlOrdenDespacho.DataSource = ListaGrid;               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
             
        public void Get()
        {
            try
            {
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.IdOrdenDespacho = Convert.ToDecimal((txtIdOrdenDespacho.Text == "") ? "0" : txtIdOrdenDespacho.Text);
                _Info.IdBodega = Convert.ToInt32(ctrl_SucBod.cmb_bodega.EditValue);
                _Info.IdSucursal = Convert.ToInt32(ctrl_SucBod.cmb_sucursal.EditValue);
                _Info.CodOrden = txtCodigo.Text;
                _Info.IdCliente = Convert.ToDecimal(ctrl_Cliente.cmb_cliente.EditValue);
                _Info.IdVendedor = Convert.ToInt32(ctrl_Cliente.cmb_vendedor.EditValue);
                _Info.IdTransportista = Convert.ToDecimal(ultraComboEditorTransportista.EditValue);
                _Info.od_fecha = Convert.ToDateTime(dateFecha.Value.ToShortDateString());
               // _Info.od_plazo = Convert.ToInt32(txtPlazo.Value);
                _Info.od_plazo = 0;
                _Info.od_fech_venc = Convert.ToDateTime(dateFechavencimiento.Value.ToShortDateString());
                _Info.od_Observacion = txtObservacion.Text;
                _Info.od_TotalKilos = (float)(Convert.ToDouble(txtKilos.EditValue));
                _Info.od_TotalQuintales = (float)(Convert.ToDouble(txtquintales.EditValue));
                _Info.IdUsuario = param.IdUsuario;
                _Info.Fecha_Transac = DateTime.Now;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;
                _Info.od_DespAbierto = (ckbDespacho.Checked) ? "S" : "N";

                if (gridControlOrdenDespacho.DataSource == null)
                {
                    gridControlOrdenDespacho.DataSource = new List<fa_orden_Desp_det_Info>();
                }
                _Info.ListaDetalle = (List<fa_orden_Desp_det_Info>)gridControlOrdenDespacho.DataSource;
                (from q in _Info.ListaDetalle select q).ToList().ForEach(var => { var.IdBodega = _Info.IdBodega; var.IdSucursal = _Info.IdSucursal; });
                int c = 1;
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void guardar() 
        {
            try
            {
                 decimal IdOrdenDespacho=0;
                if(Bus.VerificarCodigo(txtCodigo.Text,param.IdEmpresa))
                    {
                        MessageBox.Show("El codigo Ingresado Ya exite por favor ingrese uno diferente","Sistema Erp");
                        return;
                    }
                if (Validar())
                {               
                    if (Bus.GuardarDB(_Info, ref IdOrdenDespacho))
                    {                  
                        txtIdOrdenDespacho.Text = IdOrdenDespacho.ToString();

                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ctrl_SucBod.Enabled = false;
                        ctrl_Cliente.Enabled = false;
                        if (txtCodigo.Text == "")
                        {
                            txtCodigo.Text = "Ord" + IdOrdenDespacho;
                        }

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        if (MessageBox.Show("Orden Despacho # " + IdOrdenDespacho + " Ingresada con exito." + "\n" + "¿Desea Imprimir el Orden De Despacho N° " + IdOrdenDespacho + "?", "Imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ucGe_Menu_event_btnImprimir_Click(new Object(), new EventArgs());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Actualizar()
        {
            try
            {                
                string msg = "";
                _Info.ListaGuiaRemision = listaGuia;
                if (Bus.ModificarDB(param.IdEmpresa, _Info, ref msg))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Orden de Despacho", txtIdOrdenDespacho.Text);
                    MessageBox.Show(smensaje, param.Nombre_sistema);  
                }
                else
                {
                    MessageBox.Show(msg);

                    #region cargo nuevamente el detalle a sus estado anterior
                    VaciarGrid();
                    cargarpedidoxCliente();
                    List<fa_orden_Desp_det_Info> lsttmp = new List<fa_orden_Desp_det_Info>();
                    lsttmp = busDetalle.Get_List_orden_Desp_det(SetInfo);

                    foreach (var item in listapedido)
                    {
                        foreach (var item1 in lsttmp)
                        {
                            if (item.IdPedido == item1.IdPedido && item.IdProducto == item1.IdProducto)
                            {
                                item1.od_pedido = (decimal)item.saldo + (decimal)item1.od_cantidad;
                                item1.Saldo = item1.od_pedido - (decimal)item1.od_cantidad;
                                item.Checked = true;
                            }
                        }
                    }
                    lsttmp.ForEach(var =>
                    {
                        if (var.Saldo == 0)
                        {
                            var.od_pedido = (decimal)var.od_cantidad;
                        }
                    }
                        );
                    gridControlOrdenDespacho.DataSource = lsttmp;
                    ckbDespacho.Checked = (SetInfo.od_DespAbierto == "Desp. Abierto") ? true : false;

                    ckbDespacho.Enabled = false;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewOrdenDesapacho_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
             {
                if (e.Column.Caption == "Cantidad")
                {
                    if (ckbDespacho.Checked)
                    {
                        gridViewOrdenDesapacho.FocusedColumn = Saldo;
                        gridViewOrdenDesapacho.SetFocusedRowCellValue(Saldo, 0);
                        gridViewOrdenDesapacho.SetFocusedRowCellValue(od_iva, (((param.iva.porcentaje / 100) * Convert.ToDouble(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_PrecioFinal))) * Convert.ToDouble(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_cantidad))));
                        gridViewOrdenDesapacho.SetFocusedRowCellValue(od_Subtotal, Convert.ToDouble(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_PrecioFinal)) * Convert.ToDouble(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_cantidad)));
                        gridViewOrdenDesapacho.SetFocusedRowCellValue(od_total, gridViewOrdenDesapacho.GetFocusedRowCellValue(od_Subtotal));

                    }
                    else
                    {
                        if (Convert.ToDecimal(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_cantidad)) > Convert.ToDecimal(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_pedido)))
                        {
                            MessageBox.Show("La cantidad no puede superar al pedido", "Sistema Erp");
                            gridViewOrdenDesapacho.SetFocusedRowCellValue(od_cantidad, Convert.ToDecimal(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_pedido)));
                            return;
                        }
                        else
                        {
                            gridViewOrdenDesapacho.FocusedColumn = Saldo;
                            gridViewOrdenDesapacho.SetFocusedRowCellValue(Saldo, Convert.ToDecimal(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_pedido)) - Convert.ToDecimal(gridViewOrdenDesapacho.GetFocusedRowCellValue(od_cantidad)));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    
        private void frmFA_OrdenDespacho_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_frmFA_OrdenDespacho_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Set() 
        {
            try
            {
                txtCodigo.Text = SetInfo.CodOrden;
                txtIdOrdenDespacho.Text = SetInfo.IdOrdenDespacho.ToString();
                txtKilos.EditValue = SetInfo.od_TotalKilos;
                txtObservacion.Text = SetInfo.od_Observacion;
               // txtPlazo.Value = SetInfo.od_plazo;
                txtquintales.EditValue = SetInfo.od_TotalQuintales;
                dateFecha.Value = SetInfo.od_fecha;
                ctrl_SucBod.cmb_sucursal.EditValue = SetInfo.IdSucursal;
                ctrl_SucBod.cmb_bodega.EditValue = SetInfo.IdBodega;
                ctrl_Cliente.cmb_cliente.EditValue = SetInfo.IdCliente;
               // ctrl_Cliente.cmb_cliente_SelectionChangeCommitted(new Object(), new EventArgs());
                ctrl_Cliente.cmb_vendedor.EditValue = SetInfo.IdVendedor;
                ultraComboEditorTransportista.EditValue = SetInfo.IdTransportista;
                cargarpedidoxCliente();
                List<fa_orden_Desp_det_Info> lsttmp = new List<fa_orden_Desp_det_Info>();
                lsttmp = busDetalle.Get_List_orden_Desp_det(SetInfo);
            //    lsttmp.ForEach(var => var.pr_descripcion = obtnerDesProd(var.IdProducto));
                foreach (var item in listapedido)
                {
                    foreach (var item1 in lsttmp)
                    {
                        if (item.IdPedido == item1.IdPedido && item.IdProducto == item1.IdProducto)
                        {
                            item1.od_pedido = (decimal)item.saldo + (decimal)item1.od_cantidad;
                            item1.Saldo = item1.od_pedido - (decimal)item1.od_cantidad;
                            item.Checked = true;
                        }                                              
                    }
                }
                lsttmp.ForEach(var => 
                        {
                            if (var.Saldo ==0)
                            {
                                var.od_pedido = (decimal)var.od_cantidad;
                            }
                        }
                    );
                gridControlOrdenDespacho.DataSource = lsttmp;
                ckbDespacho.Checked = (SetInfo.od_DespAbierto == "Desp. Abierto") ? true : false;
                _Info.ListaDetalle = lsttmp;
                SetInfo.ListaDetalle = lsttmp;
                fa_orden_Desp_det_x_fa_pedido_det_Bus busaux = new fa_orden_Desp_det_x_fa_pedido_det_Bus();
               
                _Info.ListaAuxiliar = busaux.Get_List_fa_orden_Desp_det_x_fa_pedido_det (SetInfo);
                                       
                listaGuia = busGuia.Get_List_fa_guia_remision_det_x_fa_orden_Desp_det(SetInfo);
                var ListaGuiaRemision = listaGuia.GroupBy(v => v.gi_IdGuiaRemision).Select(g => new
                {
                    Key = g.Key,
                    IdOrdenDespacho = g.First().od_IdOrdenDespacho,
                    IdGuiaRemision = g.First().gi_IdGuiaRemision
                });

                gridControlGuia.DataSource = ListaGuiaRemision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }       
        }
       
        public Boolean Validar() 
        { 
            try
            {
                if (_Info.IdCliente == 0 || _Info.IdCliente == null)
                {
                    MessageBox.Show("Por favor seleccione Cliente", "Sistema Erp");
                    return false;
                }

                if (_Info.ListaDetalle.Count() == 0 || _Info.ListaDetalle== null) 
                {
                    MessageBox.Show("Por favor seleccione al menos un producto", "Sistema Erp");
                    return false;
            
                }
                foreach (var item in _Info.ListaDetalle)
                {
                    if(item.od_cantidad == 0)
                    {
                        MessageBox.Show("Por favor ingrese cantidad al producto" + item.pr_descripcion, "Sistema Erp");
                        return false;
                    }
                }
                if (_Info.IdTransportista == 0 || _Info.IdTransportista == null)
                {
                    MessageBox.Show("Por favor seleccione Transportista", "Sistema Erp");
                    return false;           
                }

                if (_Info.od_TotalKilos == 0)
                {

                    MessageBox.Show("Por favor ingrese Kilos", "Sistema Erp");
                    return false;
                }

                if (_Info.od_TotalQuintales == 0)
                {

                    MessageBox.Show("Por favor ingrese Quintales", "Sistema Erp");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false; 
            }
        }

        private void gridViewOrdenDesapacho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if ((_Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    fa_orden_Desp_det_Info ItemEliminar = new fa_orden_Desp_det_Info();
                    ItemEliminar = (fa_orden_Desp_det_Info)gridViewOrdenDesapacho.GetRow(gridViewOrdenDesapacho.FocusedRowHandle);

                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if (MessageBox.Show("¿Está seguro de querer Eliminar el producto ?", "Mensaje Erp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<fa_orden_Desp_det_Info> ListaTemp = new List<fa_orden_Desp_det_Info>();
                            ListaTemp = (List<fa_orden_Desp_det_Info>)gridControlOrdenDespacho.DataSource;
                            ItemEliminar = (fa_orden_Desp_det_Info)gridViewOrdenDesapacho.GetRow(gridViewOrdenDesapacho.FocusedRowHandle);
                            ListaTemp.Remove(ItemEliminar);
                            gridControlOrdenDespacho.DataSource = null;
                            gridControlOrdenDespacho.DataSource = ListaTemp;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
  
        private void panelPedidosYProductos_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                 if (_Accion ==Cl_Enumeradores.eTipo_action.actualizar)
                    {
                       
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
   
        private void gridViewOrdenDesapacho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "46")
            {              
                var Info = (fa_orden_Desp_det_Info)this.gridViewOrdenDesapacho.GetFocusedRow();
                          
                decimal IdProducto = Info.IdProducto;
                          
                if (listaGuia.Count() != 0)
                {
                    if (listaGuia.Exists(x => x.gi_IdProducto == IdProducto))
                    {
                       foreach (var item in listaGuia)
                        {

                            if (item.gi_IdProducto == Info.IdProducto)
                            {
                            MessageBox.Show("El item #: [" + Info.IdProducto + "] - " + Info.pr_descripcion + ", No se puede eliminar ya que tiene una Guía de Remisión Activa,en la guía #: " + item.gi_IdGuiaRemision + "", "Sistemas");
                                return;
                            }                          
                        }                                 
                    }
                    else
                    {                                       
                        gridViewOrdenDesapacho.DeleteSelectedRows();
                    }                                        
                }
                else
                {
                    gridViewOrdenDesapacho.DeleteSelectedRows();
                }
                                                                                                                      
            }
        }

    }
}
