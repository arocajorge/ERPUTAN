using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Winform.Compras;
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;
using Core.Erp.Winform.Controles;
using DevExpress.XtraGrid.Views.Grid;


namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_CotizacionCompra_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        com_cotizacion_compra_Bus BusCotiza = new com_cotizacion_compra_Bus();
        com_cotizacion_compra_Info InfoCotiza = new com_cotizacion_compra_Info();
        com_cotizacion_compra_Bus BusParam = new com_cotizacion_compra_Bus();
        com_cotizacion_compra_Info InfoParam = new com_cotizacion_compra_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<com_cotizacion_compra_Info> ListaosSolicitudCompra= new List<com_cotizacion_compra_Info>();
        public FrmPrd_CotizacionCompra_Consulta()
        {
            try
            {
                InitializeComponent();
               
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario1_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoCotiza = (com_cotizacion_compra_Info)gridViewcotizacion.GetFocusedRow();
                if (InfoCotiza == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_CotizacionCompra_Mantenimiento frm = new FrmPrd_CotizacionCompra_Mantenimiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.set_InfoCotiza(InfoCotiza);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();

                    frm.event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing += frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
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
                FrmPrd_CotizacionCompra_Mantenimiento frm = new FrmPrd_CotizacionCompra_Mantenimiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.getId(BusCotiza.getId(param.IdEmpresa));
                frm.Show();            
                frm.event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing+=frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoCotiza = (com_cotizacion_compra_Info)gridViewcotizacion.GetFocusedRow();
                if (InfoCotiza == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_CotizacionCompra_Mantenimiento frm = new FrmPrd_CotizacionCompra_Mantenimiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.actualizar);            
                    frm.set_InfoCotiza(InfoCotiza);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                
                    frm.event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing += frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoCotiza = (com_cotizacion_compra_Info)gridViewcotizacion.GetFocusedRow();
                if (InfoCotiza == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_CotizacionCompra_Mantenimiento frm = new FrmPrd_CotizacionCompra_Mantenimiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;                  
                    frm.set_InfoCotiza(InfoCotiza);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();
                    frm.event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing += frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
     
        private void FrmPrd_CotizacionCompra_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargaGridCotiza();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void cargaGridCotiza()
        {
            try
            {      ListaosSolicitudCompra=    BusCotiza.Get_List_cotizacion_compra(param.IdEmpresa);    
                gridControlcotizacion.DataSource = ListaosSolicitudCompra;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }  
        void frm_event_FrmPrd_CotizacionCompra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaGridCotiza();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewcotizacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoCotiza = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private com_cotizacion_compra_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (com_cotizacion_compra_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new com_cotizacion_compra_Info();
            }
        }

        private void gridViewcotizacion_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewcotizacion.GetRow(e.RowHandle) as com_cotizacion_compra_Info;
                if (data == null)
                    return;
                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

    }
}




