using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;


namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt001_frm : Form
    {
        vwtb_persona_beneficiario_Bus Bus_Beneficiario = new vwtb_persona_beneficiario_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        tb_persona_tipo_Bus Persona_Tipo_Bus = new tb_persona_tipo_Bus();

        List<cp_proveedor_clase_Info> listProvee_clas = new List<cp_proveedor_clase_Info>();
        List<cp_catalogo_Info> listCatalogo = new List<cp_catalogo_Info>();
        List<vwtb_persona_beneficiario_Info> list_Beneficiario = new List<vwtb_persona_beneficiario_Info>();
        List<tb_persona_tipo_Info> list_Persona_Tipo = new List<tb_persona_tipo_Info>();
        vwtb_persona_beneficiario_Info infoBenediciario = new vwtb_persona_beneficiario_Info();
        tb_persona_tipo_Info info = new tb_persona_tipo_Info();

        public XCXP_NATU_Rpt001_frm()
        {
            InitializeComponent();
        }
      
        private void XCXP_NATU_Rpt001_frm_Load(object sender, EventArgs e)
        {
            try
            {
                cargar_combos();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_procesar_reporte_Click(object sender, EventArgs e)
        {
            try
            {

                XCXP_NATU_Rpt001_Rpt Reporte = new XCXP_NATU_Rpt001_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;

                Reporte.Parameters["IdEmpresa"].Value = param.IdEmpresa;
                Reporte.Parameters["TipoPersona"].Value = cmb_tipo_persona.EditValue;
                Reporte.Parameters["Fecha_Ini"].Value = dtp_desde.Value;
                Reporte.Parameters["Fecha_Fin"].Value = dtp_hasta.Value;
                Reporte.Parameters["IdProveedorIni"].Value = (cmb_clase_provee.EditValue == null) ? 0 : cmb_clase_provee.EditValue;
                Reporte.Parameters["IdProveedorFin"].Value = (cmb_clase_provee.EditValue == null) ? 999999 : cmb_clase_provee.EditValue;
                Reporte.Parameters["Persona"].Value = cmb_tipo_persona.EditValue == null ? "Todos" : cmb_tipo_persona.Text;
                Reporte.Parameters["S_claseProveedor"].Value = cmb_clase_provee.EditValue == null ? "Todos" : cmb_clase_provee.Text;
                Reporte.Parameters["S_Fechadesde"].Value = dtp_desde.Text;
                Reporte.Parameters["S_Fechahasta"].Value = dtp_hasta.Text;
                Reporte.Parameters["FechaImpresion"].Value = DateTime.Now.ToString();
                Reporte.Parameters["S_IdEmpresa"].Value = param.InfoEmpresa.em_nombre;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargar_combos()
        {
            try
            {
                list_Persona_Tipo = Persona_Tipo_Bus.Get_List_persona_tipo();
                cmb_tipo_persona.Properties.DataSource = list_Persona_Tipo;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_tipo_persona_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal i = 1;
                list_Beneficiario = Bus_Beneficiario.Get_List_PersonaBeneficiario(param.IdEmpresa, Convert.ToString(cmb_tipo_persona.EditValue));
                //foreach (var item in list_Beneficiario)
                //{
                //    item.secuencial = i++;
                //}
                cmb_clase_provee.Properties.DataSource = list_Beneficiario;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void printPreviewBarItem26_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
