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
    public partial class FrmBA_Talonario_Lote_cheques_x_banco : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ba_Banco_Cuenta_Bus BusCuentaBan = new ba_Banco_Cuenta_Bus();
        ba_Talonario_cheques_x_banco_Info Info_Tal_Che = new ba_Talonario_cheques_x_banco_Info();
        ba_Talonario_cheques_x_banco_Bus busTal_Che = new ba_Talonario_cheques_x_banco_Bus();
        Cl_Enumeradores.eTipo_action Accion;
        List<ba_Talonario_cheques_x_banco_Info> lista = new List<ba_Talonario_cheques_x_banco_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing;

        string msg = "";
        #endregion

        public FrmBA_Talonario_Lote_cheques_x_banco()
        {
            InitializeComponent();
            ucGe_Menu1.event_btnGuardar_Click += ucGe_Menu1_event_btnGuardar_Click;
            ucGe_Menu1.event_btnGuardar_y_Salir_Click += ucGe_Menu1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu1.event_btnSalir_Click += ucGe_Menu1_event_btnSalir_Click;
        }

        void ucGe_Menu1_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        void ucGe_Menu1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (busTal_Che.Get_Info_Cheq_existe(param.IdEmpresa, Convert.ToInt16(cmbCuentaCbte.EditValue), Convert.ToString(txtnumchq.EditValue), ref msg))
                {
                    if (Grabar())
                        Limpiar();
                }
                else
                {
                    MessageBox.Show("El valor inicial del cheque ya esta generado, ingrese un nuevo valor para el cheque inicial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        Boolean Validar()
        {
            try
            {
                int r = 0;
                int d = 0;
                if (cmbCuentaCbte.EditValue == null || cmbCuentaCbte.Text == "")
                {
                    MessageBox.Show("Escoja una cuenta contable", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtdigito.Text == "" || txtdigito.EditValue == null)
                {
                    MessageBox.Show("Escoja una cuenta contable", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private Boolean Grabar()
        {
            try
            {
                string msg = "";
                string msg2 = "";
                int conta = Convert.ToInt32(txtchqgen.EditValue);
                int r = 0;
                string micadena;
                int d = Convert.ToInt32(txtdigito.EditValue);
                Boolean allOk = true;
                if (Validar())
                {
                   
                    for (int i = 0; i < conta; i++)
                    {
                        r = i + Convert.ToInt32(txtchqini.EditValue);
                        micadena = r.ToString();
                        Info_Tal_Che = new ba_Talonario_cheques_x_banco_Info();
                        Info_Tal_Che.Num_cheque = micadena.PadLeft(d, '0');
                        Info_Tal_Che.IdEmpresa = param.IdEmpresa;
                        ba_Banco_Cuenta_Info obj_cmbProve = (ba_Banco_Cuenta_Info)cmbCuentaCbte.Properties.View.GetFocusedRow();
                        Info_Tal_Che.IdBanco = obj_cmbProve.IdBanco;
                        Info_Tal_Che.Estado = "A";
                        Info_Tal_Che.Usado = false;
                        Info_Tal_Che.cuenta = obj_cmbProve.IdCtaCble;
                        Info_Tal_Che.numdig = d;
                        Info_Tal_Che.ejemplo = Convert.ToInt32(this.txtEjemplo.EditValue);
                       
                        if (!busTal_Che.GrabarDB(Info_Tal_Che, ref msg))
                        {
                            msg2 = msg;
                            allOk = false; //es porsias igual no funciona la validacion anterior
                        }
                    }

                    if (allOk == true)
                    {
                        ucGe_Menu1.Enabled_bntGuardar_y_Salir = true;
                        ucGe_Menu1.Enabled_btnGuardar = true;
                        MessageBox.Show(Core.Erp.Recursos.Properties.Resources.msgConfirmaGrabarOk, param.Nombre_sistema);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + msg2);
                    }
                }
                return allOk;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public void Limpiar()
        {
            try
            {
                cmbCuentaCbte.EditValue = null;
                txtdigito.Text = "";
                txtnumchq.Text = "";
                txtEjemplo.Text = "";
                txtchqini.Text = "";
                txtchqgen.Text = "";
                txtchqfin.Text = "";
                gridControltalon.DataSource = null;
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
                this.cmbCuentaCbte.Properties.DataSource = BusCuentaBan.Get_list_Banco_Cuenta(param.IdEmpresa);
                this.cmbCuentaCbte.Properties.DisplayMember = "ba_descripcion";
                this.cmbCuentaCbte.Properties.ValueMember = "IdBanco";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void cmbCuentaCbte_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int d = 0;

                ba_Banco_Cuenta_Info obj_cmbProve = (ba_Banco_Cuenta_Info)cmbCuentaCbte.Properties.View.GetFocusedRow();

                txtdigito.EditValue = obj_cmbProve.ba_num_digito_cheq;
                txtidbanco.EditValue = obj_cmbProve.IdBanco;
                string micadena = "1";
                d = Convert.ToInt32(txtdigito.EditValue);
                this.txtEjemplo.Text = micadena.PadLeft(d, '0');

                if (obj_cmbProve.IdBanco != 0)
                    Info_Tal_Che = busTal_Che.Get_Info_Ultimo_cheq_banco(param.IdEmpresa, obj_cmbProve.IdBanco, ref msg);

                if (Info_Tal_Che != null && Info_Tal_Che.Num_cheque != null)
                {

                    decimal nchq = (Convert.ToDecimal(Info_Tal_Che.Num_cheque) + 1);
                    string convert = Convert.ToString(nchq);
                    int f = 0;
                    f = Convert.ToInt32(txtdigito.EditValue);
                    this.txtchqini.EditValue = convert.PadLeft(f, '0');
                    txtnumchq.EditValue = txtchqini.EditValue;
                }
                else
                {
                    txtchqini.EditValue = txtEjemplo.Text;
                    txtnumchq.EditValue = txtEjemplo.Text;
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
                txtidbanco.Text = _Info.IdBanco.ToString();
                txtnumchq.Text = _Info.Num_cheque.ToString();
                txtchqfin.Text = _Info.chqfinal.ToString();
                txtchqini.Text = _Info.chqinicial.ToString();
                txtchqgen.Text = _Info.totalChq.ToString();
                txtdigito.Text = _Info.numdig.ToString();
                Info_Tal_Che = _Info;
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
                Info_Tal_Che.IdEmpresa = param.IdEmpresa;
                Info_Tal_Che.IdBanco = Convert.ToInt32(txtidbanco.Text);
                Info_Tal_Che.Num_cheque = txtnumchq.Text;
                Info_Tal_Che.chqfinal = Convert.ToInt32(txtchqfin.Text);
                Info_Tal_Che.chqinicial = Convert.ToInt32(txtchqini.Text);
                Info_Tal_Che.totalChq = Convert.ToInt32(txtchqgen.Text);
                Info_Tal_Che.numdig = Convert.ToInt32(txtdigito.Text);

                return Info_Tal_Che;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new ba_Talonario_cheques_x_banco_Info();
            }
        }

        private void txtchqgen_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int r = 0;
                int d = 0;
                if(cmbCuentaCbte.EditValue!=null)
                {
                    if (txtdigito.EditValue != "")
                    {
                        if (this.txtchqgen.EditValue != null && this.txtchqgen.EditValue != "" && this.txtchqgen.EditValue != "0")
                        {
                            if (txtnumchq.EditValue != null && txtnumchq.EditValue != "")
                            {
                                this.txtchqini.EditValue = this.txtnumchq.EditValue;
                                r = (Convert.ToInt32(txtchqgen.EditValue) + Convert.ToInt32(txtnumchq.EditValue))-1;
                                string micadena = r.ToString();
                                d = Convert.ToInt32(txtdigito.EditValue);
                                txtchqfin.EditValue = micadena.PadLeft(d, '0');
                                string convert = Convert.ToString(txtchqini.EditValue);
                                this.txtnumchq.EditValue = convert.PadLeft(d, '0');
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una cuenta bancaria");
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

        private void FrmBA_Talonario_Lote_cheques_x_banco_Load(object sender, EventArgs e)
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

        private void txtnumchq_Validating(object sender, CancelEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            try
            {
                gridControltalon.DataSource = null;
                lista.Clear();
                int conta = Convert.ToInt32(txtchqgen.EditValue);
                int r = 0;
                decimal c = 0;
                string micadena;
                int d = Convert.ToInt32(txtdigito.EditValue);
                for (int i = 0; i < conta; i++)
                {
                    r = i + Convert.ToInt32(txtchqini.EditValue);
                    micadena = r.ToString();
                    Info_Tal_Che = new ba_Talonario_cheques_x_banco_Info();
                    Info_Tal_Che.Num_cheque = micadena.PadLeft(d, '0');
                    lista.Add(Info_Tal_Che);
                }

                gridControltalon.DataSource = lista;
                gridControltalon.Refresh();
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtdigito_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtnumchq_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int r = 0;
                int d = 0;
                if(cmbCuentaCbte.EditValue!=null)
                {
                    if (txtdigito.EditValue != "")
                    {
                        if (this.txtnumchq.EditValue != null && this.txtnumchq.EditValue != "" && this.txtnumchq.EditValue != "0")
                        {
                            if (busTal_Che.Get_Info_Cheq_existe(param.IdEmpresa, Convert.ToInt16(cmbCuentaCbte.EditValue), Convert.ToString(txtnumchq.EditValue), ref msg))
                            {
                                this.txtchqini.EditValue = this.txtnumchq.EditValue;
                                if (txtchqgen.EditValue != null && txtchqgen.EditValue != "")
                                {
                                    r = (Convert.ToInt32(txtchqgen.EditValue) + Convert.ToInt32(txtnumchq.EditValue))-1;
                                    string micadena = r.ToString();
                                    d = Convert.ToInt32(txtdigito.EditValue);
                                    txtchqfin.EditValue = micadena.PadLeft(d, '0');
                                    string convert = Convert.ToString(txtnumchq.EditValue);
                                    this.txtnumchq.EditValue = convert.PadLeft(d, '0');
                                }
                            }
                            else
                            {
                                MessageBox.Show("El valor inicial del cheque ya esta generado, ingrese un nuevo valor para el cheque inicial", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una cuenta bancaria");
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

        private void FrmBA_Talonario_Lote_cheques_x_banco_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Event_FrmBA_Talonario_Lote_cheques_x_banco_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtchqgen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnumchq_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtdigito_KeyPress(object sender, KeyPressEventArgs e)
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
