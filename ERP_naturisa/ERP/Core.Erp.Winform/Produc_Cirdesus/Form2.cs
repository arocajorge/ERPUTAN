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
using Infragistics.Win.UltraWinGrid;
using Core.Erp.Info.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Info.Inventario;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{

    //
    public partial class Form2 : Form
    {
        public Form2()
        {
            try
            {
              InitializeComponent();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        prd_Obra_Bus BusOBra = new prd_Obra_Bus();
        prd_Obra_Info InfoObra = new prd_Obra_Info();
        in_Parametro_Bus BusParam = new in_Parametro_Bus();
        in_Parametro_Info InfoParam = new in_Parametro_Info();

        //Instancia de empresa
        public cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

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
                //InfoParam = BusParam.ObtenerParametros(param.IdEmpresa);
                gridControlObra.DataSource = BusOBra.ObtenerListaObra(param.IdEmpresa);//BusCC.ObtenerCCosto_x_CCPadre(InfoParam.IdEmpresa, InfoParam.IdCentroCosto_Padre_a_cargar);
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gridViewObras_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoObra = GetSelectedRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private prd_Obra_Info GetSelectedRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (prd_Obra_Info)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                return new prd_Obra_Info();
            }
        }

        private void gridViewObras_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e){}


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
           
        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
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
            
                switch (ribbonControl1.SelectedPage.Name)
                {
                    case "Grid":
                        documentViewer1.Visible = false;
                        gridControlObra.Visible = true;
                        break;
                    case "printPreview":
                        gridControlObra.Visible = false;
                        documentViewer1.Visible = true;
                        printableComponentLink1.CreateDocument();
                        break;
                }
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        private void btn_Salir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void btn_consultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoObra == null || InfoObra.CodObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar); frm.MdiParent = this.MdiParent;
                    frm.setObra(InfoObra);
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

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
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

        private void btn_modificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.setObra(InfoObra);
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

        private void btn_anular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoObra == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else if (InfoObra.Estado == "I")
                    MessageBox.Show("La Obra: " + InfoObra.Descripcion + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    FrmPrd_ObraMantemiento frm = new FrmPrd_ObraMantemiento();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.borrar);
                    frm.Text = frm.Text + " ***ANULAR REGISTRO***";
                    frm.Show(); frm.setObra(InfoObra);
                    frm.event_FrmPrd_ObraMantemiento_FormClosing += frm_event_FrmPrd_ObraMantemiento_FormClosing;

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.InnerException.ToString()); 
            }
        }
    }
}
