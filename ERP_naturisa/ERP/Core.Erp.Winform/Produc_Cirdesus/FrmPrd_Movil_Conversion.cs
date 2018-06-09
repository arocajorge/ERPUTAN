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
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;

using System.Threading;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_Movil_Conversion : Form
    {


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<in_Producto_Info> BindLstEle = new BindingList<in_Producto_Info>();
        BindingList<in_Producto_Info> BindLstRes = new BindingList<in_Producto_Info>();

        in_producto_Bus _Producto_B = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_parametros_CusCidersus_Bus param_Produccion = new prd_parametros_CusCidersus_Bus();
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_OrdenTaller_Bus _OrdenTAller_B = new prd_OrdenTaller_Bus();
        prd_parametros_CusCidersus_Info _Parametros_Info = new prd_parametros_CusCidersus_Info();
        in_movi_inve_Bus BusMovi = new in_movi_inve_Bus();
        in_producto_Bus Producto_B = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus ProductXBodega_Bus = new in_producto_x_tb_bodega_Bus();
        private Cl_Enumeradores.eTipo_action _Accion;
        List<prd_conversion_cusCidersus_x_in_movi_inven_Info> ListaTablaIntermedia = new List<prd_conversion_cusCidersus_x_in_movi_inven_Info>();
        prd_EtapaProduccion_Bus Etapa_B = new prd_EtapaProduccion_Bus();

        
        public FrmPrd_Movil_Conversion()
        {
            try
            {
                InitializeComponent();
                dtpFecha.EditValue = DateTime.Now;
                cmbObra.Properties.DataSource = BusOBra.ObtenerListaObra(param.IdEmpresa);
                _Parametros_Info = param_Produccion.ObtenerObjeto(param.IdEmpresa);
                ctrl_Suc_Bod.TipoCarga = Info.General.Cl_Enumeradores.eTipoFiltro.Normal;
                ctrl_Suc_Bod.Event_cmb_bodega_SelectionChangeCommitted += new Controles.UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(ctrl_Suc_Bod_Event_cmb_bodega_SelectionChangeCommitted);
                gridControlFinal.DataSource = BindLstEle;
                gridControlResiduo.DataSource = BindLstRes;
                    

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        public void setAccion(Cl_Enumeradores.eTipo_action iAccion)
        {
            try
            {
                 _Accion = iAccion;
                    funcionreadonlygrid();
                    switch (iAccion)
                    {
                        case Cl_Enumeradores.eTipo_action.grabar:
                            this.btnGuardar.Text = "Grabar Registro";
                            cambiacontroles();
                    
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
        void cambiacontroles()
        {
            try
            {
                Font fte = new System.Drawing.Font("Microsoft Sans Serif", 6.5f);

                ctrl_Suc_Bod.cmb_bodega.Size = new System.Drawing.Size(170, 18);
                ctrl_Suc_Bod.cmb_sucursal.Size = new System.Drawing.Size(170, 18);
                ctrl_Suc_Bod.label1.Text = "SUC:";
                ctrl_Suc_Bod.lblBodega.Text = "BOD:";
                ctrl_Suc_Bod.label1.Location = new Point(0, 8);
                ctrl_Suc_Bod.lblBodega.Location = new Point(0, 30);
                ctrl_Suc_Bod.label1.Font = fte;
                ctrl_Suc_Bod.lblBodega.Font = fte;
                ctrl_Suc_Bod.cmb_bodega.Font = fte;
                ctrl_Suc_Bod.cmb_sucursal.Font = fte;
                ctrl_Suc_Bod.cmb_sucursal.Location = new Point(27, 5);
                ctrl_Suc_Bod.cmb_bodega.Location = new Point(27, 27);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ctrl_Suc_Bod_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                   CargarProduc();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cmbOrdenTaller_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoBarra.Text = "";
                prd_SubGrupoTrabajo_Bus BusGT = new prd_SubGrupoTrabajo_Bus();
                var listagrupo = BusGT.ObtenerGrupoTrabajoCab_x_OT(param.IdEmpresa, Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue), Convert.ToDecimal(cmbOrdenTaller.EditValue));
                cmbGT.Properties.DataSource = listagrupo;
                CargarProduc();
                gridViewFinal.SelectAll();
                gridViewFinal.DeleteSelectedRows();
                gridViewResiduo.SelectAll();
                gridViewResiduo.DeleteSelectedRows();
                funcionreadonlygrid();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
        prd_ProcesoProductivo_x_prd_obra_Info Obra = new prd_ProcesoProductivo_x_prd_obra_Info();
       
        private void cmbObra_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodigoBarra.Text = "";
                cmbProducto.Properties.DataSource = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                 cmbOrdenTaller.Properties.DataSource = _OrdenTAller_B.ObtenerListaOT_x_CentroCosto(param.IdEmpresa, cmbObra.EditValue.ToString());
                 prd_ProcesoProductivo_x_prd_obra_Bus Bus = new prd_ProcesoProductivo_x_prd_obra_Bus();
               
                 Obra = Bus.Obtener1ProcesProductivo_x_CentroCosto(param.IdEmpresa, cmbObra.EditValue.ToString());
                 cmbEtapa.Properties.DataSource = Etapa_B.ObtenerListaEtapas(param.IdEmpresa, Obra.IdProcesoProductivo);
                 gridViewFinal.SelectAll();
                 gridViewFinal.DeleteSelectedRows();
                 gridViewResiduo.SelectAll();
                 gridViewResiduo.DeleteSelectedRows();
                 funcionreadonlygrid();
            

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
           }


        void CargarProduc() 
        {
            try
            {
                in_movi_inve_detalle_x_Producto_CusCider_Bus Bus = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
                var ordenTaller = ((List<prd_OrdenTaller_Info>)(cmbOrdenTaller.Properties.DataSource)).First(var => var.IdOrdenTaller == Convert.ToDecimal(cmbOrdenTaller.EditValue));
                var Prod = Bus.ObtenerMateriaPrima(param.IdEmpresa, Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue), Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue), ordenTaller.IdSucursal, ordenTaller.IdOrdenTaller, cmbObra.EditValue.ToString(), ordenTaller.IdEmpresa);//se envia 0 porque no buscamos que este en ninguna etapa posterior
                cmbProducto.Properties.DataSource = Prod;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                //Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                //Visor.GuardarVisor(this.ToString(), ex);
                //MessageBox.Show(ex.ToString());
            }
        }
       
        private void cmbProducto_EditValueChanged(object sender, EventArgs e) {}

        private void cmbProducto_Properties_EditValueChanged(object sender, EventArgs e){}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                   Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
                
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                var se = (vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info)gridView2.GetRow(e.RowHandle);
                txtCodigoBarra.Text = ((List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>)(cmbProducto.Properties.DataSource)).First(var => var.IdProducto == Convert.ToDecimal(se.IdProducto) && var.mv_Secuencia == se.mv_Secuencia).CodigoBarra;
                gridViewFinal.SelectAll();
                gridViewFinal.DeleteSelectedRows();
                gridViewResiduo.SelectAll();
                gridViewResiduo.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            //gridViewFinal.AddNewRow();
        }

        private void gridViewFinal_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {
                    if (e.FocusedColumn.ToString() == "CB")
                    {
                        string Codigo = txtCodigoBarra.Text + "C" + ((gridViewFinal.GetVisibleIndex(gridViewFinal.FocusedRowHandle) + 1));
                        String Largo = gridViewFinal.GetFocusedRowCellValue(_Largo).ToString();
                        if (!string.IsNullOrEmpty(Largo) && Largo != "0")
                        {

                            gridViewFinal.SetFocusedRowCellValue(colpr_descripcion, cmbProducto.Text + " Cort " + Largo + "mm");
                        }
                        String Ancho = gridViewFinal.GetFocusedRowCellValue(_Ancho).ToString();
                        if (!string.IsNullOrEmpty(Ancho) && Ancho != "0")
                        {

                            gridViewFinal.SetFocusedRowCellValue(colpr_descripcion, cmbProducto.Text + " Cort " + Largo + "mm" + " x " + Ancho + "mm");
                        }
                        gridViewFinal.SetFocusedRowCellValue(colCodBarra, Codigo.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        private void gridViewResiduo_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (_Accion == Cl_Enumeradores.eTipo_action.grabar)
                {

                    if (e.FocusedColumn.ToString() == "CB")
                    {
                        
                        string Codigo = txtCodigoBarra.Text + "R" + ((gridViewResiduo.GetVisibleIndex(gridViewResiduo.FocusedRowHandle) + 1));
                        gridViewResiduo.SetFocusedRowCellValue(colBarra2, null);
                        gridViewResiduo.SetFocusedRowCellValue(colBarra2, Codigo.ToString());

                        String Largo = gridViewResiduo.GetFocusedRowCellValue(Col_Largo).ToString();
                        if (!string.IsNullOrEmpty(Largo) && Largo != "0")
                        {
                            string LargoCod = Codigo + "x" + Largo + "mm";
                            gridViewResiduo.SetFocusedRowCellValue(col_descripcion, cmbProducto.Text + " Cort " + Largo + "mm");
                        }
                        String Ancho = gridViewResiduo.GetFocusedRowCellValue(Col_Alto).ToString();
                        if (!string.IsNullOrEmpty(Ancho) && Ancho != "0")
                        {
                            gridViewResiduo.SetFocusedRowCellValue(colCodBarra, Codigo.ToString());
                            gridViewResiduo.SetFocusedRowCellValue(col_descripcion, cmbProducto.Text + " Cort " + Largo + "mm" + " x " + Ancho + "mm");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

           List<in_Producto_Info> ProductGuardar = new List<in_Producto_Info>();
           List<in_Producto_Info> ProductosGrilla = new List<in_Producto_Info>();
           List<in_Producto_Info> list_NuevosProductos = new List<in_Producto_Info>();
           prd_OrdenTaller_Info OrdenTAller = new prd_OrdenTaller_Info();
        void Get()
        {
            try
            {
                OrdenTAller = new prd_OrdenTaller_Info();

                OrdenTAller = (prd_OrdenTaller_Info)gridViewOrdenTaLLER.GetFocusedRow();
                #region MovimientoInventarioEgreso

                for (int i = 0; i < gridViewFinal.RowCount; i++)
                {
                    var Item = (in_Producto_Info)gridViewFinal.GetRow(i);
                    if (Item != null)
                    {
                        Item.IdProducto = Convert.ToInt32(cmbProducto.EditValue);
                        ProductosGrilla.Add(Item);
                    }
                }

                in_producto_Bus Produ_B = new in_producto_Bus();
                foreach (var item in ProductosGrilla)
                {
                    in_Producto_Info newProducto = new in_Producto_Info();
                    in_Producto_Info s = Produ_B.Get_Info_BuscarProducto(Convert.ToDecimal(cmbProducto.EditValue), param.IdEmpresa);
                    newProducto = s;
                    newProducto.pr_largo = item.pr_largo;
                    newProducto.pr_alto = item.pr_alto;
                    newProducto.pr_descripcion = item.pr_descripcion;
                    newProducto.CodBarra = item.CodBarra;
                    list_NuevosProductos.Add(newProducto);
                }
                #endregion
                var List = from q in list_NuevosProductos
                           group q by q.pr_descripcion
                               into ProductosNuevos
                               select new { ProductosNuevos.Key };

                foreach (var item in List)
                {
                    ProductGuardar.Add(list_NuevosProductos.First(var => var.pr_descripcion == item.Key));
                }
          


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdNumRegistro.Focus();
                if (Validar())
                {
                    ProductGuardar = new List<in_Producto_Info>();
                    ProductosGrilla = new List<in_Producto_Info>();
                    list_NuevosProductos = new List<in_Producto_Info>();
                    Get();

                   
                    
                    GuardarProductos();
                    GuardarProductoReciduo();
                    GuardarTransaccion();
                    GuardarMOviInvenCabecera();
                    btnGuardar.Visible  = false;

                    var Movimientos = BusInve.ConsultaMovimienosxConversion(param.IdEmpresa,
                   Convert.ToInt32 ( txtIdNumRegistro.EditValue), ref msgs);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }
        prd_Conversion_CusCidersus_Info _Info;
        void GuardarTransaccion()
        {

            try
            {
                prd_Conversion_CusCidersus_Bus prdBus = new prd_Conversion_CusCidersus_Bus();


                in_producto_Bus BUSPRODUCT = new in_producto_Bus();
                _Info = new prd_Conversion_CusCidersus_Info();
                _Info.IdSucursal = Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue);
                _Info.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                _Info.CodObra = cmbObra.EditValue.ToString();
                _Info.IdOrdenTaller = Convert.ToDecimal(cmbOrdenTaller.EditValue);
                _Info.IdEtapa = Convert.ToInt32(cmbEtapa.EditValue);
                _Info.IdGrupoTrabajo = Convert.ToDecimal(cmbGT.EditValue);
                _Info.CodBarraProducto = txtCodigoBarra.Text;
                _Info.NomProducto = cmbProducto.Text;
                _Info.IdEmpresa = param.IdEmpresa;
                _Info.Fecha = Convert.ToDateTime(dtpFecha.EditValue);
                _Info.IdUsuario = param.IdUsuario;
                _Info.Fecha_transaccion = param.Fecha_Transac;
                _Info.Observacion = txtObserva.Text
                    +" Conv Prod " + cmbProducto.Text
                    + " x Obra " + cmbObra.EditValue.ToString()
                    + " Ot " + cmbOrdenTaller.Text;

                foreach (var item in ProductosGrilla)
                {
                    prd_Conversion_det_CusCidersus_Info Obj = new prd_Conversion_det_CusCidersus_Info();
                    Obj.CodBarra = item.CodBarra;
                    Obj.IdBodega = _Info.IdBodega;
                    Obj.IdEmpresa = param.IdEmpresa;
                    var prod = BUSPRODUCT.Get_Info_ProductoXNombre(param.IdEmpresa, item.pr_descripcion);
                    Obj.IdProducto = prod.IdProducto;
                        
                    Obj.IdSucursal = _Info.IdSucursal;
                    Obj.Observacion = item.pr_observacion + _Info.Observacion 
                        + " a Prod " + prod.pr_descripcion;
                    Obj.TipoPro = "Fin";
                    _Info.ListDetalle.Add(Obj);
                }
                foreach (var item in LstNewProduc)
                {
                    prd_Conversion_det_CusCidersus_Info Obj = new prd_Conversion_det_CusCidersus_Info();
                    Obj.CodBarra = item.CodBarra;
                    Obj.IdBodega = _Info.IdBodega;
                    Obj.IdEmpresa = param.IdEmpresa;
                    //Obj.IdProducto = BUSPRODUCT.ObtenerProductoXNombre(param.IdEmpresa, item.pr_descripcion).IdProducto;
                    var prod = BUSPRODUCT.Get_Info_ProductoXNombre(param.IdEmpresa, item.pr_descripcion);
                    Obj.IdProducto = prod.IdProducto;
                  
                    Obj.IdSucursal = _Info.IdSucursal;
                    Obj.Observacion = item.pr_observacion + _Info.Observacion
                        + " a Prod " + prod.pr_descripcion; 
                    Obj.TipoPro = "Res";
                    _Info.ListDetalle.Add(Obj);
                }

                
                string Mensaje = "";
                if (prdBus.GuardarDB(_Info, ref IdRegistr, ref Mensaje))
                {
                    MessageBox.Show(Mensaje);
                    txtIdNumRegistro.EditValue = IdRegistr;
                 
                    prd_conversion_cusCidersus_x_in_movi_inven_Bus BusInter = new prd_conversion_cusCidersus_x_in_movi_inven_Bus();
                    ListaTablaIntermedia.ForEach(v => { v.cv_IdConversion = IdRegistr; v.cv_IdEmpresa = param.IdEmpresa; });
                    foreach (var item in ListaTablaIntermedia)
                    {
                        BusInter.GuardarDB(item);

                    }

                }
                else
                {
                    MessageBox.Show(Mensaje);
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }
        decimal IdRegistr = 0;
        void GuardarProductos() 
        {


            try
            {
                decimal id = 0;
                string Men = "";
                string mensaje_cbte_cble = "";

                List<in_producto_x_tb_bodega_Info> ListaProductosXBodega = new List<in_producto_x_tb_bodega_Info>();
                foreach (var item in ProductGuardar)
                {
                    if (Producto_B.ValidarProductExiste(item.pr_descripcion) == false)
                    {
                        item.Fecha_Transac = param.Fecha_Transac;
                        item.Fecha_UltMod = param.Fecha_Transac;
                        item.IdUsuario = param.IdUsuario;
                        item.IdUsuarioUltMod = param.IdUsuario;
                        item.ip = param.ip;
                        item.nom_pc = param.nom_pc;
                        item.pr_codigo = "";
                        item.IdProducto = 0;
                        item.pr_observacion = item.pr_observacion + txtObserva.Text
                        + " Conv Prod " + cmbProducto.Text
                        + " x Obra " + cmbObra.EditValue.ToString()
                        + " Ot " + cmbOrdenTaller.Text
                        + " a Prod " + item.pr_descripcion;
                        in_producto_x_tb_bodega_Info Info = new in_producto_x_tb_bodega_Info();
                        if (Producto_B.GrabarDB(item, ref id, ref Men))
                        {
                            #region Asignacion


                            Info.IdEmpresa = param.IdEmpresa;
                            Info.IdSucursal = item.IdSucursal;
                            Info.IdBodega = item.IdBodega;
                            Info.IdProducto = id;
                            item.IdProducto = id;
                            Info.pr_precio_publico = item.pr_precio_publico;
                            Info.pr_precio_mayor = item.pr_precio_mayor;
                            Info.pr_precio_puerta = 0;
                            Info.pr_precio_minimo = item.pr_precio_minimo;
                            Info.pr_Por_descuento = 0;
                            Info.pr_stock_maximo = 0;
                            Info.pr_stock_minimo = 0;
                            Info.pr_costo_fob = item.pr_costo_fob;
                            Info.pr_costo_CIF = item.pr_costo_CIF;
                            Info.pr_costo_promedio = item.pr_costo_promedio;
                            Info.Estado = item.Estado;
                            ListaProductosXBodega.Add(Info);
                            #endregion
                        }
                    }
                }
                tb_Sucursal_Bus Sucur_B = new tb_Sucursal_Bus();
                tb_Bodega_Bus Bodega_B = new Business.General.tb_Bodega_Bus();
                List<tb_Bodega_Info> ListaBodegasConSucursal = new List<tb_Bodega_Info>();
                List<tb_Sucursal_Info> ListaSucursalesYbodegas = new List<tb_Sucursal_Info>();
                var Sucursales = Sucur_B.Get_List_Sucursal(param.IdEmpresa);
                foreach (tb_Sucursal_Info item in Sucursales)
                {
                    item.ListasBodegasXSucursal.Add(Bodega_B.Get_List_Bodega(param.IdEmpresa, item.IdSucursal));
                }
                foreach (var item in ListaProductosXBodega)
                {
                    foreach (var Sucursal in Sucursales)
                    {
                        List<in_producto_x_tb_bodega_Info> ListProPorBodega = new List<in_producto_x_tb_bodega_Info>();
                        foreach (var Bodegas in Sucursal.ListasBodegasXSucursal)
                        {
                            foreach (var Bodega in Bodegas)
                            {
                                #region Asignacion


                                in_producto_x_tb_bodega_Info Obj = new in_producto_x_tb_bodega_Info();
                                Obj.IdEmpresa = param.IdEmpresa;
                                Obj.IdSucursal = Sucursal.IdSucursal;
                                Obj.IdBodega = Bodega.IdBodega;
                                Obj.IdProducto = item.IdProducto;
                                Obj.pr_precio_publico = item.pr_precio_publico;
                                Obj.pr_precio_mayor = item.pr_precio_mayor;
                                Obj.pr_precio_puerta = 0;
                                Obj.pr_precio_minimo = item.pr_precio_minimo;
                                Obj.pr_Por_descuento = 0;
                                Obj.pr_stock = 0;
                                Obj.pr_stock_maximo = 0;
                                Obj.pr_stock_minimo = 0;
                                Obj.pr_costo_fob = item.pr_costo_fob;
                                Obj.pr_costo_CIF = item.pr_costo_CIF;
                                Obj.pr_costo_promedio = item.pr_costo_promedio;

                                Obj.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                                Obj.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                                Obj.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                                Obj.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                                Obj.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                                Obj.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                                Obj.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                                Obj.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                                Obj.Estado = item.Estado;

                                ListProPorBodega.Add(Obj);
                                #endregion
                            }
                        }
                        ProductXBodega_Bus.GrabaDB(ListProPorBodega, param.IdEmpresa, ref Men);
                    }
                }
                in_movi_inve_Info MoviCab_I = new in_movi_inve_Info();
                MoviCab_I.cm_fecha = Convert.ToDateTime(Convert.ToDateTime(dtpFecha.EditValue));
                MoviCab_I.cm_observacion = txtObserva.Text
                    + " Conv Prod " + cmbProducto.Text
                    + " x Obra " + cmbObra.EditValue.ToString()
                    + " Ot " + cmbOrdenTaller.Text;
                MoviCab_I.cm_tipo = "+";
                MoviCab_I.IdMovi_inven_tipo = Convert.ToInt32 (_Parametros_Info.IdMovi_inven_tipo_ing_Conversion);
                MoviCab_I.IdEmpresa = param.IdEmpresa;
                MoviCab_I.IdSucursal = Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue);
                MoviCab_I.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                List<in_movi_inve_detalle_Info> movi_det = new List<in_movi_inve_detalle_Info>();
                int sec = 1;
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaDetalleCusCidersus = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                list_NuevosProductos.ForEach(var => var.IdProducto = Producto_B.Get_Info_ProductoXNombre(param.IdEmpresa, var.pr_descripcion).IdProducto);
                foreach (var item in list_NuevosProductos)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    var Product = ProductXBodega_Bus.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue), Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue), item.IdProducto);
                    obj.dm_cantidad = 1;
                    
                    //obj.dm_observacion = "Conver x prod." + cmbProducto.Text + "Con el Id " + cmbProducto.EditValue;


                    obj.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                    obj.IdSucursal = Convert.ToInt32(_Parametros_Info.IdSucursal_Produccion);
                    obj.IdEmpresa = param.IdEmpresa;
                    obj.IdMovi_inven_tipo = MoviCab_I.IdMovi_inven_tipo;
                    obj.mv_tipo_movi = "+";
                    obj.mv_costo = Product.pr_costo_promedio == null ? 0 : Convert.ToDouble(Product.pr_costo_promedio);
                    obj.dm_precio = Product.pr_precio_publico == null ? 0 : Convert.ToDouble(Product.pr_precio_publico);
                    obj.IdProducto = item.IdProducto;
                    obj.CodigoBarra = item.CodBarra;

                    obj.ot_IdEmpresa = OrdenTAller.IdEmpresa;
                    obj.ot_IdOrdenTaller = OrdenTAller.IdOrdenTaller;
                    obj.ot_IdSucursal = OrdenTAller.IdSucursal;
                    obj.ot_CodObra = OrdenTAller.CodObra;
                    obj.et_IdEmpresa = Etapa.IdEmpresa;
                    obj.et_IdEtapa = Etapa.IdEtapa;
                    obj.et_IdProcesoProductivo = Etapa.IdProcesoProductivo;
                    obj.dm_observacion = obj.dm_observacion + txtObserva.Text
                        + " Conv Prod " + cmbProducto.Text
                        + " a Prod " + Product.pr_descripcion
                        +" x Obra " + cmbObra.EditValue.ToString()
                        + " Ot " + cmbOrdenTaller.Text;
                    ListaDetalleCusCidersus.Add(obj);
                }




                foreach (var item in ProductGuardar)
                {
                    var cantidad = ProductosGrilla.FindAll(var => var.pr_descripcion == item.pr_descripcion).Count();
                    var Product = ProductXBodega_Bus.Get_Info_Producto_x_Producto(param.IdEmpresa,
                        Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue), Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue), item.IdProducto);
                    in_movi_inve_detalle_Info Movi_I = new in_movi_inve_detalle_Info();

                    Movi_I.IdProducto = item.IdProducto;


                    Movi_I.dm_cantidad = cantidad;
                    Movi_I.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                    Movi_I.IdSucursal = Convert.ToInt32(_Parametros_Info.IdSucursal_Produccion);
                    Movi_I.IdEmpresa = param.IdEmpresa;
                    Movi_I.IdMovi_inven_tipo = MoviCab_I.IdMovi_inven_tipo;
                    Movi_I.mv_tipo_movi = "+";
                    Movi_I.mv_costo = Product.pr_costo_promedio;
                    Movi_I.dm_precio = Product.pr_precio_publico;
                    Movi_I.dm_stock_actu = Product.pr_stock + cantidad;
                    Movi_I.dm_stock_ante = Product.pr_stock;
                    Movi_I.dm_observacion = Movi_I.dm_observacion + txtObserva.Text
                        + " Conv Prod " + cmbProducto.Text
                        + " a Prod " + Product.pr_descripcion
                        + " x Obra " + cmbObra.EditValue.ToString()
                        + " Ot " + cmbOrdenTaller.Text; 
                    Movi_I.Secuencia = sec;

                    ListaDetalleCusCidersus.ForEach(var => { if (var.IdProducto == item.IdProducto) { var.mv_Secuencia = sec; } });
                    movi_det.Add(Movi_I);
                    sec++;
                }
                in_movi_inve_detalle_x_Producto_CusCider_Bus BusCuscide = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

                MoviCab_I.listmovi_inve_detalle_Info = movi_det;

                BusMovi.GrabarDB(MoviCab_I, ref id,ref mensaje_cbte_cble, ref Men);


                prd_conversion_cusCidersus_x_in_movi_inven_Info InfoInte = new prd_conversion_cusCidersus_x_in_movi_inven_Info();
                InfoInte.IdBodega = MoviCab_I.IdBodega;
                InfoInte.IdEmpresa = param.IdEmpresa;
                InfoInte.IdMovi_inven_tipo = MoviCab_I.IdMovi_inven_tipo;
                InfoInte.IdSucursal = MoviCab_I.IdSucursal;
                InfoInte.IdNumMovi = id;
                ListaTablaIntermedia.Add(InfoInte);



                ListaDetalleCusCidersus.ForEach(var => var.IdNumMovi = id);



                if (BusCuscide.GuardarDB(ListaDetalleCusCidersus, ref Men))
                {
                }
                else
                {
                }
                
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        void GuardarMOviInvenCabecera() 
        {
            try
            {
                string mensaje_cbte_cble = "";

                in_producto_x_tb_bodega_Bus _ProdXBode_B = new in_producto_x_tb_bodega_Bus();
                in_movi_inve_Info _MoviInvenI = new in_movi_inve_Info();
                _MoviInvenI.IdEmpresa = param.IdEmpresa;
                _MoviInvenI.IdSucursal = Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue);
                _MoviInvenI.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                _MoviInvenI.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);
                _MoviInvenI.cm_tipo = "-";
                _MoviInvenI.cm_fecha = Convert.ToDateTime(dtpFecha.EditValue);
                _MoviInvenI.cm_observacion =  _MoviInvenI.cm_observacion +txtObserva.Text
                        + " Egr Conv Prod " + cmbProducto.Text
                        + " x Obra " + cmbObra.EditValue.ToString()
                        + " Ot " + cmbOrdenTaller.Text; 
                in_movi_inve_detalle_Info _DetMoviInv_I = new in_movi_inve_detalle_Info();
                var Product = _ProdXBode_B.Get_Info_Producto_x_Producto(param.IdEmpresa, Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue), Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue), Convert.ToDecimal(cmbProducto.EditValue));
                _DetMoviInv_I.IdProducto = Convert.ToDecimal(cmbProducto.EditValue);
                _DetMoviInv_I.IdEmpresa = param.IdEmpresa;
                _DetMoviInv_I.IdSucursal = _MoviInvenI.IdSucursal;
                _DetMoviInv_I.IdBodega = _MoviInvenI.IdBodega;
                _DetMoviInv_I.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);
                _DetMoviInv_I.dm_cantidad = -1;
                _DetMoviInv_I.dm_observacion = _MoviInvenI.cm_observacion;
                _DetMoviInv_I.dm_precio = Product.pr_precio_publico;
                _DetMoviInv_I.mv_costo = Product.pr_costo_promedio;
                _DetMoviInv_I.dm_stock_actu = Product.pr_stock - 1;
                _DetMoviInv_I.dm_stock_ante = Product.pr_stock;
                _DetMoviInv_I.mv_tipo_movi = "-";

                _MoviInvenI.listmovi_inve_detalle_Info.Add(_DetMoviInv_I);

                in_movi_inve_detalle_x_Producto_CusCider_Bus BusCuscide = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

                decimal Id = 0;
                string Men = "";
                BusMovi.GrabarDB(_MoviInvenI, ref Id,ref mensaje_cbte_cble, ref Men);


                List<in_movi_inve_detalle_x_Producto_CusCider_Info> MoviDetCabCusCider = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                in_movi_inve_detalle_x_Producto_CusCider_Info obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                //   var Product = ProductXBodega_Bus.ObtenerObjeto(param.IdEmpresa, _Parametros_Info.IdSucursal_Princ, _Parametros_Info.IdBodega_Princ, item.IdProducto);
                obj.dm_cantidad = -1;
                obj.IdNumMovi = Id;
                obj.dm_observacion = _MoviInvenI.cm_observacion;
                obj.IdSucursal = Convert.ToInt32(ctrl_Suc_Bod.cmb_sucursal.EditValue);
                obj.IdBodega = Convert.ToInt32(ctrl_Suc_Bod.cmb_bodega.EditValue);
                obj.IdEmpresa = param.IdEmpresa;
                obj.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_egr_Conversion);
                obj.mv_tipo_movi = "-";
                obj.mv_costo = Product.pr_costo_promedio == null ? 0 : Convert.ToDouble(Product.pr_costo_promedio);
                obj.dm_precio = Product.pr_precio_publico == null ? 0 : Convert.ToDouble(Product.pr_precio_publico);
                obj.IdProducto = Convert.ToDecimal(cmbProducto.EditValue);
                obj.mv_Secuencia = 1;
                obj.CodigoBarra = txtCodigoBarra.Text;


                obj.ot_IdEmpresa = OrdenTAller.IdEmpresa;
                obj.ot_IdOrdenTaller = OrdenTAller.IdOrdenTaller;
                obj.ot_IdSucursal = OrdenTAller.IdSucursal;
                obj.ot_CodObra = OrdenTAller.CodObra;
                //obj.et_IdEmpresa = Etapa.IdEmpresa;
                //obj.et_IdEtapa = Etapa.IdEtapa;
                //obj.et_IdProcesoProductivo = Etapa.IdProcesoProductivo;

                MoviDetCabCusCider.Add(obj);
                BusCuscide.GuardarDB(MoviDetCabCusCider, ref Men);




                prd_conversion_cusCidersus_x_in_movi_inven_Info InfoInte = new prd_conversion_cusCidersus_x_in_movi_inven_Info();
                InfoInte.IdBodega = obj.IdBodega;
                InfoInte.IdEmpresa = InfoInte.cv_IdEmpresa = param.IdEmpresa;
                InfoInte.cv_IdConversion = IdRegistr;
                InfoInte.IdMovi_inven_tipo = _MoviInvenI.IdMovi_inven_tipo;
                InfoInte.IdSucursal = obj.IdSucursal;
                InfoInte.IdNumMovi = Id;
                //ListaTablaIntermedia.Add(InfoInte);
                prd_conversion_cusCidersus_x_in_movi_inven_Bus BusInter = new prd_conversion_cusCidersus_x_in_movi_inven_Bus();
                   
                BusInter.GuardarDB(InfoInte);
            
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }
        }
      
        
        List<in_Producto_Info> LstNewProduc = new List<in_Producto_Info>();
        void GuardarProductoReciduo()
        {
            try
            {

                string mensaje_cbte_cble = "";

                List<in_Producto_Info> LstProducto = new List<in_Producto_Info>();
                LstNewProduc = new List<in_Producto_Info>();
                decimal id = 0;
                string Men = "";
                for (int i = 0; i < gridViewResiduo.RowCount; i++)
                {
                    in_Producto_Info newProducto = new in_Producto_Info();
                    in_Producto_Info item = (in_Producto_Info)gridViewResiduo.GetRow(i);
                    if (item != null)
                    {
                        LstNewProduc.Add(item);
                        if (Producto_B.ValidarProductExiste(item.pr_descripcion) == false)
                        {
                            in_Producto_Info s = _Producto_B.Get_Info_BuscarProducto(Convert.ToDecimal(cmbProducto.EditValue), param.IdEmpresa);
                            newProducto = s;
                            newProducto.IdProducto = 0;
                            newProducto.pr_largo = item.pr_largo;
                            newProducto.pr_alto = item.pr_alto;
                            newProducto.pr_descripcion = item.pr_descripcion;
                            newProducto.CodBarra = item.CodBarra;
                            newProducto.pr_observacion = txtObserva.Text
                                + " Prod Rest " + newProducto.pr_descripcion
                                + " x Conv Prod " + cmbProducto.Text
                                + " x Obra " + cmbObra.EditValue.ToString()
                                + " Ot " + cmbOrdenTaller.Text; 
                            LstProducto.Add(item);
                            Producto_B.GrabarDB(newProducto, ref id, ref Men);
                            item.IdProducto = id;
                        }
                    }
                }





                tb_Sucursal_Bus Sucur_B = new tb_Sucursal_Bus();
                tb_Bodega_Bus Bodega_B = new Business.General.tb_Bodega_Bus();
                List<tb_Bodega_Info> ListaBodegasConSucursal = new List<tb_Bodega_Info>();
                List<tb_Sucursal_Info> ListaSucursalesYbodegas = new List<tb_Sucursal_Info>();
                var Sucursales = Sucur_B.Get_List_Sucursal(param.IdEmpresa);
                foreach (tb_Sucursal_Info item in Sucursales)
                {
                    item.ListasBodegasXSucursal.Add(Bodega_B.Get_List_Bodega(param.IdEmpresa, item.IdSucursal));
                }
                foreach (var item in LstProducto)
                {
                    foreach (var Sucursal in Sucursales)
                    {
                        List<in_producto_x_tb_bodega_Info> ListProPorBodega = new List<in_producto_x_tb_bodega_Info>();
                        foreach (var Bodegas in Sucursal.ListasBodegasXSucursal)
                        {
                            foreach (var Bodega in Bodegas)
                            {
                                #region Asignacion


                                in_producto_x_tb_bodega_Info Obj = new in_producto_x_tb_bodega_Info();
                                Obj.IdEmpresa = param.IdEmpresa;
                                Obj.IdSucursal = Sucursal.IdSucursal;
                                Obj.IdBodega = Bodega.IdBodega;
                                Obj.IdProducto = item.IdProducto;
                                Obj.pr_precio_publico = item.pr_precio_publico;
                                Obj.pr_precio_mayor = item.pr_precio_mayor;
                                Obj.pr_precio_puerta = 0;
                                Obj.pr_precio_minimo = item.pr_precio_minimo;
                                Obj.pr_Por_descuento = 0;
                                Obj.pr_stock = 0;
                                Obj.pr_stock_maximo = 0;
                                Obj.pr_stock_minimo = 0;
                                Obj.pr_costo_fob = item.pr_costo_fob;
                                Obj.pr_costo_CIF = item.pr_costo_CIF;
                                Obj.pr_costo_promedio = item.pr_costo_promedio;

                                //Obj.IdCtaCble_CosBaseIva = item.IdCtaCble_CosBaseIva;
                                //Obj.IdCtaCble_CosBase0 = item.IdCtaCble_CosBase0;
                                //Obj.IdCtaCble_VenIva = item.IdCtaCble_VenIva;
                                //Obj.IdCtaCble_Ven0 = item.IdCtaCble_Ven0;
                                //Obj.IdCtaCble_DesIva = item.IdCtaCble_DesIva;
                                //Obj.IdCtaCble_Des0 = item.IdCtaCble_Des0;
                                //Obj.IdCtaCble_DevIva = item.IdCtaCble_DevIva;
                                //Obj.IdCtaCble_Dev0 = item.IdCtaCble_Dev0;
                                Obj.Estado = item.Estado;


                                ListProPorBodega.Add(Obj);
                                #endregion
                            }
                        }
                        ProductXBodega_Bus.GrabaDB(ListProPorBodega, param.IdEmpresa, ref Men);
                    }
                }


                in_movi_inve_Info MoviCab_I = new in_movi_inve_Info();
                MoviCab_I.cm_fecha = Convert.ToDateTime(dtpFecha.EditValue);
                MoviCab_I.cm_observacion = txtObserva.Text
                                + " Ing Prod Rest x Conv Prod " + cmbProducto.Text
                                + " x Obra " + cmbObra.EditValue.ToString()
                                + " Ot " + cmbOrdenTaller.Text; 

                MoviCab_I.cm_tipo = "+";
                MoviCab_I.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_ingxresid_Conversion);
                MoviCab_I.IdEmpresa = param.IdEmpresa;
                MoviCab_I.IdSucursal = _Parametros_Info.IdSucursal_Princ;
                MoviCab_I.IdBodega = _Parametros_Info.IdBodega_Princ;
                List<in_movi_inve_detalle_Info> movi_det = new List<in_movi_inve_detalle_Info>();
                int sec = 1;
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListaDetalleCusCidersus = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

                LstNewProduc.ForEach(var => var.IdProducto = Producto_B.Get_Info_ProductoXNombre(param.IdEmpresa, var.pr_descripcion).IdProducto);
                foreach (var item in LstNewProduc)
                {
                    in_movi_inve_detalle_x_Producto_CusCider_Info obj = new in_movi_inve_detalle_x_Producto_CusCider_Info();
                    var Product = ProductXBodega_Bus.Get_Info_Producto_x_Producto(param.IdEmpresa, _Parametros_Info.IdSucursal_Princ, _Parametros_Info.IdBodega_Princ, item.IdProducto);
                    obj.dm_cantidad = 1;

                    obj.dm_observacion = obj.dm_observacion+ txtObserva.Text
                                + " Prod Rest " + item.pr_descripcion
                                + " x Conv Prod " + cmbProducto.Text
                                + " x Obra " + cmbObra.EditValue.ToString()
                                + " Ot " + cmbOrdenTaller.Text; 
                    //obj.dm_observacion = "Conver prod." + cmbProducto.Text + "Con el Id " + cmbProducto.EditValue;
                    
                    obj.IdSucursal = _Parametros_Info.IdSucursal_Princ;
                    obj.IdBodega = _Parametros_Info.IdBodega_Princ;
                    obj.IdEmpresa = param.IdEmpresa;
                    obj.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_ingxresid_Conversion);
                    obj.mv_tipo_movi = "+";
                    obj.mv_costo = Product.pr_costo_promedio == null ? 0 : Convert.ToDouble(Product.pr_costo_promedio);
                    obj.dm_precio = Product.pr_precio_publico == null ? 0 : Convert.ToDouble(Product.pr_precio_publico);
                    obj.IdProducto = item.IdProducto;
                    obj.CodigoBarra = item.CodBarra;



                    ListaDetalleCusCidersus.Add(obj);
                }



                foreach (var item in LstNewProduc)
                {
                    var cantidad = LstNewProduc.FindAll(var => var.pr_descripcion == item.pr_descripcion).Count();
                    var Product = ProductXBodega_Bus.Get_Info_Producto_x_Producto(param.IdEmpresa, _Parametros_Info.IdSucursal_Princ, _Parametros_Info.IdBodega_Princ, item.IdProducto);
                    in_movi_inve_detalle_Info Movi_I = new in_movi_inve_detalle_Info();

                    Movi_I.IdProducto = item.IdProducto;


                    Movi_I.dm_cantidad = cantidad;
                    Movi_I.IdSucursal = _Parametros_Info.IdSucursal_Princ;
                    Movi_I.IdBodega = _Parametros_Info.IdBodega_Princ;
                    Movi_I.IdEmpresa = param.IdEmpresa;
                    Movi_I.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_ingxresid_Conversion);
                    Movi_I.mv_tipo_movi = "+";
                    Movi_I.mv_costo = Product.pr_costo_promedio;
                    Movi_I.dm_precio = Product.pr_precio_publico;
                    Movi_I.dm_stock_actu = Product.pr_stock + cantidad;
                    Movi_I.dm_stock_ante = Product.pr_stock;
                    Movi_I.dm_observacion = Movi_I.dm_observacion + txtObserva.Text
                                + " Prod Rest " + item.pr_descripcion
                                + " x Conv Prod " + cmbProducto.Text
                                + " x Obra " + cmbObra.EditValue.ToString()
                                + " Ot " + cmbOrdenTaller.Text; 
                    Movi_I.Secuencia = sec;

                    ListaDetalleCusCidersus.ForEach(var => { if (var.IdProducto == item.IdProducto) { var.mv_Secuencia = sec; } });
                    movi_det.Add(Movi_I);
                    sec++;
                }

                in_movi_inve_detalle_x_Producto_CusCider_Bus BusCuscide = new in_movi_inve_detalle_x_Producto_CusCider_Bus();

                MoviCab_I.listmovi_inve_detalle_Info = movi_det;

                BusMovi.GrabarDB(MoviCab_I, ref id,ref mensaje_cbte_cble, ref Men);
                ListaDetalleCusCidersus.ForEach(var => var.IdNumMovi = id);

                prd_conversion_cusCidersus_x_in_movi_inven_Info InfoInte = new prd_conversion_cusCidersus_x_in_movi_inven_Info();
                InfoInte.IdBodega = MoviCab_I.IdBodega;
                InfoInte.IdEmpresa = param.IdEmpresa;
                InfoInte.IdMovi_inven_tipo = Convert.ToInt32(_Parametros_Info.IdMovi_inven_tipo_ingxresid_Conversion);
                InfoInte.IdSucursal = MoviCab_I.IdSucursal;
                InfoInte.IdNumMovi = id;
                ListaTablaIntermedia.Add(InfoInte);

                if (BusCuscide.GuardarDB(ListaDetalleCusCidersus, ref Men))
                {
                }
                else
                {
                    MessageBox.Show(Men);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
                MessageBox.Show(ex.ToString());
            }

        }

      
        private void FrmPrd_ConversionProducto_Load(object sender, EventArgs e)
        {
            try
            {
               switch (_Accion)
                {
                    case Cl_Enumeradores.eTipo_action.grabar:
                        
                        btnGuardar.Text = "Guardar";

                        ctrl_Suc_Bod.cmb_sucursal.EditValue = _Parametros_Info.IdSucursal_Produccion;
                        ctrl_Suc_Bod.cmb_bodega.EditValue = _Parametros_Info.IdBodega_Produccion;
               

                        break;
                    case Cl_Enumeradores.eTipo_action.actualizar:
                        Set();
                      
                        btnGuardar.Text = "Actualizar ";
                        break;
                    case Cl_Enumeradores.eTipo_action.Anular:
                        Set();
                        btnGuardar.Enabled = false;
                      
                        break;
                    case Cl_Enumeradores.eTipo_action.consultar:
                        Set();
                        btnGuardar.Enabled = false;
                      
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
        
        public prd_Conversion_CusCidersus_Info _SetInfo { get; set; }
        void Set() 
        {

            try
            {
                txtIdNumRegistro.Text = _SetInfo.IdConversion.ToString();
                dtpFecha.EditValue = _SetInfo.Fecha;
                txtObserva.Text = _SetInfo.Observacion;
                cmbObra.EditValue = _SetInfo.CodObra;
                cmbOrdenTaller.EditValue = _SetInfo.IdOrdenTaller;
                txtProduct.Text = _SetInfo.NomProducto;
                txtProduct.Visible = true;
                
                cmbProducto.Enabled = false;
                txtCodigoBarra.Text = _SetInfo.CodBarraProducto;
                ctrl_Suc_Bod.cmb_bodega.EditValue = _SetInfo.IdBodega;
                ctrl_Suc_Bod.cmb_sucursal.EditValue = _SetInfo.IdSucursal;
                cmbEtapa.EditValue = _SetInfo.IdEtapa;
                cmbGT.EditValue = _SetInfo.IdGrupoTrabajo;
                funcionreadonlygrid();
                if (_SetInfo.Estado == "I")
                {
                    lbl_Estado.Visible = true;
                  
                    btnGuardar.Enabled = false;
                }

                prd_Conversion_det_CusCidersus_Bus busDet = new prd_Conversion_det_CusCidersus_Bus();

                var Consulta = busDet.Counsultar(param.IdEmpresa, _SetInfo.IdConversion);
                List<in_Producto_Info> temp = new List<in_Producto_Info>();
                var Unos = Consulta.FindAll(v => v.TipoPro.Trim() == "Res");
                foreach (var item in Unos)
                {
                    in_Producto_Info obj = new in_Producto_Info();


                    obj.pr_alto = item.pr_alto;
                    obj.pr_largo = item.pr_largo;
                    obj.CodBarra = item.CodBarra;
                    obj.pr_descripcion = item.pr_descripcion;
                    obj.pr_observacion = item.Observacion;
                    temp.Add(obj);


                }
                //gridControlResiduo.DataSource = temp;
                BindLstRes = new BindingList<in_Producto_Info>();
                BindLstRes = new BindingList<in_Producto_Info>(temp);
                gridControlResiduo.DataSource = BindLstEle;
                temp = new List<in_Producto_Info>();
                var Uno = Consulta.FindAll(v => v.TipoPro.Trim() == "Fin");
                foreach (var item in Uno)
                {
                    in_Producto_Info obj = new in_Producto_Info();


                    obj.pr_alto = item.pr_alto;
                    obj.pr_largo = item.pr_largo;
                    obj.CodBarra = item.CodBarra;
                    obj.pr_descripcion = item.pr_descripcion;
                    obj.pr_observacion = item.Observacion;
                    temp.Add(obj);


                }
                
                //gridControlFinal.DataSource = temp;
                BindLstEle = new BindingList<in_Producto_Info>();
                BindLstEle = new BindingList<in_Producto_Info>(temp);
                gridControlFinal.DataSource = BindLstEle;

                var Movimientos = BusInve.ConsultaMovimienosxConversion( _SetInfo.IdEmpresa,
                    _SetInfo.IdConversion, ref msgs);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

                
                MessageBox.Show(ex.ToString());
            }
        
        }

        string msgs = "";
        in_movi_inve_detalle_x_Producto_CusCider_Bus BusInve = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        

        Boolean Validar() 
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigoBarra.Text)) 
                {
                    MessageBox.Show("Ingrese Codigo Barra");
                    return false;
                }
                if (string.IsNullOrEmpty(txtObserva.Text)) 
                {
                    MessageBox.Show("Ingrese Observacion");
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
                if ((cmbProducto.EditValue==null)) 
                {
                    MessageBox.Show("Por Favor Seleccione Producto");
                    return false;
                } 
                if (string.IsNullOrEmpty(cmbEtapa.Text))
                {
                    MessageBox.Show("Por Favor Seleccionar la Etapa");
                    return false;
                }


                int x = 0;
                for (int i = 0; i < gridViewFinal.RowCount; i++)
                {
                    in_Producto_Info Info = (in_Producto_Info)gridViewFinal.GetRow(i);
                    if (Info != null)
                    {
                        x++;
                        if (Info.pr_largo == 0) 
                        {
                            MessageBox.Show("Por Favor Ingrese largo");
                            return false;
                        }
                        if (string.IsNullOrEmpty(Info.CodBarra)) 
                        {
                            MessageBox.Show("Por Favor Ingrese Codigo de Barra");
                            return false;
                        }
                        if(string.IsNullOrEmpty(Info.pr_descripcion))
                        {
                            MessageBox.Show("Por Favor Ingrese Descripcion");
                            return false;
                        }
                    }
                }
                if (x == 0) 
                {
                    MessageBox.Show("Por Favor Ingrese Al menos un producto");
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

        private void txtProduct_EditValueChanged(object sender, EventArgs e){}

        void funcionreadonlygrid()
        {
            try
            {
                _Largo.OptionsColumn.ReadOnly = true;
                _Ancho.OptionsColumn.ReadOnly = true;
                colCodBarra.OptionsColumn.ReadOnly = true;
                Descripcion.OptionsColumn.ReadOnly = true;
                colpr_observacion.OptionsColumn.ReadOnly = true;

                Col_Largo.OptionsColumn.ReadOnly = true  ;
                Col_Alto.OptionsColumn.ReadOnly = true;
                Descripcion.OptionsColumn.ReadOnly = true;
                gridColumn10.OptionsColumn.ReadOnly = true;
                colBarra2.OptionsColumn.ReadOnly = true;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }
        void funcionactivargrid()
        {

            try
            {
                _Largo.OptionsColumn.ReadOnly = false ;
                _Ancho.OptionsColumn.ReadOnly = false ;
                col_descripcion.OptionsColumn.ReadOnly = false;
                colpr_observacion.OptionsColumn.ReadOnly = false ;

                Col_Largo.OptionsColumn.ReadOnly = false;
                Col_Alto.OptionsColumn.ReadOnly = false;
                Descripcion.OptionsColumn.ReadOnly = false;
                gridColumn10.OptionsColumn.ReadOnly = false;
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
                gridViewFinal.SelectAll();
                gridViewFinal.DeleteSelectedRows();
                gridViewResiduo.SelectAll();
                gridViewResiduo.DeleteSelectedRows();
                funcionreadonlygrid();
                cmbProducto.EditValue = 0;
                
                
                List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info> listprod = new List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>();
                listprod = (List<vwin_movi_inve_detalle_x_Producto_CusCider_Saldos_Info>)gridView2.DataSource;
                //if(listprod != null)
                foreach (var item in listprod)
                {

                    if (txtCodigoBarra.EditValue.ToString() == item.CodigoBarra.ToString())
                    {   cmbProducto.EditValue = item.IdProducto;
                        funcionactivargrid();
                    
                    }

                }
                

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

            


        }
        prd_EtapaProduccion_Info Etapa = new prd_EtapaProduccion_Info();
        private void cmbEtapa_EditValueChanged(object sender, EventArgs e){}

        private void gridViewFinal_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridViewFinal.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewResiduo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                    gridViewFinal.DeleteSelectedRows();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        prd_SubGrupoTrabajo_Info Grupo = new prd_SubGrupoTrabajo_Info();
        private void cmbGT_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Grupo = new prd_SubGrupoTrabajo_Info();
                Grupo = (prd_SubGrupoTrabajo_Info)gridViewGT.GetFocusedRow();
                cmbEtapa.EditValue = Grupo.IdEtapa;
                Etapa = new prd_EtapaProduccion_Info();
                Etapa = Etapa_B.ObtenerEtapa(param.IdEmpresa, Grupo.IdEtapa, Obra.IdProcesoProductivo);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        
    }
}

