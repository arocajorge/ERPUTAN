using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Academico;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;
using Core.Erp.Business.General;
using Core.Erp.Winform;

namespace Core.Erp.Winform.Controles
{
    public partial class UCAca_Familiar_x_Estudiante : UserControl
    {
        #region "Variables"
            Aca_Catalogo_Bus negc = new Aca_Catalogo_Bus();
            List<Aca_Catalogo_Info> listaParentescoFamiliar = new List<Aca_Catalogo_Info>();
            Aca_Familiar_Info InfoFamiliar;
            cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
            tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion

        public string IdParentestoFamiliar { get; set; }
        public decimal IdFamiliar { get; set; }
        public decimal IdEstudiante { get; set; }
        public Aca_Matricula_Info matriculaInfo { get; set; }
        public bool Mostrar_historico { get; set; }
        public Boolean Visible_Page_InfoFinanciera 
        {
            get { return xtraTabInformaciónFinanciera.PageVisible; }
            set { xtraTabInformaciónFinanciera.PageVisible = value; }
        }
        private List<Aca_Familiar_x_Estudiante_Info> lst_familiar_x_estudiante = new List<Aca_Familiar_x_Estudiante_Info>();
        Aca_Familiar_x_Estudiante_Bus bus_familiar_x_estudiante = new Aca_Familiar_x_Estudiante_Bus();

        public UCAca_Familiar_x_Estudiante()
        {
            InitializeComponent();
         
        }

       public void cargar_controles()
        {
            try
            {
                if (IdEstudiante == 0)
                {
                    lblIdFamiliarTxt.Text = IdFamiliar.ToString();
                }
                else {
                    IdFamiliar = InfoFamiliar.IdFamiliar;
                    lblIdFamiliarTxt.Text = InfoFamiliar.IdFamiliar.ToString();
                }

                if (InfoFamiliar == null)
                { return; }

                lblIdPersonaTxt.Text = InfoFamiliar.Persona_Info.IdPersona.ToString();
                txtNombres.Text = InfoFamiliar.Persona_Info.pe_nombre;
                txtApellidos.Text = InfoFamiliar.Persona_Info.pe_apellido;
                txtCedRuc.Text = InfoFamiliar.Persona_Info.pe_cedulaRuc;
                txtDireccion.Text = InfoFamiliar.Persona_Info.pe_direccion;
                txtEmailEmpresa.Text = InfoFamiliar.EmpresaEmail;
                txtDirecionEmpresa.Text = InfoFamiliar.EmpresaDireccion;
                txtNombreEmpresa.Text = InfoFamiliar.EmpresaDondeTrabaja;
                txtTelefonoEmpresa.Text = InfoFamiliar.EmpresaTelefono;                
                txtTelefono.Text = InfoFamiliar.Persona_Info.pe_telefonoCasa;                
                dtFechaNacimiento.EditValue = InfoFamiliar.Persona_Info.pe_fechaNacimiento;                
                ucGe_Docu_PersIdentificacion.set_TipoDoc_Personales(InfoFamiliar.Persona_Info.IdTipoDocumento);// == null) ? "CED" : InfoFamiliar.Persona_Info.IdTipoDocumento;
                ucGe_EstadoCivil.set_estadoCivil(InfoFamiliar.Persona_Info.IdEstadoCivil);                
                txtOcupacionLaboral.Text = InfoFamiliar.OcupacionLaboral;
                txtTitulo.Text = InfoFamiliar.Titulo;
                cmbNivelEducativo.EditValue = InfoFamiliar.IdNivelEducativo;
                chk_AutorizacionRecibir.Checked = InfoFamiliar.EstaAutorizadoRecAlumn;
                chk_AutorizacionRetirar.Checked = InfoFamiliar.EstaAutorizadoRetAlum;
                chk_Vive_con_el.Checked = InfoFamiliar.ViveConEl;
                chkViveFueraPais.Checked = InfoFamiliar.ViveFueraDelPais;
                chkFallecido.Checked = InfoFamiliar.Fallecido;
                radioGroupFueExAlumnoGraduado.EditValue =( InfoFamiliar.FueExAlumnoGraduado==true)?"1":"0";
                cmbTipoSangre.EditValue = string.IsNullOrEmpty( InfoFamiliar.IdCatalogoTipoSangre ) ? "O+" : InfoFamiliar.IdCatalogoTipoSangre;
                cmbReligion.EditValue = string.IsNullOrEmpty( InfoFamiliar.IdCatalogoReligion)?"CATOL":InfoFamiliar.IdCatalogoReligion;
                cmbIdioma.EditValue = string.IsNullOrEmpty( InfoFamiliar.IdCatalogoIdiomaNativo) ? "ESPA" : InfoFamiliar.IdCatalogoIdiomaNativo;
                txtSectorUrbanizacion.Text = InfoFamiliar.Sector_Urbanizacion;
                txtCalleSecundaria.Text = InfoFamiliar.Calle_Secundaria;
                txtCallePrincipal.Text = InfoFamiliar.Calle_Principal;
                ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue = InfoFamiliar.IdCiudad;
                if (!string.IsNullOrEmpty(InfoFamiliar.IdCiudad))
                {
                    tb_Provincia_Bus prv = new tb_Provincia_Bus();

                    ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue = prv.GetIdProvincia(InfoFamiliar.IdCiudad);

                    if (!string.IsNullOrEmpty(ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue.ToString()))
                    {
                        tb_pais_Bus pais = new tb_pais_Bus();
                        ucGe_PaisProvinciaCiudad.cmbPais.EditValue = pais.GetIdPais(ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue.ToString());
                    }
                }           
                chkDiscapacidad.Checked = InfoFamiliar.PoseeDiscapacidad;
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }          
        }

