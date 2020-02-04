using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.General
{
    public partial class FrmGe_transportista_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_transportista_Info Info_Transp = new tb_transportista_Info();
        List<tb_persona_Info> List_Pers = new List<tb_persona_Info>();
        tb_persona_bus Bus_Persona = new tb_persona_bus();
        tb_persona_Info InfoPersona = new tb_persona_Info();
        tb_transportista_Bus Bus_Transp = new tb_transportista_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        public tb_transportista_Info SetInfo { get; set; }
        int C = 0;
        public delegate void delegate_FrmGe_transportista_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmGe_transportista_Mant_FormClosing event_FrmGe_transportista_Mant_FormClosing;

        #endregion
      
        public FrmGe_transportista_Mant()
        {
            try
            {
            InitializeComponent();
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(grabar())
                    limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiar()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info_Transp = new tb_transportista_Info();
                txtIdTransportista.Text = "";
                chkEstado.Checked = true;
                txtCedula.Text = "";
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmGe_transportista_Mant(Cl_Enumeradores.eTipo_action Numerador)
             : this()
        {
            try
            {
              enu = Numerador;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {

                }
                if (C == 4)
                {

                    txtIdTransportista.Enabled = false;
                    txtIdTransportista.BackColor = System.Drawing.Color.White;
                    txtIdTransportista.ForeColor = System.Drawing.Color.Black;


                    chkEstado.Enabled = false;
                    chkEstado.BackColor = System.Drawing.Color.White;
                    chkEstado.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetTransportista()
        {
            try
            {
                Info_Transp.IdEmpresa = param.IdEmpresa;
                if (txtIdTransportista.Text != "")
                {
                    Info_Transp.IdTransportista = Convert.ToInt32(this.txtIdTransportista.EditValue);
                }
                Info_Transp.Estado = (chkEstado.Checked == true) ? "A" : "I";
                Info_Transp.Nombre = txtNombre.Text;
                Info_Transp.Cedula = txtCedula.Text;
                Info_Transp.Placa = txtPlaca.Text;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SetTransportista()
        {
            try
            {
                this.txtIdTransportista.EditValue = SetInfo.IdTransportista;
                txtCedula.Text = SetInfo.Cedula;
                txtNombre.EditValue = SetInfo.Nombre;
                txtPlaca.Text = SetInfo.Placa;
                if (SetInfo.Estado == "I")
                {
                    this.chkEstado.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    this.chkEstado.Checked = true;
                    lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean grabar()
        {
            try
            {
                Boolean bolResult = false;
                txtIdTransportista.Focus();
                GetTransportista();
                if (chkEstado.Checked == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " estado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chkEstado.Focus();
                    return false;
                }
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        bolResult = Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        bolResult = Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                         bolResult = Anular();
                        break;
                    default:
                        break;
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Guardar()
        {

            try
            {
                Boolean var = Validar();
                decimal IdTransportista = 0;
                GetTransportista();
                if (var == true)
                {
                    if (Bus_Transp.GuardarDB(Info_Transp, ref IdTransportista))
                    {
                        MessageBox.Show("Se ha guardado con éxito el Transportista : " + IdTransportista, "Sistemas");
                        txtIdTransportista.EditValue = IdTransportista;
                        //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Enabled_btnGuardar = false;
                        var = true;
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar el sub centro de costo", "Sistemas");
                        var = false;
                    }
                }
                return var;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Boolean Actualizar()
        {
            try
            {
                if (Bus_Transp.ModificarDB(Info_Transp))
                {
                    MessageBox.Show("Se ha actualizado con éxito el sub centro de costo : " + Info_Transp.IdTransportista, "Sistemas");
                    //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Enabled_btnGuardar = false;
                }
                else { MessageBox.Show("Problemas al actualizar el sub centro de costo", "Sistemas"); return false; }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Anular()
        {
            try
            {
                Boolean bolResult = false;
                 if (Info_Transp.IdTransportista != 0)
                {
                    if (lblAnulado.Visible == true)
                    {
                        MessageBox.Show("El registro ya se encuentra Anulado");
                    }
                    else
                    {

                        if (MessageBox.Show("¿Está seguro que desea anular el Transportista #: " + Info_Transp.IdTransportista + " ?", "Anulación de Transportista ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            Info_Transp.IdUsuarioUltAnu = param.IdUsuario;
                            Info_Transp.Fecha_UltAnu = DateTime.Now;
                            Info_Transp.MotivoAnulacion = ofrm.motivoAnulacion;

                            if (Info_Transp.Estado == "A")
                            {
                                if (Bus_Transp.AnularDB(Info_Transp))
                                {
                                         MessageBox.Show("Registro anulado con éxito", "Sistemas");
                                         lblAnulado.Visible = true;
                                         ucGe_Menu.Enabled_bntAnular = false;
                                         bolResult = true;
                                 }
                                 else
                                 {
                                          MessageBox.Show("Error al Anular", "Sistemas");
                                 }
                            }
                            else
                            {
                                MessageBox.Show("No se pudo anular el Transportista: " + Info_Transp.Nombre + " debido a que ya se encuentra anulado", "Anulación de Transportista", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean Validar()
        {
            try
            {
                //if (this.txtCedula.Text == "")
                //{
                //    MessageBox.Show("Ingrese la cédula", "Sistemas");
                //    txtCedula.Focus();
                //    return false;
                //}
                if (this.txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre", "Sistemas");
                    txtNombre.Focus();
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

        private void FrmGe_transportista_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmGe_transportista_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmGe_transportista_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);
                        ucGe_Menu.Enabled_bntAnular = false;
                        txtIdTransportista.Focus();
                        chkEstado.Checked = true;
                        chkEstado.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                      ucGe_Menu.Enabled_bntAnular = false;
                      ucGe_Menu.Visible_bntLimpiar = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetTransportista();

                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;

                        ucGe_Menu.Visible_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);
                        SetTransportista();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        C = 4;
                        Inhabilita_Campos(C);
                        SetTransportista();
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (txtCedula.Text != string.Empty)
                {
                    if (Bus_Persona.VericarCedulaExiste(txtCedula.Text, ref  msg))
                    {
                        InfoPersona = Bus_Persona.Get_Info_Persona(txtCedula.Text);

                        txtNombre.EditValue = InfoPersona.pe_nombreCompleto;
                    }
                }

                else
                {
                    txtNombre.EditValue = "";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


    }
}
