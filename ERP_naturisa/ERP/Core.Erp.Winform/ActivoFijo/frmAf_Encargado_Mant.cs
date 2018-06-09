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
    public partial class frmAf_Encargado_Mant : Form
    {
        

       


       #region "Declaracion de Variables y Eventos"

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;



        Af_Encargado_Info Info_Encargado = new Af_Encargado_Info();
        Af_Encargado_Bus Bus_Encargado = new Af_Encargado_Bus();
        private Cl_Enumeradores.eTipo_action Accion;
        string mensaje;

        #region "Eventos y Delegados"

        //el delegado para el evento FormClosing debe de llamarse de la misma forma de donde lo mandas a llamar con los mismo parametros solamente le aumentas la palabra delegate_
        //lo mandas a llamar desde las pantallas de consulta
        public delegate void delegate_frmAf_Encargado_FormClosing(object sender, FormClosingEventArgs e);
        //el evento debe de llamarse de la misma forma que el evento del Form de mantenimiento, solo que le aumentas la palabra event_
        public event delegate_frmAf_Encargado_FormClosing event_frmAf_Encargado_FormClosing;

        #endregion

        #endregion


        public frmAf_Encargado_Mant()
        {
            InitializeComponent();
            event_frmAf_Encargado_FormClosing += frmAf_Encargado_Mant_event_frmAf_Encargado_FormClosing;
        }

        void frmAf_Encargado_Mant_event_frmAf_Encargado_FormClosing(object sender, FormClosingEventArgs e)
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

        public void Set_Info(Af_Encargado_Info _Info_Encargado)
        {
            try
            {
                Info_Encargado = _Info_Encargado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        public Af_Encargado_Info Get_Info(ref string mensaje)
        {
            try
            {

                Af_Encargado_Info Info = new Af_Encargado_Info();

                Info.IdEmpresa= param.IdEmpresa;
                Info.IdEncargado =Convert.ToInt32(txt_IdMotivo.Text);
                Info.nom_encargado =txtDescripcion.Text;

                
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


        private void Set_Info_Controls()
        {
            try
            {
                if (Info_Encargado.IdEncargado != 0)
                {
                    txt_IdMotivo.Text = "0";
                    if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        txt_IdMotivo.Text = Info_Encargado.IdEncargado.ToString();


                    txtDescripcion.Text = Info_Encargado.nom_encargado.ToString();
                    chkEstado.Checked = (Info_Encargado.estado == "A") ? true : false;
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
                if (Info_Encargado.estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Tipo de Rubro #:" + txt_IdMotivo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Af_Encargado_Bus neg = new Af_Encargado_Bus();
                        Af_Encargado_Info moInfo = new Af_Encargado_Info();
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
                Af_Encargado_Info InfoMotivo = new Af_Encargado_Info();
                Af_Encargado_Bus BusMotivo = new Af_Encargado_Bus();


                mensaje="";
                int id = 0;

                InfoMotivo = Get_Info(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                
                resultado = BusMotivo.GrabarDB(InfoMotivo, ref id, ref mensaje);
                

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Af_Encargado_Info InfoMotivo = new Af_Encargado_Info();
                Af_Encargado_Bus BusMotivo = new Af_Encargado_Bus();

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

        private void frmAf_Encargado_Load(object sender, EventArgs e)
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

        private void frmAf_Encargado_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmAf_Encargado_FormClosing(sender, e);
        }


    }
}
