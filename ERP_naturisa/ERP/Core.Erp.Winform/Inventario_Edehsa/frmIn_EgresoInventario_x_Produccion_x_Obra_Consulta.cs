using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Business.Inventario;
using Core.Erp.Winform.Controles;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;
using DevExpress.XtraPrinting;

namespace Core.Erp.Winform.Inventario_Edehsa
{
    public partial class frmIn_EgresoInventario_x_Produccion_x_Obra_Consulta : Form
    {
       tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        UCIn_Sucursal_Bodega UCSucu = new UCIn_Sucursal_Bodega();

        in_movi_inven_tipo_Bus MoviTipoB = new in_movi_inven_tipo_Bus();
        in_movi_inve_Bus MoviInven = new in_movi_inve_Bus();
        prd_parametros_CusCidersus_Info param_Cidersus = new prd_parametros_CusCidersus_Info();
        prd_parametros_CusCidersus_Bus busParamCid = new prd_parametros_CusCidersus_Bus();


        tb_Sucursal_Info _sucuI = new tb_Sucursal_Info();
        tb_Bodega_Info _bodegaI = new tb_Bodega_Info();
        List<in_movi_inve_Info> listMoviInve = new List<in_movi_inve_Info>();
        List<in_movi_inve_detalle_Info> listMoviInve_detalle = new List<in_movi_inve_detalle_Info>();

        in_movi_inve_Info _MoviInvenInfo = new in_movi_inve_Info();
        public frmIn_EgresoInventario_x_Produccion_x_Obra_Consulta()
        {
            try
            {
                InitializeComponent();
                param_Cidersus = busParamCid.ObtenerObjeto(param.IdEmpresa);
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click;
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


                frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento frm = new frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***";
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.event_frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento_FormClosing += frm_event_frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento_FormClosing;

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
                if (_MoviInvenInfo == null)
                    MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    if (_MoviInvenInfo.IdNumMovi == null || _MoviInvenInfo.IdNumMovi == 0)
                        MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento fAjus = new frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento();

                        fAjus.set_Accion(Cl_Enumeradores.eTipo_action.consultar);


                        fAjus.Text = fAjus.Text + " ***COSULTAR REGISTRO***";
                        fAjus.MdiParent = this.MdiParent;
                        fAjus.setCab(_MoviInvenInfo);
                        fAjus.Show(); 
                    }

                }
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
                cargarData();
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
                if (_MoviInvenInfo != null)
                {
                    if (_MoviInvenInfo.Estado == "I")
                        MessageBox.Show("El Ajuste de inventario # " + _MoviInvenInfo.IdNumMovi + " ya fue anulado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {

                        if (_MoviInvenInfo == null)
                            MessageBox.Show("Selecciones una fila", "sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        else
                        {
                            //frmIn_AjustesInven_Mant fAjus = new frmIn_AjustesInven_Mant();
                            //fAjus.set_Accion(Cl_Enumeradores.eTipo_action.borrar);
                            //fAjus.set_AjusteMoviInven(_MoviInvenInfo);
                            //fAjus.Text = fAjus.Text + " ***ANULAR REGISTRO***";
                            //fAjus.Show();
                            //fAjus.Event_frmIn_AjustesInven_Mant_FormClosing += new frmIn_AjustesInven_Mant.Delegate_frmIn_AjustesInven_Mant_FormClosing(fAjus_Event_frmIn_AjustesInven_Mant_FormClosing);
                            frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento fAjus = new frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento();

                            fAjus.set_Accion(Cl_Enumeradores.eTipo_action.Anular);

                            fAjus.setCab(_MoviInvenInfo);
                            fAjus.Text = fAjus.Text + " ***ANULAR REGISTRO***";
                            fAjus.MdiParent = this.MdiParent;
                            fAjus.Show();
                            fAjus.event_frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento_FormClosing += frm_event_frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento_FormClosing;

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




        DevExpress.XtraGrid.Views.Grid.GridView Gview = new DevExpress.XtraGrid.Views.Grid.GridView();


        //int idSucuIni = 0;
        //int idSucuFin = 0;
        //int idBodegaIni = 0;
        //int idBodegaFin = 0;
        int idTipoMoviIni = 0;
        int idTipoMoviFin = 0;
        //DateTime fechaIni;
        //DateTime fechaFin;
        

        private void cargarCombos()
        {
            try
            {
                List<in_movi_inven_tipo_Info> lstTipo = new List<in_movi_inven_tipo_Info>();
                lstTipo = MoviTipoB.Get_list_movi_inven_tipo(param.IdEmpresa, "", "N", "Todos");
                cmbTipoMoviInven.DataSource = lstTipo.FindAll(var => var.IdMovi_inven_tipo == param_Cidersus.IdMovi_inven_tipo_egr_consumoprod ||
                    var.IdMovi_inven_tipo == param_Cidersus.IdMovi_inven_tipo_ing_consumoprod||var.IdMovi_inven_tipo==0);
                cmbTipoMoviInven.DisplayMember = "tm_descripcion";
                cmbTipoMoviInven.ValueMember = "IdMovi_inven_tipo";

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
        }



        private void cargarData()
        {
            try
            {
                     listMoviInve = MoviInven.Get_list_Movi_inven(param.IdEmpresa
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal, ucGe_Menu_Mantenimiento_x_usuario.getIdSucursal
                    , ucGe_Menu_Mantenimiento_x_usuario.getIdBodega, ucGe_Menu_Mantenimiento_x_usuario.getIdBodega
                    , idTipoMoviIni, idTipoMoviFin
                    , ucGe_Menu_Mantenimiento_x_usuario.fecha_desde, ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta);
               
                    gridControl.DataSource = listMoviInve;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void frmIn_AjustesInven_Cosulta_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombos();
                cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());                
            }
            
        }

        void fAjus_Event_frmIn_AjustesInven_Mant_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                 cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frm_event_frmIn_EgresoInventario_x_Produccion_x_Obra_Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void gvAjustes_Cabecera_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            try
            {

                Gview = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
                _MoviInvenInfo = (in_movi_inve_Info)Gview.GetRow(Gview.FocusedRowHandle);

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                
            }

        }


        private void cmbTipoMoviInven_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<in_movi_inve_Info> info = new List<in_movi_inve_Info>();
                gridControl.DataSource = info;


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        private void gvAjustes_Cabecera_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = gvAjustes_Cabecera.GetRow(e.RowHandle) as in_movi_inve_Info;
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
