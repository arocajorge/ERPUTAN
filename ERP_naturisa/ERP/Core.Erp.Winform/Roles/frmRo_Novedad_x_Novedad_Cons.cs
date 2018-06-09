/*CLASE: frmRo_Novedad_x_Novedad_Cons
 *MODIFICADA POR: ALBERTO MENA
 *FECHA: 09-03-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
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
    public partial class frmRo_Novedad_x_Novedad_Cons : Form
    {
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        private vwro_empleado_por_novedades_cabecera_Bus oData = new vwro_empleado_por_novedades_cabecera_Bus();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        ro_Empleado_Novedad_Bus busNovedad = new ro_Empleado_Novedad_Bus();
        
        public frmRo_Novedad_x_Novedad_Cons()
        {
            try
            {
                InitializeComponent();
                PU_CARGAR_GRILLA();

                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PU_CONSULTAR_POR_RANGO_FECHA();
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

                frmRo_Novedad_x_Novedad_Mant frm = new frmRo_Novedad_x_Novedad_Mant();
                frm.setAccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";

                frm.event_frmRo_Novedad_x_Novedad_Mant_FormClosing += frm_event_frmRo_Novedad_x_Novedad_Mant_FormClosing;

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
                var Info = (vwro_empleado_por_novedades_cabecera_Info)this.dgvListado.GetFocusedRow();
  
                if (Info == null)
                    MessageBox.Show("Debe seleccionar una registro", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else{

                    if (Info.Estado== "I"){
                        MessageBox.Show("No se pueden actualizar registros inactivos.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }else{
                        frmRo_Novedad_x_Novedad_Mant frm = new frmRo_Novedad_x_Novedad_Mant();
                        frm.setAccion(Cl_Enumeradores.eTipo_action.actualizar);
                        frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; 
                        frm.setInfo(Info);
                        frm.ShowDialog();

                        frm.event_frmRo_Novedad_x_Novedad_Mant_FormClosing += frm_event_frmRo_Novedad_x_Novedad_Mant_FormClosing;
                        PU_CARGAR_GRILLA();
                    }
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
                dgvListado.ShowPrintPreview();
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
                var Info = (vwro_empleado_por_novedades_cabecera_Info)this.dgvListado.GetFocusedRow();

                if (Info == null)
                    MessageBox.Show("Debe seleccionar una registro", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                        frmRo_Novedad_x_Novedad_Mant frm = new frmRo_Novedad_x_Novedad_Mant();
                        frm.setAccion(Cl_Enumeradores.eTipo_action.consultar);
                        frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                        frm.setInfo(Info);
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
         
            try{
                var Info = (vwro_empleado_por_novedades_cabecera_Info)this.dgvListado.GetFocusedRow();
                
                if (Info == null)
                    MessageBox.Show("Seleccione un registro", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (Info.Estado == "I")
                    MessageBox.Show("El registro  # : " + Info.IdTransaccion.ToString() + " ya fue anulada", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frmRo_Novedad_x_Novedad_Mant frm = new frmRo_Novedad_x_Novedad_Mant();
                    frm.setAccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.setInfo(Info);
                    frm.ShowDialog();

                    frm.event_frmRo_Novedad_x_Novedad_Mant_FormClosing += frm_event_frmRo_Novedad_x_Novedad_Mant_FormClosing;
                }

                PU_CARGAR_GRILLA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void PU_CONSULTAR_POR_RANGO_FECHA() {
            try
            {
                List<vwro_empleado_por_novedades_cabecera_Info> lista = new List<vwro_empleado_por_novedades_cabecera_Info>();

                lista = oData.ConsultaGeneral(param.IdEmpresa, ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
                gridControlCons.DataSource = null;
                gridControlCons.DataSource = lista;
                gridControlCons.RefreshDataSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
       
        
        }



        private void PU_CARGAR_GRILLA()
        {
            try
            {
                List<vwro_empleado_por_novedades_cabecera_Info>  lista= new List<vwro_empleado_por_novedades_cabecera_Info>();

                lista = oData.ConsultaGeneral(param.IdEmpresa);
                gridControlCons.DataSource = null;
                gridControlCons.DataSource = lista;
                gridControlCons.RefreshDataSource();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
           
        
        }
     

        void frm_event_frmRo_Novedad_x_Novedad_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PU_CARGAR_GRILLA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewCons_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e){}

        private void frmRo_Novedad_x_Novedad_Cons_Load(object sender, EventArgs e){}

  
        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }

        private void dgvListado_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void dgvListado_Click(object sender, EventArgs e)
        {

        }

        private void gridControlCons_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListado_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = dgvListado.GetRow(e.RowHandle) as vwro_empleado_por_novedades_cabecera_Info;
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

        private void ucGe_Menu_Mantenimiento_x_usuario_event_btnfiltro_fecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}
