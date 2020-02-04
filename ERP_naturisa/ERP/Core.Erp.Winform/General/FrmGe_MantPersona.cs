using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.General
{
    public partial class frmGe_MantPersona : Form
    {
        #region Declaración de Variables
        public delegate void delegate_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmGe_MantPersona_FormClosing event_frmGe_MantPersona_FormClosing;
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        tb_persona_bus _PersonaBus = new tb_persona_bus();
        string motiAnulacion = "";
        string MensajeError = "";
        #endregion
       
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {

                this.ucGe_Mant_Persona.set_Accion(iAccion);
                    _Accion = iAccion;
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            ucGe_Menu.Visible_bntAnular = false;
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
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

        public void set_Persona(tb_persona_Info _persona_info)
        {
            try
            {

                ucGe_Mant_Persona.set_Persona(_persona_info);
                lb_Anulado.Visible = (_persona_info.pe_estado == "I") ? true : false;
                _PersonaInfo = _persona_info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public frmGe_MantPersona()
        {
            try
            {
                InitializeComponent();

                this.ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                this.ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                this.ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                this.ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                this.ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
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

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
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
                Guardar();
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
                Guardar();

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

        private void FrmGe_MantPersona_Load(object sender, EventArgs e)
        {

            try
            {
                this.event_frmGe_MantPersona_FormClosing += new delegate_frmGe_MantPersona_FormClosing(frmGe_MantPersona_event_frmGe_MantPersona_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmGe_MantPersona_event_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void Guardar()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        if (ucGe_Mant_Persona.grabar())
                        {
                            MessageBox.Show("Grabacion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al actualizar verifique con sistemas ..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (ucGe_Mant_Persona.Actualizar())
                        {
                            MessageBox.Show("Actualizacion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            //ucGe_Menu.Visible_btnGuardar = false;
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al actualizar verifique con sistemas ..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        if (MessageBox.Show("Esta seguro de Anular esta persona ...", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                            fr.ShowDialog();
                                                        
                            motiAnulacion = fr.motivoAnulacion;
                            _PersonaInfo.MotivoAnulacion = motiAnulacion;
                            _PersonaInfo.IdUsuarioUltAnu = param.IdUsuario;
                            _PersonaInfo.Fecha_UltAnu = param.Fecha_Transac;


                            if (ucGe_Mant_Persona.Anular(_PersonaInfo))
                            {
                                MessageBox.Show("Anulacion Exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ucGe_Menu.Visible_bntAnular = false;
                                lb_Anulado.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido un error al actualizar verifique con sistemas ..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
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

        private void frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmGe_MantPersona_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Mant_Persona_Load(object sender, EventArgs e)
        {

        }



        void LimpiarDatos()
        {
            try
            {
                ucGe_Mant_Persona.LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
       
    }
}
