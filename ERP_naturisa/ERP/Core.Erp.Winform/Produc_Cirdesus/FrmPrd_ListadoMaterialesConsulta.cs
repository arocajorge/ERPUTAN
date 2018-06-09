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

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ListadoMaterialesConsulta : Form
    {
        public FrmPrd_ListadoMaterialesConsulta()
        {
            try
            {
                InitializeComponent();
                cargaGridListMateriales();
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
                frm = new FrmPrd_ListadoMaterialesMant();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
                frm.IdMateriales(param.IdEmpresa);
                frm.Show();
                
                frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


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
                if (InfoListMat == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoMaterialesMant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                    frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListMat);
                    frm.Show();
                    
                    frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);

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
                printableComponentLink1.Component = gridCtrlListMateriales;
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
                if (InfoListMat == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    frm = new FrmPrd_ListadoMaterialesMant();
                    frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                    frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                    frm.setCab(InfoListMat);
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
                
                if (InfoListMat != null)
                {
                    if (InfoListMat.Estado == "I")
                        MessageBox.Show("La Lista de Materiales # " + InfoListMat.IdListadoMateriales + " ya fue anulada", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (InfoListMat == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            frm = new FrmPrd_ListadoMaterialesMant();
                            frm.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            frm.Text = frm.Text + " ***ANULAR REGISTRO***"; frm.MdiParent = this.MdiParent;

                            frm.Show(); frm.setCab(InfoListMat);
                            frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


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
        FrmPrd_ListadoMaterialesMant frm = new FrmPrd_ListadoMaterialesMant();
        //Instancias de Listado de MAteriales
        List<com_ListadoMateriales_Info> LstMateriales = new List<com_ListadoMateriales_Info>();
        com_ListadoMateriales_Bus BusLMater = new com_ListadoMateriales_Bus();
        com_ListadoMateriales_Info InfoListMat = new com_ListadoMateriales_Info();


        private void cargaGridListMateriales()
        {
            try
            {
                LstMateriales = BusLMater.Get_List_ListadoMateriales(param.IdEmpresa);
            
                gridCtrlListMateriales.DataSource = LstMateriales;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }


            
        }
       
        void frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 cargaGridListMateriales();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
 
        }
        
        private void gridViewListMateriales_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                InfoListMat = (com_ListadoMateriales_Info) gridViewListMateriales.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewListMateriales_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gridViewListMateriales.GetRow(e.RowHandle) as com_ListadoMateriales_Info;
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

        private void FrmPrd_ListadoMaterialesConsulta_Load(object sender, EventArgs e){}

       
    }
}
