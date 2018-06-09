using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_Departamento_Mant : Form
    {


        #region "Declaracion de Variables y Eventos"

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        Af_Departamento_Info Departemento_Info = new Af_Departamento_Info();
        Af_Departamento_Bus Bus_Departamento = new Af_Departamento_Bus();


        private Cl_Enumeradores.eTipo_action Accion;
        string mensaje;

        #region "Eventos y Delegados"

        //el delegado para el evento FormClosing debe de llamarse de la misma forma de donde lo mandas a llamar con los mismo parametros solamente le aumentas la palabra delegate_
        //lo mandas a llamar desde las pantallas de consulta
        public delegate void delegate_frmAF_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e);
        //el evento debe de llamarse de la misma forma que el evento del Form de mantenimiento, solo que le aumentas la palabra event_
        public event delegate_frmAF_Departamento_Mant_FormClosing event_frmAF_Departamento_Mant_FormClosing;


        #endregion

        #endregion


        public frmAF_Departamento_Mant()
        {
            InitializeComponent();
            event_frmAF_Departamento_Mant_FormClosing += frmAF_Departamento_Mant_event_frmAF_Departamento_Mant_FormClosing;
        }

        void frmAF_Departamento_Mant_event_frmAF_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }


        #region "Set, Get y Cargar Datos"

        public void Set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        

        public void Set_Info(Af_Departamento_Info Info_dep)
        {
            try
            {
                Departemento_Info = Info_dep;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public Af_Departamento_Info Get_Info(ref string mensaje)
        {
            try
            {
                Af_Departamento_Info Info = new Af_Departamento_Info();
                Info.IdEmpresa= param.IdEmpresa;
                Info.IdDepartamento =Convert.ToInt32(txt_IdMotivo.Text);
                Info.nom_departamento=txtDescripcion.Text;
                
                
                if(Accion==Cl_Enumeradores.eTipo_action.grabar)
                    chkEstado.Checked=true;

                Info.estado=(chkEstado.Checked==true)? "A" : "I";

                if(chkEstado.Checked)
                    lbl_Estado.Visible=false;
                else
                    lbl_Estado.Visible=true;

                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        public void Set_Info_Controls()
        {
            try
            {
                if (Departemento_Info.IdDepartamento != 0)
                {
                    txt_IdMotivo.Text = "0";
                    if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        txt_IdMotivo.Text = Departemento_Info.IdDepartamento.ToString();

                    txtDescripcion.Text = Departemento_Info.nom_departamento.ToString();
                    chkEstado.Checked = (Departemento_Info.estado == "A") ? true : false;
                    if (chkEstado.Checked)
                        lbl_Estado.Visible = false;
                    else
                        lbl_Estado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        #endregion

        #region "Funciones y Procesos"

        public void Limpiar()
        {
            try
            {
                txt_IdMotivo.Text = "0";
                txtDescripcion.Text = "";
                chkEstado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public Boolean Validar()
        {
            try
            {
                if (txtDescripcion.Text == "" || txtDescripcion.EditValue == null)
                {
                    MessageBox.Show("Por favor ingrese un motivo de venta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                if (Departemento_Info.estado == "I")
                {
                    MessageBox.Show("El registro ya se encuentra anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txt_IdMotivo.Text.Trim() + " ?", "Anulación de Mantenimiento Tipo Rubro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        
                        Af_Departamento_Bus neg = new Af_Departamento_Bus();
                        Af_Departamento_Info moInfo = new Af_Departamento_Info();
                        string mensaje = string.Empty;

                        moInfo = Get_Info(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        //moInfo.UsuarioAnulacion = param.IdUsuario;
                        //moInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.AnularDB(moInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Guardar()
        {
            bool resultado = false;
            try
            {
                Af_Departamento_Info InfoDepartamento = new Af_Departamento_Info();
                Af_Departamento_Bus BusDepartamento = new Af_Departamento_Bus();
                mensaje="";
                int id = 0;

                InfoDepartamento = Get_Info(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                

                resultado = BusDepartamento.GrabarDB(InfoDepartamento, ref id, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Af_Departamento_Info InfoMotivo = new Af_Departamento_Info();
                Af_Departamento_Bus BusMotivo = new Af_Departamento_Bus();
                mensaje = "";
                InfoMotivo=Get_Info(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }

                resultado = BusMotivo.ModificarDB(InfoMotivo, ref mensaje);

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                    this.ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Boolean Guardar_Datos()
        {
            bool resultado = false;
            try
            {
                if (Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Guardar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Modificar();
                            break;
                    }
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

        #endregion

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    MessageBox.Show("El registro se anuló satisfactoriamente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro se no se anuló.Consulte con su departamento de Sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void frmAF_Departamento_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        txt_IdMotivo.Enabled = false;
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        txt_IdMotivo.Enabled = false;
                        Set_Info_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        txt_IdMotivo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        Set_Info_Controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        txt_IdMotivo.Enabled = false;
                        txtDescripcion.Enabled = false;
                        chkEstado.Enabled = false;
                        Set_Info_Controls();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw;
            }
        }

        private void frmAF_Departamento_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmAF_Departamento_Mant_FormClosing(sender, e);
        }


    }
}
