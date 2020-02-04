using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_CatalogoTipo_Mantenimiento : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        com_CatalogoTipo_Bus Bus = new com_CatalogoTipo_Bus();
        public com_CatalogoTipo_Info _SetInfo { get; set; }
        com_CatalogoTipo_Info _Info = new com_CatalogoTipo_Info();
        FrmCom_Catalogo fr = new FrmCom_Catalogo();
        public delegate void delegate_FrmCom_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_CatalogoTipo_Mantenimiento_FormClosing Event_FrmCom_CatalogoTipo_Mantenimiento_FormClosing;
        
        #endregion

        public FrmCom_CatalogoTipo_Mantenimiento()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
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
                Close();
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
                txtId.Text = "";
                txtDescripcion.Text = "";
                txtId.Enabled = true;
                txtDescripcion.Enabled = true;
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
                    ucGe_Menu_event_btnGuardar_Click(sender,e);                    
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
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
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

        void BloquearDatos()
        {
            try
            {
                txtId.BackColor = Color.White;
                txtId.ForeColor = Color.Black;
                txtId.Enabled = false;
                txtDescripcion.Enabled = false;
                txtDescripcion.BackColor = Color.White;
                txtDescripcion.ForeColor = Color.Black;
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
                
                if (validar())
                {
                    if (Bus.ValidarCodigoExiste(_Info.IdCatalogocompra_tipo) == false)
                    {

                        if (Bus.GuardarDB(_Info))
                        {
                            BloquearDatos();
                            fr.cargalista();
                            MessageBox.Show("Se ha ingresado Correctamente el Catálogo #:" + _Info.IdCatalogocompra_tipo);
                           
                        }

                    }
                    else
                    {
                        MessageBox.Show("El Codigo Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo");
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Modificar()
        {
            try
            {
                if (validar())
                {
                    if (Bus.Modificar(_Info))
                    {
                        txtId.Text = _Info.IdCatalogocompra_tipo.ToString();
                        MessageBox.Show("Se ha Actualizado Correctamente el registro #:" + _Info.IdCatalogocompra_tipo);
                        fr.cargalista();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmCom_CatalogoTipo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        txtId.Enabled = false;
                        txtId.BackColor = Color.White;
                        txtId.ForeColor = Color.Black;
                        Set(_Info);
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        Set(_Info);
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        Set(_Info);
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

        public void Set(com_CatalogoTipo_Info _SetInfo)
        {
            try
            {
                txtDescripcion.Text = _SetInfo.Descripcion;
                txtId.Text = _SetInfo.IdCatalogocompra_tipo;

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
                _Info.Descripcion = txtDescripcion.Text;
                _Info.IdCatalogocompra_tipo = txtId.Text;

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
      
        Boolean validar()
        {
            try
            {
                if (txtId.EditValue == null || txtId.Text == "")
                {
                    MessageBox.Show("Debe Ingresar El Codigo", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (txtDescripcion.EditValue == null || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Debe Ingresar La Descripción", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        
        private void FrmCom_CatalogoTipo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmCom_CatalogoTipo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_CatalogoTipo_Mantenimiento_Load_1(object sender, EventArgs e)
        {
            
        }

       
    }
}
