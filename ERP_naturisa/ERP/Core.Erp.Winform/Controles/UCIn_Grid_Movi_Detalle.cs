using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Winform.Inventario;

namespace Core.Erp.Winform.Controles
{
    public partial class UCIn_Grid_Movi_Detalle : UserControl
    {
        #region Declaracion de funciones

        in_Producto_Info Item;

                public enum eTipoMovi
                {
                    Ingreso = 1,
                    Egreso = 2
                }
                
                public Boolean VisiblePeso { get; set; }
                public Boolean VisibleStock { get; set; }
                public Boolean VisibleStockAnterior { get; set; }
                public Boolean VisibleCosto { get; set; }
                public Boolean VisibleCodigo { get; set; }
                public int idBodega { get; set; }
                public int idSucursal { get; set; }
                public eTipoMovi _tipomovi { get; set; }
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                List<in_Producto_Info> Lista_producto = new List<in_Producto_Info>();
                in_producto_Bus bus_producto = new in_producto_Bus();
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                in_producto_Bus _ProductoBus = new in_producto_Bus();
                in_Producto_Info Productoinfo = new in_Producto_Info();
                public Boolean ValidaStock = false;


                BindingList<in_Producto_Info> BindListProducto;
        
        #endregion
        

        public UCIn_Grid_Movi_Detalle()
        {
            try
            {
                InitializeComponent();
                
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
           
        }
        
        public void tipomoviser(eTipoMovi tip)
        {
            try
            {
                _tipomovi = tip; 
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void load_Producto()
        {
            try
            {
                Lista_producto = _ProductoBus.Get_list_Producto(param.IdEmpresa, idSucursal, idBodega);


                foreach (var item in Lista_producto)
                {
                    item.Disponible = item.pr_stock_Bodega == null ? 0 : Convert.ToDouble(item.pr_stock_Bodega) - item.pr_pedidos == null ? 0 : Convert.ToDouble(item.pr_pedidos);
                }

                this.cmbProducto_grid.DataSource = Lista_producto;
                this.cmbProducto_grid.DisplayMember = "pr_descripcion";
                this.cmbProducto_grid.ValueMember = "IdProducto";

                  

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void UCInv_grid_movi_detalle_Load(object sender, EventArgs e)
        {
            try
            {
                BindListProducto = new BindingList<in_Producto_Info>();
                gridControlProductos.DataSource = BindListProducto;

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());

            }
        }

        private Boolean Existe_Stock_Producto_Bodega(string cod_producto, ref string msg, ref double cantidad)
        {
            try
            {
                var q = from A in Lista_producto
                        where A.pr_codigo.Contains(cod_producto.Trim())
                        select A;
                if (q.ToList().Count > 0)
                {
                    foreach (var item in q)
                    {
                        cantidad = item.pr_stock_Bodega == null ? 0 : Convert.ToDouble(item.pr_stock_Bodega);
                    }
                    msg = "Stock disponible: " + cantidad.ToString();


                    return true;
                }
                else
                {
                    msg = "No existe la cantidad suficiente en stock";
                    return false;
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return false;
            }
        }

        public List<in_movi_inve_detalle_Info> get_DatosGrid()
        {
            List<in_movi_inve_detalle_Info> lss = new List<in_movi_inve_detalle_Info>();

            try
            {

                foreach (var item in BindListProducto)
                {
                    in_movi_inve_detalle_Info moviInfo = new in_movi_inve_detalle_Info();
                    moviInfo.IdEmpresa = param.IdEmpresa;
                    moviInfo.IdProducto = item.IdProducto;
                    moviInfo.dm_cantidad = item.do_Cantidad;
                    moviInfo.peso = item.pr_peso;
                    moviInfo.dm_observacion = item.pr_observacion;
                    moviInfo.mv_costo = item.pr_costo_promedio;

                    lss.Add(moviInfo);
                    
                }
                               
               
                return lss;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
                return new List<in_movi_inve_detalle_Info>();
            }
        }

        public void set_Datosgrid(List<in_movi_inve_detalle_Info> dats)
        {
            try
            {
                List<in_Producto_Info> lista = new List<in_Producto_Info>();
               
                
                foreach (var item in dats)
                {
                    in_Producto_Info info = new in_Producto_Info();

                    info.IdProducto = item.IdProducto;                  
                    info.do_Cantidad = item.dm_cantidad;
                    info.pr_peso = item.pr_peso;
                    info.pr_observacion = item.dm_observacion;
                    info.pr_codigo = Lista_producto.FirstOrDefault(v => v.IdProducto == item.IdProducto).pr_codigo;
                    info.pr_stock_Bodega = Lista_producto.FirstOrDefault(v => v.IdProducto == item.IdProducto).Disponible;
                    lista.Add(info);

                }

                BindListProducto = new BindingList<in_Producto_Info>(lista);
                gridControlProductos.DataSource = BindListProducto;
                                                           
            
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }

        }

        public void set_Datosgrid(in_Producto_Info tmp)
        {
            try
            {
              decimal id = tmp.IdProducto;
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewProductos_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Name == "colIdProducto")
                { 
              
                  Item = Lista_producto.FirstOrDefault(v => v.IdProducto == Convert.ToDecimal(e.Value));
                  gridViewProductos.SetFocusedRowCellValue(this.colpr_codigo, Item.pr_codigo);
                  gridViewProductos.SetFocusedRowCellValue(this.colpr_peso, Item.pr_peso);                
                  gridViewProductos.SetFocusedRowCellValue(this.coldo_Cantidad, 0);
                  gridViewProductos.SetFocusedRowCellValue(this.colpr_stock, Item.pr_stock_Bodega);
                  gridViewProductos.SetFocusedRowCellValue(this.colpr_observacion, "");
                  gridViewProductos.SetFocusedRowCellValue(this.colpr_costo_promedio, Item.pr_costo_promedio);
                
                }

                if (e.Column.Name == "coldo_Cantidad")
                {

                    if (Convert.ToDouble(gridViewProductos.GetFocusedRowCellValue(coldo_Cantidad)) < 0)
                    {
                        MessageBox.Show("La cantidad no admite valores negativos", "SISTEMAS");

                        gridViewProductos.SetFocusedRowCellValue(this.coldo_Cantidad, 0);
                        return;
                    }

                    if (Convert.ToDouble(gridViewProductos.GetFocusedRowCellValue(colpr_stock)) < 0)
                    {                      
                      return;
                    }


                    if (Convert.ToDouble(gridViewProductos.GetFocusedRowCellValue(coldo_Cantidad)) > Convert.ToDouble(gridViewProductos.GetFocusedRowCellValue(colpr_stock)))
                    {
                        if (_tipomovi == eTipoMovi.Egreso)
                        {
                            MessageBox.Show("La cantidad de productos supera al stock actual", "SISTEMAS");

                            gridViewProductos.SetFocusedRowCellValue(this.coldo_Cantidad, 0);
                            return;
                        }
                    }                                                                                                                                  
                }
            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridViewProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (MessageBox.Show("¿Está seguro que desea Eliminar este registro ?", "Elimina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridViewProductos.DeleteSelectedRows();
                    }
                }

            }
            catch (Exception ex)
            {
                string NameMetodo = System.Reflection.MethodBase.GetCurrentMethod().Name;
                MessageBox.Show(NameMetodo + " - " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log_Error_bus.Log_Error(NameMetodo + " - " + ex.ToString());
            }
        }

        private void gridControlProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
