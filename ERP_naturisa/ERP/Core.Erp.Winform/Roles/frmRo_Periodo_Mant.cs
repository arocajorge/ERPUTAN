/*CLASE: frmRo_Periodo_Mant
 *MODIFICADO POR: ALBERTO MENA
 *FECHA: 20-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using DevExpress.XtraSplashScreen;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Periodo_Mant : Form
    {
        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_periodo_Bus Bus = new ro_periodo_Bus();
        ro_periodo_Info Info = new ro_periodo_Info();
        public delegate void delegate_frmRo_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Periodo_Mant_FormClosing event_frmRo_Periodo_Mant_FormClosing;
        #endregion

        public frmRo_Periodo_Mant()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                event_frmRo_Periodo_Mant_FormClosing += frmRo_Periodo_Mant_event_frmRo_Periodo_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void frmRo_Periodo_Mant_event_frmRo_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
 	       
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
            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                if (Grabar())
                {
                    this.Close();
                }
            }

            if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                if (Modificar())
                {
                    this.Close();
                }
            }

            if (Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                Anular();
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (Accion == Cl_Enumeradores.eTipo_action.grabar)
            {
                Grabar();
            }

            if (Accion == Cl_Enumeradores.eTipo_action.actualizar)
            {
                Modificar();
            }

            if (Accion == Cl_Enumeradores.eTipo_action.Anular)
            {
                Anular();
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }           
        }

        private void frmRo_Periodo_Mant_Load(object sender, EventArgs e)
        {
                                             
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
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        txtIdPeriodo.Enabled = false;
                        CheckEstado.Enabled = true;
                        dtFechaIni.Enabled = true;
                        dtFechaFin.Enabled = true;
                        lblEstado.Visible = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIdPeriodo.Enabled = false;
                        CheckEstado.Enabled = true;
                        dtFechaIni.Enabled = true;
                        dtFechaFin.Enabled = true;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIdPeriodo.Enabled = false;
                        CheckEstado.Enabled = false;
                        dtFechaIni.Enabled = false;
                        dtFechaFin.Enabled = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIdPeriodo.Enabled = false;
                        CheckEstado.Checked = false;
                        CheckEstado.Enabled = false;
                        dtFechaIni.Enabled = false;
                        dtFechaFin.Enabled = false;
                        
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

        public void set_Info(ro_periodo_Info _Info)
        {
            try
            {
                Info = _Info;
                txtIdPeriodo.Text = Info.IdPeriodo.ToString();
                dtFechaIni.Text = Convert.ToString(Info.pe_FechaIni);
                dtFechaFin.Text = Convert.ToString(Info.pe_FechaFin);
                CheckEstado.Checked = (Info.pe_estado == "A") ? true : false;
                lblEstado.Visible = (Info.pe_estado == "I") ? true : false;

                if (Info.pe_estado == "I")
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
                Log_Error_bus.Log_Error(ex.ToString());         
            }
                       
        }

        public ro_periodo_Info Get_Info()
        {
            try
            {
                Info.IdEmpresa = param.IdEmpresa;
                Info.IdPeriodo = Convert.ToInt32((txtIdPeriodo.Text == "") ? "0" : txtIdPeriodo.Text);
                Info.pe_FechaIni = Convert.ToDateTime(dtFechaIni.Text);
                Info.pe_FechaFin = Convert.ToDateTime(dtFechaFin.Text);
                Info.pe_anio = Convert.ToInt32(dtFechaIni.Value.Year);
                Info.pe_mes = Convert.ToInt32(dtFechaIni.Value.Month);
                Info.pe_estado = (CheckEstado.Checked == true) ? "A" : "I";

                 return Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return new ro_periodo_Info();  
            }            

        }

        private Boolean Validar()
        {
            try
            {
                if (dtFechaIni.Text == null || dtFechaIni.Text == "" || CheckEstado.Text.Length == 0)
                {
                    MessageBox.Show("La Fecha Inicial es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (dtFechaFin.Text == null || dtFechaFin.Text == "")
                {
                    MessageBox.Show("La Fecha Final es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }

                if (CheckEstado.Text.Length == 0)
                {
                     MessageBox.Show("El Estado es obligatoria, revise por favor", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     return false;
                }

                if (Convert.ToDateTime(dtFechaIni.Text) > Convert.ToDateTime(dtFechaFin.Text))
                {
                    MessageBox.Show("La fecha de inicio :  " + Convert.ToDateTime(dtFechaIni.Text) + " ,  no puede ser mayor a la fecha final : " + Convert.ToDateTime(dtFechaFin.Text), "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void Limpiar()
        {
            try
            {
                txtIdPeriodo.Text = "";
                dtFechaFin.Value = DateTime.Now;
                dtFechaIni.Value = DateTime.Now;
                CheckEstado.Checked = true;            
            }
            catch (Exception ex)
            {
            }
        }

        private Boolean Grabar()
        {
            try
            {
                int id = 0;
                string msg = "0";

                if (Validar())
                {
                    Get_Info();
                    if (Bus.Grabar(Info, ref msg))
                    {
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor: " + msg, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                    Get_Info();
                    //confirmar linea de codigo
                    if (Bus.Modificar(Info, ref msg))
                    {
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Accion = Cl_Enumeradores.eTipo_action.grabar;
                        Limpiar();
                        return true;
                       
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor: " + msg, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB=false;
                string mensaje = "";

              
                if (MessageBox.Show("¿Está seguro que desea anular el Periodo  ?", "Anulación de Periodo  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Info.IdUsuarioUltAnu = param.IdUsuario;
                    Info.Fecha_UltMod = DateTime.Now;
                    Info.MotivoAnulacion = ofrm.motivoAnulacion;
                    Get_Info();
                    if (Bus.Anular(Info, ref mensaje))
                    {
                        MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al ANULAR PERIODO verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }
        }
       
        private void frmRo_Periodo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                  event_frmRo_Periodo_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmRo_Periodo_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

    }
}
