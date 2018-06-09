using Core.Erp.Business.General;
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
    public partial class FrmIn_Ingreso_varios_Cons_FJ : Form
    {
        FrmIn_Ingreso_varios_Cons_Handler Handler = new FrmIn_Ingreso_varios_Cons_Handler();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        public FrmIn_Ingreso_varios_Cons_FJ()
        {
            InitializeComponent();
            Handler.gridControlConsulta = this.gridControlConsulta;
            Handler.gridViewConsulta = this.gridViewConsulta;

            this.gridViewConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(Handler.gridViewConsulta_RowClick);
            this.gridViewConsulta.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Handler.gridViewConsulta_RowCellStyle);
            this.Load += new System.EventHandler(Handler.FrmIn_Ingreso_varios_Cons_Load);
            Handler.ucGe_Menu_Mantenimiento_x_usuario1 = this.ucGe_Menu_Mantenimiento_x_usuario1;
            Handler.ucGe_BarraEstadoInferior_Forms1 = this.ucGe_BarraEstadoInferior_Forms1;
        }

        private void FrmIn_Ingreso_varios_Cons_FJ_Load(object sender, EventArgs e)
        {
            try
            {
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick;
            ucGe_Menu_Mantenimiento_x_usuario1.event_btnBuscar_Click += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click;

            ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += Handler.ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;

            Handler.FrmMDIParent = this.MdiParent;
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
