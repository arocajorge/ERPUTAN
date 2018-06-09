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
    public partial class frmRo_Nomina_Tipoliqui_Cons : Form
    {
        public frmRo_Nomina_Tipoliqui_Cons()
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
                frmRo_Nomina_Tipoliqui_Mant frm = new frmRo_Nomina_Tipoliqui_Mant();
                frm.event_frmRo_Nomina_Tipoliqui_Mant_FormClosing += frm_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.setCab(null);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; 
                frm.ShowDialog();   
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
                var Info = (ro_Nomina_Tipoliqui_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipoliqui_Mant frm = new frmRo_Nomina_Tipoliqui_Mant();
                    frm.event_frmRo_Nomina_Tipoliqui_Mant_FormClosing += frm_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.setCab(Info);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***";
                    frm.ShowDialog();
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
                var Info = (ro_Nomina_Tipoliqui_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipoliqui_Mant frm = new frmRo_Nomina_Tipoliqui_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
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
                var Info = (ro_Nomina_Tipoliqui_Info)gridVwConsulta.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Seleccione una fila", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("El registro : " + Info.DescripcionProcesoNomina + " . \r Ya fue anulado", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Nomina_Tipoliqui_Mant frm = new frmRo_Nomina_Tipoliqui_Mant();
                    frm.event_frmRo_Nomina_Tipoliqui_Mant_FormClosing += frm_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing;
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
 
        void frm_event_frmRo_Nomina_Tipoliqui_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                loaddata();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
   
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Nomina_Tipoliqui_Bus bustipo = new ro_Nomina_Tipoliqui_Bus();
        string msg = "";
        cl_parametrosGenerales_Bus Param = cl_parametrosGenerales_Bus.Instance;
        void loaddata()
        {
            try
            {
                ro_Nomina_Tipo_Bus busnomina = new ro_Nomina_Tipo_Bus();
                var data = bustipo.Get_List_Nomina_Tipoliqui(Param.IdEmpresa);
                foreach (var item in data)
                {
                    item.Nomina_Tipo = busnomina.Get_Info_Nomina_Tipo(Param.IdEmpresa, item.IdNomina_Tipo).Descripcion;
                }
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

                var data = gridVwConsulta.GetRow(e.RowHandle) as ro_Nomina_Tipoliqui_Info;
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

       
        private void frmRo_Nomina_Tipoliqui_Cons_Load(object sender, EventArgs e)
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
     
       
    }
}
