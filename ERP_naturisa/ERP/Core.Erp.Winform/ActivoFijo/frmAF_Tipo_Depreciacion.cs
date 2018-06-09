using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Tipo_Depreciacion : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        Af_Tipo_Depreciacion_Info info;
        public delegate void delegate_frmAF_Tipo_Depreciacion_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmAF_Tipo_Depreciacion_FormClosing event_frmAF_Tipo_Depreciacion_FormClosing;
        string msg = "";
        #endregion

        public frmAF_Tipo_Depreciacion()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            event_frmAF_Tipo_Depreciacion_FormClosing += new delegate_frmAF_Tipo_Depreciacion_FormClosing(frmAF_Tipo_Depreciacion_event_frmAF_Tipo_Depreciacion_FormClosing);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmAF_Tipo_Depreciacion_event_frmAF_Tipo_Depreciacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
               if (grabar())
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool grabar()
        {
            try
            {
                Af_Tipo_Depreciacion_Bus bus_act_fijo_tip = new Af_Tipo_Depreciacion_Bus();
                int id = 0;
                string msg = "";
                Boolean bolResult = false;
                get_Af_Tipo_Depreciacion();
                if (txtnom_tipo_depreciacion.Text == "" || txtnom_tipo_depreciacion.Text == null)
                {
                    bolResult = false;
                }
                else
                {
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            if (bus_act_fijo_tip.GrabarDB(info, ref id, ref msg))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                LimpiarDatos();
                            }
                            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            if (bus_act_fijo_tip.ModificarDB(info, ref msg))
                            {
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                bolResult = true;
                                LimpiarDatos();
                            }
                            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();
                            info.IdUsuarioUltAnu = param.IdUsuario;
                            info.Fecha_UltAnu = DateTime.Now;
                            info.MotiAnula = ofrm.motivoAnulacion;

                            if (bus_act_fijo_tip.AnularDB(info, ref msg))
                            {
                                ucGe_Menu.Enabled_bntAnular = false;
                                bolResult = true;
                                lblEstado.Visible = true;
                            }
                            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }

                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                info = new Af_Tipo_Depreciacion_Info();
                this.txtIdTipoDepreciacion.Text = "";
                this.txtcod_tipo_depreciacion.Text = "";
                this.txtnom_tipo_depreciacion.Text = "";
                chk_estado.Checked = true;
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblEstado.Visible == true)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema);
                }
                else
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_Tipo_Depreciacion_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtcod_tipo_depreciacion.Enabled = true;
                        this.txtIdTipoDepreciacion.Enabled = false;
                        this.txtnom_tipo_depreciacion.Enabled = true;
                        chk_estado.Enabled = true;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtcod_tipo_depreciacion.Enabled = true;
                        this.txtIdTipoDepreciacion.Enabled = false;
                        this.txtnom_tipo_depreciacion.Enabled = true;
                        chk_estado.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        this.txtcod_tipo_depreciacion.Enabled = false;
                        this.txtIdTipoDepreciacion.Enabled = false;
                        this.txtnom_tipo_depreciacion.Enabled = false;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.txtcod_tipo_depreciacion.Enabled = false;
                        this.txtIdTipoDepreciacion.Enabled = false;
                        this.txtnom_tipo_depreciacion.Enabled = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void set_Af_Tipo_Depreciacion(Af_Tipo_Depreciacion_Info obj)
        {
            try
            {
                this.txtIdTipoDepreciacion.Text = obj.IdTipoDepreciacion.ToString();
                this.txtcod_tipo_depreciacion.Text = obj.cod_tipo_depreciacion.ToString();
                this.txtnom_tipo_depreciacion.Text = obj.nom_tipo_depreciacion.ToString();
                chk_estado.Checked = (obj.estado == "A")? true: false;
                lblEstado.Visible = (obj.estado == "I")? true : false;

                info = obj;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Af_Tipo_Depreciacion_Info get_Af_Tipo_Depreciacion()
        {
            try
            {
                info = new Af_Tipo_Depreciacion_Info();
                info.IdTipoDepreciacion = (this.txtIdTipoDepreciacion.Text != "") ? Convert.ToInt32(this.txtIdTipoDepreciacion.Text) : 0; 
                info.cod_tipo_depreciacion=this.txtcod_tipo_depreciacion.Text;
                info.nom_tipo_depreciacion= this.txtnom_tipo_depreciacion.Text;
                info.estado = (chk_estado.Checked)? "A" : "I";
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Af_Tipo_Depreciacion_Info();
            }

        }

        private void frmAF_Tipo_Depreciacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmAF_Tipo_Depreciacion_event_frmAF_Tipo_Depreciacion_FormClosing(sender, e);
                event_frmAF_Tipo_Depreciacion_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
