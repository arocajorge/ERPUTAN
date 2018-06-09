using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Compras
{
    public partial class FrmCom_Ordenes_Compra_x_Solicitud : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public FrmCom_Ordenes_Compra_x_Solicitud()
        {
            InitializeComponent();
        }

        private void FrmCom_Ordenes_Compra_x_Solicitud_Load(object sender, EventArgs e)
        {

        }

        public void set_grid_x_oc(  List<com_ordencompra_local_Info> listOc)
        {
            try
            {
                gridControlOC.DataSource = listOc;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Superior_Mant1_event_btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
        }
    }
}
