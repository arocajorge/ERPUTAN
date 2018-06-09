using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Infragistics.Win.UltraWinGrid;





namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_ProductoConsulta : Form
    {

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        in_producto_Bus pb = new in_producto_Bus();
        List<in_Producto_Info> lisp = new List<in_Producto_Info>();
        in_Producto_Info _productoi = new in_Producto_Info();




        public frmIn_ProductoConsulta()
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

        private void frmIn_ProductoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
               load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void load_grid()
        {
            try
            {

                in_marca_bus busmarca = new in_marca_bus();
                in_ProductoTipo_Bus busTipo = new in_ProductoTipo_Bus();
                in_categorias_bus busCat = new in_categorias_bus();
                lisp = pb.Obtener_listProducto(param.IdEmpresa);
               
                gridControlProducto.DataSource  = lisp;
                //SetUltraGridDataSource(this.UlGridProducto, lisp);
               
           
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }


        private void SetUltraGridDataSource(UltraGrid gr, Object list)
        {
            try
            {
               Dictionary<String, Object> columnKeys = new Dictionary<String, Object>(gr.DisplayLayout.Bands[0].Columns.Count);

                    foreach (UltraGridColumn column in gr.DisplayLayout.Bands[0].Columns)
                        columnKeys.Add(column.Key, null);



                    gr.DataSource = list;


                    foreach (UltraGridColumn column in gr.DisplayLayout.Bands[0].Columns)

                        if (!columnKeys.ContainsKey(column.Key))
                            column.Hidden = true;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            

        }


        private void UlGridProducto_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            try
            {
                   e.Layout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
           
         

                   //e.Layout.Bands[0].Columns[1].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                   //e.Layout.Bands[0].Columns[1].AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;


                   ////e.Layout.Bands[0].Columns[3].Width = 3;
                   // e.Layout.Bands[0].Columns[3].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Suggest;
                   // e.Layout.Bands[0].Columns[3].AutoSuggestFilterMode = Infragistics.Win.AutoSuggestFilterMode.Contains;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }        
        }

        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmIn_ProductoMantenimiento fpm = new FrmIn_ProductoMantenimiento();
                fpm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                fpm.set_estado(true);
                fpm.ShowDialog();
                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void mnu_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmIn_ProductoMantenimiento fpm = new FrmIn_ProductoMantenimiento();
                fpm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                fpm.set_producto(_productoi);
                fpm.ShowDialog();

                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void mnu_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmIn_ProductoMantenimiento fpm = new FrmIn_ProductoMantenimiento();
                fpm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.actualizar);
            
                fpm.set_producto(_productoi);
                fpm.ShowDialog();

                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }

        private void UlGridProducto_BeforeRowActivate(object sender, RowEventArgs e)
        {
            try
            {

                
                if (e.Row.Index >= 0)
                {
                    _productoi = (in_Producto_Info)e.Row.ListObject;


                }

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

        private void toolStripButton1_Click(object sender, EventArgs e){}

        private void gridViewProducto_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _productoi = (in_Producto_Info )gridViewProducto.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewProducto_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewProducto.GetRow(e.RowHandle) as in_Producto_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void mnu_anular_Click(object sender, EventArgs e)
        {
            try
            {
                FrmIn_ProductoMantenimiento fpm = new FrmIn_ProductoMantenimiento();
                fpm.set_Accion(Info.General.Cl_Enumeradores.eTipo_action.borrar);

                fpm.set_producto(_productoi);
               // fpm.MdiParent = this.MdiParent;
                fpm.ShowDialog();

                load_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        




    }
}
