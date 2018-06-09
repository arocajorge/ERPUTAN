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
using Core.Erp.Info.General;
using Core.Erp.Business.Academico;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAca_RubroGrupoFE_Mant : Form
    {
        #region "Declaracion de Variables"

        Aca_RubroGrupoFE_Info RubroGrupoInfo = new Aca_RubroGrupoFE_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        string mensaje="";

        #region "Eventos y Delegados"

        public delegate void delegate_RubroGrupoFE_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_RubroGrupoFE_Mant_FormClosing event_FrmAca_RubroGrupoFE_Mant_FormClosing;
        
        #endregion

        #endregion

        public FrmAca_RubroGrupoFE_Mant()
        {
            InitializeComponent();
            event_FrmAca_RubroGrupoFE_Mant_FormClosing += FrmAca_RubroGrupoFE_Mant_event_FrmAca_RubroGrupoFE_Mant_FormClosing;
        }

        void FrmAca_RubroGrupoFE_Mant_event_FrmAca_RubroGrupoFE_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        
        #region "Set"

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                txtIdRubroGrupo.Text = "0";
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        public void set_RubroGrupo(Aca_RubroGrupoFE_Info info)
        {
            try
            {
                RubroGrupoInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
      
        #region "Get"
        //llena los campos que se encuentran en el furmulario en una clase info
        public Aca_RubroGrupoFE_Info Get_RubroGrupo(ref string mensaje)
        {
            Aca_RubroGrupoFE_Info Info = new Aca_RubroGrupoFE_Info();
            //txtIdRubroGrupo.Text = "0";
            try
            {
                Info.IdInstitucion = param.IdInstitucion;
                Info.IdGrupoFE = Convert.ToInt32(txtIdRubroGrupo.Text);
                Info.CodGrupoFE = txtCodRubroGrupo.Text;
                Info.nom_GrupoFe = txtNomRubroGrupo.Text;
                Info.UsuarioCreacion = param.IdUsuario;
                Info.UsuarioModificacion = param.IdUsuario;

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkEstado.Checked = true;
                }

                Info.estado = (chkEstado.Checked == true) ? "A" : "I";
                if (chkEstado.Checked)
                    lbEstado.Visible = false;
                else
                    lbEstado.Visible = true;

                return Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                throw;
            }
        }

        #endregion
      
        #region "Cargar Datos"
        //esto sirve para llenar los campos en los botones de consulta, modificar y anular
        public void Cargar_Datos()
        {
            try
            {
                if (RubroGrupoInfo.IdGrupoFE != 0)
                {
                    txtIdRubroGrupo.Text = "0";
                    if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                        txtIdRubroGrupo.Text = RubroGrupoInfo.IdGrupoFE.ToString();

                    txtCodRubroGrupo.Text = RubroGrupoInfo.CodGrupoFE.ToString();
                    txtNomRubroGrupo.Text = RubroGrupoInfo.nom_GrupoFe.ToString();
                    chkEstado.Checked = (RubroGrupoInfo.estado == "A") ? true : false;

                    if (chkEstado.Checked == true)
                        lbEstado.Visible = false;
                    else
                        lbEstado.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                throw;
            }
        }

        #endregion

        #region "Procesos"
        //aqui estan todas las funciones que se utilizan en el mantenimiento
        public void Limpiar()
        {
            try
            {
                txtIdRubroGrupo.Text = "";
                txtCodRubroGrupo.Text = "";
                txtNomRubroGrupo.Text = "";
                lbEstado.Visible = false;
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
                if (txtNomRubroGrupo.Text == "" || txtNomRubroGrupo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) +" descripción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomRubroGrupo.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                if (RubroGrupoInfo.estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) +" Tipo de Rubro #:" + txtIdRubroGrupo.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        Aca_RubroGrupoFE_Bus neg = new Aca_RubroGrupoFE_Bus();
                        Aca_RubroGrupoFE_Info ruInfo = new Aca_RubroGrupoFE_Info();
                        string mensaje = string.Empty;

                        ruInfo = Get_RubroGrupo(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ": " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ruInfo.UsuarioAnulacion = param.IdUsuario;
                        ruInfo.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = neg.Eliminar(ruInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) +": " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }

        public Boolean Grabar()
        {
            bool resultado = false;
            try
            {
                Aca_RubroGrupoFE_Info ruInfo = new Aca_RubroGrupoFE_Info();
                Aca_RubroGrupoFE_Bus RubroBus = new Aca_RubroGrupoFE_Bus();

                mensaje = "";
                int id = 0;
                ruInfo = Get_RubroGrupo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                if (RubroBus.Get_List_Rubro_Grupo_FE_Existe(ruInfo, ref mensaje))
                {
                    resultado = RubroBus.Grabar(ruInfo, ref id, ref mensaje);
                    txtIdRubroGrupo.Text = id.ToString();
                }
                else
                    MessageBox.Show("El codigo ingresado: " + ruInfo.CodGrupoFE.ToString() + " ya existe. Por favor ingrese otro codigo");
                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ": " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }

        public Boolean Actualizar()
        {
            bool resultado = false;
            try
            {
                Aca_RubroGrupoFE_Info ruInfo = new Aca_RubroGrupoFE_Info();
                Aca_RubroGrupoFE_Bus RubroBus = new Aca_RubroGrupoFE_Bus();

                mensaje = "";
                ruInfo = Get_RubroGrupo(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return false;
                }
                resultado = RubroBus.Actualizar(ruInfo, ref mensaje);
                
                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ": " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }

        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                if (Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Grabar();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado = Actualizar();
                            break;
                    }
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                return false;
            }
        }

        #endregion

        #region "Eventos y Botones"

        private void FrmAca_RubroGrupoFE_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        this.chkEstado.Checked = true;
                        txtIdRubroGrupo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIdRubroGrupo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        txtIdRubroGrupo.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        txtIdRubroGrupo.Enabled = false;
                        txtCodRubroGrupo.Enabled = false;
                        txtNomRubroGrupo.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                
            }
            
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guardarDatos())
                    Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Anular())
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("El registro se no se anuló.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                mensaje = ex.Message.ToString();
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }
        }

        #endregion

        private void FrmAca_RubroGrupoFE_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmAca_RubroGrupoFE_Mant_FormClosing(sender, e);
        }
    }
}