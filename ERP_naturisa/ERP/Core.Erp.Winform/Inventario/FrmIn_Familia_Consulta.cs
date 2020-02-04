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
    using Core.Erp.Info.Inventario;
    using Core.Erp.Business.Inventario;
    using Core.Erp.Business.General;
    using Core.Erp.Info.General;

    public partial class FrmIn_Familia_Consulta : Form
    {
        #region Variables
        in_Familia_Bus bus_familia;
        cl_parametrosGenerales_Bus param;
        #endregion

        public FrmIn_Familia_Consulta()
        {
            param = cl_parametrosGenerales_Bus.Instance;
            bus_familia = new in_Familia_Bus();
            InitializeComponent();
        }

        private void FrmIn_Familia_Consulta_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            gc_consulta.DataSource = null;
            gc_consulta.DataSource = bus_familia.GetList(param.IdEmpresa);
        }

        private void gv_consulta_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                in_Familia_Info row = (in_Familia_Info)gv_consulta.GetRow(e.RowHandle);
                if (row == null)
                    return;
                if (!row.Estado)
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception)
            {   
                throw;
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gv_consulta.ShowPrintPreview();
        }

        private void LlamarFormulario(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                in_Familia_Info row = (in_Familia_Info)gv_consulta.GetFocusedRow();

                if (Accion != Cl_Enumeradores.eTipo_action.grabar && row == null)
                {
                    MessageBox.Show("Seleccione un registro",param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                FrmIn_Familia_Mantenimiento frm = new FrmIn_Familia_Mantenimiento();
                frm.event_FrmIn_Familia_Mantenimiento_FormClosing += frm_event_FrmIn_Familia_Mantenimiento_FormClosing;
                frm.MdiParent = this.MdiParent;
                frm.SetAccion(Accion, row ?? new in_Familia_Info());
                frm.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void frm_event_FrmIn_Familia_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.consultar);
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LlamarFormulario(Cl_Enumeradores.eTipo_action.Anular);
        }
    }
}
