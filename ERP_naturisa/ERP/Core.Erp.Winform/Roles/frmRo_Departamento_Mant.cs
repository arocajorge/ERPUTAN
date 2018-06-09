using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Nodes.Operations;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;


namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Departamento_Mant : Form
    {
        #region Declaracion de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();        
        ro_Departamento_Bus Bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> LstInfoDep = new List<ro_Departamento_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_Departamento_Info Info = new ro_Departamento_Info();
        ro_Departamento_Info infDepPadre = new ro_Departamento_Info();
        Cl_Enumeradores.eTipo_action Accion;
        private int Bandera = 0;
        UCRo_Departamento UCRDep = new UCRo_Departamento();

        public delegate void delegate_frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmRo_Departamento_Mant_FormClosing Event_frmRo_Departamento_Mant_FormClosing;
        #endregion

        #region codigo viejo
        #endregion

        public frmRo_Departamento_Mant()
        {
            try
            {
                  InitializeComponent();
                  ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
                  ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                  ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                  ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                  ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;

                  Event_frmRo_Departamento_Mant_FormClosing += frmRo_Departamento_Mant_Event_frmRo_Departamento_Mant_FormClosing;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }

        }

        void frmRo_Departamento_Mant_Event_frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            
            try
            {
                pu_Grabar();
            this.Close();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { pu_Grabar();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public void set_Info(ro_Departamento_Info _Info)
        {
            try
            {
                UCRDep.set_DepartamentoCheckedSelection(_Info);
                if (_Info != null)
                {
                    txtNomDpto.Text = (_Info.de_descripcion);

                    CheckEstado.Checked = (_Info.Estado == "A") ? true : false;
                    if (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.consultar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        txtid.Text = (_Info.IdDepartamento.ToString());
                    }
                    Info = _Info;

                    if (_Info.Estado == "I")
                    {
                        lbl_Estado.Visible = true;
                    }
                    else
                    {
                        lbl_Estado.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        public ro_Departamento_Info get_Info()
        {
            try
            {
                Info = new ro_Departamento_Info();
                if (Accion == Cl_Enumeradores.eTipo_action.actualizar || Accion == Cl_Enumeradores.eTipo_action.consultar || Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    Info.IdDepartamento = Convert.ToInt16(txtid.Text);
                }
                
                Info.IdEmpresa = param.IdEmpresa;
                
                Info.de_descripcion = txtNomDpto.Text;
                Info.Estado = (CheckEstado.Checked == true) ? "A" : "I";

                return Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
                return new ro_Departamento_Info();
            }
        }

        private Boolean Validar()
        {
            try
            {

                if (txtNomDpto.Text.Length == 0)
                {
                    MessageBox.Show("Error: Ingrese Datos", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }

        private void Limpiar()
        {
            try
            {
                txtid.Text = "0";
                txtNomDpto.Text = "";
                CheckEstado.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                        txtNomDpto.Enabled = true;
                        CheckEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtid.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtNomDpto.Enabled = false;
                        CheckEstado.Enabled = false;
                        lbl_Estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtNomDpto.Enabled = false;
                        CheckEstado.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private Boolean pu_Grabar()
        {
            try
            {
                int id = 0;
                string msg = "";

                if (Validar())
                {
                    get_Info();
                    if (Bus.GrabarDB(Info, ref id, ref msg))
                    {
                        MessageBox.Show(Resources.msgConfirmaGrabarOk, Resources.msgTituloGrabar, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();  
                    }
                    else
                    {
                        MessageBox.Show("El registro no se pudo guardar, revise por favor: "+msg, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

      
       

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string mensaje = "";

                if (MessageBox.Show("¿Está seguro que desea anular el Departamento...?", "Anulación de Departamento  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                    ofrm.ShowDialog();

                    Info.IdUsuarioUltAnu = param.IdUsuario;
                    Info.Fecha_UltMod = DateTime.Now;
                    Info.MotiAnula = ofrm.motivoAnulacion;

                    if (Bus.AnularDB(Info, ref mensaje))
                    {
                        MessageBox.Show(Resources.msgConfirmaAnulacionOk, Resources.msgTituloAnular, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al ANULAR DEPARTAMENTO verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message); return false;
            }
        }

        private void frmRo_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmRo_Departamento_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Departamento_Mant_Load(object sender, EventArgs e)
        {

        }

  

        private void frmRo_Departamento_Mant_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


    

    }
}
