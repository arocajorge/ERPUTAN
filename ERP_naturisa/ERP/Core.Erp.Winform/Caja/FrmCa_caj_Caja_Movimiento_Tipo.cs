using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

namespace Core.Erp.Winform.Caja
{
    public partial class FrmCa_caj_Caja_Movimiento_Tipo : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public delegate void delegate_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing;
        ct_Plancta_Bus _PlanCta_bus = new ct_Plancta_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        caj_Caja_Movimiento_Tipo_Info moviTipo_I = new caj_Caja_Movimiento_Tipo_Info();
        caj_Caja_Movimiento_Tipo_Bus moviTipo_B = new caj_Caja_Movimiento_Tipo_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        int idMoviTipo = 0;
        string motiAnulacion = "";
        string MensajeError = "";


        #region Enventos delegados locales

        void FrmCa_Caja_Movimiento_event_FrmCa_Caja_Movimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion
        #endregion
       
        public FrmCa_caj_Caja_Movimiento_Tipo()
        {
            try
            {
                InitializeComponent();

                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grabar())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.Anular;
                Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_TipoMovi(caj_Caja_Movimiento_Tipo_Info info)
        {
            try
            {
                txt_idTipoMovi.Text = info.IdTipoMovi.ToString();
                txt_descripcion.Text = info.tm_descripcion;
                this.chk_estado.Checked = (info.Estado == "I") ? false : true;
                lb_Anulado.Visible = (info.Estado == "I") ? true : false;
                ucCon_PlanCtaCmb1.set_PlanCtarInfo(info.IdCtaCble);
                if (info.tm_Signo == "+")
                    rB_Ingreso.Checked = true;
                else
                    rB_Egreso.Checked = true;


                chkSeDeposita.Checked = info.SeDeposita;

                moviTipo_I = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private caj_Caja_Movimiento_Tipo_Info Get_TipoMovi()
        {
            try
            {
                moviTipo_I.IdEmpresa = param.IdEmpresa;
                moviTipo_I.tm_descripcion  = txt_descripcion.Text.Trim();
                moviTipo_I.Estado = (this.chk_estado.Checked == true) ? "A" : "I";
                lb_Anulado.Visible = (this.chk_estado.Checked == true) ? false : true;
                moviTipo_I.Fecha_Transac = param.Fecha_Transac;
                moviTipo_I.Fecha_UltAnu = param.Fecha_Transac;
                moviTipo_I.Fecha_UltMod = param.Fecha_Transac;
                moviTipo_I.IdTipoMovi = Convert.ToInt32(txt_idTipoMovi.Text);
                moviTipo_I.IdCtaCble = ucCon_PlanCtaCmb1.get_PlanCtaInfo().IdCtaCble; 
                moviTipo_I.IdUsuario = param.IdUsuario;
                moviTipo_I.IdUsuarioUltAnu = param.IdUsuario;
                moviTipo_I.IdUsuarioUltMod = param.IdUsuario;
                moviTipo_I.ip = param.ip;
                moviTipo_I.nom_pc = param.nom_pc;
                moviTipo_I.tm_Signo = (this.rB_Ingreso.Checked == true) ? "+" : "-";

                moviTipo_I.SeDeposita = chkSeDeposita.Checked;

                return moviTipo_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new caj_Caja_Movimiento_Tipo_Info();
            }
        }

        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        gBox_TipoMovimiento.Enabled = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        chk_estado.Checked = true;
                        chk_estado.Enabled = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        //gBox_TipoMovimiento.Enabled = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                       ucGe_Menu.Visible_btnGuardar = false;
                       ucGe_Menu.Visible_bntAnular = false;
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

        public Boolean validaColumna()
        {
            try
            {
                Boolean estado = true;

                if (txt_descripcion.Text == "")
                {
                    MessageBox.Show("Antes de continuar debe ingresar Descripción", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    estado = false;
                    return estado;
                }
               

                return estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Grabar()
        {
            try
            {
                Boolean bolResult = false;
                if (validaColumna())
                {
                    Get_TipoMovi();
                    
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        if (moviTipo_B.GrabarDB(moviTipo_I, ref idMoviTipo, ref  MensajeError))
                        {
                            txt_idTipoMovi.Text = idMoviTipo.ToString();

                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "Tipo Movimiento de caja ", txt_idTipoMovi.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            //_Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            LimpiarDatos();
                            bolResult =  true;
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Grabar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        if (moviTipo_B.ModificarDB(moviTipo_I, ref  MensajeError))
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "Tipo Movimiento de caja ", txt_idTipoMovi.Text);
                            MessageBox.Show(smensaje, param.Nombre_sistema);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                            bolResult = true;
                        }
                        else
                        {
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Modificar);
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        if (moviTipo_I.Estado != "I")
                        {
                            if (MessageBox.Show("¿Está seguro que desea anular el Tipo Movimiento de caja #: " + txt_idTipoMovi.Text + " ?", "Anulación de Tipo Movimiento de caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                                fr.ShowDialog();
                                motiAnulacion = fr.motivoAnulacion;

                                moviTipo_I.MotivoAnulacion = motiAnulacion;
                                moviTipo_I.IdUsuarioUltAnu = param.IdUsuario;
                                moviTipo_I.Fecha_UltAnu = param.Fecha_Transac;
                                if (moviTipo_B.AnularDB(moviTipo_I, ref  MensajeError))
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "Tipo Movimiento de caja ", txt_idTipoMovi.Text);
                                    MessageBox.Show(smensaje, param.Nombre_sistema);
                                    lb_Anulado.Visible = true;
                                    ucGe_Menu.Visible_bntAnular = false;
                                    bolResult = true;
                                }
                                else
                                {
                                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgError_Anular);
                                    MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                    
                            }
                        }
                        else
                            MessageBox.Show("Esta Caja ya esta Anulada...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("No se puede Grabar...", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return bolResult;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                set_accion(_Accion);
                moviTipo_I = new caj_Caja_Movimiento_Tipo_Info();                
                txt_descripcion.Text = "";
                this.chk_estado.Checked = true;                
                txt_idTipoMovi.Text = "0";
                this.rB_Ingreso.Checked = true;
                chkSeDeposita.Checked = false;
                ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraCmb_Cta_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                //if (this.ultraCmb_Cta.EditValue == null)
                //    ultraCmb_Cta.EditValue = "";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCa_caj_Caja_Movimiento_Tipo_Load(object sender, EventArgs e)
        {
            try
            {
                   this.event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing += new delegate_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(FrmCa_caj_Caja_Movimiento_Tipo_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        void FrmCa_caj_Caja_Movimiento_Tipo_event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  this.event_FrmCa_caj_Caja_Movimiento_Tipo_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucCon_PlanCtaCmb1_event_cmbPlanCta_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Plancta_Info info_plancta = new ct_Plancta_Info();
                info_plancta = ucCon_PlanCtaCmb1.get_PlanCtaInfo();
                if (info_plancta != null)
                {
                    if (info_plancta.IdEmpresa != 0)
                    {
                        if (info_plancta.pc_EsMovimiento == "N")
                        {
                            MessageBox.Show("Debe seleccionar una cuenta de movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            ucCon_PlanCtaCmb1.Inicializar_cmbPlanCta();
                        }
                    }    
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
