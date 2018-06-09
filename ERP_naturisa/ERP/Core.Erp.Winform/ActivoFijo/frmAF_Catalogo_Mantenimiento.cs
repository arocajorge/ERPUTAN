using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Catalogo_Mantenimiento : DevExpress.XtraEditors.XtraForm
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string IdTipoCatalago;
        public Af_Catalogo_Info setInfo { get; set; }
        Af_Catalogo_Info _Info = new Af_Catalogo_Info();
        Af_Catalogo_Bus CatalogoBus = new Af_Catalogo_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_Event_frmAF_Catalogo_Mantenimiento_FormClosing Event_frmAF_Catalogo_Mantenimiento_FormClosing;

        #endregion
       
        public frmAF_Catalogo_Mantenimiento(string idTipoCatalogo)
        {
            try
            {
                InitializeComponent();
                IdTipoCatalago = idTipoCatalogo;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Get();
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_Eliminar), param.Nombre_sistema, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    _Info.IdUsuarioUltAnu = param.IdUsuario;
                    _Info.Fecha_UltAnu = DateTime.Now;
                    _Info.MotiAnula = ofrm.motivoAnulacion;

                    if (CatalogoBus.Anular(_Info))
                    {
                        txtIdCat.Text = _Info.IdCatalogo.ToString();
                        MessageBox.Show("Se Anulado Correctamente #:" + _Info.IdCatalogo, param.Nombre_sistema);
                        bloquear_Datos();
                        this.ucGe_Menu.Enabled_bntAnular = false;
                        lbl_Estado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_Catalogo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtIdCat.Enabled = false;
                        txtIdCat.Text = setInfo.IdCatalogo;
                        txtIdCat.BackColor = Color.White;
                        txtIdCat.ForeColor = Color.Black;
                        ucGe_Menu.Enabled_bntAnular = false;
                        if (setInfo.Estado == "I")
                        {

                            chk_estado.Enabled = true;
                        }
                        else
                        {
                            chk_estado.Enabled = false;
                        }
                        Set();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        bloquear_Datos();
                        Set();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        //bloquear_Datos();
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        Boolean Validar()
        {
            try
            {
                if (txtDescrip.Text == "" || txtDescrip.EditValue == null)
                {
                    MessageBox.Show("Por Favor Ingrese Descripcion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (txtIdCat.Text == "" || txtIdCat.EditValue == null)
                {
                    _Info.IdCatalogo = CatalogoBus.GetIdCatalogo(_Info.IdTipoCatalogo);
                }
                if (CatalogoBus.ValidarCodigoExiste(_Info.IdCatalogo) == false)
                {
                    if (CatalogoBus.ValidarIdTipoCatalogo_Descripcion(_Info.IdTipoCatalogo, _Info.Descripcion)==false)
                    {
                        if (CatalogoBus.GuardarDB(_Info))
                        {
                            MessageBox.Show("Se Guardado Correctamente #:" + _Info.IdCatalogo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Enabled_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido grabar:" + _Info.IdCatalogo, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else {
                        MessageBox.Show("La Descripción Asignada Ya Existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El Codigo Ingresado Ya se encuentra asignado \n Por favor ingrese uno nuevo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Actualizar()
        {
            
            try
            {
                Get();
                _Info.FechaUltMod = param.Fecha_Transac;
                _Info.IdUsuarioUltMod = param.IdUsuario;
                if (CatalogoBus.Modificar(_Info))
                {
                    txtIdCat.Text = _Info.IdCatalogo.ToString();
                    MessageBox.Show("Se Actualizado Correctamente #:" + _Info.IdCatalogo);
                    lbl_Estado.Visible = false;
                    //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    //ucGe_Menu.Enabled_btnGuardar = false;
                    LimpiarDatos();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _Info = new Af_Catalogo_Info();
                txtOrdenCat.Value = 0;
                txtDescrip.Text = "";                
                txtIdCat.Text = "";
                chk_estado.Checked = true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bloquear_Datos()
        {
            try
            {
                ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                ucGe_Menu.Visible_btnGuardar = false;
                ucGe_Menu.Visible_bntAnular = false;
                txtIdCat.BackColor = Color.White;
                txtIdCat.ForeColor = Color.Black;
                txtIdCat.Enabled = false;
                txtDescrip.Enabled = false;
                txtDescrip.BackColor = Color.White;
                txtDescrip.ForeColor = Color.Black;
                txtOrdenCat.Enabled = false;
                chk_estado.Enabled = false;
               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        void Get()
        {
            try
            {
                _Info.Orden = Convert.ToInt32(txtOrdenCat.Value);
                _Info.Descripcion = txtDescrip.Text;
                _Info.IdTipoCatalogo = IdTipoCatalago;
                _Info.IdCatalogo = txtIdCat.Text;


                if (chk_estado.Checked == true)
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        void Set()
        {
            try
            {
                txtOrdenCat.Value = setInfo.Orden;
                txtDescrip.Text = setInfo.Descripcion;
                txtIdCat.Text = setInfo.IdCatalogo;
                if (setInfo.Estado == "I")
                {
                    lbl_Estado.Visible = true;
                    ucGe_Menu.Enabled_bntAnular = false;
                    chk_estado.Checked = false;
                }
                else
                {
                    chk_estado.Checked = true;
                    lbl_Estado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void frmAF_Catalogo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmAF_Catalogo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
