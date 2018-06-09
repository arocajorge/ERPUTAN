using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Bancos;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Banco_Cuenta_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        public List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ba_Banco_Cuenta_Info BancoCuentI = new ba_Banco_Cuenta_Info();
        ba_Banco_Cuenta_Bus BancoCuentB = new ba_Banco_Cuenta_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;

        public delegate void delegate_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing;

        public ba_Banco_Cuenta_Info info_BaCuenta { get; set; }

        string MensajeError = "";
        #endregion
              
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion) 
        {
            try
            {
              _Accion = iAccion; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public FrmBA_Banco_Cuenta_Mant()
        {
            try
            {
                 InitializeComponent();
                 ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                 ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                 ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                 ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                 event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing += FrmBA_Banco_Cuenta_Mant_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }

        void FrmBA_Banco_Cuenta_Mant_event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {

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
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                { Close(); }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                { Limpiar(); }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    if (Anular())
                    {
                        this.Close();
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
        private void FrmBA_Banco_Cuenta_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                txtDescripcion.Focus();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        chkEstado.Checked = true;
                        chkEstado.Enabled = false;
                        cmbTipoCuenta.SelectedIndex = 0;
                        cmbMoneda.SelectedIndex = 0;
                        ucGe_Menu.Enabled_bntSalir = true;
                        lbl_Estado.Visible = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe_Menu.Visible_bntAnular = false;
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Enabled_bntSalir = true;
                       if (BancoCuentI.Estado == "I")
                       {
                           lbl_Estado.Visible = true;
                       }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        public ba_Banco_Cuenta_Info get_Info()
        {
            try
            {
                BancoCuentI.IdEmpresa = param.IdEmpresa;
                BancoCuentI.IdBanco_Financiero = UCBanco.get_IdBanco();
                BancoCuentI.ba_descripcion = txtDescripcion.Text;
                BancoCuentI.ba_Tipo = Convert.ToString(cmbTipoCuenta.Text);
                BancoCuentI.IdCtaCble = cmbCuentaContable.get_PlanCtaInfo().IdCtaCble;
                BancoCuentI.ba_Num_Cuenta = txtNumCuenta.Text;
                BancoCuentI.ba_Moneda = Convert.ToString(cmbMoneda.Text);
                BancoCuentI.ba_Ultimo_Cheque = "0";
                BancoCuentI.ba_num_digito_cheq = Convert.ToInt32(txtFormCheque.Text);
                BancoCuentI.IdUsuario = param.IdUsuario;
                BancoCuentI.Fecha_Transac = DateTime.Now;
                BancoCuentI.IdUsuarioUltMod = param.IdUsuario;
                BancoCuentI.Fecha_UltMod = DateTime.Now;
                BancoCuentI.nom_pc = param.nom_pc;
                BancoCuentI.ip = param.ip;
                BancoCuentI.Estado = (chkEstado.Checked == true)? "A" : "I" ;
                BancoCuentI.Imprimir_Solo_el_cheque = rdbSoloCheque.Checked;
                BancoCuentI.MostrarVistaPreviaCheque = ckbPreviewChe.Checked;
                return BancoCuentI;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Banco_Cuenta_Info();
            }
        }

        

        public void set_Info(ba_Banco_Cuenta_Info Info) 
        {
            try
            {
                info_BaCuenta = new ba_Banco_Cuenta_Info();
                info_BaCuenta = Info;

                UCBanco.set_BancoInfo(Convert.ToInt32(Info.IdBanco_Financiero));
                txtIdBanco.Text = Convert.ToString(Info.IdBanco);
                txtDescripcion.Text = Info.ba_descripcion;
                txtFormCheque.Value = Info.ba_num_digito_cheq;
                txtNumCuenta.Text = Info.ba_Num_Cuenta;
                cmbTipoCuenta.Text = Info.ba_Tipo;
                cmbMoneda.Text = Info.ba_Moneda;
                cmbCuentaContable.set_PlanCtarInfo(Info.IdCtaCble);
                chkEstado.Checked = (Info.Estado == "A") ? true : false;
                lbl_Estado.Visible = (Info.Estado  == "I") ? true : false;
                rdbSoloCheque.Checked = Convert.ToBoolean(Info.Imprimir_Solo_el_cheque);
                rdbChequemascomprobante.Checked = !Convert.ToBoolean(Info.Imprimir_Solo_el_cheque);
                ckbPreviewChe.Checked = Convert.ToBoolean(Info.MostrarVistaPreviaCheque);

                BancoCuentI = Info;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }
       
        private void txtFormCheque_KeyPress(object sender, KeyPressEventArgs e)
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void TxtUltimoCheque_KeyPress(object sender, KeyPressEventArgs e/*, KeyEventArgs xe*/)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (Char.IsControl(e.KeyChar ))
                    {
                        if (ModifierKeys == Keys.Control)
                        {
                            e.Handled = true;
                        }
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
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void TxtUltimoCheque_Leave(object sender, EventArgs e)
        {
            try
            {
                 string var = "";
                    string NumDig = "000000000000000000000";
                    int lon = 0;
            
                    string a = "";
            
                    lon =Convert.ToInt32( txtFormCheque.Value);

                    a = lon.ToString();


           
                    //var = NumDig  + TxtUltimoCheque.Text.Trim();
                    //var = var.Substring(var.Length - lon, lon);



                    //TxtUltimoCheque.Text = var;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Guardar() 
        {
            try
            {
                Boolean valor = true;
                string mensaje = "";
                int idBanc = 0;
                get_Info();

                

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (BancoCuentB.Get_Cuenta_Existe(BancoCuentI.IdEmpresa, BancoCuentI.IdCtaCble, ref mensaje) == true)
                    {
                        if (BancoCuentB.GrabarDB(BancoCuentI, ref idBanc, ref MensajeError))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "La Cuenta ", BancoCuentI.IdBanco);
                            MessageBox.Show(smensaje, param.Nombre_sistema);

                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                            ucGe_Menu.Visible_btnGuardar = true;
                            BancoCuentI.IdBanco = idBanc;
                            set_Info(BancoCuentI);
                            valor = true;
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            valor = false;
                        }
                        return valor;
                    }
                    else
                    {
                        MessageBox.Show("Error: La cuenta contable que ha seleccionado ya existe, escoja otra cuenta contable", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        valor = false;
                    }
                    return valor;
                }   
                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if (BancoCuentB.ModificarDB(BancoCuentI))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "La Cuenta ", BancoCuentI.IdBanco);
                        MessageBox.Show(smensaje, param.Nombre_sistema);
                        valor = true;
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        valor = false;
                    }
                    return valor;
                }
                return valor;
                }
                catch (Exception ex)
                {
                    string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                    NameMetodo = NameMetodo + " - " + ex.ToString();
                    MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                        , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                    return false;
                }
        }

        private Boolean Validar_formulario()
        {
            Boolean Respuesta = false;
            try
            {

                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Descripción sin datos..", "Favor ingrese datos");
                    Respuesta = false;
                }

                if (cmbCuentaContable.get_PlanCtaInfo().IdCtaCble == null)
                {
                    MessageBox.Show("Cuenta contable sin datos..", "Favor ingrese datos");
                    Respuesta = false;
                }

                if (txtNumCuenta.Text == "")
                {
                    MessageBox.Show("Error: Digite un número de cuenta.");
                    Respuesta = false;
                }

                if (UCBanco.get_BancoInfo().ba_descripcion == null)
                {
                    MessageBox.Show("Error: Escoja un banco");
                    Respuesta = false;
                }

                if (UCBanco.get_BancoInfo().IdBanco == 0)
                {
                    MessageBox.Show("Error: Escoja un banco");
                    Respuesta = false;
                }

                return Respuesta;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return Respuesta;
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                

                if (lbl_Estado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                    return false;
                }

                if (MessageBox.Show("¿Está seguro que desea anular la Cuenta Banco ?", "Anulación de Cuenta Banco  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    BancoCuentI.IdUsuarioUltAnu = param.IdUsuario;
                    BancoCuentI.Fecha_UltMod = DateTime.Now;
                    BancoCuentI.MotiAnula = ofrm.motivoAnulacion;

                    if (BancoCuentB.ActualizarEstado(BancoCuentI))
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "La Cuenta ", BancoCuentI.IdBanco);
                        MessageBox.Show(smensaje, param.Nombre_sistema); 
                        lbl_Estado.Visible = true;
                        resultB = true;
                    }
                    else
                    {
                        string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                        MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);   
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void Limpiar()
        {
            try
            {
                txtDescripcion.Text = "";
                txtNumCuenta.Text = "";
                cmbMoneda.Text = "";
                cmbTipoCuenta.Text = "";
                txtFormCheque.Value=0;
                cmbCuentaContable.set_PlanCtarInfo("");
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            

        }

        private void TxtUltimoCheque_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtFormCheque_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
              this.Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void TxtUltimoCheque_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void TxtUltimoCheque_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                
                    if (e.Modifiers == Keys.Control)
                    {
                        e.Handled = false;
                        return;
                
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
         
        }

        private void txtFormCheque_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsControl(e.KeyChar))
                {      
                    if (ModifierKeys == Keys.Control && ModifierKeys == Keys.Shift || ModifierKeys == Keys.Control )
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void txtFormCheque_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.Modifiers == Keys.Control)
                    {
                        txtFormCheque.Value = 0;
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbCuentaContable_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsControl(e.KeyChar ))
                {
                    if (ModifierKeys == Keys.Control)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmBA_Banco_Cuenta_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void rdbSoloCheque_CheckedChanged(object sender, EventArgs e)
        {
            rdbChequemascomprobante.Checked = !rdbSoloCheque.Checked;
        }

        private void rdbChequemascomprobante_CheckedChanged(object sender, EventArgs e)
        {
            rdbSoloCheque.Checked = !rdbChequemascomprobante.Checked;
        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCBanco_event_cmb_CuentaBanco_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtDescripcion.Text = UCBanco.get_BancoInfo().ba_descripcion + " " + cmbTipoCuenta.Text + " #:" + txtNumCuenta.Text;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtDescripcion.Text = UCBanco.get_BancoInfo().ba_descripcion + " " + cmbTipoCuenta.Text + " #:" + txtNumCuenta.Text;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtNumCuenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtDescripcion.Text = UCBanco.get_BancoInfo().ba_descripcion + " " + cmbTipoCuenta.Text + " #:" + txtNumCuenta.Text;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }
    }
}
