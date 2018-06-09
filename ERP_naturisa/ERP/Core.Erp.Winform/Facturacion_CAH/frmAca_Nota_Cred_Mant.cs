using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Caja;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.Facturacion;
using Core.Erp.Reportes.Facturacion;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Reportes.Contabilidad;

using System.IO;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Core.Erp.Info.Factuarcion_CAH;
using Core.Erp.Business.Facturacion_CAH;
using Core.Erp.Info.Academico;
using Core.Erp.Business.Academico;

namespace Core.Erp.Winform.Facturacion_CAH
{
    public partial class frmAca_Nota_Cred_Mant : Form
    {
        #region " Variables y Propiedades "
        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;

        public delegate void Delegate_frmFA_NotaCreditoDebito_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_frmFA_NotaCreditoDebito_FormClosing Event_frmFA_NotaCreditoDebito_FormClosing;

        
        string MensajeError = "";
        
        static string result = Path.GetTempPath();
        String RootReporte = result + @"NotaCredDeb.repx";

        fa_factura_Info info_fact = new fa_factura_Info();
        fa_factura_Bus bus_fact = new Business.Facturacion.fa_factura_Bus();
        fa_factura_det_Bus bus_fact_det = new Business.Facturacion.fa_factura_det_Bus();

        fa_notaCreDeb_Info info_notaDeb = new fa_notaCreDeb_Info();
        fa_notaCredDeb_Bus bus_notaDeb = new Business.Facturacion.fa_notaCredDeb_Bus();
        fa_notaCreDeb_det_bus bus_notaDeb_det = new Business.Facturacion.fa_notaCreDeb_det_bus();

        Business.Facturacion.fa_factura_Bus bus_factura_graf = new Business.Facturacion.fa_factura_Bus();
        Info.Facturacion.fa_factura_Info info_factura_graf = new Info.Facturacion.fa_factura_Info();

        tb_sis_Documento_Tipo_Talonario_Info talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();       

        fa_parametro_Bus Bus_Parametros = new fa_parametro_Bus();
        fa_parametro_info Info_Param_fac = new fa_parametro_info();
               
        fa_notaCreDeb_Info Info_NotaCre = new fa_notaCreDeb_Info();

        BindingList<fa_notaCreDeb_det_Info> BindiList_det_NC = new BindingList<fa_notaCreDeb_det_Info>();
        fa_notaCreDeb_det_Info Info_det = new fa_notaCreDeb_det_Info();

        List<fa_TipoNota_Info> ListTipoNota = new List<fa_TipoNota_Info>();
        fa_TipoNota_Bus BusTipoNota = new fa_TipoNota_Bus();

        BindingList<fa_notaCreDeb_x_fa_factura_NotaDeb_Info> BList_Documentos_relacionados = new BindingList<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
        fa_notaCreDeb_x_fa_factura_NotaDeb_Bus BusDocumentos_relacionados = new Business.Facturacion.fa_notaCreDeb_x_fa_factura_NotaDeb_Bus();
        fa_notaCreDeb_x_fa_factura_NotaDeb_Info Info_Doc_rel = new fa_notaCreDeb_x_fa_factura_NotaDeb_Info();

        fa_Cliente_Info infoCliente = new fa_Cliente_Info();
        fa_Cliente_Bus BusCliente = new fa_Cliente_Bus();
        caj_Caja_Bus caja_B = new caj_Caja_Bus();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        in_producto_Bus BusProducto = new in_producto_Bus();
        in_Producto_Info info_producto = new in_Producto_Info();

        List<vwFa_Documentos_x_Relacionar_NC_ND_Info> lstInfoFactura = new List<vwFa_Documentos_x_Relacionar_NC_ND_Info>();

        Core.Erp.Business.Facturacion.fa_notaCredDeb_Bus Bus_notaCredDeb = new Business.Facturacion.fa_notaCredDeb_Bus();
        Core.Erp.Business.Facturacion.fa_notaCreDeb_det_bus Bus_notaCredDeb_det = new Business.Facturacion.fa_notaCreDeb_det_bus();



        fa_notaCreDeb_x_ct_cbtecble_Bus Bus_notaCreDeb_x_ct_cbtecble = new fa_notaCreDeb_x_ct_cbtecble_Bus();
        fa_notaCreDeb_x_ct_cbtecble_Info info_CreDeb_cbtecble = new fa_notaCreDeb_x_ct_cbtecble_Info();

        ct_punto_cargo_Bus bus_Punto_cargo = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_Punto_cargo = new ct_punto_cargo_Info();
        List<ct_punto_cargo_Info> lst_Punto_cargo = new List<ct_punto_cargo_Info>();

        ct_punto_cargo_grupo_Bus bus_Grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_Grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> lst_Grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();


        tb_sis_impuesto_Bus BusImpuesto = new tb_sis_impuesto_Bus();
        List<tb_sis_impuesto_Info> List_Imp_Iva = new List<tb_sis_impuesto_Info>();

        fa_notaCredDeb_aca_Info InfoNotaCredDeb_aca = new fa_notaCredDeb_aca_Info();
        fa_notaCredDeb_aca_Bus BusNotaCredDeb_aca = new fa_notaCredDeb_aca_Bus();
        List<fa_notaCredDeb_aca_Info> ListotaCredDeb_aca = new List<fa_notaCredDeb_aca_Info>();

        Aca_Estudiante_Info Estudiante_info = new Aca_Estudiante_Info();

        List<vwAca_Familiar_x_Estudiante_RepEco_Info> Lista_familiar_x_estudiante_rep_eco = new List<vwAca_Familiar_x_Estudiante_RepEco_Info>();
        vwAca_Familiar_x_Estudiante_RepEco_Bus bus_fa_est_rep_eco = new vwAca_Familiar_x_Estudiante_RepEco_Bus();
        List<ct_Centro_costo_Info> Lista_centro_costo = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Bus bus_centro_costo = new ct_Centro_costo_Bus();

        decimal IdPersona_RepEco = 0;

        int rowHandle = 0;
        double Total = 0;
        #endregion

        #region " Constructor "
        public frmAca_Nota_Cred_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnImprimirSoporte_Click += ucGe_Menu_event_btnImprimirSoporte_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucSucursalBode.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
            ucGe_Menu.event_btn_Generar_XML_Click += ucGe_Menu_event_btn_Generar_XML_Click;
            Event_frmFA_NotaCreditoDebito_FormClosing += frmAca_Nota_Cred_Mant_Event_frmFA_NotaCreditoDebito_FormClosing;
            
        }

        void frmAca_Nota_Cred_Mant_Event_frmFA_NotaCreditoDebito_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        #endregion

        #region "Evento Load"
        private void frmAca_Nota_Cred_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                Info_Param_fac = new fa_parametro_info();
                Info_Param_fac = Bus_Parametros.Get_Info_parametro(param.IdEmpresa);

                
                BindiList_det_NC = new BindingList<fa_notaCreDeb_det_Info>();
                gridControlNotaCreDeb.DataSource = BindiList_det_NC;

                cargarCombos();
                cargarProductos();
                
                
               
                ucSucursalBode.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
               
                if (_Accion == 0)
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;

                Set_Accion_in_Controls();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region " Eventos botones click"
        void ucGe_Menu_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";
                string CreDeb = "C";

