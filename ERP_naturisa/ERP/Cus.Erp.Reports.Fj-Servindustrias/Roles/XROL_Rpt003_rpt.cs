using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.Drawing.Printing;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Roles;
using System.Collections.Generic;
using System.Collections;
namespace Cus.Erp.Reports.FJ.Roles
{
    public partial class XROL_Rpt003_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        List<ro_Empleado_Info> ListaEmpleado = new List<ro_Empleado_Info>();

        public XROL_Rpt003_rpt()
        {
            InitializeComponent();
            xrSubreportRol.ReportSource.RequestParameters = false;
        }

        private void XROL_Rpt003_rpt_BeforePrint(object sender, PrintEventArgs e)
        {
            try
            {
                this.DataSource = ListaEmpleado;
            }
            catch (Exception)
            {
                
                throw;
            }
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

                ((XRSubreport)sender).ReportSource.Parameters["s_idEmpresa"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["s_idEmpleado"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["s_idNominaTipo"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["s_idNominaTipoLiqui"].Value = idNominaTipoLiqui;
                ((XRSubreport)sender).ReportSource.Parameters["s_idPeriodo"].Value = idPeriodo;
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


                ((XRSubreport)sender).ReportSource.Parameters["s_idEmpresa"].Value = idEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["s_idEmpleado"].Value = idEmpleado;
                ((XRSubreport)sender).ReportSource.Parameters["s_idNominaTipo"].Value = idNominaTipo;
                ((XRSubreport)sender).ReportSource.Parameters["s_idNominaTipoLiqui"].Value = idNominaTipoLiqui;
                ((XRSubreport)sender).ReportSource.Parameters["s_idPeriodo"].Value = idPeriodo;
                // ((XRSubreport)sender).ReportSource.Parameters["PVisible_label_FielCopia"].Value = true;
                ((XRSubreport)sender).ReportSource.RequestParameters = false;
            }
            catch (Exception ex)
            {


            }

        }

        
    }
}
