using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.SeguridadAcceso;
using Core.Erp.Business.SeguridadAcceso;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.SeguridadAcceso
{
    public partial class FrmSeg_Usuario_Mant : Form
    {
        #region" Variables y Propiedades "
        public delegate void delegate_FrmSeg_Usuario_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmSeg_Usuario_Mant_FormClosing event_FrmSeg_Usuario_Mant_FormClosing;


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();


        seg_usuario_info InfoUsuario= new seg_usuario_info();
        tb_Empresa_Bus empresa_bus = new tb_Empresa_Bus();

        
        List<tb_Empresa_Info> list_all__empresas = new List<tb_Empresa_Info>();
        List<tb_Empresa_Info> lEmpresas_x_Usuario = new List<tb_Empresa_Info>();
        #endregion 

        #region " set "
        public void  set_Info(seg_usuario_info Info)
        {
            try
            {
                InfoUsuario = Info;
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

        public void set_accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            try
            {
                Accion = _Accion;
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

        #region " Constructor "
        public FrmSeg_Usuario_Mant()
        {
            try
            {
                InitializeComponent();
                event_FrmSeg_Usuario_Mant_FormClosing += FrmSeg_Usuario_Mant_event_FrmSeg_Usuario_Mant_FormClosing;

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

        void FrmSeg_Usuario_Mant_event_FrmSeg_Usuario_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region " Modificar, Guardar "
        private bool Modificar()
        {
            try
            {
                if (!Validar())
                {
                    List<tb_Empresa_Info> nuevasEmpresas = new List<tb_Empresa_Info>();
                    foreach (var empresa in listaEmpresas.CheckedItems)
                        nuevasEmpresas.Add(empresa as tb_Empresa_Info);

                    seg_usuario_info info = new seg_usuario_info();
                    info.IdUsuario = this.txtIdUsuario.Text;
                    info.Contrasena = this.txtPassword.Text;
                    info.estado = this.InfoUsuario.estado;
                    info.Nombre = txtNombre.Text;
                    info.CambiarContraseniaSgtSesion = chk_cambio_contrasenia_sigt_sesion.Checked;
                    info.ExigirDirectivaContrasenia = chk_directiva_contrasenia.Checked;

                    string mensaje = "";
                    if(new seg_usuario_bus().Update_usuario_referencias(info,nuevasEmpresas,ref mensaje))
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el usuario " + info.IdUsuario, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    } 
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ": " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                return false;
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

        private bool Guardar()
        {
            try
            {
                string msgError = "";
                bool existe = new seg_usuario_bus().Existe_Usuario(txtIdUsuario.Text, ref msgError);
                if (!msgError.Equals(""))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ": " + msgError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (existe)
                {
                    MessageBox.Show("El usuario ya existe", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                if (!Validar())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            {
                                seg_usuario_info info = new seg_usuario_info();
                                info.IdUsuario = txtIdUsuario.Text;
                                info.Contrasena = txtPassword.Text;
                                info.estado = "A";
                                info.Nombre = txtNombre.Text;
                                info.CambiarContraseniaSgtSesion = chk_cambio_contrasenia_sigt_sesion.Checked;
                                info.ExigirDirectivaContrasenia = chk_directiva_contrasenia.Checked;

                                List<int> idEmpresas = new List<int>();
                                foreach (var empresa in listaEmpresas.CheckedItems)
                                    idEmpresas.Add((empresa as tb_Empresa_Info).IdEmpresa);
                                string MensajeError = "";

                                new seg_usuario_bus().GrabarUser_x_Empresa(info, idEmpresas, ref MensajeError);
                                if (MensajeError.Equals(""))
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " el usuario " + info.IdUsuario, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                    }
                }
                return false;
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
        protected override bool ProcessDialogKey(Keys keyData)
        {
            try
            {
                bool esTextBox = false;
                foreach (Control control in this.Controls)
                {
                    if (control.Focused)
                    {
                        esTextBox = (typeof(TextBox) == control.GetType()) ? true : false;
                        continue;
                    }
                }
                if (((int)keyData == (int)Keys.Enter) && (esTextBox))
                    return base.ProcessDialogKey(Keys.Tab);
                else
                    return base.ProcessDialogKey(keyData);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return base.ProcessDialogKey(keyData);
            }
        }
        
        private void FrmManUsuario_Load(object sender, EventArgs e)
        {            
            try
            {
                txtConfirmarPassword.Visible = false;
                lblConfirmarPassword.Visible = false;
                txtIdUsuario.Enabled = false;            
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        {
                            this.toolStrip1.Visible = false;
                            txtIdUsuario.Enabled = true;                           
                            txtConfirmarPassword.Visible = true;
                            lblConfirmarPassword.Visible = true;
                            txtNombre.Text = "";
                            txtPassword.Text = "";
                            CargarEmpresas();
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        {
                            uC_Menu_Mantenimientos1.Visible_btnGuardar = false;
                            txtConfirmarPassword.Visible = true;
                            lblConfirmarPassword.Visible = true;
                            txtConfirmarPassword.Enabled = false;
                            txtPassword.Enabled = false;
                            CargarEmpresas();
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.Anular:
                        {                            
                            //this.uC_Menu_Mantenimientos1.toolStripSalir.Enabled = true;
                            this.toolStrip1.Visible = false;
                            this.toolStripButtonResetearContrasenia.Visible = false;
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.consultar:
                        {
                            uC_Menu_Mantenimientos1.Visible_bntGuardar_y_Salir = false;
                            uC_Menu_Mantenimientos1.Visible_btnGuardar = false;
                            this.toolStrip1.Visible = false;
                            CargarEmpresas();
                            this.label2.Visible = false;
                            this.txtPassword.Visible = false;
                            this.label3.Location = label2.Location;
                            this.txtNombre.Location = txtPassword.Location;
                            this.listaEmpresas.Enabled = false;
                            this.txtNombre.Enabled = false;
                            break;
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

        private void uC_Menu_Mantenimientos1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar())
                    Limpiar();
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

        private void uC_Menu_Mantenimientos1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if ((this.Accion == Cl_Enumeradores.eTipo_action.grabar) ? Guardar() : Modificar())
                    this.Close();
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

        private void uC_Menu_Mantenimientos1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        private void FrmSeg_Usuario_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_FrmSeg_Usuario_Mant_FormClosing(sender, e);
        }

        private void toolStripButtonResetearContrasenia_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSeg_Cambiar_Contrasenia frm = new FrmSeg_Cambiar_Contrasenia();
                frm.MdiParent = this.MdiParent;
                frm.Text = "Restablecer Contraseña";
                frm.set_Info(InfoUsuario);
                frm.Show();
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

        #region " Cargar datos "
        private void CargarEmpresas()
        {
            try
            {
                string mensaje = "";

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        {
                            list_all__empresas = empresa_bus.Get_List_Empresa();
                            this.listaEmpresas.DataSource = list_all__empresas;
                            this.listaEmpresas.DisplayMember = "em_nombre";
                            this.listaEmpresas.ValueMember = "IdEmpresa";
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        {
                            list_all__empresas = empresa_bus.Get_List_Empresa();
                            this.listaEmpresas.DataSource = list_all__empresas;
                            this.listaEmpresas.DisplayMember = "em_nombre";
                            this.listaEmpresas.ValueMember = "IdEmpresa";
                            lEmpresas_x_Usuario = new tb_Empresa_Bus().Get_List_Empresa_x_Usuario(InfoUsuario.IdUsuario);
                            
                            for (int i = 0; i < lEmpresas_x_Usuario.Count; i++)
                                for (int j = 0; j < list_all__empresas.Count; j++)
                                    if (list_all__empresas[j].IdEmpresa == lEmpresas_x_Usuario[i].IdEmpresa)
                                        listaEmpresas.SetItemChecked(j, true);

                            txtIdUsuario.Text = InfoUsuario.IdUsuario;
                            txtNombre.Text = InfoUsuario.Nombre;
                            txtPassword.Text = InfoUsuario.Contrasena;
                            txtConfirmarPassword.Text = InfoUsuario.Contrasena;
                            chk_cambio_contrasenia_sigt_sesion.Checked = (InfoUsuario.CambiarContraseniaSgtSesion == null) ? chk_cambio_contrasenia_sigt_sesion.Checked : (bool)InfoUsuario.CambiarContraseniaSgtSesion;
                            chk_directiva_contrasenia.Checked = (InfoUsuario.ExigirDirectivaContrasenia == null) ? false : (bool)InfoUsuario.ExigirDirectivaContrasenia;
                            break;
                        }
                    case Cl_Enumeradores.eTipo_action.consultar:
                        {
                            try
                            {
                                list_all__empresas = empresa_bus.Get_List_Empresa_x_Usuario(InfoUsuario.IdUsuario);
                                this.listaEmpresas.DataSource = list_all__empresas;
                                this.listaEmpresas.DisplayMember = "em_nombre";
                                this.listaEmpresas.ValueMember = "IdEmpresa";
                                for (int i = 0; i < listaEmpresas.Items.Count; i++)
                                {
                                    listaEmpresas.SetItemChecked(i, true);
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
                            txtIdUsuario.Text = InfoUsuario.IdUsuario;
                            txtNombre.Text = InfoUsuario.Nombre;
                            chk_cambio_contrasenia_sigt_sesion.Checked = (InfoUsuario.CambiarContraseniaSgtSesion == null) ? chk_cambio_contrasenia_sigt_sesion.Checked : (bool)InfoUsuario.CambiarContraseniaSgtSesion;
                            chk_directiva_contrasenia.Checked = (InfoUsuario.ExigirDirectivaContrasenia == null) ? false : (bool)InfoUsuario.ExigirDirectivaContrasenia;
                            chk_directiva_contrasenia.Enabled = false;
                            chk_cambio_contrasenia_sigt_sesion.Enabled = false;
                            break;
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

        #region " validaciones "
        private bool Validar()
        {
            try
            {
                if (this.txtIdUsuario.Text.Equals(""))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Id Usuario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                if (this.txtPassword.Equals(""))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                if (txtConfirmarPassword.Text.Equals(""))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Confirmar Contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                if (!txtConfirmarPassword.Text.Equals(txtPassword.Text))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique, no coincide con la confirmación de contraseña", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                if (listaEmpresas.CheckedItems.Count == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Empresa ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                if (this.txtNombre.Equals(""))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre completo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                if (this.chk_cambio_contrasenia_sigt_sesion.Checked == false)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " cambio de contraseña en el siguiente inicio de sesión del usuario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    chk_cambio_contrasenia_sigt_sesion.Focus();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void Limpiar()
        {
            try
            {
                foreach (Control control in this.groupBox1.Controls)
                    if (control.GetType() == typeof(TextBox))
                        (control as TextBox).Text = "";

                foreach (Control control in this.groupBox2.Controls)
                    if (control.GetType() == typeof(CheckBox))
                        (control as CheckBox).Checked = false;

                for (int i = 0; i < listaEmpresas.Items.Count; i++)
                {
                    listaEmpresas.SetItemChecked(i, false);
                }
                txtIdUsuario.Focus();
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
