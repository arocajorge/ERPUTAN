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
using Core.Erp.Winform.General;
namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Catalogo_Mantenimiento : Form
    {

        #region Declaración de Variables
        string IdTipoCatalago;
        public com_Catalogo_Info setInfo { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_Catalogo_Info _Info = new com_Catalogo_Info();
        com_Catalogo_Bus CatalogoBus = new com_Catalogo_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_Event_FrmCom_Catalogo_Mantenimiento_FormClosing Event_FrmCom_Catalogo_Mantenimiento_FormClosing;

        #endregion

        public FrmCom_Catalogo_Mantenimiento(string idTipoCatalogo)
        {
            try
            {
                InitializeComponent();
                IdTipoCatalago = idTipoCatalogo;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click +=ucGe_Menu_event_btnSalir_Click;
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
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
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            Guardar();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Validar())
                        {
                            Actualizar();
                        }
                        break;
                   
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            string motiAnulacion = "";
            try
            {
                Get();
                _Info.FechaUltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (MessageBox.Show("Está Seguro que desea Anular  ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                    fr.ShowDialog();
                      motiAnulacion = fr.motivoAnulacion;
                    _Info.MotivoAnulacion = motiAnulacion;
                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.FechaHoraAnul = DateTime.Now;
                    if (CatalogoBus.AnularDB(_Info))
                    {
                        txtId.Text = _Info.IdCatalogocompra.ToString();
                        MessageBox.Show("Se Anulado Correctamente #:" + _Info.IdCatalogocompra);
                        bloquear_Datos();
                        ucGe_Menu.Visible_bntAnular = false;
                        
                    }
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
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
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

        void Guardar()
        {

            try
            {
                Get();
                _Info.IdUsuario = param.IdUsuario;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;

                if (txtId.Text == "" || txtId.EditValue == null)
                {
                    _Info.IdCatalogocompra = CatalogoBus.GetId();
                }
                if (CatalogoBus.ValidarCodigoExiste(_Info.IdCatalogocompra) == false)
                {
                    if (CatalogoBus.ValidarIdTipoCatalogoCompra_Descripcion(_Info.IdCatalogocompra_tipo, _Info.Nombre) == false)
                    {
                        if (CatalogoBus.GuardarDB(_Info))
                        {
                            MessageBox.Show("Se Guardado Correctamente #:" + _Info.IdCatalogocompra, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //bloquear_Datos();
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido grabar:" + _Info.IdCatalogocompra, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La Descripción Asignada Ya Existe", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El Código Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _Info = new com_Catalogo_Info();
                txtId.Text = "";
                txtOrden.Value = 0;
                
                txtDescripcion.Text = "";
                cbxEstado.Checked = true;
             
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
                Get();
                _Info.FechaUltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (CatalogoBus.ModificarDB(_Info))
                {
                    txtId.Text = _Info.IdCatalogocompra.ToString();
                    MessageBox.Show("Se Actualizado Correctamente #:" + _Info.IdCatalogocompra);
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    LimpiarDatos();
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void bloquear_Datos()
        {
            try
            {
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_bntAnular = false;
                ucGe_Menu.Visible_bntImprimir = false;
                ucGe_Menu.Visible_bntLimpiar = false;
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

        public void Get()
        {
            try
            {
                _Info.orden = Convert.ToInt32(txtOrden.Value);
                _Info.Nombre = txtDescripcion.Text;
                _Info.IdCatalogocompra_tipo = IdTipoCatalago;
                _Info.IdCatalogocompra = txtId.Text;


                if (cbxEstado.Checked == true)
                {
                    _Info.estado = "A";
                }
                else
                {
                    _Info.estado = "I";
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set()
        {
            try
            {
                txtOrden.Value = Convert.ToInt32( setInfo.orden);
                txtDescripcion.Text = setInfo.Nombre;
                txtId.Text = setInfo.IdCatalogocompra;
                if (setInfo.estado == "I")
                {
                    lblEstado.Visible = true;
                    ucGe_Menu.Enabled_bntAnular = false;
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
      
        private void FrmCom_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_FrmCom_Catalogo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCom_Catalogo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntSalir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntSalir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        txtId.Enabled = false;
                        txtId.Text = setInfo.IdCatalogocompra;
                        txtId.BackColor = Color.White;
                        txtId.ForeColor = Color.Black;
                        ucGe_Menu.Visible_bntAnular = false;
                        if (setInfo.estado == "I")
                        {
                            cbxEstado.Enabled = true;
                            lblEstado.Visible = true;
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
                        ucGe_Menu.Visible_bntAnular = true;
                         ucGe_Menu.Visible_bntSalir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        bloquear_Datos();
                        ucGe_Menu.Visible_bntSalir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
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


       
    }
}
