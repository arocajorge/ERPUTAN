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
using Core.Erp.Reports.Inventario;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_AjustesInven_Mant : Form
    {

        #region declara
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega UCSucurBod = new UCIn_Sucursal_Bodega();
        UCInv_Grid_Movi_Detalle UCGridDetalleProduc = new UCInv_Grid_Movi_Detalle();
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

               

        in_movi_inven_tipo_Info _TipoMoviInven = new in_movi_inven_tipo_Info();
        in_producto_Bus _ProductoBus = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus _ProducxBodegaBus = new in_producto_x_tb_bodega_Bus();

        Thread oThreadBuscar;
        Thread oThreadBuscarConceptos;

        UCCon_CentroCosto UCCentroCosto = new UCCon_CentroCosto();
        in_Parametro_Bus BusParametro = new in_Parametro_Bus();
        in_Parametro_Info InfoParametro = new in_Parametro_Info();
     

        //Instancia de lista bodega
        List<tb_Bodega_Info> lmBodegaxCentroCosto = new List<tb_Bodega_Info>();
        private Cl_Enumeradores.eTipo_action _Accion;
#endregion


        public  void get_AjusteMoviInven()
        {
            try
            {

                _movi_inve_Info = new in_movi_inve_Info();

                _bodegaInfo = UCSucurBod.get_bodega();
                _sucursalInfo = UCSucurBod.get_sucursal();
                _movi_inve_Info.IdCentroCosto = UCCentroCosto.get_item();

                _movi_inve_Info.cm_anio = dtpFecha.Value.Year;
                _movi_inve_Info.cm_fecha = dtpFecha.Value;
                _movi_inve_Info.cm_mes = dtpFecha.Value.Month;
                _movi_inve_Info.cm_observacion = txtObservacion.Text.Trim();
                _movi_inve_Info.cm_tipo = (opt_ingreso.Checked == true) ? "+" : "-";
                _movi_inve_Info.CodMoviInven = txtcodigoAjuste.Text.Trim();
               // _movi_inve_Info.IdUsuario = param.IdUsuario;
                


                _movi_inve_Info.Estado = (lblAnulado.Visible == true) ? "I" : "A";
                _movi_inve_Info.IdBodega = _bodegaInfo.IdBodega;
                _movi_inve_Info.IdEmpresa = param.IdEmpresa;
                _movi_inve_Info.IdMovi_inven_tipo = _TipoMoviInven.IdMovi_inven_tipo;

                if (txtNumAjuste.Text.Length == 0)
                {
                    txtNumAjuste.Text = "0";
                }

                _movi_inve_Info.IdNumMovi = Convert.ToDecimal( txtNumAjuste.Text);
                _movi_inve_Info.IdSucursal = _sucursalInfo.IdSucursal;
                _movi_inve_Info.IdBodega = _bodegaInfo.IdBodega;

                List<in_movi_inve_detalle_Info> detalleTemp = new List<in_movi_inve_detalle_Info>();

                detalleTemp = this.UCGridDetalleProduc.get_DatosGrid();

                _movi_inve_detalle_List_Info = new List<in_movi_inve_detalle_Info>();
                
                foreach (in_movi_inve_detalle_Info item in detalleTemp)
                {
                    in_movi_inve_detalle_Info ItemDetalle= new in_movi_inve_detalle_Info();

                    ItemDetalle.dm_cantidad = item.dm_cantidad;
                    ItemDetalle.dm_observacion = item.dm_observacion;
                    ItemDetalle.dm_precio = item.dm_precio;
                    ItemDetalle.dm_stock_actu = item.dm_stock_actu;
                    ItemDetalle.dm_stock_ante = item.dm_stock_ante;
                    
                    ItemDetalle.IdEmpresa = param.IdEmpresa;
                    ItemDetalle.IdBodega = _bodegaInfo.IdBodega;
                    ItemDetalle.IdSucursal = _sucursalInfo.IdSucursal;

                    ItemDetalle.IdMovi_inven_tipo = _movi_inve_Info.IdMovi_inven_tipo;
                    ItemDetalle.IdNumMovi = _movi_inve_Info.IdNumMovi;
                    ItemDetalle.IdProducto = item.IdProducto;
                    
                    ItemDetalle.mv_costo = item.mv_costo;
                    ItemDetalle.mv_tipo_movi = _movi_inve_Info.cm_tipo;
                    ItemDetalle.peso = item.peso;
                    ItemDetalle.Secuencia = item.Secuencia;

                    _movi_inve_detalle_List_Info.Add(ItemDetalle);
                   
                }

                _movi_inve_Info.listmovi_inve_detalle_Info=_movi_inve_detalle_List_Info;            


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }         


        }


        private List<in_movi_inve_detalle_Info>  AsignarIdMovi_Inve(List<in_movi_inve_detalle_Info> listaMovi_Inve ,decimal IdMoviInven)
        {
            try
            {

                List<in_movi_inve_detalle_Info> _movi_inve_detalle_List_Info_T = new List<in_movi_inve_detalle_Info>();


                foreach (in_movi_inve_detalle_Info item in listaMovi_Inve)
                {
                    in_movi_inve_detalle_Info ItemDetalle = new in_movi_inve_detalle_Info();

                    ItemDetalle.dm_cantidad = item.dm_cantidad;
                    ItemDetalle.dm_observacion = _movi_inve_Info.cm_observacion.Trim() + " " +  item.dm_observacion.Trim();
                    ItemDetalle.dm_precio = item.dm_precio;
                    ItemDetalle.dm_stock_actu = item.dm_stock_actu;
                    ItemDetalle.dm_stock_ante = item.dm_stock_ante;
                    ItemDetalle.IdBodega = item.IdBodega;
                    ItemDetalle.IdEmpresa = item.IdEmpresa;
                    ItemDetalle.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                    ItemDetalle.IdNumMovi = IdMoviInven;
                    ItemDetalle.IdProducto = item.IdProducto;
                    ItemDetalle.IdSucursal = item.IdSucursal;
                    ItemDetalle.mv_costo = item.mv_costo;
                    ItemDetalle.mv_tipo_movi = item.mv_tipo_movi;
                    ItemDetalle.peso = item.peso;
                    ItemDetalle.Secuencia = item.Secuencia;

                    _movi_inve_detalle_List_Info_T.Add(ItemDetalle);

                }


                return _movi_inve_detalle_List_Info_T;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                return new List<in_movi_inve_detalle_Info>();               
                
            }
        
        }




        private void CargarDataAControles()
        {

            try
            {
                UCGridDetalleProduc.idSucursal = _movi_inve_Info.IdSucursal;
                UCGridDetalleProduc.idBodega = _movi_inve_Info.IdBodega;
                UCSucurBod.cmb_sucursal.SelectedValue = _movi_inve_Info.IdSucursal;
                UCSucurBod.cmb_bodega.SelectedValue = _movi_inve_Info.IdBodega;
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
                UCGridDetalleProduc.set_Datosgrid(_movi_inve_detalle_List_Info);


                cmb_tipoMoviInven.EditValue = _movi_inve_Info.IdMovi_inven_tipo;

               

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
            }
        }

        public void set_AjusteMoviInven(in_movi_inve_Info MoviInven_I)
        {
            try
            {


                _movi_inve_Info = MoviInven_I;
                _movi_inve_detalle_List_Info = OptenerDetalleMoviInven(MoviInven_I);
                _bodegaInfo.IdEmpresa = _movi_inve_Info.IdEmpresa;

                _sucursalInfo.IdSucursal = _movi_inve_Info.IdSucursal;

                _bodegaInfo.IdBodega = _movi_inve_Info.IdBodega;
                UCGridDetalleProduc.idSucursal = _movi_inve_Info.IdSucursal;
                UCGridDetalleProduc.idBodega = _movi_inve_Info.IdBodega;
                UCSucurBod.cmb_sucursal.SelectedValue = _movi_inve_Info.IdSucursal;
                UCSucurBod.cmb_bodega.SelectedValue = _movi_inve_Info.IdBodega;
                UCSucurBod.Enabled = false;

                cmb_tipoMoviInven.EditValue = MoviInven_I.IdMovi_inven_tipo;
              
                                


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
            }
        }


        private List<in_movi_inve_detalle_Info> OptenerDetalleMoviInven(in_movi_inve_Info MoviInven)
        {
            try
            {
                List<in_movi_inve_detalle_Info> listMoviInve_detalle = new List<in_movi_inve_detalle_Info>();
                
                listMoviInve_detalle = MoviInvenDetB.Obtener_list_Movi_inven_det(MoviInven.IdEmpresa, MoviInven.IdSucursal, MoviInven.IdBodega, MoviInven.IdMovi_inven_tipo, MoviInven.IdNumMovi);
                

                if (MoviInven.cm_tipo == "-")
                {

                    (from Movi in listMoviInve_detalle select Movi).ToList().ForEach(var => { var.dm_cantidad = var.dm_cantidad * -1; });

                }
                
                return listMoviInve_detalle;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                return new List<in_movi_inve_detalle_Info>() ;

            }

        }


        public Boolean grabar()
        {

            try
            {

                Boolean resultB;
                string mensaje="";

                resultB = true;

                if (Validaciones() == false)
                {
                    return false;
                }


                get_AjusteMoviInven();

                if (!(_movi_inve_Info == null))
                {
                    decimal idAjusteOut;
                    idAjusteOut = 0;



                    _movi_inve_Info.IdUsuario = param.IdUsuario;
                    _movi_inve_Info.IdUsuarioUltModi = param.IdUsuario;
                    _movi_inve_Info.ip = param.ip;
                    _movi_inve_Info.nom_pc = param.nom_pc;


                    //_movi_inve_detalle_List_Info = AsignarIdMovi_Inve(_movi_inve_Info.listmovi_inve_detalle_Info, idAjusteOut);
                    //if (_movi_inve_Info.cm_tipo == "-") // si es egreso 
                    //{
                    //    (from Movi in _movi_inve_detalle_List_Info select Movi).ToList().ForEach(var => { var.dm_cantidad = var.dm_cantidad * -1; });
                    //}


                    if (MoviInvenBuss.GrabarDB(_movi_inve_Info, ref  idAjusteOut,ref mensaje))// esta funcion graba internamente el detalle y contabiliza la transaccion
                    {
                        ///estas lineas estan en Business de moviinventario
                        /////---------------
                        //MoviInvenDetB.GrabarDB(_movi_inve_detalle_List_Info, ref mensaje);
                        //_ProducxBodegaBus.ActualizarStock_x_Bodega_con_moviInven(_movi_inve_detalle_List_Info, ref mensaje);
                        
                        
                        MessageBox.Show("Ajuste # "+ idAjusteOut  + " Por Concepto:" + "" + " Grabado Satisfactoriamente" , "Sistemas" ,MessageBoxButtons.OK, MessageBoxIcon.Information );
                        
                        resultB = true;
                        set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                        txtNumAjuste.Text = idAjusteOut.ToString();

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
                return false;

            }
        }

        //public Boolean Actualizar()
        //{

        //    try
        //    {

        //        Boolean resultB;
        //        string mensaje = "";


        //        if (Validaciones() == false)
        //        {
        //            return false;
        //        }

        //        if (MoviInvenBuss.ModificarDB (_movi_inve_Info,  ref mensaje))
        //        {


        //           // _movi_inve_detalle_List_Info = AsignarIdMovi_Inve(_movi_inve_Info.listmovi_inve_detalle_Info, idAjusteOut);
        //            MoviInvenDetB.GrabarDB (_movi_inve_detalle_List_Info, ref mensaje);
        //            _ProducxBodegaBus.ActualizarStock_x_Bodega_con_moviInven(_movi_inve_detalle_List_Info, ref mensaje);


        //            MessageBox.Show("Ajuste # " + _movi_inve_Info.IdNumMovi + " Por Concepto:" + cmb_tipoMoviInven.Text + " Actualizado Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            resultB = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show(" Error al Actualizar Ajuste verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            resultB = false;
        //        }

        //        return resultB;

        //    }
        //    catch (Exception)
        //    {
        //        return false;

        //    }
        //}

        public Boolean Anular()
        {


            try
            {


                Boolean resultB=false;
                string mensaje = "";


             
                _movi_inve_Info.listmovi_inve_detalle_Info = _movi_inve_detalle_List_Info;


                if (MessageBox.Show("¿Está seguro que desea anular el ajuste  ?", "Anulación de ajuste de inventario  " + param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    frmGe_MotivoAnulacion ofrm = new frmGe_MotivoAnulacion();
                    ofrm.ShowDialog();


                    _movi_inve_Info.IdusuarioUltAnu = param.IdUsuario;
                    _movi_inve_Info.Fecha_UltAnu = DateTime.Now;
                    _movi_inve_Info.MotivoAnulacion = ofrm.motivoAnulacion;

                    if (MoviInvenBuss.AnularDB(_movi_inve_Info,Convert.ToDateTime(DateTime.Now.ToShortDateString()), ref mensaje))
                    {
                        MessageBox.Show("Ajuste # " + _movi_inve_Info.IdNumMovi + " Por Concepto:" + cmb_tipoMoviInven.Text + " ANULADO Satisfactoriamente", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show(" Error al ANULAR Ajuste verifique con sistemas ...: " + mensaje, "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resultB = false;
                    }
                }


                return resultB;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
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


                if (cmb_tipoMoviInven.Text == "")
                {
                    MessageBox.Show("Debe escoger un tipo ajuste ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                List<in_movi_inve_detalle_Info> detalleInfo = new List<in_movi_inve_detalle_Info>();


                detalleInfo = UCGridDetalleProduc.get_DatosGrid();


                if (detalleInfo.Count == 0)
                {
                    MessageBox.Show("Debe existir al menos 1 item verifique ", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Valido = false;
                }


                foreach (var item in detalleInfo)
                {
                    if (item.dm_cantidad <= 0)
                    {
                        MessageBox.Show("El producto :" + item.NomProducto +  "No tiene cantidad verifique o comuniquese con sistema" , "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Valido = false;
                    }

                    if (item.mv_costo <= 0)
                    {
                        MessageBox.Show("El producto :" + item.NomProducto + "No tiene costo verifique o comuniquese con sistema", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Valido = false;
                    }
                }

               

                return Valido;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
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

                //cmb_tipoMoviInven.SelectedValue = -999;
                this.UCGridDetalleProduc.LimpiarGrid();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                 
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
                        this.btnGrabar.Text = "Grabar";
                        this.btnGrabar.Enabled = true;
                        this.btnlimpiar.Enabled = true;
                        this.btnAnular.Enabled = true;
                        limpiar();
                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        this.btnGrabar.Text = "Actualizar";
                        this.btnGrabar.Enabled = true;
                        this.btnlimpiar.Enabled = true;
                        
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                       
                        this.btnGrabar.Enabled = false;
                        this.btnGrabarySalir.Enabled = false;
                        this.btnAnular.Enabled = false;
                        this.btnAnular.Visible = false;
                        this.btnlimpiar.Visible = false;
                        this.btnlimpiar.Enabled = false;



                        break;

                    case Cl_Enumeradores.eTipo_action.borrar:
                       
                        this.btnGrabar.Enabled = false;
                        this.btnGrabarySalir.Enabled = false;
                        this.btnAnular.Enabled = true;
                        this.btnlimpiar.Enabled = false;
                       

                        break;


                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
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
            }

        }


        public frmIn_AjustesInven_Mant()
        {
            try
            {

                InitializeComponent();


                UCSucurBod.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucurBod_Event_cmb_sucursal_SelectionChangeCommitted);
                UCSucurBod.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted);

                this.panelSucursal_bodega.Controls.Add(UCSucurBod);
                UCSucurBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                UCSucurBod.Dock = DockStyle.Fill;


                UCGridDetalleProduc.idBodega = 1;
                UCGridDetalleProduc.idSucursal = 1;
                this.panelDetalleProducto.Controls.Add(UCGridDetalleProduc);
                UCGridDetalleProduc.Dock = DockStyle.Fill;

                UCCentroCosto.cargaCmb_centroCostos();
                //panelCentroCosto.Controls.Add(UCCentroCosto);
                UCCentroCosto.Dock = DockStyle.Fill;
                UCCentroCosto.Event_ultraComboE_CentroCosto_SelectionChanged += new UCCon_CentroCosto.delegateultraComboE_CentroCosto_SelectionChanged(UCCentroCosto_Event_ultraComboE_CentroCosto_SelectionChanged); ;

                UCGridDetalleProduc.VisibleCodigo = true;
                UCGridDetalleProduc.VisibleCosto = true;
                UCGridDetalleProduc.VisiblePeso = true;
                UCGridDetalleProduc.VisibleStockAnterior = true;
                UCGridDetalleProduc.VisibleStock = true;
           

                //kft
                UCGridDetalleProduc._tipomovi = UCInv_Grid_Movi_Detalle.eTipoMovi.Ingreso;
                InfoParametro = BusParametro.ObtenerParametros(param.IdEmpresa);
                UCGridDetalleProduc.ValidaStock = (InfoParametro.Maneja_Stock_Negativo == "S") ? false : true;
                //kft
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                
            }  
        }


        #region Eventos Delegados 
        void UCSucurBod_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //CargarMovimiento();
                //CargarProducto();

                #region que estaba manejando hilos
//                SplashScreenManager.ShowForm(typeof(frmGe_Esperar));
                this.TmHilo.Enabled = true;


                oThreadBuscarConceptos = new Thread(new ThreadStart(CargarTipoMovimiento));
                oThreadBuscarConceptos.Start();

                oThreadBuscar = new Thread(new ThreadStart(CargarProducto));
                oThreadBuscar.Start();
                #endregion
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


                //SplashScreenManager.ShowForm(typeof(frmGe_Esperar));
                this.TmHilo.Enabled = true;


                oThreadBuscarConceptos = new Thread(new ThreadStart(CargarTipoMovimiento));
                oThreadBuscarConceptos.Start();

                oThreadBuscar = new Thread(new ThreadStart(CargarProducto));
                oThreadBuscar.Start();




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


        
        public void CargarProducto()
        {

            try
            {

                ObtenerIdBodegaSucursal();

                //UCGridDetalleProduc.idSucursal = Convert.ToInt32(UCSucurBod.cmb_sucursal.SelectedValue);
                //UCGridDetalleProduc.idBodega = Convert.ToInt32(UCSucurBod.cmb_bodega.SelectedValue);

                UCGridDetalleProduc.idSucursal = UCGridDetalleProduc.idSucursal;
                UCGridDetalleProduc.idBodega = UCGridDetalleProduc.idBodega;
                UCGridDetalleProduc.load_Producto();
                UCGridDetalleProduc.LimpiarGrid();



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }


        public void CargarTipoMovimiento()
        {
            try
            {

                _bodegaInfo = UCSucurBod.get_bodega();
                _sucursalInfo = UCSucurBod.get_sucursal();
                _listMovi_inve_tipo_info = tipoMoviBus.Obtener_list_movi_inven_tipo_x_bodega(param.IdEmpresa, _bodegaInfo.IdSucursal, _bodegaInfo.IdBodega, "", "");
                cargar_tipoMovi_Inven(_bodegaInfo.IdBodega, "+", "");


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                
            }
        }


        private Boolean validar()
        {

            try
            {

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

                if (cmb_tipoMoviInven.Text == "")
                {
                    MessageBox.Show("No existe Tipo de Ajuste verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                _movi_inve_detalle_List_Info = UCGridDetalleProduc.get_DatosGrid();

                if (_movi_inve_detalle_List_Info.Count == 0)
                {
                    MessageBox.Show("No existe Items en el detalle verfique...", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                return false;
            }
        }


        private void frmIn_AjustesInven_Mant_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProducto();
                CargarTipoMovimiento();

                cmb_tipoMoviInven.EditValue = _movi_inve_Info.IdMovi_inven_tipo;

                

                CargarDataAControles();

               
                if (_Accion == null || _Accion == 0)
                { _Accion = Cl_Enumeradores.eTipo_action.grabar;
                }


                if (_Accion == Cl_Enumeradores.eTipo_action.consultar)
                {
                    cargar_cbtecble();
                }




                this.event_frmIn_AjustesInven_Mant_FormClosing += frmIn_AjustesInven_Mant_event_frmIn_AjustesInven_Mant_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }


        private void cargar_cbtecble()
        {
            try
            {
                ucCon_GridDiarioContable_.setAccion(Cl_Enumeradores.eTipo_action.consultar);

                in_movi_inve_x_ct_cbteCble_Bus MoviInven_Cbtcble_BUS = new in_movi_inve_x_ct_cbteCble_Bus();
                in_movi_inve_x_ct_cbteCble_Info MoviInven_Cbtcble_info = new in_movi_inve_x_ct_cbteCble_Info();


                MoviInven_Cbtcble_info = MoviInven_Cbtcble_BUS.Obtener_x_Movi_Inven(_movi_inve_Info.IdEmpresa,
                    _movi_inve_Info.IdSucursal, _movi_inve_Info.IdBodega, _movi_inve_Info.IdMovi_inven_tipo, _movi_inve_Info.IdNumMovi);


                this.ucCon_GridDiarioContable_.setInfo(MoviInven_Cbtcble_info.IdEmpresa, MoviInven_Cbtcble_info.IdTipoCbte, MoviInven_Cbtcble_info.IdCbteCble);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                
            }
        }




       


        private void cargar_tipoMovi_Inven(int idbodega, string tipo,string interno)
        {
            try
            {

                var q = from tmovi in _listMovi_inve_tipo_info
                        where tmovi.cm_tipo_movi.Contains(tipo)
                        && tmovi.cm_interno.Contains(interno)
                        select tmovi;
                
                cmb_tipoMoviInven.Properties.DataSource= q.ToList();
               //cmb_tipoMoviInven.Properties.DisplayMember= "tm_descripcion2";
                //cmb_tipoMoviInven.Properties.ValueMember= "IdMovi_inven_tipo";


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }
       
        private void opt_egreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargar_tipoMovi_Inven(_bodegaInfo.IdBodega, "-", "");
                this.UCGridDetalleProduc._tipomovi = UCInv_Grid_Movi_Detalle.eTipoMovi.Egreso;
                this.UCGridDetalleProduc.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());   
                
            }
            
        }

        private void opt_ingreso_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cargar_tipoMovi_Inven(_bodegaInfo.IdBodega, "+", "");
                this.UCGridDetalleProduc._tipomovi = UCInv_Grid_Movi_Detalle.eTipoMovi.Ingreso;
                this.UCGridDetalleProduc.LimpiarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

        private void mnu_salir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }



        }

        //private void cmb_tipoMoviInven_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        _TipoMoviInven = (in_movi_inven_tipo_Info)cmb_tipoMoviInven.SelectedItem;
        //    }
        //    catch (Exception ex)
        //    {
                
                
        //    }
            

        //}
        
        private void Accion_Button()
        {
            try
            {
                 switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        this.grabar();
                   
                       break;
                    case Cl_Enumeradores.eTipo_action.borrar:
                       this.Anular();
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
            }
            


        
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                Accion_Button();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
            }            

        }

        private void btnGrabarySalir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones() == false)
                {
                    return ;
                }
                Accion_Button();
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
            }       

            
        }

        private void mnu_anular_Click(object sender, EventArgs e)
        {
            try
            {
                this.Anular();
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

       
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());      
                
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Imprimir();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  

            }

        }

        private void Imprimir()
        {

            try
            {

                in_movi_inve_Bus MoviB = new in_movi_inve_Bus();
                in_movi_inve_Info DataMoviInven = new in_movi_inve_Info();
                List<in_movi_inve_Info> listMoviIn= new List<in_movi_inve_Info>();



                DataMoviInven = MoviB.Obtener_list_Movi_inven_Reporte(param.IdEmpresa, _sucursalInfo.IdSucursal, _bodegaInfo.IdBodega, _TipoMoviInven.IdMovi_inven_tipo, Convert.ToDecimal(this.txtNumAjuste.Text));

                listMoviIn.Add(DataMoviInven);


                XRpt_in_Ajuste_inventario RptAjuste = new XRpt_in_Ajuste_inventario();
                RptAjuste.cargarData(listMoviIn.ToArray());
                RptAjuste.ShowPreviewDialog();




                //XRpt_cp_OrdenGiro reprtOG = new XRpt_cp_OrdenGiro(param.IdUsuario);
                //ReportParameter reprtOG_Parametro = new ReportParameter();
                //cp_orden_giro_Bus ob = new cp_orden_giro_Bus();
                //List<cp_orden_giro_Info> lOg = new List<cp_orden_giro_Info>();
                //lOg = ob.ObtenerOrdenGiro(param.IdEmpresa, ordenGiro_I.IdCbteCble_Ogiro);


                //reprtOG.loadData(lOg.ToArray());
                //reprtOG.ShowPreviewDialog();


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                  
            }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                 _sucursalInfo.IdEmpresa = param.IdEmpresa;
                _sucursalInfo.IdSucursal = _movi_inve_Info.IdSucursal;
                _bodegaInfo.IdEmpresa = _movi_inve_Info.IdEmpresa;
                _bodegaInfo.IdBodega = _movi_inve_Info.IdBodega;
                _bodegaInfo.IdSucursal = _movi_inve_Info.IdSucursal;


                this.UCSucurBod.set_sucursal(_sucursalInfo);
               // this.UCSucurBod.set_bodega(_bodegaInfo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }        


        }

        private void frmIn_AjustesInven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               event_frmIn_AjustesInven_Mant_FormClosing();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }
        public delegate void delegate_frmIn_AjustesInven_Mant_FormClosing();
        public event delegate_frmIn_AjustesInven_Mant_FormClosing event_frmIn_AjustesInven_Mant_FormClosing;
        void frmIn_AjustesInven_Mant_event_frmIn_AjustesInven_Mant_FormClosing(){}

        private void cmb_tipoMoviInven_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _TipoMoviInven = (in_movi_inven_tipo_Info)cmb_tipoMoviInven.Properties.View.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());   
                
            }
            
        }

     
        
    }
}


/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 1207
/// </summary>