using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

using Core.Erp.Info.Contabilidad;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Winform.General;
using Core.Erp.Reportes.Inventario; 



namespace Core.Erp.Winform.Inventario
{
    public partial class FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC : Form
    {

        string MensajeError = "";

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus Bus_SubG = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Bus();
        BindingList<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info> List_SubG = new BindingList<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>();


        private void Cargar_Combos()
        {
            try
            {
                ct_Plancta_Bus BusPlanCta = new ct_Plancta_Bus();
                List<ct_Plancta_Info> ListInfoPlanCta = new List<ct_Plancta_Info>();
                ListInfoPlanCta = BusPlanCta.Get_List_Plancta_x_ctas_Movimiento(param.IdEmpresa, ref MensajeError);
                cmb_ctaCble.DataSource = ListInfoPlanCta;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC()
        {
            InitializeComponent();
        }
        
        private void FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Combos();
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewParam_Conta_Cate__CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info row = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                row = (in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info)gridViewParam_Conta_Cate_.GetRow(e.RowHandle);
                if (row == null) return;

                if (e.Column == colIdCtaCble)
                {
                    if (MessageBox.Show("¿Esta seguro que desea actualizar la cuenta contable?", param.Nombre_sistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Bus_SubG.ActualizarDB(row);
                    }                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant frm = new FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_Mant();
                frm.event_delegate_FormClosed += frm_event_delegate_FormClosed;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {                
                List_SubG = new BindingList<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>(Bus_SubG.Get_List_Info_in_subgrupo(param.IdEmpresa));
                gridControlParam_conta_cate.DataSource = List_SubG;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControlParam_conta_cate.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Mostrar_relaciones_no_parametrizadas_Click(object sender, EventArgs e)
        {
            try
            {
                List_SubG = new BindingList<in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info>(Bus_SubG.Get_List_Info_in_subgrupo_no_parametrizados(param.IdEmpresa));
                        if (List_SubG.Count == 0) MessageBox.Show("No existen relaciones no parametrizadas", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                 
                gridControlParam_conta_cate.DataSource = List_SubG;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewParam_Conta_Cate__CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column == colIdCtaCble)
                {
                    gridViewParam_Conta_Cate_.SetRowCellValue(e.RowHandle, colIdCtaCble, e.Value);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrar_movimientos_Click(object sender, EventArgs e)
        {
            try
            {
                in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info row = new in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info();
                row = (in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info)gridViewParam_Conta_Cate_.GetFocusedRow();
                if (row!=null)
                {
                    Llamar_pantalla_movimientos(row);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Llamar_pantalla_movimientos(in_subgrupo_x_CentroCosto_x_SubCentroCosto_x_CtaCble_Info info)
        {
            try
            {
                FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_x_detalle_ing_egr frm = new FrmIn_Parametrizacion_Contable_x_Cate_gr_x_CC_x_SCC_x_detalle_ing_egr();
                frm.Set_parametros(param.IdEmpresa, info.IdCategoria, info.IdLinea, info.IdGrupo, info.IdSubgrupo, info.IdCentroCosto, info.IdSub_centro_costo);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
