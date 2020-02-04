using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Vendedor_cons : Form
    {
        #region Declaración de variables
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public fa_Vendedor_Info info = new fa_Vendedor_Info();
        #endregion

        public frmFa_Vendedor_cons()
        {
            try
            {
                InitializeComponent();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info.IdVendedor != 0)
                {
                    frmFa_Vendedor_Mant frm = new frmFa_Vendedor_Mant();
                    frm.event_frmFa_Vendedor_Mant_FormClosing += frm_event_frmFa_Vendedor_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.set_Vendedor(info);
                    frm.ShowDialog();
                    load_Vendedores();
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a Anular", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frm_event_frmFa_Vendedor_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                load_Vendedores();
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
                if (info.IdVendedor != 0)
                {
                    frmFa_Vendedor_Mant frm = new frmFa_Vendedor_Mant();                    
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.set_Vendedor(info);
                    frm.ShowDialog();
                    frm.event_frmFa_Vendedor_Mant_FormClosing += frm_event_frmFa_Vendedor_Mant_FormClosing;
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a consultar", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (info.IdVendedor != 0)
                {
                    frmFa_Vendedor_Mant frm = new frmFa_Vendedor_Mant();                    
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Vendedor(info);
                    frm.ShowDialog();
                    frm.event_frmFa_Vendedor_Mant_FormClosing += frm_event_frmFa_Vendedor_Mant_FormClosing;
                    load_Vendedores();
                }
                else
                    MessageBox.Show("Por favor, seleccione un item a modificar", "ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                frmFa_Vendedor_Mant frm = new frmFa_Vendedor_Mant();                
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.ShowDialog();
                frm.event_frmFa_Vendedor_Mant_FormClosing += frm_event_frmFa_Vendedor_Mant_FormClosing;
                load_Vendedores();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_Vendedores()
        {
            try
            {
                fa_Vendedor_Bus vendedor_bus = new fa_Vendedor_Bus();
                List<fa_Vendedor_Info> lista_vendedor = new List<fa_Vendedor_Info>();
                lista_vendedor = vendedor_bus.Get_List_Vendedores(param.IdEmpresa);
                gridControl_Vendedor.DataSource = lista_vendedor;
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Vendedor_General_Load(object sender, EventArgs e)
        {
            try
            {
                load_Vendedores();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_Vendedor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UltraGrid_Vendedor_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_Vendedor.GetRow(e.RowHandle) as fa_Vendedor_Info;
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

        private void UltraGrid_Vendedor_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
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

        private fa_Vendedor_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (fa_Vendedor_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new fa_Vendedor_Info();
            }
        }
    }
}
