using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Reportes.Contabilidad;
using Core.Erp.Reportes.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Orden_Pago_Mant : Form
    {
        #region Declaración de Varibles
        public delegate void delegate_frmCP_Orden_Pago_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_Orden_Pago_Mant_FormClosing event_frmCP_Orden_Pago_Mant_FormClosing;
        string mensaje = "";
        string cadena = "Cancelación de las Facturas: ";

        Cl_Enumeradores.eTipo_action _Accion = new Cl_Enumeradores.eTipo_action();
        
        //Bus        
        cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_orden_pago_Bus Bus_OrdenPago = new cp_orden_pago_Bus();
        ba_Banco_Cuenta_Bus Bus_Banco = new ba_Banco_Cuenta_Bus();



        cp_orden_pago_formapago_Bus Bus_FormaPago = new cp_orden_pago_formapago_Bus();
        vwcp_Cbte_x_pagar_OG_Bus Bus_Cbte_x_pagar_OG = new vwcp_Cbte_x_pagar_OG_Bus();
        cp_orden_pago_tipo_Bus Bus_OrdenTipPago = new cp_orden_pago_tipo_Bus();
        ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        

        //Listas 
        cp_orden_pago_det_Info infoDet = new cp_orden_pago_det_Info();

        
        List<cp_orden_pago_tipo_Info> list_OrdenTipPago = new List<cp_orden_pago_tipo_Info>();
        List<ba_Banco_Cuenta_Info> lista_Banco = new List<ba_Banco_Cuenta_Info>();
        List<cp_orden_pago_formapago_Info> lista_FormaPago = new List<cp_orden_pago_formapago_Info>();
        List<vwcp_Cbte_x_pagar_OG_Info> lista_Cbte_x_pagar_OG = new List<vwcp_Cbte_x_pagar_OG_Info>();
        List<cp_orden_pago_det_Info> Listdet;
        List<vwcp_Cbte_x_pagar_OG_Info> lista_Cbte_x_pagar_OG_Det;
        List<ct_Cbtecble_det_Info> ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
        List<vwcp_Cbte_x_pagar_OG_Info> listatemp = new List<vwcp_Cbte_x_pagar_OG_Info>();
        

       //Infos
        ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
        vwtb_persona_beneficiario_Info info_Beneficiario = new vwtb_persona_beneficiario_Info();
        vwcp_Cbte_x_pagar_OG_Info row = new vwcp_Cbte_x_pagar_OG_Info();
        cp_orden_pago_Info Cab = new cp_orden_pago_Info();
        
        cp_orden_pago_Info Info_Orden_Pago = new cp_orden_pago_Info();
        cp_orden_pago_det_Info infoDetPago = new cp_orden_pago_det_Info();

        //BindingList
        BindingList<vwcp_Cbte_x_pagar_OG_Info> DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>();

        //Variables
        
        string Nombre = "";
        string IdTipo_op = "";
        string descripcion = "";
        decimal IdPersona = 0;
        decimal IdProveedor = 0;
        int IdOrdenPago = 0;
        string GeneraDiario;
        int IdTipoCbte_OP = 0;

        #endregion
        
        public frmCP_Orden_Pago_Mant()
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
                ucGe_Menu.event_btn_Imprimir_Reten_Click += ucGe_Menu_event_btn_Imprimir_Reten_Click;
                event_frmCP_Orden_Pago_Mant_FormClosing+=frmCP_Orden_Pago_Mant_event_frmCP_Orden_Pago_Mant_FormClosing;

                ucGe_Beneficiario.event_cmb_beneficiario_EditValueChanged += ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged;
                
                UC_DiarioContPago.validaValores = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        void ucGe_Menu_event_btn_Imprimir_Reten_Click(object sender, EventArgs e)
        {
            try
            {
               
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    decimal idProveedor = 0;
                    idProveedor = ucGe_Beneficiario.Get_Info_Proveedor() == null ? 0 : ucGe_Beneficiario.Get_Info_Proveedor().IdProveedor;
                    if (idProveedor != 0)
                    {
                        frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                        ofrm.IdEmpresa = param.IdEmpresa;
                        ofrm.IProveedor = idProveedor;
                        ofrm.carga_Grid();

                        if (ofrm.lista_AnticipoSaldo.Count != 0)
                        {
                            ofrm.ShowDialog();
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

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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
                LimpiarDatos();
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
                Imprimir();
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        void Imprimir()
        {
            try
            {
                XCXP_Rpt005_Rpt reporte = new XCXP_Rpt005_Rpt();

                int IdEmpresa = 0;              
                decimal IdOrdenPago = 0;
                decimal IdEntidad = 0;

                IdEmpresa = param.IdEmpresa;               
                IdOrdenPago =Convert.ToDecimal(txtNumOrden.EditValue);
                IdEntidad = Info_Orden_Pago.IdEntidad;

                //if (enu == Cl_Enumeradores.eTipo_action.grabar)
                //{
                //    IdEntidad = info_Beneficiario.IdEntidad;
                //}
                reporte.set_parametros(IdEmpresa, IdEntidad, IdOrdenPago);
                reporte.RequestParameters = true;

                reporte.ShowPreviewDialog();
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

                if (valida() == true)
                {

                    if (grabar() == true)
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        Boolean grabar()
        {
            try
            {
                Boolean res = true;
                this.txtObservacion.Focus();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                     
                            cp_orden_pago_tipo_Info opt_info = (cp_orden_pago_tipo_Info)cmbOrdTipPag.Properties.View.GetFocusedRow();

                            if (opt_info.GeneraDiario == "S")
                            {
                                if (!GetAsientoContable())
                                { MessageBox.Show("Verifique el Asiento Contable a generar.");
                                    res = false;
                                }
                                else
                                {
                                    Cab.GeneraDiario = opt_info.GeneraDiario;
                                    Insertar_OrdenPago();
                                    res = true;
                                }
                            }
                            else
                            {
                                Cab.GeneraDiario = opt_info.GeneraDiario;
                                Insertar_OrdenPago();
                            }
                    
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;

                    default:
                        break;
                }

             
                return res;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valida())
                    if (grabar())
                        LimpiarDatos();
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
                this.Anular();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCP_Orden_Pago_Mant_event_frmCP_Orden_Pago_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Carga_Combos()
        {
            try
            {
                list_OrdenTipPago = Bus_OrdenTipPago.Get_List_orden_pago_tipo_x_Empresa(param.IdEmpresa);
                cmbOrdTipPag.Properties.DataSource = list_OrdenTipPago;

                lista_Banco = Bus_Banco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.Properties.DataSource = lista_Banco;

                lista_FormaPago = Bus_FormaPago.Get_List_orden_pago_formapago();
                cmbFormaPago.Properties.DataSource = lista_FormaPago;
                cmbFormaPago.EditValue = lista_FormaPago.Select(q=>q.IdFormaPago).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }               
        }
       
        void ModificarAsientoContable()
        {
            try
            {
                cp_orden_pago_tipo_Info tipPago = list_OrdenTipPago.First (var=> var.IdTipo_op == cmbOrdTipPag.EditValue);

                if (tipPago.GeneraDiario == "S")
                {                                      
                    descripcion = tipPago.Descripcion;

                    vwtb_persona_beneficiario_Info Provee = ucGe_Beneficiario.Get_Persona_beneficiario_Info();
                    ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
                    double reg = 0;
                    if (DataSource.Count > 0)
                        reg = DataSource[0].Valor_Respaldado;

                    ///seteamos el Debe
                    ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdTipoCbte = Convert.ToInt32(tipPago.IdTipoCbte_OP);
                    IdTipoCbte_OP = Convert.ToInt32(tipPago.IdTipoCbte_OP);
                    info.IdCtaCble = tipPago.IdCtaCble;
                    info.IdCentroCosto = tipPago.IdCentroCosto;

                    info.dc_Valor = reg;
                    ListDetCbteCble.Add(info);
                    
                    ///seteamos el Haber
                    info = new ct_Cbtecble_det_Info();
                   // vwtb_persona_beneficiario_Info Provee = list_Beneficiario.First(var => var.secuencial == Convert.ToDecimal(cmbBeneficiario.EditValue));

                    info.IdEmpresa = param.IdEmpresa;
                    info.IdTipoCbte = Convert.ToInt32(tipPago.IdTipoCbte_OP);
                    info.IdCtaCble = (tipPago.IdCtaCble_Credito == null) ? Provee.IdCtaCble : tipPago.IdCtaCble_Credito;
                    info.IdCentroCosto = Provee.IdCentroCosto;
                    info.dc_Valor  = reg*-1;

                    ListDetCbteCble.Add(info);
                }
                else
                {
                    ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
                }
                UC_DiarioContPago.setDetalle(ListDetCbteCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmCP_Orden_Pago_Mant(Cl_Enumeradores.eTipo_action Numerador): this()
        {
            try
            {
                _Accion = Numerador; 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCP_Orden_Pago_Mant_Load(object sender, EventArgs e)
        {                                        
            try
            {
                Carga_Combos();
           
                DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>();
                this.gridControlDeudas.DataSource = DataSource;

                cp_orden_pago_Info info = new cp_orden_pago_Info();
                info.Fecha = param.Fecha_Transac;
                dteFecha.EditValue = info.Fecha;
                dteFechaPago.EditValue = info.Fecha;
                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        ucGe_Menu.Enabled_bntAnular = false;

                       txtNumOrden.Enabled = false;
                       txtNumOrden.BackColor = System.Drawing.Color.White;
                       txtNumOrden.ForeColor = System.Drawing.Color.Black;

                       txtTotPagar.Enabled = false;
                       txtTotPagar.BackColor = System.Drawing.Color.White;
                       txtTotPagar.ForeColor = System.Drawing.Color.Black;

                       this.lblAnulado.Visible = false;
                       lblSaldoOP.Visible = false;
                       txtSaldoOP.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtSaldoOP.ReadOnly = true;
                        txtNumOrden.Enabled = false;
                        txtNumOrden.BackColor = System.Drawing.Color.White;
                        txtNumOrden.ForeColor = System.Drawing.Color.Black;
                        /*cmbOrdTipPag.Enabled = false;
                        cmbOrdTipPag.BackColor = System.Drawing.Color.White;
                        cmbOrdTipPag.ForeColor = System.Drawing.Color.Black;*/
                        Set_Info_en_Controls();
                        Columnas_Grid();

                        //Para poder editar los valores de la OP
                        colValor_Respaldado.OptionsColumn.AllowEdit = true;

                        IdOrdenPago = Convert.ToInt32(txtNumOrden.EditValue);
                        lista_Cbte_x_pagar_OG_Det = new List<vwcp_Cbte_x_pagar_OG_Info>();
                        lista_Cbte_x_pagar_OG_Det = Bus_Cbte_x_pagar_OG.Get_List_Cbte_x_pagar_OG (param.IdEmpresa, IdOrdenPago);
                        DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG_Det);
                        gridControlDeudas.DataSource = DataSource;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:                                            
                          
                          ucGe_Menu.Visible_bntImprimir = false;
                          ucGe_Menu.Enabled_bntAnular = true;
                          ucGe_Menu.Visible_bntLimpiar = false;
                          ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                          ucGe_Menu.Visible_btnGuardar = false;

                          ucBa_TipoFlujo.ReadOnly(true);

                          Inhabilita_Controles();
                          Set_Info_en_Controls();

                          Columnas_Grid();

                          colValor_Respaldado.OptionsColumn.AllowEdit = false;

                          IdOrdenPago = Convert.ToInt32(txtNumOrden.EditValue);
                       
                         lista_Cbte_x_pagar_OG_Det = new List<vwcp_Cbte_x_pagar_OG_Info>();
                         lista_Cbte_x_pagar_OG_Det = Bus_Cbte_x_pagar_OG.Get_List_Cbte_x_pagar_OG(param.IdEmpresa, IdOrdenPago);
                         DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG_Det);

                         gridControlDeudas.DataSource = DataSource;


                         //UC_DiarioContPago.Cabecera_Visible=true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        txtSaldoOP.ReadOnly = true;
                        ucBa_TipoFlujo.ReadOnly(true);

                        Inhabilita_Controles();

                        Set_Info_en_Controls();
                     
                        Columnas_Grid();
                        colValor_Respaldado.OptionsColumn.AllowEdit = false;

                        IdOrdenPago = Convert.ToInt32(txtNumOrden.EditValue);

                         lista_Cbte_x_pagar_OG_Det = new List<vwcp_Cbte_x_pagar_OG_Info>();
                         lista_Cbte_x_pagar_OG_Det = Bus_Cbte_x_pagar_OG.Get_List_Cbte_x_pagar_OG(param.IdEmpresa, IdOrdenPago);
                         DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG_Det);

                         gridControlDeudas.DataSource = DataSource;

                         //UC_DiarioContPago.Cabecera_Visible = true;

                                        
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {

            try
            {
               txtNumOrden.Enabled = false;
               txtNumOrden.BackColor = System.Drawing.Color.White;
               txtNumOrden.ForeColor = System.Drawing.Color.Black;

               

               cmbOrdTipPag.Enabled = false;
               cmbOrdTipPag.BackColor = System.Drawing.Color.White;
               cmbOrdTipPag.ForeColor = System.Drawing.Color.Black;

               cmbFormaPago.Enabled = false;
               cmbFormaPago.BackColor = System.Drawing.Color.White;
               cmbFormaPago.ForeColor = System.Drawing.Color.Black;

               cmbBanco.Enabled = false;
               cmbBanco.BackColor = System.Drawing.Color.White;
               cmbBanco.ForeColor = System.Drawing.Color.Black;

               dteFecha.Enabled = false;
               dteFecha.BackColor = System.Drawing.Color.White;
               dteFecha.ForeColor = System.Drawing.Color.Black;

               dteFechaPago.Enabled = false;
               dteFechaPago.BackColor = System.Drawing.Color.White;
               dteFechaPago.ForeColor = System.Drawing.Color.Black;

               txtObservacion.Enabled = false;
               txtObservacion.BackColor = System.Drawing.Color.White;
               txtObservacion.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                
                txtNumOrden.EditValue = "0";
                txtNumOrden.Enabled = false;
                txtNumOrden.BackColor = System.Drawing.Color.White;
                txtNumOrden.ForeColor = System.Drawing.Color.Black;

                //cmbBeneficiario.EditValue = "Vacio";
                cmbOrdTipPag.EditValue = "";
                cmbOrdTipPag.Refresh();
                cmbFormaPago.Refresh();
                cmbBanco.Refresh();
                dteFecha.EditValue = System.DateTime.Now;
                dteFechaPago.EditValue = System.DateTime.Now;              
                txtObservacion.Text = "";

                txtTotPagar.EditValue = "";
                txtTotPagar.Enabled = false;
                txtTotPagar.BackColor = System.Drawing.Color.White;
                txtTotPagar.ForeColor = System.Drawing.Color.Black;

                DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>();
                gridControlDeudas.DataSource = DataSource;
                UC_DiarioContPago.LimpiarGrid();
                UC_DiarioContPago.Inicializar_diario();

                Cab = new cp_orden_pago_Info();
                Listdet = new List<cp_orden_pago_det_Info>();
                lista_Cbte_x_pagar_OG = new List<vwcp_Cbte_x_pagar_OG_Info>();

                ucGe_Menu.Visible_btnGuardar = true;
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Habilita y deshabilita las columnas de la grid de OP
        /// </summary>
        void Columnas_Grid()
        {
            try
            {
              
                colSecuencia.Visible = true;
                colIdTipo_op1.Visible = true;
           
                colReferencia.Visible = true;
                colFecha.Visible = true;
                //Deshabilidados por Pedro
                colValor_Respaldado.Visible = true;
                colTotal_a_Pagar.Visible = true;
                colTotal_a_pagar_OP.Visible = true;

                colSecuencia.OptionsColumn.AllowEdit = false;
                colIdTipo_op1.OptionsColumn.AllowEdit = false;
           
                colReferencia.OptionsColumn.AllowEdit = false;
                colFecha.OptionsColumn.AllowEdit = false;
                colTotal_a_Pagar.OptionsColumn.AllowEdit = false;
                colTotal_a_pagar_OP.OptionsColumn.AllowEdit = false;

                colIdCbteCble_Ogiro.Visible = false;
                colco_fechaOg.Visible = false;
                colco_total.Visible = false;
                colTotal_Retencion.Visible = false;

                this.colco_Valorpagar.Visible = false;
                
                colSaldoPendiente.Visible = false;
                colTipoReg.Visible = false;
           
                colcheck.Visible = false;

                this.label7.Visible = false;
                this.txtTotPagar.Visible = false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            _Accion = Accion;
        }

        public void Set_Info(cp_orden_pago_Info InfoOP)
        {
            try
            {
                Info_Orden_Pago = InfoOP;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Info_en_Controls()
        {
            try
            {
                this.txtNumOrden.EditValue = Info_Orden_Pago.IdOrdenPago;
                this.txtObservacion.Text = Info_Orden_Pago.Observacion;

                ucBa_TipoFlujo.set_TipoFlujoInfo(Info_Orden_Pago.IdTipoFlujo);
               
                this.cmbOrdTipPag.EditValue = Info_Orden_Pago.IdTipo_op;
                this.cmbFormaPago.EditValue = Info_Orden_Pago.IdFormaPago;
                this.cmbBanco.EditValue = Info_Orden_Pago.IdBanco == 0 ? null : Info_Orden_Pago.IdBanco;
                this.dteFecha.EditValue = (Info_Orden_Pago.Fecha);
                this.dteFechaPago.EditValue = Info_Orden_Pago.Fecha_Pago;

                this.txtSaldoOP.Text = Convert.ToString(Info_Orden_Pago.Saldo);
             
                cp_orden_pago_det_Bus bus = new cp_orden_pago_det_Bus();

                infoDetPago=bus.Get_Info_orden_pago(param.IdEmpresa, Info_Orden_Pago.IdOrdenPago);

                if (Info_Orden_Pago.IdTipo_op != "FACT_PROVEE")
                {
                    UC_DiarioContPago.setInfo(Convert.ToInt32(infoDetPago.IdEmpresa_cxp), Convert.ToInt32(infoDetPago.IdTipoCbte_cxp), Convert.ToDecimal(infoDetPago.IdCbteCble_cxp));
                    UC_DiarioContPago.HabilitarGrid(false);
                }
                else
                {
                    UC_DiarioContPago.HabilitarGrid(false);
                
                }

                if (Info_Orden_Pago.Estado.ToString() == "I")
                {
                    this.lblAnulado.Visible = true;
                }
                else
                {
                    this.lblAnulado.Visible = false;               
                }
                Cl_Enumeradores.eTipoPersona TipoPersona = (Cl_Enumeradores.eTipoPersona)Enum.Parse(typeof(Cl_Enumeradores.eTipoPersona), Info_Orden_Pago.IdTipo_Persona);
                ucGe_Beneficiario.set_Persona_beneficiario_Info(TipoPersona, Info_Orden_Pago.IdEntidad);    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void GetCabecera()
        {
            try
            {

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                            Cab.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                        else Cab.IdTipoFlujo = null;

                        Cab.IdEmpresa = param.IdEmpresa;
                        Cab.IdOrdenPago = Convert.ToDecimal((this.txtNumOrden.EditValue == "") ? 0 : txtNumOrden.EditValue);
                        Cab.IdTipo_op = Convert.ToString(this.cmbOrdTipPag.EditValue);
                        vwtb_persona_beneficiario_Info obj_cmbProve = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                        Cab.IdProveedor = obj_cmbProve.IdEntidad;
                        Cab.Observacion = this.txtObservacion.Text;
                        Cab.Fecha = Convert.ToDateTime(this.dteFecha.EditValue);

                        Cab.IdFormaPago = Convert.ToString(cmbFormaPago.EditValue);
                        Cab.Fecha_Pago = Convert.ToDateTime(dteFechaPago.EditValue);

                        Cab.IdBanco = Convert.ToInt32(cmbBanco.EditValue);

                        cp_orden_pago_tipo_Info cmbOrdTipPa = (cp_orden_pago_tipo_Info)cmbOrdTipPag.Properties.View.GetFocusedRow();

                        if (cmbOrdTipPa.IdEstadoAprobacion == null)
                        {
                            MessageBox.Show("El tipo de pago : " + " * " + cmbOrdTipPa.Descripcion + " * " + " no está aprobado. Imposible grabar ", "Sistemas");
                            return;
                        }
                        else
                        {
                            Cab.IdEstadoAprobacion = cmbOrdTipPa.IdEstadoAprobacion;
                        }

                        Cab.IdPersona = obj_cmbProve.IdPersona;
                        Cab.IdTipo_Persona = obj_cmbProve.IdTipo_Persona;
                        Cab.IdEntidad = obj_cmbProve.IdEntidad;

                        Cab.IdUsuario = param.IdUsuario;
                        Cab.nom_pc = param.nom_pc;
                        Cab.ip = param.ip;

                        GetDetalle();
                        Cab.Detalle = Listdet;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Cab.IdEmpresa = param.IdEmpresa;
                        Cab.IdOrdenPago = Convert.ToDecimal((this.txtNumOrden.EditValue == "") ? 0 : txtNumOrden.EditValue);
                        Cab.Observacion = this.txtObservacion.Text;
                        Cab.Fecha = Convert.ToDateTime(this.dteFecha.EditValue);
                        Cab.IdTipo_op = Convert.ToString(this.cmbOrdTipPag.EditValue);
                        Cab.IdPersona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdPersona;
                        Cab.IdTipo_Persona = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdTipo_Persona;
                        Cab.IdEntidad = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdEntidad;
                        
                        Cab.IdFormaPago = Convert.ToString(cmbFormaPago.EditValue);

                        Cab.IdBanco = Convert.ToInt32(cmbBanco.EditValue);
                        Cab.Fecha_Pago = Convert.ToDateTime(this.dteFechaPago.EditValue);

                        if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)                        
                            Cab.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;                        
                        else Cab.IdTipoFlujo = null;

                        GetDetalle();

                        break;

                    default:
                        break;
                }
                
                
                                                                            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetDetalle()
        {
            try
            {
                int focus = this.gridViewDeudas.FocusedRowHandle;
                gridViewDeudas.FocusedRowHandle = focus + 1;
                              
                Listdet = new List<cp_orden_pago_det_Info>();
                cp_orden_pago_det_Info info_det;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG);
                }
               
                this.gridControlDeudas.DataSource = DataSource;
                                
                foreach (var item in DataSource)
                {                  
                    info_det = new cp_orden_pago_det_Info();
                                                    
                    if (item.check == true ||  colcheck.Visible == false)
                    {
                        info_det.IdEmpresa = param.IdEmpresa;
                        info_det.IdEmpresa_cxp = item.IdEmpresa;
                        info_det.IdCbteCble_cxp = item.IdCbteCble_Ogiro;
                        info_det.IdTipoCbte_cxp = item.IdTipoCbte_Ogiro;
                        info_det.Valor_a_pagar = item.Valor_Respaldado;
                        info_det.Referencia = item.Referencia;
                        info_det.IdFormaPago = Cab.IdFormaPago;
                        info_det.Fecha_Pago = Cab.Fecha_Pago;
                        info_det.IdEstadoAprobacion = Cab.IdEstadoAprobacion;
                        info_det.Idbanco = Convert.ToInt32(Cab.IdBanco);
                        info_det.Secuencia = item.Secuencia;
                        info_det.IdOrdenPago = item.IdOrdenPago;
                    
                        Listdet.Add(info_det);
                    }
                }


                foreach (var item in Listdet)
                {
                    item.Fecha_Pago = Convert.ToDateTime(dteFechaPago.EditValue);
                    item.IdFormaPago= Convert.ToString(cmbFormaPago.EditValue);
                    item.Idbanco = Convert.ToInt32(cmbBanco.EditValue);

                }

                Cab.Detalle = Listdet;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean GetAsientoContable()
        {
            Boolean res = true;
            try
            {               
                InfoCbteCble = UC_DiarioContPago.Get_Info_CbteCble();
                InfoCbteCble.cb_Observacion = txtObservacion.Text;

                foreach (var item in InfoCbteCble._cbteCble_det_lista_info)
                {
                    item.dc_Observacion = item.dc_Observacion + " " + InfoCbteCble.cb_Observacion;
                    item.IdEmpresa = param.IdEmpresa;
                    item.IdTipoCbte = IdTipoCbte_OP;

                    if (String.IsNullOrEmpty(item.IdCtaCble))
                    {
                        res= false;                    
                    }
                }

                InfoCbteCble.IdEmpresa = param.IdEmpresa;
                if (IdTipoCbte_OP == 0)
                {
                    MessageBox.Show("Por favor verifique los parámetros del Tipo de comprobante para la Orden de Pago.");
                    res= false;
                }
                InfoCbteCble.IdTipoCbte = IdTipoCbte_OP;
                InfoCbteCble.IdUsuario = param.IdUsuario;
                InfoCbteCble.cb_Fecha = Convert.ToDateTime(Convert.ToDateTime
                    (dteFecha.EditValue).ToShortDateString());
                InfoCbteCble.Anio = InfoCbteCble.cb_Fecha.Year;
                InfoCbteCble.Mes = InfoCbteCble.cb_Fecha.Month;
                InfoCbteCble.cb_Observacion = "";

            
                InfoCbteCble.cb_FechaTransac = param.Fecha_Transac;
                InfoCbteCble.cb_Valor = InfoCbteCble._cbteCble_det_lista_info.FindAll(var=>var.dc_Valor >0).
                    Sum(var => var.dc_Valor);
                InfoCbteCble.Mayorizado = "N";

                string mes = Convert.ToString(InfoCbteCble.Mes);
                if (mes.Length == 1)
                    mes = "0" + mes;    

                string AnioMes = Convert.ToString(InfoCbteCble.Anio) + mes;
                int IdPeriodo = Convert.ToInt32(AnioMes);

                InfoCbteCble.IdPeriodo = IdPeriodo;
                InfoCbteCble.Estado = "A";
                InfoCbteCble.cb_Fecha = InfoCbteCble.cb_Fecha;
                InfoCbteCble.cb_Valor = InfoCbteCble.cb_Valor;

                return res;  
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return res; 
            }
                
        }
        
        public Boolean Insertar_OrdenPago()
        {
            try
            {
                GetCabecera();
                Boolean res = false;

                    decimal Id = 0;
                    decimal IDCbte = 0;
                    string codigoCbte = "";

                    cp_orden_pago_det_Bus detalle = new cp_orden_pago_det_Bus();

                res=Bus_OrdenPago.GuardaDB(Cab, ref Id, ref mensaje);
                if (Id != 0)
                {
                    Cab.IdOrdenPago = Id;
                    Info_Orden_Pago.IdEntidad = Cab.IdEntidad;
                    txtNumOrden.Text = Id.ToString();
                }
                if (res)
                    {
                        if (Cab.GeneraDiario == "S")
                        {
                            InfoCbteCble.cb_Observacion = txtObservacion.Text + " Cbte Diario x OP # " + Id + " al beneficiario " + Nombre + " por " + descripcion;
                            if (BusCbteCble.GrabarDB(InfoCbteCble, ref IDCbte, ref mensaje))
                            {
                                infoDet.IdEmpresa = Cab.IdEmpresa;
                                infoDet.IdEmpresa_cxp = param.IdEmpresa;
                                infoDet.IdCbteCble_cxp = IDCbte;
                                infoDet.IdTipoCbte_cxp = IdTipoCbte_OP;
                                infoDet.IdOrdenPago = Id;
                                
                                detalle.ModificarDB(infoDet, ref Id, ref mensaje);
                            }
                        }
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Orden de Pago ", Id);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        this.txtNumOrden.Text = Convert.ToString(Id);
                        if (MessageBox.Show("¿ Imprimir la transaccion ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }

                        if (Cab.GeneraDiario == "S")
                        {
                            if (MessageBox.Show("¿ imprimir  asiento contable ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {

                                Imprimir_Diario(InfoCbteCble.IdTipoCbte, InfoCbteCble.IdCbteCble);
                            }
                        }
                        LimpiarDatos();
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, mensaje);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Anular()
        {
            try
            {         
                if (Info_Orden_Pago != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    
                    //if (SETINFO_.Estado.ToString() == "A")
                    //{
                       
                        if (MessageBox.Show("¿Está seguro que desea anular la orden de pago #: " + Info_Orden_Pago.IdOrdenPago + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            oFrm.ShowDialog();
                            Info_Orden_Pago.Observacion = "***ANULADO*** " + Info_Orden_Pago.Observacion;
                            Info_Orden_Pago.MotiAnula = oFrm.motivoAnulacion;
                            Info_Orden_Pago.IdUsuarioUltAnu = param.IdUsuario;
                            Info_Orden_Pago.Fecha_UltAnu = param.Fecha_Transac;
                            Info_Orden_Pago.IdEmpresa = param.IdEmpresa;

                            // reversar el diario
                            BusCbteCble = new ct_Cbtecble_Bus();
                            decimal IdCbteCbleRev = 0;
                            string msg = "";

                            int IdTipoCbteRev = 0;

                          cp_orden_pago_tipo_Info InfoTipoOp= list_OrdenTipPago.FirstOrDefault(v => v.IdTipo_op == Convert.ToString(cmbOrdTipPag.EditValue));
                          if (InfoTipoOp.IdTipoCbte_OP_anulacion == 0 || InfoTipoOp.IdTipoCbte_OP_anulacion == null)
                          {
                              MessageBox.Show("No existe un tipo de comprobante para anular la OP verifique los parametros de Tipo de OP");
                              return;
                          }

                          IdTipoCbteRev = Convert.ToInt32(InfoTipoOp.IdTipoCbte_OP_anulacion);



                            cp_orden_pago_cancelaciones_Bus bus_OPCan = new cp_orden_pago_cancelaciones_Bus();
                            List<cp_orden_pago_cancelaciones_Info> lista_OPCan = new List<cp_orden_pago_cancelaciones_Info>();

                            if (Info_Orden_Pago.IdTipo_op != "FACT_PROVEE")
                            {

                                if (BusCbteCble.ReversoCbteCble(Convert.ToInt32(infoDetPago.IdEmpresa_cxp), Convert.ToDecimal(infoDetPago.IdCbteCble_cxp), Convert.ToInt32(infoDetPago.IdTipoCbte_cxp), IdTipoCbteRev,
                           ref IdCbteCbleRev, ref msg, Info_Orden_Pago.IdUsuarioUltAnu, Info_Orden_Pago.MotiAnula))
                                {
                                                                              if (Bus_OrdenPago.AnularDB(Info_Orden_Pago))
                                            {
                                                //string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Orden de Pago ", SETINFO_.IdOrdenPago);
                                                //MessageBox.Show(smensaje, param.Nombre_sistema);
                                                MessageBox.Show("Orden de Pago #: " + Info_Orden_Pago.IdOrdenPago + " Anulado correctamente, Con el Tipo de Comprobante de Anulación #" + IdTipoCbteRev + " y el Comprobante de Anulacion #: " + IdCbteCbleRev);

                                                lblAnulado.Visible = true;
                                                ucGe_Menu.Visible_btnGuardar = false;
                                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                            }
                                            else MessageBox.Show("No se pudo anular la orden de pago #: " + Info_Orden_Pago.IdOrdenPago, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Reversar el Comprobante: " + infoDetPago.IdCbteCble_cxp + "(" + msg + ")", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                            }
                            else
                            {
                                // actualizar detalle op                       
                                // consulto detalle op
                                cp_orden_pago_det_Bus bus_opDet = new cp_orden_pago_det_Bus();
                                List<cp_orden_pago_det_Info> lista_opDet = new List<cp_orden_pago_det_Info>();
                                string mensaje = "";
                                lista_opDet = bus_opDet.Get_List_OrdenPagoDetalle(infoDetPago.IdEmpresa, infoDetPago.IdOrdenPago, ref mensaje);

                                if (lista_opDet.Count != 0)
                                {
                                    if (bus_opDet.ModificarDB(lista_opDet))
                                    {
                                        if (Bus_OrdenPago.AnularDB(Info_Orden_Pago))
                                        {

                                            MessageBox.Show("Orden de Pago #: " + Info_Orden_Pago.IdOrdenPago + " Anulado correctamente", "SISTEMAS");

                                            lblAnulado.Visible = true;
                                            ucGe_Menu.Visible_btnGuardar = false;
                                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                        }
                                    }
                                    else
                                    {

                                        MessageBox.Show("No se pudo anular la orden de pago #: " + Info_Orden_Pago.IdOrdenPago, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    
                                    }
                                }
                        
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

        Boolean Actualizar()
        {
            try
            {
                Boolean res = true;
                GetCabecera();
                

                if (Bus_OrdenPago.ModificarDB(Cab, ref  mensaje))
                {
                    res = true;                    
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Orden de Pago ", Cab.IdOrdenPago);
                    MessageBox.Show(smensaje, param.Nombre_sistema);

                    if (MessageBox.Show("¿Imprimir la Transacion ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Imprimir();
                    }

                   
                    if (MessageBox.Show("¿Imprimir el asiento contable ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                     
                        if (Cab.Detalle.Count() > 0)
                        {
                            cp_orden_pago_det_Info info_d = Cab.Detalle.FirstOrDefault();
                            if (info_d.IdCbteCble_cxp > 0)
                            {
                                Imprimir_Diario(Convert.ToInt32(info_d.IdTipoCbte_cxp), Convert.ToDecimal(info_d.IdCbteCble_cxp));
                            }
                        }
                    }
                    
                    LimpiarDatos();
                }
                else
                {
                    res = false;
                    MessageBox.Show(mensaje, "Sistemas");
                }

                return res;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public Boolean valida()
        {
            try
            {
                if (this.txtObservacion.Text == "" || this.txtObservacion.Text == null)
                {
                    MessageBox.Show("Ingrese la observación ", "Sistemas");
                    return false;
                }
                if (this.cmbOrdTipPag.EditValue == "" || this.cmbOrdTipPag.EditValue == null)
                {
                    MessageBox.Show("Ingrese el tipo de pago ", "Sistemas");
                    return false;
                }

                if (this.cmbFormaPago.EditValue == "" || this.cmbFormaPago.EditValue == null)
                {
                    MessageBox.Show("Ingrese la forma de pago ", "Sistemas");
                    return false;
                }
                if (this.ucGe_Beneficiario.Get_Persona_beneficiario_Info() == null )
                {
                    MessageBox.Show("Ingrese el beneficiario ", "Sistemas");
                    return false;
                }
          
                if (Valida_Detalle() == true)
                {
                }
                else
                { return false; }

                if (GeneraDiario == "S")
                {
                    return UC_DiarioContPago.ValidarAsientosContables();               
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXP, Convert.ToDateTime(dteFecha.EditValue)))
                    return false;

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CONTA, Convert.ToDateTime(dteFecha.EditValue)))
                    return false;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        if (ucBa_TipoFlujo.get_TipoFlujoInfo() == null)
                        {
                            MessageBox.Show("Seleccione el tipo de flujo",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                            return false;
                        }
                        break;                    
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

        public Boolean Valida_Detalle()
        {
            try
            {
                Boolean res = true;
                
                
                if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
               {
                   int focus = this.gridViewDeudas.FocusedRowHandle;
                   gridViewDeudas.FocusedRowHandle = focus + 1;
                    
                    int cont = 0;
                   foreach (var item in DataSource)
                   {
                       if (item.Valor_Respaldado == 0)
                       {
                           cont = cont + 1;
                       }

                       if (item.Valor_Respaldado < 0)
                       {
                           MessageBox.Show("No se permiten valores negativos ", "Sistemas");
                           res= false;
                       }
                   }

                   if (DataSource.Count() == cont)
                   {
                       MessageBox.Show("El detalle de pago no tiene valores a cancelar ", "Sistemas");
                       res= false;
                   }

               }
                return res;
                                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;            
            }
                       
        }

        private void cmbOrdTipPag_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (ucGe_Beneficiario.Get_Persona_beneficiario_Info() == null)
                    {

                        gridViewDeudas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>();
                        gridControlDeudas.DataSource = DataSource;
                        return;
                    }

                    foreach (var item in list_OrdenTipPago)
                    {
                        if (item.IdTipo_op == cmbOrdTipPag.EditValue)
                        {
                            IdTipo_op = item.IdTipo_op;

                            if (item.GeneraDiario.ToString() == "S" && (info_Beneficiario.IdCtaCble == null || item.IdCtaCble == null))
                            {
                                GeneraDiario_SN();
                                return;
                            }

                            if (item.GeneraDiario.ToString() == "N")
                            {
                                vwtb_persona_beneficiario_Info info_benefi = (vwtb_persona_beneficiario_Info)ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                                cp_orden_pago_tipo_Info obj_pertip = (cp_orden_pago_tipo_Info)cmbOrdTipPag.Properties.View.GetFocusedRow();


                                if (IdTipo_op == "FACT_PROVEE" && info_benefi.IdTipo_Persona == "PROVEE")
                                {
                                    string TipoReg = Convert.ToString(cmbOrdTipPag.EditValue);

                                    colcheck.Visible = true;
                                    colIdCbteCble_Ogiro.Visible = true;
                                    colco_fechaOg.Visible = true;
                                    colco_total.Visible = true;
                                    colTotal_Retencion.Visible = true;

                                    colco_Valorpagar.Visible = true;
                                    colSaldoPendiente.Visible = true;

                                    IdProveedor = ucGe_Beneficiario.Get_Persona_beneficiario_Info().IdEntidad;

                                    lista_Cbte_x_pagar_OG = Bus_Cbte_x_pagar_OG.Get_List_Cbte_x_pagar_OG(param.IdEmpresa, IdProveedor, TipoReg);

                                    DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG);
                                    gridControlDeudas.DataSource = DataSource;

                                    UC_DiarioContPago.Visible = false;
                                    UC_DiarioContPago.LimpiarGrid();
                                    UC_DiarioContPago.Inicializar_diario();

                                    return;
                                }
                                else
                                {
                                    GeneraDiario_SN();
                                    UC_DiarioContPago.Visible = false;
                                    return;
                                }
                            }

                            if (item.GeneraDiario.ToString() == "S")
                            {
                                GeneraDiario_SN();
                                ModificarAsientoContable();
                                return;
                            }
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
    
        private void cmbOrdTipPag_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        void GeneraDiario_SN()
        {
            try
            {
                vwcp_Cbte_x_pagar_OG_Info infotemp = new vwcp_Cbte_x_pagar_OG_Info();
                listatemp = new List<vwcp_Cbte_x_pagar_OG_Info>();
                listatemp.Add(infotemp);

                gridViewDeudas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(listatemp);
                gridControlDeudas.DataSource = DataSource;

                colSaldoPendiente.Visible = false;
               

                colco_Valorpagar.Visible = false;
                colco_fechaOg.Visible = false;
                colco_total.Visible = false;
                colTotal_Retencion.Visible = false;
                colIdCbteCble_Ogiro.Visible = false;
                colcheck.Visible = false;

                colReferencia.OptionsColumn.AllowEdit = true;
                gridViewDeudas.SetFocusedRowCellValue(colTipoReg, IdTipo_op);

                lista_Cbte_x_pagar_OG = new List<vwcp_Cbte_x_pagar_OG_Info>();
                lista_Cbte_x_pagar_OG = listatemp;
                DataSource = new BindingList<vwcp_Cbte_x_pagar_OG_Info>(lista_Cbte_x_pagar_OG);
                gridControlDeudas.DataSource = DataSource;

                UC_DiarioContPago.Visible = true;
                UC_DiarioContPago.LimpiarGrid();   
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
                                                  
        }
        
        private void gridViewDeudas_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {                           
                vwcp_Cbte_x_pagar_OG_Info row1 = new vwcp_Cbte_x_pagar_OG_Info();
                row1 = (vwcp_Cbte_x_pagar_OG_Info)gridViewDeudas.GetRow(e.RowHandle);
                if (e.HitInfo.Column != null)
                {
                    e.HitInfo.Column.FieldName = gridViewDeudas.FocusedColumn.FieldName;
                    if (e.HitInfo.Column.FieldName == "check")
                    {
                        switch (_Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                if ((bool)gridViewDeudas.GetFocusedRowCellValue(colcheck))
                                {
                                    gridViewDeudas.SetFocusedRowCellValue(colcheck, false);
                                    vwcp_Cbte_x_pagar_OG_Info info = new vwcp_Cbte_x_pagar_OG_Info();
                                    info.check = false;
                                    info.TipoReg = row1.TipoReg;
                                    info.Referencia = row1.Referencia;
                                    info.IdCbteCble_Ogiro = row1.IdCbteCble_Ogiro;
                                    info.Fecha = row1.co_fechaOg;

                                    info.co_Valorpagar = row1.co_Valorpagar;

                                    info.Valor_Respaldado = row1.Valor_Respaldado;
                                    info.SaldoPendiente = row1.SaldoPendiente;
                                    info.SaldoAUX = row1.SaldoAUX;

                                    gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, 0);
                                    gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, info.SaldoAUX);

                                    String sub_cadena = cadena;
                                    sub_cadena = sub_cadena.Replace(row1.CodTipoDocumento + ":" + row1.co_factura  + "/", "");
                                    cadena = sub_cadena.Replace(row1.CodTipoDocumento + ":" + row1.co_factura + "/", "");

                                    txtObservacion.Text = sub_cadena;

                                    if (txtObservacion.Text == "Cancelación de las Facturas: ")
                                    {
                                        txtObservacion.Text = "";

                                    }

                                }
                                else
                                {
                                    gridViewDeudas.SetFocusedRowCellValue(colcheck, true);
                                    vwcp_Cbte_x_pagar_OG_Info info2 = new vwcp_Cbte_x_pagar_OG_Info();
                                    info2.check = true;
                                    info2.TipoReg = row1.TipoReg;
                                    info2.Referencia = row1.Referencia;
                                    info2.IdCbteCble_Ogiro = row1.IdCbteCble_Ogiro;
                                    info2.Fecha = row1.co_fechaOg;
                                    info2.co_Valorpagar = row1.co_Valorpagar;
                                    info2.Valor_Respaldado = row1.Valor_Respaldado;
                                    info2.SaldoPendiente = row1.SaldoPendiente;
                                    info2.SaldoAUX = row1.SaldoAUX;

                                    gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, info2.SaldoAUX);
                                    gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, 0);

                                    cadena = cadena + row1.CodTipoDocumento + ":" + row1.co_factura + "/";
                                    txtObservacion.Text = cadena;
                                }
                                break;

                            default:
                                break;
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
                 
        private void gridViewDeudas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {                           
                row = (vwcp_Cbte_x_pagar_OG_Info)gridViewDeudas.GetRow(e.RowHandle);
                                                                                    
                if (e.Column.Name == "colValor_Respaldado" && colcheck.Visible == false)
                {
                    if (row.Valor_Respaldado < 0)
                    {
                        MessageBox.Show("No se permiten valores negativos", "Sistemas");
                        gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, 0);
                        ModificarAsientoContable();
                        return;
                    }
                    else
                    {
                        if (_Accion != Cl_Enumeradores.eTipo_action.actualizar)
                        {
                            ModificarAsientoContable();    
                        }
                        txtTotPagar.EditValue = row.Valor_Respaldado;
                    }                         
                }

                else
                {                                                                                            
                    if (e.Column.Name == "colValor_Respaldado")
                    {
                        if (row.Valor_Respaldado < 0)
                        {
                            MessageBox.Show("No se permiten valores negativos", "Sistemas");
                            //gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, 0);
                            if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                            {
                                gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, Convert.ToDouble(gridViewDeudas.GetFocusedRowCellValue(colValor_Respaldado)));
                                gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, row.SaldoAUX);
                                gridViewDeudas.SetFocusedRowCellValue(colcheck, false);
                                return;
                            }
                            else
                            {
                                gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, 0);
                            }
                            ModificarAsientoContable();
                            txtTotPagar.EditValue = row.Valor_Respaldado;
                            return;
                        }
                        else
                        {
                            if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                            {
                                gridViewDeudas.SetFocusedRowCellValue(colco_Valorpagar, row.Valor_Respaldado);
                                gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, row.SaldoAUX);
                                gridViewDeudas.SetFocusedRowCellValue(colcheck, false);
                                return;
                            }
                            else
                            {
                                if (e.Column.Name == "colValor_Respaldado" && Convert.ToDecimal(gridViewDeudas.GetFocusedRowCellValue(colValor_Respaldado)) > 0)
                                {
                                    double x = row.SaldoAUX;
                                    double f = row.Valor_Respaldado;

                                    if (f > x)
                                    {
                                        f = row.SaldoAUX;
                                        gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, f);

                                        gridViewDeudas.SetFocusedRowCellValue(colValor_Respaldado, 0);


                                        gridViewDeudas.SetFocusedRowCellValue(colcheck, false);
                                    }
                                    double r = x - f;

                                    gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, r);
                                    gridViewDeudas.SetFocusedRowCellValue(colcheck, true);
                                }

                                if (e.Column.Name == "colValor_Respaldado" && Convert.ToDecimal(gridViewDeudas.GetFocusedRowCellValue(colValor_Respaldado)) == 0)
                                {

                                    double x = row.SaldoAUX;
                                    gridViewDeudas.SetFocusedRowCellValue(colcheck, false);
                                    gridViewDeudas.SetFocusedRowCellValue(colSaldoPendiente, x);
                                }

                                double suma = 0;
                                foreach (var item in lista_Cbte_x_pagar_OG)
                                {
                                    suma = suma + item.Valor_Respaldado;
                                }
                                txtTotPagar.EditValue = suma;
                                ModificarAsientoContable();
                            }
                        }
                    }
               }
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
        private void frmCP_Orden_Pago_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_frmCP_Orden_Pago_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {
            try
            {
                if(_Accion!=Cl_Enumeradores.eTipo_action.grabar)
                    Set_Info_en_Controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFormaPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string FormaPago = "";
                FormaPago = Convert.ToString(cmbFormaPago.EditValue);
                if (FormaPago == "EFEC")
                    cmbBanco.Enabled = false;
                else
                    cmbBanco.Enabled = true;
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Imprimir_Diario(int IdTipoCbte, decimal IdCbteCble)
        {
            XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
            ct_Cbtecble_Bus BusCbteCble = new ct_Cbtecble_Bus();

            reporte.set_parametros(param.IdEmpresa, IdTipoCbte, IdCbteCble);
            reporte.RequestParameters = true;
            reporte.ShowPreviewDialog();
        }

        private void ucBa_TipoFlujo_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
