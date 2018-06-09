
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.General;

using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Reportes.Inventario;

namespace Core.Erp.Winform.Inventario

{
    public partial class FrmIn_Transferencia_Mantenimiento : Form
    {
        #region Variables
        public delegate void delegate_frmIn_Transferencias_FormClosing(object sender, FormClosingEventArgs e);
        public event delegate_frmIn_Transferencias_FormClosing event_frmIn_Transferencias_FormClosing;

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        Cl_Enumeradores.eTipo_action _Accion;

        Boolean TerminoLoad = false;
        Decimal IdGuia = 0;
        string MensajeError = "";



        #region Declaraciones in_Parametro


        in_Parametro_Bus BusParamInv = new in_Parametro_Bus();
        in_Parametro_Info InfoParamInv = new in_Parametro_Info();

        #endregion


        #region Declaraciones Sucursal Info y  Bus

        tb_Sucursal_Info _SucursalInfoOrigen = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfoOrigen = new tb_Bodega_Info();
        tb_Sucursal_Info _SucursalInfoDestino = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfoDestino = new tb_Bodega_Info();
        #endregion


        #region Declaraciones in_Ing_Egr_Inven Info y Bus

            in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();
            BindingList<in_Ing_Egr_Inven_det_Info> ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
            
            List<in_Ing_Egr_Inven_det_Info> lista_IngEgrInv = new List<in_Ing_Egr_Inven_det_Info>();
            in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();

            List<in_Ing_Egr_Inven_det_Info> _ListaDetalleMoviInventario = new List<in_Ing_Egr_Inven_det_Info>();

            in_Ing_Egr_Inven_Bus bus_ing_egr = new in_Ing_Egr_Inven_Bus();
            in_Ing_Egr_Inven_Info info_ing = new in_Ing_Egr_Inven_Info();
            in_Ing_Egr_Inven_Info info_egr = new in_Ing_Egr_Inven_Info();
        #endregion

        #region Declaraciones in_producto Info y Bus
            in_producto_Bus Bus_Producto = new in_producto_Bus();
            in_producto_x_tb_bodega_Bus _BusProXBod = new in_producto_x_tb_bodega_Bus();
            List<in_Producto_Info> listProducto = new List<in_Producto_Info>();

            #endregion


        #region Declaraciones in_transferencia Info y Bus

                in_transferencia_bus oBus = new in_transferencia_bus();
                in_transferencia_x_in_Guia_x_traspaso_bodega_Info Info_Guia = new in_transferencia_x_in_Guia_x_traspaso_bodega_Info();
                in_transferencia_x_fa_guia_remision_Bus Bus_Inter = new in_transferencia_x_fa_guia_remision_Bus();
                in_transferencia_x_in_Guia_x_traspaso_bodega_Bus Bus_guia = new in_transferencia_x_in_Guia_x_traspaso_bodega_Bus();
            #endregion

        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();

        ct_Centro_costo_Bus Bus_CentroCosto = new ct_Centro_costo_Bus();
        List<ct_Centro_costo_Info> List_CentroCosto = new List<ct_Centro_costo_Info>();

        in_transferencia_Info InfoTransferencia = new in_transferencia_Info();
        in_UnidadMedida_Bus Bus_Uni_Med = new in_UnidadMedida_Bus();

        #endregion

        public FrmIn_Transferencia_Mantenimiento()
        {
            InitializeComponent();

            UCSucursalOrigen.Event_cmb_sucursal1_EditValueChanged += UCSucursalOrigen_Event_cmb_sucursal1_EditValueChanged;
            UCSucursalOrigen.Event_cmb_bodega1_EditValueChanged += UCSucursalOrigen_Event_cmb_bodega1_EditValueChanged;


            UCSucursalDestino.Event_cmb_sucursal1_EditValueChanged += UCSucursalDestino_Event_cmb_sucursal1_EditValueChanged;
            UCSucursalDestino.Event_cmb_bodega1_EditValueChanged += UCSucursalDestino_Event_cmb_bodega1_EditValueChanged;
            
            
            event_frmIn_Transferencias_FormClosing += new delegate_frmIn_Transferencias_FormClosing(frmIn_Transferencias_event_frmIn_Transferencias_FormClosing);

            ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;
            ucGe_Menu.event_btnGuardar_Click += ucGe_Menu_event_btnGuardar_Click;
            ucGe_Menu.event_btnGuardar_y_Salir_Click += ucGe_Menu_event_btnGuardar_y_Salir_Click;
            ucGe_Menu.event_btnImprimir_Click += ucGe_Menu_event_btnImprimir_Click;
            ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
            ucGe_Menu.event_btnlimpiar_Click += ucGe_Menu_event_btnlimpiar_Click;

            UCTipoMoviOrigen.event_cmbCatalogo_EditValueChanged += UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged;
            UCTipoMoviDestino.event_cmbCatalogo_EditValueChanged += UCTipoMoviDestino_event_cmbCatalogo_EditValueChanged;

            

        }

        void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
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

