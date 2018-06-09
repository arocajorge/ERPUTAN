using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Inventario;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_ProductoTipo_Mant : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_ProductoTipo_Info Info_ProductoTipo = new in_ProductoTipo_Info();
        in_ProductoTipo_Bus Bus_ProductoTipo = new in_ProductoTipo_Bus();
        public in_ProductoTipo_Info _SetInfo { get; set; }
        public delegate void delegate_frmIn_ProductoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmIn_ProductoTipo_Mant_FormClosing event_frmIn_ProductoTipo_Mant_FormClosing;
        #endregion
        
        public frmIn_ProductoTipo_Mant()
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
                grabar();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmIn_ProductoTipo_Mant(Cl_Enumeradores.eTipo_action Numerador)
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

        private void LimpiarDatos()
        {
            try
            {
                txtIdProductoTipo.Text = "";
                txt_descripcion.Text = "";
                chk_estado.Checked = true;
                chk_escombo.Checked = false;
                chk_maneja_inventario.Checked = false;
                chk_MateriaPrima.Checked = false;
                chk_ProductoTerminado.Checked = false;

                txt_descripcion.Focus();
                Info_ProductoTipo = new in_ProductoTipo_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void GetProducto()
        {
            try
            {
                Info_ProductoTipo.IdEmpresa = param.IdEmpresa;
                if (txtIdProductoTipo.Text != "")
                {
                    Info_ProductoTipo.IdProductoTipo = Convert.ToInt16(txtIdProductoTipo.EditValue);
                }
                Info_ProductoTipo.tp_descripcion = txt_descripcion.Text.Trim();
                Info_ProductoTipo.tp_EsCombo = (chk_escombo.Checked == true) ? "S" : "N";
                Info_ProductoTipo.tp_ManejaInven = (chk_maneja_inventario.Checked == true) ? "S" : "N";
                Info_ProductoTipo.IdUsuario = param.IdUsuario;
                Info_ProductoTipo.Fecha_Transac = DateTime.Now;
                Info_ProductoTipo.IdUsuarioUltAnu = param.IdUsuario;
                Info_ProductoTipo.Fecha_UltAnu = DateTime.Now;
                Info_ProductoTipo.IdUsuarioUltMod = param.IdUsuario;
                Info_ProductoTipo.Fecha_UltMod = DateTime.Now;
                Info_ProductoTipo.nom_pc = param.nom_pc;
                Info_ProductoTipo.ip = param.ip;
                Info_ProductoTipo.Estado = (chk_estado.Checked == true) ? "A" : "I";
                Info_ProductoTipo.EsMateriaPrima = (chk_MateriaPrima.Checked == true) ? "S" : "N";
                Info_ProductoTipo.EsProductoTerminado = (chk_ProductoTerminado.Checked == true) ? "S" : "N";
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void SetProducto()
        {
            try
            {
                this.txtIdProductoTipo.Text = _SetInfo.IdProductoTipo.ToString();
                this.txt_descripcion.Text = _SetInfo.tp_descripcion;
                this.chk_escombo.Checked = (_SetInfo.tp_EsCombo == "S") ? true : false;
                this.chk_maneja_inventario.Checked = (_SetInfo.tp_ManejaInven == "S") ? true : false;

                if (_SetInfo.EsMateriaPrima.TrimEnd() == "S")
                {
                    chk_MateriaPrima.Checked = true;
                    chk_ProductoTerminado.Checked = false;
                }
                else
                {
                    chk_ProductoTerminado.Checked = true;
                    chk_MateriaPrima.Checked = false;
                }

                if (_SetInfo.Estado.TrimEnd() == "I")
                {
                    this.chk_estado.Checked = false;
                    lblAnulado.Visible = true;
                }
                else
                {
                    chk_estado.Checked = true;
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
                txtIdProductoTipo.Focus();
                GetProducto();

                if (ValidarDatos())
                {
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

        int C = 0;
        string msg = "";


        Boolean ValidarDatos()
        {
            try
            {
                if (txt_descripcion.Text == "" || txt_descripcion.Text == null)
                {
                    MessageBox.Show("Ingrese el nombre del Tipo del Producto", "Sistemas");
                    txt_descripcion.Focus();
                    return false;
                }

                if (chk_MateriaPrima.Checked == false && chk_ProductoTerminado.Checked == false)
                {
                    MessageBox.Show("Eliga por lo menos un tipo de Producto", "Sistemas");
                    txt_descripcion.Focus();
                    return false;
                }

                if (chk_MateriaPrima.Checked == true && chk_ProductoTerminado.Checked == true)
                {
                    MessageBox.Show("Debe de elegir solo 1 tipo", "Sistemas");
                    txt_descripcion.Focus();
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

        Boolean Guardar()
        {
            try
            {
                int id = 0;
                string mensajeRecurso = "";
                if (Bus_ProductoTipo.GrabarDB(Info_ProductoTipo, ref id, ref msg))
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    txtIdProductoTipo.EditValue = Info_ProductoTipo.IdProductoTipo;
                    //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Enabled_btnGuardar = false;
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al Grabar " + msg, param.Nombre_sistema);
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
                string msg = "";               
                string mensajeRecurso = "";
                if (Bus_ProductoTipo.ModificarDB(Info_ProductoTipo,ref msg))
                {
                    mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk;
                    MessageBox.Show(mensajeRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    enu = Cl_Enumeradores.eTipo_action.grabar;
                    LimpiarDatos();
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al Actualizar " + msg, param.Nombre_sistema);
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

        Boolean Anular()
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea elminar el Item ", "Sistemas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrmMot = new General.FrmGe_MotivoAnulacion();
                    ofrmMot.ShowDialog();
                    Info_ProductoTipo.MotivoAnulacion = ofrmMot.motivoAnulacion;
                    string msg = "";
                    string mensajeRecurso = "";
                    if (Bus_ProductoTipo.EliminarDB(Info_ProductoTipo, ref msg))
                    {
                        mensajeRecurso = Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk;
                        MessageBox.Show(mensajeRecurso, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        lblAnulado.Visible = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error al Anular " + msg, "Sistemas");
                        return false;
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

        private void frmIn_ProductoTipo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        C = 1;
                        Inhabilita_Campos(C);

                        txt_descripcion.Focus();

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntAnular = false;

                        C = 3;
                        Inhabilita_Campos(C);

                        SetProducto();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;  
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetProducto();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;  
                        ucGe_Menu.Enabled_bntAnular = false;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetProducto();
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

                    txtIdProductoTipo.Enabled = false;
                    txtIdProductoTipo.BackColor = System.Drawing.Color.White;
                    txtIdProductoTipo.ForeColor = System.Drawing.Color.Black;

                    txt_descripcion.Enabled = false;
                    txt_descripcion.BackColor = System.Drawing.Color.White;
                    txt_descripcion.ForeColor = System.Drawing.Color.Black;

                    chk_estado.Enabled = false;
                    chk_estado.BackColor = System.Drawing.Color.White;
                    chk_estado.ForeColor = System.Drawing.Color.Black;

                    chk_MateriaPrima.Enabled = false;
                    chk_MateriaPrima.BackColor = System.Drawing.Color.White;
                    chk_MateriaPrima.ForeColor = System.Drawing.Color.Black;

                    chk_ProductoTerminado.Enabled = false;
                    chk_ProductoTerminado.BackColor = System.Drawing.Color.White;
                    chk_ProductoTerminado.ForeColor = System.Drawing.Color.Black;

                    chk_escombo.Enabled = false;
                    chk_escombo.BackColor = System.Drawing.Color.White;
                    chk_escombo.ForeColor = System.Drawing.Color.Black;

                    chk_maneja_inventario.Enabled = false;
                    chk_maneja_inventario.BackColor = System.Drawing.Color.White;
                    chk_maneja_inventario.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                    //txt_codPunto_cargo.Enabled = false;
                    //txt_codPunto_cargo.BackColor = System.Drawing.Color.White;
                    //txt_codPunto_cargo.ForeColor = System.Drawing.Color.Black;

                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmIn_ProductoTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmIn_ProductoTipo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chk_MateriaPrima_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk_MateriaPrima.Checked == true)
                {
                    chk_ProductoTerminado.Checked = false;
                }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chk_ProductoTerminado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ProductoTerminado.Checked == true)
            {
                chk_MateriaPrima.Checked = false;
            }
        }




    }
}
