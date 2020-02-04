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
    using Core.Erp.Info.General;
    using Core.Erp.Business.General;
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.Inventario;

    public partial class FrmIn_ProductoSeleccionar : Form
    {
        #region Variables
        cl_parametrosGenerales_Bus param;
        in_producto_Bus bus_producto;
        public in_Producto_Combo info { get; set; }
        #endregion

        public FrmIn_ProductoSeleccionar()
        {
            param = cl_parametrosGenerales_Bus.Instance;
            bus_producto = new in_producto_Bus();
            InitializeComponent();
        }

        private void Buscar()
        {
            try
            {
                gc_detalle.DataSource = bus_producto.GetListCombo(param.IdEmpresa);
            }
            catch (Exception)
            {
                
            }
        }

        private void cmb_imagen_Click(object sender, EventArgs e)
        {
            try
            {
                in_Producto_Combo row = (in_Producto_Combo)gv_detalle.GetFocusedRow();
                if (row == null)
                    return;

                info = row;
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void FrmIn_ProductoSeleccionar_Load(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
