using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_estado_cierre_Mant : Form
    {
        #region
        com_estado_cierre_Info Info = new com_estado_cierre_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_estado_cierre_Bus Bus = new com_estado_cierre_Bus();
        Cl_Enumeradores.eTipo_action Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public delegate void delegate_FrmCom_estado_cierre_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_estado_cierre_Mant_FormClosing event_FrmCom_estado_cierre_Mant_FormClosing;


        #endregion
       
        public FrmCom_estado_cierre_Mant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            event_FrmCom_estado_cierre_Mant_FormClosing += FrmCom_estado_cierre_Mant_event_FrmCom_estado_cierre_Mant_FormClosing;
        
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

        void FrmCom_estado_cierre_Mant_event_FrmCom_estado_cierre_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void FrmCom_estado_cierre_Mant_Load(object sender, EventArgs e)
        {

        }

        public void set_Info(com_estado_cierre_Info _Info)
        {
            try
            {
                Info = _Info;
                txtcodigo.Text = Info.IdEstado_cierre.ToString();
                txtdescripcion.Text = Info.Descripcion.ToString();
                chk_estado.Checked = (Info.estado == "A") ? true : false;

                lblanulado.Visible = (Info.estado == "I") ? true : false;

            }
            catch (Exception ex)
            {
            }
        }

        public com_estado_cierre_Info get_Info()
        {
            try
            {
                Info.IdEstado_cierre = txtcodigo.Text;
                Info.Descripcion = txtdescripcion.Text;
                Info.estado = (chk_estado.Checked == true) ? "A" : "I";

                return Info;
            }
            catch (Exception ex)
            {
                return new com_estado_cierre_Info();
            }
        }

        private Boolean Validar()
        {
            try
            {
                if (txtcodigo.Text.Length == 0 || txtdescripcion.Text.Length == 0)
                {
                    MessageBox.Show("Error: Ingrese Datos", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        private void Limpiar()
        {
            try
            {
                txtcodigo.Text = "";
                txtdescripcion.Text = "";
                chk_estado.Checked = true;              
            }
            catch (Exception ex)
            {
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
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = true;
                        txtcodigo.Enabled = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtcodigo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtcodigo.Enabled = false;
                        txtdescripcion.Enabled = false;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtcodigo.Enabled = false;
                        chk_estado.Enabled = false;

                        break;
                    default:
                        break;
                }
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
                string msg = "";

                if (Validar())
                {
                    get_Info();
                    if (Bus.GrabarDB(Info, ref msg))
                    {
                        MessageBox.Show("Grabado");
                    }
                    else
                    {
                        MessageBox.Show("Error: " + msg);
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
                    if (Bus.ModificarDB(Info, ref msg))
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB=false;
                string mensaje = "";

              
                if (MessageBox.Show("¿Está seguro que desea anular el Estado  ?", "Anulación de Estado de Cierre  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Info.IdUsuarioUltAnu = param.IdUsuario;
                    Info.Fecha_UltMod = DateTime.Now;
                    Info.MotivoAnulacion = ofrm.motivoAnulacion;

                    if (Bus.AnularDB(Info, ref mensaje))
                    {
                        MessageBox.Show("Estado # " + Info.IdEstado_cierre +  " ANULADO Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al ANULAR Ajuste verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FrmCom_estado_cierre_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmCom_estado_cierre_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


    }
}
