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
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Reportes.Bancos;
using Core.Erp.Winform.CuentasxPagar;
using System.IO;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.Naturisa.Bancos;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Cheques_Mant : Form
    {

        string IdFormaPago = "CHEQUE";

        string Observacion_diario = "";
        string Observacion_cbte_bancario = "";

        decimal i = 1;
        List<tb_ciudad_Info> ListInfoCiudad = new List<tb_ciudad_Info>();
        tb_Ciudad_Bus BusCiudad = new tb_Ciudad_Bus();
        vwtb_persona_beneficiario_Info InfoBeneficiario = new vwtb_persona_beneficiario_Info();

        public FrmBA_Cheques_Mant()
        {

            try
            {
                InitializeComponent();
                event_frmBA_ChequesMantenimiento_FormClosing += FrmBA_Cheques_Mant_event_frmBA_ChequesMantenimiento_FormClosing;

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

        void FrmBA_Cheques_Mant_event_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        #region delegados
        public delegate void delegate_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmBA_ChequesMantenimiento_FormClosing event_frmBA_ChequesMantenimiento_FormClosing;

        #endregion

        #region Declaracion List

        //    List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();


        List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();


        List<cp_orden_pago_cancelaciones_Info> ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
        BindingList<vwba_Banco_Movimiento_det_cancelado_Info> BindingDetalleCaja = new BindingList<vwba_Banco_Movimiento_det_cancelado_Info>();
        BindingList<vwcp_orden_pago_con_cancelacion_Info> Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
        BindingList<vwba_ordenGiroPendientes_Info> BindListOG = new BindingList<vwba_ordenGiroPendientes_Info>();

        #endregion

        #region declaracion BUS

        ba_parametros_Bus BusParamentros = new ba_parametros_Bus();
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        ba_Cbte_Ban_Bus BusBancoDetallado = new ba_Cbte_Ban_Bus();
        ba_Config_Diseno_Cheque_Bus diseno_b = new ba_Config_Diseno_Cheque_Bus();

        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Cbtecble_det_Bus CbteCbleDet_B = new ct_Cbtecble_det_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();

        //tb_ubicacion_Bus ubi_b = new tb_ubicacion_Bus();


        tb_persona_tipo_Bus Persona_Tipo_Bus = new tb_persona_tipo_Bus();

        vwcp_orden_pago_con_cancelacion_Bus orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();
        cp_orden_pago_cancelaciones_Bus BusOrdenPagoCancelacion = new cp_orden_pago_cancelaciones_Bus();
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();

        #endregion

        #region declaracion Info
        ba_Cbte_Ban_Info Info_CbteBan = new ba_Cbte_Ban_Info();


        cp_proveedor_Info InfoProveedor = new cp_proveedor_Info();

        ba_Banco_Cuenta_Info InfoBanco_cta = new ba_Banco_Cuenta_Info();
        ct_Periodo_Info InfoPeriodo = new ct_Periodo_Info();
        ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info InfoParam_Banco = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        vwtb_persona_beneficiario_Info InfoPersona_beneficiario = new vwtb_persona_beneficiario_Info();


        #endregion

        #region declaracion variables

        int IdBanco = 0;
        Boolean El_Diario_Contable_es_modificable;
        private Cl_Enumeradores.eTipo_action _Accion;
        string cheque = "";
        decimal chequeID = 0;
        string MensajeError = "";
        string referencia = "";
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        string motiAnulacion, msg2;
        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;
        decimal IdCbteCbleRev;
        decimal IdProveedor = 0;
        int c = 0;
        string msj;
        FrmBA_Talonario_cheques_x_bancoSeleccionar frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;



        #endregion

        private void BloquearDatos()
        {
            try
            {
                ucBa_TipoFlujo.ReadOnly(true);
                txt_NCheque.ReadOnly = true;
                ucBa_TextBox_Girar_a.Inhabilitar_Beneficiario(true);
                txt_Memo.ReadOnly = true;
                cmbCiudad.EditValue = true;
                dataT_fecha.Enabled = false;
                txtValor.Properties.ReadOnly = true;
                colCheck.OptionsColumn.AllowEdit = false;
                chkPostFechado.Enabled = false;
                ucGe_Beneficiario.Enabled = false;
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

        private void Limpiar()
        {
            try
            {
                ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
                tb_persona_bus busPersona = new tb_persona_bus();
                InfoPeriodo = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);
                dt_fechaCbte.Value = DateTime.Now;
                dataT_fecha.Value = DateTime.Now;
                txt_Ncomprobante.Text = "0";
                txt_Memo.Text = "";
                txtValor.EditValue = 0;
                txt_NCheque.Text = "";
                ucGe_Beneficiario.Enabled = true;
                cmbCiudad.Enabled = true;
                dataT_fecha.Enabled = true;
                chkPostFechado.Enabled = true;
                chkPostFechado.Checked = false;
                txt_NCheque.Enabled = true;
                UCMenu.Visible_bntGuardar_y_Salir = true;
                UCMenu.Visible_btnGuardar = true;
                UC_DiarioContPago.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                ucBa_CuentaBanco.Inicializar_cmbPlanCta();
                ucGe_Beneficiario.Inicializar_Beneficiario();

                _Accion = Cl_Enumeradores.eTipo_action.grabar;

                Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;

                InfoCbteCble = new ct_Cbtecble_Info();
                Info_CbteBan = new ba_Cbte_Ban_Info();

                ucBa_TextBox_Girar_a.Limpiar_Beneficiario();
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

        private void set_accion_controles()
        {
            try
            {

                UCMenu.Enabled_btnGuardar = false;
                UCMenu.Enabled_bntGuardar_y_Salir = false;
                UCMenu.Enabled_bntAnular = false;
                UCMenu.Enabled_btn_Imprimir_Cbte = false;
                UCMenu.Enabled_btn_Imprimir_Cheq = false;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCMenu.Visible_bntImprimir = false;
                        UCMenu.Visible_bntAnular = false;
                        cmbCiudad.Text = BusParamentros.Get_List_parametros(param.IdEmpresa).CiudadDefaultParaCrearCheques;

                        UCMenu.Enabled_btnGuardar = true;
                        UCMenu.Enabled_bntGuardar_y_Salir = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        UCMenu.Visible_btnGuardar = false;
                        UCMenu.Visible_bntAnular = false;
                        UCMenu.Visible_bntLimpiar = false;
                        UCMenu.Enabled_btnGuardar = true;
                        UCMenu.Enabled_bntGuardar_y_Salir = true;
                        UCMenu.Enabled_btn_Imprimir_Cbte = false;
                        UCMenu.Enabled_btn_Imprimir_Cheq = false;

                        set_Info_CbteBan();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        UCMenu.Enabled_bntAnular = true;
                        UCMenu.Enabled_btn_Imprimir_Cbte = false;
                        UCMenu.Enabled_btn_Imprimir_Cheq = false;

                        set_Info_CbteBan();

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        UCMenu.Enabled_btn_Imprimir_Cbte = true;
                        UCMenu.Enabled_btn_Imprimir_Cheq = true;
                        set_Info_CbteBan();
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

        private void frmBA_ChequesMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                ListInfoCiudad = BusCiudad.Get_List_Ciudad("");
                this.cmbCiudad.Properties.DataSource = ListInfoCiudad;
                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                InfoParam_Banco = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "CHEQ"; });
                if (InfoParam_Banco == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    UCMenu.Enabled_btnGuardar = false;
                    UCMenu.Enabled_bntGuardar_y_Salir = false;
                    UCMenu.Enabled_bntAnular = false;
                    this.Close();
                }
                else
                {
                    if (InfoParam_Banco.IdTipoCbteCble <= 0 || InfoParam_Banco.IdTipoCbteCble_Anu <= 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. \nIngréselos desde la pantalla de parámetros de banco, o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;
                        UCMenu.Enabled_bntAnular = false;
                        this.Close();
                    }
                }
                _IdTipoCbte = InfoParam_Banco.IdTipoCbteCble;
                IdTipoCbteRev = InfoParam_Banco.IdTipoCbteCble_Anu;


                set_accion_controles();

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

        void frmBA_ChequesMantenimiento_event_frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        public Boolean Validar()
        {
            try
            {
                Boolean estado = true;

                InfoPeriodo = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (InfoPeriodo == null)
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo no se encuentra ingresado ", "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    estado = false;
                    return estado;
                }

                if (InfoPeriodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = false;
                    return estado;
                }


                if (ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la cuenta Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_NCheque.Text = "";
                    estado = false;
                    return estado;
                }

                string mensaje = "";




                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (Obj_DetalleAprob.Where(q => q.Check == true).Count() == 0)
                    {
                        if (MessageBox.Show("No ha seleccionado ordenes de pago para aplicar a este cheque.... desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            estado = false;
                            return estado;
                        }
                    }

                    if (txt_NCheque.Text.Trim().Length == 0)
                    {
                        if (MessageBox.Show("Número de Cheque en blanco...Esta seguro de guardar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {

                            if (this.txt_NCheque.Text != "")
                            {
                                if (CbteBan_B.VericarChequeExiste(this.txt_NCheque.Text, param.IdEmpresa, Convert.ToDecimal(txt_Ncomprobante.Text), Convert.ToInt32(_IdTipoCbte), ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco, ref mensaje) == true)
                                {
                                    MessageBox.Show("Por favor cambie el numero de cheque: " + txt_NCheque.Text + ", porque ya fue girado a: " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    estado = false;
                                    return estado;
                                }
                            }


                            estado = true;
                        }
                        else
                        {
                            estado = false;
                        }
                        return estado;
                    }




                }

                if (ucBa_TextBox_Girar_a.valida() == "")
                {
                    MessageBox.Show("Por favor Ingrese Beneficiaro del cheque...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = false;
                    return estado;
                }

                if (Convert.ToDouble(txtValor.EditValue) <= 0)
                {
                    MessageBox.Show("Por favor Ingrese el Valor del Cheque...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = false;
                    return estado;
                }

                if (this.cmbCiudad.EditValue == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Ciudad", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estado = false;
                    return estado;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    double suma = 0;
                    if (suma > Convert.ToDouble(txtValor.EditValue))
                    {
                        MessageBox.Show("No se Procedio Actualizar, porque la sumatoria de las ordenes de giro aplicadas es de " + suma + ", y supera el valor del cheque...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        estado = false;
                        return estado;
                    }


                    
                }

                // no validar para cuando anule el cheque pues sale con la fecha de hoy y el diaria a hoy
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                        return false;
                }

                
                

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

        private void txt_NCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
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

        #region fx get y set

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCMenu.Enabled_bntAnular = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        cmbCiudad.Enabled = false;
                        dataT_fecha.Enabled = false;
                        txtValor.Enabled = false;
                        txt_NCheque.Enabled = false;
                        // txt_giracheque.Enabled = false;
                        ucBa_TextBox_Girar_a.Inhabilitar_Beneficiario(true);
                        colCheck.OptionsColumn.AllowEdit = false;
                        chkPostFechado.Enabled = false;
                        ucGe_Beneficiario.Enabled = false;
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        BloquearDatos();
                        UCMenu.Enabled_btnGuardar = false;
                        UCMenu.Enabled_bntGuardar_y_Salir = false;
                        UCMenu.Enabled_bntLimpiar = false;
                        UCMenu.Enabled_bntAnular = false;
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




        public void set_Info_CbteBan(ba_Cbte_Ban_Info _infoP)
        {
            try
            {
                Info_CbteBan = _infoP;
            }
            catch (Exception ex)
            {

            }

        }

        private void set_Info_CbteBan()
        {
            try
            {


                Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();

                BindingDetalleCaja = new BindingList<vwba_Banco_Movimiento_det_cancelado_Info>
                (BusBancoDetallado.Get_List_Cancelada(param.IdEmpresa, Info_CbteBan.IdCbteCble, Info_CbteBan.IdTipocbte, ref MensajeError));

                this.gridAprobacionOrdenPago.DataSource = BindingDetalleCaja;
                this.txt_Ncomprobante.Text = Info_CbteBan.IdCbteCble.ToString();

                dt_fechaCbte.Value = Info_CbteBan.cb_Fecha;
                ucBa_CuentaBanco.set_BaCuentaInfo(Info_CbteBan.IdBanco);
                ucGe_Beneficiario.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PROVEE, Convert.ToDecimal(Info_CbteBan.IdProveedor));

                this.txt_NCheque.Text = Info_CbteBan.cb_Cheque;
                this.ucBa_TextBox_Girar_a.set_NomBeneficiario(Info_CbteBan.cb_giradoA, Convert.ToDecimal(Info_CbteBan.IdPersona_Girado_a));
                this.txt_Memo.Text = Info_CbteBan.cb_Observacion;
                this.txtValor.EditValue = Convert.ToDouble(Info_CbteBan.cb_Valor);
                Funciones fun = new Funciones();
                Info_CbteBan.ValorEnLetras = fun.NumeroALetras(Convert.ToString(txtValor.EditValue));
                this.cmbCiudad.EditValue = Info_CbteBan.cb_ciudadChq;

                this.dataT_fecha.Value = (DateTime)Info_CbteBan.cb_FechaCheque;

                ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(Info_CbteBan.IdTipoFlujo));

                if (Info_CbteBan.PosFechado == "S")
                    this.chkPostFechado.Checked = true;
                else
                    this.chkPostFechado.Checked = false;
                lblCbt_TipoAnulacion.Visible = (Info_CbteBan.Estado == "I") ? true : false;
                lblCbt_TipoAnulacion.Text = "**ANULADO**   Cbt.Cble. de Anu.: " + Info_CbteBan.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + Info_CbteBan.IdTipoCbte_Anulacion.ToString();
                UC_DiarioContPago.setInfo(Info_CbteBan.IdEmpresa, Info_CbteBan.IdTipocbte, Info_CbteBan.IdCbteCble);
                UC_DiarioContPago.HabilitarGrid(false);
                Info_CbteBan = Info_CbteBan;
                InfoCbteCble = UC_DiarioContPago.Get_Info_CbteCble();
                ba_Banco_Cuenta_Info ctaBco = ctaBco = ucBa_CuentaBanco.get_BaCuentaInfo();



                UCSucursal.set_SucursalInfo(Info_CbteBan.IdSucursal);

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

        void GetDetalle_Grid()
        {
            try
            {
                int contador = 1;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
                    foreach (var item in Obj_DetalleAprob)
                    {
                        if (item.Check == true)
                        {
                            cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                            // Orden de cancelación
                            info_ordenCan.IdEmpresa = param.IdEmpresa;
                            info_ordenCan.IdEmpresa_op = item.IdEmpresa;
                            info_ordenCan.IdOrdenPago_op = item.IdOrdenPago;
                            info_ordenCan.Secuencia_op = item.Secuencia_OP;
                            info_ordenCan.IdEmpresa_op_padre = null;
                            info_ordenCan.IdOrdenPago_op_padre = null;
                            info_ordenCan.Secuencia_op_padre = null;
                            info_ordenCan.IdEmpresa_cxp = item.IdEmpresa_cxp;
                            info_ordenCan.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                            info_ordenCan.IdCbteCble_cxp = item.IdCbteCble_cxp;
                            info_ordenCan.IdEmpresa_pago = param.IdEmpresa;
                            info_ordenCan.IdTipoCbte_pago = InfoCbteCble.IdTipoCbte;
                            info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                            info_ordenCan.MontoAplicado = item.Valor_estimado_a_pagar_OP;
                            info_ordenCan.SaldoAnterior = 0;
                            info_ordenCan.SaldoActual = 0;
                            info_ordenCan.Observacion = txt_Memo.Text;

                            ListOrdenPagoCancelacion.Add(info_ordenCan);

                            contador = contador + 1;
                        }
                    }
                }
                else
                {
                    ListOrdenPagoCancelacion = new List<cp_orden_pago_cancelaciones_Info>();
                    foreach (var item in BindingDetalleCaja)
                    {
                        cp_orden_pago_cancelaciones_Info info_ordenCan = new cp_orden_pago_cancelaciones_Info();
                        // Orden de cancelación
                        info_ordenCan.IdEmpresa = param.IdEmpresa;
                        info_ordenCan.IdEmpresa_op = item.IdEmpresa;
                        info_ordenCan.IdOrdenPago_op = item.IdOrdenPago;
                        info_ordenCan.Secuencia_op = item.Secuencia_OP;
                        info_ordenCan.IdEmpresa_op_padre = null;
                        info_ordenCan.IdOrdenPago_op_padre = null;
                        info_ordenCan.Secuencia_op_padre = null;
                        info_ordenCan.IdEmpresa_cxp = item.IdEmpresa_cxp;
                        info_ordenCan.IdTipoCbte_cxp = item.IdTipoCbte_cxp;
                        info_ordenCan.IdCbteCble_cxp = item.IdCbteCble_cxp;
                        info_ordenCan.IdEmpresa_pago = param.IdEmpresa;
                        info_ordenCan.IdTipoCbte_pago = _IdTipoCbte;
                        info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                        info_ordenCan.MontoAplicado = item.Valor_estimado_a_pagar_OP;
                        info_ordenCan.SaldoAnterior = 0;
                        info_ordenCan.SaldoActual = 0;
                        info_ordenCan.Observacion = txt_Memo.Text;
                        info_ordenCan.Idcancelacion = item.Idcancelacion;
                        info_ordenCan.Secuencia = item.Secuencia;
                        ListOrdenPagoCancelacion.Add(info_ordenCan);

                        contador = contador + 1;
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

        public ba_Cbte_Ban_Info get_CbteBan()
        {
            try
            {

                Info_CbteBan.IdEmpresa = param.IdEmpresa;
                Info_CbteBan.IdTipocbte = _IdTipoCbte;
                Info_CbteBan.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                Info_CbteBan.Cod_Cbtecble = (Info_CbteBan.Cod_Cbtecble == "" || Info_CbteBan.Cod_Cbtecble == null || Info_CbteBan.Cod_Cbtecble == "0") ? cod_CbteCble : Info_CbteBan.Cod_Cbtecble;
                Info_CbteBan.IdPeriodo = InfoPeriodo.IdPeriodo;
                Info_CbteBan.cb_giradoA = ucBa_TextBox_Girar_a.get_NomBeneficiario();
                Info_CbteBan.IdPersona_Girado_a = ucBa_TextBox_Girar_a.Get_Id_Persona();
                if (IdBanco == 0)
                    Info_CbteBan.IdBanco = ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                else
                    Info_CbteBan.IdBanco = IdBanco;
                Info_CbteBan.cb_Fecha = dt_fechaCbte.Value;
                Info_CbteBan.cb_Observacion = txt_Memo.Text;
                Info_CbteBan.cb_secuencia = (Info_CbteBan.cb_secuencia == 0 || Info_CbteBan.cb_secuencia == null) ? 0 : Info_CbteBan.cb_secuencia;
                Info_CbteBan.cb_Valor = Convert.ToDouble(txtValor.EditValue);

                Funciones fun = new Funciones();
                Info_CbteBan.ValorEnLetras = fun.NumeroALetras(Convert.ToString(txtValor.EditValue));
                Info_CbteBan.cb_Cheque = txt_NCheque.Text;
                Info_CbteBan.cb_ChequeImpreso = "N";
                Info_CbteBan.IdProveedor = IdProveedor;
                Info_CbteBan.Estado = (lblCbt_TipoAnulacion.Visible == false) ? "A" : "I";

                Info_CbteBan.cb_ciudadChq = cmbCiudad.EditValue.ToString();
                Info_CbteBan.cb_FechaCheque = dataT_fecha.Value;
                Info_CbteBan.IdUsuario = param.IdUsuario;
                Info_CbteBan.IdUsuario_Anu = param.IdUsuario;
                Info_CbteBan.FechaAnulacion = param.Fecha_Transac;
                Info_CbteBan.Fecha_Transac = param.Fecha_Transac;
                Info_CbteBan.Fecha_UltMod = param.Fecha_Transac;
                Info_CbteBan.IdUsuarioUltMod = param.IdUsuario;
                Info_CbteBan.ip = param.ip;
                Info_CbteBan.nom_pc = param.nom_pc;
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    Info_CbteBan.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }
                Info_CbteBan.Por_Anticipo = "N";
                Info_CbteBan.PosFechado = (chkPostFechado.Checked) ? "S" : "N";
                Info_CbteBan.IdSucursal = UCSucursal.Get_IdSucursal();

                return Info_CbteBan;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
            }
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                InfoCbteCble.IdEmpresa = param.IdEmpresa;
                InfoCbteCble.IdTipoCbte = _IdTipoCbte;
                InfoCbteCble.IdPeriodo = InfoPeriodo.IdPeriodo;
                InfoCbteCble.cb_Fecha = dt_fechaCbte.Value;
                InfoCbteCble.cb_Valor = Convert.ToDouble(this.txtValor.EditValue);
                InfoCbteCble.cb_Observacion = "Cheque #:" + txt_NCheque.Text.Trim() + " Girado a:" + ucBa_TextBox_Girar_a.get_NomBeneficiario() +" "+ txt_Memo.Text;
                InfoCbteCble.Secuencia = 0;
                InfoCbteCble.Estado = "A";
                InfoCbteCble.Anio = dt_fechaCbte.Value.Year;
                InfoCbteCble.Mes = dt_fechaCbte.Value.Month;
                InfoCbteCble.IdUsuario = param.IdUsuario;
                InfoCbteCble.IdUsuarioUltModi = param.IdUsuario;
                InfoCbteCble.cb_FechaTransac = param.Fecha_Transac;
                InfoCbteCble.cb_FechaUltModi = param.Fecha_Transac;
                InfoCbteCble.Mayorizado = "N";
                InfoCbteCble.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                InfoCbteCble._cbteCble_det_lista_info = UC_DiarioContPago.Get_Info_CbteCble()._cbteCble_det_lista_info;

                return InfoCbteCble;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {

            try
            {
                double valor;
                _ListaCbteCbleDet.Clear();



                return _ListaCbteCbleDet;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        #endregion

        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;
                txt_Memo.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Actualizar();
                        break;

                    default:
                        break;
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

        private Boolean Grabar()
        {
            try
            {
                Boolean respuesta = true;
                if (Validar())
                {
                    get_Cbtecble();
                    txt_Memo.Focus();
                    string msg = "";
                    if (ucBa_CuentaBanco.get_BaCuentaInfo().Estado == "A")
                    {
                       // if (ucGe_Beneficiario.Get_Persona_beneficiario_Info().Estado == "A")
                       // {
                            //grbado el diario 
                            respuesta = CbteCble_B.GrabarDB(InfoCbteCble, ref idCbteCble, ref msg);
                            if (respuesta)
                            {
                                txt_Ncomprobante.Text = idCbteCble.ToString();
                                int idEmpresa = param.IdEmpresa;
                                string mesg2 = "";
                                GetDetalle_Grid();

                                get_CbteBan();

                                //gradando el cbte bancario 
                                respuesta = CbteBan_B.GrabarDB(Info_CbteBan, ref MensajeError);
                                if (respuesta)
                                {

                                    respuesta = BusOrdenPagoCancelacion.GuardarDB(ListOrdenPagoCancelacion, idEmpresa, ref mesg2);

                                    //txt_Memo.Text = Info_CbteBan.cb_Observacion;

                                    if (txt_NCheque.Text.Trim().Length != 0)
                                    {
                                        ba_Talonario_cheques_x_banco_Bus busTalChe = new ba_Talonario_cheques_x_banco_Bus();
                                        busTalChe.Usar(Info_CbteBan, txt_NCheque.Text, ref mesg2);
                                    }

                                    MessageBox.Show("Se Guardo el Cheque # : " + txt_NCheque.Text + " correctamente con el Comprobante contable #: " + txt_Ncomprobante.Text);

                                    Impresion_Cheque();

                                }
                                else
                                {

                                    CbteCble_B.Eliminar(InfoCbteCble, ref msg);
                                    MessageBox.Show("No se pudo Grabar el Cheque " + txt_NCheque.Text + " de Banco " + MensajeError, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    respuesta = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Grabar el Cheque " + txt_NCheque.Text + ",de Banco " + msg, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                respuesta = false;
                            }
                       // }
                        /*else
                        {
                            MessageBox.Show("El proveedor seleccionado esta anulado.\nSeleccione un proveedor activo para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }*/
                    }
                    else
                    {
                        MessageBox.Show("La cuenta bancaria seleccionada esta anulada.\nSeleccione una cuenta bancaria activa para continuar", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    return respuesta;
                }
                else
                    return false;
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

        private void Impresion_Cheque()
        {
            try
            {
                if (MessageBox.Show("¿Desea Imprimir el Cheque?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InfoBanco_cta = ucBa_CuentaBanco.get_BaCuentaInfo();
                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                            if (MessageBox.Show("¿Desea Imprimir cheque voucher [SI] ó solo cheque [NO]?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                InfoBanco_cta.Imprimir_Solo_el_cheque = false;
                            else
                                InfoBanco_cta.Imprimir_Solo_el_cheque = true;
                            break;
                    }

                    if (InfoBanco_cta.Imprimir_Solo_el_cheque == true)
                        Imprimir_Comprobante_Bancario();

                    FrmBA_Cheque_Imprimir frm = new FrmBA_Cheque_Imprimir();
                    Info_CbteBan.cb_Cheque = txt_NCheque.Text;
                    frm.set_Banco_Cuenta(InfoBanco_cta);
                    frm.set_CbteBan_I(Info_CbteBan);
                    frm.set_CbteCble(InfoCbteCble);
                    frm.ShowDialog();
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

        private Boolean Actualizar()
        {

            try
            {

                Boolean respuesta = true;

                if (Validar())
                {


                    get_Cbtecble();
                    txt_Memo.Focus();

                    idCbteCble = Info_CbteBan.IdCbteCble;
                    get_CbteBan();

                    respuesta = CbteBan_B.ModificarDB(Info_CbteBan, ref MensajeError);
                    if (respuesta)
                    {

                        MessageBox.Show("Se Modifico el Cheque #: " + txt_NCheque.Text + " correctamente con el Comprobante contable #: " + txt_Ncomprobante.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Modificar el comprobante # " + this.txt_Ncomprobante.Text + " ( " + MensajeError + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        respuesta = false;
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

        private Boolean Anular()
        {

            try
            {
                Boolean respuesta = true;
                string msg = "";


                if (Validar())
                {


                    get_Cbtecble();
                    txt_Memo.Focus();

                    idCbteCble = Info_CbteBan.IdCbteCble;
                    get_CbteBan();

                    respuesta = CbteBan_B.ModificarDB(Info_CbteBan, ref MensajeError);


                    idCbteCble = Info_CbteBan.IdCbteCble;
                    if (MessageBox.Show("¿Está seguro que desea anular Comprobante bancario #: " + Info_CbteBan.IdCbteCble + ", \n También se procederá con la liberación de los pagos de las órdenes de giro seleccionadas", "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motiAnulacion = fr.motivoAnulacion;

                        if (UC_DiarioContPago.Reverso(IdTipoCbteRev, ref IdCbteCbleRev, ref msg, motiAnulacion))
                        {
                            Info_CbteBan.MotivoAnulacion = motiAnulacion;
                            Info_CbteBan.IdUsuario_Anu = param.IdUsuario;
                            Info_CbteBan.FechaAnulacion = param.Fecha_Transac;
                            Info_CbteBan.IdTipoCbte_Anulacion = IdTipoCbteRev;
                            Info_CbteBan.IdCbteCble_Anulacion = IdCbteCbleRev;

                            if (CbteBan_B.AnularDB(Info_CbteBan, ref MensajeError))
                            {
                                GetDetalle_Grid();
                                if (BusOrdenPagoCancelacion.ModificarDB(ListOrdenPagoCancelacion))
                                {

                                    MessageBox.Show("Comprobante bancario #: " + Info_CbteBan.IdCbteCble + " Anulado correctamente, Con el Tipo de Comprobante de Anulacion #" + IdTipoCbteRev + " y el Comprobante de Anulacion #: " + IdCbteCbleRev);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo Eliminar los pagos relacionados a esta Comprobante bancario...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    respuesta = false;
                                }


                                lblCbt_TipoAnulacion.Visible = true;
                                lblCbt_TipoAnulacion.Text = "**ANULADO**   Cbt.Cble. de Anu.: " + IdCbteCbleRev.ToString() + " Tipo Cbt.Cble de Anu.: " + IdTipoCbteRev.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo Anular el Comprobante bancario " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                respuesta = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se pudo Reversar el Comprobante ( " + msg + " )", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            respuesta = false;
                        }


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

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    Limpiar();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;

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

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                e.Handled = f.Validanumero_decimal(e.KeyChar, e.KeyChar.ToString());
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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_CbteBan.IdCbteCble > 0)
                {
                    if (Info_CbteBan.Estado == "I")
                    {
                        MessageBox.Show("El Comprobante bancario #: " + Info_CbteBan.IdCbteCble + " ya esta anulado", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.Anular;
                        Anular();

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

        private void dt_fechaCbte_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataT_fecha.Value = dt_fechaCbte.Value;//dt_fechaCbte.Value.AddDays(1);

                InfoPeriodo = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

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

        private void btn_imprimirChe_Click(object sender, EventArgs e)
        {
            try
            {
                if (Info_CbteBan.IdCbteCble > 0)
                {
                    FrmBA_Cheque_Imprimir frm = new FrmBA_Cheque_Imprimir();
                    frm.set_Banco_Cuenta(InfoBanco_cta);
                    frm.set_CbteBan_I(Info_CbteBan);
                    frm.set_CbteCble(InfoCbteCble);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Antes de continuar debe Grabar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txt_NCheque_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NCheque.Text = "";
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

        private void btn_grabarysalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    Close();
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

        private void frmBA_ChequesMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.event_frmBA_ChequesMantenimiento_FormClosing(sender, e);
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

        private void ultraCmbCtaBanco_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario(); // haber -- el deber es el de la grilla la cta cte
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

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetFocusedRow();

                if (row != null)
                    if (e.HitInfo.Column != null)
                        if (e.HitInfo.Column.FieldName == "Check")
                        {
                            if (row.Check == true)
                            {
                                gridViewOP_Pendientes.SetFocusedRowCellValue(colCheck, false);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Valor_a_Cancelar_OPGrid, 0);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Saldo_x_Pagar_OP, row.Saldo_x_Pagar2);
                               
                            }
                            else
                            {
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Valor_a_Cancelar_OPGrid, row.Saldo_x_Pagar_OP);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(Saldo_x_Pagar_OP, 0);
                                gridViewOP_Pendientes.SetFocusedRowCellValue(colCheck, true);
                                ucBa_CuentaBanco.set_BaCuentaInfo(row.IdBanco == null ? 0 : Convert.ToInt32(row.IdBanco));

                            }
                            txt_Ncomprobante.Focus();
                            var a = Obj_DetalleAprob.ToList();
                            double valort = 0;

                            var q = a.LastOrDefault(var => var.Check == true);

                            if (q != null)
                            {
                                valort = a.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);
                                txtValor.EditValue = Convert.ToDouble(valort);

                                cheque = a.Last(var => var.Check == true).Girar_Cheque_a;
                                chequeID = a.FirstOrDefault(var => var.Check == true).IdPersona;
                                referencia = a.Last(var => var.Check == true).Referencia;
                                decimal idpersonaGira = chequeID;
                                string beneficiario = cheque;
                                ucBa_TextBox_Girar_a.set_NomBeneficiario(beneficiario, idpersonaGira);
                            }
                        }
                generaDiario();
                Armar_observaciones();
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

        private void generaDiario()
        {
            try
            {

                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                string referencs = "";

                foreach (var item in Obj_DetalleAprob)
                {
                    if (item.Check == true)
                    {
                        ct_Cbtecble_det_Info InfoDebe = new ct_Cbtecble_det_Info();
                        InfoDebe.IdEmpresa = param.IdEmpresa;
                        InfoDebe.IdTipoCbte = _IdTipoCbte;
                        InfoDebe.IdCtaCble = item.IdCtaCble;
                        InfoDebe.dc_Valor = Convert.ToDouble(item.Valor_aplicado);
                        InfoDebe.dc_Observacion = "";
                        referencs = referencs + " " + item.Referencia.Trim();
                        _ListaCbteCbleDet.Add(InfoDebe);
                    }
                }
                ba_Banco_Cuenta_Info InfoCuentaBancos = ucBa_CuentaBanco.get_BaCuentaInfo();

                // la cuenta de bancos siempre va al haber porq sale la plata de bancos con cheque 
                ct_Cbtecble_det_Info InfoHaber = new ct_Cbtecble_det_Info();
                InfoHaber.IdEmpresa = param.IdEmpresa;
                InfoHaber.IdTipoCbte = _IdTipoCbte;

                if (InfoCuentaBancos != null)
                {
                    InfoHaber.IdCtaCble = InfoCuentaBancos.IdCtaCble;
                }

                InfoHaber.dc_Valor = Convert.ToDouble(txtValor.EditValue) * -1;
                InfoHaber.dc_para_conciliar = true;

                InfoHaber.dc_Observacion = "";
                _ListaCbteCbleDet.Add(InfoHaber);

                // la comtrapartida siempre a debe 
                UC_DiarioContPago.setDetalle(_ListaCbteCbleDet);

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

        private void dataT_fecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataT_fecha.Value > dt_fechaCbte.Value)
                {
                    chkPostFechado.Checked = true;
                }
                else
                {
                    chkPostFechado.Checked = false;
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

        private void btnSeleccionarChequeTalonario_Click(object sender, EventArgs e)
        {
            try
            {
                ba_Banco_Cuenta_Info InfoBanco = ucBa_CuentaBanco.get_BaCuentaInfo();
                if (InfoBanco.IdBanco != null)
                {
                    int idBanco = InfoBanco.IdBanco;
                    frm = new FrmBA_Talonario_cheques_x_bancoSeleccionar(idBanco);
                    frm.ShowDialog();
                    txt_NCheque.Text = frm.num_cheque;
                }
                else
                {
                    MessageBox.Show("Favor seleccionar un Banco antes de proceder", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_Load(object sender, EventArgs e)
        {
        }

        private void txt_NCheque_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprimir_Comprobante_Bancario()
        {
            try
            {
                if (MessageBox.Show("¿Desea Imprimir el Comprobante?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InfoBanco_cta = ucBa_CuentaBanco.get_BaCuentaInfo();

                    XBAN_Rpt018_Rpt reporte = new XBAN_Rpt018_Rpt();
                    //XBAN_Rpt018_Bus BusReporte = new XBAN_Rpt018_Bus();

                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                            XBAN_NAT_Rpt001_Rpt Reporte_nat = new XBAN_NAT_Rpt001_Rpt();
                            Reporte_nat.RequestParameters = false;
                            ReportPrintTool natu = new ReportPrintTool(Reporte_nat);
                            natu.AutoShowParametersPanel = false;
                            Reporte_nat.Parameters["PIdEmpresa"].Value = Info_CbteBan.IdEmpresa;
                            Reporte_nat.Parameters["PIdTipoCbte"].Value = Info_CbteBan.IdTipocbte;
                            Reporte_nat.Parameters["PIdCbteCble"].Value = Info_CbteBan.IdCbteCble;
                            Reporte_nat.Parameters["PNombreReporte"].Value = "COMPROBANTE DE CHEQUE";
                            Reporte_nat.ShowPreview();
                            break;
                        default:
                            reporte.RequestParameters = false;
                            ReportPrintTool pt = new ReportPrintTool(reporte);
                            pt.AutoShowParametersPanel = false;
                            reporte.PIdEmpresa.Value = Info_CbteBan.IdEmpresa;
                            reporte.PIdCbteCble.Value = Info_CbteBan.IdCbteCble;
                            reporte.PIdTipo_Cbte.Value = Info_CbteBan.IdTipocbte;
                            reporte.ShowPreview();
                            break;
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

        private void UCMenu_event_btn_Imprimir_Cbte_Click(object sender, EventArgs e)
        {
            Imprimir_Comprobante_Bancario();
        }

        private void UCMenu_event_btn_Imprimir_Cheq_Click(object sender, EventArgs e)
        {
            Impresion_Cheque();
        }

        private void ucGe_Beneficiario_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoBeneficiario = ucGe_Beneficiario.Get_Persona_beneficiario_Info();

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    vwcp_orden_pago_con_cancelacion_Info Info_Pago = new vwcp_orden_pago_con_cancelacion_Info();
                    orden_pago_con_cancelacion_Bus = new vwcp_orden_pago_con_cancelacion_Bus();

                    List<vwcp_orden_pago_con_cancelacion_Info> list = new List<vwcp_orden_pago_con_cancelacion_Info>();

                    string beneficiario = InfoBeneficiario.IdBeneficiario;

                    if (String.IsNullOrEmpty(beneficiario))
                    {
                        Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                        this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                    }
                    else
                    {
                        list = orden_pago_con_cancelacion_Bus.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago(param.IdEmpresa
                            , InfoBeneficiario.IdTipo_Persona, InfoBeneficiario.IdPersona
                            , InfoBeneficiario.IdEntidad, "APRO");
                        if (list.Count != 0)
                        {
                            Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(list);
                            this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
                            frmCP_Alerta_Anticipos_x_NotasCreditos ofrm = new frmCP_Alerta_Anticipos_x_NotasCreditos();
                            ofrm.IdEmpresa = param.IdEmpresa;
                            ofrm.IProveedor = Convert.ToDecimal(InfoBeneficiario.IdEntidad);
                            ofrm.carga_Grid();

                            if (ofrm.lista_AnticipoSaldo.Count != 0)
                            {
                                ofrm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existen OP para " + InfoPersona_beneficiario.NombreCompleto, "Sistemas");
                            Obj_DetalleAprob = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                            this.gridAprobacionOrdenPago.DataSource = Obj_DetalleAprob;
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

        private void ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoBanco_cta = ucBa_CuentaBanco.get_BaCuentaInfo();

                UC_DiarioContPago.IdCtaCble_x_Banco = InfoBanco_cta.IdCtaCble;

                string msg = "";

                ba_Talonario_cheques_x_banco_Bus busTalChe = new ba_Talonario_cheques_x_banco_Bus();
                ba_Talonario_cheques_x_banco_Info InfoCheq = new ba_Talonario_cheques_x_banco_Info();
                if (InfoBanco_cta != null)
                {
                    InfoCheq = busTalChe.Get_Info_Ultimo_cheq_no_usuado(param.IdEmpresa, InfoBanco_cta.IdBanco, ref msg);
                    if (InfoCheq.Num_cheque == null)
                    {
                        txt_NCheque.Text = "";
                        MessageBox.Show("Talonario no tiene cheques, favor no olvide ingresarlos en el modulo de talonarios, puede continuar", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        txt_NCheque.MaxLength = InfoCheq.Num_cheque.Length;
                        txt_NCheque.Text = InfoCheq.Num_cheque;
                    }
                }
                IdBanco = InfoBanco_cta.IdBanco;

                generaDiario();
                Armar_observaciones();
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

        private void ucBa_TextBox_Girar_a_Load(object sender, EventArgs e)
        {

        }

        private void chk_Seleccionar_visibles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Check_visibles();
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

        private void Check_visibles()
        {
            try
            {
                if (chk_Seleccionar_visibles.Checked)
                {
                    for (int i = 0; i < gridViewOP_Pendientes.RowCount; i++)
                    {
                        vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetRow(i);
                        if (row != null)
                        {
                            if (!row.Check)
                            {
                                gridViewOP_Pendientes.SetRowCellValue(i, colCheck, true);
                                gridViewOP_Pendientes.SetRowCellValue(i, Valor_a_Cancelar_OPGrid, row.Saldo_x_Pagar_OP);
                                gridViewOP_Pendientes.SetRowCellValue(i, Saldo_x_Pagar_OP, 0);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < gridViewOP_Pendientes.RowCount; i++)
                    {
                        vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetRow(i);
                        if (row != null)
                        {
                            if (row.Check)
                            {
                                gridViewOP_Pendientes.SetRowCellValue(i, colCheck, false);
                                gridViewOP_Pendientes.SetRowCellValue(i, Valor_a_Cancelar_OPGrid, 0);
                                gridViewOP_Pendientes.SetRowCellValue(i, Saldo_x_Pagar_OP, row.Saldo_x_Pagar2);
                                
                            }
                        }
                    }
                }

                txt_Ncomprobante.Focus();
                var a = Obj_DetalleAprob.ToList();
                double valort = 0;

                var q = a.LastOrDefault(var => var.Check == true);

                if (q != null)
                {
                    valort = a.FindAll(var => var.Check == true).Sum(var => var.Valor_aplicado);
                    txtValor.EditValue = Convert.ToDouble(valort);

                    cheque = a.Last(var => var.Check == true).Nom_Beneficiario;
                    chequeID = a.FirstOrDefault(var => var.Check == true).IdPersona;
                    referencia = a.Last(var => var.Check == true).Referencia;
                    decimal idpersonaGira = chequeID;
                    string beneficiario = cheque;
                    ucBa_TextBox_Girar_a.set_NomBeneficiario(beneficiario, idpersonaGira);
                }

                generaDiario();
                Armar_observaciones();
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

        private void Armar_observaciones()
        {
            try
            {
                Observacion_diario = "";//"Cheque #:" + txt_NCheque.Text.Trim() + " Girado a:" + ucBa_TextBox_Girar_a.get_NomBeneficiario() + " Canc./ ";
                Observacion_cbte_bancario = "Canc./ ";

                foreach (var item in Obj_DetalleAprob.Where(q => q.Check == true).ToList())
                {
                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                            if (item.Referencia.Substring(0, 2) == "OP")
                            {
                                Observacion_diario += item.Referencia2 + " (" + item.Observacion + ") /";
                                Observacion_cbte_bancario += item.Referencia2 + " (" + item.Observacion + ") /";
                            }
                            else
                            {
                                Observacion_diario += item.Referencia2 + "/";
                                Observacion_cbte_bancario += item.Referencia2 + "/";
                            }
                            break;
                        default:
                            Observacion_diario += item.Referencia2 + "/";
                            Observacion_cbte_bancario += item.Referencia2 + "/";
                            break;
                    }
                }
                txt_Memo.Text = Observacion_cbte_bancario;
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
    }
}
