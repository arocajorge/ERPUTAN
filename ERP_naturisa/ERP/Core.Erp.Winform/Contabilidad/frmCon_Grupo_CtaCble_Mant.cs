using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Grupo_CtaCble_Mant : Form
    {
        #region "Variables Y Propiedades "
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string MensajeError = string.Empty;

        ct_Grupocble_Info Info_Grup_CtaCble = new ct_Grupocble_Info();
        List<ct_Grupocble_Info> Lista_Grup_CtaCble = new List<ct_Grupocble_Info>();
        ct_Grupocble_Bus Bus_Grup_CtaCble = new ct_Grupocble_Bus();

        public delegate void Delegate_frmCon_Grupo_CtaCble_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmCon_Grupo_CtaCble_Mant_FormClosing Event_frmCon_Grupo_CtaCble_Mant_FormClosing;
        #endregion

        public frmCon_Grupo_CtaCble_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            Event_frmCon_Grupo_CtaCble_Mant_FormClosing += frmCon_Grupo_CtaCble_Mant_Event_frmCon_Grupo_CtaCble_Mant_FormClosing;
        }

        void frmCon_Grupo_CtaCble_Mant_Event_frmCon_Grupo_CtaCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
            if (GrabarDatos())
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrabarDatos())
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

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GrabarDatos();
                 
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

        #region " LLenar Combos "
        private void CargarCombos()
        {
            try
            {

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

        #endregion

        #region " Set "
        public void SetInfo(ct_Grupocble_Info _Info)
        {
            try
            {
                Info_Grup_CtaCble = _Info;
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

        public void SetAccion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
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

        public void Set()
        {
            try
            {
                txtIdGrupCtaCble.Text = Info_Grup_CtaCble.IdGrupoCble;
                txtDescripcion.Text = Info_Grup_CtaCble.gc_GrupoCble;
                comboBoxEstadoFinanciero.Text = Info_Grup_CtaCble.gc_estado_financiero;
                comboBoxSumaRestaER.EditValue = Info_Grup_CtaCble.gc_signo_operacion;
                spinNumeric.Value = Info_Grup_CtaCble.gc_Orden;
                if (chkActivo.Checked == true)
                {
                    lblAnulado.Visible = false;
                }
                else
                    lblAnulado.Visible = true;
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
        #endregion

        #region " Get "
        private void Get()
        {
            try
            {
                Info_Grup_CtaCble = new ct_Grupocble_Info();
                Info_Grup_CtaCble.IdGrupoCble = txtIdGrupCtaCble.Text;
                Info_Grup_CtaCble.gc_GrupoCble = txtDescripcion.Text;
                Info_Grup_CtaCble.gc_estado_financiero = comboBoxEstadoFinanciero.Text;
                Info_Grup_CtaCble.gc_signo_operacion = Convert.ToInt32(comboBoxSumaRestaER.EditValue);
                 Info_Grup_CtaCble.gc_Orden = Convert.ToInt32(spinNumeric.Value);
                if (chkActivo.Checked == true)
                {
                    Info_Grup_CtaCble.Estado = "A";
                }
                else
                    Info_Grup_CtaCble.Estado = "I";
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
        #endregion

        #region "GrabarDatos"
        private Boolean GrabarDatos()
        {
            try
            {
                Boolean respuesta = false;
                
                if (Validaciones())
                {
                    Get();
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            respuesta = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            respuesta = Modificar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            respuesta = Anular();
                            break;
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
        #endregion

        #region " Guardar, Modificar, Anular "
        private Boolean Guardar()
        {
            try
            {
                Boolean res = false;

                if (Bus_Grup_CtaCble.GrabarDB(Info_Grup_CtaCble, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " El Grupo CtaCbl  : " + Info_Grup_CtaCble.IdGrupoCble, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + " : "+ MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                return res;
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

        private Boolean Modificar()
        {
            try
            {
                Boolean res = false;
                if (Bus_Grup_CtaCble.ModificarDB(Info_Grup_CtaCble, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " El Grupo CtaCbl  : " + Info_Grup_CtaCble.IdGrupoCble, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return res;
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
                Boolean res = false;
                if (Bus_Grup_CtaCble.EliminarDB(Info_Grup_CtaCble, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " El Grupo CtaCbl  : " + Info_Grup_CtaCble.IdGrupoCble, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return res;
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
        #endregion

        #region " Limpiar "
        private void Limpiar()
        {
            try
            {
                txtIdGrupCtaCble.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                spinNumeric.Value = 0;
                comboBoxSumaRestaER.EditValue = null;
                comboBoxEstadoFinanciero.EditValue = null;
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
        #endregion

        #region " Validacion "
        public Boolean Validaciones()
        {
            try
            {

                Boolean res = true;
                if (string.IsNullOrEmpty(txtIdGrupCtaCble.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Id del grupo cuenta contable ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdGrupCtaCble.Focus();
                    return false;
                }


                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripción del grupo cuenta contable ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescripcion.Focus();
                    return false;
                }
                if (comboBoxEstadoFinanciero.EditValue == "" || comboBoxEstadoFinanciero.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Estado Financero de la cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBoxEstadoFinanciero.Focus();
                    return false;
                }

                if (comboBoxSumaRestaER.EditValue == "" || comboBoxSumaRestaER.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " Escoja si el grupo cuenta contable suma o resta al Estado de Resultado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    comboBoxSumaRestaER.Focus();
                    return false;
                }
                
                return res;

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
        #endregion

        private void frmCon_Grupo_CtaCble_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        Set();
                        txtIdGrupCtaCble.Properties.ReadOnly = true;                      
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        Set();
                        txtIdGrupCtaCble.Properties.ReadOnly = true;
                        txtDescripcion.Properties.ReadOnly = true;
                        spinNumeric.Properties.ReadOnly = true;
                        comboBoxEstadoFinanciero.Properties.ReadOnly = true;
                        comboBoxSumaRestaER.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        Set();
                        txtIdGrupCtaCble.Properties.ReadOnly = true;
                        txtDescripcion.Properties.ReadOnly = true;
                        spinNumeric.Properties.ReadOnly = true;
                        comboBoxEstadoFinanciero.Properties.ReadOnly = true;
                        comboBoxSumaRestaER.Properties.ReadOnly = true;
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

        private void frmCon_Grupo_CtaCble_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCon_Grupo_CtaCble_Mant_FormClosing(sender, e);
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
