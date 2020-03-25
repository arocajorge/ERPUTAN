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
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Winform.Contabilidad;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Egresos_Inv_Multi_Bodega_Mant : Form
    {
        #region Variables
        //Bus        
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Producto;        
        in_UnidadMedida_Bus Bus_Uni_Med;
        in_Ing_Egr_Inven_det_Bus bus_IngEgrDet;
        in_Ing_Egr_Inven_Bus bus_IngEgr = new in_Ing_Egr_Inven_Bus();
        in_movi_inve_Bus bus_MovInv;
        tb_Bodega_Bus Bus_Bodega;
        ct_Centro_costo_Bus bus_centro_costo;
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        ct_punto_cargo_Bus bus_punto_cargo;
        string MensajeError = "";
        //Listas   
        List<ct_Centro_costo_Info> list_centro_costo;
        List<ct_punto_cargo_Info> list_punto_cargo;
        List<in_Producto_Info> listProducto;
        
        List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet;        
        List<tb_Bodega_Info> list_bodega;
        List<in_Ing_Egr_Inven_det_Info> lista = new List<in_Ing_Egr_Inven_det_Info>();
        BindingList<in_Ing_Egr_Inven_det_Info> ListaBind;
        //Infos
        in_Ing_Egr_Inven_det_Info InfoDet;
        in_movi_inve_Info infoMovInv;
        in_movi_inve_x_ct_cbteCble_Info info_InMovxCble;
        public in_Ing_Egr_Inven_Info info_IngEgr { get; set; }
        //Variables
        private Cl_Enumeradores.eTipo_action Accion;
        public delegate void delegate_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
        public Boolean res = true;

        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();
        int RowHandle = 0;

        in_Producto_Info Item = new in_Producto_Info();

        List<in_UnidadMedida_Info> lst_unidad_medida = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();
        #endregion

        public FrmIn_Egresos_Inv_Multi_Bodega_Mant()
        {
            InitializeComponent();

            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_Superior_Mant1_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_Superior_Mant1_event_btnImprimir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_Superior_Mant1_event_btnlimpiar_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_Superior_Mant1_event_btnSalir_Click;
            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_Superior_Mant1_event_btnAnular_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing += FrmIn_Egresos_Inv_Multi_Bodega_Mant_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing;
            ucGe_Sucursal.event_cmbsucursal_EditValueChanged += ucGe_Sucursal_event_cmbsucursal_EditValueChanged;


            if (Accion == 0)
            { Accion = Cl_Enumeradores.eTipo_action.grabar; }
        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void FrmIn_Egresos_Inv_Multi_Bodega_Mant_event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {            
        }

        void ucGe_Sucursal_event_cmbsucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cargar_combos_sucursal();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_Egresos_Inv_Multi_Bodega_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = ListaBind;
              
                carga_Combos();

                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        setInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.grabar:
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntLimpiar = false;
                        setInfo();
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        setInfo();
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
              
        void ucGe_Menu_Superior_Mant1_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                anular();
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
                foreach (var item in ListaBind)
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
                    XINV_Rpt003_Rpt Reporte = new XINV_Rpt003_Rpt();
                    Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                    Reporte.Parameters["IdSucursal"].Value = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                    Reporte.Parameters["IdBodega"].Value = null;
                    Reporte.Parameters["IdMovi_inven_tipo"].Value = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                    Reporte.Parameters["IdNumMovi"].Value = Convert.ToDecimal(txtNumIngreso.Text);                   
                    Reporte.RequestParameters = false;
                    DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                    pt.AutoShowParametersPanel = false;

                    Reporte.ShowPreviewDialog();
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
                if (ValidarDatos())
                {
                    if (grabar())
                    { Close(); }
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
                if (ValidarDatos())
                    grabar();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cargar_combos_sucursal()
        {
            try
            {
                // carga combo tipo movi                               
                int IdSucursal = 0;
                IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                cmbTipoMovi.cargar_TipoMotivo(IdSucursal, 0, "-", "");

                // carga combo productos grid  
                Bus_Producto = new in_producto_Bus();
                listProducto = new List<in_Producto_Info>();
                //listProducto = Bus_Producto.Get_list_Producto(param.IdEmpresa, IdSucursal);
                listProducto = Bus_Producto.Get_list_Producto(param.IdEmpresa);
                cmbProducto_grid.DataSource = listProducto;

                // carga bodega 
                Bus_Bodega = new tb_Bodega_Bus();
                list_bodega = new List<tb_Bodega_Info>();
                list_bodega = Bus_Bodega.Get_List_Bodega(param.IdEmpresa, IdSucursal);
                cmb_bodega.DataSource = list_bodega;
                cmb_bodega.DisplayMember = "bo_Descripcion";
                cmb_bodega.ValueMember = "IdBodega";
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
                //centro de costo
                bus_centro_costo = new ct_Centro_costo_Bus();
                list_centro_costo = new List<ct_Centro_costo_Info>();
                list_centro_costo = bus_centro_costo.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);
                cmb_centro_costo.DataSource = list_centro_costo;
                cmb_centro_costo.DisplayMember = "Centro_costo2";
                cmb_centro_costo.ValueMember = "IdCentroCosto";

                //subcentro de costo
                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmb_subcentrocosto.DataSource = list_subcentro_combo;

                bus_punto_cargo = new ct_punto_cargo_Bus();
                list_punto_cargo = new List<ct_punto_cargo_Info>();
                list_punto_cargo = bus_punto_cargo.Get_List_PuntoCargo(param.IdEmpresa);
                cmb_punto_cargo.DataSource = list_punto_cargo;
                cmb_punto_cargo.DisplayMember = "nom_punto_cargo";
                cmb_punto_cargo.ValueMember = "IdPunto_cargo";

                lst_unidad_medida = bus_unidad_medida.Get_list_UnidadMedida();
                cmb_unidad_medida.DataSource = lst_unidad_medida;        
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }              
        }

        public void set_Accion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                Accion = iAccion;
                switch (Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        ucGe_Menu.Enabled_bntAnular = false;

                        this.txtNumIngreso.Enabled = false;
                        this.txtNumIngreso.BackColor = System.Drawing.Color.White;
                        this.txtNumIngreso.ForeColor = System.Drawing.Color.Black;

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;

                        Inhabilita_Controles();
                         dtpFecha.Enabled = true;
                        txtObservacion.Enabled = true;

                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntLimpiar = false;

                        Inhabilita_Controles();
                                                           
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntAnular = false;

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
                txtNumIngreso.Enabled = false;
                txtNumIngreso.BackColor = System.Drawing.Color.White;
                txtNumIngreso.ForeColor = System.Drawing.Color.Black;

                txtCodigo.Enabled = false;
                txtCodigo.BackColor = System.Drawing.Color.White;
                txtCodigo.ForeColor = System.Drawing.Color.Black;

                dtpFecha.Enabled = false;

                cmbTipoMovi.Enabled = false;
                cmbTipoMovi.BackColor = System.Drawing.Color.White;
                cmbTipoMovi.ForeColor = System.Drawing.Color.Black;
               
                txtObservacion.Enabled = false;
                txtObservacion.BackColor = System.Drawing.Color.White;
                txtObservacion.ForeColor = System.Drawing.Color.Black;
             
                ucGe_Sucursal.Enabled = false;

                cmbMotivoInv.Enabled = false;
                cmbMotivoInv.BackColor = System.Drawing.Color.White;
                cmbMotivoInv.ForeColor = System.Drawing.Color.Black;
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
                set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                txtNumIngreso.Text = "";
                txtCodigo.Text = "";           
                txtObservacion.Text = "";
                dtpFecha.Value = DateTime.Now;
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                lista = new List<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = ListaBind;
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
                info_IngEgr.IdSucursal = ucGe_Sucursal.get_SucursalInfo().IdSucursal;
                info_IngEgr.IdBodega = null;
                info_IngEgr.CodMoviInven = txtCodigo.Text;
                info_IngEgr.cm_observacion = txtObservacion.Text;
                info_IngEgr.IdMovi_inven_tipo = cmbTipoMovi.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info_IngEgr.cm_fecha = dtpFecha.Value;
                info_IngEgr.IdUsuario = param.IdUsuario;
                info_IngEgr.nom_pc = param.nom_pc;
                info_IngEgr.ip = param.ip;
                info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                info_IngEgr.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;
                info_IngEgr.signo = "-";
                      

                //armando el detalle                
                int focus = gridViewProductos.FocusedRowHandle;
                gridViewProductos.FocusedRowHandle = focus + 1;
                list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>(ListaBind);

                
                /*
                foreach (var item in ListaBind)
                {
                    //if (item.IdEstadoAproba == null || item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                    //{
                    sec = sec + 1;
                    in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                    info.Secuencia = sec;
                    info.IdEmpresa = info_IngEgr.IdEmpresa;
                    info.IdSucursal = info_IngEgr.IdSucursal;
                    info.IdNumMovi = info_IngEgr.IdNumMovi;
                    info.IdEstadoAproba = item.IdEstadoAproba;
                    info.IdBodega = item.IdBodega;
                    info.IdProducto = item.IdProducto;
                    info.dm_stock_ante = item.dm_stock_ante;
                    info.dm_stock_actu = item.dm_stock_actu;
                    info.dm_observacion = item.dm_observacion;
                    info.dm_precio = item.dm_precio;
                    info.dm_peso = item.dm_peso;
                    info.IdCentroCosto = item.IdCentroCosto;
                    info.IdCentroCosto_sub_centro_costo = (item.IdCentroCosto_sub_centro_costo == null) ? null : list_subcentro_combo.FirstOrDefault(v => v.IdCentroCosto == item.IdCentroCosto && v.IdRegistro == item.IdCentroCosto_sub_centro_costo).IdCentroCosto_sub_centro_costo;
                    info.pr_descripcion = item.pr_descripcion;
                    info.IdPunto_cargo = item.IdPunto_cargo;
                    info.IdEmpresa_inv = item.IdEmpresa_inv;
                    info.IdSucursal_inv = item.IdSucursal_inv;
                    info.IdBodega_inv = item.IdBodega_inv;
                    info.IdMovi_inven_tipo_inv = item.IdMovi_inven_tipo_inv;
                    info.IdNumMovi_inv = item.IdNumMovi_inv;
                    info.secuencia_inv = item.secuencia_inv;

                    info.pr_descripcion = item.pr_descripcion;
                    info.IdPunto_cargo = item.IdPunto_cargo;

                    info.IdUnidadMedida = item.IdUnidadMedida;
                    info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                    item.IdUnidadMedida_Consumo = item.IdUnidadMedida;

                    info.dm_cantidad_sinConversion = item.dm_cantidad;
                    info.mv_costo_sinConversion = item.mv_costo;

                    info.dm_cantidad = item.dm_cantidad;
                    info.mv_costo = item.mv_costo;

                    var itemBod = list_bodega.FirstOrDefault(q => q.IdBodega == item.IdBodega);
                    info.nom_bodega = itemBod.bo_Descripcion2;

                    list_IngEgrDet.Add(info);
                }*/


                info_IngEgr.listIng_Egr = list_IngEgrDet;                        
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Verifica_Detalle()
        {
            try
            {
                foreach (var item in info_IngEgr.listIng_Egr)
                {
                    if (item.IdBodega == 0 || item.IdBodega == null)
                    {
                        MessageBox.Show("Ingrese la bodega al Item: " + item.pr_descripcion + "", param.Nombre_sistema);
                        return false;
                    }

                    if (item.IdProducto == 0)
                    {
                        MessageBox.Show("Ingrese el producto a la Bodega: " + item.nom_bodega + "", param.Nombre_sistema);
                        return false;
                    }

                    if (item.dm_cantidad_sinConversion == 0)
                    {
                        MessageBox.Show("Ingrese la cantidad para el producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }                    
                    if (item.IdUnidadMedida_sinConversion == null || item.IdUnidadMedida_sinConversion == "")
                    {
                        MessageBox.Show("Ingrese la unidad de medida para el producto " + item.pr_descripcion, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
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

        public void setInfo()
        {
            try 
            {
                //Info = _Info;
                if (info_IngEgr == null)
                { return; }
                ucGe_Sucursal.set_SucursalInfo(info_IngEgr.IdSucursal);
                txtNumIngreso.Text = Convert.ToString(info_IngEgr.IdNumMovi);
                dtpFecha.Value = info_IngEgr.cm_fecha;
                cmbTipoMovi.set_TipoMoviInvInfo(info_IngEgr.IdMovi_inven_tipo);
                txtObservacion.Text = info_IngEgr.cm_observacion;
                txtCodigo.Text = info_IngEgr.CodMoviInven;
                cmbMotivoInv.set_MotivoInvInfo(Convert.ToInt32(info_IngEgr.IdMotivo_Inv));
                lblAnulado.Visible = info_IngEgr.Estado == "I" ? true : false;
                
                lista = new List<in_Ing_Egr_Inven_det_Info>();
                bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();
                lista = bus_IngEgrDet.Get_List_Ing_Egr_Inven_det(info_IngEgr.IdEmpresa, info_IngEgr.IdSucursal, info_IngEgr.IdMovi_inven_tipo, info_IngEgr.IdNumMovi);

                foreach (var items in lista)
                {
                    items.dm_cantidad = items.dm_cantidad < 0 ? items.dm_cantidad * -1 : items.dm_cantidad;
                    items.dm_cantidad_sinConversion = items.dm_cantidad_sinConversion < 0 ? items.dm_cantidad_sinConversion * -1 : items.dm_cantidad_sinConversion;
                }

                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista);
                gridControlProductos.DataSource = ListaBind;            
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        Boolean grabar()
        {
          try
            {
                txtNumIngreso.Focus();
                Get();
                string mensaje = "";
                res = false;

                if (Verifica_Detalle())
                {
                    switch (Accion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            decimal IdNumMovi = 0;
                            if (bus_IngEgr.GuardarDB(info_IngEgr, ref   IdNumMovi, ref mensaje))
                            {
                                txtNumIngreso.Text = Convert.ToString(IdNumMovi);
                                string smensaje = string.Format(Core.Erp.Recursos.Properties.Resources.msgDespues_Grabar, "El registro del Ingreso a Bodega ", IdNumMovi.ToString());
                                MessageBox.Show(smensaje, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (MessageBox.Show("Desea Imprimir el Egreso Multibodega", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    ucGe_Menu_Superior_Mant1_event_btnImprimir_Click(null, null);
                                }
                                LimpiarDatos();
                                res = true;
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
                                //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                                //ucGe_Menu.Enabled_btnGuardar = false;
                                MessageBox.Show(mensaje, param.Nombre_sistema);
                                LimpiarDatos();
                                res = true;
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
                }
                return res;                         
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        Boolean ValidarDatos()
        {
            try
            {
                txtObservacion.Focus();

                if (ucGe_Sucursal.get_SucursalInfo() == null)
                {
                    MessageBox.Show("Seleccione la Sucursal.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ucGe_Sucursal.Focus();
                    return false;
                }

                if (cmbMotivoInv.get_MotivoInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Motivo del Inventario.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbMotivoInv.Focus();
                    return false;
                }

                if (cmbTipoMovi.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Seleccione el Tipo de Movimiento.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbTipoMovi.Focus();
                    return false;
                }

                if (txtObservacion.Text == null || txtObservacion.Text == "")
                {
                    MessageBox.Show("Digite la Observación.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservacion.Focus();
                    return false;
                }

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Cl_Enumeradores.eCliente_Vzen.NATURISA:
                        foreach (var item in ListaBind)
                        {
                            if (item.IdCentroCosto == null || item.IdCentroCosto_sub_centro_costo == null)
                            {
                                MessageBox.Show("Todos los registros deben contener centro y subcentro de costo, por favor corrija",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                return false;
                            }
                            if (item.IdEstadoAproba == "APRO")
                            {
                                MessageBox.Show("Existen productos aprobados en este movimiento, este movimiento no puede ser modificado",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                        break;                    
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;


                in_Parametro_Bus busParam = new in_Parametro_Bus();
                var infoParam = busParam.Get_Info_Parametro(param.IdEmpresa);
                if (infoParam.Maneja_Stock_Negativo == "N")
                {
                    #region ValidarStock
                    var lst = ListaBind.Where(Q => Q.IdProducto != null).GroupBy(q => new { q.IdBodega, q.IdProducto, q.pr_descripcion, q.IdUnidadMedida_sinConversion }).Select(Q => new
                    {
                        IdProducto = Q.Key.IdProducto,
                        IdBodega = Q.Key.IdBodega,
                        pr_descripcion = Q.Key.pr_descripcion,
                        Cantidad = bus_unidad_medida.GetCantidadConvertida(param.IdEmpresa,Q.Key.IdProducto, Q.Key.IdUnidadMedida_sinConversion, Q.Sum(q => q.dm_cantidad_sinConversion)),
                        CantidadAnterior = Q.Sum(q => q.CantidadAnterior)
                    });

                    lst = lst.Where(Q => Q.IdProducto != null).GroupBy(q => new { q.IdBodega, q.IdProducto, q.pr_descripcion }).Select(Q => new
                    {
                        IdProducto = Q.Key.IdProducto,
                        IdBodega = Q.Key.IdBodega,
                        pr_descripcion = Q.Key.pr_descripcion,
                        Cantidad = Q.Sum(q=>q.Cantidad),
                        CantidadAnterior = Q.Sum(q => q.CantidadAnterior)
                    });

                    foreach (var item in lst)
                    {
                        if (!Bus_Producto.ValidarStock(param.IdEmpresa, ucGe_Sucursal.Get_IdSucursal(), item.IdBodega ?? 0, item.IdProducto, item.Cantidad, item.CantidadAnterior))
                        {
                            MessageBox.Show("El producto " + item.pr_descripcion + " no tiene stock suficiente para el egreso.", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                    #endregion
                }

                if (Accion == Cl_Enumeradores.eTipo_action.grabar && infoParam.P_ValidarDiasHaciaAtras != null && infoParam.P_ValidarDiasHaciaAtras != 0)
                {
                    // Difference in days, hours, and minutes.
                    TimeSpan ts = Convert.ToDateTime(dtpFecha.Value).Date - DateTime.Now.Date;
                    int differenceInDays = ts.Days;
                    if (differenceInDays < infoParam.P_ValidarDiasHaciaAtras)
                    {
                        MessageBox.Show("No se puede registrar una transacción mayor a los dias permitidos de atraso\nDias de atraso permitidos: "+infoParam.P_ValidarDiasHaciaAtras.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        public void anular()
        {
            try
            {
                if (info_IngEgr != null)
                {
                    FrmGe_MotivoAnulacion oFrm = new FrmGe_MotivoAnulacion();

                    if (info_IngEgr.Estado == "A")
                    {
                        if (MessageBox.Show("¿Está seguro que desea anular el egreso # " + info_IngEgr.IdNumMovi + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string msg = "";
                            oFrm.ShowDialog();

                            info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            info_IngEgr.MotivoAnulacion = oFrm.motivoAnulacion;

                            info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                            info_IngEgr.IdusuarioUltAnu = param.IdUsuario;

                            //info_IngEgr.cm_observacion = "***ANULADO****" + info_IngEgr.cm_observacion;
                            //bus_IngEgr = new in_Ing_Egr_Inven_Bus();
                            if (bus_IngEgr.AnularDB(info_IngEgr, ref msg))
                            {
                                ucGe_Menu.Enabled_bntAnular = false;
                                MessageBox.Show("Anulacion con exito # " + info_IngEgr.IdNumMovi);
                                info_IngEgr.Estado = "I";

                                lblAnulado.Visible = true;

                                Accion = Cl_Enumeradores.eTipo_action.consultar;
                            }
                        }
                    }
                    else if (info_IngEgr.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la devolucion de Compra N#: " + info_IngEgr.IdNumMovi +
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
        
        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                InfoDet = new in_Ing_Egr_Inven_det_Info();
                InfoDet = (in_Ing_Egr_Inven_det_Info)this.gridViewProductos.GetFocusedRow();
                if (InfoDet == null)
                    return;

                if (e.Column.Name == "colIdProducto")
                {
                    var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);
                    InfoDet.cod_producto = itemProd.pr_codigo;
                    
                    InfoDet.mv_costo = 0;
                    InfoDet.mv_costo_sinConversion = 0;
                    InfoDet.pr_descripcion = itemProd.pr_descripcion;                    
                    InfoDet.IdUnidadMedida = itemProd.IdUnidadMedida_Consumo;
                    InfoDet.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida_Consumo;
                }
                if (e.Column == coldm_cantidad)
                {
                    foreach (var item in ListaBind)
                    {
                        if (item.dm_cantidad_sinConversion < 0)
                        {
                            item.dm_cantidad_sinConversion = 0;
                        }                        
                    }
                }
                if (e.Column == colIdCentroCosto)
                {
                    gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, null);
                    gridViewProductos.SetRowCellValue(RowHandle, colIdCentroCosto_sub_centro_costo, null);
                }
                if (e.Column == col_cod_subcentro)
                {
                    if (InfoDet.IdCentroCosto != "" && InfoDet.IdCentroCosto != null)
                    {
                        string IdRegistro = InfoDet.IdCentroCosto;
                        IdRegistro = IdRegistro + "-" + Convert.ToString(e.Value);
                        info_subcentro = list_subcentro_combo.FirstOrDefault(q => q.IdCentroCosto == InfoDet.IdCentroCosto && q.IdCentroCosto_sub_centro_costo == InfoDet.IdCentroCosto_sub_centro_costo);
                        if (info_subcentro != null)
                        {
                            gridViewProductos.SetRowCellValue(e.RowHandle, colIdRegistro_subcentro, info_subcentro.IdRegistro);
                            gridViewProductos.SetRowCellValue(RowHandle, colIdCentroCosto_sub_centro_costo, info_subcentro.IdCentroCosto_sub_centro_costo);
                        }
                        else
                        {
                            gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, null);
                            //gridViewProductos.SetRowCellValue(RowHandle, colIdCentroCosto_sub_centro_costo, null);
                        }
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

        private void FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_FrmIn_Egresos_Inv_Multi_Bodega_Mant_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProductos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                RowHandle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void Llamar_pantalla_subcentro_costo()
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
                            //Se le asigna el IdRegistro al combo y el IdSubcentro a la columna de subcentro que se va a guardar
                            gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, info_subcentro == null ? null : info_subcentro.IdRegistro);
                            gridViewProductos.SetRowCellValue(RowHandle, colIdCentroCosto_sub_centro_costo, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
                            gridViewProductos.SetRowCellValue(RowHandle, col_cod_subcentro, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
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

        private void cmb_subcentrocosto_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_subcentro_costo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    if (Item != null)
                    {
                        lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida_equivalencia(Item.IdUnidadMedida);

                        FrmIn_Unidad_Medida_Consu frm_combo = new FrmIn_Unidad_Medida_Consu();
                        frm_combo.set_config_combo(lst_unidad_medida_para_combo);
                        frm_combo.ShowDialog();
                        info_unidad_medida = frm_combo.Get_info_unidad_medida();
                        gridViewProductos.SetRowCellValue(RowHandle, col_IdUnidadMedida, info_unidad_medida == null ? null : info_unidad_medida.IdUnidadMedida);
                    }
                    
                }                
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

        private void cmb_subcentrocosto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Llamar_pantalla_subcentro_costo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewProductos_CellValueChanging_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {                
                if (e.Column == colIdProducto)
                {
                    gridViewProductos.SetRowCellValue(e.RowHandle, colIdProducto, e.Value);
                }
                if (e.Column == colIdCentroCosto)
                {
                    gridViewProductos.SetRowCellValue(e.RowHandle, colIdCentroCosto, e.Value);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewProductos_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
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

    }
}
