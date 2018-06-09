using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.General;
using DevExpress.XtraReports.UI;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt014_frm : Form
    {
        public XROL_Rpt014_frm()
        {
            InitializeComponent();
        }
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        List<ro_Nomina_Tipo_Info> ListadoNomina = new List<ro_Nomina_Tipo_Info>();
        ro_Nomina_Tipo_Bus Bus_Nomina = new ro_Nomina_Tipo_Bus();
        ro_Departamento_Bus Bus_Departamento = new ro_Departamento_Bus();
        List<ro_Departamento_Info> ListadoDepartamento = new List<ro_Departamento_Info>();
        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();
        ro_Empleado_Bus BusEmpleado = new ro_Empleado_Bus();
        List<XROL_Rpt014_Info> listado_Rubos_x_Empleado = new List<XROL_Rpt014_Info>();
        XROL_Rpt014_Bus Bus_list_Rubros = new XROL_Rpt014_Bus();


        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void XROL_Rpt014_frm_Load(object sender, EventArgs e)
        {
            try
            {
                ListadoNomina = Bus_Nomina.Get_List_Nomina_Tipo(param.IdEmpresa);
                cmbNomina.Properties.DataSource = ListadoNomina;

                ListadoDepartamento = Bus_Departamento.Get_List_Departamento(param.IdEmpresa);
                cmbDepartamento.Properties.DataSource = ListadoDepartamento;

                ListaEmpleado = BusEmpleado.Get_List_Empleado_(param.IdEmpresa);
                CmbEmpleado.Properties.DataSource = ListaEmpleado;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGenerar_Reporte_Click(object sender, EventArgs e)
        {
            try
            {

                listado_Rubos_x_Empleado = Bus_list_Rubros.Get_list_Rubros_X_Empleados(param.IdEmpresa,Convert.ToInt32( cmbNomina.EditValue),Convert.ToInt32( cmbDepartamento.EditValue));
                if (CmbEmpleado.EditValue != null && CmbEmpleado.EditValue != "")
                {
                    listado_Rubos_x_Empleado = listado_Rubos_x_Empleado.Where(v=>v.IdEmpleado==Convert.ToInt32( CmbEmpleado.EditValue)).ToList();
                }

               
                XROL_Rpt014_Rpt reporte = new XROL_Rpt014_Rpt();

                reporte.Set_Lista(listado_Rubos_x_Empleado);
                ReportPrintTool pt = new ReportPrintTool(reporte);
                printControl.PrintingSystem = reporte.PrintingSystem;
                reporte.CreateDocument();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
