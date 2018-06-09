using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Tipo_Prestamo_Mant : Form
    {
        #region Declaracion de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Tipo_Prestamo_Info Info_Tprestamo = new ro_Tipo_Prestamo_Info();
        ro_Tipo_Prestamo_Bus Bus_Tprestamo = new ro_Tipo_Prestamo_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_rubro_tipo_Bus Bus = new ro_rubro_tipo_Bus();
        public ro_Tipo_Prestamo_Info _SetInfo { get; set; }
        ro_Tipo_Prestamo_Info _Info = new ro_Tipo_Prestamo_Info();
        public delegate void delegate_frmRo_Tipo_Prestamo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Tipo_Prestamo_Mant_FormClosing event_frmRo_Tipo_Prestamo_Mant_FormClosing;

        #endregion
        
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
               Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }

        public frmRo_Tipo_Prestamo_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Tipo_Prestamo_Mant_FormClosing += frmRo_Tipo_Prestamo_Mant_event_frmRo_Tipo_Prestamo_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        void frmRo_Tipo_Prestamo_Mant_event_frmRo_Tipo_Prestamo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
                MessageBox.Show(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            Get();
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";

                //CheckEstado.Checked = false;

                if (lblEstado.Visible == true)
                {
                    ucGe_Menu.Enabled_bntAnular = false;
                    MessageBox.Show("No se puede anular debido a que ya se encuentra anulado", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    Get();
                    if (MessageBox.Show("Está seguro que desea anular el tipo de préstam...?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        _Info.IdUsuarioUltAnu = param.IdUsuario;
                        _Info.Fecha_UltMod = DateTime.Now;
                        _Info.MotiAnula = ofrm.motivoAnulacion;

                        Get();

                        if (Bus_Tprestamo.AnularDB(_Info))
                        {
                            MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblEstado.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Error al ANULAR Tipo de Préstamo verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        void Set()
        {
            try
            {
                txtIdTprestamo.Text = Convert.ToString(_SetInfo.IdTipoPrestamo == null ? 0 : _SetInfo.IdTipoPrestamo);
                textDescripcion.Text = _SetInfo.tp_Descripcion;
                textMonto.Text = Convert.ToString(_SetInfo.tp_Monto == null ? 0 : _SetInfo.tp_Monto);
                this.CheckEstado.Checked = (_SetInfo.tp_Estado == "A") ? true : false;

                if (_SetInfo.tp_Estado == "I")
                {
                    lblEstado.Visible = true;
                }
                else
                {
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        void Get()
        {

            try
            {
                _Info.IdEmpresa = param.IdEmpresa;
                if (txtIdTprestamo.Text == "")
                {
                    _Info.IdTipoPrestamo = 0;
                }
                else
                {
                    _Info.IdTipoPrestamo = Convert.ToInt32(txtIdTprestamo.Text);
                    }

                _Info.tp_Descripcion = textDescripcion.Text;            

                if (textMonto.Text == null) 
                    _Info.tp_Monto = 0;
                else
                {
                    if (textMonto.Text != "")
                    {
                        _Info.tp_Monto = Convert.ToInt32(textMonto.Text);
                    }
                    else
                        _Info.tp_Monto = 0;
                }
              
                _Info.tp_Estado = (CheckEstado.Checked == true) ? "A" : "I";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
           

        }        

        private void frmRo_Tipo_Prestamo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        CheckEstado.Checked = true;
                        this.txtIdTprestamo.BackColor = System.Drawing.Color.White;
                        lblEstado.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntAnular = false;

                        this.txtIdTprestamo.BackColor = System.Drawing.Color.White;


                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;

                        this.txtIdTprestamo.BackColor = System.Drawing.Color.White;
                        
                        this.textDescripcion.ReadOnly = true;
                        this.textDescripcion.BackColor = System.Drawing.Color.White;

                       
                       



                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Enabled_bntAnular = true;
                        break;
                    default:
                        break;

                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void Guardar()
        {
            try 
	        {	     
                if (Validar())
                {
                    Get();

                    if (Bus_Tprestamo.GuardarDB( _Info) == false)
                    {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        txtIdTprestamo.Text = Convert.ToString(_Info.IdTipoPrestamo == null ? 0 : _Info.IdTipoPrestamo);
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                    }
                }
		
	        }
	        catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
		        MessageBox.Show(ex.ToString());        
	        }
            

        }

        void Actualizar()
        {

            try
            {
                Get();

                if (Bus_Tprestamo.ModificarDB(_Info) == false)
                {
                    MessageBox.Show("El registro no se pudo guardar, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    txtIdTprestamo.Text = Convert.ToString(_Info.IdTipoPrestamo == null ? 0 : _Info.IdTipoPrestamo);
                    MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
          
        }

        Boolean Validar()
        {
            try
            {
                if (textDescripcion.Text == null || textDescripcion.Text == "")
                {
                    MessageBox.Show("La Descripción es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                              

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
       
        private void frmRo_Tipo_Prestamo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmRo_Tipo_Prestamo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRo_Tipo_Prestamo_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Limpiar()
        {
            try
            {
                txtIdTprestamo.Text = "";
                textDescripcion.Text = "";
                textMonto.Text = "";
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
