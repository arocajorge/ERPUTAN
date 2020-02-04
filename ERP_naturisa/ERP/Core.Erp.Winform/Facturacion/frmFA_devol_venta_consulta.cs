using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Facturacion;
using Core.Erp.Info.Facturacion;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;

namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_devol_venta_consulta : Form
    {


        #region "Declarion Variables"
                tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
                fa_devol_venta_Bus bus = new fa_devol_venta_Bus();
                List<fa_factura_Info> lista = new List<fa_factura_Info>();
                fa_factura_Info info = new fa_factura_Info();
                fa_devol_venta_Info infoDev = new fa_devol_venta_Info();
                UCIn_Sucursal_Bodega UCSucursal = new UCIn_Sucursal_Bodega();
                private Cl_Enumeradores.eTipo_action _Accion;
                cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
                string msg = "";
        #endregion



        public frmFa_devol_venta_consulta()
        {
            try
            {
                 InitializeComponent();
                UCSucursal.Event_cmb_bodega_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_bodega_SelectionChangeCommitted(UCSucursal_Event_cmb_bodega_SelectionChangeCommitted);
                UCSucursal.Event_cmb_sucursal_SelectionChangeCommitted += new UCIn_Sucursal_Bodega.delegate_cmb_sucursal_SelectionChangeCommitted(UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridView_devVta.ShowPrintPreview();

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
                frmFa_devol_venta_mant frm = new frmFa_devol_venta_mant();
                if (infoDev == null)
                {
                    MessageBox.Show("Seleccione la Devolucion a Consultar", "Sistemas");
                }
                else
                {
                    frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.MdiParent = this.MdiParent;
                    frm.rbNumDoc.Checked = false;
                    frm.Info_DevolucionVenta = infoDev;
                    frm.Show();
                    frm.event_FrmClose += new frmFa_devol_venta_mant.Delegate_FrmClose(frm_event_FrmClose);
                }
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (infoDev.Estado == "I") 
                { 
                    MessageBox.Show("Devolucion # " + infoDev.IdDevolucion + " de la Factura # " + infoDev.vt_NumFactura + " esta Anulada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                    return; 
                }
                frmFa_devol_venta_mant frm = new frmFa_devol_venta_mant();
                if (infoDev == null)
                {
                    MessageBox.Show("Seleccione la Devolucion a Consultar", "Sistemas");
                }
                else
                {
                    frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.MdiParent = this.MdiParent;
                    frm.rbNumDoc.Checked = false;
                    frm.Info_DevolucionVenta = infoDev;
                    frm.Show();
                    frm.event_FrmClose += new frmFa_devol_venta_mant.Delegate_FrmClose(frm_event_FrmClose);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

   
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                
                gridConsultaCot.DataSource = bus.Get_List_devol_venta(param.IdEmpresa
                  , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                  , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                  , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
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
                frmFa_devol_venta_mant frm = new frmFa_devol_venta_mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmClose += new frmFa_devol_venta_mant.Delegate_FrmClose(frm_event_FrmClose);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void UCSucursal_Event_cmb_sucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
              loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void UCSucursal_Event_cmb_bodega_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmFA_devol_venta_consulta_Load(object sender, EventArgs e)
        {
            try
            {               
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString()); 
            }
        }

        public void loadGrid()
        {
            try
            {

                gridConsultaCot.DataSource = bus.Get_List_devol_venta(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private fa_devol_venta_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (fa_devol_venta_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_devol_venta_Info();
            }
        }

        void frm_event_FrmClose(object sender, FormClosingEventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                infoDev = new fa_devol_venta_Info();
                infoDev = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridView_devVta.GetRow(e.RowHandle) as fa_devol_venta_Info;
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





    }
}
