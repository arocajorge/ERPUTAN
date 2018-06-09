using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_pedidoProducto_Consulta : Form
    {
        public frmpre_pedidoProducto_Consulta()
        {

            try
            {
                InitializeComponent();
                repositoryItemSearchLookUpEdit_Prove.DataSource = proveedorB.Get_List_proveedor(param.IdEmpresa);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
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
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.grabar, PedidoPre_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.actualizar, PedidoPre_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.consultar, PedidoPre_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.Anular, PedidoPre_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        pre_PedidoXPresupuesto_Bus PedidoPre_B = new pre_PedidoXPresupuesto_Bus();
        pre_PedidoXPresupuesto_Info PedidoPre_I = new pre_PedidoXPresupuesto_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmpre_pedidoProducto frm;

        public void load_data()
        {
            try
            {
                gridControl_pedidoXpresupuesto.DataSource = PedidoPre_B.ObtenerList(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmpre_pedidoProducto_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                List<ro_Departamento_Info> depaInfo = new List<ro_Departamento_Info>();
                ro_Departamento_Bus depaBus = new ro_Departamento_Bus();
                depaInfo = depaBus.Get_List_Departamento(param.IdEmpresa);
                repositoryItemSearchLookUpEdit_departamento.DataSource = depaInfo;
                load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void UltraGrid_pedidoXpresupuesto_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_pedidoXpresupuesto.GetRow(e.RowHandle) as pre_PedidoXPresupuesto_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void UltraGrid_pedidoXpresupuesto_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                 PedidoPre_I = (pre_PedidoXPresupuesto_Info)UltraGrid_pedidoXpresupuesto.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void llamaFrmMant(Cl_Enumeradores.eTipo_action Accion, pre_PedidoXPresupuesto_Info Info)
        {
            try
            {
                frm  = new frmpre_pedidoProducto();
                frm.event_frmpre_pedidoProducto_FormClosing += new frmpre_pedidoProducto.delegate_frmpre_pedidoProducto_FormClosing(frm_event_frmpre_pedidoProducto_FormClosing);
                frm.MdiParent = this.MdiParent;
                frm.set_accion(Accion);
               
                frm.Show();
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                    frm.set_pedido(Info);

                }
             
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_frmpre_pedidoProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
             load_data();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
