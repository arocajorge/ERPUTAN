using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Inventario
{
    using Core.Erp.Business.Inventario;
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.General;

    public partial class FrmIn_ProductoPorBodegaStock : Form
    {
        #region Variables
        in_producto_Bus bus_producto;
        BindingList<in_Producto_Info> blst;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public decimal _IdProducto { get; set; }
        #endregion

        public FrmIn_ProductoPorBodegaStock()
        {
            InitializeComponent();
            bus_producto = new in_producto_Bus();
            blst = new BindingList<in_Producto_Info>();
        }

        public void SetProductoPorBodega()
        {
            try
            {
                blst = new BindingList<in_Producto_Info>(bus_producto.GetListStockPorBodega(param.IdEmpresa,_IdProducto));
                gc_consulta.DataSource = blst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error, comuníquese con sistemas\n" + ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIn_ProductoPorBodegaStock_Load(object sender, EventArgs e)
        {
            SetProductoPorBodega();
        }
    }
}
