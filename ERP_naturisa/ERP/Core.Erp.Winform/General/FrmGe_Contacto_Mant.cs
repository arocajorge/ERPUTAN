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

namespace Core.Erp.Winform.General
{
    public partial class FrmGe_Contacto_Mant : Form
    {
        #region Variables
        private Cl_Enumeradores.eTipo_action Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_contacto_Info info_contacto = new tb_contacto_Info();
        tb_contacto_Bus  bus_contacto = new tb_contacto_Bus();
        tb_persona_bus Bus_Persona = new tb_persona_bus();
        tb_persona_Info infoPersona = new tb_persona_Info();
        string MensajeError = "";
        

        public delegate void delegate_FormGe_Contacto_Mant_FormClosing(object sender, FormClosingEventArgs e,tb_contacto_Info InfoContacto_out);
        public event delegate_FormGe_Contacto_Mant_FormClosing event_FormGe_Contacto_Mant_FormClosing;
        #endregion

        #region "Constructor"
        public FrmGe_Contacto_Mant()
        {
            InitializeComponent();
            event_FormGe_Contacto_Mant_FormClosing += FrmGe_Contacto_Mant_event_FormGe_Contacto_Mant_FormClosing;
        }

        void FrmGe_Contacto_Mant_event_FormGe_Contacto_Mant_FormClosing(object sender, FormClosingEventArgs e, tb_contacto_Info InfoContacto_out)
        {
            
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void set_Contacto(tb_contacto_Info info)
        {
            try
            {
                info_contacto = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Eventos"
        private void FormGe_Contacto_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }

                CargarCombos();


                if (Accion == 0)
                {
                    lblAnulado.Visible = false;
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        txt_idContacto.Text = bus_contacto.getId(param.IdEmpresa).ToString();
                        txt_idContacto.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        lblAnulado.Visible = false;
                        chkEstado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:                        
                        ucGe_Menu.Visible_bntAnular = false;
                        txt_idContacto.ReadOnly = true;
                        txt_codigoContacto.ReadOnly = true;
                        txtIdPersona.Properties.ReadOnly = true;
                        txt_cedulaRucContacto.Properties.ReadOnly = true;
                        CargarDatos();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txt_idContacto.ReadOnly = true;
                        txt_cedulaRucContacto.Properties.ReadOnly = true;
                        txt_codigoContacto.ReadOnly = true;
                        txtIdPersona.Properties.ReadOnly = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        CargarDatos();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        txt_idContacto.ReadOnly = true;
                        txt_codigoContacto.ReadOnly = true;
                        txtIdPersona.Properties.ReadOnly = true;
                        txt_cedulaRucContacto.Properties.ReadOnly = true;
                        CargarDatos();
                        break;
                }                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormGe_Contacto_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              
                event_FormGe_Contacto_Mant_FormClosing(sender, e,info_contacto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if(Anular())
                   Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }
        #endregion

        #region "Carga Datos"
        public void CargarDatos()
        {
            try
            {               
                //txtEmpresa.Text = Convert.ToString(info_contacto.IdEmpresa); 
                txtIdPersona.Text = Convert.ToString(info_contacto.IdPersona);
                txt_idContacto.Text = Convert.ToString(info_contacto.IdContacto);
                txt_codigoContacto.Text = info_contacto.CodContacto;
                txtOrganizacion.Text = info_contacto.Organizacion;
                txtCargo.Text = info_contacto.Cargo;
                txtMostrar_como.Text = info_contacto.Mostrar_como;
                txtNotas.Text = info_contacto.Notas;
                txtPaginaweb.Text = info_contacto.Pagina_Web;
                txtCodigoPostal.Text = info_contacto.Codigo_postal;
                txtMostrar_como.Text = info_contacto.Mostrar_como;

                ucGe_PaisProvinciaCiudad.set_InfoCiudad(info_contacto.IdCiudad.ToString());
                ucGe_PaisProvinciaCiudad.set_InfoProvincia(info_contacto.IdProvincia.ToString());
                ucGe_PaisProvinciaCiudad.set_InfoPais(info_contacto.IdPais.ToString());
                cmbNacionalidad.SelectedValue = info_contacto.IdNacionalidad.ToString();                

                txtIdPersona.Text = Convert.ToString(info_contacto.Persona_Info.IdPersona);
                txtApellido.Text = info_contacto.Persona_Info.pe_apellido;
                txt_nombresContacto.Text = info_contacto.Persona_Info.pe_nombre;
                txt_celular.Text = info_contacto.Persona_Info.pe_celular;
                txt_telefono.Text = info_contacto.Persona_Info.pe_telefonoCasa;
                txt_Direccion.Text = info_contacto.Persona_Info.pe_direccion;
                txt_cedulaRucContacto.Text = info_contacto.Persona_Info.pe_cedulaRuc;
                txtRazonSocial.Text = info_contacto.Persona_Info.pe_razonSocial;
                if(info_contacto.Persona_Info.pe_Naturaleza !=null)
                this.ucGe_NaturalezaPersona1.set_Naturaleza(info_contacto.Persona_Info.pe_Naturaleza);

                ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue = (info_contacto.Persona_Info.IdTipoDocumento == null) ? "CED" : info_contacto.Persona_Info.IdTipoDocumento;

                if (info_contacto.Fecha_alta != null && info_contacto.Fecha_alta != DateTime.MinValue)
                {
                    dT_FechaContacto.Value = Convert.ToDateTime((info_contacto.Fecha_alta != DateTime.MinValue) ? Convert.ToDateTime(info_contacto.Fecha_alta) : DateTime.Now.AddYears(-200));
                    dT_FechaContacto.Checked = (info_contacto.Fecha_alta != DateTime.MinValue) ? true : false;
                }
                if (info_contacto.Persona_Info.pe_fechaNacimiento != null)
                {
                    dt_fechaNacimiento.Value = Convert.ToDateTime((info_contacto.Persona_Info.pe_fechaNacimiento != DateTime.MinValue) ? Convert.ToDateTime(info_contacto.Persona_Info.pe_fechaNacimiento) : DateTime.Now.AddYears(-200));
                    dt_fechaNacimiento.Checked = (info_contacto.Persona_Info.pe_fechaNacimiento != DateTime.MinValue) ? true : false;
                }
                else
                {
                    dt_fechaNacimiento.Checked = false;
                }
                if (info_contacto.Fecha_Ult_Contacto != null && info_contacto.Fecha_Ult_Contacto != DateTime.MinValue)
                {
                    dt_fechaUltimaContacto.Value = Convert.ToDateTime((info_contacto.Fecha_Ult_Contacto != DateTime.MinValue) ? Convert.ToDateTime(info_contacto.Fecha_Ult_Contacto) : DateTime.Now.AddYears(-200));
                    dt_fechaUltimaContacto.Checked = (info_contacto.Fecha_Ult_Contacto != DateTime.MinValue) ? true : false;
                }
                chkEstado.Checked = (info_contacto.Estado == "A") ? true : false;
                if (info_contacto.Estado == "A")
                {
                    lblAnulado.Visible = false;
                }
                else
                {
                    if (info_contacto.Estado != null)
                    {
                        lblAnulado.Visible = true;
                    }
                }


                if (info_contacto.foto == null)
                {
                    tb_contacto_Bus BusConta = new tb_contacto_Bus();
                    byte[] foto = null;
                   foto= BusConta.Get_Image_x_contacto(info_contacto.IdEmpresa, info_contacto.IdContacto, ref MensajeError);
                   if (foto != null)
                   {
                       pic_foto.Image = Funciones.ArrayAImage(foto);
                   }
                }

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region "Get"
        public tb_contacto_Info GetContacto(ref string mensaje)
        {
            try
            {
                info_contacto = new tb_contacto_Info();
                info_contacto.IdEmpresa = param.IdEmpresa;
                info_contacto.IdContacto = Convert.ToInt32(txt_idContacto.Text.Trim());
                info_contacto.IdPersona = (txtIdPersona == null || txtIdPersona.Text.Trim() == "") ? 0 : Convert.ToDecimal(txtIdPersona.Text.Trim());
                info_contacto.CodContacto = Convert.ToString((txt_codigoContacto.Text == "" ? "" : txt_codigoContacto.Text).Trim());
                info_contacto.Organizacion = txtOrganizacion.Text.Trim();
                info_contacto.Cargo = txtCargo.Text.Trim();
                info_contacto.Mostrar_como = txtMostrar_como.Text.Trim();                
                info_contacto.Codigo_postal = txtCodigoPostal.Text.Trim();                
                info_contacto.Pagina_Web = txtPaginaweb.Text.Trim();
                info_contacto.Notas = txtNotas.Text.Trim();
                info_contacto.Estado = (chkEstado.Checked == true) ? "A" : "I";
                info_contacto.Fecha_Ult_Contacto = Convert.ToDateTime(this.dt_fechaUltimaContacto.Value);
                info_contacto.Fecha_alta = Convert.ToDateTime(this.dT_FechaContacto.Value);

                if (ucGe_PaisProvinciaCiudad.get_Info_Ciudad() != null)
                    info_contacto.IdCiudad = ucGe_PaisProvinciaCiudad.get_Info_Ciudad().IdCiudad;
                if (ucGe_PaisProvinciaCiudad.get_Info_Pais() != null)
                    info_contacto.IdPais = ucGe_PaisProvinciaCiudad.get_Info_Pais().IdPais;
                if (ucGe_PaisProvinciaCiudad.get_Info_Provincia() != null)
                    info_contacto.IdProvincia = ucGe_PaisProvinciaCiudad.get_Info_Provincia().IdProvincia;

                info_contacto.IdNacionalidad = cmbNacionalidad.SelectedValue.ToString();
                

                if (pic_foto.Image == null)
                { info_contacto.foto = null; }
                else info_contacto.foto = Funciones.ImageAArray(pic_foto.Image);

                tb_persona_Info infoPersona = new tb_persona_Info();                
                infoPersona.IdPersona = (txtIdPersona == null || txtIdPersona.Text.Trim() == "") ? 0 : Convert.ToDecimal(txtIdPersona.Text.Trim());                
                infoPersona.IdTipoDocumento = ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue.ToString();
                infoPersona.pe_cedulaRuc = this.txt_cedulaRucContacto.Text.Trim();
                infoPersona.pe_nombre = this.txt_nombresContacto.Text.Trim();
                infoPersona.pe_apellido = this.txtApellido.Text.Trim();
                infoPersona.pe_nombreCompleto = this.txt_nombresContacto.Text.Trim() + " " + this.txtApellido.Text.Trim();
                infoPersona.pe_razonSocial = this.txtRazonSocial.Text.Trim();

                Cl_NaturalezaPerso Natu = new Cl_NaturalezaPerso();
                Natu = this.ucGe_NaturalezaPersona1.get_Naturaleza();
                infoPersona.pe_Naturaleza = Natu.codigo;
                //infoPersona.pe_Naturaleza = "NATU";
                
                infoPersona.IdEstadoCivil = "SOLTE";
                infoPersona.IdTipoPersona = 2;
                infoPersona.pe_sexo = "SEXO_MAS";
                infoPersona.pe_direccion = txt_Direccion.Text.Trim();
                infoPersona.pe_telefonoCasa = txt_telefono.Text.Trim();
                infoPersona.pe_celular = txt_celular.Text.Trim();
                if (dt_fechaNacimiento.Checked == true)
                    infoPersona.pe_fechaNacimiento = Convert.ToDateTime(this.dt_fechaNacimiento.Value);
                else
                    infoPersona.pe_fechaNacimiento = null;
                infoPersona.pe_fechaModificacion = DateTime.Now;
                infoPersona.pe_UltUsuarioModi = param.IdUsuario;
                infoPersona.pe_estado = "A";

                tb_pais_Info infoPais = new tb_pais_Info();               
                infoPais.IdPais = cmbNacionalidad.SelectedValue.ToString();
               
                
                //carga la informacion de los combos
                info_contacto.Persona_Info = infoPersona;
                info_contacto.Pais_Info = infoPais; 
               
                return info_contacto;
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return new tb_contacto_Info();
            }
        }
        #endregion

        #region "Grabar,Actualizar,Eliminar"
        public bool guardarDatos()
        {
            bool resultado = false;
            try
            {
                if (Validaciones())
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Boolean Grabar()
        {
            bool resultado = false;
            try
            {
                string mensaje = string.Empty;
                info_contacto = new tb_contacto_Info();
                bus_contacto = new tb_contacto_Bus();

                info_contacto = GetContacto(ref mensaje);
                info_contacto.FechaCreacion = DateTime.Now;
                info_contacto.UsuarioCreacion = param.IdUsuario;               
                resultado = bus_contacto.GuardarContacto(info_contacto, info_contacto.IdContacto, ref mensaje);
                if (resultado == true)
                {                    
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu.Visible_btnGuardar = true;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public Boolean Actualizar()
        {
            bool resultado = false;
            try
            {
                string mensaje = string.Empty;
                info_contacto = new tb_contacto_Info();
                bus_contacto = new tb_contacto_Bus();

                info_contacto = GetContacto(ref mensaje);
                info_contacto.UsuarioModificacion = param.IdUsuario;
                info_contacto.FechaModificacion = DateTime.Now;
                resultado = bus_contacto.ActualizarContacto(info_contacto, ref mensaje);
                if (resultado == true)
                {
                    MessageBox.Show(mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                    this.ucGe_Menu.Visible_btnGuardar = true;
                    lblAnulado.Visible = false;
                    this.Accion = Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
                else
                {
                    Log_Error_bus.Log_Error(mensaje.ToString());
                    MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return resultado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        private Boolean Anular()
        {
            try
            {                
                if (info_contacto.Estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Contacto #:" + txt_idContacto.Text.Trim() + " ?", "Anulación de Mantenimiento Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();

                        bus_contacto = new tb_contacto_Bus();
                        info_contacto = new tb_contacto_Info();
                        
                        string mensaje = string.Empty;

                        info_contacto = GetContacto(ref mensaje);
                        if (mensaje != "")
                        {
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        info_contacto.UsuarioAnulacion = param.IdUsuario;
                        info_contacto.FechaAnulacion = DateTime.Now;
                        info_contacto.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = bus_contacto.AnularContacto(info_contacto, ref mensaje);
                        if (resultado)
                        {
                            MessageBox.Show("Se ha anulado correctamente el Contacto #: " + txt_idContacto.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            this.ucGe_Menu.Visible_btnGuardar = false;
                            return true;
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        
                    }
                    else
                        return false;
                }
                else
                {
                    MessageBox.Show("El Contacto #:" + txt_idContacto.Text.Trim() + " ya se encuentra anulado.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public void CargarCombos()
        {
            try
            {
                 tb_pais_Bus negPais = new tb_pais_Bus();
                cmbNacionalidad.DataSource = negPais.Get_List_pais();
                cmbNacionalidad.SelectedValue = "1";

                ucGe_PaisProvinciaCiudad.CargarComboPais();
                ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue = "1";
                ucGe_PaisProvinciaCiudad.cmbPais.EditValue = "1";
                ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue = "1";

                ucGe_NaturalezaPersona1.cargar_Combo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (this.txt_cedulaRucContacto.Text != "")
                    {
                        if (txt_cedulaRucContacto.Text.TrimStart().TrimEnd().Length != 10)
                        {
                            MessageBox.Show("Cédula Incorrecta", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txt_cedulaRucContacto.Text, ref msj))
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

                    if (txt_cedulaRucContacto.Text != "")
                    {
                        if (txt_cedulaRucContacto.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("RUC Incorrecto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (txt_cedulaRucContacto.Text.TrimStart().TrimEnd().Length != 13)
                        {


                            MessageBox.Show("RUC Incorrecto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txt_cedulaRucContacto.Text, ref msj))
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public bool Buscar_x_Contacto(ref string mensaje)
        {
            try
            {

                bus_contacto = new tb_contacto_Bus();
                bool existe = bus_contacto.ExisteContacto(param.IdEmpresa, Convert.ToDecimal(txt_idContacto.Text.Trim()), Convert.ToDecimal(txtIdPersona.Text.Trim()), ref mensaje);

                return existe;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Buscar_x_Persona(ref string mensaje)
        {
            try
            {
                Bus_Persona = new tb_persona_bus();
                bool existe = Bus_Persona.VericarCedulaExiste(txt_cedulaRucContacto.Text.Trim(), ref mensaje);
                return existe;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public void ObtenerDatos_x_Cedula()
        {
            try
            {
                string msj = string.Empty;
                Bus_Persona  = new tb_persona_bus();
                infoPersona = new tb_persona_Info();
                bus_contacto = new tb_contacto_Bus();
                info_contacto = new tb_contacto_Info();
                infoPersona = Bus_Persona.Get_Info_Persona(txt_cedulaRucContacto.Text.Trim());
                if (infoPersona != null)
                {
                    if (infoPersona.IdPersona != 0)
                    {
                        info_contacto = bus_contacto.Get_Info_contacto_x_Persona(param.IdEmpresa, infoPersona.IdPersona, ref msj);
                        if (info_contacto != null)
                        {
                            if (info_contacto.IdContacto != 0)
                            {
                                info_contacto.IdContacto = info_contacto.IdContacto;
                                info_contacto.IdEmpresa = info_contacto.IdEmpresa;
                                info_contacto.IdPais = info_contacto.IdPais;
                                info_contacto.IdProvincia = info_contacto.IdProvincia;
                                info_contacto.IdCiudad = info_contacto.IdCiudad;
                                info_contacto.IdNacionalidad = info_contacto.IdNacionalidad;
                                info_contacto.Organizacion = info_contacto.Organizacion;
                                info_contacto.CodContacto = info_contacto.CodContacto;
                                info_contacto.Cargo = info_contacto.Cargo;
                                info_contacto.Pagina_Web = info_contacto.Pagina_Web;
                                info_contacto.Notas = info_contacto.Notas;
                                info_contacto.Mostrar_como = info_contacto.Mostrar_como;
                                info_contacto.Codigo_postal = info_contacto.Codigo_postal;
                                info_contacto.Fecha_alta = info_contacto.Fecha_alta;
                                info_contacto.Fecha_Ult_Contacto = info_contacto.Fecha_Ult_Contacto;
                                //info_contacto.foto = info_contacto.foto;
                                txt_idContacto.ReadOnly = true;
                                txt_codigoContacto.ReadOnly = true;
                            }
                            
                        }
                        txt_cedulaRucContacto.Properties.ReadOnly = true;
                        txtIdPersona.Properties.ReadOnly = true;
                    }
                    info_contacto.Persona_Info.IdPersona = infoPersona.IdPersona;
                    info_contacto.Persona_Info.pe_nombre = infoPersona.pe_nombre;
                    info_contacto.Persona_Info.pe_apellido = infoPersona.pe_apellido;
                    info_contacto.Persona_Info.pe_cedulaRuc = infoPersona.pe_cedulaRuc;
                    info_contacto.Persona_Info.pe_fechaNacimiento = infoPersona.pe_fechaNacimiento;
                    info_contacto.Persona_Info.pe_Naturaleza = infoPersona.pe_Naturaleza;
                    info_contacto.Persona_Info.pe_razonSocial = infoPersona.pe_razonSocial;
                    info_contacto.Persona_Info.pe_direccion = infoPersona.pe_direccion;
                    //info_contacto.Persona_Info.pe_sexo = infoPersona.pe_sexo;
                    info_contacto.Persona_Info.pe_telefonoCasa = infoPersona.pe_telefonoCasa;
                    info_contacto.Persona_Info.IdTipoDocumento = infoPersona.IdTipoDocumento;
                    info_contacto.Persona_Info.pe_celular = infoPersona.pe_celular;
                    info_contacto.Persona_Info.pe_estado = infoPersona.pe_estado;
                    info_contacto.Estado = infoPersona.pe_estado;
                    
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void Limpiar()
        {
            //txtEmpresa.Text = string.Empty;
            txtIdPersona.Text = "0";
            txt_idContacto.Text = "0";
            txt_codigoContacto.Text = string.Empty;
            txtOrganizacion.Text = string.Empty;
            txtMostrar_como.Text = string.Empty;
            txtNotas.Text = string.Empty;
            txtPaginaweb.Text = string.Empty;
            txtCodigoPostal.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtPaginaweb.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            //ucGe_PaisProvinciaCiudad.CargarComboPais();
            ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue = "1";
            ucGe_PaisProvinciaCiudad.cmbPais.EditValue = "1";
            ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue = "1";
           
            cmbNacionalidad.SelectedValue = "1";
            ucGe_NaturalezaPersona1.cargar_Combo();
            
            pic_foto.Image = null;

            txtApellido.Text = string.Empty;
            txt_nombresContacto.Text = string.Empty;
            txt_celular.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_Direccion.Text = string.Empty;
            txt_cedulaRucContacto.Text = string.Empty;
            txt_cedulaRucContacto.Properties.ReadOnly = false;
            //ucGe_Docu_PerIdentificacion.cmb_Docum_perso.SelectedValue = string.Empty;

            dt_fechaNacimiento.Value =  DateTime.Now;
            dt_fechaNacimiento.Checked = false;
            dT_FechaContacto.Value = DateTime.Now;
            dT_FechaContacto.Checked = true;
            dt_fechaUltimaContacto.Value = DateTime.Now;
            dt_fechaUltimaContacto.Checked = true;

            chkEstado.Checked = true ;
        }

        public Boolean Validaciones()
        {
            Boolean correcto = true;
            if (string.IsNullOrEmpty(txt_cedulaRucContacto.Text))
            {
                MessageBox.Show("Digite Cedula o Ruc", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_cedulaRucContacto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Digite Apellidos", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtApellido.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_nombresContacto.Text))
            {
                MessageBox.Show("Digite Nombres", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_nombresContacto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txt_Direccion.Text))
            {
                MessageBox.Show("Digite Dirección", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtOrganizacion.Focus();
                correcto = false;
            }
            if (string.IsNullOrEmpty(txt_celular.Text))
            {
                MessageBox.Show("Digite # celular", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCargo.Focus();
                return false;
            }
            if (cmbNacionalidad.SelectedValue == null || cmbNacionalidad.SelectedValue == "")
            {
                MessageBox.Show("Seleccione la nacionalidad del Contacto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbNacionalidad.Focus();
                return false;
            }
            if (ucGe_PaisProvinciaCiudad.cmbPais.Text == "")
            {
                MessageBox.Show("Seleccione el País de Ubicación del Contacto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ucGe_PaisProvinciaCiudad.cmbPais.Focus();
                return false;
            }
            if (ucGe_PaisProvinciaCiudad.cmbProvincia.Text == "")
            {
                MessageBox.Show("Seleccione la Provincia de ubicación del Contacto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ucGe_PaisProvinciaCiudad.cmbProvincia.Focus();
                return false;
            }
            if (ucGe_PaisProvinciaCiudad.cmbCiudad.Text == "")
            {
                MessageBox.Show("Seleccione la Ciudad de Ubicación del Contacto", "Operación Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ucGe_PaisProvinciaCiudad.cmbCiudad.Focus();
                return false;
            }
           
            return correcto;
        }

        #endregion

        #region "Buscar_cedula"
        private void txt_cedulaRucContacto_Leave(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                if (txt_cedulaRucContacto.Text != "" && txt_cedulaRucContacto.Properties.ReadOnly == false)
                {
                    if (ValidarCedula())
                    {
                        if (Buscar_x_Persona(ref mensaje))
                        {
                            ObtenerDatos_x_Cedula();
                            CargarDatos();
                            if (Buscar_x_Contacto(ref mensaje))
                            {
                                MessageBox.Show("# de Contacto ya esta ingresado  : ", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            }
                        }
                        else
                            dt_fechaNacimiento.Checked = false;


                    }
                    else
                        Limpiar();

                } 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region "Cargar Foto"
        private void pic_foto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pu_Abrir_Imagen();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void pu_Abrir_Imagen()
        {

            try
            {
                OpenFileDialog EscojaFoto = new OpenFileDialog();
                EscojaFoto.InitialDirectory = "c:\\";
                EscojaFoto.Filter = "JPG FILES (*.JPG)|*.jpg|GIF FILES (*.GIF)|*.gif|JPEG FILES (*.JPEG)|*.jpeg";
                EscojaFoto.RestoreDirectory = true;
                EscojaFoto.ShowDialog();

                if (EscojaFoto.FileName != "")
                {
                    pic_foto.Image = Image.FromFile(EscojaFoto.FileName);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion


    }
}
