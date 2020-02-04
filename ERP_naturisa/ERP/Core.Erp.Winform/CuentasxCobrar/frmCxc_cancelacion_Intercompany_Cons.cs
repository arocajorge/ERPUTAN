using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;

///Prog: Derek Mejia
///V 22 02 2014 12.18

//ULT. MOD = DEREK MEJIA 12/02/2014
namespace Core.Erp.Winform.CuentasxCobrar
{
    public partial class frmCxc_cancelacion_Intercompany_Cons : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        BindingList<cxc_cancelacion_Intercompany_Info> BLinterCompInfo = new BindingList<cxc_cancelacion_Intercompany_Info>();
        cxc_cancelacion_Intercompany_Bus interCompBus = new cxc_cancelacion_Intercompany_Bus();
        cxc_cancelacion_Intercompany_Info info = new cxc_cancelacion_Intercompany_Info();
        //
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmCxc_cancelacion_Intercompany_Mant mant = new frmCxc_cancelacion_Intercompany_Mant();

        public frmCxc_cancelacion_Intercompany_Cons()
        {
            try
            {
              InitializeComponent();
              ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
              ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
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
                llama_frm(Cl_Enumeradores.eTipo_action.Anular);
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
                gridViewCancelacion.ShowPrintPreview();
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
                llama_frm(Cl_Enumeradores.eTipo_action.consultar);
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
                llama_frm(Cl_Enumeradores.eTipo_action.actualizar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llama_frm(Cl_Enumeradores.eTipo_action.grabar);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }


        public void load() {
            try
            {
                BLinterCompInfo = new BindingList<cxc_cancelacion_Intercompany_Info>(interCompBus.Get_List_cancelacion_Intercompany(param.IdEmpresa));
                gridControlCancelacion.DataSource = BLinterCompInfo;
            }
            catch (Exception ex) 
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }

        private void llama_frm(Cl_Enumeradores.eTipo_action Accion)
        {
            try
            {
                mant = new frmCxc_cancelacion_Intercompany_Mant();
                mant.event_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing += new frmCxc_cancelacion_Intercompany_Mant.delegate_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing(frm_event_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing);
                mant.MdiParent = this.MdiParent;

                if (Accion != Cl_Enumeradores.eTipo_action.grabar)
                {
                    mant.SETINFO_ = info;
                }
                mant.set_Accion(Accion);
                mant.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void frm_event_frmCo_cxc_cancelacion_Intercompany_Mant_FormClosing()
        {
            try
            {
               load();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }




        private void gridViewCancelacion_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewCancelacion.GetRow(e.RowHandle) as cxc_cancelacion_Intercompany_Info;
                if (data == null)
                    return;
                if (data.cr_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void gridViewCancelacion_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                info = new cxc_cancelacion_Intercompany_Info();
                info = (cxc_cancelacion_Intercompany_Info)gridViewCancelacion.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }     

        private void frmCo_cxc_cancelacion_Intercompany_Cons_Load_2(object sender, EventArgs e)
        {
            try
            {
                load();
            }
            catch (Exception ex)
            {
                    Log_Error_bus.Log_Error(ex.ToString());
            }

        }




    }
}
