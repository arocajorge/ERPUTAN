using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Talonario_cheques_x_bancoMant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Talonario_cheques_x_banco_Bus ba_Talonario_cheques_x_banco_B = new ba_Talonario_cheques_x_banco_Bus();
        ba_Talonario_cheques_x_banco_Info Info = new ba_Talonario_cheques_x_banco_Info();
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Bus BusCuentaBan = new ba_Banco_Cuenta_Bus();
        public delegate void delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Talonario_cheques_x_bancoMant_FormClosing Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing;
        public string numcheq;
        #endregion
       
        public FrmBA_Talonario_cheques_x_bancoMant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            //Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing += FrmBA_Talonario_cheques_x_bancoMant_Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing;
        }


        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
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
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Grabar();
                    Limpiar();
                    cmbCuentaContable.Text = "[Vacío]";
                }

                if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    Modificar();
                    Limpiar();
                }

                if (Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Anular();
                    this.Close();
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
                if (Accion == Cl_Enumeradores.eTipo_action.Anular)
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


         private void FrmBA_Talonario_cheques_x_bancoMant_Load(object sender, EventArgs e)
         {
             try
             {
                 carga_Combos();
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
            
         }
      
         private void cmbCuentaContable_EditValueChanged_1(object sender, EventArgs e)
         {
             try
             {
                 int d = 0;

                 ba_Banco_Cuenta_Info obj_cmbProve = (ba_Banco_Cuenta_Info)cmbCuentaContable.Properties.View.GetFocusedRow();
                 if (obj_cmbProve != null)
                 {
                     txtdigitos.EditValue = obj_cmbProve.ba_num_digito_cheq;
                     txtidbanco.EditValue = obj_cmbProve.IdBanco;

                     string micadena = "1";
                     d = Convert.ToInt32(txtdigitos.EditValue);
                     label1.Text = micadena.PadLeft(d, '0');
                 }


             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
         }

         public void set_Info(ba_Talonario_cheques_x_banco_Info _Info)
         {
             try
             {
                 txtNumChq.Text = _Info.Num_cheque;
                 txtidbanco.Text = _Info.IdBanco.ToString();
                 numcheq = _Info.Num_cheque; 

                 cmbCuentaContable.EditValue = _Info.IdBanco;
                 ba_Banco_Cuenta_Info obj_cmbProve = new ba_Banco_Cuenta_Info();
                 obj_cmbProve =BusCuentaBan.Get_Info_Banco_Cuenta(_Info.IdEmpresa,_Info.IdBanco);

                 txtdigitos.EditValue = obj_cmbProve.ba_num_digito_cheq;
                 txtidbanco.EditValue = obj_cmbProve.IdBanco;

                 txtsecuencia.Text = _Info.secuencia.ToString();
                 chkEstado.Checked = (_Info.Estado == "A") ? true : false;
                 lblCbt_TipoAnulacion.Visible = (_Info.Estado == "I") ? true : false;
                 chkusado.Checked = (_Info.Usado == null) ? false : Convert.ToBoolean(_Info.Usado);
                // cmbCuentaContable.EditValue = Info.cuenta;
                // txtdigitos.Text = Info.numdig.ToString();
                 string micadena = "1";
                 int d = Convert.ToInt32(txtdigitos.EditValue);
                 label1.Text = micadena.PadLeft(d, '0');
                 Info = _Info;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
         }

         public ba_Talonario_cheques_x_banco_Info get_Info()
         {
             try
             {
                 Info.Num_cheque = txtNumChq.Text.PadLeft(Convert.ToInt32(txtdigitos.Text), '0');
                 Info.IdEmpresa = param.IdEmpresa;

                 Info.IdBanco = Convert.ToInt32(txtidbanco.Text);
                 Info.secuencia = Convert.ToInt32((txtsecuencia.Text == "") ? "0" : txtsecuencia.Text);
                 Info.Estado = (chkEstado.Checked == true) ? "A" : "I";
                 Info.Usado = chkusado.Checked;

                 //Info.cuenta =  cmbCuentaContable.EditValue.ToString();
                 Info.numdig = Convert.ToInt32(txtdigitos.Text);
                 Info.ejemplo = Convert.ToInt32(label1.Text);
                 return Info;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return new ba_Talonario_cheques_x_banco_Info();
             }
         }

         private void Limpiar()
         {
             try
             {
                 txtNumChq.Text = "";
                 txtdigitos.Text = "";
                 chkEstado.Checked = true;
                 chkusado.Checked = false;
                 
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
         }

         private Boolean Validar()
         {
             try
             {
                if (cmbCuentaContable.EditValue == null || cmbCuentaContable.Text == "[Vacío]")
                 {
                     MessageBox.Show("Error: Escoja un banco", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     return false;
                 }
                 //if (Convert.ToInt32( txtNumChq.Text.Length )!= Convert.ToInt32( txtdigitos.Text))
                 //{
                 //     MessageBox.Show("Error: Debe ingresar el número de dígitos correspondiente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 //    return false;
                 //}

                 if (txtNumChq.Text.Length == 0  || chkEstado.Text.Length == 0)
                 {
                     MessageBox.Show("Error: Ingrese Datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     return false;
                 }

                 

                 return true;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return false;
             }

         }

         public void set_Accion(Cl_Enumeradores.eTipo_action _Accion)
         {
             try
             {
                 Accion = _Accion;

                 switch (Accion)
                 {
                     case Cl_Enumeradores.eTipo_action.grabar:
                         Limpiar();
                         carga_Combos();
                         ucGe_Menu.Enabled_bntAnular = false;
                         ucGe_Menu.Enabled_bntLimpiar = true;
                         txtNumChq.Enabled = true;
                         break;
                     case Cl_Enumeradores.eTipo_action.actualizar:
                         carga_Combos();
                         ucGe_Menu.Enabled_bntAnular = false;
                         ucGe_Menu.Enabled_bntLimpiar = false;
                         txtNumChq.Enabled = false;
                         //txtNumChq.Enabled = false;
                         break;
                     case Cl_Enumeradores.eTipo_action.consultar:
                         ucGe_Menu.Enabled_bntAnular = false;
                         ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                         ucGe_Menu.Visible_btnGuardar = false;
                         ucGe_Menu.Enabled_bntLimpiar = false;
                         txtNumChq.Enabled = false;
                         chkEstado.Enabled = false;
                         chkusado.Enabled = false;
                         cmbCuentaContable.Enabled = false;
                         break;
                     case Cl_Enumeradores.eTipo_action.Anular:
                         ucGe_Menu.Enabled_bntAnular = true;
                         ucGe_Menu.Visible_bntAnular = true;
                         ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                         ucGe_Menu.Visible_btnGuardar = false;
                         ucGe_Menu.Enabled_bntLimpiar = false;
                         txtNumChq.Enabled = false;
                         cmbCuentaContable.Enabled = false;
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

         void carga_Combos()
         {
             try
             {
                 this.cmbCuentaContable.Properties.DataSource = BusCuentaBan.Get_list_Banco_Cuenta(param.IdEmpresa);
                 this.cmbCuentaContable.Properties.DisplayMember = "ba_descripcion";
                 this.cmbCuentaContable.Properties.ValueMember = "IdBanco";
             }
             catch (Exception ex)
             {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
             

         }
         private Boolean Grabar()
         {
             try
             {
                 //decimal secuencia = 0;
                 string msg = "";
                 string Mensaje = "";
                 if (Validar())
                 {
                     get_Info();
                     //poner una validacion
                     if (ba_Talonario_cheques_x_banco_B.Get_Info_Cheq_existe(Info.IdEmpresa, Info.IdBanco, Info.Num_cheque, ref Mensaje) != false)
                     {
                         if (ba_Talonario_cheques_x_banco_B.GrabarDB(Info, ref msg))
                         {
                             MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk, param.Nombre_sistema);
                         }
                     }
                     else
                     {
                         MessageBox.Show("Error: El numero de cheque ingresado: "+txtNumChq.Text+" ya existe, favor ingresar otro número",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         return false;
                     }
                 }
                 else
                 {
                     return false;
                 }
                 return true;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return false;
             }
         }

         private Boolean Modificar()
         {
             try
             {
                 string msg = "";
                 if (Validar())
                 {
                     get_Info();
                     if (ba_Talonario_cheques_x_banco_B.ModificarDB(Info, numcheq, ref msg))
                     {
                         MessageBox.Show("Modificado");
                         return true;
                     }
                     else
                     {
                         MessageBox.Show("Error al Modificar " + msg);
                         return false;
                     }
                 }
                 else
                 {
                     return false;
                 }
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return false;
             }
         }

         private Boolean Anular()
         {
             try
             {
                 Boolean resultB = false;
                 string mensaje = "";
                 if (Info.Estado == "A")
                 {
                     if (MessageBox.Show("¿Está seguro que desea anular ?", "Anulación  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                     {
                         FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                         ofrm.ShowDialog();

                         Info.IdUsuario_Anu = param.IdUsuario;
                         Info.FechaAnulacion = DateTime.Now;
                         Info.MotivoAnulacion = ofrm.motivoAnulacion;

                         if (ba_Talonario_cheques_x_banco_B.AnularDB(Info, ref mensaje))
                         {
                             string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El cheque", Info.Num_cheque);
                             MessageBox.Show(smensaje, param.Nombre_sistema);
                             //MessageBox.Show("N°: " + Info.Num_cheque + " ANULADO Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             resultB = true;
                         }
                         else
                         {
                             MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgError_Anular + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                             resultB = false;
                         }
                     }
                 }
                 else
                 {
                     MessageBox.Show("Error: El cheque escogido: " + Convert.ToString(Info.Num_cheque) + " ya se encuentra anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return false;
                 }
                 return resultB;
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                 return false;
             }
         }

    /*     private void frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
         {
             try
             {
                 Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(sender, e);
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
             }
         }*/

         private void FrmBA_Talonario_cheques_x_bancoMant_FormClosing(object sender, FormClosingEventArgs e)
         {
             try
             {
                 Event_FrmBA_Talonario_cheques_x_bancoMant_FormClosing(sender, e);
             }
             catch (Exception ex)
             {
                 string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                 MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                 Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
             }
         }

         private void txtNumChq_KeyPress(object sender, KeyPressEventArgs e)
         {
             try
             {
                 if (Char.IsDigit(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else if (Char.IsControl(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else if (Char.IsSeparator(e.KeyChar))
                 {
                     e.Handled = false;
                 }
                 else
                 {
                     e.Handled = true;
                 }
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
