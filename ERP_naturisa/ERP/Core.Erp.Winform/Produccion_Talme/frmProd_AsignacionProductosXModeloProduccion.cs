using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.Produccion_Talme;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_AsignacionProductosXModeloProduccion : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        prod_ModeloProduccion_CusTalme_Bus ModeloProduccion_B = new prod_ModeloProduccion_CusTalme_Bus();
        in_producto_Bus Prod_B = new in_producto_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<in_Producto_Info> Prod = new BindingList<in_Producto_Info>();
        prod_ModeloProduccion_x_Producto_CusTal_Bus Bus = new prod_ModeloProduccion_x_Producto_CusTal_Bus();
        public frmProd_AsignacionProductosXModeloProduccion()
        {
            try
            {
                InitializeComponent();
                CmbModeloProduccion.Properties.DataSource = ModeloProduccion_B.ConsultaGeneral();
                var ListProductos = Prod_B.Get_list_Producto(param.IdEmpresa);
                repositoryItemSearchLookUpEdit1.DataSource = ListProductos;
                repositoryItemSearchLookUpEdit2.DataSource = ListProductos;
                gridControl.DataSource = Prod;
                gridControlProductoMateriaPrima.DataSource = Grid;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());   
            }
        }
        int IdModeloProduccion = 0;
        Boolean Bander = true;
        private void cmbModeloProduccion_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (Bander == false) { Bander = true; return; ; }
                if (MessageBox.Show("Si Cambia El modelo de produccion y no ha guardado los cambios realizados se perderan,  ¿Esta Seguro de cambiar el Modelo de produccion?", "ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                {
                    
                    gridView.OptionsSelection.MultiSelect = true;
                    gridView.SelectAll();
                    gridView.DeleteSelectedRows();
                    gridView.OptionsSelection.MultiSelect = false;

                    gridViewProductoMateriaPrima.OptionsSelection.MultiSelect = true;
                    gridViewProductoMateriaPrima.SelectAll();
                    gridViewProductoMateriaPrima.DeleteSelectedRows();
                    gridViewProductoMateriaPrima.OptionsSelection.MultiSelect = false;

                    if (CmbModeloProduccion.EditValue != null)
                    {
                        IdModeloProduccion = Convert.ToInt32(CmbModeloProduccion.EditValue);
                        var cons = Bus.ConsultarXModeloDeProduccion(param.IdEmpresa, Convert.ToInt32(CmbModeloProduccion.EditValue));
                        var Prodc = Prod_B.Get_list_ProductosXModeloProduccio(param.IdEmpresa, Convert.ToInt32(CmbModeloProduccion.EditValue));
                        foreach (var item in cons)
                        {
                            try
                            {
                                var I = Prodc.First(v => v.IdProducto == item.IdProducto && item.Tipo == "MATPRIMA");
                                Grid.Add(I);
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());  
                            }
                            try
                            {
                                var S = Prodc.First(v => v.IdProducto == item.IdProducto && item.Tipo == "PRODTERMI");
                                Prod.Add(S);
                            }
                            catch (Exception ex)
                            {
                                Log_Error_bus.Log_Error(ex.ToString());  
                            }

                        }

                    }
                }
                else
                {
                    Bander = false;
                    CmbModeloProduccion.EditValue = IdModeloProduccion;
                
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }
        

        BindingList<in_Producto_Info> Grid = new BindingList<in_Producto_Info>();
     
        void Guardar()
        {
            try
            {
                if (Validar() == false)
                    return;
                CmbModeloProduccion.Focus();
                if (CmbModeloProduccion.EditValue != null || CmbModeloProduccion.Text != "[Vacío]")
                {
                    foreach (var item in Grid)
                    {
                        prod_ModeloProduccion_x_Producto_CusTal_Info ItemProd = new prod_ModeloProduccion_x_Producto_CusTal_Info();
                        ItemProd.IdProducto = item.IdProducto;
                        ItemProd.IdEmpresa = param.IdEmpresa;
                        ItemProd.Tipo = "MATPRIMA";
                        ItemProd.IdModeloProd = Convert.ToInt32(CmbModeloProduccion.EditValue);
                        string Men = "";
                        if (Bus.GuardarDB(ItemProd, ref Men))
                        { }
                        else { }
                    }
                    foreach (var item in Prod)
                    {
                        prod_ModeloProduccion_x_Producto_CusTal_Info ItemProd = new prod_ModeloProduccion_x_Producto_CusTal_Info();
                        ItemProd.IdProducto = item.IdProducto;
                        ItemProd.IdEmpresa = param.IdEmpresa;
                        ItemProd.Tipo = "PRODTERMI";
                        ItemProd.IdModeloProd = Convert.ToInt32(CmbModeloProduccion.EditValue);
                        string Men = "";
                        if (Bus.GuardarDB(ItemProd, ref Men))
                        { }
                        else { }
                    }
                    MessageBox.Show("Proceso Realizado Con exito");
                }
                else 
                {
                    MessageBox.Show("Por Favor Seleccione Modelo de Produccion");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                   Guardar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }

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

        private void frmProd_AsignacionProductosXModeloProduccion_Load(object sender, EventArgs e){}

        private void gridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                
                var item = ((List<in_Producto_Info>)(repositoryItemSearchLookUpEdit2.DataSource)).First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                Point Posi = Cursor.Position;
                ValidarRepetido(item);
                  
               
                gridView.AddNewRow();
                gridView_RowClick(item, new DevExpress.XtraGrid.Views.Grid.RowClickEventArgs(new DevExpress.Utils.DXMouseEventArgs(System.Windows.Forms.MouseButtons.Right, 1, Posi.X, Posi.Y, 0), e.RowHandle));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
          
        }
        Boolean ValidarRepetido (in_Producto_Info Obj )
        {
            try
            {
                var Items = from q in Prod
                            where q.IdProducto == Obj.IdProducto
                            select q;
                if (Items.Count() == 0)
                {

                    return true;
                }
                else 
                {
                    MessageBox.Show("El Producto ya se encuentra ingresado por favor Ingrese Uno diferente");
                    Prod.Remove(Items.Last());
                    return false;
                }
				
			}
			catch (Exception ex)
			{
                Log_Error_bus.Log_Error(ex.ToString());  
				return false;
			}
        
        }
        Boolean ValidarRepetidoMatPrima(in_Producto_Info Obj)
        {
            try
            {
                var Items = from q in Grid
                            where q.IdProducto == Obj.IdProducto
                            select q;
                if (Items.Count() == 0)
                {

                    return true;
                }
                else
                {
                    MessageBox.Show("El Producto ya se encuentra ingresado por favor Ingrese Uno diferente");
                    Grid.Remove(Items.Last());
                    return false;
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
                return false;
            }

        }
        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                gridView.FocusedRowHandle = e.RowHandle;
                gridView.SetFocusedRowCellValue(pr_codigo1, ((in_Producto_Info)(sender)).pr_codigo);
                gridView.SetFocusedRowCellValue(IdProducto1, ((in_Producto_Info)(sender)).IdProducto);
                EliminarLineasVacias(gridView);


                for (int i = 0; i < gridViewProductoMateriaPrima.RowCount; i++)
                {
                    if (((in_Producto_Info)(gridViewProductoMateriaPrima.GetRow(i))) != null)
                        if (((in_Producto_Info)(gridViewProductoMateriaPrima.GetRow(i))).IdProducto == ((in_Producto_Info)(sender)).IdProducto)
                        {
                            MessageBox.Show("Un producto terminado prima no puede ser asignado a Materia Prima");
                            gridView.DeleteSelectedRows();
                            return;
                        }
                }

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());             
            }
        }

        private void gridViewProductoMateriaPrima_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
            
                var item = ((List<in_Producto_Info>)(repositoryItemSearchLookUpEdit1.DataSource)).First(v => v.IdProducto == Convert.ToDecimal(e.Value));
                ValidarRepetidoMatPrima(item);
                Point Posi = Cursor.Position;
                gridViewProductoMateriaPrima.AddNewRow();
                gridViewProductoMateriaPrima_RowClick(item, new DevExpress.XtraGrid.Views.Grid.RowClickEventArgs(new DevExpress.Utils.DXMouseEventArgs(System.Windows.Forms.MouseButtons.Right, 1, Posi.X, Posi.Y, 0), e.RowHandle));
          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }

        private void gridViewProductoMateriaPrima_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
            try
            {
                gridViewProductoMateriaPrima.FocusedRowHandle = e.RowHandle;
                gridViewProductoMateriaPrima.SetFocusedRowCellValue(pr_codigo, ((in_Producto_Info)(sender)).pr_codigo);
                gridViewProductoMateriaPrima.SetFocusedRowCellValue(IdProducto, ((in_Producto_Info)(sender)).IdProducto);
                EliminarLineasVacias(gridViewProductoMateriaPrima);

                for (int i = 0; i < gridView.RowCount; i++)
                {
                    if (((in_Producto_Info)(gridView.GetRow(i))) != null)
                        if (((in_Producto_Info)(gridView.GetRow(i))).IdProducto == ((in_Producto_Info)(sender)).IdProducto)
                        {
                            MessageBox.Show("Un producto de la materia prima no puede ser asignado a Producto Terminado");
                            gridViewProductoMateriaPrima.DeleteSelectedRows();
                            return;
                        }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        void EliminarLineasVacias(DevExpress.XtraGrid.Views.Grid.GridView View) 
        {

            try
            {
                for (int i = 0; i < View.RowCount; i++)
                {
                    var Item = (in_Producto_Info)View.GetRow(i);
                    if (Item != null)
                        if (Item.IdProducto == 0)
                            View.DeleteRow(i);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

       
        private void gridViewProductoMateriaPrima_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode.ToString() == "Delete")
                {
                    if (Bus.Borrar(param.IdEmpresa, Convert.ToInt32(CmbModeloProduccion.EditValue), Convert.ToDecimal(gridViewProductoMateriaPrima.GetFocusedRowCellValue(colIdProducto))))
                        gridViewProductoMateriaPrima.DeleteSelectedRows();
                    else
                        MessageBox.Show("No se puede Eliminar el productos debido a que tiene movimientos");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

        Boolean Validar()
        {
            try
            {
                if (CmbModeloProduccion.EditValue == null || CmbModeloProduccion.Text == "[Vacío]") 
                {
                    MessageBox.Show("Por Favor seleccionar Modelo de producción");
                    gridViewProductoMateriaPrima.DeleteSelectedRows();
                    gridView.DeleteSelectedRows();

                    return false;
                }
                if (Grid.Count == 0 ) 
                {
                    MessageBox.Show("Por favor ingrese al menos un producto En materia Prima ");
                    return false;
                }

                if (Prod.Count == 0) 
                {
                    MessageBox.Show("Por favor ingrese al menos un producto En Producto Terminado ");
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

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode.ToString() == "Delete")
                {
                    if (Bus.Borrar(param.IdEmpresa, Convert.ToInt32(CmbModeloProduccion.EditValue), Convert.ToDecimal(gridView.GetFocusedRowCellValue(colIdProducto1))))
                        gridView.DeleteSelectedRows();
                    else
                        MessageBox.Show("No se puede Eliminar el productos debido a que tiene movimientos");
                }
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }
        }

        private void gridViewProductoMateriaPrima_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e){}
    }
}
