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
using Infragistics.Win.UltraWinGrid;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_Consutal_Stock_Producto_x_Bodega : Form
    {
        public frmIn_Consutal_Stock_Producto_x_Bodega()
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
        in_Producto_Info pr = new in_Producto_Info();

        public void set_Producto(in_Producto_Info prs) {

            pr = prs;
        }
        private void frmIn_Consutal_Stock_Producto_x_Bodega_Load(object sender, EventArgs e)
        {
            try
            {
                in_producto_busqueda_Bus prB = new in_producto_busqueda_Bus();
                List<in_Producto_Info> lst = new List<in_Producto_Info>();

                lst = prB.Stokc_X_Bodeta(pr);
                ultraGrid1.DataSource = lst;
                MinimizeBox = false;
                MaximizeBox = false;
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
               this.Dispose();
            }
            catch (Exception ex)
            {
                  Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ultraGrid1_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
            
        {

            try
            {
                 UltraGridColumn columnToSummarize = e.Layout.Bands[0].Columns[13];
                SummarySettings summary = e.Layout.Bands[0].Summaries.Add("GrandTotal", SummaryType.Sum, columnToSummarize);
                summary.DisplayFormat = "Total Stock = {0}";
                summary.Appearance.TextHAlign =Infragistics.Win.HAlign.Right;

                columnToSummarize = e.Layout.Bands[0].Columns[14];
                summary = e.Layout.Bands[0].Summaries.Add("PriceAvg", SummaryType.Sum, columnToSummarize);
                summary.DisplayFormat = "Total Pedidos = {0}";
                summary.Appearance.TextHAlign = Infragistics.Win.HAlign.Right;

                columnToSummarize = e.Layout.Bands[0].Columns[10];
                summary = e.Layout.Bands[0].Summaries.Add("Promedio ", SummaryType.Average, columnToSummarize);
                summary.DisplayFormat = "Promedio PVP= {0:c}";
                summary.Appearance.TextHAlign = Infragistics.Win.HAlign.Right;

                this.ultraGrid1.DisplayLayout.Override.SummaryFooterCaptionVisible = Infragistics.Win.DefaultableBoolean.False;

                e.Layout.Override.SummaryDisplayArea = SummaryDisplayAreas.BottomFixed;
    
                e.Layout.Bands[0].Summaries.Add(SummaryType.Sum, e.Layout.Bands[0].Columns[59]);
                }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());               
            }
        }
    }
}
