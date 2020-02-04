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
///Prog: Catherine Jimenez
///11:14 22/02/2014
///
namespace Core.Erp.Winform.General
{
    public partial class FrmGe_sis_Mensajes_sys_Consulta : Form
    {
     

        tb_sis_Mensajes_sys_Bus smsBus = new tb_sis_Mensajes_sys_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public FrmGe_sis_Mensajes_sys_Consulta()
        {
            try
            {
                InitializeComponent();
                gridControlMensajes.DataSource = smsBus.Get_List_sis_Mensajes_sys();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmGe_sis_Mensajes_sys_Mantenimiento MensajMantenimiento = new FrmGe_sis_Mensajes_sys_Mantenimiento();
                MensajMantenimiento.setAccion(Cl_Enumeradores.eTipo_action.grabar);

                MensajMantenimiento.Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing += new FrmGe_sis_Mensajes_sys_Mantenimiento.delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(MensajMantenimiento_Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing);
                MensajMantenimiento.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info1 = (tb_sis_Mensajes_sys_Info)this.GridMensajes.GetFocusedRow();

                FrmGe_sis_Mensajes_sys_Mantenimiento MensajMantenimiento = new FrmGe_sis_Mensajes_sys_Mantenimiento();
                MensajMantenimiento.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                MensajMantenimiento.setInfo = Info1;
                MensajMantenimiento.Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing += new FrmGe_sis_Mensajes_sys_Mantenimiento.delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(MensajMantenimiento_Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing);
                MensajMantenimiento.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (tb_sis_Mensajes_sys_Info)this.GridMensajes.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    FrmGe_sis_Mensajes_sys_Mantenimiento MensajMantenimiento = new FrmGe_sis_Mensajes_sys_Mantenimiento();
                    MensajMantenimiento.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                    MensajMantenimiento.setInfo = Info1;
                    MensajMantenimiento.Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing += new FrmGe_sis_Mensajes_sys_Mantenimiento.delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(MensajMantenimiento_Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing);
                    MensajMantenimiento.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                var Info1 = (tb_sis_Mensajes_sys_Info)this.GridMensajes.GetFocusedRow();
                if (Info1 == null)
                    MessageBox.Show("Seleccione una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (Info1.Estado == "I")
                    MessageBox.Show("El Catálogo # : " + Info1.IdMensaje + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    FrmGe_sis_Mensajes_sys_Mantenimiento MensajMantenimiento = new FrmGe_sis_Mensajes_sys_Mantenimiento();
                    MensajMantenimiento.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    MensajMantenimiento.setInfo = Info1;
                    MensajMantenimiento.Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing += new FrmGe_sis_Mensajes_sys_Mantenimiento.delegate_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(MensajMantenimiento_Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing);
                    MensajMantenimiento.Show();
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void gridMensaje_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = GridMensajes.GetRow(e.RowHandle) as tb_sis_Mensajes_sys_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       void MensajMantenimiento_Event_FrmGe_sis_Mensajes_sys_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gridControlMensajes.DataSource = smsBus.Get_List_sis_Mensajes_sys();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void FrmGe_sis_Mensajes_sys_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
                 MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
