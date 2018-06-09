using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Reportes.CuentasxPagar;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Info.General;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.CuentasxPagar
{
    public partial class XCXP_Rpt015_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        static string result = Path.GetTempPath();
        String RootReporte = result + @"Comprobante de Retencion.repx";
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus busDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Bus();
        tb_sis_Documento_Tipo_Reporte_x_Empresa_Info InfoDoc_x_Emp = new tb_sis_Documento_Tipo_Reporte_x_Empresa_Info();
        

        public XCXP_Rpt015_frm()
        {
            InitializeComponent();           
        }


        public XCXP_Rpt015_frm(vwtb_sis_Documento_Tipo_x_Disenio_Report_Info Info)
        {
            InitializeComponent();
            commandBarItem31.PerformClick();
            XCXP_Rpt015_rpt reporte = new XCXP_Rpt015_rpt();

            InfoDoc_x_Emp = busDoc_x_Emp.get_DisenioRpt(Info.IdEmpresa, Info.codDocumentoTipo);
            if (InfoDoc_x_Emp.File_Disenio_Reporte != null)
            {
                File.WriteAllBytes(RootReporte, InfoDoc_x_Emp.File_Disenio_Reporte);
                reporte.LoadLayout(RootReporte);
            }

            InfoDoc_x_Emp.IdEmpresa = Info.IdEmpresa;
            InfoDoc_x_Emp.codDocumentoTipo = Info.codDocumentoTipo;

            xrDesignDockManager1.XRDesignPanel.OpenReport(reporte);
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string reportruta = result + "save.repx";
                xrDesignDockManager1.XRDesignPanel.SaveReport(reportruta);

                Byte[] data;
                using (System.IO.FileStream FL = new System.IO.FileStream(reportruta, System.IO.FileMode.Open))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        FL.CopyTo(ms);
                        data = ms.ToArray();
                    }
                }

                InfoDoc_x_Emp.File_Disenio_Reporte = data;
                String Mensajes = "";
                if (busDoc_x_Emp.GuardarDatos(InfoDoc_x_Emp, ref Mensajes))
                {
                    MessageBox.Show("Se Guardo Exitosamente el Diseño", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Mensajes, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
