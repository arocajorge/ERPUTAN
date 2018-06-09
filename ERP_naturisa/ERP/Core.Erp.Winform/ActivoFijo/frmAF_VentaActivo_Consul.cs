using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Business.ActivoFijo;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.ActivoFijo
{
    public partial class frmAF_VentaActivo_Consul : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        Af_Venta_Activo_Bus busVta = new Af_Venta_Activo_Bus();
        List<Af_Venta_Activo_Info> lstInfo = new List<Af_Venta_Activo_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        Af_Venta_Activo_Info InfoAf = new Af_Venta_Activo_Info();

        public frmAF_VentaActivo_Consul()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
            ucGe_Menu.event_btnBuscar_Click += ucGe_Menu_event_btnBuscar_Click;
            ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_event_btnSalir_ItemClick;
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {                
                frmAF_VentaActivo_Mant frm = new frmAF_VentaActivo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
                frm.event_FormClosed += new frmAF_VentaActivo_Mant.delegate_FormClosed(frm_event_FormClosed);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAf.IdVtaActivo == 0) { return; }
                if (InfoAf.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmAF_VentaActivo_Mant frm = new frmAF_VentaActivo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                frm._Info = busVta.Get_Info_Venta_Activo(InfoAf.IdEmpresa, InfoAf.IdVtaActivo);                
                frm.Show();
                frm.event_FormClosed += new frmAF_VentaActivo_Mant.delegate_FormClosed(frm_event_FormClosed);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAf.IdVtaActivo == 0) { return; }                
                frmAF_VentaActivo_Mant frm = new frmAF_VentaActivo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm._Info = busVta.Get_Info_Venta_Activo(InfoAf.IdEmpresa, InfoAf.IdVtaActivo);                
                frm.Show();
                frm.event_FormClosed += new frmAF_VentaActivo_Mant.delegate_FormClosed(frm_event_FormClosed);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoAf.IdVtaActivo == 0) { return; }
                if (InfoAf.Estado == "I")
                {
                    MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.El_registro_se_encuentra_anulado), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                frmAF_VentaActivo_Mant frm = new frmAF_VentaActivo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                frm._Info = busVta.Get_Info_Venta_Activo (InfoAf.IdEmpresa, InfoAf.IdVtaActivo);                
                frm.Show();
                frm.event_FormClosed += new frmAF_VentaActivo_Mant.delegate_FormClosed(frm_event_FormClosed);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_FormClosed(object sender, FormClosingEventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarGrid()
        {
            try
            {
                lstInfo = busVta.Get_List_Venta_Activo(param.IdEmpresa , ucGe_Menu.fecha_desde, ucGe_Menu.fecha_hasta);
                gridVentaActivo.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAF_VentaActivo_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewVentaActivo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewVentaActivo.GetRow(e.RowHandle) as Af_Venta_Activo_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewVentaActivo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                InfoAf = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Af_Venta_Activo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (Af_Venta_Activo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Af_Venta_Activo_Info();
            }
        }

        private void gridViewVentaActivo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoAf = gridViewVentaActivo.GetRow(e.FocusedRowHandle) as Af_Venta_Activo_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
