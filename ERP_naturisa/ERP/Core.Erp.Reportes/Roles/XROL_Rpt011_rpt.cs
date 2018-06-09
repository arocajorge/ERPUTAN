/*CLASE: XROL_Rpt011_rpt
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Collections.Generic;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;


namespace Core.Erp.Reportes.Roles
{
    public partial class XROL_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        XROL_Rpt011_Bus oReporteBus = new XROL_Rpt011_Bus();
        List<XROL_Rpt011_Info> oListado = new List<XROL_Rpt011_Info>();
        string mensaje = "";

        public XROL_Rpt011_rpt()
        {
            InitializeComponent();
        }

        private void XROL_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
               

                
                lbtca.Text =Convert.ToString( oListado.Where(v=>v.TipoCuenta=="AHO").Count());
                lbtcc.Text =Convert.ToString( oListado.Where(v => v.TipoCuenta == "COR").Count());
                lbtcv.Text =Convert.ToString( oListado.Where(v => v.TipoCuenta == "VRT").Count());
                lbtch.Text =Convert.ToString( oListado.Where(v => v.TipoCuenta == "CHEQ").Count());

               lbtotapca.Text =Convert.ToString( oListado.Where(v => v.TipoCuenta == "AHO").Sum(v=>v.Valor));
               lbtotapcc.Text = Convert.ToString(oListado.Where(v => v.TipoCuenta == "COR").Sum(v => v.Valor));
               lbtotapcv.Text = Convert.ToString(oListado.Where(v => v.TipoCuenta == "VRT").Sum(v => v.Valor));
               lbtotapch.Text = Convert.ToString(oListado.Where(v => v.TipoCuenta == "CHEQ").Sum(v => v.Valor));

                

                

                this.DataSource = oListado.ToArray();

            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
            }
        }


        public void Set_Listado( List<XROL_Rpt011_Info> lis)
        {
            try
            {
                oListado = lis;

            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
