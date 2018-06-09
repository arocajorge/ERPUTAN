using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProductoConsultaXBodega : Form
    {
        public FrmIn_ProductoConsultaXBodega()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //public fa_producto_info Producto_I { get; set; }
        public in_Producto_Info Producto_I { get; set; }


        //fa_producto_info Pro_I = new fa_producto_info();
        in_Producto_Info Pro_I = new in_Producto_Info();


        public FrmIn_ProductoConsultaXBodega(int IdEmpresa, int IdBodega, int IdSucursal):this()
        {
            try
            {
                gridControl_Producto.DataSource = Pro_B.Get_list_Producto(IdEmpresa, IdSucursal,IdBodega);
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
               this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        in_producto_Bus Pro_B = new in_producto_Bus();

        private void gridView_Producto_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Pro_I = (in_Producto_Info)gridView_Producto.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        private void frmIn_ProductoConsultaXBodega_Load(object sender, EventArgs e){}

        private void toolStripButtonSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto_I = Pro_I;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            try 
	        {
                if (e.KeyValue == 13)
                {
                    Producto_I = Pro_I;
                    this.Close();
                }
	        }
	        catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
	        }
        }

        private void gridView_Producto_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Producto_I = Pro_I;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControl_Producto_Click(object sender, EventArgs e)
        {

        }
        
    }
}
