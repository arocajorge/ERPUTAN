using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Turno_Cons : Form
    {
        #region Declaración de Variables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_turno_Info Info = new ro_turno_Info();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        ro_turno_Bus Turno_bus = new ro_turno_Bus();
        #endregion

        public frmRo_Turno_Cons()
        {
            try
            {
                InitializeComponent();
                cargagrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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
                MessageBox.Show(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmRo_Turno_Mant();

                frmMant.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
               // frmMant.MdiParent = MdiParent;
               // frmMant.Show();

                frmMant.ShowDialog();

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
                var Info = (ro_turno_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {

                    frmMant = new frmRo_Turno_Mant();
                    frmMant.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmMant.SetInfo(Info);
                    //frmMant.Show();
                    frmMant.ShowDialog();
                }
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
                var Info = (ro_turno_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    frmMant = new frmRo_Turno_Mant();

                    frmMant.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant.SetInfo(Info);
                    //frmMant.Show();
                    frmMant.ShowDialog();
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;

                }
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


                var Info = (ro_turno_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info.Estado == "I")
                    MessageBox.Show("El Turno # : " + Info.IdTurno + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmMant = new frmRo_Turno_Mant();

                    frmMant.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant.SetInfo(Info);
                    frmMant.ShowDialog();
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        private void cargagrid()
        {
            try
            {
                var listado = Turno_bus.ConsListTurno(param.IdEmpresa);
                gridControlCons.DataSource = listado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmRo_Turno_Cons_Load(object sender, EventArgs e)
        {
            try
            {
              cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        frmRo_Turno_Mant frmMant = new frmRo_Turno_Mant();

  

        void frmMant_event_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargagrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void gridViewCons_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new ro_turno_Info ();
                Info = this.gridViewCons.GetFocusedRow() as ro_turno_Info;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

      

        private void frmRo_Turno_Cons_Load_1(object sender, EventArgs e)
        {

        }

        private void gridViewCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

            try
            {

                var data = gridViewCons.GetRow(e.RowHandle) as ro_turno_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

      
    }
}
