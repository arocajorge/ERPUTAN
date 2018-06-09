using Core.Erp.Business.General;
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
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Academico
{
    public partial class FrmAcaProfesor_Mant : Form
    {
        #region "Variable"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Aca_Profesor_Info profesorInfo = new Aca_Profesor_Info();

        public delegate void delegate_FrmAcaProfesro_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaProfesro_Mant_FormClosing event_FrmAcaProfesir_Mant_FormClosing;        
        
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Profesor(Aca_Profesor_Info info)
        {
            try
            {
                profesorInfo = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public Aca_Profesor_Info Get_Profesor(ref string mensaje) {
            try
            {
                //profesorInfo = new Aca_Profesor_Info();
                profesorInfo.IdProfesor = string.IsNullOrEmpty(txtIdProfesor.Text) ? 0 : Convert.ToDecimal(txtIdProfesor.Text);
                profesorInfo.IdInstitucion = param.IdInstitucion;
                profesorInfo.CodProfesor = string.IsNullOrEmpty( txtCodigoProfesor.Text.Trim())?profesorInfo.IdProfesor.ToString():txtCodigoProfesor.Text.Trim();
                profesorInfo.Persona_Info.IdPersona = Convert.ToDecimal(lblIdPersonaTxt.Text);
                profesorInfo.Persona_Info.pe_cedulaRuc = txtCedula.Text.Trim();
                profesorInfo.Persona_Info.pe_apellido = txtApellidos.Text.Trim();
                profesorInfo.Persona_Info.pe_nombre = txtNombres.Text.Trim();
                profesorInfo.Persona_Info.pe_nombreCompleto = txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();
                profesorInfo.Persona_Info.IdTipoDocumento = ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString();                
                profesorInfo.Persona_Info.IdTipoPersona = 7;
                profesorInfo.Persona_Info.pe_cedulaRuc = txtCedula.Text.Trim();
                profesorInfo.Persona_Info.pe_Naturaleza = "NATU";
                profesorInfo.Persona_Info.IdEstadoCivil = "SOLTE";
                profesorInfo.Persona_Info.pe_celular = string.Empty;
                profesorInfo.Persona_Info.pe_celularSecundario = string.Empty;
                profesorInfo.Persona_Info.pe_direccion = string.Empty;
                profesorInfo.Persona_Info.pe_correo = string.Empty;
                profesorInfo.Persona_Info.pe_fechaCreacion = DateTime.Now;
                profesorInfo.Persona_Info.pe_fechaModificacion = DateTime.Now;
                profesorInfo.Persona_Info.pe_fechaNacimiento = null;
                profesorInfo.Persona_Info.pe_sexo = rgSexo.EditValue.ToString();
                profesorInfo.Persona_Info.pe_telefonoCasa = string.Empty;
                profesorInfo.Persona_Info.pe_telefonoInter = string.Empty;
                profesorInfo.Persona_Info.pe_telefonoOfic = string.Empty;
                profesorInfo.Persona_Info.pe_UltUsuarioModi = param.IdUsuario;
                profesorInfo.Persona_Info.pe_estado = "A";
                profesorInfo.UsuarioCreacion = param.IdUsuario;
                profesorInfo.UsuarioModificacion = param.IdUsuario;
                profesorInfo.UsuarioAnulacion = param.IdUsuario;
                profesorInfo.Base = lblBase.Text.Trim();

                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    chkEstado.Checked = true;
                }

                profesorInfo.estado = (chkEstado.Checked == true) ? "A" : "I";
                if (chkEstado.Checked)
                {
                    lblAnulado.Visible = false;
                }
                else { lblAnulado.Visible = true; }
            }
            catch (Exception)
            {
                return new Aca_Profesor_Info();
            }
            return profesorInfo;
        }
        #endregion

        #region "CargarDatos"
        public void CargarDatos() {
            try
            {
                txtIdProfesor.Text = "0";

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    txtIdProfesor.Text = profesorInfo.IdProfesor.ToString();                    
                }

                txtCodigoProfesor.Text = profesorInfo.CodProfesor;
                lblIdPersonaTxt.Text = profesorInfo.Persona_Info.IdPersona.ToString();
                txtCedula.Text = profesorInfo.Persona_Info.pe_cedulaRuc;
                txtNombres.Text = profesorInfo.Persona_Info.pe_nombre;
                txtApellidos.Text = profesorInfo.Persona_Info.pe_apellido;
                chkEstado.Checked = (profesorInfo.estado == "A") ? true : false;
                rgSexo.EditValue = (profesorInfo.Persona_Info.pe_sexo == null) ? "SEXO_MAS" : profesorInfo.Persona_Info.pe_sexo;
                ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue = (profesorInfo.Persona_Info.IdTipoDocumento == null) ? "CED" : profesorInfo.Persona_Info.IdTipoDocumento;
                lblBase.Text = profesorInfo.Base;

                if (profesorInfo.estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (profesorInfo.estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
        #endregion

        #region "Proceso"
        public void Grabar()
        {
            try
            {
                Aca_Profesor_Info profInfo = new Aca_Profesor_Info();

                string mensaje = string.Empty;
                decimal id = 0;

                profInfo = Get_Profesor(ref mensaje);
                Aca_Profesor_Bus neg = new Aca_Profesor_Bus();
                bool resultado = neg.GrabarDB(profInfo, ref id, ref mensaje);

                txtIdProfesor.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, " Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
                MessageBox.Show(ex.Message, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Actualizar()
        {
            try
            {
                Aca_Profesor_Bus neg = new Aca_Profesor_Bus();
                Aca_Profesor_Info profInfo = new Aca_Profesor_Info();
                string mensaje = string.Empty;

                profInfo = Get_Profesor(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = neg.ActualizarDB(profInfo, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                    this.ucGe_Menu.Visible_btnGuardar = false;
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Anular()
        {
            try
            {
                string mensaje = string.Empty;

                if (profesorInfo.estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Profesor # " + txtIdProfesor.Text.Trim() + " ?", "Anulación de Mantenimiento Profesor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = fr.motivoAnulacion;

                        Aca_Profesor_Bus neg = new Aca_Profesor_Bus();
                        Aca_Profesor_Info profInfo = new Aca_Profesor_Info();                       

                        profInfo = Get_Profesor(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        profInfo.MotivoAnulacion = motiAnulacion;
                        profInfo.FechaAnulacion = DateTime.Now;
                        bool resultado = neg.DeleteDB(profInfo, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else {
                    MessageBox.Show("El Profesor "+ txtIdProfesor.Text.Trim()+" ya se encuentra anulado " , "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        public bool validaciones()
        {
            try
            {
                if (!ValidarCedula())
                {
                    return false;
                }

                if (string.IsNullOrEmpty(txtNombres.Text))
                {
                    MessageBox.Show("Digite Nombre Profesor", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombres.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtApellidos.Text))
                {
                    MessageBox.Show("Digite Apellido Profesor", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtApellidos.Focus();
                    return false;
                }
        
                return true;
            }
            catch (Exception)
            {
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
                    if (this.txtCedula.Text != "")
                    {
                        if (txtCedula.Text.TrimStart().TrimEnd().Length != 10)
                        {
                            MessageBox.Show("Cédula Incorrecta", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txtCedula.Text, ref msj))
                        {
                            MessageBox.Show(msj, "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite la Cedula", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }

                }
                else if (info_doc_personal.codigo == "RUC")
                {

                    if (txtCedula.Text != "")
                    {
                        if (txtCedula.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("RUC Incorrecto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (txtCedula.Text.TrimStart().TrimEnd().Length != 13)
                        {


                            MessageBox.Show("RUC Incorrecto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txtCedula.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite Ruc", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        public void LimpiarCampos() {
            lblBase.Text = string.Empty;
            txtCodigoProfesor.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            lblIdPersonaTxt.Text = string.Empty;
            txtCedula.Text = string.Empty;
        }

        #endregion

        #region "Eventos"
        public FrmAcaProfesor_Mant()
        {
            InitializeComponent();
            LimpiarCampos();
            event_FrmAcaProfesir_Mant_FormClosing += FrmAcaProfesor_Mant_event_FrmAcaProfesir_Mant_FormClosing;
        }

        void FrmAcaProfesor_Mant_event_FrmAcaProfesir_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAcaProfesor_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaProfesir_Mant_FormClosing(sender, e);   
            }
            catch (Exception)
            {
                
                throw;
            }
        }
     
        private void FrmAcaProfesor_Mant_Load(object sender, EventArgs e)
        {
            CargarDatos();

            switch (Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    ucGe_Menu.Enabled_bntAnular = false;
                    ucGe_Menu.Enabled_bntImprimir = false;
                    this.chkEstado.Checked = true;
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

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
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

        private void lblCedula_Click(object sender, EventArgs e)
        {

        }

        private void txtCedula_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            // Validar que cedula del estudiante no existe en la tabla estudiante
            string mensaje = string.Empty;
            bool proceder = false;
            // Busca en la tabla persona y admision la cedula y traigo toda la información para mostrar en pantalla
            proceder = BuscarProfesor(ref mensaje);
            if (proceder)
            {
                CargarDatos();
            }
            else
            {
                if (!string.IsNullOrEmpty(mensaje))
                {                    
                    MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCedula.Focus();
                }
            }      
        }

        public bool BuscarProfesor(ref string mensaje)
        {

            bool proceder = false;
            
            try
            {
                Aca_Profesor_Bus neg = new Aca_Profesor_Bus();
                profesorInfo = neg.Get_Profesor_Info(txtCedula.Text.Trim());
                if (profesorInfo.Persona_Info.IdPersona!=null && profesorInfo.Base=="N")
                {
                    return true;
                }
                if (profesorInfo.Base=="S")
                {
                    mensaje = "La cédula " + txtCedula.Text.Trim() + " ya se encuentra ingresada como Profesor";
                }              
            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
                MessageBox.Show(mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            return proceder;
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    txtCedula.Properties.MaxLength = 10;
                    txtCedula.Text = txtCedula.Text.Substring(0, 10);
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {
                    txtCedula.Properties.MaxLength = 13;
                    txtCedula.Text = txtCedula.Text.Substring(0, 13);
                }
                if (ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                {
                    txtCedula.Properties.MaxLength = 20;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.ValidaNumero(e.KeyChar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion
    }
}
