using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt008_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        
        public XCXP_NATU_Rpt008_rpt()
        {
            InitializeComponent();

            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        private void XCXP_NATU_Rpt008_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrPictureBox1.Image = Funciones.ArrayAImage(param.InfoEmpresa.em_logo);
                xrL_Empresa.Text = param.InfoEmpresa.em_nombre;


                XCXP_NATU_Rpt008_Bus rptBus = new XCXP_NATU_Rpt008_Bus();
                List<XCXP_NATU_Rpt008_Info> lstInfo = new List<XCXP_NATU_Rpt008_Info>();

                string mensaje = "";
                int IdEmpresa = 0;
                DateTime FechaIni;
                DateTime FechaFin;


                string S_FechaIni = "";
                string S_FechaFin = "";
                bool Mostrar_saldo_cero = false;

                decimal IdProveedorClaseIni = 0;
                decimal IdProveedorClaseFin = 0;
                string S_ProveedorClase = "";
                decimal IdProveedorIni = 0;
                decimal IdProveedorFin = 0;

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);

                IdProveedorClaseIni = Convert.ToInt32(Parameters["IdProveedorClaseIni"].Value); 
                IdProveedorClaseFin = Convert.ToInt32(Parameters["IdProveedorClaseFin"].Value);
                S_ProveedorClase = Convert.ToString(Parameters["S_ProveedorClase"].Value);

                IdProveedorIni = Convert.ToDecimal(P_IdProveedorIni.Value);
                IdProveedorFin = Convert.ToDecimal(P_IdProveedorFin.Value);

                S_FechaIni = Convert.ToString(Parameters["S_FechaIni"].Value);
                S_FechaFin = Convert.ToString(Parameters["S_FechaFin"].Value);
                Mostrar_saldo_cero = Convert.ToBoolean(P_Mostrar_saldo_cero.Value); 
                lstInfo = rptBus.consultar_Data(IdEmpresa, IdProveedorClaseIni, IdProveedorClaseFin, IdProveedorIni, IdProveedorFin, FechaIni, FechaFin,Mostrar_saldo_cero, ref mensaje);

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt008_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt008_rpt) };       

            }
        }

    }
}
