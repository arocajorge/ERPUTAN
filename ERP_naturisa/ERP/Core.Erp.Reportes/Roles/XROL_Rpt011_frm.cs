
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Core.Erp.Business.General;
using Core.Erp.Business.Roles;
using Core.Erp.Info.Roles;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt011_frm : Form
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       
        ro_Nomina_Tipo_Bus oRo_Nomina_Tipo_Bus = new ro_Nomina_Tipo_Bus();
        ro_Nomina_Tipoliqui_Bus nominatipo_Bus = new ro_Nomina_Tipoliqui_Bus();
        ro_periodo_x_ro_Nomina_TipoLiqui_Bus periodo_nomina_bus = new ro_periodo_x_ro_Nomina_TipoLiqui_Bus();

        List<ro_Nomina_Tipo_Info> listadoNomina = new System.Collections.Generic.List<ro_Nomina_Tipo_Info>();
        List<ro_Nomina_Tipoliqui_Info> ListadoTipoLiquidacion = new System.Collections.Generic.List<ro_Nomina_Tipoliqui_Info>();
        List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> listadoPeriodo = new System.Collections.Generic.List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();


        int _idEmpresa = 0;
        decimal _idArchivo = 0;
   
        public XROL_Rpt011_frm()
        {
            InitializeComponent();
        }


      




       
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void XROL_Rpt011_frm_Load(object sender, System.EventArgs e)
        {
            try
            {
               

                

               
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        
        

        private void cmbPeriodos_EditValueChanged(object sender, System.EventArgs e)
        {

        }



        private bool validar()
        {
            try
            {
                bool ba=true;

                if (ucRo_Menu_Reportes1.getIdNominaTipo() == null)
                {

                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_la)+" la nomina", param.Nombre_sistema,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ba=false;
                }


                if (ucRo_Menu_Reportes1.getIdNominaTipoLiqui() == null)
                {

                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_el) + " el proceso", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba = false;
                }


                if (ucRo_Menu_Reportes1.Get_Info_Periodo() == null)
                {

                    MessageBox.Show(param.Get_Mensaje_sys(Info.General.enum_Mensajes_sys.Seleccione_el) + " el periodo", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ba = false;
                }

                return ba;
            }
            catch (System.Exception ex)
            {
                
                 MessageBox.Show(ex.ToString());
                 return false;
            }
        }

        private void ucRo_Menu_Reportes1_event_cmdCargar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {



                if (!validar())
                    return;
                XROL_Rpt011_Bus oReporteBus = new XROL_Rpt011_Bus();
                List<XROL_Rpt011_Info> oListado = new List<XROL_Rpt011_Info>();



                if (ucRo_Menu_Reportes1.getIdDivision() == null || ucRo_Menu_Reportes1.getIdDivision()=="")
                    oListado = oReporteBus.GetListPorArchivo(param.IdEmpresa, Convert.ToInt32(ucRo_Menu_Reportes1.getIdNominaTipo()), Convert.ToInt32(ucRo_Menu_Reportes1.getIdNominaTipoLiqui()), Convert.ToInt32(ucRo_Menu_Reportes1.getIdPeriodo()));
                else

                    oListado = oReporteBus.GetListPorArchivo(param.IdEmpresa, Convert.ToInt32(ucRo_Menu_Reportes1.getIdNominaTipo()), Convert.ToInt32(ucRo_Menu_Reportes1.getIdNominaTipoLiqui()), Convert.ToInt32(ucRo_Menu_Reportes1.getIdPeriodo()), Convert.ToInt32(ucRo_Menu_Reportes1.getIdDivision()));


                if (oListado.Count() == 0)
                {
                    MessageBox.Show("No hay datos para los filtros Seleccionados");
                    return;
                }


                XROL_Rpt011_rpt reporte = new XROL_Rpt011_rpt();

                reporte.Set_Listado(oListado);
                //ReportPrintTool pt = new ReportPrintTool(reporte);
               //   printControlReporte.PrintingSystem = reporte.PrintingSystem;
                reporte.CreateDocument();
                reporte.ShowPreview();
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


    }
}
