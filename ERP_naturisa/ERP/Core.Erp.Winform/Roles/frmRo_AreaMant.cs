using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_AreaMant : Form
    {
        #region Declaración de variables
        ro_division_Bus _Division_B = new ro_division_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_area_Bus Bus = new ro_area_Bus();
        ro_area_Info _Info= new ro_area_Info();
        public ro_area_Info _SetInfo { get; set; }
        public delegate void delegate_frmRo_AreaMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_AreaMant_FormClosing Event_frmRo_AreaMant_FormClosing;
      
        #endregion
        
        public frmRo_AreaMant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                cmbDivision.Properties.DataSource = _Division_B.ConsultaGeneral(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.Message);
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
                 Log_Error_bus.Log_Error(ex.ToString());
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
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Event_frmRo_AreaMant_FormClosing += new delegate_frmRo_AreaMant_FormClosing(frmRo_AreaMant_Event_frmRo_AreaMant_FormClosing);
                Get();
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
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.ToString());
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
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_AreaMant_Load(object sender, EventArgs e)
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
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                       // ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        //ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;

                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = true;
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
        
        void Set() 
        {
            try
            {
                 cmbDivision.EditValue = _SetInfo.IdDivision;
                txtDescripcion.EditValue = _SetInfo.Descripcion;
                txtId.EditValue = _SetInfo.IdArea;
                CheckEstado.Checked = (_SetInfo.Estado == "A") ? true : false;
                lblEstado.Visible = (_SetInfo.Estado == "I") ? true : false;
                
                cmbDivision.Properties.ReadOnly =true;
            
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        void Get()
        {
            try
            {

                if ( Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.Anular  )
                {
                    _Info.IdArea = Convert.ToInt32(txtId.EditValue);
                }
                _Info.Descripcion = txtDescripcion.Text;
                _Info.IdDivision = Convert.ToInt32(cmbDivision.EditValue);
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.Estado = (CheckEstado.Checked == true) ? "A" : "I";                
                lblEstado.Visible = (_Info.Estado == "I") ? true : false;
                _Info.FechaTransac = param.GetDateServer();
                _Info.IdUsuario = param.IdUsuario;
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frmRo_AreaMant_Event_frmRo_AreaMant_FormClosing(object sender, FormClosingEventArgs e){}

        void Guardar()
        {
            try
            {
                if (Validar())
                {
                    Get();
                    if (Bus.GuardarDB(ref _Info))
                    {
                        txtId.EditValue = _Info.IdArea;
                        MessageBox.Show("Se ha Guardado con exito el Registro #" + _Info.IdArea);
                        Limpiar();
                    }
                }
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
                Get();
                if (Bus.ModificarDB(_Info))
                {
                    txtId.EditValue = _Info.IdArea;
                    MessageBox.Show("Se ha Modificado con exito el Registro #" + _Info.IdArea);
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                    ucGe_Menu.Visible_bntAnular = false;
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void anular()
        {
            try
            {
                Get();
                if (_Info != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (_Info.Estado == "A")
                    {
                        CheckEstado.Checked = false;
                        if (MessageBox.Show("¿Está seguro que desea anular el reg #: " + _Info.IdArea + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            _Info.MotivoAnu = oFrm.motivoAnulacion;
                            _Info.IdUsuarioAnu = param.IdUsuario;
                            _Info.FechaAnu = param.Fecha_Transac;
                           
                            Get();
                            if (Bus.AnularDB(_Info))
                            {
                                MessageBox.Show("Anulado con éxito el reg #: " + _Info.IdArea);
                                CheckEstado.Checked = false;
                                lblEstado.Visible = true;
                                ucGe_Menu.Enabled_bntAnular = false;
                                this.Close();
                            }
                            else MessageBox.Show("No se pudo anular el reg #: " + _Info.IdArea + " Debido a: "
                                + msg, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo anular el reg #: " + _Info.IdArea, "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
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
                if (txtDescripcion.EditValue == null || txtDescripcion.Text == "") 
                {
                    MessageBox.Show("Por Favor Ingrese Descripcion");
                    return false;
                }
                if (cmbDivision.EditValue == null )
                {
                    MessageBox.Show("Por Favor Seleccione Division");
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
       
        private void frmRo_AreaMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              Event_frmRo_AreaMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }
      
        private void txtId_EditValueChanged(object sender, EventArgs e){}

        private void frmRo_AreaMant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
            }
        }

        public void Limpiar()
        {
            try
            {
                txtDescripcion.Text = "";
                txtId.Text = "0";
                txtId.EditValue = null;
                cmbDivision.Properties.DataSource = _Division_B.ConsultaGeneral(param.IdEmpresa);
                CheckEstado.Checked = true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}
