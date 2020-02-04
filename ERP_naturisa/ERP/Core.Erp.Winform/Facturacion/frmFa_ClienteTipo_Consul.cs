using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_ClienteTipo_Consul : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<fa_cliente_tipo_Info> lstInfo = new List<fa_cliente_tipo_Info>();
        fa_cliente_tipo_Bus busCli = new fa_cliente_tipo_Bus();
        fa_cliente_tipo_Info Info = new fa_cliente_tipo_Info();
        frmFa_ClienteTipo_Mant frm = new frmFa_ClienteTipo_Mant();

        public frmFa_ClienteTipo_Consul()
        {
            InitializeComponent();
            ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_event_btnAnular_ItemClick;
            ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_event_btnconsultar_ItemClick;
            ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_event_btnModificar_ItemClick;
            ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_event_btnNuevo_ItemClick;
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmFa_ClienteTipo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
                frm.event_frmFa_ClienteTipo_Mant_FormClosing += new frmFa_ClienteTipo_Mant.delegate_frmFa_ClienteTipo_Mant_FormClosing(frm_event_frmFa_ClienteTipo_Mant_FormClosing);                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFa_ClienteTipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargarGrid();
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
                Info = (fa_cliente_tipo_Info)gridViewClienteTipo.GetFocusedRow();

                if (Info.Idtipo_cliente == 0)
                {
                    return; 
                }
                //if (Info.estado == "I")
                //{
                //    MessageBox.Show("El registro se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}
                frm = new frmFa_ClienteTipo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);                
                frm.setInfo(Info);
                frm.Show();
                frm.event_frmFa_ClienteTipo_Mant_FormClosing += new frmFa_ClienteTipo_Mant.delegate_frmFa_ClienteTipo_Mant_FormClosing(frm_event_frmFa_ClienteTipo_Mant_FormClosing);                        
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
                Info = (fa_cliente_tipo_Info)gridViewClienteTipo.GetFocusedRow();
                if (Info.Idtipo_cliente == 0) { return; }
                
                frm = new frmFa_ClienteTipo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                frm.setInfo(Info);
                frm.Show();
                frm.event_frmFa_ClienteTipo_Mant_FormClosing += new frmFa_ClienteTipo_Mant.delegate_frmFa_ClienteTipo_Mant_FormClosing(frm_event_frmFa_ClienteTipo_Mant_FormClosing);                        
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
                Info = (fa_cliente_tipo_Info)gridViewClienteTipo.GetFocusedRow();
                if (Info.Idtipo_cliente == 0) { return; }
                if (Info.estado == "I")
                {
                    MessageBox.Show("El registro se encuentra anulado", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                frm = new frmFa_ClienteTipo_Mant();
                frm.MdiParent = this.MdiParent;
                frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                frm.setInfo(Info);
                frm.Show();
                frm.event_frmFa_ClienteTipo_Mant_FormClosing += new frmFa_ClienteTipo_Mant.delegate_frmFa_ClienteTipo_Mant_FormClosing(frm_event_frmFa_ClienteTipo_Mant_FormClosing);                        

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cargarGrid()
        {
            try
            {
                lstInfo = busCli.Get_List_fa_cliente_tipo(param.IdEmpresa);
                gridClienteTipo.DataSource = lstInfo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFa_ClienteTipo_Consul_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewClienteTipo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewClienteTipo.GetRow(e.RowHandle) as fa_cliente_tipo_Info;
                if (data == null)
                    return;

                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridViewClienteTipo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                //Info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                Info = (fa_cliente_tipo_Info)gridViewClienteTipo.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private fa_cliente_tipo_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (fa_cliente_tipo_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new fa_cliente_tipo_Info();
            }
        }
    }
}
