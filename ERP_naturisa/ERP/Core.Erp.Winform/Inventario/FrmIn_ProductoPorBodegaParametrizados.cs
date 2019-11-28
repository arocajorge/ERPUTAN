using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProductoPorBodegaParametrizados : Form
    {
        #region Variables
        public List<in_producto_x_tb_bodega_Info> ListaDetalle { get; set; }
        #endregion

        public FrmIn_ProductoPorBodegaParametrizados()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gcDetalle.ShowPrintPreview();
        }

        private void FrmIn_ProductoPorBodegaParametrizados_Load(object sender, EventArgs e)
        {
            gcDetalle.DataSource = ListaDetalle;
        }
    }
}
