using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.General;



namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_Tarjeta_cred_Mant : Form
    {

        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Tarjeta_cred_Info Info_Tarjeta = new Aca_Tarjeta_cred_Info();

        public delegate void delegate_FrmAca_Tarjeta_cred_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAca_Tarjeta_cred_Mant_FormClosing event_FrmAca_Tarjeta_cred_Mant_FormClosing;


        #endregion

        public FrmAca_Tarjeta_cred_Mant()
        {
            InitializeComponent();
            event_FrmAca_Tarjeta_cred_Mant_FormClosing += FrmAca_Tarjeta_cred_Mant_event_FrmAca_Tarjeta_cred_Mant_FormClosing;
        }

        void FrmAca_Tarjeta_cred_Mant_event_FrmAca_Tarjeta_cred_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void FrmAca_Tarjeta_cred_Mant_Load(object sender, EventArgs e)
        {

            try
            {

                CargarDatos();
                if (Accion == 0)
                { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        chkActivo.Checked = true;
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }

        }
        
        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        

        public void set_Info(Aca_Tarjeta_cred_Info info)
        {
            try
            {
                Info_Tarjeta = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }
        #endregion

        #region"Get" 
        public Aca_Tarjeta_cred_Info GetInfo(ref string mensaje)
        {
            Aca_Tarjeta_cred_Info rInfo = new Aca_Tarjeta_cred_Info();
            try
            {


                rInfo.IdTarjeta = Convert.ToInt16(txt_IdTarjeta.Text);
                rInfo.CodTarjeta = txt_codigo.Text;
                rInfo.nom_tarjeta = txt_descripcion.Text;
                rInfo.porc_comision = Convert.ToDouble(txt_porc_comision.Text);
               
                rInfo.UsuarioCreacion = param.IdUsuario;
                rInfo.UsuarioModificacion = param.IdUsuario;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;
                }

                rInfo.estado = (chkActivo.Checked == true) ? "A" : "I";
                if (chkActivo.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
            return rInfo;
        }
        #endregion

        #region "CargarDatos"
        

        public void CargarDatos()
        {
            try
            {
                txt_IdTarjeta.Text = "0";

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txt_IdTarjeta.Text = Info_Tarjeta.IdTarjeta.ToString();
                    txt_descripcion.Text = Info_Tarjeta.nom_tarjeta;
                    txt_codigo.Text = Info_Tarjeta.CodTarjeta;
                    txt_porc_comision.Text = Info_Tarjeta.porc_comision.ToString();
                }


                chkActivo.Checked = (Info_Tarjeta.estado == "A") ? true : false;
                if (Info_Tarjeta.estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (Info_Tarjeta.estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }
        #endregion

        #region "Proceso"
        public bool Grabar()
        {
            bool resultado = false;
            try
            {
                Aca_Tarjeta_cred_Info ruInfo = new Aca_Tarjeta_cred_Info();

                string mensaje = string.Empty;
                int id = 0;

                ruInfo = GetInfo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                Aca_Tarjeta_cred_Bus neg = new Aca_Tarjeta_cred_Bus();
                resultado = neg.GrabarDB(ruInfo, ref id, ref mensaje);
                txt_IdTarjeta.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
            return resultado;
        }

        public bool Actualizar()
        {  bool resultado=false;
            try
            {
                Aca_Tarjeta_cred_Bus neg = new Aca_Tarjeta_cred_Bus();
                Aca_Tarjeta_cred_Info ruInfo = new Aca_Tarjeta_cred_Info();
                string mensaje = string.Empty;

                ruInfo = GetInfo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                resultado = neg.ActualizarDB(ruInfo, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
            return resultado;
        }

        private void Anular()
        {
            try
            {
                if (Info_Tarjeta.estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) +" tarjeta #:" + txt_IdTarjeta.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();   

                        Aca_Tarjeta_cred_Bus neg = new Aca_Tarjeta_cred_Bus();
                        Aca_Tarjeta_cred_Info ruInfo = new Aca_Tarjeta_cred_Info();
                        string mensaje = string.Empty;

                        ruInfo = GetInfo(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                        }
                        ruInfo.UsuarioAnulacion = param.IdUsuario;
                        ruInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.EliminarDB(ruInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else {
                    MessageBox.Show("La tarjeta #:"+txt_IdTarjeta.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado =  Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
                            break;
                    }
                }                
            }

            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
            return resultado;
        }

        public bool validaciones()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_descripcion.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " descripción ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_descripcion.Focus();
                    return false;
                }
             
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }        
        #endregion

        #region "Eventos"

        

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }      

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            bool resultado = guardarDatos();
            if (resultado)
            {
                Close();    
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void FrmAca_Tarjeta_cred_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAca_Tarjeta_cred_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion

        
    



    }
}
