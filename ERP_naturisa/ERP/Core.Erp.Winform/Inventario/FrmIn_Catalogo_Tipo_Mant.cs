using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Catalogo_Tipo_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        in_Catalogo_Tipo_Bus Bus = new in_Catalogo_Tipo_Bus();
        in_CatalogoTipo_Info Info = new in_CatalogoTipo_Info();
        public in_CatalogoTipo_Info _SetInfo { get; set; }
        int C = 0;
        public delegate void delegate_FrmIn_Catalogo_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Catalogo_Tipo_Mant_FormClosing event_FrmIn_Catalogo_Tipo_Mant_FormClosing;

        #endregion
        
        public FrmIn_Catalogo_Tipo_Mant()
        {
            InitializeComponent();

            
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
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

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {

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
                if (grabar() == true)
                {
                    this.Close();
                }
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
                if (grabar() == true)
                {
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                txtIdCatalogo_tipo.Text = "";
                txt_descripcion.Text = "";

                ckbActivo.Checked = true;

                txt_descripcion.Focus();
                Info = new in_CatalogoTipo_Info();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean grabar()
        {
            Boolean var = false;
            try
            {
                txt_descripcion.Focus();
                GetCatalogo_Tipo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        var = Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        var = Actualizar();

                        break;
                    default:
                        break;
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

        Boolean Guardar()
        {
            string msg = "";
            try
            {

                if (txt_descripcion.Text.Trim() == "" || txt_descripcion.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Catalogo", "Sistemas");
                    txt_descripcion.Focus();
                    return false;
                }

                if (Bus.GuardarDB(Info, ref msg))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El tipo de Catálogo ", Info.IdCatalogo_tipo);
                    MessageBox.Show(smensaje, param.Nombre_sistema); 
                    txtIdCatalogo_tipo.Text = Convert.ToString(Info.IdCatalogo_tipo);
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        Boolean Actualizar()
        {
            try
            {
                if (Bus.ModificarDB(Info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Catálogo", Info.IdCatalogo_tipo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    return false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public FrmIn_Catalogo_Tipo_Mant(Cl_Enumeradores.eTipo_action Numerador)
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

        void SetCatalogo_Tipo()
        {
            try
            {
                txtIdCatalogo_tipo.Text =Convert.ToString(_SetInfo.IdCatalogo_tipo);
                txt_descripcion.Text = _SetInfo.Descripcion;

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.ckbActivo.Checked = false;
                    //lblAnulado.Visible = true;
                }
                else
                {
                    ckbActivo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetCatalogo_Tipo()
        {
            try
            {
                Info.IdCatalogo_tipo = 0;
                Info.Descripcion = txt_descripcion.Text.Trim();
                Info.Estado = (ckbActivo.Checked == true) ? "A" : "I";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Catalogo_Tipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);

                        txt_descripcion.Focus();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetCatalogo_Tipo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        ucGe_Menu.Enabled_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetCatalogo_Tipo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetCatalogo_Tipo();
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

        void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {
                    //txt_codPunto_cargo.Enabled = false;
                    //txt_codPunto_cargo.BackColor = System.Drawing.Color.White;
                    //txt_codPunto_cargo.ForeColor = System.Drawing.Color.Black;
                }
                if (C == 4)
                {
                    txtIdCatalogo_tipo.Enabled = false;
                    txtIdCatalogo_tipo.BackColor = System.Drawing.Color.White;
                    txtIdCatalogo_tipo.ForeColor = System.Drawing.Color.Black;

                    txt_descripcion.Enabled = false;
                    txt_descripcion.BackColor = System.Drawing.Color.White;
                    txt_descripcion.ForeColor = System.Drawing.Color.Black;

                }

                if (C == 3)
                {

                    txtIdCatalogo_tipo.Enabled = false;
                    txtIdCatalogo_tipo.BackColor = System.Drawing.Color.White;
                    txtIdCatalogo_tipo.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Catalogo_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Catalogo_Tipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
