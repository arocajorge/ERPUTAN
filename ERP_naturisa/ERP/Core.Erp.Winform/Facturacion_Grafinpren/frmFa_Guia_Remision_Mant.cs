using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cus.ERP.Reports.Grafinpren;
using Cus.ERP.Reports.Grafinpren.Facturacion;


namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    public partial class frmFa_Guia_Remision_Mant : Form
    {

        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Bus Sucursal_B = new tb_Sucursal_Bus();
        List<tb_transportista_Info> LisTransportista = new List<tb_transportista_Info>();
        in_producto_Bus BusProducto = new in_producto_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        decimal Aux;
        fa_guia_remision_Info Info_Guia_Ge = new fa_guia_remision_Info();
        fa_guia_remision_det_bus BusDetalle = new fa_guia_remision_det_bus();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        tb_sis_Documento_Tipo_Talonario_Info talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();  
        List<fa_guia_remision_det_Info> ListaDet = new List<fa_guia_remision_det_Info>(); 
        BindingList<fa_guia_remision_det_Info> ListaBind = new BindingList<fa_guia_remision_det_Info>();
        fa_guia_remision_det_Info Info_det = new fa_guia_remision_det_Info();
        ct_Periodo_Bus Bus_Periodo = new ct_Periodo_Bus();
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();
        Core.Erp.Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus Bus_Guia = new Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus();
        Core.Erp.Info.Facturacion_Grafinpren.fa_guia_remision_graf_Info Info_Guia = new Erp.Info.Facturacion_Grafinpren.fa_guia_remision_graf_Info();
        public delegate void Delegate_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmFA_Guia_Remision_Mant_FormClosing Event_frmFA_Guia_Remision_Mant_FormClosing;
        string MensajeError = string.Empty;
        #endregion

        #region" Constructor "
        public frmFa_Guia_Remision_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_guia_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_guia_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimirSoporte_Click += ucGe_Menu_Superior_Mant1_event_btnImprimirSoporte_Click;
            Event_frmFA_Guia_Remision_Mant_FormClosing += frmFa_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing;
            ucGe_Menu_Superior_Mant1.event_btn_Generar_XML_Click += ucGe_Menu_Superior_Mant1_event_btn_Generar_XML_Click;
        }

        
        #endregion

        #region "Eventos"
        void ucGe_Menu_Superior_Mant1_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                Core.Erp.Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus bus = new Core.Erp.Business.Facturacion_Grafinpren.fa_guia_remision_graf_Bus();
                if(bus.GenerarXML(param.IdEmpresa,UCSucursal.get_IdSucursal(),Convert.ToInt32( txtIdGuia.Text)))
                {
                    MessageBox.Show("Se genero correctamente el XML",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                  MessageBox.Show("No se puedo generar el XML",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmFa_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirSoporte();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_guia_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_GRAF_Rpt001_Rpt Rpt = new XFAC_GRAF_Rpt001_Rpt();
                List<XFAC_GRAF_Rpt001_Info> Lst = new List<XFAC_GRAF_Rpt001_Info>();
                XFAC_GRAF_Rpt001_Bus Bus = new XFAC_GRAF_Rpt001_Bus();
                Rpt.RequestParameters = false;
                //Info_Guia_Ge.IdGuiaRemision = Convert.ToDecimal(txtIdGuia.Text);
                Lst = Bus.Lista_Guias(Info_Guia_Ge.IdEmpresa, Info_Guia_Ge.IdSucursal, Info_Guia_Ge.IdBodega, Info_Guia_Ge.IdGuiaRemision, ref MensajeError);
                Rpt.lstRpt = Lst;
                Rpt.CreateDocument();
                Rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrabarDatos())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GrabarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrabarDatos())
                    this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } throw new NotImplementedException();
        }

        private void frmFa_Guia_Remision_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<fa_guia_remision_det_Info>();
                gridControlGuia.DataSource = ListaBind;
                txtCodigo.Text = "";
                cmbEquipo.Cargar_Combo();
                cargarTransportistas();
                carga_Combos_Productos();
                Event_frmFA_Guia_Remision_Mant_FormClosing += new Delegate_frmFA_Guia_Remision_Mant_FormClosing(frmFa_Guia_Remision_Mant_Event_frmFA_Guia_Remision_Mant_FormClosing);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                    break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        this.txtCodigo.ReadOnly = true;
                        this.ultraComboEditorTransportista.Properties.ReadOnly = true;
                    
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = true;
                            ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                            ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                            ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                       
                        if (Info_Guia_Ge.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        if (Info_Guia_Ge.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        }
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                         ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;
                        
                        if (Info_Guia_Ge.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        gridViewGuia.OptionsBehavior.Editable = false;
                        Set();
                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmFa_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmFA_Guia_Remision_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewGuia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
                Info_det = new fa_guia_remision_det_Info();                
                Info_det = (fa_guia_remision_det_Info)this.gridViewGuia.GetFocusedRow();
                if (Info_det != null)
                {
                double precio = Math.Round(Convert.ToDouble(gridViewGuia.GetFocusedRowCellValue(colgi_Precio)), 2);
                int cantidad = Convert.ToInt32(gridViewGuia.GetFocusedRowCellValue(colgi_cantidad));
                double Porc_Descuento = Math.Round(Convert.ToDouble(gridViewGuia.GetFocusedRowCellValue(colPor_Descuento)), 2);
                double Descuentos = Math.Round((Porc_Descuento * precio) / 100, 2); 
                double total_descuento = Math.Round(Descuentos*cantidad,2);
                Boolean TieneIva = Convert.ToBoolean(gridViewGuia.GetFocusedRowCellValue(colTieneIVA));
                double subtotal = Math.Round(((precio * cantidad) - total_descuento), 2);
                //double SubtotalFinal = (subtotal - Descuentos);
                double Iva = ((subtotal * param.iva.porcentaje) / 100);

                if (e.Column == colgi_cantidad || e.Column == colgi_Precio || e.Column == colPor_Descuento)
                {
                    gridViewGuia.SetFocusedRowCellValue(colgi_DescUnitario, Descuentos);
                    if (TieneIva == true)
                    {
                        gridViewGuia.SetFocusedRowCellValue(colgi_total, subtotal + Iva);
                        gridViewGuia.SetFocusedRowCellValue(colgi_iva, Iva);
                        gridViewGuia.SetFocusedRowCellValue(colSubtotal1, subtotal);
                        Info_det.gi_tieneIVA = "S";
                    }
                    else
                    {
                        gridViewGuia.SetFocusedRowCellValue(colgi_total, subtotal);
                        gridViewGuia.SetFocusedRowCellValue(colSubtotal1, subtotal);
                        gridViewGuia.SetFocusedRowCellValue(colgi_iva, 0);
                        Info_det.gi_tieneIVA = "N";
                    }
                         
                }

                if (e.Column == colTieneIVA)
                {
                    gridViewGuia.SetFocusedRowCellValue(colgi_DescUnitario, Descuentos);
                        if (TieneIva == true)
                        {
                            gridViewGuia.SetFocusedRowCellValue(colgi_total, subtotal + Iva);
                            gridViewGuia.SetFocusedRowCellValue(colgi_iva, Iva);
                            gridViewGuia.SetFocusedRowCellValue(colSubtotal1, subtotal);
                            Info_det.gi_tieneIVA = "S";
                        }
                        else
                        {
                            gridViewGuia.SetFocusedRowCellValue(colgi_total, subtotal);
                            gridViewGuia.SetFocusedRowCellValue(colSubtotal1, subtotal);
                            gridViewGuia.SetFocusedRowCellValue(colgi_iva, 0);
                            Info_det.gi_tieneIVA = "N";
                        }
                }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCSucursal_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarNumDoc();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCSucursal_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarNumDoc();
                if (UCSucursal.get_sucursal() != null && UCSucursal.get_sucursal().IdSucursal != 0)
                {
                    txt_Direccion_Origen.Text = UCSucursal.get_sucursal().Su_Direccion;
                }
                else
                    txt_Direccion_Origen.Text = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region " Set"
        public void SetInfo(fa_guia_remision_Info _Info) 
        {
            try
            {
                Info_Guia_Ge = _Info;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set()
        {
            try
            {
                txtIdGuia.Text = Info_Guia_Ge.IdGuiaRemision.ToString();
                txtCodigo.Text = Info_Guia_Ge.CodGuiaRemision;
                dateFecha.Value = Info_Guia_Ge.gi_fecha;

                dtpFecIniTrasl.Value = Info_Guia_Ge.gi_FecIniTraslado;
                dtpFecFinTrasl.Value = Info_Guia_Ge.gi_FecFinTraslado;
                UCSucursal.cmb_bodega.EditValue = Info_Guia_Ge.IdBodega;
                UCSucursal.cmb_sucursal.EditValue = Info_Guia_Ge.IdSucursal;
                ucFa_ClienteCmb1.set_ClienteInfo(Info_Guia_Ge.IdCliente);
                ultraComboEditorTransportista.EditValue = Info_Guia_Ge.IdTransportista;
                

                txtObservacion.Text = Info_Guia_Ge.gi_Observacion;

                if (Info_Guia_Ge.Estado == "A")
                    chkActivo.Checked = true;
                else
                    chkActivo.Checked = false;

                ctrl_NumDoc.txe_Serie.Text = Info_Guia_Ge.Serie1 + "-" + Info_Guia_Ge.Serie2;
                ctrl_NumDoc.txtNumDoc.Text = Info_Guia_Ge.NumGuia_Preimpresa;

                ListaDet = new List<fa_guia_remision_det_Info>();
                ListaDet = BusDetalle.Get_List_guia_remision_det(Info_Guia_Ge.IdEmpresa, Info_Guia_Ge.IdSucursal, Info_Guia_Ge.IdBodega, Info_Guia_Ge.IdGuiaRemision);
                Info_Guia_Ge.ListaDetalle = ListaDet;
                Info_Guia_Ge.ListaDetalle.ForEach(var => var.pr_descripcion = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                ListaBind = new BindingList<fa_guia_remision_det_Info>(Info_Guia_Ge.ListaDetalle);
                gridControlGuia.DataSource = ListaBind;

                txt_Direccion_Destino.Text = Info_Guia_Ge.Direccion_Destino;
                txt_Direccion_Origen.Text = Info_Guia_Ge.Direccion_Origen;
                txt_Placa.Text = Info_Guia_Ge.placa;
                txt_ruta.Text = Info_Guia_Ge.ruta;

                //Campos de Grafinpren
                txtNumeroCotizacion.EditValue = Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_Cotizacion;
                txtOrdenProducción.Text = Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_OP;
                dtFechaCotizacion.Value = Convert.ToDateTime(Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.fecha_Cotizacion);
                cmbEquipo.Set_InfoEquipo(Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdEquipo);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region "GET"
        public void Get()
        {
            try
            {
                Info_Guia_Ge = new fa_guia_remision_Info();
                Info_Guia_Ge.IdEmpresa = param.IdEmpresa;
                Info_Guia_Ge.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                Info_Guia_Ge.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                Info_Guia_Ge.IdGuiaRemision = Convert.ToDecimal((txtIdGuia.Text == "") ? "0" : txtIdGuia.Text);
                Info_Guia_Ge.CodGuiaRemision = txtCodigo.Text;
                
               
                Info_Guia_Ge.IdCliente = Convert.ToInt32(ucFa_ClienteCmb1.get_ClienteInfo().IdCliente);
                Info_Guia_Ge.IdVendedor = Convert.ToInt32((ultraComboEditorTransportista.EditValue == "") ? 0 : ultraComboEditorTransportista.EditValue);
                Info_Guia_Ge.IdTransportista = Convert.ToDecimal((ultraComboEditorTransportista.EditValue == "") ? 0 : ultraComboEditorTransportista.EditValue);          
                Info_Guia_Ge.gi_fecha = Convert.ToDateTime(dateFecha.Value.ToShortDateString());
                Info_Guia_Ge.gi_fech_venc = Info_Guia_Ge.gi_fecha;
                Info_Guia_Ge.gi_Observacion = txtObservacion.Text;
                Info_Guia_Ge.gi_FecIniTraslado = Convert.ToDateTime(dtpFecIniTrasl.Value.ToShortDateString());
                Info_Guia_Ge.gi_FecFinTraslado = Convert.ToDateTime(dtpFecFinTrasl.Value.ToShortDateString());

                talonarioInfo = ctrl_NumDoc.Get_Info_Talonario();
                Info_Guia_Ge.CodDocumentoTipo = talonarioInfo.CodDocumentoTipo;
                Info_Guia_Ge.Serie1 = talonarioInfo.Establecimiento;
                Info_Guia_Ge.Serie2 = talonarioInfo.PuntoEmision;
                Info_Guia_Ge.NumAutorizacion = null;
                Info_Guia_Ge.NumGuia_Preimpresa = talonarioInfo.NumDocumento;
                Info_Guia_Ge.CodDocumentoTipo = talonarioInfo.CodDocumentoTipo;
                Info_Guia_Ge.Estado =  chkActivo.Checked == true ? "A" : "I";
                Info_Guia_Ge.IdPeriodo = 0;
                Info_Guia_Ge.gi_flete = 0;
                Info_Guia_Ge.gi_interes = 0;
                Info_Guia_Ge.gi_seguro = 0;
                Info_Guia_Ge.gi_OtroValor1 = 0;
                Info_Guia_Ge.gi_OtroValor2 = 0;

                Info_Guia_Ge.Direccion_Origen = txt_Direccion_Origen.Text;
                Info_Guia_Ge.Direccion_Destino = txt_Direccion_Destino.Text;
                Info_Guia_Ge.placa = txt_Placa.Text;
                Info_Guia_Ge.ruta = txt_ruta.Text;
                Info_Guia_Ge.ListaDetalle = new List<fa_guia_remision_det_Info>(ListaBind);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void GetFacturaGrafinprent()
        {
            try
            {
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdEmpresa = Info_Guia_Ge.IdEmpresa;
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdSucursal = Info_Guia_Ge.IdSucursal;
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdBodega = Info_Guia_Ge.IdBodega;
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdGuiaRemision = Info_Guia_Ge.IdGuiaRemision;
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_Cotizacion = Convert.ToDecimal((txtNumeroCotizacion.EditValue == null || txtNumeroCotizacion.EditValue == "") ? 0 : txtNumeroCotizacion.EditValue);
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_OP = txtOrdenProducción.Text;
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.fecha_Cotizacion = Convert.ToDateTime(dtFechaCotizacion.Value.ToShortDateString());
               Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdEquipo = cmbEquipo.Get_Equipo().IdEquipo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region " Grabar Datos"
        private Boolean GrabarDatos()
        {
            try
            {
                Boolean respuesta = false;
                Get();
                GetFacturaGrafinprent();
                txtCodigo.Focus();
                if (Validar())
                {
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = Actualizar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            respuesta = Anular();
                            break;
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Cargar Combos"
       
        void carga_Combos_Productos()
        {
            try
            {
                //listProducto = BusProducto.Get_list_Productos_x_bodega(param.IdEmpresa, Convert.ToInt32(UCSucursal.get_IdSucursal()), Convert.ToInt32(UCSucursal.get_IdBodega()));
                listProducto = BusProducto.Get_list_Producto(param.IdEmpresa, 1, 1);
                cmbProducto_grid.DataSource = listProducto;
                cmbProducto_grid.DisplayMember = "pr_descripcion";
                cmbProducto_grid.ValueMember = "IdProducto";
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cargarTransportistas()
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void LoadSucursal()
        {
            try
            {
                var Sucursales = Sucursal_B.Get_List_Sucursal(param.IdEmpresa);
                foreach (var item in Sucursales)
                {
                    Info_det.IdSucursal = item.IdSucursal;
                    Info_det.IdEmpresa = item.IdEmpresa;
                   
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region "Guardar, Actualizar, Anular"
        private Boolean Guardar()
        {
            try
            {
                bool resultado = false;
                string numDocFactu = "";
                decimal id = 0;
                string ms = "";
                if (txtCodigo.Text != "")
                {
                    if (Bus_Guia.VerificarCodigo(txtCodigo.Text, param.IdEmpresa))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " ingrese un nuevo código, el anterior ya se encuentra ingresado " , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }

                     Info_Guia_Ge.IdUsuario = param.IdUsuario;
                     Info_Guia_Ge.ip = param.ip;
                     Info_Guia_Ge.nom_pc = param.nom_pc;
                     Info_Guia_Ge.Fecha_Transac = DateTime.Now;
                     
                     Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, DateTime.Now, ref MensajeError);
                     Info_Guia_Ge.IdPeriodo = Info_Periodo.IdPeriodo;
                    if (Bus_Guia.GrabarDB( Info_Guia_Ge, ref id, ref numDocFactu, ref ms))
                    {
                        resultado = true;
                        txtIdGuia.Text = id.ToString();
                        if (txtCodigo.Text == "")
                        {
                            txtCodigo.Text = Info_Guia_Ge.CodGuiaRemision;
                            ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = true;
                        }
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Guía Remisión # " + id + "\n" + param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir) + " la Guía Remisión N° " + id + "?", param.Nombre_sistema, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            ucGe_Menu_Superior_Mant1_event_btnImprimir_guia_Click(new Object(), new EventArgs());
                        }
                        Limpiar();
                    }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private Boolean Actualizar()
        {
            try
            {
                bool resultado = false;
                if (!Validar())
                { return false; }
                Info_Guia_Ge.ip = param.ip;
                Info_Guia_Ge.nom_pc = param.nom_pc;
                 Info_Guia_Ge.IdUsuarioUltMod = param.IdUsuario;
                 Info_Guia_Ge.Fecha_UltMod = DateTime.Now;
                if (Bus_Guia.ModificarDB( Info_Guia_Ge, ref MensajeError))
                {
                    resultado = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Guía de Remisión " +  Info_Guia_Ge.IdGuiaRemision, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;

            }
        }

        private Boolean Anular()
        {
            try
            {
                bool resultado = false;
                fa_factura_Bus BusFact = new fa_factura_Bus();
                List<fa_factura_Info> lstfact = new List<fa_factura_Info>();
                fa_factura_Info facInfo = new fa_factura_Info();
               
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                if ( Info_Guia_Ge.IdGuiaRemision == 0)
                { return false; }
                if (lblAnulado.Visible)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la  Guía de Remisión " + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " la  Guía de Remisión ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                     Info_Guia_Ge.MotivoAnu = ofrm.motivoAnulacion;
                     Info_Guia_Ge.ip = param.ip;
                     Info_Guia_Ge.nom_pc = param.nom_pc;
                     Info_Guia_Ge.IdUsuarioUltAnu = param.IdUsuario;
                     Info_Guia_Ge.Fecha_UltAnu = DateTime.Now;
                    if (ofrm.cerrado == "N")
                    {
                        if (Bus_Guia.ActualizarEstado(param.IdEmpresa,  Info_Guia_Ge))
                        {
                            resultado = true;
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " la Guía de Remisión " +  Info_Guia_Ge.IdGuiaRemision, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblAnulado.Visible = true;
                        }

                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Validaciones"
        void ValidarParametros()
        {
            try
            {
                fa_parametro_Bus bus_Parametro = new fa_parametro_Bus();
                fa_parametro_info fa_Parametros = bus_Parametro.Get_Info_parametro(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }



        }

        public Boolean Validar()
        {
            try
            {
                if (Info_Guia_Ge.IdCliente == 0 || Info_Guia_Ge.IdCliente == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucFa_ClienteCmb1.Focus();
                    return false;
                }
                if (Info_Guia_Ge.IdTransportista == 0 ||  Info_Guia_Ge.IdTransportista == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Transportista", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ultraComboEditorTransportista.Focus();
                    return false;
                }
                
                if ( Info_Guia_Ge.ListaDetalle.Count() == 0 ||  Info_Guia_Ge.ListaDetalle == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " agrege detalle de la guía", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridViewGuia.Focus();
                    return false;
                }

                if ( Info_Guia_Ge.gi_FecFinTraslado <  Info_Guia_Ge.gi_FecIniTraslado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Fecha_final_debe_ser_mayor_que_fecha_inicial) +" del Traslado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpFecFinTrasl.Focus();
                    return false;
                }

                if ( Info_Guia_Ge.gi_FecIniTraslado <  Info_Guia_Ge.gi_fecha)
                {
                    MessageBox.Show("La fecha de Inicio del Traslado no pude ser menor a la fecha de Emisión", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtpFecIniTrasl.Focus();
                    return false;
                }

                if (Info_Guia_Ge.Direccion_Origen == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la)+" dirección de origen", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Direccion_Origen.Focus();
                    return false;
                }

                if (Info_Guia_Ge.Direccion_Destino == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " dirección de destino", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Direccion_Destino.Focus();
                    return false;
                }

                if (Info_Guia_Ge.placa=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " placa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_Placa.Focus();
                    return false;
                }

                if (Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_OP == null || Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.Num_OP == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Numero de OP", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtOrdenProducción.Focus();
                    return false;
                }

                if (Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdEquipo == null || Info_Guia_Ge.Info_Guia_Remision_x_Grafinpren.IdEquipo == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Equipo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbEquipo.Focus();
                    return false;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.FAC, Convert.ToDateTime(dateFecha.Value)))
                    return false;

                return true;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }
        #endregion

        #region " Limpiar"
        private void Limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txtCodigo.Text = string.Empty;
                txtIdGuia.Text = string.Empty;
                txtObservacion.Text = string.Empty;
                dateFecha.Value = DateTime.Now;
                ucFa_ClienteCmb1.Inicializar_cmb_cliente();
                ultraComboEditorTransportista.EditValue = "[Vacio]";
                dtpFecFinTrasl.Value = DateTime.Now;
                dtpFecIniTrasl.Value = DateTime.Now;

                ctrl_NumDoc.txe_Serie.EditValue = "";
                ctrl_NumDoc.txtNumDoc.EditValue = "";

                dtFechaCotizacion.Value = DateTime.Now;
                cmbEquipo.InicializarEquipo();
                txtOrdenProducción.Text = string.Empty;
                txtNumeroCotizacion.Text = string.Empty;

                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_bntImprimir_Guia = false;
                ucGe_Menu_Superior_Mant1.Visible_btnImprimirSoporte = false;

                ListaBind = new BindingList<fa_guia_remision_det_Info>();
                gridControlGuia.DataSource = ListaBind;

                lblAnulado.Visible = false;
                lblImpreso.Visible = false; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Funciones personalizadas"
        private void ImprimirSoporte()
        {
            try
            {
                Get();
               
                fa_rpt_guia_remision_Info InfoReport = new fa_rpt_guia_remision_Info();

                List<fa_rpt_guia_remision_Info> lstReport = new List<fa_rpt_guia_remision_Info>();
                List<fa_guia_remision_det_Info> lsttmp = new List<fa_guia_remision_det_Info>();
                lsttmp = BusDetalle.Get_List_guia_remision_det(Info_Guia_Ge.IdEmpresa, Info_Guia_Ge.IdSucursal, Info_Guia_Ge.IdBodega, Info_Guia_Ge.IdGuiaRemision);

                lsttmp.ForEach(var => var.pr_descripcion = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                Info_Guia_Ge.ListaDetalle = lsttmp;
                InfoReport.Info = Info_Guia_Ge;
                InfoReport.ListaDetalle = Info_Guia_Ge.ListaDetalle;
                InfoReport.empresainfo = param.InfoEmpresa;
                lstReport.Add(InfoReport);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_Guia_Ge = new fa_guia_remision_Info();
                    Info_Guia_Ge.Estado = "A";
                }
                else
                {
                    Info_Guia_Ge.Estado = Info_Guia_Ge.Estado;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ReporteDocumento()
        {
            try
            {
                Get();
                fa_rpt_guia_remision_Info InfoReport = new fa_rpt_guia_remision_Info();

                List<fa_rpt_guia_remision_Info> lstReport = new List<fa_rpt_guia_remision_Info>();
                List<fa_guia_remision_det_Info> lsttmp = new List<fa_guia_remision_det_Info>();
                lsttmp = BusDetalle.Get_List_guia_remision_det( Info_Guia_Ge.IdEmpresa,  Info_Guia_Ge.IdSucursal,  Info_Guia_Ge.IdBodega,  Info_Guia_Ge.IdGuiaRemision);

                lsttmp.ForEach(var => var.pr_descripcion = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                 Info_Guia_Ge.ListaDetalle = lsttmp;
                InfoReport.Info =  Info_Guia_Ge;
                InfoReport.ListaDetalle =  Info_Guia_Ge.ListaDetalle;
                InfoReport.empresainfo = param.InfoEmpresa;
                lstReport.Add(InfoReport);
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                     Info_Guia_Ge = new fa_guia_remision_Info();
                     Info_Guia_Ge.Estado = "A";
                }
                else
                {
                     Info_Guia_Ge.Estado = Info_Guia_Ge.Estado;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ImprimirGuia()
        {
                try
                {
                    //if (lblImpreso.Visible)
                    //{
                    //    ReporteDocumento();

                    //}
                    //else
                    //{
                    //    frmFa_NumDocumento ofrm = new frmFa_NumDocumento("GUIR", param.IdEmpresa, Info_Guia_Ge.IdSucursal, Info_Guia_Ge.IdBodega);
                    //    ofrm.ShowDialog();
                    //    if (ofrm.Bole)
                    //    {
                    //        Get();
                    //        Info_Guia_Ge.NumAutorizacion = ofrm.NunAutorizacion;
                    //        Info_Guia_Ge.Impreso = "S";
                    //        string msj = ""; if (Bus_Guia.VerificarNumguia(Info_Guia_Ge))
                    //        {
                    //            Bus_Guia.Imprimir( Info_Guia_Ge, ref msj);
                    //            ReporteDocumento();
                    //            lblImpreso.Visible = true;
                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show(" La guía ya se encuentra Impresa, " + param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " ingrese un número de guía que no haya sido impreso ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        }
                    //    }

                    //}
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                }
        }
        #endregion  

        #region "eventos Personalizados"
        private void txtquintales_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan 
                        e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtquintales_KeyPress(sender, e);
        }

        private void txtNumeroCotizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtquintales_KeyPress(sender, e);
        }

        public void cargarNumDoc()
        {
            try
            {
                if (Convert.ToString(_Accion) == "grabar")
                {
                    ctrl_NumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.GUIA;
                    if (UCSucursal.get_sucursal() != null && UCSucursal.get_bodega() != null)
                    {
                        ctrl_NumDoc.IdEstablecimiento = UCSucursal.get_sucursal().Su_CodigoEstablecimiento;
                        ctrl_NumDoc.IdPuntoEmision = UCSucursal.get_bodega().cod_punto_emision;
                        ctrl_NumDoc.Get_Primer_Documento_no_usado();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion        

        private void ucFa_ClienteCmb1_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucFa_ClienteCmb1.get_ClienteInfo().IdCliente != 0)
                {
                    txt_Direccion_Destino.Text = ucFa_ClienteCmb1.get_ClienteInfo().Persona_Info.pe_direccion;
                }
                else
                    txt_Direccion_Destino.Text = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlGuia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewGuia.DeleteSelectedRows();

                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        
    }
}
