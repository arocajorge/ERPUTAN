using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using DevExpress.XtraBars;
using Core.Erp.Info.Roles;
using System.IO;
using System.Diagnostics;

namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROLES_Rpt008_frm : Form
    {
        public XROLES_Rpt008_frm()
        {
            InitializeComponent();
        }
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XROLES_Rpt008_Info> lista = new List<XROLES_Rpt008_Info>();
        XROLES_Rpt008_Bus bus = new XROLES_Rpt008_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Info info_perio = new Core.Erp.Info.Roles.ro_periodo_x_ro_Nomina_TipoLiqui_Info();
        private void ucRo_Menu_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Generar_Excell();
        }



        private void Generar_Excell()
        {
            try
            {


                ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                info = ucRo_Menu.Get_Info_Periodo();
                int IdNomina = Convert.ToInt32(ucRo_Menu.getIdNominaTipo());
                info_perio = ucRo_Menu.Get_Info_Periodo();
                info_perio.pe_anio = info_perio.pe_FechaIni.Year;
                info_perio.pe_mes = info_perio.pe_FechaIni.Month;
                lista = bus.Get_Nomina_consolidada(info_perio);
                pivotGridControl1.DataSource = lista;

                
                OpenFileDialog ofdDoc;//txt
                SaveFileDialog sfdDoc;//txt
                ofdDoc = new OpenFileDialog();
                sfdDoc = new SaveFileDialog();
                string Nombrefile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (sfdDoc.ShowDialog() == DialogResult.OK)
                {

                    if (File.Exists(sfdDoc.FileName))
                    {
                        File.Delete(sfdDoc.FileName);
                    }
                    sfdDoc.FileName = sfdDoc.FileName + ".xls";
                    pivotGridControl1.ExportToXls(sfdDoc.FileName);


                    if (MessageBox.Show("Desea ver el Archivo...?", "INFORMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        Process.Start(sfdDoc.FileName);
                }






            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

    }
}
