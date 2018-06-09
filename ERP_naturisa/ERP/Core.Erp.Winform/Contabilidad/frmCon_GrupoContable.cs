using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_GrupoContable : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        public frmCon_GrupoContable()
        {
            InitializeComponent();
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void frmCon_GrupoContable_Load(object sender, EventArgs e)
        {
            cargar_grid();
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControlGrupoCble.ShowPrintPreview();
        }

        private void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
        {

            cargar_grid();

        }

        private void cargar_grid()
        {
            try
            {
                ct_Grupocble_Bus BusGrupoCble = new ct_Grupocble_Bus();
                List<ct_Grupocble_Info> ListInfoGrupoCble = new List<ct_Grupocble_Info>();
                ListInfoGrupoCble = BusGrupoCble.Get_list_Grupocble();

                gridControlGrupoCble.DataSource = ListInfoGrupoCble;
            }
            catch (Exception ex)
            {

            }
        }

    }
}
