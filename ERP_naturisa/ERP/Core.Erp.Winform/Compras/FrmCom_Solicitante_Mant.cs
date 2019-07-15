using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Business.SeguridadAcceso;
    public partial class FrmCom_Solicitante_Mant : Form
    {
        public FrmCom_Solicitante_Mant()
        {
            InitializeComponent();
            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            event_FrmCom_Solicitante_Mant_FormClosing += FrmCom_Solicitante_Mant_event_FrmCom_Solicitante_Mant_FormClosing;
        }

        private void FrmCom_Solicitante_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                _Accion = (_Accion == 0) ? Cl_Enumeradores.eTipo_action.grabar : _Accion;
                BList_det = new BindingList<com_solicitante_aprobador_Info>();
                gc_detalle.DataSource = BList_det;
                BList_dep = new BindingList<com_solicitante_x_com_departamento_Info>();
                gc_d.DataSource = BList_dep;
                Set_Accion_Control();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus BusPersona = new tb_persona_bus();
        Cl_Enumeradores.eTipo_action _Accion = new Cl_Enumeradores.eTipo_action();


        com_solicitante_Bus Bus_comprador = new com_solicitante_Bus();
        tb_persona_Info InfoPersona = new tb_persona_Info();
        com_solicitante_Info Info = new com_solicitante_Info();
        com_departamento_Bus bus_departamento = new com_departamento_Bus();
        seg_usuario_bus bus_usuario = new seg_usuario_bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_solicitante_aprobador_Bus bus_det = new com_solicitante_aprobador_Bus();
        BindingList<com_solicitante_aprobador_Info> BList_det = new BindingList<com_solicitante_aprobador_Info>();
        BindingList<com_solicitante_x_com_departamento_Info> BList_dep = new BindingList<com_solicitante_x_com_departamento_Info>();
        com_solicitante_x_com_departamento_Bus bus_solxdep = new com_solicitante_x_com_departamento_Bus();

        public delegate void delegate_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_Solicitante_Mant_FormClosing event_FrmCom_Solicitante_Mant_FormClosing;
        int C = 0;
        string MensajeError = "";
        #endregion

        
        void FrmCom_Solicitante_Mant_event_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info = new com_solicitante_Info();
                txtIdSolicitante.Text = "0";
                txtNombre.Text = "";
                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                ComboUsuario.EditValue = null;
                ComboDepartamento.EditValue = null;
                BList_det = new BindingList<com_solicitante_aprobador_Info>();
                gc_detalle.DataSource = BList_det;
                BList_dep = new BindingList<com_solicitante_x_com_departamento_Info>();
                gc_d.DataSource = BList_dep;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void grabar()
        {
            try
            {
                txtIdSolicitante.Focus();
                GetComprador();

                switch (_Accion)
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }
      
        void Guardar()
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese el nombre del Solicitante", "Sistemas");
                    txtNombre.Focus();
                    return;
                }

                if (Bus_comprador.GuardarDB(Info, ref MensajeError))
                {
                    txtIdSolicitante.Text = Info.IdSolicitante.ToString();
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Solicitante ", Info.IdSolicitante);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    LimpiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar, MensajeError);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                 if (Bus_comprador.ModificarDB(Info, ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Solicitante", Info.IdSolicitante);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        void Anular()
        {
            try
            {
                if (Info.IdSolicitante != 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea anular eL solicitante #: " + Info.IdSolicitante + " ?", "Anulación de solicitante ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        Info.IdUsuarioUltMod = param.IdUsuario;
                        Info.MotiAnula = ofrm.motivoAnulacion;

                        if (Info.estado == "A")
                        {
                            if (Bus_comprador.AnularDB(Info, ref MensajeError))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Solicitante", Info.IdSolicitante);
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
                            MessageBox.Show("No se pudo anular el solicitante:  " + Info.IdSolicitante + " debido a que ya se encuentra anulado", "Anulación de solicitante ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CargarCombos()
        {
            try
            {
                var lstUsuario = bus_usuario.Get_List_Usuario(ref MensajeError);
                var lstDepartamento = bus_departamento.Get_List_Departamento(param.IdEmpresa);

                ComboUsuario.Properties.DataSource = lstUsuario;
                cmb_Usuario.DataSource = lstUsuario;

                ComboDepartamento.Properties.DataSource = lstDepartamento;
                cmb_Departamento.DataSource = lstDepartamento;
                cmb_departamento_dep.DataSource = lstDepartamento;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void GetComprador()
        {
            try
            {
                Info.IdSolicitante = string.IsNullOrEmpty(txtIdSolicitante.Text) ? 0 : Convert.ToDecimal(txtIdSolicitante.Text);
                Info.IdEmpresa = param.IdEmpresa;
                Info.nom_solicitante = txtNombre.Text;
                Info.IdUsuario = ComboUsuario.EditValue.ToString();
                if (ComboDepartamento.EditValue == null)
                    Info.IdDepartamento = null;
                else
                    Info.IdDepartamento = Convert.ToDecimal(ComboDepartamento.EditValue);
                
                Info.IdUsuarioUltMod = param.IdUsuario;
                Info.ConsultaDepartamento = chk_ConsultaDepartamento.Checked;
                Info.ListaDetalle = new List<com_solicitante_aprobador_Info>(BList_det);
                Info.ListaDepartamento = new List<com_solicitante_x_com_departamento_Info>(BList_dep);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetComprador()
        {
            try
            {
                if (Info != null)
                {
                    txtIdSolicitante.Text = Info.IdSolicitante.ToString();
                    ComboDepartamento.EditValue = Info.IdDepartamento;
                    ComboUsuario.EditValue = Info.IdUsuario;
                    txtNombre.Text = Info.nom_solicitante;
                    chk_ConsultaDepartamento.Checked = Info.ConsultaDepartamento;
                    BList_det = new BindingList<com_solicitante_aprobador_Info>(bus_det.GetList(Info.IdEmpresa, Info.IdSolicitante));
                    gc_detalle.DataSource = BList_det;
                    BList_dep = new BindingList<com_solicitante_x_com_departamento_Info>(bus_solxdep.GetList(Info.IdEmpresa,Info.IdSolicitante));
                    gc_d.DataSource = BList_dep;
                 }
                else
                { 
                    MessageBox.Show("Por favor seleccione un solicitante para poder modificarlo", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
       {
            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        //el resto de teclas pulsadas se desactivan
                        e.Handled = true;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            try
            {
                //string msg = "";

                //if (txtCedula.Text != string.Empty)
                //{
                //    if (BusPersona.VericarCedulaExiste(txtCedula.Text, ref  msg))
                //    {
                //        InfoPersona = BusPersona.Get_Info_Persona(txtCedula.Text);

                //        txtNombre.EditValue = InfoPersona.pe_nombreCompleto;
                //        txtIdPersona.EditValue = Convert.ToDecimal(InfoPersona.IdPersona);
                //    }                    
                //}

                //else
                //{
                //    txtNombre.EditValue = "";
                //    txtIdPersona.EditValue = "";              
                //}
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Set_Info(com_solicitante_Info _Info)
        {
            try
            {
                Info = _Info;
            }
            catch (Exception ex)
            {


            }
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
            }
            catch (Exception ex)
            {
                
                
            }
        }

        void Set_Accion_Control()
        {
            try
            {
                CargarCombos();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        
                        txtIdSolicitante.Enabled = false;
                        txtIdSolicitante.BackColor = System.Drawing.Color.White;
                        txtIdSolicitante.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        SetComprador();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;

                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        SetComprador();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Visible_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntImprimir = false;
                        SetComprador();
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean Validar()
        {
            try
            {
                txtNombre.Focus();

                if (txtNombre.Text == null || txtNombre.Text == "")
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        

        private void FrmCom_Solicitante_Mant_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            event_FrmCom_Solicitante_Mant_FormClosing(sender, e);
        }


        private void gv_detalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                gv_detalle.DeleteSelectedRows();
            }
        }

    
    }
}
