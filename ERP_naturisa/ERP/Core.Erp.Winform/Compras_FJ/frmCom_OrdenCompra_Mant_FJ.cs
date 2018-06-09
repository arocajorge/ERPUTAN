using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.General;
using Core.Erp.Winform.Inventario;

using Core.Erp.Info.General;
using Core.Erp.Info.Compras;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Inventario;


using Core.Erp.Business.General;
using Core.Erp.Business.Compras;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using Cus.Erp.Reports.Naturisa.Compras;
using System.Diagnostics;
using Cus.Erp.Reports.FJ.Compras;
using Cus.Erp.Reports.CAH.Compras;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace Core.Erp.Winform.Compras_FJ
{
    public partial class frmCom_OrdenCompra_Mant_FJ : Form
    {
        #region variables

        int RowHandle = 0;
        string MensajeError = "";
       
        in_Producto_Info Item = new in_Producto_Info();

        //orden de compra
        com_ordencompra_local_Info Info_OC = new com_ordencompra_local_Info();
        BindingList<com_ordencompra_local_det_Info> BindingList_OC_det = new BindingList<com_ordencompra_local_det_Info>();
        com_ordencompra_local_Bus Bus_OC = new com_ordencompra_local_Bus();
        com_ordencompra_local_det_Bus Bus_det_OC = new com_ordencompra_local_det_Bus();

        // Bus        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        com_TerminoPago_Info Info_TerminoPago = new com_TerminoPago_Info();
        com_TerminoPago_Bus BusTermPago = new com_TerminoPago_Bus();
        com_Catalogo_Bus Catalogo_bus = new com_Catalogo_Bus();
        com_parametro_Bus Bus_ParamCompra = new com_parametro_Bus();
        com_departamento_Bus Bus_Depart = new com_departamento_Bus();

        in_producto_Bus Bus_Producto = new in_producto_Bus();
        List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();



        com_comprador_Bus bus_Comprador = new com_comprador_Bus();
        ct_punto_cargo_Bus bus_puntoCargo = new ct_punto_cargo_Bus();

        cp_proveedor_Info Info_proveedor = new cp_proveedor_Info();
        cp_proveedor_Bus bus_proveedor = new cp_proveedor_Bus();


        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();
        ct_Centro_costo_Info Info_CentroCosto = new ct_Centro_costo_Info();

        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        List<ct_centro_costo_sub_centro_costo_Info> List_SubCentro = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info Info_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Info();

        com_Motivo_Orden_Compra_Bus bus_Motivo = new com_Motivo_Orden_Compra_Bus();


        com_estado_cierre_Bus Bus_estado_cierre = new com_estado_cierre_Bus();
        List<com_estado_cierre_Info> list_estadoCierre = new List<com_estado_cierre_Info>();

        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();
        // Listas        
        List<com_TerminoPago_Info> LstTermPago = new List<com_TerminoPago_Info>();

        List<tb_persona_Info> PersonaList = new List<tb_persona_Info>();
        List<com_comprador_Info> CompradorList = new List<com_comprador_Info>();
        List<ct_punto_cargo_Info> listPuntoCargo = new List<ct_punto_cargo_Info>();
        ct_punto_cargo_Info Info_punto_cargo = new ct_punto_cargo_Info();

        ct_punto_cargo_grupo_Bus BusPunto_Cargo_grupo = new ct_punto_cargo_grupo_Bus();
        List<ct_punto_cargo_grupo_Info> listaPuntoCargo_grupo = new List<ct_punto_cargo_grupo_Info>();

        List<com_Motivo_Orden_Compra_Info> listMotivo = new List<com_Motivo_Orden_Compra_Info>();
        List<com_departamento_Info> ListDepartamento = new List<com_departamento_Info>();


        ///

        List<tb_sis_impuesto_Info> listTipoImpu_x_Iva = new List<tb_sis_impuesto_Info>();



        //Variables 

        private Cl_Enumeradores.eTipo_action Accion;

        //banderas
        bool flag_descuento = false;
        bool flag_por_descuento = true;
        bool flag_precioFinal = false;



        double base0 = 0;
        double base12 = 0;
        double descuento = 0;
        double iva = 0;
        decimal idordenCompra = 0;

        double Descuento = 0;
        double Porc_Descuento = 0;

        //List<com_solicitud_compra_det_Info> ListaGrid;
        //List<com_solicitud_compra_det_Info> ListDetSolCom = new List<com_solicitud_compra_det_Info>();

        //string desc_producto = "";

        //List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info> listCompxSolici = new List<com_ordencompra_local_det_x_com_solicitud_compra_det_Info>();
        //List<com_solicitud_compra_det_Info> listDetSoli = new List<com_solicitud_compra_det_Info>();
        //com_ordencompra_local_det_x_com_solicitud_compra_det_Bus bus_DetxSol = new com_ordencompra_local_det_x_com_solicitud_compra_det_Bus();


        public delegate void delegate_frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmCom_OrdenCompra_Mant_FormClosing event_frmCom_OrdenCompra_Mant_FormClosing;

        #endregion

        public frmCom_OrdenCompra_Mant_FJ()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            event_frmCom_OrdenCompra_Mant_FormClosing += frmCom_OrdenCompra_Mant_event_frmCom_OrdenCompra_Mant_FormClosing;
            ucCp_Proveedor1.event_cmb_proveedor_EditValueChanged += ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged;
        }

        void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cp_proveedor_Info info = new cp_proveedor_Info();

                info = ucCp_Proveedor1.get_ProveedorInfo();

                if (info != null)
                {
                    if (info.pr_estado == "I")
                    {
                        ucCp_Proveedor1.Inicializar_cmbProveedor();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frmCom_OrdenCompra_Mant_event_frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void LoadProductos()
        {
            try
            {
                Lista_producto = Bus_Producto.Get_list_Producto_modulo_x_compra(param.IdEmpresa, cmbSucursal.get_SucursalInfo().IdSucursal);
                cmbProductoCodigo.DataSource = Lista_producto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Cargar_Combos()
        {
            try
            {
                string estadoAprob = "";
                List<com_Catalogo_Info> listEstaAprob = new List<com_Catalogo_Info>();
                listEstaAprob = Catalogo_bus.Get_ListEstadoAprobacion();
                cmbEstadoAprob.Properties.DataSource = listEstaAprob;
                cmbEstadoAprob.EditValue = "xAPRO";
                com_parametro_Info InfoComDev = new com_parametro_Info();
                InfoComDev = Bus_ParamCompra.Get_Info_parametro(param.IdEmpresa);
                estadoAprob = InfoComDev.IdEstadoAprobacion_OC;
                cmbEstadoAprob.EditValue = estadoAprob;
                /*
                if (Info_OC.IdSucursal == null || Info_OC.IdSucursal == 0)
                    cmbSucursal.Incializar_cmbsucursal();
                */
                
                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;

                listPuntoCargo = bus_puntoCargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_puntoCargo.DataSource = listPuntoCargo;
                cmb_puntoCargo.ValueMember = "IdPunto_cargo";
                cmb_puntoCargo.DisplayMember = "nom_punto_cargo";

                Bus_CentroCosto = new ct_Centro_costo_Bus();
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto.DataSource = list_centroCosto;

                List_SubCentro = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentroCosto.DataSource = List_SubCentro;
                cmb_subcentroCosto.ValueMember = "IdCentroCosto_sub_centro_costo";
                cmb_subcentroCosto.DisplayMember = "Centro_costo"; 

                

                listaPuntoCargo_grupo = BusPunto_Cargo_grupo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_grupo_punto_cargo.DataSource = listaPuntoCargo_grupo;

                string sEstadoCierre = "";

                sEstadoCierre = InfoComDev.IdEstado_cierre;

                list_estadoCierre = Bus_estado_cierre.Get_List_estado_cierre();
                cmb_estado_cierre.Properties.DataSource = list_estadoCierre;
                cmb_estado_cierre.EditValue = list_estadoCierre.FirstOrDefault(v => v.IdEstado_cierre == sEstadoCierre).IdEstado_cierre;


                tb_sis_impuesto_Bus Bus_sis_impuesto = new tb_sis_impuesto_Bus();
                listTipoImpu_x_Iva = Bus_sis_impuesto.Get_List_impuesto_para_Compras("IVA");
                cmbTipoImpuesto1.DataSource = listTipoImpu_x_Iva;

                LoadProductos();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Eventos Click del Menu Grabar ,Anular Salir Limpiar

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                Anular();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Accion_Grabar())
                {
                    LimpiarDatos();
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                    set_Accion_In_Controls();
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void frmCom_OrdenCompra_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        colIdCentroCosto.Visible = false;
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        colIdCentroCosto.Visible = false;
                        col_grupo_punto_cargo.Visible = false;
                        break;

                    default:
                        break;
                }

                gridControlOrdenCompra.DataSource = BindingList_OC_det;
                Cargar_Combos();
                if (Accion == null || Accion == 0)
                {
                    Accion = Cl_Enumeradores.eTipo_action.grabar;
                }
                set_Accion_In_Controls();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Set & Get

        public void Set_Info(com_ordencompra_local_Info _Info_OC)
        {
            Info_OC = _Info_OC;
        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action _Accion)
        {
            Accion = _Accion;
        }

        private void setInfo_In_Controls()
        {
            try
            {
                

                idordenCompra = Info_OC.IdOrdenCompra;

                txeFlete.EditValue = Convert.ToDouble(Info_OC.oc_flete);
                txtIdOC.Text = Convert.ToString(Info_OC.IdOrdenCompra);
                txtNumOC.Text = Info_OC.oc_NumDocumento;
                txtPlazo.Text = Convert.ToString(Info_OC.oc_plazo);
                txtObservacion.Text = Info_OC.oc_observacion;
                cmbSucursal.set_SucursalInfo(Info_OC.IdSucursal);
                ucCp_Proveedor1.set_ProveedorInfo(Info_OC.IdProveedor);
                
                

                ucCom_TerminoPagoCmb1.set_TermPagoInfo(Info_OC.IdTerminoPago);
                cmb_estado_cierre.EditValue = Info_OC.IdEstado_cierre;
                if (Info_OC.IdMotivo!=null) cmbMotivo.set_MotivoCompra(Convert.ToInt32(Info_OC.IdMotivo));
                cmbEstadoAprob.EditValue = Info_OC.IdEstadoAprobacion_cat;
                ucCom_Comprador1.set_CompradorInfo(Info_OC.IdComprador);
                cmbDepartamento.set_DepartamentoInfo(Convert.ToDecimal(Info_OC.IdDepartamento));
                dtpFechaEntrega.Value = Info_OC.oc_fechaVencimiento;
                dTPFecha.Value = Convert.ToDateTime(Info_OC.oc_fecha);
                if (Info_OC.Estado == "I")
                {
                    lblanulado.Visible = true;
                }
                BindingList_OC_det = new BindingList<com_ordencompra_local_det_Info>(Bus_det_OC.Get_List_ordencompra_local_det(param.IdEmpresa, cmbSucursal.get_SucursalInfo().IdSucursal, Convert.ToInt32(Info_OC.IdOrdenCompra)));
                gridControlOrdenCompra.DataSource = BindingList_OC_det;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_Accion_In_Controls()
        {
            try
            {

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        this.colIco1.Visible = false;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        cmbSucursal.Enabled = false;
                        
                        setInfo_In_Controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        txtIdOC.Enabled = false;
                        txtNumOC.Enabled = false;



                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                        //Inhabilita_Controles();

                        setInfo_In_Controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:

                        ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Visible_bntAnular = true;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        Inhabilita_Controles();
                        setInfo_In_Controls();



                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool Get_Info_OC()
        {
            try
            {
                Info_OC.IdEmpresa = param.IdEmpresa;
                Info_OC.IdSucursal = cmbSucursal.get_SucursalInfo().IdSucursal;
                Info_OC.IdProveedor = ucCp_Proveedor1.get_ProveedorInfo().IdProveedor;
                Info_OC.IdTerminoPago = ucCom_TerminoPagoCmb1.get_TermPagoInfo().IdTerminoPago;
                Info_OC.oc_NumDocumento = txtNumOC.Text;
                Info_OC.oc_observacion = txtObservacion.Text;
                txtObservacion.Focus();
                Info_OC.oc_plazo = Convert.ToInt32((txtPlazo.Text == "") ? 0 : Convert.ToInt32(txtPlazo.Text));
                Info_OC.oc_flete = Convert.ToDouble(txeFlete.EditValue);
                Info_OC.oc_fecha = Convert.ToDateTime(dTPFecha.Value.ToShortDateString());
                Info_OC.IdComprador = ucCom_Comprador1.get_CompradorInfo().IdComprador;
                Info_OC.IdDepartamento = (cmbDepartamento.Get_Info_Departamento() == null) ? 0 : cmbDepartamento.Get_Info_Departamento().IdDepartamento;
                Info_OC.oc_fechaVencimiento = Convert.ToDateTime(dtpFechaEntrega.Value.ToShortDateString());
                if (cmbMotivo.get_MotivoCompra() != null) Info_OC.IdMotivo = cmbMotivo.get_MotivoCompra().IdMotivo; else Info_OC.IdMotivo = null;
                Info_OC.IdEstado_cierre = Convert.ToString(cmb_estado_cierre.EditValue);
                Info_OC.IdEstadoAprobacion_cat = Convert.ToString(cmbEstadoAprob.EditValue);
                Info_OC.IdUsuario = param.IdUsuario;

                Info_OC.listDetalle = new List<com_ordencompra_local_det_Info>();
                foreach (var item in BindingList_OC_det)
                {

                   

                    

                    Info_OC.listDetalle.Add(item);
                }



                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_OC.IdEstadoRecepcion_cat = "PEN";
                }

                return  true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Acciones Grabar modificar Anular limpiar ,Imprimir

        void Imprimir()
        {
            try
            {
                int idEmpresa = 0;
                int idSucursal = 0;
                decimal IdOrdenCompra = 0;
              
                idEmpresa = param.IdEmpresa;
                idSucursal = cmbSucursal.get_SucursalInfo().IdSucursal;
                IdOrdenCompra = Convert.ToDecimal(txtIdOC.Text);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XCOMP_NATU_Rpt007_Rpt Reporte_Natu = new XCOMP_NATU_Rpt007_Rpt();
                        Reporte_Natu.RequestParameters = false;
                        ReportPrintTool pt_Natu = new ReportPrintTool(Reporte_Natu);
                        pt_Natu.AutoShowParametersPanel = false;
                        Reporte_Natu.PIdEmpresa.Value = idEmpresa;
                        Reporte_Natu.PIdSucursal.Value = idSucursal;
                        Reporte_Natu.PIdOrdenCompra.Value = IdOrdenCompra;
                        Reporte_Natu.ShowPreviewDialog();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:                        
                        XCOMP_FJ_Rpt001_Rpt Reporte_FJ = new XCOMP_FJ_Rpt001_Rpt();
                        Reporte_FJ.RequestParameters = false;
                        ReportPrintTool pt_FJ = new ReportPrintTool(Reporte_FJ);
                        pt_FJ.AutoShowParametersPanel = false;
                        Reporte_FJ.LlenarReporte(idEmpresa, idSucursal, IdOrdenCompra);
                        Reporte_FJ.ShowPreviewDialog();
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        XCOMP_CAH_Rpt001_Rpt Reporte_CAH = new XCOMP_CAH_Rpt001_Rpt();
                        Reporte_CAH.RequestParameters = false;
                        ReportPrintTool pt_CAH = new ReportPrintTool(Reporte_CAH);
                        Reporte_CAH.set_parametros(idEmpresa, idSucursal, IdOrdenCompra, Info_OC.Estado);
                        Reporte_CAH.ShowPreviewDialog();
                        break;
                    default:
                        XCOMP_Rpt001_Rpt Reporte_general = new XCOMP_Rpt001_Rpt();
                        Reporte_general.RequestParameters = false;
                        ReportPrintTool pt_general = new ReportPrintTool(Reporte_general);
                        pt_general.AutoShowParametersPanel = false;
                        Reporte_general.IdEmpresa.Value = idEmpresa;
                        Reporte_general.IdSucursal.Value = idSucursal;
                        Reporte_general.IdOrdenCompra.Value = IdOrdenCompra;
                        Reporte_general.ShowPreviewDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean Accion_Grabar()
        {

            try
            {
                txtObservacion.Focus();
                Boolean respuesta = false;
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:                        
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.TALME:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        int contador = 0;
                        contador = BindingList_OC_det.Where(q => q.IdCentroCosto == null).Count(); 
                        if (contador != 0)
                        {
                        if (MessageBox.Show("Existen registros sin centro de costo asignado, ¿Desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        return false;
                        }
                        break;
                    default:
                        break;
                }
                
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        respuesta = Grabar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        respuesta = Modificar();
                        break;
                    default:
                        break;
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean Grabar()
        {
            Boolean Respuesta = false;
            try
            {
                decimal id = 0;

                if (validaciones())
                {
                  if(! Get_Info_OC())
                  return false;

                    Respuesta = Bus_OC.GuardarDB(Info_OC, ref id, ref MensajeError);

                    if (Respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Orden de Compra " + Info_OC.IdOrdenCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdOC.Text = Convert.ToString(id);
                        Info_OC.IdOrdenCompra = id;
                        setInfo_In_Controls();

                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Desea_Imprimir), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Imprimir();
                        }
                        LimpiarDatos();
                    }
                }

                return Respuesta;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Respuesta;
            }
        }

        private Boolean Modificar()
        {
            Boolean respuesta = false;

            try
            {

                Get_Info_OC();
                Info_OC.IdUsuarioUltMod = param.IdUsuario;
                Info_OC.Fecha_UltMod = DateTime.Now;

                if (validaciones())
                {

                    respuesta = Bus_OC.ModificarDB(Info_OC, ref  MensajeError);

                    if (respuesta)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_modifico_corrrectamente) + " la Orden de Compra " + Info_OC.IdOrdenCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error Modificar" + MensajeError, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return respuesta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return respuesta;
            }
        }

        private void Anular()
        {
            try
            {
                if (Info_OC != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (Info_OC.Estado == "A" && Info_OC.IdEstadoRecepcion_cat != "REC")
                    {
                        if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + " /reprobar y reversar la Orden de Compra N#: " + Info_OC.oc_NumDocumento + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();
                            Info_OC.oc_observacion = "***ANULADO****" + Info_OC.oc_observacion;
                            Info_OC.MotivoAnulacion = oFrm.motivoAnulacion;
                            Info_OC.IdUsuarioUltAnu = param.IdUsuario;
                            Info_OC.FechaHoraAnul = DateTime.Now;

                            Info_OC.oc_observacion = "***ANULADO****" + Info_OC.oc_observacion;
                            if (Bus_OC.ReversarOC(Info_OC, ref msg))
                            {
                                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Se_guardo_correctamente) + " la Orden de Compra " + Info_OC.IdOrdenCompra, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Info_OC.Estado = "I";
                                ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;
                                lblanulado.Visible = true;
                            }
                        }
                    }
                    else if (Info_OC.Estado == "I")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la Orden de Compra N#: " + Info_OC.oc_NumDocumento +
                             ", " + param.Get_Mensaje_sys(enum_Mensajes_sys.Ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (Info_OC.IdEstadoRecepcion_cat == "REC")
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + " la Orden de Compra N#: " + Info_OC.oc_NumDocumento +
                            ", ya ha sido recibida.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LimpiarDatos()
        {
            try
            {
                Info_OC = new com_ordencompra_local_Info();
                BindingList_OC_det = new BindingList<com_ordencompra_local_det_Info>();

                gridControlOrdenCompra.DataSource = BindingList_OC_det;
                txtNumOC.Text = "";
                txtObservacion.Text = "";
                txtObservacion.Focus();
                txtPlazo.Text = "";
                txeFlete.EditValue = 0;
                cmbSucursal.Enabled = true;
                //cmbSucursal.set_SucursalInfo(0);
                ucCp_Proveedor1.set_ProveedorInfo(0);
                ucCom_TerminoPagoCmb1.set_TermPagoInfo("");
                
                //cmbEstadoAprob.EditValue = null;
                //cmb_estado_cierre.EditValue = null;
                cmbMotivo.set_MotivoCompra(0);
                Cargar_Combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private Boolean validaciones()
        {
            try
            {

                if (Bus_OC.VerificarCodigo(txtNumOC.Text.Trim(), param.IdEmpresa, cmbSucursal.get_SucursalInfo().IdSucursal, idordenCompra))
                {
                    MessageBox.Show("El Codigo Ingresado ya existe por favor ingrese uno diferente ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else if (txeFlete.EditValue == string.Empty)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Flete ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txeFlete.Focus(); return false;
                }
                else if (ucCom_TerminoPagoCmb1.get_TermPagoInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_) + param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Termino de Pago ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCom_TerminoPagoCmb1.Focus(); return false;
                }
                else if (cmbSucursal.get_SucursalInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_sucursal), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    cmbSucursal.Focus(); return false;
                }
                else if (ucCp_Proveedor1.get_ProveedorInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_proveedor), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCp_Proveedor1.Focus(); return false;
                }


                else if (cmbDepartamento.Get_Info_Departamento() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Departamento ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbDepartamento.Focus(); return false;
                }

                else if (ucCom_Comprador1.get_CompradorInfo() == null)
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Comprador ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucCom_Comprador1.Focus(); return false;
                }

                else if (txtObservacion.Text == "")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " Observación ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservacion.Focus(); return false;
                }
                else
                    /*if (cmbMotivo.get_MotivoCompra() == null)
                    {
                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " Motivo de Orden de Compra ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cmbMotivo.Focus(); return false;
                    }
                    else*/

                    

                        if (BindingList_OC_det.Count != 0)
                        {
                            int focus = gridViewOrdenCompra.FocusedRowHandle;
                            gridViewOrdenCompra.FocusedRowHandle = focus + 1;

                            foreach (var item in BindingList_OC_det)
                            {

                                if (item.IdProducto == 0)
                                {
                                     MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " producto ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                if (item.do_Cantidad == 0)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_la) + " cantidad para el Item : " + item.IdProducto + "  ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                if (item.do_precioCompra == 0)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_Favor_ingrese_el) + " costo para el Item : " + item.IdProducto + "  ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.FJ)
                                {
                                    in_Producto_Info info_prod = Lista_producto.Where(v => v.IdProducto == item.IdProducto).FirstOrDefault();
                                    if (info_prod != null)
                                    {
                                        if (info_prod.IdProductoTipo == 2 && item.IdPunto_cargo == null)
                                        {
                                            if (MessageBox.Show("El servicio " + info_prod.pr_descripcion_2 + " no tiene punto de cargo asignado, ¿Está seguro que desea continuar?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) 
                                            return false;
                                        }
                                    }
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Debe_escojer) + " al menos un item por orden de compra", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
               
                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.COMP, Convert.ToDateTime(dTPFecha.Value)))
                    return false;


                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Inhabilita_Controles()
        {
            try
            {
                this.txtIdOC.Enabled = false;
                this.txtIdOC.BackColor = System.Drawing.Color.White;
                this.txtIdOC.ForeColor = System.Drawing.Color.Black;

                this.txtNumOC.Enabled = false;
                this.txtNumOC.BackColor = System.Drawing.Color.White;
                this.txtNumOC.ForeColor = System.Drawing.Color.Black;

                this.dTPFecha.Enabled = false;

                this.ucCom_TerminoPagoCmb1.Enabled = false;
                this.ucCom_TerminoPagoCmb1.BackColor = System.Drawing.Color.White;
                this.ucCom_TerminoPagoCmb1.ForeColor = System.Drawing.Color.Black;

                this.ucCp_Proveedor1.Enabled = false;
                this.ucCp_Proveedor1.BackColor = System.Drawing.Color.White;
                this.ucCp_Proveedor1.ForeColor = System.Drawing.Color.Black;

                this.cmb_estado_cierre.Enabled = false;
                this.cmb_estado_cierre.BackColor = System.Drawing.Color.White;
                this.cmb_estado_cierre.ForeColor = System.Drawing.Color.Black;

                this.cmbMotivo.Enabled = false;
                this.cmbMotivo.BackColor = System.Drawing.Color.White;
                this.cmbMotivo.ForeColor = System.Drawing.Color.Black;

                this.cmbDepartamento.Enabled = false;
                this.cmbDepartamento.BackColor = System.Drawing.Color.White;
                this.cmbDepartamento.ForeColor = System.Drawing.Color.Black;

                this.ucCom_Comprador1.Enabled = false;
                this.ucCom_Comprador1.BackColor = System.Drawing.Color.White;
                this.ucCom_Comprador1.ForeColor = System.Drawing.Color.Black;

                this.txtPlazo.Enabled = false;
                this.txtPlazo.BackColor = System.Drawing.Color.White;
                this.txtPlazo.ForeColor = System.Drawing.Color.Black;

                this.txeFlete.Enabled = false;
                this.txeFlete.BackColor = System.Drawing.Color.White;
                this.txeFlete.ForeColor = System.Drawing.Color.Black;

                this.txtObservacion.Enabled = false;
                this.txtObservacion.BackColor = System.Drawing.Color.White;
                this.txtObservacion.ForeColor = System.Drawing.Color.Black;

                gridViewOrdenCompra.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_sucursal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProductos();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.ToString() == "46")
            {
                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular), param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridViewOrdenCompra.DeleteSelectedRows();
                }
            }
        }

        private void gridViewOrdenCompra_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                double subtotal = 0;
                double iva = 0;

                if (e.Column == colDescuento)
                {
                    flag_descuento = true;
                }

                if (e.Column.Name == colIdCod_Impuesto.Name)
                {

                }


                if (e.Column.Name == "ColNew")
                {

                    if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCodigo_Producto)) == 0)
                    {

                        llamarFormulario_Producto();

                    }
                    else
                    {
                        return;
                    }

                }





            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCom_OrdenCompra_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmCom_OrdenCompra_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void llamarFormulario_Producto()
        {
            try
            {
                FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();
                frm.ShowDialog();
                LoadProductos();
                frm.disposed();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

            try
            {
                if (e.FocusedColumn == colDescuento)
                {
                    flag_descuento = true;
                    flag_por_descuento = false;
                    flag_precioFinal = true;
                }
                else
                    if (e.FocusedColumn == colPorc_Descuento)
                    {
                        flag_por_descuento = true;
                        flag_descuento = false;
                        flag_precioFinal = true;
                    }
                    else
                    {
                        flag_por_descuento = false;
                        flag_descuento = false;
                        flag_precioFinal = false;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(gridViewOrdenCompra.GetFocusedRowCellValue(colIdProducto)) == 0)
                { return; }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                com_ordencompra_local_det_Info fila_OC_det = new com_ordencompra_local_det_Info();
                fila_OC_det = (com_ordencompra_local_det_Info)gridViewOrdenCompra.GetFocusedRow();

                double precio = 0;
                double cantidad = 0;
                double PrecioFinal = 0;
                double subtotal = 0;
                double Iva = 0;
                double Por_Iva = 0;
                double Total = 0;
                int cont = 0;


                if (fila_OC_det != null)
                {
                    if (fila_OC_det.IdPunto_cargo != 0 && !String.IsNullOrEmpty(Convert.ToString(fila_OC_det.IdCentroCosto)))
                    {
                        cont = BindingList_OC_det.Where(q => q.IdProducto == fila_OC_det.IdProducto && q.IdPunto_cargo == fila_OC_det.IdPunto_cargo && q.IdCentroCosto == fila_OC_det.IdCentroCosto).Count();
                    }
                }



                if (e.Column.Name == "colIdUnidadMedida")
                {
                    if (Convert.ToDecimal(gridViewOrdenCompra.GetFocusedRowCellValue(colIdProducto)) == 0)
                    {
                        gridViewOrdenCompra.DeleteSelectedRows();
                        return;
                    }
                }

                if (e.Column.Name == colCodigo_Producto.Name)
                {
                    Item = Lista_producto.First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                    gridViewOrdenCompra.SetFocusedRowCellValue(colIdProducto, Item.IdProducto);
                    gridViewOrdenCompra.SetFocusedRowCellValue(colCantidad, 0);
                    gridViewOrdenCompra.SetFocusedRowCellValue(colPrecio, Item.pr_precio_publico);
                    gridViewOrdenCompra.SetFocusedRowCellValue(col_IdUnidadMedida, Item.IdUnidadMedida);

                    tb_sis_impuesto_Info Info_Imp_Iva = new tb_sis_impuesto_Info();
                    Info_Imp_Iva = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == Item.IdCod_Impuesto_Iva);

                    if (Info_Imp_Iva != null)
                    {
                        gridViewOrdenCompra.SetFocusedRowCellValue(colIdCod_Impuesto, Info_Imp_Iva.IdCod_Impuesto);
                    }

                }
                else
                {



                    if (e.Column.Name == colCantidad.Name || e.Column.Name == colPrecio.Name || e.Column.Name == colPorc_Descuento.Name
                        || e.Column.Name == colDescuento.Name || e.Column.Name == colIdCod_Impuesto.Name)
                    {
                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colCantidad, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad)) * -1);
                        }

                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colPrecio, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio)) * -1);
                        }

                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(colPorc_Descuento, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)) * -1);
                        }
                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)) > 100)
                        {
                            MessageBox.Show("El porcentaje no puede ser mayor al 100%", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridViewOrdenCompra.SetFocusedRowCellValue(colPorc_Descuento, 0);
                        }
                        if (Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colDescuento)) < 0)
                        {
                            gridViewOrdenCompra.SetFocusedRowCellValue(coldescripcion, Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colDescuento)) * -1);
                        }

                        precio = Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPrecio));
                        cantidad = Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colCantidad));

                        decimal idproducto = Convert.ToDecimal(gridViewOrdenCompra.GetFocusedRowCellValue(colIdProducto));

                        int secuencia = Convert.ToInt32(gridViewOrdenCompra.GetFocusedRowCellValue(colSecuencia));

                        Porc_Descuento = Math.Round(Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)), 6);
                        Descuento = Math.Round((Porc_Descuento * precio) / 100, 6);

                        if (flag_por_descuento)
                        {
                            if (e.Column.Name == colPorc_Descuento.Name)
                            {
                                Porc_Descuento = Math.Round(Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colPorc_Descuento)), 6);
                                Descuento = Math.Round((Porc_Descuento * precio) / 100, 6);
                                gridViewOrdenCompra.SetFocusedRowCellValue(colDescuento, Descuento);
                            }
                        }
                        else
                            if (flag_descuento)
                            {
                                if (e.Column.Name == colDescuento.Name)
                                {
                                    Descuento = Math.Round(Convert.ToDouble(gridViewOrdenCompra.GetFocusedRowCellValue(colDescuento)), 6);
                                    Porc_Descuento = Math.Round(((Descuento / precio) * 100), 6);
                                    gridViewOrdenCompra.SetFocusedRowCellValue(colPorc_Descuento, Porc_Descuento);
                                }
                            }


                        PrecioFinal = (precio - Descuento);
                        subtotal = (PrecioFinal * cantidad);
                        Iva = 0;
                        Por_Iva = 0;
                        Total = 0;




                        gridViewOrdenCompra.SetFocusedRowCellValue(colPrecioFinal, PrecioFinal);
                        gridViewOrdenCompra.SetFocusedRowCellValue(colSubtotal, subtotal);



                        tb_sis_impuesto_Info InfoTipoImpuesto = new tb_sis_impuesto_Info();
                        InfoTipoImpuesto = listTipoImpu_x_Iva.FirstOrDefault(v => v.IdCod_Impuesto == fila_OC_det.IdCod_Impuesto);

                        if (InfoTipoImpuesto != null)
                        {
                            Iva = ((subtotal * InfoTipoImpuesto.porcentaje) / 100);
                            Por_Iva = InfoTipoImpuesto.porcentaje;
                        }


                        gridViewOrdenCompra.SetFocusedRowCellValue(colIva, Iva);
                        gridViewOrdenCompra.SetFocusedRowCellValue(colPor_Iva, Por_Iva);


                        Total = subtotal + Iva;
                        gridViewOrdenCompra.SetFocusedRowCellValue(colTotal, Total);
                    }
                }



                if (e.Column == col_cmb_puntoC)
                {
                    switch (param.IdCliente_Ven_x_Default)
                    {
                        case Cl_Enumeradores.eCliente_Vzen.FJ:
                            if (fila_OC_det.IdPunto_cargo != 0 && fila_OC_det.IdPunto_cargo != null)
                            {
                                ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
                                ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
                                info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, Convert.ToInt32(fila_OC_det.IdPunto_cargo));
                                fila_OC_det.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                                fila_OC_det.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                                fila_OC_det.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                            }
                            else
                            {
                                fila_OC_det.IdPunto_cargo_grupo = null;
                                fila_OC_det.IdCentroCosto = null;
                                fila_OC_det.IdCentroCosto_sub_centro_costo = null;
                            }
                            break;
                        default:
                            break;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewOrdenCompra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewOrdenCompra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_unidad_medida_Click(object sender, EventArgs e)
        {
            try
            {
                lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
                decimal IdProducto = 0;
                IdProducto = Convert.ToDecimal(gridViewOrdenCompra.GetRowCellValue(RowHandle, colIdProducto));
                Item = Lista_producto.FirstOrDefault(q => q.IdProducto == IdProducto);
                lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida_equivalencia(Item.IdUnidadMedida);

                FrmIn_Unidad_Medida_Consu frm_combo = new FrmIn_Unidad_Medida_Consu();
                frm_combo.set_config_combo(lst_unidad_medida_para_combo);
                frm_combo.ShowDialog();
                info_unidad_medida = frm_combo.Get_info_unidad_medida();
                gridViewOrdenCompra.SetRowCellValue(RowHandle, col_IdUnidadMedida ,info_unidad_medida==null ? null : info_unidad_medida.IdUnidadMedida);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbPuntoCargo_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
        private void cmb_subcentroCosto_Click(object sender, EventArgs e)
        {
            try
            {
                com_ordencompra_local_det_Info row = (com_ordencompra_local_det_Info)gridViewOrdenCompra.GetRow(RowHandle);
                if (row != null)
                {
                    List<ct_centro_costo_sub_centro_costo_Info> Lista_subcentro_consulta = new List<ct_centro_costo_sub_centro_costo_Info>();
                    Lista_subcentro_consulta = List_SubCentro.Where(q => q.IdEmpresa == param.IdEmpresa && q.IdCentroCosto == row.IdCentroCosto).ToList();
                    if (Lista_subcentro_consulta != null && Lista_subcentro_consulta.Count != 0)
                    {
                        frmCon_ct_centro_costo_sub_centro_costo_Cons frm_combo = new frmCon_ct_centro_costo_sub_centro_costo_Cons();
                        frm_combo.Set_config_combo(Lista_subcentro_consulta);
                        frm_combo.ShowDialog();
                        Info_SubCentroCosto = frm_combo.Get_info_centro_sub_centro_costo();
                        gridViewOrdenCompra.SetRowCellValue(RowHandle, Col_suncentro, Info_SubCentroCosto == null ? null : Info_SubCentroCosto.IdRegistro);
                        //gridViewIngreso.SetRowCellValue(RowHandle, col_IdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
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

        private void cmbPuntoCargo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucCp_Proveedor1_event_cmb_proveedor_EditValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_proveedor = ucCp_Proveedor1.get_ProveedorInfo();
                    if (Info_proveedor != null)
                    {
                        txtPlazo.Text = Info_proveedor.pr_plazo.ToString();
                    }
                    else txtPlazo.Text = "0"; return;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void ucCom_TerminoPagoCmb1_event_cmbTermPago_EditValueChanged(object sender, EventArgs e)
        {
            try
            { 
                if( Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Info_TerminoPago = ucCom_TerminoPagoCmb1.get_TermPagoInfo();
                    if (Info_TerminoPago != null)
                    {
                        txtPlazo.Text = Info_TerminoPago.Dias.ToString();
                    }
                    else txtPlazo.Text = "0"; return;
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
