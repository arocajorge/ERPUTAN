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
using Infragistics.Win.UltraWinGrid;


namespace Core.Erp.Winform.Inventario
{
    public partial class frmIn_AjustesInven_Cosulta : Form
    {


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        UCIn_Sucursal_Bodega UCSucu = new UCIn_Sucursal_Bodega();

        in_movi_inven_tipo_Bus MoviTipoB = new in_movi_inven_tipo_Bus();
        in_movi_inve_Bus MoviInven = new in_movi_inve_Bus();





        tb_Sucursal_Info _sucuI = new tb_Sucursal_Info();
        tb_Bodega_Info _bodegaI = new tb_Bodega_Info();
        List<in_movi_inve_Info> listMoviInve = new List<in_movi_inve_Info>();
        List<in_movi_inve_detalle_Info> listMoviInve_detalle = new List<in_movi_inve_detalle_Info>();



        in_movi_inve_Info _MoviInvenInfo = new in_movi_inve_Info();


        DevExpress.XtraGrid.Views.Grid.GridView Gview = new DevExpress.XtraGrid.Views.Grid.GridView();


        int idSucuIni = 0;
        int idSucuFin = 0;
        int idBodegaIni = 0;
        int idBodegaFin = 0;
        int idTipoMoviIni = 0;
        int idTipoMoviFin = 0;
        DateTime fechaIni;
        DateTime fechaFin;

        public frmIn_AjustesInven_Cosulta()
        {
            try
            {
                InitializeComponent();
                UCSucu.TipoCarga = Cl_Enumeradores.eTipoFiltro.Normal;
            }
            catch (Exception ex)
            {
              Log_Error_bus.Log_Error(ex.ToString());
            }
        }




        private void cargarCombos()
        {

            try
            {
                cmbTipoMoviInven.DataSource = MoviTipoB.Obtener_list_movi_inven_tipo(param.IdEmpresa, "", "N", "Todos");

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

                _sucuI = UCSucu.get_sucursal();

                idSucuIni = _sucuI.IdSucursal;
                idSucuFin = _sucuI.IdSucursal;

                _bodegaI = UCSucu.get_bodega();
                idBodegaIni = _bodegaI.IdBodega;
                idBodegaFin = idBodegaIni;

                idTipoMoviIni = Convert.ToInt32(cmbTipoMoviInven.SelectedValue);
                idTipoMoviFin = idTipoMoviIni;


                fechaIni = dtpDesde.Value;
                fechaFin = dtpHasta.Value;


                listMoviInve = MoviInven.Obtener_list_Movi_inven(param.IdEmpresa, idSucuIni, idSucuFin, idBodegaIni
                    , idBodegaFin, idTipoMoviIni, idTipoMoviFin, fechaIni, fechaFin);

                gridControl.DataSource = listMoviInve;            
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


       private  void setear_cabecera_grid()
        { 
            try 
            {	        
		        gvAjustes_Cabecera.ViewCaption = "Movimientos desde:" + dtpDesde.Value.ToShortDateString() + " Hasta:" + dtpHasta.Value.ToShortDateString();
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
                panelSucursal.Controls.Add(UCSucu);
                UCSucu.Dock = DockStyle.Fill;
                cargarCombos();


                dtpHasta.Value = DateTime.Now;
                dtpDesde.Value = dtpDesde.Value.AddDays(-60);


                cargarData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }


        private void mnu_salir_Click(object sender, EventArgs e)
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

        private void mnuNuevo_Click(object sender, EventArgs e)
        {
            try
            {

                frmIn_AjustesInven_Mant fAjus = new frmIn_AjustesInven_Mant();
                fAjus.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                fAjus.Text = fAjus.Text + " ***NUEVO REGISTRO***";
                fAjus.MdiParent = this.MdiParent;
                fAjus.Show();
                fAjus.event_frmIn_AjustesInven_Mant_FormClosing += fAjus_event_frmIn_AjustesInven_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void fAjus_event_frmIn_AjustesInven_Mant_FormClosing()
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


        private void mnu_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmIn_AjustesInven_Mant fAjus = new frmIn_AjustesInven_Mant();

                fAjus.set_AjusteMoviInven(_MoviInvenInfo);
                fAjus.set_Accion(Cl_Enumeradores.eTipo_action.actualizar);
                fAjus.Text = fAjus.Text + " ***MODIFICAR REGISTRO***";
                fAjus.MdiParent = this.MdiParent;
                fAjus.Show();
                fAjus.event_frmIn_AjustesInven_Mant_FormClosing += fAjus_event_frmIn_AjustesInven_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void mnu_consultar_Click(object sender, EventArgs e)
        {
            try
            {                
                frmIn_AjustesInven_Mant fAjus = new frmIn_AjustesInven_Mant();
                fAjus.set_AjusteMoviInven(_MoviInvenInfo);
                fAjus.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                

                fAjus.Text = fAjus.Text + " ***COSULTAR REGISTRO***";
                fAjus.MdiParent = this.MdiParent;
                fAjus.Show();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void gridControl_Click(object sender, EventArgs e){}

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.gvAjustes_Cabecera.ShowPrintPreview();
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
                limpiar_grilla();

                List<in_movi_inve_Info> info = new List<in_movi_inve_Info>();
                gridControl.DataSource = info;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                frmIn_AjustesInven_Mant fAjus = new frmIn_AjustesInven_Mant();
                fAjus.set_AjusteMoviInven(_MoviInvenInfo);
                fAjus.set_Accion(Cl_Enumeradores.eTipo_action.borrar);

                fAjus.Text = fAjus.Text + " ***ANULAR REGISTRO***";
                fAjus.MdiParent = this.MdiParent;
                fAjus.Show();
                fAjus.event_frmIn_AjustesInven_Mant_FormClosing += fAjus_event_frmIn_AjustesInven_Mant_FormClosing;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                setear_cabecera_grid();
                limpiar_grilla();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                setear_cabecera_grid();
                limpiar_grilla();
            }
            catch (Exception ex)
            {
                 Log_Error_bus.Log_Error(ex.ToString());
            }

        }

         private void limpiar_grilla()
        {
            try
            {
                gridControl.DataSource = null;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

         private void panelSucursal_Paint(object sender, PaintEventArgs e){}

         private void gvAjustes_Cabecera_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
         {
             try
             {
                 in_movi_inve_Info data = (in_movi_inve_Info)gvAjustes_Cabecera.GetRow(e.RowHandle);

                 if (data == null)
                 { return; }

                 if (data.Estado == "I")
                 {
                     e.Appearance.ForeColor = Color.Red;
                 }
             }
             catch (Exception ex)
             {
                 Log_Error_bus.Log_Error(ex.ToString());                 
             }
             
                        
         }


     
     
    }
}

/// <summary>
/// Prog: Katiuska Franco
/// Ult Mod: 26/02/2014  12:09
/// LIN 365
/// </summary>