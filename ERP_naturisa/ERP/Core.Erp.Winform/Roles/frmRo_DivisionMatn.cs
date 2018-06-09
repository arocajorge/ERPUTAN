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
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_DivisionMatn : Form
    {
        #region Declaración de Variables
        ro_division_Info _Info = new ro_division_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_division_Bus _Bus = new ro_division_Bus();
        public delegate void Delegate_frmRo_DivisionMatn_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmRo_DivisionMatn_FormClosing Event_frmRo_DivisionMatn_FormClosing;
        #endregion

        public frmRo_DivisionMatn()
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
                Log_Error_bus.Log_Error(ex.Message);
            }
   
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    this.ucGe_Menu_event_btnGuardar_Click(sender,e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                        Guardar();
                        limpiar();
                        CheckEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
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
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";            
                    Get();
                    if (_Info.estado == "A")
                    {
                        if (MessageBox.Show("Esta Seguro que desea Anular la Division ?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                             FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                            oFrm.ShowDialog();
                            string motivoAnulacion = oFrm.motivoAnulacion;
                            _Info.MotivoAnulacion = motivoAnulacion;
                            _Info.IdUsuarioUltAnu=param.IdUsuario;
                            _Info.Fecha_UltAnu=DateTime.Now;

                            if (_Bus.Anular(_Info, ref  msg))
                            {
                                MessageBox.Show("Se ha Anulado Con exito La division #" + _Info.IdDivision);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Currio un Problema al anular # " + _Info.IdDivision );

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Registro # " + _Info.IdDivision+"Ya esta Anulado ");

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
        
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                 Accion = iAccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_DivisionMatn_Load(object sender, EventArgs e)
        {
            try
            {
                Event_frmRo_DivisionMatn_FormClosing += new Delegate_frmRo_DivisionMatn_FormClosing(frmRo_DivisionMatn_Event_frmRo_DivisionMatn_FormClosing);
                    switch (Accion) 
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntSalir = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            ucGe_Menu.Enabled_bntSalir = true;
                            ucGe_Menu.Enabled_bntAnular = false;
                            Set();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntSalir = true;
                            ucGe_Menu.Visible_bntAnular = false;
                            Set();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                             Set();
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            ucGe_Menu.Enabled_bntSalir = true;
                            ucGe_Menu.Enabled_bntAnular = true;
                            break;
                        default:
                            break;
            
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void frmRo_DivisionMatn_Event_frmRo_DivisionMatn_FormClosing(object sender, FormClosingEventArgs e){}

        void Get() 
        {
            try
            {
                _Info = new ro_division_Info();
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    _Info.IdDivision = Convert.ToInt32(txtId.Text);
                }
                _Info.Descripcion = txtDescripcion.Text;        
                _Info.estado = (CheckEstado.Checked == true) ? "A" : "I";
                _Info.IdEmpresa = param.IdEmpresa;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public ro_division_Info _SetInfo { get; set; }
       
        void Set() 
        {
            try
            {
                txtDescripcion.EditValue = _SetInfo.Descripcion;
                txtId.EditValue = _SetInfo.IdDivision;
                if(_SetInfo.estado=="A")
                {
                    CheckEstado.Checked = true;

                }
                else
                {
                    CheckEstado.Checked = false;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);             
            }
        }

        Boolean Validar() 
        {
            try
            {
                if (txtDescripcion.EditValue == null || txtDescripcion.Text == "") 
                {
                    MessageBox.Show("Por Favor Ingresar Descripcion");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return false;
            }        
        }
   
        private void frmRo_DivisionMatn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               Event_frmRo_DivisionMatn_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }
       
        void Modificar() 
        {
            try
            {
                string msg = "";

                if (Validar())
                {
                    Get();
                    if (_Bus.ModificarDB( _Info, ref  msg))
                    {
                        txtId.EditValue = _Info.IdDivision;
                        MessageBox.Show("Se ha Actualizado Con exito La division #" + _Info.IdDivision);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        //btn_guardar.Enabled = false;
                        //btn_guardarysalir.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        limpiar();
                    }            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        
        }

        void Guardar()
        {
            try
            {
               string msg = "";
               if (Validar())
                {
                    Get();
                    if (_Bus.GuardarDB(ref _Info, ref msg))
                    {
                        txtId.EditValue = _Info.IdDivision;
                        MessageBox.Show("Se ha Ingresado Con exito La division #" + _Info.IdDivision);
                        //btn_guardar.Enabled = false;
                        //btn_guardarysalir.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Enabled_bntAnular = false;
                        limpiar();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
 
        }

        public void limpiar()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            CheckEstado.Checked = false;

        }


        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void frmRo_DivisionMatn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

     
    }
}
