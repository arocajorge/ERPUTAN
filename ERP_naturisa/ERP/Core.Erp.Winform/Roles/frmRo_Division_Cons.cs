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
using Core.Erp.Business.General;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Division_Cons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_division_Bus Bus = new ro_division_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmRo_DivisionMatn ofrm = new frmRo_DivisionMatn();
        ro_division_Info Info = new ro_division_Info();
        #endregion

        public frmRo_Division_Cons()
        {
            try
            {
                InitializeComponent();
                ofrm.Event_frmRo_DivisionMatn_FormClosing += new frmRo_DivisionMatn.Delegate_frmRo_DivisionMatn_FormClosing(ofrm_Event_frmRo_DivisionMatn_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_DivisionMatn();
                ofrm.Event_frmRo_DivisionMatn_FormClosing += new frmRo_DivisionMatn.Delegate_frmRo_DivisionMatn_FormClosing(ofrm_Event_frmRo_DivisionMatn_FormClosing);
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_DivisionMatn();
                ofrm.Event_frmRo_DivisionMatn_FormClosing += new frmRo_DivisionMatn.Delegate_frmRo_DivisionMatn_FormClosing(ofrm_Event_frmRo_DivisionMatn_FormClosing);
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm._SetInfo = Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            } 
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_DivisionMatn();
                ofrm.Event_frmRo_DivisionMatn_FormClosing += new frmRo_DivisionMatn.Delegate_frmRo_DivisionMatn_FormClosing(ofrm_Event_frmRo_DivisionMatn_FormClosing);
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm._SetInfo = Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }  
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_DivisionMatn();
                ofrm.Event_frmRo_DivisionMatn_FormClosing += new frmRo_DivisionMatn.Delegate_frmRo_DivisionMatn_FormClosing(ofrm_Event_frmRo_DivisionMatn_FormClosing);
                if (Info.estado == "I")
                {
                    MessageBox.Show("El Registro ya se Encuentra Anulado");
                }
                else
                {
                    ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                    ofrm._SetInfo = Info;
                    ofrm.MdiParent = this.MdiParent;
                    ofrm.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void ofrm_Event_frmRo_DivisionMatn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        void CargarGrid()
        {
            try
            {
                gridControlconsult.DataSource = Bus.ConsultaGeneral(param.IdEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void frmRo_Division_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                    CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void gridViewCons_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
              Info = (ro_division_Info)gridViewCons.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void gridViewCons_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewCons.GetRow(e.RowHandle) as ro_division_Info;
                if (data == null)
                    return;

                if (data.estado == "I")
                    e.Appearance.ForeColor = Color.Red;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.Message);
            }
        }

    }
}