                fa_parametro_Bus bus_Param = new fa_parametro_Bus();
                fa_parametro_info param_info = new fa_parametro_info();

                param_info = bus_Param.Get_Info_parametro(param.IdEmpresa);


                if (Bus_notaCredDeb.GenerarXml_notaCreDeb(param.IdEmpresa, Convert.ToInt32(ucSucursalBode.cmb_sucursal.EditValue), Convert.ToInt32(ucSucursalBode.cmb_bodega.EditValue), Convert.ToDecimal(txtNumNot.Text), CreDeb, param_info.pa_ruta_descarga_xml_fac_elct, ref  mensaje))
                {
                    MessageBox.Show(mensaje);
                }
                else
                { MessageBox.Show(mensaje); }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo();

                XFAC_Rpt009_rpt rptSoporte = new XFAC_Rpt009_rpt(param.IdUsuario, Info_NotaCre.CreDeb);
                XFAC_Rpt009_Bus busRpt = new XFAC_Rpt009_Bus();
                List<XFAC_Rpt009_Info> lstRpt = new List<XFAC_Rpt009_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_Soporte_NC_ND(param.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

                ImprimirDiario();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
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
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo();
                string mensajeError = "";
                FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                if (Info_NotaCre.IdNota == 0)
                { return; }
                if (Info_NotaCre.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) +", "+ param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulada), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Está_seguro_que_desea_anular_la) +" Nota Cred "+ Info_NotaCre.IdTipoDoc + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ofrm.ShowDialog();
                    Info_NotaCre.MotiAnula = ofrm.motivoAnulacion;
                    Info_NotaCre.ip = param.ip;
                    Info_NotaCre.nom_pc = param.nom_pc;
                    Info_NotaCre.IdUsuarioUltAnu = param.IdUsuario;
                    Info_NotaCre.Fecha_UltAnu = DateTime.Now;

                    if (Bus_notaCredDeb.AnularDB(Info_NotaCre, ref mensajeError))
                    {
                        ucGe_Menu.Enabled_bntAnular = false;
                        lblAnulado.Visible = true;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_Anulo_Correctamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGridContable();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                GetInfo();
                XFAC_Rpt010_rpt rptSoporte = new XFAC_Rpt010_rpt(param.IdUsuario);
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Info_NotaCre.IdTipoDoc);
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }

                XFAC_Rpt010_Bus busRpt = new XFAC_Rpt010_Bus();
                List<XFAC_Rpt010_Info> lstRpt = new List<XFAC_Rpt010_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_Impresion_NC_ND(param.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                rptSoporte.lstRpt = lstRpt;

                rptSoporte.CreateDocument();
                rptSoporte.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabarDatos())
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                grabarDatos();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }
        #endregion

        #region "Grabar Datos"
        Boolean grabarDatos()
        {
            try
            {
                Boolean bolResult = true;
                bolResult = Validar();
                if (bolResult)
                {
                    GetInfo();
                    GetInfoDocRelacionados();
                    

                    switch (_Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            bolResult = Guardar();
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            bolResult = Actualizar();
                            break;
                        default:
                            break;
                    }    
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region " Cargar Combos"
        public void cargarProductos()
        {
            try
            {

                listProducto = BusProducto.Get_list_Producto_modulo_x_Ventas(param.IdEmpresa, Convert.ToInt32(ucSucursalBode.get_IdSucursal()), Convert.ToInt32(ucSucursalBode.get_IdBodega()));
                cmbProducto_grid.DataSource = listProducto;
                cmbProducto_grid.DisplayMember = "pr_descripcion";
                cmbProducto_grid.ValueMember = "IdProducto";

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void cargarCombos()
        {
            try
            {
                ListTipoNota = BusTipoNota.Get_List_TipoNota(param.IdEmpresa, "C");
                cmbCredito.Properties.DataSource = ListTipoNota;

                Lista_centro_costo = bus_centro_costo.Get_list_Centro_Costo(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto.DataSource = Lista_centro_costo;
                cmbCentroCosto.DisplayMember = "Centro_costo";
                cmbCentroCosto.ValueMember = "IdCentroCosto";

                List<caj_Caja_Info> cajas = new List<caj_Caja_Info>();
                cajas = caja_B.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                this.cmbCaja.Properties.DataSource = cajas;
                this.cmbCaja.EditValue = 1;

                gridControlDocRelacionados.DataSource = BList_Documentos_relacionados;
                

                lst_Grupo_punto_cargo = bus_Grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa,ref MensajeError);
                cmb_Grupo.DataSource = lst_Grupo_punto_cargo;

                lst_Punto_cargo = bus_Punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_Punto_cargo.DataSource = lst_Punto_cargo;

                
                List_Imp_Iva = BusImpuesto.Get_List_impuesto_para_Ventas("IVA");
                cmbImpuestoIva.DataSource = List_Imp_Iva;

                ucAca_Estudiante.CargarListEstudiante();

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void CargarGridContable()
        {
            try
            {
                //info_CreDeb_cbtecble = Bus_notaCreDeb_x_ct_cbtecble.Get_Info_fa_notaCreDeb_x_ct_cbtecble(Info_NotaCre.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                //info_cbtecble_Reverso = Bus_cbtecble_Reversado.Get_Info_cbtecble_Reversado(info_CreDeb_cbtecble.ct_IdEmpresa, info_CreDeb_cbtecble.ct_IdTipoCbte, info_CreDeb_cbtecble.ct_IdCbteCble);
                //UC_DiarioNotaCreDeb.setInfo(info_CreDeb_cbtecble.ct_IdEmpresa, info_CreDeb_cbtecble.ct_IdTipoCbte, info_CreDeb_cbtecble.ct_IdCbteCble);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region "GET"
        public void GetInfo()
        {

            try
            {
                talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();
                Info_NotaCre.IdEmpresa = param.IdEmpresa;
                Info_NotaCre.IdNota = Convert.ToDecimal((txtNumNot.Text == "") ? "0" : txtNumNot.Text);
                Info_NotaCre.CodNota = txtCodigoNot.Text;
                Info_NotaCre.IdSucursal = Convert.ToInt32(ucSucursalBode.cmb_sucursal.EditValue);
                Info_NotaCre.IdBodega = Convert.ToInt32(ucSucursalBode.cmb_bodega.EditValue);
                Info_NotaCre.no_fecha = Convert.ToDateTime(dateFecha.Value.ToShortDateString());
                Info_NotaCre.no_fecha_venc = Convert.ToDateTime(dateFechaVencimiento.Value.ToShortDateString());
                Info_NotaCre.IdCliente = Convert.ToDecimal((ctrl_Cliente.cmb_cliente.EditValue == "<") ? 0 : ctrl_Cliente.cmb_cliente.EditValue);
                Info_NotaCre.IdVendedor = Convert.ToInt32((cmb_vendedor.cmb_vendedor.EditValue == null) ? 0 : cmb_vendedor.cmb_vendedor.EditValue);
                Info_NotaCre.IdCtaCble_TipoNota = cmbCtaCble_TipoNota.get_CuentaInfo().IdCtaCble;
                Info_NotaCre.IdTipoNota = Convert.ToInt32(cmbCredito.EditValue);
                Info_NotaCre.sc_observacion = txtObservacion.Text;
                Info_NotaCre.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                Info_NotaCre.Estado = chkActivo.Checked == true ? "A" : "I";
                Info_NotaCre.CodDocumentoTipo = "NTCR";
                Info_NotaCre.CreDeb = "C";                   
                Info_NotaCre.IdTipoDoc = "NTCR";
               
                if (rdbAutSri.Checked)
                {
                    talonarioInfo = ctrl_NumDoc.Get_Info_Talonario();
                    Info_NotaCre.Serie1 = talonarioInfo.Establecimiento;
                    Info_NotaCre.Serie2 = talonarioInfo.PuntoEmision;
                    Info_NotaCre.NumAutorizacion = null;
                    Info_NotaCre.NumNota_Impresa = talonarioInfo.NumDocumento;
                    Info_NotaCre.NaturalezaNota = "SRI";
                    

                }
                else
                {
                    if (rdbUsoInterno.Checked)
                    {
                        Info_NotaCre.Serie1 = null;
                        Info_NotaCre.Serie2 = null;
                        Info_NotaCre.NumAutorizacion = null;
                        Info_NotaCre.NumNota_Impresa = null;                        
                        Info_NotaCre.NaturalezaNota = "INT";
                    }
                }            
                
                Info_NotaCre.nom_pc = param.nom_pc;
                Info_NotaCre.ip = param.ip;
                Info_NotaCre.sc_usuario = param.IdUsuario;
                Info_NotaCre.flete = 0;
                Info_NotaCre.interes = 0;
                Info_NotaCre.valor1 = 0;
                Info_NotaCre.valor2 = 0;
                Info_NotaCre.seguro = 0;

                foreach (var item in BindiList_det_NC)
                {
                    item.vt_por_iva = param.iva.porcentaje;
                }

                Info_NotaCre.ListaDetalles = new List<fa_notaCreDeb_det_Info>(BindiList_det_NC);
                Info_NotaCre.Info_notaCredDeb_aca = Get_Info_notaCredDeb_aca();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private fa_notaCredDeb_aca_Info Get_Info_notaCredDeb_aca()
        {
            try
            {
                InfoNotaCredDeb_aca = new fa_notaCredDeb_aca_Info();
                InfoNotaCredDeb_aca.IdBodega = Info_NotaCre.IdBodega;
                InfoNotaCredDeb_aca.IdEmpresa = Info_NotaCre.IdEmpresa;
                InfoNotaCredDeb_aca.IdSucursal = Info_NotaCre.IdSucursal;
                InfoNotaCredDeb_aca.IdInstitucion = param.IdInstitucion;
                InfoNotaCredDeb_aca.IdEstudiante = ucAca_Estudiante.Get_Estudiante().IdEstudiante;
                InfoNotaCredDeb_aca.Observaciones = txtObservacion.Text;
                InfoNotaCredDeb_aca.IdNotaCredDeb = Info_NotaCre.IdNota;
                return InfoNotaCredDeb_aca;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_notaCredDeb_aca_Info();
            }

        }

        private void GetInfoDocRelacionados()
        {
            try
            {
                Info_NotaCre.lst_docs_relacionados = new List<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>(BList_Documentos_relacionados);
                foreach (var item in Info_NotaCre.lst_docs_relacionados)
                {
                    item.IdEmpresa_nt = Info_NotaCre.IdEmpresa;
                    item.IdSucursal_nt = Info_NotaCre.IdSucursal;
                    item.IdBodega_nt = Info_NotaCre.IdBodega;
                    item.IdNota_nt = Info_NotaCre.IdNota;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public cxc_cobro_Info get_Cobro()
        {
            try
            {
                cxc_cobro_Info info = new cxc_cobro_Info();
                info.IdEmpresa = param.IdEmpresa;
                info.IdSucursal = Info_NotaCre.IdSucursal;
                info.IdCliente = Info_NotaCre.IdCliente;

                info.cr_fecha = Info_NotaCre.dv_fecha;
                info.cr_fechaDocu = Info_NotaCre.dv_fecha;
                info.cr_fechaCobro = Info_NotaCre.dv_fecha;

                info.IdCobro_a_aplicar = null;
                info.cr_Banco = null;
                info.cr_cuenta = null;
                info.cr_NumDocumento = null;
                info.cr_Tarjeta = null;
                info.cr_propietarioCta = null;
                info.cr_estado = "A";
                info.cr_recibo = 0;
                info.IdBanco = null;
                info.MotiAnula = null;
                info.cr_Codigo = "";

                info.nom_pc = param.nom_pc;
                info.ip = param.ip;
                info.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                info.IdUsuario = param.IdUsuario;

                // campos vista
                info.IdCobro_tipo = Info_NotaCre.IdTipoDoc;
                info.IdTipoNotaCredito = Info_NotaCre.IdTipoNota;
                info.IdCaja = Info_NotaCre.IdCaja;
                info.cr_TotalCobro = Convert.ToDouble(Info_NotaCre.ListaDetalles.Sum(q => q.sc_total));
                // campos vista      
                info.cr_observacion = "Cobro por " + Info_NotaCre.IdTipoDoc + " del cliente id# " + Info_NotaCre.IdCliente + Info_NotaCre.sc_observacion;

                //Detalle conciliacion
                info.ListaCobro = new List<cxc_cobro_Det_Info>();
                info.ListaCobro = getDetalleCobro();

                return info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new cxc_cobro_Info();
            }
        }

        public List<cxc_cobro_Det_Info> getDetalleCobro()
        {
            try
            {
                List<cxc_cobro_Det_Info> lstCobroDet = new List<cxc_cobro_Det_Info>();
                //foreach (var item in DataFact_Apli)
                //{

                //    cxc_cobro_Det_Info info_det = new cxc_cobro_Det_Info();

                //    info_det.IdEmpresa = item.IdEmpresa;
                //    info_det.IdSucursal = item.IdSucursal;
                //    info_det.IdCobro = 0;
                //    info_det.secuencial = 0;
                //    info_det.dc_TipoDocumento = item.vt_tipoDoc;
                //    info_det.IdBodega_Cbte = Info_NotaCre.IdBodega;
                //    info_det.IdCbte_vta_nota = Convert.ToDecimal(item.IdComprobante);
                //    info_det.dc_ValorPago = item.valor_aplicar;
                //    info_det.IdUsuario = param.IdUsuario;

                //    info_det.Fecha_Transac = Convert.ToDateTime(DateTime.Now);
                //    info_det.nom_pc = param.nom_pc;
                //    info_det.ip = param.ip;

                //    lstCobroDet.Add(info_det);
                //}
                return lstCobroDet;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<cxc_cobro_Det_Info>();
            }
        }
        #endregion

        #region "SET"
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                _Accion = iAccion;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void SetInfo(fa_notaCreDeb_Info _Info)
        {
            try
            {
                Info_NotaCre = _Info;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set_Accion_in_Controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Enabled_btn_Generar_XML = false;
                        ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
                        txtCodigoNot.Properties.ReadOnly = true;
                        txtNumNot.Properties.ReadOnly = true;
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ctrl_NumDoc.Visible = false;
                        Set();
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Enabled_btn_Generar_XML = true;

                        cmbCaja.Properties.ReadOnly = true;
                        txtCodigoNot.Properties.ReadOnly = true;
                        txtNumNot.Properties.ReadOnly = true;                        
                        ucAca_Estudiante.cmbEstudiante.Properties.ReadOnly = true;
                        ctrl_Cliente.cmb_cliente.Properties.ReadOnly = true;
                        cmbCtaCble_TipoNota.Enabled = false;
                        cmbCredito.Properties.ReadOnly = true;
                        gridViewNotaCreDeb.OptionsBehavior.Editable = false;
                        ctrl_NumDoc.Enabled = false;
                        rdbAutSri.Enabled = false;
                        rdbUsoInterno.Enabled = false;                        
                        chkActivo.Properties.ReadOnly = true;
                        btn_Buscar_doc.Enabled = false;
                       
                        if (Info_NotaCre.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }

                        ucSucursalBode.Bloquerar_Combos();

                        if (Info_NotaCre.NaturalezaNota == "SRI")
                        {
                            cmbCaja.Properties.ReadOnly = true;
                            cmbCredito.Enabled = false;
                         
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ctrl_NumDoc.Visible = false;
                        Set();
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Enabled_btn_Generar_XML = false;

                        cmbCaja.Properties.ReadOnly = true;
                        txtCodigoNot.Properties.ReadOnly = true;
                        txtNumNot.Properties.ReadOnly = true;                        
                        ucAca_Estudiante.cmbEstudiante.Properties.ReadOnly = true;
                        ctrl_Cliente.cmb_cliente.Properties.ReadOnly = true;
                        cmbCtaCble_TipoNota.Enabled = false;
                        cmbCredito.Properties.ReadOnly = true;
                        gridViewNotaCreDeb.OptionsBehavior.Editable = false;
                        ctrl_NumDoc.Enabled = false;
                        rdbAutSri.Enabled = false;
                        rdbUsoInterno.Enabled = false;                        
                        chkActivo.Properties.ReadOnly = true;
                        btn_Buscar_doc.Enabled = false;
                        ucSucursalBode.Bloquerar_Combos();
                        if (Info_NotaCre.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            ucGe_Menu.Visible_bntAnular = false;
                        }
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ctrl_NumDoc.Visible = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Enabled_btn_Generar_XML = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntAnular = false;
                        cmbCaja.Properties.ReadOnly = true;
                        txtCodigoNot.Properties.ReadOnly = true;
                        txtNumNot.Properties.ReadOnly = true;                        
                        ucAca_Estudiante.cmbEstudiante.Properties.ReadOnly = true;
                        ctrl_Cliente.cmb_cliente.Properties.ReadOnly = true;
                        cmbCtaCble_TipoNota.Enabled = false;
                        cmbCredito.Properties.ReadOnly = true;                        
                        ctrl_NumDoc.Enabled = false;
                        rdbAutSri.Enabled = false;
                        rdbUsoInterno.Enabled = false;                        
                        chkActivo.Properties.ReadOnly = true;
                        btn_Buscar_doc.Enabled = false;
                        ucSucursalBode.Bloquerar_Combos();
                        if (Info_NotaCre.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        Set();
                        gridViewNotaCreDeb.OptionsBehavior.Editable = false;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Set()
        {
            try
            {
                txtNumNot.Text = Info_NotaCre.IdNota.ToString();
                txtCodigoNot.Text = Info_NotaCre.CodNota;
                ucSucursalBode.cmb_sucursal.EditValue = Info_NotaCre.IdSucursal;
                ucSucursalBode.cmb_bodega.EditValue = Info_NotaCre.IdBodega;
                dateFecha.Value = (DateTime)Info_NotaCre.no_fecha;
                dateFechaVencimiento.Value = (DateTime)Info_NotaCre.no_fecha_venc;
                ctrl_Cliente.cmb_cliente.EditValue = Info_NotaCre.IdCliente;
                txtObservacion.Text = Info_NotaCre.sc_observacion;
                cmbCredito.EditValue = Info_NotaCre.IdTipoNota;
                cmb_vendedor.set_VendedorInfo(Info_NotaCre.IdVendedor);

                cmbCtaCble_TipoNota.set_IdCtaCble(Info_NotaCre.IdCtaCble_TipoNota);
                
                cmbCaja.EditValue = Info_NotaCre.IdCaja;
                if (Info_NotaCre.Estado == "A")
                    chkActivo.Checked = true;
                else
                    chkActivo.Checked = false;

                if (Info_NotaCre.NaturalezaNota == "SRI")
                {
                    rdbAutSri.Checked = true;
                    ctrl_NumDoc.Visible = true;
                    tb_sis_Documento_Tipo_Talonario_Bus BusTalonario = new tb_sis_Documento_Tipo_Talonario_Bus();
                    tb_sis_Documento_Tipo_Talonario_Info InfoTalonario_Grabado = new tb_sis_Documento_Tipo_Talonario_Info();
                    if (Info_NotaCre.CodDocumentoTipo == null)
                    {
                        Info_NotaCre.CodDocumentoTipo = Info_NotaCre.CodNota.Substring(0, 4);
                        
                    }
                    InfoTalonario_Grabado = BusTalonario.Get_Info_Documento_Tipo_Talonario(Info_NotaCre.IdEmpresa, Info_NotaCre.CodDocumentoTipo, Info_NotaCre.Serie1, Info_NotaCre.Serie2, Info_NotaCre.NumNota_Impresa);

                    if (Convert.ToBoolean(InfoTalonario_Grabado.es_Documento_electronico) == true)
                    {
                        ctrl_NumDoc.rbt_doc_Electronico.Checked = true;
                    }
                    else
                    { ctrl_NumDoc.rbt_pre_impresa.Checked = true; }

                    ctrl_NumDoc.txe_Serie.EditValue = Info_NotaCre.Serie1 + "-" + Info_NotaCre.Serie2;
                    ctrl_NumDoc.txtNumDoc.EditValue = Info_NotaCre.NumNota_Impresa;
                    ctrl_NumDoc.btnBuscar.Enabled = false;
                    rdbUsoInterno.Checked = false;

                    ucGe_Menu.Enabled_btn_Generar_XML = true;
                }
                else
                {
                    rdbAutSri.Checked = false;
                    rdbUsoInterno.Checked = true;
                    ucGe_Menu.Enabled_btn_Generar_XML = false;
                }                
                
                SetDetalle();
                
                SetInfoDocsRelacionados();
                SetInfo_fa_notaCredDeb_aca();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        private void SetDetalle()
        {
            try
            {

                Info_NotaCre.ListaDetalles = Bus_notaCredDeb_det.Get_List_notaCreDeb_det(Info_NotaCre);
                Info_NotaCre.ListaDetalles.ForEach(var => var.pr_descripcion = BusProducto.Get_Descripcion_Producto(param.IdEmpresa, var.IdProducto));
                BindiList_det_NC = new BindingList<fa_notaCreDeb_det_Info>(Info_NotaCre.ListaDetalles);
                foreach (var item in BindiList_det_NC)
                {
                    item.sc_descTotal = item.sc_descUni * item.sc_cantidad;
                }
                gridControlNotaCreDeb.DataSource = BindiList_det_NC;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void SetInfoDocsRelacionados()
        {
            try
            {
                Info_NotaCre.lst_docs_relacionados = BusDocumentos_relacionados.Get_list_docs_x_NC(Info_NotaCre.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                BList_Documentos_relacionados = new BindingList<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>(Info_NotaCre.lst_docs_relacionados);
                gridControlDocRelacionados.DataSource = BList_Documentos_relacionados;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void SetInfo_fa_notaCredDeb_aca()
        {
            try
            {
               InfoNotaCredDeb_aca = BusNotaCredDeb_aca.Get_Info(Info_NotaCre.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                if(InfoNotaCredDeb_aca != null)
               ucAca_Estudiante.set_Estudiante(InfoNotaCredDeb_aca.IdEstudiante);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        #endregion

        #region " Guardar, Actualizar"
        Boolean Guardar()
        {
            try
            {
                Boolean bolResult = false;
                string codigo = "";
                decimal Idnota = 0;
                decimal IdNotaDebCred_aca = 0;
                string mensajeDocumentoDupli = "";
                string mensajeError = "";
                string numDocumento = "";
                //if (Validar())
                {
                    if (MessageBox.Show("La " + ctrl_NumDoc.IdTipoDocumento + " # " + talonarioInfo.Establecimiento + "-" + talonarioInfo.PuntoEmision + "-" + talonarioInfo.NumDocumento + " se procedera a Guardar." + "\n" + "¿Desea Continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Bus_notaCredDeb.VerificarCodigo(txtCodigoNot.Text) == false)
                        {

                            Info_NotaCre.Info_sisDocTipoTalo = talonarioInfo;

                            if (Bus_notaCredDeb.GuardarDB(Info_NotaCre, ref Idnota,  ref mensajeDocumentoDupli, ref mensajeError,true))
                            {
                                txtCodigoNot.Text = codigo;
                                txtNumNot.Text = Convert.ToString(Idnota);
                                Info_NotaCre.IdNota = Idnota;
                                ucGe_Menu.Enabled_btn_Generar_XML = true;
                                Info_NotaCre.Info_notaCredDeb_aca.IdNotaCredDeb = Info_NotaCre.IdNota;
                                if (BusNotaCredDeb_aca.GrabarDB(Info_NotaCre.Info_notaCredDeb_aca, ref mensajeError))
                                {
                                    bolResult = true;
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la nota cred " + Idnota, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                              
                                CargarGridContable();



                                if (MessageBox.Show("¿Desea Imprimir la " + ctrl_NumDoc.IdTipoDocumento + " # " + numDocumento + "/" + codigo + " ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_event_btnImprimir_Click(null, null);
                                }

                                if (MessageBox.Show("¿Desea Imprimir el Soporte de la " + ctrl_NumDoc.IdTipoDocumento + " # " + numDocumento + "/" + codigo + " ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                                }

                                if (MessageBox.Show("¿Desea generar el XML de la " + ctrl_NumDoc.IdTipoDocumento + " # " + numDocumento + "/" + codigo + " ?" + "\n" + "Generar XML", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_event_btn_Generar_XML_Click(null, null);
                                }

                               
                                ////


                                ucGe_Menu.Visible_btnImprimirSoporte = true;
                                ucGe_Menu.Visible_bntImprimir = true;                                
                                LimpiarDatos();
                                
                            }
                            else {
                                if (mensajeDocumentoDupli == "")
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else {
                                    MessageBox.Show(mensajeDocumentoDupli, param.Nombre_sistema);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código ingresado ya existe por favor ingrese uno diferente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                return bolResult;

            }

            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        Boolean Actualizar()
        {
            try
            {
                Boolean bolResult = false;
                string mensajeError = "";
                string mensajeDocumentoDupli = "";
                string tipo;
               
                //if (Validar())
                {
                    
                    if (Bus_notaCredDeb.ActualizarDB(Info_NotaCre, ref mensajeError, ref mensajeDocumentoDupli))
                    {
                        if (BusNotaCredDeb_aca.ActualizarDB(InfoNotaCredDeb_aca, ref mensajeError))
                        {
                        bolResult = true;
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }                     
                       

                        CargarGridContable();
                        
                        CargarGridContable();
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + mensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return bolResult;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }
        #endregion

        #region "Limpiar"
        void LimpiarDatos()
        {
            try
            {
                Info_NotaCre = new fa_notaCreDeb_Info();
                Info_NotaCre = new fa_notaCreDeb_Info();
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Info_NotaCre.ListaDetalles = new List<fa_notaCreDeb_det_Info>();
                BindiList_det_NC = new BindingList<fa_notaCreDeb_det_Info>();
                ucSucursalBode.InicializarBodega();
                gridControlNotaCreDeb.DataSource = BindiList_det_NC;
                rdbAutSri.Checked = false;
                ctrl_NumDoc.Visible = false;
                txtNumNot.Text = "";           
                txtCodigoNot.Text = "";
                dateFecha.Value = DateTime.Now;
                dateFechaVencimiento.Value = DateTime.Now;
                txtObservacion.Text = "";
                
                cmb_vendedor.Inicializar_cmbVendedor();
                cmbCtaCble_TipoNota.Inicializar_cmb_cuentas();
                ctrl_Cliente.cmb_cliente.EditValue = null;
                cmbCredito.EditValue = null;
               
                
                ctrl_NumDoc.txe_Serie.EditValue = "";
                ctrl_NumDoc.txtNumDoc.EditValue = "";
                ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                ucGe_Menu.Visible_btnGuardar = true;
                rdbUsoInterno.Checked = true;
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Validaciones "
        private Boolean Validar()
        {

            try
            {
                txtCodigoNot.Focus();
                if (ucAca_Estudiante.Get_Estudiante().IdEstudiante == 0 || ucAca_Estudiante.Get_Estudiante() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Estudiantes", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucAca_Estudiante.Focus();
                    return false;
                }
                if (ctrl_Cliente.get_ClienteInfo().IdCliente == 0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Cliente", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ctrl_Cliente.cmb_cliente.Focus();
                    return false;
                }

                if (cmbCaja.EditValue == "" || Convert.ToInt32(cmbCaja.EditValue) == 0 || cmbCaja.EditValue == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + " Seleccione la caja", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbCaja.Focus();
                    return false;
                }


                if (rdbAutSri.Checked)
                {
                    if (ctrl_NumDoc.txe_Serie.EditValue == "" || ctrl_NumDoc.txe_Serie.EditValue == null || ctrl_NumDoc.txtNumDoc.EditValue == "" || ctrl_NumDoc.txtNumDoc.EditValue == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " número de documento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ctrl_NumDoc.txe_Serie.Focus();
                        return false;
                    }

                }

                
                    if (cmbCredito.EditValue == "" || Convert.ToInt32(cmbCredito.EditValue) == 0 || cmbCredito.EditValue == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el)  + " Motivo de Crédito", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbCredito.Focus();
                        return false;
                    }


                    if (rdbAutSri.Checked)
                    {
                        if (BList_Documentos_relacionados.Count == 0)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " documento al cual se aplicará la nota de crédito.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }


                    foreach (var item in BList_Documentos_relacionados)
                    {
                        if (item.Valor_Aplicado == 0)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " valor a aplicar del documento." + item.num_doc, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (item.Valor_Aplicado > item.vt_total)
                        {
                            MessageBox.Show("El valor a aplicar es mayor al valor del documento " + item.num_doc + ", por favor ingrese un valor a aplicar apropiado.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        else
                            Total = (double)item.vt_total;

                        
                        
                    }
                    
                if(BindiList_det_NC.Count==0)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Producto y su detalle ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    gridViewNotaCreDeb.Focus();
                    return false;
                }
                else
                {
                    foreach (var item in BindiList_det_NC)
                    {
                        if (item.IdProducto == 0)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Producto ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (item.sc_cantidad == 0)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " cantidad del producto ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (item.sc_total != Total)
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + " verifique el Total del detalle de la nota de credito y del documento relacionado ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        
                    }
                }

                


                if (!Validar_CtasCbles_Factura())
                {
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }

        }

        Boolean Validar_CtasCbles_Factura()
        {
            try
            {
                if (infoCliente.IdCtaCble_cxc == null)
                {
                    if (MessageBox.Show("El Cliente no Tiene Cta Cble de Contado. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }


                if (Info_Param_fac.IdCtaCble_IVA == null)
                {
                    if (MessageBox.Show("No hay Parametrizado Cta Cble de IVA. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }

                if (cmbCtaCble_TipoNota.get_CuentaInfo().IdCtaCble == null)
                {
                    if (MessageBox.Show("No hay Cta Cble del Tipo de Nota. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
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
        #endregion

        #region "Calculos"

        public void Calculo_Saldo_Pendiente_ColumnasGrid()
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Calculo_Saldo_Pendiente()
        {
            try
            {
                double sum = 0;
                BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info> z = new BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info>();
                z = (BindingList<vwFa_Documentos_x_Relacionar_NC_ND_Info>)gridViewNotaCreDeb.DataSource;

                foreach (var item in z)
                {
                    item.valor_aplicar = (item.Saldo < item.valor_aplicar) ? 0 : item.valor_aplicar;                    
                }

                gridControlNotaCreDeb.DataSource = z;

                                 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        #region " Eventos Personalizados"
        private void rdbAutSri_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (rdbAutSri.Checked)
                {
                    ctrl_NumDoc.Visible = true;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void rdbUsoInt_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbUsoInterno.Checked)
                {
                    ctrl_NumDoc.limpiarControles();
                    ctrl_NumDoc.Visible = false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ctrl_Cliente_Event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                infoCliente = ctrl_Cliente.get_ClienteInfo();
                BList_Documentos_relacionados = new BindingList<fa_notaCreDeb_x_fa_factura_NotaDeb_Info>();
                gridControlDocRelacionados.DataSource = BList_Documentos_relacionados;
                BindiList_det_NC= new BindingList<fa_notaCreDeb_det_Info>();
                gridControlNotaCreDeb.DataSource = BindiList_det_NC;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSucursalBode_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucSucursalBode.get_bodega() != null)
                {
                    cargarProductos();
                    cargarNumDoc();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        void ucSucursalBode_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucSucursalBode.get_bodega() != null)
                {
                    cargarProductos();
                    cargarNumDoc();
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }


       
        #endregion
        
        #region " Evento FormClosing "
        private void frmAca_Nota_Cred_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Event_frmFA_NotaCreditoDebito_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
        #endregion

        void ImprimirDiario()
        {
            try
            {
                
                info_CreDeb_cbtecble = Bus_notaCreDeb_x_ct_cbtecble.Get_Info_fa_notaCreDeb_x_ct_cbtecble(Info_NotaCre.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                if (info_CreDeb_cbtecble != null)
                {
                    XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                    reporte.set_parametros(Info_NotaCre.IdEmpresa, info_CreDeb_cbtecble.ct_IdTipoCbte, info_CreDeb_cbtecble.ct_IdCbteCble);
                    reporte.RequestParameters = false;
                    reporte.ShowPreviewDialog();
                }
                else
                {
                    MessageBox.Show("No existe diario contable de esta transacción.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BuscarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                decimal IdCliente = ctrl_Cliente.get_ClienteInfo().IdCliente;
                if (IdCliente != 0)
                {
                    frmFa_factura_NotaDeb_a_cruzar frm = new frmFa_factura_NotaDeb_a_cruzar();
                    frm.Cargar_combos(IdCliente);
                    frm.ShowDialog();
                    Info_Doc_rel = frm.Get_Info();
                    if (Info_Doc_rel!=null)
                    {
                        Info_Doc_rel.Valor_Aplicado = Info_Doc_rel.vt_total==null ? 0 :(double)Info_Doc_rel.vt_total;
                        int cont = BList_Documentos_relacionados.Where(q => q.IdEmpresa_fac_nd_doc_mod == Info_Doc_rel.IdEmpresa_fac_nd_doc_mod && q.IdSucursal_fac_nd_doc_mod == Info_Doc_rel.IdSucursal_fac_nd_doc_mod && q.IdBodega_fac_nd_doc_mod == Info_Doc_rel.IdBodega_fac_nd_doc_mod
                            && q.IdCbteVta_fac_nd_doc_mod == Info_Doc_rel.IdCbteVta_fac_nd_doc_mod).Count();


                        if (cont == 0)
                        {
                            if (Info_Doc_rel != null && Info_Doc_rel.IdCbteVta_fac_nd_doc_mod != 0)
                            {
                                switch (Info_Doc_rel.vt_tipoDoc)
                                {
                                    case "FACT":
                                        info_fact = bus_fact.Get_Info_factura(Info_Doc_rel.IdEmpresa_fac_nd_doc_mod, Info_Doc_rel.IdSucursal_fac_nd_doc_mod, Info_Doc_rel.IdBodega_fac_nd_doc_mod, Info_Doc_rel.IdCbteVta_fac_nd_doc_mod);

                                        
                                        cmb_vendedor.set_VendedorInfo(info_fact.IdVendedor);

                                        
                                        if (info_fact != null)
                                        {                                            
                                            info_fact.DetFactura_List = bus_fact_det.Get_List_factura_det(info_fact.IdEmpresa, info_fact.IdSucursal, info_fact.IdBodega, info_fact.IdCbteVta, ref MensajeError);

                                            foreach (var item in info_fact.DetFactura_List)
                                            {
                                                fa_notaCreDeb_det_Info info = new fa_notaCreDeb_det_Info();
                                                info.IdEmpresa = item.IdEmpresa;
                                                info.IdSucursal = item.IdSucursal;
                                                info.IdBodega = item.IdBodega;
                                                info.IdProducto = item.IdProducto;
                                                info.sc_cantidad = item.vt_cantidad;
                                                info.sc_Precio = item.vt_Precio;
                                                info.sc_precioFinal = item.vt_PrecioFinal;
                                                info.sc_descUni = item.vt_DescUnitario;
                                                info.sc_PordescUni = item.vt_PorDescUnitario;
                                                info.sc_precioFinal = item.vt_PrecioFinal;
                                                info.sc_subtotal = item.vt_Subtotal;
                                                info.sc_iva = item.vt_iva;
                                                info.sc_total = item.vt_total;
                                                info.DetallexItems = item.vt_detallexItems;
                                                info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;
                                                info.vt_por_iva = (double)item.vt_por_iva;

                                                info.IdEmpresa_docRel = Info_Doc_rel.IdEmpresa_fac_nd_doc_mod;
                                                info.IdSucursal_docRel = Info_Doc_rel.IdSucursal_fac_nd_doc_mod;
                                                info.IdBodega_docRel = Info_Doc_rel.IdBodega_fac_nd_doc_mod;
                                                info.IdCbte_docRel = Info_Doc_rel.IdCbteVta_fac_nd_doc_mod;
                                                info.IdCentroCosto = item.IdCentroCosto;

                                                BindiList_det_NC.Add(info);
                                            }
                                        }
                                        break;
                                    case "NTDB":
                                        info_notaDeb = bus_notaDeb.Get_Info_notaCreDeb_x_ND(Info_Doc_rel.IdEmpresa_fac_nd_doc_mod, Info_Doc_rel.IdSucursal_fac_nd_doc_mod, Info_Doc_rel.IdBodega_fac_nd_doc_mod, Info_Doc_rel.IdCbteVta_fac_nd_doc_mod);
                                        if (info_notaDeb != null)
                                        {
                                            info_notaDeb.ListaDetalles = bus_notaDeb_det.Get_List_notaCreDeb_det(info_notaDeb);

                                            foreach (var item in info_notaDeb.ListaDetalles)
                                            {
                                                fa_notaCreDeb_det_Info info = new fa_notaCreDeb_det_Info();
                                                info.IdEmpresa = item.IdEmpresa;
                                                info.IdSucursal = item.IdSucursal;
                                                info.IdBodega = item.IdBodega;
                                                info.IdProducto = item.IdProducto;
                                                info.sc_cantidad = item.sc_cantidad;
                                                info.sc_Precio = item.sc_Precio;
                                                info.sc_precioFinal = item.sc_precioFinal;
                                                info.sc_descUni = item.sc_descUni;
                                                info.sc_PordescUni = item.sc_PordescUni;
                                                info.sc_precioFinal = item.sc_precioFinal;
                                                info.sc_subtotal = item.sc_subtotal;
                                                info.sc_iva = item.sc_iva;
                                                info.sc_total = item.sc_total;
                                                info.DetallexItems = item.sc_observacion;
                                                info.vt_por_iva = (double)item.vt_por_iva;
                                                info.IdCod_Impuesto_Iva = item.IdCod_Impuesto_Iva;

                                                info.IdEmpresa_docRel = Info_Doc_rel.IdEmpresa_fac_nd_doc_mod;
                                                info.IdSucursal_docRel = Info_Doc_rel.IdSucursal_fac_nd_doc_mod;
                                                info.IdBodega_docRel = Info_Doc_rel.IdBodega_fac_nd_doc_mod;
                                                info.IdCbte_docRel = Info_Doc_rel.IdCbteVta_fac_nd_doc_mod;
                                                info.IdCentroCosto = item.IdCentroCosto;

                                                BindiList_det_NC.Add(info);
                                            }
                                        }
                                        break;
                                }
                                BList_Documentos_relacionados.Add(Info_Doc_rel);
                                gridControlDocRelacionados.DataSource = BList_Documentos_relacionados;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El documento seleccionado ya se encuentra en esta nota crédito.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }    
                    }
                    
                    
                    gridControlNotaCreDeb.DataSource = BindiList_det_NC;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarNumDoc()
        {
            try
            {
                if (Convert.ToString(_Accion) == "grabar")
                {
                    ctrl_NumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.NTCR;
                    if (ucSucursalBode.get_sucursal() != null && ucSucursalBode.get_bodega() != null)
                    {
                        ctrl_NumDoc.IdEstablecimiento = ucSucursalBode.get_sucursal().Su_CodigoEstablecimiento;
                        ctrl_NumDoc.IdPuntoEmision = ucSucursalBode.get_bodega().cod_punto_emision;
                        ctrl_NumDoc.Get_Primer_Documento_no_usado();
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbCredito_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (cmbCredito.EditValue != null)
                {

                    fa_TipoNota_Info InfoTipoNota = new fa_TipoNota_Info();
                    InfoTipoNota = ListTipoNota.FirstOrDefault(v => v.IdTipoNota == Convert.ToInt32(cmbCredito.EditValue));
                    string IdCtaCble = "";


                    if (InfoTipoNota.IdCtaCble == null)
                    {
                        fa_TipoNota_x_Empresa_x_Sucursal_Bus BusTipoNT = new Business.Facturacion.fa_TipoNota_x_Empresa_x_Sucursal_Bus();
                        fa_TipoNota_x_Empresa_x_Sucursal_Info InfoTipo_NT_x_Sucu = new fa_TipoNota_x_Empresa_x_Sucursal_Info();
                        InfoTipo_NT_x_Sucu = BusTipoNT.Get_Info_TipoNota_x_Empresa_x_Sucursal_x_TipoNota(param.IdEmpresa, ucSucursalBode.get_IdSucursal(), InfoTipoNota.IdTipoNota);
                        IdCtaCble = InfoTipo_NT_x_Sucu.IdCtaCble;

                    }
                    else
                    { IdCtaCble = InfoTipoNota.IdCtaCble; }


                    cmbCtaCble_TipoNota.set_IdCtaCble(IdCtaCble);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void gridViewDocRelacionados_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info_Doc_rel = (fa_notaCreDeb_x_fa_factura_NotaDeb_Info)gridViewDocRelacionados.GetRow(e.FocusedRowHandle);
                if (Info_Doc_rel!=null)
                {
                    if (Info_Doc_rel.esta_en_base)
                    {
                        col_valor_aplicado.OptionsColumn.AllowEdit = false;
                    }else
                        col_valor_aplicado.OptionsColumn.AllowEdit = true;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void gridViewDocRelacionados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void gridViewDocRelacionados_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!Info_Doc_rel.esta_en_base)
                {
                    if (e.KeyCode == Keys.Delete)
                    {
                        if (MessageBox.Show("¿Desea eliminar la fila seleccionada?", param.Nombre_sistema, MessageBoxButtons.YesNo) !=
                          DialogResult.Yes)
                            return;

                        List < fa_notaCreDeb_det_Info > List = new List<fa_notaCreDeb_det_Info>(BindiList_det_NC);
                        foreach (var item in List)
                        {
                            if (item.IdEmpresa_docRel == Info_Doc_rel.IdEmpresa_fac_nd_doc_mod && Info_Doc_rel.IdSucursal_fac_nd_doc_mod == item.IdSucursal_docRel
                                && Info_Doc_rel.IdBodega_fac_nd_doc_mod == item.IdBodega_docRel && item.IdCbte_docRel == Info_Doc_rel.IdCbteVta_fac_nd_doc_mod)
                                BindiList_det_NC.Remove(item);                               
                        }
                        gridViewDocRelacionados.DeleteRow(gridViewDocRelacionados.FocusedRowHandle);
                        gridControlNotaCreDeb.RefreshDataSource();

                        gridControlDocRelacionados.DataSource = null;
                        gridControlDocRelacionados.DataSource = BList_Documentos_relacionados;
                    }    
                }
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private void cmb_Punto_cargo_Click(object sender, EventArgs e)
        {
            try
            {
                fa_notaCreDeb_det_Info row = (fa_notaCreDeb_det_Info)gridViewNotaCreDeb.GetFocusedRow();
                if (row != null)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridViewNotaCreDeb.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(rowHandle, ColIdPunto_Cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        

                        frm_cons.ShowDialog();
                        info_Punto_cargo = frm_cons.Get_Info();
                        if (info_Punto_cargo != null)
                        {
                            gridViewNotaCreDeb.SetFocusedRowCellValue(ColIdPunto_Cargo, info_Punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridViewNotaCreDeb.SetFocusedRowCellValue(ColIdPunto_Cargo, null);
                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewNotaCreDeb_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewNotaCreDeb_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                double precio = 0;
                double cantidad = 0;
                double descuento_total = 0;
                double Porc_Descuento = 0;
                double Descuento_unitario = 0;
                double subtotal = 0;
                double SubtotalFinal = 0;
                double Iva = 0;
                double Porc_Iva = 0;
                double Total_Vta = 0;



                Info_det = new fa_notaCreDeb_det_Info();
                Info_det = (fa_notaCreDeb_det_Info)this.gridViewNotaCreDeb.GetFocusedRow();
                precio = Info_det.sc_Precio;
                cantidad = Info_det.sc_cantidad;
                descuento_total = Info_det.sc_descTotal;
                Porc_Descuento = Info_det.sc_PordescUni;
                Descuento_unitario = Info_det.sc_descUni;

                precio = Convert.ToDouble(gridViewNotaCreDeb.GetFocusedRowCellValue(colPrecio));
                cantidad = Convert.ToInt32(gridViewNotaCreDeb.GetFocusedRowCellValue(colCantidad));
                Porc_Descuento = Convert.ToDouble(gridViewNotaCreDeb.GetFocusedRowCellValue(colPorDesc));
                descuento_total = ((cantidad * precio) * Porc_Descuento) / 100;
                Descuento_unitario = (Porc_Descuento * precio) / 100;
                subtotal = (precio * cantidad) - descuento_total;
                Info_det.sc_descUni = Descuento_unitario;
                Info_det.sc_PordescUni = Porc_Descuento;


                subtotal = (precio * cantidad);
                SubtotalFinal = (subtotal - descuento_total);
                Iva = 0;
                Porc_Iva = 0;
                Total_Vta = 0;



                if (e.Column == colCantidad || e.Column == colPrecio)
                {
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colsc_precioFinal, (precio - Descuento_unitario));
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colDescuento, descuento_total);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colIva, 0);

                    string IdCodImpuesto = gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva) == null ? "" : gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva).ToString();
                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = List_Imp_Iva.FirstOrDefault(v => v.IdCod_Impuesto == IdCodImpuesto);

                    if (InfoTipoImpuesto != null)
                    {
                        Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    Total_Vta = subtotal + Iva;


                    gridViewNotaCreDeb.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colIva, Iva);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colTotal, Total_Vta);




                }

                if (e.Column == colIdCod_Impuesto_Iva)
                {
                    string IdCodImpuesto = gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva) == null ? "" : gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva).ToString();
                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = List_Imp_Iva.FirstOrDefault(v => v.IdCod_Impuesto == IdCodImpuesto);
                    Iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }
                    Total_Vta = subtotal + Iva;
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colIva, Iva);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    Total_Vta = subtotal + Iva;
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colTotal, Total_Vta);


                }


                if (e.Column == colPorDesc)
                {

                    gridViewNotaCreDeb.SetFocusedRowCellValue(colsc_precioFinal, (precio - Descuento_unitario));
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colDescuento, descuento_total);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colSubtotal, subtotal - descuento_total);

                    string IdCodImpuesto = gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva) == null ? "" : gridViewNotaCreDeb.GetRowCellValue(e.RowHandle, colIdCod_Impuesto_Iva).ToString();
                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = List_Imp_Iva.FirstOrDefault(v => v.IdCod_Impuesto == IdCodImpuesto);
                    Iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    gridViewNotaCreDeb.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colIva, Iva);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colTotal, (subtotal + Iva - descuento_total));
                }

                if (e.Column.Name == colCodigo_Producto.Name)
                {
                    info_producto = listProducto.First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    //gridViewNotaCreDeb.SetFocusedRowCellValue(colCodigo_Producto, info_producto.IdProducto);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colCantidad, 0);
                    gridViewNotaCreDeb.SetFocusedRowCellValue(colPrecio, info_producto.pr_precio_publico);


                    tb_sis_impuesto_Info Info_Imp_Iva = new tb_sis_impuesto_Info();
                    Info_Imp_Iva = List_Imp_Iva.FirstOrDefault(v => v.IdCod_Impuesto == info_producto.IdCod_Impuesto_Iva);

                    if (Info_Imp_Iva != null)
                    {
                        gridViewNotaCreDeb.SetFocusedRowCellValue(colIdCod_Impuesto_Iva, Info_Imp_Iva.IdCod_Impuesto);
                    }

                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void btn_cargar_diario_Click(object sender, EventArgs e)
        {
            try
            {
                fa_notaCreDeb_x_ct_cbtecble_Bus BusCbteCble = new Business.Facturacion.fa_notaCreDeb_x_ct_cbtecble_Bus();
                fa_notaCreDeb_x_ct_cbtecble_Info InfoNota_x_cbte = new fa_notaCreDeb_x_ct_cbtecble_Info();

                if (_Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    InfoNota_x_cbte = BusCbteCble.Get_Info_fa_notaCreDeb_x_ct_cbtecble(Info_NotaCre.IdEmpresa, Info_NotaCre.IdSucursal, Info_NotaCre.IdBodega, Info_NotaCre.IdNota);
                    ucCon_GridDiario.setInfo(InfoNota_x_cbte.no_IdEmpresa, InfoNota_x_cbte.ct_IdTipoCbte, InfoNota_x_cbte.ct_IdCbteCble);
                }
                


            }
            catch (Exception ex)
            {

            }
        }

        private void gridControlNotaCreDeb_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewNotaCreDeb.DeleteSelectedRows();

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

        private void ucAca_Estudiante_event_UCAca_Estudiante_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucAca_Estudiante.cmbEstudiante.EditValue != null && ucAca_Estudiante.cmbEstudiante.EditValue != "[Vacio]")
                {
                    List<fa_Cliente_Info> Lista_Cliente = new List<fa_Cliente_Info>();
                    infoCliente = new fa_Cliente_Info();
                    Lista_familiar_x_estudiante_rep_eco = new List<vwAca_Familiar_x_Estudiante_RepEco_Info>();
                    Lista_familiar_x_estudiante_rep_eco = bus_fa_est_rep_eco.Get_List_RepresentateEconomico_x_Estudiante(param.IdInstitucion, Convert.ToDecimal(ucAca_Estudiante.cmbEstudiante.EditValue));
                    if (Lista_familiar_x_estudiante_rep_eco.Count != 0)
                    {
                        if (Lista_familiar_x_estudiante_rep_eco.Count == 1)
                        {
                            foreach (var item in Lista_familiar_x_estudiante_rep_eco)
                            {
                                infoCliente = BusCliente.Get_info_Cliente_x_IdPersona(param.IdEmpresa, item.IdPersona);
                                if (infoCliente != null)
                                {
                                    ctrl_Cliente.Enabled = true;
                                    ctrl_Cliente.cargar_Clientes();
                                    ctrl_Cliente.set_ClienteInfo(infoCliente.IdCliente);
                                    ctrl_Cliente.cmb_cliente.Properties.ReadOnly = true;
                                }
                            }

                        }
                        else
                        {
                            foreach (var item in Lista_familiar_x_estudiante_rep_eco)
                            {
                                infoCliente = BusCliente.Get_info_Cliente_x_IdPersona(param.IdEmpresa, item.IdPersona);
                                if (infoCliente != null)
                                {
                                    Lista_Cliente.Add(infoCliente);
                                }
                            }
                            ctrl_Cliente.Enabled = true;
                            ctrl_Cliente.cmb_cliente.Properties.DataSource = Lista_Cliente;
                            ctrl_Cliente.cmb_cliente.Properties.ReadOnly = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }
    }
}