using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Controles;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ClienteMantenimiento : Form
    {
        public FrmPrd_ClienteMantenimiento()
        {
            try
            {
             InitializeComponent();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                event_FrmPrd_ClienteMantenimiento_FormClosing += FrmPrd_ClienteMantenimiento_event_FrmPrd_ClienteMantenimiento_FormClosing;
                ucGe.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
                ucGe.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               // ucGe

           
                UC_Doc_per.event_cmb_Docum_perso_SelectedValueChanged += UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        void UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                info_persona = new tb_persona_Info();
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();



                if (info_doc_personal.codigo == "CED" || info_doc_personal.codigo == "PAS")
                {
                    label13.Visible = true;
                    cmbSexo.Visible = true;
                    CmbEstadoCivil.Visible = true;
                    lbEstadoCivil.Visible = true;
                }
                else
                {
                    label13.Visible = false;
                    cmbSexo.Visible = false;
                    CmbEstadoCivil.Visible = false;
                    lbEstadoCivil.Visible = false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        void FrmPrd_ClienteMantenimiento_event_FrmPrd_ClienteMantenimiento_FormClosing(object sender, FormClosingEventArgs e){}
        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Boolean IdPersona_Registrada = false;
        Boolean IdCliente_Registrado = false;
        decimal id_persona = 0;
        decimal id_cliente = 0;
        UCGe_Docu_Personales UC_Doc_per = new UCGe_Docu_Personales();
        
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;

        fa_Cliente_Info info = new fa_Cliente_Info();
        fa_Cliente_Info info_tmp = new fa_Cliente_Info();
        //tb_ubicacion_Info info_ubicacion = new tb_ubicacion_Info();
        tb_persona_Info info_persona = new tb_persona_Info();
        Cl_TipoDoc_Personales_Info info_doc_personal = new Cl_TipoDoc_Personales_Info();

        List<ct_Plancta_Info> listaPLan = new List<ct_Plancta_Info>();
        List<Cl_TipoCliente_Info> ListaTipoCliente = new List<Cl_TipoCliente_Info>();
        List<Cl_Categoria_Financiera_Info> ListaCategoria = new List<Cl_Categoria_Financiera_Info>();
        List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();
        List<Cl_ActividadEconomica_Info> lista_actividad_economica = new List<Cl_ActividadEconomica_Info>();
        List<tb_persona_Info> listaPersona = new List<tb_persona_Info>();
        List<fa_Cliente_Info> listaCliente = new List<fa_Cliente_Info>();
        List<tb_Catalogo_Info> ListadoSexo = new List<tb_Catalogo_Info>();

        tb_Catalogo_Bus BusCastalogo = new tb_Catalogo_Bus();


        #endregion

        private void FrmPrd_ClienteMantenimiento_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString();
            try
            {
                lbl_id_cliente.Visible = true;
                load_ubicacion();
                load_tipo_doc();
                load_combos();
                Cargar_Tipo_Sexo();
                Cargar_Tipo_EstadoCivil();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                      //  this.btn_grabar.Text = "Grabar Registro";
                        this.chk_Estado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                       // this.btn_grabar.Text = "Actualizar Registro";
                        enable_objetos(true);
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                      //  this.btn_grabar.Text = "Anular Registro";

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        enable_objetos(false);

                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
                Log_Error_bus.Log_Error(ex.ToString());
            }
          }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              _Accion = iAccion;

              switch (iAccion)
              {
                  case Cl_Enumeradores.eTipo_action.grabar:
                      break;
                  case Cl_Enumeradores.eTipo_action.actualizar:
                      ucGe.Enabled_bntAnular = false;
                      break;
                  case Cl_Enumeradores.eTipo_action.Anular:
                      break;
                  case Cl_Enumeradores.eTipo_action.consultar:
                       ucGe.Enabled_btnAceptar = false;
                       ucGe.Enabled_bntGuardar_y_Salir = false;
                       ucGe.Enabled_btnGuardar = false;
                       ucGe.Enabled_bntAnular = false;
                      break;
                  case Cl_Enumeradores.eTipo_action.duplicar:
                      break;
                  default:
                      break;
              }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #region metodo set y get del Cliente
        public void set_Cliente(fa_Cliente_Info obj)
        {
           
            try
            {
                info = new fa_Cliente_Info();
                    lbl_id_cliente.Text = obj.IdCliente.ToString();
                    lbl_id_persona.Text = obj.IdPersona.ToString();
                    txt_nombres.Text = obj.Persona_Info.pe_nombre.Trim();
                    txt_apellidos.Text = obj.Persona_Info.pe_apellido.Trim();
                    txt_cedula.Text = obj.Persona_Info.pe_cedulaRuc.Trim();
                    txt_direccion.Text = obj.Persona_Info.pe_direccion.Trim();
                    chk_Estado.Checked = (obj.Estado == "A") ? true : false;
                    txt_razon_social.Text = obj.Persona_Info.pe_razonSocial.Trim();//55
                    txt_telefono_ofic.Text = obj.Persona_Info.pe_telefonoOfic.Trim();
                    txtcorreo.Text = info.cl_Mail_Garante;
                    ucGe_Sucursal_combo1.set_SucursalInfo(obj.IdSucursal);
                    cmb_Tipo.EditValue = obj.Idtipo_cliente;
                    txtcorreo.Text = obj.cl_Mail_Rep_Legal;
                    txt_observacion.Text = obj.cl_observacion;
                    
                    txt_casilla.Text = obj.cl_casilla;
                    txt_fax.Text = obj.cl_fax;

                    ucGe_PaisProvinciaCiudad.set_InfoPais(obj.IdPais);
                    ucGe_PaisProvinciaCiudad.set_InfoProvincia(obj.IdProvincia);
                    ucGe_PaisProvinciaCiudad.set_InfoCiudad(obj.IdCiudad);
                                    
                    cmb_actividad_economica.EditValue = "ACTCOMCL_001";
                    UC_Doc_per.set_TipoDoc_Personales(obj.Persona_Info.IdTipoDocumento);
                    if (obj.Persona_Info.IdTipoDocumento == "CED" || obj.Persona_Info.IdTipoDocumento == "PAS")
                    {
                       
                        cmbSexo.Visible = true;
                        CmbEstadoCivil.Visible = true;
                        cmbSexo.EditValue = obj.Persona_Info.pe_sexo;
                        CmbEstadoCivil.EditValue = obj.Persona_Info.IdEstadoCivil;
                    }
                    else
                    {
                        cmbSexo.Visible = false;
                        CmbEstadoCivil.Visible = false;
                    }
                    txtcorreo.Text = obj.Mail_Principal;
                    info = obj;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        public fa_Cliente_Info get_Cliente()
        {
           // if (ValidarCajasTexto() == true)
            //{ return; }
            try
            {
                
                // clase cliente                
                info = new fa_Cliente_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdCliente = (lbl_id_cliente.Text != "") ? Convert.ToInt32(lbl_id_cliente.Text) : 0;
                info.IdPersona = (lbl_id_persona.Text != "") ? Convert.ToDecimal(lbl_id_persona.Text) : 0;
                id_persona = Convert.ToDecimal(info.IdPersona);
                info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                info.IdVendedor = 0;
                info.Idtipo_cliente = Convert.ToInt32(cmb_Tipo.EditValue);
                info.IdTipoCredito = "CRE";
                info.cl_Cat_crediticia = "A";
                info.cl_plazo = 0;
                info.cl_porcentaje_descuento = 0;
                info.IdCtaCble_cxc = null;
                info.IdCtaCble_Anti = null;
                info.cl_Cell_Garante = null;
                info.cl_Cell_Garante = null;
                info.cl_observacion = txt_observacion.Text;
                info.IdCiudad = ucGe_PaisProvinciaCiudad.get_Info_Ciudad().IdCiudad;
                info.cl_Cupo = 0;
               info.Persona_Info.pe_razonSocial = txt_razon_social.Text;
                info.IdClienteRelacionado = null;
                info.cl_Rep_Legal = null;
                info.cl_Mail_Rep_Legal = null;
                info.cl_Cell_Rep_Legal = null;
                info.cl_Ger_Gen = null;
                info.cl_Mail_Ger_Gen = null;
                info.cl_Cell_Ger_Gen = null;
                info.cl_casilla = txt_casilla.Text; ;
                info.cl_casilla = 
                info.cl_fax = txt_fax.Text;
                info.IdActividadComercial = "NORM";
                info.IdUsuario = param.IdUsuario;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info_persona = new tb_persona_Info();
                if (chk_Estado.Checked == true)
                {
                    info_persona.pe_estado = "A";
                }
                else
                {
                    info_persona.pe_estado = "A";
                }
                info.Codigo =Convert.ToString( (lbl_id_cliente.Text != "") ? Convert.ToInt32(lbl_id_cliente.Text) : 0);

                info.Mail_Principal = txtcorreo.Text;
                // clase  persona
                
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                info_persona.IdPersona = id_persona;
                info_persona.CodPersona = id_persona.ToString();
                info_persona.pe_apellido = txt_apellidos.Text;
                info_persona.pe_nombre = txt_nombres.Text ;
                info_persona.pe_nombreCompleto = txt_apellidos.Text + " " + this.txt_nombres.Text;
                info_persona.pe_razonSocial = txt_razon_social.Text ;
                info_persona.pe_fechaNacimiento =Convert.ToDateTime( maskedTextBox1.Text);
                info_persona.pe_telefonoOfic = txt_telefono_ofic.Text ;
                info_persona.pe_telefonoInter = txt_telefono_ofic.Text ;
                info_persona.pe_celular = txt_telefono_ofic.Text;
                info_persona.pe_telefonoCasa = txt_telefono_ofic.Text ;
                info_persona.pe_telfono_Contacto = txt_telefono_ofic.Text;
                info_persona.pe_fax = txt_fax.Text;
                info_persona.pe_casilla = txt_casilla.Text;
                info_persona.IdTipoDocumento = info_doc_personal.codigo;
                info_persona.IdTipoPersona = 1;
                info_persona.IdUsuario = param.IdUsuario;
              
               // info_persona.pe_Naturaleza = " ";
                info_persona.pe_cedulaRuc = txt_cedula.Text;
                info_persona.pe_direccion = txt_direccion.Text ;
                info_persona.pe_correo = txtcorreo.Text;
                if (info_persona.IdTipoDocumento == "CED")
                {
                    info_persona.pe_sexo = cmbSexo.EditValue.ToString();
                    info_persona.IdEstadoCivil = CmbEstadoCivil.EditValue.ToString();
                    info_persona.pe_Naturaleza = "NATU";
                }
                else
                {
                    info_persona.pe_sexo = "SEXO_MAS";
                    info_persona.IdEstadoCivil = "SOLTE";
                    info_persona.pe_Naturaleza = "JURI";
                }    
                info_persona.pe_UltUsuarioModi = param.nom_pc;
                info_persona.pe_fechaCreacion = DateTime.Now;
                info_persona.pe_fechaModificacion = DateTime.Now;
                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod =Convert.ToDateTime( DateTime.Now.ToString("yyyy-MM-dd"));
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.IdVendedor = 1;
                info.cl_Cupo = 0;
                info.IdClienteRelacionado = 0;
                info.Estado = (chk_Estado.Checked == true) ? "A" : "I";
                info.Persona_Info = info_persona;
               
                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return info;
            }

        }
        #endregion

        #region load de los objetos y combos
        private void load_tipo_doc()
        {
            try
            {
                UC_Doc_per.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_Doc_per);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void load_ubicacion()
        {
            try
            {
                ucGe_PaisProvinciaCiudad.CargarComboPais();    

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Cargar_Categoria_financiera()
        {
            try
            {
                Cl_Categoria_Financiera_Info info_cat = new Cl_Categoria_Financiera_Info();
                info_cat.id = "A";
                info_cat.descripcion = "A";
                ListaCategoria.Add(info_cat);
                info_cat = new Cl_Categoria_Financiera_Info();
                info_cat.id = "B";
                info_cat.descripcion = "B";
                ListaCategoria.Add(info_cat);
                info_cat = new Cl_Categoria_Financiera_Info();
                info_cat.id = "C";
                info_cat.descripcion = "C";
                ListaCategoria.Add(info_cat);
                info_cat = new Cl_Categoria_Financiera_Info();
                info_cat.id = "D";
                info_cat.descripcion = "D";
                ListaCategoria.Add(info_cat);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void load_combos()
        {
            try
            {
               

                fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();

                tb_persona_bus bus_persona = new tb_persona_bus();



                listaPersona = bus_persona.Get_List_Persona();

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        #endregion

        private void enable_objetos(Boolean estado)
        {
            try
            {
              //  this.btn_grabar.Enabled = estado;
              //  this.btn_guardarSalir.Enabled = estado;
                this.cmb_Tipo.Enabled = estado;
                this.UC_Doc_per.Enabled = estado;
                this.txt_cedula.Enabled = estado;
                this.txt_nombres.Enabled = estado;
                this.txt_apellidos.Enabled = estado;
                this.txt_razon_social.Enabled = estado;
                this.ucGe_Sucursal_combo1.Enabled = estado;
                this.chk_Estado.Enabled = estado;
                this.txt_direccion.Enabled = estado;
                this.txt_telefono_ofic.Enabled = estado;
                this.txt_casilla.Enabled = estado;
                this.txt_fax.Enabled = estado;
                this.txt_observacion.Enabled = estado;
                this.cmb_actividad_economica.Enabled = estado;
                cmbSexo.Enabled = estado;
                CmbEstadoCivil.Enabled = estado;
                txtcorreo.Enabled = estado;
                           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void guardar()
        {
            try
            {
                string msg = "";
                Boolean Res = true;
                fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
                tb_persona_bus bus_persona = new tb_persona_bus();

              


                get_Cliente();
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (ValidarCajasTexto() == true)
                        { return; }

                         if (IdCliente_Registrado == true)
                            {
                                Res = bus_cliente.ModificarDB(info, ref msg);
                                listaCliente.Remove(info_tmp);
                                listaCliente.Add(info);
                            }
                            else
                            {
                                //Res = bus_cliente.GrabarDB(info, info_persona, ref id_persona, ref id_cliente, ref msg);                                                                                                    
                                Res = bus_cliente.GrabarDB(info, ref id_persona, ref id_cliente, ref msg);                                                                                                    
                            }

                            this.lbl_id_cliente.Text = id_cliente.ToString();
                            this.lbl_id_persona.Text = id_persona.ToString();

                            if (!Res)
                                MessageBox.Show("Error: " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                            {
                                MessageBox.Show("Se Guardo Exitosamente el Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txt_cedula.Enabled = false;
                            }
                       
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Res =  bus_cliente.ModificarDB(info, ref msg);
                        if (!Res)
                        {
                            MessageBox.Show("Error: " + msg, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Se Actualizo Exitosamente el Cliente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        break;

                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }




        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCajasTexto() == true)
                {
                    return;
                }
                guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cedula_Leave(object sender, EventArgs e)
        {
            try
            {
                var select = from A in listaPersona
                             where A.pe_cedulaRuc.Trim() == this.txt_cedula.Text
                             select A;

                if (select.ToList().Count > 0)
                {
                    foreach (var item in select)
                    {
                        id_persona = Convert.ToDecimal(item.IdPersona);
                    }

                    IdPersona_Registrada = true;

                    var select_id = from B in listaCliente
                                    where B.IdPersona == id_persona
                                    select B;

                    if (select_id.ToList().Count > 0)
                    {

                        IdCliente_Registrado = true;
                        MessageBox.Show("Cliente ya existe en la Base de Datos", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        foreach (var item in select_id)
                        {
                            fa_Cliente_Info tmp = new fa_Cliente_Info();
                            tmp = item;
                            info_tmp = new fa_Cliente_Info();
                            info_tmp = item;
                            set_Cliente(tmp);
                        }
                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                         //   this.btn_grabar.Text = "Actualizar Registro";
                        }
                    }
                    else
                    {
                        IdCliente_Registrado = false;
                    }

                    var select_persona = from A in listaPersona
                                         where A.pe_cedulaRuc.Trim() == this.txt_cedula.Text
                                         select A;
                    foreach (var item in select_persona)
                    {
                        this.lbl_id_persona.Text = item.IdPersona.ToString();
                        id_persona = item.IdPersona;
                        this.txt_nombres.Text = item.pe_nombre.Trim();
                        this.txt_apellidos.Text = item.pe_apellido.Trim();
                        this.chk_Estado.Checked = (item.pe_estado == "A") ? true : false;
                        this.txt_razon_social.Text = item.pe_razonSocial.Trim();
                        this.txt_direccion.Text = item.pe_direccion.Trim();
                        this.txt_telefono_ofic.Text = (item.pe_telefonoOfic != "") ? item.pe_telefonoOfic : " ";
                        this.txt_casilla.Text = item.pe_casilla;
                        this.txt_fax.Text = item.pe_fax;
                    }
                }
                else
                {
                    IdPersona_Registrada = false;
                    this.txt_nombres.Focus();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCajasTexto() == true)
                {
                    return;
                }
                guardar();
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public  delegate void  Delegate_FrmPrd_ClienteMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_ClienteMantenimiento_FormClosing event_FrmPrd_ClienteMantenimiento_FormClosing;
        private void FrmPrd_ClienteMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              event_FrmPrd_ClienteMantenimiento_FormClosing(sender, e);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Superior_Mant1_Load(object sender, EventArgs e)
        {

        }

        public void Cargar_Tipo_Sexo()
        {
            try
            {
               cmbSexo.Properties.DataSource= BusCastalogo.Get_List_Sexo();

            }
            catch (Exception  ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void Cargar_Tipo_EstadoCivil()
        {
            try
            {
                CmbEstadoCivil.Properties.DataSource = BusCastalogo.Get_List_EstadoCivil();
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //
        private void cmb_Tipo_EditValueChanged(object sender, EventArgs e)
        {           
        }
        public bool ValidarCajasTexto()
        {
            try
            {
                bool BVerificarObjetosVacios = false;

                if (txtcorreo.Text == "")
                {
                    errorProviderValidarTxt.SetError(txtcorreo, "Ingrese Correo");
                    BVerificarObjetosVacios = true;
                }
                if (txt_direccion.Text == "")
                {
                    errorProviderValidarTxt.SetError(txt_direccion, "Ingrese Direccion");
                    BVerificarObjetosVacios = true;
                }

                if (txt_direccion.Text == "")
                {
                    errorProviderValidarTxt.SetError(txt_direccion, "Ingrese Direccion");
                    BVerificarObjetosVacios = true;
                }

                if (txt_nombres.Text== "")
                {
                    errorProviderValidarTxt.SetError(txt_nombres, "Ingrese Nombre");
                    BVerificarObjetosVacios = true;
                }
                if (txt_apellidos.Text == "")
                {
                    errorProviderValidarTxt.SetError(txt_apellidos, "Ingrese Nombre");
                    BVerificarObjetosVacios = true;
                }
                if (txt_razon_social.Text == "")
                {
                    errorProviderValidarTxt.SetError(txt_razon_social, "Ingrese Razon Social");
                    BVerificarObjetosVacios = true;
                }
                if (cmb_actividad_economica.Text == "")
                {
                    errorProviderValidarTxt.SetError(cmb_actividad_economica, "Escoga una Actividad");
                    BVerificarObjetosVacios = true;
                }
                if (txt_cedula.Text == "")
                {
                    errorProviderValidarTxt.SetError(txt_cedula, "Ingrese Ruc/Cedula");
                    BVerificarObjetosVacios = true;
                }

                if (cmb_Tipo.Text == "")
                {
                    errorProviderValidarTxt.SetError(cmb_Tipo, "Escoga un Tipo");
                    BVerificarObjetosVacios = true;
                }
                //if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
                //{
                //    errorProviderValidarTxt.SetError(ucGe_Sucursal_combo1, "Escoga una Sucursal");
                //    BVerificarObjetosVacios = true;
                //}

                
                return BVerificarObjetosVacios;

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void ucGe_Menu_Superior_Mant1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_Superior_Mant1_Load_2(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
