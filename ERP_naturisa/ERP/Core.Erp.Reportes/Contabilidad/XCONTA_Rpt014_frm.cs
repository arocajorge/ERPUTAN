using Core.Erp.Business.General;
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

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt014_frm : Form
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCONTA_Rpt014_frm()
        {
            InitializeComponent();
        }

        private void Menu_event_btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XCONTA_Rpt014_Rpt rpt = new XCONTA_Rpt014_Rpt();
                rpt.P_FechaIni.Value = Menu.bei_Desde.EditValue == null ? DateTime.Now : Menu.bei_Desde.EditValue;
                rpt.P_FechaIni.Visible = false;
                rpt.P_FechaFin.Value = Menu.bei_Hasta.EditValue == null ? DateTime.Now : Menu.bei_Hasta.EditValue;
                rpt.P_FechaFin.Visible = false;

                rpt.P_IdCentroCosto.Value = Menu.Get_info_Centro_costo() == null ? "" : Menu.Get_info_Centro_costo().IdCentroCosto;
                rpt.P_IdCentroCosto.Visible = false;
                rpt.P_IdGrupoCble.Value = "";
                rpt.P_IdGrupoCble.Visible = false;
                rpt.P_IdCtaCble.Value = Menu.Get_info_plancta() == null ? "" : Menu.Get_info_plancta().IdCtaCble;
                rpt.P_IdCtaCble.Visible = false;
                rpt.Set_list_grupo_cble(Menu.Get_grupo_checked());
                rpt.PS_CentroCosto.Value = Menu.Get_info_Centro_costo() == null ? "TODOS" : Menu.Get_info_Centro_costo().Centro_costo2;
                rpt.PS_GrupoCble.Value = Menu.Get_grupo_checked_nombres();
                rpt.PS_CtaCble.Value = Menu.Get_info_plancta() == null ? "TODAS" : Menu.Get_info_plancta().pc_Cuenta2;

                rpt.P_Mostrar_CC.Value = Menu.bei_Check.EditValue == null ? false : Menu.bei_Check.EditValue;
                rpt.P_Mostrar_SCC.Value = Menu.bei_Check2.EditValue == null ? false : Menu.bei_Check2.EditValue;
                rpt.P_Mostrar_Grupo.Value = Menu.bei_Check3.EditValue == null ? false : Menu.bei_Check3.EditValue;
                rpt.P_Mostrar_Punto.Value = Menu.bei_Check4.EditValue == null ? false : Menu.bei_Check4.EditValue;

                ReportPrintTool pt = new ReportPrintTool(rpt);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.RequestParameters = false;
                
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                MessageBox.Show(ex.Message, param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void XCONTA_Rpt014_frm_Load(object sender, EventArgs e)
        {
            try
            {
                Menu.Cargar_combos();

                switch (param.IdCliente_Ven_x_Default)
                {
                    case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.GRAFINPRENT:
                        Menu.Visible_bei_Check2 = DevExpress.XtraBars.BarItemVisibility.Never;
                        Menu.Visible_bei_Check3 = DevExpress.XtraBars.BarItemVisibility.Never;
                        Menu.Visible_bei_Check4 = DevExpress.XtraBars.BarItemVisibility.Never;
                        Menu.Visible_Grupo_Punto_cargo = false;
                        break;
                    case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.FJ:
                        
                        break;                   
                    default:
                        break;
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
