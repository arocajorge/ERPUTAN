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
using Core.Erp.Business.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_ProvisionIngresoOCCons : Form
    {
        #region Variables
        in_ProvisionIngresosPorOC_Bus bus;
        cl_parametrosGenerales_Bus param;
        #endregion

        public FrmIn_ProvisionIngresoOCCons()
        {
            bus = new in_ProvisionIngresosPorOC_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            InitializeComponent();
        }

        private void gvConsulta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            in_ProvisionIngresosPorOC_Info row = (in_ProvisionIngresosPorOC_Info)gvConsulta.GetRow(e.RowHandle);
            if (row == null)
            {
                e.Appearance.ForeColor = Color.Black;
                return;
            }
            if (!row.Estado)
            {
                e.Appearance.ForeColor = Color.Red;
                return;
            }
            else
            {
                e.Appearance.ForeColor = Color.Black;
                return;
            }
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            in_ProvisionIngresosPorOC_Info row = (in_ProvisionIngresosPorOC_Info)gvConsulta.GetFocusedRow();
            if (Accion != Cl_Enumeradores.eTipo_action.grabar)
            {
                if (row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (Accion != Cl_Enumeradores.eTipo_action.consultar && !row.Estado)
                {
                    MessageBox.Show("El registro se encuentra anulado", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            FrmIn_ProvisionIngresoOCMant frm = new FrmIn_ProvisionIngresoOCMant();
            frm.MdiParent = this.MdiParent;
            frm.SetInfo(Accion, row ?? new in_ProvisionIngresosPorOC_Info());
            frm.event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed += frm_event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed;
            frm.Show();
        }

        private void Buscar()
        {
            gcConsulta.DataSource = bus.GetList(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario1.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario1.fecha_hasta);
        }

        void frm_event_delegateFrmIn_ProvisionIngresoOCMant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.grabar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.actualizar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcConsulta.ShowPrintPreview();
        }

        private void FrmIn_ProvisionIngresoOCCons_Load(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
