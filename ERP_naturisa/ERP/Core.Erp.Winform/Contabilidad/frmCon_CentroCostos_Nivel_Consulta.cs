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
using Core.Erp.Winform.Controles;
using Core.Erp.Winform.Contabilidad;
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Contabilidad
{
    public partial class frmCon_CentroCostos_Nivel_Consulta : Form
    {
        #region Declaración de Variables
        public DataTable lm = new DataTable();
        cl_parametrosGenerales_Bus Parametros = cl_parametrosGenerales_Bus.Instance;
        ct_Centro_costo_nivel_Bus _CentroCostoNivelBus = new ct_Centro_costo_nivel_Bus();
        ct_Centro_costo_nivel_Info _CentroCostoNivelInfo = new ct_Centro_costo_nivel_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmCon_CentroCostos_Nivel_Mant frm;
        #endregion

        public frmCon_CentroCostos_Nivel_Consulta()
        {
            InitializeComponent();
        }

        private void frmCon_CentroCostos_Nivel_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargargrid();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

              

                
                    frm = new frmCon_CentroCostos_Nivel_Mant();
                    frm.event_frmCon_CentroCostos_Nivel_Mant_FormClosing += frm_event_frmCon_CentroCostos_Nivel_Mant_FormClosing;                    
                    frm.Text = frm.Text + "***NUEVO REGISTRO***";
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

        void frm_event_frmCon_CentroCostos_Nivel_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargargrid();
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

                _CentroCostoNivelInfo = (ct_Centro_costo_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_CentroCostoNivelInfo != null)
                {
                    frm = new frmCon_CentroCostos_Nivel_Mant();
                    frm.event_frmCon_CentroCostos_Nivel_Mant_FormClosing += frm_event_frmCon_CentroCostos_Nivel_Mant_FormClosing;                    
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    frm._CentroCostoNivelInfo = _CentroCostoNivelInfo;                    
                    frm.set_CentroCostoNivel(_CentroCostoNivelInfo);
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

                _CentroCostoNivelInfo = (ct_Centro_costo_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_CentroCostoNivelInfo != null)
                {
                    frm = new frmCon_CentroCostos_Nivel_Mant();
                    frm.event_frmCon_CentroCostos_Nivel_Mant_FormClosing += frm_event_frmCon_CentroCostos_Nivel_Mant_FormClosing;
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._CentroCostoNivelInfo = _CentroCostoNivelInfo;
                    frm.set_CentroCostoNivel(_CentroCostoNivelInfo);
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

        private void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                _CentroCostoNivelInfo = (ct_Centro_costo_nivel_Info)gridViewNivel.GetFocusedRow();

                if (_CentroCostoNivelInfo != null)
                {
                    frm = new frmCon_CentroCostos_Nivel_Mant();
                    frm.event_frmCon_CentroCostos_Nivel_Mant_FormClosing += frm_event_frmCon_CentroCostos_Nivel_Mant_FormClosing;
                    frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    frm._CentroCostoNivelInfo = _CentroCostoNivelInfo;
                    frm.set_CentroCostoNivel(_CentroCostoNivelInfo);
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

        private void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewNivel.ShowRibbonPrintPreview();
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
                Close();
            }
            catch (Exception ex)
            {
               Log_Error_bus.Log_Error(ex.ToString());
               MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargargrid()
        {
            try
            {
                gridNivel.DataSource = _CentroCostoNivelBus.Get_list_Centro_costo_nivel(Parametros.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridViewNivel_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewNivel.GetRow(e.RowHandle) as ct_Centro_costo_nivel_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewNivel_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _CentroCostoNivelInfo = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private ct_Centro_costo_nivel_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (ct_Centro_costo_nivel_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new ct_Centro_costo_nivel_Info();
            }
        }
    }
}
