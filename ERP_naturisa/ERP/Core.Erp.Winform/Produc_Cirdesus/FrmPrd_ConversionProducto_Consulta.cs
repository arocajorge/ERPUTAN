using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produc_Cirdesus;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_ConversionProducto_Consulta : Form
    {
        public FrmPrd_ConversionProducto_Consulta()
        {
            try
            {
                 InitializeComponent();
                CargarGrid();
                ofrm.Event_FrmPrd_ConversionProducto_FormClosing += new FrmPrd_ConversionProducto.Delegate_FrmPrd_ConversionProducto_FormClosing(ofrm_Event_FrmPrd_ConversionProducto_FormClosing);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnImprimir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnImprimir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
            
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
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
                Close();
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
                ofrm = new FrmPrd_ConversionProducto();
                ofrm.Event_FrmPrd_ConversionProducto_FormClosing += new FrmPrd_ConversionProducto.Delegate_FrmPrd_ConversionProducto_FormClosing(ofrm_Event_FrmPrd_ConversionProducto_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.grabar);
               // ofrm._SetInfo = _Info;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
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
                //printableComponentLink1.Component = null;
                printableComponentLink1.Component = gridControl;

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
                ofrm = new FrmPrd_ConversionProducto();
                ofrm.Event_FrmPrd_ConversionProducto_FormClosing += new FrmPrd_ConversionProducto.Delegate_FrmPrd_ConversionProducto_FormClosing(ofrm_Event_FrmPrd_ConversionProducto_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.consultar);
                ofrm.Set(_Info) ;
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
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
                ofrm = new FrmPrd_ConversionProducto();
                ofrm.Event_FrmPrd_ConversionProducto_FormClosing += new FrmPrd_ConversionProducto.Delegate_FrmPrd_ConversionProducto_FormClosing(ofrm_Event_FrmPrd_ConversionProducto_FormClosing);
                ofrm.setAccion(Info.General.Cl_Enumeradores.eTipo_action.Anular);
                ofrm.Set(_Info);
                ofrm.MdiParent = this.MdiParent;
                ofrm.Show();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }



        void ofrm_Event_FrmPrd_ConversionProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                    CargarGrid();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        FrmPrd_ConversionProducto ofrm = new FrmPrd_ConversionProducto();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_Conversion_CusCidersus_Bus Bus = new prd_Conversion_CusCidersus_Bus();

        void CargarGrid()
        {
            try
            {
                gridControl.DataSource = Bus.ConsultaGeneral(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        
        }


        prd_Conversion_CusCidersus_Info _Info = new prd_Conversion_CusCidersus_Info();
        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void FrmPrd_ConversionProducto_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrid();
            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                _Info = (prd_Conversion_CusCidersus_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

       


    }
}
