using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Info.Produccion_Talme;

namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_ComprasChatarra_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prod_CompraChatarra_CusTalme_Bus Bus = new prod_CompraChatarra_CusTalme_Bus();
        frmProd_ComprasChatarra ofrm;
        public frmProd_ComprasChatarra_Consulta()
        {
            try
            {
                 InitializeComponent();
                ofrm = new frmProd_ComprasChatarra();
                ofrm.Evente_frmProd_ComprasChatarra_FormClosing += new frmProd_ComprasChatarra.delegate_frmProd_ComprasChatarra_FormClosing(ofrm_Evente_frmProd_ComprasChatarra_FormClosing);
                CargarGrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
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
                llamaFRM(Info.General.Cl_Enumeradores.eTipo_action.consultar);               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void llamaFRM(Info.General.Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                ofrm = new frmProd_ComprasChatarra();
                ofrm.MdiParent = this.MdiParent;
                ofrm.setAccion(Accion);
                ofrm.Evente_frmProd_ComprasChatarra_FormClosing += new frmProd_ComprasChatarra.delegate_frmProd_ComprasChatarra_FormClosing(ofrm_Evente_frmProd_ComprasChatarra_FormClosing);
                if (Accion != Info.General.Cl_Enumeradores.eTipo_action.grabar)
                {
                    ofrm._SetInfo = _Info;
                }
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFRM(Info.General.Cl_Enumeradores.eTipo_action.Anular);      
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFRM(Info.General.Cl_Enumeradores.eTipo_action.grabar);    
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ofrm_Evente_frmProd_ComprasChatarra_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_buscar_Click(object sender, EventArgs e){}


        void CargarGrid()
        {
            try
            {
                 //gridControl.DataSource = Bus.ConsultaGeneral(param.IdEmpresa, Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString()), Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString()));        
                gridControl.DataSource = Bus.ConsultaGeneral(param.IdEmpresa
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_desde)
                    , Convert.ToDateTime(ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta));        
          
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }
         
        
        private void frmProd_ComprasChatarra_Consulta_Load(object sender, EventArgs e){}

     
        prod_CompraChatarra_CusTalme_Info _Info = new prod_CompraChatarra_CusTalme_Info();
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                 _Info = (prod_CompraChatarra_CusTalme_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

       
        private void gridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e){}

    }
}