        void UCTipoMoviDestino_event_cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UCTipoMoviDestino.cargar_TipoMotivo(Convert.ToInt32(UCSucursalDestino.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursalDestino.cmb_bodega.EditValue), "+", "");
                UCTipoMoviDestino.set_TipoMoviInvInfo(Convert.ToInt32(InfoParamInv.IdMovi_inven_tipo_ingresoBodegaDestino));
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UCTipoMoviOrigen.cargar_TipoMotivo(Convert.ToInt32(UCSucursalOrigen.cmb_sucursal.EditValue), Convert.ToInt32(UCSucursalOrigen.cmb_bodega.EditValue), "-", "");
                UCTipoMoviOrigen.set_TipoMoviInvInfo(Convert.ToInt32( InfoParamInv.IdMovi_inven_tipo_egresoBodegaOrigen));
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCSucursalDestino_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (TerminoLoad == true)
                {
                    Get_IdSucursal_Bodega();
                    this.UCTipoMoviDestino_event_cmbCatalogo_EditValueChanged(sender, e);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCSucursalDestino_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                    Get_IdSucursal_Bodega();
                    this.UCTipoMoviDestino_event_cmbCatalogo_EditValueChanged(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCSucursalOrigen_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (TerminoLoad == true)
                {
                    
                    Get_IdSucursal_Bodega();

                    this.UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged(sender, e);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UCSucursalOrigen_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //if (TerminoLoad == true)
                //{
                    Get_IdSucursal_Bodega();

                    this.UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged(sender, e);

                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
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

        void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            try
            {

                if (Accion_Grabar())
                {
                    Close();
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
                if (Accion_Grabar())
                {
                    LimpiarDatos();
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                    set_accion_controls();
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
                if (ValidarAnulacion_x_Estado())
                {
                    in_movi_inve_Bus _BusMOviInve = new in_movi_inve_Bus();
                    in_movi_inve_Info _InfoMoviInv = new in_movi_inve_Info();
                    string mensaje = "";


                    if (InfoTransferencia.IdTransferencia == 0)
                    { return; }
                    if (InfoTransferencia.Estado == "I")
                    {
                        MessageBox.Show("No se puede anular la transferencia por que ya se encuentra anulada");
                        return;
                    }
                    if (MessageBox.Show("¿Está seguro que desea anular la transferencia ?", "Anulación de transferencia " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();
                        InfoTransferencia.MotivoAnu = ofrm.motivoAnulacion;
                        InfoTransferencia.ip = param.ip;
                        InfoTransferencia.nom_pc = param.nom_pc;
                        InfoTransferencia.IdUsuarioUltAnu = param.IdUsuario;
                        InfoTransferencia.Fecha_UltAnu = DateTime.Now;
                        InfoTransferencia.IdEmpresa = param.IdEmpresa;
                        if (ofrm.cerrado == "N")
                        {
                            oBus.Anular(InfoTransferencia, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje);
                            ucGe_Menu.Enabled_bntAnular = false;
                            lblAnulado.Visible = true;
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
                foreach (var item in ListaBind)
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

        void frmIn_Transferencias_event_frmIn_Transferencias_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        
        #region Funciones Set y Get

        public void Set_Info(in_transferencia_Info info)
        {
            try
            {
                InfoTransferencia = info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        public void Set_Info_controls( )
        {
            try
            {
                if (InfoTransferencia != null)
                {

                    if (InfoTransferencia.IdEmpresa != 0)
                    {
                        ucIn_Catalogos_Cmb1.set_CatalogosInfo( InfoTransferencia.IdEstadoAprobacion_cat);
                        InfoTransferencia.IdUsuario = InfoTransferencia.IdUsuario;
                        _BodegaInfoOrigen.IdSucursal = InfoTransferencia.IdSucursalOrigen;
                        _BodegaInfoDestino.IdSucursal = InfoTransferencia.IdSucursalDest;
                        TerminoLoad = true;
                        _BodegaInfoOrigen.IdBodega = InfoTransferencia.IdBodegaOrigen;
                        _BodegaInfoDestino.IdBodega = InfoTransferencia.IdBodegaDest;
                        UCSucursalOrigen.cmb_sucursal.EditValue = InfoTransferencia.IdSucursalOrigen;
                        UCSucursalOrigen.cmb_bodega.EditValue = InfoTransferencia.IdBodegaOrigen;

                        UCSucursalOrigen.set_bodega(_BodegaInfoOrigen);
                        UCSucursalDestino.set_bodega(_BodegaInfoDestino);

                        txtNumtransferencia.Text = InfoTransferencia.IdTransferencia.ToString();
                        txtObservacion.Text = InfoTransferencia.tr_Observacion;
                        dtpFecha.Value = Convert.ToDateTime(InfoTransferencia.tr_fecha);
                        txtCodigo.Text = InfoTransferencia.Codigo;

                        UCTipoMoviOrigen.set_TipoMoviInvInfo(InfoTransferencia.IdMovi_inven_tipo_SucuOrig == null ? 0 : Convert.ToInt32(InfoTransferencia.IdMovi_inven_tipo_SucuOrig));
                        UCTipoMoviDestino.set_TipoMoviInvInfo(InfoTransferencia.IdMovi_inven_tipo_SucuDest == null ? 0 : Convert.ToInt32(InfoTransferencia.IdMovi_inven_tipo_SucuDest));

                        lista_IngEgrInv = Bus_IngEgrDet.Get_List_Ing_Egr_Inven_det_x_transferencia(param.IdEmpresa,InfoTransferencia.IdSucursalOrigen,InfoTransferencia.IdBodegaOrigen, InfoTransferencia.IdTransferencia);
                        ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_IngEgrInv);
                        gridControlProductos.DataSource = ListaBind;


                        var obj = Bus_Inter.Get_Info_transferencia_x_fa_guia_remision(param.IdEmpresa, InfoTransferencia.IdSucursalOrigen, InfoTransferencia.IdBodegaOrigen, InfoTransferencia.IdTransferencia);
                        if (obj != null)
                        {
                            if (obj.IdGuiaRemision != 0)
                            {
                                txtIdGuiaRemision.Text = obj.IdGuiaRemision.ToString();
                            }
                        }

                        //ucInv_GridCbte_Cble_x_Ing_Egr_Inv_Egreso.CargarDatos_CbteCble(InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Origen, InfoTransferencia.IdSucursal_Ing_Egr_Inven_Origen, InfoTransferencia.IdBodegaOrigen, InfoTransferencia.IdMovi_inven_tipo_SucuOrig, InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen);
                        //ucInv_GridCbte_Cble_x_Ing_Egr_Inv_Ingreso.CargarDatos_CbteCble(InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Destino, InfoTransferencia.IdSucursal_Ing_Egr_Inven_Destino, InfoTransferencia.IdBodegaDest, InfoTransferencia.IdMovi_inven_tipo_SucuDest, InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino);

                        UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged(new object(), new EventArgs());

                        info_ing.IdEmpresa = InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToInt32(InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Destino);
                        info_ing.IdSucursal = InfoTransferencia.IdSucursal_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToInt32(InfoTransferencia.IdSucursal_Ing_Egr_Inven_Destino);
                        info_ing.IdMovi_inven_tipo = InfoTransferencia.IdMovi_inven_tipo_SucuDest == null ? 0 : Convert.ToInt32(InfoTransferencia.IdMovi_inven_tipo_SucuDest);
                        info_ing.IdNumMovi = InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino == null ? 0 : Convert.ToDecimal(InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino);
                        btnIng.Text = info_ing.IdNumMovi.ToString();                        

                        info_egr.IdEmpresa = InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToInt32(InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Origen);
                        info_egr.IdSucursal = InfoTransferencia.IdSucursal_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToInt32(InfoTransferencia.IdSucursal_Ing_Egr_Inven_Origen);
                        info_egr.IdMovi_inven_tipo = InfoTransferencia.IdMovi_inven_tipo_SucuOrig == null ? 0 : Convert.ToInt32(InfoTransferencia.IdMovi_inven_tipo_SucuOrig);
                        info_egr.IdNumMovi = InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen == null ? 0 : Convert.ToDecimal(InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen);
                        btnEgr.Text = info_egr.IdNumMovi.ToString();

                        if (InfoTransferencia.IdEstadoAprobacion_cat == "APRO")
                        {
                            ucIn_Catalogos_Cmb1.Perfil_Lectura();
                            //gridViewProductos.OptionsBehavior.Editable = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                
            }

        }

        public void Set_Accion(Cl_Enumeradores.eTipo_action accion)
        {
            try
            {
                _Accion = accion;   
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }

        }
        
        public List<in_transferencia_det_Info> Get_Info_det()
        {
            try
            {
                InfoTransferencia.lista_detalle_transferencia = new List<in_transferencia_det_Info>();
                foreach (var item in ListaBind)
                {
                    if (item.Checked == true)
                    {
                        //Campos detalle de transferencia
                        in_transferencia_det_Info info_det_trans = new in_transferencia_det_Info();
                        info_det_trans.IdEmpresa = param.IdEmpresa;
                        info_det_trans.IdProducto = item.IdProducto;
                        info_det_trans.tr_Observacion = item.dm_observacion;

                        info_det_trans.dt_cantidad = item.dm_cantidad_sinConversion;
                        info_det_trans.IdUnidadMedida = item.IdUnidadMedida_sinConversion;

                        info_det_trans.IdCentroCosto = item.IdCentroCosto;
                        info_det_trans.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                        info_det_trans.pr_descripcion = item.pr_descripcion;
                        info_det_trans.IdPunto_cargo = item.IdPunto_cargo;
                        info_det_trans.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                        

                        //Campos guia
                        info_det_trans.Info_Guia_x_traspaso_bodega_det.IdEmpresa = item.Info_Guia_x_traspaso_bodega_det.IdEmpresa;
                        info_det_trans.Info_Guia_x_traspaso_bodega_det.IdGuia = item.Info_Guia_x_traspaso_bodega_det.IdGuia;
                        info_det_trans.Info_Guia_x_traspaso_bodega_det.secuencia = item.Info_Guia_x_traspaso_bodega_det.secuencia;

                        InfoTransferencia.lista_detalle_transferencia.Add(info_det_trans);                        
                    }
                }
                return InfoTransferencia.lista_detalle_transferencia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return new List<in_transferencia_det_Info>();
            }

        }

        public in_transferencia_Info Get_Info()
        {
            try
            {
                _SucursalInfoOrigen = UCSucursalOrigen.get_sucursal();
                _BodegaInfoOrigen = UCSucursalOrigen.get_bodega();
                _SucursalInfoDestino = UCSucursalDestino.get_sucursal();
                _BodegaInfoDestino = UCSucursalDestino.get_bodega();

                InfoTransferencia.IdEmpresa = param.IdEmpresa;
                InfoTransferencia.IdSucursalOrigen = _SucursalInfoOrigen.IdSucursal;
                InfoTransferencia.IdBodegaOrigen = _BodegaInfoOrigen.IdBodega;
                InfoTransferencia.IdSucursalDest = _SucursalInfoDestino.IdSucursal;
                InfoTransferencia.IdBodegaDest = _BodegaInfoDestino.IdBodega;
                InfoTransferencia.tr_Observacion = txtObservacion.Text;
                InfoTransferencia.tr_fecha = dtpFecha.Value;
                InfoTransferencia.Estado = (lblAnulado.Visible == false) ? "A" : "I";
                InfoTransferencia.IdUsuario = param.IdUsuario;

                InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Destino = param.IdEmpresa;
                InfoTransferencia.IdEmpresa_Ing_Egr_Inven_Origen = param.IdEmpresa;

                InfoTransferencia.IdSucursal_Ing_Egr_Inven_Destino = UCSucursalDestino.get_sucursal().IdSucursal;
                InfoTransferencia.IdSucursal_Ing_Egr_Inven_Origen = UCSucursalOrigen.get_sucursal().IdSucursal;

                InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Destino = btnIng.Text == "" ? 0 : Convert.ToDecimal(btnIng.Text);
                InfoTransferencia.IdNumMovi_Ing_Egr_Inven_Origen = btnEgr.Text == "" ? 0 : Convert.ToDecimal(btnEgr.Text);

                InfoTransferencia.IdMovi_inven_tipo_SucuOrig = UCTipoMoviOrigen.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                InfoTransferencia.IdMovi_inven_tipo_SucuDest = UCTipoMoviDestino.get_TipoMoviInvInfo().IdMovi_inven_tipo;

                InfoTransferencia.IdMotivo_Inv_SucuOrig = ucin_motivo_origen.get_MotivoInvInfo().IdMotivo_Inv;
                InfoTransferencia.IdMotivo_Inv_SucuDest = ucin_motivo_destino.get_MotivoInvInfo().IdMotivo_Inv;
                InfoTransferencia.IdEstadoAprobacion_cat = ucIn_Catalogos_Cmb1.Get_CatalogosInfo().IdCatalogo;
                InfoTransferencia.IdTransferencia = Convert.ToDecimal((txtNumtransferencia.Text == "") ? "0" : txtNumtransferencia.Text);
                InfoTransferencia.ip = param.ip;
                InfoTransferencia.nom_pc = param.nom_pc;
                InfoTransferencia.Codigo = txtCodigo.Text;

                Get_Info_det();

                return InfoTransferencia;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return new in_transferencia_Info();
            }
        }

        public void Get_IdSucursal_Bodega()
        {
            try
            {

                _SucursalInfoOrigen = UCSucursalOrigen.get_sucursal();
                _BodegaInfoOrigen = UCSucursalOrigen.get_bodega();

                _SucursalInfoDestino = UCSucursalDestino.get_sucursal();
                _BodegaInfoDestino = UCSucursalDestino.get_bodega();

                if (_SucursalInfoOrigen != null && _BodegaInfoOrigen != null)
                {
                    if (_SucursalInfoOrigen.IdSucursal != 0 && -_BodegaInfoOrigen.IdBodega != 0)
                    {
                        listProducto = Bus_Producto.Get_list_Producto(param.IdEmpresa);
                        cmbProducto_grid.DataSource = listProducto;
                        cmbProducto_grid.DisplayMember = "pr_descripcion";
                        cmbProducto_grid.ValueMember = "IdProducto";
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
              
            }

        }

        private void set_accion_controls()
        {
            try
            {

                switch (_Accion)
                {

                    case Cl_Enumeradores.eTipo_action.grabar:
                        txtNumtransferencia.Enabled = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        
                        ucGe_Menu.Visible_bntImprimir = false;
                        break;


                    case Cl_Enumeradores.eTipo_action.actualizar:
                        txtNumtransferencia.Enabled = false;
                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Visible_bntImprimir = true;
                        UCSucursalOrigen.Bloquerar_Combos();
                        UCSucursalDestino.Bloquerar_Combos();

                        Set_Info_controls();

                        if (InfoTransferencia.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                            ucGe_Menu.Visible_bntGuardar_y_Salir = false;
                            ucGe_Menu.Visible_btnGuardar = false;
                        }

                        if (InfoTransferencia.IdEstadoAprobacion_cat == "XAPRO")
                        {
                            ucin_motivo_destino.Perfil_Lectura(true);
                            ucin_motivo_origen.Perfil_Lectura(true);
                        }
                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                        txtNumtransferencia.Enabled = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntImprimir = true;
                        UCSucursalOrigen.Bloquerar_Combos();
                        Set_Info_controls();
                        ucGe_Menu.Enabled_bntAnular = false;
                        if (InfoTransferencia.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        ucGe_Menu.Enabled_bntAnular = false;
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        txtNumtransferencia.Enabled = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        UCSucursalOrigen.Bloquerar_Combos();
                        Set_Info_controls();
                        if (InfoTransferencia.Estado == "I")
                        {
                            lblAnulado.Visible = true;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {


            }
        }

        #endregion

        #region fx Grabar y Modificar
        
        private Boolean Accion_Grabar()
        {
            try
            {
                Boolean respuesta = false;

                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    respuesta = Grabar();
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                {
                    respuesta = Modificar();
                }
                if (respuesta)
                {
                    if (MessageBox.Show("¿Desea imprimir la transferencia # " + InfoTransferencia.IdTransferencia + "?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        imprimir();
                }
                return respuesta;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }

        }

        Boolean ValidarDatos()
        {
            try
            {
                txtCodigo.Focus();

                List<in_transferencia_det_Info> listaDetalle = new List<in_transferencia_det_Info>();
                listaDetalle = Get_Info_det();

                if (_BodegaInfoDestino.IdBodega == _BodegaInfoOrigen.IdBodega && _SucursalInfoDestino.IdSucursal == _SucursalInfoOrigen.IdSucursal)
                {
                    MessageBox.Show("Por favor selecciones una bodega destino diferente a la bodega origen");
                    return false;
                }

                if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo() == null)
                {
                    MessageBox.Show("Por favor seleccione el estado de aprobación de la transferencia");
                    return false;
                }

                if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo()!=null)
                {
                    if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo().IdCatalogo=="APRO")
                    {
                        if (ucin_motivo_origen.get_MotivoInvInfo() == null)
                        {
                            MessageBox.Show("Por favor seleccione el motivo para el movimiento de egreso");
                            return false;
                        }
                        if (ucin_motivo_destino.get_MotivoInvInfo() == null)
                        {
                            MessageBox.Show("Por favor seleccione el motivo para el movimiento de ingreso");
                            return false;
                        }
                    }
                }

                if (UCTipoMoviDestino.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por favor selecciones un Tipo Movimiento Ingreso ");
                    return false;
                }
                if (UCTipoMoviOrigen.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Por favor selecciones un Tipo Movimiento Egreso ");
                    return false;
                }

                
                if (listaDetalle.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un producto");
                    return false;
                }

                foreach (var item in listaDetalle)
                {
                    if (item.dt_cantidad==0)
                    {
                        MessageBox.Show("Por favor seleccione una cantidad para el producto "+ item.pr_descripcion);
                        return false;
                    }
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa,Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        private Boolean Modificar()
        {
            try
            {

                Boolean boolResult = false;
                string msjError = "";

                boolResult = ValidarDatos();

                if (boolResult)
                {
                    Get_Info();


                    boolResult = oBus.ModificarDB(InfoTransferencia);
                    if (boolResult)
                    {
                        MessageBox.Show("Actualizado con éxito la transferencia : #" + InfoTransferencia.IdTransferencia, "Sistemas");
                        boolResult = true;                        

                        var list_Guias = from C in ListaBind
                                         group C by new { C.Info_Guia_x_traspaso_bodega_det.IdEmpresa, C.Info_Guia_x_traspaso_bodega_det.IdGuia}
                                             into grouping
                                             select new { grouping.Key };


                        if (Bus_guia.EliminarDB(InfoTransferencia))
                        {
                            foreach (var item in list_Guias)
                            {
                                if (item.Key.IdGuia != 0)
                                {
                                    in_transferencia_x_in_Guia_x_traspaso_bodega_Info Obj = new in_transferencia_x_in_Guia_x_traspaso_bodega_Info();
                                    Obj.IdEmpresa = InfoTransferencia.IdEmpresa;
                                    Obj.IdSucursalOrgen = InfoTransferencia.IdSucursalOrigen;
                                    Obj.IdBodegaOrigen = InfoTransferencia.IdBodegaOrigen;
                                    Obj.IdTransferencia = InfoTransferencia.IdTransferencia;
                                    Obj.IdEmpresa_Guia = item.Key.IdEmpresa;
                                    Obj.IdGuia = item.Key.IdGuia;
                                    Obj.Observacion = " ";
                                    Bus_guia.GuardarDB(Obj, ref msjError);
                                }

                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar", "Sistemas");
                    }

                }
                return boolResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }

        Boolean Grabar()
        {
            try
            {
                Boolean boolResult = false;
                string msjError = "";             

                boolResult=ValidarDatos();
                if (boolResult)
                {
                   Get_Info();                    
                        decimal _idTransferencia = 0;

                    boolResult=oBus.GuardarDB(InfoTransferencia, ref _idTransferencia);
                    if (boolResult)
                        {
                            MessageBox.Show("Guardado Con Exito la Transferencia : #" + _idTransferencia, "Sistemas");
                            boolResult = true;
                            txtNumtransferencia.Text = _idTransferencia.ToString();

                            var list_Guias = from C in ListaBind
                                             group C by new { C.Info_Guia_x_traspaso_bodega_det.IdEmpresa, C.Info_Guia_x_traspaso_bodega_det.IdGuia }
                                                 into grouping
                                                 select new { grouping.Key };

                            foreach (var item in list_Guias)
                            {
                                if (item.Key.IdGuia != 0)
                                {
                                    in_transferencia_x_in_Guia_x_traspaso_bodega_Info Obj = new in_transferencia_x_in_Guia_x_traspaso_bodega_Info();

                                    Obj.IdEmpresa = InfoTransferencia.IdEmpresa;
                                    Obj.IdSucursalOrgen = InfoTransferencia.IdSucursalOrigen;
                                    Obj.IdBodegaOrigen = InfoTransferencia.IdBodegaOrigen;
                                    Obj.IdTransferencia = InfoTransferencia.IdTransferencia;
                                    Obj.IdEmpresa_Guia = item.Key.IdEmpresa;
                                    Obj.IdGuia = item.Key.IdGuia;
                                    Obj.Observacion = " ";
                                    Bus_guia.GuardarDB(Obj, ref msjError);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar", "Sistemas");
                        }
                }


                return boolResult;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        #endregion

        private void Cargar_combos()
        {
            try
            {
                in_UnidadMedida_Bus BusUniM = new in_UnidadMedida_Bus();
                cmbUniMedida_grid.DataSource = BusUniM.Get_list_UnidadMedida();
                cmbCentroCosto_grid.DataSource = Bus_CentroCosto.Get_list_Centro_Costo_cuentas_de_movimiento(param.IdEmpresa, ref MensajeError);

                ucIn_Catalogos_Cmb1.cargar_Catalogos(1);
                ucIn_Catalogos_Cmb1.set_CatalogosInfo("APRO");
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
      
        private void frmIn_Transferencias_Load(object sender, EventArgs e)
        {
            try
            {
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = ListaBind;
                Get_IdSucursal_Bodega();
                TerminoLoad = true;
                if (_Accion == 0) { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

                InfoParamInv = BusParamInv.Get_Info_Parametro(param.IdEmpresa);
                int ? IdMovi_inven_tipo_egresoBodegaOrigen = InfoParamInv.IdMovi_inven_tipo_egresoBodegaOrigen;
                int ? IdMovi_inven_tipo_ingresoBodegaDestino = InfoParamInv.IdMovi_inven_tipo_ingresoBodegaDestino;
                IdMovi_inven_tipo_egresoBodegaOrigen = (IdMovi_inven_tipo_egresoBodegaOrigen == null) ? 0 : IdMovi_inven_tipo_egresoBodegaOrigen;
                IdMovi_inven_tipo_ingresoBodegaDestino = (IdMovi_inven_tipo_ingresoBodegaDestino == null) ? 0 : IdMovi_inven_tipo_ingresoBodegaDestino;
                UCTipoMoviOrigen.set_TipoMoviInvInfo(Convert.ToInt32(IdMovi_inven_tipo_egresoBodegaOrigen));
                UCTipoMoviDestino.set_TipoMoviInvInfo(Convert.ToInt32(IdMovi_inven_tipo_ingresoBodegaDestino));

                Cargar_combos();
                set_accion_controls();              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


        }
       
        private void frmIn_Transferencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frmIn_Transferencias_event_frmIn_Transferencias_FormClosing(sender, e);
                event_frmIn_Transferencias_FormClosing(sender, e);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void UCSucursalOrigen_Event_cmb_sucursal1_EditValueChanged_1(object sender, EventArgs e)
        {

            try
            {
                if (TerminoLoad == true)
                {
                    Get_IdSucursal_Bodega();

                    this.UCTipoMoviOrigen_event_cmbCatalogo_EditValueChanged(sender, e);

                }
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

                if (InfoDet != null)
                {
                    if (e.Column.Name == "colIdProducto")
                    {

                        var itemProd = listProducto.FirstOrDefault(p => p.IdProducto == InfoDet.IdProducto);

                        if (InfoDet.IdProducto == InfoDet.IdProducto)
                        {
                            InfoDet.cod_producto = itemProd.pr_codigo;
                            InfoDet.dm_peso = itemProd.pr_peso == null ? 0 : Convert.ToDouble(itemProd.pr_peso);
                            InfoDet.dm_stock_ante = itemProd.pr_stock_Bodega;
                            InfoDet.dm_stock_actu = itemProd.pr_stock_Bodega + InfoDet.dm_cantidad;
                            InfoDet.dm_precio = itemProd.pr_precio_publico == null ? 0 : Convert.ToDouble(itemProd.pr_precio_publico);
                            InfoDet.mv_costo = itemProd.pr_costo_promedio == null ? 0 : Convert.ToDouble(itemProd.pr_costo_promedio);
                            InfoDet.mv_costo_sinConversion = itemProd.pr_costo_promedio == null ? 0 : Convert.ToDouble(itemProd.pr_costo_promedio);
                            InfoDet.Checked = true;
                            InfoDet.pr_descripcion = itemProd.pr_descripcion;
                            InfoDet.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida;
                            InfoDet.IdUnidadMedida = itemProd.IdUnidadMedida;
                            InfoDet.nom_UnidadMedida = itemProd.nom_UnidadMedida_Consumo;
                            InfoDet.IdUnidadMedida_Consumo = itemProd.IdUnidadMedida_Consumo;
                        }

                    }

                    if (e.Column.Name == "coldm_cantidad")
                    {
                        foreach (var item in ListaBind)
                        {
                            if (item.dm_cantidad_sinConversion < 0)
                            {
                                item.dm_cantidad_sinConversion = 0;
                            }
                            else
                            {
                                item.dm_stock_actu = item.dm_stock_ante + item.dm_cantidad_sinConversion;
                            }

                        }
                    }


                    if (e.Column == colIdCentroCosto_grid)
                    {
                        BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
                        BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>
                            (Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(e.Value)));

                        foreach (ct_centro_costo_sub_centro_costo_Info item in BindListaSubCentro)
                        {
                            item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                        }

                        cmbSubCentroCosto_grid.Items.Clear();
                        foreach (var item in BindListaSubCentro)
                        {
                            cmbSubCentroCosto_grid.Items.Add(item.NomSubCentroCosto);
                        }
                    }
                    else

                        if (e.Column == colNomSubCentroCosto)
                        {
                            if (!String.IsNullOrEmpty(Convert.ToString(InfoDet.NomSubCentroCosto)))
                            {
                                string idSubcentro = "";
                                try
                                {
                                    idSubcentro = BindListaSubCentro.FirstOrDefault
                                   (q => InfoDet.NomSubCentroCosto == "[" + q.IdCentroCosto_sub_centro_costo.Trim() + "] - " + q.Centro_costo.Trim()).IdCentroCosto_sub_centro_costo;

                                }
                                catch (Exception ex)
                                {
                                    Log_Error_bus.Log_Error(ex.ToString());
                                    idSubcentro = "";
                                }
                                gridViewProductos.SetFocusedRowCellValue(colIdCentroCosto_sub_centro_costo, idSubcentro);
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

        private void gridViewProductos_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var Item = (in_Ing_Egr_Inven_det_Info)gridViewProductos.GetRow(e.FocusedRowHandle);
                cmbSubCentroCosto_grid.Items.Clear();
                Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();
                foreach (var item in Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa, Convert.ToString(gridViewProductos.GetFocusedRowCellValue(colIdCentroCosto_grid))))
                {
                    item.NomSubCentroCosto = "[" + item.IdCentroCosto_sub_centro_costo.Trim() + "] - " + item.Centro_costo.Trim();
                    cmbSubCentroCosto_grid.Items.Add(item.NomSubCentroCosto);
                }

                if (Item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                {
                    colIdProducto.OptionsColumn.AllowEdit = false;
                    coldm_cantidad.OptionsColumn.AllowEdit = false;
                    coldm_observacion.OptionsColumn.AllowEdit = false;
                    colNomSubCentroCosto.OptionsColumn.AllowEdit = false;
                    colIdCentroCosto_grid.OptionsColumn.AllowEdit = false;
                }
                else
                {
                    colIdProducto.OptionsColumn.AllowEdit = true;
                    coldm_cantidad.OptionsColumn.AllowEdit = true;
                    coldm_observacion.OptionsColumn.AllowEdit = true;
                    colNomSubCentroCosto.OptionsColumn.AllowEdit = true;
                    colIdCentroCosto_grid.OptionsColumn.AllowEdit = true;
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                colIdProducto.OptionsColumn.AllowEdit = true;
                coldm_cantidad.OptionsColumn.AllowEdit = true;
                coldm_observacion.OptionsColumn.AllowEdit = true;
                colNomSubCentroCosto.OptionsColumn.AllowEdit = true;
                colIdCentroCosto_grid.OptionsColumn.AllowEdit = true;
                
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

        void LimpiarDatos()
        {
            try
            {
                
                IdGuia = 0;
                txtNumtransferencia.Text = "";
                txtObservacion.Text = "";                                
                ListaBind = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = ListaBind;
                InfoTransferencia = new in_transferencia_Info();
                txtCodigo.Text = string.Empty;
                btnEgr.Text = "0";
                btnIng.Text = "0";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_guia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                in_Guia_x_traspaso_bodega_det_Bus BusGuiaTras = new in_Guia_x_traspaso_bodega_det_Bus();
                if (txtIdGuiaRemision.EditValue != null && txtIdGuiaRemision.EditValue != "")
                {
                    IdGuia = Convert.ToDecimal(this.txtIdGuiaRemision.EditValue);

                    List<in_Guia_x_traspaso_bodega_det_Info>  list_Guia_det = BusGuiaTras.Get_List_Guia_x_traspaso_bodega_sin_transferencia_det(param.IdEmpresa, IdGuia);
                    if (list_Guia_det.Count() == 0)
                    {
                        MessageBox.Show("No existe la Guia: #" + txtIdGuiaRemision.Text);
                        return;
                    }
                    foreach (var item in list_Guia_det)
                    {
                        if (ListaBind.Where(q => q.Info_Guia_x_traspaso_bodega_det.IdEmpresa == item.IdEmpresa && q.Info_Guia_x_traspaso_bodega_det.IdGuia == item.IdGuia && q.Info_Guia_x_traspaso_bodega_det.secuencia == item.secuencia).Count() == 0)
                        {
                            in_Ing_Egr_Inven_det_Info infoMoviInv = new in_Ing_Egr_Inven_det_Info();
                            infoMoviInv.IdProducto = item.IdProducto;
                            infoMoviInv.dm_cantidad_sinConversion = item.Cantidad_enviar;
                            infoMoviInv.dm_cantidad = item.Cantidad_enviar;
                            infoMoviInv.IdUnidadMedida = item.IdUnidadMedida;
                            infoMoviInv.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                            infoMoviInv.mv_costo = item.do_precioCompra;
                            infoMoviInv.IdCentroCosto = item.IdCentroCosto;
                            infoMoviInv.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                            infoMoviInv.Checked = true;
                            infoMoviInv.cod_producto = item.pr_codigo;
                            infoMoviInv.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                            infoMoviInv.IdPunto_cargo = item.IdPunto_cargo;
                            infoMoviInv.dm_observacion = item.observacion;

                            //Campos de guia 
                            infoMoviInv.Info_Guia_x_traspaso_bodega_det.IdEmpresa = item.IdEmpresa;
                            infoMoviInv.Info_Guia_x_traspaso_bodega_det.IdGuia = item.IdGuia;
                            infoMoviInv.Info_Guia_x_traspaso_bodega_det.secuencia = item.secuencia;
                            
                            ListaBind.Add(infoMoviInv);
                        }
                    }
                    gridControlProductos.DataSource = ListaBind;
                    gridControlProductos.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimir()
        {
            try
            {
                XINV_Rpt017_Rpt Reporte = new XINV_Rpt017_Rpt();
                Reporte.P_IdSucursal_origen.Value = InfoTransferencia.IdSucursalOrigen;
                Reporte.P_IdBodega_origen.Value = InfoTransferencia.IdBodegaOrigen;
                Reporte.P_IdTransferencia.Value = InfoTransferencia.IdTransferencia;

                Reporte.RequestParameters = false;
                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(Reporte);
                pt.AutoShowParametersPanel = false;

                Reporte.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_Click_1(object sender, EventArgs e)
        {

            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucIn_Catalogos_Cmb1_event_delegate_cmbCatalogo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo() != null)
                {
                    if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo().IdCatalogo == "XAPRO")
                    {
                        ucin_motivo_origen.Perfil_Lectura(true);
                        ucin_motivo_destino.Perfil_Lectura(true);
                    }
                    if (ucIn_Catalogos_Cmb1.Get_CatalogosInfo().IdCatalogo == "APRO")
                    {
                        ucin_motivo_origen.Perfil_Lectura(false);
                        ucin_motivo_destino.Perfil_Lectura(false);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                }
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
                    if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIng_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (btnIng.Text == "0" || btnIng.Text == "")
                {
                    MessageBox.Show("Esta transferencia no tiene un ingreso relacionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int IdSucursal = UCSucursalDestino.get_bodega().IdSucursal;
                int IdBodega = UCSucursalDestino.get_bodega().IdBodega;
                int IdMovi_inven_tipo = UCTipoMoviDestino.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                decimal IdNumMovi = Convert.ToDecimal(btnIng.Text);

                info_ing = bus_ing_egr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                if (info_ing.IdEmpresa!=0)
                {
                    FrmIn_Ingreso_varios_Mant frm = new FrmIn_Ingreso_varios_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.setInfo(info_ing);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();        
                }                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEgr_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (btnEgr.Text == "0" || btnEgr.Text =="")
                {
                    MessageBox.Show("Esta transferencia no tiene un egreso relacionado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int IdSucursal = UCSucursalOrigen.get_bodega().IdSucursal;
                int IdBodega = UCSucursalOrigen.get_bodega().IdBodega;
                int IdMovi_inven_tipo = UCTipoMoviOrigen.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                decimal IdNumMovi = Convert.ToDecimal(btnEgr.Text);
                info_egr = bus_ing_egr.Get_Info_Ing_Egr_Inven(param.IdEmpresa, IdSucursal, IdMovi_inven_tipo, IdNumMovi);
                if (info_egr.IdEmpresa!=0)
                {
                    FrmIn_Egresos_Varios_Mant frm = new FrmIn_Egresos_Varios_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.setInfo_(info_egr);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();    
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
