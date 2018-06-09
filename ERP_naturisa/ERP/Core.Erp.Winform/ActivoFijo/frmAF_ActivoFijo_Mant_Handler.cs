using Core.Erp.Business.ActivoFijo;
using Core.Erp.Business.ActivoFijo_FJ;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Roles;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.ActivoFijo_FJ;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Roles;
using Core.Erp.Reportes.ActivoFijo;
using Core.Erp.Winform.General;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Core.Erp.Winform.ActivoFijo
{
    public class frmAF_ActivoFijo_Mant_Handler
    {


        //#region Declaracion de controles
        //public System.Windows.Forms.GroupBox groupBox1;
        //public System.Windows.Forms.TabControl tab1;
        //public System.Windows.Forms.TabPage tabPage1;
        //public System.Windows.Forms.Label label10;
        //public System.Windows.Forms.Label label9;
        //public System.Windows.Forms.Label label2;
        //public System.Windows.Forms.Label lbl_id_activo;
        //public System.Windows.Forms.Label label1;
        //public System.Windows.Forms.Label lbl_title_id;
        //public System.Windows.Forms.GroupBox groupBox2;
        //public System.Windows.Forms.GroupBox groupBox4;
        //public System.Windows.Forms.TextBox txt_anio_fabrica;
        //public System.Windows.Forms.TextBox txt_num_placa;
        //public System.Windows.Forms.Label label18;
        //public System.Windows.Forms.Label label17;
        //public System.Windows.Forms.TextBox txt_observacion;
        //public System.Windows.Forms.Label label16;
        //public System.Windows.Forms.Label label15;
        //public System.Windows.Forms.Label label14;
        //public System.Windows.Forms.Label label13;
        //public System.Windows.Forms.Label label12;
        //public System.Windows.Forms.Label label11;
        //public System.Windows.Forms.DateTimePicker dtFecha_fin_depreciacion;
        //public System.Windows.Forms.DateTimePicker dtFecha_ini_depreciacion;
        //public System.Windows.Forms.DateTimePicker dtFechaCompra;
        //public System.Windows.Forms.Label label21;
        //public System.Windows.Forms.Label label20;
        //public System.Windows.Forms.Label label19;
        //public System.Windows.Forms.TextBox txt_nombre;
        //public System.Windows.Forms.CheckBox chk_estado;
        //public System.Windows.Forms.TextBox txt_codigo_activofijo;
        //public System.Windows.Forms.Label label25;
        //public System.Windows.Forms.TabPage tabPage3;
        //public System.Windows.Forms.Label label6;
        //public System.Windows.Forms.Label label5;
        //public System.Windows.Forms.Label label4;
        //public System.Windows.Forms.Label label3;
        //public Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        //public Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        //public DevExpress.XtraEditors.LabelControl lblEstado;
        //public System.Windows.Forms.TextBox txt_DescCorta;
        //public System.Windows.Forms.Label label26;
        //public System.Windows.Forms.Label label27;
        //public System.Windows.Forms.OpenFileDialog openFileDialog1;
        //public System.Windows.Forms.Label label30;
        //public System.Windows.Forms.TextBox txtBarra;
        //public System.Windows.Forms.TextBox txtParte;
        //public System.Windows.Forms.Label label29;
        //public System.Windows.Forms.Label label28;
        //public System.Windows.Forms.TabPage tabPage4;
        //public DevExpress.XtraGrid.GridControl gridContab;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridViewBancoParam;
        //public DevExpress.XtraGrid.Columns.GridColumn colTipo;
        //public DevExpress.XtraGrid.Columns.GridColumn ColCtaCble;
        //public DevExpress.XtraGrid.Columns.GridColumn colCcosto;
        //public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_ctacble;
        //public DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        //public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_centro_costo;
        //public DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        //public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit3;
        //public DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit3View;
        //public DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        //public DevExpress.XtraGrid.Columns.GridColumn IdTipoCuenta;
        //public DevExpress.XtraGrid.Columns.GridColumn colIdCtaCble;
        //public DevExpress.XtraGrid.Columns.GridColumn colpc_Cuenta;
        //public Controles.UCGe_Sucursal_combo ucGe_Sucursal_combo1;
        //public DevExpress.XtraEditors.TextEdit txtDescripTecnica;
        //public System.Windows.Forms.Label label31;
        //public System.Windows.Forms.TabPage tabPage5;
        //public System.Windows.Forms.Panel panel1;
        //public System.Windows.Forms.TabPage tabPage6;
        //public System.Windows.Forms.Panel panel2;
        //public System.Windows.Forms.Button btnVisualizar;
        //public System.Windows.Forms.DateTimePicker dtpFecUltDepreciacion;
        //public System.Windows.Forms.DateTimePicker dtpFechaMovimiento;
        //public DevExpress.XtraEditors.TextEdit txtDepreAnual;
        //public DevExpress.XtraEditors.TextEdit txtValorUltDepreciacion;
        //public DevExpress.XtraEditors.TextEdit txtTotalMejora;
        //public DevExpress.XtraEditors.TextEdit txtValorNeto;
        //public DevExpress.XtraEditors.TextEdit txtDepreAcumulada;
        //public DevExpress.XtraEditors.TextEdit txtTotalBajas;
        //public DevExpress.XtraEditors.TextEdit txtValorAdquisicion;
        //public DevExpress.XtraEditors.TextEdit txtPorDepreciacion;
        //public System.Windows.Forms.Label label42;
        //public System.Windows.Forms.Label label41;
        //public System.Windows.Forms.Label label40;
        //public System.Windows.Forms.Label label38;
        //public System.Windows.Forms.Label label37;
        //public System.Windows.Forms.Label label36;
        //public System.Windows.Forms.Label label35;
        //public System.Windows.Forms.Label label34;
        //public System.Windows.Forms.Label label33;
        //public System.Windows.Forms.Label label32;
        //public System.Windows.Forms.DateTimePicker dtpFecRetiro;
        //public System.Windows.Forms.DateTimePicker dtpFecVencimiento;
        //public System.Windows.Forms.DateTimePicker dtpFecVenta;
        //public System.Windows.Forms.DateTimePicker dtpFecPoliza;
        //public DevExpress.XtraEditors.TextEdit txtPoliza;
        //public DevExpress.XtraEditors.TextEdit txtValorVenta;
        //public DevExpress.XtraEditors.TextEdit txtValorPoliza;
        //public DevExpress.XtraEditors.LabelControl labelControl7;
        //public DevExpress.XtraEditors.LabelControl labelControl6;
        //public DevExpress.XtraEditors.LabelControl labelControl5;
        //public DevExpress.XtraEditors.LabelControl labelControl4;
        //public DevExpress.XtraEditors.LabelControl labelControl3;
        //public DevExpress.XtraEditors.LabelControl labelControl2;
        //public DevExpress.XtraEditors.LabelControl labelControl1;
        //public DevExpress.XtraEditors.TextEdit txt_porc_depreciacion;
        //public DevExpress.XtraEditors.TextEdit txt_meses_depreciar;
        //public DevExpress.XtraEditors.TextEdit txt_vida_util;
        //public DevExpress.XtraEditors.TextEdit txt_costo_historico;
        //public DevExpress.XtraEditors.TextEdit txt_costo_compra;
        //public System.Windows.Forms.Label label43;
        //public DevExpress.XtraEditors.SearchLookUpEdit cmb_tipo_activo_f;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        //public DevExpress.XtraEditors.SearchLookUpEdit cmbPeriodo;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        //public DevExpress.XtraEditors.SearchLookUpEdit cmb_TipoDepreciacion;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        //public DevExpress.XtraEditors.TextEdit txtValorSalvamento;
        //public System.Windows.Forms.Label label44;
        //public DevExpress.XtraEditors.TextEdit txtValorResidual;
        //public System.Windows.Forms.Label label39;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        //public System.Windows.Forms.PictureBox picFoto;
        //public DevExpress.XtraGrid.Columns.GridColumn colCentro_costo;
        //public DevExpress.XtraGrid.Columns.GridColumn colIdCentroCosto;
        //public DevExpress.XtraEditors.SimpleButton btnFactura_OC;
        //public System.Windows.Forms.TabPage tabPage2;
        //public DevExpress.XtraEditors.LabelControl labelControl11;
        //public DevExpress.XtraEditors.LabelControl labelControl10;
        //public DevExpress.XtraEditors.LabelControl labelControl9;
        //public DevExpress.XtraEditors.LabelControl labelControl8;
        //public Controles.UCGe_Sucursal_combo cmbSucursalOC;
        //public System.Windows.Forms.Label label22;
        //public DevExpress.XtraEditors.TextEdit txtCantidadOC;
        //public DevExpress.XtraEditors.TextEdit txtNumDocOC;
        //public DevExpress.XtraEditors.TextEdit txtSecuenciaOC;
        //public DevExpress.XtraEditors.TextEdit txtIdOC;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        //public System.Windows.Forms.SplitContainer splitContainer1;
        //public DevExpress.XtraEditors.GroupControl groupControl1;
        //public DevExpress.XtraEditors.GroupControl groupControl2;
        //public DevExpress.XtraEditors.LabelControl lblIdEmpresaOC;
        //public System.Windows.Forms.Label lblIdProducto;
        //public DevExpress.XtraEditors.LabelControl labelControl17;
        //public DevExpress.XtraEditors.LabelControl lblIdEmpresa_Ogiro;
        //public DevExpress.XtraEditors.LabelControl labelControl15;
        //public DevExpress.XtraEditors.LabelControl labelControl14;
        //public DevExpress.XtraEditors.LabelControl labelControl13;
        //public DevExpress.XtraEditors.LabelControl labelControl12;
        //public DevExpress.XtraEditors.LabelControl labelControl18;
        //public DevExpress.XtraEditors.LabelControl labelControl16;
        //public DevExpress.XtraEditors.TextEdit txtTotalOC;
        //public DevExpress.XtraEditors.TextEdit txtIvaOC;
        //public DevExpress.XtraEditors.TextEdit txtSubtotalOC;
        //public DevExpress.XtraEditors.TextEdit txtCostoOC;
        //public DevExpress.XtraEditors.TextEdit txtTipoOG;
        //public DevExpress.XtraEditors.TextEdit txtIdTipoOG;
        //public DevExpress.XtraEditors.TextEdit txtIdOrdenGiro;
        //public Controles.UCAF_Catalogos cmbColor;
        //public Controles.UCAF_Catalogos cmbModelo;
        //public Controles.UCAF_Catalogos cmbMarca;
        //public Controles.UCCp_Proveedor cmbProveedor;
        //public System.Windows.Forms.Label label24;
        //public System.Windows.Forms.Label label23;
        //public DevExpress.XtraEditors.TextEdit txt_num_serie;
        //public DevExpress.XtraEditors.TextEdit txtSerieChasis;
        //public DevExpress.XtraEditors.TextEdit txtSerieMotor;
        //public DevExpress.XtraEditors.SearchLookUpEdit cmbCategoriaAF;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        //public DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        //public System.Windows.Forms.Label label45;
        //public Controles.UCAf_Encargado ucAf_Encargado;
        //public DevExpress.XtraGrid.Columns.GridColumn colpc_clave_corta;
        //public DevExpress.XtraGrid.Columns.GridColumn colEstado;
        //public DevExpress.XtraGrid.Columns.GridColumn colpc_Estado;
        //public Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //public Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        //public System.Windows.Forms.TabPage tabPage7;
        //public System.Windows.Forms.Panel panel3;
        //public System.Windows.Forms.ToolStrip toolStrip1;
        //public System.Windows.Forms.ToolStripButton toolStripButtonRefrescar;
        //public System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        //public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        //public System.Windows.Forms.ToolStripButton toolStripButtonNuevaUbi;
        //public System.Windows.Forms.GroupBox groupBox5;
        //public DevExpress.XtraGrid.GridControl gridcUbicacionActivo;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridvUbicacionActivo;
        //public System.Windows.Forms.GroupBox groupBox3;
        //public Controles.UCAf_DepartamentoCmb ucAf_Departamento;
        //public System.Windows.Forms.Label label8;
        //public Controles.UCAF_Catalogos cmbUbicacion;
        //public System.Windows.Forms.Label label7;
        //public DevExpress.XtraGrid.Columns.GridColumn colNombre;
        //public DevExpress.XtraGrid.Columns.GridColumn colUbicacionActual;
        //public DevExpress.XtraGrid.Columns.GridColumn colNombreDepatamento;
        //public DevExpress.XtraGrid.Columns.GridColumn ColCentroCostoActu;
        //public DevExpress.XtraGrid.Columns.GridColumn colFechacambio;
        //public DevExpress.XtraGrid.Columns.GridColumn ColIdCambioUbicacion;
        //public System.Windows.Forms.Label label47;
        //public System.Windows.Forms.Label label46;
        //public DevExpress.XtraEditors.TextEdit txtValorUnidad;
        //public Controles.UCAF_Catalogos cmb_Unidades;
        //public Controles.UCFa_Cliente_x_centro_costo_cmb ucFa_Cliente_x_centro_costo_cmb1;
        //public DevExpress.XtraEditors.SearchLookUpEdit cmb_Grupo;
        //public DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;

        //public DevExpress.XtraGrid.GridControl gridControl_Activos_Relacionado;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView_Activos_Relacionado;
        //public DevExpress.XtraGrid.Columns.GridColumn ColIdActivoFijo;
        //public DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion;
        //public DevExpress.XtraGrid.Columns.GridColumn Col_Descripcion_Tecnica;
        //public DevExpress.XtraGrid.Columns.GridColumn Col_codigo_activo_Relacionado;
        //public DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Activos_Relacionados;
        //public DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        //public DevExpress.XtraGrid.Columns.GridColumn ColCodActivoFijo_;
        //public DevExpress.XtraGrid.Columns.GridColumn ColAf_Nombre;
        //public DevExpress.XtraGrid.Columns.GridColumn Col_Af_DescripcionTecnica;
        //public DevExpress.XtraEditors.TextEdit txtCapacidad;
        //public DevExpress.XtraEditors.CheckEdit chkCarroceria;
        //public System.Windows.Forms.TabPage tabPageCamionesRelacionados;
        //#endregion

        //#region Declaracion de variables generales
        //tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //Cl_Enumeradores.eTipo_action _Accion;
        //#endregion

        //#region Declaración de Variables
        //string codActivoFijo = "";
        //string msg = "";
        //int id = 0;
        //string MensajeError = "";
        //int Id_Activo_Fijo = 0;
        //#endregion

        //#region Declaración de Info y Listas
        //List<tb_Sucursal_Info> lista_sucursal = new List<tb_Sucursal_Info>();

        //Af_Activo_fijo_Info Info_AF = new Af_Activo_fijo_Info();
        //Af_Activo_fijo_Bus Bus_AF = new Af_Activo_fijo_Bus();

        //ct_punto_cargo_Info info_Punto_cargo = new ct_punto_cargo_Info();
        //ct_punto_cargo_Bus bus_Punto_cargo = new ct_punto_cargo_Bus();


        //Af_Activo_fijo_x_ct_punto_cargo_Info info_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Info();
        //Af_Activo_fijo_x_ct_punto_cargo_Bus bus_af_x_pc = new Af_Activo_fijo_x_ct_punto_cargo_Bus();

        //Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info info_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Info();
        //Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus bus_af_x_cc = new Af_Activo_fijo_x_ct_centro_costo_sub_centro_costo_Bus();

        //List<Af_Activo_fijo_tipo_Info> lista_tipo_activo_fijo = new List<Af_Activo_fijo_tipo_Info>();


        //List<Af_Activo_fijo_CtasCbles_Info> listaGrid = new List<Af_Activo_fijo_CtasCbles_Info>();
        //List<Af_Activo_fijo_CtasCbles_Tipo_Info> listaTipoCble = new List<Af_Activo_fijo_CtasCbles_Tipo_Info>();

        //List<ct_Plancta_Info> List_PLanCta = new List<ct_Plancta_Info>();
        //List<Af_Departamento_Info> List_dpto = new List<Af_Departamento_Info>();
        //List<Af_Tipo_Depreciacion_Info> lista_depre = new List<Af_Tipo_Depreciacion_Info>();
        //List<Af_PeriodoDepreciacion_Info> lista_periodo = new List<Af_PeriodoDepreciacion_Info>();

        //cp_proveedor_Bus Bus_Proveedor = new cp_proveedor_Bus();
        //List<cp_proveedor_Info> List_Proveedor = new List<cp_proveedor_Info>();

        //List<vwAf_ActivoCtasCbles_Info> lstVwAf = new List<vwAf_ActivoCtasCbles_Info>();

        //List<in_UnidadMedida_Info> Lista_UnidadMedida = new List<in_UnidadMedida_Info>();
        //in_UnidadMedida_Bus bus_UnidadMedida = new in_UnidadMedida_Bus();

        //List<Af_Activo_fijo_Info> lista_activo_Fijo = new List<Af_Activo_fijo_Info>();

        //ro_Empleado_Bus BusEmple = new ro_Empleado_Bus();
        //List<ro_Empleado_Info> Lista_Empleado = new List<ro_Empleado_Info>();

        //Af_Catalogo_Bus BusCata = new Af_Catalogo_Bus();
        //List<Af_Catalogo_Info> List_Catalogo = new List<Af_Catalogo_Info>();
        //List<Af_Activo_fijo_Categoria_Info> List_Activo_Fijo_Categoria = new List<Af_Activo_fijo_Categoria_Info>();
        //Af_Activo_fijo_Categoria_Bus BusCategoria = new Af_Activo_fijo_Categoria_Bus();

        //vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info infoFactura_SinCruce = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();

        //List<vwAf_CambioUbicacion_Info> lstVwcambioubi_info = new List<vwAf_CambioUbicacion_Info>();
        //Af_CambioUbicacion_Activo_Bus busCambio = new Af_CambioUbicacion_Activo_Bus();


        //ct_centro_costo_sub_centro_costo_Info info_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Info();
        //ct_centro_costo_sub_centro_costo_Bus bus_sub_centro_costo = new ct_centro_costo_sub_centro_costo_Bus();

        //BindingList<Af_Activo_fijo_x_Af_Activo_fijo_Info> Lista_activos_relacionados = new BindingList<Af_Activo_fijo_x_Af_Activo_fijo_Info>();
        //Af_Activo_fijo_x_Af_Activo_fijo_Bus Activos_Relacionado_bus = new Af_Activo_fijo_x_Af_Activo_fijo_Bus();
        //Af_Activo_fijo_Info Activo_Fijo_Seleccionado_info = new Af_Activo_fijo_Info();

        //#endregion

        //Form FrmChildren;
        //Form FrmParent;
        //Cl_Enumeradores.eCliente_Vzen eCliente;
        //Boolean Crear_Subcentro = false;

        //public frmAF_ActivoFijo_Mant_Handler()
        //{
        //    if (eCliente == 0)
        //    {
        //        eCliente = Cl_Enumeradores.eCliente_Vzen.GENERAL;
        //    }
        //}

        //public void Set_FrmChildren(Form _FrmChildren)
        //{
        //    try
        //    {
        //        this.FrmChildren = _FrmChildren;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void Set_FrmParent(Form _FrmParent)
        //{
        //    try
        //    {
        //        this.FrmParent = _FrmParent;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void Set_eCliente(Cl_Enumeradores.eCliente_Vzen _eCliente)
        //{
        //    try
        //    {
        //        this.eCliente = _eCliente;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        LimpiarDatos();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        XACTF_Rpt009_rpt Reporte = new XACTF_Rpt009_rpt();
        //        XACTF_Rpt009_Bus busRpt = new XACTF_Rpt009_Bus();
        //        List<XACTF_Rpt009_Info> infoRpt = new List<XACTF_Rpt009_Info>();

        //        Reporte.RequestParameters = false;
        //        infoRpt = busRpt.get_CodigoBarra(param.IdEmpresa, Convert.ToInt32(lbl_id_activo.Text));
        //        Reporte.infoRpt = infoRpt;

        //        Reporte.CreateDocument();
        //        Reporte.ShowPreviewDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        FrmChildren.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (GuardarDatos())
        //        {
        //            FrmChildren.Close();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (GuardarDatos())
        //        {
        //            LimpiarDatos();
        //            _Accion = Cl_Enumeradores.eTipo_action.grabar;
        //            set_Accion_Controls();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Info_AF.IdActivoFijo != 0)
        //        {
        //            if (lblEstado.Visible == true)
        //            {
        //                MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema);
        //            }
        //            else
        //            {

        //                if (MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Esta_seguro_que_desea_anular) + Info_AF.Af_Nombre + " ?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                    FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
        //                    ofrm.ShowDialog();

        //                    Info_AF.IdUsuarioUltAnu = param.IdUsuario;
        //                    Info_AF.Fecha_UltAnu = DateTime.Now;
        //                    Info_AF.MotiAnula = ofrm.motivoAnulacion;

        //                    if (Info_AF.Estado == "A")
        //                    {
        //                        string msg = "";
        //                        Af_Activo_fijo_Bus bus_act_fij = new Af_Activo_fijo_Bus();
        //                        if (bus_act_fij.EliminarDB(Info_AF, ref msg))
        //                        {
        //                            lblEstado.Visible = true;
        //                            ucGe_Menu.Enabled_bntAnular = false;
        //                        }
        //                        MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.No_se_puede_anular) + Info_AF.Af_Nombre + param.Get_Mensaje_sys(enum_Mensajes_sys.Debido_q_ya_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }

        //                }

        //            }
        //        }
        //        else
        //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_item_a_anular), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private Boolean Guardar()
        //{
        //    try
        //    {

        //        string CodActivo = "";
        //        Boolean bolResult = false;
        //        if (Validar())
        //        {
        //            get_ActivoFijo();

        //            bolResult = Bus_AF.GrabarDB(Info_AF, ref id, ref CodActivo, ref msg);

        //            if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
        //            {
        //                if (bolResult)
        //                {
        //                    bolResult = Crear_Punto_cargo();
        //                }
        //            }

        //            if (bolResult)
        //            {
        //                lbl_id_activo.Text = Convert.ToString(id);
        //                txt_codigo_activofijo.Text = CodActivo;
        //                txtBarra.Text = (txtBarra.Text == "" || txtBarra.Text == null) ? CodActivo : txtBarra.Text;
        //                MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }

        //        }
        //        return bolResult;

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }

        //}

        //private Boolean Actualizar()
        //{
        //    try
        //    {
        //        Boolean bolResult = false;
        //        if (Validar())
        //        {
        //            get_ActivoFijo();

        //            Info_AF.IdUsuarioUltMod = param.IdUsuario;
        //            Info_AF.Fecha_UltMod = DateTime.Now;

        //            bolResult = Bus_AF.ModificarDB(Info_AF, ref msg);
        //            bolResult = Crear_Punto_cargo();
        //            if (bolResult)
        //            {
        //                bolResult = true;
        //                MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        return bolResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }

        //}

        //private Boolean Anular()
        //{

        //    try
        //    {

        //        Boolean bolResult = false;
        //        get_ActivoFijo();


        //        FrmGe_MotivoAnulacion frm = new FrmGe_MotivoAnulacion();
        //        frm.ShowDialog();
        //        Info_AF.MotiAnula = frm.motivoAnulacion;
        //        Info_AF.IdUsuarioUltAnu = param.IdUsuario;
        //        Info_AF.Fecha_UltAnu = DateTime.Now;
        //        bolResult = Bus_AF.EliminarDB(Info_AF, ref msg);

        //        if (bolResult)
        //        {
        //            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show(msg, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }





        //        return bolResult;

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }
        //}

        //public Boolean GuardarDatos()
        //{
        //    try
        //    {
        //        Boolean respuesta = false;

        //        switch (_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
        //                respuesta = Guardar();
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                respuesta = Actualizar();
        //                break;
        //        }

        //        return respuesta;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }
        //}

        //private void LimpiarDatos()
        //{
        //    try
        //    {
        //        Info_AF = new Af_Activo_fijo_Info();
        //        _Accion = Cl_Enumeradores.eTipo_action.grabar;
        //        set_Accion(_Accion);

        //        txtValorUnidad.Text = "";


        //        this.lbl_id_activo.Text = "";
        //        this.txt_codigo_activofijo.Text = "";
        //        this.txt_nombre.Text = "";
        //        cmbMarca.Inicializar_Catalogos();
        //        cmbModelo.Inicializar_Catalogos();
        //        txt_num_serie.EditValue = "";
        //        cmbColor.Inicializar_Catalogos();



        //        this.txt_costo_historico.Text = "0";
        //        this.txt_costo_compra.Text = "0";
        //        this.txt_observacion.Text = "";
        //        this.txt_num_placa.Text = "";
        //        this.txt_anio_fabrica.Text = "";
        //        chk_estado.Checked = true;
        //        this.txt_DescCorta.Text = "";
        //        this.txtParte.Text = "";
        //        this.txtBarra.Text = "";
        //        txtDescripTecnica.EditValue = "";

        //        txtValorPoliza.EditValue = "";
        //        txtValorVenta.EditValue = "";
        //        txtPoliza.EditValue = "";
        //        txtValorSalvamento.EditValue = "";
        //        txtValorResidual.EditValue = "";
        //        lblIdEmpresaOC.Text = "";
        //        lblIdProducto.Text = "";
        //        lblIdEmpresa_Ogiro.Text = "";
        //        txtNumDocOC.EditValue = "";
        //        txtCantidadOC.EditValue = "";
        //        txtCostoOC.EditValue = "";
        //        txtSubtotalOC.EditValue = "";
        //        txtIvaOC.EditValue = "";
        //        txtTotalOC.EditValue = "";
        //        txtIdOC.EditValue = "";
        //        txtSecuenciaOC.EditValue = "";
        //        txtIdOrdenGiro.EditValue = "";
        //        txtIdTipoOG.EditValue = "";
        //        txtTipoOG.EditValue = "";

        //        txtSerieChasis.EditValue = "";
        //        txtSerieMotor.EditValue = "";

        //        switch (eCliente)
        //        {
        //            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.FJ:
        //                ucFa_Cliente_x_centro_costo_cmb1.Inicializar_Combos();
        //                cmb_Unidades.Inicializar_Catalogos();
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
        //                cmbUbicacion.Inicializar_Catalogos();
        //                break;
        //            default:
        //                cmbUbicacion.Inicializar_Catalogos();
        //                break;
        //        }
        //        set_Accion_Controls();

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public Boolean Validar()
        //{
        //    try
        //    {
        //        txt_codigo_activofijo.Focus();


        //        if (this.txt_nombre.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese el nombre del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_nombre.Focus();
        //            return false;
        //        }

        //        if (this.ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
        //        {
        //            MessageBox.Show("Por favor escoja la sucursal donde se encuentra el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.ucGe_Sucursal_combo1.Focus();
        //            return false;
        //        }


        //        if (cmb_tipo_activo_f.EditValue == "" || cmb_tipo_activo_f.EditValue == null)
        //        {
        //            MessageBox.Show("Por favor escoja el Tipo de Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmb_tipo_activo_f.Focus();
        //            return false;
        //        }

        //        if (cmbCategoriaAF.EditValue == "" || cmbCategoriaAF.EditValue == null)
        //        {
        //            MessageBox.Show("Por favor escoja la Categoria del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmbCategoriaAF.Focus();
        //            return false;
        //        }


        //        if (cmb_TipoDepreciacion.EditValue == "" || cmb_TipoDepreciacion.EditValue == null)
        //        {
        //            MessageBox.Show("Por favor escoja el Tipo de Depreciacion", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmb_TipoDepreciacion.Focus();
        //            return false;
        //        }



        //        if (this.txt_costo_historico.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese el costo histórico del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_costo_historico.Focus();
        //            return false;
        //        }

        //        if (this.txt_costo_compra.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese el costo de compra del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_costo_compra.Focus();
        //            return false;
        //        }

        //        if (this.txt_vida_util.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese la vida útil del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_vida_util.Focus();
        //            return false;
        //        }

        //        if (this.txt_meses_depreciar.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese los meses a depreciar el Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_meses_depreciar.Focus();
        //            return false;
        //        }

        //        if (this.txt_porc_depreciacion.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese el % depreciación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_porc_depreciacion.Focus();
        //            return false;
        //        }

        //        if (this.txt_observacion.Text == "")
        //        {
        //            MessageBox.Show("Por favor ingrese la observación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.txt_observacion.Focus();
        //            return false;
        //        }

        //        if (cmbMarca.get_CatalogosInfo() == null)
        //        {
        //            MessageBox.Show("Por favor ingrese la marca del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmbMarca.Focus();
        //            return false;
        //        }

        //        if (cmbModelo.get_CatalogosInfo() == null)
        //        {
        //            MessageBox.Show("Por favor ingrese el modelo del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmbModelo.Focus();
        //            return false;
        //        }

        //        if (cmbColor.get_CatalogosInfo() == null)
        //        {
        //            MessageBox.Show("Por favor ingrese el color del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            this.cmbColor.Focus();
        //            return false;
        //        }



        //        List<Af_Activo_fijo_CtasCbles_Info> lstInfo = new List<Af_Activo_fijo_CtasCbles_Info>();
        //        var gridView = (List<vwAf_ActivoCtasCbles_Info>)gridContab.DataSource;
        //        foreach (var item in gridView)
        //        {
        //            if (item.IdCtaCble == null || item.IdCtaCble == "")
        //            {
        //                MessageBox.Show("Por favor escoja la cuenta para la " + item.IdTipoCuenta, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                return false;
        //            }
        //        }


        //        if (cmbProveedor.get_ProveedorInfo() == null)
        //        {
        //            MessageBox.Show("Por favor escoja el Proveedor", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            cmbProveedor.Focus();
        //            return false;
        //        }

        //        if (txtDescripTecnica.EditValue == null)
        //        {
        //            MessageBox.Show("Por favor ingrese la Descripcion Tecnica", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            txtDescripTecnica.Focus();
        //            return false;
        //        }

        //        switch (eCliente)
        //        {
        //            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.FJ:
        //                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo() == null)
        //                {
        //                    MessageBox.Show("Por favor ingrese el centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                    ucFa_Cliente_x_centro_costo_cmb1.Focus();
        //                    return false;
        //                }
        //                if (ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo() == null)
        //                {
        //                    MessageBox.Show("Por favor ingrese el sub centro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                    ucFa_Cliente_x_centro_costo_cmb1.Focus();
        //                    return false;
        //                }
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
        //                if (cmbUbicacion.get_CatalogosInfo() == null)
        //                {
        //                    MessageBox.Show("Por favor ingrese la ubicación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                    this.cmbUbicacion.Focus();
        //                    return false;
        //                }
        //                break;
        //            default:
        //                if (cmbUbicacion.get_CatalogosInfo() == null)
        //                {
        //                    MessageBox.Show("Por favor ingrese la ubicación del Activo Fijo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //                    this.cmbUbicacion.Focus();
        //                    return false;
        //                }
        //                break;
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }
        //}

        //public void iniciar()
        //{
        //    try
        //    {
        //        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        //{
        //    try
        //    {
        //        _Accion = iAccion;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void set_Accion_Controls()
        //{
        //    try
        //    {

        //        switch (_Accion)
        //        {
        //            case Cl_Enumeradores.eTipo_action.grabar:
                        
        //                this.chk_estado.Checked = true;
        //                ucGe_Menu.Enabled_bntImprimir = false;
        //                ucGe_Menu.Enabled_bntAnular = false;
        //                this.cmbProveedor.Enabled = true;
        //                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
        //                {
        //                    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(false);
        //                }
        //                break;
        //            case Cl_Enumeradores.eTipo_action.actualizar:
        //                ucGe_Sucursal_combo1.Enabled = false;
        //                cmb_tipo_activo_f.Properties.ReadOnly = true;
        //                cmbCategoriaAF.Properties.ReadOnly = true;
        //                cmbProveedor.Enabled = false;
        //                dtFechaCompra.Enabled = false;
        //                ucGe_Menu.Enabled_bntAnular = false;
        //                this.lbl_title_id.Visible = true;
        //                this.lbl_id_activo.Visible = true;
        //                this.chk_estado.Enabled = true;
        //                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
        //                {
        //                    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
        //                }
        //                set_ActivoFijo_in_controls();
        //                break;
        //            case Cl_Enumeradores.eTipo_action.Anular:
        //                ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
        //                ucGe_Menu.Enabled_btnGuardar = false;
        //                this.lbl_title_id.Visible = true;
        //                this.lbl_id_activo.Visible = true;
        //                this.txt_nombre.Enabled = false;
        //                this.txt_codigo_activofijo.Enabled = false;
        //                this.cmbColor.Enabled = false;
        //                this.cmbModelo.Enabled = false;
        //                this.txt_num_serie.Enabled = false;
        //                this.cmbMarca.Enabled = false;
        //                this.cmbUbicacion.Enabled = false;
        //                this.ucGe_Sucursal_combo1.Enabled = false;
        //                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
        //                {
        //                    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
        //                }
        //                this.cmb_tipo_activo_f.Enabled = false;
        //                this.cmbCategoriaAF.Enabled = false;
        //                this.cmb_TipoDepreciacion.Enabled = false;
        //                this.txt_DescCorta.Enabled = false;

        //                this.dtFechaCompra.Enabled = false;
        //                this.dtFecha_ini_depreciacion.Enabled = false;
        //                this.dtFecha_fin_depreciacion.Enabled = false;
        //                this.txt_costo_historico.Enabled = false;
        //                this.txt_costo_compra.Enabled = false;
        //                this.txt_vida_util.Enabled = false;
        //                this.txt_meses_depreciar.Enabled = false;
        //                this.txt_porc_depreciacion.Enabled = false;
        //                this.txt_observacion.Enabled = false;
        //                this.txt_observacion.Enabled = false;
        //                this.txt_num_placa.Enabled = false;
        //                this.txt_anio_fabrica.Enabled = false;


        //                this.chk_estado.Enabled = false;
        //                set_ActivoFijo_in_controls();
        //                break;
        //            case Cl_Enumeradores.eTipo_action.consultar:

        //                this.lbl_title_id.Visible = true;
        //                this.lbl_id_activo.Visible = true;
        //                ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
        //                ucGe_Menu.Enabled_btnGuardar = false;
        //                ucGe_Menu.Enabled_bntAnular = false;
        //                ucGe_Menu.Enabled_bntLimpiar = false;
        //                if (eCliente == Cl_Enumeradores.eCliente_Vzen.FJ)
        //                {
        //                    ucFa_Cliente_x_centro_costo_cmb1.ReadOnly_All(true);
        //                }
        //                set_ActivoFijo_in_controls();
        //                break;
        //        }



        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void load_combos()
        //{
        //    try
        //    {
        //        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();

        //        cmbMarca.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_MARCA.ToString());
        //        cmbModelo.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_DISEÑO.ToString());
        //        cmbColor.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_COLOR.ToString());


        //        Af_Activo_fijo_tipo_Bus bus_tipo_ActFij = new Af_Activo_fijo_tipo_Bus();
        //        lista_tipo_activo_fijo = bus_tipo_ActFij.Get_List_ActivoFijoTipo(param.IdEmpresa);
        //        cmb_tipo_activo_f.Properties.DataSource = lista_tipo_activo_fijo;

        //        string msjError = "";
        //        List_Activo_Fijo_Categoria = BusCategoria.Get_List_Activo_fijo_Categoria(param.IdEmpresa, ref msjError);

        //        tb_Sucursal_Bus bus_sucursal = new tb_Sucursal_Bus();
        //        lista_sucursal = bus_sucursal.Get_List_Sucursal(param.IdEmpresa);

        //        Af_Tipo_Depreciacion_Bus bus_depre = new Af_Tipo_Depreciacion_Bus();
        //        lista_depre = bus_depre.Get_List_ActivoFijo(param.IdEmpresa);

        //        cmb_TipoDepreciacion.Properties.DataSource = lista_depre;


        //        Af_PeriodoDepreciacion_Bus bus_periodo = new Af_PeriodoDepreciacion_Bus();
        //        lista_periodo = bus_periodo.Get_List_PeriodoDepreciacion();
        //        cmbPeriodo.Properties.DataSource = lista_periodo;


        //        Af_Activo_fijo_CtasCbles_Tipo_Bus busTiposCbles = new Af_Activo_fijo_CtasCbles_Tipo_Bus();
        //        listaTipoCble = busTiposCbles.Get_List_Activo_fijo_CtasCbles_Tipo();

        //        ct_Centro_costo_Bus busSubCen = new ct_Centro_costo_Bus();
        //        cmb_centro_costo.DataSource = busSubCen.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

        //        ct_Plancta_Bus busCuenta = new ct_Plancta_Bus();
        //        cmb_ctacble.DataSource = busCuenta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);




        //        bool flag = false;

               



        //        repositoryItemSearchLookUpEdit3.DataSource = listaTipoCble;






        //        switch (eCliente)
        //        {
        //            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.FJ:
        //                cmb_Unidades.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UNIDADES.ToString());
        //                ucFa_Cliente_x_centro_costo_cmb1.Cargar_combos();
        //                gridControl_Activos_Relacionado.DataSource = Lista_activos_relacionados;

        //                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.consultar)
        //                {
        //                    int idactivo_fijo = 0;
        //                    idactivo_fijo = Convert.ToInt32(lbl_id_activo.Text);
        //                    lista_activo_Fijo = Bus_AF.Get_List_ActivoFijo_x_Tipo(param.IdEmpresa, 1).Where(v => v.IdActivoFijo != idactivo_fijo).ToList();
        //                }
        //                else
        //                {
        //                    lista_activo_Fijo = Bus_AF.Get_List_ActivoFijo_x_Tipo(param.IdEmpresa, 1);

        //                }
        //                cmb_Activos_Relacionados.DataSource = lista_activo_Fijo;
        //                cmb_Activos_Relacionados.DisplayMember = "Af_Nombre";
        //                cmb_Activos_Relacionados.ValueMember = "IdActivoFijo";
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
        //                cmbUbicacion.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
        //                ucAf_Departamento.cargar();
        //                break;
        //            default:
        //                cmbUbicacion.cargar_Catalogos(Cl_Enumeradores.eTipoCatalogo_AF.TIP_UBICACION.ToString());
        //                ucAf_Departamento.cargar();
        //                break;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void set_ActivoFijo(Af_Activo_fijo_Info obj)
        //{
        //    try
        //    {
        //        Info_AF = obj;

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void set_ActivoFijo_in_controls()
        //{
        //    try
        //    {
        //        this.lbl_id_activo.Text = Info_AF.IdActivoFijo.ToString();

                
        //        switch (eCliente)
        //        {
        //            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.FJ:
        //                this.txtValorUnidad.Text = Info_AF.Af_ValorUnidad_Actu.ToString();
        //                this.cmb_Unidades.set_CatalogosInfo(Info_AF.IdUnidadFact_cat);
        //                CargarUbicacion_FJ(Info_AF.IdEmpresa, Info_AF.IdActivoFijo);
        //                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo(Info_AF.IdCentroCosto);
        //                ucFa_Cliente_x_centro_costo_cmb1.Set_Info_Centro_costo_sub_centro_costo(Info_AF.IdCentroCosto_sub_centro_costo);
        //                Lista_activos_relacionados = new BindingList<Af_Activo_fijo_x_Af_Activo_fijo_Info>(Activos_Relacionado_bus.Get_List_activos_relacionados(param.IdEmpresa, Info_AF.IdActivoFijo));
        //                txtCapacidad.Text = Info_AF.Af_Capacidad;
        //                if (Info_AF.Es_carroceria != null)
        //                    chkCarroceria.Checked = (bool)Info_AF.Es_carroceria;
        //                gridControl_Activos_Relacionado.DataSource = Lista_activos_relacionados;
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
        //                CargarGridUbicacion(param.IdEmpresa, Info_AF.IdActivoFijo);
        //                this.cmbUbicacion.set_CatalogosInfo(Info_AF.IdTipoCatalogo_Ubicacion);
        //                ucAf_Departamento.Inicializar_cmb_departamento();
        //                ucAf_Departamento.set_Info(Convert.ToInt16(Info_AF.IdDepartamento));
        //                break;
        //            default:
        //                CargarGridUbicacion(param.IdEmpresa, Info_AF.IdActivoFijo);
        //                this.cmbUbicacion.set_CatalogosInfo(Info_AF.IdTipoCatalogo_Ubicacion);
        //                ucAf_Departamento.Inicializar_cmb_departamento();
        //                ucAf_Departamento.set_Info(Convert.ToInt16(Info_AF.IdDepartamento));
        //                break;
        //        }


        //        this.txt_codigo_activofijo.Text = Info_AF.CodActivoFijo;
        //        this.txt_nombre.Text = Info_AF.Af_Nombre;
        //        this.cmbMarca.set_CatalogosInfo(Info_AF.IdCatalogo_Marca);
        //        this.cmbModelo.set_CatalogosInfo(Info_AF.IdCatalogo_Modelo);
        //        this.txt_num_serie.EditValue = Info_AF.Af_NumSerie;
        //        this.cmbColor.set_CatalogosInfo(Info_AF.IdCatalogo_Color);
        //        ucGe_Sucursal_combo1.set_SucursalInfo(Info_AF.IdSucursal);
        //        this.cmb_tipo_activo_f.EditValue = Info_AF.IdActijoFijoTipo;
        //        this.cmbCategoriaAF.EditValue = Info_AF.IdCategoriaAF;
        //        this.dtFechaCompra.Value = Info_AF.Af_fecha_compra;
        //        this.dtFecha_ini_depreciacion.Value = Info_AF.Af_fecha_ini_depre;
        //        this.dtFecha_fin_depreciacion.Value = Info_AF.Af_fecha_fin_depre;
        //        this.txt_costo_historico.Text = Info_AF.Af_Costo_historico.ToString();
        //        this.txt_costo_compra.Text = Info_AF.Af_costo_compra.ToString();
        //        this.txt_vida_util.Text = Info_AF.Af_Vida_Util.ToString();
        //        this.txt_meses_depreciar.Text = Info_AF.Af_Meses_depreciar.ToString();
        //        this.txt_porc_depreciacion.Text = Info_AF.Af_porcentaje_deprec.ToString();
        //        this.txt_observacion.Text = Info_AF.Af_observacion;
        //        this.txt_num_placa.Text = Info_AF.Af_NumPlaca;
        //        this.txt_anio_fabrica.Text = Info_AF.Af_Anio_fabrica.ToString();
        //        this.chk_estado.Checked = (Info_AF.Estado == "A") ? true : false;
        //        lblEstado.Visible = (Info_AF.Estado == "I") ? true : false;
        //        this.cmb_TipoDepreciacion.EditValue = Info_AF.IdTipoDepreciacion;
        //        if (Info_AF.Af_foto != null) { picFoto.Image = Funciones.ArrayAImage(Info_AF.Af_foto); }
        //        this.txt_DescCorta.Text = Info_AF.Af_DescripcionCorta;
        //        this.cmbPeriodo.EditValue = Info_AF.IdPeriodoDeprec;
        //        this.txtParte.Text = Convert.ToString(Info_AF.Af_Codigo_Parte);
        //        this.txtBarra.Text = Info_AF.Af_Codigo_Barra;


        //        txtDescripTecnica.EditValue = Info_AF.Af_DescripcionTecnica;
        //        cmbProveedor.set_ProveedorInfo(Info_AF.IdProveedor == null ? 0 : (int)Info_AF.IdProveedor);
        //        dtpFecPoliza.Value = Info_AF.Af_FechaPoliza == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_FechaPoliza);
        //        txtValorPoliza.EditValue = Info_AF.Af_ValorPoliza;
        //        txtValorVenta.EditValue = Info_AF.Af_ValorVenta;
        //        txtPoliza.EditValue = Info_AF.Af_NumPoliza;
        //        dtpFecVenta.Value = Info_AF.Af_Fecha_Venta == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Venta);
        //        dtpFecVencimiento.Value = Info_AF.Af_Fecha_Vencimiento == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Vencimiento);
        //        dtpFecRetiro.Value = Info_AF.Af_Fecha_Retiro == null ? DateTime.Now : Convert.ToDateTime(Info_AF.Af_Fecha_Retiro);

        //        txtValorSalvamento.EditValue = Info_AF.Af_ValorSalvamento;
        //        txtValorResidual.EditValue = Info_AF.Af_ValorResidual;


        //        lblIdEmpresaOC.Text = Convert.ToString(Info_AF.IdEmpresa_oc);
        //        lblIdProducto.Text = Convert.ToString(Info_AF.IdProducto);
        //        lblIdEmpresa_Ogiro.Text = Convert.ToString(Info_AF.IdEmpresa_Ogiro);
        //        txtNumDocOC.EditValue = Info_AF.numDocumento;
        //        txtCantidadOC.EditValue = Info_AF.Cantidad;
        //        txtCostoOC.EditValue = Info_AF.Costo_uni;
        //        txtSubtotalOC.EditValue = Info_AF.SubTotal;
        //        txtIvaOC.EditValue = Info_AF.valor_Iva;
        //        txtTotalOC.EditValue = Info_AF.Total;
        //        txtIdOC.EditValue = Info_AF.IdOrdenCompra;
        //        cmbSucursalOC.set_SucursalInfo(Info_AF.IdSucursal_oc == null ? 0 : (int)Info_AF.IdSucursal_oc);
        //        txtSecuenciaOC.EditValue = Info_AF.Secuencia_oc;
        //        txtIdOrdenGiro.EditValue = Info_AF.IdCbteCble_Ogiro;
        //        txtIdTipoOG.EditValue = Info_AF.IdTipoCbte_Ogiro;
        //        txtTipoOG.EditValue = Info_AF.IdOrden_giro_Tipo;

        //        txtSerieChasis.EditValue = Info_AF.Af_NumSerie_Chasis;
        //        txtSerieMotor.EditValue = Info_AF.Af_NumSerie_Motor;

        //        ucAf_Encargado.set_Info(Info_AF.IdEncargado == null ? 0 : (int)Info_AF.IdEncargado);


        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public Af_Activo_fijo_Info get_ActivoFijo()
        //{
        //    try
        //    {
        //        //revisar esto
        //        //Info_AF.CodActivoFijo = codActivoFijo;
        //        Info_AF = new Af_Activo_fijo_Info();
        //        Info_AF.IdEmpresa = param.IdEmpresa;
        //        Info_AF.IdActivoFijo = (this.lbl_id_activo.Text != "") ? Convert.ToInt32(this.lbl_id_activo.Text) : 0;
        //        Info_AF.CodActivoFijo = (this.txt_codigo_activofijo.Text == "") ? codActivoFijo : txt_codigo_activofijo.Text;
        //        Info_AF.Af_Nombre = this.txt_nombre.Text;
        //        Info_AF.IdCatalogo_Marca = cmbMarca.get_CatalogosInfo().IdCatalogo;
        //        Info_AF.IdCatalogo_Modelo = cmbModelo.get_CatalogosInfo().IdCatalogo;
        //        Info_AF.Af_NumSerie = Convert.ToString(txt_num_serie.EditValue);
        //        Info_AF.IdCatalogo_Color = cmbColor.get_CatalogosInfo().IdCatalogo;

        //        Info_AF.IdSucursal = ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal;
        //        Info_AF.IdActijoFijoTipo = Convert.ToInt32(this.cmb_tipo_activo_f.EditValue);
        //        Info_AF.IdCategoriaAF = Convert.ToInt32(this.cmbCategoriaAF.EditValue);

        //        Info_AF.Af_fecha_compra = this.dtFechaCompra.Value;
        //        Info_AF.Af_fecha_ini_depre = this.dtFecha_ini_depreciacion.Value;
        //        Info_AF.Af_fecha_fin_depre = this.dtFecha_fin_depreciacion.Value;
        //        Info_AF.Af_Costo_historico = (this.txt_costo_historico.Text != "") ? Convert.ToDouble(this.txt_costo_historico.Text) : 0;
        //        Info_AF.Af_costo_compra = (this.txt_costo_compra.Text != "") ? Convert.ToDouble(this.txt_costo_compra.Text) : 0;
        //        Info_AF.Af_Vida_Util = (this.txt_vida_util.Text != "") ? Convert.ToInt32(this.txt_vida_util.Text) : 0;
        //        Info_AF.Af_Meses_depreciar = (this.txt_meses_depreciar.Text != "") ? Convert.ToInt32(this.txt_meses_depreciar.Text) : 0;
        //        Info_AF.Af_porcentaje_deprec = (this.txt_porc_depreciacion.Text != "") ? Convert.ToDouble(this.txt_porc_depreciacion.Text) : 0;
        //        Info_AF.Af_observacion = (this.txt_observacion.Text != "") ? this.txt_observacion.Text : " ";
        //        Info_AF.Af_NumPlaca = (this.txt_num_placa.Text != "") ? this.txt_num_placa.Text : " ";
        //        Info_AF.Af_Anio_fabrica = (this.txt_anio_fabrica.Text != "") ? Convert.ToInt32(this.txt_anio_fabrica.Text) : 0;
        //        Info_AF.Estado = (chk_estado.Checked) ? "A" : "I";
        //        Info_AF.IdEmpresa = param.IdEmpresa;
        //        Info_AF.IdUsuario = param.IdUsuario;
        //        Info_AF.Fecha_Transac = DateTime.Now;

        //        Info_AF.nom_pc = param.nom_pc;
        //        Info_AF.ip = param.ip;
        //        Info_AF.IdTipoDepreciacion = Convert.ToInt32(this.cmb_TipoDepreciacion.EditValue);

        //        if (picFoto.Image != null) { Info_AF.Af_foto = Funciones.ImageAArray(picFoto.Image); } else Info_AF.Af_foto = null;
        //        Info_AF.Af_DescripcionCorta = this.txt_DescCorta.Text;
        //        Info_AF.IdPeriodoDeprec = Convert.ToString(this.cmbPeriodo.EditValue);
        //        Info_AF.Af_Codigo_Parte = (this.txtParte.Text == "" || this.txtParte.Text == null) ? "" : Convert.ToString(this.txtParte.Text);
        //        Info_AF.Af_Codigo_Barra = this.txtBarra.Text;

        //        Info_AF.Af_DescripcionTecnica = txtDescripTecnica.EditValue.ToString();
        //        Info_AF.IdProveedor = cmbProveedor.get_ProveedorInfo().IdProveedor;
        //        Info_AF.Af_FechaPoliza = dtpFecPoliza.Value;
        //        Info_AF.Af_ValorPoliza = (txtValorPoliza.EditValue == "" || txtValorPoliza.EditValue == null) ? 0 : Convert.ToDouble(txtValorPoliza.EditValue);
        //        Info_AF.Af_ValorVenta = (txtValorVenta.EditValue == "" || txtValorVenta.EditValue == null) ? 0 : Convert.ToDouble(txtValorVenta.EditValue);
        //        Info_AF.Af_NumPoliza = (txtPoliza.EditValue == "" || txtPoliza.EditValue == null) ? "" : txtPoliza.EditValue.ToString();
        //        Info_AF.Af_Fecha_Venta = dtpFecVenta.Value;
        //        Info_AF.Af_Fecha_Vencimiento = dtpFecVencimiento.Value;
        //        Info_AF.Af_Fecha_Retiro = dtpFecRetiro.Value;
        //        Info_AF.Estado_Proceso = Cl_Enumeradores.eEstadoActivoFijo.TIP_ESTADO_AF_ACTIVO.ToString();
        //        Info_AF.Af_ValorSalvamento = (txtValorSalvamento.EditValue == "" || txtValorSalvamento.EditValue == null) ? 0 : Convert.ToDouble(txtValorSalvamento.EditValue);
        //        Info_AF.Af_ValorResidual = (txtValorResidual.EditValue == "" || txtValorResidual.EditValue == null) ? 0 : Convert.ToDouble(txtValorResidual.EditValue);

        //        Info_AF.IdEmpresa_oc = (lblIdEmpresaOC.Text == "" || lblIdEmpresaOC.Text == null) ? 0 : Convert.ToInt32(lblIdEmpresaOC.Text);
        //        Info_AF.IdProducto = (lblIdProducto.Text == "" || lblIdProducto.Text == null) ? 0 : Convert.ToDecimal(lblIdProducto.Text);
        //        Info_AF.IdEmpresa_Ogiro = (lblIdEmpresa_Ogiro.Text == "" || lblIdEmpresa_Ogiro.Text == null) ? 0 : Convert.ToInt32(lblIdEmpresa_Ogiro.Text);
        //        Info_AF.numDocumento = Convert.ToString(txtNumDocOC.EditValue);
        //        Info_AF.Cantidad = (txtCantidadOC.EditValue == "" || txtCantidadOC.EditValue == null) ? 0 : Convert.ToDouble(txtCantidadOC.EditValue);
        //        Info_AF.Costo_uni = (txtCostoOC.EditValue == "" || txtCostoOC.EditValue == null) ? 0 : Convert.ToDouble(txtCostoOC.EditValue);
        //        Info_AF.SubTotal = (txtSubtotalOC.EditValue == "" || txtSubtotalOC.EditValue == null) ? 0 : Convert.ToDouble(txtSubtotalOC.EditValue);
        //        Info_AF.valor_Iva = (txtIvaOC.EditValue == "" || txtIvaOC.EditValue == null) ? 0 : Convert.ToDouble(txtIvaOC.EditValue);
        //        Info_AF.Total = (txtTotalOC.EditValue == "" || txtTotalOC.EditValue == null) ? 0 : Convert.ToDouble(txtTotalOC.EditValue);
        //        Info_AF.IdOrdenCompra = (txtIdOC.EditValue == "" || txtIdOC.EditValue == null) ? 0 : Convert.ToDecimal(txtIdOC.EditValue);
        //        Info_AF.Secuencia_oc = (txtSecuenciaOC.EditValue == "" || txtSecuenciaOC.EditValue == null) ? 0 : Convert.ToInt32(txtSecuenciaOC.EditValue);
        //        Info_AF.IdCbteCble_Ogiro = (txtIdOrdenGiro.EditValue == "" || txtIdOrdenGiro.EditValue == null) ? 0 : Convert.ToDecimal(txtIdOrdenGiro.EditValue);
        //        Info_AF.IdTipoCbte_Ogiro = (txtIdTipoOG.EditValue == "" || txtIdTipoOG.EditValue == null) ? 0 : Convert.ToInt32(txtIdTipoOG.EditValue);
        //        Info_AF.IdOrden_giro_Tipo = Convert.ToString(txtTipoOG.EditValue);

                
        //        if (cmbSucursalOC.get_SucursalInfo() == null)
        //            Info_AF.IdSucursal_oc = Convert.ToInt32(null);
        //        else
        //            Info_AF.IdSucursal_oc = cmbSucursalOC.get_SucursalInfo().IdSucursal;

        //        Info_AF.Af_NumSerie_Chasis = Convert.ToString(txtSerieChasis.EditValue);
        //        Info_AF.Af_NumSerie_Motor = Convert.ToString(txtSerieMotor.EditValue);


        //        if (ucAf_Encargado.get_Info() != null) Info_AF.IdEncargado = ucAf_Encargado.get_Info().IdEncargado;

        //        switch (eCliente)
        //        {
        //            case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.NATURISA:
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.FJ:
        //                if (cmb_Unidades.get_CatalogosInfo() != null) Info_AF.IdUnidadFact_cat = cmb_Unidades.get_CatalogosInfo().IdCatalogo;
        //                if (txtValorUnidad.Text != "") Info_AF.Af_ValorUnidad_Actu = Convert.ToDouble(txtValorUnidad.Text);
        //                Info_AF.IdCentroCosto = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdCentroCosto;
        //                Info_AF.IdCentroCosto_sub_centro_costo = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo_sub_centro_costo().IdCentroCosto_sub_centro_costo;
        //                Info_AF.lista_Activo_relacionados = Lista_activos_relacionados.ToList();
        //                Info_AF.Af_Capacidad = txtCapacidad.Text;
        //                Info_AF.Es_carroceria = chkCarroceria.Checked;
        //                break;
        //            case Cl_Enumeradores.eCliente_Vzen.GENERAL:
        //                Info_AF.IdTipoCatalogo_Ubicacion = cmbUbicacion.get_CatalogosInfo().IdCatalogo;
        //                if (ucAf_Departamento.get_Info() != null) Info_AF.IdDepartamento = ucAf_Departamento.get_Info().IdDepartamento;
        //                break;
        //            default:
        //                Info_AF.IdTipoCatalogo_Ubicacion = cmbUbicacion.get_CatalogosInfo().IdCatalogo;
        //                if (ucAf_Departamento.get_Info() != null) Info_AF.IdDepartamento = ucAf_Departamento.get_Info().IdDepartamento;
        //                break;
        //        }

        //        return Info_AF;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return new Af_Activo_fijo_Info();
        //    }
        //}

        //private List<Af_Activo_fijo_CtasCbles_Info> getCtasCbles_Af()
        //{
        //    try
        //    {
        //        List<Af_Activo_fijo_CtasCbles_Info> lstInfo = new List<Af_Activo_fijo_CtasCbles_Info>();
        //        var gridView = (List<vwAf_ActivoCtasCbles_Info>)gridContab.DataSource;

        //        foreach (var item in gridView)
        //        {
        //            Af_Activo_fijo_CtasCbles_Info infoCbte = new Af_Activo_fijo_CtasCbles_Info();
        //            //infoCbte.IdEmpresa = param.IdEmpresa;
        //            //infoCbte.IdActivoFijo = item.IdActivoFijo;
        //            //infoCbte.IdTipoCuenta = item.IdTipoCuenta;
        //            //infoCbte.IdCtaCble = item.IdCtaCble;
        //            //infoCbte.IdCentroCosto = (item.IdCentroCosto == "") ? null : item.IdCentroCosto;
        //            //infoCbte.Observacion = "";

        //            lstInfo.Add(infoCbte);
        //        }

        //        return lstInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return new List<Af_Activo_fijo_CtasCbles_Info>();
        //    }
        //}

        //public void frmAF_ActivoFijo_Mant_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        load_combos();
        //        if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }
        //        ucGe_Sucursal_combo1.set_SucursalInfo(param.IdSucursal);
        //        set_Accion_Controls();

        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void txt_costo_historico_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_costo_historico.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void txt_costo_historico_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Funciones f = new Funciones();
        //        txt_costo_historico.Text = f.Format_text_2_decimales(txt_costo_historico.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void txt_costo_compra_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_costo_compra.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void txt_costo_compra_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Funciones f = new Funciones();
        //        txt_costo_compra.Text = f.Format_text_2_decimales(txt_costo_compra.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void txt_vida_util_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.ValidaNumero(e.KeyChar);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void txt_meses_depreciar_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.ValidaNumero(e.KeyChar);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void txt_porc_depreciacion_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.Validanumero_decimal(e.KeyChar, this.txt_porc_depreciacion.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void txt_anio_fabrica_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    try
        //    {
        //        Funciones val = new Funciones();
        //        e.Handled = val.ValidaNumero(e.KeyChar);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void dtFecha_ini_depreciacion_ValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.txt_meses_depreciar.Text != null)
        //        {
        //            if (this.txt_meses_depreciar.Text != "")
        //            {
        //                this.dtFecha_fin_depreciacion.Value = this.dtFecha_ini_depreciacion.Value.AddMonths(Convert.ToInt32(this.txt_meses_depreciar.Text));
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void carga_datos_activo_fijo_tipo()
        //{
        //    try
        //    {
        //        Af_Activo_fijo_tipo_Info info_act_fijo_tipo = new Af_Activo_fijo_tipo_Info();
        //        info_act_fijo_tipo = (Af_Activo_fijo_tipo_Info)cmb_tipo_activo_f.EditValue;
        //        this.txt_porc_depreciacion.Text = info_act_fijo_tipo.Af_Porcentaje_depre.ToString();
        //        this.txt_vida_util.Text = info_act_fijo_tipo.Af_anio_depreciacion.ToString();
        //        this.txt_meses_depreciar.Text = (12 * info_act_fijo_tipo.Af_anio_depreciacion).ToString();
        //        this.dtFecha_fin_depreciacion.Value = this.dtFecha_ini_depreciacion.Value.AddMonths(Convert.ToInt32(this.txt_meses_depreciar.Text));
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void cmb_tipo_activo_f_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        carga_datos_activo_fijo_tipo();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void txt_vida_util_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        carga_datos_activo_fijo_tipo();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void txt_porc_depreciacion_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (Convert.ToDouble(this.txt_porc_depreciacion.Text) > 100)
        //        {
        //            //Porcentaje_de_depreciacion_mayor_a_100
        //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Porcentaje_de_depreciacion_mayor_a_100), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            this.txt_porc_depreciacion.Text = "";
        //            this.txt_porc_depreciacion.Focus();
        //        }
        //        else
        //        {
        //            Funciones f = new Funciones();
        //            txt_porc_depreciacion.Text = f.Format_text_2_decimales(txt_porc_depreciacion.Text);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }

        //}

        //public void cmbSucursal_Validated(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (ucGe_Sucursal_combo1.get_SucursalInfo().IdSucursal == null)
        //        {
        //            //Por_favor_seleccione_sucursal
        //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_sucursal), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            ucGe_Sucursal_combo1.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void cmb_TipoDepreciacion_SelectedValueChanged(object sender, EventArgs e)
        //{

        //}

        //public void label26_Click(object sender, EventArgs e)
        //{

        //}

        //public void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}

        //public void cmb_tipo_activo_f_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        cargarParametrosTipo_AF();
        //        List<Af_Activo_fijo_Categoria_Info> lstCateInfo = new List<Af_Activo_fijo_Categoria_Info>();
        //        lstCateInfo = List_Activo_Fijo_Categoria.Where(q => q.IdActivoFijoTipo == Convert.ToInt32(cmb_tipo_activo_f.EditValue)).ToList();
        //        cmbCategoriaAF.Properties.DataSource = lstCateInfo;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void cargarParametrosTipo_AF()
        //{
        //    try
        //    {
        //        var select = lista_tipo_activo_fijo.Where(q => q.IdActivoFijoTipo == Convert.ToInt32(cmb_tipo_activo_f.EditValue)).FirstOrDefault();

        //        tb_Sucursal_Info InfoSucu = ucGe_Sucursal_combo1.get_SucursalInfo();

        //        if (select != null)
        //        {

        //            codActivoFijo = select.CodActivoFijo + ((InfoSucu == null) ? "" : InfoSucu.codigo);

        //            txt_vida_util.EditValue = select.Af_anio_depreciacion;
        //            txt_meses_depreciar.EditValue = select.Af_anio_depreciacion * 12;
        //            txt_porc_depreciacion.EditValue = select.Af_Porcentaje_depre;

        //            dtFecha_fin_depreciacion.Value = dtFecha_ini_depreciacion.Value.AddMonths(Convert.ToInt32(txt_meses_depreciar.EditValue));

        //            foreach (var item in lstVwAf)
        //            {
        //                if (item.IdTipoCuenta == Cl_Enumeradores.eTipo_Cbte_Activos_Fijos.CTA_ACTIVO.ToString())
        //                {
        //                    item.IdCtaCble = select.IdCtaCble_Activo;
        //                    item.IdCentroCosto = select.IdCentroCosto_Activo;
        //                }

        //                if (item.IdTipoCuenta == Cl_Enumeradores.eTipo_Cbte_Activos_Fijos.CTA_DEPRE_ACUM.ToString())
        //                {
        //                    item.IdCtaCble = select.IdCtaCble_Dep_Acum;
        //                    item.IdCentroCosto = select.IdCentroCosto_Dep_Acum;
        //                }

        //                if (item.IdTipoCuenta == Cl_Enumeradores.eTipo_Cbte_Activos_Fijos.CTA_GASTOS_DEPRE.ToString())
        //                {
        //                    item.IdCtaCble = select.IdCtaCble_Gastos_Depre;
        //                    item.IdCentroCosto = select.IdCentroCosto_Gasto_Depre;
        //                }
        //            }
        //        }
        //        gridContab.DataSource = null;
        //        gridContab.DataSource = lstVwAf;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void picFoto_DoubleClick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        pu_Abrir_Imagen();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void pu_Abrir_Imagen()
        //{
        //    try
        //    {
        //        OpenFileDialog EscojaFoto = new OpenFileDialog();
        //        EscojaFoto.InitialDirectory = "c:\\";
        //        EscojaFoto.Filter = "JPG FILES (*.JPG)|*.jpg|GIF FILES (*.GIF)|*.gif|JPEG FILES (*.JPEG)|*.jpeg";
        //        EscojaFoto.RestoreDirectory = true;
        //        EscojaFoto.ShowDialog();

        //        if (EscojaFoto.FileName != "")
        //        {
        //            picFoto.Image = Image.FromFile(EscojaFoto.FileName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void btnFactura_OC_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbProveedor.get_ProveedorInfo() != null)
        //        {
        //            frmAF_ActivoFijo_x_OC_x_Factura frm = new frmAF_ActivoFijo_x_OC_x_Factura();

        //            infoFactura_SinCruce = new vwAF_OrdenCompra_x_Proveedor_Factura_SinCruce_ActivoFijo_Info();
        //            frm.set_OC_Factura_Activo(param.IdEmpresa, cmbProveedor.get_ProveedorInfo().IdProveedor);
        //            frm.ShowDialog();

        //            infoFactura_SinCruce = frm.getObtenerDatos();

        //            if (infoFactura_SinCruce != null)
        //            {
        //                txt_costo_compra.EditValue = infoFactura_SinCruce.Saldo_Factu;
        //                txt_costo_historico.EditValue = 0;
        //                dtFechaCompra.Value = infoFactura_SinCruce.Fecha_Ing_Bod;
        //                dtFecha_ini_depreciacion.Value = infoFactura_SinCruce.Fecha_Ing_Bod;
        //                txt_observacion.Text = infoFactura_SinCruce.dm_observacion;
        //                ucGe_Sucursal_combo1.set_SucursalInfo(infoFactura_SinCruce.IdSucursal_oc);
        //                txt_nombre.Text = infoFactura_SinCruce.nom_producto;

        //                lblIdEmpresaOC.Text = Convert.ToString(infoFactura_SinCruce.IdEmpresa_oc);
        //                lblIdProducto.Text = Convert.ToString(infoFactura_SinCruce.IdProducto);
        //                lblIdEmpresa_Ogiro.Text = Convert.ToString(infoFactura_SinCruce.IdEmpresa_Ogiro);
        //                txtNumDocOC.EditValue = infoFactura_SinCruce.numDocumento;
        //                txtCantidadOC.EditValue = infoFactura_SinCruce.Cantidad;
        //                txtCostoOC.EditValue = infoFactura_SinCruce.Costo_uni;
        //                txtSubtotalOC.EditValue = infoFactura_SinCruce.SubTotal;
        //                txtIvaOC.EditValue = infoFactura_SinCruce.valor_Iva;
        //                txtTotalOC.EditValue = infoFactura_SinCruce.Total;
        //                txtIdOC.EditValue = infoFactura_SinCruce.IdOrdenCompra;
        //                cmbSucursalOC.set_SucursalInfo(infoFactura_SinCruce.IdSucursal_oc);
        //                txtSecuenciaOC.EditValue = infoFactura_SinCruce.Secuencia_oc;
        //                txtIdOrdenGiro.EditValue = infoFactura_SinCruce.IdCbteCble_Ogiro;
        //                txtIdTipoOG.EditValue = infoFactura_SinCruce.IdTipoCbte_Ogiro;
        //                txtTipoOG.EditValue = infoFactura_SinCruce.IdOrden_giro_Tipo;
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Por_favor_seleccione_proveedor), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void toolStripButtonRefrescar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CargarGridUbicacion(param.IdEmpresa, Info_AF.IdActivoFijo);
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void toolStripButtonNuevaUbi_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        frmAF_Cambio_Ubicacion frm = new frmAF_Cambio_Ubicacion();
        //        frm.MdiParent = FrmParent;
        //        frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
        //        frm.set_InfoActivo_Fijo(Info_AF);
        //        frm.ShowDialog();
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void CargarGridUbicacion(int IdEmpresa, int IdActivo)
        //{
        //    try
        //    {
        //        lstVwcambioubi_info = busCambio.Get_List_CambioUbicacion(IdEmpresa, IdActivo);
        //        if (lstVwcambioubi_info.Count() != 0)
        //            gridcUbicacionActivo.DataSource = lstVwcambioubi_info;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private void CargarUbicacion_FJ(int idEmpresa, int IdActivo)
        //{
        //    try
        //    {
        //        lstVwcambioubi_info = busCambio.Get_List_CambioUbicacion(idEmpresa, IdActivo);
        //        if (lstVwcambioubi_info.Count() != 0)
        //        {
        //            gridcUbicacionActivo.DataSource = lstVwcambioubi_info;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //private Boolean Crear_Punto_cargo()
        //{
        //    try
        //    {
        //        info_af_x_pc = bus_af_x_pc.Get_Info_x_Activo_fijo(Info_AF.IdEmpresa, Info_AF.IdActivoFijo);
        //        if (info_af_x_pc.IdPunto_cargo_PC == 0)
        //        {
        //            //--Creo punto de cargo
        //            info_Punto_cargo.IdEmpresa = param.IdEmpresa;
        //            info_Punto_cargo.nom_punto_cargo = Info_AF.Af_Nombre;
        //            info_Punto_cargo.Estado = "A";

        //            bus_Punto_cargo.GuardarDB(info_Punto_cargo, param.IdEmpresa);
        //        }
        //        else
        //        {
        //            info_Punto_cargo = bus_Punto_cargo.Get_Info_Punto_cargo(param.IdEmpresa, info_af_x_pc.IdPunto_cargo_PC);
        //        }
        //        //Relaciono activo fijo con punto de cargo
        //        info_af_x_pc.IdEmpresa_AF = Info_AF.IdEmpresa;
        //        info_af_x_pc.IdActivoFijo_AF = Info_AF.IdActivoFijo;
        //        info_af_x_pc.IdEmpresa_PC = info_Punto_cargo.IdEmpresa;
        //        info_af_x_pc.IdPunto_cargo_PC = info_Punto_cargo.IdPunto_cargo;

        //        if (ucFa_Cliente_x_centro_costo_cmb1 != null)
        //        {
        //            if (bus_af_x_pc.MergeDB(info_af_x_pc))
        //            {
        //                //Relaciono activo fijo con centro de costo
        //                info_af_x_cc.IdEmpresa_AF = Info_AF.IdEmpresa;
        //                info_af_x_cc.IdActivoFijo_AF = Info_AF.IdActivoFijo;
        //                info_af_x_cc.IdCentroCosto_Scc = Info_AF.IdCentroCosto;
        //                info_af_x_cc.IdCentroCosto_sub_centro_costo_Scc = Info_AF.IdCentroCosto_sub_centro_costo;
        //                info_af_x_cc.IdEmpresa_Scc = ucFa_Cliente_x_centro_costo_cmb1.Get_Info_Centro_costo().IdEmpresa;

        //                if (bus_af_x_cc.MergeDB(info_af_x_cc))
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }
        //}

        //private Boolean Anular_Punto_cargo()
        //{
        //    try
        //    {
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //        return false;
        //    }
        //}

        //public void gridView_Activos_Relacionado_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyCode == Keys.Delete)
        //        {
        //            //  gridView_Activos_Relacionado = new DevExpress.XtraGrid.Views.Grid.GridView();

        //            if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                gridView_Activos_Relacionado.DeleteSelectedRows();
        //                //   gridControl_Activos_Relacionado.RefreshDataSource();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

        //    }
        //}

        //public void cmb_Activos_Relacionados_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        //Activo_Fijo_Seleccionado_info = lista_activo_Fijo.Where(v => v.IdActivoFijo == Id_Activo_Fijo).FirstOrDefault();
        //        // gridView_Activos_Relacionado.SetFocusedRowCellValue(Col_codigo_activo_Relacionado, Activo_Fijo_Seleccionado_info.CodActivoFijo);
        //        // gridView_Activos_Relacionado.SetFocusedRowCellValue(Col_Descripcion, Activo_Fijo_Seleccionado_info.Af_DescripcionCorta);
        //        // gridView_Activos_Relacionado.SetFocusedRowCellValue(Col_Descripcion_Tecnica, Activo_Fijo_Seleccionado_info.Af_DescripcionTecnica);

        //    }
        //    catch (Exception ex)
        //    {

        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void cmb_Activos_Relacionados_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        //{
        //    try
        //    {
        //        Id_Activo_Fijo = Convert.ToInt32(e.NewValue);
        //    }
        //    catch (Exception ex)
        //    {

        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}

        //public void chkCarroceria_EditValueChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (chkCarroceria.Checked)
        //        {
        //            if (!tab1.TabPages.Contains(tabPageCamionesRelacionados))
        //            {
        //                tab1.TabPages.Add(tabPageCamionesRelacionados);
        //                tab1.SelectedTab = tabPageCamionesRelacionados;
        //            }
        //        }
        //        else
        //        {
        //            if (tab1.TabPages.Contains(tabPageCamionesRelacionados))
        //            {
        //                tab1.TabPages.Remove(tabPageCamionesRelacionados);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
        //        MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Error_comunicarse_con_sistemas) + ex.Message + " ", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
        //    }
        //}
    }
}
