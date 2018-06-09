using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System.Xml;
using Core.Erp.Winform.Controles;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ProveedorMantenimiento : Form
    {
        public FrmPrd_ProveedorMantenimiento()
        {
            try
            {
                 InitializeComponent();
               
                paramCP_I = paramCP_B.Get_Info_parametros( param.IdEmpresa);
                event_FrmPrd_ProveedorMantenimiento_FormClosing += FrmPrd_ProveedorMantenimiento_event_FrmPrd_ProveedorMantenimiento_FormClosing;


                ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
                ucGe_Menu.event_btnGuardar_y_Salir_Click+=ucGe_Menu_event_btnGuardar_y_Salir_Click;
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
                if (ValidarTxt() == true)
                {
                    return;
                }
                Grabar();

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
                Grabar();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void FrmPrd_ProveedorMantenimiento_event_FrmPrd_ProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e){ }

        #region variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_bus PersoB = new tb_persona_bus();
        public cp_proveedor_Info proveedorI = null;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        UCGe_Docu_Personales UCDocumento = new UCGe_Docu_Personales();
        UCGe_NaturalezaPersona UCNaturaleza = new UCGe_NaturalezaPersona();
        UCCp_TipoServicioxProve UCTipoSer = new UCCp_TipoServicioxProve();
        UCCp_TipoGasto UCTipoGasto = new UCCp_TipoGasto();
        tb_persona_Info persoI = new tb_persona_Info();
       List<cp_codigo_SRI_Info> lm_codigo_sri = new List<cp_codigo_SRI_Info>();

        //ubicacion 
        UCFa_Ubicacion UC = new UCFa_Ubicacion();
        //tb_ubicacion_Info info_ubicacion = new tb_ubicacion_Info();

        public List<cp_proveedor_codigo_SRI_Info> _ListaCodProveeAnt = new List<cp_proveedor_codigo_SRI_Info>();
        public List<cp_proveedor_codigo_SRI_Info> _ListaCodProveeDet = new List<cp_proveedor_codigo_SRI_Info>();
        public List<cp_proveedor_codigo_SRI_Info> _ListaCodProveeDetN = new List<cp_proveedor_codigo_SRI_Info>();
        public cp_proveedor_codigo_SRI_Bus codPro_B = new cp_proveedor_codigo_SRI_Bus();

        public cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        cp_TipoServicioxProvee_Info tipoServPro = new cp_TipoServicioxProvee_Info();
        cp_catalogo_Info tipoGasto = new cp_catalogo_Info();

        public int fila, columna,fila2;
        String format = "MM/dd/yyyy";
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();
        #endregion

        #region metodosGetSET


        public cp_proveedor_Info get_proveedorInfo()
        {
            try
            {
                tipoGasto = UCTipoGasto.get_Dato();
                tipoServPro = UCTipoSer.get_Dato();

                proveedorI = new cp_proveedor_Info();
                //info_ubicacion = UC.get_Ubicacion();
                proveedorI.IdEmpresa = param.IdEmpresa;
                proveedorI.IdProveedor =Convert.ToDecimal( txt_codigoProv.Text);
                proveedorI.IdPersona = Convert.ToDecimal(txt_idPersona.Text);
                proveedorI.pr_codigo = (txt_codigoProv.Text.Length == 0) ? "" : txt_codigoProv.Text.Trim();
                proveedorI.pr_nombre = (txt_nomProveedor.Text.Length == 0) ? "" : txt_nomProveedor.Text.Trim();
                proveedorI.pr_girar_cheque_a = txt_nomProveedor.Text;

                proveedorI.IdTipoServicio = tipoServPro.codigo;
                proveedorI.IdTipoGasto = tipoGasto.IdCatalogo;

                proveedorI.pr_contribuyenteEspecial = "N";
                proveedorI.pr_plazo = 0;
                proveedorI.pr_estado = (chk_estado.Checked == true) ? "A" : "I";
               // proveedorI.IdCiudad = info_ubicacion.IdUbicacion;
                if (cmb_nacionalidad.Text == "Nacional") 
                {
                    proveedorI.pr_nacionalidad = "NAC";
                }
                else
                {proveedorI.pr_nacionalidad = "EXT";
                }
                
                proveedorI.IdUsuario = param.IdUsuario;
                proveedorI.Fecha_Transac = DateTime.Now;
                proveedorI.IdUsuarioUltMod = param.IdUsuario;
                proveedorI.Fecha_UltMod = DateTime.Now;
                proveedorI.nom_pc = param.nom_pc;
                proveedorI.ip = param.ip;
                proveedorI.contacto = txt_contacto.Text;
                proveedorI.responsable = txt_responsable.Text;
                proveedorI.comentario = txt_comentario.Text;
                proveedorI.IdProveedor =Convert.ToDecimal( txt_IdProveedor.Text);
              //  proveedorI.IdCentroCosoto =null;
               // proveedorI.IdCtaCble_Anticipo = ".";
               // proveedorI.IdCtaCble_Gasto = ".";
                proveedorI.IdClaseProveedor = 1;
                proveedorI.ip = param.ip;
                proveedorI.Fecha_Transac = param.Fecha_Transac;
                proveedorI.nom_pc = param.nom_pc;
                proveedorI.IdUsuario = param.IdUsuario;
                return proveedorI;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new cp_proveedor_Info();
            }
        }

        public void set_ProveedorInfo(cp_proveedor_Info info)
        {
            try
            {
                txt_codigoProv.Text = (info.pr_codigo!=null)?info.pr_codigo.Trim():"";
                txt_nomProveedor.Text = (info.pr_nombre!=null)?info.pr_nombre.Trim():"";
                txt_codigoProv.Text = (info.pr_codigo!=null)?info.pr_codigo.Trim():"";
                txt_IdProveedor.Text = info.IdProveedor.ToString();
                txt_idPersona.Text = info.IdPersona.ToString();
                txt_contacto.Text = info.contacto;
                txt_responsable.Text = info.responsable;
                txt_comentario.Text = info.comentario;
                if (info.pr_nacionalidad == "NAC")
                {
                    cmb_nacionalidad.Text = "Nacional";
                }
                else
                {
                    cmb_nacionalidad.Text = "Extranjero";
                }
                this.UCTipoSer.set_TipoServixProvee((info.IdTipoServicio!=null)?info.IdTipoServicio.Trim():"");
                this.UCTipoGasto.set_TipoGasto((info.IdTipoGasto!=null)?info.IdTipoGasto.Trim():"");
                chk_estado.Checked = (info.pr_estado == "A") ? true : false;
                //info_ubicacion.IdUbicacion = info.IdCiudad;
                //this.UC.set_UbicacionCheckedSelection(info_ubicacion);
                

                proveedorI = info;
             }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString()); }
        }

        public void set_PersonaInfo(tb_persona_Info info)
        {
            try
            {
                txt_RazonSocial.Text = info.pe_razonSocial;
                txt_telefono.Text = info.pe_celular;
                txt_fax.Text = info.pe_fax;
                txt_email.Text = info.pe_correo;
                txt_ci_ruc.Text = info.pe_cedulaRuc;
                txt_direcProve.Text = info.pe_direccion;
                this.UCDocumento.set_TipoDoc_Personales(info.IdTipoDocumento.Trim());
                this.UCNaturaleza.set_Naturaleza(info.pe_Naturaleza.Trim());
                persoI = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        void txt_vacios()
        {
            try
            {
                txt_telefono.Text = ""; txt_RazonSocial.Text = "";
                txt_nomProveedor.Text = "";
                txt_fax.Text = "";
                txt_email.Text = ""; txt_direcProve.Text = "";
                txt_codigoProv.Text = ""; txt_ci_ruc.Text = "";
               
                this.UCDocumento.set_TipoDoc_Personales("CED");
                this.UCNaturaleza.set_Naturaleza("NATUR");
                this.UCTipoGasto.set_TipoGasto("GLOC");
                this.UCTipoSer.set_TipoServixProvee("SUMV");
                chk_estado.Enabled = false; chk_estado.Checked = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public tb_persona_Info get_personaInfo()
        {
            try
            {
                persoI = new tb_persona_Info();
                decimal idP = Convert.ToDecimal(txt_idPersona.Text);
                
                persoI.CodPersona = (txt_idPersona.Text.Length <=0)?"":txt_idPersona.Text.Trim();
                persoI.IdPersona = idP;
                persoI.pe_sexo = "SEXO_MAS";
                persoI.pe_nombre = " ";
                persoI.pe_apellido = " ";
                persoI.pe_nombreCompleto = (txt_nomProveedor.Text.Length == 0) ? "" : txt_nomProveedor.Text.Trim();
                persoI.IdTipoPersona = 1;
                persoI.IdEstadoCivil = "SOLTE";
                persoI.pe_estado = "A";

                persoI.pe_razonSocial = (txt_RazonSocial.Text.Length == 0) ? "" : txt_RazonSocial.Text.Trim();
                persoI.pe_celular = (txt_telefono.Text.Length == 0) ? "" : txt_telefono.Text.Trim();
                persoI.pe_fax = (txt_fax.Text.Length == 0) ? "" : txt_fax.Text.Trim();
                persoI.pe_correo = (txt_email.Text.Length == 0) ? "" : txt_email.Text.Trim();
                persoI.pe_cedulaRuc = (txt_ci_ruc.Text.Length == 0) ? "" : txt_ci_ruc.Text.Trim();
                persoI.pe_direccion = (txt_direcProve.Text.Length == 0) ? "" : txt_direcProve.Text.Trim();

                Cl_TipoDoc_Personales_Info tipodo = new Cl_TipoDoc_Personales_Info();
                tipodo = UCDocumento.get_TipoDoc_Personales();
                Cl_NaturalezaPerso NatPer = new Cl_NaturalezaPerso();
                NatPer = UCNaturaleza.get_Naturaleza();

                persoI.IdTipoDocumento = tipodo.codigo;
                persoI.pe_Naturaleza = NatPer.codigo;


                return persoI;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new tb_persona_Info();

            }

        }

        #endregion
        
        public void set_accion(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                _Accion = Accion;
                
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                      //  cmb_nacionalidad.EditValue=0;
                       // this.btn_grabar.Text = "Grabar";
                        txt_vacios();
                                           
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        // txt_ci_ruc.Enabled = false;
                        txt_codigoProv.ReadOnly = true;
                       // this.btn_grabar.Text = "Actualizar";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        chk_estado.Checked = false;
                        txt_telefono.Enabled = false;
                        txt_RazonSocial.Enabled = false;
                      //  this.btn_grabar.Text = "Anular";
                        txt_nomProveedor.Enabled = false;
                   
                        txt_fax.Enabled = false;
                        txt_email.Enabled = false;
                        txt_direcProve.Enabled = false;
                        txt_codigoProv.Enabled = false;
                        txt_ci_ruc.Enabled = false;
                        this.UCDocumento.Enabled = false;
                        this.UCNaturaleza.Enabled = false;
                        this.UCTipoGasto.Enabled = false;
                        this.UCTipoSer.Enabled = false;
                        chk_estado.Enabled = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       // this.btn_grabar.Text = "Actualizar";
                       // this.btn_grabar.Enabled = false;
                        txt_telefono.Enabled = false;
                        txt_RazonSocial.Enabled = false;
                       
                        txt_nomProveedor.Enabled = false;
                   
                        txt_fax.Enabled = false;
                        txt_email.Enabled = false;
                        txt_direcProve.Enabled = false;
                        txt_codigoProv.Enabled = false;
                        txt_ci_ruc.Enabled = false;
                        this.UCDocumento.Enabled = false;
                        this.UCNaturaleza.Enabled = false;
                        this.UCTipoGasto.Enabled = false;
                        this.UCTipoSer.Enabled = false;
                        chk_estado.Enabled = false;
                      
                        cmb_nacionalidad.Enabled = false;
                       
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
        
        private void UCCP_Mant_Proveedor_Load(object sender, EventArgs e)
        {
            try
            {
                pnDocumento.Controls.Add(UCDocumento);
                UCDocumento.Dock = DockStyle.Fill;

                pnNaturaleza.Controls.Add(UCNaturaleza);
                UCNaturaleza.Dock = DockStyle.Fill;

                pnTipoServicioxProvee.Controls.Add(UCTipoSer);
                UCTipoSer.Dock = DockStyle.Fill;

                pnTipoGasto.Controls.Add(UCTipoGasto);
                UCTipoGasto.Dock = DockStyle.Fill;

       

                load_ubicacion();
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void load_ubicacion()
        {
            try
            {
                //panel_ubicacion.Controls.Add(UC);
                //UC.set_Solo_chequea_unItem(true);
                //UC.set_Treelist_AllowRecursiveNodeChecking(false);
                //UC.set_Treelist_SelectMultiple(false);
                //UC.set_Treelist_ShowCheckBoxes(true);
                //UC.Dock = DockStyle.Fill;
                //UC.set_UbicacionCheckedSelection(info_ubicacion);
            }
            catch(Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public Boolean Grabar()
        {
            try
            {

                string msgError = "";

                    int c;
                    decimal idPer = 0;
                    decimal idPro = 0;

                    //if (txt_idPersona.Text == "0" || txt_idPersona.Text == "")
                    //    c = 0;
                    //else
                    //    c = 1;

                    get_personaInfo();
                    get_proveedorInfo();

                    cp_proveedor_Bus provB = new cp_proveedor_Bus();


                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        
                        
                            PersoB.GrabarDB(persoI, ref idPer, ref msgError);
                            proveedorI.IdPersona = idPer;
                            txt_idPersona.Text = idPer.ToString();
                       



                        string msgErro = "";


                        if (provB.GrabarDB (proveedorI, ref idPro, ref msgErro))
                        {
                            txt_IdProveedor.Text = idPro.ToString();
                            MessageBox.Show("Proveedor #" + txt_codigoProv.Text + " Ingresado Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); _Accion = Cl_Enumeradores.eTipo_action.actualizar; return true;
                        }
                        else
                        {
                            MessageBox.Show("No se grabo" + msgErro , "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
                        }


                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        proveedorI.IdUsuarioUltMod = param.IdUsuario;
                        proveedorI.Fecha_UltMod = param.Fecha_Transac;

                        provB.ModificarDB(proveedorI);
                        PersoB.ModificarDB(persoI, ref msgError);

                        MessageBox.Show("Información del Proveedor Actualizada Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); return true;
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.Anular)
                    {
                        proveedorI.IdUsuarioUltAnu = param.IdUsuario;
                        proveedorI.Fecha_UltAnu = param.Fecha_Transac;

                        provB.AnularDB(proveedorI);
                        MessageBox.Show("Proveedor Anulado Correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information); return true;
                    }
                    return false;

               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
            
        }
        

        private void txt_ci_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Funciones val = new Funciones();
                e.Handled = val.Validanumero_decimal(e.KeyChar, txt_ci_ruc.Text.ToString());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        //public cp_proveedor_Info proveedorI { get; set; }

        private void txt_ci_ruc_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string mensaje = "";
                if(_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if(PersoB.VericarCedulaExiste(txt_ci_ruc.Text.Trim(), ref mensaje) == true)
                    {
                        persoI = PersoB.Get_Info_Persona(txt_ci_ruc.Text.Trim());
                        txt_idPersona.Text = (persoI.IdPersona!=null)?persoI.IdPersona.ToString():"0";
                        txt_direcProve.Text = (persoI.pe_direccion != null || persoI.pe_direccion != "") ? persoI.pe_direccion.Trim() : txt_direcProve.Text;
                        txt_RazonSocial.Text = (persoI.pe_razonSocial != null || persoI.pe_razonSocial != "") ? persoI.pe_razonSocial.Trim() : txt_RazonSocial.Text;
                        txt_telefono.Text = (persoI.pe_celular != null || persoI.pe_celular != "") ? persoI.pe_celular.Trim() : txt_telefono.Text;
                        txt_email.Text = (persoI.pe_correo != null || persoI.pe_correo != "") ? persoI.pe_correo.Trim() : txt_email.Text;
                        txt_fax.Text = (persoI.pe_fax != null || persoI.pe_fax != "") ? persoI.pe_fax.Trim() : txt_fax.Text;

                        cp_proveedor_Info proIngresado = new cp_proveedor_Info();
                        proIngresado = proveedorB.Get_Info_Proveedor_x_Persona(param.IdEmpresa, persoI.IdPersona, ref mensaje);
                       
                        if(proIngresado == null)
                        {
                            if(mensaje != "NUEVO")
                                MessageBox.Show(mensaje);
                        }
                        else
                        {
                            if(_Accion == Cl_Enumeradores.eTipo_action.grabar)
                            {
                                MessageBox.Show(" El ruc ingresado está registrado en base.\n Puede proceder actualizar la información del proveedor");
                                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                                set_ProveedorInfo(proIngresado);
                            }
                        }
                    }
                    else
                    {
                        persoI = null;
                        txt_idPersona.Text = "0";
                        //txt_direcProve.Text = "";
                        //txt_RazonSocial.Text = "";
                        //txt_telefono.Text = "";
                        //txt_email.Text = "";
                        //txt_fax.Text = "";
                    }
                }
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString()); }
        }
      
        private void txt_codigoProv_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string mensaje = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (proveedorB.VericarCodigoExiste(txt_codigoProv.Text.Trim(), param.IdEmpresa, ref mensaje) == true)
                    {
                        MessageBox.Show("Por favor cambie de codigo, Codigo asignado a: " + mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_codigoProv.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
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

        private void btn_guardarSalir_Click(object sender, EventArgs e)
        {
            try
            {
                    if (Grabar())
                        this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }           

        }

      
        private void btn_grabar_Click(object sender, EventArgs e)
        {
            try
            {
               Grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
   
        }

        public delegate void delegate_FrmPrd_ProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmPrd_ProveedorMantenimiento_FormClosing event_FrmPrd_ProveedorMantenimiento_FormClosing;
        private void FrmPrd_ProveedorMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmPrd_ProveedorMantenimiento_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void txt_ci_ruc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Error caracter no Permitido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmb_nacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void IdProveedor(decimal idP)
        {

            try
            {txt_codigoProv.Text = Convert.ToString(idP);
            txt_IdProveedor.Text = Convert.ToString(idP);

            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public void IdProveedorModificar(decimal idProveedor)
        {

            try
            {
                txt_codigoProv.Text = Convert.ToString(idProveedor);
                txt_IdProveedor.Text = Convert.ToString(idProveedor);

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        public bool ValidarTxt()
        {
         try 
	      {
              bool BSiEstaVacio = false;
              if (txt_ci_ruc.Text == "")
              {
                  errorProviderValidaTxt.SetError(txt_ci_ruc, "Ingrese Ruc o Cedula");
                  BSiEstaVacio = true;
              }
              if (txt_contacto.Text == "")
              {
                  errorProviderValidaTxt.SetError(txt_contacto, "Ingrese Contacto");
                  BSiEstaVacio = true;
              }
              if (txt_nomProveedor.Text == "")
              {
                  errorProviderValidaTxt.SetError(txt_nomProveedor, "Ingrese Nombre");
                  BSiEstaVacio = true;
              }
              if (txt_email.Text == "")
              {
                  errorProviderValidaTxt.SetError(txt_email, "Ingrese Mail");
                  BSiEstaVacio = true;
              }


              if (txt_RazonSocial.Text == "")
              {
                  errorProviderValidaTxt.SetError(txt_RazonSocial, "Ingrese Razon Social");
                  BSiEstaVacio = true;
              }
              return BSiEstaVacio;
		
	      }
	      catch (Exception)
	      {
		
		  return false;
	      }
        }
     
    }
}
