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
    public partial class FrmAcaAdmision_Mant : Form
    {
        #region "Variables"
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Aca_Admision_Info admisionInfo = new Aca_Admision_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_persona_bus neg = new tb_persona_bus();
        tb_persona_Info infoPersona = new tb_persona_Info();
        Aca_Aspirante_Info AspiranteInfo = new Aca_Aspirante_Info();
        Aca_Aspirante_Bus AspBus = new Aca_Aspirante_Bus();
        Aca_Admision_Bus AdmBus = new Aca_Admision_Bus();

        public delegate void delegate_FrmAcaAdmision_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmAcaAdmision_Mant_FormClosing event_FrmAcaAdmision_Mant_FormClosing;
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
                MessageBox.Show( NameMetodo +" " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Admision(Aca_Admision_Info info)
        {
            try
            {
                admisionInfo = info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region "Get"
        public Aca_Admision_Info GetAdmision(ref string mensaje) {
            admisionInfo = new Aca_Admision_Info();
            try
            {

                admisionInfo.IdInstitucion = param.IdInstitucion;
                admisionInfo.IdAdmision = string.IsNullOrEmpty(txtIdAdmision.Text) ? 0 : Convert.ToDecimal(txtIdAdmision.Text);
                admisionInfo.CodAdmision = string.IsNullOrEmpty(txtCodigoAdmision.Text) ? txtIdAdmision.Text : txtCodigoAdmision.Text;

                admisionInfo.IdCatalogoGrupoFamiliarConviviencia = cmbConQuienVive.EditValue == null ? "" : cmbConQuienVive.EditValue.ToString();
                admisionInfo.IdCatalogoIdiomaNativo = cmbIdiomaNativo.EditValue == null ? "" : cmbIdiomaNativo.EditValue.ToString();
                admisionInfo.IdCatalogoTipoReligion = cmbReligion.EditValue == null ? "" : cmbReligion.EditValue.ToString();
                admisionInfo.IdCatalogoTipoSangre = cmbTipoSangre.EditValue == null ? "" : cmbTipoSangre.EditValue.ToString();

                //admisionInfo.IdPeriodoLectivo = cmbAnioLectivo.EditValue == null ? "" : cmbAnioLectivo.EditValue.ToString();
                admisionInfo.IdAnioLectivo = cmbAnioLectivo.EditValue == null ? 0 : Convert.ToInt16(cmbAnioLectivo.EditValue.ToString());

                admisionInfo.IdSede = cmbSede.EditValue == null ? 0 : Convert.ToInt16(cmbSede.EditValue.ToString());
                admisionInfo.IdJornada = cmbJornada.EditValue == null ? 0 : Convert.ToInt16(cmbJornada.EditValue);
                admisionInfo.IdSeccion = cmbSeccion.EditValue == null ? 0 : Convert.ToInt16(cmbSeccion.EditValue.ToString());
                admisionInfo.IdCurso = cmbCurso.EditValue == null ? 0 : Convert.ToInt16(cmbCurso.EditValue);

                if(chkPoseeDiscapacidad.Checked != false)
                    admisionInfo.PoseeDiscapacidad = chkPoseeDiscapacidad.Checked;
                admisionInfo.TelefonoEmergente = txtTelefonoEmergencia.Text;
                admisionInfo.EstablecimientoEducativoDondeAsiste = txtCualEstablecimientoEducativoAsiste.Text;
                admisionInfo.EnQueGradoTieneHermanos = txtEnQueGrado.Text;

                admisionInfo.TieneHermanosEnOtrosColegios = (rgTieneHermanosEnOtroColegio.EditValue.ToString() == "1") ? true : false;

                admisionInfo.TieneHermanoEnNuestroColegio = (this.rgTieneHermanosEnNuestroColegio.EditValue.ToString() == "1") ? true : false;

                admisionInfo.HijoUnico = (rgHijoUnico.EditValue.ToString() == "1") ? true : false;

                admisionInfo.HijoProfeDelColegio = (rgHijoProfesorNuestrocolegio.EditValue.ToString() == "1") ? true : false;

                admisionInfo.ActualAsisteEstableEducativo = (rgAsisteEstablecimientoEducativo.EditValue.ToString() == "1") ? true : false;
                // Datos del Aspirante
                Aca_Aspirante_Info aspiranteInfo = new Aca_Aspirante_Info();                
                aspiranteInfo.IdInstitucion = param.IdInstitucion;
                aspiranteInfo.IdAspirante = Convert.ToDecimal(lblIdAspiranteTxt.Text.Trim());
                aspiranteInfo.Barrio = txtBarrio.Text;
                aspiranteInfo.Lugar = txtLugar.Text.Trim();
                aspiranteInfo.Pais_Info.IdPais = cmbNacionalidad.SelectedValue.ToString();
                aspiranteInfo.UsuarioCreacion = param.IdUsuario;
                aspiranteInfo.UsuarioModificacion = param.IdUsuario;
                aspiranteInfo.Estado = "A";
                aspiranteInfo.FechaCreacion = DateTime.Now;
                //Datos de Persona
                aspiranteInfo.Persona_Info.IdEmpresa = param.IdEmpresa;
                aspiranteInfo.Persona_Info.IdPersona = Convert.ToDecimal(lblIdPersonaTxt.Text);
                aspiranteInfo.Persona_Info.pe_nombre = txtNombres.Text.Trim();
                aspiranteInfo.Persona_Info.pe_apellido = txtApellidos.Text.Trim();
                aspiranteInfo.Persona_Info.pe_nombreCompleto = txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();
                aspiranteInfo.Persona_Info.pe_sexo = rgSexo.EditValue.ToString();
                aspiranteInfo.Persona_Info.IdTipoDocumento = ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString();
                aspiranteInfo.Persona_Info.pe_cedulaRuc = txtCedRuc.Text.Trim();
                aspiranteInfo.Persona_Info.pe_fechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.EditValue);
                aspiranteInfo.Persona_Info.pe_direccion = txtDireccion.Text.Trim();
                aspiranteInfo.Persona_Info.pe_telefonoCasa = txtTelefono.Text.Trim();
                aspiranteInfo.Persona_Info.pe_celular = txtNroCelular.Text.Trim();
                aspiranteInfo.Persona_Info.pe_correo = txtEmail.Text.Trim();
                aspiranteInfo.Persona_Info.pe_Naturaleza = "NATU";
                aspiranteInfo.Persona_Info.IdEstadoCivil = "SOLTE";
                aspiranteInfo.Persona_Info.IdTipoPersona = 6; // Aspirante
                aspiranteInfo.Persona_Info.pe_estado = "A";

                admisionInfo.aspiranteInfo = aspiranteInfo;
                admisionInfo.UsuarioCreacion = param.IdUsuario;
                admisionInfo.UsuarioModificacion = param.IdUsuario;
                admisionInfo.Estado = "A";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
            return admisionInfo;
        }
        #endregion

        #region "Cargar Datos"

        public void CargarDatosAdmision() {
            try
            {                   
                txtIdAdmision.Text = Convert.ToString(admisionInfo.IdAdmision);               
                txtCodigoAdmision.Text = admisionInfo.CodAdmision;                
                lblIdPersonaTxt.Text = Convert.ToString( admisionInfo.aspiranteInfo.Persona_Info.IdPersona);
                lblIdAspiranteTxt.Text = Convert.ToString(admisionInfo.IdAspirante);
                txtApellidos.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_apellido;
                txtNombres.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_nombre;
                txtCedRuc.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_cedulaRuc;
                txtLugar.Text = admisionInfo.aspiranteInfo.Lugar;
                txtNroCelular.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_celular;
                txtTelefono.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_telefonoCasa;
                txtDireccion.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_direccion;
                txtEmail.Text = admisionInfo.aspiranteInfo.Persona_Info.pe_correo;
                txtBarrio.Text = admisionInfo.aspiranteInfo.Barrio;


                ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue = (admisionInfo.aspiranteInfo.Persona_Info.IdTipoDocumento == null) ? "CED" : admisionInfo.aspiranteInfo.Persona_Info.IdTipoDocumento;                
                dtFechaNacimiento.EditValue = (admisionInfo.aspiranteInfo.Persona_Info.pe_fechaNacimiento == null) ? "" : Convert.ToDateTime( admisionInfo.aspiranteInfo.Persona_Info.pe_fechaNacimiento).ToShortDateString();
                rgSexo.EditValue = (admisionInfo.aspiranteInfo.Persona_Info.pe_sexo == null) ? "SEXO_MAS" : admisionInfo.aspiranteInfo.Persona_Info.pe_sexo;
               

                txtTelefonoEmergencia.Text = admisionInfo.TelefonoEmergente;
                txtEnQueGrado.Text = admisionInfo.EnQueGradoTieneHermanos;
                txtCualEstablecimientoEducativoAsiste.Text = admisionInfo.EstablecimientoEducativoDondeAsiste;
                
                cmbNacionalidad.SelectedValue = string.IsNullOrEmpty(admisionInfo.aspiranteInfo.Pais_Info.IdPais) ? "1" : admisionInfo.aspiranteInfo.Pais_Info.IdPais;
               
                //cmbAnioLectivo.EditValue = admisionInfo.IdPeriodoLectivo;
                cmbAnioLectivo.EditValue = admisionInfo.IdAnioLectivo;
                               
                cmbCurso.EditValue = admisionInfo.IdCurso==0?string.Empty:admisionInfo.IdCurso.ToString();
                cmbSede.EditValue = admisionInfo.IdSede==0?string.Empty:admisionInfo.IdSede.ToString();
                cmbJornada.EditValue = admisionInfo.IdJornada==0?string.Empty:admisionInfo.IdJornada.ToString();
                cmbSeccion.EditValue = admisionInfo.IdSeccion==0?string.Empty:admisionInfo.IdSeccion.ToString();

                cmbConQuienVive.EditValue = string.IsNullOrEmpty(admisionInfo.IdCatalogoGrupoFamiliarConviviencia)  ? "PADRES" : admisionInfo.IdCatalogoGrupoFamiliarConviviencia;
                cmbIdiomaNativo.EditValue = string.IsNullOrEmpty(admisionInfo.IdCatalogoIdiomaNativo) ? "ESPA" : admisionInfo.IdCatalogoIdiomaNativo;
                cmbTipoSangre.EditValue =  string.IsNullOrEmpty(admisionInfo.IdCatalogoTipoSangre) ? "O+" : admisionInfo.IdCatalogoTipoSangre;
                cmbReligion.EditValue = string.IsNullOrEmpty(admisionInfo.IdCatalogoTipoReligion) ? "CATOL" : admisionInfo.IdCatalogoTipoReligion;


                rgAsisteEstablecimientoEducativo.EditValue = (admisionInfo.ActualAsisteEstableEducativo == true) ? "1" : "0";
                rgHijoProfesorNuestrocolegio.EditValue = (admisionInfo.HijoProfeDelColegio == true) ? "1" : "0";
                rgHijoUnico.EditValue = (admisionInfo.HijoUnico == true) ? "1" : "0";
                rgTieneHermanosEnOtroColegio.EditValue = (admisionInfo.TieneHermanosEnOtrosColegios == true) ? "1" : "0";
                rgTieneHermanosEnNuestroColegio.EditValue = (admisionInfo.TieneHermanoEnNuestroColegio == true) ? "1" : "0";

                chkPoseeDiscapacidad.EditValue = admisionInfo.PoseeDiscapacidad;                
                chkActivo.Checked = (admisionInfo.Estado == "A") ? true : admisionInfo.Estado==""?true: false;
                
                if (admisionInfo.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (admisionInfo.Estado != null && admisionInfo.Estado != "")
                    {
                        lblAnulado.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        
        }

        public void CargarCombos() {
            try
            {
                // Con quien vive el alumno
                Aca_Catalogo_Bus neg = new Aca_Catalogo_Bus();
                cmbConQuienVive.Properties.DataSource = neg.Get_List_CatalogoXtipo("GRP_FAM_CONV");
                // Religion
                cmbReligion.Properties.DataSource = neg.Get_List_CatalogoXtipo("RELIG");
                //Idioma Nativo
                cmbIdiomaNativo.Properties.DataSource = neg.Get_List_CatalogoXtipo("IDIOMA");
                //Tipo Sangre
                cmbTipoSangre.Properties.DataSource = neg.Get_List_CatalogoXtipo("GRUP_SAN");

                //Sede
                Aca_Sede_Bus negSede = new Aca_Sede_Bus();
                cmbSede.Properties.DataSource = negSede.Get_List_Sede(param.IdInstitucion);

                Aca_Anio_Lectivo_Bus negPeriodoLec = new Aca_Anio_Lectivo_Bus();
                cmbAnioLectivo.Properties.DataSource = negPeriodoLec.Get_List_Anio_Lectivo(param.IdInstitucion);

                Aca_Jornada_Bus negJornada = new Aca_Jornada_Bus();
                cmbJornada.Properties.DataSource = negJornada.Get_Lista_Jornada(param.IdInstitucion);

                Aca_Curso_Bus negCurwso = new Aca_Curso_Bus();
                cmbCurso.Properties.DataSource = negCurwso.Get_Lista_Curso(param.IdInstitucion);

                Aca_Seccion_Bus negSeccion = new Aca_Seccion_Bus();
                cmbSeccion.Properties.DataSource = negSeccion.Get_Lista_Seccion(param.IdInstitucion);

                tb_pais_Bus negPais = new tb_pais_Bus();
                cmbNacionalidad.DataSource = negPais.Get_List_pais();
                cmbNacionalidad.SelectedValue = "1";
                

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);       
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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

                if (cmbNacionalidad.SelectedValue==null|| cmbNacionalidad.SelectedValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " nacionalidad del Aspirante ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbNacionalidad.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtNombres.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " nombre del Aspirante ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombres.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtApellidos.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Apellido del Aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellidos.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(dtFechaNacimiento.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " fecha de nacimiento del Aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dtFechaNacimiento.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtDireccion.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " dirección del Aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDireccion.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtTelefono.EditValue.ToString()))
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " teléfono del Aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTelefono.Focus();
                    return false;
                }

                if (rgSexo.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " sexo del Aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rgSexo.Focus();
                    return false;
                }

                // Pestaña 2
                if (cmbAnioLectivo.EditValue == null || cmbAnioLectivo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " periodo lectivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    xtraTabAdmision.SelectedTabPage = xtraTabAdmision.TabPages[1];
                    cmbAnioLectivo.Focus();
                    return false;

                }

                if (cmbSede.EditValue == null || cmbSede.EditValue == "" || cmbSede.EditValue=="0")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sede", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSede.Focus();
                    return false;
                }

                if (cmbJornada.EditValue == null || cmbJornada.EditValue == "" || cmbJornada.EditValue=="0")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Jornada", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbJornada.Focus();
                    return false;
                }

                if (cmbSeccion.EditValue == null || cmbSeccion.EditValue == "" || cmbSeccion.EditValue=="0")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " Sección", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbSeccion.Focus();
                    return false;
                }

                if (cmbCurso.EditValue == null || cmbCurso.EditValue == "" || cmbCurso.EditValue=="0")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " curso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCurso.Focus();
                    return false;
                }

                // Pestaña 3
                if (cmbConQuienVive.EditValue==null|| cmbConQuienVive.EditValue=="")
                {
                    MessageBox.Show("Seleccione con quien vive el aspirante", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbConQuienVive.Focus();
                    return false;
                }

                if (cmbReligion.EditValue==null|| cmbReligion.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la) + " religión", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbReligion.Focus();
                    return false;
                }

                if (cmbTipoSangre.EditValue==null || cmbTipoSangre.EditValue=="")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " tipo de sangre", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoSangre.Focus();
                    return false;
                    
                }

                if (cmbIdiomaNativo.EditValue == null || cmbIdiomaNativo.EditValue == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " idioma nativo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbIdiomaNativo.Focus();
                    return false;

                }

           
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_CI_Ruc_Pasaporte), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Ingrese_CI_Ruc_Pasaporte), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }                    
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
       
        public bool BuscarAdmision_x_Persona(ref string mensaje)
        {
            try
            {
                
                AdmBus = new Aca_Admision_Bus();
               bool existe = AdmBus.ExisteCedula(param.IdInstitucion, Convert.ToDecimal(txtIdAdmision.Text.Trim()), txtCedRuc.Text.Trim(), ref mensaje);               
               
                return existe;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }            
        }


        #endregion

        #region "Insertar,Actualizar,Eliminar"
        public bool guardarDatos()
        {
            try
            {
                if (validaciones())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            GrabarAdmision();
                            
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:
                            Actualizar();
                            break;
                    }
                    return true;
                }
                else { return false; }
            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        private void GrabarAdmision()
        {
            try
            {
                Aca_Admision_Bus negAdmision = new Aca_Admision_Bus();
                admisionInfo = new Aca_Admision_Info();

                decimal id = 0;
                string mensaje = string.Empty;
                admisionInfo = GetAdmision(ref mensaje);

                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = negAdmision.GrabarDB(admisionInfo, ref id, ref mensaje);
                txtIdAdmision.Text = id.ToString();

                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu.Visible_btnGuardar = true;
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
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Actualizar()
        {
            try
            {
                Aca_Admision_Bus negAdmision = new Aca_Admision_Bus();
                Aca_Admision_Info infoAdmision = new Aca_Admision_Info();
                string mensaje = string.Empty;

                infoAdmision = GetAdmision(ref mensaje);
                if (mensaje != "")
                {
                    MessageBox.Show(mensaje);
                    return;
                }
                bool resultado = negAdmision.ActualizarDB(infoAdmision, ref mensaje);
                if (resultado)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) +" la admisión # : " + txtCodigoAdmision.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Anular()
        {
            try
            {
                if (admisionInfo.Estado != "I")
                {
                    if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " la admisión # " + txtIdAdmision.Text.Trim() + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                        string motiAnulacion = fr.motivoAnulacion;

                        Aca_Admision_Bus negAdmision = new Aca_Admision_Bus();
                        Aca_Admision_Info infoAdmision = new Aca_Admision_Info();
                        string mensaje = string.Empty;

                        infoAdmision = GetAdmision(ref mensaje);
                        infoAdmision.UsuarioAnulacion = param.IdUsuario;
                        infoAdmision.MotivoAnulacion = motiAnulacion;
                        if (mensaje != "")
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_encontrado) + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        bool resultado = negAdmision.EliminarDB(infoAdmision, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Anulada_corectamente) + " la admisión # : " + txtCodigoAdmision.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else 
                {
                    MessageBox.Show("La admisión #:"+ txtIdAdmision.Text.Trim() + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region "Eventos"
        private void FrmAcaAdmision_Mant_Load(object sender, EventArgs e)
        {
            try
            {

                CargarCombos();               
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular  = false;
                        ucGe_Menu.Enabled_bntImprimir = false;
                        this.chkActivo.Checked = true;
                        LimpiarControles();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        txtCedRuc.Enabled = false;
                        CargarDatosAdmision();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        txtCedRuc.Enabled = false;
                        CargarDatosAdmision();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        lblAnulado.Visible = false;
                        txtCedRuc.Enabled = false;
                        CargarDatosAdmision();
                        break;
                }

            }
            catch (Exception ex)
            {
                
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        public FrmAcaAdmision_Mant()
        {
            InitializeComponent();
            event_FrmAcaAdmision_Mant_FormClosing += FrmAcaAdmision_Mant_event_FrmAcaAdmision_Mant_FormClosing;
        }

        void FrmAcaAdmision_Mant_event_FrmAcaAdmision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {

                bool resultado = false;
                resultado = guardarDatos();
                if (resultado)
                {
                    Close();
                }            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }

            
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            guardarDatos();
            LimpiarControles();
        }

        private void cmbSede_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSede.EditValue!=null && cmbSede.EditValue!="")
                {
                    //Aca_Jornada_Bus negJornada = new Aca_Jornada_Bus();
                    //cmbJornada.Properties.DataSource = negJornada.Get_List_Jornada(param.IdInstitucion, Convert.ToInt16(cmbSede.EditValue));
                }
              
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                
            }
        }

        private void cmbJornada_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbJornada.EditValue != null && cmbJornada.EditValue!= "")
                {
                    //Aca_Seccion_Bus negSeccion = new Aca_Seccion_Bus();
                    //cmbJornada.Properties.DataSource = negSeccion.Get_List_Seccion(param.IdInstitucion, Convert.ToInt16(cmbJornada.EditValue));
                }
               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbSeccion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSeccion.EditValue!=null && cmbSeccion.EditValue!="")
                {
                    //Aca_Curso_Bus negCurso = new Aca_Curso_Bus();
                    //cmbCurso.Properties.DataSource = negCurso.Get_List_Curso(param.IdInstitucion, Convert.ToInt16(cmbSeccion.EditValue));
                }              
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void FrmAcaAdmision_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmAcaAdmision_Mant_FormClosing(sender, e);                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            Anular();
            Close();
        }

        private void txtCedRuc_Leave(object sender, EventArgs e)
        {
            try
            {
                // Valida si cédula ya se encuentra ingresa en la tabla de admision
                string mensaje = string.Empty;
                if (txtCedRuc.Text != "")
                {
                    if (ValidarCedula())
                    {
                        if (BuscarAdmision_x_Persona(ref mensaje))
                        {
                            MessageBox.Show(mensaje + ":" + txtCedRuc.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCedRuc.Focus();
                            LimpiarControles();
                        }
                        else
                        {
                            ObtenerDatosAdmisiones_x_Cedula();
                            CargarDatosAdmision();
                        }
                    }
                    else
                        LimpiarControles();

                }  
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion
       
        public void LimpiarControles() {
            try
            {
                this.lblIdPersonaTxt.Text = "0";
                this.lblIdAspiranteTxt.Text = "0";
                txtCedRuc.Text = string.Empty;
                txtNombres.Text = string.Empty;
                txtApellidos.Text = string.Empty;
                txtBarrio.Text = string.Empty;
                txtCodigoAdmision.Text = string.Empty;
                txtCualEstablecimientoEducativoAsiste.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEnQueGrado.Text = string.Empty;
                txtLugar.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtTelefonoEmergencia.Text = string.Empty;
                txtNroCelular.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtIdAdmision.Text = "0";
                cmbAnioLectivo.EditValue = null;
                cmbCurso.EditValue = null;
                cmbJornada.EditValue = null;
                cmbSeccion.EditValue = null;
                dtFechaNacimiento.EditValue = null;
                cmbSede.EditValue = null;
                txtEnQueGrado.Text = string.Empty;
                rgSexo.EditValue = null;
                chkPoseeDiscapacidad.EditValue = null;

                rgAsisteEstablecimientoEducativo.EditValue = false;
                rgHijoProfesorNuestrocolegio.EditValue = false;
                rgHijoUnico.EditValue = false;
                rgTieneHermanosEnNuestroColegio.EditValue = false;
                rgTieneHermanosEnOtroColegio.EditValue = false;

                cmbConQuienVive.EditValue="PADRES";
                cmbIdiomaNativo.EditValue="ESPA";
                cmbTipoSangre.EditValue = "O+";
                cmbReligion.EditValue = "CATOL";
                chkActivo.Checked = true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void ObtenerDatosAdmisiones_x_Cedula()
        {
            try
            {
                string msj = string.Empty;
                neg = new tb_persona_bus();
                infoPersona = new tb_persona_Info();
                AspiranteInfo = new Aca_Aspirante_Info();
                AspBus = new Aca_Aspirante_Bus();
                infoPersona = neg.Get_Info_Persona(txtCedRuc.Text.Trim());
                AspiranteInfo = AspBus.Get_Info_Aspirante(infoPersona.IdPersona, ref msj);
                admisionInfo.IdInstitucion = param.IdInstitucion;
                admisionInfo.IdAspirante = AspiranteInfo.IdAspirante;
                admisionInfo.aspiranteInfo.Persona_Info.IdPersona = infoPersona.IdPersona;
                admisionInfo.aspiranteInfo.Persona_Info.pe_nombre  = infoPersona.pe_nombre;
                admisionInfo.aspiranteInfo.Persona_Info.pe_apellido = infoPersona.pe_apellido;
                admisionInfo.aspiranteInfo.Persona_Info.pe_cedulaRuc = infoPersona.pe_cedulaRuc;
                admisionInfo.aspiranteInfo.Persona_Info.pe_fechaNacimiento = infoPersona.pe_fechaNacimiento;
                admisionInfo.aspiranteInfo.Persona_Info.pe_correo = infoPersona.pe_correo;
                admisionInfo.aspiranteInfo.Persona_Info.pe_direccion = infoPersona.pe_direccion;
                admisionInfo.aspiranteInfo.Persona_Info.pe_sexo = infoPersona.pe_sexo;
                admisionInfo.aspiranteInfo.Persona_Info.pe_telefonoCasa = infoPersona.pe_telefonoCasa;
                admisionInfo.aspiranteInfo.Persona_Info.IdTipoDocumento = infoPersona.IdTipoDocumento;
                admisionInfo.aspiranteInfo.Persona_Info.pe_celular = infoPersona.pe_celular;
                admisionInfo.aspiranteInfo.Persona_Info.pe_estado = infoPersona.pe_estado;
                admisionInfo.aspiranteInfo.Pais_Info.IdPais = AspiranteInfo.Pais_Info.IdPais;
                admisionInfo.Estado = infoPersona.pe_estado;

            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + NameMetodo + " - " + ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
      
    }
}
