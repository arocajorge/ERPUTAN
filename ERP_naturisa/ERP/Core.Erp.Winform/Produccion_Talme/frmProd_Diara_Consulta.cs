using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.Produccion_Talme;
using Core.Erp.Business.General;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
namespace Core.Erp.Winform.Produccion_Talme
{
    public partial class frmProd_Diara_Consulta : Form
    {
        prod_GestionProductivaLaminado_CusTalme_Bus _BusProd_B = new prod_GestionProductivaLaminado_CusTalme_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        frmProd_Diaria_Man frm = new frmProd_Diaria_Man();
        public frmProd_Diara_Consulta()
        {
            try
            {
                  InitializeComponent();
             frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        void frm_Event_frmProd_Diaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                CargarGrid();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                CargarGrid();
            }
            catch (Exception ex)
            {

                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }
        public void CargarGrid() 
        {
            try
            {
                DateTime FechaIni = Convert.ToDateTime(dtpFechaIni.Value.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(dtpFechaFin.Value.ToShortDateString());
                gridControlOrdeCompra.DataSource = _BusProd_B.ConulstaGenerla(param.IdEmpresa, FechaIni, FechaFin);
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmProd_Diaria_Man frm = new frmProd_Diaria_Man();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.grabar);
                frm.Show();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }
        prod_GestionProductivaLaminado_CusTalme_Info _Info = new prod_GestionProductivaLaminado_CusTalme_Info();
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                _Info = (prod_GestionProductivaLaminado_CusTalme_Info)gridView.GetFocusedRow();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                frm = new frmProd_Diaria_Man();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.consultar);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmProd_Diara_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                dtpFechaIni.Value = DateTime.Now.AddDays(-30);
                CargarGrid();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frm = new frmProd_Diaria_Man();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.borrar);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

            try
            {
                frm = new frmProd_Diaria_Man();
                frm.Event_frmProd_Diaria_FormClosing += new frmProd_Diaria_Man.delegate_frmProd_Diaria_FormClosing(frm_Event_frmProd_Diaria_FormClosing);
                frm.setAccion(Core.Erp.Info.General.Cl_Enumeradores.eTipo_action.actualizar);
                frm._SetInfo = _Info;
                frm.Show();
            }
            catch (Exception ex)
            {
                
                Cl_VisorSucucesos Visor = new Cl_VisorSucucesos();
                Visor.GuardarVisor(this.ToString(), ex);
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gridControlOrdeCompra.ShowRibbonPrintPreview();
        }
        //prod_GestionProductivaTechos_CusTalme_Cab_Info Info = new prod_GestionProductivaTechos_CusTalme_Cab_Info();
        //private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    Info = (prod_GestionProductivaTechos_CusTalme_Cab_Info)gridView.GetFocusedRow();
        //}
    }
}
