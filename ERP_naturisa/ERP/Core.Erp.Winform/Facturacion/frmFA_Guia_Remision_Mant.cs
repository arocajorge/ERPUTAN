using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.Facturacion;
using Core.Erp.Winform.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using System.Windows;
using DevExpress.Xpf;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Guia_Remision_Mant : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_orden_Desp_Bus BusOrdenDes = new fa_orden_Desp_Bus();
        fa_OrdenDespachoDet_bus BusOrdenDeta = new fa_OrdenDespachoDet_bus();
        List<tb_transportista_Info> LisTransportista = new List<tb_transportista_Info>();
        in_producto_Bus BusProduCto = new in_producto_Bus();
        UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        UCFa_Cliente_Facturacion ctrl_Cliente = new UCFa_Cliente_Facturacion();
        fa_guia_remision_Bus Bus = new fa_guia_remision_Bus();
        UCGe_NumeroDocTrans ctrl_numerdoc = new UCGe_NumeroDocTrans();
        private Cl_Enumeradores.eTipo_action _Accion;
        fa_orden_Desp_Info ItemChek = new fa_orden_Desp_Info();
        decimal Aux;
        List<fa_guia_remision_det_Info> ListTemp = new List<fa_guia_remision_det_Info>();
        fa_guia_remision_Info _Info = new fa_guia_remision_Info();
        fa_guia_remision_det_bus BusDetalle = new fa_guia_remision_det_bus();
        public fa_guia_remision_Info SetInfo { get; set; }
        public delegate void Delegate_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmFA_Guia_Remision_Mant_FormClosing Event_frmFA_Guia_Remision_Mant_FormClosing;
        
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
        
        public frmFa_Guia_Remision_Mant()
        {
            try
            {
                InitializeComponent();
               // ctrl_Cliente.Event_cmb_cliente_RowSelected += new UCFa_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(ctrl_Cliente_Event_cmb_cliente_RowSelected);
                ctrl_SucBod.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(ctrl_SucBod_Event_cmb_sucursal_SelectionChangeCommitted);
                ctrl_SucBod.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(ctrl_SucBod_Event_cmb_bodega_SelectionChangeCommitted);

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
                CargarOrdenXcliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        void ValidarParametros()
        {
            try
            {
                fa_parametro_Bus bus_Parametro = new fa_parametro_Bus();
                fa_parametro_info fa_Parametros = bus_Parametro.Get_Info_parametro(param.IdEmpresa);
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
                CargarOrdenXcliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void CargarOrdenXcliente()
        {
            try
            {
                 List<fa_orden_Desp_Info > lista = new List<fa_orden_Desp_Info>();
                 lista = BusOrdenDes.CargarOrdenDespachoPorCliente(param.IdEmpresa, (int)ctrl_SucBod.cmb_sucursal.EditValue, (int)ctrl_SucBod.cmb_bodega.EditValue, (decimal)ctrl_Cliente.cmb_cliente.EditValue);
                gridControlOrdenDespacho.DataSource =lista;
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
                ctrl_Cliente.CargarCombosXsucurlsa((int)ctrl_SucBod.cmb_sucursal.EditValue);
                CargarOrdenXcliente();
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
                LisTransportista = Bustransportista.Get_List_transportista(param.IdEmpresa);
                ultraComboEditorTransportista.Properties.DataSource = LisTransportista;
                ultraComboEditorTransportista.Properties.DisplayMember = "Nombre";
                ultraComboEditorTransportista.Properties.ValueMember = "IdTransportista";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void CargarControles() 
        {

            try
            {

                ctrl_Cliente.llblRuc.Visible = false;
                ctrl_Cliente.txt_Ruc.Visible = false;
                ctrl_Cliente.lbltelefono.Visible = false;
                ctrl_Cliente.txt_Telefonos.Visible = false;
                ctrl_Cliente.lblDireccion.Visible = false;
                ctrl_Cliente.txt_Direccion.Visible = false;
                ctrl_Cliente.cmb_vendedor.Visible = false;
                ctrl_Cliente.lblVendedor.Visible = false;
                ctrl_Cliente.Dock = DockStyle.Fill;
                pnlCliente.Controls.Add(ctrl_Cliente);

                ctrl_SucBod.Dock = DockStyle.Fill;
                ctrl_SucBod.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                pnlSucBod.Controls.Add(ctrl_SucBod);

                ctrl_Cliente.CargarCombosXsucurlsa((int)ctrl_SucBod.cmb_sucursal.EditValue);

                ctrl_numerdoc.Dock = DockStyle.Fill;
                //ctrl_numerdoc.Obtener_Ult_Documento_no_usado(param.IdEmpresa,(int)ctrl_SucBod.cmb_sucursal.SelectedValue, (int)ctrl_SucBod.cmb_bodega.SelectedValue, "GUIR");


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void frmFA_Guia_Remision_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                            txtCodigo.Text = "";
            CargarControles(); 
            cargarTransportistas();
            Event_frmFA_Guia_Remision_Mant_FormClosing += new Delegate_frmFA_Guia_Remision_Mant_FormClosing(frmFA_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing);
          
            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:

                    btnGuardar.Text = "Guardar";
                    ctrl_numerdoc.Visible = false;
                    this.Text = this.Text + "***Guardar***";
                    btnImprimirDoc.Enabled = false;
                    btnAnular.Enabled = false;

                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    btnGuardar.Text = "Actualizar";
                    this.Text = this.Text + "***Actualizar***";
                    ctrl_Cliente.Enabled = false;
                    ctrl_SucBod.Enabled = false;

                       this.txtCodigo.Enabled = false;                    
                       this.txtKilos.Enabled = false;                 
                       this.txtquintales.Enabled = false;
                       this.ultraComboEditorTransportista.Enabled = false;

                       gridViewOrden.OptionsBehavior.Editable = false;
                       gridViewGuia.OptionsBehavior.Editable = false;

                       this.txtNumPlaca.Enabled = false;
                       this.txtNumPlaca.BackColor = System.Drawing.Color.White;
                       this.txtNumPlaca.ForeColor = System.Drawing.Color.Black;

                       this.txtOrigenPlaca.Enabled = false;
                       this.txtOrigenPlaca.BackColor = System.Drawing.Color.White;
                       this.txtOrigenPlaca.ForeColor = System.Drawing.Color.Black;

                       this.txtDestinoPlaca.Enabled = false;
                       this.txtDestinoPlaca.BackColor = System.Drawing.Color.White;
                       this.txtDestinoPlaca.ForeColor = System.Drawing.Color.Black;
                                                         
                    if (SetInfo.Impreso == "S")
                    {
                        lblImpreso.Visible = true;
                        btnGuardar.Enabled = false;
                        btnguardarYsalir.Enabled = false;
                        panelsec.Visible = true;
                    }
                    if (SetInfo.Estado == "I") 
                    {
                        lblAnulado.Visible = true;
                        btnAnular.Enabled = false;
                    }
                    Set();
                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    this.Text = this.Text + "***Anular***";
                    if (SetInfo.Estado == "I")
                    {
                        lblAnulado.Visible = true;
                        btnAnular.Enabled = false;
                    }
                    if (SetInfo.Impreso == "S")
                    {
                        lblImpreso.Visible = true;
                        btnGuardar.Enabled = false;
                        btnguardarYsalir.Enabled = false;
                        btnAnular.Enabled = false;
                        panelsec.Visible = true;
                    }
                    btnGuardar.Enabled = false;
                        btnguardarYsalir.Enabled = false;
                     ctrl_Cliente.Enabled = false;
                    ctrl_SucBod.Enabled = false;
                    Set();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    this.Text = this.Text + "***Consulta***";

                        btnGuardar.Enabled = false;
                        btnguardarYsalir.Enabled = false;
                        btnAnular.Enabled = false;
                        btnLimpiar.Enabled = false;
                    if (SetInfo.Impreso == "S")
                    {

                        lblImpreso.Visible = true;
                      
                        panelsec.Visible = true;
                    }
                    if (SetInfo.Estado == "I")
                    {
                        lblAnulado.Visible = true;
                        btnAnular.Enabled = false;
                    }
                    ctrl_Cliente.Enabled = false;
                    ctrl_SucBod.Enabled = false;
                    Set();
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

        void frmFA_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e){}
       
        private void gridViewOrden_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
             {
                for (int i = 0; i < gridViewOrden.RowCount; i++)
                {
                    if ((Boolean)gridViewOrden.GetRowCellValue(i, Chek))
                    {
                        gridViewOrden.SetRowCellValue(i, Chek, false);
                    }
                }
                if ((bool)gridViewOrden.GetFocusedRowCellValue(Chek))
                {
                    gridViewOrden.SetFocusedRowCellValue(Chek, false);
                }
                else
                {
                    gridViewOrden.SetFocusedRowCellValue(Chek, true);
                }
                ItemChek = (fa_orden_Desp_Info)gridViewOrden.GetRow(gridViewOrden.FocusedRowHandle);
                txtKilos.EditValue = ItemChek.od_TotalKilos;
                txtquintales.EditValue = ItemChek.od_TotalQuintales;
                _Info.IdVendedor = ItemChek.IdVendedor;
                _Info.IdTransportista = ItemChek.IdTransportista;
                ultraComboEditorTransportista.EditValue = ItemChek.IdTransportista;
                _Info.gi_plazo = ItemChek.od_plazo;
                _Info.gi_fech_venc = ItemChek.od_fech_venc;
                List<fa_orden_Desp_det_Info> DetallEOrdendes = new List<fa_orden_Desp_det_Info>();
                DetallEOrdendes = BusOrdenDeta.Get_List_orden_Desp_det(ItemChek);
                List<fa_guia_remision_det_Info> DetalleGuiaRemision = new List<fa_guia_remision_det_Info>();
                fa_parametro_Bus bus_Parametro = new fa_parametro_Bus();
                fa_parametro_info fa_Parametros = bus_Parametro.Get_Info_parametro(param.IdEmpresa);

                foreach (var item in DetallEOrdendes)
                {
                    fa_guia_remision_det_Info temp = new fa_guia_remision_det_Info();

                    if (item.Tiene_guia=="N")
                    {
                        temp.od_IdOrdenDespacho = item.IdOrdenDespacho;
                        temp.pr_descripcion = BusProduCto.Get_Descripcion_Producto(param.IdEmpresa, item.IdProducto);
                        temp.IdProducto = item.IdProducto;
                        temp.IdSucursal = item.IdSucursal;
                        temp.gi_cantidad = item.od_cantidad;
                        temp.gi_costo = item.od_costo;
                        temp.gi_cantidadAux = (item.od_cantidad * (1 + (fa_Parametros.pa_porc_max_total_item_x_despa_Guia / 100)));
                        temp.gi_iva = item.od_iva;
                        temp.gi_costo = item.od_costo;
                        temp.gi_DescUnitario = item.od_DescUnitario;
                        temp.gi_PorDescUnitario = item.od_PorDescUnitario;
                        temp.gi_Precio = item.od_Precio;
                        temp.gi_PrecioFinal = item.Precio_Final;
                        temp.gi_tieneIVA = item.od_tieneIVA;
                        temp.gi_total = item.od_total;
                        temp.IdBodega = item.IdBodega;
                        temp.IdEmpresa = param.IdEmpresa;
                        temp.Secuencia = item.Secuencia;
                        temp.Subtotal = item.od_Subtotal;
                        temp.gi_detallexItems = item.od_detallexItems;

                        //temp.gi_peso = item.Peso;
                        DetalleGuiaRemision.Add(temp);
                    }
                                                         
                }
                gridControlGuia.DataSource = DetalleGuiaRemision;
                ListTemp = DetalleGuiaRemision;
              }

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
            _Info.IdSucursal = (int)ctrl_SucBod.cmb_sucursal.EditValue;
            _Info.IdBodega = (int)ctrl_SucBod.cmb_bodega.EditValue;
            _Info.gi_fecha = Convert.ToDateTime(dateFecha.Value.ToShortDateString());

            _Info.gi_fech_venc = _Info.gi_fecha;

            _Info.gi_FecIniTraslado = Convert.ToDateTime(dtpFecIniTrasl.Value.ToShortDateString());
            _Info.gi_FecFinTraslado = Convert.ToDateTime(dtpFecFinTrasl.Value.ToShortDateString());

            _Info.CodGuiaRemision = txtCodigo.Text;
            _Info.IdGuiaRemision = Convert.ToDecimal((txtIdGuia.Text == "") ? "0" : txtIdGuia.Text);
            _Info.IdVendedor = Convert.ToInt32(ultraComboEditorTransportista.EditValue);
            _Info.IdCliente = Convert.ToDecimal((ctrl_Cliente.cmb_cliente.EditValue == null) ? 0 : ctrl_Cliente.cmb_cliente.EditValue);
            _Info.gi_TotalQuintales = Convert.ToDouble(txtquintales.EditValue);
            _Info.gi_TotalKilos = Convert.ToDouble(txtKilos.EditValue);
            _Info.IdTransportista = (decimal)ultraComboEditorTransportista.EditValue;
            _Info.gi_Observacion = txtObservacion.Text;
                if(lblImpreso.Visible)
                {
            _Info.Serie1 = lblSerie1.Text;
            _Info.Serie2 = lblserie2.Text;
            _Info.NumGuia_Preimpresa = lblNuMPreImpresa.Text;
                }

            _Info.ListaDetalle = (List<fa_guia_remision_det_Info>)gridControlGuia.DataSource;
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
                fa_guia_remision_det_x_orden_despacho_det_bus BusOrdemxGuia = new fa_guia_remision_det_x_orden_despacho_det_bus();
                txtIdGuia.Text = SetInfo.IdGuiaRemision.ToString();
                txtCodigo.Text = SetInfo.CodGuiaRemision;
                dateFecha.Value = SetInfo.gi_fecha;

                dtpFecIniTrasl.Value = SetInfo.gi_FecIniTraslado;
                dtpFecFinTrasl.Value = SetInfo.gi_FecFinTraslado;

                ctrl_SucBod.cmb_sucursal.EditValue = SetInfo.IdSucursal;
                ctrl_SucBod.cmb_bodega.EditValue = SetInfo.IdBodega;
                ctrl_Cliente.cmb_cliente.EditValue = SetInfo.IdCliente;
                ultraComboEditorTransportista.EditValue = SetInfo.IdTransportista;
                txtKilos.EditValue = SetInfo.gi_TotalKilos;
                txtquintales.EditValue = SetInfo.gi_TotalQuintales;
                CargarOrdenXcliente();
                txtObservacion.Text = SetInfo.gi_Observacion;
                lblSerie1.Text = SetInfo.Serie1;
                lblserie2.Text = SetInfo.Serie2;
                lblNuMPreImpresa.Text = SetInfo.NumGuia_Preimpresa;

                SetInfo.ListaDetalle = BusDetalle.Get_List_guia_remision_det(SetInfo.IdEmpresa, SetInfo.IdSucursal, SetInfo.IdBodega, SetInfo.IdGuiaRemision);


                SetInfo.ListaDetalle.ForEach(var => var.pr_descripcion = BusProduCto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                gridControlGuia.DataSource = SetInfo.ListaDetalle;
                ctrl_numerdoc.txe_Serie.EditValue = SetInfo.Serie1 + "-" + SetInfo.Serie2; 
               // ctrl_numerdoc.txtSerie2.Text = SetInfo.Serie2;
                ctrl_numerdoc.txtNumDoc.Text = SetInfo.NumGuia_Preimpresa;



                List<fa_orden_Desp_Info> lista = new List<fa_orden_Desp_Info>();
                decimal IdOrdenDespacho = BusOrdemxGuia.GetIdOrdenDespacho(SetInfo);


                lista = BusOrdenDes.CargarOrdenDespachoPorCliente(param.IdEmpresa, (int)ctrl_SucBod.cmb_sucursal.EditValue, (int)ctrl_SucBod.cmb_bodega.EditValue, (decimal)ctrl_Cliente.cmb_cliente.EditValue);

                (from q in lista where q.IdOrdenDespacho == IdOrdenDespacho select q).ToList().ForEach(var => var.Chek = true);
             
                gridControlOrdenDespacho.DataSource = lista;
                fa_parametro_Bus bus_Parametro = new fa_parametro_Bus();
                fa_parametro_info fa_Parametros = bus_Parametro.Get_Info_parametro(param.IdEmpresa);
                List<fa_orden_Desp_det_Info> DetallEOrdendes = new List<fa_orden_Desp_det_Info>();
                fa_orden_Desp_Info temp2 = new fa_orden_Desp_Info();
                temp2.IdOrdenDespacho = IdOrdenDespacho;
                temp2.IdEmpresa = param.IdEmpresa;
                temp2.IdSucursal = (int)ctrl_SucBod.cmb_sucursal.EditValue;
                temp2.IdBodega = (int)ctrl_SucBod.cmb_bodega.EditValue;
                DetallEOrdendes = BusOrdenDeta.Get_List_orden_Desp_det(temp2);
                DetallEOrdendes.ForEach(var => var.od_cantidad = var.od_cantidad * (1 + (fa_Parametros.pa_porc_max_total_item_x_despa_Guia / 100)));
                foreach (var item in SetInfo.ListaDetalle)
                {
                    foreach (var item1 in DetallEOrdendes)
                    {
                        if (item.IdProducto == item1.IdProducto && item.Secuencia == item1.Secuencia)
                        {
                            item.gi_cantidadAux = item1.od_cantidad;

                        }

                    }
                }

                gridControlGuia.DataSource = SetInfo.ListaDetalle;

                fa_factura_Bus BusFact = new fa_factura_Bus();
                List<fa_factura_Info> lstfact = new List<fa_factura_Info>();
                lstfact.Add(BusFact.Get_Info_FactuXGuia(SetInfo));
                gridControlFactura.DataSource = lstfact;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                    Get();
                txtCodigo.Focus();

                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            Guardar();
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
            

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        public void Guardar()
        {
            try
            {
                string numDocFactu = "";
                decimal id = 0;
                string ms = "";
                if (txtCodigo.Text != "")
                {
                    if (Bus.VerificarCodigo(txtCodigo.Text, param.IdEmpresa))
                    {
                        MessageBox.Show("El código Ingresado Ya existe por favor ingrese uno diferente",param.Nombre_sistema);
                        return;
                    }
                }

                if (Validar())
                {
                    _Info.IdUsuario = param.IdUsuario;
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.Fecha_Transac = DateTime.Now;

                    if (Bus.GrabarDB(_Info, ref id, ref numDocFactu, ref ms))
                    {
                        txtIdGuia.Text = id.ToString();
                        btnGuardar.Enabled = false;
                        btnguardarYsalir.Enabled = false;
                        ctrl_Cliente.Enabled = false;
                        ctrl_SucBod.Enabled = false;
                        if (txtCodigo.Text == "")
                        {
                            txtCodigo.Text = "GUIR" + txtIdGuia.Text;
                            btnImprimirDoc.Enabled = true;
                        }
                        if (MessageBox.Show("Guía de Remisión # " + id + " Ingresada con éxito." + "\n" + "¿Desea Imprimir la Guía Remisión N° " + id + "?", "Imprimir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            btnImprimir_Click(new Object(), new EventArgs());
                        }
                        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
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
                if(!Validar())
                { return; }              
                           
                string msn = "";
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (Bus.ModificarDB(_Info, ref msn))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Guía de Remisión", _Info.IdGuiaRemision);
                    MessageBox.Show(smensaje, param.Nombre_sistema);  
                }
            
        
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
                if(_Info.IdTransportista ==0|| _Info.IdTransportista == null )
                {
                    MessageBox.Show("Por Favor seleccione Transportista", "Sistema ERP");
                    return false;
                }
                if (_Info.IdCliente  == 0 || _Info.IdCliente== null)
                {
                    MessageBox.Show("Por Favor seleccione Cliente", "Sistema ERP");
                    return false;
                }
                if (_Info.gi_TotalKilos == 0 || _Info.gi_TotalKilos == null)
                {
                    MessageBox.Show("Por Favor ingrese Kilos", "Sistema ERP");
                    return false;
                }
                if (_Info.gi_TotalQuintales == 0 || _Info.gi_TotalQuintales == null)
                {
                    MessageBox.Show("Por Favor ingrese Quintales","Sistema ERP");
                    return false;
                }
                if (_Info.ListaDetalle.Count() == 0 || _Info.ListaDetalle == null)
                {
                    MessageBox.Show("Por Favor seleccione orden despacho", "Sistema ERP");
                    return false;
                }

                if (_Info.gi_FecFinTraslado < _Info.gi_FecIniTraslado)
                {
                    MessageBox.Show("La fecha de Finalización del Traslado no pude ser menor a la fecha Inicial del Traslado", "Sistema ERP");
                    return false;
                }

                if (_Info.gi_FecIniTraslado < _Info.gi_fecha)
                {
                    MessageBox.Show("La fecha de Inicio del Traslado no pude ser menor a la fecha de Emisión", "Sistema ERP");
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
       
        private void frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               Event_frmFA_Guia_Remision_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewGuia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            try
            { fa_parametro_Bus bus_Parametro = new fa_parametro_Bus();
                fa_parametro_info fa_Parametros = bus_Parametro.Get_Info_parametro(param.IdEmpresa);
                if (e.Column.Caption == "Cantidad")
                {
                    decimal valormax = Convert.ToDecimal(gridViewGuia.GetFocusedRowCellValue(cantAux));
                    decimal Aux = Convert.ToDecimal(gridViewGuia.GetFocusedRowCellValue(colgi_cantidad));
                    if (Aux > valormax)
                    {
                        MessageBox.Show("La Cantidad ingresada no puede exceder en un "+fa_Parametros.pa_porc_max_total_item_x_despa_Guia+"% al valor original");
                        gridViewGuia.SetFocusedRowCellValue(colgi_cantidad, valormax);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGuia_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Aux = Convert.ToDecimal(gridViewGuia.GetFocusedRowCellValue(colgi_cantidad));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnguardarYsalir_Click(object sender, EventArgs e)
        {

            try
            {
                Get();
                if (Validar())
                {
                    btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = "";
                txtIdGuia.Text = "";
                txtKilos.EditValue = 0;
                txtObservacion.Text = "";
               // txtPlazo.Value = 0;
                txtquintales.EditValue = 0;
                dateFecha.Value = DateTime.Now;

                ctrl_Cliente.cmb_cliente.Text = "";
                gridControlGuia.DataSource = new List<fa_orden_Desp_Info>();
                gridControlOrdenDespacho.DataSource = new List<fa_guia_remision_Info>();
                //ctrl_numerdoc.Obtener_Ult_Documento_no_usado(param.IdEmpresa,(int)ctrl_SucBod.cmb_sucursal.SelectedValue, (int)ctrl_SucBod.cmb_bodega.SelectedValue, "GUIR");
                btnGuardar.Text = "Guardar";
                this.Text = "Guía De Remisión ***Guardar***";
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                ctrl_Cliente.Enabled = true;
                ctrl_SucBod.Enabled = true;
                btnGuardar.Enabled = true;
                btnguardarYsalir.Enabled = true;
                btnImprimirDoc.Enabled = true;
                lblAnulado.Visible = false;
                lblImpreso.Visible = false;
                panelsec.Visible = false;
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
                if (lblImpreso.Visible)
                {
                    ReporteDocumento();

                }
                else
                {
                    frmFa_NumDocumento ofrm = new frmFa_NumDocumento("GUIR", param.IdEmpresa, (int)ctrl_SucBod.cmb_sucursal.EditValue, (int)ctrl_SucBod.cmb_bodega.EditValue);
                    ofrm.ShowDialog();
                    if (ofrm.Bole)
                    {
                        Get();

                        lblSerie1.Text = _Info.Serie1 = ofrm.Serie1;
                        lblserie2.Text = _Info.Serie2 = ofrm.Serie2;
                        _Info.NumAutorizacion = ofrm.NunAutorizacion;
                        lblNuMPreImpresa.Text = _Info.NumGuia_Preimpresa = ofrm.NumDocument;
                        panelsec.Visible = true;
                        _Info.Impreso = "S";
                        string msj = ""; if (Bus.VerificarNumguia(_Info))
                        {
                            Bus.Imprimir(_Info, ref msj);
                            ReporteDocumento();
                            lblImpreso.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("El número de Guía ya se encuentra Impresa Por favor ingrese una diferente");

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                                
        }

        public void ReporteDocumento() 
        {
            try
            {
                Get();
                //XRPT_fa_GuiaRemision_doc xprt = new XRPT_fa_GuiaRemision_doc();
                fa_rpt_guia_remision_Info InfoReport = new fa_rpt_guia_remision_Info();

                List<fa_rpt_guia_remision_Info> lstReport = new List<fa_rpt_guia_remision_Info>();
                _Info.Vendedor = ctrl_Cliente.cmb_vendedor.Text;
                _Info.Cliente = ctrl_Cliente.cmb_cliente.Text;
                _Info.Sucursal = ctrl_SucBod.cmb_sucursal.Text;
                _Info.Bodega = ctrl_SucBod.cmb_bodega.Text;
                List<fa_guia_remision_det_Info> lsttmp = new List<fa_guia_remision_det_Info>();
                lsttmp = BusDetalle.Get_List_guia_remision_det(_Info.IdEmpresa, _Info.IdSucursal, _Info.IdBodega, _Info.IdGuiaRemision);

                lsttmp.ForEach(var => var.pr_descripcion = BusProduCto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                _Info.ListaDetalle = lsttmp;
                InfoReport.Info = _Info;
                InfoReport.ListaDetalle = _Info.ListaDetalle;
                InfoReport.empresainfo = param.InfoEmpresa;
                lstReport.Add(InfoReport);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    _Info = new fa_guia_remision_Info();
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

        private void btnAnular_Click(object sender, EventArgs e)
        {

            try
            {
                Get();

                fa_factura_Bus BusFact = new fa_factura_Bus();
                List<fa_factura_Info> lstfact = new List<fa_factura_Info>();
                fa_factura_Info facInfo = new fa_factura_Info();
                facInfo = BusFact.Get_Info_FactuXGuia(_Info);
                if (facInfo != null)
                {
                    MessageBox.Show("No se puede Anular la  Guáa de Remisión ya que tiene la Factura #:" + facInfo.IdCbteVta + "Activa");
                    return;

                }
                
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                if (_Info.IdGuiaRemision == 0)
                { return; }
                if (lblAnulado.Visible)
                {
                    MessageBox.Show("No se puede anular cotización por que ya se encuentra anulada");
                    return;
                }
                if (MessageBox.Show("¿Está seguro que desea anular la Cotización ?", "Anulación de Cotización", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    _Info.MotivoAnu = ofrm.motivoAnulacion;
                    _Info.ip = param.ip;
                    _Info.nom_pc = param.nom_pc;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Fecha_UltAnu = DateTime.Now;
                    if (ofrm.cerrado == "N")
                    {
                        if (Bus.ActualizarEstado(param.IdEmpresa, _Info)) 
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Guía de Remisión", _Info.IdGuiaRemision);
                            MessageBox.Show(smensaje, param.Nombre_sistema);  
                            lblAnulado.Visible = true;
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
               
            try
            {

                Get();
                //XRPT_fa_GuiaRemision xprt = new XRPT_fa_GuiaRemision();
                fa_rpt_guia_remision_Info InfoReport = new fa_rpt_guia_remision_Info();

                List<fa_rpt_guia_remision_Info> lstReport = new List<fa_rpt_guia_remision_Info>();
                _Info.Vendedor = ctrl_Cliente.cmb_vendedor.Text;
                _Info.Cliente = ctrl_Cliente.cmb_cliente.Text;
                _Info.Sucursal = ctrl_SucBod.cmb_sucursal.Text;
                _Info.Bodega = ctrl_SucBod.cmb_bodega.Text;
                List<fa_guia_remision_det_Info> lsttmp = new List<fa_guia_remision_det_Info>();
                lsttmp = BusDetalle.Get_List_guia_remision_det(_Info.IdEmpresa, _Info.IdSucursal, _Info.IdBodega, _Info.IdGuiaRemision);

                lsttmp.ForEach(var => var.pr_descripcion = BusProduCto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                _Info.ListaDetalle = lsttmp;
                InfoReport.Info = _Info;
                InfoReport.ListaDetalle = _Info.ListaDetalle;
                InfoReport.empresainfo = param.InfoEmpresa;
                //InfoReport.info.TOTAL = (double)txtTotal.Value;
                lstReport.Add(InfoReport);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    _Info = new fa_guia_remision_Info();
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

           
        }
    
}

