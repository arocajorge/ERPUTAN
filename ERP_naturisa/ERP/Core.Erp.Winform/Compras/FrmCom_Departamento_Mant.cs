using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Departamento_Mant : Form
    {
        #region Variables

        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        com_departamento_Info Info_Departamento = new com_departamento_Info();
        com_departamento_Info Depar = new com_departamento_Info();
        com_departamento_Bus Bus = new com_departamento_Bus();
        
        public delegate void delegate_FrmCom_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmCom_Departamento_Mant_FormClosing event_FrmCom_Departamento_Mant_FormClosing;

        string mensaje = "";

        #endregion

        public FrmCom_Departamento_Mant()
        {
            InitializeComponent();
            event_FrmCom_Departamento_Mant_FormClosing += FrmCom_Departamento_Mant_event_FrmCom_Departamento_Mant_FormClosing;
        }

        void FrmCom_Departamento_Mant_event_FrmCom_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmCom_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmCom_Departamento_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                
                
            }
        }

        #region Funciones Set y Get

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void set_Accion_In_controls()
        {

            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntImprimir = false;
                        chkEstado.Checked = true;
                        chkEstado.Enabled = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        chkEstado.Enabled = true;
                        Set_Info_Departamento_In_controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        Set_Info_Departamento_In_controls();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        chkEstado.Enabled = false;
                        Set_Info_Departamento_In_controls();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Set_Info_Departamento(com_departamento_Info Info)
        {
            try
            {
                Info_Departamento = Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Set_Info_Departamento_In_controls()
        {
            try
            {
                
                txtIdDepartamento.Text = Info_Departamento.IdDepartamento.ToString();
                txtNombre_Departamento.Text = Info_Departamento.nom_departamento;
                chkEstado.Checked = (Info_Departamento.Estado == "A") ? true : false;
                if (chkEstado.Checked)
                    lblEstado.Visible = false;
                else
                    lblEstado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        public com_departamento_Info Get_Departamento(ref string mensaje)
        {
            com_departamento_Info Depar_Info = new com_departamento_Info();
            try
            {
                Depar_Info.IdEmpresa = param.IdEmpresa;
                Depar_Info.IdDepartamento = (txtIdDepartamento.Text != "") ? Convert.ToDecimal(txtIdDepartamento.Text) : 0;
                Depar_Info.nom_departamento = txtNombre_Departamento.Text;
                Depar_Info.Estado = (chkEstado.Checked == true) ? "A" : "I";

                return Depar_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw new Exception();
            }
        }

        #endregion

        #region Procesos

        public Boolean Grabar()
        {
            bool resultado = false;
            try
            {
                Depar = new com_departamento_Info();
                if (txtNombre_Departamento.Text == "")
                {
                    MessageBox.Show("Ingrese un Nombre para el Departamento", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }

                Depar = Get_Departamento(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return resultado;
                }
                Depar.IdUsuario = param.IdUsuario;
                Depar.Fecha_Transac = DateTime.Now;

                if (Bus.GuardarDB(Depar))
                {
                    MessageBox.Show("Grabado Exitoso", " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resultado = true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Modificar()
        {
            bool resultado = false;
            try
            {
                Depar = new com_departamento_Info();
                if (txtNombre_Departamento.Text == "")
                {
                    MessageBox.Show("Ingrese un Nombre para el Departamento", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return resultado;
                }

                Depar = Get_Departamento(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return resultado;
                }

                Depar.IdUsuarioUltMod = param.IdUsuario;
                Depar.Fecha_UltMod = DateTime.Now;

                if (Bus.ModificarDB(Depar))
                {
                    MessageBox.Show("Grabado Exitoso", " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resultado = true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        resultado = Grabar();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        resultado = Modificar();
                        break;
                }
                return resultado;
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Limpiar()
        {
            txtIdDepartamento.Text = "";
            txtNombre_Departamento.Text = "";
        }

        private void Anular()
        {
            try
            {
                if (Info_Departamento.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txtIdDepartamento.Text.Trim() + " ?", "Anulación de Mantenimiento Tipo Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Depar = new com_departamento_Info();
                        
                        mensaje = "";

                        Depar = Get_Departamento(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        Depar.IdUsuarioUltAnu = param.IdUsuario;
                        Depar.MotiAnula = fr.motivoAnulacion;
                        bool resultado = Bus.AnularDB(Depar);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El rubro #:" + txtIdDepartamento.Text.Trim() + " ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            if (guardarDatos())
                Limpiar();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (guardarDatos())
                Close();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCom_Departamento_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                set_Accion_In_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
