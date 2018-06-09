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
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Catalogo_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public ro_Catalogo_Info Info = new ro_Catalogo_Info();
        ro_Catalogo_Bus Bus = new ro_Catalogo_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        public delegate void delegate_frmRo_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Catalogo_Mant_FormClosing Event_frmRo_Catalogo_Mant_FormClosing;

        #endregion

        public frmRo_Catalogo_Mant()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                 ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                 ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

            try
            {
                Get();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            Grabar();
                            Close();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            Actualizar();
                            Close();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Get();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            Grabar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            Actualizar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
          try
          {
              Get();
              if (MessageBox.Show("Está seguro que desea anular el registro...?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
              {
                  Get();
                  if (Bus.AnularDB(Info))
                  {
                      txtId.Text = Info.IdCatalogo.ToString();
//                      MessageBox.Show("Se ha anulado correctamente el registro # :" + Info.IdCatalogo);
                      MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
              Log_Error_bus.Log_Error(ex.ToString());
          } 
        }

        int idTipoCatalogo = 0;
        
        public frmRo_Catalogo_Mant(int IdTipoCatalgo):this()
        {
            try
            {
               // Info.IdTipoCatalogo = IdTipoCatalgo;
                idTipoCatalogo = IdTipoCatalgo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {

                Accion = _Accion;

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Limpiar();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Catalogo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Event_frmRo_Catalogo_Mant_FormClosing += new delegate_frmRo_Catalogo_Mant_FormClosing(frmRo_Catalogo_Mant_Event_frmRo_Catalogo_Mant_FormClosing);
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        lblEstado.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        txtCodigo.Enabled = false;
                        this.txtCodigo.BackColor = System.Drawing.Color.White;
                        this.txtCodigo.ForeColor = System.Drawing.Color.Black;
                        Set();
                
                  break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                                                
                        cbxEstado.Enabled = false;
                        
                        txtCodigo.Enabled = false;
                        this.txtCodigo.BackColor = System.Drawing.Color.White;
                        this.txtCodigo.ForeColor = System.Drawing.Color.Black;

                        txtDescripcion.Enabled = false;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White;
                        this.txtDescripcion.ForeColor = System.Drawing.Color.Black;



                         Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        //bloquear_Datos();

                         cbxEstado.Enabled = false;
                        
                        txtCodigo.Enabled = false;
                        this.txtCodigo.BackColor = System.Drawing.Color.White;
                        this.txtCodigo.ForeColor = System.Drawing.Color.Black;

                        txtDescripcion.Enabled = false;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White;
                        this.txtDescripcion.ForeColor = System.Drawing.Color.Black;



                         Set();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmRo_Catalogo_Mant_Event_frmRo_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e){}
     
        void Grabar() 
        {
            try
            {
                if (Bus.ValidarCodigoExiste(Info.CodCatalogo) == false)
                {
                    Get();
                    if (Bus.GuardarDB(ref Info))
                    {
                        txtId.Text = Info.IdCatalogo.ToString();
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }
                }
                else
                {

                    MessageBox.Show("El código ingresado ya se encuentra asignado .\n Por favor ingrese uno nuevo","ATENCION",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        public void bloquear_Datos()
        {
            try
            {
                txtCodigo.Enabled = false;
                txtDescripcion.Enabled = false;
                txtId.Enabled = false;
                cbxEstado.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Actualizar()
        {
            try
            {
                string msg = "";

                if (Validar())
                {
                    Get();

                    if (Bus.ModificarDB(Info, ref msg))
                    {
                        txtId.Text = Info.IdCatalogo.ToString();
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        lblEstado.Visible = false;
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_frmRo_Catalogo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        Boolean Validar() 
        {
            try
            {
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null) 
                {
                    MessageBox.Show("Por favor ingrese la descripción");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void Limpiar()
        {
            try
            {
                txtCodigo.Enabled = true;
                txtCodigo.Text = "";
                txtDescripcion.Text = "";
                txtId.Text = "";
                cbxEstado.Checked = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e){}

        ro_Catalogo_Info _Info = new ro_Catalogo_Info();

        void Get()
        {
            try
            {
                Info = new ro_Catalogo_Info();

                Info.IdTipoCatalogo = idTipoCatalogo;
                
                Info.ca_descripcion = txtDescripcion.Text;
                Info.CodCatalogo = txtCodigo.Text;
                Info.IdCatalogo = Convert.ToInt32((txtId.Text == "") ? "0" : txtId.Text);
                if (cbxEstado.Checked == true)
                {
                    Info.ca_estado = "A";
                }
                else
                {
                    Info.ca_estado = "I";
                }
                //return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                //return new ro_Catalogo_Info();
            }
        }

        public ro_Catalogo_Info _SetInfo { get; set; }

        void Set()
        {
            try
            {
                txtDescripcion.Text = _SetInfo.ca_descripcion;
                txtId.Text = _SetInfo.IdCatalogo.ToString();
                txtCodigo.Text = _SetInfo.CodCatalogo;
                cbxEstado.Checked = _SetInfo.ca_estado == "A" ? true : false;
                lblEstado.Visible = (_SetInfo.ca_estado == "I") ? true : false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void frmRo_Catalogo_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }
       
    }
}
