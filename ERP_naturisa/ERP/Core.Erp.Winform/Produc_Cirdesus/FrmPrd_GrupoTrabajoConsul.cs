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
    public partial class FrmPrd_GrupoTrabajoConsul : Form
    {
        public FrmPrd_GrupoTrabajoConsul()
        {
            InitializeComponent();
        }
        prd_GrupoTrabajo_Info Info= new prd_GrupoTrabajo_Info();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<prd_GrupoTrabajo_Info> ListaGT = new List<prd_GrupoTrabajo_Info>();
        prd_GrupoTrabajo_Bus BusGT = new prd_GrupoTrabajo_Bus();
        private void ucGe_Menu_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FrmPrd_GrupoTrabajoMant frm = new FrmPrd_GrupoTrabajoMant();
                frm.SetAcciones(Cl_Enumeradores.eTipo_action.grabar);
                frm.Text = frm.Text + " ***NUEVO REGISTRO***"; frm.MdiParent = this.MdiParent;
               
                frm.Show();

             //   frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);

            }

        }

        private void ucGe_Menu_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Info == null)
                {
                    MessageBox.Show("Selecciones un Registro");
                    return;
                }
                  FrmPrd_GrupoTrabajoMant frm = new FrmPrd_GrupoTrabajoMant();
                  frm.SetAcciones(Cl_Enumeradores.eTipo_action.actualizar);
                  frm.Text = frm.Text + " ***MODIFICAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                 
                   frm.Show();
                   frm.Set(Info);
                //   frm.Event_FrmPrd_ListadoMaterialesMant_FormClosing += new FrmPrd_ListadoMaterialesMant.Delegate_FrmPrd_ListadoMaterialesMant_FormClosing(frm_Event_FrmPrd_ListadoMaterialesMant_FormClosing);


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
                if (Info == null)
                {
                    MessageBox.Show("Selecciones un Registro");
                    return;
                }
                FrmPrd_GrupoTrabajoMant frm = new FrmPrd_GrupoTrabajoMant();
                 frm.SetAcciones(Cl_Enumeradores.eTipo_action.consultar);
                 frm.Text = frm.Text + " ***CONSULTAR REGISTRO***"; frm.MdiParent = this.MdiParent;
                
                 frm.Show();
                 frm.Set(Info);
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

        private void FrmPrd_GrupoTrabajoConsul_Load(object sender, EventArgs e)
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



        public void CargarData()
        {
            try
            {
                ListaGT = BusGT.ObtenerGrupoTrabajoCab(param.IdEmpresa);
                gridControlGT.DataSource = ListaGT;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void gridViewGT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Info = (prd_GrupoTrabajo_Info)gridViewGT.GetFocusedRow();

            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
        }
    }
}
