using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CentroCostos_Man : Form
    {
        #region "variables"
        public delegate void delegate_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CentroCostos_Man_FormClosing event_frmCon_CentroCostos_Man_FormClosing;

        string MensajeError = "";

        ct_Centro_costo_nivel_Bus BusNivel = new ct_Centro_costo_nivel_Bus();
        List<ct_Centro_costo_nivel_Info> ListNivelCta = new List<ct_Centro_costo_nivel_Info>();
        ct_Centro_costo_Bus Centro_costo_Bus = new ct_Centro_costo_Bus();

        List<ct_Centro_costo_Info> listCentro_costo_padre = new List<ct_Centro_costo_Info>();

        public ct_Centro_costo_Info Info_centro_costo = new ct_Centro_costo_Info();
        public ct_Centro_costo_Info Info_padre_centro_costo = new ct_Centro_costo_Info();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public Cl_Enumeradores.eTipo_action _Accion;

        frmCon_PlanCuenta_Mant frm;
        #endregion 

        #region"Constructor"
        public frmCon_CentroCostos_Man()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += this.ucGe_Menu_Superior_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += this.ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += this.ucGe_Menu_Superior_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += this.ucGe_Menu_Superior_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += this.ucGe_Menu_Superior_event_btnAnular_Click;

            event_frmCon_CentroCostos_Man_FormClosing+=frmCon_CentroCostos_Man_event_frmCon_CentroCostos_Man_FormClosing;
            this.Load += new System.EventHandler(this.frmCon_CentroCostos_Man_Load);
            this.cmb_centro_costo_padre.EditValueChanged += new System.EventHandler(this.cmb_centro_costo_padre_EditValueChanged);
        }
        #endregion

        void frmCon_CentroCostos_Man_event_frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        #region Handler
        
        #region "set"
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

        public void set_info(ct_Centro_costo_Info _Info)
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

        private void set_info_in_controlsGe()
        {
            try
            {
                if (Info_centro_costo != null)
                {

                    txt_codigo.Text = Info_centro_costo.IdCentroCosto;
                    txt_nombre.Text = Info_centro_costo.Centro_costo;
                    cmb_centro_costo_padre.EditValue = Info_centro_costo.IdCentroCostoPadre;
                    cmb_nivel.SelectedValue = Info_centro_costo.IdNivel;
                    //cmb_centro_costo_padre.Properties.DataSource;
                    chk_es_cta_movi.Checked = (Info_centro_costo.pc_EsMovimiento == "S") ? true : false;
                    chk_estado.Checked = (Info_centro_costo.pc_Estado == "A") ? true : false;
                    txt_codigo_alterno.Text = Info_centro_costo.CodCentroCosto;
                    cmb_ctaCble.set_IdCtaCble(Info_centro_costo.IdCtaCble);
                    if (Info_centro_costo.pc_Estado == "I")
                    {
                        lblAnulado.Visible = true;
                    }
                    else
                    {
                        lblAnulado.Visible = false;
                    }
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

       

        #endregion
        
        #region "eventos" 
        public void frmCon_CentroCostos_Man_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0)
                {
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }             
                    cargar_combo();
                    set_accionGe();      
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

        public void ucGe_Menu_Superior_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
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

        public void ucGe_Menu_Superior_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        public void ucGe_Menu_Superior_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarGe();
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

        public void ucGe_Menu_Superior_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuardarDatos() == true)
                {
                    this.Close();
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

        public void ucGe_Menu_Superior_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarDatos();
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

        #region"Validaciones"
        private Boolean validarGe()
        {

            try
            {
                Boolean res = true;
              
                if (txt_nombre.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " el nombre del centro costo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmb_nivel.SelectedValue == null)
                {
                    if (cmb_nivel.SelectedValue == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " niveles para el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("El nivel no puede ser 0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
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

        #region"Get"
        private void get_infoGe()
        {

            try
            {
                Info_centro_costo.IdEmpresa = param.IdEmpresa;
                Info_centro_costo.IdCentroCosto = txt_codigo.Text;
                Info_centro_costo.Centro_costo = txt_nombre.Text;
                Info_centro_costo.IdCentroCostoPadre = (cmb_centro_costo_padre.EditValue == null || cmb_centro_costo_padre.EditValue == "") ? "" : (string)cmb_centro_costo_padre.EditValue;
                Info_centro_costo.IdNivel = ((Int32)cmb_nivel.SelectedValue == 0) ? 1 : (Int32)cmb_nivel.SelectedValue;
                Info_centro_costo.pc_EsMovimiento = (chk_es_cta_movi.Checked == true) ? "S" : "N";
                Info_centro_costo.pc_Estado = (chk_estado.Checked) ? "A" : "I";
                Info_centro_costo.CodCentroCosto = (txt_codigo_alterno.Text == null || txt_codigo_alterno.Text == "") ? null : txt_codigo_alterno.Text.Trim();
                Info_centro_costo.IdCtaCble = (cmb_ctaCble.get_CuentaInfo() == null) ? null : cmb_ctaCble.get_CuentaInfo().IdCtaCble;
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

        private void set_accionGe()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        limpiarGe();
                        chk_estado.Checked = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                        this.cmb_centro_costo_padre.Enabled = false;
                        set_info_in_controlsGe();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.cmb_centro_costo_padre.Enabled = false;
                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                        set_info_in_controlsGe();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.cmb_centro_costo_padre.Enabled = false;
                        this.txt_codigo.Enabled = false;
                        this.txt_codigo.BackColor = System.Drawing.Color.White;
                        this.txt_codigo.ForeColor = System.Drawing.Color.Black;
                        set_info_in_controlsGe();
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

        #region "Limpiar" 
        public void limpiarGe()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_centro_costo = new ct_Centro_costo_Info();
                txt_codigo.Text = "";
                txt_nombre.Text = "";
                cmb_centro_costo_padre.EditValue = "";
                cmb_centro_costo_padre.Enabled = true;
                cmb_nivel.SelectedValue = 1;
                chk_es_cta_movi.Checked = false;
                chk_estado.Checked = true;
                lblAnulado.Visible = false;
                txt_codigo_alterno.Text = "";
                txt_codigo.Clear();
                txt_nombre.Clear();
                Info_centro_costo = new ct_Centro_costo_Info();
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
        private void cargar_combo()
        {
            try
            {
                listCentro_costo_padre = Centro_costo_Bus.Get_list_Centro_Costo_cuentas_padre(param.IdEmpresa, ref MensajeError);
              
                    cmb_centro_costo_padre.Properties.DataSource = listCentro_costo_padre;
                    ListNivelCta = BusNivel.Get_list_Centro_costo_nivel(param.IdEmpresa);
                    cmb_nivel.DataSource = ListNivelCta;
                    cmb_nivel.ValueMember = "IdNivel";
                    cmb_nivel.DisplayMember = "IdNivel";
                    cmb_nivel.SelectedValue = 1;
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
                
                Info_centro_costo.Fecha_Transac = DateTime.Now;
                Info_centro_costo.IdUsuario = param.IdUsuario;
                Res = Centro_costo_Bus.GrabarDB(Info_centro_costo, ref  MensajeError);
                if (Res)
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "", Info_centro_costo.IdCtaCble + "-" + Info_centro_costo.Centro_costo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    ucGe_Menu.Visible_btnGuardar = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        limpiarGe();
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
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucGe_Menu.Visible_btnGuardar = true;
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        limpiarGe();
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

        Boolean GuardarDatos()
        {
            try
            {
                Boolean Res = false;            
                
                 if (validarGe() == false)
                    { return false; }
                    get_infoGe();
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

        public void anular()
        {
            try
            {
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
                                _Accion = Cl_Enumeradores.eTipo_action.consultar;
                            }
                        }
                    }
                    else if (Info_centro_costo.pc_Estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la cuenta : " + Info_centro_costo.Centro_costo2 + "," + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        #endregion

        public void cmb_centro_costo_padre_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Info_padre_centro_costo = listCentro_costo_padre.FirstOrDefault(v => v.IdCentroCosto == Convert.ToString(cmb_centro_costo_padre.EditValue));
                string MensajeError = "";

                if (_Accion == Info.General.Cl_Enumeradores.eTipo_action.grabar && Info_padre_centro_costo != null)
                {
                    txt_codigo.Text = Info_padre_centro_costo.IdCentroCosto + Centro_costo_Bus.Get_IdCentroCosto(Info_padre_centro_costo.IdEmpresa, Info_padre_centro_costo, ref MensajeError);
                    txt_nombre.Text = Info_padre_centro_costo.Centro_costo;
                    cmb_nivel.SelectedValue = Info_padre_centro_costo.IdNivel + 1;
                    chk_estado.Checked = true;

                    var maxvalue = ListNivelCta.Max(x => x.IdNivel);

                    if ((Int32)maxvalue == Info_padre_centro_costo.IdNivel + 1)
                    { chk_es_cta_movi.Checked = true; }
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
        #endregion

        private void frmCon_CentroCostos_Man_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_CentroCostos_Man_FormClosing(sender, e);
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

    }
}
