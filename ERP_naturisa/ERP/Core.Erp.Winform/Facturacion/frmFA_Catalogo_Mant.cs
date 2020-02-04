using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Winform.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Catalogo_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_catalogo_Info _Info = new fa_catalogo_Info();
        fa_catalogo_Bus Bus_Catalogo = new fa_catalogo_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        int IdTipoCatalago;
        public fa_catalogo_Info setInfo { get; set; }
        public delegate void delegate_frmFA_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Catalogo_Mant_FormClosing event_frmFA_Catalogo_Mant_FormClosing;
        private Cl_Enumeradores.eTipo_action _Accion;
        #endregion

        public frmFa_Catalogo_Mant(int idTipoCatalogo)
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmFA_Catalogo_Mant_FormClosing+=frmFA_Catalogo_Mant_event_frmFA_Catalogo_Mant_FormClosing;
                IdTipoCatalago = idTipoCatalogo;
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
                if (guardarDatos())
                {
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
                guardarDatos();
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
                if (Validar())
                {
                    Get();
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                          bolResult =  Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                         bolResult=   Actualizar();
                            break;
                    }
                }
                else
                    return false;

                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                string msjError = "";
                Get();                
                if (MessageBox.Show("Está seguro que desea anular el registro ?", "Anulación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Fecha_UltAnu  = DateTime.Now;
                    _Info.MotiAnula = ofrm.motivoAnulacion;

                    if (Bus_Catalogo.AnularDB(_Info, ref msjError))
                    {
                        this.txtIdCatalogo.Text = _Info.IdCatalogo.ToString();
                        MessageBox.Show("Se ha anulado correctamente el catálogo # :" + _Info.IdCatalogo);

                        this.lblAnulado.Visible = true;
                        this.ucGe_Menu.Enabled_bntAnular = false;
                    }
                    else
                    {
                        MessageBox.Show("Error " + msjError);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmFA_Catalogo_Mant_event_frmFA_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e){}

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
                    MessageBox.Show("Por favor ingrese la descripción", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        void Get()
        {
            try
            {
               
                _Info.Orden = Convert.ToInt32(txtOrden.Value);
                _Info.Nombre= txtDescripcion.Text;
                _Info.IdCatalogo_tipo = IdTipoCatalago;
                _Info.IdCatalogo = this.txtIdCatalogo.Text;
                _Info.Estado = "A";
                _Info.IdUsuario = param.IdUsuario;
                _Info.nom_pc = param.nom_pc;
                _Info.ip = param.ip;
                    
              
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
                txtOrden.Value = Convert.ToInt32(setInfo.Orden);
                txtDescripcion.Text = setInfo.Nombre;
                this.txtIdCatalogo.Text = setInfo.IdCatalogo;
               
                if (setInfo.Estado == "I")
                {
                    this.lblAnulado.Visible = true;
                    ucGe_Menu.Enabled_bntAnular = false;
                    
                }
                else
                {
                    this.lblAnulado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean Guardar()
        {
            try
            {
                string mensaje = "";
                string IdCatalogo = "";
                if (Bus_Catalogo.GuardarDB( _Info, ref IdCatalogo, ref mensaje))
                {
                    MessageBox.Show("Se ha guardado correctamente el catálogo # : " + IdCatalogo, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    return true;
                }
                else {
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string msjError = "";
                _Info.IdUsuarioUltMod = param.IdUsuario;
                _Info.FechaUltMod = DateTime.Now;
                if (Bus_Catalogo.ModificarDB(_Info, ref msjError))
                {
                    MessageBox.Show("Se ha actualizado correctamente el catálogo # : " + _Info.IdCatalogo);
                    Limpiar();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al actualizar " + msjError);
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

        private void frmFA_Catalogo_Mant_Load(object sender, EventArgs e)
        {
            try
            {
              
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.lblAnulado.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                     
                        this.txtIdCatalogo.Enabled = false;
                        this.txtIdCatalogo.BackColor = System.Drawing.Color.White;
                        this.txtIdCatalogo.ForeColor = System.Drawing.Color.Black;

                        this.txtIdCatalogo.Text = setInfo.IdCatalogo;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                     
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        this.txtIdCatalogo.Enabled = false;
                        this.txtIdCatalogo.BackColor = System.Drawing.Color.White;
                        this.txtIdCatalogo.ForeColor = System.Drawing.Color.Black;

                        this.txtDescripcion.Enabled = false;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White;
                        this.txtDescripcion.ForeColor = System.Drawing.Color.Black;

                        this.txtOrden.Enabled = false;
                        this.txtOrden.BackColor = System.Drawing.Color.White;
                        this.txtOrden.ForeColor = System.Drawing.Color.Black;

                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        

                        this.txtIdCatalogo.Enabled = false;
                        this.txtIdCatalogo.BackColor = System.Drawing.Color.White;
                        this.txtIdCatalogo.ForeColor = System.Drawing.Color.Black;

                        this.txtDescripcion.Enabled = false;
                        this.txtDescripcion.BackColor = System.Drawing.Color.White;
                        this.txtDescripcion.ForeColor = System.Drawing.Color.Black;

                        this.txtOrden.Enabled = false;
                        this.txtOrden.BackColor = System.Drawing.Color.White;
                        this.txtOrden.ForeColor = System.Drawing.Color.Black;


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
       
        private void frmFA_Catalogo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmFA_Catalogo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Limpiar()
        {
            try
            {
                txtDescripcion.Text = "";
                txtIdCatalogo.Text = "";
                txtOrden.EditValue = 0;
                txtIdCatalogo.Enabled = true;
                
            }
            catch (Exception ex)
            {
                
              Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
