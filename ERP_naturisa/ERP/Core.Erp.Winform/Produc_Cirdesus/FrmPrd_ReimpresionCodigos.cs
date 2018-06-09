using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.Inventario_Cidersus;
using Cus.Erp.Reports.Cidersus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ReimpresionCodigos : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_Sucursal_Bus busSuc = new tb_Sucursal_Bus();
        tb_Bodega_Bus busBod = new tb_Bodega_Bus();
        List<tb_Sucursal_Info> sucursales = new List<tb_Sucursal_Info>();
        List<tb_Bodega_Info> bodegas = new List<tb_Bodega_Info>();
        in_movi_inve_detalle_x_Producto_CusCider_Bus Bus_movi_inve_detalle_x_Producto = new in_movi_inve_detalle_x_Producto_CusCider_Bus();
        in_movi_inve_detalle_Bus busMovDet = new in_movi_inve_detalle_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info> List_movi_inve_detalle_x_Producto = new BindingList<in_movi_inve_detalle_x_Producto_CusCider_Info>();
        List<in_movi_inve_detalle_x_Producto_CusCider_Info> result = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();

        string msg = "";
        in_movi_inven_tipo_Bus busTipMov = new in_movi_inven_tipo_Bus();
        in_producto_Bus busProducto = new in_producto_Bus();
        
        public FrmPrd_ReimpresionCodigos()
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

       
        private Boolean validar()
        {

            try
            {
                if (Convert.ToInt32(ucIn_Sucursal_Bodega.get_sucursal().IdSucursal) == 0)
                { MessageBox.Show("Seleccione una Sucursal"); return false; }
                if (Convert.ToInt32(ucIn_Sucursal_Bodega.get_bodega().IdBodega) == 0)
                { MessageBox.Show("Seleccione una Bodega"); return false; }
                if (0==Convert.ToInt32( cmbProducto.EditValue))
                { MessageBox.Show("Seleccione un Producto"); return false; }
                    
                   
                return true;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return false;
            }

        }
        

        void imprimir()
        {
            try
            {

                //-- CARLOS ACTALIZACION

                XRpt_prd_ReimpresionCodBarra XRpt_Reimpresion = new XRpt_prd_ReimpresionCodBarra();
                List<in_movi_inve_detalle_x_Producto_CusCider_Info> ListadoCodBarra = new List<in_movi_inve_detalle_x_Producto_CusCider_Info>();
                txtCodbarra.Focus();

                foreach (var item in List_movi_inve_detalle_x_Producto)
                {
                    if (item.check == true)
                        ListadoCodBarra.Add(item);
                }

                if (ListadoCodBarra.Count > 0)
                {
                    XRpt_Reimpresion.loadData(ListadoCodBarra.ToArray(), "");
                    XRpt_Reimpresion.ShowPreviewDialog();

                }
                else
                {
                    MessageBox.Show("No tiene seleccionado ningún codigos de barra a imprimir");
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }
        private void Frm_Prd_ReimpresionCodigos_Load(object sender, EventArgs e)
        {
            try
            {
                cargacombos();
                dtpFechaIni.Value = DateTime.Now.AddDays(-30);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        void cargacombos()
        {
            try
            {
               

                in_producto_Bus busProd = new in_producto_Bus();
                List<in_Producto_Info> productos = new List<in_Producto_Info>();
                
                productos  = busProd.Get_list_Producto_ManejaSeries(param.IdEmpresa);
                in_Producto_Info prod = new in_Producto_Info();
                prod.pr_descripcion = "Todos";
                prod.IdProducto = 0;
                productos.Add(prod);
                cmbProducto.Properties.DataSource = productos;
                cmbProducto.EditValue = 0;

                in_movi_inven_tipo_Bus busTipMov = new in_movi_inven_tipo_Bus();
                List<in_movi_inven_tipo_Info> LstTipMov = new List<in_movi_inven_tipo_Info>();
                LstTipMov = busTipMov.Get_list_movi_inven_tipo(param.IdEmpresa,"+","N","Todos");

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

        private void cmbTipMov_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void cmbProducto_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                 }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void txtNumMov_TextChanged(object sender, EventArgs e)
        {
            try
            {

                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        private void gridVwConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridVwConsulta.GetRow(e.RowHandle) as in_movi_inve_detalle_x_Producto_CusCider_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                imprimir();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_event_btnproductos_Click(object sender, EventArgs e)
        {
            try
            {
               
                chkTodos.Checked = false;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        public void BuscarCodBarra()
        {
            try
            {
              List_movi_inve_detalle_x_Producto= new BindingList<Info.Produc_Cirdesus.in_movi_inve_detalle_x_Producto_CusCider_Info>( Bus_movi_inve_detalle_x_Producto.ReimpresionCodigoBarra(txtCodbarra.Text, param.IdEmpresa));

              if (List_movi_inve_detalle_x_Producto.Count > 0)
              {
                  gridCtrlConsulta.DataSource = List_movi_inve_detalle_x_Producto;
              }
              else
              {
                  MessageBox.Show("No Existe Movimiento para el Codigo Barra "+txtCodbarra.Text);
                  gridCtrlConsulta.DataSource = null;
              }

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void txtCodbarra_KeyPress(object sender, KeyPressEventArgs e)       
        {
            try
            {
            if (e.KeyChar == 13)
            {
                BuscarCodBarra();
            }
            }
            catch (Exception ex)
            {
                
            Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar())
                    return;
                List_movi_inve_detalle_x_Producto =new BindingList<Info.Produc_Cirdesus.in_movi_inve_detalle_x_Producto_CusCider_Info>( Bus_movi_inve_detalle_x_Producto.ReimpresionCodigoBarra(param.IdEmpresa, dtpFechaIni.Value, dtpFechaFin.Value, ucIn_Sucursal_Bodega.get_bodega().IdBodega, ucIn_Sucursal_Bodega.get_sucursal().IdSucursal,Convert.ToInt32(cmbProducto.EditValue)));

                if (List_movi_inve_detalle_x_Producto.Count > 0)
                {
                    gridCtrlConsulta.DataSource = List_movi_inve_detalle_x_Producto;
                }
                else
                {
                    MessageBox.Show("No Existe Movimiento para el Codigo Barra " + txtCodbarra.Text);
                    gridCtrlConsulta.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                
               Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in List_movi_inve_detalle_x_Producto)
                {
                    if (chkTodos.Checked == true)
                    {
                        item.check = true;
                    }
                    else
                    {
                        item.check = false;
                    }
                }
                gridCtrlConsulta.RefreshDataSource();
                
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
