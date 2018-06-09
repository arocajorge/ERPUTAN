using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Compras;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Winform.Contabilidad;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.IO;
using Cus.Erp.Reports.FJ.Inventario;
namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Egresos_Varios_Mant_FJ : Form
    {
        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto;
        in_movi_inven_tipo_Bus Bus_InMovTipo;        
        in_UnidadMedida_Bus Bus_Uni_Med;
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        in_Ing_Egr_Inven_det_Bus bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus bus_IngEgr;
        ct_Centro_costo_Bus bus_centro_costo;        
        in_movi_inve_x_ct_cbteCble_Bus bus_InMovxCble;
        in_movi_inve_Bus bus_MovInv;


        string MensajeError = "";
        //Listas
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        List<in_movi_inven_tipo_Info> listInMovTip = new List<in_movi_inven_tipo_Info>();
        
        List<ct_Centro_costo_Info> list_centro_costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();

        
        //Infos
        in_movi_inve_x_ct_cbteCble_Info info_InMovxCble;
        in_movi_inve_Info infoMovInv;
        
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        in_Producto_Info Info_validar_cantidades = new in_Producto_Info();

        //Variables PRINCIPALES DE LA PANTALLA
        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
        BindingList<in_Ing_Egr_Inven_det_Info> List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();

        
        public delegate void delegate_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Egreso_varios_Mant_FormClosing event_FrmIn_Egreso_varios_Mant_FormClosing;
               
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();

        Cl_Enumeradores.eTipo_action Accion;
        int IdEmpresa_inv = 0;
        int IdSucursal_inv = 0;
        int IdBodega_inv = 0;
        int IdMovi_inven_tipo_inv = 0;
        decimal IdNumMovi_inv = 0;
        int RowHandle = 0;
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        List<ct_punto_cargo_Info> list_punto_cargo = new List<ct_punto_cargo_Info>();

        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        List<ct_punto_cargo_grupo_Info> list_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();

        List<in_Motivo_Inven_Info> list_MotivoInv = new List<in_Motivo_Inven_Info>();
        in_Motivo_Inven_Info info_MotivoInv = new in_Motivo_Inven_Info();
        in_Motivo_Inven_Bus bus_MotivoInv = new in_Motivo_Inven_Bus();

        in_Parametro_Info info_parametros = new in_Parametro_Info();
        in_Parametro_Bus bus_parametros = new in_Parametro_Bus();

        in_Producto_Info Item = new in_Producto_Info();

        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();

        List<in_UnidadMedida_Equiv_conversion_Info> lst_unidad_equiv = new List<in_UnidadMedida_Equiv_conversion_Info>();
        in_UnidadMedida_Equiv_conversion_Bus bus_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Bus();
        in_UnidadMedida_Equiv_conversion_Info info_unidad_equiv = new in_UnidadMedida_Equiv_conversion_Info();        

        #endregion

        public FrmIn_Egresos_Varios_Mant_FJ()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            
         
            event_FrmIn_Egreso_varios_Mant_FormClosing += FrmIn_Egresos_Varios_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing;
            gridViewProductos.CellValueChanging += gridViewProductos_CellValueChanging;

            ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;
            ucIn_Sucursal_Bodega1.Event_cmb_sucursal1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged;
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {

        }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucIn_Sucursal_Bodega1.get_bodega() != null)
                    cmbTipoMovi.cargar_TipoMotivo(ucIn_Sucursal_Bodega1.get_IdSucursal(), ucIn_Sucursal_Bodega1.get_IdBodega(), "-", "");
                else
                    cmbTipoMovi.Inicializar_Catalogos();
                CargarProducto();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Egresos_Varios_Mant_event_FrmIn_Egreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                               
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FrmIn_Egresos_Varios_Mant_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {           
        }
        
        private void FrmIn_Egresos_Varios_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                info_parametros = bus_parametros.Get_Info_Parametro(param.IdEmpresa);

                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;

                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
                
                carga_Combos();

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        colMotivo_inv.Visible = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        //col_grupo_pto_cargo.Visible = true;
                        //colIdPunto_cargo.Visible = true;
                        break;

                    case Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA:
                      // col_grupo_pto_cargo.Visible = true;
                       // colIdPunto_cargo.Visible = true;
                        break;
                    default:
                        break;
                }

                set_Accion_in_controls();

                
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ValidarDatos()) --Ricardo me dijo que elimine esto. --PS--
                //{
                    if (ValidarAnulacion_x_Estado())
                    {
                        Get();

                        string mensaje = "";
                        if (MessageBox.Show("Esta seguro que desea eliminar la transaccion ", param.Nombre_sistema, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        { return; }
                        Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();
                        info_IngEgr.MotivoAnulacion = ofrm.motivoAnulacion;
                        info_IngEgr.IdusuarioUltAnu = param.IdUsuario;
                        info_IngEgr.Fecha_UltAnu = param.Fecha_Transac;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();

                        if (bus_IngEgr.AnularDB(info_IngEgr, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema);
                            lblAnulado.Visible = true;

                            //  anular movimiento inventario                  
                            infoMovInv = new in_movi_inve_Info();
                            string msgAnula = "";
                            bus_MovInv = new in_movi_inve_Bus();
                            infoMovInv = bus_MovInv.Get_Info_Movi_inven(IdEmpresa_inv, IdSucursal_inv, IdBodega_inv, IdMovi_inven_tipo_inv, IdNumMovi_inv);

                            if (bus_MovInv.AnularDB(infoMovInv, param.Fecha_Transac, ref msgAnula))
                            {
                                MessageBox.Show("Movimiento de Inventario Anulado: " + msgAnula, param.Nombre_sistema);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al anular el registro: " + mensaje, param.Nombre_sistema);
                        }
                    }
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean ValidarAnulacion_x_Estado()
        {
            try
            {
                foreach (var item in List_Bind_IngEgrDet)
                {
                    //if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    //{
                    //    MessageBox.Show("No Se Puede Anular por que hay Registros Aprobados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    return false;
                    //}
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                switch ( param.IdCliente_Ven_x_Default)   
                {

                    case Cl_Enumeradores.eCliente_Vzen.FJ:

                    XINV_FJ_Rpt007_Rpt Reporte = new XINV_FJ_Rpt007_Rpt();
                    Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    Reporte.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                    Reporte.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                    Reporte.Parameters["IdMovi_inven_tipo"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                    Reporte.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);
                    Reporte.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;
                    Reporte.ShowPreviewDialog();


                    break;

                    default:
                    XINV_Rpt002_Rpt Reporte_ = new XINV_Rpt002_Rpt();
                    Reporte_.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    Reporte_.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                    Reporte_.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                    Reporte_.Parameters["IdMovi_inven_tipo"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                    Reporte_.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);
                    Reporte_.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt_ = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte_);
                    pt_.AutoShowParametersPanel = false;
                    Reporte_.ShowPreviewDialog();

                        break;
                }   
                    
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grabar())
                    LimpiarDatos();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_Combos()
        {
            try
            {
                CargarProducto();
                bus_centro_costo = new ct_Centro_costo_Bus();
                list_centro_costo = new List<ct_Centro_costo_Info>();
                list_centro_costo = bus_centro_costo.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmbCentroCosto_grid.DataSource = list_centro_costo;
                cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
                cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
                //subcentro de costo
                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentrocosto.DataSource = list_subcentro_combo;
                cmb_subcentrocosto.DisplayMember = "Centro_costo";
                cmb_subcentrocosto.ValueMember = "IdCentroCosto_sub_centro_costo";


                bus_punto_cargo = new ct_punto_cargo_Bus();
                list_punto_cargo = new List<ct_punto_cargo_Info>();
                list_punto_cargo = bus_punto_cargo.Get_List_punto_Cargo_con_subcentro(param.IdEmpresa);
                cmbPuntoCargo_grid.DataSource = list_punto_cargo;
                cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo";
                cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";
                list_grupo_punto_cargo = bus_grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Punto_cargo_grupo.DataSource = list_grupo_punto_cargo;
                list_MotivoInv = bus_MotivoInv.Get_List_Motivo_Inven(param.IdEmpresa);
                cmb_Motivo_Inv.DataSource = list_MotivoInv;
                cmb_Motivo_Inv.ValueMember = "IdMotivo_Inv";

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;
                cmb_unidad_medida_convertida.DataSource = lst_unidad_medida;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        void CargarProducto()
        {
            try
            {
                Bus_Producto = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null && ucIn_Sucursal_Bodega1.cmb_bodega.EditValue != null)
                {
                    listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                }
                cmbProducto_grid.DataSource = listProducto;
                cmbProducto_grid.DisplayMember = "pr_descripcion";
                cmbProducto_grid.ValueMember= "IdProducto";
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
                Accion = iAccion;
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void set_Accion_in_controls()
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        dtpFecha.Enabled = false;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.FJ:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.TALME:
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        lbl_responsable.Visible = true;
                        ucIn_Responsable1.Visible = true;
                        colIdPunto_cargo.Visible = true;
                        break;
                    case Cl_Enumeradores.eCliente_Vzen.GENERAL:
                        break;
                    default:
                        break;
                }
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        this.txtNumIngreso.ReadOnly = true;
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {
                            dtpFecha.Enabled = false;
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:
                        setInfo_in_controls();

                        foreach (var item in List_Bind_IngEgrDet)
                        {
                            Info_validar_cantidades = listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto);

                            if (Info_validar_cantidades != null)
                            {
                                listProducto.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa && q.IdSucursal == item.IdSucursal && q.IdBodega == item.IdBodega && q.IdProducto == item.IdProducto).pr_Pedidos_inv = Info_validar_cantidades.pr_Pedidos_inv - (Math.Abs(item.dm_cantidad) * -1);
                            }
                        }

                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                        Inhabilita_Controles();
                        dtpFecha.Enabled = true;
                        txtObservacion.Enabled = true;
                        if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT)
                        {
                            dtpFecha.Enabled = false;
                            txtObservacion.ReadOnly = false;
                        }
                        
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;
                        Inhabilita_Controles();
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        setInfo_in_controls();
                        ucGe_Menu_Superior_Mant1.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = false;
                        ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                        Inhabilita_Controles();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Inhabilita_Controles()
        {
            try
            {
                txtNumIngreso.ReadOnly = true;                
                
                dtpFecha.Enabled = false;

                cmbTipoMovi.Enabled = false;
                
                txtObservacion.ReadOnly = true;
                
                ucIn_Sucursal_Bodega1.cmb_sucursal.Enabled = false;
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                carga_Combos();
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                txtCodigo.Text = "";
                txtObservacion.Text = "";
                dtpFecha.Value = DateTime.Now;
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = List_Bind_IngEgrDet;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Get()
        {
            try
            {
                info_IngEgr = new in_Ing_Egr_Inven_Info();               
                info_IngEgr.IdEmpresa = param.IdEmpresa;
                info_IngEgr.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                info_IngEgr.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                info_IngEgr.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                info_IngEgr.CodMoviInven = txtCodigo.Text;
                info_IngEgr.cm_observacion = txtObservacion.Text;
                info_IngEgr.IdMovi_inven_tipo = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info_IngEgr.cm_fecha = dtpFecha.Value;
                info_IngEgr.IdUsuario = param.IdUsuario;
                info_IngEgr.nom_pc = param.nom_pc;
                info_IngEgr.ip = param.ip;
                info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                info_IngEgr.signo = "-";
                info_IngEgr.IdMotivo_Inv = ucIn_MotivoInvCmb1.get_MotivoInvInfo().IdMotivo_Inv;
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        info_IngEgr.IdResponsable = ucIn_Responsable1.get_Info_Responsable().IdResponsable;
                        break;
                    default:
                        info_IngEgr.IdResponsable = null;
                        break;
                }
                
                info_IngEgr.listIng_Egr = GetDetalle();
                foreach (var item in info_IngEgr.listIng_Egr )
                {
                    item.IdEmpresa = info_IngEgr.IdEmpresa;
                    item.IdNumMovi = info_IngEgr.IdNumMovi;
                    item.IdSucursal = info_IngEgr.IdSucursal;
                    item.IdBodega = info_IngEgr.IdBodega;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        List<in_Ing_Egr_Inven_det_Info> GetDetalle()
        {
            try
            {
                return new  List<in_Ing_Egr_Inven_det_Info>(List_Bind_IngEgrDet);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<in_Ing_Egr_Inven_det_Info>();
            }
        }

        public void setInfo_(in_Ing_Egr_Inven_Info info_IngEgr_)
        {
            info_IngEgr = info_IngEgr_;
        }

        private void setInfo_in_controls()
        {
            try 
            {             
                if (info_IngEgr == null)
                { return; }

                txtNumIngreso.Text = Convert.ToString(info_IngEgr.IdNumMovi);
                ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = info_IngEgr.IdSucursal;
                ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = info_IngEgr.IdBodega;
                dtpFecha.Value = info_IngEgr.cm_fecha;
                cmbTipoMovi.set_TipoMoviInvInfo(info_IngEgr.IdMovi_inven_tipo);
                txtObservacion.Text = info_IngEgr.cm_observacion;
                txtCodigo.Text = info_IngEgr.CodMoviInven;
            
                lblAnulado.Visible = info_IngEgr.Estado == "I" ? true : false;
                ucIn_Responsable1.set_Info_Responsable((info_IngEgr.IdResponsable == null) ? 0 : Convert.ToDecimal(info_IngEgr.IdResponsable));
                bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                List_Bind_IngEgrDet = new BindingList<in_Ing_Egr_Inven_det_Info>(bus_IngEgrDet.Get_List_Ing_Egr_Inven_det(param.IdEmpresa, info_IngEgr.IdSucursal, info_IngEgr.IdMovi_inven_tipo, info_IngEgr.IdNumMovi));
                foreach (var item in List_Bind_IngEgrDet)
                {
                    item.dm_cantidad = item.dm_cantidad < 0 ? item.dm_cantidad * -1 : item.dm_cantidad;
                    item.dm_cantidad_sinConversion = item.dm_cantidad_sinConversion < 0 ? item.dm_cantidad_sinConversion * -1 : item.dm_cantidad_sinConversion;
                }
                ucIn_MotivoInvCmb1.set_MotivoInvInfo((int)info_IngEgr.IdMotivo_Inv);

                gridControlProductos.DataSource = List_Bind_IngEgrDet;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean grabar()
        {
            try
            {
                txtNumIngreso.Focus();
                if (!ValidarDatos())
                    return false;

                Get();
                string mensaje = "";
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.CAH:
                        foreach (var item in info_IngEgr.listIng_Egr)
                        {
                            in_Producto_Info Info_Prod_msg = new in_Producto_Info();
                            Info_Prod_msg = listProducto.First(q => q.IdProducto == item.IdProducto);

                            if (Info_Prod_msg.pr_stock_minimo <= (Info_Prod_msg.pr_Disponible - item.dm_cantidad_sinConversion))
                            {
                                MessageBox.Show("El item " + Info_Prod_msg.pr_descripcion + " están a punto de terminarse", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    default:
                        break;
                }

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        decimal IdNumMovi = 0;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.GuardarDB(info_IngEgr, ref   IdNumMovi, ref mensaje))
                        {
                            txtNumIngreso.Text = Convert.ToString(IdNumMovi);
                            string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro del egreso a Bodega ", IdNumMovi.ToString());
                            MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //MessageBox.Show("Se ha procedido a grabar el registro del Ingreso a Bodega #: " + IdNumMovi.ToString() + " exitosamente.", "Operación Exitosa");

                            // consulta grid contable                      
                            var item = info_IngEgr.listIng_Egr.FirstOrDefault();
                            ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));

                            if (MessageBox.Show("Desea Imprimir el Egreso", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                            }

                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al grabar el Ingreso a Bodega, " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;

                    case Cl_Enumeradores.eTipo_action.actualizar:

                        info_IngEgr.IdUsuarioUltModi = param.IdUsuario;
                        info_IngEgr.Fecha_UltMod = param.Fecha_Transac;
                        bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                        if (bus_IngEgr.ModificarDB(info_IngEgr, ref mensaje))
                        {
                            MessageBox.Show(mensaje, param.Nombre_sistema);
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }                
        }
                    
        public void anular()
        {
            try
            {
                if (info_IngEgr != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();
                    if (info_IngEgr.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el egreso N#: " + info_IngEgr.IdNumMovi + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            info_IngEgr.MotivoAnulacion = oFrm.motivoAnulacion;

                            info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                            info_IngEgr.IdusuarioUltAnu = param.IdUsuario;

                            info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                            if (bus_IngEgr.AnularDB(info_IngEgr, ref msg))
                            {
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro ", info_IngEgr.IdNumMovi.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //MessageBox.Show("Anulación con éxito # " + info_IngEgr.IdNumMovi);
                                info_IngEgr.Estado = "I";

                                lblAnulado.Visible = true;

                                //  anular movimiento inventario                  
                                infoMovInv = new in_movi_inve_Info();
                                string msgAnula = "";

                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                                //consulta detalle
                                var item = List_Bind_IngEgrDet.FirstOrDefault();

                                bus_MovInv = new in_movi_inve_Bus();
                                infoMovInv = bus_MovInv.Get_Info_Movi_inven(Convert.ToInt32(item.IdEmpresa_inv), Convert.ToInt32(item.IdSucursal_inv), Convert.ToInt32(item.IdBodega_inv), Convert.ToInt32(item.IdMovi_inven_tipo_inv), Convert.ToDecimal(item.IdNumMovi_inv));

                                if (bus_MovInv.AnularDB(infoMovInv, param.Fecha_Transac, ref msgAnula))
                                {
                                    MessageBox.Show("Movimiento de Inventario Anulado: " + msgAnula, param.Nombre_sistema);
                                }          

                                Accion = Cl_Enumeradores.eTipo_action.consultar;
                            }
                        }
                    }
                    else if (info_IngEgr.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la devolución de Compra N#: " + info_IngEgr.IdNumMovi +
                             ", ya se encuentra anulada", "Anulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void gridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewProductos.DeleteSelectedRows();
                    }
                }

                // para pegar en las columnas en el mismo orden 
                if (e.KeyCode == Keys.V && e.Control == true)
                {
                    Pegar_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Pegar_Data()
        {
            try
            {
                string[] data = ClipboardData.Split('\n');
                if (data.Length < 1) return;
                foreach (string row in data)
                {
                    if (!Agregar_fila_copiada(row))
                        break;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        string ClipboardData
        {
            get
            {
                IDataObject iData = Clipboard.GetDataObject();
                if (iData == null) return "";

                if (iData.GetDataPresent(DataFormats.Text))
                    return (string)iData.GetData(DataFormats.Text);
                return "";
            }
            set { Clipboard.SetDataObject(value); }
        }

        private Boolean Agregar_fila_copiada(string data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(data)) return false;
                string[] rowData = data.Split(new char[] { '\r', '\x09' });


                //posicion de la ata pegada
                //codigo produc | unidad medida |cant |costo|observacion|

                in_Ing_Egr_Inven_det_Info newRow = new in_Ing_Egr_Inven_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                    string cod_producto = rowData[0];
                    in_Producto_Info Info_Producto;
                    var QProducto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto);
                    if (QProducto != null)
                    { Info_Producto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto); }
                    else { MessageBox.Show("el codigo de este producto:" + cod_producto + " no esta en la base"); return false; }



                    string IdUnidadMedida = Convert.ToString(rowData[2]) == "" ? Info_Producto.IdUnidadMedida_Consumo : Convert.ToString(rowData[2]);
                    double cantidad = Convert.ToDouble(rowData[3]);
                    double costo_unitario = Convert.ToDouble(rowData[4]);
                    string observacion = Convert.ToString(rowData[1]);


                    in_Ing_Egr_Inven_det_Info emp = new in_Ing_Egr_Inven_det_Info();
                    if (!string.IsNullOrWhiteSpace(cod_producto))
                    {

                        newRow.IdProducto = Info_Producto.IdProducto;
                        newRow.cod_producto = cod_producto;
                        newRow.dm_cantidad = cantidad;
                        newRow.dm_cantidad_sinConversion = cantidad;
                        newRow.IdUnidadMedida = IdUnidadMedida;
                        newRow.IdUnidadMedida_sinConversion = IdUnidadMedida;
                        newRow.mv_costo = costo_unitario;
                        newRow.mv_costo_sinConversion = costo_unitario;
                        newRow.dm_observacion = observacion;
                        newRow.nom_UnidadMedida = Info_Producto.nom_UnidadMedida;


                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                        return false;
                    }

                    List_Bind_IngEgrDet.Add(newRow);
                    return true;
                }
                else
                {
                    MessageBox.Show("No hay las columnas necesarias para insertar al registros");
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "El formato debe ser el siguiente\n" + "|codigo Producto|nombre producto|unidad med.|cantidad|costo|observacion det|centros cos|", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                //InfoDet = new in_Ing_Egr_Inven_det_Info();
                InfoDet = (in_Ing_Egr_Inven_det_Info)this.gridViewProductos.GetFocusedRow();

                if (e.Column.Name == "colIdProducto")
                {
                    foreach (var item in List_Bind_IngEgrDet)
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                        if (item.IdProducto == InfoDet.IdProducto)
                        {
                            item.cod_producto = itemProd.pr_codigo;
                            InfoDet.mv_costo = 0;
                            InfoDet.mv_costo_sinConversion = 0;
                            InfoDet.pr_descripcion = itemProd.pr_descripcion;
                            InfoDet.IdUnidadMedida = itemProd.IdUnidadMedida_Consumo;
                            InfoDet.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida_Consumo;
                            InfoDet.pr_codigo = itemProd.pr_codigo;
                        }
                    }
                }
                
                if (e.Column == coldm_cantidad_sin_conversion || e.Column == colIdProducto || e.Column == col_IdUnidadMedida)
                {
                    if (InfoDet.IdUnidadMedida_sinConversion != null)
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);
                        if (itemProd != null)
                        {
                            info_unidad_equiv = bus_unidad_equiv.Get_Info_in_UnidadMedida_Equiv_conversion(InfoDet.IdUnidadMedida_sinConversion, itemProd.IdUnidadMedida_Consumo);
                            if (info_unidad_equiv != null)
                            {
                                InfoDet.dm_cantidad = InfoDet.dm_cantidad_sinConversion * info_unidad_equiv.valor_equiv;
                            }
                            else
                                MessageBox.Show("No existe una conversión de " + InfoDet.IdUnidadMedida_sinConversion + " a " + itemProd.IdUnidadMedida_Consumo, param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        }
                    }
                }

                if (e.Column == colIdPunto_cargo)
                {
                    if (InfoDet.IdPunto_cargo != null)
                    {
                        info_punto_cargo = bus_punto_cargo.Get_info_punto_Cargo_con_subcentro(param.IdEmpresa, Convert.ToInt32(InfoDet.IdPunto_cargo));
                        if (info_punto_cargo != null)
                        {
                            InfoDet.IdCentroCosto = info_punto_cargo.IdCentroCosto_Scc;
                            InfoDet.IdCentroCosto_sub_centro_costo = info_punto_cargo.IdCentroCosto_sub_centro_costo_Scc;
                            InfoDet.IdPunto_cargo_grupo = info_punto_cargo.IdPunto_cargo_grupo;
                        }
                        else
                        {
                            InfoDet.IdCentroCosto = null;
                            InfoDet.IdCentroCosto_sub_centro_costo = null;
                            InfoDet.IdPunto_cargo_grupo = null;
                        }
                    }
                    else
                    {
                        InfoDet.IdCentroCosto = null;
                        InfoDet.IdCentroCosto_sub_centro_costo = null;
                        InfoDet.IdPunto_cargo_grupo = null;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Egresos_Varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Egreso_varios_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus(); 
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean ValidarDatos()
        {
            try
            {
                
                txtObservacion.Focus();
                if (ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == null || ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == null || ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoMovi.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_MotivoInvCmb1.get_MotivoInvInfo()==null)
                {
                    MessageBox.Show("Seleccione el motivo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtObservacion.Text == "")
                {
                    MessageBox.Show("Ingrese la Observación", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (dtpFecha.Value == null)
                {
                    MessageBox.Show("Ingrese la Fecha de la Transacción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (List_Bind_IngEgrDet.Count() <= 0)
                {
                    MessageBox.Show("Ingrese al menos un Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                switch (param.IdCliente_Ven_x_Default)
                {
                   case Cl_Enumeradores.eCliente_Vzen.CAH:
                        if (ucIn_Responsable1.get_Info_Responsable() == null)
                        {
                            MessageBox.Show("Ingrese un responsable de la transacción", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                        break;
                }

                foreach (var item in List_Bind_IngEgrDet)
                {
                    if (item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida_sinConversion == null)
                    {
                        MessageBox.Show("Seleccione la Unidad de Medida para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (item.IdCentroCosto == "" || item.IdCentroCosto == null)
                    {
                        MessageBox.Show("Seleccione un centro de costo para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        MessageBox.Show("Existen items aprobados en este egreso de bodega y no se puede modificar " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    switch (param.IdCliente_Ven_x_Default)
                    {
                       case Cl_Enumeradores.eCliente_Vzen.CAH:
                            if (item.IdMotivo_Inv == null)
                            {
                                MessageBox.Show("Seleccione un motivo para el Producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                            break;
                    }
                }

                
                if (info_parametros != null)
                {
                    if (info_parametros.Maneja_Stock_Negativo.Trim() == "N")
                    {
                        string Producto_no_contabilizado = "";
                        List<decimal> revisados = new List<decimal>();
                        int res = 0;
                        foreach (var item in List_Bind_IngEgrDet)
                        {

                            if (param.IdCliente_Ven_x_Default == Cl_Enumeradores.eCliente_Vzen.FJ)
                            {
                                if (item.IdCentroCosto_sub_centro_costo == null)
                                {
                                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_el) + " Subcentro de costo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                            }
                            
                            res = revisados.Where(q => q == item.IdProducto).Count();
                            if (res == 0)
                            {
                                double cantidad_pedida = Math.Round(List_Bind_IngEgrDet.Where(q => q.IdProducto == item.IdProducto).Sum(q => q.dm_cantidad), 2,MidpointRounding.AwayFromZero);
                                in_Producto_Info producto = listProducto.FirstOrDefault(q => q.IdProducto == item.IdProducto && q.IdEmpresa == param.IdEmpresa && q.IdSucursal == ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal && q.IdBodega == ucIn_Sucursal_Bodega1.get_bodega().IdBodega);
                                double cantidad_disponible = Convert.ToDouble(producto.pr_stock) - Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv));

                                if (cantidad_disponible < cantidad_pedida)
                                {
                                    MessageBox.Show("Producto: " + producto.pr_descripcion_2 + "\nStock actual en bodega: " + producto.pr_stock.ToString() + " " + producto.nom_UnidadMedida_Consumo + "\nCantidad pedida no aprobada :" + Math.Abs(Convert.ToDouble(producto.pr_Pedidos_inv)) + " " + producto.nom_UnidadMedida_Consumo + " \nCantidad pedida en este egreso: " + cantidad_pedida.ToString() + " " + producto.nom_UnidadMedida_Consumo + " \nCorrija las cantidades.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                }
                                bool se_valida_paramatrizacion_contable_x_producto = info_parametros.P_se_valida_parametrizacion_x_producto==null ? false : (bool)info_parametros.P_se_valida_parametrizacion_x_producto;
                                if (se_valida_paramatrizacion_contable_x_producto)
                                {
                                    if (producto.IdCtaCble_Inventario==null || producto.IdCtaCble_Costo == null)
                                    {
                                        if (Producto_no_contabilizado == "") Producto_no_contabilizado = producto.pr_descripcion_2;
                                        else Producto_no_contabilizado += "\n" + producto.pr_descripcion_2;
                                    }
                                }
                                revisados.Add(item.IdProducto);
                            }
                        }
                        if (Producto_no_contabilizado != "")
                        {
                            MessageBox.Show("Los siguientes productos no estan parametrizados contablemente, por favor corrija:\n"+Producto_no_contabilizado, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }
                }

                if(!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV,Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }        

        private void gridViewProductos_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProductos.GetRow(e.RowHandle) as in_Ing_Egr_Inven_det_Info;
                if (data == null)
                    return;

                if (data.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    e.Appearance.ForeColor = Color.Blue;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_diarios_Click(object sender, EventArgs e)
        {
            try
            {
                // consulta grid contable             
                var item = List_Bind_IngEgrDet.FirstOrDefault();
                if (item != null)
                    ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
            }
            catch (Exception ex)
            {

            }
        }

        private void cmb_punto_cargo_Click(object sender, EventArgs e)
        {

        }

        private void Llamar_pantalla_subcentro()
        {
            try
            {
                in_Ing_Egr_Inven_det_Info Row = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetRow(RowHandle);
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
                            gridViewProductos.SetRowCellValue(RowHandle, colIdCentroCosto_grid, info_subcentro == null ? null : info_subcentro.IdCentroCosto);
                            gridViewProductos.SetRowCellValue(RowHandle, collIdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);                            
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

        private void cmb_subcentro_costo_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_subcentro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_unidad_medida_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_unidad_medida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Llamar_pantalla_unidad_medida()
        {
            try
            {
                lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
                decimal IdProducto = 0;
                if (RowHandle >= 0)
                {
                    IdProducto = Convert.ToDecimal(gridViewProductos.GetRowCellValue(RowHandle, colIdProducto));
                    Item = listProducto.FirstOrDefault(q => q.IdProducto == IdProducto);
                    if (Item!=null)
                    {
                        lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida_equivalencia(Item.IdUnidadMedida);

                        FrmIn_Unidad_Medida_Consu frm_combo = new FrmIn_Unidad_Medida_Consu();
                        frm_combo.set_config_combo(lst_unidad_medida_para_combo);
                        frm_combo.ShowDialog();
                        info_unidad_medida = frm_combo.Get_info_unidad_medida();
                        gridViewProductos.SetRowCellValue(RowHandle, colIdUnidadMedida_sinConversion, info_unidad_medida == null ? null : info_unidad_medida.IdUnidadMedida);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void IdCentroCosto_sub_centro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_subcentro();    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_subcentro_costo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_subcentro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmb_unidad_medida_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_unidad_medida();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewProductos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;

                if (RowHandle != 0)
                {
                    /* SE COMENTO PORQUE EN GRAFINPREN NI EN NATURISA SE USA ESTO, SUPONGO Q ES DE ALEMAN PERO HAY QUE REVISARLO PORQUE NO TE DEJA GRABAR
                    if (List_Bind_IngEgrDet.Count() != 0)
                    {
                        if (List_Bind_IngEgrDet.Last().IdProducto != 0 && List_Bind_IngEgrDet.Last().dm_cantidad != 0 && List_Bind_IngEgrDet.Last().IdUnidadMedida != null)
                        {
                            in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                            info.IdCentroCosto = InfoDet.IdCentroCosto;
                            info.IdPunto_cargo_grupo = InfoDet.IdPunto_cargo_grupo;
                            info.IdMotivo_Inv = InfoDet.IdMotivo_Inv;
                            info.IdPunto_cargo = InfoDet.IdPunto_cargo;
                            List_Bind_IngEgrDet.Add(info);
                        }

                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void lblPlantilla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = null;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    File.WriteAllBytes(@filePath, Properties.Resources.Plantilla_inventario);
                    MessageBox.Show("Archivo descargado con exito.\r\n\r\n" + filePath, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cmbProducto_grid_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAnulado_Click(object sender, EventArgs e)
        {

        }

        private void check_aplicar_Todos_CheckedChanged(object sender, EventArgs e)
        {
            bool si_existeDta = false;
            try
            {
                int sec = 0;
                int puntoCargo = 0;
                string IdCentro = "";
                string IdSubcentro = "";
                int motivo = 0;
                foreach (var item in List_Bind_IngEgrDet)
                {
                    if (item.IdPunto_cargo != null && item.IdCentroCosto != null && item.IdCentroCosto_sub_centro_costo != null && item.IdMotivo_Inv!=null)
                    {
                       
                        si_existeDta = true;
                        if (sec == 0)
                        {
                            puntoCargo = Convert.ToInt32(item.IdPunto_cargo);
                            IdCentro = item.IdCentroCosto;
                            IdSubcentro = item.IdCentroCosto_sub_centro_costo;
                            motivo =Convert.ToInt32( item.IdMotivo_Inv);
                            sec = 1;
                        }
                    }
                        item.IdPunto_cargo = puntoCargo;
                        item.IdCentroCosto = IdCentro;
                        item.IdCentroCosto_sub_centro_costo = IdSubcentro;
                        item.IdMotivo_Inv = motivo;
                    }
                


                gridControlProductos.RefreshDataSource();
                if (!si_existeDta)
                {
                    MessageBox.Show("Ingrese los datos a duplicar en el primer registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                   MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
