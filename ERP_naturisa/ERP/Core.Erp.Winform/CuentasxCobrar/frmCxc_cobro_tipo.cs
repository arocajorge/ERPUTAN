using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;


namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_cobro_tipo : Form
    {
        public frmCxc_cobro_tipo()
        {
            try
            {
             InitializeComponent();
             ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdCobro_tipo.ToString() == "") { MessageBox.Show("Elija un Registro antes de Continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                frmCxc_cobro_tipo_Mant frm = new frmCxc_cobro_tipo_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm.info = info;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                //cxc_cobro_tipo_Param_conta_x_sucursal_Bus bus = new cxc_cobro_tipo_Param_conta_x_sucursal_Bus();
                //List<cxc_cobro_tipo_Param_conta_x_sucursal_Info> LISTA = new List<cxc_cobro_tipo_Param_conta_x_sucursal_Info>();
                //LISTA = bus.obtenerTodasSucu(param.IdEmpresa, info.IdCobro_tipo);
                //frm.gridConsulta.DataSource = LISTA;
                frm.event_frmCo_cxc_cobro_tipo_Mant_FormClosing += new frmCxc_cobro_tipo_Mant.delegate_frmCo_cxc_cobro_tipo_Mant_FormClosing(frm_event_frmCo_cxc_cobro_tipo_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdCobro_tipo.ToString() == "") { MessageBox.Show("Elija un Registro antes de Continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                frmCxc_cobro_tipo_Mant frm = new frmCxc_cobro_tipo_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.info = info;
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmCxc_cobro_tipo_Mant frm = new frmCxc_cobro_tipo_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmCo_cxc_cobro_tipo_Mant_FormClosing += new frmCxc_cobro_tipo_Mant.delegate_frmCo_cxc_cobro_tipo_Mant_FormClosing(frm_event_frmCo_cxc_cobro_tipo_Mant_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();


        private Cl_Enumeradores.eTipo_action _Accion;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cxc_cobro_tipo_Info info = new cxc_cobro_tipo_Info();
        cxc_cobro_tipo_Bus bus = new cxc_cobro_tipo_Bus();
        private void frmCo_cxc_cobro_tipo_Load(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadGrid() {
            try
            {
                gridConsulta.DataSource = bus.Get_List_Cobro_Tipo();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private cxc_cobro_tipo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (cxc_cobro_tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new cxc_cobro_tipo_Info();
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        void frm_event_frmCo_cxc_cobro_tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 


        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView1.GetRow(e.RowHandle) as cxc_cobro_tipo_Info;
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

        
        



    
    }
        
}
