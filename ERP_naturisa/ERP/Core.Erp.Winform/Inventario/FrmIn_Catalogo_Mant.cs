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
    public partial class FrmIn_Catalogo_Mant : Form
    {


        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        in_Catalogo_Bus Bus = new in_Catalogo_Bus();
        in_Catalogo_Info Info = new in_Catalogo_Info();
        public in_Catalogo_Info _SetInfo { get; set; }
        int C = 0;
        public delegate void delegate_FrmIn_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Catalogo_Mant_FormClosing event_FrmIn_Catalogo_Mant_FormClosing;
        #endregion

        public FrmIn_Catalogo_Mant()
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
                if (Validar())
                {
                    if (grabar() == true)
                    {
                        this.Close();
                    }
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
                if (Validar())
                {
                    if (grabar() == true)
                    {

                    } 
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Boolean Validar()
        {
            try
            {
                Boolean res = true;
            
                if (txt_IdCatalogo.Text.Trim() == "" || txt_IdCatalogo.Text == null)
                {
                    MessageBox.Show("Ingrese el IdCatalogo", "Sistemas");
                    txt_IdCatalogo.Focus();
                    res = false;
                }

                if (txt_abreviatura.Text.Trim() == "" || txt_abreviatura.Text == null)
                {
                    MessageBox.Show("Ingrese un abreviatura", "Sistemas");
                    txt_abreviatura.Focus();
                    res = false;
                }

                if (txt_nombre.Text.Trim() == "" || txt_nombre.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Catalogo", "Sistemas");
                    txt_nombre.Focus();
                    res = false;
                }

                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean grabar()
        {
            Boolean var = false;
            try
            {
                txt_IdCatalogo.Focus();
                GetCatalogo();

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
                if (Bus.GuardarDB(Info, ref msg))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Catálogo", Info.IdCatalogo);
                    MessageBox.Show(smensaje, param.Nombre_sistema); 
                    txt_IdCatalogo.Text = Info.IdCatalogo;
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
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Catálogo", Info.IdCatalogo);
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

        public FrmIn_Catalogo_Mant(Cl_Enumeradores.eTipo_action Numerador)
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
               
        private void FrmIn_Catalogo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);

                        txt_IdCatalogo.Focus();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetCatalogo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        ucGe_Menu.Enabled_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetCatalogo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetCatalogo();
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

        void SetCatalogo()
        {
            try
            {
                txtIdCatalogo_tipo.Text =Convert.ToString(_SetInfo.IdCatalogo_tipo);
                txt_IdCatalogo.Text = _SetInfo.IdCatalogo;
                txt_abreviatura.Text = _SetInfo.Abrebiatura;
                txt_nombre.Text = _SetInfo.Nombre;

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.ckbActivo.Checked = false;
                    lblAnulado.Visible = true;
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

        void GetCatalogo()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            try
            {
                Info.IdCatalogo_tipo = Convert.ToInt16(txtIdCatalogo_tipo.Text.Trim());
                Info.IdCatalogo = txt_IdCatalogo.Text.Trim();
                Info.Abrebiatura = txt_abreviatura.Text.Trim();
                Info.Nombre = txt_nombre.Text.Trim();
                Info.Estado = (ckbActivo.Checked == true) ? "A" : "I";
                Info.NombreIngles = null;
                Info.Orden = r.Next(1, 9999);
                Info.IdUsuario = param.IdUsuario;
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.FechaUltMod = DateTime.Now;
                Info.nom_pc = param.nom_pc;
                Info.ip = param.ip;

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

                    txt_IdCatalogo.Enabled = false;
                    txt_IdCatalogo.BackColor = System.Drawing.Color.White;
                    txt_IdCatalogo.ForeColor = System.Drawing.Color.Black;

                    txt_abreviatura.Enabled = false;
                    txt_abreviatura.BackColor = System.Drawing.Color.White;
                    txt_abreviatura.ForeColor = System.Drawing.Color.Black;

                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    ckbActivo.Enabled = false;
                    ckbActivo.BackColor = System.Drawing.Color.White;
                    ckbActivo.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                   txt_IdCatalogo.Enabled = false;
                   txt_IdCatalogo.BackColor = System.Drawing.Color.White;
                   txt_IdCatalogo.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Catalogo_Mant_FormClosing(sender,e);
            }
            catch (Exception ex )
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LimpiarDatos()
        {
            try
            {
                txtIdCatalogo_tipo.Text = "";
                txt_IdCatalogo.Text = "";
                txt_abreviatura.Text = "";
                txt_nombre.Text = "";
                Info = new in_Catalogo_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
