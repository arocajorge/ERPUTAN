using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;
using Core.Erp.Info.General;
using Core.Erp.Winform.Produc_Cirdesus;
using DevExpress.XtraPrinting;
//version 240620113 13:31




namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_SubGrupoTrabajoConsulta : Form
    {
        public FrmPrd_SubGrupoTrabajoConsulta()
        {
            try
            {
                    InitializeComponent();
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                    ucGe_Menu_Mantenimiento_x_usuario1.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

       
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Dispose();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_SubGrupoTrabajoMantenimiento frm = new FrmPrd_SubGrupoTrabajoMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();

                frm.EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing += new FrmPrd_SubGrupoTrabajoMantenimiento.delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(frm_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();

                if (InfoGrupoTrabajo == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_SubGrupoTrabajoMantenimiento frm = new FrmPrd_SubGrupoTrabajoMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);

                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setCab(InfoGrupoTrabajo);

                    frm.EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing += new FrmPrd_SubGrupoTrabajoMantenimiento.delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(frm_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing);

                }
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
                //gridControlObra.ShowPrintPreview();
                string leftColumn = "Fecha: [Date Printed][Time Printed]";
                string middleColumn = "Página:[Page # of Pages #]";
                string rightColumn = "Usuario:" + param.IdUsuario;

                // Create a PageHeaderFooter object and initializing it with
                // the link's PageHeaderFooter.

                PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

                // Clear the PageHeaderFooter's contents.
                phf.Header.Content.Clear();
                phf.Footer.Content.Clear();
                Font fte = new System.Drawing.Font("Tahoma", 8.5f, FontStyle.Bold, GraphicsUnit.Point);

                // Add custom information to the link's header.
                phf.Header.Font = fte;
                phf.Footer.Font = fte;
                phf.Header.Content.AddRange(new string[] { leftColumn, "", rightColumn, "hola" });
                phf.Header.LineAlignment = BrickAlignment.Center;
                phf.Footer.Content.AddRange(new string[] { "", "", middleColumn });
                phf.Footer.LineAlignment = BrickAlignment.Center;
                printableComponentLink1.Landscape = true;
                printableComponentLink1.Component = gridControlGrupoTrabajo;
                printableComponentLink1.ShowPreview();
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
                InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();
                if (InfoGrupoTrabajo == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_SubGrupoTrabajoMantenimiento frm = new FrmPrd_SubGrupoTrabajoMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setCab(InfoGrupoTrabajo);
                    frm.EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing += new FrmPrd_SubGrupoTrabajoMantenimiento.delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(frm_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing);





                }
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
                string msg = "";

                InfoGrupoTrabajo = (prd_SubGrupoTrabajo_Info)gridViewGrupoTrabajo.GetFocusedRow();
                if (InfoGrupoTrabajo == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else if (InfoGrupoTrabajo.Estado == "I")
                    MessageBox.Show("Este Grupo de Trabajo ya esta Anulado / Inactivo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (MessageBox.Show("¿Está seguro que desea Anular / Inactivar el Grupo de Trabajo " + InfoGrupoTrabajo.Descripcion + " ?", "Anulación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //InfoOrdenTaller.Estado = "I";
                    //BusOrdenTaller.Anular(param.IdEmpresa, InfoOrdenTaller, ref msg);
                    FrmPrd_SubGrupoTrabajoMantenimiento frm = new FrmPrd_SubGrupoTrabajoMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                    frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setCab(InfoGrupoTrabajo); frm.EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing += new FrmPrd_SubGrupoTrabajoMantenimiento.delegate_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(frm_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
     
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_SubGrupoTrabajo_Bus BusProduccion = new prd_SubGrupoTrabajo_Bus();
        prd_SubGrupoTrabajo_Info InfoGrupoTrabajo = new prd_SubGrupoTrabajo_Info();
        
        void frm_EVENT_FrmPrd_GrupoTrabajoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
               CargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }      

        private void FrmPrd_GrupoTrabajoConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargaGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void CargaGrid()
        {
            try
            {
                gridControlGrupoTrabajo.DataSource = BusProduccion.ObtenerGrupoTrabajoCab(param.IdEmpresa);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridViewGrupoTrabajo_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewGrupoTrabajo.GetRow(e.RowHandle) as prd_SubGrupoTrabajo_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void ucGe_Menu_Mantenimiento_x_usuario1_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
      

         }
}
