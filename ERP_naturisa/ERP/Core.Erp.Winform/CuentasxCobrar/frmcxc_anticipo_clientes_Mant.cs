using Core.Erp.Winform.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Caja;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Reportes.CuentasxCobrar;

//Derek 24012014
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_anticipo_clientes_Mant : Form
    {
        #region Variables
         private Cl_Enumeradores.eTipo_action _Accion;
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) { _Accion = iAccion; }
        
        List<cxc_cobro_Info> cxccinfoLst = new List<cxc_cobro_Info>();
        cxc_cobro_Info info = new cxc_cobro_Info();
        cxc_cobro_Bus cobroBus = new cxc_cobro_Bus();
        cxc_cobro_x_Anticipo_Info cobroAntiinfo = new cxc_cobro_x_Anticipo_Info();
        cxc_cobro_x_Anticipo_Info CAInfo = new cxc_cobro_x_Anticipo_Info();
        BindingList<cxc_cobro_x_Anticipo_Info> cobroAntiBininfo = new BindingList<cxc_cobro_x_Anticipo_Info>();
        List<cxc_cobro_x_Anticipo_det_Info> cobroAntiDetinfo = new List<cxc_cobro_x_Anticipo_det_Info>();
        cxc_cobro_x_Anticipo_Bus cxccABus = new cxc_cobro_x_Anticipo_Bus();
        cxc_cobro_x_Anticipo_det_Bus cxccAdBus = new cxc_cobro_x_Anticipo_det_Bus();
        cxc_cobro_Bus cxccBus = new cxc_cobro_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<cxc_cobro_tipo_Info> cobroTipoInfoLst = new List<cxc_cobro_tipo_Info>();
        cxc_cobro_tipo_Bus cobroTipoBus = new cxc_cobro_tipo_Bus();
        List<tb_banco_Info> BancoLst = new List<tb_banco_Info>();
        tb_banco_Bus BancoBus = new tb_banco_Bus();
        List<ba_Banco_Cuenta_Info> LstBancoCuentaInfo = new List<ba_Banco_Cuenta_Info>();
        ba_Banco_Cuenta_Bus BancoCuentaBus = new ba_Banco_Cuenta_Bus();
        List<tb_tarjeta_Info> TarjetaInfoList = new List<tb_tarjeta_Info>();
        tb_tarjeta_Bus TarjetaBus = new tb_tarjeta_Bus();
        List<tb_Sucursal_Info> SucuInfo = new List<tb_Sucursal_Info>();
        tb_Sucursal_Bus SucuBus = new tb_Sucursal_Bus();
        caj_Caja_Bus busCaja = new caj_Caja_Bus();
        cxc_parametro_Bus cxcParametroBus = new cxc_parametro_Bus();
        string MensajeError = "";
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cxc_cobro_x_Anticipo_Info SETINFO_ { get; set; }
        Boolean cambiocont = true;
        public delegate void delegate_frmcxc_anticipo_clientes_Mant_FormClosing();
        public event delegate_frmcxc_anticipo_clientes_Mant_FormClosing event_frmcxc_anticipo_clientes_Mant_FormClosing;

        #endregion

        public frmCxc_anticipo_clientes_Mant()
        {
            try
            {
                InitializeComponent();                
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
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

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                List<XCXC_Rpt002_Info> lstRpt = new List<XCXC_Rpt002_Info>();
                XCXC_Rpt002_rpt rptSoporte = new XCXC_Rpt002_rpt(param.IdUsuario);
                XCXC_Rpt002_Bus busRpt = new XCXC_Rpt002_Bus();

                rptSoporte.RequestParameters = false;
                lstRpt = busRpt.get_ImpresionAnticipo(param.IdEmpresa, cmbSucursal.get_SucursalInfo().IdSucursal, Convert.ToDecimal(txtIdAnticipo.Text));
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

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
                txtObservacion.Focus();
                if (validar())
                {
                    if (Grabar())
                        Close();
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
                txtObservacion.Focus();
                if (validar())
                    if (Grabar())
                    {
                        load();
                        presentar();
                    }
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
                AnularAnticipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void control_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void load()
        {
            try
            {                                
                if (SETINFO_ != null)
                {
                    if (SETINFO_.Estado == "I")
                    {
                        lblAnular.Visible = true;
                    }
                }
                CargarTipoCobro();
                //carga el listado de los bancos en la grilla
                BancoLst = new List<tb_banco_Info>(BancoBus.Get_List_Banco());
                repositoryItemSearchLookUpEditBanco.DataSource = BancoLst;
                //carga el listado de las cuentas de los bancos
                LstBancoCuentaInfo = BancoCuentaBus.Get_list_Banco_Cuenta(param.IdEmpresa);
                repositoryItemSearchLookUpEditBancoDepo.DataSource = LstBancoCuentaInfo;
                //carga el combo de caja
                TarjetaInfoList = new List<tb_tarjeta_Info>(TarjetaBus.Get_List_tarjeta());
                repositoryItemSearchLookUpEditTarjeta.DataSource = TarjetaInfoList;                
                cmbCaja.Properties.DataSource = busCaja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
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
                cobroAntiinfo = new cxc_cobro_x_Anticipo_Info();
                cobroAntiinfo.listDetalle_Anticipo = new List<cxc_cobro_x_Anticipo_det_Info>();
                cobroAntiinfo.listCobros = new List<cxc_cobro_Info>();
                cobroAntiBininfo = new BindingList<cxc_cobro_x_Anticipo_Info>();                
                txtObservacion.Text = "";
                txtIdAnticipo.Text = "0";
                cmbSucursal.get_SucursalInfo();
                cmbCaja.EditValue = "";
                ucFa_Cliente.set_ClienteInfo(0);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTipoCobro()
        {
            try
            {
                cobroTipoInfoLst = new List<cxc_cobro_tipo_Info>(cobroTipoBus.Get_List_Cobro_Tipo_Anticipo(param.IdEmpresa));
                repositoryItemSearchLookUpEditCobroTipo.DataSource = cobroTipoInfoLst;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AnularAnticipo()
        {
            try
            {

            }
            catch (Exception ex)
            {
                                
            }
        }

        public void presentar()
        {
            try
            {
                cobroAntiBininfo = new BindingList<cxc_cobro_x_Anticipo_Info>(cxccABus.Get_List_cobro_x_Anticipo(param.IdEmpresa, Convert.ToInt32(txtIdAnticipo.EditValue), ref MensajeError));
                calculo();
                foreach (var item in cobroAntiBininfo)
                {
                    item.Ico = (Bitmap)imageList1.Images[0];
                }
                gridControlcxc.DataSource = cobroAntiBininfo;
                txtObservacion.Focus();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        public void calculo()
        {
            try
            {
                txtEfectivo.EditValue = 0;
                txtCheque.EditValue = 0;
                txtDeposito.EditValue = 0;
                txtOtros.EditValue = 0;
                txtCobrado.EditValue = 0;
                foreach (var item in cobroAntiBininfo)
                {
                    if (item.IdCobro_tipo == "EFEC")
                    {
                        txtEfectivo.EditValue = Convert.ToDecimal(txtEfectivo.EditValue) + Convert.ToDecimal(item.Valor);
                    }
                    else
                    {
                        if (item.IdCobro_tipo == "TARJ" || item.IdCobro_tipo == "CHQF" || item.IdCobro_tipo == "CHQV")
                        {
                            txtCheque.EditValue = Convert.ToDecimal(txtCheque.EditValue) + Convert.ToDecimal(item.Valor);
                        }
                        else
                        {
                            if (item.IdCobro_tipo == "DEPO")
                            {
                                txtDeposito.EditValue = Convert.ToDecimal(txtDeposito.EditValue) + Convert.ToDecimal(item.Valor);
                            }
                            else
                            {
                                if (item.IdCobro_tipo != "TARJ" && item.IdCobro_tipo != "CHQF" && item.IdCobro_tipo != "CHQV" && item.IdCobro_tipo != "EFEC" && item.IdCobro_tipo != "DEPO")
                                {
                                    txtOtros.EditValue = Convert.ToDecimal(txtOtros.EditValue) + Convert.ToDecimal(item.Valor);
                                }
                            }
                        }
                    }
                }
                txtCobrado.EditValue = Convert.ToDecimal(txtEfectivo.EditValue) + Convert.ToDecimal(txtCheque.EditValue) + Convert.ToDecimal(txtDeposito.EditValue) + Convert.ToInt32(txtOtros.EditValue);
                txtEfectivo.EditValue = "$" + " " + Convert.ToString(txtEfectivo.EditValue);
                txtCheque.EditValue = "$" + " " + Convert.ToString(txtCheque.EditValue);
                txtDeposito.EditValue = "$" + " " + Convert.ToString(txtDeposito.EditValue);
                txtOtros.EditValue = "$" + " " + Convert.ToString(txtOtros.EditValue);
                txtCobrado.EditValue = "$" + " " + Convert.ToString(txtCobrado.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Get_Info_Anticipo()
        {
            try
            {
                cobroAntiinfo = new cxc_cobro_x_Anticipo_Info();
                cobroAntiinfo.IdEmpresa = param.IdEmpresa;
                cobroAntiinfo.Fecha = Convert.ToDateTime(dtpFecha.EditValue).Date;
                cobroAntiinfo.IdAnticipo = Convert.ToDecimal(txtIdAnticipo.EditValue);
                cobroAntiinfo.IdSucursal = cmbSucursal.get_SucursalInfo().IdSucursal;
                cobroAntiinfo.IdCliente = ucFa_Cliente.get_ClienteInfo().IdCliente;
                cobroAntiinfo.Observacion = Convert.ToString(txtObservacion.EditValue);
                //cobroAntiinfo.IdCbteCble_Caja = null;
                //cobroAntiinfo.IdTipocbte_Caja = null;
                //cobroAntiinfo.IdEmpresa_Caja = null;
                cobroAntiinfo.Fecha_Transac = param.Fecha_Transac.Date;
                cobroAntiinfo.Fecha_UltAnu = null;
                cobroAntiinfo.Fecha_UltMod = null;
                cobroAntiinfo.nom_pc = param.nom_pc;
                cobroAntiinfo.ip = param.ip;
                cobroAntiinfo.IdCaja = Convert.ToInt32(cmbCaja.EditValue);

                cobroAntiinfo.IdUsuario = param.IdUsuario;
                cobroAntiinfo.Estado = "A";


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Boolean Get_Info_Anticipo_Detalle()
        {
            try
            {
                int secuencia = 0;
                cobroAntiDetinfo = new List<cxc_cobro_x_Anticipo_det_Info>();
                foreach (var item2 in cobroAntiBininfo)
                {
                    secuencia++;
                    cxc_cobro_x_Anticipo_det_Info item = new cxc_cobro_x_Anticipo_det_Info();


                    item.IdFila = secuencia;

                    item.IdEmpresa = param.IdEmpresa;
                    item.IdAnticipo = cobroAntiinfo.IdAnticipo;
                    item.Secuencia = secuencia;
                    item.IdCobro_tipo = item2.IdCobro_tipo;

                    if (item2.IdEmpresa > 0)
                        item.IdEmpresa_Cobro = item2.IdEmpresa;
                    else
                        item.IdEmpresa_Cobro = null;

                    if (item2.IdSucursal > 0)
                        item.IdSucursal_cobro = item2.IdSucursal;
                    else
                        item.IdSucursal_cobro = null;

                    if (item2.IdCobro_cobro > 0)
                        item.IdCobro_cobro = item2.IdCobro_cobro;
                    else
                        item.IdCobro_cobro = null;

                    item.Fecha_Transac = param.Fecha_Transac;
                    item.Fecha_UltAnu = null;
                    item.Fecha_UltMod = null;
                    item.nom_pc = param.nom_pc;
                    item.ip = param.ip;

                    item.IdUsuario = param.IdUsuario;
                    item.Estado = "A";

                    cobroAntiDetinfo.Add(item);

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

        public Boolean GETINFOCXC()
        {
            try
            {
                cxccinfoLst = new List<cxc_cobro_Info>();
                int numeroPosicion = 0;

                foreach (var item in cobroAntiBininfo)
                {

                    numeroPosicion++;
                    info = new cxc_cobro_Info();

                    info.IdFila = numeroPosicion;

                    foreach (var item2 in BancoLst)
                    {
                        if (item2.ba_descripcion == item.cr_Banco)
                        {
                            info.cr_Banco = item2.ba_descripcion;
                        }
                    }

                    info.cr_fecha = (Convert.ToDateTime(dtpFecha.EditValue)).Date;

                    if (item.cr_fechaCobro == Convert.ToDateTime("01/01/0001"))
                        info.cr_fechaCobro = DateTime.Now.Date;
                    else
                        info.cr_fechaCobro = item.cr_fechaCobro.Date;


                    

                    if (item.cr_fechaDocu == Convert.ToDateTime("01/01/0001"))
                        info.cr_fechaDocu = item.cr_fechaCobro.Date;
                    else
                        info.cr_fechaDocu = item.cr_fechaDocu.Date;



                    info.Fecha_Transac = param.Fecha_Transac.Date;
                    info.Fecha_UltAnu = null;
                    info.Fecha_UltMod = null;
                    info.nom_pc = param.nom_pc;
                    info.IdCobro_a_aplicar = null;
                    info.cr_observacion = "Cobro x Ant. x  " + info.IdCobro_tipo + " #Anticipo:" + cobroAntiinfo.IdAnticipo + " a Cliente:" + ucFa_Cliente.get_ClienteInfo().Nombre_Cliente + " " + Convert.ToString(txtObservacion.EditValue);
                    info.IdCliente = ucFa_Cliente.get_ClienteInfo().IdCliente;
                    info.nom_pc = param.nom_pc;
                    info.ip = param.ip;
                    info.IdUsuario = param.IdUsuario;
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = param.IdSucursal;
                    info.cr_TotalCobro = Convert.ToDouble(item.Valor);
                    info.cr_cuenta = item.cr_cuenta;
                    info.cr_NumDocumento = item.cr_NumDocumento;
                    info.cr_Tarjeta = item.cr_Tarjeta;
                    info.IdBanco = Convert.ToInt32(item.IdBanco);
                    info.IdCobro_tipo = item.IdCobro_tipo;
                    //03/02/2014 Derek Mejía Soria
                    info.IdCobro = (item.IdCobro_cobro == 0) ? 0 : item.IdCobro_cobro;
                    if (info.IdCobro_tipo != "" && info.IdCobro_tipo != null)
                    {
                        var tipCobro = cobroTipoInfoLst.Where(q => q.IdCobro_tipo == info.IdCobro_tipo).First();
                        if (tipCobro.tc_EsCheque == "S")
                        {
                            if (info.cr_Banco == "" || info.cr_Banco == null)
                            {
                                MessageBox.Show("Se debe seleccionar un banco en registro: " + numeroPosicion, "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                                //break;
                            }                        
                        }

                        //if (tipCobro.tc_SePuede_Depositar == "S")
                        //{
                        //    if (info.IdBanco == 0 || info.IdBanco == null)
                        //    {
                        //        MessageBox.Show("Se debe seleccionar un banco a depositar en registro: " + numeroPosicion, "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //        return false;
                        //    }                      
                        //}
                    }
                    else
                    {
                        if (info.IdCobro_tipo == "" || info.IdCobro_tipo != null)
                        {
                            MessageBox.Show("Se debe seleccionar un tipo de cobro en el registro: " + numeroPosicion, "Operación Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }

                    info.IdSucursal = cobroAntiinfo.IdSucursal;
                    info.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                    cxccinfoLst.Add(info);
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

        public Boolean SETINFO()
        {
            try
            {
                txtIdAnticipo.EditValue = SETINFO_.IdAnticipo;
                ucFa_Cliente.set_ClienteInfo(Convert.ToDecimal(SETINFO_.IdCliente));
                dtpFecha.EditValue = SETINFO_.Fecha;
                txtObservacion.EditValue = SETINFO_.Observacion;
                cmbSucursal.set_SucursalInfo(SETINFO_.IdSucursal);
                colIco.Visible = true;
                cmbCaja.EditValue = SETINFO_.IdCaja;
                cxc_cobro_x_Anticipo_Bus cxccinfoBus = new cxc_cobro_x_Anticipo_Bus();
                cobroAntiBininfo = new BindingList<cxc_cobro_x_Anticipo_Info>(cxccinfoBus.Get_List_cobro_x_Anticipo (param.IdEmpresa, Convert.ToInt32(txtIdAnticipo.EditValue), ref MensajeError));
                calculo();
                foreach (var item in cobroAntiBininfo)
                {
                    item.chek = true;
                    item.Ico = (Bitmap)imageList1.Images[0];
                }
                gridControlcxc.DataSource = cobroAntiBininfo;
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void frmcxc_anticipo_clientes_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmcxc_anticipo_clientes_Mant_FormClosing();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmcxc_anticipo_clientes_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                presentar();
                load();
                cmbSucursal.set_SucursalInfo(param.IdSucursal);
                cmbCaja.EditValue = cxcParametroBus.Get_Info_parametro(param.IdEmpresa).pa_IdCaja_x_cobros_x_CXC;               
                colIco.Visible = false;
                ucFa_Cliente.set_ClienteInfo(0);
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        dtpFecha.EditValue = DateTime.Now.Date;
                        dtpFecha.DateTime = System.DateTime.Now;
                        ucGe_Menu.Enabled_btnImprimirSoporte = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        SETINFO();
                        dtpFecha.Enabled = false;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        SETINFO();
                        gridViewcxc.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
                        ucFa_Cliente.Enabled = false;
                        cmbSucursal.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        dtpFecha.Enabled = false;
                        gridViewcxc.OptionsBehavior.Editable = false;
                        colIco.OptionsColumn.AllowEdit = true;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                        ucGe_Menu.Enabled_bntAnular = false;
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

        private Boolean validar()
        {
            try
            {
                Boolean res = true;

                if (cmbCaja.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbCaja.Focus();
                    return false;
                }

                if (ucFa_Cliente.get_ClienteInfo() == null || ucFa_Cliente.get_ClienteInfo().IdCliente==0)
                {
                    MessageBox.Show("Seleccione un cliente", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (cmbSucursal.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Seleccione una sucursal", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbSucursal.Focus();
                    return false;
                }

                if (txtObservacion.EditValue == null || txtObservacion.EditValue == "")
                {
                    MessageBox.Show("Digite una observacion", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
               

                if(!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.CXC, Convert.ToDateTime(dtpFecha.EditValue)))
                    return false;


                return res;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public Boolean Grabar()
        {
            try
            {
                if (Get_Info_Anticipo() == false)
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (Get_Info_Anticipo_Detalle() == false)
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (GETINFOCXC() == false)
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                cobroAntiinfo.listDetalle_Anticipo = cobroAntiDetinfo;
                cobroAntiinfo.listCobros = cxccinfoLst;

                if (cxccABus.GuardarDB(cobroAntiinfo, ref MensajeError, true, Cl_Enumeradores.PantallaEjecucion.ANTICIPOS) == false)
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                string mensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk,"El anticipo ",cobroAntiinfo.IdAnticipo);
                MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK);
                txtIdAnticipo.EditValue = cobroAntiinfo.IdAnticipo;

                if (MessageBox.Show("¿Desea Imprimir el Anticipo # " + cobroAntiinfo.IdAnticipo + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                }

                //ucGe_Menu.Visible_btnGuardar = false;
                //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Enabled_btnImprimirSoporte = true;
                LimpiarDatos();

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void gridViewcxc_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {           
            try
            {
                CAInfo = new cxc_cobro_x_Anticipo_Info();
                CAInfo = (cxc_cobro_x_Anticipo_Info)gridViewcxc.GetFocusedRow();
                validarCampos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewcxc_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                calculo();    
                CAInfo = new cxc_cobro_x_Anticipo_Info();
                CAInfo = (cxc_cobro_x_Anticipo_Info)gridViewcxc.GetFocusedRow();
                validarCampos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void setearfechas()
        {
            try
            {
                if (cambiocont == true)
                {
                    List<cxc_cobro_x_Anticipo_Info> lista = cobroAntiBininfo.ToList();

                    int cont = 0;
                    foreach (var item in lista)
                    {
                        cont++;
                        item.contador = cont;
                    }
                    lista.Find(var => var.contador == cont).cr_fechaDocu = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    lista.Find(var => var.contador == cont).cr_fechaCobro = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                    cobroAntiBininfo = new BindingList<cxc_cobro_x_Anticipo_Info>(lista);
                    gridControlcxc.DataSource = cobroAntiBininfo;
                    cambiocont = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void validarCampos()
        {
            try
            {
                if (CAInfo != null)
                {
                    var item = cobroTipoInfoLst.Where(q => q.IdCobro_tipo == CAInfo.IdCobro_tipo).First();

                    if (item.tc_EsCheque == "S")
                    {
                        colIdBanco.OptionsColumn.AllowEdit = true;
                        colcr_cuenta.OptionsColumn.AllowEdit = true;
                        colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                        colcr_fechaDocu.OptionsColumn.AllowEdit = true;
                        colcr_Tarjeta.OptionsColumn.AllowEdit = true;
                        ColIdBancoDeposito.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        if (item.tc_SePuede_Depositar == "S")
                        {
                            ColIdBancoDeposito.OptionsColumn.AllowEdit = true;
                            colIdBanco.OptionsColumn.AllowEdit = false;
                            colcr_cuenta.OptionsColumn.AllowEdit = true;
                            colcr_NumDocumento.OptionsColumn.AllowEdit = true;
                            colcr_fechaDocu.OptionsColumn.AllowEdit = true;
                            colcr_Tarjeta.OptionsColumn.AllowEdit = false;
                        }
                        else
                        {
                            colIdBanco.OptionsColumn.AllowEdit = false;
                            colcr_cuenta.OptionsColumn.AllowEdit = false;
                            colcr_NumDocumento.OptionsColumn.AllowEdit = false;
                            colcr_fechaDocu.OptionsColumn.AllowEdit = false;
                            colcr_Tarjeta.OptionsColumn.AllowEdit = false;
                            ColIdBancoDeposito.OptionsColumn.AllowEdit = false;
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

        private void gridViewcxc_RowCountChanged(object sender, EventArgs e)
        {
            
        }

        private void gridViewcxc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                if (e.Column.Name == "colIco")
                {
                    ConsultarCobro();
                }

                if (e.Column.Name == "colNewTipoCobro")
                {                    
                    frmCxc_cobro_tipo_Mant frm = new frmCxc_cobro_tipo_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                    frm.ShowDialog();                    

                    string IdTipoCobro = frm.IdTipoCobro;
                    if (IdTipoCobro != null)
                    {
                        cxc_Cobro_Tipo_x_Anticipo_Bus busTipAntCob = new cxc_Cobro_Tipo_x_Anticipo_Bus();
                        cxc_Cobro_Tipo_x_Anticipo_Info InfoTipAntCob = new cxc_Cobro_Tipo_x_Anticipo_Info();
                        InfoTipAntCob.IdEmpresa = param.IdEmpresa;
                        InfoTipAntCob.IdCobro_tipo = IdTipoCobro;
                        InfoTipAntCob.posicion = 1;
                        busTipAntCob.GuardarDB(InfoTipAntCob);
                        CargarTipoCobro();
                        gridViewcxc.SetFocusedRowCellValue(colIdCobro_tipo, IdTipoCobro);
                    }                    
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean ConsultarCobro()
        {
            try
            {
                cxc_cobro_x_Anticipo_Info infoA = new cxc_cobro_x_Anticipo_Info();
                infoA = (cxc_cobro_x_Anticipo_Info)gridViewcxc.GetFocusedRow();
                if (infoA == null)
                {
                    return false;
                }
                cxc_cobro_Info infocobro = new cxc_cobro_Info();
                infocobro = cxccBus.Get_Info_Cobro(infoA.IdEmpresa_Cobro, infoA.IdSucursal_cobro, Convert.ToInt32(infoA.IdCobro_cobro));
                frmCxc_CobrosGenerales_Mant frm = new frmCxc_CobrosGenerales_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.Set_info(infocobro);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmClose += new frmCxc_CobrosGenerales_Mant.Delegate_FrmClose(frm_event_FrmClose);
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void frm_event_FrmClose(object sender, FormClosingEventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
