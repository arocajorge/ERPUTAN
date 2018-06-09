using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Facturacion_Grafinpren;
using Core.Erp.Business.Facturacion;

using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Reportes.Facturacion;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Info.CuentasxCobrar;
using System.Reflection;
using Core.Erp.Business.Caja;
using Core.Erp.Reportes.Contabilidad;
using System.IO;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    public partial class frmFa_Factura_Mant : Form
    {
        #region declaracion de Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private Cl_Enumeradores.eTipo_action _Accion;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        fa_factura_x_ct_cbtecble_Info Info_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Info();

        //delegados y eventos
        public delegate void delegate_frmFA_Factura_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmFA_Factura_FormClosing event_frmFA_Factura_FormClosing;


        static string result = Path.GetTempPath();
        String RootReporte = result + @"Factura.repx";
        //int lengthNumFac = 0;
        Boolean fec = false;
        double SumValForPag = 0;
        double SumPorDist = 0;
        string MensajeError = "";
        decimal IdCbteVta = 0;
        int rowHandle = 0;

       
        fa_parametro_Bus Bus_Param_facturacion = new fa_parametro_Bus();
        in_Parametro_Bus Bus_param_inven = new in_Parametro_Bus();


        Business.Facturacion_Grafinpren.fa_factura_Bus Bus_Factura = new Business.Facturacion_Grafinpren.fa_factura_Bus();
        Business.Facturacion_Grafinpren.fa_factura_det_Bus Bus_factura_det = new Business.Facturacion_Grafinpren.fa_factura_det_Bus();
        
        
        tb_sis_Documento_Tipo_Talonario_Bus BusDoc = new tb_sis_Documento_Tipo_Talonario_Bus();
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus Bus_Prod_x_bod = new in_producto_x_tb_bodega_Bus();
        ct_punto_cargo_Bus Bus_Punto_Cargo = new ct_punto_cargo_Bus();
        fa_factura_x_formaPago_Bus Bus_FacxForPag = new fa_factura_x_formaPago_Bus();
        
        caj_Caja_Bus Bus_Caja = new caj_Caja_Bus();
        fa_TerminoPago_Bus Bus_Termino_pago = new fa_TerminoPago_Bus();
        fa_TerminoPago_Distribucion_Bus Bus_Termi_PagoDistri = new fa_TerminoPago_Distribucion_Bus();
        
        //Clases Info

        in_Parametro_Info Info_param_inven = new in_Parametro_Info();
        in_Producto_Info Info_producto = new in_Producto_Info();
        fa_parametro_info Info_Param_fact = new fa_parametro_info();
        
        fa_factura_Info InfoFactura = new fa_factura_Info();
        fa_factura_det_info Info_Fact_Det = new fa_factura_det_info();
        
        fa_Cliente_Info InfoCliente = new fa_Cliente_Info();

        tb_sis_Documento_Tipo_Talonario_Info Info_Documento_talonario_Actual = new tb_sis_Documento_Tipo_Talonario_Info();
        
        fa_factura_x_formaPago_Info Info_fac_x_forma_pago = new fa_factura_x_formaPago_Info();
        

        fa_TerminoPago_Info Info_TerminoPago = new fa_TerminoPago_Info();

        
        //Listas Info
        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();
        List<fa_TerminoPago_Info> list_TerminoPago = new List<fa_TerminoPago_Info>();
        List<ct_punto_cargo_Info> Lista_PuntoCargo = new List<ct_punto_cargo_Info>();
        
        List<fa_Documento_Tipo_info> lmTipoDoc = new List<fa_Documento_Tipo_info>();
        List<in_movi_inve_detalle_Info> invList = new List<in_movi_inve_detalle_Info>();

       
        List<fa_TerminoPago_Distribucion_Info> List_Termino_Pago_x_Distri = new List<fa_TerminoPago_Distribucion_Info>();
        List<fa_factura_x_formaPago_Info> List_fac_x_forma_pago = new List<fa_factura_x_formaPago_Info>();
        
        //BindingList Info

        BindingList<fa_factura_x_fa_TerminoPago_Info> Binding_list_fac_form_pago = new BindingList<fa_factura_x_fa_TerminoPago_Info>();
        BindingList<fa_factura_det_info> Binding_List_Factura_det = new BindingList<fa_factura_det_info>();

        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        List<ct_punto_cargo_Info> lst_punto_cargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();
        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> lst_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();

        tb_sis_impuesto_Bus BusImp = new tb_sis_impuesto_Bus();
        List<tb_sis_impuesto_Info> listTipoImpu_x_Iva = new List<tb_sis_impuesto_Info>();

        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        ct_Centro_costo_Bus Bus_CentroCosto =new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();


        #endregion

        public frmFa_Factura_Mant()
        {
            InitializeComponent();
            event_frmFA_Factura_FormClosing += frmFa_Factura_Mant_event_frmFA_Factura_FormClosing;
        }

        void frmFa_Factura_Mant_event_frmFA_Factura_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmFa_Factura_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmFA_Factura_FormClosing(sender, e);
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

        #region funciones get & set

        public void Set_Accion(Cl_Enumeradores.eTipo_action Accion_)
        {
            try
            {
                _Accion = Accion_;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Set_Info_in_controls()
        {
            try
            {
                IdCbteVta = InfoFactura.IdCbteVta;
                txtIdFactura.EditValue = InfoFactura.IdCbteVta;
                UCSucursal.cmb_sucursal.EditValue = InfoFactura.IdSucursal;
                UCSucursal.cmb_bodega.EditValue = InfoFactura.IdBodega;
                cmbCaja.EditValue = InfoFactura.IdCaja;
                ucFa_ClienteCmb.set_ClienteInfo(InfoFactura.IdCliente);

                txtidContable.Text = InfoFactura.IdCbteVta.ToString();
                lblAutorizacion.Text = InfoFactura.vt_autorizacion;

                InfoFactura.IdUsuario = param.IdUsuario;
                ucFa_VendedorCmb.set_VendedorInfo(InfoFactura.IdVendedor);
                dateFecha.Value = InfoFactura.vt_fecha;
                dateFechaVencimiento.Value = InfoFactura.vt_fech_venc;
                
                txtObservacion.Text = InfoFactura.vt_Observacion;
                
                Info_Documento_talonario_Actual = BusDoc.Verificar_DocumentoElectronico(InfoFactura.IdEmpresa, "FACT", InfoFactura.vt_serie1, InfoFactura.vt_serie2, InfoFactura.vt_NumFactura, Info_Documento_talonario_Actual, ref MensajeError);

                if (Info_Documento_talonario_Actual.es_Documento_electronico != null)//no tiene talonario
                {
                    UCNumDoc.txtNumDoc.Text = InfoFactura.vt_NumFactura;
                    UCNumDoc.txe_Serie.EditValue = InfoFactura.vt_serie1 + "-" + InfoFactura.vt_serie2;
                    UCNumDoc.rbt_doc_Electronico.Checked = (bool)Info_Documento_talonario_Actual.es_Documento_electronico;
                }
                     
                //datos internos
                txt_num_op.Text = InfoFactura.Factura_Graf.num_op;
                txt_num_cotizacion.Text = InfoFactura.Factura_Graf.num_cotizacion;
                ucFa_Equipos_Graf1.Set_InfoEquipo(InfoFactura.Factura_Graf.IdEquipo);
                dt_fecha_num_op.Value = Convert.ToDateTime((InfoFactura.Factura_Graf.fecha_op == DateTime.MinValue)? DateTime.Now : InfoFactura.Factura_Graf.fecha_op);
                dt_fecha_cotizacion.Value = (InfoFactura.Factura_Graf.fecha_cotizacion == DateTime.MinValue) ? DateTime.Now : InfoFactura.Factura_Graf.fecha_cotizacion;
                txt_porc_comision.Text = InfoFactura.Factura_Graf.porc_comision.ToString();
                spinEditDiasPlazo.Value = InfoFactura.vt_plazo;

                cmbTerminoPago.EditValue = InfoFactura.vt_tipo_venta;
               // cmbTerminoPago.Properties.DataSource = null;

                SumValForPag = 0;
                SumPorDist = 0;
                foreach (var item in Binding_list_fac_form_pago)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                    info.Por_Distribucion = item.Por_Distribucion;
                    info.Valor = item.Valor;

                    SumValForPag = SumValForPag + info.Valor;
                    SumPorDist = SumPorDist + info.Por_Distribucion;
                }

                if (Lista_producto.Count() == 0) { load_Producto(InfoFactura.IdEmpresa, InfoFactura.IdSucursal, InfoFactura.IdBodega); }
                
                InfoFactura.DetFactura_List=Bus_factura_det.Get_List_factura_det(InfoFactura.IdEmpresa,InfoFactura.IdSucursal,InfoFactura.IdBodega,InfoFactura.IdCbteVta,ref MensajeError);
                Binding_List_Factura_det = new BindingList<fa_factura_det_info>(InfoFactura.DetFactura_List);
                gridControl_Factura.DataSource = Binding_List_Factura_det;


                ucFa_FormaPago_x_Factura.Cargar_grid_x_Factura(InfoFactura.IdEmpresa, InfoFactura.IdSucursal, InfoFactura.IdBodega, InfoFactura.IdCbteVta);
                
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

        public void Set_Info(fa_factura_Info _InfoFactura)
        {
            try
            {
                InfoFactura = _InfoFactura;
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

        private void Set_Accion_In_controls()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        UCNumDoc.txtNumDoc.Properties.ReadOnly = true;
                        UCNumDoc.txe_Serie.Properties.ReadOnly = true;
                       // gridView_Factura.OptionsBehavior.ReadOnly = true;
                        UCSucursal.Bloquerar_Combos();
                        Set_Info_in_controls();
                        
                        CalcularTotales();
              
                        ucFa_ClienteCmb.Enabled = false;                        
                        if (lblAnulado.Visible == true)
                        {
                            gridView_Factura.OptionsBehavior.ReadOnly = true;
                        }                        
                        dateFecha.Enabled = false;
                        spinEditDiasPlazo.Enabled = false;
                        dateFechaVencimiento.Enabled = false;
                        cmbTerminoPago.Enabled = false;
                        cmbCaja.Enabled = false;
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                       // this.gridViewFormaPag.OptionsBehavior.Editable = false;

                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.grabar:
                        UCNumDoc.Set_Perfil_solo_lectura(false);
                        tabControl2.Enabled = false;
                        xtraTabControl_cuerpo.Enabled = false;
                        ucFa_VendedorCmb.Enabled = true;
                        ucFa_ClienteCmb.Enabled = true;
                        cmbTerminoPago.Enabled = true;
                        cmbCaja.Enabled = true;
                        dateFecha.Enabled = true;
                        spinEditDiasPlazo.Enabled = true;
                        dateFechaVencimiento.Enabled = true;
                        ucGe_Menu.Visible_btnGuardar = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu.Visible_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        gridView_Factura.OptionsBehavior.ReadOnly = false;
                        ucGe_Menu.Enabled_btn_Generar_XML = false;
                        Cargar_Grid();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        //  btnAnular.Enabled = false;                        
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                        gridView_Factura.OptionsBehavior.ReadOnly = true;
                        txtObservacion.Enabled = false;
                        Set_Info_in_controls();

                        CalcularTotales();
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_bntImprimir = true;
                        ucGe_Menu.Visible_btnImprimirSoporte = true;
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        dateFecha.Enabled = false;
                        spinEditDiasPlazo.Enabled = false;
                        dateFechaVencimiento.Enabled = false;
                        cmbTerminoPago.Enabled = false;

                        
                        cmbCaja.Enabled = false;
                        UCSucursal.Bloquerar_Combos();
                        

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set_Info_in_controls();
                        CalcularTotales();
                        UCNumDoc.Set_Perfil_solo_lectura(true);
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Visible_bntImprimir = false;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        ucGe_Menu.Visible_btnImprimirSoporte = false;
                        UCSucursal.Bloquerar_Combos();
                        
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

        public  fa_factura_Info Get_Info_Factura()
        {
            try
            {
                tb_sis_Documento_Tipo_Talonario_Info talonarioInfo = new tb_sis_Documento_Tipo_Talonario_Info();
                InfoFactura = new fa_factura_Info();
                talonarioInfo = UCNumDoc.Get_Info_Talonario();
                InfoFactura.IdCbteVta = txtIdFactura.Text == "" ? 0 : Convert.ToDecimal(txtIdFactura.Text);
                InfoFactura.CodCbteVta = "";
                InfoFactura.Estado = "A";
                InfoFactura.Fecha_Transaccion = DateTime.Now;
                InfoFactura.Fecha_UltAnu = DateTime.Now;
                InfoFactura.Fecha_UltMod = DateTime.Now;
                InfoFactura.IdBodega = Convert.ToInt32(UCSucursal.cmb_bodega.EditValue);
                InfoFactura.IdSucursal = Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue);
                InfoFactura.IdCliente = Convert.ToInt32(ucFa_ClienteCmb.get_ClienteInfo().IdCliente);
                InfoFactura.IdEmpresa = param.IdEmpresa;
                InfoFactura.IdPeriodo = (DateTime.Now.Year * 100) + DateTime.Now.Month;
                InfoFactura.IdUsuario = param.IdUsuario;
                InfoFactura.IdUsuarioUltAnu = param.IdUsuario;
                InfoFactura.IdUsuarioUltModi = param.IdUsuario;
                InfoFactura.IdVendedor = Convert.ToInt32((ucFa_VendedorCmb.get_VendedorInfo() == null) ? 0 : ucFa_VendedorCmb.get_VendedorInfo().IdVendedor);
                InfoFactura.ip = param.ip;
                InfoFactura.nom_pc = param.nom_pc;
                InfoFactura.vt_fecha = Convert.ToDateTime(dateFecha.Value);
                InfoFactura.vt_fech_venc = Convert.ToDateTime(dateFechaVencimiento.Value);
                InfoFactura.vt_flete = 0;
                InfoFactura.vt_interes = 0;
                InfoFactura.vt_NumFactura = talonarioInfo.NumDocumento;
                InfoFactura.IdCaja = Convert.ToInt32(cmbCaja.EditValue);
                InfoFactura.Factura_Graf.IdEmpresa = InfoFactura.IdEmpresa;
                InfoFactura.Factura_Graf.IdSucursal = InfoFactura.IdSucursal;
                InfoFactura.Factura_Graf.IdBodega = InfoFactura.IdBodega;
                InfoFactura.Factura_Graf.IdCbteVta = InfoFactura.IdCbteVta;
                InfoFactura.Factura_Graf.num_op = (txt_num_op.Text == "") ? " " : txt_num_op.Text;
                InfoFactura.Factura_Graf.fecha_op = dt_fecha_num_op.Value;
                InfoFactura.Factura_Graf.num_cotizacion = (txt_num_cotizacion.Text == "") ? " " : txt_num_cotizacion.Text;
                InfoFactura.Factura_Graf.fecha_cotizacion = dt_fecha_cotizacion.Value;
                InfoFactura.Factura_Graf.IdEquipo = ucFa_Equipos_Graf1.Get_Equipo().IdEquipo;
                InfoFactura.Factura_Graf.porc_comision = (txt_porc_comision.Text == "") ? 0 : Convert.ToDouble(txt_porc_comision.Text);
                

                InfoFactura.vt_Observacion = txtObservacion.Text;

                InfoFactura.vt_OtroValor1 = 0;
                InfoFactura.vt_OtroValor2 = 0;

                InfoFactura.vt_plazo = Info_TerminoPago.Dias_Vct;
                InfoFactura.vt_seguro = 0;
                InfoFactura.vt_serie1 = talonarioInfo.Establecimiento;
                InfoFactura.vt_serie2 = talonarioInfo.PuntoEmision;
                InfoFactura.EsDocumentoElectronico = (bool)talonarioInfo.es_Documento_electronico;
                InfoFactura.vt_tipo_venta = Info_TerminoPago.IdTerminoPago;
                InfoFactura.vt_tipoDoc = "FACT";
                InfoFactura.vt_anio = InfoFactura.vt_fecha.Year;
                InfoFactura.vt_mes = InfoFactura.vt_fecha.Month;
                InfoFactura.Vendedor = (ucFa_VendedorCmb.cmb_vendedor.Text == "") ? "" : ucFa_VendedorCmb.cmb_vendedor.Text;
                InfoFactura.Cliente = ucFa_ClienteCmb.cmb_cliente.Text;

                InfoFactura.DetFactura_List = new List<fa_factura_det_info>(Binding_List_Factura_det.Where(q=>q.IdProducto!=0));

                InfoFactura.DetformaPago_list = Get_List_fact_x_Termino_pago();
                InfoFactura.lista_formaPago_x_Factura = Get_List_fact_x_forma_pago();

                return InfoFactura;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new fa_factura_Info();
            }
        }

        public List<fa_factura_x_fa_TerminoPago_Info> Get_List_fact_x_Termino_pago()
        {
            try
            {
                List<fa_factura_x_fa_TerminoPago_Info> ListaFormaPago = new List<fa_factura_x_fa_TerminoPago_Info>();
                foreach (var item in Binding_list_fac_form_pago)
                {
                    fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = InfoFactura.IdBodega;
                    info.IdBodega = InfoFactura.IdSucursal;
                    info.IdCbteVta = InfoFactura.IdCbteVta;

                    info.Secuencia = item.Secuencia;
                    info.Fecha = dateFecha.Value;
                    info.Fecha_vct = item.Fecha_vct;
                    info.Dias_Plazo = item.Dias_Plazo;
                    info.Por_Distribucion = item.Por_Distribucion;
                    info.Valor = item.Valor;
                    info.IdTerminoPago = item.IdTerminoPago;
                    ListaFormaPago.Add(info);
                }
                return ListaFormaPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<fa_factura_x_fa_TerminoPago_Info>();
            }
        }


        public List<fa_factura_x_formaPago_Info> Get_List_fact_x_forma_pago()
        {
            try
            {
                List<fa_factura_x_formaPago_Info> ListaFormaPago = new List<fa_factura_x_formaPago_Info>();

                ListaFormaPago = ucFa_FormaPago_x_Factura.Get_List_factura_x_formaPago();

              
                return ListaFormaPago;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas)
                    , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<fa_factura_x_formaPago_Info>();
            }
        }

        #endregion

        #region funciones Grabar & Modifica & Anular & Limpiar & Validar

        private Boolean Anular()
        {
            Boolean Respuesta = false;

            try
            {
                if (MessageBox.Show("¿Realmente Desea Anular la Factura?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
                    if (InfoFactura.Estado == "I" || lblAnulado.Visible == true)
                    { MessageBox.Show("La Factura se encuentra Anulada.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return Respuesta;
                    }

                    Get_Info_Factura();
                    frm.ShowDialog();
                    InfoFactura.MotivoAnulacion = frm.motivoAnulacion;
                    string mensaje_error = "";

                    Respuesta=Bus_Factura.AnularDB(InfoFactura, param.Fecha_Transac, ref mensaje_error);
                    if (Respuesta)
                    {
                        MessageBox.Show("La Factura se Anuló Correctamente.\n" + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
                        ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_btnGuardar = false;
                        

                    }
                    else
                    {
                        MessageBox.Show("Error al anular Factura " + "**** " + frm.motivoAnulacion + " ****"); lblAnulado.Visible = true;
                    }
                }

                return Respuesta;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void limpiar()
        {
            try
            {
                txtIdFactura.Text = "";
                gridControl_Factura.DataSource = null;
                txtObservacion.Text = "";
                txtidContable.Text = "";
                ucFa_ClienteCmb.set_ClienteInfo(0);
                ucFa_VendedorCmb.set_VendedorInfo(0);
                cmbCaja.EditValue = Info_Param_fact.IdCaja_Default_Factura;
                cmbTerminoPago.EditValue = "";
                spinEditDiasPlazo.Value = 0;
                dateFecha.Value = dateFechaVencimiento.Value = DateTime.Now;
                CalcularTotales();
                cargarNumDoc();
                txtObservacion.Text = "";
                
                //campos presonalizados
                txt_num_cotizacion.Text = "";
                txt_num_op.Text = "";
                txt_porc_comision.Text = "";
                dt_fecha_cotizacion.Value = DateTime.Now;
                dt_fecha_num_op.Value = DateTime.Now;
                ucFa_Equipos_Graf1.InicializarEquipo();

                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                Binding_List_Factura_det = new BindingList<fa_factura_det_info>();
                InfoFactura.DetFactura_List = new List<fa_factura_det_info>();

                Set_Accion_In_controls();
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

        Boolean Guardar()
        {
            try
            {
                Boolean bolResult = false;
                decimal idCbte_vta = 0;
                string numDocFactura = "";
                txtObservacion.Focus();

                Get_Info_Factura();

                if (!validar())
                {
                    return bolResult;
                }
                else
                {
                  

                    string mensajeDocumentoDupli = "";
                    string msg = "";


                    if (MessageBox.Show("La FACT # " + InfoFactura.vt_serie1 + "-" + InfoFactura.vt_serie2 + "-" + InfoFactura.vt_NumFactura + " se procedera a Guardar." + "\n" + "¿Desea Continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                      

                        bolResult = Bus_Factura.GuardarDB(InfoFactura, ref idCbte_vta, ref numDocFactura, ref msg, ref mensajeDocumentoDupli);

                        if (bolResult)
                        {
                            InfoFactura.IdCbteVta = idCbte_vta;
                            txtIdFactura.EditValue = idCbte_vta;
                            txtidContable.Text = Convert.ToString(idCbte_vta);


                            MessageBox.Show("La FACT # " + numDocFactura + "/" + idCbte_vta + " Fue almacenada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ucGe_Menu.Enabled_btn_Generar_XML = true;
                            
                            if (MessageBox.Show("¿Desea Imprimir la Factura # " + numDocFactura + "/" + idCbte_vta + " ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                            }

                            if (MessageBox.Show("¿Desea Imprimir el Soporte de la Factura # " + numDocFactura + "/" + idCbte_vta + " ?" + "\n" + "Imprimir", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_event_btnImprimirSoporte_Click(null, null);
                            }

                            if (MessageBox.Show("¿Desea Generar el Xml de la Factura # " + numDocFactura + "/" + idCbte_vta + " ?" + "\n" + "Generar Xml", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                Generar_Xml();
                            }
                            limpiar();
                        }
                        else
                        {
                            if (mensajeDocumentoDupli == "")
                            {
                                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(mensajeDocumentoDupli, param.Nombre_sistema);
                                cargarNumDoc();
                            }
                        };





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

        Boolean Modificar()
        {
            try
            {
                Boolean bolResult = false;

                txtObservacion.Focus();

                Get_Info_Factura();

                if (!validar())
                {
                    return bolResult;
                }
                else
                {
                    
                    string msg = "";

                    if (MessageBox.Show("La FACT # " + InfoFactura.vt_serie1 + "-" + InfoFactura.vt_serie2 + "-" + InfoFactura.vt_NumFactura + " se procedera a Guardar." + "\n" + "¿Desea Continuar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        
                        bolResult = Bus_Factura.ModificarDB(InfoFactura, ref msg);
                        if (bolResult)
                        {
                            bolResult = true;
                            MessageBox.Show("La FACT # " + InfoFactura.vt_serie1 + "-" + InfoFactura.vt_serie2 + "-" + InfoFactura.vt_NumFactura + " Fue Modificada con Exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                        }
                        else { MessageBox.Show(msg); };
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

        Boolean Guardar_Datos()
        {
            try
            {
                Boolean respuesta = false;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Guardar();
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Modificar();
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ":" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarParametros()
        {
            try
            {
                fa_parametro_Bus BusParametros = new fa_parametro_Bus();
                fa_parametro_info param_fa = new fa_parametro_info();
                param_fa = BusParametros.Get_Info_parametro(param.IdEmpresa);
                if (param_fa != null)
                {
                    if (param_fa.IdMovi_inven_tipo_Factura == 0 || param_fa.IdMovi_inven_tipo_Factura_Anulacion == 0 || param_fa.IdTipoCbteCble_Factura == 0 || param_fa.IdTipoCbteCble_Factura_Costo_VTA == 0 || param_fa.IdTipoCbteCble_Factura_Costo_VTA_Reverso == 0 || param_fa.IdTipoCbteCble_Factura_Reverso == 0)
                    {
                        MessageBox.Show("No puede continuar porque están incompletos los parámetros de Ventas.. \nIngréselos desde la pantalla de parámetros de Ventas o, comuníquese con sistemas", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Faltan Parametros de factuacion ");
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

        public Boolean validar()
        {
            try
            {
                txtIdFactura.Focus();
                double TotalPorcent = 0;
                foreach (var item in Binding_list_fac_form_pago)
                {
                    TotalPorcent = item.Por_Distribucion + TotalPorcent;
                }
                if (TotalPorcent > 100) { MessageBox.Show("La suma del porcentaje de formas de cobro no puede exeder el 100% "); ;return false; };

                if (ucFa_ClienteCmb.get_ClienteInfo() == null)
                {
                    MessageBox.Show("No ha Ingresado Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (ucFa_VendedorCmb.get_VendedorInfo() == null) { MessageBox.Show("No ha Ingresado Vendedor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }

                if (txtObservacion.Text == "") { MessageBox.Show("No ha Ingresado la Observacion"); txtObservacion.Focus(); return false; }

                if (ucFa_Equipos_Graf1.Get_Equipo().IdEquipo == 0)
                {
                    MessageBox.Show("No ha escogido la máquina.", param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }

                if (List_Termino_Pago_x_Distri.Count() == 0)
                {
                }
                else
                {
                    if (SumPorDist != 100)
                    {
                        MessageBox.Show("El % de Forma Pago no es igual al 100% ", param.Nombre_sistema);
                        return false;
                    }
                }

                if (cmbCaja.EditValue == null || Convert.ToString(cmbCaja.EditValue) == "" || Convert.ToInt32(cmbCaja.EditValue) == 0)
                {
                    MessageBox.Show("Ingrese la caja ", param.Nombre_sistema);
                    return false;
                }

                if (this.cmbTerminoPago.EditValue == null || Convert.ToString(cmbTerminoPago.EditValue) == "")
                {
                    MessageBox.Show("Ingrese el Término de Pago ", param.Nombre_sistema);
                    return false;
                }

                int count1= Binding_List_Factura_det.Count(v => v.IdProducto > 0);

                if (count1 == 0)
                {
                    MessageBox.Show("No ha agregado Ningún Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }



                int count2 = InfoFactura.lista_formaPago_x_Factura.Count();

                if (count2 == 0)
                {
                    MessageBox.Show("No ha seleccionado forma de pago", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                


                foreach (var item in Binding_List_Factura_det)
                {
                    if (item.IdProducto != 0)
                    {
                        Info_producto = Lista_producto.FirstOrDefault(q => q.IdProducto == item.IdProducto);
                        if (item.vt_detallexItems == null || item.vt_detallexItems.Trim() == "")
                        {
                            MessageBox.Show("Ingrese la observación del item " + Info_producto.pr_descripcion_2 + " en el detalle ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        if (item.vt_cantidad == 0)
                        {
                            MessageBox.Show("El item " + Info_producto.pr_descripcion_2 + " registra valores de cantidad en 0. Por favor ingrese la cantidad ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                        if (item.IdCentroCosto == null)
                        {
                            MessageBox.Show("El item " + Info_producto.pr_descripcion_2 + " no tiene centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }

                if (UCNumDoc.Get_Info_Talonario().NumDocumento == "")
                {
                    return false;
                    if (UCNumDoc.Get_Info_Talonario().NumDocumento == null)
                    {
                        return false;
                    }
                }

                if (!Validar_CtasCbles_Factura())
                {
                    return false;
                }
                if (_Accion==Cl_Enumeradores.eTipo_action.grabar)
                {
                    UCNumDoc.IdEstablecimiento = UCSucursal.get_sucursal().Su_CodigoEstablecimiento;
                    UCNumDoc.IdPuntoEmision = UCSucursal.get_bodega().cod_punto_emision;
                    UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT;
                    UCNumDoc.Get_Primer_Documento_no_usado();    
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.FAC, Convert.ToDateTime(dateFecha.Value)))
                    return false;

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

        #endregion

        #region Controles
        public void UCSucursal_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
                cargarNumDoc();
                //ultraCmb_tipoDoc_ValueChanged(new object(), new EventArgs());
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

        public void UCSucursal_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();
                cargarNumDoc();
               // ultraCmb_tipoDoc_ValueChanged(new object(), new EventArgs());
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
        
        public void ucGe_Menu_event_btn_Generar_XML_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = "";

                fa_parametro_Bus bus_Param = new fa_parametro_Bus();
                fa_parametro_info param_info = new fa_parametro_info();

                param_info = bus_Param.Get_Info_parametro(param.IdEmpresa);

                if (Bus_Factura.GenerarXml_Factura(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), InfoFactura.IdCbteVta, param_info.pa_ruta_descarga_xml_fac_elct, ref  mensaje))
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

        public void ucGe_Menu_event_btnImprimirSoporte_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_Rpt007_rpt rptSoporte = new XFAC_Rpt007_rpt(param.IdUsuario);
                XFAC_Rpt007_Bus busRpt = new XFAC_Rpt007_Bus();
                List<XFAC_Rpt007_Info> lstRpt = new List<XFAC_Rpt007_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_SoporteFactura(InfoFactura.IdEmpresa, InfoFactura.IdSucursal, InfoFactura.IdBodega, InfoFactura.IdCbteVta);
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

        void ImprimirDiario()
        {
            try
            {
                XCONTA_Rpt003_rpt reporte = new XCONTA_Rpt003_rpt();
                reporte.set_parametros(Info_Fac_x_cbtecble.ct_IdEmpresa, Info_Fac_x_cbtecble.ct_IdTipoCbte, Info_Fac_x_cbtecble.ct_IdCbteCble);
                reporte.RequestParameters = true;
                reporte.ShowPreviewDialog();
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
        
        public void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
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

        public void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
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

        public void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XFAC_Rpt008_rpt rptSoporte = new XFAC_Rpt008_rpt(param.IdUsuario);
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
                tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();

                InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(param.IdEmpresa, Cl_Enumeradores.eTipoDocumento_Talonario.FACT.ToString());
                if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
                {
                    File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                    rptSoporte.LoadLayout(RootReporte);
                }


                XFAC_Rpt008_Bus busRpt = new XFAC_Rpt008_Bus();
                List<XFAC_Rpt008_Info> lstRpt = new List<XFAC_Rpt008_Info>();
                rptSoporte.RequestParameters = false;

                lstRpt = busRpt.get_ImpresionFactura(InfoFactura.IdEmpresa, InfoFactura.IdSucursal, InfoFactura.IdBodega, InfoFactura.IdCbteVta);
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

        public void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
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

        public void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar_Datos())
                    limpiar();
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

        public void UCGrid_Evente_ultraGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                CalcularTotales();
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

        public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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

        public void UCGrid_Event_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                CalcularTotales();
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

        public void UCGrid_Event_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                CalcularTotales();
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

        public void Cargar_Grid()
        {
            try
            {
                Binding_List_Factura_det = new BindingList<fa_factura_det_info>();
                for (int i = 0; i < Info_Param_fact.NumeroDeItemFact; i++)
                {
                    Binding_List_Factura_det.Add(new fa_factura_det_info());
                }
                gridControl_Factura.DataSource = Binding_List_Factura_det;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void Generar_Xml()
        {
            try
            {
                string mensaje = "";

                fa_parametro_Bus bus_Param = new fa_parametro_Bus();
                fa_parametro_info param_info = new fa_parametro_info();

                param_info = bus_Param.Get_Info_parametro(param.IdEmpresa);

                if (Bus_Factura.GenerarXml_Factura(param.IdEmpresa, Convert.ToInt32(UCSucursal.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursal.cmb_bodega.EditValue), InfoFactura.IdCbteVta, param_info.pa_ruta_descarga_xml_fac_elct, ref  mensaje))
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

        public void frmFA_Factura_Load(object sender, EventArgs e)
        {
            try
            {
                
                
                ValidarParametros();
                ucFa_FormaPago_x_Factura.Cargar_grid();

                cargar_combo();
                
                Info_param_inven = Bus_param_inven.Get_Info_Parametro(param.IdEmpresa);
                Info_Param_fact=Bus_Param_facturacion.Get_Info_parametro(param.IdEmpresa);

                cmbCaja.Properties.DataSource = Bus_Caja.Get_list_caja(param.IdEmpresa, ref  MensajeError);
                ucFa_Equipos_Graf1.Cargar_Combo();

                cmbCaja.EditValue = Info_Param_fact.IdCaja_Default_Factura;
                Cargar_Grid();

                lst_grupo_punto_cargo = bus_grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Grupo_punto_cargo.DataSource = lst_grupo_punto_cargo;

                lst_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_Punto_Cargo.DataSource = lst_punto_cargo;

              
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                Set_Accion_In_controls();
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

        public void LoadProductos()
        {
            try
            {
                //gridControl_Factura.DataSource = null;
                if (UCSucursal.get_bodega()!=null && UCSucursal.get_sucursal()!=null)
                {
                    gridControl_Factura.DataSource = Binding_List_Factura_det;
                    load_Producto(param.IdEmpresa, UCSucursal.get_IdSucursal(), UCSucursal.get_IdBodega());    
                }

                //carga combo Punto de Cargo
                Lista_PuntoCargo = Bus_Punto_Cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_Punto_Cargo.DataSource = Lista_PuntoCargo;
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

        public void load_Producto(int idempresa, int IdSucursal, int IdBodega)
        {
            try
            {
                Lista_producto = Bus_Producto.Get_list_Producto(idempresa, IdSucursal, IdBodega);
                foreach (var item in Lista_producto)
                {
                    item.Disponible = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock) - item.pr_pedidos == null ? 0 : Convert.ToDouble(item.pr_pedidos);
                }
                cmbProducto.DataSource = Lista_producto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private List<fa_catalogo_Info> lstNaturaleza()
        {
            try
            {
                List<fa_catalogo_Info> lstInfo = new List<fa_catalogo_Info>();
                fa_catalogo_Info Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_TODO.ToString();
                lstInfo.Add(Info);

                Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_VENT.ToString();
                lstInfo.Add(Info);

                return lstInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

                return new List<fa_catalogo_Info>();
            }
        }

        void CalcularIva()
        {
            try
            {
                double precio = 0;
                double cantidad = 0;
                double PrecioFinal = 0;
                double subtotal = 0;
                double Iva = 0;
                double Por_Iva = 0;
                double Total = 0;

                foreach (var item in Binding_List_Factura_det )
                {
                    if (Info_param_inven.Maneja_Stock_Negativo == "N")
                    {

                        if (item.IdProducto > 0)
                        {
                            var ItemProd_Busc = Lista_producto.First(v => v.IdProducto == item.IdProducto);

                           
                                if (item.vt_cantidad > ItemProd_Busc.pr_stock)
                                {
                                    MessageBox.Show("La cantidad Supera Al Stock");
                                    item.vt_cantidad = item.stock;
                                }
                            if (item.vt_cantidad < 0)
                            {
                                item.vt_cantidad = item.vt_cantidad * -1;
                            }
                        }
                    }



                    item.vt_DescUnitario = Math.Round((item.vt_PorDescUnitario * (item.vt_Precio )) / 100, 2);

                    item.vt_PrecioFinal = Math.Round(((item.vt_Precio ) - item.vt_DescUnitario), 2);

                    item.vt_Subtotal = item.vt_cantidad * Math.Round((item.vt_PrecioFinal), 2);



                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == item.IdCod_Impuesto_Iva);

                    if (InfoTipoImpuesto != null)
                    {
                        Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Por_Iva = InfoTipoImpuesto.porcentaje;
                    }


                    item.vt_iva = ((item.vt_Subtotal) * Por_Iva) / 100;
                    item.vt_total = Math.Round((item.vt_Subtotal + item.vt_iva), 2);
                    
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        public void CalcularTotales()
        {
            try
            {
                double base0 = 0;
                double base12 = 0;
                double descuento = 0;
                double iva = 0;
                foreach (var item in Binding_List_Factura_det)
                {
                    //if (item.vt_tieneIVA == true)
                    //{
                    //    base12 += item.vt_Subtotal;
                    //    iva += item.vt_iva;
                    //}
                    //else
                    //{
                    //    base0 += item.vt_total;
                    //}
                    descuento += item.vt_DescUnitario;
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

        public void dateFechaVencimiento_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                TimeSpan o = dateFechaVencimiento.Value - Convert.ToDateTime(dateFecha.Value.ToShortDateString());
                spinEditDiasPlazo.Value = o.Days;
                spinEditDiasPlazo_Validating(new object(), new CancelEventArgs());
                if (this.dateFechaVencimiento.Value < dateFecha.Value)
                {
                    dateFechaVencimiento.Value = dateFecha.Value;

                    return;
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

        public void spinEditDiasPlazo_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if (this.spinEditDiasPlazo.Value < 0)
                {
                    dateFechaVencimiento.Value = dateFecha.Value;
                    spinEditDiasPlazo.Value = 0;
                    return;
                }
                dateFechaVencimiento.Value = dateFecha.Value;
                dateFechaVencimiento.Value = Convert.ToDateTime(dateFechaVencimiento.Value.ToShortDateString()).AddDays(Convert.ToDouble(spinEditDiasPlazo.Value));
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

        public void txtTransporte_AfterExitEditMode(object sender, EventArgs e)
        {
            try
            {
                CalcularTotales();
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

        public void mnu_salir_Click(object sender, EventArgs e)
        {


        }

        public void cargarNumDoc()
        {
            try
            {
                if (Convert.ToString(_Accion) == "grabar")
                {
                    UCNumDoc.IdTipoDocumento = Cl_Enumeradores.eTipoDocumento_Talonario.FACT;
                    if (UCSucursal.get_sucursal() != null && UCSucursal.get_bodega() != null)
                    {
                        UCNumDoc.IdEstablecimiento = UCSucursal.get_sucursal().Su_CodigoEstablecimiento;
                        UCNumDoc.IdPuntoEmision = UCSucursal.get_bodega().cod_punto_emision;
                        UCNumDoc.Get_Primer_Documento_no_usado();
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

        public void btnAnular_Click(object sender, EventArgs e)
        {

        }

        public void setFacturaCotizacion(fa_cotizacion_info infoCot)
        {
            try
            {
                ucFa_ClienteCmb.set_ClienteInfo(infoCot.IdCliente);
                InfoFactura.IdUsuario = param.IdUsuario;
                ucFa_VendedorCmb.set_VendedorInfo(infoCot.IdVendedor);
                dateFecha.Value = infoCot.cc_fecha;
                dateFechaVencimiento.Value = infoCot.cc_fechaVencimiento;
                txtObservacion.Text = infoCot.cc_observacion;
                spinEditDiasPlazo.Value = infoCot.cc_diasPlazo;
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

        public void setFacturaGUIR(fa_guia_remision_Info infoGuia)
        {
            try
            {
                ucFa_ClienteCmb.set_ClienteInfo(infoGuia.IdCliente);
                InfoFactura.IdUsuario = param.IdUsuario;
                ucFa_VendedorCmb.set_VendedorInfo(infoGuia.IdVendedor);
                txtObservacion.Text = infoGuia.gi_Observacion;
                dateFecha.Value = Convert.ToDateTime(infoGuia.gi_fecha); spinEditDiasPlazo.Value = Convert.ToDecimal(infoGuia.gi_plazo);
                dateFechaVencimiento.Value = Convert.ToDateTime(infoGuia.gi_fech_venc);
             
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
       
       
        public void ultraComboDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (Char)102)
                {
                    btnConsultar_Click(new object(), new EventArgs());
                }
               
            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex) { Log_Error_bus.Log_Error(ex.ToString()); MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
       
        



        public void gridViewFormaPago_RowCountChanged(object sender, EventArgs e)
        {


        }

        public void gridViewFormaPago_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


        }

        public void ultraCombo_tipoFactura_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cargarNumDoc();
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

        public void txtTotal_ValueChanged(object sender, EventArgs e)
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

        public void cmbTerminoPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTerminoPago.EditValue != null)
                {
                    if (cmbTerminoPago.Text!= "")
                    {
                        Info_TerminoPago = new fa_TerminoPago_Info();
                        Info_TerminoPago = list_TerminoPago.Where(q => q.IdTerminoPago == Convert.ToString(cmbTerminoPago.EditValue)).FirstOrDefault();
                        spinEditDiasPlazo.EditValue = Info_TerminoPago.Dias_Vct;
                    }
                }
                else
                {
                    spinEditDiasPlazo.EditValue = 1;
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

        public void cmbTerminoPago_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
        {
            try
            {
                fa_TerminoPago_Info objCmb = (fa_TerminoPago_Info)cmbTerminoPago.Properties.View.GetFocusedRow();

                if (objCmb != null)
                {

                    List_Termino_Pago_x_Distri = Bus_Termi_PagoDistri.Get_List_TerminoPago_Distribucion(objCmb.IdTerminoPago);
                    double ValorTotalFactura = 0;

                    ValorTotalFactura = 0;

                    if (ValorTotalFactura == 0)
                    {
                        MessageBox.Show("Ingrese el valor total de la factura .", param.Nombre_sistema);
                        return;
                    }

                    Binding_list_fac_form_pago = new BindingList<fa_factura_x_fa_TerminoPago_Info>();
                    SumValForPag = 0;
                    SumPorDist = 0;
                    foreach (var item in List_Termino_Pago_x_Distri)
                    {

                        fa_factura_x_fa_TerminoPago_Info info = new fa_factura_x_fa_TerminoPago_Info();

                        info.Secuencia = item.Secuencia;
                        info.Por_Distribucion = item.Por_distribucion;

                        DateTime fecha = dateFecha.Value.AddDays(item.Num_Dias_Vcto);

                        info.Fecha_vct = fecha;
                        info.Dias_Plazo = item.Num_Dias_Vcto;

                        info.Valor = ValorTotalFactura * (item.Por_distribucion / 100);
                        info.IdTerminoPago = cmbTerminoPago.EditValue.ToString();


                        SumValForPag = SumValForPag + info.Valor;
                        SumPorDist = SumPorDist + info.Por_Distribucion;

                        Binding_list_fac_form_pago.Add(info);
                    }
                    //gridControlFormaPag.DataSource = Binding_list_fac_form_pago;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Validar_CtasCbles_Factura()
        {
            try
            {
                if (Info_TerminoPago.Dias_Vct == 0)
                {
                    if (InfoCliente.IdCtaCble_cxc == null)
                    {
                        if (MessageBox.Show("El Cliente no Tiene Cta Cble de Contado. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (InfoCliente.IdCtaCble_cxc_Credito == null)
                    {
                        if (MessageBox.Show("El Cliente no Tiene Cta Cble de Credito. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            return false;
                        }
                    }
                }

                if (Info_Param_fact.IdCtaCble_IVA == null)
                {
                    if (MessageBox.Show("No hay Parametrizado Cta Cble de IVA. No Generará Diario, Desea Continuar?" + "\n", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }

                in_Producto_Info Info_Producto = new in_Producto_Info();

              
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

        public void ucFa_ClienteCmb_event_cmb_cliente_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucFa_ClienteCmb.get_ClienteInfo() != null)
                {
                    tabControl2.Enabled = true;
                    xtraTabControl_cuerpo.Enabled = true;
                    string IdTipoCredito = "";
                    InfoCliente = ucFa_ClienteCmb.get_ClienteInfo();
                    if (InfoCliente.IdTipoCredito == null)
                        IdTipoCredito = Cl_Enumeradores.eTipoCreditoCliente.AMB.ToString();
                    else
                        IdTipoCredito = InfoCliente.IdTipoCredito;


                   


                    spinEditDiasPlazo.EditValue = InfoCliente.cl_plazo;
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

        private void gridView_Factura_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {

                double cantidad = 0;
                double precio = 0;
                double precio_final = 0;
                double Descuento_Unitario = 0;
                double Porc_Descuento = 0;
                double Porc_Iva = 0;
                double Descuento_total = 0;
                double subtotal = 0;
                double iva = 0;
                double Total_Vta = 0;

                

                Info_Fact_Det = new fa_factura_det_info();
                Info_Fact_Det = (fa_factura_det_info)this.gridView_Factura.GetFocusedRow();



                precio = Convert.ToDouble(gridView_Factura.GetFocusedRowCellValue(colPrecio));
                cantidad = Convert.ToInt32(gridView_Factura.GetFocusedRowCellValue(colCantidad));
                Porc_Descuento = Convert.ToDouble(gridView_Factura.GetFocusedRowCellValue(colPorc_Descuento));
                Descuento_total = ((cantidad * precio) * Porc_Descuento) / 100;
                Descuento_Unitario = (Porc_Descuento * precio) / 100;
                subtotal = (precio * cantidad)-Descuento_total;
                iva = 0;
                Porc_Iva = 0;
                Total_Vta = 0;



                if (e.Column == colCantidad || e.Column==colPrecio)
                {
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);


                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Fact_Det.IdCod_Impuesto_Iva);
                    

                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    Total_Vta = subtotal + iva;


                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridView_Factura.SetFocusedRowCellValue(colTotal, Total_Vta);
                    
                }

                if (e.Column == colIdCod_Impuesto_Iva)
                {
                    gridView_Factura.SetFocusedRowCellValue(colvt_PrecioFinal, (precio - Descuento_Unitario));
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal - Descuento_total);

                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Fact_Det.IdCod_Impuesto_Iva);
                    iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }
                    Total_Vta = subtotal + iva;
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    Total_Vta = subtotal + iva;
                    gridView_Factura.SetFocusedRowCellValue(colTotal, Total_Vta);

                }

                if (e.Column == colPorc_Descuento)
                {
                    Descuento_Unitario = (precio * Porc_Descuento) / 100;
                    Descuento_total = ((cantidad * precio) * Porc_Descuento) / 100;
                    subtotal = (precio * cantidad);

                    gridView_Factura.SetFocusedRowCellValue(colvt_PrecioFinal, (precio - Descuento_Unitario));
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, Descuento_total);
                    gridView_Factura.SetFocusedRowCellValue(colSubTotal_sin_desc, subtotal);
                    gridView_Factura.SetFocusedRowCellValue(colSubtotal, subtotal - Descuento_total);

                  

                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Info_Fact_Det.IdCod_Impuesto_Iva);
                    iva = 0;
                    Porc_Iva = 0;

                    if (InfoTipoImpuesto != null)
                    {
                        iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                        Porc_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Porc_Iva);
                    gridView_Factura.SetFocusedRowCellValue(colIva, iva);
                    gridView_Factura.SetFocusedRowCellValue(colTotal, (subtotal + iva - Descuento_total));
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                NameMetodo = NameMetodo + " - " + ex.ToString();
                MessageBox.Show(NameMetodo + " " + param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmbProducto_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                double Por_Iva = 0;
                if (e.NewValue != null)
                {
                    in_Producto_Info InfoProd = Lista_producto.First(v => v.IdProducto == Convert.ToDecimal(e.NewValue));
                    gridView_Factura.SetFocusedRowCellValue(colCodigo_Producto, InfoProd.IdProducto);
                    gridView_Factura.SetFocusedRowCellValue(colPrecio, InfoProd.pr_precio_publico);
                    gridView_Factura.SetFocusedRowCellValue(colCosto, InfoProd.pr_costo_promedio);
                    gridView_Factura.SetFocusedRowCellValue(colStock, InfoProd.pr_stock);
                    gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_Ven0, InfoProd.IdCtaCble_Ven0);
                    gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_VenIva, InfoProd.IdCtaCble_VenIva);
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, InfoProd.Porc_Descuento);
                    tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                    InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == InfoProd.IdCod_Impuesto_Iva);

                    if (InfoTipoImpuesto != null)
                    {

                        Por_Iva = InfoTipoImpuesto.porcentaje;
                    }

                    gridView_Factura.SetFocusedRowCellValue(colIdCod_Impuesto_Iva, InfoProd.IdCod_Impuesto_Iva);
                    gridView_Factura.SetFocusedRowCellValue(col_vt_estado, 'A');
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, Por_Iva);
                }
                else
                {
                    gridView_Factura.SetFocusedRowCellValue(colCodigo_Producto, null);
                    gridView_Factura.SetFocusedRowCellValue(colPrecio, 0);
                    gridView_Factura.SetFocusedRowCellValue(colCosto, 0);
                    gridView_Factura.SetFocusedRowCellValue(colStock, 0);
                    gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_Ven0, 0);
                    gridView_Factura.SetFocusedRowCellValue(colIdCtaCble_VenIva, 0);
                    gridView_Factura.SetFocusedRowCellValue(colDescuento, 0);
                    gridView_Factura.SetFocusedRowCellValue(colIdCod_Impuesto_Iva, null);
                    gridView_Factura.SetFocusedRowCellValue(col_vt_estado, 'I');
                    gridView_Factura.SetFocusedRowCellValue(colPorce_Iva, 0); 
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void txt_porc_comision_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl_Factura_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btn_Generar_XML_Click_1(object sender, EventArgs e)
        {
            try
            {
                Generar_Xml();

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

        private void spinEditDiasPlazo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (spinEditDiasPlazo.EditValue != null)
                {
                    if (spinEditDiasPlazo.Text != "")
                    {
                        dateFechaVencimiento.Value = DateTime.Now.AddDays(Convert.ToInt32(spinEditDiasPlazo.EditValue));
                    }
                }
                else
                {
                    dateFechaVencimiento.Value = DateTime.Now;
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

        private void gridView_Factura_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                rowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void cmb_Punto_Cargo_Click(object sender, EventArgs e)
        {
            try
            {
                fa_factura_det_info row = (fa_factura_det_info)gridView_Factura.GetFocusedRow();
                if (row != null)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridView_Factura.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(rowHandle, ColIdPunto_Cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        

                        frm_cons.ShowDialog();
                        info_punto_cargo = frm_cons.Get_Info();
                        if (info_punto_cargo != null)
                        {
                            gridView_Factura.SetFocusedRowCellValue(ColIdPunto_Cargo, info_punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridView_Factura.SetFocusedRowCellValue(ColIdPunto_Cargo, null);
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


        void cargar_combo()
        {
            try
            {
                
                listTipoImpu_x_Iva = BusImp.Get_List_impuesto_para_Ventas("IVA");
                cmbImp_Iva.DataSource = listTipoImpu_x_Iva;

                
                    list_TerminoPago = new List<fa_TerminoPago_Info>();
                    list_TerminoPago = Bus_Termino_pago.Get_List_TerminoPago("");
                
                cmbTerminoPago.Properties.DataSource = list_TerminoPago;


                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.DataSource = list_centroCosto;

                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentrocosot.DataSource = list_subcentro_combo;

                

            }
            catch (Exception ex)
            {

            }
        }

        private void gridControl_Factura_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.ToString() == "46")
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el registro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView_Factura.DeleteSelectedRows();

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

        private void btn_cargar_diario_Click(object sender, EventArgs e)
        {
            try
            {

                
                fa_factura_x_ct_cbtecble_Bus Bus_Fac_x_cbtecble = new fa_factura_x_ct_cbtecble_Bus();

                Info_Fac_x_cbtecble = Bus_Fac_x_cbtecble.Get_info_fa_factura_x_ct_cbtecble(InfoFactura.IdEmpresa, InfoFactura.IdSucursal,InfoFactura.IdBodega , InfoFactura.IdCbteVta,Cl_Enumeradores.eMotivo_Diario_x_Vta.X_FACT );

                ucCon_GridDiario.setInfo(Info_Fac_x_cbtecble.ct_IdEmpresa, Info_Fac_x_cbtecble.ct_IdTipoCbte, Info_Fac_x_cbtecble.ct_IdCbteCble);

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void Llamar_a_pantalla_subcentro()
        {
            try
            {


                fa_factura_det_info Row = (fa_factura_det_info)gridView_Factura.GetRow(rowHandle);
                if (Row != null)
                {
                    if (Row.IdCentroCosto != null)
                    {
                        List<ct_centro_costo_sub_centro_costo_Info> Lista_subcentro_consulta = new List<ct_centro_costo_sub_centro_costo_Info>();
                        Lista_subcentro_consulta = list_subcentro_combo.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == Row.IdCentroCosto).ToList();
                        if (Lista_subcentro_consulta != null && Lista_subcentro_consulta.Count != 0)
                        {
                            frmCon_ct_centro_costo_sub_centro_costo_Cons frm_combo = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                            frm_combo.Set_config_combo(Lista_subcentro_consulta);
                            frm_combo.ShowDialog();
                            info_subcentro = frm_combo.Get_info_centro_sub_centro_costo();
                            gridView_Factura.SetRowCellValue(rowHandle, Col_IdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdRegistro);
                            //gridViewIngreso.SetRowCellValue(RowHandle, col_IdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_subcentrocosot_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_a_pantalla_subcentro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
