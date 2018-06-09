using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Reportes.Bancos;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_DepositoBancario_Mant : Form
    {
        public delegate void delegate_FrmBA_DepositoBancario_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_DepositoBancario_FormClosing event_FrmBA_DepositoBancario_FormClosing;

        #region Declaración de variables

        string msj;
        int IdTipoCbte_OP = 0;
        double sumaIng = 0;
        double sumaEgr = 0;
        double suma = 0;
        decimal sumaCxC = 0;
        string motiAnulacion, msg2;
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        string ctaCble_acreedoraDeposito = "";

        int _IdTipoCbte = 0;
        int IdTipoCbteRev = 0;
        
        decimal IdCbteCbleRev;
        string MensajeError = "";


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        cxc_cobro_tipo_Param_conta_x_sucursal_Bus cobroTipo_B = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();



        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();

        cxc_cobro_Bus cxc_B = new cxc_cobro_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();

        List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> ListParam_cobroTipo = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();


        List<cxc_cobro_Info> ListaSumatoria = new List<cxc_cobro_Info>();
        List<cxc_cobro_Info> ListaSumGroupXtipoCobro = new List<cxc_cobro_Info>();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ba_Cbte_Ban_Info CbteBan_I = new ba_Cbte_Ban_Info();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        List<ct_Cbtecble_det_Info> ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
        BindingList<cxc_cobro_Info> Binding_DataSource = new BindingList<cxc_cobro_Info>();
        List<cxc_cobro_Info> lista = new List<cxc_cobro_Info>();
        List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> LstIngrEgrexDepo = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
        List<cxc_cobro_Info> list = new List<cxc_cobro_Info>();


        

        
        public ba_Cbte_Ban_Info Info_CbteBan { get; set; }
        

        
        ba_Banco_Cuenta_Info _b = new ba_Banco_Cuenta_Info();



        private Cl_Enumeradores.eTipo_action _Accion;
        
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();

        
        
        

        Boolean El_Diario_Contable_es_modificable;

        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus CajMoviDepo = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();
        List<ba_Banco_Cuenta_Info> list_CtaBanco = new List<ba_Banco_Cuenta_Info>();
        cxc_cobro_Info InfoCobro = new cxc_cobro_Info();

        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus bus_cobro_x_deposito = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();

        #endregion

        public FrmBA_DepositoBancario_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;


               
                //load_grid();         
                ListParam_cobroTipo = cobroTipo_B.Get_List_cobro_tipo_Param_conta_x_sucursal(param.IdEmpresa);
                //Usu_B.Validar_PermisoModificacionCbteCble(param.IdUsuario, "MODIFDIARIO_BAN", ref msj, ref El_Diario_Contable_es_modificable);
                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "DEPO"; });



                if (paramBa_I == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Visible_btnGuardar = false;
                    this.Close();
                }
                else
                {
                    if (paramBa_I.IdTipoCbteCble <= 0 || paramBa_I.IdTipoCbteCble_Anu <= 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco IdTipoCbteCble o IdTipoCbteCble_Anu.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        this.Close();
                    }
                    else
                    {
                        _IdTipoCbte = paramBa_I.IdTipoCbteCble;
                        IdTipoCbteRev = paramBa_I.IdTipoCbteCble_Anu;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if(Accion_grabar())
                    Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_grabar())
                {
                    Limpiar();
                    set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                    set_Accion_x_controles();

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbteBan_I.Estado == "I")
                {
                    MessageBox.Show("El Comprobante bancario #: " + CbteBan_I.IdCbteCble + " ya está Anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (txt_Ncomprobante.Text != "0" || txt_Ncomprobante.Text != "")
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.Anular;
                        Anular();
                    }
                    else
                        MessageBox.Show("No tiene Comprobante de Depósito para poder proceder con la Anulación ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void FrmBA_DepositoBancario_Load(object sender, EventArgs e)
        {
            try
            {

                if (_Accion == 0)
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }

                set_Accion_x_controles();
                cmb_TipoMovCaj.SelectedIndex=0;
    
                            
                this.event_FrmBA_DepositoBancario_FormClosing += new delegate_FrmBA_DepositoBancario_FormClosing(FrmBA_DepositoBancario_event_FrmBA_DepositoBancario_FormClosing);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmBA_DepositoBancario_event_FrmBA_DepositoBancario_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        void UC_BtnValidadModifCbt_event_btn_PermisoModiCbt_Click(object sender, EventArgs e)
        {
           
        }

        private void Generar_Diario_cble()
        {
            try
            {
              
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                string referencs = "";
                ba_Banco_Cuenta_Info InfoCuentaBancos = ucBa_CuentaBanco.get_BaCuentaInfo();
                if (InfoCuentaBancos != null)
                {
                    ucCon_GridDiarioDeposito.IdCtaCble_x_Banco = InfoCuentaBancos.IdCtaCble;

                    foreach (var item in Binding_DataSource)
                    {
                        if (item.chek == true)
                        {
                            ct_Cbtecble_det_Info Info_haber_x_cobros = new ct_Cbtecble_det_Info();
                            Info_haber_x_cobros.IdEmpresa = param.IdEmpresa;
                            Info_haber_x_cobros.IdTipoCbte = _IdTipoCbte;
                            Info_haber_x_cobros.IdCtaCble = item.IdCtaCble;
                            Info_haber_x_cobros.dc_Valor = Convert.ToDouble(item.cr_TotalCobro) *-1;
                            Info_haber_x_cobros.dc_para_conciliar = false;

                           
                            Info_haber_x_cobros.dc_Observacion = txt_Memo.Text.Trim();

                            referencs = referencs + " " + item.IdCobro_tipo.Trim();
                            _ListaCbteCbleDet.Add(Info_haber_x_cobros);
                        }
                    }

                    // la cuenta de bancos siempre va al debe por q es un deposito la plata entra a bancos
                    ct_Cbtecble_det_Info Info_debito_x_banco = new ct_Cbtecble_det_Info();
                    Info_debito_x_banco.IdEmpresa = param.IdEmpresa;
                    Info_debito_x_banco.IdTipoCbte = _IdTipoCbte;
                    Info_debito_x_banco.IdCtaCble = InfoCuentaBancos.IdCtaCble;
                    Info_debito_x_banco.dc_Valor = Convert.ToDouble(txe_totalDepositar.EditValue);
                    Info_debito_x_banco.dc_para_conciliar = true;

                    Info_debito_x_banco.dc_Observacion = txt_Memo.Text.Trim();


                    _ListaCbteCbleDet.Add(Info_debito_x_banco);



                    ucCon_GridDiarioDeposito.setDetalle(_ListaCbteCbleDet);

                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;

                
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value,ref MensajeError);

                if (Per_I.pe_estado == "I")
                {
                    MessageBox.Show("No se procedió a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
              
                }

              

                if (ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco==0 )
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                       estado = false;
                       return estado;
                
                }

               if (Convert.ToDouble(txe_totalDepositar.EditValue) == 0)
                {
                    MessageBox.Show("Por favor Ingrese el Valor del Depósito...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

               

                 estado =this.ucCon_GridDiarioDeposito.ValidarAsientosContables();

                 if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                     return false; 

                 return estado;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private bool Accion_grabar()
        {
            try
            {
                bool res = false;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        res = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        res = Actualizar();
                        break;                    
                    default:
                        break;
                }
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = dt_fechaCbte.Value;
                CbteCble_I.cb_Valor = Convert.ToDouble(txe_totalDepositar.EditValue);
                CbteCble_I.cb_Observacion = txt_Memo.Text.Trim();
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dt_fechaCbte.Value.Year;
                CbteCble_I.Mes = dt_fechaCbte.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                
                CbteCble_I._cbteCble_det_lista_info = ucCon_GridDiarioDeposito.Get_Info_CbteCble()._cbteCble_det_lista_info;
                foreach (var item in CbteCble_I._cbteCble_det_lista_info)
                {
                    item.IdEmpresa = CbteCble_I.IdEmpresa;
                    item.IdTipoCbte = CbteCble_I.IdTipoCbte;
                }
                return CbteCble_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return new ct_Cbtecble_Info();
            }
        }

        public List<ct_Cbtecble_det_Info> get_CbteCble_det()
        {
            try
            {
                _ListaCbteCbleDet.Clear();

                CbteCble_I._cbteCble_det_lista_info = ucCon_GridDiarioDeposito.Get_Info_CbteCble()._cbteCble_det_lista_info;
                

                return _ListaCbteCbleDet;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ct_Cbtecble_det_Info>();
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan()
        {
            try
            {
                CbteBan_I.IdEmpresa = param.IdEmpresa;
                CbteBan_I.IdTipocbte = _IdTipoCbte;
                CbteBan_I.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                CbteBan_I.Cod_Cbtecble = (CbteBan_I.Cod_Cbtecble == "" || CbteBan_I.Cod_Cbtecble == null || CbteBan_I.Cod_Cbtecble == "0") ? cod_CbteCble : CbteBan_I.Cod_Cbtecble;
                CbteBan_I.IdPeriodo = Per_I.IdPeriodo;

                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    CbteBan_I.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }

                CbteBan_I.IdBanco = ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                CbteBan_I.cb_Fecha = dt_fechaCbte.Value;
                CbteBan_I.cb_Observacion = txt_Memo.Text.Trim();
                CbteBan_I.cb_secuencia = (CbteBan_I.cb_secuencia == 0 ) ? 0 : CbteBan_I.cb_secuencia;
                CbteBan_I.cb_Valor = Convert.ToDouble(txe_totalDepositar.EditValue);
                CbteBan_I.Estado = (lb_Anulado.Visible == false) ? "A" : "I";
                CbteBan_I.IdUsuario = param.IdUsuario;
                CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                CbteBan_I.Fecha_Transac = param.Fecha_Transac;
                CbteBan_I.Fecha_UltMod = param.Fecha_Transac;
                CbteBan_I.IdUsuarioUltMod = param.IdUsuario;
                CbteBan_I.ip = param.ip;
                CbteBan_I.nom_pc = param.nom_pc;

                CbteBan_I.IdSucursal = UCSucursal.Get_IdSucursal();

                CbteBan_I.info_Cbtecble = get_Cbtecble();

                return CbteBan_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return new ba_Cbte_Ban_Info();
            }
        }

        public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> get_IngrEgrexDepo()
        {          
            try
            {

                LstIngrEgrexDepo = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();

                foreach (var item in ListaSumatoria)
                {
                    ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info IngrEgrexDepo_I = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info();
                   
                    IngrEgrexDepo_I.mcj_IdEmpresa= item.IdEmpresa;
		            IngrEgrexDepo_I.mcj_IdCbteCble=item.IdCbteCble_MoviCaja;
		            IngrEgrexDepo_I.mcj_IdTipocbte=item.IdTipocbte_MoviCaja;
		            IngrEgrexDepo_I.mba_IdEmpresa=item.IdEmpresa;
                    IngrEgrexDepo_I.mba_IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
		            IngrEgrexDepo_I.mba_IdTipocbte=_IdTipoCbte;
                    IngrEgrexDepo_I.mcj_Secuencia = item.Secuencia_MoviCaja;


                    LstIngrEgrexDepo.Add(IngrEgrexDepo_I);
                }

                return LstIngrEgrexDepo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
                
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Accion_x_controles()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        txe_totalDepositar.Properties.ReadOnly = true;
                        txt_Ncomprobante.ReadOnly = true;
                        ucBa_CuentaBanco.Perfil_Lectura(_Accion);
                        gridControlCobros.Enabled = false;
                        ucCon_GridDiarioDeposito.Enabled = false;
                        set_CbteBan_I();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucBa_TipoFlujo.ReadOnly(true);
                        set_CbteBan_I();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucBa_CuentaBanco.Perfil_Lectura(_Accion);
                        ucCon_GridDiarioDeposito.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        txe_totalDepositar.Properties.ReadOnly = true;
                        txt_Ncomprobante.ReadOnly = true;
                        txt_Memo.ReadOnly = true;
                        set_CbteBan_I();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean Grabar()
        {
            try
            {
                Boolean respuesta_Guardar_CbteCble = false;
                Boolean respuesta_Guardar_CbteBan = false;
                txt_Memo.Focus();
                if (validaColumna())
                {
                    txt_Memo.Focus();
                    get_Cbtecble();
                    string msg = "";
                    ba_Banco_Cuenta_Info obj_cmbCtaBan = ucBa_CuentaBanco.get_BaCuentaInfo();
                    respuesta_Guardar_CbteCble = CbteCble_B.GrabarDB(CbteCble_I, ref idCbteCble, ref msg);
                    if (respuesta_Guardar_CbteCble)
                        {
                            txt_Ncomprobante.Text = idCbteCble.ToString();
                            get_CbteBan();
                            respuesta_Guardar_CbteBan=CbteBan_B.GrabarDB(CbteBan_I,ref MensajeError);
                            if (respuesta_Guardar_CbteBan)
                            {
                                get_IngrEgrexDepo();
                                if (CajMoviDepo.GrabarDB(LstIngrEgrexDepo))
                                {
                                    if (MessageBox.Show("Se Guardo el Despósito correctamente con el Comprobante contable #: " + obj_cmbCtaBan.ba_descripcion  + "\n ¿ Desea Imprimir el Depósito del Comprobante bancario #: " + CbteBan_I.IdCbteCble, " Imprimir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        Imprimir();
                                    }
                                }
                                else
                                    MessageBox.Show("No se pudo Grabar Los ingresos seleccionados", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("No se pudo Grabar el Depósito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar el Comprobante Depósito \n "+msg , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                    MessageBox.Show("No se puede grabar Comprobante bancario de Deposito, verifique los saldos del debe y haber...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (respuesta_Guardar_CbteBan && respuesta_Guardar_CbteCble);
            }
            catch (Exception ex )
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return false;
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean respuesta_rev_cbteCble = false;
                Boolean respuesta_Update_Estado_Cbte = false;
                Boolean respuesta_Eliminar_Cobros = false;

                if (lb_Anulado.Visible == true)
                {
                    MessageBox.Show("El Comprobante bancario de Depósito #: " + CbteBan_I.IdCbteCble + " ya está Anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Comprobante bancario de Depósito #: " + CbteBan_I.IdCbteCble + " Se procedera a liberar los Cobros y Egresos aplicados en este comprobante", "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        motiAnulacion = fr.motivoAnulacion;

                        respuesta_rev_cbteCble = CbteCble_B.ReversoCbteCble(param.IdEmpresa, Convert.ToDecimal(CbteBan_I.IdCbteCble), CbteBan_I.IdTipocbte, IdTipoCbteRev, ref IdCbteCbleRev, ref msg2, param.IdUsuario);

                        if (respuesta_rev_cbteCble)
                        {
                            CbteBan_I.MotivoAnulacion = motiAnulacion;
                            CbteBan_I.IdUsuario_Anu = param.IdUsuario;
                            CbteBan_I.FechaAnulacion = param.Fecha_Transac;
                            CbteBan_I.IdTipoCbte_Anulacion = IdTipoCbteRev;
                            CbteBan_I.IdCbteCble_Anulacion = IdCbteCbleRev;

                            respuesta_Update_Estado_Cbte = CbteBan_B.AnularDB(CbteBan_I, ref MensajeError);
                            if (respuesta_Update_Estado_Cbte)
                            {
                                respuesta_Eliminar_Cobros = bus_cobro_x_deposito.EliminarCobros_x_deposito(param.IdEmpresa, CbteBan_I.IdTipocbte, CbteBan_I.IdCbteCble);
                                if (respuesta_Eliminar_Cobros)
                                    MessageBox.Show("Comprobante bancario de Depósito # " + CbteBan_I.IdCbteCble + " Anulado correctamente, Con el Tipo de Comprobante de Anulación #" + IdTipoCbteRev + " y el Comprobante de Anulación #: " + IdCbteCbleRev, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("No se pudo Eliminar los Cobro depositados...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                lb_Anulado.Visible = true;
                                lblCbt_TipoAnulacion.Visible = true;
                                lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + CbteBan_I.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + CbteBan_I.IdTipoCbte_Anulacion.ToString();
                            }
                            else
                                MessageBox.Show("No se pudo Anular el Comprobante bancario de Depósito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("No se pudo Reversar el Comprobante bancario de Depósito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return (respuesta_rev_cbteCble && respuesta_Eliminar_Cobros && respuesta_Update_Estado_Cbte);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private Boolean Actualizar()
        {
            Boolean respuesta = false;

            try
            {

                get_CbteBan();

                respuesta=CbteBan_B.ModificarDB(CbteBan_I, ref MensajeError);

                if (respuesta)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Deposito correctamente con el Comprobante contable ", txt_Ncomprobante.Text);
                    MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("No se pudo Modificar el Comprobante Depósito # " + this.txt_Ncomprobante.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return respuesta;
            }
            catch (Exception ex) 
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        public void set_CbteBan_I()
        {
            try
            {
                ucBa_CuentaBanco.set_BaCuentaInfo(Info_CbteBan.IdBanco);
                this.txt_Ncomprobante.Text = Info_CbteBan.IdCbteCble.ToString();
                dt_fechaCbte.Value = Info_CbteBan.cb_Fecha;
                this.txt_Memo.Text = Info_CbteBan.cb_Observacion;
                ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(Info_CbteBan.IdTipoFlujo));
                if (Info_CbteBan.Estado == "I")
                    lb_Anulado.Visible = true;

                lblCbt_TipoAnulacion.Visible = (Info_CbteBan.Estado == "I") ? true : false;
                lblCbt_TipoAnulacion.Text = "Cbt.Cble. de Anu.: " + Info_CbteBan.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + Info_CbteBan.IdTipoCbte_Anulacion.ToString();
                _IdTipoCbte = Info_CbteBan.IdTipocbte;
                CbteBan_I = Info_CbteBan;
                List<cxc_cobro_Info> LstCobro_I = new List<cxc_cobro_Info>();
                LstCobro_I = CbteBan_B.Get_List_CobrosDepositados(Info_CbteBan.IdEmpresa, Info_CbteBan.IdCbteCble, Info_CbteBan.IdTipocbte, ref MensajeError);
                gridControlCobros.DataSource = LstCobro_I;
                ListaSumatoria.AddRange(LstCobro_I);
                txe_totalIngreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.Tipo =="Ingreso" select q.cr_TotalCobro).Sum()); //Convert.ToDecimal(ListaSumatoria.Sum(c => c.cr_TotalCobro  ));
                txe_totalEgreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.Tipo == "Egreso" select  q.cr_TotalCobro).Sum());
                txe_totalDepositar.EditValue = Convert.ToDouble(Info_CbteBan.cb_Valor);
                this.ucCon_GridDiarioDeposito.setInfo(Info_CbteBan.IdEmpresa, Info_CbteBan.IdTipocbte, Info_CbteBan.IdCbteCble);
                List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();             
                lm = this.ucCon_GridDiarioDeposito.Get_Info_CbteCble()._cbteCble_det_lista_info;
                _ListaCbteCbleDetAnt = lm;

                UCSucursal.set_SucursalInfo(Info_CbteBan.IdSucursal);
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_CbteCbleInfo()
        {
            try
            {
                
                if (CbteBan_I.IdCbteCble != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";

                    lm = _CbteCbleBus.Get_list_Cbtecble_det(CbteBan_I.IdEmpresa, CbteBan_I.IdTipocbte, CbteBan_I.IdCbteCble, ref MensajeError);

                    _ListaCbteCbleDetAnt = lm;
                
                    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_Memo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Diario_cble();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_totalDepositar_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Diario_cble();

                calcula();

                ModificarAsientoContable();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void UltraGrid_Cobros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column==null)
                    return;
                
                if (e.HitInfo.Column.Name == "Chek")
                {

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        return;

                    var data = UltraGrid_Cobros.GetRow(e.RowHandle) as cxc_cobro_Info;
                    if ((bool)UltraGrid_Cobros.GetFocusedRowCellValue(Chek))
                    {                        
                        UltraGrid_Cobros.SetFocusedRowCellValue(Chek, false);
                    }
                    else
                    {
                        UltraGrid_Cobros.SetFocusedRowCellValue(Chek, true);
                    }
                     

                    txe_totalIngreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.cr_TotalCobro > 0 select q.cr_TotalCobro).Sum());
                    txe_totalEgreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.cr_TotalCobro < 0 select -1*q.cr_TotalCobro).Sum());
                }
                Generar_Diario_cble();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ModificarAsientoContable()
        {
            try
            {               
                ListDetCbteCble = new List<ct_Cbtecble_det_Info>();               
                ///seteamos el Debe
                ///
                ct_Cbtecble_det_Info info = new ct_Cbtecble_det_Info();
                ///           
                info = new ct_Cbtecble_det_Info();
                info.IdEmpresa = param.IdEmpresa;

                ba_Banco_Cuenta_Info obj_cmbCtaBan = ucBa_CuentaBanco.get_BaCuentaInfo();

                info.IdCtaCble = obj_cmbCtaBan.IdCtaCble;

                info.IdTipoCbte = _IdTipoCbte;

                if (suma < 0)
                {
                    info.dc_Valor = 0;
                }
                else
                {                 
                    info.dc_Valor = suma;
                }
                
                ListDetCbteCble.Add(info);   
                
                ///seteamos el Haber
                ///                           
                foreach (var item in list)
                {
                    info = new ct_Cbtecble_det_Info();
                   
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdCtaCble = item.IdCtaCble;
                    info.IdTipoCbte = _IdTipoCbte;


                    if (item.cr_TotalCobro > 0)
                    {
                        if (item.cr_TotalCobro < 0)
                        {
                            info.dc_Valor = item.cr_TotalCobro;
                        }
                        else
                        {
                            info.dc_Valor = item.cr_TotalCobro * -1;
                        }                    
                    }

                    if (item.cr_TotalCobro < 0)
                    {                       
                          info.dc_Valor = item.cr_TotalCobro * -1;                                        
                    }
                                     
                    ListDetCbteCble.Add(info);
                }
                
                //}
                //else
                //{
                //    ListDetCbteCble = new List<ct_Cbtecble_det_Info>();
                //}
                this.ucCon_GridDiarioDeposito.setDetalle(ListDetCbteCble);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
  
        void calcula()
        {
            try
            {
                   suma = 0;
            
                    var grupolist = (from q in Binding_DataSource
                                     where q.chek == true
                                     group q by q.IdCtaCble into grupo
                                     select new
                                     {

                                         IdCtaCble = grupo.Key,
                                         TotalCobro = grupo.Sum(s => s.cr_TotalCobro)
                                     });

                    list = new List<cxc_cobro_Info>();
                    foreach (var item1 in grupolist)
                    {              
                        cxc_cobro_Info info = new cxc_cobro_Info();
                        info.cr_TotalCobro = item1.TotalCobro;
                        info.IdCtaCble = item1.IdCtaCble;

                        suma = suma + info.cr_TotalCobro;

                        list.Add(info);
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }
        
        private void FrmBA_DepositoBancario_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {  
                this.event_FrmBA_DepositoBancario_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlCobros_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UltraGrid_Cobros_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    return;

                var data = UltraGrid_Cobros.GetRow(e.RowHandle) as cxc_cobro_Info;
                if (data!=null)
                {
                    bool Checkeado = data.chek;
                    if (!Checkeado)
                    {
                        if (ListaSumatoria.Where(q => q == data).Count()!=0) 
                            ListaSumatoria.Remove(data);    
                        
                           
                    }
                    else
                    {
                        if (ListaSumatoria.Where(q => q == data).Count() == 0) 
                            ListaSumatoria.Add(data);
                    }
                    txe_totalIngreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.cr_TotalCobro > 0 select q.cr_TotalCobro).Sum());
                    txe_totalEgreso.EditValue = Convert.ToDouble((from q in ListaSumatoria where q.cr_TotalCobro < 0 select -1 * q.cr_TotalCobro).Sum());    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txe_totalIngreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txe_totalDepositar.EditValue = Convert.ToDouble(txe_totalIngreso.EditValue) - Convert.ToDouble(txe_totalEgreso.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txe_totalEgreso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txe_totalDepositar.EditValue = Convert.ToDouble(txe_totalIngreso.EditValue) - Convert.ToDouble(txe_totalEgreso.EditValue);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void lb_Anulado_Click(object sender, EventArgs e)
        {

        }

        private void cmb_TipoMovCaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    lista = new List<cxc_cobro_Info>();
                    lista = cxc_B.Get_List_Cobros_x_depositar(param.IdEmpresa, Convert.ToString(cmb_TipoMovCaj.Text));
                    Binding_DataSource = new BindingList<cxc_cobro_Info>(lista);
                    gridControlCobros.DataSource = Binding_DataSource;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Imprimir()
        {
            try
            {

                XBAN_Rpt014_rpt Reporte = new XBAN_Rpt014_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["PIdEmpresa"].Value = CbteBan_I.IdEmpresa;
                Reporte.Parameters["PIdTipoCbte"].Value = CbteBan_I.IdTipocbte;
                Reporte.Parameters["PIdCbteCble"].Value = CbteBan_I.IdCbteCble;

                Reporte.ShowPreview();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_Ncomprobante.Text = "0";
                CbteBan_I = new ba_Cbte_Ban_Info();
                dt_fechaCbte.Value = DateTime.Now;
                txt_Memo.Text = "";
                txe_totalDepositar.EditValue = 0;
                lblCbt_TipoAnulacion.Visible = false;

                ucBa_CuentaBanco.set_BaCuentaInfo(0);
                ucCon_GridDiarioDeposito.LimpiarGrid();
                set_Accion_x_controles();
                cmb_TipoMovCaj_SelectedIndexChanged(null, null);

                txe_totalIngreso.Text = "0.00";
                txe_totalEgreso.Text = "0.00";
                txe_totalDepositar.Text = "0.00";

                ListaSumatoria= new List<cxc_cobro_Info>();
                ListaSumGroupXtipoCobro= new List<cxc_cobro_Info>();
                _ListaCbteCbleDet= new List<ct_Cbtecble_det_Info>();
                CbteCble_I= new ct_Cbtecble_Info();
                CbteBan_I= new ba_Cbte_Ban_Info();
                _ListaCbteCbleDetAnt= new List<ct_Cbtecble_det_Info>();
                ListDetCbteCble= new List<ct_Cbtecble_det_Info>();
                Binding_DataSource= new BindingList<cxc_cobro_Info>();
                lista= new List<cxc_cobro_Info>();
                LstIngrEgrexDepo= new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
                list = new List<cxc_cobro_Info>();


                cmb_TipoMovCaj_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Generar_Diario_cble();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
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
                    for (int i = 0; i < UltraGrid_Cobros.RowCount; i++)
                    {
                        UltraGrid_Cobros.SetRowCellValue(i, Chek, true);
                    }
                }
                else
                {
                    for (int i = 0; i < UltraGrid_Cobros.RowCount; i++)
                    {
                        UltraGrid_Cobros.SetRowCellValue(i, Chek, false);
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
    }
}
