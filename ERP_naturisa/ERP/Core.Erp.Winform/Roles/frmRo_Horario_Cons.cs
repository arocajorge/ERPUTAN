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
//PLANIFICACION DE HORARIOS
//DEREK MEJÍA SORIA
//ULTIMA MODIFICACIÓN: 08/01/2014
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Horario_Cons : Form
    {
        #region Declaración de variables
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Horario_Bus Turno_bus = new ro_Horario_Bus();
        ro_Horario_Info Info = new ro_Horario_Info();
        frmRo_Horario_Mant frmMant = new frmRo_Horario_Mant();
        #endregion

        public frmRo_Horario_Cons()
        {
            try
            {
                InitializeComponent();
                frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;

                cargagrid();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                frmMant = new frmRo_Horario_Mant(Cl_Enumeradores.eTipo_action.grabar);
                frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                frmMant.Text = frmMant.Text + " ***NUEVO REGISTRO***";
                //frmMant.MdiParent = MdiParent;
                //frmMant.Show();
                frmMant.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ro_Horario_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                  {
                    frmMant = new frmRo_Horario_Mant(Cl_Enumeradores.eTipo_action.actualizar);
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ACTUALIZAR REGISTRO***";
                    frmMant._SetInfo = Info;
                    //frmMant.MdiParent = MdiParent;
                    //frmMant.Show();
                    frmMant.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                gridViewCons.ShowPrintPreview();
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
                var Info = (ro_Horario_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmMant = new frmRo_Horario_Mant(Cl_Enumeradores.eTipo_action.consultar);
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***CONSULTAR REGISTRO***";
                    frmMant._SetInfo = Info;
                    //frmMant.MdiParent = MdiParent;
                    //frmMant.Show();
                    frmMant.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                

                var Info = (ro_Horario_Info)this.gridViewCons.GetFocusedRow();
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info.Estado == "I")
                    MessageBox.Show("El Turno # : " + Info.IdHorario + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {

                    frmMant = new frmRo_Horario_Mant(Cl_Enumeradores.eTipo_action.Anular);
                    frmMant.event_frmRo_Turno_Mant_FormClosing += frmMant_event_frmRo_Turno_Mant_FormClosing;
                    frmMant.Text = frmMant.Text + " ***ANULAR REGISTRO***";
                    frmMant._SetInfo = Info;
                    //frmMant.MdiParent = MdiParent;
                    //frmMant.Show();
                    frmMant.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frmMant_event_frmRo_Turno_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              cargagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void cargagrid()
        {
            try
            {
                var listado = Turno_bus.Get_List_Horario(param.IdEmpresa);
                gridControlCons.DataSource = listado;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());  
            }

        }

        private void frmRo_Turno_Cons_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
               //this.colIdTurno.OptionsColumn.AllowEdit = false;
               //this.colHoraIni.OptionsColumn.AllowEdit = false;
               //this.colHoraFin.OptionsColumn.AllowEdit = false;
               //this.colEstado.OptionsColumn.AllowEdit = false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewCons_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = new ro_Horario_Info();
                Info = this.gridViewCons.GetFocusedRow() as ro_Horario_Info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewCons_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridViewCons.GetRow(e.RowHandle) as ro_Horario_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


    }
}
