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
    public partial class frmProd_GestionProductivaTechos_Consulta : Form
    {
        public frmProd_GestionProductivaTechos_Consulta()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
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
                Close();
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
                ofrm = new frmProd_GestionProductivaTechos();
                ofrm.Event_frmProd_GestionProductivaTechos_FormClosing += new frmProd_GestionProductivaTechos.delegate_frmProd_GestionProductivaTechos_FormClosing(ofrm_Event_frmProd_GestionProductivaTechos_FormClosing);
                ofrm.setAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm._SetInfo = Info;
                ofrm.Show();
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
                ofrm = new frmProd_GestionProductivaTechos();
                ofrm.Event_frmProd_GestionProductivaTechos_FormClosing += new frmProd_GestionProductivaTechos.delegate_frmProd_GestionProductivaTechos_FormClosing(ofrm_Event_frmProd_GestionProductivaTechos_FormClosing);
                ofrm.setAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm._SetInfo = Info;
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
                ofrm = new frmProd_GestionProductivaTechos();
                ofrm.Event_frmProd_GestionProductivaTechos_FormClosing += new frmProd_GestionProductivaTechos.delegate_frmProd_GestionProductivaTechos_FormClosing(ofrm_Event_frmProd_GestionProductivaTechos_FormClosing);
                ofrm.setAccion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm._SetInfo = Info;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmProd_GestionProductivaTechos ofrm = new frmProd_GestionProductivaTechos(); 
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_GestionProductivaTechos_CusTalme_Cab_Bus Bus = new prod_GestionProductivaTechos_CusTalme_Cab_Bus();

        private void frmProd_GestionProductivaTechos_Consulta_Load(object sender, EventArgs e)
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
                DateTime FechaInf =Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde);
                DateTime FechaFin =Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControl.DataSource = Bus.ConsultaGeneral(param.IdEmpresa, FechaInf, FechaFin);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ofrm_Event_frmProd_GestionProductivaTechos_FormClosing(object sender, FormClosingEventArgs e)
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

        prod_GestionProductivaTechos_CusTalme_Cab_Info Info = new prod_GestionProductivaTechos_CusTalme_Cab_Info();
       
        
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               Info = (prod_GestionProductivaTechos_CusTalme_Cab_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

     
    }
}
