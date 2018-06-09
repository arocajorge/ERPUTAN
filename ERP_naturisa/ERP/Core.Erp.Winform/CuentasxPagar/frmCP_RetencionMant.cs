using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.CuentasxPagar;

using Core.Erp.Winform.General;

using Cus.Erp.Reports.Naturisa.CuentasxPagar;

using Core.Erp.Info.class_sri.Retencion;
using System.Xml.Serialization;
using System.IO;

using Core.Erp.Info.General;

using Core.Erp.Reportes.CuentasxPagar;



namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_RetencionMant : Form
    {
        decimal IdProveedor;
        double sumValorRet = 0;
        FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
        
        
        #region Declaración de Variables
        //Bus        
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();     
        cp_parametros_Bus paramCP_B = new cp_parametros_Bus();   
        cp_retencion_Bus busRetencion = new cp_retencion_Bus();
        cp_codigo_SRI_Bus busCodigoSRI = new cp_codigo_SRI_Bus();
        cp_orden_giro_Bus busOgiro = new cp_orden_giro_Bus();
        ct_Cbtecble_Bus busCbtecble = new ct_Cbtecble_Bus();
          
        //Listas 
        List<cp_retencion_det_Info> listDetReten = new List<cp_retencion_det_Info>();
        List<cp_proveedor_codigo_SRI_Info> lista_CodigoSRI_Proveedor = new List<cp_proveedor_codigo_SRI_Info>();
        cp_proveedor_codigo_SRI_Bus bus_CodigoSRI_Proveedor = new cp_proveedor_codigo_SRI_Bus();
        List<cp_codigo_SRI_Info> lm_codigo_sri = new List<cp_codigo_SRI_Info>();
        List<cp_orden_giro_Info> list_Og = new List<cp_orden_giro_Info>();

        //Infos
        cp_parametros_Info paramCP_I = new cp_parametros_Info();
        cp_proveedor_Info infoProveedor = new cp_proveedor_Info();
        vwcp_orden_giro_sin_retenciones_Info infoSinReten = new vwcp_orden_giro_sin_retenciones_Info();
       
        cp_retencion_x_ct_cbtecble_Info infoRetCbteCble = new cp_retencion_x_ct_cbtecble_Info();   
        cp_retencion_Info infoRetencion = new cp_retencion_Info();
        ct_Cbtecble_Info InfoCbteCble = new ct_Cbtecble_Info();
        cp_retencion_Info Info_Retencion = new cp_retencion_Info();
                
        //Variables
        double sumBaseIVA = 0;
        double sumBaseRTF = 0;
        int contIVA = 0;
        int contRTF = 0;    
        string MensajeError = "";

        string Imp_ReImp = "";

        frmCP_ImprimirRetencion fr = new frmCP_ImprimirRetencion();
        Cl_Enumeradores.eTipo_action Accion = new Cl_Enumeradores.eTipo_action();


         //Delegados       
        public delegate void delegate_frmCP_RetencionMant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCP_RetencionMant_FormClosing event_frmCP_RetencionMant_FormClosing;
        
        #endregion



        public void Set_Info_Retencion(cp_retencion_Info _Info_Retencion )
        {
            Info_Retencion = _Info_Retencion;
            ucCp_Retencion1.set_Info_Retencion(_Info_Retencion);
        }


        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion_)
        {
            Accion = Accion_;
        }

        public frmCP_RetencionMant()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;

            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            ucGe_Menu.event_btn_Generar_XML_Click += ucGe_Menu_event_btn_Generar_XML_Click;

            ucGe_Menu.event_btnImprimirSoporte_Click += ucGe_Menu_event_btnImprimirSoporte_Click;
            event_frmCP_RetencionMant_FormClosing+=frmCP_RetencionMant_event_frmCP_RetencionMant_FormClosing;

            ucGe_Menu.event_btnReImprimir_Click += ucGe_Menu_event_btnReImprimir_Click;
       

            ucCp_Retencion1.event_gridView_SRI_CellValueChanged += ucCp_Retencion1_event_gridView_SRI_CellValueChanged;
        }

        void Inicializar_Controles()
        {
            try
            {
                Accion = Cl_Enumeradores.eTipo_action.grabar;
                infoRetencion = new cp_retencion_Info();
                infoSinReten = new vwcp_orden_giro_sin_retenciones_Info();

                txtNumCbte.EditValue = null;
                dteFechaOg.EditValue = null;
                dteFechaFact.EditValue =null;
                txtTipoDoc.EditValue = null;
                txtNumDoc.EditValue = null;
                txtProveedor.EditValue = null;
                txtObservacion.Text = "";
                txtSubTotalIva.EditValue = null;
                txtSubtotal0.EditValue = null;
                txtNoObjetoDeIva.EditValue = null;
                txtIva.EditValue = null;
                txtValorIva.EditValue = null;
                txtServicio.EditValue = null;
                txtValorServicio.EditValue = null;
                txtBaseImponible.EditValue = null;

                ucCp_Retencion1.LimpiarGrid_Retencion();
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
                Inicializar_Controles();
            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                XCXP_NATU_Rpt005_Rpt reporte1 = new XCXP_NATU_Rpt005_Rpt();

                reporte1.set_parametros(Convert.ToInt32(Info_Retencion.IdEmpresa_Ogiro), Convert.ToDecimal(Info_Retencion.IdCbte_CXP), Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro));
                reporte1.RequestParameters = true;
                reporte1.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        void ucGe_Menu_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    string mensaje = "";

                    cp_parametros_Bus bus_Param = new cp_parametros_Bus();
                    cp_parametros_Info param_info = new cp_parametros_Info();

                    param_info = bus_Param.Get_Info_parametros(param.IdEmpresa);

                    if (String.IsNullOrEmpty(param_info.pa_ruta_descarga_xml_fac_elct))
                    {
                        MessageBox.Show("No existe Ruta de Descarga","Sistemas");
                        return;
                    
                    }

                    if (busRetencion.Generacion_xml_SRI(param.IdEmpresa, Convert.ToDecimal(ucCp_Retencion1.txtIdRetencion.EditValue), ref  mensaje))
                    {
                        MessageBox.Show(mensaje);
                    }
                    else
                    { MessageBox.Show(mensaje); }
                }
                catch (Exception ex)
                {
                    Log_Error_bus.Log_Error(ex.ToString());
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucCp_Retencion1_event_gridView_SRI_CellValueChanged(object sender, EventArgs e)
        {
            try
            {
                ucCp_Retencion1.set_Valores(Convert.ToDouble(txtBaseImponible.EditValue), Convert.ToDouble(txtValorIva.EditValue));

                ucCp_Retencion1.set_Datos_Proveedor(infoSinReten.IdCtaCble_CXP, txtProveedor.Text, Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));
             
           }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnReImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imp_ReImp = "RI";
                Imprimir_Retencion(Imp_ReImp);
                                   
            }
            catch (Exception ex)
            {              
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void Imprimir_Retencion(string Imp_ReImp)
        {
            try
            {            
                string titulo = "";

                switch (Imp_ReImp)
                {
                    case "I":
                        //Imprimir
                        titulo = "Impresión de Retención y Actualización de Talonario de Retención.";
                        break;
                    case "RI":
                        //Reimprimir
                        titulo = "Reimpresión de Retención # " + ucCp_Retencion1.Get_Info_Talonario().NumDocumento;
                        break;               
                    default:
                        break;
                }

                 busOgiro = new cp_orden_giro_Bus();
                 list_Og = new List<cp_orden_giro_Info>();
                 list_Og = busOgiro.Get_List_orden_giro (param.IdEmpresa, Convert.ToDecimal(txtNumCbte.EditValue));
                 fr = new frmCP_ImprimirRetencion();

                 fr.Text = titulo;

                 fr.set_numRetencion(Convert.ToString(ucCp_Retencion1.Get_Info_Talonario().Establecimiento + "-" + ucCp_Retencion1.Get_Info_Talonario().PuntoEmision), ucCp_Retencion1.Get_Info_Talonario().NumDocumento,
                  list_Og.ToArray(),
                 infoRetencion.IdRetencion, paramCP_I.pa_TipoCbte_OG, ucCp_Retencion1.Get_Info_Talonario().CodDocumentoTipo);

                 fr.ShowDialog();

                 if (Imp_ReImp == "I")
                {
                    infoRetencion = busRetencion.Get_Info_retencion(param.IdEmpresa, Convert.ToDecimal(txtNumCbte.EditValue), paramCP_I.pa_TipoCbte_OG);
                    if (infoRetencion.re_EstaImpresa == "S")
                    {
                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bnRetImprimir = true;
                        ucGe_Menu.Enabled_btnImprimirSoporte = true;
                    }     
                              
                }             
            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
      
        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imp_ReImp = "I";
                Imprimir_Retencion(Imp_ReImp);
                                                                                                                                                                                       
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
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        if (ValidaBaseIvaRtf())
                        {
                            Grabar_Retencion();
                            Close();
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        if (Valida())
                        {
                            Modificar_Retencion();
                            Close();
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Anular_Retencion();
                        Close();
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        break;
                    default:
                        break;
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
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:

                            if (ValidaBaseIvaRtf())
                            {
                                Grabar_Retencion();
                            }
                                                                               
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                           
                            if(Valida())
                            {
                                Modificar_Retencion();
                            }
                          
                            break;
                        case Cl_Enumeradores.eTipo_action.Anular:
                            Anular_Retencion();
                            break;
                        case Cl_Enumeradores.eTipo_action.consultar:
                            break;
                        default:
                            break;
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
                    Anular_Retencion();
                    this.Close();
                    this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        
        private void btnConsProv_Click(object sender, EventArgs e)
        {
            try
            {
                frmCP_ConsultaRetencion_Proveedor frm = new frmCP_ConsultaRetencion_Proveedor();
               
                frm.ShowDialog();
                infoSinReten = frm.Info;

                txtNumCbte.Text = Convert.ToString(infoSinReten.IdCbteCble_Ogiro);
                txtNumDoc.Text = infoSinReten.co_serie + " - " + infoSinReten.co_factura;
                txtProveedor.Text = infoSinReten.pr_nombre;
                txtObservacion.Text = infoSinReten.co_observacion;
                dteFechaOg.EditValue = infoSinReten.co_fechaOg;
                dteFechaFact.EditValue = infoSinReten.co_FechaFactura;
                txtSubTotalIva.EditValue = infoSinReten.co_subtotal_iva;
                txtSubtotal0.EditValue = infoSinReten.co_subtotal_siniva;
                txtNoObjetoDeIva.EditValue = infoSinReten.BseImpNoObjDeIva;
                txtIva.EditValue = infoSinReten.co_Por_iva;
                txtValorIva.EditValue = infoSinReten.co_valoriva;
                txtServicio.EditValue = infoSinReten.co_Serv_por;
                txtValorServicio.EditValue = infoSinReten.co_Serv_valor;

                txtTipoDoc.EditValue = infoSinReten.Tipo_Documento;
                txtBaseImponible.EditValue = infoSinReten.co_baseImponible;
                        
                IdProveedor = infoSinReten.IdProveedor;
         
                Inhablita_Campos();

                ucCp_Retencion1.LimpiarGrid_Retencion();
        
                ucCp_Retencion1.Get_Primer_Documento_no_usado(param.IdEmpresa, "001", "001");           
              
                ucCp_Retencion1.set_Datos_Proveedor(infoSinReten.IdCtaCble_CXP, infoSinReten.pr_nombre,Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion));

                Obtener_CodigoSRI_x_Proveedor(param.IdEmpresa, infoSinReten.IdProveedor);

                ucCp_Retencion1.GeneraDiarioRetencion();



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                  
        }

        private void Obtener_CodigoSRI_x_Proveedor(int IdEmpresa, decimal IdProveedor)
        {
            try
            {
                 lista_CodigoSRI_Proveedor= new List<cp_proveedor_codigo_SRI_Info>();
                 bus_CodigoSRI_Proveedor= new cp_proveedor_codigo_SRI_Bus();

                 lista_CodigoSRI_Proveedor = bus_CodigoSRI_Proveedor.Get_List_proveedor_codigo_SRI(IdEmpresa, IdProveedor);

                 if (lista_CodigoSRI_Proveedor.Count != 0)
                 {

                     lm_codigo_sri = new List<cp_codigo_SRI_Info>();
                     lm_codigo_sri = busCodigoSRI.Get_List_codigo_SRI_IvaRet(param.IdEmpresa);
                     List<cp_codigo_SRI_Info> listaAux_codigoSRI_grid = new List<cp_codigo_SRI_Info>();


                     if (lm_codigo_sri.Count !=0)
                     {
                         foreach (var item in lista_CodigoSRI_Proveedor)
                         {
                             cp_codigo_SRI_Info info = new cp_codigo_SRI_Info();

                             var item2 = lm_codigo_sri.FirstOrDefault(c => c.IdCodigo_SRI == item.IdCodigo_SRI);

                             info.IdCodigo_SRI = item2.IdCodigo_SRI;
                             info.Tipo = item2.Tipo;
                             info.co_porRetencion = item2.co_porRetencion;
                             info.IdCtaCble = item2.IdCtaCble;
                             info.FechaVigente = item2.FechaVigente;

                             if (item2.Tipo == "IVA")
                             {
                                 info.BaseImponible = Convert.ToDouble(txtValorIva.EditValue);
                                 info.MontoRetencion = info.BaseImponible * (item2.co_porRetencion / 100);
                             }
                             else
                             {
                                 info.BaseImponible = Convert.ToDouble(txtBaseImponible.EditValue);
                                 info.MontoRetencion = info.BaseImponible * (item2.co_porRetencion / 100);
                             
                             }

                             info.codigoSRI = item2.codigoSRI;
                             


                             listaAux_codigoSRI_grid.Add(info);
                         }
                     
                     }

                     ucCp_Retencion1.set_ListaCodigoSRI(listaAux_codigoSRI_grid);

                 }

            }
            catch (Exception ex)
            {                
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void set_accion_in_controls()
        {

            try
            {
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        Inhablita_Campos();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Visible_btnGuardar = true;

                        ucGe_Menu.Enabled_bntImprimir = false;

                        ucGe_Menu.Enabled_btn_Generar_XML = false;


                        ucGe_Menu.Enabled_bnRetImprimir = false;

                        ucGe_Menu.Enabled_btnImprimirSoporte = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Inhablita_Campos();

                        ucCp_Retencion1.dtp_fechaEmisionRetencion.Enabled = false;

                        txtObservacion.Enabled = true;

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Visible_btnGuardar = true;

                        btnConsProv.Enabled = false;
                        set_Info_In_Controls();

                        ucCp_Retencion1.Inhabilitar_Controles_numDocuRetencion();
                        ucCp_Retencion1.Inhabilitar_Controles_Retencion(false);
                        ucCp_Retencion1.HabilitarGrid_Diario_retencion(false);


                        if (Info_Retencion.re_EstaImpresa == "S")
                        {
                            ucGe_Menu.Enabled_bntImprimir = false;
                            ucGe_Menu.Enabled_bnRetImprimir = true;
                        }
                        else
                        {
                            ucGe_Menu.Enabled_bntImprimir = true;
                            ucGe_Menu.Enabled_bnRetImprimir = false;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Inhablita_Campos();
                        ucGe_Menu.Enabled_bntAnular = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Visible_btnGuardar = false;

                        ucCp_Retencion1.dtp_fechaEmisionRetencion.Enabled = false;

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_bntAnular = true;

                        //btnGrabar.Image=Core.Erp.Winform.Properties.Resources.eliminar;

                        btnConsProv.Enabled = false;
                        set_Info_In_Controls();

                        ucCp_Retencion1.Inhabilitar_Controles_numDocuRetencion();
                        ucCp_Retencion1.Inhabilitar_Controles_Retencion(false);
                        ucCp_Retencion1.HabilitarGrid_Diario_retencion(false);

                        ucGe_Menu.Enabled_bntImprimir = false;
                        ucGe_Menu.Enabled_bnRetImprimir = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Inhablita_Campos();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntSalir = true;
                        ucGe_Menu.Visible_btnGuardar = false;

                        ucCp_Retencion1.dtp_fechaEmisionRetencion.Enabled = false;

                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;

                        ucCp_Retencion1.Inhabilitar_Controles_numDocuRetencion();

                        btnConsProv.Enabled = false;
                        set_Info_In_Controls();

                        if (Info_Retencion.re_EstaImpresa == "S")
                        {
                            ucGe_Menu.Enabled_bntImprimir = false;
                            ucGe_Menu.Enabled_bnRetImprimir = true;
                        }
                        else
                        {
                            ucGe_Menu.Enabled_bntImprimir = true;
                            ucGe_Menu.Enabled_bnRetImprimir = false;
                        }

                        ucCp_Retencion1.Inhabilitar_Controles_numDocuRetencion();
                        ucCp_Retencion1.Inhabilitar_Controles_Retencion(false);
                        ucCp_Retencion1.HabilitarGrid_Diario_retencion(false);

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

            }
        
        }

        void set_Info_In_Controls()
        {
            try
            {
                cp_orden_giro_Info infOgiro = new cp_orden_giro_Info();
                infOgiro.IdCbteCble_Ogiro = Convert.ToDecimal(Info_Retencion.IdCbteCble_Ogiro);
                infOgiro.IdTipoCbte_Ogiro = Convert.ToInt32(Info_Retencion.IdTipoCbte_Ogiro);
                infOgiro.IdEmpresa = param.IdEmpresa; 
                                           
                infOgiro = busOgiro.Get_Info_orden_giro(infOgiro);

                txtNumCbte.Text = Convert.ToString(infOgiro.IdCbteCble_Ogiro);
                txtNumDoc.Text = infOgiro.co_serie + " - " + infOgiro.co_factura;
                txtProveedor.Text = Info_Retencion.NomProveedor;
                txtObservacion.Text = infOgiro.co_observacion;
                dteFechaOg.EditValue = infOgiro.co_fechaOg;
                dteFechaFact.EditValue = infOgiro.co_FechaFactura;
                txtSubTotalIva.EditValue = infOgiro.co_subtotal_iva;
                txtSubtotal0.EditValue = infOgiro.co_subtotal_siniva;
                txtNoObjetoDeIva.EditValue = infOgiro.BseImpNoObjDeIva;
                txtIva.EditValue = infOgiro.co_Por_iva;
                txtValorIva.EditValue = infOgiro.co_valoriva;
                txtServicio.EditValue = infOgiro.co_Serv_por;
                txtValorServicio.EditValue = infOgiro.co_Serv_valor;

                txtBaseImponible.EditValue = infOgiro.co_baseImponible;
                txtTipoDoc.EditValue = Info_Retencion.Tipo_Documento;

                


                ucCp_Retencion1.txtIdRetencion.EditValue = Info_Retencion.IdRetencion;          
               
                if (Info_Retencion.Estado == "I")
                {
                    lblAnulada.Visible = true;
                }
                else
                {
                    lblAnulada.Visible = false;                
                }

                //Detalle Retencion
                List<cp_retencion_det_Info> listRetencion = new List<cp_retencion_det_Info>();
                cp_retencion_det_Bus bus_DetRetencion = new cp_retencion_det_Bus();
                if (Info_Retencion.IdEmpresa_Ogiro != null && Info_Retencion.IdCbte_CXP != null && Info_Retencion.IdTipoCbte_Ogiro != null)
                {
                    listRetencion = bus_DetRetencion.Get_List_retencion_det_x_Report(infOgiro.IdEmpresa, infOgiro.IdCbteCble_Ogiro, infOgiro.IdTipoCbte_Ogiro);         

                }
                else
                {
                    listRetencion = bus_DetRetencion.Get_List_retencion_det_x_Report(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion);                        
                }
                             
                List<cp_codigo_SRI_Info> listSRI= new List<cp_codigo_SRI_Info>();
                
                foreach (var item in listRetencion)
                {
                    cp_codigo_SRI_Info infoSRI = new cp_codigo_SRI_Info();
                    infoSRI.IdCodigo_SRI = item.IdCodigo_SRI;
                    infoSRI.Tipo = item.re_tipoRet;
                    infoSRI.co_porRetencion = item.re_Porcen_retencion;
                    infoSRI.BaseImponible = item.re_baseRetencion;
                    infoSRI.MontoRetencion = Convert.ToDouble(item.re_valor_retencion);
                    infoSRI.IdCtaCble = item.IdCtaCble;
                    infoSRI.FechaVigente = item.FVigCoSRI;

                    listSRI.Add(infoSRI);
                }
     
                ucCp_Retencion1.set_ListaCodigoSRI(listSRI);
              

                if (Info_Retencion.serie1 != null && Info_Retencion.NumRetencion != null)
                {
                    ucCp_Retencion1.set_Valores_Documento(Info_Retencion.serie1,Info_Retencion.serie2, Info_Retencion.NumRetencion);
                }
                else
                {                 
                    ucCp_Retencion1.Get_Ult_Documento_no_usado(param.IdEmpresa, "001","001");               
                }
                             
                //Detalle Diario Retencion  
                          
                infoRetCbteCble = busRetencion.Get_Info_retencion_x_ct_cbtecble(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion);
                        
                ucCp_Retencion1.setInfo_DiarioRetencion(infoRetCbteCble.ct_IdEmpresa, infoRetCbteCble.ct_IdTipoCbte, infoRetCbteCble.ct_IdCbteCble);


            }
            catch (Exception ex)
            {               
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }

        void Inhablita_Campos()
        {
            try
            {
            
                ucCp_Retencion1.txtIdRetencion.Enabled = false;
                ucCp_Retencion1.txtIdRetencion.BackColor=System.Drawing.Color.White;
                ucCp_Retencion1.txtIdRetencion.ForeColor = System.Drawing.Color.Black;

                txtTipoDoc.Enabled = false;
                txtTipoDoc.BackColor = System.Drawing.Color.White;
                txtTipoDoc.ForeColor = System.Drawing.Color.Black;
                
                txtNumCbte.Enabled = false;
                txtNumCbte.BackColor = System.Drawing.Color.White;
                txtNumCbte.ForeColor = System.Drawing.Color.Black;

                txtNumDoc.Enabled = false;
                txtNumDoc.BackColor = System.Drawing.Color.White;
                txtNumDoc.ForeColor = System.Drawing.Color.Black;

                txtProveedor.Enabled = false;
                txtProveedor.BackColor = System.Drawing.Color.White;
                txtProveedor.ForeColor = System.Drawing.Color.Black;

                txtObservacion.Enabled = false;
                txtObservacion.BackColor = System.Drawing.Color.White;
                txtObservacion.ForeColor = System.Drawing.Color.Black;

                txtSubTotalIva.Enabled = false;
                txtSubTotalIva.BackColor = System.Drawing.Color.White;
                txtSubTotalIva.ForeColor = System.Drawing.Color.Black;

                txtIva.Enabled = false;
                txtIva.BackColor = System.Drawing.Color.White;
                txtIva.ForeColor = System.Drawing.Color.Black;

                txtValorIva.Enabled = false;
                txtValorIva.BackColor = System.Drawing.Color.White;
                txtValorIva.ForeColor = System.Drawing.Color.Black;

                txtSubtotal0.Enabled = false;
                txtSubtotal0.BackColor = System.Drawing.Color.White;
                txtSubtotal0.ForeColor = System.Drawing.Color.Black;

                txtServicio.Enabled = false;
                txtServicio.BackColor = System.Drawing.Color.White;
                txtServicio.ForeColor = System.Drawing.Color.Black;

                txtValorServicio.Enabled = false;
                txtValorServicio.BackColor = System.Drawing.Color.White;
                txtValorServicio.ForeColor = System.Drawing.Color.Black;

                txtNoObjetoDeIva.Enabled = false;
                txtNoObjetoDeIva.BackColor = System.Drawing.Color.White;
                txtNoObjetoDeIva.ForeColor = System.Drawing.Color.Black;

                txtBaseImponible.Enabled = false;
                txtBaseImponible.BackColor = System.Drawing.Color.White;
                txtBaseImponible.ForeColor = System.Drawing.Color.Black;

                dteFechaOg.Enabled = false;
                dteFechaOg.BackColor = System.Drawing.Color.White;
                dteFechaOg.ForeColor = System.Drawing.Color.Black;

                dteFechaFact.Enabled = false;
                dteFechaFact.BackColor = System.Drawing.Color.White;
                dteFechaFact.ForeColor = System.Drawing.Color.Black;
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                                        
        }

        void frmCP_RetencionMant_event_frmCP_RetencionMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
       
        private void frmCP_RetencionMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            event_frmCP_RetencionMant_FormClosing(sender,e);
        }    
       
        private void frmCP_RetencionMant_Load(object sender, EventArgs e)
        {
            try
            {                                                   
                paramCP_I = paramCP_B.Get_Info_parametros(param.IdEmpresa);
                if (Accion == 0) { Accion = Info.General.Cl_Enumeradores.eTipo_action.grabar; }
                set_accion_in_controls();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                                                  
        }     
           
        void GetCabecera_Retencion()
        {
            try
            {
               
                
                infoRetencion.IdEmpresa = param.IdEmpresa;
                infoRetencion.IdEmpresa_Ogiro = infoSinReten.Idempresa;
                infoRetencion.IdCbteCble_Ogiro = Convert.ToDecimal(txtNumCbte.Text);
                infoRetencion.IdTipoCbte_Ogiro = infoSinReten.IdTipoCbte_Ogiro;                
                infoRetencion.observacion = txtObservacion.Text;
         
                infoRetencion.fecha = Convert.ToDateTime(ucCp_Retencion1.dtp_fechaEmisionRetencion.Value);
                infoRetencion.serie1 = ucCp_Retencion1.Get_Info_Talonario().Establecimiento;
                infoRetencion.serie2 = ucCp_Retencion1.Get_Info_Talonario().PuntoEmision;                    
                infoRetencion.NumRetencion = ucCp_Retencion1.Get_Info_Talonario().NumDocumento == "" ? "0" : ucCp_Retencion1.Get_Info_Talonario().NumDocumento;
                                       
                infoRetencion.IdUsuario = param.IdUsuario;
                infoRetencion.Fecha_Transac = param.Fecha_Transac;
                infoRetencion.nom_pc = param.nom_pc;
                infoRetencion.ip = param.ip;

                if (contIVA > 0)
                {
                    infoRetencion.re_Tiene_RTiva = "S";
                }
                else
                {
                    infoRetencion.re_Tiene_RTiva = "N";
                }
                if (contRTF > 0)
                {
                    infoRetencion.re_Tiene_RFuente = "S";
                }
                else
                {
                    infoRetencion.re_Tiene_RFuente = "N";               
                }

                GetDetalle_Retencion();
                infoRetencion.ListDetalle = listDetReten;                                           
            }
            catch (Exception ex)
            {               
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        void Get_Modi()
        {
            try
            {               
                infoRetencion.IdEmpresa = param.IdEmpresa;                  
                infoRetencion.IdRetencion = Convert.ToDecimal(ucCp_Retencion1.txtIdRetencion);
              
                infoRetencion.observacion = txtObservacion.Text;              
                infoRetencion.nom_pc = param.nom_pc;
                infoRetencion.ip = param.ip;
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        
        
        void GetDetalle_Retencion()
        {
            try
            {
                sumValorRet = 0;
                listDetReten = new List<cp_retencion_det_Info>();
                                      
                foreach (var item in ucCp_Retencion1.Get_BindingList())
           
                {
                    cp_retencion_det_Info infoDetReten = new cp_retencion_det_Info();
                    infoDetReten.IdEmpresa = param.IdEmpresa;
                 
                    infoDetReten.re_tipoRet = item.Tipo;

                    if (item.Tipo == "IVA")
                    {
                        infoDetReten.re_baseRetencion = Convert.ToDouble(txtValorIva.EditValue);
                    }

                    if (item.Tipo == "RTF")
                    {
                        infoDetReten.re_baseRetencion = Convert.ToDouble(txtBaseImponible.EditValue);
                    }

                    infoDetReten.re_Porcen_retencion = item.co_porRetencion;
                    infoDetReten.re_valor_retencion = Convert.ToDouble(item.MontoRetencion);
                    infoDetReten.IdCtaCble = item.IdCtaCble;
                    infoDetReten.IdUsuario = param.IdUsuario;
                    infoDetReten.Fecha_Transac = param.Fecha_Transac;
                    infoDetReten.nom_pc = param.nom_pc;
                    infoDetReten.ip = param.ip;
              
                    infoDetReten.IdCodigo_SRI = item.IdCodigo_SRI;
                    infoDetReten.re_Codigo_impuesto = item.codigoSRI;


                    sumValorRet = sumValorRet + Convert.ToDouble(infoDetReten.re_valor_retencion);

                    
                    listDetReten.Add(infoDetReten);
                }
            }
            catch (Exception ex)
            {               
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                                  
        }
       
        public Boolean getAsientoContable()
        {
            Boolean res = false;
            try
            {
                InfoCbteCble = new ct_Cbtecble_Info();                        
              
                foreach (var item in ucCp_Retencion1.Get_BindingList_ct_Cbtecble_det())
                {
                    item.dc_Observacion = "" + item.dc_Observacion;
                    item.IdEmpresa = param.IdEmpresa;                  
                    item.IdTipoCbte = Convert.ToInt32(paramCP_I.pa_IdTipoCbte_x_Retencion);

                    InfoCbteCble._cbteCble_det_lista_info.Add(item);
                }

                InfoCbteCble.IdEmpresa = param.IdEmpresa;
                if (infoSinReten.IdTipoCbte_Ogiro == 0)
                {
                    MessageBox.Show("Por favor verifique los parámetros del Tipo de comprobante de la Retención.");
                    return false;
                }
                
                InfoCbteCble.IdTipoCbte =Convert.ToInt32( paramCP_I.pa_IdTipoCbte_x_Retencion);
                InfoCbteCble.IdUsuario = param.IdUsuario;
     
                InfoCbteCble.cb_Fecha = Convert.ToDateTime(Convert.ToDateTime(ucCp_Retencion1.dtp_fechaEmisionRetencion.Value).ToShortDateString());
               
                InfoCbteCble.Anio = InfoCbteCble.cb_Fecha.Year;
                InfoCbteCble.Mes = InfoCbteCble.cb_Fecha.Month;
                InfoCbteCble.cb_Observacion = "";

                InfoCbteCble.cb_FechaTransac = param.Fecha_Transac;

                InfoCbteCble.cb_Valor = InfoCbteCble._cbteCble_det_lista_info.FindAll(var => var.dc_Valor > 0).
                    Sum(var => var.dc_Valor);

                InfoCbteCble.Mayorizado = "N";

                string mes = Convert.ToString(InfoCbteCble.Mes);
                if (mes.Length == 1)
                    mes = "0" + mes;

                string AnioMes = Convert.ToString(InfoCbteCble.Anio) + mes;
                int IdPeriodo = Convert.ToInt32(AnioMes);

                InfoCbteCble.IdPeriodo = IdPeriodo;
                InfoCbteCble.Estado = "A";
                InfoCbteCble.cb_Fecha = InfoCbteCble.cb_Fecha;
                InfoCbteCble.cb_Valor = InfoCbteCble.cb_Valor;

                res = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        void Grabar_Retencion()
         {
             try
             {
                 decimal ID = 0;
                 string msg = "";
                 
                                
                     GetCabecera_Retencion();

                     if (!getAsientoContable())
                     { MessageBox.Show("Verifique el Asiento Contable de Retención a generar."); }
                     else
                     {
                         if (MessageBox.Show("¿Está seguro de Grabar la Retención ?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {                            
                             //graba la retencion solamente la cab y det de retencion + el cbte contable
                             if (busRetencion.Graba_CbteCble_Ret_FactProveedor(infoRetencion, InfoCbteCble,  ref msg))
                             {

                                 infoRetencion.serie1 = ucCp_Retencion1.Get_Info_Talonario().Establecimiento;
                                 infoRetencion.serie2 = ucCp_Retencion1.Get_Info_Talonario().PuntoEmision;
                                 infoRetencion.NumRetencion = ucCp_Retencion1.Get_Info_Talonario().NumDocumento;
                                 infoRetencion.EsDocumentoElectronico = Convert.ToBoolean(ucCp_Retencion1.Get_Info_Talonario().es_Documento_electronico);

                                 infoRetencion.re_EstaImpresa = "S";

                                 //actualizando el suencial de la retencion serie y #retencion
                                 busRetencion.Modificar_Num_Retencion(infoRetencion, ref msg);

                                 //Actualizar valor retenido en factura proveedor
                                 cp_orden_giro_Bus bus_FactProve = new cp_orden_giro_Bus();
                                 
                                 //resta el saldo del valor a pagar de cxp
                                 if (bus_FactProve.Modificar_ValorRetencion(infoSinReten.Idempresa, infoSinReten.IdCbteCble_Ogiro, infoSinReten.IdTipoCbte_Ogiro,sumValorRet, ref msg))
                                 {                                                              
                                 }


                                 


                                                              
                                 if (MessageBox.Show("¿Desea imprimir la Retención ?", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                 {

                                   
                                     //actualizar estado Usado

                                     
                                     MessageBox.Show("Retención # : " + infoRetencion.IdRetencion + " / " + infoRetencion.NumRetencion + " - " + infoRetencion.NAutorizacion + " , Grabada Exitosamente","Sistemas");
                                                                      
                                     ucGe_Menu.Enabled_btn_Generar_XML = true;
                          
                                     //Imprime Retencion

                                     Imp_ReImp="I";
                                     Imprimir_Retencion(Imp_ReImp);
                                     Inicializar_Controles();                                                          
                                 }
                                 else
                                 {                                   
                                     MessageBox.Show("Retención # : " + infoRetencion.IdRetencion + " , Grabada Exitosamente","Sistemas");
                                     ucGe_Menu.Enabled_bntImprimir = true;
                                     ucGe_Menu.Enabled_btn_Generar_XML = true;

                                 }
                             
                                 ucCp_Retencion1.txtIdRetencion.EditValue = infoRetencion.IdRetencion;
                                 btnConsProv.Enabled = false;
                                 Inicializar_Controles();                                                                                             
                             }
                             else
                             {
                                 MessageBox.Show("Error al Grabar la Retención: " + msg, "Sistemas");
                             }
                        }
                         else
                         {
                             InfoCbteCble = new ct_Cbtecble_Info();
                             infoRetencion = new cp_retencion_Info();
                             listDetReten = new List<cp_retencion_det_Info>();
                                                
                         }                        
                     }
                 
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }                                          
         }

        private Boolean Modificar_Retencion()
        {
            try
            {              
                string msg = "";
            
                Boolean res = false;
            
                    Get_Modi();

                    if (busRetencion.ActualizarDB(infoRetencion, ref msg))
                    {
                        MessageBox.Show("Retención # : " + infoRetencion.IdRetencion + " , Modificada Exitosamente", "Sistemas");                     
                        res = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar la Retención " + msg);                    
                        res = false;
                    }
              
                return res;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
        void Anular_Retencion()
         {
             try
             {               
                 decimal idcbtecble_rev = 0;
                 string msg = "";
                 string user = "";
                 string MotivoAnulacion="";
                 
                 string numRetencion="";
   
                 numRetencion = ucCp_Retencion1.Get_Info_Talonario().Establecimiento + "-" + ucCp_Retencion1.Get_Info_Talonario().PuntoEmision + "-" + ucCp_Retencion1.Get_Info_Talonario().NumDocumento;

                 if (MessageBox.Show("¿Está realmente seguro que desea anular la Retención #: " + numRetencion + " ?. Este proceso afectará a la Orden de Giro #: " + txtNumCbte.EditValue + "", "Anulación de Retención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                 {                                                          
                     frm= new FrmGe_MotivoAnulacion();                                                                                      
                     frm.ShowDialog();
                     frm.motivoAnulacion = frm.motivoAnulacion + " .De la Orden de Giro: IdEmpresa_Ogiro: " + Info_Retencion.IdEmpresa_Ogiro + " /IdCbteCle_Ogiro: " + Info_Retencion.IdCbteCble_Ogiro + " /IdTipoCbte_Ogiro: " + Info_Retencion.IdTipoCbte_Ogiro + "";

                     infoRetencion = busRetencion.Get_Info_retencion(Info_Retencion.IdEmpresa, Info_Retencion.IdRetencion);

                     infoRetencion.IdEmpresa_Ogiro= null;
                     infoRetencion.IdTipoCbte_Ogiro = null;
                     infoRetencion.IdCbteCble_Ogiro = null;
                         infoRetencion.IdEmpresa = infoRetCbteCble.rt_IdEmpresa;
                         infoRetencion.MotivoAnulacion = frm.motivoAnulacion;
                         infoRetencion.Fecha_UltAnu = DateTime.Now;
                         infoRetencion.IdUsuarioUltAnu = param.IdUsuario;
                         

                     if (busRetencion.AnularDB(infoRetencion,ref idcbtecble_rev,ref msg))
                     {

                         MessageBox.Show("Retención # : " + txtNumCbte.EditValue + " , Anulada Exitosamente", "Sistemas");
                     }
                     else
                     {
                         MessageBox.Show("Error al Anular la Retención", "Sistemas");
                     }               
                 }                                           
             }
             catch (Exception ex)
             {                 
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }         
         }

        public Boolean ValidaBaseIvaRtf()
         {
             try
             {
                 sumBaseIVA = 0;
                 sumBaseRTF = 0;
          
                 foreach (var item in ucCp_Retencion1.Get_BindingList())
                 {
                    if (item.Tipo == "IVA")
                    {
                        sumBaseIVA = sumBaseIVA + item.BaseImponible;
                    }
                    if (item.Tipo == "RTF")
                    {
                        sumBaseRTF = sumBaseRTF + item.BaseImponible;
                    }

                  
                 }
                 if (sumBaseIVA > Convert.ToDouble(txtValorIva.EditValue))
                 {
                    MessageBox.Show("La sumatoria de la Base Imponible del detalle Tipo IVA no puede ser mayor al porcentaje del iva de la factura","Sistemas");
                    return false;
                 }

                 if (sumBaseRTF > Convert.ToDouble(txtBaseImponible.EditValue))
                 {                   
                    MessageBox.Show("La sumatoria de la Base Imponible del detalle Tipo RTF no puede ser mayor a la Base Imponible de la factura", "Sistemas");
                    return false;
                 }

                 if (ucCp_Retencion1.Get_BindingList().Count() == 0)
                 {
                    MessageBox.Show("Genere el Detalle de Retención", "Sistemas");
                    return false;                
                 }


                 if (!ucCp_Retencion1.valida())
                 {
                     return false;
                 }


                 foreach (var item in ucCp_Retencion1.Get_BindList_ct_Cbtecble_det_Retencion())
                 {
                     if (String.IsNullOrEmpty(item.IdCtaCble))
                     {
                         MessageBox.Show("Ingrese la Cta. Contable en el Diario de la Retención", "Sistemas");
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

        private Boolean Valida()
        {
            try
            {
                if (txtObservacion.Text.Length == 0 || txtObservacion.Text == "")
                {
                    MessageBox.Show("Por Favor Ingresar Descripcion");
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

        private void txtSubTotalIva_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                foreach (var item in ucCp_Retencion1.Get_BindingList())
                {
                                if (item.Tipo == "RTF")
                                {
                                    item.BaseImponible = Convert.ToDouble(Convert.ToDouble(txtSubTotalIva.EditValue) + Convert.ToDouble(txtSubtotal0.EditValue));
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                }
                                else
                                {
                                    item.BaseImponible = Convert.ToDouble(Convert.ToDouble(txtValorIva.EditValue));
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                }
                }


                ucCp_Retencion1.Set_BindingList_codigo_SRI(ucCp_Retencion1.Get_BindingList());               
              
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorIva_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                 foreach (var item in ucCp_Retencion1.Get_BindingList())
                {
                                if (item.Tipo == "RTF")
                                {
                                    item.BaseImponible = Convert.ToDouble(Convert.ToDouble(txtSubTotalIva.EditValue)+Convert.ToDouble(txtSubtotal0.EditValue));
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                }
                                else
                                {
                                    item.BaseImponible = Convert.ToDouble(Convert.ToDouble(txtValorIva.EditValue));
                                    item.MontoRetencion = item.BaseImponible * (item.co_porRetencion / 100);
                                }
                }


                ucCp_Retencion1.Set_BindingList_codigo_SRI(ucCp_Retencion1.Get_BindingList());  
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            
    }
}
