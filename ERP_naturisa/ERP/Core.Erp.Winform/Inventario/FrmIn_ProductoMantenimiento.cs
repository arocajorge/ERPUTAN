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
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Nodes;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Winform.Controles;
using System.IO;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Data.Inventario;
using Infragistics.Win.UltraWinGrid;
using Core.Erp.Winform.General;

namespace Core.Erp.Winform.Inventario
{

    public partial class FrmIn_ProductoMantenimiento : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_Producto_Info _productoI = new in_Producto_Info();
        string mensaje = "";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_categorias_Info _categoriaInfo = new in_categorias_Info();

        //listaPlan 
        ct_Plancta_Bus _PlanCta_bus1 = new ct_Plancta_Bus();
        List<ct_Plancta_Info> listaPlan = new List<ct_Plancta_Info>();

        //lista producto x proveedor
        List<in_producto_x_cp_proveedor_Info> lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
        List<in_producto_x_cp_proveedor_Info> _lm_prod_x_prove = new List<in_producto_x_cp_proveedor_Info>();
        in_producto_x_cp_proveedor_Bus pxp_bus = new in_producto_x_cp_proveedor_Bus();
        DataTable dt = new DataTable("detalle");
        DataTable Tabla_proveedor = new DataTable("pr_nombre");
        //lista producto composicion
        List<in_Producto_Composicion_Info> lsComposicionProducto = new List<in_Producto_Composicion_Info>();
        List<in_Producto_Composicion_Info> _lsComposicionProducto = new List<in_Producto_Composicion_Info>();

        //lista producto x bodega
        List<in_producto_x_tb_bodega_Info> lsProductoBodega_Insert = new List<in_producto_x_tb_bodega_Info>();
        List<in_producto_x_tb_bodega_Info> lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();


        List<in_producto_x_tb_bodega_Info> _lsProductoBodega_Anterior = new List<in_producto_x_tb_bodega_Info>();
        in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();

        UCIN_Categorias UCCategoria = new UCIN_Categorias();

        DataTable TablaCta = new DataTable();
        private Cl_Enumeradores.eTipo_action _Accion;


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
                            break;
                        case Cl_Enumeradores.eTipo_action.actualizar:
                            this.btnGrabar.Text = "Actualizar";
                            this.btnGrabar.Enabled = true;

