using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Winform.CuentasxPagar
{
    public partial class frmCP_Conciliacion_Ing_Bod_x_OG_Consul : DevExpress.XtraEditors.XtraForm
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus busConci = new cp_Conciliacion_Ing_Bodega_x_Orden_Giro_Bus();
        List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info> lstInfo = new List<vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info>();
        vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info Info = new vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();

        public frmCP_Conciliacion_Ing_Bod_x_OG_Consul()
        {
            InitializeComponent();
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;

        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info.IdConciliacion == 0) { return; }
                if (Info.Estado == "I")
                {
                    MessageBox.Show("El registro se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frmCP_Conciliacion_Ing_Bod_x_OG_Mant frm = new frmCP_Conciliacion_Ing_Bod_x_OG_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                frm._InfoConci = busConci.Get_Info_Conciliacion_Ing(Info.IdEmpresa, Info.IdConciliacion);
                frm.set_Info();
                frm.Show();
                frm.event_delegate_frmCP_Conciliacion += new frmCP_Conciliacion_Ing_Bod_x_OG_Mant.delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(frm_event_delegate_frmCP_Conciliacion); 
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

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCP_Conciliacion_Ing_Bod_x_OG_Mant frm = new frmCP_Conciliacion_Ing_Bod_x_OG_Mant();
                frm.MdiParent = this.MdiParent; ;
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
                frm.event_delegate_frmCP_Conciliacion += new frmCP_Conciliacion_Ing_Bod_x_OG_Mant.delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(frm_event_delegate_frmCP_Conciliacion); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_delegate_frmCP_Conciliacion(object sender, FormClosingEventArgs e)
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

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info.IdConciliacion == 0) { return; }
                frmCP_Conciliacion_Ing_Bod_x_OG_Mant frm = new frmCP_Conciliacion_Ing_Bod_x_OG_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm._InfoConci = busConci.Get_Info_Conciliacion_Ing(Info.IdEmpresa, Info.IdConciliacion);
                frm.set_Info();
                frm.Show();
                frm.event_delegate_frmCP_Conciliacion += new frmCP_Conciliacion_Ing_Bod_x_OG_Mant.delegate_frmCP_Conciliacion_Ing_Bod_x_OG_Mant_FormClosing(frm_event_delegate_frmCP_Conciliacion); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnBuscar_Click(object sender, EventArgs e)
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

        private void frmCP_Conciliacion_Ing_Bod_x_OG_Consul_Load(object sender, EventArgs e)
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


        void CargarGrid()
        {
            try
            {
                lstInfo = busConci.Get_List_Conciliacion(param.IdEmpresa, ucGe_Menu.fecha_desde , ucGe_Menu.fecha_hasta);
                gridConciliacion_Ing_OC.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewConciliacion_Ing_OC_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewConciliacion_Ing_OC.GetRow(e.RowHandle) as vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info;
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

        private void gridViewConciliacion_Ing_OC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new vwcp_Conciliacion_Ing_Bodega_x_Orden_Giro_Info();
            }
        }


    }
}