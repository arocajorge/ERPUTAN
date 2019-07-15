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
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Winform.General;
using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.Inventario;

    public partial class FrmCom_CompradorMantenimiento : Form
    {
        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus BusPersona = new tb_persona_bus();
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        com_comprador_Bus Bus_comprador = new com_comprador_Bus();
        tb_persona_Info InfoPersona = new tb_persona_Info();
        com_comprador_Info Info = new com_comprador_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<seg_usuario_info> list_usuario = new List<seg_usuario_info>();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();
        BindingList<com_comprador_familia_Info> blst = new BindingList<com_comprador_familia_Info>();
        in_Familia_Bus bus_familia = new in_Familia_Bus();
        com_comprador_familia_Bus bus_det = new com_comprador_familia_Bus();
        public com_comprador_Info _SetInfo { get; set; }
        public delegate void delegate_FrmCom_CompradorMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_CompradorMantenimiento_FormClosing event_FrmCom_CompradorMantenimiento_FormClosing;
        int C = 0;
        string MensajeError = "";
        #endregion

        public FrmCom_CompradorMantenimiento()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            event_FrmCom_CompradorMantenimiento_FormClosing += FrmCom_CompradorMantenimiento_event_FrmCom_CompradorMantenimiento_FormClosing;
           
        }

        void FrmCom_CompradorMantenimiento_event_FrmCom_CompradorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmCom_CompradorMantenimiento(Cl_Enumeradores.eTipo_action Numerador): this()
          {
              try
              {
                   enu = Numerador;
              }
              catch (Exception ex)
              {
                  Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
          }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
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

        private void LimpiarDatos()
        {
            try
            {
                enu = Cl_Enumeradores.eTipo_action.grabar;
                Info = new com_comprador_Info();

                txtIdComprador.EditValue= "";
                txtNombre.Text = "";
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                cmbIdUsuario.EditValue = null;
                blst = new BindingList<com_comprador_familia_Info>();
                gc_detalle.DataSource = blst;
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                    this.Close();
                }
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    grabar();
                }
                            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txtIdComprador.Focus();
                GetComprador();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        Actualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        Anular();
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
      
        void Guardar()
        {
            try
            {
                if (txtNombre.EditValue == null)
                {
                    MessageBox.Show("Ingrese el nombre del comprador","Sistemas");
                    txtNombre.Focus();
                    return;                
                }

                if (Bus_comprador.GuardarDB(Info, ref MensajeError))
                {                  
                    txtIdComprador.EditValue = Info.IdComprador;
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El comprador ", Info.IdComprador);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Error);
                                
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
                 if (Bus_comprador.ModificarDB(Info, ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El comprador", Info.IdComprador);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                    //ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;    
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                          
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        void Anular()
        {
            try
            {
                if (Info.IdComprador != 0 )
                {
                    if (MessageBox.Show("¿Está seguro que desea anular eL Comprador #: " + Info.IdComprador + " ?", "Anulación de Comprador ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        Info.IdUsuarioUltAnu = param.IdUsuario;
                        Info.Fecha_UltAnu = DateTime.Now;
                        Info.MotiAnula = ofrm.motivoAnulacion;

                        if (Info.Estado == "A")
	                    {
		                        if (Bus_comprador.AnularDB(Info, ref MensajeError))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El comprador", Info.IdComprador);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                                    lblAnulado.Visible = true;
                                } 
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular, MensajeError);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);                                    
                                } 
	                    }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Comprador:  " + Info.IdComprador + " debido a que ya se encuentra anulado", "Anulación de Comprador ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                   
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void GetComprador()
        {
            try
            {
                txtIdComprador.Focus();
                Info.IdComprador = Convert.ToDecimal((txtIdComprador.EditValue == "") ? "0" : txtIdComprador.EditValue);                
                Info.IdEmpresa = param.IdEmpresa;
                Info.Descripcion = Convert.ToString(txtNombre.EditValue);
                Info.IdUsuario = param.IdUsuario;
                Info.IdUsuario_com = Convert.ToString(cmbIdUsuario.EditValue);
                Info.Fecha_Transac = DateTime.Now;
                Info.Correo = txt_correo.Text;
                Info.ListaDetalle = new List<com_comprador_familia_Info>(blst);

                Info.ListaDetalle = Info.ListaDetalle.GroupBy(q => q.IdFamilia).Select(q => new com_comprador_familia_Info
                {
                    IdFamilia = q.Key
                }).ToList();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetComprador()
        {
            try
            {
                if (Info != null)
                {
                    if (_SetInfo != null)
                    {
                        txtIdComprador.EditValue = _SetInfo.IdComprador;
                        txtNombre.EditValue = _SetInfo.Descripcion;
                        cmbIdUsuario.EditValue = _SetInfo.IdUsuario_com == "" ? null : _SetInfo.IdUsuario_com;
                        txt_correo.Text = _SetInfo.Correo;
                        blst = new BindingList<com_comprador_familia_Info>(bus_det.GetList(param.IdEmpresa,_SetInfo.IdComprador));
                        gc_detalle.DataSource = blst;
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un comprador para poder modificarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un comprador para poder modificarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                
        private void FrmCom_CompradorMantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                blst = new BindingList<com_comprador_familia_Info>();
                gc_detalle.DataSource = blst;
                Cargar_combos();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                 
                         C = 1;
                        Inhabilita_Campos(C);                                                              
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;

                        C = 3;
                        Inhabilita_Campos(C);
                                                                   
                        SetComprador();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;

                        C = 4;
                        Inhabilita_Campos(C);

                        SetComprador();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = true;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;

                        C = 4;
                        Inhabilita_Campos(C);
                                           
                        SetComprador();
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

        void Inhabilita_Campos(int C)
        {
            try
            {
                if (C == 1)
                {
                    txtIdComprador.Enabled = false;
                    txtIdComprador.BackColor = System.Drawing.Color.White;
                    txtIdComprador.ForeColor = System.Drawing.Color.Black;                
                }
                if(C==4)
                {
                
                txtIdComprador.Enabled = false;
                txtIdComprador.BackColor = System.Drawing.Color.White;
                txtIdComprador.ForeColor = System.Drawing.Color.Black;

                txtNombre.Enabled = false;
                txtNombre.BackColor = System.Drawing.Color.White;
                txtNombre.ForeColor = System.Drawing.Color.Black;
                }

                if (C == 3)
                {

                    txtIdComprador.Enabled = false;
                    txtIdComprador.BackColor = System.Drawing.Color.White;
                    txtIdComprador.ForeColor = System.Drawing.Color.Black;
                }             
            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
              MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                
        }
      
        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtIdComprador_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                txtNombre.Focus();

                if (txtNombre.EditValue == null || txtNombre.Text == "")
                {
                    MessageBox.Show("Por Favor Ingresar Nombre");
                    txtNombre.Focus();
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

        private void FrmCom_CompradorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               this.event_FrmCom_CompradorMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos()
        {
            try
            {
                list_usuario = bus_usuario.Get_List_Usuario_x_Empresa(param.IdEmpresa, ref MensajeError);
                cmbIdUsuario.Properties.DataSource = list_usuario;

                cmb_familia.DataSource = bus_familia.GetList(param.IdEmpresa);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gv_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Delete)
                {
                    gv_detalle.DeleteSelectedRows();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
