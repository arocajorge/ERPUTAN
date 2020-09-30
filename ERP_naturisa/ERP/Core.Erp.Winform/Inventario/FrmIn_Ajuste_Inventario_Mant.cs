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
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Winform;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Inventario;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using System.IO;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Ajuste_Inventario_Mant : Form
    {
       #region Eventos Delegados
        void UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                

                opt_ingreso.Checked = true;

                #region que estaba manejando hilos
                //                SplashScreenManager.ShowForm(typeof(frmGe_Esperar));
                this.TmHilo.Enabled = true;


                oThreadBuscarConceptos = new Thread(new ThreadStart(CargarTipoMovimiento));
                oThreadBuscarConceptos.Start();

                oThreadBuscar = new Thread(new ThreadStart(CargarProducto));
                oThreadBuscar.Start();


                #endregion

                //CargarTipoMovimiento();
                //CargarProducto();

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCSucurBod_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                //CargarMovimiento();
                //CargarProducto();

                opt_ingreso.Checked = true;
                //SplashScreenManager.ShowForm(typeof(frmGe_Esperar));

                this.TmHilo.Enabled = true;
                oThreadBuscarConceptos = new Thread(new ThreadStart(CargarTipoMovimiento));
                oThreadBuscarConceptos.Start();
                oThreadBuscar = new Thread(new ThreadStart(CargarProducto));
                oThreadBuscar.Start();

                //CargarTipoMovimiento();
                //CargarProducto();


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void UCCentroCosto_Event_ultraComboE_CentroCosto_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lmBodegaxCentroCosto = new List<tb_Bodega_Info>();
                string IdCentroCosto = "";
                IdCentroCosto = UCCentroCosto.get_item();
                UCSucurBod.cargar_bodega(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion

       #region DECLARACION DE VARIABLES
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //UCIn_Grid_Movi_Detalle UCGridDetalleProduc = new UCIn_Grid_Movi_Detalle();
        in_movi_inven_tipo_Bus tipoMoviBus = new in_movi_inven_tipo_Bus();
        in_movi_inve_Bus MoviInvenBuss = new in_movi_inve_Bus();
        in_movi_inve_detalle_Bus MoviInvenDetB = new in_movi_inve_detalle_Bus();
        in_movi_inve_Info _movi_inve_Info = new in_movi_inve_Info();
        List<in_movi_inve_detalle_Info> _movi_inve_detalle_List_Info = new List<in_movi_inve_detalle_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Bodega_Info _bodegaInfo = new tb_Bodega_Info();
        tb_Sucursal_Info _sucursalInfo = new tb_Sucursal_Info();
        List<in_movi_inven_tipo_Info> _listMovi_inve_tipo_info = new List<in_movi_inven_tipo_Info>();
        in_movi_inven_tipo_Info _Movi_inve_tipo_info = new in_movi_inven_tipo_Info();        
        in_producto_Bus _ProductoBus = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus _ProducxBodegaBus = new in_producto_x_tb_bodega_Bus();
        Thread oThreadBuscar;
        Thread oThreadBuscarConceptos;
        UCCon_CentroCosto_ctas_padre UCCentroCosto = new UCCon_CentroCosto_ctas_padre();
        in_Parametro_Bus BusParametro = new in_Parametro_Bus();
        in_Parametro_Info InfoParametro = new in_Parametro_Info();
        List<tb_Bodega_Info> lmBodegaxCentroCosto = new List<tb_Bodega_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
        in_Ing_Egr_Inven_det_Bus Bus_IngEgrDet = new in_Ing_Egr_Inven_det_Bus();

        in_Ing_Egr_Inven_Info MoviInven_I = new in_Ing_Egr_Inven_Info();


#endregion
        in_Ing_Egr_Inven_Info info_IngEgr = new in_Ing_Egr_Inven_Info();
        List<in_Ing_Egr_Inven_det_Info> list_IngEgrDet;
        BindingList<in_Ing_Egr_Inven_det_Info> BindList_Ing_egr_inve_det;
        List<in_Ing_Egr_Inven_det_Info> lista_IngEgrInv = new List<in_Ing_Egr_Inven_det_Info>();
        in_Ing_Egr_Inven_Bus Bus_IngEgr = new in_Ing_Egr_Inven_Bus();
        in_Ing_Egr_Inven_det_Info InfoDet = new in_Ing_Egr_Inven_det_Info();
        List<in_Producto_Info> listProducto = new List<in_Producto_Info>();
        in_producto_Bus Bus_Producto = new in_producto_Bus();
        
        ct_centro_costo_sub_centro_costo_Bus Bus_SubCentroCosto = new ct_centro_costo_sub_centro_costo_Bus();        
        ct_Centro_costo_Bus BusCentroCosto = new ct_Centro_costo_Bus();
        BindingList<ct_centro_costo_sub_centro_costo_Info> BindListaSubCentro = new BindingList<ct_centro_costo_sub_centro_costo_Info>();
        
        List<ct_Centro_costo_Info> ListCentro_Costo = new List<ct_Centro_costo_Info>();
        List<ct_centro_costo_sub_centro_costo_Info> list_subcentro_combo = new List<ct_centro_costo_sub_centro_costo_Info>();
        ct_centro_costo_sub_centro_costo_Info info_subcentro = new ct_centro_costo_sub_centro_costo_Info();

        List<in_UnidadMedida_Info> lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
        in_UnidadMedida_Bus bus_unidad_medida = new in_UnidadMedida_Bus();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();
        in_Producto_Info itemProd = new in_Producto_Info();
        int RowHandle = 0;
        string msg = "";
        public  void get_AjusteMoviInven()
        {
            try
            {
                _bodegaInfo = UCSucurBod.get_bodega();
                _sucursalInfo = UCSucurBod.get_sucursal();
                //_movi_inve_Info.IdCentroCosto = UCCentroCosto.get_item();

                info_IngEgr.IdEmpresa = param.IdEmpresa;
                info_IngEgr.IdNumMovi = Convert.ToDecimal((txtNumAjuste.Text == "") ? "0" : txtNumAjuste.Text);
                info_IngEgr.IdSucursal = _sucursalInfo.IdSucursal;
                info_IngEgr.IdBodega = _bodegaInfo.IdBodega;
                info_IngEgr.CodMoviInven = txtcodigoAjuste.Text.Trim();
                info_IngEgr.cm_observacion = txtObservacion.Text;
                info_IngEgr.IdMovi_inven_tipo = ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo().IdMovi_inven_tipo;
                info_IngEgr.cm_fecha = dtpFecha.Value;
                info_IngEgr.IdUsuario = param.IdUsuario;
                info_IngEgr.nom_pc = param.nom_pc;
                info_IngEgr.ip = param.ip;
                info_IngEgr.Fecha_Transac = param.Fecha_Transac;
                info_IngEgr.signo = (opt_ingreso.Checked == true) ? "+" : "-";
                info_IngEgr.IdMotivo_Inv = cmbMotivoInv.get_MotivoInvInfo().IdMotivo_Inv;

                GetDetalle();
                info_IngEgr.listIng_Egr = list_IngEgrDet;               

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void GetDetalle()
        {
            try
            {
                list_IngEgrDet = new List<in_Ing_Egr_Inven_det_Info>();

                double Stock_Ant = 0;
                foreach (var item in BindList_Ing_egr_inve_det)
                {
                    if (item.IdEstadoAproba == null || item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.PEND.ToString())
                    {
                        in_Ing_Egr_Inven_det_Info info = new in_Ing_Egr_Inven_det_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdSucursal = item.IdSucursal;
                        info.IdNumMovi = item.IdNumMovi;
                        info.Secuencia = item.Secuencia;
                        info.IdBodega = item.IdBodega;
                        info.IdProducto = item.IdProducto;
                        
                        info.dm_stock_ante = item.dm_stock_ante;
                        info.dm_stock_actu = item.dm_stock_actu;
                        info.dm_observacion = item.dm_observacion;
                        info.dm_precio = item.dm_precio;
                        
                        info.dm_peso = item.dm_peso;
                        info.IdCentroCosto = item.IdCentroCosto;
                        info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;

                        info.pr_descripcion = item.pr_descripcion;
                        
                        info.IdPunto_cargo = item.IdPunto_cargo;

                        info.dm_cantidad_sinConversion = item.dm_cantidad;
                        info.IdUnidadMedida_sinConversion = item.IdUnidadMedida;
                        info.mv_costo_sinConversion = item.mv_costo;

                        info.dm_cantidad = item.dm_cantidad;
                        info.IdUnidadMedida = item.IdUnidadMedida_Consumo;
                        info.mv_costo = item.mv_costo;

                        list_IngEgrDet.Add(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDataAControles()
        {
            try
            {
                UCSucurBod.cmb_sucursal.EditValue = _movi_inve_Info.IdSucursal;
                UCSucurBod.cmb_bodega.EditValue = _movi_inve_Info.IdBodega;
                this.txtcodigoAjuste.Text = _movi_inve_Info.CodMoviInven;
                this.txtNumAjuste.Text = _movi_inve_Info.IdNumMovi.ToString();
                this.txtObservacion.Text = _movi_inve_Info.cm_observacion.Trim();

                _sucursalInfo = new tb_Sucursal_Info();
                _sucursalInfo.IdEmpresa = param.IdEmpresa;
                _sucursalInfo.IdSucursal = _movi_inve_Info.IdSucursal;

                if (_movi_inve_Info.cm_tipo == "+")
                {
                     opt_ingreso.Checked =true;
                }

                if (_movi_inve_Info.cm_tipo == "-")
                {
                      opt_egreso.Checked =true;
                }

                dtpFecha.Value = _movi_inve_Info.cm_fecha;
                lblAnulado.Visible = (_movi_inve_Info.Estado == "I") ? true : false;
                this.UCCentroCosto.set_item(_movi_inve_Info.IdCentroCosto);
               // ucIn_Grid_Movi_Detalle1.set_Datosgrid(_movi_inve_detalle_List_Info);
                
                ucIn_TipoMoviInv_Cmb1.set_TipoMoviInvInfo(_movi_inve_Info.IdMovi_inven_tipo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_info(in_Ing_Egr_Inven_Info _MoviInven_I)
        {
            try
            {
                MoviInven_I = _MoviInven_I;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void set_AjusteMoviInven()
        {
            try
            {
                txtNumAjuste.Text = Convert.ToString(MoviInven_I.IdNumMovi);
                UCSucurBod.cmb_sucursal.EditValue = MoviInven_I.IdSucursal;
                UCSucurBod.cmb_bodega.EditValue = MoviInven_I.IdBodega;
                dtpFecha.Value = MoviInven_I.cm_fecha;
                ucIn_TipoMoviInv_Cmb1.set_TipoMoviInvInfo(MoviInven_I.IdMovi_inven_tipo);
                txtObservacion.Text = MoviInven_I.cm_observacion;
                txtcodigoAjuste.Text = MoviInven_I.CodMoviInven;                
                lblAnulado.Visible = MoviInven_I.Estado == "I" ? true : false;
                if (MoviInven_I.signo == "+")
                    opt_ingreso.Checked = true;
                else
                    opt_egreso.Checked = true;
                //consulta detalle
                cmbMotivoInv.set_MotivoInvInfo(Convert.ToInt32(MoviInven_I.IdMotivo_Inv));

                lista_IngEgrInv = Bus_IngEgrDet.Get_List_Ing_Egr_Inven_det_x_Num_Movimiento(param.IdEmpresa, MoviInven_I.IdSucursal, MoviInven_I.IdMovi_inven_tipo, MoviInven_I.IdNumMovi);
                BindList_Ing_egr_inve_det = new BindingList<in_Ing_Egr_Inven_det_Info>(lista_IngEgrInv);
                gridControlProductos.DataSource = BindList_Ing_egr_inve_det;

                var item = lista_IngEgrInv.FirstOrDefault();
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(item.IdEmpresa), Convert.ToInt32(item.IdSucursal), Convert.ToInt32(item.IdBodega), Convert.ToInt32(item.IdMovi_inven_tipo), Convert.ToDecimal(item.IdNumMovi));


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        public Boolean grabar()
        {
            try
            {
                Boolean resultB = true;
                string mensaje="";

                if (Validaciones() == false)
                {
                    return false;
                }

                get_AjusteMoviInven();
                if (!(info_IngEgr == null))
                {
                    decimal IdNumMovi = 0;
                    info_IngEgr.IdUsuario = param.IdUsuario;
                    info_IngEgr.ip = param.ip;
                    info_IngEgr.nom_pc = param.nom_pc;

                    if (Bus_IngEgr.GuardarDB(info_IngEgr, ref   IdNumMovi, ref mensaje))
                    {
                        MessageBox.Show("Ajuste # " + IdNumMovi  + " Grabado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resultB = true;
                        set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                        txtNumAjuste.Text = Convert.ToString(IdNumMovi);

                        //ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        //ucGe_Menu.Enabled_btnGuardar = false;

                        if (MessageBox.Show("¿Desea Imprimir el Ajuste a Inventario # " + IdNumMovi + "\n" + "Imprimir", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ucGe_Menu_event_btnImprimir_Click(null, null);
                        }

                        LimpiarDatos();
                    }
                    else
                    {
                        MessageBox.Show(" Error al Grabar Ajuste verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }

                    return resultB;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean Anular()
        {
            try
            {
                Boolean resultB=false;
                string mensaje = "";
                if (ValidarAnulacion_x_Estado())
                {
                    _movi_inve_Info.listmovi_inve_detalle_Info = _movi_inve_detalle_List_Info;
                    if (MessageBox.Show("¿Está seguro que desea anular el ajuste  ?", "Anulación de ajuste de inventario  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmGe_MotivoAnulacion ofrm = new FrmGe_MotivoAnulacion();
                        ofrm.ShowDialog();

                        _movi_inve_Info.IdusuarioUltAnu = param.IdUsuario;
                        _movi_inve_Info.Fecha_UltAnu = DateTime.Now;
                        _movi_inve_Info.MotivoAnulacion = ofrm.motivoAnulacion;

                        if (MoviInvenBuss.AnularDB(_movi_inve_Info, Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje))
                        {
                            MessageBox.Show("Ajuste # " + _movi_inve_Info.IdNumMovi + " Por Concepto:" + ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo().tm_descripcion + " ANULADO Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ucGe_Menu.Enabled_bntAnular = false;
                            resultB = true;
                        }
                        else
                        {
                            MessageBox.Show(" Error al ANULAR Ajuste verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            resultB = false;
                        }
                    }
                }
                return resultB;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean ValidarAnulacion_x_Estado()
        {
            try
            {
                foreach (var item in BindList_Ing_egr_inve_det)
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

        public Boolean Validaciones()
        {
            try
            {
                Boolean Valido = true;

                if (txtObservacion.Text=="")
                {
                    MessageBox.Show("Debe ingresar una observacion", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }


                if (ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("Debe escoger un tipo ajuste ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;       
                }

                if (cmbMotivoInv.get_MotivoInvInfo() == null)
                {
                    MessageBox.Show("Debe escoger el Motivo del Movimiento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }

                if (_sucursalInfo.IdSucursal==0)
                {

                    MessageBox.Show("Debe escoger una sucursal ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                
                }


                if (_bodegaInfo.IdBodega==0)
                {

                    MessageBox.Show("Debe escoger una bodega ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;

                }

                
               // detalleInfo = ucIn_Grid_Movi_Detalle1.get_DatosGrid();


                if (BindList_Ing_egr_inve_det.Count == 0)
                {
                    MessageBox.Show("Debe existir al menos 1 item verifique ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }


                foreach (var item in BindList_Ing_egr_inve_det)
                {/*
                    if (item.dm_cantidad_sinConversion <= 0)
                    {
                        MessageBox.Show("El producto :" + item.cod_producto +  " No tiene cantidad verifique o comuniquese con sistema" , "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Valido = false;
                    }

                    if (item.mv_costo_sinConversion <= 0)
                    {
                        MessageBox.Show("El producto :" + item.cod_producto + " No tiene costo verifique o comuniquese con sistema", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Valido = false;
                    }*/
                    Valido = true;
                }

                if (!param.Validar_periodo_cerrado_x_modulo(param.IdEmpresa, Cl_Enumeradores.eModulos.INV, Convert.ToDateTime(dtpFecha.Value)))
                    return false;

                return Valido;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void limpiar()
        {

            try
            {


                this.txtcodigoAjuste.Text = "";
                this.txtNumAjuste.Text = "0";
                this.txtObservacion.Text = "";

                _sucursalInfo = null;
                _bodegaInfo = null;

                dtpFecha.Value = DateTime.Now;
                lblAnulado.Visible = false;

                _movi_inve_detalle_List_Info.Clear();
                _movi_inve_Info = null;


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
                _Accion = iAccion;
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                         ucGe_Menu.Enabled_bntAnular = false;
                       
                        limpiar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        ucGe_Menu.Enabled_bntAnular = false;
                       
                        
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:

                        ucGe_Menu.Enabled_bntAnular = false;
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;

                    case Cl_Enumeradores.eTipo_action.Anular:
                        ucGe_Menu.Enabled_bntGuardar_y_Salir = false;                        
                        ucGe_Menu.Visible_bntLimpiar = false;
                        ucGe_Menu.Enabled_btnGuardar = false;
                        break;

                }

            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void ObtenerIdBodegaSucursal()
        {
            try
            {
                _sucursalInfo = UCSucurBod.get_sucursal();
                _bodegaInfo = UCSucurBod.get_bodega();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FrmIn_Ajuste_Inventario_Mant()
        {
            try
            {
                InitializeComponent();                
                UCCentroCosto.cargaCmb_centroCostos();
                UCCentroCosto.Dock = DockStyle.Fill;

                InfoParametro = BusParametro.Get_Info_Parametro(param.IdEmpresa);                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        
        public void CargarProducto()
        {
            try
            {
                //cargar productos
                ObtenerIdBodegaSucursal();
                listProducto = Bus_Producto.Get_list_Producto(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega);
                cmbProducto_grid.DataSource = listProducto;
                cmbProducto_grid.DisplayMember = "pr_descripcion";
                cmbProducto_grid.ValueMember = "IdProducto";
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Cargar_Centro_Subcentro()
        {
            try
            {
                //Centro de costo
                ListCentro_Costo = BusCentroCosto.Get_list_Centro_Costo(param.IdEmpresa, ref msg);
                cmbCentroCosto_grid.DataSource = ListCentro_Costo;
                cmbCentroCosto_grid.DisplayMember = "Centro_costo2";
                cmbCentroCosto_grid.ValueMember = "IdCentroCosto";
                //Sub Centro de Costo
                list_subcentro_combo = Bus_SubCentroCosto.Get_list_centro_costo_sub_centro_costo(param.IdEmpresa);
                cmbSubcentro_costo.DataSource = list_subcentro_combo;

                lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida();
                cmbUnidadMedida.DataSource = lst_unidad_medida_para_combo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarTipoMovimiento()
        {
            try
            {

                opt_ingreso.Checked = true;
                _bodegaInfo = UCSucurBod.get_bodega();
                _sucursalInfo = UCSucurBod.get_sucursal();
                _listMovi_inve_tipo_info = tipoMoviBus.Get_list_movi_inven_tipo_x_bodega (param.IdEmpresa, _bodegaInfo.IdSucursal, _bodegaInfo.IdBodega, "", "");
                cargar_tipoMovi_Inven(_sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, "+", "");

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean validar()
        {

            try
            {
                /*
                if (txtObservacion.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese una observacion","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation );
                    return false;
                }


                if (_sucursalInfo.IdSucursal == 0)
                {
                    MessageBox.Show("No existe Sucursal verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (_bodegaInfo.IdBodega==0)
                {
                    MessageBox.Show("No existe bodega verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo() == null)
                {
                    MessageBox.Show("No existe Tipo de Ajuste verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

               // _movi_inve_detalle_List_Info = ucIn_Grid_Movi_Detalle1.get_DatosGrid();

                if (_movi_inve_detalle_List_Info.Count == 0)
                {
                    MessageBox.Show("No existe Items en el detalle verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                */
                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
       
        private void frmIn_AjustesInven_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                BindList_Ing_egr_inve_det = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = BindList_Ing_egr_inve_det;
                CargarProducto();
                Cargar_Centro_Subcentro();
                CargarTipoMovimiento();
                if (_movi_inve_Info != null)
                {
                    ucIn_TipoMoviInv_Cmb1.set_TipoMoviInvInfo(_movi_inve_Info.IdMovi_inven_tipo);
                }
                event_frmIn_AjustesInven_Mant_FormClosing += FrmIn_Ajuste_Inventario_Mant_event_frmIn_AjustesInven_Mant_FormClosing;                
                UCSucurBod.Event_cmb_bodega_SelectionChangeCommitted +=UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted;
               
                if (_Accion == null || _Accion == 0)
                { 
                    _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }

                if (_Accion == Cl_Enumeradores.eTipo_action.consultar || _Accion == Cl_Enumeradores.eTipo_action.actualizar || _Accion == Cl_Enumeradores.eTipo_action.Anular)
                {
                    set_AjusteMoviInven();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public delegate void delegate_frmIn_AjustesInven_Mant_FormClosing();

        public event delegate_frmIn_AjustesInven_Mant_FormClosing event_frmIn_AjustesInven_Mant_FormClosing;

        private void frmIn_AjustesInven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                event_frmIn_AjustesInven_Mant_FormClosing();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void FrmIn_Ajuste_Inventario_Mant_event_frmIn_AjustesInven_Mant_FormClosing()
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

        private void cargar_cbtecble()
        {
            try
            {               
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(Convert.ToInt32(_movi_inve_Info.IdEmpresa), Convert.ToInt32(_movi_inve_Info.IdSucursal), Convert.ToInt32(_movi_inve_Info.IdBodega), Convert.ToInt32(_movi_inve_Info.IdMovi_inven_tipo), Convert.ToDecimal(_movi_inve_Info.IdNumMovi));

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_tipoMovi_Inven(int IdSucursal, int idbodega, string tipo,string interno)
        {
            try
            {
                ucIn_TipoMoviInv_Cmb1.cargar_TipoMotivo(IdSucursal, idbodega, tipo, interno);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void opt_egreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {                
                cargar_tipoMovi_Inven(_sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, "-", "");                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void opt_ingreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargar_tipoMovi_Inven(_sucursalInfo.IdSucursal,_bodegaInfo.IdBodega, "+", "");
            }
            catch (Exception ex)
            { Log_Error_bus.Log_Error(ex.ToString());
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean Accion_Button()
        {
            try
            {
                switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        return grabar();
                   
                       break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                       return Anular();
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

        private void Imprimir()
        {
            try
            {
              
                XINV_Rpt005_rpt reporte = new XINV_Rpt005_rpt();
                reporte.IdEmpresa.Value = param.IdEmpresa;
                reporte.IdSucursal.Value = Convert.ToInt32(UCSucurBod.cmb_sucursal.EditValue);
                reporte.IdBodega.Value = Convert.ToInt32(UCSucurBod.cmb_bodega.EditValue);
                reporte.IdMoviInvenTipo.Value = Convert.ToInt32(ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo().IdMovi_inven_tipo);
                reporte.IdNumMovi.Value = Convert.ToDecimal(txtNumAjuste.Text);

                reporte.lblBodega.Text = UCSucurBod.cmb_bodega.Text;
                reporte.lblConcepto.Text = ucIn_TipoMoviInv_Cmb1.get_TipoMoviInvInfo().tm_descripcion;
                reporte.lblFechaMovimiento.Text = dtpFecha.Text;
                reporte.lblMovimiento.Text = txtNumAjuste.Text;
                reporte.lblIngresadoPor.Text = param.IdUsuario;                
                reporte.RequestParameters = false;


                DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(reporte);
                pt.AutoShowParametersPanel = false;
                reporte.ShowPreviewDialog();


                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _sucursalInfo.IdSucursal = _movi_inve_Info.IdSucursal;
                _bodegaInfo.IdEmpresa = _movi_inve_Info.IdEmpresa;
                _bodegaInfo.IdBodega = _movi_inve_Info.IdBodega;
                _bodegaInfo.IdSucursal = _movi_inve_Info.IdSucursal;
                this.UCSucurBod.set_sucursal(_sucursalInfo);
                _sucursalInfo.IdEmpresa = param.IdEmpresa;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            opt_ingreso.Checked = true;

            this.TmHilo.Enabled = true;
            oThreadBuscarConceptos = new Thread(new ThreadStart(CargarTipoMovimiento));
            oThreadBuscarConceptos.Start();
            oThreadBuscar = new Thread(new ThreadStart(CargarProducto));
            oThreadBuscar.Start();

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                this.Anular();            
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
                Accion_Button();
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
                if (Validaciones() == false)
                {
                    return;
                }
                if (Accion_Button())
                    this.Close();
                
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ucGe_Menu_event_btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void UCSucurBod_Event_cmb_bodega1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarProducto();
                if (opt_egreso.Checked)
                    opt_egreso_CheckedChanged(null, null);
                if (opt_ingreso.Checked)
                    opt_ingreso_CheckedChanged(null, null);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCSucurBod_Event_cmb_sucursal1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CargarProducto();
                if (opt_egreso.Checked)
                    opt_egreso_CheckedChanged(null, null);
                if (opt_ingreso.Checked)
                    opt_ingreso_CheckedChanged(null, null);
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
                if (InfoDet!= null)
                {
                    if (e.Column == colIdProducto)
                    {
                        itemProd = listProducto.FirstOrDefault(q => q.IdEmpresa == param.IdEmpresa && q.IdProducto == InfoDet.IdProducto);
                        if (itemProd != null)
                        {
                            InfoDet.cod_producto = itemProd.pr_codigo;
                            InfoDet.IdUnidadMedida_sinConversion = itemProd.IdUnidadMedida_Consumo;
                            InfoDet.dm_cantidad_sinConversion = 0;
                            InfoDet.mv_costo_sinConversion = 0;
                            InfoDet.pr_descripcion = itemProd.pr_descripcion;
                        }
                    }

                    if (e.Column == coldm_cantidad_sinConversion)
                    {
                        if (InfoDet.dm_cantidad < 0)
                            InfoDet.dm_cantidad = 0;
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
                RowHandle = e.FocusedRowHandle;
                if (Item != null)
                {
                    if (Item.IdEstadoAproba == Cl_Enumeradores.eEstadoAprobacion_Ing_Egr.APRO.ToString())
                    {
                        colIdProducto.OptionsColumn.AllowEdit = false;
                        coldm_cantidad_sinConversion.OptionsColumn.AllowEdit = false;
                        coldm_observacion.OptionsColumn.AllowEdit = false;
                        colIdCentroCosto_grid.OptionsColumn.AllowEdit = false;
                    }
                    else
                    {
                        colIdProducto.OptionsColumn.AllowEdit = true;
                        coldm_cantidad_sinConversion.OptionsColumn.AllowEdit = true;
                        coldm_observacion.OptionsColumn.AllowEdit = true;
                        colIdCentroCosto_grid.OptionsColumn.AllowEdit = true;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                colIdProducto.OptionsColumn.AllowEdit = true;
                coldm_cantidad_sinConversion.OptionsColumn.AllowEdit = true;
                coldm_observacion.OptionsColumn.AllowEdit = true;                
                //colUnidadMedida_Grid.OptionsColumn.AllowEdit = true;
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
                _Accion = Cl_Enumeradores.eTipo_action.grabar;
                UCSucurBod_Event_cmb_sucursal1_EditValueChanged(null, null);
                UCSucurBod_Event_cmb_bodega1_EditValueChanged(null, null);
                BindList_Ing_egr_inve_det = new BindingList<in_Ing_Egr_Inven_det_Info>();
                gridControlProductos.DataSource = BindList_Ing_egr_inve_det;
                txtNumAjuste.Text = "";
                txtcodigoAjuste.Text = "";
                txtObservacion.Text = "";
                info_IngEgr = new in_Ing_Egr_Inven_Info();
                info_IngEgr.listIng_Egr = new List<in_Ing_Egr_Inven_det_Info>();
                ucInv_GridCbte_Cble_x_Ing_Egr_Inv1.CargarDatos_CbteCble(0, 0, 0, 0, 0);                
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
                
                //ro_Empleado_Novedad_Det_Info newRow = new ro_Empleado_Novedad_Det_Info();
                in_Ing_Egr_Inven_det_Info newRow = new in_Ing_Egr_Inven_det_Info();
                if (rowData.Count() >= 3) //return false;          
                {

                    string cod_producto = rowData[0];
                    in_Producto_Info Info_Producto=new in_Producto_Info();
                    var QProducto = listProducto.FirstOrDefault(v => v.pr_codigo.Trim() == cod_producto.Trim());
                    if (QProducto != null)
                    { 
                        Info_Producto = listProducto.FirstOrDefault(v => v.pr_codigo == cod_producto); }
                    /*
                    else 
                    { 
                        MessageBox.Show("el codigo de este producto:" + cod_producto + " no esta en la base"); 
                        return false; 
                    }

                    */
                    
                    string IdUnidadMedida = Convert.ToString(rowData[2]);
                    double cantidad = Convert.ToDouble(rowData[3]);
                    double costo_unitario = Convert.ToDouble(rowData[4]);
                    string observacion = Convert.ToString (rowData[1]);


                    in_Ing_Egr_Inven_det_Info emp = new in_Ing_Egr_Inven_det_Info();
                    if (!string.IsNullOrWhiteSpace(cod_producto))
                    {
                        if (fx_Verificar_Reg_Repetidos(emp, false, 0))
                        {
                            newRow.IdProducto = Info_Producto.IdProducto;
                            newRow.cod_producto = cod_producto;
                            newRow.dm_cantidad = cantidad;
                            newRow.dm_cantidad_sinConversion = cantidad;
                            newRow.IdUnidadMedida = IdUnidadMedida == "" ? QProducto.IdUnidadMedida_Consumo: IdUnidadMedida;
                            newRow.IdUnidadMedida_sinConversion = IdUnidadMedida == "" ? QProducto.IdUnidadMedida_Consumo : IdUnidadMedida;
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

                    }
                    else
                    {
                        MessageBox.Show("Ya se encuentra registrado el codigo del producto # :" + cod_producto);
                        return false;
                    }

                    BindList_Ing_egr_inve_det.Add(newRow);
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
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
                return false;       
            }                                
        }

        Boolean banderaCargaBatch = false;

        private Boolean fx_Verificar_Reg_Repetidos(in_Ing_Egr_Inven_det_Info Info_det , Boolean eliminar, int tipo)
        {
            try
            {
                int cont = 0;


                
                if (banderaCargaBatch)
                {
                    cont = (from C in BindList_Ing_egr_inve_det
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad==Info_det.dm_cantidad
                            && C.mv_costo==Info_det.mv_costo
                            select C).Count();
                }
                else
                {
                    cont = (from C in lista_IngEgrInv
                            where C.cod_producto == Info_det.cod_producto
                            && C.dm_cantidad == Info_det.dm_cantidad
                            && C.mv_costo == Info_det.mv_costo
                            select C).Count();
                }


                if (cont == tipo)
                {
                    return true;
                }
                else
                {
                    if (eliminar == true)
                    {
                        gridViewProductos.DeleteRow(gridViewProductos.FocusedRowHandle);
                        MessageBox.Show("El producto con la misma cantidad y costo  ya se encuentra ingresado, se procederá con su eliminación.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El producto ya se encuentra ingresado.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); return false;
            }

        }

        private void cmbUnidadMedida_Click(object sender, EventArgs e)
        {
            try
            {
                Llamar_pantalla_unidad_medida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void cmbSubcentro_costo_Click(object sender, EventArgs e)
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
                            gridViewProductos.SetRowCellValue(RowHandle, colIdRegistro_subcentro, info_subcentro == null ? null : info_subcentro.IdRegistro);
                            gridViewProductos.SetRowCellValue(RowHandle, colIdSubcentro, info_subcentro == null ? null : info_subcentro.IdCentroCosto_sub_centro_costo);
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

        private void Llamar_pantalla_unidad_medida()
        {
            try
            {
                lst_unidad_medida_para_combo = new List<in_UnidadMedida_Info>();
                decimal IdProducto = 0;
                IdProducto = Convert.ToDecimal(gridViewProductos.GetRowCellValue(RowHandle, colIdProducto));
                itemProd = listProducto.FirstOrDefault(q => q.IdProducto == IdProducto);
                lst_unidad_medida_para_combo = bus_unidad_medida.Get_list_UnidadMedida_equivalencia(itemProd.IdUnidadMedida);

                FrmIn_Unidad_Medida_Consu frm_combo = new FrmIn_Unidad_Medida_Consu();
                frm_combo.set_config_combo(lst_unidad_medida_para_combo);
                frm_combo.ShowDialog();
                info_unidad_medida = frm_combo.Get_info_unidad_medida();
                gridViewProductos.SetRowCellValue(RowHandle, colIdUnidadMedida_sinConversion, info_unidad_medida == null ? null : info_unidad_medida.IdUnidadMedida);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewProductos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colIdProducto)
                {
                    gridViewProductos.SetRowCellValue(e.RowHandle, colIdProducto, e.Value);
                }
                if (e.Column == colIdCentroCosto_grid)
                {
                    gridViewProductos.SetRowCellValue(e.RowHandle, colIdRegistro_subcentro, null);
                    gridViewProductos.SetRowCellValue(e.RowHandle, colIdSubcentro, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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


    }
}

