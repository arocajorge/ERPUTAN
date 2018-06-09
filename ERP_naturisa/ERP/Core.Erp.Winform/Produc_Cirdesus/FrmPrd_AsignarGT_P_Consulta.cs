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
    public partial class FrmPrd_AsignarGT_P_Consulta : Form
    {
        prd_GruposTrabajo_PorPP_Info info = new prd_GruposTrabajo_PorPP_Info();
        prd_GruposTrabajo_PorPP_Bus Bus = new prd_GruposTrabajo_PorPP_Bus();
        private cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<prd_GruposTrabajo_PorPP_Info> Lista = new List<prd_GruposTrabajo_PorPP_Info>();
        public FrmPrd_AsignarGT_P_Consulta()
        {
            InitializeComponent();
        }

        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_AsignarGT_P_ProductivoMantenimiento frm = new FrmPrd_AsignarGT_P_ProductivoMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;

                frm.Show();

                //   frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void ucGe_Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ucGe_Menu_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (info == null)
                {
                    MessageBox.Show("Selecciones un Registro");
                    return;
                }
                FrmPrd_AsignarGT_P_ProductivoMantenimiento frm = new FrmPrd_AsignarGT_P_ProductivoMantenimiento();
                frm.set_Accion(Cl_Enumeradores.eTipo_action.consultar);
                frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;

                frm.Set(info);
                frm.Show();
                
                //   frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void gridViewEtapasGrupos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                info = (prd_GruposTrabajo_PorPP_Info)gridViewEtapasGrupos.GetFocusedRow();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        public void CargarData()
        {
            try
            {
                Lista = Bus.GetListEtapasProceProductivo(param.IdEmpresa);
                GridetapasGrupos.DataSource = Lista;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmPrd_AsignarGT_P_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        //private void gridViewEtapasGrupos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        //{
        //    try
        //    {
        //        info = (prd_GruposTrabajo_PorPP_Info)gridViewEtapasGrupos.GetFocusedRow();

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void GridetapasGrupos_Click(object sender, EventArgs e)
        {
            try
            {
                info = (prd_GruposTrabajo_PorPP_Info)gridViewEtapasGrupos.GetFocusedRow();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //private void gridViewEtapasGrupos_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //    try
        //    {
        //        info = (prd_GruposTrabajo_PorPP_Info)gridViewEtapasGrupos.GetFocusedRow();

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
