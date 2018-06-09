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
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Roles
{
    public partial class frmRo_Nomina_Tipo_Cons : Form
    {
        #region Declaración de Vraiables
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Nomina_Tipo_Bus bustipo = new ro_Nomina_Tipo_Bus();
        string msg = "";
        cl_parametrosGenerales_Bus Param = cl_parametrosGenerales_Bus.Instance;
        #endregion

        public frmRo_Nomina_Tipo_Cons()
        {
            try
            {
              InitializeComponent();
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
                this.Close();
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
                frmRo_Nomina_Tipo_Mant frm = new frmRo_Nomina_Tipo_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; 
                //frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmro_Nomina_Tipo_Mant_FormClosing += frm_event_frmro_Nomina_Tipo_Mant_FormClosing;

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
                var Info = (ro_Nomina_Tipo_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipo_Mant frm = new frmRo_Nomina_Tipo_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.setCab(Info);
                    frm.Text = frm.Text + "***MODIFICAR REGISTRO***";
                    //frm.MdiParent = this.MdiParent;
                    frm.ShowDialog();
                    frm.event_frmro_Nomina_Tipo_Mant_FormClosing += frm_event_frmro_Nomina_Tipo_Mant_FormClosing;
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
                gridConsulta.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var Info = (ro_Nomina_Tipo_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipo_Mant frm = new frmRo_Nomina_Tipo_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar); 
                    //frm.MdiParent = this.MdiParent;
                    frm.setCab(Info);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.ShowDialog();

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
                var Info = (ro_Nomina_Tipo_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("El registro : " + Info.Descripcion + " . \r  Ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipo_Mant frm = new frmRo_Nomina_Tipo_Mant();
                    frm.event_frmro_Nomina_Tipo_Mant_FormClosing += frm_event_frmro_Nomina_Tipo_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.setCab(Info);
                    frm.ShowDialog(); 
          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        void frm_event_frmro_Nomina_Tipo_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        
        void loaddata()
        {
            try
            {
                var data = bustipo.Get_List_Nomina_Tipo(Param.IdEmpresa);
                gridConsulta.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }


        }

        private void gridVwConsulta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {

                var data = gridVwConsulta.GetRow(e.RowHandle) as ro_Nomina_Tipo_Info;
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

        private void frmro_Nomina_Tipo_Cons_Load(object sender, EventArgs e)
        {
            try
            {
              loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e){}

    
    }
}
