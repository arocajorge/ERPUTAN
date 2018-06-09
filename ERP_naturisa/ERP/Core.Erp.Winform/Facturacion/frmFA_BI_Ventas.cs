using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_BI_Ventas : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public frmFa_BI_Ventas()
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                pivotGridControlVentas.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
            
        }

        private void frmFa_BI_Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
