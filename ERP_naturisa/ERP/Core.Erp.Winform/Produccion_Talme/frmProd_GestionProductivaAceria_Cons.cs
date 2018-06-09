using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Talme;


namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_GestionProductivaAceria_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        prod_GestionProductivaAcero_CusTalme_Bus Bus = new prod_GestionProductivaAcero_CusTalme_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmProd_GestionProductivaAceria ofrm = new frmProd_GestionProductivaAceria();


        public frmProd_GestionProductivaAceria_Cons()
        {
            try
            {
                InitializeComponent();
                ofrm.Event_frmProd_GestionProductivaAceria_FormClosing += new frmProd_GestionProductivaAceria.Delegate_frmProd_GestionProductivaAceria_FormClosing(ofrm_Event_frmProd_GestionProductivaAceria_FormClosing);
                CargarGrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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
                ofrm = new frmProd_GestionProductivaAceria();
                ofrm.Event_frmProd_GestionProductivaAceria_FormClosing += new frmProd_GestionProductivaAceria.Delegate_frmProd_GestionProductivaAceria_FormClosing(ofrm_Event_frmProd_GestionProductivaAceria_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm._SetInfo = _Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
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
                Close();
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
                gridControl.ShowRibbonPrintPreview();
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
                CargarGrid();
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
                ofrm = new frmProd_GestionProductivaAceria();
                ofrm.Event_frmProd_GestionProductivaAceria_FormClosing += new frmProd_GestionProductivaAceria.Delegate_frmProd_GestionProductivaAceria_FormClosing(ofrm_Event_frmProd_GestionProductivaAceria_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm._SetInfo = _Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
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
                ofrm = new frmProd_GestionProductivaAceria();
                ofrm.Event_frmProd_GestionProductivaAceria_FormClosing += new frmProd_GestionProductivaAceria.Delegate_frmProd_GestionProductivaAceria_FormClosing(ofrm_Event_frmProd_GestionProductivaAceria_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ofrm_Event_frmProd_GestionProductivaAceria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 CargarGrid();
            }
            catch (Exception ex)
            {
                   Log_Error_bus.Log_Error(ex.ToString());
            }
    
        }

      
        void CargarGrid() 
        {
            try
            {
               // gridControl.DataSource = Bus.ConsultaGenera(param.IdEmpresa, Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString()));
                gridControl.DataSource = Bus.ConsultaGenera(param.IdEmpresa
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde)
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta));
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}

        prod_GestionProductivaAcero_CusTalme_Info _Info = new prod_GestionProductivaAcero_CusTalme_Info();
        
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _Info = (prod_GestionProductivaAcero_CusTalme_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }
    }
}
