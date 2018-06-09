using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Winform.Contabilidad;
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

namespace Core.Erp.Winform.Contabilidad_FJ
{
    public partial class frmCon_CentroCosto_x_cliente_Mant : Form
    {
        #region "variables"
       
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ct_Centro_costo_Info Info_centro_costo = new ct_Centro_costo_Info();
        ct_Centro_costo_Bus Centro_costo_Bus = new ct_Centro_costo_Bus();
        Cl_Enumeradores.eTipo_action _Accion;

        List<fa_Cliente_Info> listCliente = new List<fa_Cliente_Info>();
        fa_Cliente_Info Info_Cliente = new fa_Cliente_Info();
        fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();
        fa_cliente_x_ct_centro_costo_Info Cl_x_cc_Info = new fa_cliente_x_ct_centro_costo_Info();
        fa_cliente_x_ct_centro_costo_Bus Cl_x_cc_Bus = new fa_cliente_x_ct_centro_costo_Bus();
        string MensajeError = "";

        public delegate void delegate_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CentroCostos_Man_FormClosing event_frmCon_CentroCostos_Man_FormClosing;
        #endregion 
        public frmCon_CentroCosto_x_cliente_Mant()
        {
            InitializeComponent();
            event_frmCon_CentroCostos_Man_FormClosing += frmCon_CentroCosto_x_cliente_Mant_event_frmCon_CentroCostos_Man_FormClosing;
            
        }

