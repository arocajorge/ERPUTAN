using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Inventario;

using Core.Erp.Info.General;
//Roberto
//
namespace Core.Erp.Winform.Controles
{
    public partial class UCFa_GridFactura : UserControl
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        fa_parametro_Bus parametros = new fa_parametro_Bus();
        fa_parametro_info parametros_Info = new fa_parametro_info();
        in_Parametro_Bus in_param_B = new in_Parametro_Bus();
        in_Parametro_Info in_param_I = new in_Parametro_Info();
        public BindingList<fa_factura_det_info> DataSource;//= new BindingList<fa_producto_info>();
        in_producto_Bus _ProductoBus = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<in_Producto_Info> Lista_producto;// = new List<fa_producto_info>();
        public List<in_Producto_Info> lstPro_x_Bodega { get; set; }
        in_Producto_Info Item;
        Boolean _ValidaStock = true;
        Boolean Valida = true;
        public delegate void delegate_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e);
        public event delegate_ultraGrid_AfterCellUpdate Event_ultraGrid_AfterCellUpdate;
        public delegate void delegate_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e);
        public event delegate_ultraGrid_ClickCell Event_ultraGrid_ClickCell;
        List<fa_factura_det_info> listTabla = new List<fa_factura_det_info>();
        public delegate void Delegate_ultraGrid_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e);
        public event Delegate_ultraGrid_PreviewKeyDown Evente_ultraGrid_PreviewKeyDown;
        public delegate void delegate_gridView_KeyDown(KeyEventArgs e);
        public event delegate_gridView_KeyDown event_gridView_KeyDown;

        #endregion


        public Boolean VisibleDescuento
        {
            get { return colDescuento.Visible; }
            set { colDescuento.Visible = value; } 
        }

        public Boolean VisibleStock
        { 
            get { return colStock.Visible; } 
            set { colStock.Visible = value; } 
        }

        public Boolean VisiblePorcDescuento
        {
            get { return colDescuento.Visible; }
            set { colDescuento.Visible = value; }
        }

        public Boolean VisiblePeso
        {
            get { return colPeso.Visible; }
            set { colPeso.Visible = value; }
        }

        public Boolean VisibleCosto
        {
            get { return colCosto.Visible; }
            set { colCosto.Visible = value; }
        }

        public Boolean VisibleIdPunto_Cargo
        {
            get { return colIdPunto_Cargo.Visible; }
            set { colIdPunto_Cargo.Visible = value; }
        }

        public Boolean VisiblePrecio_Iva
        {
            get { return colPrecio_Iva.Visible; }
            set { colPrecio_Iva.Visible = value; }
        }
      
        public Boolean ValidaStock 
        { get{return _ValidaStock; }
            set{_ValidaStock =value;}
        }

        public void ocultarIva()
        {
            try
            {
               colPaga_Iva.Visible = false;
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        public Boolean Inhabilitar_col_Stock 
        {
            get { return this.colStock.OptionsColumn.AllowEdit; }
            set { this.colStock.OptionsColumn.AllowEdit = value; }
        
        }

        public Boolean Inhabilitar_col_Peso
        {
            get { return this.colPeso.OptionsColumn.AllowEdit; }
            set { this.colPeso.OptionsColumn.AllowEdit = value; }

        }
        
        public UCFa_GridFactura()
        {
            try
            {
                InitializeComponent();
                Event_ultraGrid_ClickCell += GridFacturaDevExpres_Event_ultraGrid_ClickCell;
                Event_ultraGrid_AfterCellUpdate += GridFacturaDevExpres_Event_ultraGrid_AfterCellUpdate;
                event_gridView_KeyDown += GridFacturaDevExpres_event_gridView_KeyDown;
                cmbProductoCodigo.EditValueChanging += cmbProductoCodigo_EditValueChanging;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }           
        }

        public UCFa_GridFactura(Boolean _VisibleDescuento, Boolean _VisiblePorcDescuento, Boolean _VisiblePeso, Boolean _ValidaStock, Boolean _VisibleCosto, Boolean _VisibleStock)
            : this()
        {
            try
            {
                VisibleStock = _VisibleStock;
                VisibleDescuento = _VisibleDescuento;
                VisiblePorcDescuento = _VisiblePorcDescuento;
                VisiblePeso = _VisiblePeso;
                ValidaStock = _ValidaStock;
                VisibleCosto = _VisibleCosto;

                colStock.Visible = _VisibleStock;
                colDescuento.Visible = _VisibleDescuento;
                colPorc_Descuento.Visible = _VisiblePorcDescuento;
                colPeso.Visible = _VisiblePeso;
                colCosto.Visible = false;
                colCosto_Promedio.Visible = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }



        }

        void GridFacturaDevExpres_Event_ultraGrid_AfterCellUpdate(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}

        void GridFacturaDevExpres_Event_ultraGrid_ClickCell(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e){}

        void cmbProductoCodigo_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                           
                //if (TipoCarga == Cl_Enumeradores.eTipo_action.grabar)
                //{                   
                    //original 23/05/2014
                    if (Valida == true)
                    {
                       

                        Item = Lista_producto.First(v => v.IdProducto == Convert.ToDecimal(e.NewValue));
                        gridView.SetFocusedRowCellValue(colIdProducto, Item.IdProducto);
                        gridView.SetFocusedRowCellValue(colPaga_Iva, (Item.pr_ManejaIva=="S")?true:false );
                        gridView.SetFocusedRowCellValue(colPrecio, Item.pr_precio_publico );
                        gridView.SetFocusedRowCellValue(colPeso, Item.pr_peso);
                        gridView.SetFocusedRowCellValue(colCosto, Item.pr_costo_promedio);
                        gridView.SetFocusedRowCellValue(colPaga_Iva, (Item.pr_ManejaIva=="S")?true:false );
                        gridView.SetFocusedRowCellValue(colStock, Item.pr_stock );
                        gridView.SetFocusedRowCellValue(colIdCtaCble_Ven0, Item.IdCtaCble_Ven0);
                        gridView.SetFocusedRowCellValue(colIdCtaCble_VenIva, Item.IdCtaCble_VenIva);
                    }
                    else { Valida = true; }



            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }      

        }
            
        public void load_Producto(int idempresa, int IdSucursal, int IdBodega) 
        {
            try
            {
                Lista_producto = _ProductoBus.Get_list_Producto(idempresa, IdSucursal,IdBodega); 
                  foreach (var item in Lista_producto)
                  {
                      item.Disponible = item.pr_stock == null ? 0 : Convert.ToDouble(item.pr_stock) - item.pr_pedidos == null ? 0 : Convert.ToDouble(item.pr_pedidos);
                      
                  }

                  lstPro_x_Bodega = Lista_producto;
                cmbProductoCodigo.DataSource = Lista_producto;
            

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }


        private List<fa_catalogo_Info> lstNaturaleza()
        {
            try
            {
                List<fa_catalogo_Info> lstInfo = new List<fa_catalogo_Info>();
                fa_catalogo_Info Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_TODO.ToString(); 
                lstInfo.Add(Info);

                Info = new fa_catalogo_Info();
                Info.IdCatalogo = Cl_Enumeradores.eTipoNaturalezaProducto.PRD_X_VENT.ToString();
                lstInfo.Add(Info);

                return lstInfo;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   

                return new List<fa_catalogo_Info>();
            }
        }

        void CalcularIva() 
        {
            try
            {
                            
                foreach (var item in DataSource)
                {               
                        if (in_param_I.Maneja_Stock_Negativo == "N")
                        {

                            if (item.IdProducto > 0)
                            {
                                var ItemProd_Busc = Lista_producto.First(v => v.IdProducto == item.IdProducto);

                                if (_ValidaStock == true)
                                {
                                    if (item.vt_cantidad > ItemProd_Busc.pr_stock)
                                    {
                                        MessageBox.Show("La cantidad Supera Al Stock");
                                        item.vt_cantidad = item.stock;
                                    }
                                }

                                if (item.vt_cantidad < 0)
                                {
                                    item.vt_cantidad = item.vt_cantidad * -1;
                                }
                              
                            }                      
                    }

                        item.vt_DescUnitario = Math.Round((item.vt_PorDescUnitario * (item.vt_Precio * item.vt_cantidad)) / 100, 2);
                        item.vt_PrecioFinal = Math.Round(((item.vt_Precio * item.vt_cantidad) - item.vt_DescUnitario), 2);
                    item.vt_Subtotal = Math.Round((item.vt_PrecioFinal), 2);
                   
                   
                    //if (item.vt_tieneIVA == true)
                    //{
                    //    item.vt_iva = ((item.vt_Subtotal) * param.iva) / 100;
                    //}
                    //else
                    //{
                    //    item.vt_iva = 0;
                    //}

                    item.vt_total = Math.Round((item.vt_Subtotal + item.vt_iva), 2);
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        void Calcular()
        {
            try
            {
                CalcularIva();

              gridControl.RefreshDataSource();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }
        
        private void gridControl1_Click(object sender, EventArgs e){}
      
        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                double Descuento = 0;
                double ValorProd = 0;
                double PorDescuento = 0;

                ValorProd = Math.Round((Convert.ToDouble(gridView.GetFocusedRowCellValue(colCantidad)) * Convert.ToDouble(gridView.GetFocusedRowCellValue(colPrecio))),2);
                if (e.Column.Caption == "Descuento")
                {
                    Descuento = Math.Abs(Convert.ToDouble(e.Value));
                    PorDescuento = (Descuento / ValorProd) * 100;
                    gridView.SetFocusedRowCellValue(colPorc_Descuento, Math.Round(PorDescuento, 2));               
                }

                

                Calcular();
                if (e.Column.Caption == "Cantidad") 
                {
                    //gridView.SetFocusedRowCellValue(colCantidad, Math.Abs(Convert.ToDouble(e.Value)));                
                }         

                Event_ultraGrid_AfterCellUpdate(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }

        }
          
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            try
            {
                if (e.Column.Caption == "  IVA") 
                    {
                        if (gridView.OptionsBehavior.Editable == true)
                        {
                            if (Convert.ToBoolean(gridView.GetFocusedValue()))
                            {
                                gridView.SetFocusedValue(false);
                            }
                            else
                            {
                                gridView.SetFocusedValue(true);
                            }
                            CalcularIva();

                            gridControl.RefreshDataSource();
                        }
                    }

         
                    Event_ultraGrid_ClickCell(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        }

        public void set_grid_detalle(List<fa_factura_det_info> lm)
        {
            try
            {
                             

                //colCodigo_Producto.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
                colSecuencia.SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
            
           

        }
       

        public List<fa_factura_det_info> get_Tabla_detalle()
        {
            try
            {   
                

                return DataSource.ToList();
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                return new List<fa_factura_det_info>();
            }

        }
       
        public void BloquearGrid()
        {
            try
            {
              gridView.OptionsBehavior.Editable = false;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }           
        }

        public void Clear_Ugrid()
        {
            try
            {
                if (DataSource != null)
                { DataSource.Clear();  }

                for (int i = 0; i < parametros_Info.NumeroDeItemFact; i++)
                {
                    fa_factura_det_info Var = new fa_factura_det_info();
                  //  Var.Secuencia = i+1;
                    DataSource.Add(Var);
                }

                gridControl.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
                
            }

            
        }
          
        private void gridControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            try
            {
                Calcular();

                    Evente_ultraGrid_PreviewKeyDown(sender, e);
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
            
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
      
      
       
        private void GridFacturaDevExpres_Load(object sender, EventArgs e)
        {
            try
            {
                DataSource = new BindingList<fa_factura_det_info>();
                in_param_I = in_param_B.Get_Info_Parametro(param.IdEmpresa);
                parametros_Info = parametros.Get_Info_parametro(param.IdEmpresa);
                for (int i = 0; i < parametros_Info.NumeroDeItemFact; i++)
                {
                    DataSource.Add(new fa_factura_det_info());
                }
                gridControl.DataSource = DataSource;


               
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
  }

        void GridFacturaDevExpres_event_gridView_KeyDown(KeyEventArgs e){}

        public void carga_Grid(List<fa_factura_det_info> list) //haac 29052014
        {
            try
            {            
                DataSource = new BindingList<fa_factura_det_info>(list);
                gridControl.DataSource = DataSource;
                           
            }
            catch (Exception ex)
            {

                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());   
            }
        
        
        }
                 
    }
}

