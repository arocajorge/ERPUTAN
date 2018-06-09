using Core.Erp.Business.General;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Info.SeguridadAcceso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Cambiar_Contrasenia : Form
    {
        #region " Variables y Propiedades "
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        seg_usuario_info usuario = new seg_usuario_info();
        seg_usuario_bus bus = new seg_usuario_bus();
        string MensajeError = string.Empty;
        string Usuario = string.Empty;
        bool? ExigirDirectivaContrasenia;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public void set_usuario(string _usuario)
        {
            usuario.IdUsuario = _usuario;
        }
        #endregion

        #region "Constructor"
        public FrmSeg_Cambiar_Contrasenia()
        {
            InitializeComponent();
        }
        #endregion

        #region "set"
        public void set_Info(seg_usuario_info _Usuario)
        {
            try
            {
                usuario = _Usuario;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region "Guardar"
        private Boolean Guardar()
        {
            try
            {
                Boolean Cambio = false;
                usuario = new seg_usuario_info();
                bus = new seg_usuario_bus();
                if (Validar())
                {
                    usuario.IdUsuario = txtUsuario.Text;
                    usuario.Contrasena = txtContrasenia_Actual.Text;
                    if (usuario.Contrasena.Trim() != txtNueva_Contrasenia.Text.Trim())
                    {
                        bool resultado = bus.Existe_Usuario(usuario.IdUsuario, ref MensajeError);
                        if (MensajeError.Equals(""))
                        {
                            if (resultado)
                            {
                                if (this.Text != "Restablecer Contraseña")
                                {
                                    if (bus.Validar_Credenciales(usuario, ref MensajeError))
                                    {
                                        if (MensajeError.Equals(""))
                                        {
                                            txtUsuario.Enabled = true;
                                            txtContrasenia_Actual.Enabled = true;
                                            ExigirDirectivaContrasenia = usuario.ExigirDirectivaContrasenia;
                                            if (txtNueva_Contrasenia.Text == null || txtNueva_Contrasenia.Text == "" && txtConfirmar_Contrasenia.Text == null || txtConfirmar_Contrasenia.Text == "")
                                            {
                                                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " nueva contraseña ", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                {
                                                    return txtNueva_Contrasenia.Focus();
                                                }
                                            }
                                        }
                                        if (Validaciones())
                                        {
                                            usuario.Contrasena = txtNueva_Contrasenia.Text;
                                            usuario.Fecha_UltMod = DateTime.Now;
                                            usuario.IdUsuarioUltModi = txtUsuario.Text;
                                            if (usuario.Contrasena == txtConfirmar_Contrasenia.Text)
                                            {
                                                int j = usuario.Contrasena.Length;
                                                bool correcta = false;
                                                int acum = 0;
                                                int acumtotal = 0;
                                                int acumnume = 0;
                                                int acumay = 0;
                                                if (ExigirDirectivaContrasenia == true)
                                                {
                                                    if (j >= 8)
                                                    {
                                                        for (int i = 0; i < j; i++)
                                                        {
                                                            if (!char.IsWhiteSpace(usuario.Contrasena, i) && !char.IsSeparator(usuario.Contrasena, i))
                                                            {
                                                                if (!char.IsControl(usuario.Contrasena, i) && !char.IsNumber(usuario.Contrasena, i)
                                                                   && !char.IsLower(usuario.Contrasena, i) && !char.IsLetter(usuario.Contrasena, i))
                                                                {
                                                                    acum = 1;
                                                                }
                                                                else if (char.IsDigit(usuario.Contrasena, i))
                                                                {
                                                                    acumnume = 1;
                                                                }
                                                                else if (char.IsUpper(usuario.Contrasena, i))
                                                                {
                                                                    acumay = 1;
                                                                }
                                                            }

                                                        }
                                                        acumtotal = acum + acumnume + acumay;
                                                        if (acumtotal == 3)
                                                        {
                                                            correcta = true;
                                                        }
                                                        else
                                                        {
                                                            if (acum == 0)
                                                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la nueva contraseña, no ah ingresado por lo menos un CARACTER ESPECIAL.. EJEMPLOS: !,@,#,$,%,^,&,*,(,),_,+,{,},:,.,/", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            if (acumnume == 0)
                                                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la nueva contraseña, no ah ingresado por lo menos un NUMERO.. EJEMPLOS: 1,2,3,4,5,6,7,8,9,0", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            if (acumay == 0)
                                                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la nueva contraseña, no ah ingresado por lo menos un letra MAYUSCULA.. EJEMPLOS: A,B,C,D", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            txtNueva_Contrasenia.Focus();
                                                            return correcta;
                                                        }

                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("La contraseña no consta de minimo 8 caracteres", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        txtNueva_Contrasenia.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    usuario.Fecha_UltMod = DateTime.Now;
                                                    usuario.IdUsuarioUltModi = txtUsuario.Text;
                                                    usuario.CambiarContraseniaSgtSesion = false;
                                                    if (bus.Actualizar_Password(usuario, ref MensajeError))
                                                    {
                                                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la nueva contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        Cambio = true;
                                                    }
                                                    else { MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                                }
                                                if (correcta == true)
                                                {
                                                    usuario.Fecha_UltMod = DateTime.Now;
                                                    usuario.IdUsuarioUltModi = txtUsuario.Text;
                                                    usuario.CambiarContraseniaSgtSesion = false;
                                                    if (bus.Actualizar_Password(usuario, ref MensajeError))
                                                    {
                                                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la nueva contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        Cambio = true;
                                                    }
                                                    else { MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la contraseña, no coincide con la confirmacion de contraseña ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
                                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la contraseña Actual no es la correcta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    if (Validaciones())
                                    {
                                        usuario.Contrasena = txtNueva_Contrasenia.Text;
                                        usuario.Fecha_UltMod = DateTime.Now;
                                        usuario.IdUsuarioUltModi = txtUsuario.Text;
                                        usuario.CambiarContraseniaSgtSesion = chk_cambio_contrasenia_sigt_sesion.Checked;
                                        usuario.ExigirDirectivaContrasenia = chk_directiva_contrasenia.Checked;
                                        if (usuario.Contrasena == txtConfirmar_Contrasenia.Text.Trim())
                                        {
                                            if (bus.Actualizar_Password(usuario, ref MensajeError))
                                            {
                                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la nueva contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                Cambio = true;
                                            }
                                            else { MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }
                                        }
                                        else
                                        {
                                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique la contraseña, no coincide con la confirmación de contraseña ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Core.Erp.Business.General.cl_parametrosGenerales_Bus.Instance.IdUsuario = null;
                                MessageBox.Show("El usuario no existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show(MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La nueva contraseña es igual a la contraseña actual, " + param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique su nueva contraseña ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                return Cambio;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region"Limpiar"
        private void Limpiar()
        {
            try
            {
                txtUsuario.Text = string.Empty;
                txtConfirmar_Contrasenia.Text = string.Empty;
                txtContrasenia_Actual.Text = string.Empty;
                txtConfirmar_Contrasenia.Text = string.Empty;
                usuario = new seg_usuario_info();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "Validaciones"
        private Boolean Validar()
        {
            try
            {
                Boolean resultado = true;
                if (string.IsNullOrEmpty(txtUsuario.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Usuario ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return false;
                }
                if (this.Text != "Restablecer Contraseña")
                    if (string.IsNullOrEmpty(txtContrasenia_Actual.Text.Trim()))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " contraseña actual ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtContrasenia_Actual.Focus();
                        return false;
                    }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Validaciones()
        {
            try
            {
                Boolean resultado = true;
                if (string.IsNullOrEmpty(txtNueva_Contrasenia.Text.Trim()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " nueva contraseña ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNueva_Contrasenia.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtConfirmar_Contrasenia.Text.Trim()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " confirmación de la contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtConfirmar_Contrasenia.Focus();
                    return false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region "Eventos"
        private void ucGe_Menu_Superior_Mant_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            if (Guardar())
                Close();
        }

        private void ucGe_Menu_Superior_Mant_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_Superior_Mant_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != null || txtUsuario.Text != "")
                if (MessageBox.Show("Esta seguro que no desea conservar los datos", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Limpiar();
                }
        }
        #endregion

        #region "Load"
        private void FrmSeg_Cambiar_Contrasenia_Load(object sender, EventArgs e)
        {
            try
            {

                if (this.Text == "Restablecer Contraseña")
                {
                    txtUsuario.Text = usuario.IdUsuario;
                    txtUsuario.Enabled = false;
                    lblContarseniaAnterior.Visible = false;
                    txtContrasenia_Actual.Visible = false;
                    chk_cambio_contrasenia_sigt_sesion.Checked = true;
                }
                else
                    if (usuario.IdUsuario != null && usuario.IdUsuario != "")
                    {
                        groupBox2.Visible = false;
                        txtUsuario.Text = usuario.IdUsuario;
                        txtUsuario.Enabled = false;
                        if (bus.Validar_Directiva_Contrasena(usuario, ref MensajeError))
                        {
                            ExigirDirectivaContrasenia = usuario.ExigirDirectivaContrasenia;
                            if (ExigirDirectivaContrasenia == true)
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " actualice su contraseña, debe componerce de minimo 8 CARACTERES, compuesta de MAYUSCULA, MINUSCULA, NUMERO y CARACTER ESPECIAL.." + " EJEMPLO: Hola123@", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtNueva_Contrasenia.Focus();
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
