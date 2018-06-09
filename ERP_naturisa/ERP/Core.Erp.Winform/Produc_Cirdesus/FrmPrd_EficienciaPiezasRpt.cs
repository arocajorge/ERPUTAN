using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Winform.Controles;
using Core.Erp.Business.General;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Business.Produc_Cirdesus;

namespace Core.Erp.Winform.Produc_Cirdesus
{
    public partial class FrmPrd_EficienciaPiezasRpt : Form
    {
        public FrmPrd_EficienciaPiezasRpt()
        {
            try
            {
                InitializeComponent();
                iniciar_controles();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        //instancia de centro de costo
        UCCon_CentroCosto_ctas_padre UCCentroCosto = new UCCon_CentroCosto_ctas_padre();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        //XRpt_prd_EficienciaPiezas XRpt_Eficiencia = new XRpt_prd_EficienciaPiezas();

        prd_EficienciaPiezas_Rpt_Info InfoEf = new prd_EficienciaPiezas_Rpt_Info();
        List<prd_EficienciaPiezas_Rpt_Info> LstEf = new List<prd_EficienciaPiezas_Rpt_Info>();
        prd_EficienciaPiezas_Rpt_Bus busEf = new prd_EficienciaPiezas_Rpt_Bus();

        private void FrmPrd_EficienciaPiezasRpt_Load(object sender, EventArgs e){}

        private void iniciar_controles()
        {
            try
            {
                UCCentroCosto.cargaCmb_centroCostos();
                panelCentroCosto.Controls.Add(UCCentroCosto);
                UCCentroCosto.Dock = DockStyle.Fill;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            try
            {
                //XRpt_Eficiencia = new XRpt_prd_EficienciaPiezas();

                InfoEf = busEf.ObtenerReporte(param.IdEmpresa,param.IdSucursal,UCCentroCosto.get_item());
                
                LstEf.Clear();
                LstEf.Add(InfoEf);
                //XRpt_Eficiencia.cargaData(LstEf.ToArray(), param.IdUsuario);

                //printControlEficienciaPiezas.PrintingSystem = XRpt_Eficiencia.PrintingSystem;
                //XRpt_Eficiencia.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }
    }
}
