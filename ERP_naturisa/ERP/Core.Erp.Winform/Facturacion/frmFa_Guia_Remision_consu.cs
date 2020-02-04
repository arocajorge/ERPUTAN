using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.General;
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using Core.Erp.Business.General;
using Core.Erp.Winform.General;


namespace Core.Erp.Winform.Facturacion
{
    public partial class frmFa_Guia_Remision_consu : Form
    {
        public frmFa_Guia_Remision_consu()
        {
            try
            {
               InitializeComponent();
                Ofrm.Event_frmFA_Guia_Remision_Mant_FormClosing += new frmFa_Guia_Remision_Mant.Delegate_frmFA_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ultrGuiaRemision1.ShowRibbonPrintPreview();
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

                Ofrm = new frmFa_Guia_Remision_Mant();
                Ofrm.Event_frmFA_Guia_Remision_Mant_FormClosing += new frmFa_Guia_Remision_Mant.Delegate_frmFA_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing);
                Ofrm.SetInfo = info;
                Ofrm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
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
                Ofrm = new frmFa_Guia_Remision_Mant();
                Ofrm.Event_frmFA_Guia_Remision_Mant_FormClosing += new frmFa_Guia_Remision_Mant.Delegate_frmFA_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing);
                Ofrm.SetInfo = info;
                Ofrm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
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
                Ofrm = new frmFa_Guia_Remision_Mant();
                Ofrm.Event_frmFA_Guia_Remision_Mant_FormClosing += new frmFa_Guia_Remision_Mant.Delegate_frmFA_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing);
                Ofrm.SetInfo = info;
                Ofrm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
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

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Ofrm = new frmFa_Guia_Remision_Mant();
                Ofrm.Event_frmFA_Guia_Remision_Mant_FormClosing += new frmFa_Guia_Remision_Mant.Delegate_frmFA_Guia_Remision_Mant_FormClosing(Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing);

                Ofrm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                Ofrm.MdiParent = this.MdiParent;
                Ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }
        }

        void Ofrm_Event_frmFA_Guia_Remision_Mant_FormClosing(object sender, FormClosingEventArgs e)
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
        frmFa_Guia_Remision_Mant Ofrm = new frmFa_Guia_Remision_Mant();

        #region Declaraciones
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        UCIn_Sucursal_Bodega ctrl_SucBod = new UCIn_Sucursal_Bodega();
        tb_Sucursal_Info _SucursalInfo = new tb_Sucursal_Info();
        tb_Bodega_Info _BodegaInfo = new tb_Bodega_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        fa_guia_remision_Bus oBus = new fa_guia_remision_Bus();
        fa_guia_remision_Info info = new fa_guia_remision_Info();
        #endregion
        #region Eventos

        private void frmFA_Guia_Remision_Load(object sender, EventArgs e)
        {
            try
            {
                //dtpFechaIni.Value = DateTime.Now.AddDays(-30);
                //pnlBodegaSucrusal.Dock = DockStyle.Fill;
                //ctrl_SucBod.TipoCarga = Cl_Enumeradores.eTipoFiltro.todos;
                
                //pnlBodegaSucrusal.Controls.Add(ctrl_SucBod);
                CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }

        
        private void gridViewGuiaRemision_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGuiaRemision.GetRow(e.RowHandle) as fa_guia_remision_Info;
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

        private void gridViewGuiaRemision_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                  info = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
        #endregion
        #region Funciones

        public void CargarGrid()
        {
            try
            {
                List<fa_guia_remision_Info> lst = new List<fa_guia_remision_Info>();

                lst = oBus.Get_List_guia_remision(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);

                var order = from q in lst
                            orderby q.IdGuiaRemision descending
                            select q;

                ultrGuiaRemision1.DataSource = order.ToList();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }
        }


        private fa_guia_remision_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {

            try
            {
                 return (fa_guia_remision_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new fa_guia_remision_Info();
            }
        }
        
        #endregion


    
    
    }
}