                            break;
                        case Cl_Enumeradores.eTipo_action.borrar:
                           // this.btnGrabarySalir.Text = "Anular";
                            this.btnGrabar.Enabled = true;
                            this.btnGrabarySalir.Enabled = true;
                            break;
                        //case Cl_Enumeradores.eTipo_action.consultar:
                        //    this.btn_grabar.Enabled = false;
                        //    break;
                        default:
                            break;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        public void set_categoria(in_categorias_Info categoriaInfo)
        {
            try 
            {

                _categoriaInfo = categoriaInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            
            }
        }
        public void set_producto(in_Producto_Info iProdu)
        {


            try
            {
                //loadTipoProducto();
                //cargar_combo_cuentas();
                //loadTipoMarca();
                //loadUnidad_Medida();
                carga_dgvProductoBodega();
                txtDescripcion2.Text = iProdu.pr_descripcion_2;
                txtPesoEspecifico.Value= iProdu.PesoEspecifico;
                txtAnchoEspecifico.Value = iProdu.AnchoEspecifico;
                txtCodigo.Enabled = false;
                chkActivo.Checked = (iProdu.Estado == "A") ? true : false;
                cmb_marca.Value  = iProdu.IdMarca ;
                cmbTipoConsumo.SelectedValue = iProdu.IdTipoConsumo == null ? "" : iProdu.IdTipoConsumo;
                lblIdProducto.Text = iProdu.IdProducto.ToString();
                cmb_tipoProducto.SelectedValue = iProdu.IdProductoTipo;
                cmb_unidadMedida.SelectedValue = iProdu.IdUnidadMedida;
                txtAlto.Value = iProdu.pr_alto;
                txtCodigo.Text = iProdu.pr_codigo;
                txtCodigoBarra.Text = iProdu.pr_codigo_barra;
                txtCostoCIF.Value =  Convert.ToDecimal( iProdu.pr_costo_CIF);
                txtCostoFOB.Value = Convert.ToDecimal( iProdu.pr_costo_fob) ;
                txtCostoPromedio.Value = Convert.ToDecimal( iProdu.pr_costo_promedio);
                txtNombre.Text = iProdu.pr_descripcion;
                txtDiasAereo.Value = iProdu.pr_DiasAereo;
                txtDiasMaritimo.Value = iProdu.pr_DiasMaritimo;
                txtDiasTerrestre.Value = iProdu.pr_DiasTerrestre;
                chkEstaPromosion.Checked  = ( iProdu.pr_EstaPromocion =="S") ? true:false;
                txtLargo.Value = iProdu.pr_largo ;
                chkCalculaIva.Checked  = (iProdu.pr_ManejaIva=="S")? true : false ;
                chkManejaSeries.Checked  = (iProdu.pr_ManejaSeries=="S")?true:false;
                txtObservacion.Text = iProdu.pr_observacion;
                txtPartidaArancelaria.Text = iProdu.pr_partidaArancel;
                txtPeso.Value = iProdu.pr_peso;
                txtPorPartidaArancelaria.Value = iProdu.pr_porcentajeArancel;
                txtPrecioMayor.Value = Convert.ToDecimal( iProdu.pr_precio_mayor);
                txtPrecioMinimo.Value = Convert.ToDecimal( iProdu.pr_precio_minimo);
                txtPrecioPublico.Value =Convert.ToDecimal(  iProdu.pr_precio_publico);
                txtProfundidad.Value = iProdu.pr_profundidad;
                txtStockMaximo.Value = Convert.ToDecimal(iProdu.pr_stock_maximo);
                txtStockminimo.Value = Convert.ToDecimal(iProdu.pr_stock_minimo);
                _categoriaInfo.IdCategoria = iProdu.IdCategoria;
                UCCategoria.set_CategoriaCheckedSelection(_categoriaInfo);
                cmb_presentacion.SelectedValue = iProdu.IdPresentacion;

                pibx_imagenPequeña.Image = ArrayAImage(iProdu.pr_imagenPeque);


                _productoI = iProdu;

                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }


        public in_Producto_Info get_producto()
        {

            try
            {
            _productoI = new in_Producto_Info();
                _productoI.IdEmpresa = param.IdEmpresa;
                _productoI.Estado = (chkActivo.Checked == true) ? "A" : "I";
                _productoI.pr_descripcion = txtNombre.Text.Trim();
                _productoI.IdMarca = Convert.ToInt32(cmb_marca.Value);
                _productoI.IdPresentacion = Convert.ToString(cmb_presentacion.SelectedValue);

                _productoI.pr_descripcion_2 = txtDescripcion2.Text;
                _productoI.PesoEspecifico = Convert.ToDouble(txtPesoEspecifico.Value);
                _productoI.AnchoEspecifico = Convert.ToDouble(txtAnchoEspecifico.Value);

                _categoriaInfo = UCCategoria.get_categoriainfo();

                byte[] arr = ImageAArray(pibx_imagenPequeña.Image);

                _productoI.pr_imagenPeque = arr;

                _productoI.IdTipoConsumo = Convert.ToString(cmbTipoConsumo.SelectedValue);


                _productoI.IdCategoria = _categoriaInfo.IdCategoria;
                //_productoI.IdCtaCble_CosInv = (Ucmb_ctaCostoInve.Value == null) ? "" : Ucmb_ctaCostoInve.Value.ToString();
                //_productoI.IdCtaCble_DesVta = (Ucmb_ctaDesVta.Value == null) ? "" : Ucmb_ctaDesVta.Value.ToString();
                //_productoI.IdCtaCble_DevVta = (Ucmb_ctaDevVta.Value == null) ? "" : Ucmb_ctaDevVta.Value.ToString();
                //_productoI.IdCtaCble_Inv = (Ucmb_ctaIven.Value == null) ? "" : Ucmb_ctaIven.Value.ToString();
                //_productoI.IdCtaCble_Vta = (Ucmb_ctaVta.Value == null) ? "" : Ucmb_ctaVta.Value.ToString();


               

                _productoI.IdMarca =Convert.ToInt32( cmb_marca.Value);
                _productoI.IdProducto = Convert.ToDecimal(lblIdProducto.Text);
                _productoI.IdProductoTipo = Convert.ToInt32( cmb_tipoProducto.SelectedValue);
                _productoI.IdUnidadMedida = (cmb_unidadMedida.SelectedValue == null) ? "UNI" : cmb_unidadMedida.SelectedValue.ToString();
                _productoI.pr_alto = Convert.ToDouble(txtAlto.Value);
                _productoI.pr_codigo = txtCodigo.Text.Trim();
                _productoI.pr_codigo_barra = txtCodigoBarra.Text.Trim();
                _productoI.pr_costo_CIF = Convert.ToDouble(txtCostoCIF.Value);
                _productoI.pr_costo_fob = Convert.ToDouble(txtCostoFOB.Value);
                _productoI.pr_costo_promedio = Convert.ToDouble(txtCostoPromedio.Value);
                _productoI.pr_DiasAereo = Convert.ToInt32(txtDiasAereo.Value);
                _productoI.pr_DiasMaritimo = Convert.ToInt32(txtDiasMaritimo.Value);
                _productoI.pr_DiasTerrestre = Convert.ToInt32(txtDiasTerrestre.Value);
                _productoI.pr_EstaPromocion = (chkEstaPromosion.Checked == true) ? "S" : "N";
                _productoI.pr_largo = Convert.ToInt32(txtLargo.Value);
                _productoI.pr_ManejaIva = (chkCalculaIva.Checked == true) ? "S" : "N";
                _productoI.pr_ManejaSeries = (chkManejaSeries.Checked == true) ? "S" : "N";
                _productoI.pr_observacion = txtObservacion.Text.Trim();
                _productoI.pr_partidaArancel = txtPartidaArancelaria.Text.Trim();
                _productoI.pr_pedidos = 0;
                _productoI.pr_peso = Convert.ToDouble(txtPeso.Value);
                _productoI.pr_porcentajeArancel = txtPorPartidaArancelaria.Value;
                _productoI.pr_precio_mayor = Convert.ToDouble(txtPrecioMayor.Value);
                _productoI.pr_precio_minimo = Convert.ToDouble(txtPrecioMinimo.Value);
                _productoI.pr_precio_publico = Convert.ToDouble(txtPrecioPublico.Value);
                _productoI.pr_profundidad = Convert.ToDouble(txtProfundidad.Value);
                _productoI.pr_stock = 0;
                _productoI.pr_stock_maximo= Convert.ToDouble(txtStockMaximo.Value);
                _productoI.pr_stock_minimo= Convert.ToDouble(txtStockminimo.Value);




                _productoI.IdCentro_Costo_Costo = ctrl_ctasContables.Obtener_CentroDeCosotoCosto();
                _productoI.IdCentro_Costo_Inventario = ctrl_ctasContables.Obtener_CentroCostoInventario();
                _productoI.IdCtaCble_Costo = ctrl_ctasContables.Obtener_CbtCbleCosto();
                _productoI.IdCtaCble_Inven = ctrl_ctasContables.Obtener_CtaCbleInventario();





                return _productoI;

            }
            catch (Exception ex )
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new in_Producto_Info();
            }

                                     
           


            
        }
        public List<in_producto_x_cp_proveedor_Info> get_grid_pxp_guardar()
        {
            try
            {
                List<in_producto_x_cp_proveedor_Info> lss = new List<in_producto_x_cp_proveedor_Info>();
                UltraGridProveedor.DisplayLayout.Rows.Band.AddNew();
             
                for (int i = 0; i < UltraGridProveedor.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(UltraGridProveedor.Rows[i].Cells[0].Value) == true)
                    {
                        in_producto_x_cp_proveedor_Info pxp_inf = new in_producto_x_cp_proveedor_Info();
                        pxp_inf.IdEmpresa_prod = param.IdEmpresa;
                        pxp_inf.IdEmpresa_prov = param.IdEmpresa;
                        pxp_inf.IdProducto = Convert.ToInt32(lblIdProducto.Text);
                        //pxp_inf.IdProveedor = Convert.ToDecimal(UltraGridProveedor.Rows[i].Cells[1].Value);
                        pxp_inf.IdProveedor = Convert.ToDecimal(UltraGridProveedor.Rows[i].Cells[1].Value);
                        pxp_inf.NomProducto_en_Proveedor = Convert.ToString(UltraGridProveedor.Rows[i].Cells[2].Text);
                        lss.Add(pxp_inf);
                    }

                    lm_prod_x_prove = lss;
                }
                return lss;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<in_producto_x_cp_proveedor_Info>();
            }
        }

        public Boolean Validaciones()
        {
            try
            {
                Boolean Valido = true;




                if (cmb_marca.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione una marca valida", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtNombre.Text=="")
                {
                    MessageBox.Show("debe Ingresar el nombre del producto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                in_categorias_Info Catei= new  in_categorias_Info();
                Catei = UCCategoria.get_categoriainfo();


                if (Catei.IdCategoria == "" || Catei.IdCategoria==null)
                {
                    MessageBox.Show("Seleccione una categoria ....", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


                if (chkCalculaIva.Checked == false)
                {
                    if (MessageBox.Show("Este item no esta calculando IVA .. Esta seguro???", "Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                    {
                        return false;
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

        public Boolean Anular()
        {


            try
            {

                if (!(_productoI == null))
                {
                    get_producto();
                    in_producto_Bus perBu = new in_producto_Bus();
                    return perBu.AnularDB(_productoI,ref mensaje);
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
        public Boolean Actualizar()
        {

            try
            {
                if (Validaciones() == false)
                {
                    return false;
                }


                if (!(_productoI == null))
                {
                    get_producto();
                    get_grid_pxp_guardar();
                    get_gridComposicion();
                    get_gridProductoBodega();

                    in_producto_Bus perBu = new in_producto_Bus();
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();
                    in_producto_x_tb_bodega_Bus busProductoBodega = new in_producto_x_tb_bodega_Bus();

                    perBu.ModificarDB(_productoI, ref mensaje);

                    //elimino datos de tabla producto_x_proveedor
                    if (_lm_prod_x_prove != lm_prod_x_prove)
                    {
                        pxpbus.eliminarregistrotabla(_lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref mensaje);
                        pxpbus.ModificarLIsta(lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref mensaje);
                    }
                    //elimino y grabo datos de tabla Composicion
                    if (_lsComposicionProducto != lsComposicionProducto)
                    {
                        busComposicion.eliminarregistrotabla(_lsComposicionProducto, param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text), ref mensaje);
                        busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref mensaje);
                    }

                    //grabo registros nuevos de tabla producto x bodega

                    busProductoBodega.EliminarDB(param.IdEmpresa, Convert.ToDecimal(lblIdProducto.Text));
                    busProductoBodega.GrabaDB(lsProductoBodega_Insert, param.IdEmpresa, ref mensaje);
                 //   busProductoBodega.ModificarDB(lsProductoBodega_Update , param.IdEmpresa, ref mensaje);
                        
                            //FrmGe_MensajeError frErr = new FrmGe_MensajeError();
                            //frErr.set_mensajeError(mensaje);
                            //frErr.ShowDialog();

                        
                        
                    

                    MessageBox.Show("Actualizacion ok..", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }
        }


        public Boolean grabar()
        {

            try
            {

                Boolean resultB;

                _productoI = get_producto();


                if (Validaciones() == false)
                {
                    return false;
                }


                if (!(_productoI == null))
                {
                    decimal idProducto;
                    idProducto = 0;

                    get_grid_pxp_guardar();
                    get_gridComposicion();
                    

                    in_producto_Bus prob = new in_producto_Bus();
                    in_producto_x_cp_proveedor_Bus pxpbus = new in_producto_x_cp_proveedor_Bus();
                    in_Producto_Composicion_Bus busComposicion = new in_Producto_Composicion_Bus();
                    

                    if (prob.GrabarDB(_productoI, ref  idProducto, ref mensaje))
                    {
                        lblIdProducto.Text = idProducto.ToString();
                        get_gridProductoBodega();
                        //elimino y grabo datos de tabla producto_x_proveedor
                        if (_lm_prod_x_prove != lm_prod_x_prove)
                        {
                            pxpbus.eliminarregistrotabla(_lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref mensaje);
                            pxpbus.ModificarLIsta(lm_prod_x_prove, param.IdEmpresa, Convert.ToInt32(this.lblIdProducto.Text), ref mensaje);
                        }
                        //elimino y grabo datos de tabla Composicion
                        if (_lsComposicionProducto != lsComposicionProducto)
                        {
                            busComposicion.eliminarregistrotabla(_lsComposicionProducto, param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text), ref mensaje);
                            busComposicion.GrabarDB(lsComposicionProducto, Convert.ToInt32(lblIdProducto.Text), ref mensaje);
                        }
                      
                            busProductoBodega.GrabaDB(lsProductoBodega_Insert , param.IdEmpresa, ref mensaje);
                            busProductoBodega.ModificarDB(lsProductoBodega_Update, param.IdEmpresa, ref mensaje);
                                                           

                        MessageBox.Show("Grabacion ok.. ...", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       

                        _Accion = Cl_Enumeradores.eTipo_action.actualizar;
                        resultB = true;
                    }
                    else
                    {
                        MessageBox.Show( mensaje, " Sistemas ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


        public FrmIn_ProductoMantenimiento()
        {
            try
            {
                 InitializeComponent();
                tb_Catalogo_Bus CatalogoBus = new tb_Catalogo_Bus();
                loadTipoProducto();
                loadTipoMarca();
                loadUnidad_Medida();
                loadPresentacion();
                cmbTipoConsumo.DataSource = CatalogoBus.ObteneCatalogoPorTipo(25);
                UCCategoria.Event_treeListCategoria_AfterCheckNode += UCCategoria_Event_treeListCategoria_AfterCheckNode;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void UCCategoria_Event_treeListCategoria_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
              var info = (in_categorias_Info)sender;
                switch (_Accion)
                {
               
                    case Cl_Enumeradores.eTipo_action.grabar:
                  
                            ctrl_ctasContables.setValores(info.IdCtaCtble_Inve, info.IdCentro_Costo_Inventario, info.IdCtaCtble_Costo, info.IdCentro_Costo_Costo);
                            foreach (var item in DataSource)
                            {
                                item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                                item.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                                item.IdCtaCble_Costo = info.IdCtaCtble_Costo;
                                item.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;

                            }
                            gridControlProdxBodega.RefreshDataSource();
                        

                    break;
                    case Cl_Enumeradores.eTipo_action.actualizar:

                    ctrl_ctasContables.setValores(info.IdCtaCtble_Inve, info.IdCentro_Costo_Inventario, info.IdCtaCtble_Costo, info.IdCentro_Costo_Costo);
                    foreach (var item in DataSource)
                    {
                        item.IdCtaCble_Inven = info.IdCtaCtble_Inve;
                        item.IdCentro_Costo_Inventario = info.IdCentro_Costo_Inventario;
                        item.IdCtaCble_Costo = info.IdCtaCtble_Costo;
                        item.IdCentro_Costo_Costo = info.IdCentro_Costo_Costo;

                    }
                    gridControlProdxBodega.RefreshDataSource();
                    break;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
        private void loadTipoProducto()
        {
            try
            {


                List<in_ProductoTipo_Info> tipop = new List<in_ProductoTipo_Info>();
                //in_productoTipo_Bus tipoB = new in_productoTipo_Bus();
                in_ProductoTipo_Bus tipoB = new in_ProductoTipo_Bus();



               // tipoB.Obtener_ProductosTipos(

                tipop = tipoB.Obtener_ProductosTipos(param.IdEmpresa);



                cmb_tipoProducto.DisplayMember = "tp_descripcion";
                cmb_tipoProducto.ValueMember = "IdProductoTipo";
                cmb_tipoProducto.DataSource = tipop;



            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }

        }

        private void loadTipoMarca()
        {

            try
            {
                List<in_Marca_Info> lisM = new List<in_Marca_Info>();
                in_marca_bus mb = new in_marca_bus();

                
               lisM= mb.Obtener_listMarca(param.IdEmpresa);



                cmb_marca.DisplayMember = "Descripcion";
                cmb_marca.ValueMember = "IdMarca";
                cmb_marca.DataSource = lisM;

                cmb_marca.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }



        }
        private void loadUnidad_Medida()
        {


            try
            {

                List<in_unidad_medida_info> lisM = new List<in_unidad_medida_info>();
                tb_Catalogo_Bus UniB = new tb_Catalogo_Bus();



                lisM = UniB.ObtenerList_Unidad_Medida();


                
                cmb_unidadMedida.DisplayMember = "Descripcion";
                cmb_unidadMedida.ValueMember = "codigo";
                cmb_unidadMedida.DataSource = lisM;

                cmb_unidadMedida.SelectedIndex = 0;




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }



        }
        private void loadPresentacion()
        {



            try
            {

                List<in_presentacion_Info> lisM = new List<in_presentacion_Info>();
                tb_Catalogo_Bus UniB = new tb_Catalogo_Bus();



                lisM = UniB.ObtenerList_Presentacion();



                cmb_presentacion.DisplayMember = "Descripcion";
                cmb_presentacion.ValueMember = "codigo";
                cmb_presentacion.DataSource = lisM;

                cmb_presentacion.SelectedIndex = 0;




            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }



        }
        private void cargar_combo_cuentas()
        {
            try
            {
                 creaTablaCta();


                    this.Ucmb_ctaIven.DisplayMember = "pc_Cuenta2";
                    this.Ucmb_ctaIven.ValueMember = "IdCtaCble";
                    this.Ucmb_ctaIven.DataSource = TablaCta;

                    this.Ucmb_ctaVta.DisplayMember = "pc_Cuenta2";
                    this.Ucmb_ctaVta.ValueMember = "IdCtaCble";
                    this.Ucmb_ctaVta.DataSource = TablaCta;

                    this.Ucmb_ctaDesVta.DisplayMember = "pc_Cuenta2";
                    this.Ucmb_ctaDesVta.ValueMember = "IdCtaCble";
                    this.Ucmb_ctaDesVta.DataSource = TablaCta;


                    this.Ucmb_ctaDevVta.DisplayMember = "pc_Cuenta2";
                    this.Ucmb_ctaDevVta.ValueMember = "IdCtaCble";
                    this.Ucmb_ctaDevVta.DataSource = TablaCta;


                    this.Ucmb_ctaCostoInve.DisplayMember = "pc_Cuenta2";
                    this.Ucmb_ctaCostoInve.ValueMember = "IdCtaCble";
                    this.Ucmb_ctaCostoInve.DataSource = TablaCta;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            


        
        }
        private void creaTablaCta()
        {
            try
            {
                listaPlan = _PlanCta_bus1.ObtenerPlanctaOnlyMovimiento(param.IdEmpresa);


                TablaCta.Columns.Add("pc_Cuenta2");
                TablaCta.Columns.Add("Descripcion                         .");
                TablaCta.Columns.Add("IdCtaCble");

                foreach (var item in listaPlan)
                {
                    DataRow filas;
                    filas = TablaCta.NewRow();
                    filas[0] = item.pc_Cuenta2;
                    filas[1] = item.pc_Cuenta;
                    filas[2] = item.IdCtaCble.Trim();

                    TablaCta.Rows.Add(filas);
                    TablaCta.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }
        public void set_estado(Boolean valor)
        {
            try
            {
               chkActivo.Checked=valor;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }
        UCIN_CtsContablesParaContabilizar ctrl_ctasContables;

        ct_Centro_costo_Bus centroCosto_B = new ct_Centro_costo_Bus();
        ct_Plancta_Bus plnCta_B = new ct_Plancta_Bus();
        private void FrmIn_ProductoMantenimiento_Load(object sender, EventArgs e)
        {
            //por chilli willi temporal

            try
            {

            

            tabControl_Producto.TabPages.Remove(tab_Costos);
            tabControl_Producto.TabPages.Remove(tab_DatosImportacion);
            tabControl_Producto.TabPages.Remove(tab_ParametrosContablesxProducto);
            tabControl_Producto.TabPages.Remove(tab_DatosContables);
            
            //

            var plncta_lst = plnCta_B.ObtenerPlanctaOnlyMovimiento(param.IdEmpresa);
            var CtrCsto = centroCosto_B.ObtenerCentroCostoOnlyMovimiento(param.IdEmpresa);
            cmbIdCtaCbleCentroDeCosto.DataSource = plncta_lst;
            cmbIdCtaCbleInventario.DataSource = plncta_lst;
            cmbCentrodeCosotCosto.DataSource = CtrCsto;
            cmbCentrodeCosotInventario.DataSource = CtrCsto;



            ctrl_ctasContables= new Controles.UCIN_CtsContablesParaContabilizar();
            tab_DatosContables.Controls.Add(ctrl_ctasContables);
       
            cargar_combo_cuentas();
            
            load_grid();
            carga_ultragrid_composicion();
            carga_dgvProductoBodega();


            this.panelCategoria.Controls.Add(UCCategoria);
            UCCategoria.set_Solo_chequea_unItem(true);
            UCCategoria.set_Treelist_SelectMultiple(false);
            UCCategoria.set_Treelist_ShowCheckBoxes(true);
            UCCategoria.set_CategoriaCheckedSelection(_categoriaInfo);
            UCCategoria.Dock = DockStyle.Fill;


            if (_Accion == null || _Accion == 0)
            { _Accion = Cl_Enumeradores.eTipo_action.grabar; }

            switch (_Accion)
            {
                case Cl_Enumeradores.eTipo_action.grabar:
                    break;
                case Cl_Enumeradores.eTipo_action.actualizar:
                    ctrl_ctasContables.setValores(_productoI.IdCtaCble_Inven, _productoI.IdCentro_Costo_Inventario, _productoI.IdCtaCble_Costo, _productoI.IdCentro_Costo_Costo);
                    break;
                case Cl_Enumeradores.eTipo_action.borrar:
                    ctrl_ctasContables.setValores(_productoI.IdCtaCble_Inven, _productoI.IdCentro_Costo_Inventario, _productoI.IdCtaCble_Costo, _productoI.IdCentro_Costo_Costo);
                    break;
                case Cl_Enumeradores.eTipo_action.consultar:
                    ctrl_ctasContables.setValores(_productoI.IdCtaCble_Inven, _productoI.IdCentro_Costo_Inventario, _productoI.IdCtaCble_Costo, _productoI.IdCentro_Costo_Costo);
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
        private void load_tree()
        {
            //try
            //{
            //    in_categorias_bus cb = new in_categorias_bus();
            //    List<in_categorias_Info> lic = new List<in_categorias_Info>();
            //    lic = cb.Obtener_listCategoria(1);


            //    this.trelist_Categoria.DataSource = lic;




            //    //Call the operation:
            //    GetCheckedNodesOperation op = new GetCheckedNodesOperation();
            //    treeList1.NodesIterator.DoOperation(op);
            //    //Get the number of checked nodes:
            //    int count = op.CheckedNodes.Count;
            //}
            //catch (Exception ex)
            //{
            //    Log_Error_bus.Log_Error(ex.ToString());
            //}

        }


        public void load_grid()
        {
            try
            {
             dt.Columns.Add("*", typeof(Boolean));
                dt.Columns.Add("Proveedor", typeof(string));
                dt.Columns.Add("Descripcion según Proveedor", typeof(string));
                dt.AcceptChanges();
                UltraGridProveedor.DataSource = dt;
                carga_cmb_proveedor();
                _lm_prod_x_prove = pxp_bus.ObtenerProducto_Proveedor(param.IdEmpresa);

                foreach (var item in _lm_prod_x_prove)
                {
                    if (item.IdProducto.ToString() == this.lblIdProducto.Text)
                    {
                        DataRow filas;
                        filas = dt.NewRow();
                        filas[0] = true;
                        filas[1] = Convert.ToInt32(item.IdProveedor);
                        //UltraGridProveedor.DisplayLayout.Bands[0].Columns[1].ValueList=Convert.ToDecimal(item.IdProveedor);
                        //item.IdProveedor;
                        filas[2] = item.NomProducto_en_Proveedor;
                        dt.Rows.Add(filas);
                        dt.AcceptChanges();
                    }
                }

                {

                }
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
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void tabPage7_Click(object sender, EventArgs e){}
        
        private void txtCodigoBarra_TextChanged(object sender, EventArgs e){}

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                codigoBarraProducto.Text = txtCodigoBarra.Text;
                codigoBarraProducto.Refresh();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }
        private void mnuGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                   txtCodigo.Focus();
                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        grabar();
                        return;
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        Actualizar();
                        return;

                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
            

        }
        private void btn_guardarYsalir_Click(object sender, EventArgs e)
        {
            try
            {
             txtCodigo.Focus();
         

                    if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                    {
                        grabar();
                    }

                    if (_Accion == Cl_Enumeradores.eTipo_action.actualizar)
                    {
                        Actualizar();

                    }


                    this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            


        }
        ///De image a byte []:
        public byte[] ImageAArray(Image Imagen)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                Imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
        }
        ///De byte [] a image:
        public Image ArrayAImage(byte[] ArrBite)
        {
            try
            {
                MemoryStream ms = new MemoryStream(ArrBite);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return null;
            }
            
        }
        private void btn_imgGrande_Click(object sender, EventArgs e)
        {
            try
            {


                openFileDialogImagenGrande.Filter = "JPG|*.jpg";
                openFileDialogImagenGrande.ShowDialog();
                if (!string.IsNullOrEmpty(openFileDialogImagenGrande.FileName))
                {
                    if (File.Exists(openFileDialogImagenGrande.FileName))
                    {
                        Image Imagen = Image.FromFile(openFileDialogImagenGrande.FileName);
                        pibx_imagenPequeña.Image = Imagen;

                        byte[] arr = ImageAArray(Imagen);
                    }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void carga_cmb_proveedor()
        {
            try
            {
                List<cp_proveedor_Info> _ProveedorInfo = new List<cp_proveedor_Info>();
                cp_proveedor_Bus _ProveedorBus = new cp_proveedor_Bus();
                _ProveedorInfo = _ProveedorBus.ObtenerListProveedorInfo(param.IdEmpresa);

                creaTabla(_ProveedorInfo, Tabla_proveedor);
                ultraCmb_Proveedor.DisplayMember = "pr_nombre";
                ultraCmb_Proveedor.ValueMember = "IdProveedor";
                ultraCmb_Proveedor.DataSource = Tabla_proveedor;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void creaTabla(List<cp_proveedor_Info> Lista, DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("pr_nombre");
                tablaNCombo.Columns.Add("IdProveedor");
                foreach (var item in Lista)
                {
                    DataRow filas;
                    filas = tablaNCombo.NewRow();
                    filas[0] = item.pr_nombre;
                    filas[1] = item.IdProveedor;
                    tablaNCombo.Rows.Add(filas);
                    tablaNCombo.AcceptChanges();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UltraGridProveedor_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            try
            {
                  UltraGridProveedor.DisplayLayout.Bands[0].Columns[1].ValueList = ultraCmb_Proveedor;
            
                UltraGridProveedor.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }


        private void carga_ultragrid_composicion()
        {
            try
            {
                   DataTable dt = new DataTable("detalle");
            
                    in_Producto_Composicion_Bus bus = new in_Producto_Composicion_Bus();
                    dt.Columns.Add("Descripcion", typeof(string));
                    dt.Columns.Add("Cantidad", typeof(string));
                    dt.AcceptChanges();

                    carga_cmb_ProductoHijo();
                    _lsComposicionProducto = bus.ObtenerListProductoComposicion(param.IdEmpresa, Convert.ToInt32(lblIdProducto.Text));

                    foreach (var item in _lsComposicionProducto)
                    {
                        DataRow filas;
                        filas = dt.NewRow();
                        filas[0] = Convert.ToInt32(item.IdProductoHijo);
                        filas[1] = item.Cantidad;
                        dt.Rows.Add(filas);
                        dt.AcceptChanges();
                    }
                    this.ultraGrid_Composicion.DataSource = dt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void carga_cmb_ProductoHijo()
        {
            try
            {
                DataTable Tabla = new DataTable("pr_nombre");
                List<in_Producto_Info> ls = new List<in_Producto_Info>();
                in_producto_Bus bus = new in_producto_Bus();
                ls = bus.Obtener_listProducto(param.IdEmpresa);

                creaTablaProductoHijo(ls, Tabla);
                ultraCombo_ProductoHijo.DisplayMember = "pr_descripcion";
                ultraCombo_ProductoHijo.ValueMember = "IdProducto";
                ultraCombo_ProductoHijo.DataSource = Tabla;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void creaTablaProductoHijo(List<in_Producto_Info> Lista, DataTable tablaNCombo)
        {
            try
            {
                tablaNCombo.Columns.Add("pr_descripcion");
                tablaNCombo.Columns.Add("IdProducto");
                foreach (var item in Lista)
                {
                    if (item.IdProducto != Convert.ToInt32(lblIdProducto.Text))
                    {
                        DataRow filas;
                        filas = tablaNCombo.NewRow();
                        filas[0] = item.pr_descripcion;
                        filas[1] = item.IdProducto;
                        tablaNCombo.Rows.Add(filas);
                        tablaNCombo.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public List<in_Producto_Composicion_Info> get_gridComposicion()
        {
            try
            {
                List<in_Producto_Composicion_Info> lss = new List<in_Producto_Composicion_Info>();
                for (int i = 0; i < this.ultraGrid_Composicion.Rows.Count; i++)
                {
                    in_Producto_Composicion_Info info = new in_Producto_Composicion_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdProductoPadre = Convert.ToInt32(lblIdProducto.Text);
                    info.IdProductoHijo = Convert.ToDecimal(ultraGrid_Composicion.Rows[i].Cells[0].Value);
                    info.Cantidad = Convert.ToInt32(ultraGrid_Composicion.Rows[i].Cells[1].Text);
                    lss.Add(info);
                }
                lsComposicionProducto = lss;
                return lss;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new List<in_Producto_Composicion_Info>();
            }
        }



        private void ultraGrid_Composicion_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            try
            {
                ultraGrid_Composicion.DisplayLayout.Bands[0].Columns[0].Width = 300;
                    ultraGrid_Composicion.DisplayLayout.Bands[0].Columns[0].ValueList = ultraCombo_ProductoHijo;
                    ultraGrid_Composicion.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnBottom;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
      
        }

        private void ultraGrid_Composicion_AfterRowInsert(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
        {
            try
            {
                for (int i = 0; i < ultraGrid_Composicion.Rows.Count; i++)
                    if (ultraGrid_Composicion.Rows[i].Cells[1].Text == "")
                    {
                        ultraGrid_Composicion.Rows[i].Cells[1].Value = 0;
                    }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        BindingList<in_producto_x_tb_bodega_Info> DataSource;
        private void carga_dgvProductoBodega()
        {
            try
            {
                DataSource = new BindingList<in_producto_x_tb_bodega_Info>();
                List<tb_Bodega_Info> ls = new List<tb_Bodega_Info>();
                tb_Bodega_Bus bus = new tb_Bodega_Bus();

                ls = bus.Obtener_BodegasTodas(param.IdEmpresa);
                foreach (var item in ls)
                {
                    in_producto_x_tb_bodega_Info obj = new in_producto_x_tb_bodega_Info();

                    obj.bodega = item.bo_Descripcion;
                    obj.sucursal = item.NomSucursal;
                    obj.IdSucursal = item.IdSucursal;
                    obj.IdBodega = item.IdBodega;




                    DataSource.Add(obj);
                }

                gridControlProdxBodega.DataSource = DataSource;


                //for (int i = 0; i < ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns.Count; i++)
                //{0
                //    ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns[i].Hidden = true;
                //}

                //ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns["bo_Descripcion"].Hidden = false;
                //ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns["NomSucursal"].Hidden = false;
                //ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns["Considera"].Hidden = false;
                //ultraGridProducto_x_Bodega.DisplayLayout.Bands[0].Columns["PVP"].Hidden = false;


                List<in_producto_x_tb_bodega_Info> lsProdBodega = new List<in_producto_x_tb_bodega_Info>();

                lsProdBodega = busProductoBodega.ObtenerExisteProductoxBodega(param.IdEmpresa, Convert.ToDecimal(lblIdProducto.Text));
                foreach (var item1 in DataSource)
                {
                    foreach (var item in lsProdBodega)
                    {
                        if (item.IdBodega ==item1.IdBodega && item.IdSucursal == item1.IdSucursal)
                        {
                            item1.EstaEnBase = true;
                            item1.Considera = (item.Estado == "A") ? true : false;

                            item1.IdCtaCble_Costo = item.IdCtaCble_Costo;
                            item1.IdCtaCble_Inven = item.IdCtaCble_Inven;
                            item1.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                            item1.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;
                            //ultraGridProducto_x_Bodega.Rows[i].Cells["Considera"].Value = (item.Estado == "A") ? true : false;
                            //ultraGridProducto_x_Bodega.Rows[i].Cells["EstaEnBase"].Value = true;
                        }
                    }
                }


                _lsProductoBodega_Anterior = lsProdBodega;

                gridControlProdxBodega.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());            
                
            }
            
        }

        private void ultraGridProducto_x_Bodega_InitializeLayout(object sender, InitializeLayoutEventArgs e){}

        //get la grilla de producto por bodega para grabarla
        public void get_gridProductoBodega()
        {
            try
            {
                lsProductoBodega_Insert  = new List<in_producto_x_tb_bodega_Info>();
                lsProductoBodega_Update = new List<in_producto_x_tb_bodega_Info>();
                foreach (var item in DataSource)
                {

                    in_producto_x_tb_bodega_Info info = new in_producto_x_tb_bodega_Info();
                    info.IdEmpresa = param.IdEmpresa;
                    info.IdSucursal = item.IdSucursal;
                    info.IdBodega = item.IdBodega;
                    info.IdProducto = Convert.ToInt32(lblIdProducto.Text);
                    info.pr_precio_publico = (double)txtPrecioPublico.Value;

                    info.IdCtaCble_Costo = item.IdCtaCble_Costo;
                    info.IdCtaCble_Inven = item.IdCtaCble_Inven;
                    info.IdCentro_Costo_Costo = item.IdCentro_Costo_Costo;
                    info.IdCentro_Costo_Inventario = item.IdCentro_Costo_Inventario;



                    info.Estado = (item.Considera == true) ? "A" : "I";

                    if (item.Considera == true)
                    {
                        info.EstaEnBase = true;
                        lsProductoBodega_Insert.Add(info);
                    }
                    else 
                    {
                        //if (info.Estado == "A") // si esta activo o ha sido check
                        //{

                        //    info.EstaEnBase = false;
                        //    lsProductoBodega_Update.Add(info);
                        //}


                    }
                }

                ////Losiguiente filtra aquellos registros nuevos de los anteriores para solo grabar los nuevos
                //List<in_producto_x_tb_bodega_Info>lss = new List<in_producto_x_tb_bodega_Info>();
                //var restOfFacilities = from q in lsProductoBodega_Nueva
                //                       where !_lsProductoBodega_Anterior.Select(A => A.IdBodega).Contains(q.IdBodega)
                //                       select q;
                //foreach (var item in restOfFacilities.ToList())
                //{
                //    lss.Add(item);
                //}
                //if(lss.Count!=0)
                //    lsProductoBodega_Nueva = lss;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void chkTodosBodega_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                 if (chkTodosBodega.Checked)
                {
                    foreach (var item in DataSource)
                    {
                        item.Considera = true;
                    }
            
                }else
                {
                    foreach (var item in DataSource)
                    {
                        item.Considera = false;
                    }
                }
                gridControlProdxBodega.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void txtPrecioPublico_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in DataSource)
                {
                    item.pr_precio_publico = Convert.ToDouble(txtPrecioPublico.Value);
                }
                gridControlProdxBodega.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ultraGridProducto_x_Bodega_InitializeLayout_1(object sender, InitializeLayoutEventArgs e){}

        private void mnu_anular_Click(object sender, EventArgs e)
        {
            try
            {
            if (Anular()) { MessageBox.Show("Anulacion Exitosa"); } else { MessageBox.Show("Error al anular "); }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void gridControlProdxBodega_Click(object sender, EventArgs e){}

        private void cmb_unidadMedida_SelectedIndexChanged(object sender, EventArgs e){}


    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 1369
/// </summary>