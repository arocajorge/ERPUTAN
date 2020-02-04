using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Cotizacion_Mant :Form       
    {
        #region declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmFA_Cotizacion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Cotizacion_Mant_FormClosing event_frmFA_Cotizacion_Mant_FormClosing;

        public int GUARDAR;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        private Cl_Enumeradores.eTipo_action _Accion;

        //public UCIn_Sucursal_Bodega UCfaBodega = new UCIn_Sucursal_Bodega();

        tb_Bodega_Info infoBodega = new tb_Bodega_Info();
        tb_Sucursal_Info infoSucursal = new tb_Sucursal_Info();

        // GridFacturaDevExpres faGridDetalle;

        public fa_cotizacion_info infocotizacion = new fa_cotizacion_info();
        fa_cotizacion_Bus buscotizacion = new fa_cotizacion_Bus();
        fa_cotizacion_det_info infocotizacionDetalle = new fa_cotizacion_det_info();
        fa_Cliente_Info infoCliente = new fa_Cliente_Info();
        List<fa_cotizacion_det_info> listadetalle = new List<fa_cotizacion_det_info>();
        List<fa_cotizacion_det_info> listatabla = new List<fa_cotizacion_det_info>();

        //UCFA_Cliente_Facturacion UCfaCliente = new UCFA_Cliente_Facturacion();

        public int IDsucursal;
        public int IDBodega;
        //productos datos
        in_producto_Bus dataProducto = new in_producto_Bus();

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                UCfaBodega.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(faBodega_Event_cmb_sucursal_SelectionChangeCommitted);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void faBodega_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
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
        public void LoadProductos()
        {
            try
            {
                faGridDetalle.Clear_Ugrid();
                //faGridDetalle.ucmb_productos.DataSource = null;
                infoBodega = UCfaBodega.get_bodega();
                infoSucursal = UCfaBodega.get_sucursal();
                //faGridDetalle.idBodega = infoBodega.IdBodega;
                //faGridDetalle.idSucursal = infoSucursal.IdSucursal;
                faGridDetalle.load_Producto(param.IdEmpresa, Convert.ToInt32(UCfaBodega.cmb_sucursal.EditValue), Convert.ToInt32(UCfaBodega.cmb_bodega.EditValue));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion

        public frmFa_Cotizacion_Mant()
        {
            try
            {
                InitializeComponent();
                          
                event_frmFA_Cotizacion_Mant_FormClosing += new delegate_frmFA_Cotizacion_Mant_FormClosing(frmFA_Cotizacion_Mant_event_frmFA_Cotizacion_Mant_FormClosing);
                faGridDetalle.Event_ultraGrid_AfterCellUpdate += new UCFa_GridFactura.delegate_ultraGrid_AfterCellUpdate(faGridDetalle_Event_ultraGrid_AfterCellUpdate);
                faGridDetalle.Event_ultraGrid_ClickCell += new UCFa_GridFactura.delegate_ultraGrid_ClickCell(faGridDetalle_Event_ultraGrid_ClickCell);
                UCfaBodega.Event_cmb_bodega_SelectedIndexChanged += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectedIndexChanged(faBodega_Event_cmb_bodega_SelectedIndexChanged);
                UCfaBodega.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(faBodega_Event_cmb_bodega_SelectionChangeCommitted);
                UCfaBodega.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(faBodega_Event_cmb_sucursal_SelectionChangeCommitted);

                UCfaBodega.Event_cmb_bodega1_EditValueChanged += new UCIn_Sucursal_Bodega.delegate_cmb_bodega1_EditValueChanged(UCfaBodega_Event_cmb_bodega1_EditValueChanged);
                UCfaBodega.Event_cmb_sucursal1_EditValueChanged += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal1_EditValueChanged(UCfaBodega_Event_cmb_sucursal1_EditValueChanged);


                UCfaBodega.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        void UCfaBodega_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCfaBodega_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                AnularCotizacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ImprimirDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = true;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;                
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarCotizacion();
                if (MessageBox.Show("¿Desea Salir?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarCotizacion();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void faBodega_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
             LoadProductos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void faGridDetalle_Event_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
              CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void faGridDetalle_Event_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
               CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void faBodega_Event_cmb_bodega_SelectedIndexChanged(object sender, EventArgs e){}
       
        void frmFA_Cotizacion_Mant_event_frmFA_Cotizacion_Mant_FormClosing(object sender, FormClosingEventArgs e){}
       
        private void frmFA_Cotizacion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                faGridDetalle.load_Producto(param.IdEmpresa, Convert.ToInt32(UCfaBodega.cmb_sucursal.EditValue), Convert.ToInt32(UCfaBodega.cmb_bodega.EditValue));
             
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:                                                
                        ucGe_Menu.Enabled_bntLimpiar = false;
                       ucGe_Menu.Visible_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.grabar:                        
                       ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                       ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;                        
                        break;
                    default:
                        break;
                }

                infoBodega = UCfaBodega.get_bodega();
                infoSucursal = UCfaBodega.get_sucursal();
                UCfaBodega.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;

                if(IdCotizacion!=0){
                    
                    infocotizacion.IdCotizacion = IdCotizacion;
                    UCfaCliente.txt_Direccion.Visible = false;
                    UCfaCliente.txt_Ruc.Visible = false;
                    UCfaCliente.txt_Telefonos.Visible = false;
                    UCfaCliente.lbltelefono.Visible = false;
                    UCfaCliente.llblRuc.Visible = false;
                    UCfaCliente.lblDireccion.Visible = false;
                    UCfaBodega.cmb_bodega.EditValue = Convert.ToInt32(infocotizacion.IdBodega);
                    UCfaBodega.cmb_sucursal.EditValue = Convert.ToInt32(infocotizacion.IdSucursal);
                    
                    Detalle();
                    CalcularTotales();
                    return;
                }

                UCfaBodega.cmb_sucursal.EditValue = IdSucursal;
                UCfaBodega.cmb_bodega.EditValue = IdBodega;
                faGridDetalle.Dock = DockStyle.Fill;              
                faBodega_Event_cmb_bodega_SelectionChangeCommitted(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ImprimirDatos()
        {
            try
            {
                List<fa_rpt_Cotizacion_Info> log = new List<fa_rpt_Cotizacion_Info>();


                fa_rpt_Cotizacion_Info info = new fa_rpt_Cotizacion_Info();

                listadetalle.Clear();
                Detalle();
          
                info.IdCotizacion = IdCotizacion;
                getCabecera();
                //
                //listadetalle = buscotizacion.get .Get_Info_cotizacio(param.IdEmpresa, infoSucursal.IdSucursal, infocotizacion.IdBodega, IdCotizacion);
                //convertir_infotabla(listatabla, listadetalle);
                info.listaP = listatabla;
                info.cotizacion = infocotizacion;
                info.cotizacion.Vendedor = UCfaCliente.cmb_vendedor.Text;
                info.cotizacion.Cliente = UCfaCliente.cmb_cliente.Text;
                info.Sucursal = infoSucursal.Su_Descripcion;
                info.Bodega = infoBodega.bo_Descripcion;
                info.infoEmp.em_nombre = param.InfoEmpresa.em_nombre;
                info.idUsuario = param.IdUsuario;
                info.infoEmp.em_logo = param.InfoEmpresa.em_logo;
                info.infoEmp.em_direccion = param.InfoEmpresa.em_direccion;

                info.STotal0 = Convert.ToDecimal(txtStotal0.EditValue);
                info.STotalImp = Convert.ToDecimal(txtSTotaliva.EditValue);
                log.Add(info);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AnularCotizacion()
        {
            try
            {
                string mensajeE = "";
                FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                if (infocotizacion.cc_estado == "I" || lblAnulado.Visible == true) { MessageBox.Show("La Cotizacion se encuentra Anulada."); return; }

                frm.ShowDialog();
                infocotizacion.MotivoAnu = frm.motivoAnulacion;
                infocotizacion.IdEmpresa = param.IdEmpresa;
                infocotizacion.IdSucursal = IdSucursal;
                infocotizacion.IdBodega = IdBodega;
                infocotizacion.IdCotizacion = Convert.ToDecimal(txtNumCot.Text);
                infocotizacion.Fecha_UltAnu = DateTime.Now;
                infocotizacion.IdUsuarioUltAnu = param.IdUsuario;
                if (buscotizacion.AnularDB(infocotizacion, ref mensajeE) == true)
                {
                    //MessageBox.Show("La Cotizacion se Anuló.\n" +
                    //  frm.motivoAnulacion);
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Cotización", infocotizacion.IdCotizacion);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    lblAnulado.Visible = true; 
                    ucGe_Menu.Visible_bntAnular = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Validar()
        {
            try
            {
                if (UCfaCliente.cmb_cliente.EditValue == null || Convert.ToInt32(UCfaCliente.cmb_cliente.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese un Cliente", "Validacion");
                    return false; 
                }

                if (UCfaCliente.cmb_vendedor.EditValue == null || Convert.ToInt32(UCfaCliente.cmb_vendedor.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese un Vendedor", "Validacion");
                    return false;
                }


                if (UCfaBodega.cmb_bodega.EditValue == null || Convert.ToInt32(UCfaBodega.cmb_bodega.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese una Bodega", "Validacion");
                    return false;
                }

                if (UCfaBodega.cmb_sucursal.EditValue == null || Convert.ToInt32(UCfaBodega.cmb_sucursal.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese la Sucursal", "Validacion");
                    return false;
                }

                if (txtObservacion.Text == "" || txtObservacion.Text == null)
                {
                    MessageBox.Show("Ingrese la Observacion", "Validacion");
                    return false;
                }

                List<fa_cotizacion_det_info> list = new List<fa_cotizacion_det_info>();
                int contVali = 0;
                foreach (var item in listatabla)
                {
                    if ((item.dc_cantidad == 0 || item.dc_precio == 0) && item.IdProducto != 0)
                    {
                        MessageBox.Show("Ingrese Cantidad y Precio en el Producto" + item.IdProducto, "Validacion");
                        return false;
                    }
                    if (item.IdProducto != 0)
                    {
                        contVali = contVali + 1;                        
                    }
                }

                if (contVali == 0)
                {
                    MessageBox.Show("Ingrese el Producto", "Validacion");
                    return false;
                }

                if (listatabla.Count() == 0) {
                    MessageBox.Show("Agregue Productos en la Cotizacion.", "Validacion"); 
                    return false; 
                }

                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void GuardarCotizacion()
        {
            try
            {   
                List<fa_cotizacion_det_info> listadetalleCotizac = new List<fa_cotizacion_det_info>();
                decimal IdNumCotizacion = 0;
                string message = "";
                listatabla.Clear();
                //listatabla = faGridDetalle.get_Tabla_detalle();

                txtNumCot.Focus();
                if (Validar())
                {
                    getCabecera();
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        //convertir_info(listatabla, listadetalleCotizac);
                        infocotizacion.lista_detalle = listadetalleCotizac;//asignado el detalle 

                        if (buscotizacion.GrabarDB(infocotizacion, ref IdNumCotizacion, ref message))
                        {
                            IdCotizacion = IdNumCotizacion;
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Cotización", infocotizacion.IdCotizacion);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            txtNumCot.Text = Convert.ToString(IdNumCotizacion);
                        }
                        else
                        {
                            MessageBox.Show("Error al Guardar " + message, "Guardar");
                        }
                    }
                    else if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        //convertir_info(listatabla, listadetalleCotizac);
                        infocotizacion.lista_detalle = listadetalleCotizac;
                        infocotizacion.IdCotizacion = IdCotizacion;
                        infocotizacion.Fecha_UltMod = DateTime.Now;
                        infocotizacion.IdUsuarioUltMod = param.IdUsuario;
                        if (buscotizacion.ModificarDB(infocotizacion, ref message))
                        {
                            IdCotizacion = infocotizacion.IdCotizacion;
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Cotización", infocotizacion.IdCotizacion);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;                            
                            //cambiarTabla();
                        }
                        else
                        {
                            MessageBox.Show("Error al Actualizar." + message, "Guardar");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        public void getCabecera() {
            try
            {
                infoBodega = UCfaBodega.get_bodega();
                infoSucursal = UCfaBodega.get_sucursal();

                infocotizacion.IdBodega = infoBodega.IdBodega;
                infocotizacion.IdSucursal = infoBodega.IdSucursal;
                infocotizacion.IdCliente = Convert.ToInt32(UCfaCliente.cmb_cliente.EditValue);
                infocotizacion.cc_tipopago = (rbtnContado.Checked == true) ? "CON" : "CRE";
                infocotizacion.cc_fecha = dateFecha.Value;
                infocotizacion.cc_diasPlazo = Convert.ToInt32(spinEditDiasPlazo.Value);
                infocotizacion.cc_observacion = txtObservacion.Text;
                infocotizacion.cc_interes = Convert.ToDouble( txtInteres.EditValue);
                infocotizacion.cc_transporte = Convert.ToDouble(txtTransporte.EditValue);
                infocotizacion.cc_otroValor1 = Convert.ToDouble(txtOtro1.EditValue);
                infocotizacion.cc_otroValor2 = Convert.ToDouble(txtOtro2.EditValue);
                infocotizacion.CodCotizacion = txtCodigoCot.Text;
                infocotizacion.IdVendedor = Convert.ToInt32( UCfaCliente.cmb_vendedor.EditValue);
                fa_Cliente_Bus clientebus = new fa_Cliente_Bus();
                fa_Vendedor_Info vendedor = new fa_Vendedor_Info();
                infoCliente.IdCliente = Convert.ToInt32(UCfaCliente.cmb_cliente.EditValue);
                clientebus.ConsultarClienteVendedor(param.IdEmpresa, ref infoCliente, ref vendedor);
                infocotizacion.cc_dirigidoA =UCfaCliente.cmb_cliente.Text;
                infocotizacion.cc_fechaVencimiento = dateFechaVencimiento.Value;
                infocotizacion.IdEmpresa = param.IdEmpresa;
                infocotizacion.IdUsuario = param.IdUsuario;
                infocotizacion.ip = param.ip;
                infocotizacion.nom_pc = param.nom_pc;
                infocotizacion.iva = param.iva.porcentaje;
                infocotizacion.total = Convert.ToDouble( txtTotal.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal IdCotizacion = 7135;

        public void Detalle()
        {
            try
            {                
                infocotizacion= buscotizacion.Get_Info_cotizacio(param.IdEmpresa,IdSucursal,IdBodega,IdCotizacion);
                //List<fa_cotizacion_det_info> fu = new List<fa_cotizacion_det_info>();                
                //faGridDetalle.set_grid_detalle(fu);                
                UCfaCliente.cmb_cliente.EditValue = infocotizacion.IdCliente;
                UCfaCliente.cmb_vendedor.EditValue = infocotizacion.IdVendedor;
             //   this.panel1.Controls.Add(faBodega);
                UCfaBodega.cmb_sucursal.EditValue = IdSucursal;
                UCfaBodega.cmb_bodega.EditValue = IdBodega;
                LoadProductos();
                spinEditDiasPlazo.Value = infocotizacion.cc_diasPlazo;
                rbtnContado.Checked=(infocotizacion.cc_tipopago == "CON") ? true : false;
                rbtnCredito.Checked = (infocotizacion.cc_tipopago == "CRE") ? true : false;
                txtObservacion.Text = infocotizacion.cc_observacion;
                dateFecha.Value = infocotizacion.cc_fecha;
                txtInteres.EditValue = Convert.ToDecimal(infocotizacion.cc_interes);
                txtTransporte.EditValue = Convert.ToDecimal(infocotizacion.cc_transporte);
                txtOtro1.EditValue = Convert.ToDecimal(infocotizacion.cc_otroValor1);
                txtOtro2.EditValue = Convert.ToDecimal(infocotizacion.cc_otroValor2);
                txtCodigoCot.Text = infocotizacion.CodCotizacion;
                txtNumCot.Text = Convert.ToString(IdCotizacion);
                dateFechaVencimiento.Value = infocotizacion.cc_fechaVencimiento;
                //listadetalle=buscotizacion.Get_Info_cotizacio(param.IdEmpresa, IdSucursal, IdBodega, IdCotizacion);
                //convertir_infotabla(listatabla, listadetalle);
               //faGridDetalle.set_grid_detalle(listatabla);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void spinEditDiasPlazo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                
                if (this.spinEditDiasPlazo.Value < 0)
                {
                    spinEditDiasPlazo.Value = 0;
                    return;
                }
                dateFechaVencimiento.Value = dateFecha.Value;
                dateFechaVencimiento.Value = Convert.ToDateTime(dateFechaVencimiento.Value.ToShortDateString()).AddDays(Convert.ToDouble(spinEditDiasPlazo.Value));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TimeSpan o = dateFechaVencimiento.Value - dateFecha.Value;
                spinEditDiasPlazo.Value = o.Days;
                spinEditDiasPlazo_Validating(new object(), new CancelEventArgs());
                if (this.dateFechaVencimiento.Value < dateFecha.Value)
                {
                    dateFechaVencimiento.Value = dateFecha.Value;
                    
                    return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtTransporte_KeyPress(object sender, KeyPressEventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void CalcularTotales()
        {
            try
            {
             listadetalle.Clear();
                    //listatabla = faGridDetalle.get_Tabla_detalle();
                    //convertir_info(listatabla, listadetalle);
                    double base0 = 0;
                    double base12 = 0;
                    double iva = 0;
                    foreach (var item in listadetalle)
                    {
                        if (item.dc_pagaIva == "S")
                        {
                            base12 += item.dc_total;
                            iva += item.dc_iva;
                        }
                        else
                        {
                            base0 += item.dc_total;

                        }

                    }
                    txtStotal0.EditValue = (decimal)base0;
                    txtSTotaliva.EditValue = (decimal)base12;
                    txtStotal.EditValue = (decimal)base0 + (decimal)base12;
                    txtiva.EditValue = (decimal)iva;// *((Decimal)param.iva / 100);
                    decimal otros;
                    otros = Convert.ToDecimal(txtTransporte.EditValue) + Convert.ToDecimal(txtInteres.EditValue) + Convert.ToDecimal(txtOtro1.EditValue) + Convert.ToDecimal(txtOtro2.EditValue);
                    //txtStotal.Value =txtStotal0.Value + txtSTotaliva.Value;
                    txtTotal.EditValue = Convert.ToDecimal(txtStotal.EditValue) + otros;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }

        public void limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                //faGridDetalle.Clear_Ugrid();
                txtTotal.EditValue = txtTransporte.EditValue = txtInteres.EditValue = txtiva.EditValue = txtOtro1.EditValue = txtOtro2.EditValue = txtStotal.EditValue = txtStotal0.EditValue = txtSTotaliva.EditValue = 0;
                txtNumCot.Text = txtCodigoCot.Text = txtObservacion.Text = "";
                UCfaCliente.cmb_vendedor.Text = UCfaCliente.cmb_cliente.Text = "";
                spinEditDiasPlazo.Value = 0;
                dateFecha.Value = dateFechaVencimiento.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cambiarTabla()
        {
            try
            {
                List<fa_cotizacion_det_info> list = new List<fa_cotizacion_det_info>();
                foreach (var item in listatabla)
                {
                    if (item.dc_cantidad != 0) {
                        infocotizacionDetalle.IdProducto = item.IdProducto;
                        infocotizacionDetalle.dc_peso = item.dc_peso;
                        
                        infocotizacionDetalle.dc_cantidad = item.dc_cantidad;
                        
                        infocotizacionDetalle.dc_precio = item.dc_precio;
                        infocotizacionDetalle.dc_por_desUni = item.dc_por_desUni;
                        infocotizacionDetalle.dc_precioFinal = item.dc_precioFinal;
                        infocotizacionDetalle.dc_subtotal = item.dc_subtotal;
                        infocotizacionDetalle.dc_iva = item.dc_iva;
                        infocotizacionDetalle.dc_total = item.dc_total;
                        infocotizacionDetalle.dc_pagaIva = (item.Paga_Iva==true)?"S":"N";
                        infocotizacionDetalle.dc_detallexItems = item.dc_detallexItems;
                        if (item.dc_cantidad != 0) { list.Add(item); }
                    }
                }
                //faGridDetalle.set_grid_detalle(list);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void txtTransporte_AfterExitEditMode(object sender, EventArgs e)
        {
            try
            {
             CalcularTotales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmFA_Cotizacion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmFA_Cotizacion_Mant_event_frmFA_Cotizacion_Mant_FormClosing(sender, e);
                event_frmFA_Cotizacion_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
