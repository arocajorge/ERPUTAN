using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Bancos;
using Core.Erp.Info.Bancos;
using Core.Erp.Winform.General;
using Core.Erp.Business.General;
using Core.Erp.Info.General;


namespace Core.Erp.Winform.Bancos
{
    public partial class FrmBA_Inversion_Mant : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        double retencion = 0;
        double total = 0;
        double interes = 0;
        ba_Inversion_Bus busInversion = new ba_Inversion_Bus();
        string msg = "";
        ba_Inversion_Info infograbar = new ba_Inversion_Info();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public delegate void delegate_FrmBA_Inversion_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmBA_Inversion_Mant_FormClosing event_FrmBA_Inversion_Mant_FormClosing;
        #endregion
        
        public FrmBA_Inversion_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                this.event_FrmBA_Inversion_Mant_FormClosing += FrmBA_Inversion_Mant_event_FrmBA_Inversion_Mant_FormClosing;
                loaddata();
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
                this.Close();
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
                if (guardar()) { this.Close(); }
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
                guardar();
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
                this.ucGe_Menu_event_btnGuardar_Click(sender,e);
            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void FrmBA_Inversion_Mant_event_FrmBA_Inversion_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
   
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void loaddata()
        {
            try
            {
                ba_Banco_Cuenta_Bus busBanco = new ba_Banco_Cuenta_Bus();
                List<ba_Banco_Cuenta_Info> bancos = busBanco.Get_list_Banco_Cuenta(param.IdEmpresa);
                cmbBanco.Properties.DataSource = bancos;
                dtpFecha.EditValue = Convert.ToDateTime (DateTime.Now.ToShortDateString());
                dtpFVcto.EditValue = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void setinfo(ba_Inversion_Info info)
        {
            try
            {
                infograbar = info;
                lblIdInversion.Text = Convert.ToString(info.IdInversion);
                txtCodigo.Text = info.Cod_Inversion;
                cmbBanco.EditValue = info.IdBanco;
                dtpFecha.EditValue = info.Fecha;
                txtMonto.Text = Convert.ToString(info.Monto);
                txtPRetencion.EditValue = info.Por_Retencion;
                txtTasa.Text = Convert.ToString(info.Tasa);
                txtInteres.Text = Convert.ToString(info.Valor_interes);
                txtPlazo.Text = Convert.ToString(info.Plazo);
                txtOtros.Text = Convert.ToString(info.Otros);
                txtCapital.Text = txtMonto.Text;
                txtTotal.Text = Convert.ToString(info.Total_recibir);
                txtObservacion.Text  = info.Observacion;
                lblAnulado.Visible = (info.Estado == "I") ? true : false;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private Boolean getinfo()
        {
            Boolean res = false;
            try
            {
                infograbar.IdEmpresa = param.IdEmpresa;
                infograbar.Cod_Inversion = txtCodigo.Text;
                infograbar.IdBanco = Convert.ToInt32(cmbBanco.EditValue);
                infograbar.Fecha = Convert.ToDateTime(Convert.ToDateTime( dtpFecha.EditValue).ToShortDateString());
                infograbar.Monto = Convert.ToDouble( txtMonto.Text);
                infograbar.Tasa = Convert.ToDouble(txtTasa.Text);//Convert.ToDecimal(txtTasa.Text);
                infograbar.Por_Retencion = Convert.ToDouble(txtPRetencion.Text);
                infograbar.Valor_retencion = Convert.ToDouble(txtRetencion.Text);
                infograbar.Otros = Convert.ToDouble(txtOtros.Text);
                infograbar.Valor_interes = Convert.ToDouble(txtInteres.Text);
                infograbar.Capital = Convert.ToDouble(txtCapital.Text);
                infograbar.Total_recibir = Convert.ToDouble(txtTotal.Text);
                infograbar.Observacion = txtObservacion.Text;
                infograbar.Plazo = Convert.ToInt32(txtPlazo.Text);
                infograbar.Fecha_Vct = Convert.ToDateTime(Convert.ToDateTime(dtpFVcto.EditValue).ToShortDateString());

                res = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;
        }

        private Boolean validar()
        {
            Boolean res = false;
            try
            {

                if (cmbBanco.EditValue == null || Convert.ToInt32(cmbBanco.EditValue)==0)
                {
                    MessageBox.Show("Por favor ingrese el Banco.", param.Nombre_sistema);
                }
                if (String.IsNullOrEmpty(txtMonto.Text) || String.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Por favor ingrese el monto.", param.Nombre_sistema);
                }

                if (String.IsNullOrEmpty(txtTasa.Text) || String.IsNullOrWhiteSpace(txtTasa.Text))
                {
                    MessageBox.Show("Por favor ingrese la tasa.", param.Nombre_sistema);
                }

                if (String.IsNullOrEmpty(txtPRetencion.Text) || String.IsNullOrWhiteSpace(txtPRetencion.Text))
                {
                    MessageBox.Show("Por favor ingrese el porcentaje de Retención.", param.Nombre_sistema);
                }
                
                if (String.IsNullOrEmpty(txtPlazo.Text) || String.IsNullOrWhiteSpace(txtPlazo   .Text))
                {
                    MessageBox.Show("Por favor ingrese el plazo.", param.Nombre_sistema);
                }


                res = getinfo();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;
        }
 
        private Boolean guardar()
        {
            Boolean res = false;
            try
            {
                if(validar())
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        infograbar.Fecha_UltMod = DateTime.Now;
                        infograbar.IdUsuarioUltMod = param.IdUsuario;
                        if (busInversion.ModificarDB(infograbar, ref msg))
                        {
                            MessageBox.Show("Actualizado exitosamente.", param.Nombre_sistema); setAccion(Cl_Enumeradores.eTipo_action.consultar);
                            load();
                            setinfo(infograbar);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error..." + msg, param.Nombre_sistema);
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        infograbar.Fecha_Transac = DateTime.Now;
                        infograbar.IdUsuario = param.IdUsuario;
                        infograbar.nom_pc= param.nom_pc;
                        infograbar.ip = param.ip;
                        if (busInversion.GrabarDB(infograbar, ref msg))
                        {
                            MessageBox.Show("Grabado exitosamente.", param.Nombre_sistema); setAccion(Cl_Enumeradores.eTipo_action.consultar);
                            load();
                            setinfo(infograbar);
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error..." + msg, param.Nombre_sistema);
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        infograbar.Fecha_UltAnu = DateTime.Now;
                        infograbar.IdUsuarioUltAnu = param.IdUsuario;

                        if (infograbar.Estado == "I")
                        {
                            MessageBox.Show("La inversión# " + infograbar.IdInversion + " ya se encuentra anulada.");
                            break;
                        }
                        else
                        {
                            
                            if (MessageBox.Show("¿Está seguro que desea anular la inversión: " + infograbar.IdInversion +
                                " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                                oFrm.ShowDialog();
                                infograbar.MotiAnula = oFrm.motivoAnulacion;
                                if (busInversion.AnularDB(infograbar, ref msg))
                                {
                                    MessageBox.Show("Anulado exitosamente.", param.Nombre_sistema);
                                    setAccion(Cl_Enumeradores.eTipo_action.consultar);
                                    load();
                                    setinfo(infograbar);
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido un error..." + msg, param.Nombre_sistema);
                                }
                            }
                        }
                        
                        break;
                        
                    default: break;         

                }


                res = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return res;
        }
   
        void bloqueartextbox()
        {
            try
            {

                Color color = Color.White;
                Color negro = Color.Black;
                txtCodigo.Enabled = false; txtCodigo.BackColor = color; txtCodigo.ForeColor = negro;
                cmbBanco.Enabled = false; cmbBanco.BackColor = color; cmbBanco.ForeColor = negro;
                txtMonto.Enabled = false; txtMonto.BackColor = color; txtMonto.ForeColor = negro;
                txtTasa.Enabled = false; txtTasa.BackColor = color; txtTasa.ForeColor = negro;
                txtRetencion.Enabled = false; txtRetencion.BackColor = color; txtRetencion.ForeColor = negro;
                txtPRetencion.Enabled = false; txtPRetencion.BackColor = color; txtPRetencion.ForeColor = negro;
                txtOtros.Enabled = false; txtOtros.BackColor = color; txtOtros.ForeColor = negro;
                txtInteres.Enabled = false; txtInteres.BackColor = color; txtInteres.ForeColor = negro;
                txtPlazo.Enabled = false; txtPlazo.BackColor = color; txtPlazo.ForeColor = negro;
                dtpFVcto.Enabled = false; dtpFVcto.BackColor = color; dtpFVcto.ForeColor = negro;
                dtpFecha.Enabled = false; dtpFecha.BackColor = color; dtpFecha.ForeColor = negro;
                txtObservacion.Enabled = false; txtObservacion.BackColor = color; txtObservacion.ForeColor = negro;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        void activarbotonactualizar()
        {
            try
            {
                txtObservacion.Enabled = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        
        void load()
        {
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        bloqueartextbox();
                        activarbotonactualizar();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                       ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        bloqueartextbox();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                         ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        bloqueartextbox();
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
        
        private void FrmBA_Inversion_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void FrmBA_Inversion_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 event_FrmBA_Inversion_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void txtMonto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcularinteres();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }


        }

        private void txtTasa_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               calcularinteres();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void txtPlazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {   
                calcularinteres();
                string plazo = txtPlazo.Text.Substring(0, txtPlazo.Text.Length - 1);

                if (plazo == "")
                    plazo = "0";

                dtpFVcto.EditValue = (Convert.ToDateTime(dtpFecha.EditValue)).AddDays(Convert.ToInt32(plazo));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            
        }

        void calcularinteres()
        {
            try
            {

                txtInteres.Text = Convert.ToString(Math.Round(interes, 2));
                interes =  Convert.ToDouble(txtMonto.EditValue) *
                    Convert.ToDouble(txtTasa.EditValue) / 360 * Convert.ToDouble(txtPlazo.EditValue);

                txtInteres.Text = Convert.ToString(Math.Round(interes,2));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void calculartotal()
        {
            try
            {
                txtTotal.Text = Convert.ToString(Math.Round(total, 2));
                total = Convert.ToDouble(txtOtros.EditValue) +
                    interes + Convert.ToDouble(txtMonto.EditValue) - retencion;
                txtCapital.Text = txtMonto.Text;
                txtTotal.Text = Convert.ToString(Math.Round(total,2));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void calcularretencion()
        {
            try
            {
                txtRetencion.Text = Convert.ToString(retencion);
                retencion = interes *Convert.ToDouble(txtPRetencion.EditValue);
                txtRetencion.Text = Convert.ToString(Math.Round(retencion,2));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtPRetencion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                calcularretencion();
                calculartotal();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtInteres_TextChanged(object sender, EventArgs e)
        {
            try
            {

                calcularretencion();
                calculartotal();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txtOtros_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              calculartotal();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        private void dtpFecha_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string plazo = txtPlazo.Text.Substring(0, txtPlazo.Text.Length - 1);

                if (plazo == "")
                    plazo = "0";

                dtpFVcto.EditValue = (Convert.ToDateTime(dtpFecha.EditValue)).AddDays(Convert.ToInt32(plazo));
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        //private void btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}

        //private void btnGuardarSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (guardar()) { this.Close(); }
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}

        //private void btn_guardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        guardar();
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}

        //private void btnAnular_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        btn_guardar_Click(sender, e);
        //    }
        //    catch (Exception ex)
        //    {
        //        Log_Error_bus.Log_Error(ex.ToString());
        //    }

        //}
    }
}
