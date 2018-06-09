using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.ERP.Reports.Grafinpren.CuentasxCobrar
{
    public partial class XCXC_GRAF_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        List<XCXC_GRAF_Rpt002_Info> lst_reporte = new List<XCXC_GRAF_Rpt002_Info>();
        XCXC_GRAF_Rpt002_Bus bus_reporte = new XCXC_GRAF_Rpt002_Bus();


        public XCXC_GRAF_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(decimal IdVendedor, decimal IdCliente, DateTime FechaCorte, string nom_Vendedor, string nom_Cliente, bool Mostrar_solo_vencidas)
        {
            try
            {
                p_IdVendedor.Value = IdVendedor;
                p_IdVendedor.Visible = false;

                p_IdCliente.Value = IdCliente;
                p_IdCliente.Visible = false;

                p_FechaCorte.Value = FechaCorte.Date;
                p_FechaCorte.Visible = false;

                p_Mostrar_solo_vencidas.Value = Mostrar_solo_vencidas;
                p_Mostrar_solo_vencidas.Visible = false;

                S_Cliente.Value = nom_Cliente;
                S_Vendedor.Value = nom_Vendedor;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt002_Rpt) };
            }
        }

        private void XCXC_GRAF_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblEmpresa.Text = param.NombreEmpresa;
                lblFecha.Text = param.Fecha_Transac.ToString();
                lblUsuario.Text = param.IdUsuario;
                decimal IdCliente = Convert.ToDecimal(p_IdCliente.Value);
                decimal IdVendedor = Convert.ToDecimal(p_IdVendedor.Value);
                DateTime FechaCorte = Convert.ToDateTime(p_FechaCorte.Value);
                bool Mostrar_solo_vencidas = Convert.ToBoolean(p_Mostrar_solo_vencidas.Value);

                lst_reporte = bus_reporte.Get_list_reporte(param.IdEmpresa, IdCliente, IdVendedor, FechaCorte,Mostrar_solo_vencidas);
                this.DataSource = lst_reporte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_GRAF_Rpt002_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_GRAF_Rpt002_Rpt) };
            }
        }
    }
}
