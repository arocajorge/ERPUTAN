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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Punto_Cargo_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        ct_punto_cargo_Bus Bus = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info Info = new ct_punto_cargo_Info();
        List<ct_punto_cargo_grupo_Info> lista_grupo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus grupo_bus = new ct_punto_cargo_grupo_Bus();
        #endregion
        
        public frmCon_Punto_Cargo_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
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

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
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
                if (validar())
                {
                    grabar();
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
                if (validar())
                {
                    grabar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmCon_Punto_Cargo_Mant(Cl_Enumeradores.eTipo_action Numerador): this()
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

        private void limpiar()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info = new ct_punto_cargo_Info();
                txt_codPunto_cargo.Text = "";
                txt_nombre.Text = "";
                ckbActivo.Checked = true;

                txt_codPunto_cargo.Focus();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txt_codPunto_cargo.Focus();
                GetPuntoCargo();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        string ver = "";
                        string variable = (this.txt_codPunto_cargo.Text).TrimEnd();

                        if (variable != "")
                        {
                            if (Bus.VericarCodigoExiste(variable, ref  ver))
                            {
                                MessageBox.Show("El Codigo #: " + txt_codPunto_cargo.Text + " , ya se encuentra ingresado ", "Sistemas");
                                return;
                            }

                        }

                        Guardar();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        Actualizar();
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

        void Guardar()
        {
            try
            {
                if (txt_nombre.Text == "" || txt_nombre.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Punto de Cargo", "Sistemas");
                    txt_nombre.Focus();
                    return;
                }

                if (Bus.GuardarDB(Info,param.IdEmpresa))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro : ", Info.IdPunto_cargo);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    txt_codPunto_cargo.Text = Info.codPunto_cargo;
                    limpiar();
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            try
            {
                if (Bus.ModificarDB(Info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", "");
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Modificar,param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Anular()
        {
            try
            {
                if (Bus.AnularDB(Info))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgTituloAnular, "El registro ", "");
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    lblAnulado.Visible = true;
                }
                else
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Anular, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ct_punto_cargo_Info _SetInfo { get; set; }

        void SetPuntoCargo()
        {
            try
            {
                txt_IdPunto_cargo.EditValue = _SetInfo.IdPunto_cargo;
                txt_codPunto_cargo.Text = _SetInfo.codPunto_cargo;
                txt_nombre.Text = _SetInfo.nom_punto_cargo;
                cmb_grupo.EditValue = _SetInfo.IdPunto_cargo_grupo;
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

        void GetPuntoCargo()
        {
            try
            {
                Info.codPunto_cargo = Convert.ToString((txt_codPunto_cargo.Text == "") ? "" : Convert.ToString(txt_codPunto_cargo.Text).Trim());
                Info.IdPunto_cargo = Convert.ToInt32(txt_IdPunto_cargo.EditValue);
                Info.IdEmpresa = param.IdEmpresa;
                Info.nom_punto_cargo = Convert.ToString(txt_nombre.Text);
                Info.Estado = (ckbActivo.Checked == true) ? "A" : "I";
                Info.IdPunto_cargo_grupo =Convert.ToInt32( cmb_grupo.EditValue);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int C = 0;

        private void frmCon_Punto_Cargo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        C = 1;
                        Inhabilita_Campos(C);

                        txt_codPunto_cargo.Focus();
                        ckbActivo.Checked = true;
                        ckbActivo.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        ucGe_Menu.Enabled_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetPuntoCargo();
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
                    
                }
                if (C == 4)
                {

                    txt_codPunto_cargo.Enabled = false;
                    txt_codPunto_cargo.BackColor = System.Drawing.Color.White;
                    txt_codPunto_cargo.ForeColor = System.Drawing.Color.Black;

                    txt_nombre.Enabled = false;
                    txt_nombre.BackColor = System.Drawing.Color.White;
                    txt_nombre.ForeColor = System.Drawing.Color.Black;

                    ckbActivo.Enabled = false;
                    ckbActivo.BackColor = System.Drawing.Color.White;
                    ckbActivo.ForeColor = System.Drawing.Color.Black;
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

        private void txt_codPunto_cargo_KeyPress(object sender, KeyPressEventArgs e)
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

        public delegate void delegate_frmCon_Punto_Cargo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_Punto_Cargo_Mant_FormClosing event_frmCon_Punto_Cargo_Mant_FormClosing;

        private void frmCon_Punto_Cargo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_Punto_Cargo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Cargar_Datos()
        {
            try
            {
                string Error="";
                lista_grupo = grupo_bus.Get_List_punto_cargo_grupo(param.IdEmpresa, ref Error);
                cmb_grupo.Properties.DataSource = lista_grupo;

                cmb_grupo.Properties.ValueMember = "IdPunto_cargo_grupo";
                cmb_grupo.Properties.DisplayMember = "nom_punto_cargo_grupo";

            }
            catch (Exception ex)
            {
                

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            }
        }

        public bool validar()
        {
            try
            {
                bool ba_validar_datos = true;
                if (cmb_grupo.EditValue == null || cmb_grupo.EditValue == "")
                {
                    MessageBox.Show("Seleccione un grupo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba_validar_datos = false;
                }


                if (txt_nombre.Text == null || txt_nombre.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre del punto de cargo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba_validar_datos = false;
                }



                return ba_validar_datos;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
