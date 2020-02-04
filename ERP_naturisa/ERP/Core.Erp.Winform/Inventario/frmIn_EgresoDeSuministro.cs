using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_EgresoDeSuministro : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        BindingList<in_egreso_d_Suministro_Info> DataSource; 

        public FrmIn_EgresoDeSuministro()
        {
            try
            {
                InitializeComponent();
              
                 DataSource = new BindingList<in_egreso_d_Suministro_Info>();
                gridContro.DataSource = DataSource;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void ucGe_Menu_event_btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnGuardar_y_Salir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
