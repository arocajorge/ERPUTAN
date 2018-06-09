using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Linq;




namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Producto_Busqueda : Form
    {
        public FrmIn_Producto_Busqueda()
        {
            try
            {
                InitializeComponent();
                RefreshListProduct();
                _prodBod = new in_Producto_Info();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
         public FrmIn_Producto_Busqueda(int idbodega, int idsucursal):this()
        {
            try
            {
               setearbodega_suc(idbodega, idsucursal);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


         tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Categorias ctrl_Categoria = new UCIn_Categorias();
        public UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        string cadena = "";
        List<in_categorias_Info> LstCate_I = new List<in_categorias_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        List<in_Producto_Info> lst = new List<in_Producto_Info>();

        public in_Producto_Info _prodBod { get; set; }


        IQueryable<in_Producto_Info> source;
        tb_Sucursal_Info suc = new tb_Sucursal_Info();
        tb_Bodega_Info bod = new tb_Bodega_Info();
               
        public void setearbodega_suc(int idbodega, int idsucursal)
        {
            try
            {   
                suc.IdEmpresa = bod.IdEmpresa =param.IdEmpresa;
                suc.IdSucursal = bod.IdSucursal = idsucursal;
                bod.IdBodega = idbodega;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        }


        private void frmIn_Producto_Busqueda_Load(object sender, EventArgs e)
        {
            try
            {
                ctrl_Categoria.Dock = DockStyle.Fill;
                ctrl_Categoria.set_Treelist_AllowRecursiveNodeChecking(true);
                ctrl_SucBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
                ctrl_SucBod.Dock = DockStyle.Fill;
                pnlCategoria.Controls.Add(ctrl_Categoria);
                pnlSucBod.Controls.Add(ctrl_SucBod);
                RefreshListProduct();

                if (suc.IdSucursal != 0 && bod.IdBodega != 0)
                {
                    ctrl_SucBod.set_sucursal(suc);
                    ctrl_SucBod.set_bodega(bod);
                }
                RefreshListProduct();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnlCategoria_Paint(object sender, PaintEventArgs e){}

        private void RefreshListProduct()
        {
            try
            {


                in_Producto_Info prd = new in_Producto_Info();
                in_producto_busqueda_Bus ob = new in_producto_busqueda_Bus();
                _SucursalInfo = ctrl_SucBod.get_sucursal();
                _BodegaInfo = ctrl_SucBod.get_bodega();
                LstCate_I = ctrl_Categoria.get_CategoriaList();
                lst = ob.obtenerListProducto(LstCate_I, param.IdEmpresa, _SucursalInfo.IdSucursal, _BodegaInfo.IdBodega);
                //ultrGriProductos.DataSource = lst;

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

                ctrl_Categoria.get_categoriainfo();
                LstCate_I = ctrl_Categoria.get_CategoriaList();

                RefreshListProduct();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click_1(object sender, EventArgs e)
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

        private void filterControl1_Click(object sender, EventArgs e)
        {
            try
            {
               RefreshListProduct();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void filterControl1_FilterChanged(object sender, DevExpress.XtraEditors.FilterChangedEventArgs e)
        {
          try
            {
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }     


        }

        
       
        
    }
}
