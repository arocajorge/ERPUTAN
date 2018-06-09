using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProductoXBodega : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus Bus_Sucursal = new tb_Sucursal_Bus();
        tb_Bodega_Bus Bus_Bodega = new tb_Bodega_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus Bus_Product = new in_producto_Bus();
        in_producto_x_tb_bodega_Bus Bus_Prod_X_Bod = new in_producto_x_tb_bodega_Bus();
        List<tb_Bodega_Info> List_Bodegas = new List<tb_Bodega_Info>();
        List<tb_Sucursal_Info> List_Sucursales = new List<tb_Sucursal_Info>();
        BindingList<in_Producto_Info> Productos_no_asignados;
        BindingList<in_Producto_Info> Productos_Asignados_x_Bodega;
        in_Producto_Info Info_Pro = new in_Producto_Info();
        string Mensaje = "";
        public FrmIn_ProductoXBodega()
        {
            try
            {
                InitializeComponent();
                List_Sucursales = Bus_Sucursal.Get_List_Sucursal(param.IdEmpresa);
                List_Bodegas = Bus_Bodega.Get_List_Bodega(param.IdEmpresa);
                cmbSucursal.Properties.DataSource = List_Sucursales;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbSucursal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbBodega.Properties.DataSource = List_Bodegas.FindAll(v => v.IdSucursal == Convert.ToInt32(cmbSucursal.EditValue));
                cmbBodega.EditValue = null;
                if (Productos_no_asignados != null)
                {
                    if (Productos_no_asignados.Count() > 0)
                    {
                        Productos_no_asignados.Clear();
                        Productos_Asignados_x_Bodega.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void cmbBodega_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBodega.EditValue != null)
                {
                    Productos_Asignados_x_Bodega = new BindingList<in_Producto_Info>(Bus_Product.Get_list_Producto(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue), Convert.ToInt32(cmbBodega.EditValue))); 
                    Productos_no_asignados = new BindingList<in_Producto_Info>(Bus_Product.Get_list_Productos_not_exist_in_producto_x_bodega(param.IdEmpresa, Convert.ToInt32(cmbSucursal.EditValue), Convert.ToInt32(cmbBodega.EditValue)));
                    gridControlProducto.DataSource = Productos_no_asignados;
                    gridControlProdXBodega.DataSource = Productos_Asignados_x_Bodega;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CambioproductoAproductoXBodega(in_Producto_Info item, ref  in_producto_x_tb_bodega_Info address) 
        {

            try
            {

                in_producto_Bus InProdxbod_bus = new in_producto_Bus();
                in_Producto_Info Oinfo = new in_Producto_Info();
                Oinfo = InProdxbod_bus.Get_Info_BuscarProducto(item.IdProducto, param.IdEmpresa);
                address.IdSucursal = Convert.ToInt32(cmbSucursal.EditValue);
                address.IdBodega = Convert.ToInt32(cmbBodega.EditValue);
                address.IdEmpresa = param.IdEmpresa;
                address.IdProducto = item.IdProducto;
                address.pr_precio_publico = item.pr_precio_publico;
                address.pr_precio_mayor = item.pr_precio_mayor;
                address.pr_precio_puerta = 0;
                address.pr_precio_minimo = item.pr_precio_minimo;
                address.pr_Por_descuento = 0;
                //address.pr_stock = item.pr_stock;
                address.pr_stock_maximo = 0;
                address.pr_stock_minimo = 0;
                address.pr_costo_fob = item.pr_costo_fob;
                address.pr_costo_CIF = item.pr_costo_CIF;
                address.pr_costo_promedio = item.pr_costo_promedio;
                address.Estado = "A";
                address.IdCtaCble_CosBaseIva = Oinfo.IdCtaCble_CosBaseIva;
                address.IdCtaCble_CosBase0 = Oinfo.IdCtaCble_CosBase0;
                address.IdCtaCble_VenIva = Oinfo.IdCtaCble_VenIva;
                address.IdCtaCble_Ven0 = Oinfo.IdCtaCble_Ven0;
                address.IdCtaCble_DesIva = Oinfo.IdCtaCble_DesIva;
                address.IdCtaCble_Des0 = Oinfo.IdCtaCble_Des0;
                address.IdCtaCble_DevIva = Oinfo.IdCtaCble_DevIva;
                address.IdCtaCble_Dev0 = Oinfo.IdCtaCble_Dev0;
                address.IdCtaCble_Inven = Oinfo.IdCtaCble_Inventario;
                address.IdCtaCble_Costo = Oinfo.IdCtaCble_Costo;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }
        
        private void btnDerechaç_Click(object sender, EventArgs e)
        {

            try
            {
                in_Producto_Info Item = (in_Producto_Info)gridViewProducto_no_asigandos.GetFocusedRow();

                if (Item != null)
                {

                    if (Productos_Asignados_x_Bodega.Count(v => v.IdProducto == Item.IdProducto) == 0)
                    {
                        Productos_Asignados_x_Bodega.Add(Item);
                        in_producto_x_tb_bodega_Info obj = new in_producto_x_tb_bodega_Info();


                        CambioproductoAproductoXBodega(Item, ref obj);

                        Bus_Prod_X_Bod.GrabaDB(obj, param.IdEmpresa, ref Mensaje);

                        Productos_no_asignados.Remove(Item);
                        gridControlProducto.RefreshDataSource();
                        gridControlProdXBodega.RefreshDataSource();
                    }
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Info Item = (in_Producto_Info)gridViewProdXBodega.GetFocusedRow();

                if (Item != null)
                {
                    
                       
                        in_producto_x_tb_bodega_Info obj = new in_producto_x_tb_bodega_Info();
                        CambioproductoAproductoXBodega(Item, ref obj);
                        try
                        {
                            Bus_Prod_X_Bod.EliminarDB(obj, param.IdEmpresa, ref Mensaje);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("El item esta siendo utilizado en una Transacción no se puede eliminar de la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (Mensaje == "Eliminado OK..")
                        {
                            Productos_no_asignados.Add(Item);
                            Productos_Asignados_x_Bodega.Remove(Item);
                        }
                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }

        }

        private void btnDerechaTodos_Click(object sender, EventArgs e)
        {
            try
            {
                bool grabadoOk = false;


                foreach (var item2 in gridViewProducto_no_asigandos.GetSelectedRows())
                {
                    grabadoOk = false;
                    in_Producto_Info item = (in_Producto_Info)gridViewProducto_no_asigandos.GetRow(item2);
                    in_producto_x_tb_bodega_Info obj = new in_producto_x_tb_bodega_Info();

                    CambioproductoAproductoXBodega(item, ref obj);
                    try
                    {
                       grabadoOk= Bus_Prod_X_Bod.GrabaDB(obj, param.IdEmpresa, ref Mensaje);
                    }
                    catch (Exception ex)
                    {
                    }
                    if (grabadoOk==true)
                    {
                       Productos_Asignados_x_Bodega.Add(item);
                    }
                }


                Productos_no_asignados.Clear();
                cmbBodega_EditValueChanged(new Object(), new EventArgs());

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnIzquierdaTodos_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (var item2 in gridViewProdXBodega.GetSelectedRows())
                {

                    in_Producto_Info item = (in_Producto_Info)gridViewProdXBodega.GetRow(item2);
                    in_producto_x_tb_bodega_Info obj = new in_producto_x_tb_bodega_Info();
                    
                    CambioproductoAproductoXBodega(item, ref obj);
                    try
                    {
                        Bus_Prod_X_Bod.EliminarDB(obj, param.IdEmpresa, ref Mensaje);
                    }
                    catch (Exception ex)
                    {
                     //   MessageBox.Show("Algunos item están siendo utilizado en  Transacciónes no se pueden eliminar de la bodega", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //return;
                    }
                    if (Mensaje == "Eliminado OK..")
                    {
                        Productos_no_asignados.Add(item);
                       
                    }
                }


                Productos_Asignados_x_Bodega.Clear();
                cmbBodega_EditValueChanged(new Object(), new EventArgs());
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmIn_ProductoXBodega_Load(object sender, EventArgs e)
        {

        }

      
    }
}
