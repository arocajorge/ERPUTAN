using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Periodo_Mantenimiento : Form
    {
        #region Declaración de Variables
        public ct_Periodo_Bus periodob = new ct_Periodo_Bus();
        public ct_Periodo_Info info = new ct_Periodo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        public ct_Periodo_Info Pi = new ct_Periodo_Info();
        public ct_Periodo_Bus pb = new ct_Periodo_Bus();
        public delegate void delegate_frmCon_Periodo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCon_Periodo_Mantenimiento_FormClosing event_frmCon_Periodo_Mantenimiento_FormClosing;
        string MensajeError = "";

        #endregion

        public frmCon_Periodo_Mantenimiento()
        {
            InitializeComponent();
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
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

        public ct_Periodo_Info get_periodo()
        {

            try
            {
                Pi.IdEmpresa = param.IdEmpresa;
                Pi.IdPeriodo = Convert.ToInt32(this.txtperiodo.Text);
                Pi.IdanioFiscal = ucgE_Aniof1.get_anio();
                Pi.pe_mes = ucgE_Mes1.get_idMes();
                Pi.pe_FechaIni = this.dtFechaIni.Value;
                Pi.pe_FechaFin = this.dtFechaFin.Value;
                Pi.pe_estado = (chk_activo.Checked == true) ? "A" : "I";
                Pi.pe_cerrado = (chk_cerrado.Checked == true) ? "S" : "N";

                return Pi;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Periodo_Info();
            }

        }

        private Boolean Grabar()
        {

            try
            {
                get_periodo();

                if (periodob.GrabarDB(Pi, ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Periodo ", Pi.IdPeriodo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu.Visible_btnGuardar = false;
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    LimpiiarDatos();
                }
                else
                {
                    string smensaje = "El Periodo no se puego guardar, puede que el mismo ya este creado.";
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Modificar()
        {

            try
            {
                get_periodo();

                if (periodob.ModificarDB(Pi, ref MensajeError))
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Periodo ", Pi.IdPeriodo);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    //ucGe_Menu.Visible_btnGuardar = false;
                    //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    LimpiiarDatos();
                }
                else
                {
                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean Anular()
        {
            try
            {
                get_periodo();

                if (Pi.IdPeriodo != 0)
                {
                    if (lblAnulado.Visible == true)
                    {
                        MessageBox.Show("El registro ya se encuentra Anulado");
                    }
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el Periodo #: " + Pi.IdPeriodo + " ?", "ANULACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();

                            Pi.IdUsuarioUltAnu = param.IdUsuario;
                            Pi.Fecha_UltAnu = DateTime.Now;
                            Pi.MotivoAnulacion = ofrm.motivoAnulacion;


                            if (periodob.EliminarDB(Pi, ref MensajeError))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Periodo ", Pi.IdPeriodo);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                chk_activo.Checked = false;
                                ucGe_Menu.Visible_bntAnular = false;
                                lblAnulado.Visible = true;
                            }
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                else
                    MessageBox.Show("Por favor, seleccione un item a anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void Procesar()
        {
            try
            {
                get_periodo();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Modificar();
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

        public void set_indexAnio(int idAnio)
        {
            try
            {
                ucgE_Aniof1.set_indexanio(idAnio);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void set_indexmes(int idMes)
        {
            try
            {
                this.ucgE_Mes1.set_indexmes(idMes);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void set_periodo(ct_Periodo_Info info)
        {
            try
            {
                this.ucgE_Mes1.set_indexmes(info.pe_mes);
                this.ucgE_Aniof1.set_indexanio(info.IdanioFiscal);
                this.txtperiodo.Text = info.IdPeriodo.ToString();
                this.dtFechaIni.Value = info.pe_FechaIni;
                this.dtFechaFin.Value = info.pe_FechaFin;

                this.chk_cerrado.Checked = (info.pe_cerrado == "S") ? true : false;
                this.chk_activo.Checked = (info.pe_estado == "A") ? true : false;
                Pi = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCon_Periodo_Mantenimiento_Load(object sender, EventArgs e)
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chk_activo.Checked = true;
                        ucgE_Mes1_Event_cmbmes_SelectedIndexChanged(sender, e);
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.ucgE_Aniof1.set_enable_cmbanio(false);
                        this.ucgE_Mes1.set_enable_cmbmes(false);
                        this.txtperiodo.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        this.ucgE_Aniof1.set_enable_cmbanio(false);
                        this.txtperiodo.Enabled = false;
                        this.ucgE_Mes1.set_enable_cmbmes(false);
                        this.dtFechaFin.Enabled = false;
                        this.dtFechaIni.Enabled = false;
                        this.chk_activo.Enabled = false;
                        this.chk_cerrado.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        this.txtperiodo.Enabled = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        this.dtFechaFin.Enabled = false;
                        this.dtFechaIni.Enabled = false;
                        this.chk_cerrado.Enabled = false;
                        this.chk_activo.Enabled = false;
                        this.ucgE_Aniof1.set_enable_cmbanio(false);
                        this.ucgE_Mes1.set_enable_cmbmes(false);
                        break;
                    default:
                        break;
                }
                ucgE_Aniof1.Event_cmbanio_SelectedIndexChanged += new UCGe_Aniof.delegatecmbanio_SelectedIndexChanged(ucgE_Aniof1_Event_cmbanio_SelectedIndexChanged);
                ucgE_Mes1.Event_cmbmes_SelectedIndexChanged += new UCGe_Mes.delegatecmbmes_SelectedIndexChanged(ucgE_Mes1_Event_cmbmes_SelectedIndexChanged);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtperiodo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validate_periodo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtFechaIni_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validate_fechaini();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtFechaFin_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                validate_fechafin();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCon_Periodo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCon_Periodo_Mantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                Procesar();
                Close();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private Boolean validate_periodo()
        {
            try
            {
                Boolean bstatus;
                if (txtperiodo.Text == "")
                {
                    error.SetError(txtperiodo, "Período vacío");
                    bstatus = false;
                }
                else
                {
                    bstatus = true;
                }
                return bstatus;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private Boolean validate_fechaini()
        {
            try
            {
                Boolean bstatus;
                if (Convert.ToInt32(dtFechaIni.Value.Year) != ucgE_Aniof1.get_anio() && Convert.ToInt32(dtFechaIni.Value.Month) != ucgE_Mes1.get_idMes())
                {
                    error.SetError(txtperiodo, "Mes y Año del Inicio diferente al año fiscal y periodo");
                    bstatus = false;
                }
                else
                {
                    bstatus = true;
                }
                return bstatus;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private Boolean validate_fechafin()
        {
            try
            {
                Boolean bstatus;
                if (Convert.ToInt32(dtFechaFin.Value.Year) != ucgE_Aniof1.get_anio() && Convert.ToInt32(dtFechaFin.Value.Month) != ucgE_Mes1.get_idMes())
                {
                    error.SetError(txtperiodo, "Mes y Año del final diferente al año fiscal y periodo");
                    bstatus = false;
                }
                else
                {
                    bstatus = true;
                }
                return bstatus;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CalculaFechas()
        {
            try
            {
                DateTime DI = Convert.ToDateTime("01/" + ucgE_Mes1.get_idMes() + "/" + ucgE_Aniof1.get_anio());
                DateTime DF = DI.AddMonths(1).AddDays(-1);

                dtFechaIni.Value = DI;
                dtFechaFin.Value = DF;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucgE_Mes1_Event_cmbmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ianio = 0;
                int imes = 0;
                int idPeriodo = 0;


                imes = ucgE_Mes1.get_idMes();
                ianio = ucgE_Aniof1.get_anio();
                idPeriodo = ianio * 100 + imes;
                txtperiodo.Text = idPeriodo.ToString();

                CalculaFechas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucgE_Aniof1_Event_cmbanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ianio = 0;
                int imes = 0;
                int idPeriodo = 0;
                object a = ((ComboBox)sender).SelectedItem;
                ct_AnioFiscal_Info oani = new ct_AnioFiscal_Info();
                oani = (ct_AnioFiscal_Info)a;
                imes = ucgE_Mes1.get_idMes();
                ianio = oani.IdanioFiscal;
                idPeriodo = ianio * 100 + imes;
                txtperiodo.Text = idPeriodo.ToString();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Pi = new ct_Periodo_Info();
                txtperiodo.Text = "";               
                chk_activo.Checked = true;                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
