using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Producto_x_Proveedor : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Bus Proveedores_B = new cp_proveedor_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public FrmIn_Producto_x_Proveedor()
        {
            try
            {
                InitializeComponent();
                cmbProveedor.Properties.DataSource = Proveedores_B.Get_List_proveedor(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
           
         
        }
        BindingList<in_Producto_Info> Producto = new BindingList<in_Producto_Info>();
        BindingList<in_Producto_Info> ProductoXProveedor = new BindingList<in_Producto_Info>();
        in_producto_Bus Produ_B = new in_producto_Bus();
        string mensaje = "";
        private void cmbProveedor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Producto = new BindingList<in_Producto_Info>(Produ_B.Get_Productos_X_Proveedor(param.IdEmpresa, Convert.ToDecimal(cmbProveedor.EditValue),param.IdEmpresa,"not"));
                ProductoXProveedor = new BindingList<in_Producto_Info>(Produ_B.Get_Productos_X_Proveedor(param.IdEmpresa, Convert.ToDecimal(cmbProveedor.EditValue), param.IdEmpresa));
                gridControlProducto.DataSource = Producto;
                gridControlProductoXPRoveedor.DataSource = ProductoXProveedor;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }

        }
        in_producto_x_cp_proveedor_Bus ProducXProvee = new in_producto_x_cp_proveedor_Bus();
        private void btnDerechaç_Click(object sender, EventArgs e)
        {
            try
            {
             in_Producto_Info Item = (in_Producto_Info)gridViewProducto.GetFocusedRow(); ;
                if (Item != null)
                {
                    if(ProductoXProveedor.Count(v=>v.IdProducto == Item.IdProducto) != 0)
                    return;
                    
                    ProductoXProveedor.Add(Item);
                    in_producto_x_cp_proveedor_Info obj = new in_producto_x_cp_proveedor_Info();
                    obj.IdEmpresa_prod = param.IdEmpresa;
                    obj.IdEmpresa_prov = param.IdEmpresa;
                    obj.IdProducto = Item.IdProducto;
                    obj.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                    obj.NomProducto_en_Proveedor = "";

                    ProducXProvee.Grabar_Producto_Proveedor(obj, param.IdEmpresa, Item.IdProducto,ref mensaje);
                    

                    Producto.Remove(Item);
                    gridControlProducto.RefreshDataSource();
                    gridControlProductoXPRoveedor.RefreshDataSource();
                }
                //int[] Rows = gridViewProducto.GetSelectedRows();
                //foreach (var item in Rows)
                //{
                //    gridViewProducto.FocusedRowHandle = item;
                //    in_Producto_Info Item = (in_Producto_Info)gridViewProducto.GetFocusedRow();
                //    if (Item != null)
                //    {
                //        ProductoXProveedor.Add(Item);
                //    }
                //}
                //foreach (var item in Rows)
                //{
                //    //gridViewProducto.FocusedRowHandle = item;
                //    in_Producto_Info Item = (in_Producto_Info)gridViewProducto.GetRow(item);
                //    if (Item != null)
                //    {
                //        Producto.Remove(Item);
                //    }
                //}
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void btnDerechaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var Item in Producto)
                {
                    ProductoXProveedor.Add(Item);
                    in_producto_x_cp_proveedor_Info obj = new in_producto_x_cp_proveedor_Info();
                    obj.IdEmpresa_prod = param.IdEmpresa;
                    obj.IdEmpresa_prov = param.IdEmpresa;
                    obj.IdProducto = Item.IdProducto;
                    obj.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                    obj.NomProducto_en_Proveedor = "";

                    ProducXProvee.Grabar_Producto_Proveedor(obj, param.IdEmpresa, Item.IdProducto, ref mensaje);
                }
                Producto.Clear();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void btnIzquierdaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ProductoXProveedor)
                {
                    Producto.Add(item);
                    in_producto_x_cp_proveedor_Info obj = new in_producto_x_cp_proveedor_Info();
                    obj.IdEmpresa_prod = param.IdEmpresa;
                    obj.IdEmpresa_prov = param.IdEmpresa;
                    obj.IdProducto = item.IdProducto;
                    obj.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                    obj.NomProducto_en_Proveedor = "";

                    ProducXProvee.eliminarregistrotablaUno(obj, param.IdEmpresa, item.IdProducto, ref mensaje);


                }
                cmbProveedor_EditValueChanged(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
             { 
                in_Producto_Info Item = (in_Producto_Info)gridViewProdXProveedor.GetFocusedRow(); ;
                        if (Item != null)
                        {
                            if (Producto.Count(v => v.IdProducto == Item.IdProducto) != 0)
                                return;
                    
                            Producto.Add(Item);

                            in_producto_x_cp_proveedor_Info obj = new in_producto_x_cp_proveedor_Info();
                            obj.IdEmpresa_prod = param.IdEmpresa;
                            obj.IdEmpresa_prov = param.IdEmpresa;
                            obj.IdProducto = Item.IdProducto;
                            obj.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                            obj.NomProducto_en_Proveedor = "";

                            ProducXProvee.eliminarregistrotablaUno(obj, param.IdEmpresa, Item.IdProducto, ref mensaje);


                            ProductoXProveedor.Remove(Item);
                            gridControlProducto.RefreshDataSource();
                            gridControlProductoXPRoveedor.RefreshDataSource();
                        }         

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
            
        }

        private void gridViewProdXProveedor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                in_Producto_Info Item = (in_Producto_Info)gridViewProdXProveedor.GetRow(e.PrevFocusedRowHandle);
                in_producto_x_cp_proveedor_Info obj = new in_producto_x_cp_proveedor_Info();
                obj.IdEmpresa_prod = param.IdEmpresa;
                obj.IdEmpresa_prov = param.IdEmpresa;
                obj.IdProducto = Item.IdProducto;
                obj.IdProveedor = Convert.ToDecimal(cmbProveedor.EditValue);
                obj.NomProducto_en_Proveedor = Item.pr_descripcion;

                ProducXProvee.ModificarDB(obj, ref mensaje);
                
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

        private void panelControl3_Paint(object sender, PaintEventArgs e){}

        private void FrmIn_Producto_x_Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 191
/// </summary>