using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Bancos;
using Core.Erp.Winform.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Contabilidad;
///Prog: Derek Mejia
///V 22 02 2014 12.18

//DEREK MEJIA 15/02/2014
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_cancelacion_Intercompany_Mant : Form
    {
        #region Declaración de variables
        private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        public cxc_cancelacion_Intercompany_Info SETINFO_ { get; set; }
        UCFa_Cliente_Facturacion ctrl_Cliente = new UCFa_Cliente_Facturacion();
        cxc_cancelacion_Intercompany_Info _Info = new cxc_cancelacion_Intercompany_Info();
        List<cxc_cancelacion_Intercompany_det_Info> _InfoDet = new List<cxc_cancelacion_Intercompany_det_Info>();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing();
        public event delegate_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing event_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing;
        //Derek Mejía 13/02/2014
        fa_Cliente_Bus FaClienteBus = new fa_Cliente_Bus();
        fa_Cliente_Info FaClienteInfo = new fa_Cliente_Info();
        //

        //Derek Mejía 24/02/2014
        List<tb_tarjeta_Info> Tarj = new List<tb_tarjeta_Info>();
        List<tb_banco_Info> Banc = new List<tb_banco_Info>();
        //

        //Derek Mejía 14/02/2014
        cxc_cancelacion_Intercompany_Bus CancInterBus = new cxc_cancelacion_Intercompany_Bus();
        cxc_cancelacion_Intercompany_Det_Bus CancInterDetBus = new cxc_cancelacion_Intercompany_Det_Bus();
        //
        //Derek Mejía 17/02/2014
        List<cxc_cancelacion_Intercompany_det_Info> CancInterDetInfoList = new List<cxc_cancelacion_Intercompany_det_Info>();
        //

        //Derek Mejía 17/02/2014
        cxc_cobro_Info _InfoCobro = new cxc_cobro_Info();
        //
        //Derek Mejía 22/02/2014
        List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info> vistaBLInfo = new List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info>();
        tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
        cxc_cobro_tipo_Bus BustipoCxC = new cxc_cobro_tipo_Bus();
        fa_TipoNota_Bus BusTipoNota = new fa_TipoNota_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_TipoNota_Info> ListTipoNota = new List<fa_TipoNota_Info>();
        tb_banco_Bus BusBanco = new tb_banco_Bus();
        tb_tarjeta_Bus BusTarje = new tb_tarjeta_Bus();
        cxc_cobro_Bus Bus = new cxc_cobro_Bus();
        List<cxc_cobro_Det_Info> G_ListadoDet_Cobros_Inter = new List<cxc_cobro_Det_Info>();
        public delegate void Delegate_FrmClose(object sender, FormClosingEventArgs e);
        public event Delegate_FrmClose event_FrmClose;
        UCCon_DiarioContable_Facturacion UCDiario = new UCCon_DiarioContable_Facturacion();
        caj_Caja_Bus busCaja = new caj_Caja_Bus();
        decimal d = 0;
        string msg = "";
        string MensajeError = "";
        #endregion
       
        public frmCxc_cancelacion_Intercompany_Mant()
        {
            try
            {
                 InitializeComponent();
                CargarCombo();
           
              //  ctrl_Cliente.Event_cmb_cliente_RowSelected += new Controles.UCFa_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(ctrl_Cliente_Event_cmb_cliente_RowSelected);
                event_FrmClose += new Delegate_FrmClose(frmCo_cxc_cancelacion_Intercompany_Mant_event_FrmClose);

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
                CargarGrillaXCliente();
                txeValor.EditValue = txeSaldoPendiente.EditValue = 0;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            try
            {
                event_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing();
                frmCo_cxc_cancelacion_Intercompany_Mant_event_FrmClose(sender, e);
                //event_FrmClose(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmCo_cxc_cancelacion_Intercompany_Mant_event_FrmClose(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
        }

        //UCFA_Cliente_Facturacion ctrl_Cliente = new UCFA_Cliente_Facturacion();
        //private Cl_Enumeradores.eTipo_action _Accion;

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

        //public frmcxc_CobrosGenerales_Mant()
        //{
        //    InitializeComponent();
        //    CargarCombo();
           
        //    ctrl_Cliente.Event_cmb_cliente_RowSelected += new Controles.UCFA_Cliente_Facturacion.Delegate_cmb_cliente_RowSelected(ctrl_Cliente_Event_cmb_cliente_RowSelected);
        //    event_FrmClose += new Delegate_FrmClose(frmcxc_CobrosGenerales_Mant_event_FrmClose);
        //}

        void frmcxc_CobrosGenerales_Mant_event_FrmClose(object sender, FormClosingEventArgs e)
        {
        }
       
        //void ctrl_Cliente_Event_cmb_cliente_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        //{
        //    try
        //    {
        //        CargarGrillaXCliente();
        //        txeValor.EditValue = txeSaldoPendiente.EditValue = 0;
        //    }
        //    catch(Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}
        
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
                return new List<fa_TipoNota_Info>();
            }
        }

        public void CargarCombo()
        {
            try
            {
                ListTipoNota = BusTipoNota.Get_List_TipoNota(param.IdEmpresa);
                cmbSucursal.DataSource = BusSuc.Get_List_Sucursal(param.IdEmpresa);
                cmbSucursal.DisplayMember = "Su_Descripcion";
                cmbSucursal.ValueMember = "IdSucursal";
                ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
                this.cmbBancoCta.DataSource = bancoB.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.cmbBancoCta.DisplayMember = "ba_descripcion";
                this.cmbBancoCta.ValueMember = "IdBanco";
                cmbTipoCobro.DataSource = (from q in BustipoCxC.Get_List_Cobro_Tipo()
                                           orderby q.tc_Orden ascending
                                           select q).ToList();
                cmbTipoCobro.DisplayMember = "tc_descripcion";
                cmbTipoCobro.ValueMember = "IdCobro_tipo";
                cmbTipoNC.DataSource = TipoNota("C");
                cmbTipoNC.DisplayMember = "no_Descripcion";
                cmbTipoNC.ValueMember = "IdTipoNota";

                //Derek Mejia 24/05/2014
                Banc = new List<tb_banco_Info>();
                Banc.Add(new tb_banco_Info());
                foreach (var item1 in BusBanco.Get_List_Banco())
                {Banc.Add(item1);}
                cmbBancos.DataSource = Banc;
                cmbBancos.DisplayMember = "ba_descripcion";
                cmbBancos.ValueMember = "IdBanco";
                
                Tarj = new List<tb_tarjeta_Info>();
                Tarj.Add(new tb_tarjeta_Info());
                foreach (var item in BusTarje.Get_List_tarjeta())
                {Tarj.Add(item);}
                //Tarj = BusTarje.ListaTarjetas();
                cmbTarjetas.DataSource = Tarj;
                cmbTarjetas.DisplayMember = "tr_Descripcion";
                cmbTarjetas.ValueMember = "IdTarjeta";
                //

                cmbCaja.Properties.DataSource = busCaja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                cxc_parametro_Bus busParam = new cxc_parametro_Bus();
                cxc_parametro_Info infoparam = new cxc_parametro_Info();

                infoparam = busParam.Get_Info_parametro(param.IdEmpresa);
                if (infoparam != null)
                    cmbCaja.EditValue = infoparam.pa_IdCaja_x_Default;

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
               this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        //private void frmcxc_CuentasxCobrar_Mant_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ctrl_Cliente.Dock = DockStyle.Fill;
        //        pnlCliente.Controls.Add(ctrl_Cliente);
        //        ctrl_Cliente.cmb_vendedor.Visible = false;
        //        switch(_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
                        


        //                cmbTipoCobro_SelectionChangeCommitted(sender,e);
        //                btnAnular.Enabled = false;
        //                break;
        //            case Cl_Enumeradores.eTipo_action.consultar:
        //                btnGuardar.Enabled = btnguardarYsalir.Enabled = btnAnular.Enabled = false;
        //                Set();
        //                obtenerDetalle();
                         
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                Set();
        //                obtenerDetalle();
        //                panel2.Enabled = false;
        //                btnAnular.Enabled = false;
        //                break;
        //            case Cl_Enumeradores.eTipo_action.borrar:
        //                Set();
        //                obtenerDetalle();
        //                btnGuardar.Enabled = btnguardarYsalir.Enabled = false;
        //                break;
        //            default:
        //                break;
        //        }
        //        if (_Info.cr_estado == "I") { lblAnulado.Visible = true; }
        //        cargarGridContable();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    }
        //public cxc_cobro_Info _Info = new cxc_cobro_Info();
        
        public void Get()
        {
            try
            {
                _InfoCobro.cr_propietarioCta = txtPropietario.Text;
                _InfoCobro.IdEmpresa = param.IdEmpresa;
                //Derek Mejia 24/02/2014
                //if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                //{ 
                //    decimal numero =0;
                //foreach (var item in CancInterDetBus.ConsultarDetalle(param.IdEmpresa, Convert.ToDecimal(SETINFO_.IdCancelacion)))
                //    {
                //        numero = Convert.ToDecimal(item.cbr_IdCobro);
                //        break;
                //    }
                //    _InfoCobro.IdCobro = numero;
                //}
                //else{_InfoCobro.IdCobro = 0;}  
                //
                _InfoCobro.IdCobro = 0;
                _InfoCobro.IdCobro_a_aplicar = null;
                _InfoCobro.cr_Codigo = (txtCodCuenta.Text == "") ? "" : txtCodCuenta.Text;
                _InfoCobro.cr_recibo = Convert.ToDecimal((txtRecibo.Text == "") ? "0" : txtRecibo.Text);
                _InfoCobro.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                _InfoCobro.IdSucursal = Convert.ToInt16((cmbSucursal.SelectedValue == null) ? 0 : cmbSucursal.SelectedValue);
                _InfoCobro.cr_fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                _InfoCobro.cr_fechaCobro = Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString());
                _InfoCobro.cr_fechaDocu = Convert.ToDateTime(dtpFechaIngreso.Value.ToShortDateString());
                _InfoCobro.IdCliente = Convert.ToInt32((ctrl_Cliente.cmb_cliente.EditValue == null) ? 0 : ctrl_Cliente.cmb_cliente.EditValue);
                _InfoCobro.IdCobro_tipo = (cmbTipoCobro.SelectedValue == null) ? "" : cmbTipoCobro.SelectedValue.ToString();
                _InfoCobro.IdTipoNotaCredito = Convert.ToInt32((cmbTipoNC.SelectedValue == null) ? 0 : cmbTipoNC.SelectedValue);
                _InfoCobro.cr_TotalCobro = Convert.ToDouble(txeValor.EditValue);
                _InfoCobro.cr_Banco = (cmbBancos.Text == "Core.Erp.Info.General.tb_banco_InfoCobro" || cmbBancos.Text == "") ? null : (cmbBancos.Text.ToString()).Trim();
                _InfoCobro.IdBanco = Convert.ToInt32(cmbBancoCta.SelectedValue);
                _InfoCobro.cr_cuenta = txtNumCuenta.Text.ToString();
                //_InfoCobro.cr_Tarjeta = (cmbTarjetas.Text == "Core.Erp.Info.General.tb_tarjeta_InfoCobro") ? " " : (cmbTarjetas.Text.ToString()).Trim();
                if (cmbTarjetas.SelectedItem != null)
                {
                    var tarjeta = (tb_tarjeta_Info)cmbTarjetas.SelectedItem;
                    _InfoCobro.cr_Tarjeta = (tarjeta.IdBanco != 0) ? Convert.ToString(tarjeta.tr_Descripcion) : null;
                }
                _InfoCobro.cr_NumDocumento = txtNumTarje.Text.ToString();
                _InfoCobro.cr_NumDocumento = txtNumCheque.Text.ToString();
                //_InfoCobro.cr_recibo = Convert.ToDecimal(txtRecibo.Text);
                _InfoCobro.nom_pc = param.nom_pc;
                _InfoCobro.ip = param.ip;
                _InfoCobro.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _InfoCobro.IdUsuario = param.IdUsuario;

                _InfoCobro.cr_observacion = "Cobro en " + _InfoCobro.IdCobro + "  Monto Total:" + _InfoCobro.cr_TotalCobro + txtObservacion.Text;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //public void Set()
        //{
        //    try
        //    {
        //        cmbTipoCobro.SelectedValue = SETINFO_.IdCobro_tipo;
        //        cmbTipoCobro_SelectionChangeCommitted(new object(), new EventArgs());
        //        txtPropietario.Text = SETINFO_.cr_propietarioCta;
        //        cmbCaja.EditValue = SETINFO_.IdCaja;
        //        txtIdCuenta.Text = SETINFO_.IdCobro.ToString();
        //        txtCodCuenta.Text = SETINFO_.cr_Codigo;
        //        txtRecibo.Text = SETINFO_.cr_recibo.ToString();
        //        txtCodCuenta.Text = SETINFO_.cr_Codigo;
        //        cmbSucursal.SelectedValue = SETINFO_.IdSucursal;
        //        dtpFecha.Value = SETINFO_.cr_fecha;
        //        dtpFechaCobro.Value = SETINFO_.cr_fechaCobro;
        //        dtpFechaIngreso.Value = SETINFO_.cr_fechaDocu;
        //        ctrl_Cliente.cmb_cliente.EditValue = SETINFO_.IdCliente;
        //        txtNumCheque.Text = SETINFO_.cr_NumDocumento;
        //        cmbTipoNC.SelectedValue = (SETINFO_.IdTipoNotaCredito == null) ? "" : SETINFO_.IdTipoNotaCredito;
        //        txtValor.Value = Convert.ToDecimal(SETINFO_.cr_TotalCobro);
        //        cmbBancoCta.SelectedValue = Convert.ToInt32(SETINFO_.IdBanco);
        //        cmbBancos.Text = SETINFO_.cr_Banco;
        //        txtNumCuenta.Text = SETINFO_.cr_cuenta;
        //        cmbTarjetas.Text = SETINFO_.cr_Tarjeta;
        //        txtNumTarje.Text = SETINFO_.cr_NumDocumento;
        //        txtObservacion.Text = SETINFO_.cr_observacion;
        //        txtRecibo.Text = SETINFO_.cr_recibo.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
            
            
        //}
        
        #region get notaDebitoCredito
        fa_notaCreDeb_Info NDCInfo = new fa_notaCreDeb_Info();
        List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>();
        fa_notaCredDeb_Bus BusBNotaDB = new fa_notaCredDeb_Bus();
        cxc_parametro_Info InfoCxCPara = new cxc_parametro_Info();
        cxc_parametro_Bus BusCxCPara = new cxc_parametro_Bus();

        private void getNotaDC()
        {
            try
            {
                InfoCxCPara = BusCxCPara.Get_Info_parametro(param.IdEmpresa);
                NDCInfo = new fa_notaCreDeb_Info();
                NDCInfo.CodNota = "";

                NDCInfo.IdEmpresa = param.IdEmpresa;
                NDCInfo.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                NDCInfo.IdBodega = 1;
                NDCInfo.IdCliente = Convert.ToInt32(ctrl_Cliente.cmb_cliente.EditValue);
                NDCInfo.IdVendedor = Convert.ToInt32(ctrl_Cliente.cmb_vendedor.EditValue);
                NDCInfo.ip = param.ip;
                NDCInfo.nom_pc = param.nom_pc;
                NDCInfo.NumNota_Impresa = "";
                NDCInfo.NaturalezaNota = "INT";
                NDCInfo.no_dev_venta = "";
                NDCInfo.CreDeb = (cmbTipoCobro.SelectedValue == "NTCR") ? "C" : "D";
                NDCInfo.no_fecha = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_fecha_venc = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                NDCInfo.no_dev_venta = "";

                NDCInfo.IdTipoNota = Convert.ToInt32(cmbTipoNC.SelectedValue);
                //NDCInfo.sc_observacion = cmbTipoCobro.SelectedValue.ToString() + "  " + "Cobro " + SETINFO_.IdCobro.ToString() + " ==> " + txtObservacion.Text;
                NDCInfo.sc_usuario = param.IdUsuario;

                NDCInfo.IdUsuarioUltAnu = "";

                //NDCInfo.IdUsuario = param.IdUsuario;
                NDCInfo.Estado = "A";
                NDCInfo.IdDevolucion = 0;//Convert.ToDecimal(txtidDev.Text);
                NDCInfo.nom_pc = param.nom_pc;
                NDCInfo.ip = param.ip;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void getNotaDCDetalle()
        {
            try
            {


                cxc_Parametros_x_cheqProtesto_Info Info_Param_x_Cheq_Prost = InfoCxCPara.LstParamProtesto.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa
                    && v.pa_IdSucursal_x_default_x_cheqProtes == Convert.ToInt32(cmbSucursal.SelectedValue));


                List<fa_notaCreDeb_det_Info> ListaNDC = new List<fa_notaCreDeb_det_Info>();
                
                fa_notaCreDeb_det_Info ListaNDCInfo = new fa_notaCreDeb_det_Info();
                ListaNDCInfo.IdEmpresa = param.IdEmpresa;
                ListaNDCInfo.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                ListaNDCInfo.IdBodega = 1;
                ListaNDCInfo.IdProducto = Convert.ToDecimal(Info_Param_x_Cheq_Prost.pa_IdProducto_x_NC_x_Cobro);
                ListaNDCInfo.pr_descripcion = "";
                ListaNDCInfo.sc_costo = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_estado = "A";
                ListaNDCInfo.sc_observacion = "Nota Debito por Cheque Protestado";
                ListaNDCInfo.sc_iva = 0;

                ListaNDCInfo.sc_descUni = 0;
                ListaNDCInfo.sc_PordescUni = 0;
                ListaNDCInfo.sc_cantidad = 1;
                ListaNDCInfo.sc_Precio = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_precioFinal = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_subtotal = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.sc_total = Convert.ToDouble(txeValor.EditValue);
                ListaNDCInfo.Secuencia = 1;
                ListaNDC.Add(ListaNDCInfo);
                NDCInfo.ListaDetalles = ListaNDC;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        #endregion
        
        public List<cxc_cobro_Det_Info> getDetalle()
        {
            try
            {
                List<vwcxc_cartera_x_cobrar_Info> LISTA = new List<vwcxc_cartera_x_cobrar_Info>();
                List<cxc_cobro_Det_Info> listacxcDET = new List<cxc_cobro_Det_Info>();
                var s = from q in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource where q.Check == true select q;
                foreach (var item in s)
                {
                    cxc_cobro_Det_Info info = new cxc_cobro_Det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                    info.dc_TipoDocumento = item.TipoDoc;
                    info.dc_ValorPago = item.TotalxCobrado;
                    info.estado = "A";
                    info.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    info.IdBodega_Cbte = item.IdBodega;
                    info.IdCbte_vta_nota = item.IdCbteVta;
                    info.IdCobro = _InfoCobro.IdCobro;
                    info.IdUsuario = param.IdUsuario;
                    info.ip = param.ip;
                    info.nom_pc = param.nom_pc;
                    listacxcDET.Add(info);
                }
                return listacxcDET;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<cxc_cobro_Det_Info>();
            }
        }

        public Boolean validar()
        {
            try
            {
                var s = from q in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource where q.Check == true select q;

                if(s.Count() == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione Cobros", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                if (cmbCaja.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Caja", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCaja.Focus();
                    return true;
                }

                if(grbDatosBanco.Visible==true){}
                return false;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return true;
            }
        }

        //Derek Mejía 14/02/2014

        public Boolean GETINFO() {
            try
            {
                _Info.cr_propietarioCta = txtPropietario.Text;
                _Info.IdEmpresa = param.IdEmpresa;
                //_Info.IdCobro = Convert.ToDecimal((txtIdCuenta.Text == "") ? "0" : txtIdCuenta.Text);
                _Info.IdCancelacion = (txtIdCuenta.Text==""||txtIdCuenta.Text==null)?CancInterBus.GetId(param.IdEmpresa):Convert.ToDecimal(txtIdCuenta.Text);                
                //_Info.cr_Codigo = (txtCodCuenta.Text == "") ? "" : txtCodCuenta.Text;
                //_Info.cr_recibo = Convert.ToDecimal((txtRecibo.Text == "") ? "0" : txtRecibo.Text);
                _Info.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                _Info.IdSucursal = Convert.ToInt16((cmbSucursal.SelectedValue == null) ? 0 : cmbSucursal.SelectedValue);
                _Info.cr_fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
                _Info.cr_fechaCobro = Convert.ToDateTime(dtpFechaCobro.Value.ToShortDateString());
                _Info.cr_fechaDocu = Convert.ToDateTime(dtpFechaIngreso.Value.ToShortDateString());
                _Info.IdCliente = Convert.ToInt32((ctrl_Cliente.cmb_cliente.EditValue == null) ? 0 : ctrl_Cliente.cmb_cliente.EditValue);
                _Info.IdCobro_tipo = (cmbTipoCobro.SelectedValue == null) ? "" : cmbTipoCobro.SelectedValue.ToString();
                _Info.IdTipoNotaCredito = (cmbTipoNC.SelectedValue == null) ? "" : cmbTipoNC.SelectedValue.ToString();
                _Info.cr_TotalCobro = Convert.ToDouble(txeValor.EditValue);
                _Info.cr_Banco = (cmbBancos.Text == "Core.Erp.Info.General.tb_banco_Info" || cmbBancos.Text == "") ? null : (cmbBancos.Text.ToString()).Trim();
                //_Info.IdBanco = Convert.ToInt32(cmbBancoCta.SelectedValue);
                _Info.cr_cuenta = txtNumCuenta.Text.ToString();
                _Info.cr_Tarjeta = (cmbTarjetas.Text == "Core.Erp.Info.General.tb_tarjeta_Info" || cmbTarjetas.Text=="") ? null : (cmbTarjetas.Text.ToString()).Trim();
                _Info.cr_NumDocumento = txtNumTarje.Text.ToString();
                _Info.cr_NumDocumento = txtNumCheque.Text.ToString();
                _Info.cr_observacion = txtObservacion.Text;
                _Info.Observacion = txtObservacion.Text;
                //_Info.cr_recibo = Convert.ToDecimal(txtRecibo.Text);
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;
                _Info.Fecha_Transac = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _Info.IdUsuario = param.IdUsuario;
                _Info.cr_estado = (_Info.cr_estado == "" || _Info.cr_estado==null) ? "A" : _Info.cr_estado;
                _Info.Fecha_Transac = null;
                _Info.IdUsuario = param.IdUsuario;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                _Info.Fecha_UltMod = DateTime.Now.Date;
                _Info.IdUsuarioUltAnu = null;
                _Info.Fecha_UltAnu = null;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;
                _Info.GeneraDeps = "N";
                _Info.IdCaja = Convert.ToInt32(cmbCaja.EditValue);                
                _Info.IdTipoNotaCredito = (cmbTipoNC.SelectedValue == null) ? "" : cmbTipoNC.SelectedValue.ToString();
                return true;

                //_Info.ListaCobro = new List<cxc_cobro_Det_Info>();
                //_Info.ListaCobro = getDetalle();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public Boolean GETINFODET() {
            try
            {
                
                List<vwcxc_cartera_x_cobrar_Info> LISTA = new List<vwcxc_cartera_x_cobrar_Info>();
                _InfoDet = new List<cxc_cancelacion_Intercompany_det_Info>();
                var s = from q in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource where q.Check == true select q;
                int secuencia = 1;
                foreach (var item in s)
                {
                    cxc_cancelacion_Intercompany_det_Info info = new cxc_cancelacion_Intercompany_det_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdCancelacion = _Info.IdCancelacion;
                    info.Secuencia = secuencia++;
                    info.cbteVta_IdEmpresa = item.IdEmpresa;
                    info.cbteVta_IdSucursal = item.IdSucursal;
                    info.cbteVta_IdBodega = item.IdBodega;
                    info.cbteVta_TipoDoc = item.vt_tipoDoc;
                    info.cbteVta_IdCbteVta =item.IdComprobante;
                    info.cbr_IdEmpresa = null;
                    info.cbr_IdSucursal = null;
                    info.cbr_IdCobro = null;
                    info.Valor_Aplicado = item.TotalxCobrado;


                    //info.IdSucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                    //info.dc_TipoDocumento = item.TipoDoc;
                    //info.dc_ValorPago = item.TotalxCobrado;
                    //info.estado = "A";
                    //info.Fecha_UltMod = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    //info.IdBodega_Cbte = item.IdBodega;
                    //info.IdCbte_vta_nota = item.IdCbteVta;
                    //info.IdCobro = SETINFO_.IdCobro;
                    //info.IdUsuario = param.IdUsuario;
                    //info.ip = param.ip;
                    //info.nom_pc = param.nom_pc;
                    _InfoDet.Add(info);

                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }

        public Boolean Guardar() {
            try
            {
                if (GETINFO()==false){return false;}
                if (GETINFODET() == false) { return false; }
                if (CancInterBus.GuardarDB(_Info)==true)
                {
                    if (CancInterDetBus.GuardarDB(_InfoDet) == true) { }
                    else { return false;}
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }            
        }

        //

        //Derek Mejía 17/02/2014
        public void Set()
        {
            try
            {
                cmbTipoCobro.SelectedValue = SETINFO_.IdCobro_tipo;
                cmbTipoCobro_SelectionChangeCommitted(new object(), new EventArgs());
                txtPropietario.Text = SETINFO_.cr_propietarioCta;
                cmbCaja.EditValue = SETINFO_.IdCaja;
                txtIdCuenta.Text = SETINFO_.IdCancelacion.ToString();                
                //txtRecibo.Text = SETINFO_.cr_recibo.ToString();
                //txtCodCuenta.Text = SETINFO_.cr_Codigo;
                cmbSucursal.SelectedValue = SETINFO_.IdSucursal;
                dtpFecha.Value = Convert.ToDateTime(SETINFO_.cr_fecha);
                dtpFechaCobro.Value = Convert.ToDateTime(SETINFO_.cr_fechaCobro);
                dtpFechaIngreso.Value = Convert.ToDateTime(SETINFO_.cr_fechaDocu);
                ctrl_Cliente.cmb_cliente.EditValue = SETINFO_.IdCliente;
                txtNumCheque.Text = SETINFO_.cr_NumDocumento;
                cmbTipoNC.SelectedValue = (SETINFO_.IdTipoNotaCredito == null) ? "" : SETINFO_.IdTipoNotaCredito;
                txeValor.EditValue = Convert.ToDouble(SETINFO_.cr_TotalCobro);
                //cmbBancoCta.SelectedValue = Convert.ToInt32(SETINFO_.IdBanco);
                cmbBancos.Text = SETINFO_.cr_Banco;
                txtNumCuenta.Text = SETINFO_.cr_cuenta;
                cmbTarjetas.Text = SETINFO_.cr_Tarjeta;
                txtNumTarje.Text = SETINFO_.cr_NumDocumento;
                txtObservacion.Text = SETINFO_.cr_observacion;
                //txtRecibo.Text = SETINFO_.cr_recibo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }                        
        }

        //Derek Mejía 17/02/2014
        public void CargarGrillaXCliente()
        {
            try
            {
                List<vwcxc_cartera_x_cobrar_Info> Lst = new List<vwcxc_cartera_x_cobrar_Info>();
                //Lst = Bus.NotasCreditoConFacturaXCobrar(param.IdEmpresa, (int)cmbSucursal.SelectedValue, (decimal)ctrl_Cliente.cmb_cliente.EditValue);
                FaClienteInfo = FaClienteBus.Get_Info_Cliente(param.IdEmpresa, (decimal)ctrl_Cliente.cmb_cliente.EditValue);
                Lst = Bus.NotasCreditoConFacturaXCodigoCLi(FaClienteInfo.Codigo);
                Lst.ForEach(v => v.TotalxCobrado = 0);

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Lst = Lst.Where(q => q.Saldo > 0).ToList();
                }
                else
                {
                    CargarGrillaXIntercompanyDet(ref Lst);
                    //List<cxc_cobro_Det_Info> LstdetCobro = new List<cxc_cobro_Det_Info>();

                    //LstdetCobro = Bus.ObtenerDetalleCobro(param.IdEmpresa, SETINFO_.IdSucursal, SETINFO_.IdCobro);

                    //foreach (var item in LstdetCobro)
                    //{
                    //    (from q in Lst select q).ToList().ForEach(v => { if (v.IdCbteVta == item.IdCbte_vta_nota) { v.TotalxCobrado = item.dc_ValorPago; v.Check = true; v.SaldoAUX = v.SaldoAUX + item.dc_ValorPago; } });
                    //}
                    Lst = Lst.Where(v => v.Saldo != 0 && v.TotalxCobrado != 0).ToList();
                }
                //Lst.ForEach(var => var.Ico = (Bitmap)imageList1.Images[0]);
                gridControlCobro.DataSource = Lst;               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //Derek Mejía 17/02/2014
        public void CargarGrillaXIntercompanyDet(ref List<vwcxc_cartera_x_cobrar_Info> Lst)
        {
            try
            {
                CancInterDetInfoList = new List<cxc_cancelacion_Intercompany_det_Info>();
                CancInterDetInfoList = CancInterDetBus.Get_List_cancelacion_Intercompany_det(param.IdEmpresa, SETINFO_.IdCancelacion);
                foreach (var item in CancInterDetInfoList)
                {
                    foreach (var i in Lst)
                    {
                        if (i.IdComprobante == item.cbteVta_IdCbteVta)
                        {
                            //i.Saldo = 0;
                            i.TotalxCobrado = item.Valor_Aplicado;
                            i.Check = true;
                            //i.SaldoAUX = i.SaldoAUX + item.Valor_Aplicado;
                            break;
                        }
                    }
                }
                xyz();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return;
            }
        }

        public void obtenerDetalle()
        {
            try
            {
                CancInterDetInfoList = new List<cxc_cancelacion_Intercompany_det_Info>();
                CancInterDetInfoList = CancInterDetBus.Get_List_cancelacion_Intercompany_det(param.IdEmpresa, SETINFO_.IdCancelacion);
                foreach (var item in CancInterDetInfoList)
                {
                    var addressG = ((List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource).First(s => s.IdCbteVta == item.cbteVta_IdCbteVta);
                    addressG.Check = true;
                    addressG.TotalxCobrado = item.Valor_Aplicado;
                }
                xyz();

                //------------------------------------------------------------------------------------------------------------------------//
                //List<cxc_cobro_Det_Info> lista = new List<cxc_cobro_Det_Info>();
                //lista = Bus.ObtenerDetalleCobro(param.IdEmpresa, Convert.ToInt32(cmbSucursal.SelectedValue), SETINFO_.IdCobro);
                ////var T = from q in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource where q.Check==true select q;
                //foreach (var item in lista)
                //{
                //    var addressG = ((List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource).First(s => s.IdCbteVta == item.IdCbte_vta_nota);
                //    addressG.Check = true;
                //    addressG.TotalxCobrado = item.dc_ValorPago;
                //}
                //xyz();
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean GuardarDetalleCobro(List<cxc_cobro_Det_Info> Lst) {
            try
            {
                List<cxc_cobro_Det_Info> l = new List<cxc_cobro_Det_Info>();
                //Bus.EliminarDetalleCobro(_InfoCobro.IdEmpresa, _InfoCobro.IdSucursal, _InfoCobro.IdCobro);
                foreach (var item in Lst)
                {                    
                    l = new List<cxc_cobro_Det_Info>();
                    l.Add(item);

                    //Bus.GuardarDB(l);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        
        }
        //
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar()){return;}
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Guardar() == true)
                        {
                            txtIdCuenta.Text = Convert.ToString(_Info.IdCancelacion);
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Cancelación ", _Info.IdCancelacion);
                            MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);                        
                            //MessageBox.Show("Grabada Exitosamente la Cancelación # " + _Info.IdCancelacion, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Guarda CABECERA Y DETALLE DE COBRO DEREK 17/02/2014

                            G_ListadoDet_Cobros_Inter = new List<cxc_cobro_Det_Info>();
                            G_ListadoDet_Cobros_Inter = getDetalle();

                            int contador = 0;
                            foreach (var item1 in G_ListadoDet_Cobros_Inter)
                            {
                                contador++;
                                Get();

                                List<cxc_cobro_Det_Info> ListDet_Cobr= new List<cxc_cobro_Det_Info>();
                                ListDet_Cobr.Add(item1);

                                _InfoCobro.ListaCobro = ListDet_Cobr;

                                _InfoCobro.cr_TotalCobro = item1.dc_ValorPago;


                                //Graba Cabecera y detalle getDetalle()
                                string MsgError = "";
                                if (Bus.GuardarDB(Cl_Enumeradores.PantallaEjecucion.COBROS, ref _InfoCobro, ref MsgError))
                                //if (Bus.GuardarDB(ref SETINFO_) )
                                {
                                    string mensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Cuenta por Cobrar", _InfoCobro.IdCobro);
                                    MessageBox.Show(mensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    //MessageBox.Show("Se guardo Con exito la Cuenta por Cobrar #" + _InfoCobro.IdCobro, "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    
                                    ////Derek 21/02/2014 - Mod 22/02/2014
                                    int variable = 0;
                                    foreach (var item in _InfoDet)
                                    {
                                        variable++;
                                        if (contador == variable)
                                        {
                                            item.cbr_IdEmpresa = _InfoCobro.IdEmpresa;
                                            item.cbr_IdSucursal = _InfoCobro.IdSucursal;
                                            item.cbr_IdCobro = _InfoCobro.IdCobro;  
                                        }                                        
                                    }                                                                        

                                    btnGuardar.Enabled = btnguardarYsalir.Enabled = false;
                                }
                                else
                                {
                                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //Actualizar detalle de cancelacion intercompany Derek Mejía 22/02/2014
                                CancInterDetBus.GuardarDB(_InfoDet);
                            }
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        //Guarda CABECERA Y DETALLE DE COBRO DEREK 17/02/2014
                        if (GETINFO() == false) {
                            MessageBox.Show("No se actualizaron los datos", "Operación no exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break; }                
                        if (CancInterBus.GuardarDB(_Info)==true)
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Cancelación", _Info.IdCancelacion);
                            MessageBox.Show(smensaje, param.Nombre_sistema);                        
                            //MessageBox.Show("Se Modifico exitosamente la Cancelación # " + _Info.IdCancelacion, "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Modifica CABECERA Y DETALLE DE COBRO DEREK 17/02/2014

                            G_ListadoDet_Cobros_Inter = new List<cxc_cobro_Det_Info>();
                            G_ListadoDet_Cobros_Inter = getDetalle();

                            int contador = 0;
                            foreach (var item1 in G_ListadoDet_Cobros_Inter)
                            {
                                contador++;
                                Get();
                                //Derek 24/02/2014
                                cxc_cancelacion_Intercompany_det_Info lst = new cxc_cancelacion_Intercompany_det_Info();
                                lst = CancInterDetBus.Get_List_cancelacion_Intercompany_det(param.IdEmpresa, Convert.ToDecimal(SETINFO_.IdCancelacion), contador);
                                //
                                //List<cxc_cobro_Det_Info> ListDet_Cobr= new List<cxc_cobro_Det_Info>();
                                //ListDet_Cobr.Add(item1);

                                //_InfoCobro.ListaCobro = ListDet_Cobr;

                                //_InfoCobro.cr_TotalCobro = item1.dc_ValorPago;


                                //MODIFICAR Cabecera y detalle getDetalle()
                                _InfoCobro.IdCobro = Convert.ToDecimal(lst.cbr_IdCobro);
                                if (Bus.ModificarDB(_InfoCobro, Cl_Enumeradores.PantallaEjecucion.COBROS))                                
                                {
                                    string mensaje2 = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Cuenta por Cobrar ", _InfoCobro.IdCobro);
                                    MessageBox.Show(mensaje2, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);                        
                                    //MessageBox.Show("Se Modifico con exito la Cuenta por Cobrar #" + _InfoCobro.IdCobro, "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);

                                    //Modificar DETALLECOBRO
                                    //Bus.ModificarDetalleCobro(_InfoCobro.ListaCobro);
                                    ////Derek 21/02/2014 - Mod 22/02/2014
                                    //int variable = 0;
                                    //foreach (var item in _InfoDet)
                                    //{
                                    //    variable++;
                                    //    if (contador == variable)
                                    //    {
                                    //        item.cbr_IdEmpresa = _InfoCobro.IdEmpresa;
                                    //        item.cbr_IdSucursal = _InfoCobro.IdSucursal;
                                    //        item.cbr_IdCobro = _InfoCobro.IdCobro;  
                                    //    }                                        
                                    //}                                                                        
                                    btnGuardar.Enabled = btnguardarYsalir.Enabled = false;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }   
                        //Actualizar detalle de cancelacion intercompany Derek Mejía 22/02/2014
                        //CancInterDetBus.GuardarDetalle(_InfoDet);                                         
                        break;
                    default:
                        break;
                }
                //Derek Mejia 24/02/2014
                PresentarCobrosRelacionados();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbTipoCobro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                  cxc_cobro_tipo_Info tipo = (cxc_cobro_tipo_Info)cmbTipoCobro.SelectedItem;
                        if (tipo.IdCobro_tipo == "NTCR" || tipo.IdCobro_tipo == "NTDE")
                        {
                            pnlTipoNota.Visible = true;
                            gpbDatosTarjeta.Visible = false;
                            grbDatosBanco.Visible = false;
                            lblTipoNC.Text = tipo.tc_descripcion;
                            gpbDatosTarjeta.Left = grbDatosBanco.Left;
                            gpbDatosTarjeta.Top = grbDatosBanco.Top;

                            cmbTipoNC.DataSource = TipoNota((tipo.IdCobro_tipo == "NTDE") ? "D" : "C");
                            cmbTipoNC.DisplayMember = "no_Descripcion";
                            cmbTipoNC.ValueMember = "IdTipoNota";

                        }
                        if (tipo.IdCobro_tipo != "NTCR" && tipo.IdCobro_tipo != "NTDE")
                        {
                            pnlTipoNota.Visible = false;
                            pnlTipoNota.Left = grbDatosBanco.Left;
                            pnlTipoNota.Top = grbDatosBanco.Top;

                        }
                        if (tipo.tc_EsCheque == "S")
                        {
                            grbDatosBanco.Text = "Datos del Cheque";
                            pnlTipoNota.Visible = false;
                            gpbDatosTarjeta.Visible = false;
                            grbDatosBanco.Visible = true;

                            //pnlTipoNota.Left = grbDatosBanco.Left;
                            //pnlTipoNota.Top = grbDatosBanco.Top;

                        } if (tipo.tc_EsCheque != "S")
                        {
                            grbDatosBanco.Visible = false;
                        }
                        if (tipo.IdCobro_tipo == "TARJ")
                        {
                            grbDatosBanco.Text = "Datos de la Tarjeta";
                            pnlTipoNota.Visible = false;
                            gpbDatosTarjeta.Visible = true;
                            grbDatosBanco.Visible = false;

                            gpbDatosTarjeta.Left = grbDatosBanco.Left;
                            gpbDatosTarjeta.Top = grbDatosBanco.Top;

                        }
                        if (tipo.IdCobro_tipo == "DEPO")
                        {
                            grbDatosBanco.Text = "Datos del Deposito";
                            cmbBancoCta.Visible = true;
                            label16.Visible = true;
                            label11.Visible = false;
                            label8.Visible = false;
                            label17.Visible = true;
                            txtPropietario.Visible = false;
                            txtNumCuenta.Visible = false;
                            grbDatosBanco.Visible = true;
                            cmbBancos.Visible = false;

                        }
                        else
                        {
                            label17.Visible = false;
                            label11.Visible = true;
                            label8.Visible = true;
                            txtPropietario.Visible = true;
                            txtNumCuenta.Visible = true;
                            cmbBancos.Visible = true;
                            //Derek Mejia 24/02/2014
                            cmbBancoCta.Text = "";
                            txtPropietario.Text = "";
                            txtNumCuenta.Text = "";
                            cmbBancos.Text = "";

                            //grbDatosBanco.Visible = true;
                            cmbBancoCta.Visible = false;
                            label16.Visible = false;
                        }
                        if (tipo.tc_Afecha == "S")
                        {
                            pnlFechaCobro.Visible = true;
                        }
                        if (tipo.tc_Afecha == "N")
                        {
                            pnlFechaCobro.Visible = false;
                        }
                        if (tipo.IdCobro_tipo != "TARJ")
                        {
                            gpbDatosTarjeta.Visible = false;
                        }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Sumar()
        {
            try
            {
            if (Convert.ToBoolean(gridViewCobros.GetFocusedRowCellValue(colCheck)))
            {
                
            if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)) < Convert.ToDouble(txeSaldoPendiente.EditValue) )
            {
                    //problema
                if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colSaldo)) > 0)
                {
                    if ((double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado) == 0)
                    {
                        gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, gridViewCobros.GetFocusedRowCellValue(colSaldo));
                    }
                }
                if (Convert.ToDouble(txeSaldoPendiente.EditValue) < Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado))) 
                {
                }
                else
                {
                    //txtSaldoPendiente.Value = txtSaldoPendiente.Value - Convert.ToDecimal(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                }
            }
            else
            {
                if (Convert.ToDouble(txeSaldoPendiente.EditValue) < Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)))
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
            if ((double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)==0) { 
            gridViewCobros.SetFocusedRowCellValue(colSaldo, (double)gridViewCobros.GetFocusedRowCellValue(saldoAUX) - (double)gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado));
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void xyz()
        {
            try
            {
                if (Convert.ToDouble(txeValor.EditValue) == 0) { return; }
                double sum = 0;
                List<vwcxc_cartera_x_cobrar_Info> z = new List<vwcxc_cartera_x_cobrar_Info>();
                //List<vwcxc_cartera_x_cobrar_Info> asd =from x in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource
                //                                                    where x.Check==true
                //                                                    select x;

                z = (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource;
                
                foreach(var item in z)
                {
                    item.TotalxCobrado = (item.SaldoAUX<item.TotalxCobrado)?0:item.TotalxCobrado;
                    item.Saldo = item.SaldoAUX-item.TotalxCobrado;
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    gridControlCobro.DataSource = null;
                }                
                gridControlCobro.DataSource = z;

                var s = from x in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource
                        where x.Check == true
                        select x;
                List<vwcxc_cartera_x_cobrar_Info> LstChek = new List<vwcxc_cartera_x_cobrar_Info>();
                        
                foreach(var item in s)
                {
                    sum +=(double)item.TotalxCobrado;
                }

                txeSaldoPendiente.EditValue = Convert.ToDouble(txeValor.EditValue) - sum;
            //    List<vwcxc_cartera_x_cobrar_Info> aux = new List<vwcxc_cartera_x_cobrar_Info>();
           //     aux = (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource;
                //gridControlCobro.DataSource=((List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource).ForEach(q => q.TotalxCobrado = ((q.TotalxCobrado < 0) ? 0 : q.TotalxCobrado)) ;
                // gridControlCobro.DataSource=((List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource).ForEach(q => q.TotalxCobrado = ((q.TotalxCobrado > q.SaldoAUX) ? 0 : q.TotalxCobrado));

                
                //aux.ForEach(q => q.TotalxCobrado = ((q.TotalxCobrado < 0) ? 0 : q.TotalxCobrado));
                //gridControlCobro.DataSource = aux;
                //aux.ForEach(q => q.TotalxCobrado = ((q.TotalxCobrado > q.SaldoAUX) ? 0 : q.TotalxCobrado));
                //gridControlCobro.DataSource = aux;

                //if (e.Column.FieldName == "TotalxCobrado")
                //{

                //    foreach (vwcxc_cartera_x_cobrar_Info item in asd)
                //    {
                //        if (item.Check)
                //        {
                //            LstChek.Add(item);
                //        }

                //    }
                //}

                //foreach (var item in LstChek)
                //{
                //    sum = sum + (decimal)item.TotalxCobrado;
                //}

                //txtSaldoPendiente.Value = txtValor.Value - sum;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Calcular(DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) 
        {
            try
            {
                double sum = 0;

                List<vwcxc_cartera_x_cobrar_Info> asd = (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource;
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
            }
            

        }
      
        private void btnguardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
                btnGuardar_Click(sender, e);
                if(MessageBox.Show("¿Desea Salir?","¿?",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes){
                this.Close();}
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                frm.ShowDialog();
                msg = frm.motivoAnulacion;
                if (lblAnulado.Visible == true){ MessageBox.Show("Ya esta ANULADO", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;}
                _Info.cr_estado = "I";
                if (Guardar() == true) {
                    MessageBox.Show("Anulado OK", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblAnulado.Visible = true;
                }
                //if (Bus.Anular(SETINFO_)){
                //    MessageBox.Show("Anulado OK","Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                //    lblAnulado.Visible = true;
                //}
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
                btnGuardar.Enabled = btnguardarYsalir.Enabled = true;
                ctrl_Cliente.cmb_cliente.EditValue = 0;
                txtNumCheque.Text = txtNumCuenta.Text = txtNumTarje.Text = txtObservacion.Text = txtRecibo.Text = txtCodCuenta.Text = txtIdCuenta.Text = "";
                txeSaldoPendiente.EditValue = txeValor.EditValue = 0;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
        //private void frmcxc_CobrosGenerales_Mant_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    try
        //    {
        //        frmcxc_CobrosGenerales_Mant_event_FrmClose(sender, e);
        //        event_FrmClose(sender, e);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}
       
        public void validarFechas(){
            try
            {
                if (dtpFecha.Value > dtpFechaIngreso.Value)
                {
                    dtpFechaIngreso.Value = dtpFecha.Value;
                }
                if (dtpFechaCobro.Value < dtpFechaIngreso.Value)
                {
                    dtpFechaCobro.Value = dtpFechaIngreso.Value;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }
        }

        public void cargarGridContable()
        {
            try
            {
               
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
                gridViewCobros.ShowPrintPreview();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnReversarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea Guardar?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cxc_cobro_Det_Bus BusDet_cobro = new cxc_cobro_Det_Bus();

                    if (BusDet_cobro.EliminarDetalleCobro(param.IdEmpresa, Convert.ToInt32(cmbSucursal.SelectedValue), Convert.ToDecimal(txtIdCuenta.Text)))
                    {
                        MessageBox.Show("Reversado");
                        CargarGrillaXCliente();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridViewCobros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    return;
                }
                else
                {
                    e.HitInfo.Column.FieldName = gridViewCobros.FocusedColumn.FieldName;
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
                            return;
                        }
                        else
                        {
                            if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotal)) != 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, true);
                            }
                            if (Convert.ToDouble(txeSaldoPendiente.EditValue) == 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                                MessageBox.Show("No hay Saldo para Asignar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            if ((double)gridViewCobros.GetFocusedRowCellValue(colSaldo) < 0)
                            {
                                gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                            }
                        }
                    }
                    //else if (e.HitInfo.Column.FieldName == "Ico")
                    //{
                    //    if (cmbCaja.EditValue == null) { MessageBox.Show("Por favor, Seleccione la Caja."); }
                    //    else
                    //    {
                    //        frmcxc_CobrosRetenciones frm = new frmcxc_CobrosRetenciones();
                    //        vwcxc_cartera_x_cobrar_Info red = (vwcxc_cartera_x_cobrar_Info)gridViewCobros.GetFocusedRow();
                    //        frm.Accion = _Accion;
                    //        frm.setInfo(red, ctrl_Cliente.cmb_cliente.Text, Convert.ToInt32(cmbCaja.EditValue));
                    //        frm.ShowDialog();
                    //        CargarGrillaXCliente();
                    //    }
                    //}
                    Sumar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Sumar();
            }
        }

        private void gridViewCobros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colTotalxCobrado" && Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)) > 0)
                    if (Convert.ToDouble(gridViewCobros.GetFocusedRowCellValue(colTotalxCobrado)) > Convert.ToDouble(txeSaldoPendiente.EditValue))
                    {
                        gridViewCobros.SetFocusedRowCellValue(colCheck, false);
                        gridViewCobros.SetFocusedRowCellValue(colTotalxCobrado, 0);
                    }
                xyz();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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

                var s = from x in (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource
                        where x.Check == true
                        select x;
                xyz();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmCo_cxc_cancelacion_Intercompany_Mant_Load(object sender, EventArgs e)
        {
            try
            {                
                xtraTabPage2.PageVisible = false;
                ctrl_Cliente.Dock = DockStyle.Fill;
                pnlCliente.Controls.Add(ctrl_Cliente);
                ctrl_Cliente.cmb_vendedor.Visible = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar: 
                        cargarGridContable();
                        cmbTipoCobro_SelectionChangeCommitted(sender, e);
                        btnAnular.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        btnGuardar.Enabled = btnguardarYsalir.Enabled = btnAnular.Enabled = false;
                        Set();
                        obtenerDetalle();
                        panel2.Enabled = false;
                        gridViewCobros.OptionsBehavior.Editable = false;                        
                        btnGuardar.Enabled = btnguardarYsalir.Enabled = btnLimpiar.Enabled = false;                        

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                        obtenerDetalle();                        
                        panel2.Enabled = false;
                        gridViewCobros.OptionsBehavior.Editable = false;
                        btnLimpiar.Enabled = false;  
                        btnAnular.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        obtenerDetalle();
                        
                        btnGuardar.Enabled = btnguardarYsalir.Enabled = btnLimpiar.Enabled = false;
                        break;
                    default:
                        break;
                }
                if (SETINFO_.cr_estado == "I") { lblAnulado.Visible = true; }
                cargarGridContable();
                //Derek Mejia 24/02/2014
                PresentarCobrosRelacionados();
                //
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //private void txtValor_Validating(object sender, CancelEventArgs e)
        //{
        //    try
        //    {
        //        txeSaldoPendiente.EditValue = Convert.ToDouble(txeValor.EditValue);
        //        CargarGrillaXCliente();
        //        List<vwcxc_cartera_x_cobrar_Info> Lst = (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource;
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }
        //}

        private void dtpFechaIngreso_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validarFechas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }
        }

        private void txtIdCuenta_TextChanged(object sender, EventArgs e)
        {            
        }

        public void PresentarCobrosRelacionados() {
            try
            {
                //Cargar vwcxc_cancelacion_Intercompany_x_cxc_cobro_det
                vistaBLInfo = new List<vwcxc_cancelacion_Intercompany_x_cxc_cobro_det_Info>(CancInterBus.Get_List_cancelacion_Intercompany_x_cxc_cobro_det(param.IdEmpresa, Convert.ToDecimal(txtIdCuenta.Text)));
                gridControlCobrosRelacionados.DataSource = vistaBLInfo;
                gridViewCobrosRelacionados.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        //

        //Derek Mejia 25022014-------Grabar Depositos
        //ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();

        //public ct_Cbtecble_Info get_Cbtecble()
        //{
        //    try
        //    {
        //        CbteCble_I.IdEmpresa = param.IdEmpresa;
        //        CbteCble_I.IdTipoCbte = _IdTipoCbte;
        //        //CbteCble_I.CodCbteCble = "";
        //        CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
        //        CbteCble_I.Fecha = dtpFecha.Value.Date;
        //        CbteCble_I.Valor = Convert.ToDouble(this.txtValor.Value);
        //        CbteCble_I.Observacion = " Banco: " + _Info.cr_Banco;
        //        CbteCble_I.Secuencia = 0;
        //        CbteCble_I.Estado = "A";
        //        CbteCble_I.Anio = dtpFecha.Value.Year;
        //        CbteCble_I.Mes = dtpFecha.Value.Month;
        //        CbteCble_I.IdUsuario = param.IdUsuario;
        //        CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
        //        CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
        //        CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
        //        CbteCble_I.Mayorizado = "N";
        //        //CbteCble_I._cbteCble_det_lista_info = _ListaCbteCbleDet;

        //        return CbteCble_I;

        //    }
        //    catch (Exception ex)
        //    {
        //      Log_Error_bus.Log_Error(ex.ToString());
        //        return null;

        //    }
        //}

        //ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();

        //public ba_Cbte_Ban_Info get_CbteBan()
        //{
        //    try
        //    {
        //        CbteBan_I.IdEmpresa = param.IdEmpresa;
        //        CbteBan_I.IdTipocbte = _IdTipoCbte;
        //        CbteBan_I.IdCbteCble = 0;
        //        CbteBan_I.Cod_Cbtecble = (CbteBan_I.Cod_Cbtecble == "" || CbteBan_I.Cod_Cbtecble == null || CbteBan_I.Cod_Cbtecble == "0") ? cod_CbteCble : CbteBan_I.Cod_Cbtecble;
        //        CbteBan_I.IdPeriodo = Per_I.IdPeriodo;
        //        CbteBan_I.IdBanco = (CbteBan_I.IdBanco == null || CbteBan_I.IdBanco < 1) ? _b.IdBanco : CbteBan_I.IdBanco;
        //        CbteBan_I.cb_Fecha = dtpFecha.Value.Date;
        //        CbteBan_I.cb_Observacion = txt_Memo.Text.Trim();
        //        CbteBan_I.cb_secuencia = (CbteBan_I.cb_secuencia == 0 || CbteBan_I.cb_secuencia == null) ? 0 : CbteBan_I.cb_secuencia;
        //        CbteBan_I.cb_Valor = Convert.ToDouble(this.txt_totalDepositar.Value);
        //        CbteBan_I.Estado = (lb_Anulado.Visible == false) ? "A" : "I";
        //        CbteBan_I.IdUsuario = param.IdUsuario;
        //        CbteBan_I.IdUsuario_Anu = param.IdUsuario;
        //        CbteBan_I.FechaAnulacion = param.Fecha_Transac;
        //        CbteBan_I.Fecha_Transac = param.Fecha_Transac;
        //        CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
        //        CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
        //        CbteBan_I.ip = param.ip;
        //        CbteBan_I.nom_pc = param.nom_pc;

        //        return CbteBan_I;
        //    }
        //    catch (Exception ex)
        //    {
        //      Log_Error_bus.Log_Error(ex.ToString());
        //        return null;
        //    }
        //}


        //ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
        //decimal idCbteCble = 0;
        //string cod_CbteCble ="";
        //ba_Banco_Parametros_bus paramBa_B = new ba_Banco_Parametros_bus();
        //List<ba_Banco_Parametros_Info> listParaBan = new List<ba_Banco_Parametros_Info>();
        //ba_Banco_Parametros_Info paramBa_I = new ba_Banco_Parametros_Info();
        //ct_Periodo_Info Per_I = new ct_Periodo_Info();
        //ct_Periodo_Bus Per_B = new ct_Periodo_Bus();

        //string motiAnulacion, msg2;                

        //string ctaCble_acreedoraDeposito = "";
        //int _IdTipoCbte = 0;
        //int IdTipoCbteRev = 0;
        //decimal IdCbteCbleRev;      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //ba_Cbte_Ban_Bus b = new ba_Cbte_Ban_Bus();
                ////
                //listParaBan = paramBa_B.ObtenerParametrosBanco(param.IdEmpresa);
                //paramBa_I = listParaBan.Find(delegate(ba_Banco_Parametros_Info P) { return P.CodTipoCbteBan == "DEPO"; });
                //Per_I = Per_B.ObtenerObjetoInfo(param.IdEmpresa, dtpFecha.Value.Date);
                ////
                //get_CbteBan();
                //get_Cbtecble();
                //b.Grabar_Deposito_Intercomny(param.IdEmpresa, CbteBan_I
                //, InfoCbteCble, ref idCbteCble, ref cod_CbteCble, ref msg);
            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txeValor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                 txeSaldoPendiente.EditValue = Convert.ToDouble(txeValor.EditValue);
                CargarGrillaXCliente();
                List<vwcxc_cartera_x_cobrar_Info> Lst = (List<vwcxc_cartera_x_cobrar_Info>)gridControlCobro.DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               
            }
        }

        //
    }
}
