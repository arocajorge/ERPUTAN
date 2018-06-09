using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_TerminoPagos_Mant : Form
    {

        #region Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        
        Cl_Enumeradores.eTipo_action _Accion = new Cl_Enumeradores.eTipo_action();


        com_TerminoPago_Bus Bus_comprador = new com_TerminoPago_Bus();
        com_TerminoPago_Info Info = new com_TerminoPago_Info();

        
        public delegate void delegate_FrmCom_TerminoPagos_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_TerminoPagos_Mant_FormClosing event_FrmCom_TerminoPagos_Mant_FormClosing;
        int C = 0;
        string MensajeError = "";

        #endregion

        public FrmCom_TerminoPagos_Mant()
        {
            InitializeComponent();
            UcGe_Menu.event_btnGuardar_Click += UcGe_Menu_event_btnGuardar_Click;
            UcGe_Menu.event_btnGuardar_y_Salir_Click += UcGe_Menu_event_btnGuardar_y_Salir_Click;
            UcGe_Menu.event_btnAnular_Click += UcGe_Menu_event_btnAnular_Click;
            UcGe_Menu.event_btnSalir_Click += UcGe_Menu_event_btnSalir_Click;
            UcGe_Menu.event_btnlimpiar_Click += UcGe_Menu_event_btnlimpiar_Click;
            event_FrmCom_TerminoPagos_Mant_FormClosing += FrmCom_TerminoPagos_Mant_event_FrmCom_TerminoPagos_Mant_FormClosing;
        }

        void FrmCom_TerminoPagos_Mant_event_FrmCom_TerminoPagos_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void FrmCom_TerminoPagos_Mant_event_FrmCom_Solicitante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void UcGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }     
        }

        void UcGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void UcGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void UcGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void UcGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            } 
        }

        private void FrmCom_TerminoPagos_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                _Accion = (_Accion == 0) ? Cl_Enumeradores.eTipo_action.grabar : _Accion;

                Set_Accion_Control();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }  

        }


        private void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info = new com_TerminoPago_Info();

                txtcodigo.Text = "0";
                txtdescripcion.Text = "";
                txtdescripcion.Focus();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void grabar()
        {
            try
            {
                txtcodigo.Focus();
                Get_Info_Termino_Pago();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        string ver = "";
                        
                        if (txtdescripcion.Text != string.Empty)
                        {
                            
                        }

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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }                
        }
      
        void Guardar()
        {
            try
            {
                if (txtdescripcion.Text == "")
                {
                    txtdescripcion.Focus();
                    return;
                }

                if (Bus_comprador.GuardarDB(Info))
                {
                    txtcodigo.Text = Info.IdTerminoPago.ToString();
                    //Grabado_satisfactoriamente
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
                     
        }

        void Actualizar()
        {
            try
            {
                 if (Bus_comprador.ModificarDB(Info))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
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

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }              
        }

        void Anular()
        {
            try
            {
                if (Info.IdTerminoPago != "")
                {
                    //Esta_seguro_Eliminar
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_Eliminar) + " #:" + Info.IdTerminoPago , param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        Info.IdUsuarioUltAnu = param.IdUsuario;
                        Info.Fecha_UltAnu = DateTime.Now;
                        Info.MotiAnula = ofrm.motivoAnulacion;

                        if (Info.Estado == "A")
                        {
                            if (Bus_comprador.AnularDB(Info))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Grabado_satisfactoriamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UcGe_Menu.Visible_bntAnular = false;
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
                            //Debido_q_ya_se_encuentra_anulado
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular_registro) + Info.IdTerminoPago + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }

                }
                else
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public com_TerminoPago_Info Get_Info_Termino_Pago()
        {
            try
            {
                Info.IdTerminoPago = (txtcodigo.Text == "") ? "0" : txtcodigo.Text;
                Info.Descripcion = txtdescripcion.Text;
                Info.Dias = Convert.ToInt32(txtdias.Text);
                

                if (this.chk_activo.Checked == true)
                {
                    Info.Estado = "A";
                }
                else
                {
                    Info.Estado = "I";
                }
                return Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new com_TerminoPago_Info();
            }
        }

        private void Set_Info_Termino_Pago_In_Controls()
        {
            try
            {
                if (Info != null)
                {
                    txtcodigo.Text = Info.IdTerminoPago.ToString();
                    txtdescripcion.Text = Info.Descripcion;
                    txtdias.Text = Info.Dias.ToString();

                    if (Info.Estado == "I")
                    {
                        this.chk_activo.Checked = false;
                        lblAnulado.Visible = true;
                    }
                    else
                    {
                        chk_activo.Checked = true;
                        lblAnulado.Visible = false;
                    }
                }
                else
                { 
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_modi), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Info(com_TerminoPago_Info _Info)
        {
            try
            {
                Info = _Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

       private  void Set_Accion_Control()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        
                        txtcodigo.Enabled = false;
                        txtcodigo.BackColor = System.Drawing.Color.White;
                        txtcodigo.ForeColor = System.Drawing.Color.Black;
                        chk_activo.Checked = true;
                        chk_activo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        
                        UcGe_Menu.Enabled_bntLimpiar = false;
                        Set_Info_Termino_Pago_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        UcGe_Menu.Visible_btnGuardar = false;
                        UcGe_Menu.Visible_bntGuardar_y_Salir = false;
                        UcGe_Menu.Visible_bntAnular = true;

                        UcGe_Menu.Enabled_bntLimpiar = false;

                        Set_Info_Termino_Pago_In_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        UcGe_Menu.Visible_bntLimpiar = false;
                        UcGe_Menu.Visible_btnGuardar = false;
                        UcGe_Menu.Visible_bntGuardar_y_Salir = false;
                        UcGe_Menu.Visible_bntAnular = false;
                        UcGe_Menu.Visible_bntImprimir = false;
                        Set_Info_Termino_Pago_In_Controls();
                        break;
                    default:
                        break;
                }

                
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        public Boolean Validar()
        {
            try
            {
                txtdescripcion.Focus();

                if (txtdescripcion.Text == null || txtdescripcion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Descripcion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdescripcion.Focus();
                    return false;
                }
               

                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void FrmCom_TerminoPagos_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmCom_TerminoPagos_Mant_FormClosing(sender, e);

        }

        

        


        
    }
}
