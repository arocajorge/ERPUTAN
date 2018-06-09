using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Core.Erp.Info.General;
using Core.Erp.Business.General;

using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;

using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars;

namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt019_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_rubro_tipo_Bus Rubro_Bus = new ro_rubro_tipo_Bus();
        List<ro_rubro_tipo_Info> List_rubro = new List<ro_rubro_tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();


        public XROL_Rpt019_frm()
        {
            InitializeComponent();
        }


        private void GenerarReporte()
        {
            try
            {
                XROL_Rpt019_rpt Reporte = new XROL_Rpt019_rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["idNominaTipo"].Value = cmbnomina.EditValue;
                Reporte.Parameters["idNominaTipoLiqui"].Value =cmbnominaTipo.EditValue;
                Reporte.Parameters["IdDepartamento"].Value = cmb_Departamento.EditValue == "" ? 0 : Convert.ToInt32(cmb_Departamento.EditValue);
                Reporte.Parameters["fecha_inicio"].Value = dtp_fecha_inicio.EditValue;
                Reporte.Parameters["fecha_fin"].Value = dtp_fecha_fin.EditValue;

                printControlReporte.PrintingSystem = Reporte.PrintingSystem;
                Reporte.CreateDocument();

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        public void Cargar_Datos()
        {

            try
            {
                dtp_fecha_fin.EditValue = DateTime.Now;
                dtp_fecha_inicio.EditValue = DateTime.Now.AddMonths(-1);
                listadoNomina = oRo_Nomina_Tipo_Bus.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbnomina.Properties.DataSource = listadoNomina;


                Lis_Departamento = Departamento_bus.Get_List_Departamento(param.IdEmpresa);
                cmb_Departamento.Properties.DataSource = Lis_Departamento;


            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
        public bool validar()
        {
            bool bandera = true;
            try
            {
                if (cmbnomina.EditValue == null)
                {
                    bandera = false;
                    //  MessageBox.Show(param.Get_Mensaje_sys(enum_Mensajes_sys.Seleccione_la)+"nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Seleccione la nomina", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //if (cmb_Departamento.EditValue == null)
                //{
                //    bandera = false;
                //    MessageBox.Show("Seleccione el departamento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                if (cmbnominaTipo.EditValue == null)
                {
                    bandera = false;
                    MessageBox.Show("Seleccione el Proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Convert.ToDateTime(dtp_fecha_inicio.EditValue).Date > Convert.ToDateTime(dtp_fecha_fin.EditValue).Date)
                {
                    bandera = false;
                    MessageBox.Show("fecha inicio no puede ser mayor que la fecha final", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return bandera;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
                return bandera;
            }

        }

        private void Cmbsalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception ex)
            {
                
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validar())
                {
                    GenerarReporte();
                }
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }

        private void cmbnomina_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ListadoTipoLiquidacion = nominatipo_Bus.Get_List_Nomina_Tipoliqui_x_Nomina_Tipo(param.IdEmpresa, Convert.ToInt32(cmbnomina.EditValue));
               cmbnominaTipo.Properties.DataSource = ListadoTipoLiquidacion;
            }
            catch (Exception ex)
            {
                
                 Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void XROL_Rpt019_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar_Datos();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
