using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Reflection;

using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Business.CuentasxCobrar;
using Core.Erp.Business.General;


namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt016_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;


        public XCXC_Rpt016_Rpt()
        {
            InitializeComponent();
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            lblUsuario.Text = param.IdUsuario;
        }

        private void XCXC_Rpt016_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt016_Bus rptBus = new XCXC_Rpt016_Bus();
                List<XCXC_Rpt016_Info> lstInfo = new List<XCXC_Rpt016_Info>();

                int IdEmpresa = 0, IdSucursal = 0, IdBodega_Cbte = 0;
                decimal IdCbte_vta_nota = 0;
                string CodDocumentoTipo = "";

                IdEmpresa = Convert.ToInt32(PIdEmpresa.Value);
                IdSucursal = Convert.ToInt32(PIdSucursal.Value);
                IdBodega_Cbte = Convert.ToInt32(PIdBodega_Cbte.Value);
                IdCbte_vta_nota = Convert.ToInt32(PIdCbte_vta_nota.Value);
                CodDocumentoTipo = Convert.ToString(PTipoDocumento.Value);

                lstInfo = rptBus.Get_Data_Reporte(IdEmpresa, IdSucursal, IdBodega_Cbte, IdCbte_vta_nota, CodDocumentoTipo);

                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt016_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt016_Rpt) };
            }
        }

    }
}
