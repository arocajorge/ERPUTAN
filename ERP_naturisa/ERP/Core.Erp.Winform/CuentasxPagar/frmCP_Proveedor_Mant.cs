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
using Core.Erp.Winform.Controles;
using Core.Erp.Info.CuentasxPagar;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using System.Xml;

using Core.Erp.Winform.General;



namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Proveedor_Mant : Form
    {
        #region  'Declaracion Variables Generales Param LogError'
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;

        #endregion 

        #region Declaración de variables


        string MensajeError = "";
        int IdClaseProveedor = 0;
        string[] CodRetencion = new string[] { "COD_RET_FUE", "COD_RET_IVA" };


        //cp_proveedor_
        cp_proveedor_Info InfoProveedor = new Info.CuentasxPagar.cp_proveedor_Info();
       cp_proveedor_Bus BusProveedor = new cp_proveedor_Bus();

       //proveedor_Autorizacion
       cp_proveedor_Autorizacion_Bus BusProvee_Auto = new cp_proveedor_Autorizacion_Bus();
       List<cp_proveedor_Autorizacion_Info> List_Proveedor_Auto = new List<cp_proveedor_Autorizacion_Info>();
       List<cp_proveedor_Autorizacion_Info> List_Proveedor_Auto_Ant = new List<cp_proveedor_Autorizacion_Info>();
       BindingList<cp_proveedor_Autorizacion_Info> DataSourceProveedorAutorizacion = new BindingList<cp_proveedor_Autorizacion_Info>();


       //proveedor_codigo_SRI_
       cp_proveedor_codigo_SRI_Bus Bus_Provee_Cod_Sri = new cp_proveedor_codigo_SRI_Bus();
       List<cp_proveedor_codigo_SRI_Info> List_Proveedor_Cod_Sri = new List<cp_proveedor_codigo_SRI_Info>();

       // //proveedor_clase
       cp_proveedor_clase_Bus busClasProve = new cp_proveedor_clase_Bus();
       

       //tb_persona
       tb_persona_bus BusPersona = new tb_persona_bus();
       tb_persona_Info InfoPersona = new Info.General.tb_persona_Info();
      
       //cp_codigo_SRI
       cp_codigo_SRI_Bus dat_ti = new cp_codigo_SRI_Bus();
       cp_codigo_SRI_Info Item = new cp_codigo_SRI_Info();
       List<cp_codigo_SRI_Info> lista_codigoSRI_grid = new List<cp_codigo_SRI_Info>();
       List<cp_codigo_SRI_Info> lista_codigo_sri = new List<cp_codigo_SRI_Info>();
       List<cp_codigo_SRI_Info> lista_codigoSRI;
       BindingList<cp_codigo_SRI_Info> BinList_codigoSRI;
       

       
              
        //cp_parametros_
       cp_parametros_Info paramCP_I = new cp_parametros_Info();
       cp_parametros_Bus paramCP_B = new cp_parametros_Bus();

        //tb_persona_direccion
       tb_persona_direccion_Info Info_PerDirecc = new tb_persona_direccion_Info();
       tb_persona_direccion_Bus Bus_PerDirecc = new tb_persona_direccion_Bus();
       List<tb_persona_direccion_Info> Lista_PerDirecc = new List<tb_persona_direccion_Info>();
       BindingList<tb_persona_direccion_Info> List_direcciones_x_persona = new BindingList<tb_persona_direccion_Info>();
        #endregion


        #region 'Delegados'
       public delegate void delegate_frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e);
       public event delegate_frmCP_MantProveedor_FormClosing event_frmCP_MantProveedor_FormClosing;
        #endregion


       public Boolean validaciones()
       {
           try
           {
               txt_nomProveedor.Focus();

               if (uc_Proveedor_Clase.get_ClaseProveedorInfo() == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Ingrese_la) + " clase del proveedor" , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               if (txt_nomProveedor.Text == "")
               {
                   MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Ingrese_el) + " nombre del proveedor"   , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txt_nomProveedor.Focus();
                   return false;
               }


               if (txe_cedRucPas.EditValue == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Ingrese_CI_Ruc_Pasaporte) , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }


               if (cmb_ctacbleCxp.get_PlanCtaInfo().IdCtaCble == null)
               {
                   MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_la) + " Cuenta por pagar del Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               if (UCNaturaleza.get_Naturaleza() == null || String.IsNullOrEmpty(UCNaturaleza.get_Naturaleza().codigo))
               {
                   MessageBox.Show("Seleccione la Naturaleza del Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;

               }


               if (ucGe_PaisProvinciaCiudad.get_Info_Pais() == null)
               {
                   MessageBox.Show("Seleccione el Pais del Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }


               if (ucGe_PaisProvinciaCiudad.get_Info_Provincia() == null)
               {
                   MessageBox.Show("Seleccione la Provincia del Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }


               if (ucGe_PaisProvinciaCiudad.get_Info_Ciudad() == null)
               {
                   MessageBox.Show("Seleccione la Ciudad del Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               if (String.IsNullOrEmpty(cmbCtaCbleAnti.get_PlanCtaInfo().IdCtaCble))
               {

                   MessageBox.Show("Ingrese la cuenta contable anticipo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }


               
               if (UCTipoSer.get_Dato()== null)
               {
                   MessageBox.Show("Antes de Continuar debe Seleccionar el Tipo de Servicio.. \n Datos incompletos..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               if (UCTipoGasto.get_Dato() == null)
               {

                   MessageBox.Show("Antes de Continuar debe Seleccionar el Tipo de Gasto:.. \n Datos incompletos..", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }

               foreach (var item in ucGe_Persona_x_Direcciones_Grid1.Get_list_direcciones_x_persona())
               {
                   if (item.IdTipoDireccion == 0 || item.IdTipoDireccion == null)
                   {
                        MessageBox.Show("La dirección: "+item.Direccion+" no tiene un tipo seleccionado, por favor corrija", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

       public void Limpiar()
       {
           try
           {

               

               txt_IdProveedor.Text = "0";
               txt_nomProveedor.EditValue = null;
               txt_codigoProv.Text = "";
               txe_cedRucPas.EditValue = null;
               txt_idPersona.Text = "0";
               txt_RazonSocial.Text = "";
               txt_email.EditValue = null;
               txtCorreoSecun.EditValue = null;
               txtCorreoAlterno.EditValue = null;
               txt_giraA.Text = "";

               ucGe_PaisProvinciaCiudad.Inicializar_Catalogos();


               txt_direcProve.Text = "";
               txt_celular.Text = "";
               txt_fax.Text = "";
               txt_responsable.Text = "";
               txt_contacto.Text = "";
               txe_telefono_oficina.EditValue = null;
               txe_telefono_contacto.EditValue = null;
               txe_telefono_casa.EditValue = null;

               uc_Proveedor_Clase.Inicializar_cmbClaseProveedor();


               cmb_ctacbleCxp.Inicializar_cmbPlanCta();
               cmbCtaCbleAnti.Inicializar_cmbPlanCta();
               cmbCtaCbleGasto.Inicializar_cmbPlanCta();
               cmbCentroDeCosto.Inicializar_cmbCentroCosto();

               txt_comentario.Text = "";
               txt_Plazo.Text = "0";
               cmb_idtCredito.EditValue = null;
               cmb_ICE.EditValue = null;
               cmb_101.EditValue = null;

               BinList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();
               gridControl_SRI.DataSource = BinList_codigoSRI;

               if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "CED")
               {
                   txe_cedRucPas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                   txe_cedRucPas.Properties.Mask.EditMask = @"\d{0,10}";
               }



               UCNaturaleza.set_Naturaleza("NATU");
               cmb_nacionalidad.SelectedIndex = 0;
               chk_estado.Checked = true;

               uccP_Proveedor_Autoriza1.Limpiar_Autorizacion_x_Proveedor();

               Set_Id_Combos_Ubicacion();
               ucGe_Persona_x_Direcciones_Grid1.Limpiar_persona_x_direccion();
               txtNum_cta_acred.Text = string.Empty;

               cmb_banco_acred.set_BancoInfo(0);
               cmb_tipo_cta_acred.Set_IdCatalogo("AHO");


           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }

       public void set_Accion(Cl_Enumeradores.eTipo_action Accion)
       {
           try
           {
               _Accion = Accion;

              
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }

       private void set_Accion_Controles()
       {

           try
           {
               switch (_Accion)
               {
                   case Cl_Enumeradores.eTipo_action.grabar:
                       chk_estado.Checked = true;
                       UCGe_Menu.Visible_bntAnular = false;
                       break;
                   case Cl_Enumeradores.eTipo_action.actualizar:
                       UCGe_Menu.Visible_btnGuardar = false;
                       UCGe_Menu.Visible_bntAnular = false;
                       UCGe_Menu.Visible_bntLimpiar = false;
                       set_ProveedorInfo_in_controls();
                       break;
                   case Cl_Enumeradores.eTipo_action.Anular:
                       UCGe_Menu.Visible_bntLimpiar = false;
                       UCGe_Menu.Visible_bntGuardar_y_Salir = false;
                       UCGe_Menu.Visible_btnGuardar = false;
                       UCGe_Menu.Visible_bntImprimir = false;
                       set_ProveedorInfo_in_controls();
                       break;
                   case Cl_Enumeradores.eTipo_action.consultar:
                       UCGe_Menu.Visible_bntLimpiar = false;
                       UCGe_Menu.Visible_bntGuardar_y_Salir = false;
                       UCGe_Menu.Visible_btnGuardar = false;
                       UCGe_Menu.Visible_bntAnular = false;
                       set_ProveedorInfo_in_controls();
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

       public void set_ProveedorInfo(cp_proveedor_Info _infoProveedor)
       {
           try
           {
               InfoProveedor = _infoProveedor;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }

       private void set_ProveedorInfo_in_controls()
       {
           try
           {
               uccP_Proveedor_Autoriza1.set_IdProveedor(InfoProveedor.IdProveedor);
               uccP_Proveedor_Autoriza1.Cargar_Autorizacion_x_Proveedor();
               txt_nomProveedor.Text = (InfoProveedor.pr_nombre != null) ? InfoProveedor.pr_nombre.Trim() : "";
               txt_codigoProv.Text = (InfoProveedor.pr_codigo != null) ? InfoProveedor.pr_codigo.Trim() : "";
               txt_IdProveedor.Text = InfoProveedor.IdProveedor.ToString();
               txt_giraA.Text = (InfoProveedor.pr_girar_cheque_a != null) ? InfoProveedor.pr_girar_cheque_a.Trim() : "";
               txt_idPersona.Text = InfoProveedor.IdPersona.ToString();
               txt_Plazo.Text = Convert.ToString(InfoProveedor.pr_plazo).Trim();
               txt_contacto.Text = InfoProveedor.contacto;
               txt_responsable.Text = InfoProveedor.responsable;
               txt_comentario.Text = InfoProveedor.comentario;
               txe_cedRucPas.Text = InfoProveedor.Persona_Info.pe_cedulaRuc;
               cmbCentroDeCosto.set_IdCentroCosto(InfoProveedor.IdCentroCosoto);
               this.UCTipoSer.set_TipoServixProvee((InfoProveedor.IdTipoServicio != null) ? InfoProveedor.IdTipoServicio.Trim() : "");
               this.UCTipoGasto.set_TipoGasto((InfoProveedor.IdTipoGasto != null) ? InfoProveedor.IdTipoGasto.Trim() : "");
               chk_estado.Checked = (InfoProveedor.pr_estado == "A") ? true : false;
               lblAnulado.Visible =  (InfoProveedor.pr_estado == "I") ? true : false;
               chk_contEspecial.Checked = (InfoProveedor.pr_contribuyenteEspecial == "S") ? true : false;
               cmb_101.EditValue = InfoProveedor.codigoSRI_101_Predeter;
               cmb_ICE.EditValue = InfoProveedor.codigoSRI_ICE_Predeter;
               cmb_idtCredito.EditValue = InfoProveedor.idCredito_Predeter;

               ucGe_PaisProvinciaCiudad.set_InfoPais(InfoProveedor.IdPais);
               ucGe_PaisProvinciaCiudad.set_InfoProvincia(InfoProveedor.IdProvincia);
               ucGe_PaisProvinciaCiudad.set_InfoCiudad(InfoProveedor.IdCiudad);

               string Nacionalidad = "";
               Nacionalidad = (InfoProveedor.pr_nacionalidad == null) ? "NAC" : InfoProveedor.pr_nacionalidad;
               cmb_nacionalidad.SelectedIndex = (Nacionalidad.Trim() == "EXT") ? 1 : 0;

               uc_Proveedor_Clase.set_ClaseProveedorInfo(InfoProveedor.IdClaseProveedor);
               cmb_ctacbleCxp.set_PlanCtarInfo((InfoProveedor.IdCtaCble_CXP != null) ? InfoProveedor.IdCtaCble_CXP.Trim() : "");
               cmbCtaCbleAnti.set_PlanCtarInfo(InfoProveedor.IdCtaCble_Anticipo);
               cmbCtaCbleGasto.set_PlanCtarInfo(InfoProveedor.IdCtaCble_Gasto);


             


               UCTipoGasto.set_TipoGasto(InfoProveedor.IdTipoGasto);
               UCTipoSer.set_TipoServixProvee(InfoProveedor.IdTipoServicio);
               List_Proveedor_Cod_Sri = Bus_Provee_Cod_Sri.Get_List_proveedor_codigo_SRI(param.IdEmpresa, InfoProveedor.IdProveedor);
               List<cp_codigo_SRI_Info> listaAux_codigoSRI_grid = new List<cp_codigo_SRI_Info>();
               if (List_Proveedor_Cod_Sri.Count != 0)
               {
                   foreach (var item in List_Proveedor_Cod_Sri)
                   {
                       cp_codigo_SRI_Info info_codSRIprov = new cp_codigo_SRI_Info();
                       var item2 = lista_codigoSRI_grid.FirstOrDefault(c => c.IdCodigo_SRI == item.IdCodigo_SRI);
                       info_codSRIprov.IdCodigo_SRI = item2.IdCodigo_SRI;
                       info_codSRIprov.codigoSRI = item2.codigoSRI;
                       info_codSRIprov.co_codigoBase = item2.co_codigoBase;
                       info_codSRIprov.Tipo = item2.Tipo;
                       info_codSRIprov.co_porRetencion = item2.co_porRetencion;
                       listaAux_codigoSRI_grid.Add(info_codSRIprov);
                   }
               }
               txt_RazonSocial.Text = InfoProveedor.Persona_Info.pe_razonSocial;
               txt_celular.Text = InfoProveedor.Persona_Info.pe_celular;
               txt_celular_secundario.Text = InfoProveedor.Persona_Info.pe_celularSecundario;

               txt_fax.Text = InfoProveedor.Persona_Info.pe_fax;
               txt_email.Text = InfoProveedor.Persona_Info.pe_correo;
               txtCorreoSecun.EditValue = InfoProveedor.Persona_Info.pe_correo_secundario1;
               txtCorreoAlterno.EditValue = InfoProveedor.Persona_Info.pe_correo_secundario2;
               txt_direcProve.Text = InfoProveedor.Persona_Info.pe_direccion;
               txe_telefono_oficina.EditValue = InfoProveedor.Persona_Info.pe_telefonoOfic;
               txe_telefono_contacto.EditValue = InfoProveedor.Persona_Info.pe_telfono_Contacto;
               txe_telefono_casa.EditValue = InfoProveedor.Persona_Info.pe_telefonoCasa;
               this.UCDocumento.set_TipoDoc_Personales(InfoProveedor.Persona_Info.IdTipoDocumento.Trim());
               this.UCNaturaleza.set_Naturaleza(InfoProveedor.Persona_Info.pe_Naturaleza.Trim());
               txe_cedRucPas.EditValue = InfoProveedor.Persona_Info.pe_cedulaRuc;
               InfoPersona = InfoProveedor.Persona_Info;
               BinList_codigoSRI = new BindingList<cp_codigo_SRI_Info>(listaAux_codigoSRI_grid);
               gridControl_SRI.DataSource = BinList_codigoSRI;

                   cmb_banco_acred.set_BancoInfo(Convert.ToInt32(InfoProveedor.IdBanco_acreditacion)); 
               if(InfoProveedor.IdTipoCta_acreditacion_cat!=null)
                   cmb_tipo_cta_acred.Set_IdCatalogo(InfoProveedor.IdTipoCta_acreditacion_cat);
               txtNum_cta_acred.Text = InfoProveedor.num_cta_acreditacion;

               ucGe_Persona_x_Direcciones_Grid1.Set_direcciones_x_persona(InfoProveedor.IdPersona);
               uCct_Pto_Cargo_Grupo1.Set_info_grupo(InfoProveedor.IdPunto_cargo_grupo);
               uCct_Pto_Cargo_Grupo1.Set_info_punto_cargo(InfoProveedor.IdPunto_cargo);


               chk_parte_relacionada.Checked = InfoProveedor.es_empresa_relacionada;


           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
           }
       }

       public cp_proveedor_Info GetInfo_Proveedor()
       {
           try
           {

               InfoProveedor = new cp_proveedor_Info();

               InfoProveedor.IdEmpresa = param.IdEmpresa;
               InfoProveedor.IdProveedor = Convert.ToDecimal(txt_IdProveedor.Text.Trim());
               InfoProveedor.pr_codigo = (txt_codigoProv.Text.Length == 0) ? "" : txt_codigoProv.Text.Trim();
               InfoProveedor.pr_nombre = (txt_nomProveedor.Text.Length == 0) ? "" : txt_nomProveedor.Text.Trim();
               InfoProveedor.pr_girar_cheque_a = (txt_giraA.Text.Length == 0) ? "" : txt_giraA.Text.Trim();
               InfoProveedor.IdTipoServicio = UCTipoSer.get_Dato().codigo;
               InfoProveedor.IdTipoGasto = UCTipoGasto.get_Dato().IdCatalogo;
               InfoProveedor.IdCtaCble_CXP = this.cmb_ctacbleCxp.get_PlanCtaInfo().IdCtaCble;
               InfoProveedor.pr_contribuyenteEspecial = (chk_contEspecial.Checked == true) ? "S" : "N";
               InfoProveedor.pr_plazo = Convert.ToInt32(txt_Plazo.Text);
               InfoProveedor.pr_estado = (chk_estado.Checked == true) ? "A" : "I";
               InfoProveedor.pr_nacionalidad = cmb_nacionalidad.SelectedItem.ToString().Trim();
               InfoProveedor.idCredito_Predeter = (cmb_idtCredito.EditValue != null) ? Convert.ToInt32(cmb_idtCredito.EditValue) : 0;
               
               if (InfoProveedor.idCredito_Predeter == 0)
                   InfoProveedor.idCredito_Predeter = null;
               else
                   InfoProveedor.idCredito_Predeter = Convert.ToInt32(cmb_idtCredito.EditValue);
           
               InfoProveedor.codigoSRI_ICE_Predeter = (cmb_ICE.EditValue != null) ? Convert.ToInt32(cmb_ICE.EditValue) : 0;
               if (InfoProveedor.codigoSRI_ICE_Predeter == 0)
                   InfoProveedor.codigoSRI_ICE_Predeter = null;
               else
                   InfoProveedor.codigoSRI_ICE_Predeter = Convert.ToInt32(cmb_ICE.EditValue);

               InfoProveedor.codigoSRI_101_Predeter = (cmb_101.EditValue != null) ? Convert.ToInt32(cmb_101.EditValue) : 0;

               if (InfoProveedor.codigoSRI_101_Predeter == 0)
                   InfoProveedor.codigoSRI_101_Predeter = null;
               else
                   InfoProveedor.codigoSRI_101_Predeter = Convert.ToInt32(cmb_101.EditValue);

               InfoProveedor.IdPersona = Convert.ToDecimal(txt_idPersona.Text.Trim());
               InfoProveedor.IdCiudad = ucGe_PaisProvinciaCiudad.get_Info_Ciudad().IdCiudad;
               InfoProveedor.contacto = (txt_contacto.Text.Length == 0) ? "" : txt_contacto.Text.Trim();
               InfoProveedor.responsable = (txt_responsable.Text.Length == 0) ? "" : txt_responsable.Text.Trim();
               InfoProveedor.comentario = (txt_comentario.Text.Length == 0) ? "" : txt_comentario.Text.Trim();
               
               if (uc_Proveedor_Clase.get_ClaseProveedorInfo() == null)
                   InfoProveedor.IdClaseProveedor = 0;
               else
                   InfoProveedor.IdClaseProveedor = uc_Proveedor_Clase.get_ClaseProveedorInfo().IdClaseProveedor;
               
               if (String.IsNullOrEmpty(cmbCtaCbleAnti.get_PlanCtaInfo().IdCtaCble))
                   InfoProveedor.IdCtaCble_Anticipo = null;
               else
                   InfoProveedor.IdCtaCble_Anticipo = cmbCtaCbleAnti.get_PlanCtaInfo().IdCtaCble.Trim();

               if (String.IsNullOrEmpty(cmbCtaCbleGasto.get_PlanCtaInfo().IdCtaCble))
                   InfoProveedor.IdCtaCble_Gasto = null;
               else
                   InfoProveedor.IdCtaCble_Gasto = cmbCtaCbleGasto.get_PlanCtaInfo().IdCtaCble.Trim();

               if (String.IsNullOrEmpty(cmbCentroDeCosto.get_item()))
                   InfoProveedor.IdCentroCosoto = null;
               else
                   InfoProveedor.IdCentroCosoto = cmbCentroDeCosto.get_item().Trim();

               int focus = gridView_SRI.FocusedRowHandle;
               gridView_SRI.FocusedRowHandle = focus + 1;

               if (BinList_codigoSRI.Count != 0)
               {
                   foreach (var item in BinList_codigoSRI)
                   {
                       cp_proveedor_codigo_SRI_Info info = new cp_proveedor_codigo_SRI_Info();
                       info.IdEmpresa = param.IdEmpresa;
                       info.IdCodigo_SRI = item.IdCodigo_SRI;
                       InfoProveedor.lista_codigoSRI_Proveedor.Add(info);
                   }
               }
               InfoProveedor.lista_codigoSRI_Proveedor_Old = List_Proveedor_Cod_Sri;


               if(cmb_banco_acred.get_BancoInfo()!=null)
                   InfoProveedor.IdBanco_acreditacion=cmb_banco_acred.get_BancoInfo().IdBanco;
                InfoProveedor.IdTipoCta_acreditacion_cat=cmb_tipo_cta_acred.Get_Info_Catalogo().IdCatalogo;
                InfoProveedor.num_cta_acreditacion=txtNum_cta_acred.Text ;

                if(uCct_Pto_Cargo_Grupo1.Get_info_grupo()!=null) InfoProveedor.IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo1.Get_Id_grupo();
                if (uCct_Pto_Cargo_Grupo1.Get_info_punto_cargo() != null) InfoProveedor.IdPunto_cargo = uCct_Pto_Cargo_Grupo1.Get_Id_punto_cargo();

                InfoProveedor.es_empresa_relacionada = chk_parte_relacionada.Checked;

               return InfoProveedor;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return new cp_proveedor_Info();
           }
       }

        private tb_persona_Info GetInfo_Persona()
       {
           try
           {
               tb_Catalogo_Bus catB = new tb_Catalogo_Bus();
               List<Cl_EstadoCivil_Info> lEsCivi = new List<Cl_EstadoCivil_Info>();
               List<Cl_Sexo_Info> lSexo = new List<Cl_Sexo_Info>();

               InfoPersona = new tb_persona_Info();
               decimal idP = Convert.ToDecimal(txt_idPersona.Text);

               InfoPersona.CodPersona = (txt_idPersona.Text.Length <= 0) ? "" : txt_idPersona.Text.Trim();
               InfoPersona.IdPersona = idP;

               lEsCivi = catB.Get_List_EstadoCivil();
               lSexo = catB.Get_List_Sexo();

               InfoPersona.pe_sexo = lSexo[0].codigo;
               InfoPersona.IdEstadoCivil = lEsCivi[0].codigo;

               InfoPersona.pe_nombre = " ";
               InfoPersona.pe_apellido = (txt_nomProveedor.Text.Length == 0) ? "" : txt_nomProveedor.Text.Trim();
               InfoPersona.pe_nombreCompleto = (txt_nomProveedor.Text.Length == 0) ? "" : txt_nomProveedor.Text.Trim();
               InfoPersona.IdTipoPersona = 1;

               InfoPersona.pe_estado = "A";

               InfoPersona.pe_razonSocial = (txt_RazonSocial.Text.Length == 0) ? "" : txt_RazonSocial.Text.Trim();

               InfoPersona.pe_celular = (txt_celular.Text.Length == 0) ? "" : txt_celular.Text.Trim();
               InfoPersona.pe_celularSecundario = (txt_celular_secundario.Text.Length == 0) ? "" : txt_celular_secundario.Text.Trim();


               InfoPersona.pe_telefonoCasa = (txe_telefono_casa.Text.Length == 0) ? "" : Convert.ToString(txe_telefono_casa.EditValue).Trim();
               InfoPersona.pe_telefonoOfic = (txe_telefono_oficina.Text.Length == 0) ? "" : Convert.ToString(txe_telefono_oficina.EditValue).Trim();
               InfoPersona.pe_telfono_Contacto = (txe_telefono_contacto.Text.Length == 0) ? "" : Convert.ToString(txe_telefono_contacto.EditValue).Trim();


               InfoPersona.pe_fax = (txt_fax.Text.Length == 0) ? "" : txt_fax.Text.Trim();
               InfoPersona.pe_correo = (txt_email.Text.Length == 0) ? "" : txt_email.Text.Trim();

               InfoPersona.pe_correo_secundario1 = Convert.ToString(txtCorreoSecun.EditValue);
               InfoPersona.pe_correo_secundario2 = Convert.ToString(txtCorreoAlterno.EditValue);

               InfoPersona.pe_cedulaRuc = (txe_cedRucPas.EditValue == null) ? "" : Convert.ToString(txe_cedRucPas.EditValue).Trim();

               InfoPersona.pe_direccion = (txt_direcProve.Text.Length == 0) ? "" : txt_direcProve.Text.Trim();

               Cl_TipoDoc_Personales_Info tipodo = new Cl_TipoDoc_Personales_Info();
               tipodo = UCDocumento.get_TipoDoc_Personales();
               Cl_NaturalezaPerso NatPer = new Cl_NaturalezaPerso();
               NatPer = UCNaturaleza.get_Naturaleza();
               if (NatPer != null)
                   InfoPersona.pe_Naturaleza = NatPer.codigo;
               else
               {
                   MessageBox.Show("Seleccione");
                   return new tb_persona_Info();
               }
               InfoPersona.IdTipoDocumento = tipodo.codigo;

               return InfoPersona;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return new tb_persona_Info();
           }
       }

        private List<tb_persona_direccion_Info>GetInfo_Per_Dire()
       {
           try
           {
               Lista_PerDirecc = ucGe_Persona_x_Direcciones_Grid1.Get_list_direcciones_x_persona();
               return Lista_PerDirecc;
           }
           catch (Exception ex)
           {
               string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
               MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
               return new List<Info.General.tb_persona_direccion_Info>();
           }
       }

        private void txt_codigoProv_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string mensaje = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (BusProveedor.VericarCodigoExiste(txt_codigoProv.Text.Trim(), param.IdEmpresa, ref mensaje) == true)
                    {
                        MessageBox.Show("Este código ya se encuenta Registrado. Por favor ingrese otro Código: " + mensaje, "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_codigoProv.Text = "";
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
            
        private void cmbClaseProveedor_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txe_cedRucPas_Leave(object sender, EventArgs e)
        {
            try
            {

                if (txe_cedRucPas.EditValue == null || txe_cedRucPas.EditValue == "")
                {
                    return;

                }
                                             
                    string men = "";
                    if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                       {
                           if (!BusPersona.Verifica_Ruc(Convert.ToString(txe_cedRucPas.EditValue), ref men))
                           {
                               MessageBox.Show(men);
                           }

                       }
                    if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                    {
                        if (!BusPersona.Verifica_Ruc(Convert.ToString(txe_cedRucPas.EditValue), ref men))
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

        private void txe_cedRucPas_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txe_cedRucPas.EditValue == null || txe_cedRucPas.EditValue == "")
                {
                    return;
                }
                
                
                string mensaje = "";
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    if(BusPersona.VericarCedulaExiste(Convert.ToString(txe_cedRucPas.EditValue).Trim(), ref mensaje) == true)
                    {
                        InfoPersona = BusPersona.Get_Info_Persona(Convert.ToString(txe_cedRucPas.EditValue).Trim());
                        txt_idPersona.Text = InfoPersona.IdPersona.ToString();

                        if (InfoPersona.IdPersona != 0)
                            ucGe_Persona_x_Direcciones_Grid1.Set_direcciones_x_persona(InfoPersona.IdPersona);

                        txt_direcProve.Text = !String.IsNullOrEmpty(InfoPersona.pe_direccion) ? InfoPersona.pe_direccion.Trim() : txt_direcProve.Text;              
                        txt_RazonSocial.Text = !String.IsNullOrEmpty(InfoPersona.pe_razonSocial) ? InfoPersona.pe_razonSocial.Trim() : txt_RazonSocial.Text;
                        
                        txt_celular.Text = !String.IsNullOrEmpty(InfoPersona.pe_celular) ? InfoPersona.pe_celular.Trim() : txt_celular.Text;

                        txe_telefono_oficina.EditValue = !String.IsNullOrEmpty(InfoPersona.pe_telefonoOfic) ? InfoPersona.pe_telefonoOfic.Trim() : txe_telefono_oficina.EditValue;
                        txe_telefono_contacto.EditValue = !String.IsNullOrEmpty(InfoPersona.pe_telfono_Contacto) ? InfoPersona.pe_telfono_Contacto.Trim() : txe_telefono_contacto.EditValue;
                        txe_telefono_casa.EditValue = !String.IsNullOrEmpty(InfoPersona.pe_telefonoCasa) ? InfoPersona.pe_telefonoCasa.Trim() : txe_telefono_casa.EditValue;


                        txt_email.Text = !String.IsNullOrEmpty(InfoPersona.pe_correo) ? InfoPersona.pe_correo.Trim() : txt_email.Text;
                        txtCorreoSecun.Text = !String.IsNullOrEmpty(InfoPersona.pe_correo_secundario1) ? InfoPersona.pe_correo_secundario1.Trim() : txtCorreoSecun.Text;
                        txtCorreoAlterno.Text = !String.IsNullOrEmpty(InfoPersona.pe_correo_secundario2) ? InfoPersona.pe_correo_secundario2.Trim() : txtCorreoAlterno.Text;

                        txt_fax.Text = ! String.IsNullOrEmpty(InfoPersona.pe_fax) ? InfoPersona.pe_fax.Trim() : txt_fax.Text;

                        this.UCNaturaleza.set_Naturaleza(InfoPersona.pe_Naturaleza.Trim());

                        cp_proveedor_Info InfoProveedor_existente = new cp_proveedor_Info();
                        InfoProveedor_existente = BusProveedor.Get_Info_Proveedor_x_Persona(param.IdEmpresa, InfoPersona.IdPersona, ref mensaje);

                        if (InfoProveedor_existente == null || InfoProveedor_existente.IdPersona==0)
                        {
                            if (mensaje != "NUEVO")                                
                                MessageBox.Show(mensaje);
                            txt_nomProveedor.Text = "";
                            txt_codigoProv.Text = "";
                            txt_IdProveedor.Text = "0";
                            _Accion = Cl_Enumeradores.eTipo_action.grabar;
                        }
                        else
                        {
                            if (_Accion == Cl_Enumeradores.eTipo_action.grabar || _Accion == Cl_Enumeradores.eTipo_action.actualizar)
                            {
                                MessageBox.Show("**ALERTA ** El ruc ingresado está registrado en la base como proveedor con los siguientes Datos:\n\n" 
                                    + " Codigo:" + InfoProveedor_existente.pr_codigo + "\n" 
                                    + " Ruc:" + InfoProveedor_existente.Persona_Info.pe_cedulaRuc + "\n"
                                    + " Nombre:" + InfoProveedor_existente.pr_nombre + "\n"
                                    + " Direccion:" + InfoProveedor_existente.Persona_Info.pe_direccion + "\n\n" 
                                     + " El sistema procedera a Buscar este proveedor y se pondra en modo ACTUALIZAR"
                                    ,param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                                InfoProveedor = InfoProveedor_existente;
                                set_Accion_Controles();
                                set_ProveedorInfo_in_controls();
                                
                            }
                        }
                    }
                    else
                    {
                        InfoPersona = null;
                        txt_idPersona.Text = "0";
                       
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

       
        private void gridView_SRI_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdCodigo_SRI_sri")
                {

                    Item = lista_codigoSRI_grid.FirstOrDefault(c => c.co_estado == "A" && c.IdCodigo_SRI == Convert.ToDecimal(e.Value));
                    gridView_SRI.SetFocusedRowCellValue(colTipo, Item.Tipo);
                    gridView_SRI.SetFocusedRowCellValue(colco_porRetencion_sri, Item.co_porRetencion);
                    gridView_SRI.SetFocusedRowCellValue(colcodigoSRI_sri, Item.codigoSRI);                   
                    gridView_SRI.SetFocusedRowCellValue(colco_codigoBase, Item.co_codigoBase);
                               
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridView_SRI_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                 if (e.KeyValue.ToString() == "46")
                {                   
                        gridView_SRI.DeleteSelectedRows();
                        gridControl_SRI.RefreshDataSource();                                       
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

       
        private void tabGeneral_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                if (tabGeneral.SelectedTab == tabPageDatosContabls)
                {
                    if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                    {}
                    /*else
                    {                       
                        uc_Proveedor_Clase.set_ClaseProveedorInfo(uc_Proveedor_Clase.Primer());                   
                    }*/
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_nomProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_RazonSocial.Text = Convert.ToString(txt_nomProveedor.EditValue);
                txt_giraA.Text = Convert.ToString(txt_nomProveedor.EditValue);


            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void uc_Proveedor_Clase_event_cmb_Provedor_clase_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (uc_Proveedor_Clase.get_ClaseProveedorInfo() != null)
                {
                    cmbCtaCbleAnti.set_PlanCtarInfo(uc_Proveedor_Clase.get_ClaseProveedorInfo().IdCtaCble_Anticipo);
                    cmbCtaCbleGasto.set_PlanCtarInfo(uc_Proveedor_Clase.get_ClaseProveedorInfo().IdCtaCble_gasto);
                    cmb_ctacbleCxp.set_PlanCtarInfo(uc_Proveedor_Clase.get_ClaseProveedorInfo().IdCtaCble_CXP);
                    cmbCentroDeCosto.set_item(uc_Proveedor_Clase.get_ClaseProveedorInfo().IdCentroCosto);
                }
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (uc_Proveedor_Clase.get_ClaseProveedorInfo() == null)
                    {
                        cp_proveedor_clase_Info info = new cp_proveedor_clase_Info();
                        info = busClasProve.Get_Info_proveedor_clase(param.IdEmpresa, IdClaseProveedor);

                        if (info != null)
                        {
                            cmbCtaCbleAnti.set_PlanCtarInfo(info.IdCtaCble_Anticipo);
                            cmbCtaCbleGasto.set_PlanCtarInfo(info.IdCtaCble_gasto);
                            cmb_ctacbleCxp.set_PlanCtarInfo(info.IdCtaCble_CXP);
                            cmbCentroDeCosto.set_item(info.IdCentroCosto);
                        }
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

        void UCDocumento_event_cmb_Docum_perso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    txe_cedRucPas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    txe_cedRucPas.Properties.Mask.EditMask = @"\d{0,10}";
                    txe_cedRucPas.EditValue = null;

                    UCNaturaleza.set_Naturaleza("NATU");
                }

                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "RUC")
                {
                    txe_cedRucPas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    txe_cedRucPas.Properties.Mask.EditMask = @"\d{0,13}";
                    txe_cedRucPas.EditValue = null;

                    UCNaturaleza.set_Naturaleza("JURI");
                }

                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "PAS")
                {
                    txe_cedRucPas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                    txe_cedRucPas.EditValue = null;

                    UCNaturaleza.set_Naturaleza("OTRO");
                }



            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        #region 'Fx Grabar Actualizar y Accion Guardar'

        private Boolean Grabar_()
        {

            try
            {
                Boolean Respuesta_Grabar_Provee = true;
                Boolean Respuesta_Grabar_Persona = true;
                Boolean Respuesta_Graba_Persona_Direccion = true;

                if (validaciones() == false)
                {
                    return false; 
                }

                string msgError = "";
                Boolean Ya_Existe_Persona = false;
                decimal IdPersona = 0;
                decimal IdProveedor = 0;

                Ya_Existe_Persona =  (Convert.ToDecimal(txt_idPersona.Text) > 0) ?true:false;
                

                GetInfo_Persona();
                GetInfo_Proveedor();
                GetInfo_Per_Dire();

                    if (Ya_Existe_Persona==false)//no existe persona grabo la persona
                    {
                       Respuesta_Grabar_Persona= BusPersona.GrabarDB(InfoPersona, ref IdPersona, ref msgError);
                        InfoProveedor.IdPersona = IdPersona;
                        txt_idPersona.Text = IdPersona.ToString();
                    }

                    if (Ya_Existe_Persona == true)// existe la persona procedor a actualizar
                    {
                        Respuesta_Grabar_Persona = BusPersona.ModificarDB(InfoPersona,ref msgError);
                        InfoProveedor.IdPersona = InfoPersona.IdPersona;
                        txt_idPersona.Text = InfoPersona.IdPersona.ToString();
                    }

                    InfoProveedor.ip = param.ip;
                    InfoProveedor.Fecha_Transac = param.Fecha_Transac;
                    InfoProveedor.nom_pc = param.nom_pc;
                    InfoProveedor.IdUsuario = param.IdUsuario;
                    string msgErro = "";


                    if (Respuesta_Grabar_Persona)// si grabo o actualizo la persona procede a grabar el proveedor
                    {
                        Respuesta_Grabar_Provee = BusProveedor.GrabarDB(InfoProveedor, ref IdProveedor, ref msgErro);

                        if (Respuesta_Grabar_Provee)
                        {

                            txt_IdProveedor.Text = IdProveedor.ToString();
                            
                            
                            Bus_Provee_Cod_Sri.GrabarDB(List_Proveedor_Cod_Sri);


                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El Proveedor", IdProveedor);
                            MessageBox.Show(smensaje, param.Nombre_sistema);

                        }
                        else
                        {
                            MessageBox.Show("No se grabó" + msgErro, "SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }

                    if (Respuesta_Grabar_Persona)// si grabo o actualizo la persona procede a grabar el proveedor
                    {                       
                        if (Respuesta_Grabar_Provee)
                        {

                            Respuesta_Graba_Persona_Direccion = Bus_PerDirecc.GuardarDB(Lista_PerDirecc, Convert.ToDecimal(txt_idPersona.Text.Trim()), ref msgErro);
                            //MessageBox.Show("Se ha Grabado la Dirección", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se grabó" + msgErro, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                    return (Respuesta_Grabar_Persona && Respuesta_Grabar_Provee && Respuesta_Graba_Persona_Direccion);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
                
            }

        }

        private Boolean Actualizar()
        {

            try
            {

                Boolean Respuesta_Actualizar_Provee = true;
                Boolean Respuesta_Actualizar_Persona = true;
                Boolean Respuesta_Actualizar_Per_Direc = true;

                if (validaciones() == false)
                {
                    return false;
                }

                

                GetInfo_Persona();
                GetInfo_Proveedor();
                GetInfo_Per_Dire();
                if (Lista_PerDirecc.Count() != 0)
                {                   
                    foreach (var item in Lista_PerDirecc)
                    {
                        item.IdPersona = InfoPersona.IdPersona;
                        if (item.IdDireccion == 0)
                        {
                            Info_PerDirecc = new tb_persona_direccion_Info();
                            Info_PerDirecc.IdPersona = item.IdPersona;
                            //Info_PerDirecc.IdDireccion = item.IdDireccion;
                            Info_PerDirecc.Direccion = item.Direccion;
                            Info_PerDirecc.IdTipoDireccion = item.IdTipoDireccion;
                            Info_PerDirecc.prioridad = item.prioridad;
                            Info_PerDirecc.estado = true;
                            Info_PerDirecc.Ciudad = "";
                            Info_PerDirecc.calle = "";
                            Info_PerDirecc.cod_postal = "";
                            Info_PerDirecc.referencia = "";

                            Bus_PerDirecc.GuardarDB(Info_PerDirecc, Info_PerDirecc.IdPersona, ref MensajeError);
                        }
                        else
                        {
                            Respuesta_Actualizar_Per_Direc = Bus_PerDirecc.ModificarDB(Lista_PerDirecc, ref MensajeError);
                        }                        
                    }
                }
                
                    InfoProveedor.IdUsuarioUltMod = param.IdUsuario;
                    InfoProveedor.Fecha_UltMod = param.Fecha_Transac;

                   Respuesta_Actualizar_Provee= BusProveedor.ModificarDB(InfoProveedor);
                   Respuesta_Actualizar_Persona= BusPersona.ModificarDB(InfoPersona, ref MensajeError);
                   Bus_Provee_Cod_Sri.ModificarLista(InfoProveedor);
                   

                    string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Modificar, "El Proveedor", InfoProveedor.IdProveedor);
                    MessageBox.Show(smensaje, param.Nombre_sistema);
                    

                    return Respuesta_Actualizar_Provee;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        private void Anular()
        {
            try
            {
                if (InfoProveedor.pr_estado != "I")
                {
                    if (MessageBox.Show("¿Está seguro que desea anular el Proveedor #:" + txt_IdProveedor.Text.Trim() + " ?", "Anulación ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion fr = new FrmGe_MotivoAnulacion();
                        fr.ShowDialog();
                       
                        
                        string mensaje = string.Empty;

                        GetInfo_Proveedor();

                        InfoProveedor.IdUsuarioUltAnu = param.IdUsuario;
                        InfoProveedor.MotivoAnulacion = fr.motivoAnulacion;
                        bool resultado = BusProveedor.AnularDB(InfoProveedor);
                        if (resultado)
                        {
                            MessageBox.Show("Se ha anulado correctamente el proveedor # : " + txt_IdProveedor.Text, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            Log_Error_bus.Log_Error(mensaje.ToString());
                            MessageBox.Show("Error " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El Proveedor #:" + txt_IdProveedor.Text.Trim() + " ya se encuentra anulado.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show("Error " + ex.Message.ToString(), "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool Accion_Guardar()
        {
            bool resultado = false;
            try
            {
                if (validaciones())
                {
                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            resultado = Grabar_();

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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
            
        }

        #endregion



        public frmCP_Proveedor_Mant()
        {
            try
            {
                InitializeComponent();
           
                uc_Proveedor_Clase.event_cmb_Provedor_clase_EditValueChanged += uc_Proveedor_Clase_event_cmb_Provedor_clase_EditValueChanged;
                UCDocumento.event_cmb_Docum_perso_SelectedValueChanged += UCDocumento_event_cmb_Docum_perso_SelectedValueChanged;
                event_frmCP_MantProveedor_FormClosing += frmCP_Proveedor_Mant_event_frmCP_MantProveedor_FormClosing;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void frmCP_Proveedor_Mant_event_frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmCP_MantProveedor_Load(object sender, EventArgs e)
        {

             try
            {
                if (_Accion == 0)  { _Accion = Info.General.Cl_Enumeradores.eTipo_action.grabar; }

                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);


                if (UCDocumento.cmb_Docum_perso.SelectedValue.ToString() == "CED")
                {
                    txe_cedRucPas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    txe_cedRucPas.Properties.Mask.EditMask = @"\d{0,10}";
                }


                Cargar_Combos();
                Set_Id_Combos_Ubicacion();
                set_Accion_Controles();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


        private void frmCP_MantProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               this.event_frmCP_MantProveedor_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        

        #region 'Eventos de Botones'

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Guardar())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Guardar())
                {
                    _Accion = Info.General.Cl_Enumeradores.eTipo_action.grabar;
                    Limpiar();
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {

                Anular();
                Limpiar();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnlimpiar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Set_Id_Combos_Ubicacion()
        {
            try
            {
                foreach (TabPage item in tabGeneral.TabPages)
                {
                    tabGeneral.SelectedTab = item;
                }
                tabGeneral.SelectedTab = tabPageDatosPrin;

                cmb_nacionalidad.SelectedIndex = 0;
                ucGe_PaisProvinciaCiudad.CargarComboPais();
                ucGe_PaisProvinciaCiudad.cmbCiudad.EditValue = "1";
                ucGe_PaisProvinciaCiudad.cmbPais.EditValue = "1";
                ucGe_PaisProvinciaCiudad.cmbProvincia.EditValue = "1";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_Combos()
        {
            try
            {
                uc_Proveedor_Clase.cargar_Claseproveedores();

                lista_codigo_sri = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion, param.IdEmpresa);
                BinList_codigoSRI = new BindingList<cp_codigo_SRI_Info>();
                gridControl_SRI.DataSource = BinList_codigoSRI;

                lista_codigoSRI_grid = dat_ti.Get_List_codigo_SRI_IvaRet(param.IdEmpresa);
                cmb_IdCodigoSRI_grid.DataSource = lista_codigoSRI_grid;
                cmb_IdCodigoSRI_grid.DisplayMember = "descriConcate";
                cmb_IdCodigoSRI_grid.ValueMember = "IdCodigo_SRI";

                string[] CodRetencion2 = new string[] { "COD_ICE" };

                lista_codigoSRI = new List<cp_codigo_SRI_Info>();
                lista_codigoSRI = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion2, param.IdEmpresa);

                cmb_ICE.Properties.DisplayMember = "descriConcate";
                cmb_ICE.Properties.ValueMember = "IdCodigo_SRI";
                cmb_ICE.Properties.DataSource = lista_codigoSRI;

                string[] CodRetencion3 = new string[] { "COD_101" };

                lista_codigoSRI = new List<cp_codigo_SRI_Info>();
                lista_codigoSRI = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion3, param.IdEmpresa);

                cmb_101.Properties.DisplayMember = "descriConcate";
                cmb_101.Properties.ValueMember = "IdCodigo_SRI";
                cmb_101.Properties.DataSource = lista_codigoSRI;

                string[] CodRetencion4 = new string[] { "COD_IDCREDITO" };

                lista_codigoSRI = new List<cp_codigo_SRI_Info>();
                lista_codigoSRI = dat_ti.Get_List_codigo_SRI_x_codigo(CodRetencion4, param.IdEmpresa);

                cmb_idtCredito.Properties.DisplayMember = "descriConcate";
                cmb_idtCredito.Properties.ValueMember = "IdCodigo_SRI";
                cmb_idtCredito.Properties.DataSource = lista_codigoSRI;

                uCct_Pto_Cargo_Grupo1.Cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
