using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.General;

namespace Cus.ERP.Reports.Grafinpren.Facturacion
{
    public partial class XFAC_GRAF_Rpt002_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;        

        public XFAC_GRAF_Rpt002_frm()
        {
            InitializeComponent();
        }

        private void btn_actualizar_data_Click(object sender, EventArgs e)
        {
            try
            {
                cargarDatosGrid();
            }
            catch (Exception)
            {
                
                
            }
        }

        void cargarDatosGrid()
        {
            try
            {
                XFAC_GRAF_Rpt002_Bus rptBus = new XFAC_GRAF_Rpt002_Bus();
                string MensError="";
                
                DateTime fechaini = DateTime.Now;
                DateTime fechafin = DateTime.Now;
                fechaini = dtpfecha_ini.Value;
                fechafin = dtpfecha_fin.Value;


                this.pivotGridControlDocumento.DataSource = rptBus.Get_List_Data(param.IdEmpresa, fechaini, fechafin, ref MensError);


            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        private void XFAC_GRAF_Rpt002_frm_Load(object sender, EventArgs e)
        {
            
            dtpfecha_fin.Value = DateTime.Now;
            dtpfecha_ini.Value = DateTime.Now.AddMonths(-1);
            cargarDatosGrid();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_impri_Click(object sender, EventArgs e)
        {
            try
            {
                this.pivotGridControlDocumento.ShowPrintPreview();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

       
    }
}
