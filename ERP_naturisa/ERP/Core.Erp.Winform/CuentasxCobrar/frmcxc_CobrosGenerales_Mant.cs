using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.CuentasxCobrar;
using Microsoft.VisualBasic.Devices;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Caja;
using Core.Erp.Reportes.CuentasxCobrar;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.Caja;
using Core.Erp.Reportes.Contabilidad;
using Core.Erp.Info.Bancos;

///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_CobrosGenerales_Mant : Form
    {

        string MensajeError = "";
        string cadena = "Canc./: ";
        public delegate void Delegate_FrmClose(object sender, FormClosingEventArgs e);
        public event Delegate_FrmClose event_FrmClose;

        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        cxc_cobro_tipo_Bus BustipoCxC = new cxc_cobro_tipo_Bus();
        List<cxc_cobro_tipo_Info> list_cobro_tipo_info = new List<cxc_cobro_tipo_Info>();
        
        cxc_cobro_Bus Bus = new cxc_cobro_Bus();
        cxc_cobro_Info Info_Cobro = new cxc_cobro_Info();
        List<cxc_cobro_Det_Info> list_det_cobro_Info = new List<cxc_cobro_Det_Info>();

        fa_TipoNota_Bus BusTipoNota = new fa_TipoNota_Bus();
        List<fa_TipoNota_Info> ListTipoNota = new List<fa_TipoNota_Info>();

        tb_banco_Bus BusBanco = new tb_banco_Bus();
        tb_tarjeta_Bus BusTarje = new tb_tarjeta_Bus();
        
        cxc_parametro_Bus cxcParametroBus = new cxc_parametro_Bus();
        
        BindingList<vwcxc_cartera_x_cobrar_Info> bList = new BindingList<vwcxc_cartera_x_cobrar_Info>();

        List<caj_Caja_Info> ListCaja = new List<Info.Caja.caj_Caja_Info>();
        caj_Caja_Bus busCaja = new caj_Caja_Bus();

        fa_notaCreDeb_Info NDCInfo = new fa_notaCreDeb_Info();
        List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>();
        fa_notaCredDeb_Bus BusBNotaDB = new fa_notaCredDeb_Bus();
        cxc_parametro_Info InfoCxCPara = new cxc_parametro_Info();
        cxc_parametro_Bus BusCxCPara = new cxc_parametro_Bus();

        
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public frmCxc_CobrosGenerales_Mant()
        {
            try
            {
                InitializeComponent();                
            //    ctrl_Cliente.Event_cmb_cliente_RowSelected += new Controles.UCFa_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(ctrl_Cliente_Event_cmb_cliente_RowSelected);
                event_FrmClose += new Delegate_FrmClose(frmcxc_CobrosGenerales_Mant_event_FrmClose);
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click +=ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click +=ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnImprimirSoporte_Click += ucGe_Menu_event_btnImprimirSoporte_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        public void Set_info(cxc_cobro_Info _Info )
        {
            try
            {
                Info_Cobro = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<XCXC_Rpt004_Info> lstRpt = new List<XCXC_Rpt004_Info>();
                XCXC_Rpt004_Bus busRpt = new XCXC_Rpt004_Bus();
                XCXC_Rpt004_rpt reporte = new XCXC_Rpt004_rpt(param.IdUsuario);

                reporte.RequestParameters = false;
                lstRpt = busRpt.get_ImpresionCobro(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal), Info_Cobro.IdCobro);
                reporte.lstRpt = lstRpt;
                reporte.CreateDocument();
                reporte.ShowPreviewDialog();

                if (MessageBox.Show("¿Desea imprimir el diario del cobro?",param.Nombre_sistema,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ImprimirDiario();    
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ImprimirDiario()
        {
            try
            {
                XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();

                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                cxc_cobro_x_ct_cbtecble_Bus BusCxCxCt = new cxc_cobro_x_ct_cbtecble_Bus();
                InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                InfoCxCxCt = BusCxCxCt.Get_Info_cobro_x_ct_cbtecble(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal), Convert.ToDecimal(txtIdCuenta.Text));

                reporte.set_parametros(InfoCxCxCt.ct_IdEmpresa, InfoCxCxCt.ct_IdTipoCbte, InfoCxCxCt.ct_IdCbteCble);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();

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

        void LimpiarDatos()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucFa_ClienteCmb1.Inicializar_cmb_cliente();
                txtNum_documento.Text = txtNumCuenta.Text = txtNumTarje.Text = txtObservacion.Text = txtRecibo.Text = txtCodCuenta.Text = txtIdCuenta.Text = "";
                txeSaldoPendiente.EditValue = txeValor.EditValue = 0.00;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_Cobro = new cxc_cobro_Info();
                Info_Cobro.ListaCobro = new List<cxc_cobro_Det_Info>();
                bList = new BindingList<vwcxc_cartera_x_cobrar_Info>();
                gridControlCobro.DataSource = bList;
                UC_Cbte_Contable.LimpiarGrid();
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
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
                guardarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean guardarDatos()
        {
            try
            {
                txtObservacion.Focus();
                Boolean bolResult = true;
                if (validar()) { return false; }
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Get();
                        string mensaErro = "";


                        if (Bus.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref Info_Cobro, ref mensaErro))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Cuenta por Cobrar ", Info_Cobro.IdCobro);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdCuenta.Text = Info_Cobro.IdCobro.ToString();
                            if (Info_Cobro.cr_Codigo == "")
                            {
                                txtCodCuenta.Text = "CXC" + Info_Cobro.IdCobro;
                                txtRecibo.Text = Info_Cobro.cr_recibo.ToString();
                            }
                           
                            cargarGridContable();

                            if (MessageBox.Show("¿Desea Imprimir el Cobro # " + Info_Cobro.IdCobro + "\n" + "Imprimir", param.NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                            }

                            LimpiarDatos();
                            
                        }
                        else
                            bolResult = false;


                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Get();
                        if (Bus.ModificarDB(Info_Cobro, Cl_Enumeradores.PantallaEjecucion.COBROS))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Cuenta por Cobrar ", Info_Cobro.IdCobro);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtIdCuenta.Text = Info_Cobro.IdCobro.ToString();
                            if (Info_Cobro.cr_Codigo == "")
                            {
                                txtCodCuenta.Text = "CXC" + Info_Cobro.IdCobro;
                                txtRecibo.Text = Info_Cobro.cr_recibo.ToString();
                            }
                            cargarGridContable();

                            LimpiarDatos();
                        }else
                            bolResult = false;
                        
                        break;
                    default:
                        break;
                }

                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblAnulado.Visible == true)
                {
                    MessageBox.Show("El cobro ya se encuentra anulado", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                ba_Cbte_Ban_Info infobnaco = new ba_Cbte_Ban_Info();
                if (Bus.Valida_cobro_x_deposito(Info_Cobro,ref  infobnaco))
                {
                    MessageBox.Show("El cobro tiene depositos aplicados y no se puede anular.", param.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (MessageBox.Show("Se procederá a liberar los comprobantes aplicados a este cobro, ¿Está seguro que desea anular el cobro #" + Info_Cobro.IdCobro + "?", param.NombreEmpresa, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                frm.ShowDialog();
                MensajeError = frm.motivoAnulacion;
                Info_Cobro.MotiAnula = MensajeError;

                if (Bus.AnularDB(Info_Cobro))
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    lblAnulado.Visible = true;
                    cargarGridContable();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmcxc_CobrosGenerales_Mant_event_FrmClose(object sender, FormClosingEventArgs e)
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
        
        public void CargarGrillaXCliente()
        {
            try
            {
                bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(Bus.NotasCreditoConFacturaXCobrar(param.IdEmpresa, ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal, ucFa_ClienteCmb1.get_ClienteInfo().IdCliente));
                
                if (bList.Count() > 0)
                {
                    foreach (var item in bList)
                    {
                        item.TotalxCobrado = 0;
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.Saldo > 0 && q.Estado == "A").ToList());
                    }
                    else
                    {
                        List<cxc_cobro_Det_Info> LstdetCobro = new List<cxc_cobro_Det_Info>();
                        cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();
                        LstdetCobro = BusDet_cobro.Get_List_Cobro_detalle(param.IdEmpresa, Info_Cobro.IdSucursal, Info_Cobro.IdCobro);
                        List<vwcxc_cartera_x_cobrar_Info> detalle = new List<vwcxc_cartera_x_cobrar_Info>();
                        foreach (cxc_cobro_Det_Info item in LstdetCobro)
                        {
                            vwcxc_cartera_x_cobrar_Info inf = new vwcxc_cartera_x_cobrar_Info();
                            inf = bList.FirstOrDefault(q => q.IdCbteVta == item.IdCbte_vta_nota);
                            inf.TotalxCobrado = item.dc_ValorPago;
                            inf.Check = true;
                            inf.SaldoAUX = inf.SaldoAUX + item.dc_ValorPago;
                            detalle.Add(inf);
                        }
                        if (_Accion == Cl_Enumeradores.eTipo_action.actualizar && detalle.Count == 0)
                            bList =new BindingList<vwcxc_cartera_x_cobrar_Info>(bList.Where(q => q.Saldo > 0).ToList());
                        else
                            bList = new BindingList<vwcxc_cartera_x_cobrar_Info>(detalle);
                    }
                    foreach (var item in bList)
                    {
                        item.Ico = (Bitmap)imageList1.Images[0];
                    }
                    
                    gridControlCobro.DataSource = bList;
                }
                             
           }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       
        public List<fa_TipoNota_Info> TipoNota(string tipon)
        {
            try
            {
                var tipo = from q in ListTipoNota
                           where q.Tipo == tipon
                           select q;

                return tipo.ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<fa_TipoNota_Info>();
            }
        }
        
        public void CargarCombo()
        {
            try
            {
                ListTipoNota = BusTipoNota.Get_List_TipoNota(param.IdEmpresa);
                ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
                this.cmbBancoCta.DataSource = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.cmbBancoCta.DisplayMember = "ba_descripcion";
                this.cmbBancoCta.ValueMember = "IdBanco";

                list_cobro_tipo_info = (from q in BustipoCxC.Get_List_Cobro_Tipo()
                                        orderby q.tc_Orden ascending
                                        select q).ToList();

                cmbTipoCobro.DataSource = list_cobro_tipo_info;
                cmbTipoCobro.DisplayMember = "tc_descripcion";
                cmbTipoCobro.ValueMember = "IdCobro_tipo";



                cmbTipoNC.DataSource = TipoNota("C");
                cmbTipoNC.DisplayMember = "no_Descripcion";
                cmbTipoNC.ValueMember = "IdTipoNota";


                cmbBancos.Properties.DataSource = BusBanco.Get_List_Banco();
                cmbBancos.Properties.DisplayMember = "ba_descripcion";
                cmbBancos.Properties.ValueMember = "IdBanco";

                cmbTarjetas.DataSource = BusTarje.Get_List_tarjeta();
                cmbTarjetas.DisplayMember = "tr_Descripcion";
                cmbTarjetas.ValueMember = "IdTarjeta";

                ListCaja=  busCaja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                cmbCaja.Properties.DataSource = ListCaja;
                    
                cxc_parametro_Bus busParam = new cxc_parametro_Bus();
                cxc_parametro_Info infoparam = new cxc_parametro_Info();

                infoparam = busParam.Get_Info_parametro(param.IdEmpresa);
                if (infoparam != null)
                    cmbCaja.EditValue = infoparam.pa_IdCaja_x_Default;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void mnu_salir_Click(object sender, EventArgs e)
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
       
        private void frmcxc_CuentasxCobrar_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaIngreso.Value = DateTime.Now;
                cmbCaja.EditValue = cxcParametroBus.Get_Info_parametro(param.IdEmpresa).pa_IdCaja_x_cobros_x_CXC;
                bList = new BindingList<vwcxc_cartera_x_cobrar_Info>();
                gridControlCobro.DataSource = bList;
                CargarCombo();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        cmbTipoCobro_SelectionChangeCommitted(sender, e);
                        ucGe_Menu.Enabled_btnImprimirSoporte = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = ucGe_Menu.Enabled_bntLimpiar = ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        Set();
                        CargarGrillaXCliente(); 
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Sucursal_combo1.Enabled=false;
                        ucFa_ClienteCmb1.Enabled=false;
                        cmbCaja.Enabled = false;
                        txeValor.Enabled = false;
                        txtIdCuenta.Enabled = false;


                        Set();
                        CargarGrillaXCliente();                             
                        panel2.Enabled = true;
                        ucGe_Menu.Enabled_bntAnular = ucGe_Menu.Enabled_bntLimpiar  = false;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        if (lblAnulado.Visible == true)
                            ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = ucGe_Menu.Enabled_bntLimpiar = ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        CargarGrillaXCliente();
                        ucGe_Menu.Visible_btnGuardar = ucGe_Menu.Visible_bntGuardar_y_Salir = ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        break;
                    default:
                        break;
                }
                if (Info_Cobro.cr_estado == "I")
                {
                    cxc_cobro_x_ct_cbtecble_Bus busComp = new cxc_cobro_x_ct_cbtecble_Bus();
                    var TI = busComp.Get_List_cobro_x_ct_cbtecble_x_Reverso(param.IdEmpresa, Info_Cobro.IdSucursal, Info_Cobro.IdCobro);
                    lblAnulado.Visible = true; lblCbt_TipoAnulacion.Visible = true;
                    if (TI != null)
                        lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + TI.ct_IdCbteCble + " Tipo Cbt.Cble de Anu.: " + TI.ct_IdTipoCbte;
                    else lblCbt_TipoAnulacion.Visible = false;
                }                
                fa_parametro_Bus busParamFac = new fa_parametro_Bus();
                fa_parametro_info Parm = busParamFac.Get_Info_parametro(param.IdEmpresa);
                if (Parm == null || String.IsNullOrEmpty(Parm.IdCtaCble_x_anticipo_cliente) && _Accion != Cl_Enumeradores.eTipo_action.consultar)
                {
                    MessageBox.Show("Por favor, verifique que la Cta Cble de Anticipo este correctamente parametrizada.");
                    _Accion = Cl_Enumeradores.eTipo_action.consultar; frmcxc_CuentasxCobrar_Mant_Load(sender, e);
                    
                  
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Get() 
        {
            try
            {
                Info_Cobro = new cxc_cobro_Info();
                Info_Cobro.cr_propietarioCta = "";
                Info_Cobro.IdEmpresa = param.IdEmpresa;
                Info_Cobro.IdCobro = Convert.ToDecimal((txtIdCuenta.Text == "") ? "0" : txtIdCuenta.Text);
                Info_Cobro.cr_Codigo = (txtCodCuenta.Text == "") ? "" : txtCodCuenta.Text;
                Info_Cobro.cr_recibo = Convert.ToDecimal((txtRecibo.Text == "") ? "0" : txtRecibo.Text);
                Info_Cobro.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                Info_Cobro.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                Info_Cobro.cr_fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());

                Info_Cobro.cr_fechaCobro = Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString());
                Info_Cobro.cr_fechaDocu = (DateTime)dtpFechaIngreso.Value;
                Info_Cobro.IdCliente = ucFa_ClienteCmb1.get_ClienteInfo().IdCliente;
                Info_Cobro.IdCobro_tipo = (cmbTipoCobro.SelectedValue == null) ? "" : cmbTipoCobro.SelectedValue.ToString();
                Info_Cobro.cr_TotalCobro = Math.Round(Convert.ToDouble(txeValor.EditValue), 2);
                Info_Cobro.IdTipoNotaCredito = null;
                Info_Cobro.IdBanco = null;
                Info_Cobro.cr_cuenta = "";
                Info_Cobro.cr_Tarjeta = "";
                Info_Cobro.cr_NumDocumento = "";
                

                cxc_cobro_tipo_Info tipo = (cxc_cobro_tipo_Info)cmbTipoCobro.SelectedItem;

                switch (tipo.IdMotivo_tipo_cobro)
                {
                    case "EFEC":
                        Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        break;
                    case "CHEQ":
                        Info_Cobro.cr_Banco =  cmbBancos.Text;
                        Info_Cobro.cr_cuenta = txtNumCuenta.Text.ToString();
                        Info_Cobro.cr_NumDocumento = txtNum_documento.Text.ToString();
                        break;
                    case "DEPO":
                         Info_Cobro.IdBanco = Convert.ToInt32(cmbBancoCta.SelectedValue);
                         Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        break;
                    case "NTCR":
                        Info_Cobro.IdTipoNotaCredito = Convert.ToInt32((cmbTipoNC.SelectedValue == null) ? 0 : cmbTipoNC.SelectedValue);
                        Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        break;
                    case "NTDB":
                        Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        Info_Cobro.IdTipoNotaCredito = Convert.ToInt32((cmbTipoNC.SelectedValue == null) ? 0 : cmbTipoNC.SelectedValue);
                        break;
                    case "RET":
                        Info_Cobro.cr_NumDocumento = txtNum_documento.Text.ToString();
                        Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        break;
                    case "TARJ":
                        Info_Cobro.cr_Tarjeta = cmbTarjetas.Text;
                        Info_Cobro.cr_fechaCobro = Info_Cobro.cr_fechaDocu;
                        break;
                    default:
                        break;
                }


                Info_Cobro.cr_observacion = txtObservacion.Text;
                Info_Cobro.nom_pc = param.nom_pc;
                Info_Cobro.ip = param.ip;
                Info_Cobro.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                Info_Cobro.IdUsuario = param.IdUsuario;

                Info_Cobro.ListaCobro = new List<cxc_cobro_Det_Info>();
                Info_Cobro.ListaCobro = getDetalle();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public void Set()
        {
            try
            {
                cmbTipoCobro.SelectedValue = Info_Cobro.IdCobro_tipo;
                cmbTipoCobro_SelectionChangeCommitted(new object(), new EventArgs());
                cmbCaja.EditValue = Info_Cobro.IdCaja;
                txtIdCuenta.Text = Info_Cobro.IdCobro.ToString();
                txtCodCuenta.Text = Info_Cobro.cr_Codigo;
                txtRecibo.Text = Info_Cobro.cr_recibo.ToString();
                txtCodCuenta.Text = Info_Cobro.cr_Codigo;
                ucGe_Sucursal_combo1.set_SucursalInfo(Info_Cobro.IdSucursal);
                dtpFecha.Value = Info_Cobro.cr_fecha;
                dtpFechaCobro.Value = Info_Cobro.cr_fechaCobro;
                dtpFechaIngreso.Value = Info_Cobro.cr_fechaDocu;
                ucFa_ClienteCmb1.set_ClienteInfo(Convert.ToInt32(Info_Cobro.IdCliente));
                txtNum_documento.Text = Info_Cobro.cr_NumDocumento;
                cmbTipoNC.SelectedValue = (Info_Cobro.IdTipoNotaCredito == null) ? 0 : Info_Cobro.IdTipoNotaCredito;
                txeValor.EditValue = Convert.ToDouble(Info_Cobro.cr_TotalCobro);
                cmbBancoCta.SelectedValue = Convert.ToInt32(Info_Cobro.IdBanco);
                cmbBancos.EditValue = Info_Cobro.IdBanco;
                txtNumCuenta.Text = Info_Cobro.cr_cuenta;
                cmbTarjetas.Text = Info_Cobro.cr_Tarjeta;
                txtNumTarje.Text = Info_Cobro.cr_NumDocumento;
                txtObservacion.Text = Info_Cobro.cr_observacion;
                txtRecibo.Text = Info_Cobro.cr_recibo.ToString();

                cargarGridContable();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getNotaDC()
        {
            try
            {
                InfoCxCPara = BusCxCPara.Get_Info_parametro(param.IdEmpresa);


                NDCInfo = new fa_notaCreDeb_Info();
                NDCInfo.CodNota = "";

                NDCInfo.IdEmpresa = param.IdEmpresa;
                NDCInfo.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                NDCInfo.IdBodega = 1;
                NDCInfo.IdCliente = ucFa_ClienteCmb1.get_ClienteInfo().IdCliente;
                NDCInfo.IdVendedor = 0;
                NDCInfo.ip = param.ip;
                NDCInfo.nom_pc = param.nom_pc;
                NDCInfo.NumNota_Impresa = "";
                NDCInfo.NaturalezaNota = "INT";
                NDCInfo.no_dev_venta = "";
                NDCInfo.CreDeb = (cmbTipoCobro.SelectedValue=="NTCR")?"C":"D";
                NDCInfo.no_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_fecha_venc = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_dev_venta = "";
                NDCInfo.IdTipoNota = Convert.ToInt32(cmbTipoNC.SelectedValue);
                NDCInfo.sc_observacion = cmbTipoCobro.SelectedValue.ToString() + "  " + "Cobro " + Info_Cobro.IdCobro.ToString() + " ==> " + txtObservacion.Text;
                NDCInfo.sc_usuario = param.IdUsuario;
                NDCInfo.IdUsuarioUltAnu = "";
                NDCInfo.Estado = "A";
                NDCInfo.IdDevolucion = 0;
                NDCInfo.nom_pc = param.nom_pc;
                NDCInfo.ip = param.ip;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void getNotaDCDetalle()
        {
            try
            {

                cxc_Parametros_x_cheqProtesto_Info Info_Param = InfoCxCPara.LstParamProtesto.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa
                  && v.pa_IdSucursal_x_default_x_cheqProtes == ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal);



                List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>();
                fa_notaCreDeb_det_Info ListaNDCInfo = new fa_notaCreDeb_det_Info();
                ListaNDCInfo.IdEmpresa = param.IdEmpresa;
                ListaNDCInfo.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                ListaNDCInfo.IdBodega = 1;
                ListaNDCInfo.IdNota = 0;
                ListaNDCInfo.Secuencia = 1;
                ListaNDCInfo.IdProducto = Convert.ToDecimal(Info_Param.pa_IdProducto_x_NC_x_Cobro);
                ListaNDCInfo.sc_cantidad = 1;
                ListaNDCInfo.sc_Precio = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_descUni = 0;
                ListaNDCInfo.sc_PordescUni = 0;
                ListaNDCInfo.sc_precioFinal = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_subtotal = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_iva = 0;
                ListaNDCInfo.sc_total = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_costo = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_estado ="A";
                ListaNDCInfo.sc_observacion = "";

                ListaNDC.Add(ListaNDCInfo);
                NDCInfo.ListaDetalles = ListaNDC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        public List<cxc_cobro_Det_Info> getDetalle()
        {
            try
            {
              List<vwcxc_cartera_x_cobrar_Info> LISTA = new List<vwcxc_cartera_x_cobrar_Info>();
              list_det_cobro_Info = new List<cxc_cobro_Det_Info>();

                var s = from q in bList where q.Check == true select q;

                foreach (var item in s)
                {
                    cxc_cobro_Det_Info info = new cxc_cobro_Det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                    info.IdBodega_Cbte = item.IdBodega;
                    info.IdCbte_vta_nota = item.IdCbteVta;
                    info.dc_TipoDocumento = item.TipoDoc;
                    info.dc_ValorPago = Math.Round(item.TotalxCobrado, 2);
                    info.estado = "A";
                    info.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    info.IdUsuario = param.IdUsuario;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;

                    list_det_cobro_Info.Add(info);
                }
                return list_det_cobro_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cxc_cobro_Det_Info>();
            }
        }
    
        public Boolean validar()
        {
            try
            {
                
                var s = from q in bList where q.Check == true select q;

                if (s.Count() == 0)
                {
                    if (!(MessageBox.Show("¿Desea Realizar un Cobro sin facturas?", "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        MessageBox.Show("Antes de continuar seleccione Cobros"
                              , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                }
                else
                {
                    double suma = s.Sum(q => q.TotalxCobrado);
                    double valor_aplicar = txeValor.EditValue == null ? 0 : Convert.ToDouble(txeValor.EditValue);

                    if (Math.Round(valor_aplicar,2) > Math.Round(suma,2))
                    {
                        if (!(MessageBox.Show("El valor a aplicar es mayor a los cobros seleccionados. ¿Desea continuar? \nValor a aplicar: " + valor_aplicar.ToString() + "\nValor aplicado: " + suma.ToString(), "¿?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            return true;
                        }    
                    }
                    
                }
                if (cmbCaja.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Caja"
                          ,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCaja.Focus();
                    return true;
                }

                caj_Caja_Info caja = ListCaja.First(q => q.IdCaja == Convert.ToInt32(cmbCaja.EditValue));
                if (String.IsNullOrEmpty(caja.IdCtaCble))
                {
                    MessageBox.Show("La Caja seleccionada no tiene parametrizada la Cta Cble para contabilizar el registro...\r ",
                        param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCaja.Focus();
                    return true;
                }

                if (txtObservacion.Text == "" || txtObservacion.Text == null)
                {
                    MessageBox.Show("Ingrese la Observacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservacion.Focus();
                    return true;
                }

                cxc_cobro_tipo_Info info_tipo_cobro = new cxc_cobro_tipo_Info();

                if (cmbTipoCobro != null)
                {
                    info_tipo_cobro = (cxc_cobro_tipo_Info)cmbTipoCobro.SelectedItem;
                }

                if (info_tipo_cobro.IdCobro_tipo == "NTCR" || info_tipo_cobro.IdCobro_tipo == "NTDB")
                {
                    MessageBox.Show("Los cobros por notas de credito o debito deben ser realizados por la pantalla de Nota Credito y Debito "
                         , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                if (info_tipo_cobro.IdCobro_tipo == "CHEQ" )
                {
                     if (txtNum_documento.Text == "" || txtNum_documento.Text == null)
                     {
                         MessageBox.Show("Ingrese el Numero de Cheque", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         txtNum_documento.Focus();
                         return true;
                     }

                    if (txtNumCuenta.Text == "" || txtNumCuenta.Text == null)
                    {
                        MessageBox.Show("Ingrese el Numero de Cuenta Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumCuenta.Focus();
                        return true;
                    }

                    if (cmbBancos.EditValue == null)
                    {
                        MessageBox.Show("Seleccione el banco ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbBancos.Focus();
                        return true;
                    }
                }


                if (info_tipo_cobro.IdCobro_tipo == "TARJ")
                {
                    if (txtNumTarje.Text == "" || txtNumTarje.Text == null)
                    {
                        MessageBox.Show("Ingrese el Numero de Tarjeta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNumTarje.Focus();
                        return true;
                    }

                    if (cmbTarjetas.SelectedValue == null)
                    {
                        MessageBox.Show("Seleccione el tipo de tarjeta ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbBancos.Focus();
                        return true;
                    }
                }

                foreach (var item in s)
                {
                    if (item.TotalxCobrado==0)
                    {
                        MessageBox.Show("El valor a aplicar no puede ser 0, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtpFecha.Value)))
                    return true;
                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtpFechaIngreso.Value)))
                    return true;
                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtpFechaCobro.Value)))
                    return true;

                return false;
              }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
        
        public void Sumar()
        {
            try
            {
                vwcxc_cartera_x_cobrar_Info row = new vwcxc_cartera_x_cobrar_Info();
                row = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetRow(gridViewCobros.FocusedRowHandle);

                if (row.Check)
                {

                    if (Math.Round(Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)),2) < Math.Round(Convert.ToDouble(txeSaldoPendiente.EditValue),2))
                    {

                        if (Convert.ToDecimal(gridViewCobros.GetFocusedRowCellValue(colSaldo)) > 0)
                        {
                            if ((double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado) == 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, gridViewCobros.GetFocusedRowCellValue(colSaldo));
                            }
                        }
                        if (Convert.ToDouble(txeSaldoPendiente.EditValue) < Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)))
                        {
                        }
                        
                    }
                    else
                    {
                        if (Math.Round(Convert.ToDouble(txeSaldoPendiente.EditValue),2) < Math.Round(Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)),2))
                        {
                        }
                        else
                        {
                            gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, Convert.ToDouble(txeSaldoPendiente.EditValue));
                            ///resta check true
                            //gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(colSaldo) - (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                        }
                        txeSaldoPendiente.EditValue = 0;
                        //ojooo
                    }
                }
                //resta check
                double TotalxCobrado = (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado);
                if (TotalxCobrado == 0)
                {
                    gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(saldoAUX) - (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xyz()
        {
            try
            {
                if (Convert.ToDouble(txeValor.EditValue) == 0){return;}
                double sum = 0;
                
         
                
                
                foreach(var item in bList)
                {
                    item.TotalxCobrado = (item.SaldoAUX<item.TotalxCobrado)?0:item.TotalxCobrado;
                    item.Saldo = item.SaldoAUX-item.TotalxCobrado;
                }

                gridControlCobro.DataSource = bList;

                var s = from x in bList
                        where x.Check == true
                        select x;
                List<vwcxc_cartera_x_cobrar_Info> LstChek = new List<vwcxc_cartera_x_cobrar_Info>();
                        
                foreach(var item in s)
                {
                    sum += Math.Round((double)item.TotalxCobrado,2);
                }

                
                txeSaldoPendiente.EditValue = Math.Round(Math.Round(Convert.ToDouble(txeValor.EditValue),2) - Math.Round(sum,2),2);
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Calcular(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) 
        {
            try
            {
                double sum = 0;

                List<vwcxc_cartera_x_cobrar_Info> asd = new List<vwcxc_cartera_x_cobrar_Info>(bList);
                List<vwcxc_cartera_x_cobrar_Info> LstChek = new List<vwcxc_cartera_x_cobrar_Info>();
                if (e.Column.FieldName == "TotalxCobrado")
                {

                    foreach (vwcxc_cartera_x_cobrar_Info item in asd)
                    {
                        if (item.Check)
                        {
                            LstChek.Add(item);
                        }
                    }
                }

                foreach (var item in LstChek)
                {
                    sum = sum + (double)item.TotalxCobrado;
                }

                txeSaldoPendiente.EditValue = Convert.ToDouble(txeValor.EditValue) - sum;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmcxc_CobrosGenerales_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmcxc_CobrosGenerales_Mant_event_FrmClose(sender, e);
                event_FrmClose(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void dtpFecha_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validarFechas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dtpFechaIngreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validarFechas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dtpFechaCobro_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validarFechas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void validarFechas(){
            try
            {
                
                if (dtpFechaCobro.Value < (DateTime)dtpFechaIngreso.Value)
                {
                    dtpFechaCobro.Value = (DateTime)dtpFechaIngreso.Value;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CargarGrillaXCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void cargarGridContable()
        {
            try
            {
                cxc_cobro_x_ct_cbtecble_Info InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                cxc_cobro_x_ct_cbtecble_Bus BusCxCxCt = new cxc_cobro_x_ct_cbtecble_Bus();
                InfoCxCxCt = new cxc_cobro_x_ct_cbtecble_Info();
                InfoCxCxCt = BusCxCxCt.Get_Info_cobro_x_ct_cbtecble(param.IdEmpresa, Convert.ToInt32(ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal), Convert.ToDecimal(txtIdCuenta.Text));
                UC_Cbte_Contable.setInfo(InfoCxCxCt.ct_IdEmpresa, InfoCxCxCt.ct_IdTipoCbte, InfoCxCxCt.ct_IdCbteCble);          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewCobros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column == null) return;
                e.HitInfo.Column.FieldName = gridViewCobros.FocusedColumn.FieldName;

                vwcxc_cartera_x_cobrar_Info row1 = new vwcxc_cartera_x_cobrar_Info();
                row1 = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetRow(e.RowHandle);
                if (row1!=null)
                {
                    if (e.HitInfo.Column.FieldName == "Check")
                    {
                        if ((Boolean)gridViewCobros.GetFocusedRowCellValue(colCheck))
                        {

                            gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                            gridViewCobros.SetFocusedRowCellValue(colSaldo, gridViewCobros.GetFocusedRowCellValue(saldoAUX));
                            if ((Boolean)gridViewCobros.GetFocusedRowCellValue(colCheck) == false)
                            {
                                var asd = gridViewCobros.GetRow(gridViewCobros.FocusedRowHandle);
                            }
                            //suma check false
                            gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado) + (double)gridViewCobros.GetFocusedRowCellValue(saldoAUX));

                            if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)) == 0 || Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)) > Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(saldoAUX)))
                            {
                                gridViewCobros.SetFocusedRowCellValue(colSaldo, gridViewCobros.GetFocusedRowCellValue(saldoAUX));
                            }

                            gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, 0);


                            String sub_cadena = cadena;
                            sub_cadena = sub_cadena.Replace(row1.vt_NunDocumento + "/", "");
                            cadena = sub_cadena.Replace(row1.vt_NunDocumento + "/", "");

                            txtObservacion.Text = sub_cadena;

                            if (txtObservacion.Text == "Canc./: ")
                            {
                                txtObservacion.Text = "";

                            }


                            return;
                        }
                        else
                        {
                            if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotal)) != 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, true);
                            }
                            if (Math.Round(Convert.ToDouble(txeSaldoPendiente.EditValue),2) == 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " valor de cobro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txeValor.Focus();
                            }
                            else
                            {
                                cadena = cadena + row1.vt_NunDocumento + "/";
                                txtObservacion.Text = cadena;
                            }
                            if ((double)gridViewCobros.GetFocusedRowCellValue(colSaldo) < 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                            }

                            

                        }



                    }
                    else if (e.HitInfo.Column.FieldName == "Ico")
                    {
                        if (cmbCaja.EditValue == null) { MessageBox.Show("Por favor, Seleccione la Caja."); }
                        else
                        {
                            frmCxc_CobrosRetenciones frm = new frmCxc_CobrosRetenciones();
                            vwcxc_cartera_x_cobrar_Info red = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetFocusedRow();
                            fa_factura_Info Infofac = new fa_factura_Info();
                            fa_factura_Bus busFac= new fa_factura_Bus();

                            fa_notaCreDeb_Info InfoNd = new fa_notaCreDeb_Info();
                            fa_notaCredDeb_Bus busNd = new fa_notaCredDeb_Bus();

                            frm.Accion = _Accion;
                            if (red.TipoDoc == "FACT")
                            {
                                Infofac = busFac.Get_Info_factura(red.IdEmpresa, red.IdSucursal, red.IdBodega, red.IdCbteVta);
                                frm.setInfo(Infofac, null, Convert.ToString(ucFa_ClienteCmb1.get_ClienteInfo().IdCliente), Convert.ToInt32(cmbCaja.EditValue),red.TipoDoc);
                            }
                            else
                            {
                                InfoNd = busNd.Get_Info_notaCreDeb_x_ND(red.IdEmpresa, red.IdSucursal, red.IdBodega, red.IdCbteVta);
                                frm.setInfo(null, InfoNd, Convert.ToString(ucFa_ClienteCmb1.get_ClienteInfo().IdCliente), Convert.ToInt32(cmbCaja.EditValue), red.TipoDoc);
                            }
                            frm.ShowDialog();
                            CargarGrillaXCliente();
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Sumar();
        }

        private void gridViewCobros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                vwcxc_cartera_x_cobrar_Info row1 = new vwcxc_cartera_x_cobrar_Info();
                row1 = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetRow(e.RowHandle);
                if (row1!=null)
                 {
                    if (e.Column.Name == "colTotalxCobrado" && Convert.ToDecimal(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)) > 0)
                        if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)) > Convert.ToDouble(txeSaldoPendiente.EditValue))
                        {
                            gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                            gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, 0);
                        }
                    xyz();    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewCobros_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {  
                if (Convert.ToDouble(txeSaldoPendiente.EditValue) == 0 || Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)) > Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)))
                {
                    gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, 0);
                }
                else
                {
                    if (Convert.ToString(gridViewCobros.GetFocusedRowCellValue(colTotal)) != "")
                    {
                        gridViewCobros.SetFocusedRowCellValue(colCheck, true);
                    }
                }

                var s = from x in bList
                        where x.Check == true
                        select x;
                xyz();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeValor_Validating(object sender, CancelEventArgs e)
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

        private void ucFa_ClienteCmb1_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txeSaldoPendiente.EditValue = txeValor.EditValue;
                CargarGrillaXCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txeValor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cadena = "Canc./: ";
                txtObservacion.Text = "";
                CargarGrillaXCliente();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoCobro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                cxc_cobro_tipo_Info tipo = (cxc_cobro_tipo_Info)cmbTipoCobro.SelectedItem;

                grbDatosBanco.Visible = false;
                pnlTipoNota.Visible = false;
                gpbDatosTarjeta.Visible = false;
                gbDatosDeposito.Visible = false;
                dtpFechaCobro.Visible = true;
                dtpFechaIngreso.Visible = true;

                lb_documento.Text = "";
                lb_documento.Visible = false;
                txtNum_documento.Visible = false;


                switch (tipo.IdMotivo_tipo_cobro)
                {
                    case "EFEC":
                        dtpFechaCobro.Visible = true;
                        break;
                    case "CHEQ":
                        grbDatosBanco.Visible = true;
                        lb_documento.Text = "Cheque#:";
                        lb_documento.Visible = true;
                        txtNum_documento.Visible = true;
                        break;
                    case "DEPO":
                        gbDatosDeposito.Visible = true;
                        break;
                    case "NTCR" :
                            pnlTipoNota.Visible = true;
                        break;
                    case "NTDB" :
                        pnlTipoNota.Visible = true;
                    break;
                    case "RET":
                        lb_documento.Text = "Retencion#:";
                        lb_documento.Visible = true;
                        txtNum_documento.Visible = true;
                        break;
                    case "TARJ":
                        gpbDatosTarjeta.Visible = true;
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

        private void btn_cargar_diario_Click(object sender, EventArgs e)
        {
            try
            {
                cargarGridContable();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpFecha.Value!=null)
                {
                    dtpFechaCobro.Value = dtpFecha.Value;
                    dtpFechaIngreso.Value = dtpFecha.Value;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        
    }
}
