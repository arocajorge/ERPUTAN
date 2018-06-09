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
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Clientes_Mant : Form
    {

        #region declaraciones
        Boolean IdPersona_Registrada = false;
        Boolean IdCliente_Registrado = false;
        decimal id_persona = 0;
        decimal id_cliente = 0;

        public List<fa_Cliente_Tabla_Info> ListClientes { get; set; }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        fa_Cliente_Bus bus_cliente = new fa_Cliente_Bus();
        fa_Cliente_Info info = new fa_Cliente_Info();
        fa_Cliente_Info info_tmp = new fa_Cliente_Info();        
        tb_Sucursal_Info info_sucursal = new tb_Sucursal_Info();
        tb_persona_Info info_persona = new tb_persona_Info();
        fa_catalogo_Info info_catalogo = new fa_catalogo_Info();
        fa_catalogo_Info info_actividad = new fa_catalogo_Info();
        Cl_TipoDoc_Personales_Info info_doc_personal = new Cl_TipoDoc_Personales_Info();
        tb_persona_bus bus_persona = new tb_persona_bus();
        List<ct_Plancta_Info> listaPLan = new List<ct_Plancta_Info>();
        List<ct_Plancta_Info> ListaPlanAntList = new List<ct_Plancta_Info>();
        List<fa_catalogo_Info> ListaTipoCliente = new List<fa_catalogo_Info>();
        List<Cl_Categoria_Financiera_Info> ListaCategoria = new List<Cl_Categoria_Financiera_Info>();
        List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();
        List<fa_Vendedor_Info> lista_vendedor = new List<fa_Vendedor_Info>();
        List<fa_catalogo_Info> lista_actividad_economica = new List<fa_catalogo_Info>();
        ct_Centro_costo_Bus BusCostos = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> ListCostos = new List<ct_Centro_costo_Info>();
        List<tb_persona_direccion_Info> lista_direccion = new List<tb_persona_direccion_Info>();
        List<tb_persona_direccion_Info> Direccion_Lista = new List<tb_persona_direccion_Info>();
        tb_persona_direccion_Bus bus_direccion = new tb_persona_direccion_Bus();
        List<fa_cliente_contactos_Info> Lista_Contactos = new List<fa_cliente_contactos_Info>();
        fa_cliente_contactos_Bus Bus_Contactos = new fa_cliente_contactos_Bus();
        BindingList<fa_cliente_pto_emision_cliente_Info> blist_Punto_emision = new BindingList<fa_cliente_pto_emision_cliente_Info>();
        fa_cliente_pto_emision_cliente_Bus bus_Punto_emision = new fa_cliente_pto_emision_cliente_Bus();
        List<fa_Cliente_Info> listaCliente = new List<fa_Cliente_Info>();
        fa_cliente_tipo_Info InfoTipoCli = new fa_cliente_tipo_Info();

        public delegate void Delegate_frmFA_Clientes_Mant_FormClosing();
        public event Delegate_frmFA_Clientes_Mant_FormClosing event_frmFA_Clientes_Mant_FormClosing;

        string MensajeError = "";

        #endregion
        
        public frmFa_Clientes_Mant()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
               ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
               ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
               ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
               ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
                
                event_frmFA_Clientes_Mant_FormClosing += frmFA_Clientes_Mant_event_frmFA_Clientes_Mant_FormClosing;
                UC_Doc_per.event_cmb_Docum_perso_SelectedValueChanged += UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged;
                cmbTipo.event_cmbClienteTipo_EditValueChanged += cmbTipo_event_cmbClienteTipo_EditValueChanged;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmbTipo_event_cmbClienteTipo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTipoCli = cmbTipo.get_ClienteTipoInfo();
                if (InfoTipoCli != null)
                {
                    cmb_plancta.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Con);
                    cmb_PlanCta_Credito.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Cred);
                    cmb_PlanCtaAnti.set_PlanCtarInfo(InfoTipoCli.IdCtaCble_CXC_Anticipo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (validaciones() == true)
                {
                    if (guardar(ref msg))
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "";

                if (validaciones() == true)
                {
                    guardar(ref msg);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {     
                Anular();
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        void frmFA_Clientes_Mant_event_frmFA_Clientes_Mant_FormClosing(){}

        void UC_Doc_per_event_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
              txt_cedula_Enter(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region metodo set y get del Cliente


        public void set_Cliente(fa_Cliente_Info obj)
        {
            try
            {
                info = new fa_Cliente_Info();
                info = obj;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_Cliente_in_controls()
        {
            try
            {
                this.lbl_id_cliente.Text = info.IdCliente.ToString();
                this.txtCodigo.Text= info.Codigo;
                this.lbl_id_persona.Text = info.IdPersona.ToString();
                this.txt_nombres.Text = info.Persona_Info.pe_nombre.Trim();
                this.txt_apellidos.Text = info.Persona_Info.pe_apellido.Trim();
                UC_Doc_per.set_TipoDoc_Personales(info.Persona_Info.IdTipoDocumento);
                this.txt_cedula.Text = info.Persona_Info.pe_cedulaRuc.Trim();
                this.txt_direccion.Text = info.Persona_Info.pe_direccion.Trim();
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;
                lblEstado.Visible = (info.Estado == "I") ? true : false;
                this.txt_razon_social.Text = info.Persona_Info.pe_razonSocial.Trim();
                this.txt_telefono_ofic.Text = info.Persona_Info.pe_telefonoOfic;
                this.chk_Estado.Enabled = true;
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;
                this.txtTelefonoCasa.Text = info.Persona_Info.pe_telefonoCasa;
                this.txtTelefonoInterno.Text = info.Persona_Info.pe_telefonoInter;
                this.txtTelefonoContac.Text = info.Persona_Info.pe_telfono_Contacto;
                this.txtCelularPrin.Text = info.Persona_Info.pe_celular;
                this.txtCelularSecun.Text = info.Persona_Info.pe_celularSecundario;
                this.txt_casilla.Text = Convert.ToString(info.Persona_Info.pe_casilla);
                this.txt_fax.Text = Convert.ToString(info.Persona_Info.pe_fax);

                ucGe_Natu_clie.set_Naturaleza(info.Persona_Info.pe_Naturaleza);
                

                this.lbl_id_persona.Text = info.IdPersona.ToString();
                this.lbl_id_cliente.Text = info.IdCliente.ToString();
                this.ucGe_Sucursal_combo1.set_SucursalInfo(info.IdSucursal);
                this.ucFa_VendedorCmb1.set_VendedorInfo(info.IdVendedor);
                cmbTipo.set_ClienteTipoInfo(info.Idtipo_cliente);
                id_persona = Convert.ToDecimal(info.IdPersona);
                opt_ambas.Checked = (info.IdTipoCredito == Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString()) ? true : false;
                opt_contado.Checked = (info.IdTipoCredito == Cl_Enumeradores.eTipoCreditoCliente.CON.ToString()) ? true : false;
                opt_credito.Checked = (info.IdTipoCredito == Cl_Enumeradores.eTipoCreditoCliente.CRE.ToString()) ? true : false;

                this.cmb_categoria.SelectedValue = info.cl_Cat_crediticia;
                this.txt_plazo.Text = info.cl_plazo.ToString();

                this.txtMailPrincipal.EditValue = info.Mail_Principal;
                this.txtCorreoSecun.EditValue = info.Mail_Secundario1;
                this.txtCorreoAlterno.EditValue = info.Mail_Secundario2;

                this.cmbCostoCXC.set_IdCentroCosto (info.IdCentroCosto_CXC);
                this.cmbCostoAnticipo.set_IdCentroCosto(info.IdCentroCosto_Anticipo);

                this.txt_descuento.Text = info.cl_porcentaje_descuento.ToString();
                this.cmb_plancta.set_PlanCtarInfo(info.IdCtaCble_cxc);
                cmb_PlanCtaAnti.set_PlanCtarInfo(info.IdCtaCble_Anti);

                cmb_PlanCta_Credito.set_PlanCtarInfo(info.IdCtaCble_cxc_Credito);
                cmbCentroCosto_Credito.set_IdCentroCosto(info.IdCentroCosto_CXC_Credito);

                this.txt_celular_garante.Text = info.cl_Cell_Garante;
                this.txt_nombre_garante.Text = info.cl_Garante;
                this.txt_mail_garante.Text = info.cl_Mail_Garante;
                this.txt_observacion.Text = info.cl_observacion;                
                this.txt_cupo_asignado.Text = info.cl_Cupo.ToString();
                this.txt_razon_social.Text = info.Persona_Info.pe_razonSocial;
                this.cmb_cliente_principal.EditValue = info.IdClienteRelacionado;
                this.txt_nombre_rep_legal.Text = info.cl_Rep_Legal;
                this.txt_mail_rep_legal.Text = info.cl_Mail_Rep_Legal;
                this.txt_celular_rep_legal.Text = info.cl_Cell_Rep_Legal;
                this.txt_nombre_gerente.Text = info.cl_Ger_Gen;
                this.txt_mail_gerente.Text = info.cl_Mail_Ger_Gen;
                this.txt_celular_gerente.Text = info.cl_Cell_Ger_Gen;
                this.txt_casilla.Text = info.cl_casilla;
                this.txt_fax.Text = info.cl_fax;
                

                ucGe_PaisProvinciaCiudad.set_InfoPais(info.IdPais);
                ucGe_PaisProvinciaCiudad.set_InfoProvincia(info.IdProvincia);
                ucGe_PaisProvinciaCiudad.set_InfoCiudad(info.IdCiudad);
                ucGe_PaisProvinciaCiudad.set_InfoParroquia(info.IdParroquia);

                cmb_actividad_economica.set_CatalogosInfo(info.IdActividadComercial);
                this.chk_Estado.Checked = (info.Estado == "A") ? true : false;

                ucFa_Cliente_x_Contacto1.Set_Info_Cliente(info);
                info.list_punto_emision_x_cliente = bus_Punto_emision.Get_List(param.IdEmpresa, info.IdCliente);
                if (info.list_punto_emision_x_cliente!=null)
                {
                    blist_Punto_emision = new BindingList<fa_cliente_pto_emision_cliente_Info>(info.list_punto_emision_x_cliente);
                    gridControlPuntoEmision.DataSource = blist_Punto_emision;
                }

                chk_empresa_relacionada.Checked = info.es_empresa_relacionada;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        public fa_Cliente_Info get_Cliente()
        {
            try
            {
                info = new fa_Cliente_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdCliente = (this.lbl_id_cliente.Text != "") ? Convert.ToInt32(this.lbl_id_cliente.Text) : 0;
                info.IdPersona = (this.lbl_id_persona.Text != "") ? Convert.ToDecimal(this.lbl_id_persona.Text) : 0;
                info.Codigo = this.txtCodigo.Text;
                id_persona = Convert.ToDecimal(info.IdPersona);
                info.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
                info.IdVendedor = ucFa_VendedorCmb1.get_VendedorInfo().IdVendedor;
                info.Idtipo_cliente = this.cmbTipo.get_ClienteTipoInfo().Idtipo_cliente;
                info.IdTipoCredito = (opt_ambas.Checked == true) ? Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString() : (opt_contado.Checked == true) ? Cl_Enumeradores.eTipoCreditoCliente.CON.ToString() : Cl_Enumeradores.eTipoCreditoCliente.CRE.ToString();
                info.cl_Cat_crediticia = this.cmb_categoria.SelectedValue.ToString();
                info.cl_plazo = (this.txt_plazo.Text != "") ? Convert.ToInt32(this.txt_plazo.Text) : 0;
                info.cl_porcentaje_descuento = (this.txt_descuento.Text != "") ? Convert.ToDouble(this.txt_descuento.Text):0;
                if (this.cmb_plancta.get_PlanCtaInfo() != null)
                    info.IdCtaCble_cxc = cmb_plancta.get_PlanCtaInfo().IdCtaCble;
                info.IdCtaCble_Anti = cmb_PlanCtaAnti.get_PlanCtaInfo().IdCtaCble;
                info.cl_Cell_Garante = (this.txt_celular_garante.Text != "") ? this.txt_celular_garante.Text : " ";
                info.cl_Garante = (this.txt_nombre_garante.Text != "") ? this.txt_nombre_garante.Text : " ";
                info.cl_Mail_Garante = (this.txt_mail_garante.Text != "") ? this.txt_mail_garante.Text : " ";
                info.cl_observacion = (this.txt_observacion.Text != "") ? this.txt_observacion.Text : " ";
                
                info.cl_Cupo = (this.txt_cupo_asignado.Text != "") ? Convert.ToDouble(this.txt_cupo_asignado.Text) : 0;
                info.Persona_Info.pe_razonSocial = (this.txt_razon_social.Text != "") ? this.txt_razon_social.Text : " ";
                info.IdClienteRelacionado = (this.cmb_cliente_principal.TabIndex == -1) ? 0 : Convert.ToDecimal(this.cmb_cliente_principal.EditValue);
                info.cl_Rep_Legal = (this.txt_nombre_rep_legal.Text != "") ? this.txt_nombre_rep_legal.Text : " ";
                info.cl_Mail_Rep_Legal = (this.txt_mail_rep_legal.Text != "") ? this.txt_mail_rep_legal.Text : " ";
                info.cl_Cell_Rep_Legal = (this.txt_celular_rep_legal.Text != "") ? this.txt_celular_rep_legal.Text : " ";
                info.cl_Ger_Gen = (this.txt_nombre_gerente.Text != "") ? this.txt_nombre_gerente.Text : " ";
                info.cl_Mail_Ger_Gen = (this.txt_mail_gerente.Text != "") ? this.txt_mail_gerente.Text : " ";
                info.cl_Cell_Ger_Gen = (this.txt_celular_gerente.Text != "") ? this.txt_celular_gerente.Text : " ";
                info.cl_casilla = (this.txt_casilla.Text != "") ? this.txt_casilla.Text : " ";
                info.cl_fax = (this.txt_fax.Text != "") ? this.txt_fax.Text : " ";
                info.IdActividadComercial = this.cmb_actividad_economica.get_CatalogosInfo().IdCatalogo;
                info.Mail_Principal = (this.txtMailPrincipal.EditValue != null) ? this.txtMailPrincipal.EditValue.ToString() : "";
                info.Mail_Secundario1 = (this.txtCorreoSecun.EditValue != null) ? this.txtCorreoSecun.EditValue.ToString() : "";
                info.Mail_Secundario2 = (this.txtCorreoAlterno.EditValue != null) ? this.txtCorreoAlterno.EditValue.ToString() : "";
                info.IdCentroCosto_CXC = (cmbCostoCXC.get_item() == "") ? null : cmbCostoCXC.get_item();
                info.IdCentroCosto_Anticipo = (cmbCostoAnticipo.get_item() == "") ? null : cmbCostoAnticipo.get_item();

                info.IdCtaCble_cxc_Credito = cmb_PlanCta_Credito.get_PlanCtaInfo().IdCtaCble;
                info.IdCentroCosto_CXC_Credito = (cmbCentroCosto_Credito.get_item() == "") ? null : cmbCentroCosto_Credito.get_item();
                info.list_contactos_x_cliente = ucFa_Cliente_x_Contacto1.Get_List_cliente_contactos();

                info.IdCiudad = ucGe_PaisProvinciaCiudad.get_Info_Ciudad().IdCiudad;
                info.IdParroquia = ucGe_PaisProvinciaCiudad.get_Info_Parroquia() == null ? null : ucGe_PaisProvinciaCiudad.get_Info_Parroquia().IdParroquia;

                info.es_empresa_relacionada = chk_empresa_relacionada.Checked;
              

                info_persona = new tb_persona_Info();
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                info_persona.IdPersona = id_persona;
                info_persona.pe_Naturaleza = ucGe_Natu_clie.get_Id_Naturaleza();
                info_persona.CodPersona = (id_persona != 0) ? id_persona.ToString() : "";
                info_persona.pe_apellido = (this.txt_apellidos.Text != "") ? this.txt_apellidos.Text : " ";
                info_persona.pe_nombre = (this.txt_nombres.Text != "") ? this.txt_nombres.Text : " ";
                info_persona.pe_nombreCompleto = this.txt_apellidos.Text + " " + this.txt_nombres.Text;
                info_persona.pe_razonSocial = (this.txt_razon_social.Text != "") ? this.txt_razon_social.Text : this.txt_nombres.Text + "  " + this.txt_apellidos.Text;
                info_persona.pe_fechaNacimiento = DateTime.Now;

                info_persona.pe_telefonoOfic = (this.txt_telefono_ofic.Text != "") ? this.txt_telefono_ofic.Text : " ";
                info_persona.pe_telefonoInter = (this.txtTelefonoInterno.Text != "") ? this.txtTelefonoInterno.Text : " ";
                info_persona.pe_celular = (this.txtCelularPrin.Text != "") ? this.txtCelularPrin.Text : " ";
                info_persona.pe_telefonoCasa = (this.txtTelefonoCasa.Text != "") ? this.txtTelefonoCasa.Text : " ";
                info_persona.pe_telfono_Contacto = (this.txtTelefonoContac.Text != "") ? this.txtTelefonoContac.Text : " ";
                info_persona.pe_celularSecundario = (this.txtCelularSecun.Text != "") ? this.txtCelularSecun.Text : " ";

                info_persona.pe_fax = (this.txt_fax.Text != "") ? this.txt_fax.Text : " ";
                info_persona.pe_casilla = (this.txt_casilla.Text != "") ? this.txt_casilla.Text : " ";
                info_persona.IdTipoDocumento = info_doc_personal.codigo;
                info_persona.pe_correo = (this.txtMailPrincipal.EditValue != null) ? this.txtMailPrincipal.EditValue.ToString() : "";

                info_persona.IdTipoPersona = 1;
                info_persona.pe_cedulaRuc = (this.txt_cedula.Text != "") ? this.txt_cedula.Text : " ";
                info_persona.pe_direccion = (this.txt_direccion.Text != "") ? this.txt_direccion.Text : " ";


                
               
                
                info_persona.pe_estado = (this.chk_Estado.Checked == true) ? "A" : "I";
                info_persona.pe_UltUsuarioModi = param.IdUsuario;
                info_persona.pe_fechaCreacion = DateTime.Now;
                info_persona.pe_fechaModificacion = DateTime.Now;

                info.IdUsuario = param.IdUsuario;
                info.Fecha_Transac = DateTime.Now;
                info.IdUsuarioUltMod = param.IdUsuario;
                info.Fecha_UltMod = DateTime.Now;
                info.IdUsuarioUltAnu = param.IdUsuario;
                info.Fecha_UltAnu = DateTime.Now;
                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.Estado = (this.chk_Estado.Checked==true )?"A":"I";
                lista_direccion = ucGe_Persona_x_Direcciones_Grid1.Get_list_direcciones_x_persona();
                info_persona.list_direcciones_x_persona = lista_direccion;

                info.list_punto_emision_x_cliente = new List<fa_cliente_pto_emision_cliente_Info>(blist_Punto_emision);



                tb_Catalogo_Bus busCat = new tb_Catalogo_Bus();
                List<tb_Catalogo_Info> catalogo = new List<tb_Catalogo_Info>();


                catalogo = busCat.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.SEXO);
                if (catalogo.Count > 0)
                { info_persona.pe_sexo = catalogo[0].CodCatalogo; }
                else
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros del Catalogo, Falta ingresar sexo de la persona.. " +
                            "\nIngréselos desde la pantalla de Catálogo,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new fa_Cliente_Info();
                };


                catalogo = busCat.Get_List_Catalogo(Cl_Enumeradores.TipoCatalogo.ESTCIVIL);
                if (catalogo.Count > 0)
                { info_persona.IdEstadoCivil = catalogo[0].CodCatalogo; }
                else
                {
                    MessageBox.Show("No puede continuar porque están incompletos los parámetros del Catalogo, Falta ingresar estado civil de la persona.. " +
                            "\nIngréselos desde la pantalla de Catálogo,o comuníquese con sistemas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new fa_Cliente_Info();
                };


                info.Persona_Info = info_persona;




                return info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return info;
            }
            
        }
        
        #endregion

        #region load de los objetos y combos
       

        private void load_ubicacion()
        {
            try
            {
                ucGe_PaisProvinciaCiudad.CargarComboPais();                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load_combos()
        {
            try
            {
                cmb_PlanCta_Credito.cargar_PlanCta();
                cmb_PlanCtaAnti.cargar_PlanCta();
                cmb_plancta.cargar_PlanCta();
                Cargar_Categoria_financiera();
                this.cmb_categoria.DataSource = ListaCategoria;
                this.cmb_categoria.DisplayMember = "descripcion";
                this.cmb_categoria.ValueMember = "id";

                cmb_actividad_economica.cargar_Catalogos(Convert.ToInt32(Cl_Enumeradores.FaTipoCat.ACT_ECO)); ;

                tb_persona_bus bus_persona = new tb_persona_bus();
                listaCliente = new List<fa_Cliente_Info>();
                listaCliente = bus_cliente.Get_List_Cliente(param.IdEmpresa);
                listaCliente = listaCliente.Where(q => q.IdCliente != 0).ToList();

                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:                        
                        this.ucGe_Sucursal_combo1.get_SucursalInfo();
                        this.ucFa_VendedorCmb1.get_VendedorInfo();
                        this.cmb_categoria.SelectedItem = 0;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                     
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
                }
                this.cmb_cliente_principal.Properties.DataSource = listaCliente;
                this.cmb_cliente_principal.Properties.DisplayMember = "Nombre_Cliente";
                this.cmb_cliente_principal.Properties.ValueMember = "IdCliente";
                this.gridControlPuntoEmision.DataSource = blist_Punto_emision;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        #endregion

        private void enable_objetos(Boolean estado)
        {
            try
            {
              
                this.cmbTipo.Enabled = estado;
                this.UC_Doc_per.Enabled = estado;
                this.txt_cedula.ReadOnly = !estado;
                this.txt_nombres.Enabled = estado;
                this.txt_apellidos.Enabled = estado;
                this.txt_razon_social.Enabled = estado;
                this.ucGe_Sucursal_combo1.Enabled = estado;
                this.ucFa_VendedorCmb1.Enabled = estado;
                this.chk_Estado.Enabled = estado;
                this.txt_direccion.Enabled = estado;
                this.txt_telefono_ofic.Enabled = estado;
                this.txt_casilla.Enabled = estado;
                this.txt_fax.Enabled = estado;
                this.txt_observacion.Enabled = estado;
                this.cmb_actividad_economica.Enabled = estado;
                this.cmb_plancta.Enabled = estado;
                this.cmb_categoria.Enabled = estado;
                this.opt_ambas.Enabled = estado;
                this.opt_contado.Enabled = estado;
                this.opt_credito.Enabled = estado;
                this.txt_plazo.Enabled = estado;
                this.txt_descuento.Enabled = estado;
                this.txt_cupo_asignado.Enabled = estado;
                this.cmb_cliente_principal.Enabled = estado;
                this.txt_nombre_rep_legal.Enabled = estado;
                this.txt_celular_rep_legal.Enabled = estado;
                this.txt_mail_rep_legal.Enabled = estado;
                this.txt_nombre_gerente.Enabled = estado;
                this.txt_mail_gerente.Enabled = estado;
                this.txt_celular_gerente.Enabled = estado;
                this.txt_celular_garante.Enabled = estado;
                this.txt_mail_garante.Enabled = estado;
                this.txt_nombre_garante.Enabled = estado;
                this.ucGe_PaisProvinciaCiudad.Enabled = estado;
                cmb_PlanCtaAnti.Enabled = estado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void frmFA_Clientes_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
                load_ubicacion();
                load_combos();
                set_accion_in_controls();
                ucGe_Persona_x_Direcciones_Grid1.Set_direcciones_x_persona(info.IdPersona);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_accion_in_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        this.chk_Estado.Checked = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        set_Cliente_in_controls();
                        ucGe_Menu.Visible_bntAnular = false;
                        enable_objetos(true);
                        txt_cedula.ReadOnly = true;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        set_Cliente_in_controls();
                        txt_cedula.ReadOnly = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        set_Cliente_in_controls();
                        txt_cedula.ReadOnly = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        lblEstado.Visible = (info.Estado == "I") ? true : false;
                        
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean guardar(ref string MensajeError)
        {
            try
            {
                Boolean Res = false;

                if (get_Cliente() != null)
                {
                   
                   
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                           
                            if (IdCliente_Registrado == true)
                            {
                                Res = bus_cliente.ModificarDB(info, ref MensajeError);


                                listaCliente.Remove(info_tmp);
                                listaCliente.Add(info);
                            }
                            else
                            {                                
                                Res = bus_cliente.GrabarDB(info, ref id_persona, ref id_cliente, ref MensajeError);
                               
                            }

                            this.lbl_id_cliente.Text = id_cliente.ToString();
                            this.lbl_id_persona.Text = id_persona.ToString();

                            if (!Res)
                                MessageBox.Show("Error: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                txt_cedula.ReadOnly = true;
                                LimpiarDatos();
                            }
                           
                            break;

                        case Cl_Enumeradores.eTipo_action.actualizar:

                            Res = bus_cliente.ModificarDB(info, ref MensajeError);

                          
                            if (!Res)
                                MessageBox.Show("Error: " + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                LimpiarDatos();
                            }
                            break;         
                    }
                }

                return Res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MensajeError = ex.Message;
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                
            }
        }

        private Boolean Anular()
        {
            try
            {
                Boolean resultB = false;
                string mensaje = "";
                if (lblEstado.Visible == true)
                {
                    MessageBox.Show("No se puede Anular Debido a que ya se encuentra Anulado");
                }
                else
                {

                    if (MessageBox.Show("¿Está seguro que desea anular el Cliente: " + "[" + info.IdCliente + "] -" + info.Persona_Info.pe_nombre + " " + info.Persona_Info.pe_apellido + " ?", "Anulación de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (info.Estado == "A")
                        {
                            FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                            ofrm.ShowDialog();


                            get_Cliente();
                            info.IdUsuarioUltAnu = param.IdUsuario;
                            info.Fecha_UltAnu = DateTime.Now;
                            info.MotivoAnulacion = ofrm.motivoAnulacion;

                            if (bus_cliente.EliminarDB(info, ref mensaje))
                            {                                
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Anular, "El Cliente", info.IdCliente);
                                MessageBox.Show(smensaje, param.Nombre_sistema);
                                ucGe_Menu.Visible_bntAnular = false;
                                lblEstado.Visible = true;
                                resultB = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo anular el Cliente: " + info.Nombre_Cliente + " Se encuentra Anulado", "Anulación de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resultB = false;
                        }
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean validaciones()
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (!ValidarCedula())
                    {
                        return false;
                    }
                }
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                if (info_doc_personal.codigo == "RUC")
                {
                    if (txt_razon_social.Text == "" || txt_razon_social.Text == null)
                    {
                        MessageBox.Show("Digite la Razon Social del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_razon_social.Focus();
                        return false;
                    }
                }
                else 
                {
                    if (txt_nombres.EditValue == "" || txt_nombres.EditValue == null)
                    {
                        MessageBox.Show("Digite el Nombre del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_nombres.Focus();
                        return false;
                    }

                    if (txt_apellidos.EditValue == "" || txt_apellidos.EditValue == null)
                    {
                        MessageBox.Show("Digite el Apellido del Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_apellidos.Focus();
                        return false;
                    }                    
                }

                if (ucGe_Sucursal_combo1.get_SucursalInfo() == null )
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal_combo1.cmbsucursal.Focus();
                    return false;
                }

                if (ucFa_VendedorCmb1.get_VendedorInfo() == null )
                {
                    MessageBox.Show("Seleccione el Vendedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucFa_VendedorCmb1.cmb_vendedor.Focus();
                    return false;
                }

                if (cmb_actividad_economica.get_CatalogosInfo() == null )
                {
                    MessageBox.Show("Seleccione la Actividad Economica", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_actividad_economica.cmbCatalogo.Focus();
                    return false;
                }

                if (cmbTipo.get_ClienteTipoInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipo.cmbClienteTipo.Focus();
                    return false;
                }

                if (cmb_plancta.get_PlanCtaInfo() == null || cmb_plancta.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable CXC", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_plancta.cmbPlanCta.Focus();
                    return false;
                }

                if (cmb_PlanCtaAnti.get_PlanCtaInfo() == null || cmb_PlanCtaAnti.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable de Anticipos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_PlanCtaAnti.cmbPlanCta.Focus();
                    return false;
                }

                if (cmb_PlanCta_Credito.get_PlanCtaInfo() == null || cmb_PlanCta_Credito.get_PlanCtaInfo().IdCtaCble == "")
                {
                    MessageBox.Show("Seleccione la Cuenta Contable de Credito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmb_PlanCtaAnti.cmbPlanCta.Focus();
                    return false;
                }

                if (txtMailPrincipal.EditValue == "" || txtMailPrincipal.EditValue == null)
                {
                    MessageBox.Show("Digite el Correo Principal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMailPrincipal.Focus();
                    return false;                   
                }

                if (ucGe_PaisProvinciaCiudad.get_Info_Pais() == null)
                {
                    MessageBox.Show("Seleccione el Pais del cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     ucGe_PaisProvinciaCiudad.cmbPais.Focus();
                    return false;
                }

                if (ucGe_PaisProvinciaCiudad.get_Info_Provincia() == null)
                {
                    MessageBox.Show("Seleccione la Provincia del cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_PaisProvinciaCiudad.cmbProvincia.Focus();
                    return false;
                }

                if (ucGe_PaisProvinciaCiudad.get_Info_Ciudad() == null)
                {
                    MessageBox.Show("Seleccione la Ciudad del cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_PaisProvinciaCiudad.cmbCiudad.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
        }

        Boolean ValidarCedula() 
        {
            try
            {
                info_doc_personal = UC_Doc_per.get_TipoDoc_Personales();
                tb_persona_bus tbPersona = new tb_persona_bus();
                string msj = "";

                if (info_doc_personal.codigo == "CED")
                {
                    if (txt_cedula.Text != "")
                    {
                        if (txt_cedula.Text.TrimStart().TrimEnd().Count() != 10)
                        {
                            MessageBox.Show("Cedula Incorrecta");
                            return false;
                        }

                        if (!tbPersona.Verifica_Ruc(txt_cedula.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite la Cedula");
                        return false;
                    }

                }
                else if (info_doc_personal.codigo == "RUC")
                {

                    if (txt_cedula.Text != "")
                    {
                        if (txt_cedula.Text.Substring(10, 3) != "001")
                        {
                            MessageBox.Show("RUC Incorrecto");
                            return false;
                        }
                        if (txt_cedula.Text.TrimStart().TrimEnd().Count() != 13)
                        {


                            MessageBox.Show("RUC Incorrecto");
                            return false;
                        }
                        if (!tbPersona.Verifica_Ruc(txt_cedula.Text, ref msj))
                        {
                            MessageBox.Show(msj);
                        }
                    }
                    else {
                        MessageBox.Show("Digite el Cedula");
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_plazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_plazo.Text).Length > 5)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_descuento.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_descuento_Leave(object sender, EventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                txt_descuento.Text = f.Format_text_2_decimales(txt_descuento.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cupo_asignado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_cupo_asignado.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cupo_asignado_Leave(object sender, EventArgs e)
        {
            try
            {
                Funciones f = new Funciones();
                txt_cupo_asignado.Text = f.Format_text_2_decimales(txt_cupo_asignado.Text);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
               
        private void txt_cedula_Enter(object sender, EventArgs e)
        {
            try
            {                
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                    {
                        txt_cedula.MaxLength = 10;
                        if (txt_cedula.Text != "")
                            txt_cedula.Text = txt_cedula.Text.Length > 10 ? txt_cedula.Text.Substring(0, 10) : txt_cedula.Text;
                    }
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                    {
                        txt_cedula.MaxLength = 13;
                        if (txt_cedula.Text != "")
                            txt_cedula.Text = txt_cedula.Text.Length > 13 ? txt_cedula.Text.Substring(0, 13) : txt_cedula.Text;
                    }
                    if (UC_Doc_per.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                    {
                        txt_cedula.MaxLength = 20;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmFA_Clientes_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                   event_frmFA_Clientes_Mant_FormClosing();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void txt_cedula_Leave(object sender, EventArgs e)
        {
            try
            {                
               
                tb_persona_Info select = bus_persona.Get_Info_Persona(txt_cedula.Text.TrimStart().TrimEnd());
                if (select != null && select.IdPersona != 0)
                {
                    id_persona = select.IdPersona;
                    IdPersona_Registrada = true;

                    fa_Cliente_Info select_id = bus_cliente.Get_info_Cliente_x_IdPersona(param.IdEmpresa, id_persona);

                    if (select_id != null && select_id.IdCliente != 0)
                    {

                        IdCliente_Registrado = true;
                        MessageBox.Show("Cliente ya existe en la Base de Datos", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        fa_Cliente_Info tmp = new fa_Cliente_Info();
                        tmp = select_id;
                        info_tmp = new fa_Cliente_Info();
                        info_tmp = select_id;
                        set_Cliente(bus_cliente.Get_Info_Cliente(tmp.IdEmpresa, tmp.IdCliente));
                        set_Cliente_in_controls();

                        if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                        {
                            _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                            {
                                ucGe_Menu.Visible_btnGuardar = true;;
                                txt_cedula.ReadOnly = true;
                            }
                        }
                    }
                    else
                    {
                        IdCliente_Registrado = false;
                    }

                    
                        this.lbl_id_persona.Text = Convert.ToString(select.IdPersona);
                        id_persona = select.IdPersona;
                        this.txt_nombres.Text = Convert.ToString(select.pe_nombre);
                        this.txt_apellidos.Text = Convert.ToString(select.pe_apellido);
                        this.chk_Estado.Checked = (select.pe_estado == "A") ? true : false;
                        this.txt_razon_social.Text = Convert.ToString(select.pe_razonSocial);
                        this.txt_direccion.Text = Convert.ToString(select.pe_direccion);
                        this.txt_telefono_ofic.Text = (String.IsNullOrWhiteSpace(select.pe_telefonoOfic))
                            ? select.pe_telefonoOfic = string.Empty : select.pe_telefonoOfic;
                        this.txtTelefonoCasa.Text = (String.IsNullOrWhiteSpace(select.pe_telefonoCasa))
                            ? select.pe_telefonoCasa = string.Empty : select.pe_telefonoCasa;
                        this.txtTelefonoInterno.Text = (String.IsNullOrWhiteSpace(select.pe_telefonoInter))
                            ? select.pe_telefonoInter = string.Empty : select.pe_telefonoInter;
                        this.txtTelefonoContac.Text = (String.IsNullOrWhiteSpace(select.pe_telfono_Contacto))
                            ? select.pe_telfono_Contacto = string.Empty : select.pe_telfono_Contacto;
                        this.txtCelularPrin.Text = (String.IsNullOrWhiteSpace(select.pe_celular))
                            ? select.pe_celular = string.Empty : select.pe_celular;
                        this.txtCelularSecun.Text = (String.IsNullOrWhiteSpace(select.pe_celularSecundario))
                            ? select.pe_celularSecundario = string.Empty : select.pe_celularSecundario;
                        this.txt_casilla.Text = Convert.ToString(select.pe_casilla);
                        this.txt_fax.Text = Convert.ToString(select.pe_fax);
                   // }
                }
                else
                {
                    id_persona = 0;
                    IdPersona_Registrada = false;
                    this.txt_nombres.Focus();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmb_actividad_economica_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {

                    if (txt_nombres.Text.Length >100)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {

                    if (txt_apellidos.Text.Length > 100)
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_telefono_ofic_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_telefono_ofic.Text).Length > 11)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_casilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_casilla.Text ).Length > 10)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_cupo_asignado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_plazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_celular_rep_legal_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_celular_rep_legal.Text).Length > 11)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_celular_gerente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_celular_gerente.Text).Length > 11)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_celular_garante_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != 8)
                {
                    if ((e.KeyChar < 48 || e.KeyChar > 58) || (txt_celular_garante.Text).Length > 11)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    base.OnKeyPress(e);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                info = new fa_Cliente_Info();
                info.Persona_Info = new tb_persona_Info();
                info_persona = new tb_persona_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                this.lbl_id_cliente.Text = "";
                this.lbl_id_persona.Text = "";
                id_persona = 0;                
                opt_ambas.Checked = true;                
                this.txt_plazo.Text = "";
                this.txt_descuento.Text = "";
                this.txt_celular_garante.Text = "";
                this.txt_nombre_garante.Text = "";
                this.txt_mail_garante.Text = "";
                this.txt_observacion.Text = "";               
                this.txt_cupo_asignado.Text = "";
                this.txt_razon_social.Text = "";                
                this.txt_nombre_rep_legal.Text = "";
                this.txt_mail_rep_legal.Text = "";
                this.txt_celular_rep_legal.Text = "";
                this.txt_nombre_gerente.Text = "";
                this.txt_mail_gerente.Text = "";
                this.txt_celular_gerente.Text = "";
                this.txt_casilla.Text = "";
                this.txt_fax.Text = "";                
                this.txtMailPrincipal.EditValue = "";
                this.txtCorreoSecun.EditValue = "";
                this.txtCorreoAlterno.EditValue = "";
                this.txt_apellidos.Text = "";
                this.txt_nombres.Text = "";
                this.txt_razon_social.Text = "";                

                this.txt_telefono_ofic.Text = "";
                this.txtTelefonoInterno.Text = "";
                this.txtCelularPrin.Text = "";
                this.txtTelefonoCasa.Text = "";
                this.txtTelefonoContac.Text = "";
                this.txtCelularSecun.Text = "";
                this.txt_fax.Text = "";
                this.txt_casilla.Text = "";
                this.txt_cedula.Text = "";
                this.txt_direccion.Text = "";                
                this.chk_Estado.Checked = true;
                
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txt_cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucFa_VendedorCmb1_Load(object sender, EventArgs e)
        {

        }

        private void tabPageInfoGeneral_Click(object sender, EventArgs e)
        {

        }
    }
}
