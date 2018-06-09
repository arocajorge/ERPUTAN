using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Business.Produccion_Talme;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_Parametros : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_movi_inven_tipo_Bus MoviTipo_B = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> ListMoviTipo = new List<in_movi_inven_tipo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_Bodega_Bus Bodega_B = new tb_Bodega_Bus();
        tb_Sucursal_Bus Sucursal_B = new tb_Sucursal_Bus();
        List<tb_Sucursal_Info> ListaSucursales = new List<tb_Sucursal_Info>();
        List<tb_Bodega_Info> ListaBodegas = new List<tb_Bodega_Info>();
        BindingList<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info> data = new BindingList<prod_Parametros_x_MoviInven_x_ModeloProduccion_Info>();
        prod_ModeloProduccion_CusTalme_Bus ModeloProduccion_B = new prod_ModeloProduccion_CusTalme_Bus();
        in_movi_inven_tipo_Bus moviTipo_B = new in_movi_inven_tipo_Bus();
        List<in_movi_inven_tipo_Info> ListMovi = new List<in_movi_inven_tipo_Info>();
        in_producto_Bus producto_B = new in_producto_Bus();
        public frmProd_Parametros()
        {
            try
            {
                InitializeComponent();
                gridControlModeloProduccion.DataSource = data;
                ListMoviTipo = MoviTipo_B.Get_List_movi_inven_tipo(param.IdEmpresa);
                ListaSucursales = Sucursal_B.Get_List_Sucursal(param.IdEmpresa);
                ListaBodegas = Bodega_B.Get_List_Bodega(param.IdEmpresa);
                cmbSucursalIngresi.DataSource = ListaSucursales;
                cmbModeloProduccion.DataSource = ModeloProduccion_B.ConsultaGeneral();
                cmbMoviInvenTipo.DataSource = ListMoviTipo;
                cmbSucursalEgreso.DataSource = ListaSucursales;
                cmbMoviInveTipoEgreso.DataSource = ListMoviTipo;
                cmbSucursalIngresi.EditValueChanged += new EventHandler(cmbSucursalIngresi_EditValueChanged);
                gridViewModeloProduccion.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridViewModeloProduccion_CellValueChanged);
                gridViewModeloProduccion.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridViewModeloProduccion_CellValueChanging);
                gridViewModeloProduccion.AddNewRow();
                //gridViewModeloProduccion.AddNewRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void gridViewModeloProduccion_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.Caption != "Modelo de Produccion")
                {
                    if (Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdModeloProd)) != 0)
                    {
                        if (e.Column.Caption == "Sucursal Ingreso Producto" )
                        {

                            cmbBodegaIngreso.Items.Clear();

                            foreach (var item in Bodega_B.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(e.Value)))
                            {
                                cmbBodegaIngreso.Items.Add(item.bo_Descripcion);
                            }


                            gridViewModeloProduccion.SetFocusedRowCellValue(colIdSucursal_IngxProducTermi, Convert.ToInt32(e.Value));
                            gridViewModeloProduccion.SetFocusedRowCellValue(colIdEmpresa, param.IdEmpresa);
                            gridViewModeloProduccion.SetFocusedRowCellValue(colBodega, null);
                        }

                        if (e.Column.Caption == "Sucursale Egreso Producto")
                        {
                            cmbBodegaEgreso.Items.Clear();
                            foreach (var item in Bodega_B.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(e.Value)))
                            {
                                cmbBodegaEgreso.Items.Add(item.bo_Descripcion);
                            }
                            gridViewModeloProduccion.SetFocusedRowCellValue(colIdSucursal_EgrxMateriaPrima, Convert.ToInt32(e.Value));
                            gridViewModeloProduccion.SetFocusedRowCellValue(colBodegaEgreso, null);
                        }
                      
                    }
                    else
                    {
                        MessageBox.Show("Primero Seleccione Modelo Produccion");
                    }
                }
        //        var s = base.ActiveControl;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                foreach (var item in Bodega_B.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdSucursal_IngxProducTermi))))
                {
                    cmbBodegaIngreso.Items.Add(item.bo_Descripcion);
                }
            
            }
           
        }
          
            

        void gridViewModeloProduccion_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e){}
        
        void cmbSucursalIngresi_EditValueChanged(object sender, EventArgs e){}

        private void BtnGuardar_Click(object sender, EventArgs e){}

        private void btnSalir_Click(object sender, EventArgs e){}

        private void btnSalir_Click_1(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void gridViewModeloProduccion_Click(object sender, EventArgs e){}

        private void gridViewModeloProduccion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if((prod_Parametros_x_MoviInven_x_ModeloProduccion_Info)gridViewModeloProduccion.GetFocusedRow()==null)
                    gridViewModeloProduccion.AddNewRow();

                cmbBodegaIngreso.Items.Clear();
                foreach (var item in Bodega_B.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdSucursal_IngxProducTermi))))
                {
                    cmbBodegaIngreso.Items.Add(item.bo_Descripcion);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }

        private void repositoryItemGridLookUpEdit1View_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e){}

        private void gridViewModeloProduccion_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (e.FocusedColumn.Caption == "Producto Egreso" || e.FocusedColumn.Caption == "Producto Ingreso")
                {
                    cmbProductoEgreso.Items.Clear();
                    cmbMateriaPrima.Items.Clear();
                    int Id = Bodega_B.Get_List_Bodega(param.IdEmpresa, Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdSucursal_IngxProducTermi))).First(v => v.bo_Descripcion == gridViewModeloProduccion.GetFocusedRowCellValue(colBodegaEgreso).ToString()).IdBodega;
                    foreach (var item in producto_B.Get_list_ProductosSucursalXBodegaXModulodeProduccion(param.IdEmpresa, Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdModeloProd)), Id, Convert.ToInt32(gridViewModeloProduccion.GetFocusedRowCellValue(colIdSucursal_EgrxMateriaPrima))))
                    {
                        if (item.nom_Tipo_Producto == "PRODTERMI")
                            cmbProductoEgreso.Items.Add(item.pr_descripcion);
                        else
                            cmbMateriaPrima.Items.Add(item.pr_descripcion);                    

                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());           
            }            
        }

        private void toolStripButton1_Click(object sender, EventArgs e){}

        

    }
}
