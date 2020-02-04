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
    public partial class frmCon_Punto_Cargo_Grupo_Mant : Form
    {
        #region "Variables Y Propiedades "
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion;
        string MensajeError = string.Empty;
       
        ct_punto_cargo_grupo_Info Info_Pun_Car_Grup = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> Lista_Pun_Car_Grup = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus Bus_Pun_Car_Grup = new ct_punto_cargo_grupo_Bus();

        public delegate void Delegate_frmCon_Punto_Cargo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmCon_Punto_Cargo_Grupo_Mant_FormClosing Event_frmCon_Punto_Cargo_Grupo_Mant_FormClosing;
        #endregion

        #region " Constructor "
        public frmCon_Punto_Cargo_Grupo_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            Event_frmCon_Punto_Cargo_Grupo_Mant_FormClosing += frmCon_Punto_Cargo_Grupo_Mant_Event_frmCon_Punto_Cargo_Grupo_Mant_FormClosing;
        }

        void frmCon_Punto_Cargo_Grupo_Mant_Event_frmCon_Punto_Cargo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region " Eventos "
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
        #endregion

        #region " Evento Load "
        private void frmCon_Punto_Cargo_Grupo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                cmbCuentaContable.cargar_PlanCta();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        txtId.Properties.ReadOnly = true;
                        //txtCodigo.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        Set();
                        txtId.Properties.ReadOnly = true;
                        //txtCodigo.Properties.ReadOnly = true;                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        Set();
                        txtId.Properties.ReadOnly = true;
                        txtCodigo.Properties.ReadOnly = true;
                        cmbCuentaContable.cmbPlanCta.Properties.ReadOnly = true;
                        txtNombre.Properties.ReadOnly = true;                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        Set();
                        txtId.Properties.ReadOnly = true;
                        txtCodigo.Properties.ReadOnly = true;
                        cmbCuentaContable.cmbPlanCta.Properties.ReadOnly = true;
                        txtNombre.Properties.ReadOnly = true;
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
        #endregion

        #region " Set "
        public void SetInfo(ct_punto_cargo_grupo_Info _Info)
        {
            try
            {
                Info_Pun_Car_Grup = _Info;
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
                txtId.EditValue = Info_Pun_Car_Grup.IdPunto_cargo_grupo;
                txtCodigo.Text = Info_Pun_Car_Grup.cod_Punto_cargo_grupo;
                txtNombre.Text = Info_Pun_Car_Grup.nom_punto_cargo_grupo;
                cmbCuentaContable.set_PlanCtarInfo(Info_Pun_Car_Grup.IdCtaCble);
                chkActivo.Checked = Info_Pun_Car_Grup.estado;
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
                Info_Pun_Car_Grup = new ct_punto_cargo_grupo_Info();
                Info_Pun_Car_Grup.IdEmpresa = param.IdEmpresa;
                Info_Pun_Car_Grup.IdPunto_cargo_grupo = txtId.EditValue == "" ? 0 : Convert.ToInt32(txtId.EditValue);
                Info_Pun_Car_Grup.cod_Punto_cargo_grupo = txtCodigo.Text;
                Info_Pun_Car_Grup.nom_punto_cargo_grupo = txtNombre.Text;
                Info_Pun_Car_Grup.IdCtaCble = cmbCuentaContable.get_PlanCtaInfo().IdCtaCble;
                Info_Pun_Car_Grup.estado = chkActivo.Checked;
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
                Get();
                if (Validaciones())
                {
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
                
                    if (Bus_Pun_Car_Grup.GuardarDB(Info_Pun_Car_Grup, ref MensajeError))
                    {
                        res = true;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " El Grupo de Punto Cargo  : " + Info_Pun_Car_Grup.nom_punto_cargo_grupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
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
                if (Bus_Pun_Car_Grup.ModificarDB(Info_Pun_Car_Grup, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " El Grupo de Punto Cargo  : " + Info_Pun_Car_Grup.nom_punto_cargo_grupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (Bus_Pun_Car_Grup.AnularDB(Info_Pun_Car_Grup, ref MensajeError))
                {
                    res = true;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + " El Grupo de Punto Cargo  : " + Info_Pun_Car_Grup.nom_punto_cargo_grupo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtId.EditValue = string.Empty;
                txtCodigo.Text = string.Empty;
                txtNombre.Text = string.Empty;
                cmbCuentaContable.Inicializar_cmbPlanCta();
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
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre del grupo de punto de cargo ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                    return false;
                }

                //if (cmbCuentaContable.cmbPlanCta.EditValue == "" || cmbCuentaContable.cmbPlanCta.EditValue == null)
                //{
                //    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " cuenta contable ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    cmbCuentaContable.Focus();
                //    return false;
                //}
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

        #region " Evento FormClosing"
        private void frmCon_Punto_Cargo_Grupo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCon_Punto_Cargo_Grupo_Mant_FormClosing(sender, e);
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
    }
}
