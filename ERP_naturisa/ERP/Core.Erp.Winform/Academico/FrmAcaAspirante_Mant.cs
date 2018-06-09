using Core.Erp.Business.General;
using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaAspirante_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Aspirante_Info infoAspirante = new Aca_Aspirante_Info();
        Aca_Aspirante_Bus negAspirante ;
        public delegate void delegate_FrmAcaAspirante_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaAspirante_Mant_FormClosing event_FrmAcaAspirante_Mant_FormClosing;

        
        #endregion

        public FrmAcaAspirante_Mant()
        {
            InitializeComponent();
           event_FrmAcaAspirante_Mant_FormClosing+=FrmAcaAspirante_Mant_event_FrmAcaAspirante_Mant_FormClosing;
        }
    
        #region "Carga Datos"
        private void CargarCombos()
        {
            tb_pais_Bus neg = new tb_pais_Bus();
            cmbNacionalidad.DataSource = neg.Get_List_pais();
            cmbNacionalidad.SelectedValue = "1";
        }

        public void CargarDatosAspirante()
        {
            try
            {
                txtIdAspirante.Text = Convert.ToString(infoAspirante.IdAspirante);
                txtCodigo.Text = infoAspirante.CodAspirante;
                txtApellidos.Text = infoAspirante.Persona_Info.pe_apellido;
                txtNombres.Text = infoAspirante.Persona_Info.pe_nombre;
                txtLugar.Text = infoAspirante.Lugar;
                txtNroCelular.Text = infoAspirante.Persona_Info.pe_celular;
                txtTelefono.Text = infoAspirante.Persona_Info.pe_telefonoCasa;
                txtDireccion.Text = infoAspirante.Persona_Info.pe_direccion;
                txtEmail.Text = infoAspirante.Persona_Info.pe_correo;
                txtBarrio.Text = infoAspirante.Barrio;
                txtCedRuc.Text = infoAspirante.Persona_Info.pe_cedulaRuc;
                ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue = (infoAspirante.Persona_Info.IdTipoDocumento == null) ? "CED" : infoAspirante.Persona_Info.IdTipoDocumento;
                cmbNacionalidad.SelectedValue = (infoAspirante.Pais_Info.IdPais == null) ? "1" : infoAspirante.Pais_Info.IdPais;


                //dtFechaNacimiento.EditValue = (infoAspirante.Persona_Info.pe_fechaNacimiento.ToString() == null) ? DateTime.Now.ToShortDateString() : Convert.ToDateTime( infoAspirante.Persona_Info.pe_fechaNacimiento).ToShortDateString();
                if (infoAspirante.Persona_Info.pe_fechaNacimiento == null)
                {
                    dtFechaNacimiento.EditValue = DateTime.Now;
                }
                else
                {
                    dtFechaNacimiento.EditValue = Convert.ToDateTime(infoAspirante.Persona_Info.pe_fechaNacimiento).ToShortDateString();
                }
                
                
                rgSexo.EditValue = (infoAspirante.Persona_Info.pe_sexo == null) ? "SEXO_MAS" : infoAspirante.Persona_Info.pe_sexo;
                lblIdPersonaTxt.Text = infoAspirante.Persona_Info.IdPersona.ToString();
                chkActivo.Checked = (infoAspirante.Persona_Info.pe_estado == "A") ? true : false;
                if (infoAspirante.Persona_Info.pe_estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (infoAspirante.Persona_Info.pe_estado !=null)
                    {
                        lblAnulado.Visible = true;    
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

        public void ObtenerDatosAspirante_x_Cedula()
        {
            try
            {
                tb_persona_bus neg = new tb_persona_bus();
                tb_persona_Info infoPersona = new tb_persona_Info();
                infoPersona = neg.Get_Info_Persona(txtCedRuc.Text.Trim());
                infoAspirante.IdInstitucion = param.IdInstitucion;
                infoAspirante.IdAspirante = Convert.ToDecimal(txtIdAspirante.Text);
                infoAspirante.Persona_Info.IdPersona = infoPersona.IdPersona;
                infoAspirante.Persona_Info.pe_nombre = infoPersona.pe_nombre;
                infoAspirante.Persona_Info.pe_apellido = infoPersona.pe_apellido;
                infoAspirante.Persona_Info.pe_cedulaRuc = infoPersona.pe_cedulaRuc;
                infoAspirante.Persona_Info.pe_fechaNacimiento = infoPersona.pe_fechaNacimiento;
                infoAspirante.Persona_Info.pe_correo = infoPersona.pe_correo;
                infoAspirante.Persona_Info.pe_direccion = infoPersona.pe_direccion;
                infoAspirante.Persona_Info.pe_sexo = infoPersona.pe_sexo;
                infoAspirante.Persona_Info.pe_telefonoCasa = infoPersona.pe_telefonoCasa;
                infoAspirante.Persona_Info.IdTipoDocumento = infoPersona.IdTipoDocumento;
                infoAspirante.Persona_Info.pe_celular = infoPersona.pe_celular;
                infoAspirante.Persona_Info.pe_estado = infoPersona.pe_estado;               

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

        #region "Set"
        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
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

        public void set_Aspirante(Aca_Aspirante_Info info)
        {
            try
            {
                infoAspirante = info;
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

        #region "Get"
        public Aca_Aspirante_Info GetAspirante(ref string mensaje) {
            try
            {
                infoAspirante = new Aca_Aspirante_Info();
                infoAspirante.IdAspirante = ( txtIdAspirante.Text.Trim()=="" || txtIdAspirante.Text==null)?0: Convert.ToDecimal(txtIdAspirante.Text.Trim());
                infoAspirante.CodAspirante = (this.txtCodigo.Text.Trim() == "" || this.txtCodigo.Text == null) ? txtIdAspirante.Text.Trim() : this.txtCodigo.Text.Trim();
                infoAspirante.IdInstitucion = param.IdInstitucion;
                infoAspirante.Lugar = txtLugar.Text.Trim();
                infoAspirante.Barrio = txtBarrio.Text.Trim();
                infoAspirante.UsuarioCreacion = param.IdUsuario;
                infoAspirante.FechaCreacion = DateTime.Now;
               

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkActivo.Checked = true;                    
                }

                infoAspirante.Estado = (chkActivo.Checked == true) ? "A" : "I";
                if (chkActivo.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }

                tb_persona_Info infoPersona = new tb_persona_Info();
                infoPersona.IdEmpresa = param.IdEmpresa;
                infoPersona.IdPersona =  string.IsNullOrEmpty(lblIdPersonaTxt.Text) ? 0 : Convert.ToDecimal(lblIdPersonaTxt.Text.Trim());
                infoPersona.CodPersona = string.IsNullOrEmpty (txtCodigo.Text) ? "" : txtCodigo.Text.Trim();
                infoPersona.IdTipoDocumento = ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString();
                infoPersona.pe_cedulaRuc = this.txtCedRuc.Text.Trim();
                infoPersona.pe_nombre = this.txtNombres.Text.Trim();
                infoPersona.pe_apellido = this.txtApellidos.Text.Trim();
                infoPersona.pe_nombreCompleto = this.txtNombres.Text.Trim() + " " + this.txtApellidos.Text.Trim();
                infoPersona.pe_Naturaleza = "NATU";
                infoPersona.IdEstadoCivil = "SOLTE";
                infoPersona.IdTipoPersona = 6; // Aspirante

                infoPersona.pe_direccion = txtDireccion.Text.Trim();
                infoPersona.pe_telefonoCasa = txtTelefono.Text.Trim();
                infoPersona.pe_celular = txtNroCelular.Text.Trim();
                infoPersona.pe_correo = txtEmail.Text.Trim();
                infoPersona.pe_fechaNacimiento = Convert.ToDateTime(this.dtFechaNacimiento.Text);
                infoPersona.pe_sexo = rgSexo.Properties.Items[rgSexo.SelectedIndex].Value.ToString();
                infoPersona.pe_fechaModificacion = DateTime.Now;
                infoPersona.pe_UltUsuarioModi = param.IdUsuario;
                infoPersona.pe_estado = "A";

                tb_pais_Info infoPais = new tb_pais_Info();
                infoPais.IdPais = cmbNacionalidad.SelectedValue.ToString();

                infoAspirante.Persona_Info = infoPersona;
                infoAspirante.Pais_Info = infoPais;
                infoAspirante.Estado = "A";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return infoAspirante;
        }
        #endregion

        #region "Proceso"
            public void guardarDatos()
            {
                try
                {
                    if (validaciones())
                    {
                        switch (Accion)
                        {
                            case Cl_Enumeradores.eTipo_action.grabar:
                                Grabar();
                                break;

                            case Cl_Enumeradores.eTipo_action.actualizar:
                                Actualizar();
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

            #region"Grabar,Actualizar, Eliminar"
            private void Grabar()
            {
                try
                {                   
                    Aca_Aspirante_Info infoAsp = new Aca_Aspirante_Info();
                    negAspirante = new Aca_Aspirante_Bus();

                    decimal idAspirante = 0;
                    string mensaje = string.Empty;
                    infoAsp = GetAspirante(ref mensaje);

                    if (mensaje != "")
                    {   
                        return;
                    }
                    infoAsp.Persona_Info.pe_fechaCreacion = DateTime.Now;
                    infoAsp.UsuarioCreacion = param.IdUsuario;

                    bool resultado = negAspirante.GrabarDB(infoAsp, ref idAspirante, ref mensaje);
                    txtIdAspirante.Text = idAspirante.ToString();

                    if (resultado == true)
                    {
                        MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        Log_Error_bus.Log_Error(mensaje.ToString());
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            private void Actualizar()
            {
                try
                {
                    negAspirante = new Aca_Aspirante_Bus();
                    Aca_Aspirante_Info infoAsp = new Aca_Aspirante_Info();
                    string mensaje = string.Empty;

                    infoAsp = GetAspirante(ref mensaje);
                    if (mensaje != "")
                    {
                        MessageBox.Show(mensaje);
                        return;
                    }
                    bool resultado = negAspirante.ActualizarDB(infoAsp, ref mensaje);
                    if (resultado)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " el aspirante # : " + txtCodigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        this.ucGe_Menu.Visible_btnGuardar = false;
                    }
                    else
                    {
                        Log_Error_bus.Log_Error(mensaje.ToString());
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            private void Anular()
            {
                try
                {
                    if (infoAspirante.Estado != "I")
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) +" Aspirante # " + txtIdAspirante.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                            fr.ShowDialog();
                            string motiAnulacion = fr.motivoAnulacion;

                            negAspirante = new Aca_Aspirante_Bus();
                            Aca_Aspirante_Info infoAsp = new Aca_Aspirante_Info();
                            string mensaje = string.Empty;

                            infoAsp = GetAspirante(ref mensaje);
                            if (mensaje != "")
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                            infoAsp.MotivoAnulacion=motiAnulacion;
                            infoAsp.UsuarioAnulacion = param.IdUsuario;
                            bool resultado = negAspirante.DeleteDB(infoAsp, ref mensaje);
                            if (resultado)
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) +" el aspirante # : " + txtCodigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                                this.ucGe_Menu.Visible_btnGuardar = false;
                            }
                            else
                            {
                                Log_Error_bus.Log_Error(mensaje.ToString());
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else { MessageBox.Show("El aspirante #:" + txtIdAspirante.Text+ param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information); }                    
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

        #endregion

        #region "Validaciones"
        private Boolean validaciones()
        {
            try
            {
                if (!ValidarCedula())
                {
                    return false;
                }

                if (txtNombres.EditValue == "" || txtNombres.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " Nombre del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombres.Focus();
                    return false;
                }

                if (txtApellidos.EditValue == "" || txtApellidos.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " Apellido del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellidos.Focus();
                    return false;
                }

                if (dtFechaNacimiento.EditValue == "" || dtFechaNacimiento.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " fecha de nacimiento del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaNacimiento.Focus();
                    return false;
                }

                if (txtDireccion.EditValue == "" || txtDireccion.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_la) + " dirección del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDireccion.Focus();
                    return false;
                }

                if (txtTelefono.EditValue == "" || txtTelefono.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_el) + " teléfono del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefono.Focus();
                    return false;
                }

                return true;
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

        public bool ValidarExisteCedula(ref string mensaje)
        {
            try
            {
                Aca_Aspirante_Bus neg = new Aca_Aspirante_Bus();
                bool existe = neg.ExisteCedula(param.IdInstitucion, Convert.ToDecimal(txtIdAspirante.Text.Trim()), txtCedRuc.Text.Trim(), ref mensaje);
                return existe;
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

        Boolean ValidarCedula()
        {
            try
            {
                Cl_TipoDoc_Personales_Info info_doc_personal = new Cl_TipoDoc_Personales_Info();
                info_doc_personal = ucGe_Docu_PerIdentificacion.get_TipoDoc_Personales();
                tb_persona_bus tbPersona = new tb_persona_bus();
                string msj = "";

                if (info_doc_personal.codigo == "CED")
                {
                    if (this.txtCedRuc.Text != "")
                    {
                        if (txtCedRuc.Text.TrimStart().TrimEnd().Length != 10)
                        {
                            MessageBox.Show("Cédula Incorrecta", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txtCedRuc.Text, ref msj))
                        {
                            MessageBox.Show(msj, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite la Cedula", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                }
                else if (info_doc_personal.codigo == "RUC")
                {

                    if (txtCedRuc.Text != "")
                    {
                        if (txtCedRuc.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("RUC Incorrecto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (txtCedRuc.Text.TrimStart().TrimEnd().Length != 13)
                        {


                            MessageBox.Show("RUC Incorrecto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txtCedRuc.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite Ruc", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
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

        public void LimpiarPantalla() {
            txtApellidos.Text = string.Empty;
            txtBarrio.Text = string.Empty;
            txtCedRuc.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLugar.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtNroCelular.Text = string.Empty;
            txtTelefono.Text=string.Empty;
        }

        #endregion

        #region "Evento"
        void FrmAcaAspirante_Mant_event_FrmAcaAspirante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              //  event_FrmAcaAspirante_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
   
        private void FrmAcaAspirante_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                CargarCombos();
                CargarDatosAspirante();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        this.chkActivo.Checked = true;
                        LimpiarPantalla();
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void txtCedRuc_Leave(object sender, EventArgs e)
        {
            try
            {
                // Validar que cedula del estudiante no existe en la tabla estudiante
                string mensaje = string.Empty;
                if (ValidarExisteCedula(ref mensaje))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedRuc.Focus();
                }
                else
                {
                    ObtenerDatosAspirante_x_Cedula();
                    if (infoAspirante.IdAspirante != 0)
                    {
                        CargarDatosAspirante();
                    }
                    else
                    {
                        MessageBox.Show("No existen datos, favor ingresar datos del aspirante");
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

        private void txtCedRuc_Enter(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    if (!String.IsNullOrEmpty(txtCedRuc.Text))
                    {
                        txtCedRuc.Properties.MaxLength = 10;
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 10);
                    }
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {
                    if (!String.IsNullOrEmpty(txtCedRuc.Text))
                    {
                        txtCedRuc.Properties.MaxLength = 13;
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 13);
                    }
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                {
                    if (!String.IsNullOrEmpty(txtCedRuc.Text))
                    {
                        txtCedRuc.Properties.MaxLength = 20;
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

        private void txtCedRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
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

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
        }
       
        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            guardarDatos(); 
            Close();
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {            
            Anular();
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAcaAspirante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaAspirante_Mant_FormClosing(sender, e);
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
