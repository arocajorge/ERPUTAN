using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core.Erp.Winform.Compras
{
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;

    public partial class FrmCom_ProductoComprasAnteriores : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        in_producto_Bus bus_producto;
        BindingList<in_Producto_ComprasAnteriores> blst;
        public decimal IdProducto { get; set; }
        public in_Producto_ComprasAnteriores info { get; set; }
        #endregion

        public FrmCom_ProductoComprasAnteriores()
        {
            InitializeComponent();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_producto = new in_producto_Bus();
            blst = new BindingList<in_Producto_ComprasAnteriores>();
        }

        private void FrmCom_ProductoComprasAnteriores_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            blst = new BindingList<in_Producto_ComprasAnteriores>(bus_producto.GetListCompras(param.IdEmpresa, IdProducto));
            gc_detalle.DataSource = blst;
        }

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                in_Producto_ComprasAnteriores row = (in_Producto_ComprasAnteriores)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                info = row;
                this.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
