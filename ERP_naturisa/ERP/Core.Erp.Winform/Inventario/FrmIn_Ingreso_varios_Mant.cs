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

using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Contabilidad;

using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Reportes.Inventario;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Cus.Erp.Reports.Naturisa.Inventario;
using Cus.Erp.Reports.Naturisa.Compras;
using System.IO;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ingreso_varios_Mant : Form
    {
        #region Declaración de Variables
        //Bus
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        in_movi_inven_tipo_Bus Bus_InMovTipo = new in_movi_inven_tipo_Bus();

        in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
        in_Ing_Egr_Inven_Bus Bus_IngEgr = new in_Ing_Egr_Inven_Bus();
        in_movi_inve_x_ct_cbteCble_Bus bus_InMovxCble = new in_movi_inve_x_ct_cbteCble_Bus();
        in_movi_inve_Bus bus_MovInv = new in_movi_inve_Bus();

        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        vwIn_UnidadMedida_Equivalencia_Bus busUniEqui = new vwIn_UnidadMedida_Equivalencia_Bus();
        in_UnidadMedida_Bus Bus_Uni_Med = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> list_unidad_medida = new List<in_UnidadMedida_Info>();
        ct_punto_cargo_Bus bus_punto_cargo = new ct_punto_cargo_Bus();
        in_Motivo_Inven_Bus bus_MotivoInv = new in_Motivo_Inven_Bus();
        ct_punto_cargo_grupo_Bus bus_grupo_punto_cargo = new ct_punto_cargo_grupo_Bus();

        //Listas
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();        
        List<ct_Centro_costo_Info> list_centroCosto = new List<ct_Centro_costo_Info>();        
        List<ct_punto_cargo_Info> list_punto_cargo = new List<ct_punto_cargo_Info>();        
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();

        List<ct_punto_cargo_grupo_Info> list_grupo_punto_cargo = new List<ct_punto_cargo_grupo_Info>();

       //Infos
        in_movi_inve_x_ct_cbteCble_Info info_InMovxCble;
        in_movi_inve_Info infoMovInv;
        in_Parametro_Bus bus_parametro = new in_Parametro_Bus();
        in_Parametro_Info info_parametro = new in_Parametro_Info();
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        ct_punto_cargo_Info info_punto_cargo = new ct_punto_cargo_Info();
        ct_punto_cargo_grupo_Info info_grupo_punto_cargo = new ct_punto_cargo_grupo_Info();
        
        //Variables
        Cl_Enumeradores.eTipo_action Accion;

//        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
        in_Ing_Egr_Inven_Info Info_ing_egr_Inven_ = new in_Ing_Egr_Inven_Info();

        //List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();

        BindingList<in_Ing_Egr_Inven_det_Info> ListBinding_Ing_Egr_Inven_det = new BindingList<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();

        
        //Listas para validar estado de cierre de oc
        List<in_Ing_Egr_Inven_det_Info> lst_ing_x_oc = new List<in_Ing_Egr_Inven_det_Info>();
        List<com_ordencompra_local_det_Info> lst_oc_det = new List<com_ordencompra_local_det_Info>();
        com_ordencompra_local_det_Bus bus_oc_det = new com_ordencompra_local_det_Bus();


        public delegate void delegate_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Ingreso_varios_Mant_FormClosing event_FrmIn_Ingreso_varios_Mant_FormClosing; 
        int RowHandle = 0;

        #endregion
            
        public FrmIn_Ingreso_varios_Mant()
        {
            InitializeComponent();

            ucGe_Menu_Superior_Mant1.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu_Superior_Mant1.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu_Superior_Mant1.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu_Superior_Mant1.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu_Superior_Mant1.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu_Superior_Mant1.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;

            event_FrmIn_Ingreso_varios_Mant_FormClosing += FrmIn_Ingreso_varios_Mant_event_FrmIn_Ingreso_varios_Mant_FormClosing;

            gridViewProductos.CellValueChanging += gridViewProductos_CellValueChanging;

            ucIn_Sucursal_Bodega1.Event_cmb_bodega1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged;

            ucIn_Sucursal_Bodega1.Event_cmb_sucursal1_EditValueChanged += ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged;
          
            
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {                         
                carga_Combos_Productos_y_Tipo_Movi();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucIn_Sucursal_Bodega1_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Accion != Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado)
                {
                    carga_Combos_Productos_y_Tipo_Movi();    
                }
                
            }
            catch (Exception ex)
            {               
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
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

        void FrmIn_Ingreso_varios_Mant_event_FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
       
        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    if (ValidarAnulacion_x_Estado())
                    {
                        Get_Info();

                        string mensaje = "";
                        if (MessageBox.Show("Esta seguro que desea eliminar la transaccion ", "Sistemas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        { return; }
                        Core.Erp.Winform.General.FrmGe_MotivoAnulacion ofrm = new General.FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();
                        Info_ing_egr_Inven_.MotivoAnulacion = ofrm.motivoAnulacion;
                        Info_ing_egr_Inven_.IdusuarioUltAnu = param.IdUsuario;

                        Info_ing_egr_Inven_.Fecha_UltAnu = param.Fecha_Transac;

                        if (Bus_IngEgr.AnularDB(Info_ing_egr_Inven_, ref mensaje))
                        {
                            MessageBox.Show(mensaje, "Sistemas");
                            lblAnulado.Visible = true;

                            //  anular movimiento inventario                  
                            infoMovInv = new in_movi_inve_Info();
                            string msgAnula = "";

                            //consulta detalle
                            var item = ListBinding_Ing_Egr_Inven_det.FirstOrDefault();

                            infoMovInv = bus_MovInv.Get_Info_Movi_inven(Convert.ToInt32(item.IdEmpresa_inv), Convert.ToInt32(item.IdSucursal_inv), Convert.ToInt32(item.IdBodega_inv), Convert.ToInt32(item.IdMovi_inven_tipo_inv), Convert.ToDecimal(item.IdNumMovi_inv));

                            if (bus_MovInv.AnularDB(infoMovInv, param.Fecha_Transac, ref msgAnula))
                            {
                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                                MessageBox.Show("Movimiento de Inventario Anulado: " + msgAnula, param.Nombre_sistema);
                            }
                        }
                        else
                        {
                            string msgRecurso = Core.Erp.Recursos.Properties.Resources.msgError_Anular;
                            MessageBox.Show(msgRecurso + "\n" + mensaje);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean ValidarAnulacion_x_Estado()
        {
            try
            {
                foreach (var item in ListBinding_Ing_Egr_Inven_det)
                {
                    if (item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        MessageBox.Show("No Se Puede Anular por que hay Registros Aprobados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
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

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Imprimir_ing_x_oc()
        {
            try
            {
                int IdEmpresa = 0;
                int IdSucursal = 0;
                int IdBodega = 0;
                int IdMovi_inven_tipo = Info_ing_egr_Inven_.IdMovi_inven_tipo;
                decimal IdNumMovi = 0;
                
                com_parametro_Info info_Comparam = new com_parametro_Info();
                com_parametro_Bus bus_Comparam = new com_parametro_Bus();
                info_Comparam = bus_Comparam.Get_Info_parametro(param.IdEmpresa);

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        XINV_NAT_Rpt004_Rpt reporte_personalizado = new XINV_NAT_Rpt004_Rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        IdNumMovi = Convert.ToDecimal(txtNumIngreso.Text);
                        IdMovi_inven_tipo = Info_ing_egr_Inven_.IdMovi_inven_tipo == 0 ? Convert.ToInt32(info_Comparam.IdMovi_inven_tipo_OC) : Info_ing_egr_Inven_.IdMovi_inven_tipo;

                        reporte_personalizado.PIdEmpresa.Value = IdEmpresa;
                        reporte_personalizado.PIdSucursal.Value = IdSucursal;
                        reporte_personalizado.PIdBodega.Value = IdBodega;
                        reporte_personalizado.PIdNumMovi.Value = IdNumMovi;
                        reporte_personalizado.PIdMovi_inven_tipo.Value = IdMovi_inven_tipo;

                        reporte_personalizado.PIdEmpresa.Visible = false;
                        reporte_personalizado.PIdSucursal.Visible = false;
                        reporte_personalizado.PIdBodega.Visible = false;
                        reporte_personalizado.PIdNumMovi.Visible = false;
                        reporte_personalizado.PIdMovi_inven_tipo.Visible = false;

                        reporte_personalizado.RequestParameters = false;

                        reporte_personalizado.ShowPreviewDialog();

                        break;
                    default:
                        XCOMP_Rpt003_Rpt reporte = new XCOMP_Rpt003_Rpt();

                        IdEmpresa = param.IdEmpresa;
                        IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        IdNumMovi = Convert.ToDecimal(txtNumIngreso.Text);
                        IdMovi_inven_tipo = Convert.ToInt32(info_Comparam.IdMovi_inven_tipo_OC);

                        reporte.set_parametros(IdEmpresa, IdSucursal, IdBodega, IdNumMovi, IdMovi_inven_tipo);
                        reporte.RequestParameters = true;

                        reporte.ShowPreviewDialog();
                        break;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (lst_ing_x_oc.Count > 0)
                {
                    Imprimir_ing_x_oc();
                }
                else
                {
                    XINV_Rpt001_Rpt Reporte = new XINV_Rpt001_Rpt();
                    Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    Reporte.Parameters["IdSucursal"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                    Reporte.Parameters["IdBodega"].Value = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                    Reporte.Parameters["IdTipoMoviInv"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                    Reporte.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);

                    Reporte.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;

                    Reporte.ShowPreviewDialog();
                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    if (grabar())
                    { Close(); }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Superior_Mant1_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                    grabar();
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void carga_Combos_Productos_y_Tipo_Movi()
        {
            try
            {
                cmbTipoMovi.cargar_TipoMotivo(Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue), "+", "");
                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue!=null)
                {
                    listProducto = Bus_Producto.Get_list_Producto_modulo_x_inventario(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                    cmbProducto_grid.DataSource = listProducto;
                }
                    
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        void carga_Combos()
        {
            try
            {
                carga_Combos_Productos_y_Tipo_Movi();
                string MensajeError = "";
                // carga centro costo         
                list_centroCosto = Bus_CentroCosto.Get_list_Centro_Costo(param.IdEmpresa);
                cmbCentroCosto_grid.DataSource = list_centroCosto;

                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentrocosto.DataSource = list_subcentro_combo;

                //carga Punto cargo              
                list_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmbPuntoCargo_grid.DataSource = list_punto_cargo;
                cmbPuntoCargo_grid.DisplayMember = "nom_punto_cargo";
                cmbPuntoCargo_grid.ValueMember = "IdPunto_cargo";

                //cargar Grupo Pto de Cargo
                list_grupo_punto_cargo = bus_grupo_punto_cargo.Get_List_punto_cargo_grupo(param.IdEmpresa, ref MensajeError);
                cmb_Punto_cargo_grupo.DataSource = list_grupo_punto_cargo;

                list_unidad_medida = Bus_Uni_Med.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = list_unidad_medida;
                cmb_unidad_medida_convertida.DataSource = list_unidad_medida; 
            }
            catch (Exception ex)
            {                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        void Inhabilita_Controles()
        {
            try
            {
                txtNumIngreso.ReadOnly = true;

                //txtCodigo.ReadOnly = true;

                //dtpFecha.Enabled = false;

                cmbTipoMovi.Enabled = false;

                cmbMotivoInv.Enabled = false;

                //txtObservacion.ReadOnly = true;
             
                
                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = false;              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDatos()
        {
            try
            {
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                txtCodigo.Text = "";
                
                txtObservacion.Text = "";                             
                dtpFecha.Value = DateTime.Now;
                Info_ing_egr_Inven_ = new in_Ing_Egr_Inven_Info();
                Info_ing_egr_Inven_.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                lst_ing_x_oc = new List<in_Ing_Egr_Inven_det_Info>();

                ListBinding_Ing_Egr_Inven_det = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = ListBinding_Ing_Egr_Inven_det;
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv.CargarDatos_CbteCble(0, 0, 0, 0, 0);
                colmv_costo_sin_conversion.OptionsColumn.AllowEdit = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region set get info

                public void setInfo(in_Ing_Egr_Inven_Info Info_)
                {

                    Info_ing_egr_Inven_ = Bus_IngEgr.GetInfo(Info_.IdEmpresa, Info_.IdSucursal, Info_.IdMovi_inven_tipo, Info_.IdNumMovi);
                }
       
                public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
                {
                    Accion = iAccion;
                }

                private void set_Accion_in_Controls()
                {
                    try
                    {
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
                            case Cl_Enumeradores.eCliente_Vzen.CAH:
                                colIdRegistro_subcentro.Visible = false;
                                col_IdCentroCosto_sub_centro_costo.Visible = false;
                                col_grupo_pto_cargo.Visible = true;
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
                                ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                                ucGe_Menu_Superior_Mant1.Visible_bntAnular = false;

                                this.colmv_costo.OptionsColumn.AllowEdit = true;

                                this.txtNumIngreso.Enabled = false;
                                this.txtNumIngreso.BackColor = System.Drawing.Color.White;
                                this.txtNumIngreso.ForeColor = System.Drawing.Color.Black;

                                break;
                            case Cl_Enumeradores.eTipo_action.actualizar:

                                ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                                Inhabilita_Controles();
                                dtpFecha.Enabled = true;
                                txtObservacion.Enabled = true;
                                setInfo_In_controls();

                                break;
                            case Cl_Enumeradores.eTipo_action.Anular:

                                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                                ucGe_Menu_Superior_Mant1.Enabled_bntLimpiar = false;

                                Inhabilita_Controles();
                                setInfo_In_controls();

                                break;
                            case Cl_Enumeradores.eTipo_action.consultar:

                                ucGe_Menu_Superior_Mant1.Visible_btnGuardar = false;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = false;
                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;

                                Inhabilita_Controles();
                                setInfo_In_controls();
                                break;
                            case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:
                                ucGe_Menu_Superior_Mant1.Enabled_btnGuardar = true;
                                ucGe_Menu_Superior_Mant1.Visible_bntGuardar_y_Salir = true;
                                ucGe_Menu_Superior_Mant1.Enabled_bntAnular = false;
                                gridControlProductos.Enabled = false;
                                Inhabilita_Controles();
                                dtpFecha.Enabled = true;
                                txtObservacion.Enabled = true;
                                cmbMotivoInv.Enabled = true;
                                ucIn_Sucursal_Bodega1.cmb_bodega.Enabled = true; 
                                setInfo_In_controls();
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

                private void setInfo_In_controls()
                {
                    try
                    {
                        Info_ing_egr_Inven_ = Bus_IngEgr.GetInfo(param.IdEmpresa, Info_ing_egr_Inven_.IdSucursal, Info_ing_egr_Inven_.IdMovi_inven_tipo, Info_ing_egr_Inven_.IdNumMovi);
                        if (Info_ing_egr_Inven_ == null)
                            return;
                        
                        txtNumIngreso.Text = Convert.ToString(Info_ing_egr_Inven_.IdNumMovi);                
                        ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue = Info_ing_egr_Inven_.IdSucursal;
                        ucIn_Sucursal_Bodega1.cmb_bodega.EditValue = Info_ing_egr_Inven_.IdBodega;
                        dtpFecha.Value = Info_ing_egr_Inven_.cm_fecha;              
                        cmbTipoMovi.set_TipoMoviInvInfo(Info_ing_egr_Inven_.IdMovi_inven_tipo);
                        txtObservacion.Text = Info_ing_egr_Inven_.cm_observacion;
                        txtCodigo.Text = Info_ing_egr_Inven_.CodMoviInven;

               
                        cmbMotivoInv.set_MotivoInvInfo(Convert.ToInt32(Info_ing_egr_Inven_.IdMotivo_Inv));
                                      
                        lblAnulado.Visible = Info_ing_egr_Inven_.Estado == "I" ? true : false;

                        //consulta detalle

                        ListBinding_Ing_Egr_Inven_det = new BindingList<in_Ing_Egr_Inven_det_Info>(Bus_IngEgrDet.Get_List_Ing_Egr_Inven_det(param.IdEmpresa, Info_ing_egr_Inven_.IdSucursal, Info_ing_egr_Inven_.IdMovi_inven_tipo, Info_ing_egr_Inven_.IdNumMovi));
                        gridControlProductos.DataSource = ListBinding_Ing_Egr_Inven_det;
                        
                        #region Obtengo Id de oc para validar
                        if (ListBinding_Ing_Egr_Inven_det.Where(q => q.IdOrdenCompra != null).Count() > 0)
                        {
                            lst_ing_x_oc = (from q in ListBinding_Ing_Egr_Inven_det
                                            group q by new { q.IdEmpresa_oc, q.IdSucursal_oc, q.IdOrdenCompra } into g
                                            select new in_Ing_Egr_Inven_det_Info
                                            {
                                                IdEmpresa_oc = g.Key.IdEmpresa_oc,
                                                IdSucursal_oc = g.Key.IdSucursal_oc,
                                                IdOrdenCompra = g.Key.IdOrdenCompra,
                                            }).ToList();

                            colmv_costo_sin_conversion.OptionsColumn.AllowEdit = false;
                        }
                        #endregion

                        var item = ListBinding_Ing_Egr_Inven_det.FirstOrDefault();
                        if (ListBinding_Ing_Egr_Inven_det != null)
                        {
                            if (ListBinding_Ing_Egr_Inven_det.Count != 0)
                                cmb_Estado_apro_x_Ing_Egr_Inven1.set_Info(item.IdEstadoAproba);
                        }

                        if (item != null)
                        {
                            if (item.IdEstadoAproba == "APRO")
                                cmb_Estado_apro_x_Ing_Egr_Inven1.Enabled = false;

                            ucInv_GridCbte_Cble_x_Ing_Egr_Inv.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));
                        }
                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                void Get_Info()
                {
                    try
                    {

                        Info_ing_egr_Inven_ = new in_Ing_Egr_Inven_Info();
                        Info_ing_egr_Inven_.IdEmpresa = param.IdEmpresa;
                        Info_ing_egr_Inven_.IdNumMovi = Convert.ToDecimal((txtNumIngreso.Text == "") ? "0" : txtNumIngreso.Text);
                        Info_ing_egr_Inven_.IdSucursal = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue);
                        Info_ing_egr_Inven_.IdBodega = Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue);
                        Info_ing_egr_Inven_.CodMoviInven = txtCodigo.Text;
                        Info_ing_egr_Inven_.cm_observacion = txtObservacion.Text;
                        Info_ing_egr_Inven_.IdMovi_inven_tipo = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                        Info_ing_egr_Inven_.cm_fecha = dtpFecha.Value;
                        Info_ing_egr_Inven_.IdUsuario = param.IdUsuario;
                        Info_ing_egr_Inven_.nom_pc = param.nom_pc;
                        Info_ing_egr_Inven_.ip = param.ip;
                        Info_ing_egr_Inven_.Fecha_Transac = param.Fecha_Transac;
                        Info_ing_egr_Inven_.signo = "+";
                        Info_ing_egr_Inven_.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;
                        Info_ing_egr_Inven_.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>(ListBinding_Ing_Egr_Inven_det);



                    }
                    catch (Exception ex)
                    {
                        Log_Error_bus.Log_Error(ex.ToString());
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        #endregion

        public Boolean grabar()
        {
            try
            {
                txtNumIngreso.Focus();
                Get_Info();
                string mensaje = "";
                string msgRecurso = "";
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:

                        Boolean resultB;
                        resultB = true;

                        decimal IdNumMovi = 0;
                        Info_ing_egr_Inven_.IdUsuario = param.IdUsuario;
                        //if (Bus_IngEgr.GuardarDB(Info_ing_egr_Inven_ , ref   IdNumMovi, ref mensaje))
                        if (Bus_IngEgr.NuevoGuardar(Info_ing_egr_Inven_))
                        {
                            txtNumIngreso.Text = Convert.ToString(Info_ing_egr_Inven_.IdNumMovi.ToString());
                            msgRecurso = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro del Ingreso a Bodega ", Info_ing_egr_Inven_.IdNumMovi.ToString());
                            MessageBox.Show(msgRecurso, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //consulta detalle
                            var item = Info_ing_egr_Inven_.listIng_Egr.FirstOrDefault();
                            ucInv_GridCbte_Cble_x_Ing_Egr_Inv.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));


                            if (MessageBox.Show("Desea Imprimir el Ingreso", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                        Info_ing_egr_Inven_.IdUsuario = param.IdUsuario;
                        Info_ing_egr_Inven_.IdUsuarioUltModi = param.IdUsuario;
                        Info_ing_egr_Inven_.Fecha_UltMod = param.Fecha_Transac;
                        //if (Bus_IngEgr.ModificarDB(Info_ing_egr_Inven_, ref mensaje))
                        if (Bus_IngEgr.NuevoModificar(Info_ing_egr_Inven_))
                        {
                            if (lst_ing_x_oc.Where(q => q.IdOrdenCompra != null).Count() > 0)
                            {
                                foreach (var item in lst_ing_x_oc)
                                {
                                    Modificar_estado_cierre_oc(Convert.ToInt32(item.IdEmpresa_oc), Convert.ToInt32(item.IdSucursal_oc), Convert.ToDecimal(item.IdOrdenCompra));
                                }
                            }
                            MessageBox.Show("El registro #" + Info_ing_egr_Inven_.IdNumMovi.ToString()+" ha sido actualizado exitósamente", "Sistemas");
                            LimpiarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el registro: " + mensaje, param.Nombre_sistema);
                            return false;
                        }

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar_proceso_cerrado:

                        Info_ing_egr_Inven_.IdUsuarioUltModi = param.IdUsuario;
                        Info_ing_egr_Inven_.Fecha_UltMod = param.Fecha_Transac;
                        if (Bus_IngEgr.ModificarDB_proceso_cerrado(Info_ing_egr_Inven_, ref mensaje))
                        {
                            MessageBox.Show(mensaje, "Sistemas");
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
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
       
       
        }
      
        private void FrmIn_Ingreso_varios_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                if (Accion == 0) { Accion = Cl_Enumeradores.eTipo_action.grabar; }
                gridControlProductos.DataSource = ListBinding_Ing_Egr_Inven_det;
                ucIn_Sucursal_Bodega1.set_Idsucursal(param.IdSucursal);
                ucIn_Sucursal_Bodega1.cmb_sucursal.Properties.ReadOnly = true;
                carga_Combos();
                set_Accion_in_Controls();
             
            }
            catch (Exception ex)
            {               
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoDet = (in_Ing_Egr_Inven_det_Info)this.gridViewProductos.GetFocusedRow();
                if (e.Column == colIdProducto) 
                {
                    foreach (var item in ListBinding_Ing_Egr_Inven_det )
                    {
                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                        if (item.IdProducto == InfoDet.IdProducto)
                        {
                            item.cod_producto = itemProd.pr_codigo;
                            item.mv_costo = itemProd.pr_costo_promedio == null ? 0 : Convert.ToDouble(itemProd.pr_costo_promedio);
                            item.mv_costo_sinConversion = itemProd.pr_costo_promedio == null ? 0 : Convert.ToDouble(itemProd.pr_costo_promedio);
                            item.pr_descripcion = itemProd.pr_descripcion;
                            item.IdUnidadMedida = itemProd.IdUnidadMedida;
                            item.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida;
                        }                                                                                      
                    }
                }

                if (e.Column == coldm_cantidad_sin_conversion)
                {
                    foreach (var item in ListBinding_Ing_Egr_Inven_det)
                    {
                        if (item.dm_cantidad_sinConversion < 0)
                        {
                            item.dm_cantidad_sinConversion = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void FrmIn_Ingreso_varios_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Ingreso_varios_Mant_FormClosing(sender,e);
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void gridViewProductos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                
                var Item = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetRow(e.FocusedRowHandle);
                RowHandle = e.FocusedRowHandle;
                if (RowHandle != 0)
                {
                    /* SE COMENTO PORQUE NO ESTA PROBADA, HAY ERRORES QUE NO DEJAN CONTINUAR
                    if (ListBinding_Ing_Egr_Inven_det.Count() != 0)
                    {
                        if (ListBinding_Ing_Egr_Inven_det.Last().IdProducto != 0 && ListBinding_Ing_Egr_Inven_det.Last().dm_cantidad_sinConversion != 0 && ListBinding_Ing_Egr_Inven_det.Last().IdUnidadMedida != null)
                        {
                            in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                            info.IdCentroCosto = InfoDet.IdCentroCosto;
                            info.IdPunto_cargo_grupo = InfoDet.IdPunto_cargo_grupo;
                            info.IdPunto_cargo = InfoDet.IdPunto_cargo;
                            ListBinding_Ing_Egr_Inven_det.Add(info);
                        }

                    }
                     */
                }

                if (Item == null) return;
                
                foreach (var item in Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(gridViewProductos.GetFocusedRowCellValue(colIdCentroCosto_grid))))
                {
                    item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                }

                
                if (Item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                {
                    colIdProducto.OptionsColumn.AllowEdit = false;
                    coldm_cantidad_sin_conversion.OptionsColumn.AllowEdit = false;
                    coldm_observacion.OptionsColumn.AllowEdit = false;
                    //colUnidadMedida_Grid.OptionsColumn.AllowEdit = false;
                    colIdCentroCosto_grid.OptionsColumn.AllowEdit = false;
                    colIdPunto_cargo.OptionsColumn.AllowEdit = false;                    
                }
                else
                {
                    colIdProducto.OptionsColumn.AllowEdit = true;
                    coldm_cantidad_sin_conversion.OptionsColumn.AllowEdit = true;
                    coldm_observacion.OptionsColumn.AllowEdit = true;
                    //colUnidadMedida_Grid.OptionsColumn.AllowEdit = true;
                    colIdCentroCosto_grid.OptionsColumn.AllowEdit = true;
                    colIdPunto_cargo.OptionsColumn.AllowEdit = true;
                }      
               
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name + " " + this.Name;
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
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
                    var QProducto = listProducto.FirstOrDefault(v => v.IdEmpresa==param.IdEmpresa && v.pr_codigo == cod_producto);
                    if (QProducto != null)
                    { Info_Producto = listProducto.FirstOrDefault(v => v.IdEmpresa == param.IdEmpresa && v.pr_codigo == cod_producto); }
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

                    ListBinding_Ing_Egr_Inven_det.Add(newRow);
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

        Boolean ValidarDatos()
        {
            try
            {
                txtCodigo.Focus();
                info_parametro = bus_parametro.Get_Info_Parametro(param.IdEmpresa);

                if (ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue ==  null || ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Sucursal", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == null || ucIn_Sucursal_Bodega1.cmb_bodega.EditValue == "")
                {
                    MessageBox.Show("Seleccione la Bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbTipoMovi.get_TipoMoviInvInfo() == null )
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cmbMotivoInv.get_MotivoInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Motivo del Inventario", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                if (ListBinding_Ing_Egr_Inven_det.Count() <= 0)
                {
                    MessageBox.Show("Ingrese al menos un Producto", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                string Producto_no_contabilizado = "";
                foreach (var item in ListBinding_Ing_Egr_Inven_det)
                {
                    if (item.dm_cantidad_sinConversion == 0)
                    {
                        MessageBox.Show("Ingrese la cantidad para el producto " + item.IdProducto, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (item.IdUnidadMedida_sinConversion == "" || item.IdUnidadMedida_sinConversion == null)
                    {
                        MessageBox.Show("Seleccione la Unidad de Medida para el producto " + item.IdProducto , param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                    
                    in_Producto_Info producto = listProducto.FirstOrDefault(q => q.IdProducto == item.IdProducto && q.IdEmpresa == param.IdEmpresa && q.IdSucursal == ucIn_Sucursal_Bodega1.get_sucursal().IdSucursal && q.IdBodega == ucIn_Sucursal_Bodega1.get_bodega().IdBodega);
                    bool se_valida_paramatrizacion_contable_x_producto = info_parametro.P_se_valida_parametrizacion_x_producto == null ? false : (bool)info_parametro.P_se_valida_parametrizacion_x_producto;
                    if (se_valida_paramatrizacion_contable_x_producto)
                    {
                        if (producto.IdCtaCble_Inventario == null || producto.IdCtaCble_Costo == null)
                        {
                            if (Producto_no_contabilizado == "") Producto_no_contabilizado = producto.pr_descripcion_2;
                            else Producto_no_contabilizado += "\n" + producto.pr_descripcion_2;
                        }
                    }
                }
                if (Producto_no_contabilizado != "")
                {
                    MessageBox.Show("Los siguientes productos no estan parametrizados contablemente, por favor corrija:\n" + Producto_no_contabilizado, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
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
                
        void llamarFormulario_Producto()
        {
            try
            {
                FrmIn_Producto_Mant frm = new FrmIn_Producto_Mant();
                frm.ShowDialog();
                listProducto = Bus_Producto.Get_list_Producto(param.IdEmpresa, Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_sucursal.EditValue), Convert.ToInt32(ucIn_Sucursal_Bodega1.cmb_bodega.EditValue));
                cmbProducto_grid.DataSource = listProducto;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProductos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.Name == colIdProducto.Name)
                {

                    if (Convert.ToDouble(gridViewProductos.GetFocusedRowCellValue(colIdProducto)) == 0)
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

        private void cmb_subcentrocosto_Click(object sender, EventArgs e)
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
                            gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, info_subcentro == null ? null : info_subcentro.IdRegistro);
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

        private void cmbPuntoCargo_grid_Click(object sender, EventArgs e)
        {
            try
            {
                in_Ing_Egr_Inven_det_Info row = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetFocusedRow();
                if (row != null)
                {
                    if (row.IdPunto_cargo_grupo != null)
                    {
                        frmCon_Punto_Cargo_Cons frm_cons = new frmCon_Punto_Cargo_Cons();

                        GridViewInfo info = gridViewProductos.GetViewInfo() as GridViewInfo;
                        GridCellInfo info_cell = info.GetGridCellInfo(RowHandle, colIdPunto_cargo);

                        frm_cons.Cargar_grid_x_grupo((int)row.IdPunto_cargo_grupo);

                        //frm_cons.Location = new Point(this.Right, gridControlDiario.Top);                        

                        frm_cons.ShowDialog();
                        info_punto_cargo = frm_cons.Get_Info();
                        if (info_punto_cargo != null)
                        {
                            gridViewProductos.SetFocusedRowCellValue(colIdPunto_cargo, info_punto_cargo.IdPunto_cargo);
                        }
                        else
                            gridViewProductos.SetFocusedRowCellValue(colIdPunto_cargo, null);
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

        private void Modificar_estado_cierre_oc(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
        {

            try
            {
                List<in_Ing_Egr_Inven_det_Info> lista_IngEgr = new List<in_Ing_Egr_Inven_det_Info>();
                lista_IngEgr = Bus_IngEgrDet.Get_List_Ing_Egr_det_x_OC_Agrupado(IdEmpresa, IdSucursal, IdOrdenCompra);

                if (lista_IngEgr.Count != 0)
                {
                    string Estado_cierre = "";

                    foreach (var item2 in lista_IngEgr)
                    {
                        //consulta detalle OC
                        com_ordencompra_local_det_Bus bus_detoc = new com_ordencompra_local_det_Bus();
                        com_ordencompra_local_Bus bus_oc = new com_ordencompra_local_Bus();

                        List<com_ordencompra_local_det_Info> lista_oc = new List<com_ordencompra_local_det_Info>();
                        lista_oc = bus_detoc.Get_List_ordencompra_local_det_Agrupado(IdEmpresa, IdSucursal, IdOrdenCompra);

                        if (lista_oc.Count != 0)
                        {
                            com_ordencompra_local_det_Info itemDet = lista_oc.FirstOrDefault(q => q.IdEmpresa == item2.IdEmpresa_oc && q.IdSucursal == item2.IdSucursal_oc && q.IdOrdenCompra == item2.IdOrdenCompra);

                            if (item2.dm_cantidad > 1 && item2.dm_cantidad < itemDet.do_Cantidad)
                            {
                                // actualizar cabecera OC estado cierre="PEN"
                                Estado_cierre = "PEN";
                                bus_oc.Modificar_Estado_Cierre(Convert.ToInt32(item2.IdEmpresa_oc), Convert.ToInt32(item2.IdSucursal_oc), Convert.ToDecimal(item2.IdOrdenCompra), Estado_cierre);
                            }
                            else
                                if (item2.dm_cantidad == itemDet.do_Cantidad)
                                {
                                    // actualizar cabecera OC estado cierre="CERR"
                                    Estado_cierre = "CERR";
                                    bus_oc.Modificar_Estado_Cierre(Convert.ToInt32(item2.IdEmpresa_oc), Convert.ToInt32(item2.IdSucursal_oc), Convert.ToDecimal(item2.IdOrdenCompra), Estado_cierre);
                                }
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
    }
}
