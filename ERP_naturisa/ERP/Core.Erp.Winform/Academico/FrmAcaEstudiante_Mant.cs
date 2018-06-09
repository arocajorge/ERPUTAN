using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Core.Erp.Business.Academico;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
//using Core.Erp.General;
using System.IO;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Recursos.Properties;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaEstudiante_Mant : DevExpress.XtraEditors.XtraForm
    {


        #region Variables

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string MensajeError = "";
        private Funciones func = new Funciones();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action Accion;
        Aca_Estudiante_Bus busEstudiante = new Aca_Estudiante_Bus();
        
        public delegate void delegate_FrmAcaEstudiante_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaEstudiante_Mant_FormClosing event_FrmAcaEstudiante_Mant_FormClosing;
        
        Aca_Estudiante_Bus negEstudiante = new Aca_Estudiante_Bus();
        public  Aca_Estudiante_Info infoEstudiante = new Aca_Estudiante_Info();
    
        Aca_ficha_medica_Info infoFichaMed = new Aca_ficha_medica_Info();
        Aca_ficha_medica_Bus negFichaMed = new Aca_ficha_medica_Bus();
        
        List<Aca_Familiar_Info> Lista_familiares_x_estudiante = new List<Aca_Familiar_Info>();
        Aca_Familiar_Info infoFamiliar = new Aca_Familiar_Info();

        Aca_Familiar_Bus BusFamiliar_x_Estudiante = new Aca_Familiar_Bus();
        BindingList<Aca_Estudiante_x_Alergia_Info> listaAlergias = new BindingList<Aca_Estudiante_x_Alergia_Info>();
        #endregion

        #region "Constructor"
        public FrmAcaEstudiante_Mant()
        {
            InitializeComponent();
            event_FrmAcaEstudiante_Mant_FormClosing += FrmAcaEstudiante_Mant_event_FrmAcaEstudiante_Mant_FormClosing;
        }
        #endregion

        #region "Eventos"
        void FrmAcaEstudiante_Mant_event_FrmAcaEstudiante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        
        private void FrmAcaEstudiante_Mant_Load(object sender, EventArgs e)
        {
            try
            {
            CargarCombos();
            CargarDatosEstudiante();
            CargarAlergiasEstudiante();

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    chkActivo.Checked = true;
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    InicializarMetodos();                

                    break;
                case Cl_Enumeradores.eTipo_action.Anular:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    InicializarMetodos();
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                    ucGe_Menu.Enabled_btnGuardar = false;
                    ucGe_Menu.Enabled_bntAnular = false;
                    InicializarMetodos();
                    break;
            }

            cargarFormularios();

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

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
            bool resultado = guardarDatos();
            if (resultado)
            {
                Close();
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();

        }

        private void txtCedRuc_Enter(object sender, EventArgs e)
        {
            if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "CED")
            {
                txtCedRuc.Properties.MaxLength = 10;
                if (txtCedRuc.Text.Length >= 10)
                {
                    txtCedRuc.Text = txtCedRuc.Text.Substring(0, 10);
                }
            }
            if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
            {
                txtCedRuc.Properties.MaxLength = 13;
                if (txtCedRuc.Text.Length >= 13)
                {
                    txtCedRuc.Text = txtCedRuc.Text.Substring(0, 13);
                }
            }
            if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
            {
                if (txtCedRuc.Text.Length >= 20)
                {
                    txtCedRuc.Properties.MaxLength = 20;
                }
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

        private void txtCedRuc_Leave(object sender, EventArgs e)
        {
             try
            {
            // Validar que cedula del estudiante no existe en la tabla estudiante
            bool existePersona = false;
            string mensaje = string.Empty;
            if (txtCedRuc.Text.Trim() != "")
            {
                if (ValidarExisteCedula(ref mensaje))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedRuc.Focus();
                }
                else
                {

                    bool validar = ValidarCedula();
                    if (!validar)
                    {
                        txtCedRuc.Focus();
                    }
                    else
                    {


                        BuscarFamiliar_x_Cedula();
                    }

                }
            }
            else
            { LimpiarControles(); 
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

        private void FrmAcaEstudiante_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaEstudiante_Mant_FormClosing(sender, e);
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

        private void txtCedRuc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    txtCedRuc.Properties.MaxLength = 10;
                    if (txtCedRuc.Text.Length >= 10)
                    {
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 10);
                    }
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {

                    txtCedRuc.Properties.MaxLength = 13;
                    if (txtCedRuc.Text.Length >= 13)
                    {
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 13);
                    }
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                {
                    if (txtCedRuc.Text.Length >= 20)
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

                        if  (string.IsNullOrEmpty(txtNombres.Text.ToString()))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Nombre del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtNombres.Focus();
                                return false;
                            }

                        if (string.IsNullOrEmpty(txtApellidos.Text.ToString()))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Apellido del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtApellidos.Focus();
                                return false;
                            }

                        if  (string.IsNullOrEmpty(dtFechaNacimiento.EditValue.ToString()))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha de nacimiento del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dtFechaNacimiento.Focus();
                            return false;
                        }

                        if (string.IsNullOrEmpty( txtDireccion.Text.ToString()))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " dirección del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtDireccion.Focus();
                            return false;
                        }

                        if (string.IsNullOrEmpty(txtTelefono.Text.ToString()))
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " teléfono del Estudiante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            private bool ValidarExisteCedula(ref string mensaje)
            {
                try
                {
                    bool existe = false;
                    if (string.IsNullOrEmpty(txtIdEstudiante.Text.Trim()) && txtIdEstudiante.Text.Trim() != string.Empty )
                    {
                     existe = negEstudiante.ExisteCedula(param.IdInstitucion,Convert.ToDecimal(txtIdEstudiante.Text.Trim()), txtCedRuc.Text.Trim(), ref mensaje);
                   
                    }
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

            private void ObtenerDatosEstudiante_x_Cedula() {
                try
                {
                    tb_persona_bus neg = new tb_persona_bus();
                    tb_persona_Info infoPersona = new tb_persona_Info();
                    infoPersona = neg.Get_Info_Persona(txtCedRuc.Text.Trim());
                    infoEstudiante.IdInstitucion = param.IdInstitucion;
                    infoEstudiante.IdEstudiante = Convert.ToDecimal( txtIdEstudiante.Text);
                    infoEstudiante.Persona_Info.IdPersona = infoPersona.IdPersona;
                    infoEstudiante.Persona_Info.pe_nombre = infoPersona.pe_nombre;
                    infoEstudiante.Persona_Info.pe_apellido = infoPersona.pe_apellido;
                    infoEstudiante.Persona_Info.pe_cedulaRuc = infoPersona.pe_cedulaRuc;
                    infoEstudiante.Persona_Info.pe_fechaNacimiento = infoPersona.pe_fechaNacimiento;
                    infoEstudiante.Persona_Info.pe_correo = infoPersona.pe_correo;
                    infoEstudiante.Persona_Info.pe_direccion = infoPersona.pe_direccion;
                    infoEstudiante.Persona_Info.pe_sexo = infoPersona.pe_sexo;
                    infoEstudiante.Persona_Info.pe_telefonoCasa = infoPersona.pe_telefonoCasa;
                    infoEstudiante.Persona_Info.IdTipoDocumento = infoPersona.IdTipoDocumento;
                    infoEstudiante.Persona_Info.pe_celular = infoPersona.pe_celular;
                    infoEstudiante.Persona_Info.pe_estado = infoPersona.pe_estado;
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
                            MessageBox.Show("Digite la Cedula",param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            private void LimpiarControles()
            {
                try
                {
                    lblIdPersona.Text = string.Empty;
                    //txtCedRuc.Text = string.Empty;
                    dtFechaNacimiento.DateTime = DateTime.Now;
                    txtLugar.Text = string.Empty;
                    cmbNacionalidad.SelectedValue = "1";
                    cmbNacionalidad2.SelectedValue = "1";
                    cmbNacionalidad3.SelectedValue = "1";
                    txtDireccion.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                    txtBarrio.Text = string.Empty;
                    txtNroCelular.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtIdEstudiante.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                    this.txtApellidos.Text = string.Empty;
                    this.txtNombres.Text = string.Empty;
                    txtSeguroMedico.Text = string.Empty;
                    cmb_GrupoSanguineo.EditValue = null;
                    meOtrasIndicaciones.Text = string.Empty;
                    meMedicamentosContraindicados.Text = string.Empty;
                    ucAca_Familiar_x_EstudianteRepLegal.LimpiarControles();
                    ucAca_Familiar_x_EstudianteRepEcono.LimpiarControles();
                    ucAca_Familiar_x_EstudianteMadre.LimpiarControles();
                    ucAca_Familiar_x_EstudiantePadre.LimpiarControles();
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

            private void BuscarFamiliar_x_Cedula()
            {
                try
                {
                    bool existePersona = false;
                    string msj = string.Empty;

                    Aca_Familiar_Bus neg = new Aca_Familiar_Bus();


                    infoFamiliar = new Aca_Familiar_Info();
                    if (txtIdEstudiante.Text == string.Empty) // esto es para el ingreso de un estudiante
                    {
                        infoFamiliar = neg.GetFamiliar_x_Estudiante(txtCedRuc.Text.Trim(), ref existePersona);
                    }
                    else
                    {
                        infoFamiliar = neg.GetFamiliar_x_Estudiante(Convert.ToDecimal(txtIdEstudiante.EditValue), txtCedRuc.Text.Trim(), ref existePersona);
                    }

                    if (existePersona)
                    {

                        txtApellidos.Text = infoFamiliar.Persona_Info.pe_apellido;
                        txtNombres.Text = infoFamiliar.Persona_Info.pe_nombre;                       
                        txtNroCelular.Text = infoFamiliar.Persona_Info.pe_celular;
                        txtTelefono.Text = infoFamiliar.Persona_Info.pe_telefonoCasa;
                        txtDireccion.Text = infoFamiliar.Persona_Info.pe_direccion;
                        txtEmail.Text = infoFamiliar.Persona_Info.pe_correo;
                        dtFechaNacimiento.EditValue = (infoFamiliar.Persona_Info.pe_fechaNacimiento.ToString() == null) ? DateTime.Now.ToShortDateString() : infoFamiliar.Persona_Info.pe_fechaNacimiento.ToString();
                        rgSexo.EditValue = (infoFamiliar.Persona_Info.pe_sexo == null) ? "SEXO_MAS" : infoFamiliar.Persona_Info.pe_sexo;
                        lblIdPersona.Text = infoFamiliar.Persona_Info.IdPersona.ToString();
                        chkActivo.Checked = (infoFamiliar.Persona_Info.pe_estado == "A") ? true : false;
                       
                       
                    }
                    //else
                    //{
                    //    LimpiarControles(); txtNombres.Focus();
                       
                    //}

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

            private void cargarFormularios()
            {
                try
                {
                    foreach (DevExpress.XtraTab.XtraTabPage item in xtraTabEstudiante.TabPages)
                    {
                        xtraTabEstudiante.SelectedTabPage = item;
                    }
                    xtraTabEstudiante.SelectedTabPageIndex = 0;
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

        #region "Proceso"   

        void InicializarMetodos()
        {
            try
            {

           
            set_FichaMedica(infoEstudiante.IdEstudiante);
            CargarDatosFichaMedica();

            //Lista_familiares_x_estudiante = BusFamiliar_x_Estudiante.Get_List_Familiar_x_Estudiante(infoEstudiante.IdInstitucion, infoEstudiante.IdEstudiante);
            if (Lista_familiares_x_estudiante.Count != 0)
            {
                infoFamiliar = Lista_familiares_x_estudiante.Find(v => v.IdParentescoCat == "MADR");
                ucAca_Familiar_x_EstudianteMadre.IdEstudiante = infoEstudiante.IdEstudiante;
                ucAca_Familiar_x_EstudianteMadre.Set_Info_Datos_Familiar(infoFamiliar);

                infoFamiliar = Lista_familiares_x_estudiante.Find(v => v.IdParentescoCat == "PADR");
                ucAca_Familiar_x_EstudiantePadre.IdEstudiante = infoEstudiante.IdEstudiante;
                ucAca_Familiar_x_EstudiantePadre.Set_Info_Datos_Familiar(infoFamiliar);

                infoFamiliar = Lista_familiares_x_estudiante.Find(v => v.IdParentescoCat == "REP_ECO");
                ucAca_Familiar_x_EstudianteRepEcono.IdEstudiante = infoEstudiante.IdEstudiante;
                ucAca_Familiar_x_EstudianteRepEcono.Set_Info_Datos_Familiar(infoFamiliar);

                infoFamiliar = Lista_familiares_x_estudiante.Find(v => v.IdParentescoCat == "REP_LEGAL");
                ucAca_Familiar_x_EstudianteRepLegal.IdEstudiante = infoEstudiante.IdEstudiante;
                ucAca_Familiar_x_EstudianteRepLegal.Set_Info_Datos_Familiar(infoFamiliar);
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

        public void CargarCombos()
        {
            try
            {

            tb_pais_Bus neg = new tb_pais_Bus();
            //carda combo 1
            cmbNacionalidad.DataSource = neg.Get_List_pais();
            cmbNacionalidad.SelectedValue = "1";
            //carda combo 2
            cmbNacionalidad2.DataSource = neg.Get_List_pais();
            cmbNacionalidad2.SelectedValue = "1";
            //carda combo 3
            cmbNacionalidad3.DataSource = neg.Get_List_pais();
            cmbNacionalidad3.SelectedValue = "1";
            
            Aca_Catalogo_Bus negc = new Aca_Catalogo_Bus();
            this.cmb_GrupoSanguineo.Properties.DataSource = negc.Get_List_CatalogoXtipo("GRUP_SAN");
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
        public void CargarAlergiasEstudiante()
        {
            try
            {            
            Aca_estudiante_x_Alergia_Bus neg = new Aca_estudiante_x_Alergia_Bus();
            this.gcAlergia.DataSource = null;
            listaAlergias = new BindingList<Aca_Estudiante_x_Alergia_Info>(neg.Get_List_estudiante_x_Alergia(param.IdInstitucion, infoEstudiante.IdEstudiante));
            this.gcAlergia.DataSource = listaAlergias;
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

        public void set_Estudiante(Aca_Estudiante_Info info)
        {
            try
            {
                infoEstudiante = info;
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

        private void set_FichaMedica(decimal IdEstudiante)
        {
            try
            {
                negFichaMed = new Aca_ficha_medica_Bus();
                infoFichaMed = negFichaMed.Get_ficha_medica(param.IdInstitucion, IdEstudiante);

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
             
        #region "Carga Datos"
        private void CargarDatosFichaMedica()
        {
            try
            {

            meMedicamentosContraindicados.Text = infoFichaMed.MedicaContraIndic;
            meOtrasIndicaciones.Text = infoFichaMed.OtrasIndicacionesMedicas;
            cmb_GrupoSanguineo.EditValue = infoFichaMed.GrupoSanguineoCatalogo;
            txtSeguroMedico.Text = infoFichaMed.SeguroMedico;
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

        private void CargarDatosEstudiante()
        {
            try
            {
                txtIdEstudiante.Text = Convert.ToString(infoEstudiante.IdEstudiante);                
                txtCodigo.Text = infoEstudiante.cod_estudiante;
                txtCodigo2.Text = infoEstudiante.cod_estudiante2;

                txtApellidos.Text = infoEstudiante.Persona_Info.pe_apellido;
                txtNombres.Text = infoEstudiante.Persona_Info.pe_nombre;
                txtLugar.Text = infoEstudiante.lugar;
                txtNroCelular.Text = infoEstudiante.Persona_Info.pe_celular;
                txtTelefono.Text = infoEstudiante.Persona_Info.pe_telefonoCasa;
                txtDireccion.Text = infoEstudiante.Persona_Info.pe_direccion;
                txtEmail.Text = infoEstudiante.Persona_Info.pe_correo;
                txtBarrio.Text = infoEstudiante.barrio;
                txtCedRuc.Text = infoEstudiante.Persona_Info.pe_cedulaRuc;
                ucGe_Docu_PerIdentificacion.set_TipoDoc_Personales(infoEstudiante.Persona_Info.IdTipoDocumento);// == null) ? "CED" : infoEstudiante.Persona_Info.IdTipoDocumento;
                cmbNacionalidad.SelectedValue = (infoEstudiante.Pais_Info.IdPais == null) ? "1" : infoEstudiante.Pais_Info.IdPais;
                cmbNacionalidad2.SelectedValue = (infoEstudiante.Pais_Info.IdPais == null) ? "1" : infoEstudiante.Pais_Info.IdPais;
                cmbNacionalidad3.SelectedValue = (infoEstudiante.Pais_Info.IdPais == null) ? "1" : infoEstudiante.Pais_Info.IdPais;
                dtFechaNacimiento.EditValue = (infoEstudiante.Persona_Info.pe_fechaNacimiento.ToString() == null) ? DateTime.Now.ToShortDateString() : infoEstudiante.Persona_Info.pe_fechaNacimiento.ToString();
                rgSexo.EditValue = (infoEstudiante.Persona_Info.pe_sexo == null) ? "SEXO_MAS" : infoEstudiante.Persona_Info.pe_sexo;
                lblIdPersona.Text = infoEstudiante.Persona_Info.IdPersona.ToString();
                chkActivo.Checked = (infoEstudiante.Persona_Info.pe_estado == "A") ? true : false;
                if (infoEstudiante.Persona_Info.pe_estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (infoEstudiante.Persona_Info.pe_estado != null)
                    {
                        lblAnulado.Visible = true;    
                    }                    
                }

                Lista_familiares_x_estudiante = BusFamiliar_x_Estudiante.Get_List_Familiar_x_Estudiante(infoEstudiante.IdInstitucion, infoEstudiante.IdEstudiante);                
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
        private Aca_Estudiante_Info GetEstudiante(ref string mensaje)
        {
            infoEstudiante = new Aca_Estudiante_Info();

            try
            {
                infoEstudiante.IdEstudiante = (txtIdEstudiante.Text == null || txtIdEstudiante.Text.Trim() == "") ? 0 : Convert.ToDecimal(txtIdEstudiante.Text.Trim());
                infoEstudiante.cod_estudiante = (txtCodigo.Text == null || txtCodigo.Text.Trim() == "") ? txtIdEstudiante.Text.Trim() : txtCodigo.Text.Trim();
                infoEstudiante.cod_estudiante2 = (txtCodigo2.Text == null || txtCodigo2.Text.Trim() == "") ? "" : txtCodigo2.Text.Trim();
                infoEstudiante.IdInstitucion = param.IdInstitucion;
                infoEstudiante.lugar = txtLugar.Text.Trim();
                infoEstudiante.barrio = txtBarrio.Text.Trim();
                if(chkActivo.Checked == true)
                infoEstudiante.estado = "A";
                infoEstudiante.FechaModificacion = DateTime.Now;
                infoEstudiante.UsuarioModificacion = param.IdUsuario;
                infoEstudiante.cod_alterno = "";

                tb_persona_Info infoPersona = new tb_persona_Info();
                infoPersona.IdEmpresa = param.IdEmpresa;
                infoPersona.IdPersona = (lblIdPersona.Text == null || lblIdPersona.Text.Trim() == "") ? 0 : Convert.ToDecimal(lblIdPersona.Text.Trim());
                //infoPersona.CodPersona = (txtCodigo.Text == null || txtCodigo.Text.Trim() == "") ? "" : txtCodigo.Text.Trim();
                infoPersona.IdTipoDocumento = ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString();
                infoPersona.pe_cedulaRuc = this.txtCedRuc.Text.Trim();
                infoPersona.pe_nombre = this.txtNombres.Text.Trim();
                infoPersona.pe_apellido = this.txtApellidos.Text.Trim();
                infoPersona.pe_nombreCompleto = this.txtNombres.Text.Trim() + " " + this.txtApellidos.Text.Trim();
                infoPersona.pe_Naturaleza = "NATU";                                     
                infoPersona.IdEstadoCivil = "SOLTE";
                infoPersona.IdTipoPersona = 5; // Estudiante

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
                tb_pais_Info infoPais2 = new tb_pais_Info();
                tb_pais_Info infoPais3 = new tb_pais_Info();
                infoPais.IdPais = cmbNacionalidad.SelectedValue.ToString();
                infoPais2.IdPais = cmbNacionalidad2.SelectedValue.ToString();
                infoPais3.IdPais = cmbNacionalidad3.SelectedValue.ToString();
                //carga la informacion de los combos
                infoEstudiante.Persona_Info = infoPersona;
                infoEstudiante.Pais_Info = infoPais;
                infoEstudiante.Pais_Info2 = infoPais2;
                infoEstudiante.Pais_Info3 = infoPais3;

                infoEstudiante.FichaMedica_Info = GetFichaMedica();
                infoEstudiante.listaFamiliar = GetFamiliarEstudiante(ref mensaje);              
                // Alergia
                BindingList<Aca_Estudiante_x_Alergia_Info> listaAlergias1 = new BindingList<Aca_Estudiante_x_Alergia_Info>();
                foreach (var item in listaAlergias)
                {
                    if (item.Activo == true)
                    {
                        
                        listaAlergias1.Add(item);
                        
                    }

                }
                infoEstudiante.listaAlergias = new List<Aca_Estudiante_x_Alergia_Info>(listaAlergias1);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return infoEstudiante;
        }

        public Aca_ficha_medica_Info GetFichaMedica()
        {
            try
            {
                infoFichaMed = new Aca_ficha_medica_Info();
                infoFichaMed.IdInstitucion = infoEstudiante.IdInstitucion;
                infoFichaMed.IdEstudiante = infoEstudiante.IdEstudiante;
                infoFichaMed.SeguroMedico = txtSeguroMedico.Text.Trim();
                infoFichaMed.MedicaContraIndic = meMedicamentosContraindicados.Text.Trim();
                infoFichaMed.OtrasIndicacionesMedicas = meOtrasIndicaciones.Text.Trim();
                infoFichaMed.GrupoSanguineoCatalogo = (cmb_GrupoSanguineo.EditValue == null) ? "O+" : cmb_GrupoSanguineo.EditValue.ToString();
                return infoFichaMed;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return infoFichaMed;
            }
        }

        public List<Aca_Familiar_Info> GetFamiliarEstudiante(ref string mensaje) {            
            try
            {
                UCAca_Familiar_x_Estudiante ucFami = new UCAca_Familiar_x_Estudiante();
                Lista_familiares_x_estudiante = new List<Aca_Familiar_Info>();

                ucFami.IdParentestoFamiliar="MADR";
                infoFamiliar = ucAca_Familiar_x_EstudianteMadre.Get_Info_Datos_Familiar(ref mensaje);
                Lista_familiares_x_estudiante.Add(infoFamiliar);

                if (mensaje==string.Empty)
                {
                    ucFami.IdParentestoFamiliar = "PADR";
                    infoFamiliar = ucAca_Familiar_x_EstudiantePadre.Get_Info_Datos_Familiar(ref mensaje);
                    Lista_familiares_x_estudiante.Add(infoFamiliar);

                    if (mensaje == string.Empty)
                    {
                        ucFami.IdParentestoFamiliar = "REP_ECO";
                        infoFamiliar = ucAca_Familiar_x_EstudianteRepEcono.Get_Info_Datos_Familiar(ref mensaje);                        
                        Lista_familiares_x_estudiante.Add(infoFamiliar);
                        if (mensaje == string.Empty)
                        {
                            ucFami.IdParentestoFamiliar = "REP_LEGAL";
                            infoFamiliar = ucAca_Familiar_x_EstudianteRepLegal.Get_Info_Datos_Familiar(ref mensaje);                             
                            Lista_familiares_x_estudiante.Add(infoFamiliar);                             
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
            return Lista_familiares_x_estudiante;
        }

        #endregion
     
        #region "Insert,Update,Delete"

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
                            resultado = GrabarEstudiante();
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            resultado =  Actualizar();
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            resultado = Anular();
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
            return resultado;
        }

        private bool GrabarEstudiante()
        {
            try
            {
                negEstudiante = new Aca_Estudiante_Bus();
                Aca_Estudiante_Info infoEst = new Aca_Estudiante_Info();
                
                decimal id = 0;
                string mensaje = string.Empty;
                infoEst = GetEstudiante(ref mensaje);

                if (mensaje!="")
                {
                     MessageBox.Show(mensaje);
                     return false;
                }
                infoEst.Persona_Info.pe_fechaCreacion = DateTime.Now;
                infoEst.UsuarioCreacion = param.IdUsuario;

                bool resultado = negEstudiante.GrabarDB(infoEst, ref id, ref mensaje);
                txtIdEstudiante.Text = id.ToString();
                
                if (resultado == true)
                {
                    MessageBox.Show( param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente)+ " el estudiante # : " + id, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    //this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    //this.ucGe_Menu.Visible_btnGuardar = false;
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        private bool Actualizar()
        {
            try
            {
                negEstudiante = new Aca_Estudiante_Bus();
                Aca_Estudiante_Info infoEst = new Aca_Estudiante_Info();
                string mensaje = string.Empty;

                infoEst = GetEstudiante(ref mensaje);
                if (mensaje!="")
                {
                      MessageBox.Show(mensaje);
                      return false;
                }
                bool resultado = negEstudiante.ActualizarDB(infoEst, ref mensaje);
                if (resultado)
                {
                    
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) +" el estudiante # : " + txtCodigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    return true;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
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

        private bool Anular()
        {
            try
            {
                bool resultado = false;
                if (infoEstudiante.estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular_el) + " Estudiante #:" + txtIdEstudiante.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        negEstudiante = new Aca_Estudiante_Bus();
                        infoEstudiante.UsuarioAnulacion = param.IdUsuario;
                        infoEstudiante.MotivoAnulacion = fr.motivoAnulacion;
                        infoEstudiante.FechaAnulacion = DateTime.Now;
                        resultado = negEstudiante.DeleteDB(Lista_familiares_x_estudiante,infoEstudiante, ref MensajeError);
                        if (resultado)
                        {
                           
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente) + "el estudiante # : " + txtCodigo.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);    
                         
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(MensajeError.ToString());
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + ":" + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                }
                else {
                    MessageBox.Show("El Estudiante #:" + txtIdEstudiante.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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

        
    }
}