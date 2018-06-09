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
    public partial class XROL_Rpt018_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Departamento_bus = new ro_Departamento_Bus();
        List<ro_Departamento_Info> Lis_Departamento = new List<ro_Departamento_Info>();
        ro_rubro_tipo_Bus Rubro_Bus = new ro_rubro_tipo_Bus();
        List<ro_rubro_tipo_Info> List_rubro = new List<ro_rubro_tipo_Info>();
        ro_Empleado_Bus Empleado_Bus = new ro_Empleado_Bus();
        List<ro_Empleado_Info> Lis_Empleado = new List<ro_Empleado_Info>();
        public XROL_Rpt018_frm()
        {
            InitializeComponent();
        }


        private void pu_GenerarReporte()
        {
            try
            {
                XROL_Rpt018_Rpt Reporte = new XROL_Rpt018_Rpt();

                Reporte.RequestParameters = false;
                ReportPrintTool pt = new ReportPrintTool(Reporte);

                pt.AutoShowParametersPanel = false;
                Reporte.Parameters["s_fechaInicial"].Value = Convert.ToDateTime(dtp_fecha_inicio.EditValue);
                Reporte.Parameters["s_fechaFinal"].Value = Convert.ToDateTime(dtp_fecha_fin.EditValue);
                Reporte.Parameters["p_IdDepartamento"].Value = cmb_Departamento.EditValue == "" ? 0 : Convert.ToInt32(cmb_Departamento.EditValue);
                Reporte.Parameters["p_IdEmpleado"].Value = cmbEmpleados.EditValue == "" ? 0 : Convert.ToInt32(cmbEmpleados.EditValue);
                Reporte.Parameters["p_idnomina"].Value = cmbnomina.EditValue == "" ? 0 : Convert.ToInt32(cmbnomina.EditValue);
                Reporte.Parameters["idrubro"].Value = cmbRubros.EditValue == "" ? 0 : Convert.ToInt32(cmbRubros.EditValue);


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


                List_rubro = Rubro_Bus.Get_List_rubros_Ing_Egr(param.IdEmpresa,"E","I");
                cmbRubros.Properties.DataSource = List_rubro;
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

                if (cmb_Departamento.EditValue == null)
                {
                    bandera = false;
                    MessageBox.Show("Seleccione el departamento", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //if (cmbRubros.EditValue == null)
                //{
                //    bandera = false;
                //    MessageBox.Show("Seleccione el rubro", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

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

        private void cmb_Departamento_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Lis_Empleado = Empleado_Bus.Get_Lis_Empleado_x_Departamento(param.IdEmpresa, Convert.ToInt32(cmb_Departamento.EditValue));
                cmbEmpleados.Properties.DataSource = Lis_Empleado;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

        private void XROL_Rpt018_frm_Load(object sender, EventArgs e)
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
                pu_GenerarReporte();
            }
            catch (Exception ex)
            {

                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
