using Core.Erp.Business.General;
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
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaInstitucionFinanciera_Mant : Form
    {
        #region "Variables"
        Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_InstitucionFinanciera_Info InstitucionFinaciero_Info = new Aca_InstitucionFinanciera_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_FrmAcaInstitucionFinanciera_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaInstitucionFinanciera_Mant_FormClosing event_FrmAcaInstitucionFinanciera_Mant_FormClosing;
        #endregion

        #region "Set"
        public void Set_Accion(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                Accion = accion;
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

        public void Set_InstitucionFinanciera(Aca_InstitucionFinanciera_Info institucionFiInfo)
        {
            try
            {
                InstitucionFinaciero_Info = institucionFiInfo;
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
        public Aca_InstitucionFinanciera_Info Get_InstitucionFinanciera(ref string mensaje)
        {
            try
            {
                InstitucionFinaciero_Info.IdInstitucionFinanciera = Convert.ToInt16( txtIdInstitucionFinanciera.Text);
                InstitucionFinaciero_Info.IdTipoCuentaCatalogo = cmbTipoCuenta.EditValue == null ? "" : cmbTipoCuenta.EditValue.ToString();
                
                
                InstitucionFinaciero_Info.CodigoInstitucion = txtCodigoInstitucion.Text;
                InstitucionFinaciero_Info.NombreInstitucion = txtNombreInstitucion.Text;
                InstitucionFinaciero_Info.CodigoAlterno = txtCodigoAlterno.Text;
                InstitucionFinaciero_Info.NombreAlterno = txtNombreAlterno.Text;
                InstitucionFinaciero_Info.Porc_comision = Convert.ToDecimal( txtPorcentajeComision.EditValue);

                if (chkbEstado.Checked == true)
                {
                    InstitucionFinaciero_Info.Estado = "A";
                }
                else
                {
                    InstitucionFinaciero_Info.Estado = "I";
                }
                return InstitucionFinaciero_Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return InstitucionFinaciero_Info;
            }
        }
        #endregion

        #region "Cargar Datos"
        void Cargar_Controles()
        {
            try
            {
                
                txtCodigoInstitucion.Text = InstitucionFinaciero_Info.CodigoInstitucion;
                txtIdInstitucionFinanciera.Text = InstitucionFinaciero_Info.IdInstitucionFinanciera.ToString();
                
                txtNombreInstitucion.Text = InstitucionFinaciero_Info.NombreInstitucion;

                if(!String.IsNullOrEmpty(InstitucionFinaciero_Info.CodigoAlterno))
                    txtCodigoAlterno.Text = InstitucionFinaciero_Info.CodigoAlterno.ToString();
                if (!String.IsNullOrEmpty(InstitucionFinaciero_Info.NombreAlterno))
                    txtNombreAlterno.Text = InstitucionFinaciero_Info.NombreAlterno;

                txtPorcentajeComision.Text = InstitucionFinaciero_Info.Porc_comision.ToString();
                cmbTipoCuenta.EditValue = (InstitucionFinaciero_Info.IdTipoCuentaCatalogo==null || InstitucionFinaciero_Info.IdTipoCuentaCatalogo=="")? "TARJE":InstitucionFinaciero_Info.IdTipoCuentaCatalogo;

                if (InstitucionFinaciero_Info.Estado == "I")
                {
                    ucGe_Menu.Enabled_bntAnular = false;
                    lblEstado.Visible = true;
                    chkbEstado.Checked = false;
                }
                else
                {
                    lblEstado.Visible = false;
                    chkbEstado.Checked = true;
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

        public void CargarCombo() {
            // cmbTipoCuenta
            Aca_Catalogo_Bus negc = new Aca_Catalogo_Bus();
            this.cmbTipoCuenta.Properties.DataSource = negc.Get_List_CatalogoXtipo("TIPOCUEN");            
        }
        #endregion

        #region "Proceso"

        #region "Grabar,Actualizar,Eliminar"
        private bool Grabar()
        {
            try
            {
                Aca_InstitucionFinanciera_Info infoIF = new Aca_InstitucionFinanciera_Info();
                Aca_InstitucionFinanciera_Bus negIF = new Aca_InstitucionFinanciera_Bus();

                int idInstitucionFinanciera = 0;
                string mensaje = string.Empty;
                infoIF = Get_InstitucionFinanciera(ref mensaje);

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                infoIF.FechaCreacion = DateTime.Now;
                infoIF.UsuarioCreacion = param.IdUsuario;

                bool resultado = negIF.GrabarDB(infoIF, ref idInstitucionFinanciera, ref mensaje);
                txtIdInstitucionFinanciera.Text = idInstitucionFinanciera.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
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

        private bool Actualizar()
        {
            try
            {
                Aca_InstitucionFinanciera_Bus negIF = new Aca_InstitucionFinanciera_Bus();
                Aca_InstitucionFinanciera_Info infoIF = new Aca_InstitucionFinanciera_Info();
                string mensaje = string.Empty;

                infoIF = Get_InstitucionFinanciera(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                infoIF.FechaModificacion = DateTime.Now;
                infoIF.UsuarioModificacion = param.IdUsuario;
                bool resultado = negIF.ActualizarDB(infoIF, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        private bool Anular()
        {
            try
            {
                if (InstitucionFinaciero_Info.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) +" Institución Financiera " + txtIdInstitucionFinanciera.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = fr.motivoAnulacion;

                        Aca_InstitucionFinanciera_Bus negIF = new Aca_InstitucionFinanciera_Bus();
                        Aca_InstitucionFinanciera_Info infoIF = new Aca_InstitucionFinanciera_Info();
                        string mensaje = string.Empty;

                        infoIF = Get_InstitucionFinanciera(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        infoIF.MotivoAnulacion = motiAnulacion;
                        infoIF.UsuarioAnulacion = param.IdUsuario;
                        bool resultado = negIF.EliminarDB(infoIF, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                            return true;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                else { MessageBox.Show("La Institución Financiera " + txtIdInstitucionFinanciera.Text + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information); }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }


        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                          resultado=  Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                          resultado=  Actualizar();
                            break;
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
            return resultado;
        }
        #endregion

        public bool validaciones() {
            try
            {
                if (cmbTipoCuenta.EditValue==null || cmbTipoCuenta.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " tipo de cuenta ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoCuenta.Focus();
                    return false;
                }

                if (txtCodigoInstitucion.Text=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " código de la Institución Financiera", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoInstitucion.Focus();
                    return false;
                }

                if (txtNombreInstitucion.Text=="")
                {  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre de la Institución Financiera ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreInstitucion.Focus();
                    return false;                    
                }

                if (txtCodigoAlterno.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " código alterno de la Institución Financiera", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoAlterno.Focus();
                    return false;
                }

                if (txtNombreAlterno.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre alterno de la Institución Financiera ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombreAlterno.Focus();
                    return false;
                }    

                if (txtPorcentajeComision.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " porcentaje de comisión ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPorcentajeComision.Focus();
                    return false;
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

        public void LimpiarPantalla()
        {

            txtCodigoInstitucion.Text = string.Empty;
            txtIdInstitucionFinanciera.Text = string.Empty;
            txtNombreInstitucion.Text = string.Empty;
            txtPorcentajeComision.Text = string.Empty;
        }
        #endregion

        #region "Eventos"
        public FrmAcaInstitucionFinanciera_Mant()
        {
            InitializeComponent();
            event_FrmAcaInstitucionFinanciera_Mant_FormClosing += FrmAcaInstitucionFinanciera_Mant_event_FrmAcaInstitucionFinanciera_Mant_FormClosing;
        }

        void FrmAcaInstitucionFinanciera_Mant_event_FrmAcaInstitucionFinanciera_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void FrmAcaInstitucionFinanciera_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaInstitucionFinanciera_Mant_FormClosing(sender, e);
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

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }     

        private void FrmAcaInstitucionFinanciera_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                LimpiarPantalla();
                CargarCombo();
                Cargar_Controles();
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:                        
                        break;

                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;                        
                        chkbEstado.Checked = true;
                        chkbEstado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular: 
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;

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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool resultado = guardarDatos();
            if (resultado)
            {
                Close();
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        #endregion

        
    }
}
