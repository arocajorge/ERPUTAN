using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CentroCostos_Nivel_Mant : Form
    {
        #region Declaración de Variables
        public ct_Centro_costo_nivel_Info _CentroCostoNivelInfo = new ct_Centro_costo_nivel_Info();
        public ct_Centro_costo_nivel_Bus _CentroCostoNivelBus = new ct_Centro_costo_nivel_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public delegate void delegate_frmCon_CentroCostos_Nivel_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_CentroCostos_Nivel_Mant_FormClosing event_frmCon_CentroCostos_Nivel_Mant_FormClosing;

        #endregion

        public frmCon_CentroCostos_Nivel_Mant()
        {
            InitializeComponent();
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_CentroCostos_Nivel_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.lblnivel.Text = _CentroCostoNivelBus.Get_Id(param.IdEmpresa).ToString();
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.txtdescripcion.Enabled = false;
                        this.num_digitos.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        this.txtdescripcion.Enabled = false;
                        this.num_digitos.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_CentroCostoNivel(ct_Centro_costo_nivel_Info info)
        {
            try
            {
                lblnivel.Text = info.IdNivel.ToString();
                txtdescripcion.Text = info.ni_descripcion;
                num_digitos.Value = Convert.ToInt32(info.ni_digitos);
                chk_estado.Checked = (info.Estado == "A") ? true : false;
                _CentroCostoNivelInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public ct_Centro_costo_nivel_Info get_CentroCostoNivel(int idempresa)
        {
            try
            {
                _CentroCostoNivelInfo.IdEmpresa = idempresa;
                _CentroCostoNivelInfo.IdNivel = Convert.ToInt32(lblnivel.Text);
                _CentroCostoNivelInfo.ni_descripcion = txtdescripcion.Text;
                _CentroCostoNivelInfo.ni_digitos = Convert.ToByte(num_digitos.Value);
                _CentroCostoNivelInfo.Estado = (chk_estado.Checked == true) ? "A" : "I";
                return _CentroCostoNivelInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Centro_costo_nivel_Info();
            }

        }

        private bool validar()
        {
            try
            {
                if (txtdescripcion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Por favor Ingrese la descripción del Nivel...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (num_digitos.Value == 0)
                {
                    MessageBox.Show("Por favor Ingrese el numéro de digitos...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Grabar()
        {
            try
            {
                if (validar())
                {
                    get_CentroCostoNivel(param.IdEmpresa);

                    if (_CentroCostoNivelBus.GrabarDB(_CentroCostoNivelInfo))
                    {

                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El nivel ", _CentroCostoNivelInfo.IdNivel.ToString());
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Grabado ok");
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Registro repetido");
                    }
                   
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Modificar()
        {

            try
            {
                if (validar())
                {
                    get_CentroCostoNivel(param.IdEmpresa);

                    if (_CentroCostoNivelBus.ModificarDB(_CentroCostoNivelInfo))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El nivel ", _CentroCostoNivelInfo.IdNivel.ToString());
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Grabado ok");
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Registro repetido");
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Anular()
        {

            try
            {
                if (validar())
                {
                    get_CentroCostoNivel(param.IdEmpresa);

                    if (_CentroCostoNivelInfo.IdNivel != 0)
                    {
                        if (lblAnulado.Visible == true)
                        {
                            MessageBox.Show("El registro ya se encuentra Anulado");
                        }
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea anular el Nivel #: " + _CentroCostoNivelInfo.IdNivel + " ?", "ANULACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                                ofrm.ShowDialog();

                                _CentroCostoNivelInfo.IdUsuarioUltAnu = param.IdUsuario;
                                _CentroCostoNivelInfo.Fecha_UltAnu = DateTime.Now;
                                _CentroCostoNivelInfo.MotivoAnulacion = ofrm.motivoAnulacion;


                                if (_CentroCostoNivelBus.EliminarDB(_CentroCostoNivelInfo))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Nivel ", _CentroCostoNivelInfo.IdNivel.ToString());
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    chk_estado.Checked = false;
                                    ucGe_Menu.Visible_bntAnular = false;
                                    lblAnulado.Visible = true;
                                }
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                    }
                    else
                        MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }
               
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Procesar()
        {
            try
            {

                get_CentroCostoNivel(param.IdEmpresa);


                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Anular();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_CentroCostos_Nivel_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_CentroCostos_Nivel_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _CentroCostoNivelInfo = new ct_Centro_costo_nivel_Info();
                this.lblnivel.Text = _CentroCostoNivelBus.Get_Id(param.IdEmpresa).ToString();
                txtdescripcion.Text = "";
                num_digitos.Value = 0;
                chk_estado.Checked = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
