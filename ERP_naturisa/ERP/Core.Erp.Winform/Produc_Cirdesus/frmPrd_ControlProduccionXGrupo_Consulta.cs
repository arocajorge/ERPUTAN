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
using Core.Erp.Info.General;
using DevExpress.XtraPrinting;
namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class frmPrd_ControlProduccionXGrupo_Consulta : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        frmPrd_ControlProduccionxGrupo_Mant Ofrm = new frmPrd_ControlProduccionxGrupo_Mant();
        List<prd_ControlProduccionObrero_Info> Lista = new List<prd_ControlProduccionObrero_Info>();
        prd_ControlProduccionObrero_Bus Bus = new prd_ControlProduccionObrero_Bus(); 
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        prd_ControlProduccionObrero_Info _Info = new prd_ControlProduccionObrero_Info();
        prd_SubGrupoTrabajo_Bus GrupoTrabajoBus = new prd_SubGrupoTrabajo_Bus();
        List<prd_SubGrupoTrabajo_Info> LisGrupoTrabajo = new List<prd_SubGrupoTrabajo_Info>();

        public frmPrd_ControlProduccionXGrupo_Consulta()
        {
            try
            {
                InitializeComponent();
               }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }



        


        private void ucGe_Menu_event_btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl.ShowPrintPreview();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ucGe_Menu_event_btnSalir_Click(object sender, EventArgs e)
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

        private void frmPrd_ControlProduccionXGrupo_Consulta_Load(object sender, EventArgs e)
        {
            try
            {
                      CagarGrupoTrabajo();
                                 }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void CagarGrupoTrabajo()
        {
            try
            {
              LisGrupoTrabajo=  GrupoTrabajoBus.ObtenerGrupoTrabajoCab(param.IdEmpresa);
              CmbGrupoTrabajo.Properties.DataSource = LisGrupoTrabajo;
              gridControl.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
             Lista=   Bus.ObtenerCrtlPrdObreroCab(param.IdEmpresa,Convert.ToInt32( CmbGrupoTrabajo.EditValue),dtpFInicio.Value,dtpFFin.Value);
             gridControl.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
