using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;



using Core.Erp.Business.Contabilidad;
using Core.Erp.Info.Contabilidad;

using Core.Erp.Business.General;


namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt010_frm : Form
    {

        #region Variables
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

        ct_Periodo_Bus busPeriodo = new ct_Periodo_Bus();
        List<ct_Periodo_Info> listPeriodo = new List<ct_Periodo_Info>();
        ct_Periodo_Info infoPeriodo = new ct_Periodo_Info();
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        List<XCONTA_Rpt010_Info> lista = new List<XCONTA_Rpt010_Info>();
        XCONTA_Rpt010_Info Info_Fila = new XCONTA_Rpt010_Info();

        #endregion

        public XCONTA_Rpt010_frm()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                XCONTA_Rpt010_Rpt Reporte = new XCONTA_Rpt010_Rpt();

                int IdPunto_cargo_grupo = 0;
                string Nom_Periodo = "";

                DateTime FechaIni;
                DateTime FechaFin;

                FechaIni = dtpFechaIni.Value;
                FechaFin = dtpFechaFin.Value;

                IdPunto_cargo_grupo = uCct_Pto_Cargo_Grupo.Get_Id_grupo();

                if (IdPunto_cargo_grupo == 0)
                { MessageBox.Show("Escoja el grupo de punto de cargo", param.Nombre_sistema, MessageBoxButtons.OK); return; }

                Nom_Periodo = cmb_Periodo.Text;

                Reporte.PIdEmpresa.Value = param.IdEmpresa;
                Reporte.PIdEmpresa.Visible = false;

                Reporte.PFechaIni.Value = FechaIni;
                Reporte.PFechaIni.Visible = false;

                Reporte.PFechaFin.Value = FechaFin;
                Reporte.PFechaFin.Visible = false;

                Reporte.PIdPunto_cargo_grupo.Value = IdPunto_cargo_grupo;
                Reporte.PIdPunto_cargo_grupo.Visible = false;

                Reporte.PMostrar_Reg_Cero.Value = chkMostrar_Saldo_cero.Checked;
                Reporte.PMostrar_Reg_Cero.Visible = false;


                Reporte.RequestParameters = false;


                splashScreenManager.ShowWaitForm();//Inicio splash
                Reporte.ShowPreview();
                splashScreenManager.CloseWaitForm();//terminar splash
            }
            catch (Exception ex)
            {
                splashScreenManager.CloseWaitForm();
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XCONTA_Rpt010_frm_Load(object sender, EventArgs e)
        {
            carga_combos();
        }

        void carga_combos()
        {
            try
            {
                string msg = "";

                uCct_Pto_Cargo_Grupo.Cargar_combos();

                listPeriodo = busPeriodo.Get_List_PeriodoCombo(param.IdEmpresa, ref msg);
                cmb_Periodo.Properties.DataSource = listPeriodo;
                cmb_Periodo.Properties.ValueMember = "IdPeriodo";
                cmb_Periodo.Properties.DisplayMember = "nom_periodo";
                
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Periodo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                ct_Periodo_Info oPeriO = listPeriodo.FirstOrDefault(v => v.IdPeriodo == Convert.ToInt32(cmb_Periodo.EditValue));

                dtpFechaIni.Value = oPeriO.pe_FechaIni;
                dtpFechaFin.Value = oPeriO.pe_FechaFin;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    
    }
}
