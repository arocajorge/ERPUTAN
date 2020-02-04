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
using Core.Erp.Info.General;
using Core.Erp.Business.General;



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Unidad_Medida_Consu : Form
    {
        bool Es_consulta = true;
        in_UnidadMedida_Info InfoUni_Medi = new in_UnidadMedida_Info();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        in_UnidadMedida_Bus UniBus = new in_UnidadMedida_Bus();
        in_UnidadMedida_Info info_unidad_medida = new in_UnidadMedida_Info();
        List<in_UnidadMedida_Info> listUni_med = new List<in_UnidadMedida_Info>();
        int Row_handle = 0;
        FrmIn_Unidad_Medida_Mant frm = new FrmIn_Unidad_Medida_Mant();

        public void set_config_combo(List<in_UnidadMedida_Info> _Lista)
        {
            try
            {
                Es_consulta = false;
                ucGe_BarraEstado.Hide();
                ucGe_Menu.Hide();
                this.ControlBox = false;
                toolStrip1.Visible = true;
                colEstado.Visible = false;
                colUsado_en_Movimiento.Visible = false;
                this.Text = "";
                listUni_med = _Lista;

                gridView_unidad_med.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FrmIn_Unidad_Medida_Consu()
        {
            InitializeComponent();

            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnImprimir_ItemClick += ucGe_Menu_event_btnImprimir_ItemClick;

        }

        void ucGe_Menu_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridView_unidad_med.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoUni_Medi = (in_UnidadMedida_Info)gridView_unidad_med.GetFocusedRow();

                if (InfoUni_Medi != null)
                {
                    frm = new FrmIn_Unidad_Medida_Mant();
                    frm.Text = frm.Text + "***ANULAR REGISTRO***";
                    frm._InfoUni_Med = InfoUni_Medi;
                    frm._Accion = Cl_Enumeradores.eTipo_action.Anular;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Unidad_Medida_Mant_FormClosing += frm_event_FrmIn_Unidad_Medida_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoUni_Medi = (in_UnidadMedida_Info)gridView_unidad_med.GetFocusedRow();

                if (InfoUni_Medi != null)
                {
                    frm = new FrmIn_Unidad_Medida_Mant();
                    frm.Text = frm.Text + "***CONSULTAR REGISTRO***";
                    frm._InfoUni_Med = InfoUni_Medi;
                    frm._Accion = Cl_Enumeradores.eTipo_action.consultar;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Unidad_Medida_Mant_FormClosing += frm_event_FrmIn_Unidad_Medida_Mant_FormClosing;
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

        }

        void frm_event_FrmIn_Unidad_Medida_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                InfoUni_Medi = (in_UnidadMedida_Info)gridView_unidad_med.GetFocusedRow();

                if (InfoUni_Medi != null)
                {
                    frm = new FrmIn_Unidad_Medida_Mant();
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    frm._InfoUni_Med = InfoUni_Medi;
                    frm._Accion = Cl_Enumeradores.eTipo_action.actualizar;
                    frm.Show();
                    frm.MdiParent = this.MdiParent;
                    frm.event_FrmIn_Unidad_Medida_Mant_FormClosing+=frm_event_FrmIn_Unidad_Medida_Mant_FormClosing;
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un Registro a Mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cargar_grid()
        {
            try
            {
                if (Es_consulta)
                {
                    listUni_med = UniBus.Get_list_UnidadMedida();
                    gridControl_uni_medida.DataSource = listUni_med;
                }
                else
                {
                    gridControl_uni_medida.DataSource = listUni_med;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new FrmIn_Unidad_Medida_Mant();
                frm._Accion = Cl_Enumeradores.eTipo_action.grabar;
                frm.Text = frm.Text + "*** NUEVO REGISTRO ***";
                frm.Show();
                frm.MdiParent = this.MdiParent;
                frm.event_FrmIn_Unidad_Medida_Mant_FormClosing+=frm_event_FrmIn_Unidad_Medida_Mant_FormClosing;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void gridControl_uni_medida_Click(object sender, EventArgs e)
        {

        }

        private void FrmIn_Unidad_Medida_Consu_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_grid();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Load(object sender, EventArgs e)
        {

        }

        private void gridView_unidad_med_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_unidad_med.GetRow(e.RowHandle) as in_UnidadMedida_Info;
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

        private void gridView_unidad_med_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (!Es_consulta)
                {
                    info_unidad_medida = (in_UnidadMedida_Info)gridView_unidad_med.GetRow(Row_handle);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public in_UnidadMedida_Info Get_info_unidad_medida()
        {
            try
            {
                return info_unidad_medida;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void gridView_unidad_med_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info_unidad_medida = (in_UnidadMedida_Info)gridView_unidad_med.GetFocusedRow();
                Row_handle = e.FocusedRowHandle;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Vaciar_Click(object sender, EventArgs e)
        {
            try
            {
                info_unidad_medida = null;
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView_unidad_med_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(!Es_consulta)
                if (e.KeyCode == Keys.Enter)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
