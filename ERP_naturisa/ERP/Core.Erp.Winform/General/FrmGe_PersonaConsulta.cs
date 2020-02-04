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


namespace Core.Erp.Winform.General
{
    public partial class frmGe_PersonaConsulta : Form
    {
        #region Declaración de Variables
        private tb_persona_Info _personaI = new tb_persona_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        #endregion
       
        public frmGe_PersonaConsulta()
        {
            try
            {
                InitializeComponent();
                 cargar_Personas();
                 ucGe_Menu.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                 ucGe_Menu.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                 ucGe_Menu.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                 ucGe_Menu.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                 ucGe_Menu.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
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
                this.Close();
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
                frmGe_MantPersona frMPer = new frmGe_MantPersona();
                frMPer.event_frmGe_MantPersona_FormClosing += new frmGe_MantPersona.delegate_frmGe_MantPersona_FormClosing(frMPer_event_frmGe_MantPersona_FormClosing);
                frMPer.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frMPer.Text = frMPer.Text + " ***NUEVO REGISTRO***";
                frMPer.MdiParent = this.MdiParent;
                frMPer.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void frMPer_event_frmGe_MantPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargar_Personas();
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

                _personaI = (tb_persona_Info)gridViewPersona.GetFocusedRow();

                frmGe_MantPersona frMPer = new frmGe_MantPersona();
                frMPer.event_frmGe_MantPersona_FormClosing += new frmGe_MantPersona.delegate_frmGe_MantPersona_FormClosing(frMPer_event_frmGe_MantPersona_FormClosing);
                frMPer.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                frMPer.set_Persona(_personaI);
                frMPer.Text = frMPer.Text + " ***MODIFICAR***";
                frMPer.MdiParent = this.MdiParent;
                frMPer.Show();

                cargar_Personas();
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

                _personaI = (tb_persona_Info)gridViewPersona.GetFocusedRow();

                frmGe_MantPersona frMPer = new frmGe_MantPersona();
                frMPer.event_frmGe_MantPersona_FormClosing += new frmGe_MantPersona.delegate_frmGe_MantPersona_FormClosing(frMPer_event_frmGe_MantPersona_FormClosing);
                frMPer.set_Persona(_personaI);
                frMPer.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                frMPer.Text = frMPer.Text + " ***COSULTAR***";
                frMPer.MdiParent = this.MdiParent;
                frMPer.Show();

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
                _personaI = (tb_persona_Info)gridViewPersona.GetFocusedRow();
                
                frmGe_MantPersona frMPer = new frmGe_MantPersona();
                frMPer.event_frmGe_MantPersona_FormClosing += new frmGe_MantPersona.delegate_frmGe_MantPersona_FormClosing(frMPer_event_frmGe_MantPersona_FormClosing);
                frMPer.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                frMPer.set_Persona(_personaI);
                frMPer.Text = frMPer.Text + " ***Anular***";
                frMPer.MdiParent = this.MdiParent;
                frMPer.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_Personas()
        {
            try
            {
                 tb_persona_bus perB = new tb_persona_bus();
                 List<tb_persona_Info> listPer = new List<tb_persona_Info>();

                 listPer = perB.Get_List_Persona();
                this.gridControlPersona.DataSource= listPer;

              }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void FrmGe_PersonaConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_Personas();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControlPersona_Click(object sender, EventArgs e)
        {

        }

        private void gridViewPersona_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewPersona.GetRow(e.RowHandle) as tb_persona_Info;
                if (data == null)
                    return;
                if (data.pe_estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
