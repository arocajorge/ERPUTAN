using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Core.Erp.Reportes.CuentasxCobrar
{
    public partial class XCXC_Rpt011_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XCXC_Rpt011_rpt()
        {
            InitializeComponent();
            
            lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
        }

        public void Set_parameters(int IdSucursal,string nom_Sucursal, decimal IdCliente,string nom_Cliente , int IdTipo_cliente, string nom_Tipo_cliente, DateTime Fecha_corte)
        {
            try
            {
                p_IdSucursal.Value = IdSucursal;
                p_IdSucursal.Visible = false;

                p_IdClienteIni.Value = IdCliente;
                p_IdClienteIni.Visible = false;

                p_IdClienteFin.Value = IdCliente == 0 ? 9999 : IdCliente;
                p_IdClienteFin.Visible = false;

                p_IdTipoCliente.Value = IdTipo_cliente;
                p_IdTipoCliente.Visible = false;

                p_FechaCorte.Value = Fecha_corte;
                p_FechaCorte.Visible = false;

                p_nom_cliente.Value = nom_Cliente;
                p_nomSucursal.Value = nom_Sucursal;
                p_nomTipoCliente.Value = nom_Tipo_cliente;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Set_parameters", ex.Message), ex) { EntityType = typeof(XCXC_Rpt011_rpt) };
            }
        }

        private void XCXC_Rpt011_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCXC_Rpt011_Bus rptBus = new XCXC_Rpt011_Bus();
                List<XCXC_Rpt011_Info> lstRpt = new List<XCXC_Rpt011_Info>();
                lblEmpresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;

                int IdEmpresa = 0;
                int IdSucursal = 0;
                decimal IdClienteIni = 0;
                decimal IdClienteFin = 0;
                int IdTipoCliente = 0;
                DateTime FechaCorte = DateTime.Now;

                IdEmpresa = Convert.ToInt32(param.IdEmpresa);
                IdSucursal = Convert.ToInt32(p_IdSucursal.Value);
                IdClienteIni = Convert.ToInt32(p_IdClienteIni.Value);
                IdClienteFin = Convert.ToInt32(p_IdClienteFin.Value);
                IdTipoCliente = Convert.ToInt32(p_IdTipoCliente.Value);
                FechaCorte = Convert.ToDateTime(p_FechaCorte.Value);

                lstRpt = rptBus.get_List_EstadoCtaResumido(IdEmpresa, IdSucursal, IdClienteIni, IdClienteFin, FechaCorte, IdTipoCliente);
                this.DataSource = lstRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXC_Rpt011_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXC_Rpt011_rpt) };
            }
        }

    }
}
