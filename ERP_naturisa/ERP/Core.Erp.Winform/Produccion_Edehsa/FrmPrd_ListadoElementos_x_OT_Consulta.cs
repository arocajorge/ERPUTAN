using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Compras;
using Core.Erp.Info.Compras;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Business.Compras_Edehsa;

namespace Core.Erp.Winform.Produccion_Edehsa
{
    public partial class FrmPrd_ListadoElementos_x_OT_Consulta : Form
    {
        public FrmPrd_ListadoElementos_x_OT_Consulta()
        {
            try
            {
                InitializeComponent();
                cargaGridListadoElementos_x_OT();
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
                frm = new FrmPrd_ListadoElementos_x_OT_Mant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                //frm.IdMateriales(param.IdEmpresa);
                frm.Show();

                frm.Event_FrmPrd_ListadoElementos_x_OTMant_FormClosing += new FrmPrd_ListadoElementos_x_OT_Mant.Delegate_FrmPrd_ListadoElementos_x_OTMant_FormClosing(frm_Event_FrmPrd_ListadoElementos_x_OT_Mant_FormClosing);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);

            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (InfoListadoElementos_x_OT == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoElementos_x_OT_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListadoElementos_x_OT);
                    frm.Show();

                    frm.Event_FrmPrd_ListadoElementos_x_OTMant_FormClosing += new FrmPrd_ListadoElementos_x_OT_Mant.Delegate_FrmPrd_ListadoElementos_x_OTMant_FormClosing(frm_Event_FrmPrd_ListadoElementos_x_OT_Mant_FormClosing);

                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);

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
                printableComponentLink1.Component = gridCtrlListadoElementos_x_OT;
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
                if (InfoListadoElementos_x_OT == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoElementos_x_OT_Mant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListadoElementos_x_OT);
                    frm.Show(); 


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
                
                if (InfoListadoElementos_x_OT != null)
                {
                    if (InfoListadoElementos_x_OT.Estado == "I")
                        MessageBox.Show("La Lista de Materiales # " + InfoListadoElementos_x_OT.IdListadoElementos_x_OT + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (InfoListadoElementos_x_OT == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            frm = new FrmPrd_ListadoElementos_x_OT_Mant();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;

                            frm.Show(); frm.setCab(InfoListadoElementos_x_OT);
                            frm.Event_FrmPrd_ListadoElementos_x_OTMant_FormClosing += new FrmPrd_ListadoElementos_x_OT_Mant.Delegate_FrmPrd_ListadoElementos_x_OTMant_FormClosing(frm_Event_FrmPrd_ListadoElementos_x_OT_Mant_FormClosing);


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //Instancia de empresa
        public cl_parametrosGenerales_Bus param= cl_parametrosGenerales_Bus.Instance;
        FrmPrd_ListadoElementos_x_OT_Mant frm = new FrmPrd_ListadoElementos_x_OT_Mant();
        //Instancias de Listado de MAteriales
        List<com_ListadoElementos_x_OT_Info> LstListadoElementos_x_OT = new List<com_ListadoElementos_x_OT_Info>();
        com_ListadoElementos_x_OT_Bus BusListadoElementos_x_OT = new com_ListadoElementos_x_OT_Bus();
        com_ListadoElementos_x_OT_Info InfoListadoElementos_x_OT = new com_ListadoElementos_x_OT_Info();


        private void cargaGridListadoElementos_x_OT()
        {
            try
            {
                LstListadoElementos_x_OT = BusListadoElementos_x_OT.Get_List_ListadoElementos_x_OT(param.IdEmpresa);

                gridCtrlListadoElementos_x_OT.DataSource = LstListadoElementos_x_OT;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            
        }

        void frm_Event_FrmPrd_ListadoElementos_x_OT_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                cargaGridListadoElementos_x_OT();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }

        private void gridViewListadoElementos_x_OT_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoListadoElementos_x_OT = (com_ListadoElementos_x_OT_Info)gridViewListadoElementos_x_OT.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewListadoElementos_x_OT_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewListadoElementos_x_OT.GetRow(e.RowHandle) as com_ListadoElementos_x_OT_Info;
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

        private void FrmPrd_ListadoElementos_x_OTConsulta_Load(object sender, EventArgs e){}

       
    }
}
