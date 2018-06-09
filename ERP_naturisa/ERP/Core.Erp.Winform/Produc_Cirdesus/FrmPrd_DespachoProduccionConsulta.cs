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
using Core.Erp.Info.Facturacion;
using Core.Erp.Business.Facturacion;
using DevExpress.XtraPrinting;
//version 16/07/2013
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_DespachoProduccionConsulta : Form
    {
        public FrmPrd_DespachoProduccionConsulta()
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

        #region "Eventos clic de Botones"
        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
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
                FrmPrd_DespachoMantenimiento frm = new FrmPrd_DespachoMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show(); frm.event_FrmPrd_DespachoMantenimiento_FormClosing += frm_event_FrmPrd_DespachoMantenimiento_FormClosing;


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
                InfoDespacho = (prd_Despacho_Info)gridViewDespacho.GetFocusedRow();
                if (InfoDespacho == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_DespachoMantenimiento frm = new FrmPrd_DespachoMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);

                    //obtenerGuia();
                    //frm.setCabGuia(infoguia);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setCab(InfoDespacho);
                    frm.event_FrmPrd_DespachoMantenimiento_FormClosing += frm_event_FrmPrd_DespachoMantenimiento_FormClosing;

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
                printableComponentLink1.Component = gridControlDespacho;
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
                InfoDespacho = (prd_Despacho_Info)gridViewDespacho.GetFocusedRow();
                if (InfoDespacho == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_DespachoMantenimiento frm = new FrmPrd_DespachoMantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                    obtenerGuia();
                    // frm.setCabGuia(infoguia);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.setCab(InfoDespacho);
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
                if (InfoDespacho != null)
                {
                    if (InfoDespacho.Estado == "I")
                        MessageBox.Show("El Despacho # " + InfoDespacho.NumDespacho + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (InfoDespacho == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            FrmPrd_DespachoMantenimiento frm = new FrmPrd_DespachoMantenimiento();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                            frm.MdiParent = this.MdiParent;
                            frm.Show(); frm.setCab(InfoDespacho);
                            frm.event_FrmPrd_DespachoMantenimiento_FormClosing += frm_event_FrmPrd_DespachoMantenimiento_FormClosing;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

            }
        }
        #endregion

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_Despacho_Bus BusProduccion = new prd_Despacho_Bus();
        prd_Despacho_Info InfoDespacho = new prd_Despacho_Info();

        //instancias facturacion - guia
       // fa_guia_remision_x_prd_Despacho_Bus busGuia_x_despacho = new fa_guia_remision_x_prd_Despacho_Bus();


        fa_guia_remision_x_prd_Despacho_Info infoGuia_x_despacho = new fa_guia_remision_x_prd_Despacho_Info();
        fa_guia_remision_Bus busguia = new fa_guia_remision_Bus();
        fa_guia_remision_Info infoguia = new fa_guia_remision_Info();

        private prd_Despacho_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (prd_Despacho_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prd_Despacho_Info();
            }
        }

        private void CargaGrid()
        {
            try
            {
                gridControlDespacho.DataSource = BusProduccion.ObtenerDespachoCab(param.IdEmpresa);
                gridViewDespacho.ExpandAllGroups();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void FrmPrd_DespachoProduccionConsulta_Load(object sender, EventArgs e)
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

        private void gridViewDespacho_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoDespacho = (prd_Despacho_Info)gridViewDespacho.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        
        }

        private void obtenerGuia()
        {
            try
            {
                //infoGuia_x_despacho = busGuia_x_despacho.ObtieneUnRegistro(InfoDespacho);
                //infoguia = busguia.ObtieneUnRegistro(infoGuia_x_despacho);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_FrmPrd_DespachoMantenimiento_FormClosing(object sender, FormClosingEventArgs e)
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

        private void gridViewDespacho_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewDespacho.GetRow(e.RowHandle) as prd_Despacho_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }
    }
}