       #region "Set"
       public void Set_Info_Datos_Familiar(Aca_Familiar_Info Info)
       {
           try
           {
               InfoFamiliar = new Aca_Familiar_Info();
               InfoFamiliar = Info;
               cargar_controles();
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }
        
       #endregion

       #region "Get"
       public Aca_Familiar_Info Get_Info_Datos_Familiar(ref string mensaje)
       {
           try
           {
               Aca_Familiar_Info FamiInfo = new Aca_Familiar_Info();
               FamiInfo.Persona_Info.IdPersona = (lblIdPersonaTxt.Text.Trim() == "") ? 0 : Convert.ToInt32(lblIdPersonaTxt.Text.Trim());
               FamiInfo.IdFamiliar = IdFamiliar;
               FamiInfo.Persona_Info.pe_nombre = txtNombres.Text;
               FamiInfo.Persona_Info.pe_apellido = txtApellidos.Text;

               if (txtNombres.Text.Trim() != "" && txtApellidos.Text.Trim() != "")
               {
                   if (txtCedRuc.Text.Trim() == "" || dtFechaNacimiento.EditValue == null)
                   {
                       mensaje = " Ingrese cédula y fecha de nacimiento del Familiar";

                       return new Aca_Familiar_Info();
                   }
               }

               FamiInfo.Persona_Info.pe_nombreCompleto = txtNombres.Text.Trim() + " " + txtApellidos.Text.Trim();
               FamiInfo.Persona_Info.IdTipoDocumento = this.ucGe_Docu_PersIdentificacion.SelectedValue();
               FamiInfo.Persona_Info.IdEstadoCivil = ucGe_EstadoCivil.cmb_estadoCivil.SelectedValue.ToString();
               // Cliente:
               FamiInfo.Persona_Info.IdTipoPersona = 2;
               FamiInfo.Persona_Info.pe_Naturaleza = "NATU";
               FamiInfo.Persona_Info.pe_celular = txtTelefono.Text.Trim();
               FamiInfo.Persona_Info.pe_fechaNacimiento = Convert.ToDateTime(dtFechaNacimiento.EditValue);
               FamiInfo.IdParentescoCat = IdParentestoFamiliar;
               FamiInfo.Persona_Info.pe_sexo = (IdParentestoFamiliar == "PADR") ? "SEXO_MAS" : "SEXO_FEM";
               FamiInfo.Persona_Info.pe_telefonoCasa = txtTelefono.Text.Trim();
               FamiInfo.Persona_Info.pe_telefonoOfic = txtTelefonoEmpresa.Text.Trim();
               FamiInfo.Persona_Info.pe_estado = "A";
               FamiInfo.Persona_Info.pe_UltUsuarioModi = param.IdUsuario;
               FamiInfo.Persona_Info.pe_cedulaRuc = txtCedRuc.Text;               
               FamiInfo.Persona_Info.pe_direccion = txtDireccion.Text;
               FamiInfo.EmpresaDondeTrabaja = txtNombreEmpresa.Text;
               FamiInfo.EmpresaDireccion = txtDirecionEmpresa.Text.Trim();
               FamiInfo.EmpresaTelefono = txtTelefonoEmpresa.Text.Trim();
               FamiInfo.EmpresaEmail = txtEmailEmpresa.Text.Trim();
               FamiInfo.EstaAutorizadoRecAlumn = chk_AutorizacionRecibir.Checked;
               FamiInfo.EstaAutorizadoRetAlum = chk_AutorizacionRetirar.Checked;
               FamiInfo.ViveConEl = chk_Vive_con_el.Checked;
               FamiInfo.OcupacionLaboral = txtOcupacionLaboral.Text;
               FamiInfo.IdNivelEducativo = (cmbNivelEducativo.EditValue == null) ? "PRIM" : cmbNivelEducativo.EditValue.ToString();
               FamiInfo.Titulo = txtTitulo.Text.Trim();
               FamiInfo.Calle_Principal = txtCallePrincipal.Text;
               FamiInfo.Calle_Secundaria = txtCalleSecundaria.Text;
               FamiInfo.Fallecido = chkFallecido.Checked;
               FamiInfo.FueExAlumnoGraduado = radioGroupFueExAlumnoGraduado.EditValue=="0"?false:true;
               FamiInfo.IdCatalogoIdiomaNativo = cmbIdioma.EditValue == null ? "ESPA" : cmbIdioma.EditValue.ToString();
               FamiInfo.IdCatalogoReligion = cmbReligion.EditValue==null? "CATOL" :  cmbReligion.EditValue.ToString();
               FamiInfo.IdCatalogoTipoSangre = cmbTipoSangre.EditValue == null ? "O+" : cmbTipoSangre.EditValue.ToString();
               FamiInfo.PoseeDiscapacidad = chkDiscapacidad.Checked;
               FamiInfo.Sector_Urbanizacion = txtSectorUrbanizacion.Text;
               FamiInfo.ViveFueraDelPais = chkViveFueraPais.Checked;
               FamiInfo.UsuarioCreacion = param.IdUsuario;


               if (txtNombres.Text.Trim() != "" && txtApellidos.Text.Trim() != "")
               {
                   if (ucGe_PaisProvinciaCiudad.cmbPais.EditValue == null|| ucGe_PaisProvinciaCiudad.cmbPais.EditValue=="")
                   {
                       mensaje = " Debe seleccionar el pais";
                       return new Aca_Familiar_Info();
                   }

                   if (ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue == null || ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue=="")
                   {
                       mensaje = " Debe seleccionar la provincia";
                       return new Aca_Familiar_Info();
                   }

                   if (ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue == null || ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue=="")
                    {
                        mensaje = " Debe seleccionar la ciudad";
                        return new Aca_Familiar_Info();
                    }else{
                        FamiInfo.IdCiudad = ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue.ToString();
                    }
               }
               //InfoFamiliar = FamiInfo;
               return FamiInfo;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return new Aca_Familiar_Info();
           }
       }

       #endregion

     
        public void CargarCombo() 
        {
            try
            {
                this.cmbNivelEducativo.Properties.DataSource = negc.Get_List_CatalogoXtipo("NIVEL_EDU");
                this.cmbIdioma.Properties.DataSource = negc.Get_List_CatalogoXtipo("IDIOMA");
                this.cmbReligion.Properties.DataSource = negc.Get_List_CatalogoXtipo("RELIG");
                this.cmbTipoSangre.Properties.DataSource = negc.Get_List_CatalogoXtipo("GRUP_SAN");

                listaParentescoFamiliar = negc.Get_List_CatalogoXtipo("PAREN_FAMI");

                Aca_Catalogo_Info InfoParentesco = listaParentescoFamiliar.FirstOrDefault(v => v.IdCatalogo == IdParentestoFamiliar);

                if (InfoParentesco == null)
                {
                    tabPage_informacion.Text = "";
                }
                else
                { tabPage_informacion.Text = "Información del " + InfoParentesco.Descripcion.ToLower(); }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCAca_Familiar_x_Estudiante_Load(object sender, EventArgs e)
        {
            CargarCombo();
            xtraTabInformaciónFinanciera.PageVisible = false;
            tabPage_historico.PageVisible = Mostrar_historico;
        
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
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
	        }               
        }

        private void txtCedRuc_Enter(object sender, EventArgs e)
        {
            try
            {
                if (ucGe_Docu_PersIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    txtCedRuc.Properties.MaxLength = 10;
                    if (txtCedRuc.Text.Length >= 10)
                    {
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 10);
                    }
                }
                if (ucGe_Docu_PersIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {
                    txtCedRuc.Properties.MaxLength = 13;
                    if (txtCedRuc.Text.Length >= 13)
                    {
                        txtCedRuc.Text = txtCedRuc.Text.Substring(0, 13);
                    }
                }
                if (ucGe_Docu_PersIdentificacion.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
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
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }        
        }

        Boolean ValidarCedula()
        {
            try
            {
                Cl_TipoDoc_Personales_Info info_doc_personal = new Cl_TipoDoc_Personales_Info();

                info_doc_personal = ucGe_Docu_PersIdentificacion.get_TipoDoc_Personales();
                tb_persona_bus tbPersona = new tb_persona_bus();
                string msj = "";

                if (info_doc_personal.codigo == "CED")
                {
                    if (this.txtCedRuc.Text != "")
                    {
                        if (txtCedRuc.Text.TrimStart().TrimEnd().Length != 10)
                        {                            
                            MessageBox.Show("Cédula Incorrecta", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txtCedRuc.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digita la Cédula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                else if (info_doc_personal.codigo == "RUC")
                {

                    if (txtCedRuc.Text != "")
                    {
                        if (txtCedRuc.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("Ruc Incorrecto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                            return false;
                        }
                        if (txtCedRuc.Text.TrimStart().TrimEnd().Length != 13)
                        {
                            MessageBox.Show("Ruc Incorrecto", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txtCedRuc.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digita Ruc", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void txtCedRuc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCedRuc.Text.Trim() != "")
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

                    //BuscarFamiliar_x_Cedula();
                }
                else { LimpiarControles(); }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message.ToString());
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void BuscarFamiliar_x_Cedula() 
        {
            try
            {
                bool existePersona = false;
                string msj = string.Empty;

                Aca_Familiar_Bus neg = new Aca_Familiar_Bus();


                InfoFamiliar = new Aca_Familiar_Info();
                if (IdEstudiante == 0) // esto es para el ingreso de un estudiante
                {
                    InfoFamiliar = neg.GetFamiliar_x_Estudiante(txtCedRuc.Text.Trim(), ref existePersona);
                }
                else
                {
                    InfoFamiliar = neg.GetFamiliar_x_Estudiante(IdEstudiante, txtCedRuc.Text.Trim(), ref existePersona);
                }

                if (existePersona)
                {
                    cargar_controles();
                }
                //else
                //{
                //    //LimpiarControles(); txtNombres.Focus();
                    //if (IdParentestoFamiliar == "REP_ECO")
                    //{
                    //    IdFamiliar = 3;
                    //}

                    //if (IdParentestoFamiliar == "REP_LEGAL")
                    //{
                    //    IdFamiliar = 4;
                    //}
                    //this.lblIdFamiliarTxt.Text = IdFamiliar.ToString();
                //}

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void LimpiarControles() 
        {
            try
            {
                this.lblIdPersonaTxt.Text = string.Empty;
                this.txtApellidos.Text = string.Empty;
                this.txtNombres.Text = string.Empty;
                this.txtTitulo.Text = string.Empty;
                this.txtDireccion.Text = string.Empty;
                this.txtDirecionEmpresa.Text = string.Empty;
                this.txtTelefonoEmpresa.Text = string.Empty;
                this.txtEmailEmpresa.Text = string.Empty;
                this.txtOcupacionLaboral.Text = string.Empty;
                this.txtTelefono.Text = string.Empty;                
                
                this.cmbTipoSangre.EditValue = "O+";
                this.cmbReligion.EditValue = "CATOL";
                this.cmbIdioma.EditValue = "ESPA";
                this.cmbNivelEducativo.EditValue = "SIN_EDU";
                //this.txtCedRuc.Text = string.Empty;
                dtFechaNacimiento.DateTime = DateTime.Now;
                lblIdFamiliarTxt.Text = string.Empty;
               
                chk_Vive_con_el.Checked = false;
                chkViveFueraPais.Checked = false;
                ucGe_PaisProvinciaCiudad.cmbPais.EditValue = null;                
                ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue = null;
                ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue = null;
                ucGe_PaisProvinciaCiudad.cmbParroquia.EditValue = null;
                //this.txtNombres.Focus();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

            
        }

        public void Cargar_familiares_x_estudiante_historico(int IdInstitucion, decimal IdEstudiante)
        {
            try
            {
                lst_familiar_x_estudiante = bus_familiar_x_estudiante.Get_list_familiar_x_estudiante(IdInstitucion, IdEstudiante);
                gridControlHistorico.DataSource = lst_familiar_x_estudiante;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewHistorico_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_activo_his)
                {
                    gridViewHistorico.SetRowCellValue(e.RowHandle, col_activo_his, e.Value);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewHistorico_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == col_activo_his)
                {
                    if (Convert.ToBoolean(e.Value) == true)
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}
