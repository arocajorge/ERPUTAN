using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_Catalogo_Mantenimiento : Form
    {

        #region Declaración de Variables
        string IdTipoCatalago;
        public cxc_catalogo_Info setInfo { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cxc_catalogo_Info _Info = new cxc_catalogo_Info();
        cxc_catalogo_Bus CatalogoBus = new cxc_catalogo_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_Event_frmCxc_Catalogo_Mantenimiento_FormClosing Event_frmCxc_Catalogo_Mantenimiento_FormClosing;

        #endregion
        
        public frmCxc_Catalogo_Mantenimiento(string idTipoCatalogo)
        {
            try
            {
                InitializeComponent();
                IdTipoCatalago = idTipoCatalogo;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
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
                LimpiarDatos();
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
                Get();
                _Info.FechaUltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (MessageBox.Show("Está Seguro que desea Anular  ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CatalogoBus.AnularDB(_Info))
                    {
                        txtId.Text = _Info.IdCatalogo.ToString();
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El registro ", _Info.IdCatalogo);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Se Anulado Correctamente #:" + _Info.IdCatalogo);
                        bloquear_Datos();                        
                        ucGe_Menu.Enabled_bntAnular = false;
                    }
                }
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
                _Info = new cxc_catalogo_Info();
                txtOrden.Value = 0;
                txtDescripcion.Text = "";                
                txtId.Text = "";
                cbxEstado.Checked = true;
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
                Close();
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
                    if (guardarDatos()) 
                        Close();
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
                    guardarDatos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        Boolean guardarDatos()
        {
            try
            {
                Boolean bolResult = true;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                            bolResult = Guardar();                       
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:                       
                            bolResult = Actualizar();
                        
                        break;
                    default: MessageBox.Show("hi");
                        break;
                }
                return  bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frmCxc_Catalogo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtId.Enabled = false;
                        txtId.Text = setInfo.IdCatalogo;
                        txtId.BackColor = Color.White;
                        txtId.ForeColor = Color.Black;
                        ucGe_Menu.Enabled_bntAnular = false;
                        if (setInfo.Estado == "I")
                        {
                            
                            cbxEstado.Enabled = true;
                        }
                        else
                        {
                            cbxEstado.Enabled = false;
                        }
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        bloquear_Datos();
                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        bloquear_Datos();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        Set();
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

        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
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

        Boolean Validar()
        {
            try
            {
                if (txtDescripcion.Text == "" || txtDescripcion.Text == null)
                {
                    MessageBox.Show("Por Favor Ingrese Descripción", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Boolean bolResult = true;
                Get();
                _Info.IdUsuario = param.IdUsuario;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;

                if (txtId.Text == "" || txtId.Text == null)
                {
                    _Info.IdCatalogo = CatalogoBus.GetId();
                }
                if (CatalogoBus.ValidarCodigoExiste(_Info.IdCatalogo) == false)
                {
                    if (CatalogoBus.ValidarIdTipoCatalogo_Descripcion(_Info.IdCatalogo_tipo, _Info.Nombre)==false)
                    {
                        if (CatalogoBus.GuardarDB(_Info))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro ", _Info.IdCatalogo);
                            MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);                        
                            
                            LimpiarDatos();
                        }
                        else
                        {
                            bolResult = false;
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Grabar,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        bolResult = false;
                        MessageBox.Show("La Descripción Asignada Ya Existe", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    bolResult = false;
                    MessageBox.Show("El Código Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        Boolean Actualizar()
        {            
            try
            {
                Boolean bolResult = true;
                Get();
                _Info.FechaUltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (CatalogoBus.ModificarDB(_Info))
                {
                    txtId.Text = _Info.IdCatalogo.ToString();
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El registro ", _Info.IdCatalogo);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    
                    LimpiarDatos();
                    lblEstado.Visible = false;
                }
                else
                    bolResult = false;

                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public void bloquear_Datos()
        {
            try
            {
                txtId.BackColor = Color.White;
                txtId.ForeColor = Color.Black;
                txtId.Enabled = false;
                txtDescripcion.Enabled = false;
                txtDescripcion.BackColor = Color.White;
                txtDescripcion.ForeColor = Color.Black;
                txtOrden.Enabled = false;
                cbxEstado.Enabled = false;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        void Get()
        {
            try
            {
                _Info.Orden= Convert.ToInt32(txtOrden.Value);
                _Info.Nombre = txtDescripcion.Text;
                _Info.IdCatalogo_tipo = IdTipoCatalago;
                _Info.IdCatalogo = txtId.Text;


                if (cbxEstado.Checked == true)
                {
                    _Info.Estado = "A";
                }
                else
                {
                    _Info.Estado = "I";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void Set()
        {
            try
            {
                txtOrden.Value = setInfo.Orden;
                txtDescripcion.Text = setInfo.Nombre;
                txtId.Text = setInfo.IdCatalogo;
                if (setInfo.Estado == "I")
                {
                    lblEstado.Visible = true;
                    cbxEstado.Checked = false;
                }
                else
                {
                    cbxEstado.Checked = true;
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       


        private void frmCxc_Catalogo_Mantenimiento_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmCxc_Catalogo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
