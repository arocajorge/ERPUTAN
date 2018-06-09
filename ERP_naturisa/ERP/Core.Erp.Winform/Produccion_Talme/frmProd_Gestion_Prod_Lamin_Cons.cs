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
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_Gestion_Prod_Lamin_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        prod_GestionProductivaLaminado_CusTalme_Bus _BusProd_B = new prod_GestionProductivaLaminado_CusTalme_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmProd_Gestion_Prod_Lamin_Mant frm = new frmProd_Gestion_Prod_Lamin_Mant();


        public frmProd_Gestion_Prod_Lamin_Cons()
        {
            try
            {
                  InitializeComponent();
             frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
             ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
             ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmProd_Gestion_Prod_Lamin_Mant();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridControlOrdeCompra.ShowRibbonPrintPreview();
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
                MessageBox.Show(ex.ToString());
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmProd_Gestion_Prod_Lamin_Mant frm = new frmProd_Gestion_Prod_Lamin_Mant();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmProd_Gestion_Prod_Lamin_Mant();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frm = new frmProd_Gestion_Prod_Lamin_Mant();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_Event_frmProd_Diaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        public void CargarGrid() 
        {
            try
            {
                DateTime FechaIni = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde);
                DateTime FechaFin = Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlOrdeCompra.DataSource = _BusProd_B.ConulstaGenerla(param.IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        prod_GestionProductivaLaminado_CusTalme_Info _Info = new prod_GestionProductivaLaminado_CusTalme_Info();
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                _Info = (prod_GestionProductivaLaminado_CusTalme_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmProd_Diara_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Gestion_Prod_Lamin_Mant.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }


        
    }
}
