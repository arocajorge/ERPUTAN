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

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Reportes.Bancos;
using Cus.Erp.Reports.Naturisa.Bancos;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Credito_Mant : Form
    {
        //Bus
        int bandera = 0;

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        ba_tipo_nota_Bus busTipNota = new ba_tipo_nota_Bus();
        ba_Cbte_Ban_Bus BusBancoDetallado = new ba_Cbte_Ban_Bus();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus paramBa_B = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Bus bancoB = new ba_Banco_Cuenta_Bus();
        ct_Cbtecble_Bus CbteCble_B = new ct_Cbtecble_Bus();
        ba_Cbte_Ban_Bus CbteBan_B = new ba_Cbte_Ban_Bus();
        ct_Periodo_Bus Per_B = new ct_Periodo_Bus();
        ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus CajMoviDepo = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Bus();
        cxc_cobro_Bus cxc_B = new cxc_cobro_Bus();

        ba_Cbte_Ban_Info info_ba_Cbte_Ban = new ba_Cbte_Ban_Info();

        List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> listParaBan = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();
        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info paramBa_I = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

        //Listas

        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
        public List<ct_Cbtecble_det_Info> _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
        ct_Cbtecble_Info CbteCble_I = new ct_Cbtecble_Info();
        ba_Banco_Cuenta_Info InfoBancoCta = new ba_Banco_Cuenta_Info();
        ba_tipo_nota_Info tipo_nota = new ba_tipo_nota_Info();
        ct_Periodo_Info Per_I = new ct_Periodo_Info();
        List<cxc_cobro_Info> lista = new List<cxc_cobro_Info>();
        List<cxc_cobro_Info> ListaSumatoria = new List<cxc_cobro_Info>();
        List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> LstIngrEgrexDepo = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
        BindingList<cxc_cobro_Info> Binding_DataSource = new BindingList<cxc_cobro_Info>();
        
        string MensajeError = "";
        private Cl_Enumeradores.eTipo_action _Accion;
        string ctaCble_acreedoraCredito = "";
        decimal idCbteCble = 0;
        string cod_CbteCble = "";
        int _IdTipoCbte = 0;       
        int _IdTipoCbte_NC = 0;      
        int IdTipoCbteRev_NC = 0;
        string dc = "";
        string motiAnulacion = "";
        int IdTipoCbteRev;
        decimal IdCbteCbleRev;
        int IdBanco = 0;
        
        public delegate void delegate_FrmBA_Credito_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Credito_Mant_FormClosing event_FrmBA_Credito_Mant_FormClosing;
                             
        public FrmBA_Credito_Mant()
        {
            InitializeComponent();

            try
            {

                event_FrmBA_Credito_Mant_FormClosing += FrmBA_Credito_Mant_event_FrmBA_Credito_Mant_FormClosing;
                ucbA_TipoNota.event_cmb_TipoNota_EditValueChanged += ucbA_TipoNota_event_cmb_TipoNota_EditValueChanged;
                ucBa_CuentaBanco.event_cmb_CuentaBanco_EditValueChanged += ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged;

                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;

                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_info_Cbte_Ban(ba_Cbte_Ban_Info _Info_Cbte_Ban_Info)
        {
            try
            {
                info_ba_Cbte_Ban = _Info_Cbte_Ban_Info;
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
                if (info_ba_Cbte_Ban.Estado == "I")
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

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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

        void ucBa_CuentaBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();
            UC_Diario_x_NC.IdCtaCble_x_Banco = ctaBancaria.IdCtaCble;

            generaDiario();
        }

        void ucbA_TipoNota_event_cmb_TipoNota_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {                    
                    bandera = 1;
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

        void FrmBA_Credito_Mant_event_FrmBA_Credito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void generaDiario()
        {
            try
            {
                double Total_Debe = 0;
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();

                if (Binding_DataSource.Count() > 0)
                {
                    foreach (var item in Binding_DataSource)
                    {
                        if (item.chek == true)
                        {
                            ct_Cbtecble_det_Info credito_info = new ct_Cbtecble_det_Info();
                            credito_info.IdEmpresa = param.IdEmpresa;
                            credito_info.IdTipoCbte = _IdTipoCbte_NC;
                            credito_info.IdCtaCble = item.IdCtaCble;
                            credito_info.dc_Observacion = txt_Memo.Text.Trim();
                            credito_info.dc_Valor = Convert.ToDouble(item.cr_TotalCobro) * -1; // al credito la contrapartida de bancos
                            _ListaCbteCbleDet.Add(credito_info);
                            Total_Debe = Total_Debe + credito_info.dc_Valor;
                        }
                    }
                }


                ct_Cbtecble_det_Info debito_info_x_banco = new ct_Cbtecble_det_Info();// la cuenta bancos va al debito por q es una NC

                ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();


                ba_tipo_nota_Info Info_tipoflujo = new ba_tipo_nota_Info();

                debito_info_x_banco.IdEmpresa = param.IdEmpresa;
                debito_info_x_banco.IdTipoCbte = _IdTipoCbte_NC;
                if (ctaBancaria != null)
                {
                    debito_info_x_banco.IdCtaCble = ctaBancaria.IdCtaCble;
                    debito_info_x_banco.dc_para_conciliar = true;
                }

                debito_info_x_banco.dc_Observacion = txt_Memo.Text.Trim();
                debito_info_x_banco.dc_Valor = Total_Debe * -1;// al debito la cta bancos


                _ListaCbteCbleDet.Add(debito_info_x_banco);
                UC_Diario_x_NC.setDetalle(_ListaCbteCbleDet);
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
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();

                if (Binding_DataSource.Count() > 0)
                {
                    foreach (var item in Binding_DataSource)
                    {
                        item.chek = false;
                    }
                }

                if (tipo_nota != null)
                {
                    if (tipo_nota.IdCtaCble != null)
                    {
                        ct_Cbtecble_det_Info credito_info = new ct_Cbtecble_det_Info();
                        credito_info.IdEmpresa = param.IdEmpresa;
                        credito_info.IdTipoCbte = _IdTipoCbte_NC;
                        credito_info.IdCtaCble = tipo_nota.IdCtaCble;
                        credito_info.dc_Observacion = txt_Memo.Text.Trim();
                        credito_info.dc_Valor = 0; // al credito la contrapartida de bancos
                        _ListaCbteCbleDet.Add(credito_info);
                        Total_Debe = Total_Debe + credito_info.dc_Valor;
                    }
                }
                
                ct_Cbtecble_det_Info debito_info_x_banco = new ct_Cbtecble_det_Info();// la cuenta bancos va al debito por q es una NC

                ba_Banco_Cuenta_Info ctaBancaria = ucBa_CuentaBanco.get_BaCuentaInfo();


                ba_tipo_nota_Info Info_tipoflujo = new ba_tipo_nota_Info();

                debito_info_x_banco.IdEmpresa = param.IdEmpresa;
                debito_info_x_banco.IdTipoCbte = _IdTipoCbte_NC;
                if (ctaBancaria != null)
                {
                    debito_info_x_banco.IdCtaCble = ctaBancaria.IdCtaCble;
                    debito_info_x_banco.dc_para_conciliar = true;
                }

                debito_info_x_banco.dc_Observacion = txt_Memo.Text.Trim();
                debito_info_x_banco.dc_Valor = Total_Debe * -1;// al debito la cta bancos


                _ListaCbteCbleDet.Add(debito_info_x_banco);
                UC_Diario_x_NC.setDetalle(_ListaCbteCbleDet);
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
                //UC_diario.Observacion(dc, txt_Memo.Text);
                //generaDiario();
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

        public Boolean Validar()
        {
            try
            {
                Boolean estado = true;

                int validaCta_convalor = 0;

                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Per_I.pe_cerrado == "S")
                {
                    MessageBox.Show("No se procedio a Grabar porque el Periodo se encuentra cerrado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la Cta. Bancaria", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }
            
                if (ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione el motivo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (ucGe_Sucursal.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione la sucursal.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }


                if (ucGe_Sucursal.get_SucursalInfo().IdSucursal == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione la sucursal.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (validaCta_convalor > 0)
                {
                    MessageBox.Show("No se puede grabar Comprobante,  verifique los saldos del debe y haber, que se están enviando con la cuenta contable en blanco ...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.BAN, Convert.ToDateTime(dt_fechaCbte.Value)))
                    return false;

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        if (ucBa_TipoFlujo.get_TipoFlujoInfo() == null)
                        {
                            MessageBox.Show("Seleccione el tipo de flujo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        break;
                }

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

        public List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info> get_IngrEgrexDepo()
        {
            try
            {
                foreach (var item in ListaSumatoria)
                {
                    ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info IngrEgrexDepo_I = new ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info();

                    IngrEgrexDepo_I.mcj_IdEmpresa = item.IdEmpresa;
                    IngrEgrexDepo_I.mcj_IdCbteCble = item.IdCbteCble_MoviCaja;
                    IngrEgrexDepo_I.mcj_IdTipocbte = item.IdTipocbte_MoviCaja;
                    IngrEgrexDepo_I.mcj_Secuencia = item.Secuencia_MoviCaja;
                    IngrEgrexDepo_I.mba_IdEmpresa = item.IdEmpresa;
                    IngrEgrexDepo_I.mba_IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                    IngrEgrexDepo_I.mba_IdTipocbte = _IdTipoCbte;

                    LstIngrEgrexDepo.Add(IngrEgrexDepo_I);
                }

                return LstIngrEgrexDepo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
            }
        }

        public ba_Cbte_Ban_Info get_CbteBan()
        {
            try
            {
                dc = "Credito ";
                
                _IdTipoCbte = _IdTipoCbte_NC;

                if (info_ba_Cbte_Ban == null)
                {
                    info_ba_Cbte_Ban = new ba_Cbte_Ban_Info();
                }


                info_ba_Cbte_Ban.IdEmpresa = param.IdEmpresa;
                info_ba_Cbte_Ban.IdTipocbte = _IdTipoCbte_NC;
                info_ba_Cbte_Ban.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);
                info_ba_Cbte_Ban.Cod_Cbtecble = (info_ba_Cbte_Ban.Cod_Cbtecble == "" || info_ba_Cbte_Ban.Cod_Cbtecble == null || info_ba_Cbte_Ban.Cod_Cbtecble == "0") ? cod_CbteCble : info_ba_Cbte_Ban.Cod_Cbtecble;
                info_ba_Cbte_Ban.IdPeriodo = Per_I.IdPeriodo;

                if (ucBa_TipoFlujo.get_TipoFlujoInfo() != null)
                {
                    info_ba_Cbte_Ban.IdTipoFlujo = ucBa_TipoFlujo.get_TipoFlujoInfo().IdTipoFlujo;
                }
                else
                    info_ba_Cbte_Ban.IdTipoFlujo = null;

                if (ucGe_Sucursal.get_SucursalInfo() != null)
                {
                    info_ba_Cbte_Ban.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                }
                           
                if (IdBanco == 0)
                    info_ba_Cbte_Ban.IdBanco = ucBa_CuentaBanco.get_BaCuentaInfo().IdBanco;
                else
                    info_ba_Cbte_Ban.IdBanco = IdBanco;
                info_ba_Cbte_Ban.cb_Fecha = dt_fechaCbte.Value;
                info_ba_Cbte_Ban.cb_Observacion = txt_Memo.Text.Trim();
                info_ba_Cbte_Ban.cb_secuencia = (info_ba_Cbte_Ban.cb_secuencia == 0 ) ? 0 : info_ba_Cbte_Ban.cb_secuencia;
                info_ba_Cbte_Ban.cb_Valor = CbteCble_I.cb_Valor;
                info_ba_Cbte_Ban.Estado = (lblCbt_TipoAnulacion.Visible == false) ? "A" : "I";//faltaaaaaaaa
                info_ba_Cbte_Ban.IdUsuario = param.IdUsuario;
                info_ba_Cbte_Ban.IdUsuario_Anu = param.IdUsuario;

              //  info_ba_Cbte_Ban.IdTipoNota = Convert.ToInt32(UCmbMotivo.EditValue);
                info_ba_Cbte_Ban.IdTipoNota = ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota;

                info_ba_Cbte_Ban.FechaAnulacion = param.Fecha_Transac;
                info_ba_Cbte_Ban.Fecha_Transac = param.Fecha_Transac;
                info_ba_Cbte_Ban.Fecha_UltMod = param.Fecha_Transac;
                info_ba_Cbte_Ban.IdUsuarioUltMod = param.IdUsuario;
                info_ba_Cbte_Ban.cb_ChequeImpreso = "N";
                info_ba_Cbte_Ban.ip = param.ip;
                info_ba_Cbte_Ban.nom_pc = param.nom_pc;

                double TotalDebe = 0;
                foreach (var item in CbteCble_I._cbteCble_det_lista_info)
                {  
                    if (item.dc_Valor_D > 0)
                    {
                        TotalDebe = TotalDebe + item.dc_Valor_D;
                    }
                }
                info_ba_Cbte_Ban.cb_Valor = TotalDebe;
                info_ba_Cbte_Ban.info_Cbtecble = get_Cbtecble();

                return info_ba_Cbte_Ban;
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); 
                return new ba_Cbte_Ban_Info();
            }
        }

        public void set_CbteBan_I()
        {
            try
            {

                this.txt_Ncomprobante.Text = info_ba_Cbte_Ban.IdCbteCble.ToString();
                dt_fechaCbte.Value = info_ba_Cbte_Ban.cb_Fecha;
                ucBa_TipoFlujo.set_TipoFlujoInfo(Convert.ToDecimal(info_ba_Cbte_Ban.IdTipoFlujo));

                this.ucBa_CuentaBanco.set_BaCuentaInfo(info_ba_Cbte_Ban.IdBanco);

                ucbA_TipoNota.set_TipoNotaInfo(Convert.ToInt32(info_ba_Cbte_Ban.IdTipoNota));
                this.txt_Memo.Text = info_ba_Cbte_Ban.cb_Observacion;
                

                lblCbt_TipoAnulacion.Visible = (info_ba_Cbte_Ban.Estado == "I") ? true : false;

                lblCbt_TipoAnulacion.Text = "**ANULADO**con el Cbt.Cble. de Anu.: " + info_ba_Cbte_Ban.IdCbteCble_Anulacion.ToString() + " Tipo Cbt.Cble de Anu.: " + info_ba_Cbte_Ban.IdTipoCbte_Anulacion.ToString();

                UC_Diario_x_NC.setInfo(info_ba_Cbte_Ban.IdEmpresa, info_ba_Cbte_Ban.IdTipocbte, info_ba_Cbte_Ban.IdCbteCble);
                
                
                CbteCble_I = UC_Diario_x_NC.Get_Info_CbteCble();


                List<cxc_cobro_Info> LstCobro_I = new List<cxc_cobro_Info>();
                LstCobro_I = CbteBan_B.Get_List_CobrosDepositados(info_ba_Cbte_Ban.IdEmpresa, info_ba_Cbte_Ban.IdCbteCble, info_ba_Cbte_Ban.IdTipocbte, ref MensajeError);
                gridControlCobros.DataSource = LstCobro_I;

                ListaSumatoria.AddRange(LstCobro_I);


                 ucGe_Sucursal.set_SucursalInfo(info_ba_Cbte_Ban.IdSucursal);


                set_CbteCbleInfo();



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            _Accion = iAccion;
        }

        public void set_CbteCbleInfo()
        {
           
            try
            {
                if (info_ba_Cbte_Ban.IdCbteCble != 0)
                {
                    ct_Cbtecble_det_Bus _CbteCbleBus = new ct_Cbtecble_det_Bus();
                    List<ct_Cbtecble_det_Info> lm = new List<ct_Cbtecble_det_Info>();
                    string MensajeError = "";
                    lm = _CbteCbleBus.Get_list_Cbtecble_det(info_ba_Cbte_Ban.IdEmpresa, info_ba_Cbte_Ban.IdTipocbte, info_ba_Cbte_Ban.IdCbteCble, ref MensajeError);
                    UC_Diario_x_NC.setInfo(info_ba_Cbte_Ban.IdEmpresa, info_ba_Cbte_Ban.IdTipocbte, info_ba_Cbte_Ban.IdCbteCble);
                    
                    

                }
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
                CbteCble_I._cbteCble_det_lista_info = UC_Diario_x_NC.Get_Info_CbteCble()._cbteCble_det_lista_info;
                CbteCble_I.IdEmpresa = param.IdEmpresa;
                CbteCble_I.IdTipoCbte = _IdTipoCbte_NC;
                CbteCble_I.IdPeriodo = Per_I.IdPeriodo;
                CbteCble_I.cb_Fecha = dt_fechaCbte.Value;
                CbteCble_I.cb_Observacion = "El " + dc + txt_Memo.Text + " de la Cta Bancaria " + ucBa_CuentaBanco.get_BaCuentaInfo().ba_descripcion;
                CbteCble_I.Secuencia = 0;
                CbteCble_I.Estado = "A";
                CbteCble_I.Anio = dt_fechaCbte.Value.Year;
                CbteCble_I.Mes = dt_fechaCbte.Value.Month;
                CbteCble_I.IdUsuario = param.IdUsuario;
                CbteCble_I.IdUsuarioUltModi = param.IdUsuario;
                CbteCble_I.cb_FechaTransac = param.Fecha_Transac;
                CbteCble_I.cb_FechaUltModi = param.Fecha_Transac;
                CbteCble_I.Mayorizado = "N";
                CbteCble_I.IdCbteCble = Convert.ToDecimal(txt_Ncomprobante.Text);                
                CbteCble_I.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                
                double TotalDebe = 0;
                foreach (var item in CbteCble_I._cbteCble_det_lista_info)
                {
                    if (item.dc_Observacion == "")
                    {
                        item.dc_Observacion = "El " + dc + txt_Memo.Text + " de la Cta Bancaria " + ucBa_CuentaBanco.get_BaCuentaInfo().ba_descripcion;
                    }
                    if (item.dc_Valor_D>0)
                    {
                        TotalDebe = TotalDebe + item.dc_Valor_D;
                    }
                }
                CbteCble_I.cb_Valor = TotalDebe;
                return CbteCble_I;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ct_Cbtecble_Info();
            }

        }

        Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    respuesta = Grabar();
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    respuesta = Actualizar();
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

        private Boolean Grabar()
        {
            try
            {
                Boolean respuesta = false;


                if (Validar())
                {
                    txt_Memo.Focus();

                    string msg = "";

                    
                        get_Cbtecble();

                    respuesta=CbteCble_B.GrabarDB(CbteCble_I, ref idCbteCble, ref msg);

                    if (respuesta)
                        {
                            txt_Ncomprobante.Text = idCbteCble.ToString();
                            get_CbteBan();

                        respuesta=CbteBan_B.GrabarDB(info_ba_Cbte_Ban, ref MensajeError);

                        if (respuesta)
                            {

                                get_IngrEgrexDepo();

                                if (ListaSumatoria.Count !=0)
                                {
                                    if (CajMoviDepo.GrabarDB(LstIngrEgrexDepo))
                                    {
                                                                             
                                    }
                                    else
                                        MessageBox.Show("No se pudo Grabar Los ingresos seleccionados", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                
                                }
                                
                                if (MessageBox.Show("Se Guardo correctamente con el Comprobante de " + dc + " #: " + txt_Ncomprobante.Text + "\n ¿ Desea Imprimir el Comprobante bancario ?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Imprimir();
                                }
                             }
                            else
                                MessageBox.Show("No se pudo Grabar el " + dc, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); 
                return false;
            }
        }

        Boolean Anular()
        {
            try
            {

                Boolean Respuesta = false;

                if (MessageBox.Show("¿Está seguro que desea anular dicho Comprobante?" + "\n También se procederá con la liberación de los pagos de las órdenes de giro seleccionadas", "Anulación de Comprobante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                    motiAnulacion = fr.motivoAnulacion;


                    Respuesta = UC_Diario_x_NC.Reverso(IdTipoCbteRev, ref IdCbteCbleRev, ref MensajeError, motiAnulacion);
                    if (Respuesta)
                    {
                        info_ba_Cbte_Ban.MotivoAnulacion = motiAnulacion;
                        info_ba_Cbte_Ban.IdUsuario_Anu = param.IdUsuario;
                        info_ba_Cbte_Ban.FechaAnulacion = param.Fecha_Transac;
                        info_ba_Cbte_Ban.IdTipoCbte_Anulacion = IdTipoCbteRev;
                        info_ba_Cbte_Ban.IdCbteCble_Anulacion = IdCbteCbleRev;

                        if (CbteBan_B.AnularDB(info_ba_Cbte_Ban, ref MensajeError))
                        {
                            
                            lblCbt_TipoAnulacion.Visible = true;
                            lblCbt_TipoAnulacion.Visible = true;
                            lblCbt_TipoAnulacion.Text = "**ANULADO** con el Cbt.Cble. de Anu.: " + IdCbteCbleRev.ToString() + " Tipo Cbt.Cble de Anu.: " + IdTipoCbteRev.ToString();

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

        public Boolean Validacion()
        {
            try
            {
                Boolean estado = true;
                Per_I = Per_B.Get_Info_Periodo(param.IdEmpresa, dt_fechaCbte.Value, ref MensajeError);

                if (Per_I.pe_cerrado == "S")
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
                    MessageBox.Show("Antes de continuar seleccione la sucursal.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (ucBa_TipoFlujo.get_TipoFlujoInfo() == null)
                {
                    MessageBox.Show("Antes de continuar seleccione el tipo de flujo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                if (ucbA_TipoNota.get_TipoNotaInfo().IdTipoNota == 0)
                {
                    MessageBox.Show("Antes de continuar seleccione el motivo.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    estado = false;
                    return estado;
                }

                
                int validaCta_convalor = 0;

                if (validaCta_convalor > 0)
                {
                    MessageBox.Show("No se puede grabar Comprobante,  verifique los saldos del debe y haber, que se están enviando con la cuenta contable en blanco ...", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString()); return false;
            }
        }

        Boolean Actualizar()
        {

            try
            {
                Boolean respuesta = false;

                respuesta = Validacion();
                if (respuesta)
                {
                    idCbteCble = info_ba_Cbte_Ban.IdCbteCble;
                    get_CbteBan();
                    respuesta = CbteBan_B.ModificarDB(info_ba_Cbte_Ban, ref MensajeError);

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

        public void Imprimir()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:

                        XBAN_NAT_Rpt001_Rpt reporte_naturisa = new XBAN_NAT_Rpt001_Rpt();
                        reporte_naturisa.RequestParameters = false;
                        ReportPrintTool natu = new ReportPrintTool(reporte_naturisa);
                        natu.AutoShowParametersPanel = false;
                        reporte_naturisa.Parameters["PIdEmpresa"].Value = CbteCble_I.IdEmpresa;
                        reporte_naturisa.Parameters["PIdTipoCbte"].Value = CbteCble_I.IdTipoCbte;
                        reporte_naturisa.Parameters["PIdCbteCble"].Value = CbteCble_I.IdCbteCble;
                        reporte_naturisa.Parameters["PNombreReporte"].Value = "NOTA DE CREDITO";

                        reporte_naturisa.ShowPreview();
                        break;
                    
                    default:
                        XBAN_Rpt012_rpt Reporte = new XBAN_Rpt012_rpt();
                        Reporte.RequestParameters = false;
                        ReportPrintTool pt = new ReportPrintTool(Reporte);
                        pt.AutoShowParametersPanel = false;

                        Reporte.Parameters["PIdEmpresa"].Value = CbteCble_I.IdEmpresa;
                        Reporte.Parameters["PIdTipoCbte"].Value = CbteCble_I.IdTipoCbte;
                        Reporte.Parameters["PIdCbteCble"].Value = CbteCble_I.IdCbteCble;
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

        private void FrmBA_Credito_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                listParaBan = paramBa_B.Get_List_Banco_Parametros(param.IdEmpresa);
                paramBa_I = listParaBan.Find(delegate(ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info P) { return P.CodTipoCbteBan == "NCBA"; });


                if (paramBa_I == null)
                {
                    MessageBox.Show("No puede continuar porque no han ingresado los parámetros de banco..\n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    if (paramBa_I.IdTipoCbteCble == null || paramBa_I.IdTipoCbteCble < 1 || paramBa_I.IdTipoCbteCble_Anu == null || paramBa_I.IdTipoCbteCble_Anu < 1)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de banco.. \n Ingréselos desde la pantalla de parámetros de banco o, comuníquese  con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        _IdTipoCbte_NC = paramBa_I.IdTipoCbteCble;
                        IdTipoCbteRev_NC = paramBa_I.IdTipoCbteCble_Anu;
                        ctaCble_acreedoraCredito = paramBa_I.IdCtaCble;
                    }
                }

                dc = "Credito ";
                _IdTipoCbte = _IdTipoCbte_NC;
                IdTipoCbteRev = IdTipoCbteRev_NC;

                set_Accion_x_controles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (info_ba_Cbte_Ban.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    _Accion = Cl_Enumeradores.eTipo_action.Anular;
                    Grabar();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Credito_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_FrmBA_Credito_Mant_FormClosing(sender, e);
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
            generaDiario();
            if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
            {
                set_CbteCbleInfo();
            }
        }

        private void ultraCmbCtaBanco_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void UltraGrid_Cobros_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (e.HitInfo.Column.Name == "Chek")
                {

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular || _Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                        return;

                    var data = UltraGrid_Cobros.GetRow(e.RowHandle) as cxc_cobro_Info;
                    if ((bool)UltraGrid_Cobros.GetFocusedRowCellValue(Chek))
                    {
                        UltraGrid_Cobros.SetFocusedRowCellValue(Chek, false);
                        ListaSumatoria.Remove(data);
                    }
                    else
                    {
                        UltraGrid_Cobros.SetFocusedRowCellValue(Chek, true);
                        ListaSumatoria.Add(data);

                    }

                    
                }
                generaDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_TipoMovCaj_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lista = new List<cxc_cobro_Info>();
                lista = cxc_B.Get_List_Cobros_x_depositar(param.IdEmpresa, Convert.ToString(cmb_TipoMovCaj.Text));
                Binding_DataSource = new BindingList<cxc_cobro_Info>(lista);
                gridControlCobros.DataSource = Binding_DataSource;  
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
                info_ba_Cbte_Ban = new ba_Cbte_Ban_Info();
                dt_fechaCbte.Value = DateTime.Now;
                txt_Memo.Text = "";
                
                lblCbt_TipoAnulacion.Visible = false;



                _ListaCbteCbleDetAnt = new List<ct_Cbtecble_det_Info>();
                _ListaCbteCbleDet = new List<ct_Cbtecble_det_Info>();
                CbteCble_I = new ct_Cbtecble_Info();
                InfoBancoCta = new ba_Banco_Cuenta_Info();



                Per_I = new ct_Periodo_Info();
                lista = new List<cxc_cobro_Info>();
                ListaSumatoria = new List<cxc_cobro_Info>();
                LstIngrEgrexDepo = new List<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito_Info>();
                Binding_DataSource = new BindingList<cxc_cobro_Info>();

                this.gridControlCobros.DataSource = null;
                UC_Diario_x_NC.LimpiarGrid();
                ucGe_Sucursal.set_SucursalInfo(0);
                ucbA_TipoNota.set_TipoNotaInfo(0);
                ucBa_TipoFlujo.set_TipoFlujoInfo(0);
                ucBa_CuentaBanco.set_BaCuentaInfo(0);
                cmb_TipoMovCaj.Text = "";

                
                set_Accion_x_controles();

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
                        cmb_TipoMovCaj.SelectedIndex = 0;
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_btnGuardar = true;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        txt_Ncomprobante.ReadOnly = true;
                        
                        set_CbteBan_I();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = true;
                        set_CbteBan_I();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntAnular = false;
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
    }
}
