using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;


namespace Core.Erp.Winform.Controles
{
    public partial class UCGe_Mant_Persona : UserControl
    {
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_persona_bus PersoB = new tb_persona_bus();
        tb_persona_Info _PersonaInfo = new tb_persona_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCGe_Docu_Personales UCDocumento = new UCGe_Docu_Personales();
        UCGe_EstadoCivil UCEstadoCivil = new UCGe_EstadoCivil();
        UCGe_Sexo UCGenero = new UCGe_Sexo();
        UCGe_NaturalezaPersona UCNaturaleza = new UCGe_NaturalezaPersona();

        string MensajeError = "";

        public UCGe_Mant_Persona()
        {
            try
            {
                InitializeComponent();
                UCNaturaleza.Event_cmb_naturalezaPersona_SelectedIndexChanged += new UCGe_NaturalezaPersona.delegate_cmb_naturalezaPersona_SelectedIndexChanged(UCNaturaleza_Event_cmb_naturalezaPersona_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        void UCNaturaleza_Event_cmb_naturalezaPersona_SelectedIndexChanged(object sender, EventArgs e) 
        {

        }

        public Boolean grabar()
        {

            try
            {
                string msgError = "";
                Boolean resultB;

                if (Validaciones() == false)
                {
                    return false;
                }


                if (!(_PersonaInfo == null))
                {
                    decimal idPersonaOut;
                    idPersonaOut = 0;

                    get_Persona();
                    tb_persona_bus perBu = new tb_persona_bus();

                    if (perBu.GrabarDB(_PersonaInfo, ref  idPersonaOut, ref msgError))
                    {

                        //llenando tipo persona
                        List<tb_personaxPersonaTipo_Info> lpersonaxPersonaTipo = new List<tb_personaxPersonaTipo_Info>();

                        for (int i = 0; i < chkListTipoPersona.CheckedItems.Count; i++)
                        {
                            if (chkListTipoPersona.GetItemChecked(i))
                            {
                                tb_personaTipo_Info itemxPer = (tb_personaTipo_Info)chkListTipoPersona.Items[i];
                                tb_personaxPersonaTipo_Info itemxTipoPero = new tb_personaxPersonaTipo_Info();

                            }
                        }




                        resultB = true;
                    }
                    else
                    {
                        resultB = false;
                    }

                    return resultB;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;

            }
        }

        public Boolean Actualizar()
        {

            try
            {
                string megError = "";
                if (Validaciones() == false)
                {
                    return false;
                }


                if (_PersonaInfo != null)
                {
                    get_Persona();
                    tb_persona_bus perBu = new tb_persona_bus();
                    return perBu.ModificarDB(_PersonaInfo, ref megError);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public Boolean Anular(tb_persona_Info _PersonaInfo)
        {
            try
            {
                if (!(_PersonaInfo == null))
                {
                    get_Persona();
                    tb_persona_bus perBu = new tb_persona_bus();


                    return perBu.AnularDB(_PersonaInfo, ref MensajeError);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        private void IniciarControles()
        {
            try
            {
                this.PanelTipoDoc.Controls.Add(this.UCDocumento);
                UCDocumento.Dock = DockStyle.Fill;


                this.panelGenero1.Controls.Add(this.UCGenero);
                UCGenero.Dock = DockStyle.Fill;

                this.PanelEstadiCivil.Controls.Add(this.UCEstadoCivil);
                this.UCEstadoCivil.Dock = DockStyle.Fill;

                this.PanelNaturaleza.Controls.Add(this.UCNaturaleza);
                this.UCNaturaleza.Dock = DockStyle.Fill;

                UCEstadoCivil.cargar_Combo();
                UCGenero.cargar_combo();

                 ucRo_CatalogoTipoCta.set_cargar_combo_x_tipo(9);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public Boolean Validaciones()
        {
            try
            {
                Boolean Valido = true;
                string sNombreCompleto = "";

                if (txt_Ruc.Text == "")
                {
                    MessageBox.Show("Debe ingresar la Cedula/Ruc o Identificador", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }

                if (txt_direccion.Text == "" || txt_direccion.Text == null)
                {
                    MessageBox.Show("Debe ingresar la dirección.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }

                Cl_NaturalezaPerso clNa = new Cl_NaturalezaPerso();
                clNa = UCNaturaleza.get_Naturaleza();


                switch (clNa.codigo.Trim())
                {
                    case "NATUR":
                        sNombreCompleto = txt_apellidos.Text.Trim() + " " + txt_nombres.Text.Trim();
                        if (txt_apellidos.Text == string.Empty || txt_nombres.Text == string.Empty)
                        {
                            MessageBox.Show("Debe Ingresar apellido y nombre para personas Naturales ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Valido = false;
                        }
                        break;

                    case "JURID":
                        sNombreCompleto = txt_razonSocial.Text.Trim();
                        if (txt_razonSocial.Text == string.Empty)
                        {
                            MessageBox.Show("Debe Ingresar la Razon social para personas Juridicas", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Valido = false;
                        }
                        break;

                    default:
                        sNombreCompleto = txt_apellidos.Text.Trim() + " " + txt_nombres.Text.Trim() + " - " + txt_razonSocial.Text.Trim();
                        if (txt_razonSocial.Text == string.Empty && txt_apellidos.Text == string.Empty)
                        {
                            MessageBox.Show("Debe Ingresar al menos Razon social o Apellido ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Valido = false;
                        }
                        break;
                }
                txt_nombreCompleto.Text = sNombreCompleto;
                return Valido;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        public void iniciar()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Set_Accion_in_Controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_Persona_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_Persona_in_controls();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_Persona_in_controls();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void get_Persona()
        {
            try
            {
                _PersonaInfo.pe_apellido = this.txt_apellidos.Text;
                _PersonaInfo.pe_casilla = this.txt_casilla.Text;
                _PersonaInfo.pe_celular = this.txt_celular.Text;
                _PersonaInfo.pe_correo = this.txt_correo.Text;
                _PersonaInfo.pe_direccion = this.txt_direccion.Text;
                _PersonaInfo.pe_fax = this.txt_Fax.Text;
                _PersonaInfo.pe_nombreCompleto = this.txt_nombreCompleto.Text;
                _PersonaInfo.pe_nombre = this.txt_nombres.Text;
                _PersonaInfo.pe_razonSocial = this.txt_razonSocial.Text;
                _PersonaInfo.pe_cedulaRuc = this.txt_Ruc.Text;
                _PersonaInfo.pe_telefonoCasa = this.txt_telefonoCasa.Text;
                _PersonaInfo.pe_telfono_Contacto = this.txt_telefonoContacto.Text;
                _PersonaInfo.pe_telefonoInter = this.txt_telefonoInter.Text;
                _PersonaInfo.pe_telefonoOfic = this.txt_TeleOficina.Text;
                _PersonaInfo.IdPersona = Convert.ToInt32(this.lblIdPersona.Text);
                _PersonaInfo.pe_fechaNacimiento = dtp_fechaNacimiento.Value;
                _PersonaInfo.pe_fechaModificacion = DateTime.Now;


                _PersonaInfo.pe_estado = (chkEstado.Checked == true) ? "A" : "I";

                UCEstadoCivil.cargar_Combo();
                Cl_EstadoCivil_Info estaCivil = new Cl_EstadoCivil_Info();
                estaCivil = this.UCEstadoCivil.get_estadoCivil();
                _PersonaInfo.IdEstadoCivil = estaCivil.codigo;

                Cl_Sexo_Info sexoI = new Cl_Sexo_Info();
                sexoI = this.UCGenero.get_sexo();
                _PersonaInfo.pe_sexo = sexoI.codigo;

                Cl_NaturalezaPerso Natu = new Cl_NaturalezaPerso();
                Natu = this.UCNaturaleza.get_Naturaleza();
                _PersonaInfo.pe_Naturaleza = Natu.codigo;

                Cl_TipoDoc_Personales_Info docu = new Cl_TipoDoc_Personales_Info();
                docu = this.UCDocumento.get_TipoDoc_Personales();
                _PersonaInfo.IdTipoDocumento = docu.codigo;

                _PersonaInfo.IdTipoPersona = 1;

                _PersonaInfo.pe_correo_secundario1 = Convert.ToString(txtCorreoSecun.EditValue);
                _PersonaInfo.pe_correo_secundario2 = Convert.ToString(txtCorreoAlterno.EditValue);
                _PersonaInfo.IdBanco_acreditacion = cmb_Banco.get_BancoInfo().IdBanco;
                _PersonaInfo.IdTipoCta_acreditacion_cat = ucRo_CatalogoTipoCta.get_Catalogo().CodCatalogo;
                _PersonaInfo.num_cta_acreditacion = txtnumCta.Text;
             


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void set_Persona(tb_persona_Info personI)
        {
            _PersonaInfo = personI;
        }

        public void set_Persona_in_controls()
        {
            try
            {
                this.txt_apellidos.Text = _PersonaInfo.pe_apellido;
                this.txt_casilla.Text = _PersonaInfo.pe_casilla;
                this.txt_celular.Text = _PersonaInfo.pe_celular;
                this.txt_correo.Text = _PersonaInfo.pe_correo;
                this.txt_direccion.Text = _PersonaInfo.pe_direccion;
                this.txt_Fax.Text = _PersonaInfo.pe_fax;
                this.txt_nombreCompleto.Text = _PersonaInfo.pe_nombreCompleto;
                this.txt_nombres.Text = _PersonaInfo.pe_nombre;
                this.txt_razonSocial.Text = _PersonaInfo.pe_razonSocial;
                this.txt_Ruc.Text = _PersonaInfo.pe_cedulaRuc;
                this.txt_telefonoCasa.Text = _PersonaInfo.pe_telefonoCasa;
                this.txt_telefonoContacto.Text = _PersonaInfo.pe_telfono_Contacto;
                this.txt_telefonoInter.Text = _PersonaInfo.pe_telefonoInter;
                this.txt_TeleOficina.Text = _PersonaInfo.pe_telefonoOfic;
                this.lblIdPersona.Text = _PersonaInfo.IdPersona.ToString();
                chkEstado.Checked = (_PersonaInfo.pe_estado == "A") ? true : false;
                if (_PersonaInfo.pe_fechaNacimiento == null) dtp_fechaNacimiento.Value = DateTime.Now; else dtp_fechaNacimiento.Value = Convert.ToDateTime(_PersonaInfo.pe_fechaNacimiento);
                this.UCEstadoCivil.set_estadoCivil(_PersonaInfo.IdEstadoCivil);
                this.UCGenero.set_sexo(_PersonaInfo.pe_sexo);
                this.UCNaturaleza.set_Naturaleza(_PersonaInfo.pe_Naturaleza);
                this.UCDocumento.set_TipoDoc_Personales(_PersonaInfo.IdTipoDocumento);

                txtCorreoSecun.EditValue = _PersonaInfo.pe_correo_secundario1;
                txtCorreoAlterno.EditValue = _PersonaInfo.pe_correo_secundario2;
                if(_PersonaInfo.IdBanco_acreditacion!=null)
                cmb_Banco.set_BancoInfo(Convert.ToInt32( _PersonaInfo.IdBanco_acreditacion));

                if (_PersonaInfo.IdTipoCta_acreditacion_cat != null)
                    ucRo_CatalogoTipoCta.set_item(_PersonaInfo.IdTipoCta_acreditacion_cat);
                

                if (_PersonaInfo.num_cta_acreditacion != null)
                    txtnumCta.Text = _PersonaInfo.num_cta_acreditacion;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_Ruc_Validating(object sender, CancelEventArgs e)
        {
            string mensaje = "";

            try
            {
                if (PersoB.VericarCedulaExiste(txt_Ruc.Text.Trim(), ref mensaje) == true)
                {
                    MessageBox.Show("Ya Existe una persona con esta cedula verfique : " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void LimpiarDatos()
        {
            try
            {
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                _PersonaInfo = new tb_persona_Info();
                txt_apellidos.Text = "";
                txt_casilla.Text = "";
                txt_celular.Text = "";
                txt_correo.Text = "";
                txt_direccion.Text = "";
                txt_Fax.Text = "";
                txt_nombreCompleto.Text = "";
                txt_nombres.Text = "";
                txt_razonSocial.Text = "";
                txt_Ruc.Text = "";
                txt_telefonoCasa.Text = "";
                txt_telefonoContacto.Text = "";
                txt_telefonoInter.Text = "";
                txt_TeleOficina.Text = "";
                this.lblIdPersona.Text = "";
                chkEstado.Checked = true;

                txtCorreoSecun.EditValue = "";
                txtCorreoAlterno.EditValue = "";
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCGe_Mant_Persona_Load(object sender, EventArgs e)
        {
            try
            {
                IniciarControles();
                Set_Accion_in_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_Ruc_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txt_Ruc.Text == null || txt_Ruc.Text == "")
                {
                    return;
                }

                string men = "";
                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    if (!PersoB.Verifica_Ruc(Convert.ToString(txt_Ruc.Text), ref men))
                    {
                        MessageBox.Show(men);
                    }
                }
                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {
                    if (!PersoB.Verifica_Ruc(Convert.ToString(txt_Ruc.Text), ref men))
                    {
                        MessageBox.Show(men);
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