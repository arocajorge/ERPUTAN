using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Reportes.Bancos;
using Cus.Erp.Reports.Naturisa.Bancos;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Debito_Mant : Form
    {
        # region 'delegados'
        //Delegados
        public delegate void delegate_FrmBA_Debito_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Debito_Mant_FormClosing event_FrmBA_Debito_Mant_FormClosing;
        #endregion

        #region 'declaracion de Bus e Info'
        //Parametros Generales
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //ba_Banco_Parametros
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus Bus_Banco_Param = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info Info_Banco_Param = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();
        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> List_Info_Banco_Param = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();

        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        //cp_orden_pago_con_cancelacion
        vwcp_orden_pago_con_cancelacion_Bus Bus_orden_pago_con_cancelacion = new vwcp_orden_pago_con_cancelacion_Bus();
        cp_orden_pago_cancelaciones_Bus Bus_ordenPago_cancelaciones = new cp_orden_pago_cancelaciones_Bus();

        //ba_Banco_Cuenta
        ba_Banco_Cuenta_Bus Bus_Banco_Cta = new ba_Banco_Cuenta_Bus();
        ba_Banco_Cuenta_Info Info_Banco_Cta = new ba_Banco_Cuenta_Info();

        //ct_Cbtecble
        ct_Cbtecble_Bus Bus_CbteCble = new ct_Cbtecble_Bus();
        ct_Cbtecble_Info Info_CbteCble = new ct_Cbtecble_Info();

        //ct_Cbtecble_det
        List<ct_Cbtecble_det_Info> List_CbteCble_det_ant = new List<ct_Cbtecble_det_Info>();
        List<ct_Cbtecble_det_Info> List_CbteCble_det = new List<ct_Cbtecble_det_Info>();

        //ct_Periodo
        ct_Periodo_Bus Bus_Periodo = new ct_Periodo_Bus();

        //cp_orden_pago_cancelaciones
        List<cp_orden_pago_cancelaciones_Info> List_orden_Pago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();

        //vwcp_orden_pago_con_cancelacion
        BindingList<vwcp_orden_pago_con_cancelacion_Info> List_BingList_orden_pago_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();

        //vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi
        BindingList<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info> List_BindList_DetalleCaja = new BindingList<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info>();

        

        //ct_Periodo
        ct_Periodo_Info Info_Periodo = new ct_Periodo_Info();

        //ba_Cbte_Ban
        ba_Cbte_Ban_Info info_Cbte_Ban = new ba_Cbte_Ban_Info();
        ba_Cbte_Ban_Bus Bus_Cbte_Ban = new ba_Cbte_Ban_Bus();

        //ba_tipo_nota
        ba_tipo_nota_Info tipo_nota = new ba_tipo_nota_Info();
        ba_tipo_nota_Bus Bus_TipNota = new ba_tipo_nota_Bus();

        #endregion

        #region 'declaracion de variable'
        private Cl_Enumeradores.eTipo_action _Accion;
        string MensajeError = "";
        string ctaCble_acreedoraDebito = "";
        decimal idCbteCble = 0;
        decimal IdCbteCbleRev;
        int IdTipoCbte_ND = 0;
        int IdTipoCbteRev_ND = 0;
        string dc = "";
        int IdBanco = 0;
        #endregion

        void Limpiar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                txt_Ncomprobante.Text = "0";
                info_Cbte_Ban = new ba_Cbte_Ban_Info();
                dt_fechaCbte.Value=DateTime.Now;
                txt_Memo.Text="";
                

                lblCbt_TipoAnulacion.Visible = false;

                List_orden_Pago_Cancelaciones = new List<cp_orden_pago_cancelaciones_Info>();
                List_BindList_DetalleCaja = new BindingList<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info>();
                List_BingList_orden_pago_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();

                List_CbteCble_det_ant = new List<ct_Cbtecble_det_Info>();
                List_CbteCble_det = new List<ct_Cbtecble_det_Info>();
                
                Info_CbteCble = new ct_Cbtecble_Info();
                info_Cbte_Ban = new ba_Cbte_Ban_Info();
                ucBa_CuentaBanco.set_BaCuentaInfo(0);
                ucbA_TipoNota.set_TipoNotaInfo(0);

                this.gridAprobacionOrdenPago.DataSource = null;

                cargar_OP_Pendientes();
                this.UC_Diario_x_NC.LimpiarGrid();
                set_Accion_x_controles();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public FrmBA_Debito_Mant()
        {
            try
            {
                InitializeComponent();
                event_FrmBA_Debito_Mant_FormClosing += FrmBA_Debito_Mant_event_FrmBA_Debito_Mant_FormClosing;
                ucBa_CuentaBanco.event_cmb_CuentaBanco_EditValueChanged += ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged;

                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }                               
        }

        void ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();
                UC_Diario_x_NC.IdCtaCble_x_Banco = ctaBancaria.IdCtaCble;

                generaDiario();
            }
            catch (Exception ex)
           {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void FrmBA_Debito_Mant_event_FrmBA_Debito_Mant_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FrmBA_Debito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmBA_Debito_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void generaDiario()
        {
            try
            {
                double Total_Debe = 0;
                List_CbteCble_det = new List<ct_Cbtecble_det_Info>();
                
                if (List_BingList_orden_pago_con_cancelacion.Count() > 0)
                {
                    foreach (var item in List_BingList_orden_pago_con_cancelacion)
                    {
                        if (item.Check == true)
                        {
                            ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                            debe.IdEmpresa = param.IdEmpresa;
                            debe.IdTipoCbte = IdTipoCbte_ND;
                            debe.IdCtaCble = item.IdCtaCble;
                            debe.dc_Observacion = txt_Memo.Text.Trim();
                            debe.dc_Valor = Convert.ToDouble(item.Valor_aplicado);
                            List_CbteCble_det.Add(debe);
                            Total_Debe = Total_Debe + debe.dc_Valor;
                        }
                    }
                }
                
                
                ba_tipo_nota_Info Info_tipoflujo = new ba_tipo_nota_Info();

                
                ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();

                Haber.IdEmpresa = param.IdEmpresa;
                Haber.IdTipoCbte = IdTipoCbte_ND;

                if (ctaBancaria != null)
                {
                    if (ctaBancaria.IdCtaCble != null)
                    {
                        Haber.IdCtaCble = ctaBancaria.IdCtaCble;
                        Haber.dc_para_conciliar = true;
                    }
                }
                Haber.dc_Observacion = txt_Memo.Text.Trim();
                Haber.dc_Valor = Total_Debe * -1;
                
                

                List_CbteCble_det.Add(Haber);
                
                UC_Diario_x_NC.setDetalle(List_CbteCble_det);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void generaDiario_Tipo_Nota()
        {
            try
            {
                double Total_Debe = 0;
                List_CbteCble_det = new List<ct_Cbtecble_det_Info>();

                if (List_BingList_orden_pago_con_cancelacion.Count() > 0)
                {
                    foreach (var item in List_BingList_orden_pago_con_cancelacion)
                    {
                        item.Check = false;
                    
                    }
                }

                if (tipo_nota != null)
                {
                    if (tipo_nota.IdCtaCble != null)
                    {
                        ct_Cbtecble_det_Info debe = new ct_Cbtecble_det_Info();
                        debe.IdEmpresa = param.IdEmpresa;
                        debe.IdTipoCbte = IdTipoCbte_ND;
                        debe.IdCtaCble = tipo_nota.IdCtaCble;
                        debe.dc_Observacion = txt_Memo.Text.Trim();
                        debe.dc_Valor = 0;
                        List_CbteCble_det.Add(debe);
                        Total_Debe = Total_Debe + debe.dc_Valor;
                    }
                }

                ct_Cbtecble_det_Info Haber = new ct_Cbtecble_det_Info();
                ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();

                Haber.IdEmpresa = param.IdEmpresa;
                Haber.IdTipoCbte = IdTipoCbte_ND;

                if (ctaBancaria != null)
                {
                    if (ctaBancaria.IdCtaCble != null)
                    {
                        Haber.IdCtaCble = ctaBancaria.IdCtaCble;
                        Haber.dc_para_conciliar = true;
                    }
                }
                Haber.dc_Observacion = txt_Memo.Text.Trim();
                Haber.dc_Valor = Total_Debe * -1;
                List_CbteCble_det.Add(Haber);

                UC_Diario_x_NC.setDetalle(List_CbteCble_det);
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
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                   generaDiario();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    
        private Boolean Validacion()
        {
            try
            {
                Boolean estado = true;
                Info_Periodo = Bus_Periodo.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Info_Periodo.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (this.ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (ucGe_Sucursal.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la Sucursal.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }
                /*
                if (ucBa_TipoFlujo.get_TipoFlujoInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione el Tipo de Flujo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }*/

                if (ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione el motivo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                    return false; 

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan()
        {
            try
            {
                info_Cbte_Ban.IdEmpresa = param.IdEmpresa;
                info_Cbte_Ban.IdTipocbte = IdTipoCbte_ND;
                info_Cbte_Ban.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                info_Cbte_Ban.Cod_Cbtecble = info_Cbte_Ban.Cod_Cbtecble;
                info_Cbte_Ban.IdPeriodo = Info_Periodo.IdPeriodo;

                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    info_Cbte_Ban.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }else
                    info_Cbte_Ban.IdTipoFlujo = null;

                if (ucGe_Sucursal.get_SucursalInfo() != null)
                {
                    info_Cbte_Ban.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                }

                if (IdBanco == 0)
                    info_Cbte_Ban.IdBanco = this.ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                else
                    info_Cbte_Ban.IdBanco = IdBanco;
                info_Cbte_Ban.cb_Fecha = dt_fechaCbte.Value;
                info_Cbte_Ban.IdTipoNota = ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota;
                info_Cbte_Ban.cb_Observacion = txt_Memo.Text.Trim();
                info_Cbte_Ban.cb_secuencia = (info_Cbte_Ban.cb_secuencia == 0) ? 0 : info_Cbte_Ban.cb_secuencia;
                info_Cbte_Ban.cb_Valor = Info_CbteCble.cb_Valor;
                info_Cbte_Ban.Estado = (lblCbt_TipoAnulacion.Visible == false) ? "A" : "I";
                info_Cbte_Ban.IdUsuario = param.IdUsuario;
                info_Cbte_Ban.IdUsuario_Anu = param.IdUsuario;

                info_Cbte_Ban.FechaAnulacion = param.Fecha_Transac;
                info_Cbte_Ban.Fecha_Transac = param.Fecha_Transac;
                info_Cbte_Ban.Fecha_UltMod = param.Fecha_Transac;
                info_Cbte_Ban.IdUsuarioUltMod = param.IdUsuario;
                info_Cbte_Ban.cb_ChequeImpreso = "N";
                info_Cbte_Ban.ip = param.ip;
                info_Cbte_Ban.nom_pc = param.nom_pc;
                double TotalDebe = 0;
                foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                {                   
                    if (item.dc_Valor_D > 0)
                    {
                        TotalDebe = TotalDebe + item.dc_Valor_D;
                    }
                }
                info_Cbte_Ban.cb_Valor = TotalDebe;

                info_Cbte_Ban.info_Cbtecble = get_Cbtecble();

                return info_Cbte_Ban;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Cbte_Ban_Info();
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

        private  void set_Accion_x_controles()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        Menu.Enabled_btnGuardar = true;
                        Menu.Enabled_bntGuardar_y_Salir = true;
                        Menu.Enabled_bntAnular = false;
                        ucBa_CuentaBanco.Perfil_Lectura(_Accion);
                        txt_Memo.ReadOnly = false;
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        
                        Menu.Enabled_btnGuardar = true;
                        Menu.Enabled_bntGuardar_y_Salir = true;
                        Menu.Enabled_bntAnular = false;
                       
                        txt_Ncomprobante.ReadOnly = true;
                        ucBa_CuentaBanco.Perfil_Lectura(_Accion);

                        set_CbteBan_I();

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        
                        Menu.Enabled_btnGuardar = false;
                        Menu.Enabled_bntGuardar_y_Salir = false;
                        Menu.Enabled_bntAnular = true;
                        set_CbteBan_I();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar :
                        Menu.Enabled_btnGuardar = false;
                        Menu.Enabled_bntGuardar_y_Salir = false;
                        Menu.Enabled_bntAnular = false;
                        ucBa_CuentaBanco.Perfil_Lectura(_Accion);
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

        private  void set_CbteBan_I()
        {
            try
            {
               // int contador = 0;
                List_BingList_orden_pago_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>();
                //List_BindList_DetalleCaja = new BindingList<vwcp_orden_pago_con_cancelacion_x_CbteBan_Debi_Info>
                //    (Bus_Cbte_Ban.Get_List_CanceladaNotaDebCred(param.IdEmpresa, info_Cbte_Ban.IdCbteCble, info_Cbte_Ban.IdTipocbte, ref MensajeError));
                
                //this.gridAprobacionOrdenPago.DataSource = BindingDetalleCaja;

                this.txt_Ncomprobante.Text = info_Cbte_Ban.IdCbteCble.ToString();
                dt_fechaCbte.Value = info_Cbte_Ban.cb_Fecha;
                this.ucBa_CuentaBanco.set_BaCuentaInfo(info_Cbte_Ban.IdBanco) ;

                ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(info_Cbte_Ban.IdTipoFlujo));
                ucGe_Beneficiario1.set_Persona_beneficiario_Info(Cl_Enumeradores.eTipoPersona.PROVEE, Convert.ToDecimal(info_Cbte_Ban.IdProveedor));
                ucbA_TipoNota.set_TipoNotaInfo(Convert.ToInt32(info_Cbte_Ban.IdTipoNota));
                this.txt_Memo.Text = info_Cbte_Ban.cb_Observacion;

                lblCbt_TipoAnulacion.Visible = (info_Cbte_Ban.Estado == "I") ? true : false;
                lblCbt_TipoAnulacion.Visible = (info_Cbte_Ban.Estado == "I") ? true : false;
                lblCbt_TipoAnulacion.Text = "**ANULADO**con el Cbt.Cble. de Anu.: " + info_Cbte_Ban.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + info_Cbte_Ban.IdTipoCbte_Anulacion.ToString();

                UC_Diario_x_NC.setInfo(info_Cbte_Ban.IdEmpresa, info_Cbte_Ban.IdTipocbte, info_Cbte_Ban.IdCbteCble);

                Info_CbteCble = UC_Diario_x_NC.Get_Info_CbteCble();
                
                ucGe_Sucursal.set_SucursalInfo(info_Cbte_Ban.IdSucursal);
                set_CbteCbleInfo();

                vwba_Cbte_Ban_detallePagos_Bus _CbteBan_B = new vwba_Cbte_Ban_detallePagos_Bus();
                List<vwba_ordenGiroPendientes_Info> lm = new List<vwba_ordenGiroPendientes_Info>();

                lm = _CbteBan_B.Get_List_PgCheque(info_Cbte_Ban.IdEmpresa, info_Cbte_Ban.IdTipocbte, info_Cbte_Ban.IdCbteCble);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void set_CbteCbleInfo()
        {
            try
            {
                if (info_Cbte_Ban.IdCbteCble != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";
                    lm = _CbteCbleBus.Get_list_Cbtecble_det(info_Cbte_Ban.IdEmpresa, info_Cbte_Ban.IdTipocbte, info_Cbte_Ban.IdCbteCble, ref MensajeError);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Info( ba_Cbte_Ban_Info Info)
        {
            try
            {
                info_Cbte_Ban = Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        public ct_Cbtecble_Info get_Cbtecble()
        {
            try
            {
                Info_CbteCble._cbteCble_det_lista_info = this.UC_Diario_x_NC.Get_Info_CbteCble()._cbteCble_det_lista_info;
                Info_CbteCble.IdEmpresa = param.IdEmpresa;
                Info_CbteCble.IdTipoCbte = IdTipoCbte_ND;                  
                Info_CbteCble.IdPeriodo = Info_Periodo.IdPeriodo;
                Info_CbteCble.cb_Fecha = dt_fechaCbte.Value.Date;
                Info_CbteCble.cb_Valor = 0;
                Info_CbteCble.cb_Observacion = "N/D " + dc + txt_Memo.Text + ucBa_CuentaBanco.get_BaCuentaInfo().ba_descripcion;
                Info_CbteCble.Secuencia = 0;
                Info_CbteCble.Estado = "A";
                Info_CbteCble.Anio = dt_fechaCbte.Value.Year;
                Info_CbteCble.Mes = dt_fechaCbte.Value.Month;
                Info_CbteCble.IdUsuario = param.IdUsuario;
                Info_CbteCble.IdUsuarioUltModi = param.IdUsuario;
                Info_CbteCble.cb_FechaTransac = param.Fecha_Transac;
                Info_CbteCble.cb_FechaUltModi = param.Fecha_Transac;
                Info_CbteCble.Mayorizado = "N";
                Info_CbteCble.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                
                Info_CbteCble.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;

                double TotalDebe = 0;
                foreach (var item in Info_CbteCble._cbteCble_det_lista_info)
                {
                    if (item.dc_Observacion == "")
                    {
                        item.dc_Observacion = "N/D " + dc + txt_Memo.Text + ucBa_CuentaBanco.get_BaCuentaInfo().ba_descripcion;
                    }
                    if (item.dc_Valor_D > 0)
                    {
                        TotalDebe = TotalDebe + item.dc_Valor_D;
                    }
                }
                Info_CbteCble.cb_Valor = TotalDebe;

                return Info_CbteCble;              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return new ct_Cbtecble_Info();
            }

        }

        private  void GetDetalle_Grid()
        {
            try
            {
                int contador = 1;
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    foreach (var item in List_BingList_orden_pago_con_cancelacion)
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
                            info_ordenCan.IdTipoCbte_pago = Info_CbteCble.IdTipoCbte;
                            info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                            info_ordenCan.MontoAplicado = item.Valor_estimado_a_pagar_OP;
                            info_ordenCan.SaldoAnterior = 0;
                            info_ordenCan.SaldoActual = 0;
                            info_ordenCan.Observacion = txt_Memo.Text;
                            List_orden_Pago_Cancelaciones.Add(info_ordenCan);

                            contador = contador + 1;
                        }
                    }
                }
                else
                {
                    foreach (var item in List_BindList_DetalleCaja)
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
                        info_ordenCan.IdTipoCbte_pago = IdTipoCbte_ND;
                        info_ordenCan.IdCbteCble_pago = Convert.ToDecimal(txt_Ncomprobante.Text);
                        info_ordenCan.MontoAplicado = item.Valor_estimado_a_pagar_OP;
                        info_ordenCan.SaldoAnterior = 0;
                        info_ordenCan.SaldoActual = 0;
                        info_ordenCan.Observacion = txt_Memo.Text;
                        info_ordenCan.Idcancelacion = item.Idcancelacion;
                        List_orden_Pago_Cancelaciones.Add(info_ordenCan);

                        contador = contador + 1;
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

        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (Grabar())
                    {
                        respuesta = true;
                        Limpiar();
                    }
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (Actualizar())
                    {
                        respuesta = true;
                        Limpiar();
                    }
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

        private Boolean Anular()
        {
            try
            {
                
                Boolean Respuesta = false;
               
                    if (MessageBox.Show("¿Está seguro que desea anular dicho Comprobante?" + "\n También se procederá con la liberación de los pagos de las órdenes de giro seleccionadas", "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = "";
                        motiAnulacion = fr.motivoAnulacion;



                        Respuesta = UC_Diario_x_NC.Reverso(IdTipoCbteRev_ND, ref IdCbteCbleRev, ref MensajeError, motiAnulacion);
                        if (Respuesta)
                        {
                            info_Cbte_Ban.MotivoAnulacion = motiAnulacion;
                            info_Cbte_Ban.IdUsuario_Anu = param.IdUsuario;
                            info_Cbte_Ban.FechaAnulacion = param.Fecha_Transac;
                            info_Cbte_Ban.IdTipoCbte_Anulacion = IdTipoCbteRev_ND;
                            info_Cbte_Ban.IdCbteCble_Anulacion = IdCbteCbleRev;

                            if (Bus_Cbte_Ban.AnularDB(info_Cbte_Ban, ref MensajeError))
                            {
                                cp_orden_pago_cancelaciones_Bus OGPagos_B = new cp_orden_pago_cancelaciones_Bus();
                                if (OGPagos_B.Eliminar_OrdenPagoCancelaciones(info_Cbte_Ban.IdEmpresa,info_Cbte_Ban.IdTipocbte, info_Cbte_Ban.IdCbteCble, ref MensajeError))
                                {
                                    GetDetalle_Grid();
                                    //BusOrdenPagoCancelacion.ModificarDB(ListOrdenPagoCancelacion);

                                    MessageBox.Show("Comprobante bancario # " + info_Cbte_Ban.IdCbteCble + " Anulado correctamente");
                                }
                                else
                                    MessageBox.Show("No se pudo Eliminar los pagos relacionados a esta Comprobante bancario...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                                lblCbt_TipoAnulacion.Visible = true;
                                lblCbt_TipoAnulacion.Visible = true;
                                lblCbt_TipoAnulacion.Text = "**ANULADO** con el Cbt.Cble. de Anu.: " + IdCbteCbleRev.ToString() + " Tipo Cbt.Cble de Anu.: " + IdTipoCbteRev_ND.ToString();



                            }
                            else
                                MessageBox.Show("No se pudo Anular el Comprobante bancario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("No se pudo Reversar el Comprobante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    return Respuesta;

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

            try
            {
                Boolean respuesta = false;

                respuesta =Validacion();
                if (respuesta)
                {
                    idCbteCble = info_Cbte_Ban.IdCbteCble;
                    get_CbteBan();
                    respuesta = Bus_Cbte_Ban.ModificarDB(info_Cbte_Ban, ref MensajeError);

                    if (respuesta)
                    {                        
                        if (MessageBox.Show("Se ha actualizado correctamente el Comprobante de " + dc + " #: " + txt_Ncomprobante.Text + "\n ¿ Desea Imprimir el Comprobante bancario ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                    }
                }
                return respuesta;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return false;
                
            }
        }

        private Boolean Grabar()
        {
            try
            {
                Boolean respuesta = false;

                respuesta=Validacion();

                if (respuesta)
                {
                    txt_Memo.Focus();
                    string msg = "";
                    get_Cbtecble();

                    if (ucBa_CuentaBanco.get_BaCuentaInfo().Estado == "A")
                    {
                        vwtb_persona_beneficiario_Info Info_Beneficiario = new vwtb_persona_beneficiario_Info();
                        Info_Beneficiario = ucGe_Beneficiario1.Get_Persona_beneficiario_Info();
                        if (Info_Beneficiario.Estado == null || Info_Beneficiario.Estado =="A")
                        {
                            respuesta = Bus_CbteCble.GrabarDB(Info_CbteCble, ref idCbteCble, ref msg);
                        }
                        else
                        {
                            MessageBox.Show("El Beneficiario que ha seleccionado se encuentra anulado.\nPor favor seleccione un beneficiario activo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cuenta bancaria que ha seleccionado se encuentra anulada.\nPor favor seleccione una cuenta activa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (respuesta)
                        {
                            txt_Ncomprobante.Text = idCbteCble.ToString();
                            get_CbteBan();

                        respuesta=Bus_Cbte_Ban.GrabarDB(info_Cbte_Ban, ref MensajeError);

                        if (respuesta)
                            {

                                //get_lisOG_Paga();

                                //OGPagos_B.GrabarLista(lisOG_Paga, param.IdEmpresa, ref IdCancelacion);

                                int idEmpresa = param.IdEmpresa;
                                string mesg2 = "";
                                GetDetalle_Grid();
                        Bus_ordenPago_cancelaciones.GuardarDB(List_orden_Pago_Cancelaciones, idEmpresa, ref mesg2);

                                if (MessageBox.Show("Se Guardo correctamente con el Comprobante de " + dc + " #: " + txt_Ncomprobante.Text + "\n ¿ Desea Imprimir el Comprobante bancario ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Imprimir();
                                }

                            }
                            else
                                MessageBox.Show("No se pudo Grabar el Cbte Bancario" + dc, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Grabar el Comprobante " + dc + " (" + msg + ")", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }

                return respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return false;
            }
        }

        private void cargar_OP_Pendientes()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                 
                    List_BingList_orden_pago_con_cancelacion = new BindingList<vwcp_orden_pago_con_cancelacion_Info>(Bus_orden_pago_con_cancelacion.Get_List_orden_pago_con_cancelacion_Mayor_a_cero_x_OrdenPago(param.IdEmpresa,
                        InfoBeneficiario.IdTipo_Persona, InfoBeneficiario.IdPersona, InfoBeneficiario.IdEntidad
                       ,  "APRO"));


                    gridAprobacionOrdenPago.DataSource = List_BingList_orden_pago_con_cancelacion;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Debito_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                List_Info_Banco_Param = Bus_Banco_Param.Get_List_Banco_Parametros(param.IdEmpresa);
                Info_Banco_Param = List_Info_Banco_Param.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NDBA"; });

                if (Info_Banco_Param == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    if (Info_Banco_Param.IdTipoCbteCble < 0 || Info_Banco_Param.IdTipoCbteCble_Anu < 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. Ingréselos desde la pantalla de parámetros de banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        ctaCble_acreedoraDebito = Info_Banco_Param.IdCtaCble;
                        IdTipoCbte_ND = Info_Banco_Param.IdTipoCbteCble;
                        IdTipoCbteRev_ND = Info_Banco_Param.IdTipoCbteCble_Anu;
                    }
                }

                set_Accion_x_controles();
                dc = "Debito ";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        private void txe_monto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                generaDiario();
                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    set_CbteCbleInfo();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
            
        }

        private void Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Menu_event_btnImprimir_Click(object sender, EventArgs e)
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

        private void Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_Cbte_Ban.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    _Accion = Cl_Enumeradores.eTipo_action.Anular;
                    Anular();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private  void Imprimir()
        {
            try
            {
               switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XBAN_NAT_Rpt001_Rpt Reporte_nat = new XBAN_NAT_Rpt001_Rpt();
                        Reporte_nat.RequestParameters = false;
                        ReportPrintTool natu = new ReportPrintTool(Reporte_nat);
                        natu.AutoShowParametersPanel = false;
                        Reporte_nat.Parameters["PIdEmpresa"].Value = Info_CbteCble.IdEmpresa;
                        Reporte_nat.Parameters["PIdTipoCbte"].Value = Info_CbteCble.IdTipoCbte;
                        Reporte_nat.Parameters["PIdCbteCble"].Value = Info_CbteCble.IdCbteCble;
                        Reporte_nat.Parameters["PNombreReporte"].Value = "NOTA DE DEBITO";
                        Reporte_nat.ShowPreview();
                        break;

                    default:
               
                            XBAN_Rpt013_rpt Reporte = new XBAN_Rpt013_rpt();
                            Reporte.RequestParameters = false;
                            ReportPrintTool pt = new ReportPrintTool(Reporte);
                            pt.AutoShowParametersPanel = false;
                            Reporte.Parameters["PIdEmpresa"].Value = Info_CbteCble.IdEmpresa;
                            Reporte.Parameters["PIdTipoCbte"].Value = Info_CbteCble.IdTipoCbte;
                            Reporte.Parameters["PIdCbteCble"].Value = Info_CbteCble.IdCbteCble;
                            Reporte.ShowPreview();
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

        private void Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucbA_TipoNota_event_cmb_TipoNota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {                    
                    tipo_nota = ucbA_TipoNota.get_TipoNotaInfo();
                    if (tipo_nota != null)
                    {
                        if (tipo_nota.IdCtaCble != null)
                        {
                            if (MessageBox.Show("¿Desea generar actualizar el diario?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                generaDiario_Tipo_Nota();
                            }
                        }
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

        vwtb_persona_beneficiario_Info InfoBeneficiario = new vwtb_persona_beneficiario_Info();

        private void ucGe_Beneficiario1_event_cmb_beneficiario_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoBeneficiario = ucGe_Beneficiario1.Get_Persona_beneficiario_Info();
                cargar_OP_Pendientes();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
          
        }

        private void gridViewOP_Pendientes_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                vwcp_orden_pago_con_cancelacion_Info row = (vwcp_orden_pago_con_cancelacion_Info)gridViewOP_Pendientes.GetFocusedRow();

                if (row != null)
                {
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
                        }
                        generaDiario();
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
    }
}
