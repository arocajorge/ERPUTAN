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
    public partial class FrmPrd_EnsambladoProductoFinal_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        FrmPrd_EnsambladoProductoFinal_Mantenimiento frm = new FrmPrd_EnsambladoProductoFinal_Mantenimiento();

        public FrmPrd_EnsambladoProductoFinal_Consulta()
        {
            try
            {
               InitializeComponent();
               ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
               ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
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
                frm = new FrmPrd_EnsambladoProductoFinal_Mantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing += new FrmPrd_EnsambladoProductoFinal_Mantenimiento.Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(frm_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());

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
                printableComponentLink1.Component = gridCtrlEnsamblado;
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
                if (Info == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_EnsambladoProductoFinal_Mantenimiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);

                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***";
                    frm.MdiParent = this.MdiParent;
                    frm.Show(); 
                    frm.setCab(Info);


                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info != null)
                {
                    if (Info.Estado == "I")
                        MessageBox.Show("La Generacion de Ord/Compra # " + Info.IdEnsamblado + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (Info == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            frm = new FrmPrd_EnsambladoProductoFinal_Mantenimiento();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                            frm.MdiParent = this.MdiParent;
                            frm.Show(); frm.setCab(Info);
                            frm.Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing += new FrmPrd_EnsambladoProductoFinal_Mantenimiento.Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(frm_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing);


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

        void frm_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
          {
                cargagrid(); 
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        string msg = "";
        prd_Ensamblado_CusCider_Bus BusEnsamblado = new prd_Ensamblado_CusCider_Bus();
        List<prd_Ensamblado_CusCider_Info> ListaGrid = new List<prd_Ensamblado_CusCider_Info>();

        void cargagrid()
        {
            try
            {
                ListaGrid = BusEnsamblado.ConsultaGeneral(param.IdEmpresa, ref msg);
               
                gridCtrlEnsamblado.DataSource = ListaGrid;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(msg +"Error de sistema debido a: "+ ex.ToString());
             
            }
            
        }
        
        prd_Ensamblado_CusCider_Info Info = new prd_Ensamblado_CusCider_Info();

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Info = (prd_Ensamblado_CusCider_Info)gridViewEnsamblado.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewEnsamblado.GetRow(e.RowHandle) as prd_Ensamblado_CusCider_Info;
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

        private void FrmPrd_EnsambladoProductoFinal_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargagrid();
               frm.Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing += new FrmPrd_EnsambladoProductoFinal_Mantenimiento.Delegate_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing(frm_Event_FrmPrd_EnsambladoProductoFinal_Mantenimiento_FormClosing);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        
        }      

    }
}
