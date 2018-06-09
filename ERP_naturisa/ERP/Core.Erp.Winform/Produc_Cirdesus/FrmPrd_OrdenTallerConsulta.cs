using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_OrdenTallerConsulta : Form
    {
        public FrmPrd_OrdenTallerConsulta()
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
                FrmPrd_OrdenTallerMantenimiento frm = new FrmPrd_OrdenTallerMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show(); frm.event_FrmPrd_OrdenTallerMantenimiento_FormClosing += new FrmPrd_OrdenTallerMantenimiento.delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing(frm_event_FrmPrd_OrdenTallerMantenimiento_FormClosing);
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
                InfoOrdenTaller = (prd_OrdenTaller_Info)gridViewOrdenTaller.GetFocusedRow();
                 if (InfoOrdenTaller == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_OrdenTallerMantenimiento frm = new FrmPrd_OrdenTallerMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_OT(InfoOrdenTaller);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_FrmPrd_OrdenTallerMantenimiento_FormClosing += new FrmPrd_OrdenTallerMantenimiento.delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing(frm_event_FrmPrd_OrdenTallerMantenimiento_FormClosing);
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
                printableComponentLink1.Component = gridCtrlOrdenTaller;
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
                InfoOrdenTaller = (prd_OrdenTaller_Info)gridViewOrdenTaller.GetFocusedRow();
                if (InfoOrdenTaller == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_OrdenTallerMantenimiento frm = new FrmPrd_OrdenTallerMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.set_OT(InfoOrdenTaller);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();

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
                InfoOrdenTaller = (prd_OrdenTaller_Info)gridViewOrdenTaller.GetFocusedRow();
                if (InfoOrdenTaller == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (InfoOrdenTaller.Estado == "I")
                    MessageBox.Show("Esta Orden de Taller ya esta Anulada / Inactiva", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (MessageBox.Show("¿Está seguro que desea Anular / Inactivar la Orden de Taller " + InfoOrdenTaller.Codigo + " ?", "Anular Orden de Taller", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //InfoOrdenTaller.Estado = "I";
                    //BusOrdenTaller.Anular(param.IdEmpresa, InfoOrdenTaller, ref msg);
                    FrmPrd_OrdenTallerMantenimiento frm = new FrmPrd_OrdenTallerMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.set_OT(InfoOrdenTaller);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.event_FrmPrd_OrdenTallerMantenimiento_FormClosing += new FrmPrd_OrdenTallerMantenimiento.delegate_FrmPrd_OrdenTallerMantenimiento_FormClosing(frm_event_FrmPrd_OrdenTallerMantenimiento_FormClosing);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //Instancia de empresa
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        //Instancias de Orden de taller
        List<prd_OrdenTaller_Info> lmOrdenTaller = new List<prd_OrdenTaller_Info>();
        prd_OrdenTaller_Bus BusOrdenTaller = new prd_OrdenTaller_Bus();
        prd_OrdenTaller_Info InfoOrdenTaller = new prd_OrdenTaller_Info();

        private void cargaGridObras()
        {
            try
            {
                lmOrdenTaller = BusOrdenTaller.ObtenerListaOT(param.IdEmpresa);
                tb_Sucursal_Bus BusSuc = new tb_Sucursal_Bus();
                //lmOrdenTaller.ForEach(var => var.NomSucursal = BusSuc.
                gridCtrlOrdenTaller.DataSource = lmOrdenTaller;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }



        }
      
        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewOrdenTaller.GetRow(e.RowHandle) as prd_OrdenTaller_Info;
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

       
        private void FrmPrd_OrdenTallerConsulta_Load(object sender, EventArgs e)
        {
            try
            {
                 cargaGridObras();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        void frm_event_FrmPrd_OrdenTallerMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              cargaGridObras();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


       
        private void ucGe_Menu_Mantenimiento_x_usuario_Load(object sender, EventArgs e)
        {

        }


       

    }
}
