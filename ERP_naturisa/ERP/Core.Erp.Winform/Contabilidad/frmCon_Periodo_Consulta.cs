using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Business.General;


namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_Periodo_Consulta : Form
    {
        #region Declaracion de Variables
        int op;
        public DataTable lm = new DataTable();
        ct_Periodo_Bus pb = new ct_Periodo_Bus();
        ct_Periodo_Info pi = new ct_Periodo_Info();
        cl_parametrosGenerales_Bus Parametros = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmCon_Periodo_Mantenimiento frm;
        string MensajeError = "";
        #endregion
        
        public frmCon_Periodo_Consulta()
        {
            InitializeComponent();
        }
       
        private void frmCon_Periodo_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarGrid()
        {
            try
            {
                gridControlPeriodo.DataSource = pb.Get_List_Periodo(Parametros.IdEmpresa,ref MensajeError);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private ct_Periodo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ct_Periodo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Periodo_Info();
            }
        }
        
        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                frm = new frmCon_Periodo_Mantenimiento();
                frm.event_frmCon_Periodo_Mantenimiento_FormClosing += frm_event_frmCon_Periodo_Mantenimiento_FormClosing;
                frm.Text = frm.Text + "***NUEVO REGISTRO***";
                frm.info = pi;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmCon_Periodo_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = (ct_Periodo_Info)gridViewPerido.GetFocusedRow();

                if (pi != null)
                {
                    frm = new frmCon_Periodo_Mantenimiento();
                    frm.event_frmCon_Periodo_Mantenimiento_FormClosing += frm_event_frmCon_Periodo_Mantenimiento_FormClosing;
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    frm.info = pi;
                    frm.set_periodo(pi);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = (ct_Periodo_Info)gridViewPerido.GetFocusedRow();

                if (pi != null)
                {
                    frm = new frmCon_Periodo_Mantenimiento();
                    frm.event_frmCon_Periodo_Mantenimiento_FormClosing += frm_event_frmCon_Periodo_Mantenimiento_FormClosing;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm.info = pi;
                    frm.set_periodo(pi);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                pi = (ct_Periodo_Info)gridViewPerido.GetFocusedRow();

                if (pi != null)
                {
                    frm = new frmCon_Periodo_Mantenimiento();
                    frm.event_frmCon_Periodo_Mantenimiento_FormClosing += frm_event_frmCon_Periodo_Mantenimiento_FormClosing;
                    frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    frm.info = pi;
                    frm.set_periodo(pi);
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Seleccione un Registro ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void gridViewPerido_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                pi = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewPerido_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridViewPerido.GetRow(e.RowHandle) as ct_Periodo_Info;
                if (data == null)
                    return;

                if (data.pe_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
