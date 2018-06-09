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
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_TipoDeFlujoMant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        ba_TipoFlujo_Bus Bus = new ba_TipoFlujo_Bus();
        public ba_TipoFlujo_Info SetInfo { get; set; }
        ba_TipoFlujo_Info Info = new ba_TipoFlujo_Info();
        public delegate void delegate_frmba_TipoDeFlujoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmba_TipoDeFlujoMant_FormClosing Event_frmba_TipoDeFlujoMant_FormClosing;
        #endregion        
        
        public FrmBA_TipoDeFlujoMant()
        {
            try
            {
                InitializeComponent();
                Event_frmba_TipoDeFlujoMant_FormClosing += frmba_TipoDeFlujoMant_Event_frmba_TipoDeFlujoMant_FormClosing;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese descripción", param.Nombre_sistema);
                    return;
                }
                this.ucGe_Menu_event_btnGuardar_Click(sender,e);
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese descripción", param.Nombre_sistema);
                    return;
                }
                Get();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Guardar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Anular();
                    this.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmba_TipoDeFlujoMant_Event_frmba_TipoDeFlujoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        public void SetAccion(Cl_Enumeradores.eTipo_action iAccion )
            {
                try
                {
                   _Accion = iAccion;
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                }

            }
         
        void set() 
        {
            try
            {

                txtDescripcion.Text = SetInfo.Descricion;
                txtIdTipoFlujo.Text = Convert.ToString(SetInfo.IdTipoFlujo);
                cbxEstado.Checked = SetInfo.Estado == "A" ? true : false;
                lblEstado.Visible = (SetInfo.Estado == "I") ? true : false;

                rbt_Ingreso.Checked = SetInfo.Tipo == "ING" ? true : false;
                txt_codigo.Text = SetInfo.cod_flujo;


                 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Get() 
        {
            try
            {
                Info = new ba_TipoFlujo_Info();
                Info.Descricion = txtDescripcion.Text;
                Info.IdTipoFlujoPadre = null;
                Info.IdTipoFlujo = Convert.ToInt32(txtIdTipoFlujo.Text == "" ? "0" : txtIdTipoFlujo.Text);
                Info.IdEmpresa = param.IdEmpresa;
                Info.Estado = cbxEstado.Checked==true ? "A": "I";
                Info.Tipo = rbt_Ingreso.Checked == true ? "ING" : "EGR";
                Info.cod_flujo = txt_codigo.Text;


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void frmba_TipoDeFlujoMant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ucGe_Menu.Visible_bntAnular = false;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            cbxEstado.Checked = true;
                            cbxEstado.Enabled = false;
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            ucGe_Menu.Visible_bntAnular = false;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            cbxEstado.Enabled = true;
                            cbxEstado.Visible = true;
                            set();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            ucGe_Menu.Visible_bntAnular = true;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                            set();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                           ucGe_Menu.Visible_bntAnular = false;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                    
                            set();
                            break;
                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Guardar()
        {
            try
            {
                decimal  IdTipoFlujo = 0;
                if (Bus.GuardarDB(Info, ref IdTipoFlujo))
                {
                    MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk,param.Nombre_sistema);
                    txtIdTipoFlujo.Text = IdTipoFlujo.ToString();
                    ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    ucGe_Menu.Visible_btnGuardar = true;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void Modificar() 
        {
            try
            {
                if (Bus.ModificarDB(Info))
                    {
                        MessageBox.Show("Registro actualizado correctamente", param.Nombre_sistema);
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
    
        }

        void Anular() 
        {
            try
            {
                string mensaje = "";

                if (lblEstado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                }
                else
                {
                    Get();
                    if (MessageBox.Show("¿Está seguro que desea anular Tipo de Flujo  ?", "Anulación de Tipo de Flujo  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        Info.IdUsuarioUltAnu = param.IdUsuario;
                        Info.Fecha_UltMod = DateTime.Now;
                        Info.MotiAnula = ofrm.motivoAnulacion;


                        if (Bus.AnularDB(Info))
                        {
                            MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaAnulacionOk, param.Nombre_sistema);
                            lblEstado.Visible = true;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

       
        
        private void frmba_TipoDeFlujoMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  Event_frmba_TipoDeFlujoMant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

      
    }
}

