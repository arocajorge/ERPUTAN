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
namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Consultar_Stock_Producto_x_Bodega : Form
    {
        in_Producto_Info pr = new in_Producto_Info();

        public FrmIn_Consultar_Stock_Producto_x_Bodega()
        {
            InitializeComponent();
        }
        
        public void set_Producto(in_Producto_Info prs) {

            pr = prs;
        }
      
        private void frmIn_Consutal_Stock_Producto_x_Bodega_Load(object sender, EventArgs e)
        {
            
            in_producto_busqueda_Bus prB = new in_producto_busqueda_Bus();
            List<in_Producto_Info> lst = new List<in_Producto_Info>();

            lst = prB.Stokc_X_Bodeta(pr);
            gridControlproductos.DataSource = lst;
            MinimizeBox = false;
            MaximizeBox = false;
            
        }

       
        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
