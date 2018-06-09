using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.Inventario_Cidersus;
using Core.Erp.Business.Inventario_Edehsa;

using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario_Edehsa;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using System.Threading;
using Cus.Erp.Reports.Cidersus.Produccion;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ConversionProducto : Form
    {
        #region  VARIABLES

        Int32 Sec = 0;

        string CodigoBarra = "";
        double PesoSubPieza = 0;
        double PesoPorDimensiopn = 0;
        double pr_largoMpSobrante = 0, pr_altoMpSobrante = 0, pr_PesoMpSobrante;
        decimal idMovimientoimprimir=0;
        decimal idMovimientoimprimirMPSobrante=0;
        in_movi_inve_detalle_x_Producto_CusCider_Bus Bus_TablaIntermedia = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        prd_Conversion_CusCidersus_Bus prdBus = new prd_Conversion_CusCidersus_Bus();

        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_Producto_Dimensiones_bus BusProductoDimensiones = new in_Producto_Dimensiones_bus();

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_OrdenTaller_Bus _OrdenTAller_B = new prd_OrdenTaller_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();
        in_movi_inve_Bus Bus_Movimiento = new in_movi_inve_Bus();
        in_producto_x_tb_bodega_Bus ProductXBodega_Bus = new in_producto_x_tb_bodega_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        prd_EtapaProduccion_Bus Etapa_B = new prd_EtapaProduccion_Bus();
        prd_SubGrupoTrabajo_Bus Bus_GrupoTrabajo = new prd_SubGrupoTrabajo_Bus();
        in_movi_inve_detalle_Bus BusDetalle = new in_movi_inve_detalle_Bus();

        List<in_movi_inve_detalle_Info> ListaDetalle_SubProductos = new List<in_movi_inve_detalle_Info>();
        List<in_movi_inve_detalle_Info> ListaDetalle_MP_Sobrante_POrCorteMP = new List<in_movi_inve_detalle_Info>();
        BindingList<in_Producto_Info> Listas_Prod_convertir = new BindingList<in_Producto_Info>();
        prd_Conversion_CusCidersus_Info _Info = new prd_Conversion_CusCidersus_Info();
        prd_ProcesoProductivo_x_prd_obra_Info Obra = new prd_ProcesoProductivo_x_prd_obra_Info();
        BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaSubPiezas = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaRetazoTmp = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaMP_SobranteTablaIntermedia = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_Producto_Info> LstNewProduc = new List<in_Producto_Info>();

        in_movi_inve_detalle_Info InfoDetalleSubPieza = null;
        in_movi_inve_detalle_Info InfoDetalleMPSobrante = null;
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoSubPiezasTablaIntermedia = null;
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoMP_SobranteTablaIntermedia = null;
        in_movi_inve_Info InfoSubPiezaCab = null;
        in_movi_inve_Info InfoMP_Sobrante_CAB = null;
        in_movi_inve_detalle_x_Producto_CusCider_Info InfoProductoAcortar = new in_movi_inve_detalle_x_Producto_CusCider_Info();

        in_Producto_Dimensiones_Info InfoProductoDimensiones = new in_Producto_Dimensiones_Info();

        prd_OrdenTaller_Info OrdenTAller = new prd_OrdenTaller_Info();      
        string msgs = "";
        prd_SubGrupoTrabajo_Info Grupo = new prd_SubGrupoTrabajo_Info();
       #endregion  
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
              _Accion = iAccion;
               
                switch (iAccion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                       

                        break;

                    case Cl_Enumeradores.eTipo_action.consultar:
                       
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                       

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
        public FrmPrd_ConversionProducto()
        {
            try
            {
                InitializeComponent();
                dtpFecha.EditValue = DateTime.Now;
                cmbObra.Properties.DataSource = BusOBra.ObtenerListaObra(param.IdEmpresa);
                _Parametros_Info = param_Produccion.ObtenerObjeto(param.IdEmpresa);
               

             

                ucGe_Menu.event_btnSalir_Click += ucGe_Menu_event_btnSalir_Click;
                ucGe_Menu.event_btnAnular_Click += ucGe_Menu_event_btnAnular_Click;


                _Accion = Cl_Enumeradores.eTipo_action.grabar;



                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbProducto_EditValueChanged(object sender, EventArgs e){}
        private void cmbProducto_Properties_EditValueChanged(object sender, EventArgs e){}
        void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {

            try
            {
                if (Validar())
                {
                    //ucGe_Menu_event_btnGuardar_Click(sender, e);
                    Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }   
        decimal IdRegistr = 0;
        public delegate void Delegate_FrmPrd_ConversionProducto_FormClosing(object sender, FormClosingEventArgs e);
        public event Delegate_FrmPrd_ConversionProducto_FormClosing Event_FrmPrd_ConversionProducto_FormClosing;
        private void FrmPrd_ConversionProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               Event_FrmPrd_ConversionProducto_FormClosing(sender, e);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        private void FrmPrd_ConversionProducto_Load(object sender, EventArgs e)
        {
            try
            {
                cargacombos();
                gridControlElementosRestantes.DataSource = ListaRetazoTmp;
                Event_FrmPrd_ConversionProducto_FormClosing += new Delegate_FrmPrd_ConversionProducto_FormClosing(FrmPrd_ConversionProducto_Event_FrmPrd_ConversionProducto_FormClosing);

                switch (_Accion)
                {

                    case Cl_Enumeradores.eTipo_action.grabar:

                        break;
                    
                    case Cl_Enumeradores.eTipo_action.Anular:

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
                
                MessageBox.Show(ex.ToString());
            }
        }       
        void FrmPrd_ConversionProducto_Event_FrmPrd_ConversionProducto_FormClosing(object sender, FormClosingEventArgs e){}
        void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
       {
           
            try
            {
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtProduct_EditValueChanged(object sender, EventArgs e){ }
        prd_EtapaProduccion_Info Etapa = new prd_EtapaProduccion_Info();
        private void gridViewFinal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridViewSubPiezas.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        void cargacombos()
        {//cmbOrdenTaller
            //cmbGT

            try
            {
                cmbOrdenTaller.Properties.DataSource = _OrdenTAller_B.ObtenerListaOT(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


        }
        private void cmbObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //txtCodigoBarra.Text = "";

                //////REVISAR EL OBTENER LISTA OT X CENTRO DE COSTO
                ///////////////////////////////////////////////////

                //cmbOrdenTaller.Properties.DataSource = _OrdenTAller_B.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, cmbObra.EditValue.ToString());
                //prd_ProcesoProductivo_x_prd_obra_Bus Bus = new prd_ProcesoProductivo_x_prd_obra_Bus();
                //Obra = Bus.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, cmbObra.EditValue.ToString());
                gridViewSubPiezas.SelectAll();
                gridViewSubPiezas.DeleteSelectedRows();

             


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        private void cmbGT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    Grupo = new prd_SubGrupoTrabajo_Info();
                    Etapa = new prd_EtapaProduccion_Info();
                    Etapa = Etapa_B.ObtenerEtapa(param.IdEmpresa, Grupo.IdEtapa, Obra.IdProcesoProductivo);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        private void txtCodigoBarra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string sTipoMovimiento = "-";
                if (e.KeyChar == 13)
                {
                    InfoProductoAcortar = BusInve.TraeProductoxCodigoBarra_UltMov(txtCodigoBarra.Text, param.IdEmpresa, sTipoMovimiento);

                    if (InfoProductoAcortar.CodigoBarra != null)
                    {
                        InfoProductoDimensiones = BusProductoDimensiones.Get_Info_BuscarProducto_Dimensiones(param.IdEmpresa, InfoProductoAcortar.IdProducto);
                        txtProducto.Text = InfoProductoAcortar.pr_descripcion;

                        //txtProfundidad.Text =Convert.ToString( InfoProductoAcortar.pr_profundidad);
                        //txtaltura.Text = Convert.ToString(InfoProductoAcortar.pr_alto);
                        //txtAncho.Text = Convert.ToString(InfoProductoAcortar.pr_largo);

                        txtProfundidad.Text = Convert.ToString(InfoProductoAcortar.pr_profundidad);
                        txtaltura.Text = Convert.ToString(InfoProductoDimensiones.alto);
                        txtAncho.Text = Convert.ToString(InfoProductoDimensiones.longitud);


                        CodigoBarra = txtCodigoBarra.Text;
                        TxtPeso.Text = InfoProductoAcortar.pr_peso.ToString();
                        //cmbObra.EditValue = InfoProductoAcortar.ot_CodObra;
                        //cmbOrdenTaller.EditValue = InfoProductoAcortar.ot_IdOrdenTaller;
                        txtCodigoBarra.Text = "";
                        //txtProfundidad.Text = "";
                        //TxtPeso.Text = "";
                        //txtaltura.Text = "";
                        //txtAncho.Text = "";
                        //txtProducto.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El Producto con CB:"+ txtCodigoBarra.Text + "No registra Egreso" );
                    }
                    
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
            
        }
        private void txtalturaCortar_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtalturaCortar.Text != "")
                {
                    if (Convert.ToDouble(txtalturaCortar.Text) > Convert.ToDouble(txtaltura.Text))
                    {
                        MessageBox.Show("Error la Altura Ingresada excede a la del Producto");
                        txtalturaCortar.Text = "";
                    }

                    //if ((Convert.ToInt32(txtalturaCortar.Text) * Convert.ToInt32(txtUnidadesCortadas.Text)) > Convert.ToInt32(txtaltura.Text))
                    //{
                    //    MessageBox.Show("Error " + txtUnidadesCortadas.Text + " * " + txtalturaCortar.Text + "Es Mayor Altura " + txtaltura.Text);
                    //    txtalturaCortar.Text = "";
                    //}

                    if (txtLargoCortar.Text != "")
                        if (Convert.ToDouble(txtLargoCortar.Text) > Convert.ToDouble(txtAncho.Text))
                        {
                            MessageBox.Show("Error el valor Ingresado excede a la del Producto");
                            txtLargoCortar.Text = "";
                        }


                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
           
        }
        private void txtLargoCortar_EditValueChanged(object sender, EventArgs e)
          {
              try
              {
                  if (txtLargoCortar.Text != "")
                  {
                      //if (Convert.ToDouble(txtalturaCortar.Text) > Convert.ToDouble(txtaltura.Text))
                      //    MessageBox.Show("Error la Altura Ingresada excede a la del Producto");

                      if ((Convert.ToInt32(txtLargoCortar.Text) * Convert.ToInt32(txtUnidadesCortadas.Text)) > Convert.ToInt32(txtAncho.Text))
                          MessageBox.Show("Error "+txtUnidadesCortadas.Text+" * " +txtLargoCortar.Text +"Es Mayor Largo "+txtaltura.Text);
                         
                      if (txtLargoCortar.Text != "")
                          if (Convert.ToDouble(txtLargoCortar.Text) > Convert.ToDouble(txtAncho.Text))
                              MessageBox.Show("Error El Largo Ingresado excede a la del Producto");
                          
                             
                  }
              }
              catch (Exception ex)
              {

                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.Message);
              }

          }
        private void BtnGenerar_Click(object sender, EventArgs e)
          {

          }
        private void BtnGenerar_Click_1(object sender, EventArgs e)
          {
              try
              {
                  ObtenerPesoSubpieza(InfoProductoAcortar.pr_peso);
                  GenerarSuPiezas();

              }
              catch (Exception ex)
              {
                  
                  Log_Error_bus.Log_Error(ex.ToString());
                  MessageBox.Show(ex.Message);
              }
          }
        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Grabar();
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {
            
        }
        private void gridViewSubPiezas_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
          
        }
        public void GenerarSuPiezas()
        {
            try
            {

                Int32 cont = Convert.ToInt32(txtUnidadesCortadas.Text);
                //Int32 Sec = 0;
                while (cont > 0)
                {
                    Sec++;
                    cont--;                
                    // generacion de datos para tabla in_movi_inve_detalle_x_Producto_CusCider
                    InfoSubPiezasTablaIntermedia = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    InfoSubPiezasTablaIntermedia.IdEmpresa = param.IdEmpresa;
                    InfoSubPiezasTablaIntermedia.IdSucursal = param.IdSucursal;
                    InfoSubPiezasTablaIntermedia.IdBodega = InfoProductoAcortar.IdBodega;

                    InfoSubPiezasTablaIntermedia.IdMovi_inven_tipo = 3;// ING X CONV A PROD 
                    //InfoDetalleSubPieza.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);

                    InfoSubPiezasTablaIntermedia.IdNumMovi = 0;
                    InfoSubPiezasTablaIntermedia.mv_Secuencia = 1;
                    InfoSubPiezasTablaIntermedia.Secuencia = Sec;
                    InfoSubPiezasTablaIntermedia.IdProducto = InfoProductoAcortar.IdProducto;
                    InfoSubPiezasTablaIntermedia.CodigoBarra = CodigoBarra + "-" + "C" + "-" + Sec + "-" + Convert.ToDouble(txtalturaCortar.Text) + "X" + Convert.ToDouble(txtLargoCortar.Text);
                    InfoSubPiezasTablaIntermedia.mv_tipo_movi = "-";
                    InfoSubPiezasTablaIntermedia.dm_cantidad = 1;
                    InfoSubPiezasTablaIntermedia.dm_observacion = txtObserva.Text;
                    InfoSubPiezasTablaIntermedia.dm_precio = InfoProductoAcortar.dm_precio;
                    InfoSubPiezasTablaIntermedia.mv_costo = InfoProductoAcortar.mv_costo;
                    InfoSubPiezasTablaIntermedia.pr_Descripcion = "CORTE PROD" + InfoProductoAcortar.IdProducto + InfoProductoAcortar.pr_Descripcion + "PARA" + cmbOrdenTaller.Text;
                    InfoSubPiezasTablaIntermedia.pr_alto = Convert.ToDouble(txtalturaCortar.Text);
                    InfoSubPiezasTablaIntermedia.pr_largo = Convert.ToDouble(txtLargoCortar.Text);
                    InfoSubPiezasTablaIntermedia.ot_CodObra = cmbObra.EditValue.ToString();
                    InfoSubPiezasTablaIntermedia.ot_IdOrdenTaller = Convert.ToDecimal(cmbOrdenTaller.EditValue);
                    InfoSubPiezasTablaIntermedia.et_IdProcesoProductivo = InfoProductoAcortar.et_IdProcesoProductivo;
                    InfoSubPiezasTablaIntermedia.pr_peso = PesoSubPieza;

                    InfoSubPiezasTablaIntermedia.ocd_IdOrdenCompra = InfoProductoAcortar.ocd_IdOrdenCompra;
                    InfoSubPiezasTablaIntermedia.NumDocumentoRelacionadoProveedor = InfoProductoAcortar.NumDocumentoRelacionadoProveedor;
                    InfoSubPiezasTablaIntermedia.NumFacturaProveedor = InfoProductoAcortar.NumFacturaProveedor;

                    ListaSubPiezas.Add(InfoSubPiezasTablaIntermedia);
                }
                gridControlSubPiezas.DataSource = ListaSubPiezas;
                gridControlSubPiezas.RefreshDataSource();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
        public  void Set(prd_Conversion_CusCidersus_Info _SetInfo)
        {

            try
            {
                txtIdNumRegistro.Text = _SetInfo.IdNumMov.ToString();
                dtpFecha.EditValue = _SetInfo.Fecha;
                txtObserva.Text = _SetInfo.Observacion;
                cmbObra.EditValue = _SetInfo.CodObra;
                cmbOrdenTaller.EditValue = _SetInfo.IdOrdenTaller;
                if (_SetInfo.Estado == "I")
                {
                    lbl_Estado.Visible = true;    
                }

                ListaSubPiezas =new BindingList<Info.Produc_Cirdesus.in_movi_inve_detalle_x_Producto_CusCider_Info>( Bus_TablaIntermedia.GetConsUltaProductoCortados(_SetInfo.IdEmpresa, _SetInfo.IdSucursal, _SetInfo.IdBodega,Convert.ToInt32( _SetInfo.IdMovi_inven_Tipo), Convert.ToInt32(_SetInfo.IdNumMov)));
                txtObserva.Text = ListaSubPiezas.FirstOrDefault().dm_observacion;
                gridControlSubPiezas.DataSource = ListaSubPiezas;
                gridControlSubPiezas.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        Boolean Validar()
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtObserva.Text))
                {
                    MessageBox.Show("Ingrese una Observacion");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbObra.Text))
                {
                    MessageBox.Show("Por Favor seleccionar Obra");
                    return false;
                }
                if (string.IsNullOrEmpty(cmbOrdenTaller.Text))
                {
                    MessageBox.Show("Por Favor Seleccionar Orden de Taller");
                    return false;
                }

                if (ListaSubPiezas.Count == 0)
                {
                    MessageBox.Show("No hay Detalle del Producto Cortado");
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
        public void Get()
        {
            try
            {

                gridControlSubPiezas.DataSource = ListaSubPiezas;
                ListaMP_SobranteTablaIntermedia = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();



                //**************** generar datos para las piezas cortadas*********************************
                 int sec = 0;
            foreach (var item in ListaSubPiezas)
            {
                InfoDetalleSubPieza = new in_movi_inve_detalle_Info();
                InfoDetalleSubPieza.IdEmpresa =item.IdEmpresa;
                InfoDetalleSubPieza.IdSucursal = item.IdSucursal;
                InfoDetalleSubPieza.IdBodega = item.IdBodega;

                InfoDetalleSubPieza.IdMovi_inven_tipo = 3;
                //InfoDetalleSubPieza.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);

                InfoDetalleSubPieza.IdNumMovi = 0;
                InfoDetalleSubPieza.Secuencia = item.Secuencia;
                InfoDetalleSubPieza.mv_tipo_movi = "+";
                InfoDetalleSubPieza.IdProducto = InfoProductoAcortar.IdProducto;
                InfoDetalleSubPieza.dm_cantidad = 1;
                InfoDetalleSubPieza.dm_stock_actu = 1;
                InfoDetalleSubPieza.dm_stock_ante = 1;
                InfoProductoAcortar.dm_observacion = "SUBPIEZA " + InfoProductoAcortar.IdProducto + "-" + txtCodigoBarra.Text;
                InfoDetalleSubPieza.dm_precio = 0;
                InfoDetalleSubPieza.mv_costo = 0;

                InfoDetalleSubPieza.oc_IdOrdenCompra = Convert.ToDecimal(item.ocd_IdOrdenCompra);
                InfoDetalleSubPieza.NumDocumentoRelacionadoProveedor = item.NumDocumentoRelacionadoProveedor;
                InfoDetalleSubPieza.NumFacturaProveedor = item.NumFacturaProveedor;

                ListaDetalle_SubProductos.Add(InfoDetalleSubPieza);  
            }
            // generacion de datos para in_movi_inve
            InfoSubPiezaCab = new in_movi_inve_Info();
            InfoSubPiezaCab.IdEmpresa = param.IdEmpresa;
            InfoSubPiezaCab.IdSucursal = param.IdSucursal;
            InfoSubPiezaCab.IdBodega = InfoProductoAcortar.IdBodega;
            InfoSubPiezaCab.IdNumMovi = 0;
            InfoSubPiezaCab.CodMoviInven = "MOVCP";
            InfoSubPiezaCab.cm_tipo = "-";
            InfoSubPiezaCab.cm_observacion = cmbObra.Text + " " + txtObserva.Text;
            InfoSubPiezaCab.cm_fecha = DateTime.Now;
            InfoSubPiezaCab.cm_anio = DateTime.Now.Year;
            InfoSubPiezaCab.cm_mes = DateTime.Now.Month;
            InfoSubPiezaCab.IdUsuario = param.IdUsuario;
            InfoSubPiezaCab.Estado = "A";
            InfoSubPiezaCab.Fecha_Transac = DateTime.Now;
          
            InfoSubPiezaCab.IdMovi_inven_tipo = 3;
            //InfoDetalleSubPieza.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);

            InfoSubPiezaCab.listmovi_inve_detalle_Info = ListaDetalle_SubProductos;



             //*****************LISTADOS DE MATERIA PRIMA SOBRANDE O RESIDUO DE LA PIEZA CORTADA***********************


            foreach (var item in ListaRetazoTmp)
            {// generacion de datos para tabla in_movi_inve_detalle_x_Producto_CusCider
                sec=sec+1;
                InfoMP_SobranteTablaIntermedia = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                InfoMP_SobranteTablaIntermedia.IdEmpresa = param.IdEmpresa;
                InfoMP_SobranteTablaIntermedia.IdSucursal = param.IdSucursal;
                InfoMP_SobranteTablaIntermedia.IdBodega = InfoProductoAcortar.IdBodega;

                InfoMP_SobranteTablaIntermedia.IdMovi_inven_tipo = 5;//ING X CONV A MP X RESIDUO
                //InfoMP_SobranteTablaIntermedia.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_ing_Conversion);

                InfoMP_SobranteTablaIntermedia.IdNumMovi = 0;
                InfoMP_SobranteTablaIntermedia.mv_Secuencia = 1;
                InfoMP_SobranteTablaIntermedia.Secuencia = sec;
                InfoMP_SobranteTablaIntermedia.IdProducto = InfoProductoAcortar.IdProducto;
                InfoMP_SobranteTablaIntermedia.CodigoBarra = item.CodigoBarra + "-" + "R" + "-" + sec + "-" + item.pr_alto + "X"+item.pr_largo;
                InfoMP_SobranteTablaIntermedia.mv_tipo_movi = "+";
                InfoMP_SobranteTablaIntermedia.dm_cantidad = 1;
                InfoMP_SobranteTablaIntermedia.dm_observacion = txtObserva.Text;
                InfoMP_SobranteTablaIntermedia.dm_precio = InfoProductoAcortar.dm_precio;
                InfoMP_SobranteTablaIntermedia.mv_costo = InfoProductoAcortar.mv_costo;
                InfoMP_SobranteTablaIntermedia.pr_Descripcion = "RESIDUO MP PRODUCTO CO " + InfoProductoAcortar.IdProducto + " DESC" + InfoProductoAcortar.pr_Descripcion + "PARA" + cmbOrdenTaller.Text;
                InfoMP_SobranteTablaIntermedia.pr_alto = item.pr_alto;
                InfoMP_SobranteTablaIntermedia.pr_largo =item.pr_largo;
                InfoMP_SobranteTablaIntermedia.ot_CodObra = cmbObra.EditValue.ToString();
                InfoMP_SobranteTablaIntermedia.ot_IdOrdenTaller =Convert.ToDecimal( cmbOrdenTaller.EditValue);
                InfoMP_SobranteTablaIntermedia.pr_peso = item.pr_peso;
                InfoMP_SobranteTablaIntermedia.et_IdProcesoProductivo = InfoProductoAcortar.et_IdProcesoProductivo;

                InfoMP_SobranteTablaIntermedia.ocd_IdOrdenCompra = Convert.ToDecimal(InfoProductoAcortar.ocd_IdOrdenCompra);
                InfoMP_SobranteTablaIntermedia.NumDocumentoRelacionadoProveedor = InfoProductoAcortar.NumDocumentoRelacionadoProveedor;
                InfoMP_SobranteTablaIntermedia.NumFacturaProveedor = InfoProductoAcortar.NumFacturaProveedor;

                ListaMP_SobranteTablaIntermedia.Add(InfoMP_SobranteTablaIntermedia);

                // llenar lista de detalle de MP sobrante para la tabla in_movi_inve_detalle
                InfoDetalleMPSobrante = new in_movi_inve_detalle_Info();
                InfoDetalleMPSobrante.IdEmpresa = item.IdEmpresa;
                InfoDetalleMPSobrante.IdSucursal = item.IdSucursal;
                InfoDetalleMPSobrante.IdBodega = item.IdBodega;

                InfoDetalleMPSobrante.IdMovi_inven_tipo = 5;
                //InfoMP_SobranteTablaIntermedia.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_ing_Conversion);


                InfoDetalleMPSobrante.IdNumMovi = 0;
                InfoDetalleMPSobrante.Secuencia = item.Secuencia;
                InfoDetalleMPSobrante.mv_tipo_movi = "+";
                InfoDetalleMPSobrante.IdProducto = InfoProductoAcortar.IdProducto;
                InfoDetalleMPSobrante.dm_cantidad = 1;
                InfoDetalleMPSobrante.dm_stock_actu = 1;
                InfoDetalleMPSobrante.dm_stock_ante = 1;
                InfoDetalleMPSobrante.dm_observacion = "MP SOBRANTE PROD. COD. " + item.IdProducto + item.CodigoBarra;
                InfoDetalleMPSobrante.dm_precio = 0;
                InfoDetalleMPSobrante.mv_costo = 0;
                
                InfoDetalleMPSobrante.oc_IdOrdenCompra =  Convert.ToDecimal(InfoProductoAcortar.ocd_IdOrdenCompra);
                InfoDetalleMPSobrante.NumDocumentoRelacionadoProveedor = InfoProductoAcortar.NumDocumentoRelacionadoProveedor;
                InfoDetalleMPSobrante.NumFacturaProveedor = InfoProductoAcortar.NumFacturaProveedor;

                ListaDetalle_MP_Sobrante_POrCorteMP.Add(InfoDetalleMPSobrante);

            }
            // generacion de datos para in_movi_inve de mp sobrante
            InfoMP_Sobrante_CAB = new in_movi_inve_Info();
            InfoMP_Sobrante_CAB.IdEmpresa = param.IdEmpresa;
            InfoMP_Sobrante_CAB.IdSucursal = param.IdSucursal;
            InfoMP_Sobrante_CAB.IdBodega = InfoProductoAcortar.IdBodega;

            InfoMP_Sobrante_CAB.IdMovi_inven_tipo = 5;
            //InfoMP_SobranteTablaIntermedia.IdMovi_inven_tipo = Convert.ToInt16(_Parametros_Info.IdMovi_inven_tipo_ing_Conversion);

            InfoMP_Sobrante_CAB.IdNumMovi = 0;
            InfoMP_Sobrante_CAB.CodMoviInven = "MOVCP";
            InfoMP_Sobrante_CAB.cm_tipo = "+";
            InfoMP_Sobrante_CAB.cm_observacion = cmbObra.Text + " " + txtObserva.Text;
            InfoMP_Sobrante_CAB.cm_fecha = DateTime.Now;
            InfoMP_Sobrante_CAB.cm_anio = DateTime.Now.Year;
            InfoMP_Sobrante_CAB.cm_mes = DateTime.Now.Month;
            InfoMP_Sobrante_CAB.IdUsuario = param.IdUsuario;
            InfoMP_Sobrante_CAB.Estado = "A";
            InfoMP_Sobrante_CAB.Fecha_Transac = DateTime.Now;
            
            InfoMP_Sobrante_CAB.listmovi_inve_detalle_Info = ListaDetalle_MP_Sobrante_POrCorteMP;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString()); 
            }
        }
        public void Grabar()
        { decimal IdnumMov=0;
          string Mensaje="";
            try
            {
                if (Cl_Enumeradores.eTipo_action.grabar == _Accion)
                {
                    Get();
                    if (!Validar())
                        return;
                    // Guardar las subpiezas cortadas
                    if (Bus_Movimiento.GrabarDB(InfoSubPiezaCab, ref IdnumMov, ref Mensaje, ref Mensaje, true))
                    idMovimientoimprimir=IdnumMov;
                        foreach (var item in ListaSubPiezas)
                        {
                            item.IdNumMovi = IdnumMov;
                        }
                        if (Bus_TablaIntermedia.GuardarDB(ListaSubPiezas.ToList(), ref Mensaje))
                        {
                            // guardar materia prima sobrante de la pieza cortada

                            if (ListaMP_SobranteTablaIntermedia.Count > 0)
                            {
                                if (Bus_Movimiento.GrabarDB(InfoMP_Sobrante_CAB, ref IdnumMov, ref Mensaje, ref Mensaje, true))
                                {
                                    idMovimientoimprimirMPSobrante = IdnumMov;
                                    foreach (var item in ListaMP_SobranteTablaIntermedia)
                                    {
                                        item.IdNumMovi = IdnumMov;
                                    }
                                    if (Bus_TablaIntermedia.GuardarDB(ListaMP_SobranteTablaIntermedia, ref Mensaje))
                                    {
                                        MessageBox.Show("Se Guardaron las Piezas Generadas 'Y LA MATERIA PRIMA SOBRANTE'");
                                        if (MessageBox.Show("¿Se procedera a  imprimir los codigos de barra de los productos especiales?", "Impresión de Codigo de Barra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            imprimircodigo();
                                        }
                                        gridControlSubPiezas.DataSource = null;
                                        gridControlElementosRestantes.DataSource = null;
                                        gridControlSubPiezas.RefreshDataSource();
                                        gridControlElementosRestantes.RefreshDataSource();
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Se Guardaron las Piezas Generadas 'NO UBO MATERIA PRIMA SOBRANTE PARA GUARDAR'");
                                if (MessageBox.Show("¿Se procedera a  imprimir los codigos de barra de los productos especiales?", "Impresión de Codigo de Barra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    imprimircodigo();
                                }
                                gridControlSubPiezas.DataSource = null;
                                gridControlElementosRestantes.DataSource = null;
                                gridControlSubPiezas.RefreshDataSource();
                                gridControlElementosRestantes.RefreshDataSource();
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
        
        private void txtalturaCortar_EditValueChanged(object sender, EventArgs e)
     {
         

         }
        private void txtLargoCortar_Leave(object sender, EventArgs e)
        {
            if (txtLargoCortar.Text != "")
            {
                if (Convert.ToDouble(txtLargoCortar.Text) > Convert.ToDouble(txtAncho.Text))
                {
                    MessageBox.Show("Error la Altura Ingresada excede a la del Producto");
                    txtLargoCortar.Text = "";
                }

                if ((Convert.ToInt32(txtLargoCortar.Text) * Convert.ToInt32(txtUnidadesCortadas.Text)) > Convert.ToInt32(txtAncho.Text))
                {
                    MessageBox.Show("Error " + txtUnidadesCortadas.Text + " * " + txtLargoCortar.Text + "Es Mayor Altura " + txtAncho.Text);
                    txtLargoCortar.Text = "";
                }

                

        }
     }


        //CellValueChanged
        private void gridViewElementosRestantes_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Info Infocorte = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                Infocorte = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewElementosRestantes.GetFocusedRow();
                txtAncho.Focus();
                gridViewElementosRestantes.SetFocusedRowCellValue(ColCodBarra, CodigoBarra);


                if (Infocorte != null)
                {
                    if (Infocorte.pr_alto != null)
                    {
                        pr_altoMpSobrante = (double)Infocorte.pr_alto;
                    }
                    else
                    {
                        pr_altoMpSobrante = 1;
                    }
                    if (Infocorte.pr_largo != null)
                    {
                        pr_largoMpSobrante = (double)Infocorte.pr_largo;
                    }
                    else
                    {
                        pr_largoMpSobrante = 1;
                    }



                    pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoPorDimensiopn;
                    // pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoSubPieza;

                }
                gridViewElementosRestantes.SetFocusedRowCellValue(pr_pesoR, pr_PesoMpSobrante);



            }
            catch (Exception ex)
            {


            }
        }

        //private void gridViewElementosRestantes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        in_movi_inve_detalle_x_Producto_CusCider_Info Infocorte = new in_movi_inve_detalle_x_Producto_CusCider_Info();
        //        Infocorte = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewElementosRestantes.GetFocusedRow();
        //        txtAncho.Focus();
        //        gridViewElementosRestantes.SetFocusedRowCellValue(ColCodBarra, CodigoBarra);


        //        if (Infocorte != null)
        //        {
        //            if (Infocorte.pr_alto != null)
        //            {
        //                pr_altoMpSobrante = (double)Infocorte.pr_alto;
        //            }
        //            else
        //            {
        //                pr_altoMpSobrante = 1;
        //            }
        //            if (Infocorte.pr_largo != null)
        //            {
        //                pr_largoMpSobrante = (double)Infocorte.pr_largo;
        //            }
        //            else
        //            {
        //                pr_largoMpSobrante = 1;
        //            }



        //            pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoPorDimensiopn;

        //        }
        //        gridViewElementosRestantes.SetFocusedRowCellValue(pr_pesoR, pr_PesoMpSobrante);



        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //}




         private void labelControl7_Click(object sender, EventArgs e)
        {

        }

         public void ObtenerPesoSubpieza(double PesototalPieza)
                {
                   
                    try
                    {
                       
                        
                        //PesoSubPieza = Convert.ToDouble(InfoProductoAcortar.pr_peso) / (Convert.ToDouble((InfoProductoAcortar.alto * InfoProductoAcortar.longitud)));
                        PesoSubPieza = Convert.ToDouble(InfoProductoAcortar.pr_peso) / (Convert.ToDouble((InfoProductoAcortar.alto * InfoProductoAcortar.longitud)));                     
                        PesoPorDimensiopn = PesoSubPieza;
                        PesoSubPieza = PesoSubPieza * (Convert.ToDouble(txtLargoCortar.Text) * Convert.ToDouble(txtalturaCortar.Text));


                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }

         public void ObtenerPesoMPsobrante()
         {
             try
             {

                 //pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoPorDimensiopn;
                 pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoPorDimensiopn;
                
             }
             catch (Exception)
             {
                 
                 
             }
         }



         void imprimircodigo()
         {
             try
             {
                 List<XPRO_CUS_CID_Rpt001_Info> listDataMPSobrante = new List<XPRO_CUS_CID_Rpt001_Info>();

                 XPRO_CUS_CID_Rpt001 frp = new XPRO_CUS_CID_Rpt001();
                 List<XPRO_CUS_CID_Rpt001_Info> listData = new List<XPRO_CUS_CID_Rpt001_Info>();
                 XPRO_CUS_CID_Rpt001_Bus bus = new XPRO_CUS_CID_Rpt001_Bus();
                 listData = bus.Get_Codigo_Barra(param.IdEmpresa, param.IdSucursal, InfoDetalleSubPieza.IdBodega,
                 InfoDetalleSubPieza.IdMovi_inven_tipo,Convert.ToInt32(idMovimientoimprimir));

                 if (idMovimientoimprimirMPSobrante > 0)
                 {
                     listDataMPSobrante = bus.Get_Codigo_Barra(param.IdEmpresa, param.IdSucursal, InfoDetalleMPSobrante.IdBodega,
               InfoDetalleMPSobrante.IdMovi_inven_tipo, Convert.ToInt32(idMovimientoimprimirMPSobrante));
                     if (listDataMPSobrante != null)
                     {
                         listData.AddRange(listDataMPSobrante);
                     }
                 }
                

                 
                

                 frp.loadData(listData);
                 frp.ShowPreviewDialog();
                         
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString());
             }


         }

         private void ucGe_Menu_event_btnSalir_Click_1(object sender, EventArgs e)
         {
             try
             {
                 this.Close();
             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
         }

         private void gridControlSubPiezas_Click(object sender, EventArgs e)
         {

         }

         private void gridViewElementosRestantes_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
         {
             try
             {
                 in_movi_inve_detalle_x_Producto_CusCider_Info Infocorte = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                 Infocorte = (in_movi_inve_detalle_x_Producto_CusCider_Info)gridViewElementosRestantes.GetFocusedRow();
                 txtAncho.Focus();
                 if (e.Column.Name == "CooCollpr_largo" || e.Column.Name == "Collpr_alto")
                 {
                     if (Infocorte.pr_alto != null && Infocorte.pr_largo != null)
                     {
                         pr_PesoMpSobrante = Convert.ToDouble(Infocorte.pr_alto) * Convert.ToDouble(Infocorte.pr_largo) * PesoPorDimensiopn;
                         gridViewElementosRestantes.SetFocusedRowCellValue(ColCodBarra, CodigoBarra);
                         gridViewElementosRestantes.SetFocusedRowCellValue(pr_pesoR, pr_PesoMpSobrante);
                     }

                 }

                 //if (Infocorte != null)
                 //{
                 //    if (Infocorte.pr_alto != null)
                 //    {
                 //        pr_altoMpSobrante = (double)Infocorte.pr_alto;
                 //    }
                 //    else
                 //    {
                 //        pr_altoMpSobrante = 1;
                 //    }
                 //    if (Infocorte.pr_largo != null)
                 //    {
                 //        pr_largoMpSobrante = (double)Infocorte.pr_largo;
                 //    }
                 //    else
                 //    {
                 //        pr_largoMpSobrante = 1;
                 //    }



                     // pr_PesoMpSobrante = pr_largoMpSobrante * pr_altoMpSobrante * PesoSubPieza;

                // }



             }
             catch (Exception ex)
             {


             }
         }


    }
}

