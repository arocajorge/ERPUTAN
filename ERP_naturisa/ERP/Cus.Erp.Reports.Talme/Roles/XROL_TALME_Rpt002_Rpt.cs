using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Drawing.Printing;
using Core.Erp.Info.Roles;
using System.Collections.Generic;
using System.Collections;

namespace Cus.Erp.Reports.Talme.Roles
{
    public partial class XROL_TALME_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();

        public XROL_TALME_Rpt002_Rpt()
        {
            InitializeComponent();
            xrSubreportRol.ReportSource.RequestParameters = false;
        }

        private void xrSubreportRol_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                int idEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                decimal idEmpleado = ((ro_Empleado_Info)GetCurrentRow()).IdEmpleado;
                int idNominaTipo = Convert.ToInt32(this.PIdNomina_Tipo.Value);
                int idNominaTipoLiqui = Convert.ToInt32(this.PIdNominaTipoLiqui.Value);
                int idPeriodo = Convert.ToInt32(this.PIdPeriodo.Value);

                ((XRSubreport)sender).ReportSource.Parameters["P_idEmpresa"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["P_idEmpleado"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["P_idNominaTipo"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["P_idNominaTipoLiqui"].Value = idNominaTipoLiqui;
                ((XRSubreport)sender).ReportSource.Parameters["P_idPeriodo"].Value = idPeriodo;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;

            }
            catch (Exception ex)
            {

            }
        }

        public void ListEmpleado(List<ro_Empleado_Info> Lis)
        {
            try
            {
                ListaEmpleado = Lis;
            }
            catch (Exception)
            {

            }
        }

        private void xrSubreportRolCopia_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {

                int idEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                decimal idEmpleado = ((ro_Empleado_Info)GetCurrentRow()).IdEmpleado;
                int idNominaTipo = Convert.ToInt32(this.PIdNomina_Tipo.Value);
                int idNominaTipoLiqui = Convert.ToInt32(this.PIdNominaTipoLiqui.Value);
                int idPeriodo = Convert.ToInt32(this.PIdPeriodo.Value);

                ((XRSubreport)sender).ReportSource.Parameters["P_idEmpresa"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["P_idEmpleado"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["P_idNominaTipo"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["P_idNominaTipoLiqui"].Value = idNominaTipoLiqui;
                ((XRSubreport)sender).ReportSource.Parameters["P_idPeriodo"].Value = idPeriodo;
                // ((XRSubreport)sender).ReportSource.Parameters["PVisible_label_FielCopia"].Value = true;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void XROL_TALME_Rpt002_Rpt_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.DataSource = ListaEmpleado;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
