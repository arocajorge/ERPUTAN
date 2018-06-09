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
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

using DevExpress.XtraGrid.Views.Grid.ViewInfo;
//version 240620113 13:31
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ObraConsulta : Form
    {
        #region Declaracion Variable
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_Obra_Info InfoObra = new prd_Obra_Info();
        in_Parametro_Bus BusParam = new in_Parametro_Bus();
        in_Parametro_Info InfoParam = new in_Parametro_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        BindingList<prd_Obra_Info> ListadoObra= new BindingList<prd_Obra_Info>();
        #endregion

        public FrmPrd_ObraConsulta()
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
                FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                frm.set_Acccion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoObra = (prd_Obra_Info)gridViewObras.GetFocusedRow();
                if (InfoObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.set_Info(InfoObra);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.Show();
                    frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;

                    
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
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
                printableComponentLink1.Component = null;
                gridControlObra.RefreshDataSource();
                printableComponentLink1.Component = gridControlObra;
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
                InfoObra = (prd_Obra_Info)gridViewObras.GetFocusedRow();
                if (InfoObra == null || InfoObra.CodObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.set_Info(InfoObra);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.Show();

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                InfoObra = (prd_Obra_Info)gridViewObras.GetFocusedRow();
                if (InfoObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (InfoObra.Estado == "I")
                    MessageBox.Show("La Obra: " + InfoObra.Descripcion + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Acccion(Cl_Enumeradores.eTipo_action.Anular);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.MdiParent = this.MdiParent;
                    frm.Show(); frm.set_Info(InfoObra);
                    frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
       
        private void FrmPrd_ObraConsulta_Load(object sender, EventArgs e)
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

        private void cargaGridObras()
        {
            try
            {
                ListadoObra= new BindingList<prd_Obra_Info>(BusOBra.ObtenerListaObra(param.IdEmpresa));
                gridControlObra.DataSource = ListadoObra;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        //private void gridViewObras_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    try
        //    {
        //        InfoObra = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        //private prd_Obra_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        //{
        //    try
        //    {
        //        return (prd_Obra_Info)view.GetRow(view.FocusedRowHandle);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}

        private void gridViewObras_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewObras.GetRow(e.RowHandle) as prd_Obra_Info;
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
    

        void frm_event_FrmPrd_ObraMantemiento_FormClosing(object sender, FormClosingEventArgs e)
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


        private void gridViewObras_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;

                GridHitInfo hitInfo = view.CalcHitInfo(e.Point);

                if (hitInfo.InRow)
                {

                    view.FocusedRowHandle = hitInfo.RowHandle;

                    ContextMenu.Show(view.GridControl, e.Point);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());

            }

        }

    }
}
