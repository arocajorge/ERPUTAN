using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Horario_Mant : Form
    {
        #region Declaración de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Horario_Info infoHorario = new ro_Horario_Info();
        ro_Horario_Bus turno_bus = new ro_Horario_Bus();
        public delegate void delegate_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Turno_Mant_FormClosing event_frmRo_Turno_Mant_FormClosing;
        Cl_Enumeradores.eTipo_action enu = new Cl_Enumeradores.eTipo_action();
        #endregion

        public frmRo_Horario_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                event_frmRo_Turno_Mant_FormClosing += frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            } 
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       public void limpiar()
        {
           txtIdTurno.Text = ""; 
           txtHoraIni.Text = "";
           txtToleranciaEnt.Text = "0";
           txtInicioEnt.Text = "";
           txtInicioSal.Text = "";
           txtSalidaLunch.Text = "";
           txtMinAlmuerzo.Text = "";
           txtDescripcion.Text = "";
           txtHoraFin.Text = "";
           txtToleranciaSal.Text = "";
           txtFinalEnt.Text = "";
           txtFinalSal.Text = "";
           txtRegresoLunch.Text = "";
           txtTotalHoras.Text = "";
        }

        void frmRo_Turno_Mant_event_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e){}

        public frmRo_Horario_Mant(Cl_Enumeradores.eTipo_action Numerador)
            : this()
        {
            try
            {
              enu = Numerador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        public void GetTurno()
        {
            try
            {
                infoHorario.IdEmpresa = param.IdEmpresa;
                if (enu == Cl_Enumeradores.eTipo_action.consultar || enu == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    infoHorario.IdHorario = Convert.ToDecimal(txtIdTurno.EditValue);
                }
                string[] HoraIni = this.txtHoraIni.Text.Split(':');
                infoHorario.HoraIni = new TimeSpan(Convert.ToInt32(HoraIni[0]), Convert.ToInt32(HoraIni[1]), 0);

                string[] HoraFin = this.txtHoraFin.Text.Split(':');
                infoHorario.HoraFin = new TimeSpan(Convert.ToInt32(HoraFin[0]), Convert.ToInt32(HoraFin[1]), 0);

                //Derek 11/12/2013

                infoHorario.ToleranciaEnt = Convert.ToInt32(txtToleranciaEnt.EditValue);

                infoHorario.ToleranciaSal = Convert.ToInt32(txtToleranciaSal.EditValue);

                string[] InicioEnt = txtInicioEnt.Text.Split(':');
                infoHorario.InicioEntrada = new TimeSpan(Convert.ToInt32(InicioEnt[0]), Convert.ToInt32(InicioEnt[1]), 0);

                string[] FinalEnt = txtFinalEnt.Text.Split(':');
                infoHorario.FinalEntrada = new TimeSpan(Convert.ToInt32(FinalEnt[0]), Convert.ToInt32(FinalEnt[1]), 0);

                string[] InicioSal = txtInicioSal.Text.Split(':');
                infoHorario.InicioSal = new TimeSpan(Convert.ToInt32(InicioSal[0]), Convert.ToInt32(InicioSal[1]), 0);

                string[] FinalSal = txtFinalSal.Text.Split(':');
                infoHorario.FinalSalida = new TimeSpan(Convert.ToInt32(FinalSal[0]), Convert.ToInt32(FinalSal[1]), 0);

                string[] SalidaLunch = txtSalidaLunch.Text.Split(':');
                infoHorario.SalLunch = new TimeSpan(Convert.ToInt32(SalidaLunch[0]), Convert.ToInt32(SalidaLunch[1]), 0);

                string[] RegresoLunch = txtRegresoLunch.Text.Split(':');
                infoHorario.RegLunch = new TimeSpan(Convert.ToInt32(RegresoLunch[0]), Convert.ToInt32(RegresoLunch[1]), 0);
                //

                infoHorario.Min_Almuerzo = Convert.ToInt32(txtMinAlmuerzo.EditValue);

                infoHorario.Estado = "A";

                infoHorario.Descripcion = this.txtDescripcion.Text;
                if (txtToleranciaHora.Text != "")
                {
                    infoHorario.Tolerancia_Hora = Convert.ToInt32(txtToleranciaHora.Text);
                }
                if (txtToleranciaMinuto.Text != "")
                {
                    infoHorario.Tolerancia_Minuto = Convert.ToInt32(txtToleranciaMinuto.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public ro_Horario_Info _SetInfo { get; set; }

        void SetTurno()
        {

            try
            {
                txtIdTurno.EditValue = _SetInfo.IdHorario;
                txtHoraIni.EditValue = _SetInfo.HoraIni;
                txtHoraFin.EditValue = _SetInfo.HoraFin;
                txtToleranciaEnt.EditValue = _SetInfo.ToleranciaEnt;
                txtToleranciaSal.EditValue = _SetInfo.ToleranciaSal;
                txtInicioEnt.EditValue = _SetInfo.InicioEntrada;
                txtFinalEnt.EditValue = _SetInfo.FinalEntrada;
                txtInicioSal.EditValue = _SetInfo.InicioSal;
                txtFinalSal.EditValue = _SetInfo.FinalSalida;
                txtSalidaLunch.EditValue = _SetInfo.SalLunch;
                txtRegresoLunch.EditValue = _SetInfo.RegLunch;
                txtMinAlmuerzo.EditValue = _SetInfo.Min_Almuerzo;
                txtToleranciaMinuto.Text = _SetInfo.Tolerancia_Minuto.ToString();
                txtToleranciaHora.Text = _SetInfo.Tolerancia_Hora.ToString();
                txtDescripcion.EditValue = _SetInfo.Descripcion;

                if (_SetInfo.Estado == "I")
                {
                    lblEstado.Visible = true;
                }
                else
                {
                    lblEstado.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        public void insertar()
        {
            try
            {
                this.txtIdTurno.Focus();

                decimal Id = 0;
                string mensaje = "";
                infoHorario.IdUsuario = param.IdUsuario;
                if (turno_bus.GuardarDB(infoHorario, ref Id, ref mensaje))
                {
                    MessageBox.Show("El registro ha sido guardado con éxito - Turno #: " + Id, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdTurno.EditValue = Id;
                    limpiar();
                }
                else
                    MessageBox.Show("Error al ingresar el turno", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void Actualizar()
        {
            try
            {
                infoHorario.IdUsuarioUltMod = param.IdUsuario;
                if (turno_bus.ModificarDB(infoHorario, ""))
                {
                    this.txtIdTurno.Text = _SetInfo.IdHorario.ToString();
                    MessageBox.Show("El registro ha sido guardado con éxito - Turno #: " + _SetInfo.IdHorario, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar(); //cambio 28/10/2015
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtHoraIni_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtHoraIni.Text = txtHoraIni.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtHoraFin_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtHoraFin.Text = txtHoraFin.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtTotalHoras_EditValueChanged(object sender, EventArgs e)
        {
            

        }       

        public Boolean grabar()
        {
            Boolean res = true;
            try
            {
                this.txtIdTurno.Focus();
                this.GetTurno();

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (Validar())
                        {
                            insertar();
                        }
                        else return false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        if (Validar())
                        {
                            Actualizar();
                        }
                        else return false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        this.Anular();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
                res = false;
            } return res;
        }

        Boolean Validar()
        {
            try
            {
                if (this.txtHoraIni.EditValue == null || this.txtHoraIni.EditValue == "00:00")
                {
                    MessageBox.Show("La Hora Inicial es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (this.txtHoraFin.EditValue == null || this.txtHoraFin.EditValue == "00:00")
                {
                    MessageBox.Show("La Hora Final es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                //Derek 12/12/2013
                if (Convert.ToInt32(txtToleranciaEnt.EditValue) > 60)
                {
                    MessageBox.Show("La Tolerancia de Entrada debe ser menor a 60 minutos, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //MessageBox.Show("Por Favor Ingrese una tolerancia de entrada menor a 60 min");
                    return false;
                }

                if (Convert.ToInt32(txtToleranciaSal.EditValue) > 60)
                {
                    MessageBox.Show("La Tolerancia de Salida debe ser menor a 60 minutos, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //MessageBox.Show("Por Favor Ingrese una tolerancia de salida menor a 60 min");
                    return false;
                }

                if (Convert.ToInt32(txtMinAlmuerzo.EditValue) > 60)
                {
                    MessageBox.Show("Por favor ingrese minutos del lunch menor a 60 minutos...", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //MessageBox.Show("Por Favor Ingrese minutos del lunch menores a 60 min");
                    return false;
                }

                //

                if (this.txtMinAlmuerzo.EditValue == null || this.txtMinAlmuerzo.EditValue == "0")
                {
                    //MessageBox.Show("Por Favor Ingrese los minutos del lunch");
                    MessageBox.Show("Los minutos del lunch son obligatorios, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (this.txtDescripcion.EditValue == null || this.txtDescripcion.EditValue == "")
                {
                    //MessageBox.Show("Por Favor Ingrese la descripción");
                    MessageBox.Show("La descripción es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void frmRo_Turno_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                txtHoraIni.Focus();
                lblEstado.Visible = false;

                switch (enu)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        this.txtIdTurno.Enabled = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.lblEstado.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        this.txtIdTurno.Enabled = false;
                        this.SetTurno();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        this.SetTurno();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        this.txtIdTurno.Enabled = false;
                        this.SetTurno();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
       
        private void frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmRo_Turno_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void Anular()
        {
            try
            {
                if (MessageBox.Show("Esta Seguro que desea Anular el turno?", "Anulacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    oFrm.ShowDialog();
                    _SetInfo.MotiAnula=  oFrm.motivoAnulacion;
                    _SetInfo.IdUsuarioUltAnu = param.IdUsuario;
                    _SetInfo.Fecha_UltAnu = DateTime.Now;

                    if (turno_bus.AnularDB(_SetInfo))
                    {
                        MessageBox.Show("El registro ha sido anulado con éxito" , "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblEstado.Visible = true;
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtInicioEnt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtInicioEnt.Text = txtInicioEnt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtFinalEnt_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtFinalEnt.Text = txtFinalEnt.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtInicioSal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                   txtInicioSal.Text = txtInicioSal.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtFinalSal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtFinalSal.Text = txtFinalSal.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtSalidaLunch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtSalidaLunch.Text = txtSalidaLunch.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txtRegresoLunch_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 txtRegresoLunch.Text = txtRegresoLunch.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        private void frmRo_Horario_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

       


    }
}

