using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using System.Windows.Forms;

namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_AreaCons : Form
    {
        #region Declaración de variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_area_Bus Bus = new ro_area_Bus();
        frmRo_AreaMant ofrm = new frmRo_AreaMant();
        ro_area_Info Info = new ro_area_Info();
        #endregion        

        public frmRo_AreaCons()
        {
            try
            {
                 InitializeComponent();
                    ofrm.Event_frmRo_AreaMant_FormClosing += new frmRo_AreaMant.delegate_frmRo_AreaMant_FormClosing(ofrm_Event_frmRo_AreaMant_FormClosing);
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_AreaMant();
                ofrm.Event_frmRo_AreaMant_FormClosing += new frmRo_AreaMant.delegate_frmRo_AreaMant_FormClosing(ofrm_Event_frmRo_AreaMant_FormClosing);
                ofrm._SetInfo = Info;
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_AreaMant();
                ofrm.Event_frmRo_AreaMant_FormClosing += new frmRo_AreaMant.delegate_frmRo_AreaMant_FormClosing(ofrm_Event_frmRo_AreaMant_FormClosing);
                ofrm._SetInfo = Info;
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_AreaMant();
                ofrm.Event_frmRo_AreaMant_FormClosing += new frmRo_AreaMant.delegate_frmRo_AreaMant_FormClosing(ofrm_Event_frmRo_AreaMant_FormClosing);
                ofrm._SetInfo = Info;
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ofrm = new frmRo_AreaMant();
                ofrm.Event_frmRo_AreaMant_FormClosing += new frmRo_AreaMant.delegate_frmRo_AreaMant_FormClosing(ofrm_Event_frmRo_AreaMant_FormClosing);
                ofrm.set_Accion(Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ofrm_Event_frmRo_AreaMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        void Cargar()
        {
            try
            {
                gridControlconsult.DataSource = Bus.ConsultaGeneral(param.IdEmpresa);
                gridViewCons.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        private void gridViewCons_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
               Info = (ro_area_Info)gridViewCons.GetFocusedRow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmRo_AreaCons_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log_Error_bus.Log_Error(ex.ToString());
            }            
        }

        private void gridViewCons_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            try
            {
                var data = gridViewCons.GetRow(e.RowHandle) as ro_area_Info;
                if (data == null)
                    return;

                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

    }
}