        void frmCon_CentroCosto_x_cliente_Mant_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmCon_CentroCosto_x_cliente_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (_Accion == 0 || _Accion == null)
                    {
                        _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    }
                        cargar_combo_cliente();
                        switch (_Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                limpiarFj();
                                chk_estado.Checked = true;
                                ucGe_Menu.Visible_bntAnular = false;
                                ucGe_Menu.Visible_bntImprimir = false;
                                txt_codigo.Text = Centro_costo_Bus.Get_IdCentroCosto_x_Raiz(param.IdEmpresa, ref MensajeError);
                                break;
                            case Cl_Enumeradores.eTipo_action.actualizar:
                                ucGe_Menu.Enabled_bntAnular = false;
                                ucGe_Menu.Enabled_bntLimpiar = false;
                                ucGe_Menu.Visible_btnGuardar = false;
                                this.txt_codigo.Enabled = false;
                                this.txt_codigo.BackColor = System.Drawing.Color.White;
                                this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                                this.cmbCliente.Enabled = false;
                                set_info_in_controls();
                                break;
                            case Cl_Enumeradores.eTipo_action.Anular:
                                ucGe_Menu.Visible_bntLimpiar = false;
                                ucGe_Menu.Visible_btnGuardar = false;
                                ucGe_Menu.Visible_bntImprimir = false;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                this.cmbCliente.Enabled = false;
                                this.txt_codigo.Enabled = false;
                                this.txt_codigo.BackColor = System.Drawing.Color.White;
                                this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                                set_info_in_controls();
                                break;
                            case Cl_Enumeradores.eTipo_action.consultar:
                                ucGe_Menu.Visible_bntLimpiar = false;
                                ucGe_Menu.Visible_btnGuardar = false;
                                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                ucGe_Menu.Visible_bntAnular = false;
                                this.cmbCliente.Enabled = false;
                                this.txt_codigo.Enabled = false;
                                this.txt_codigo.BackColor = System.Drawing.Color.White;
                                this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                                set_info_in_controls();
                                break;
                            default:
                                break;
                        }
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region "Set"
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
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setInfo(ct_Centro_costo_Info _Info)
        {
            try
            {
                Info_centro_costo = _Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_info_in_controls()
        {

            try
            {
                txt_codigo.Text = Info_centro_costo.IdCentroCosto;
                cmbCliente.EditValue = Info_centro_costo.IdCliente_cli;
                txt_nombre.Text = Info_centro_costo.Centro_costo;
                chk_estado.Checked = (Info_centro_costo.pc_Estado == "A") ? true : false;
                if (Info_centro_costo.pc_Estado == "I")
                {
                    lblAnulado.Visible = true;
                }
                else
                {
                    lblAnulado.Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void get_info_CentroCosto_x_Cliente()
        {

            try
            {
                if (cmbCliente.EditValue != null && cmbCliente.EditValue != "Vacio")
                    Info_Cliente = listCliente.FirstOrDefault(v => v.IdCliente == Convert.ToDecimal(cmbCliente.EditValue));

                Cl_x_cc_Info.IdCentroCosto_cc = Info_centro_costo.IdCentroCosto;
                Cl_x_cc_Info.IdEmpresa_cc = Info_centro_costo.IdEmpresa;
                if (cmbCliente.EditValue != null)
                {
                    Cl_x_cc_Info.IdCliente_cli = Info_Cliente.IdCliente;
                    Cl_x_cc_Info.IdEmpresa_cli = Info_Cliente.IdEmpresa;
                    Cl_x_cc_Info.nom_Cliente = Info_Cliente.Persona_Info.pe_razonSocial;
                }
                Cl_x_cc_Info.nom_Centro_costo = Info_centro_costo.Centro_costo;
                Cl_x_cc_Info.Observacion = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Get"
        private void get_info()
        {

            try
            {
                Info_centro_costo.IdEmpresa = param.IdEmpresa;
                Info_centro_costo.IdCentroCosto = txt_codigo.Text;
                Info_centro_costo.Centro_costo = txt_nombre.Text;
                Info_centro_costo.pc_Estado = (chk_estado.Checked) ? "A" : "I";
                Info_centro_costo.pc_EsMovimiento = "S";
                Info_centro_costo.IdCtaCble = null;
                Info_centro_costo.IdNivel = 1;
                Info_centro_costo.IdCentroCostoPadre = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Validaciones"
        private Boolean validar()
        {

            try
            {
                Boolean res = true;
                if (cmbCliente.EditValue == "" && cmbCliente.EditValue == null || cmbCliente.EditValue == "[Vacio]")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " cliente ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCliente.Focus();
                    return false;
                }


                if (txt_nombre.Text == "" || txt_nombre.Text == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre del cliente ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_nombre.Focus();
                    return false;
                }

                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region "Limpiar"
        private void limpiarFj()
        {
            try
            {
                txt_codigo.Text = string.Empty;
                txt_nombre.Text = string.Empty;
                txt_nombre.Enabled = true;
                Info_Cliente = new fa_Cliente_Info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region"Cargar Combo"
        private void cargar_combo_cliente()
        {
            try
            {
                listCliente = new List<fa_Cliente_Info>();
                listCliente = BusCliente.Get_List_Clientes(param.IdEmpresa);
                cmbCliente.Properties.DataSource = listCliente;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region " guardar, actualizar, anular"
        Boolean Guardar()
        {
            try
            {
                Boolean Res = false;
                get_info();
                Info_centro_costo.Fecha_Transac = DateTime.Now;
                Info_centro_costo.IdUsuario = param.IdUsuario;
                Res = Centro_costo_Bus.GrabarDB(Info_centro_costo, ref  MensajeError);
                if (Res)
                {
                   //Guardar en tabla intermedia
                    Cl_x_cc_Info = new fa_cliente_x_ct_centro_costo_Info();
                    get_info_CentroCosto_x_Cliente();
                    if (Cl_x_cc_Info.IdCliente_cli != 0)
                        Res = Cl_x_cc_Bus.GrabarBD(Cl_x_cc_Info, ref MensajeError);
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardaron_los_datos_correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Visible_btnGuardar = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    cmbCliente.EditValue = "[Vacio]";
                    limpiarFj();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    txt_codigo.Text = Centro_costo_Bus.Get_IdCentroCosto_x_Raiz(param.IdEmpresa, ref MensajeError);
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(MensajeError + " " + smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Actualizar()
        {
            try
            {
                Boolean Res = false;
                Info_centro_costo.Fecha_UltMod = DateTime.Now;
                Info_centro_costo.IdUsuarioUltMod = param.IdUsuario;
                Res = Centro_costo_Bus.ModificarDB(Info_centro_costo, ref  MensajeError);
                if (Res)
                {
                    Cl_x_cc_Info = new fa_cliente_x_ct_centro_costo_Info();
                    get_info_CentroCosto_x_Cliente();
                    if (Cl_x_cc_Info.IdCliente_cli != 0)
                        Res = Cl_x_cc_Bus.ModificarBD(Cl_x_cc_Info, ref MensajeError);
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Visible_btnGuardar = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        cmbCliente.EditValue = "[Vacio]";
                        limpiarFj();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return Res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean grabar()
        {
            try
            {
                Boolean Res = false;
                if (validar() == false)
                    { return false; }
                    get_info();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Res = Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Res = Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    default:
                        break;
                }
                return Res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean anular()
        {
            try
            {
                Boolean res = false;
                if (Info_centro_costo != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (Info_centro_costo.pc_Estado == "A")
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) + " cuenta " + Info_centro_costo.Centro_costo2, param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            Info_centro_costo.MotivoAnulacion = oFrm.motivoAnulacion;
                            Info_centro_costo.Fecha_UltAnu = param.Fecha_Transac;
                            Info_centro_costo.IdUsuarioUltAnu = param.IdUsuario;

                            //InfoPlanCta.dv_observacion = "***ANULADO****" + _Info_dev_compra.dv_observacion;
                            if (Centro_costo_Bus.AnularDB(Info_centro_costo, ref msg))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Info_centro_costo.pc_Estado = "I";
                                lblAnulado.Visible = true;
                                res = true;
                                _Accion = Cl_Enumeradores.eTipo_action.consultar;
                            }
                        }
                    }
                    else if (Info_centro_costo.pc_Estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la cuenta : " + Info_centro_costo.Centro_costo2 + "," + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        private void cmbCliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.EditValue != null && cmbCliente.EditValue != "[Vacio]" && cmbCliente.EditValue != "")
                {
                    Info_Cliente = listCliente.FirstOrDefault(w => w.IdCliente == Convert.ToDecimal(cmbCliente.EditValue));

                    txt_nombre.Text = Info_Cliente.Persona_Info.pe_razonSocial;
                }
                else
                {
                    txt_nombre.Enabled = true;
                    txt_nombre.Text = "";
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            grabar();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (grabar())
                this.Close();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            if (anular())
                this.Close();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCon_CentroCosto_x_cliente_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCon_CentroCostos_Man_FormClosing(sender, e);
        }

    }
}
