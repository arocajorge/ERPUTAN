using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Detalle_Ing_Egr_Bodega_Alerta : Form
    {
        public FrmIn_Detalle_Ing_Egr_Bodega_Alerta()
        {
            InitializeComponent();
        }



        List<in_Ing_Egr_Inven_det_Info> list_a_mostrar = new List<in_Ing_Egr_Inven_det_Info>();


        public void set_info_list(List<in_Ing_Egr_Inven_det_Info> _list_a_mostrar)
        {
            list_a_mostrar = _list_a_mostrar;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmIn_Detalle_Ing_Egr_Bodega_Alerta_Load(object sender, EventArgs e)
        {
            gridControlIngEgr.DataSource = list_a_mostrar;
        }
    }
}
