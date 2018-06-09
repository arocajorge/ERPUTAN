using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Info.CuentasxPagar;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt018_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        string OP_CtbeCble = "";
        int IdEmpresa = 0;
        int IdTipoCbte = 0;
        decimal IdCbteCble = 0;

        public XBAN_Rpt018_Rpt()
        {
            InitializeComponent();
            this.xrL_Fecha.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");
            this.xrLUsuario.Text = param.IdUsuario.ToString();
        }

        private void XBAN_Rpt018_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                switch (param.IdCliente_Ven_x_Default)
                {
                    case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.FJ:
                        xrL_concepto.Visible = true;
                        xrL_ba_descripcion.Visible = true;
                        ref_xban_rpt019_rpt.Visible = true;
                        break;
                    case Core.Erp.Info.General.Cl_Enumeradores.eCliente_Vzen.TRANSGANDIA:
                        xrL_concepto.Visible = true;
                        xrL_ba_descripcion.Visible = true;
                        ref_xban_rpt019_rpt.Visible = true;
                        break;
                    default:
                        break;
                }
                XBAN_Rpt018_Bus repbus = new XBAN_Rpt018_Bus();
                List<XBAN_Rpt018_Info> listDataRpt = new List<XBAN_Rpt018_Info>();

                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble = Convert.ToDecimal(this.PIdCbteCble.Value);
                IdTipoCbte = Convert.ToInt32(this.PIdTipo_Cbte.Value);

                cp_orden_pago_cancelaciones_Bus BusOp = new cp_orden_pago_cancelaciones_Bus();
                List<cp_orden_pago_cancelaciones_Info> listsOP = new List<cp_orden_pago_cancelaciones_Info>();

                listsOP = BusOp.Get_List_OP_x_CbteCtble(IdEmpresa, IdTipoCbte, IdCbteCble, ref mensaje);

                foreach (var item in listsOP)
                {
                    if (OP_CtbeCble == "" || OP_CtbeCble == null)
                        OP_CtbeCble = item.IdOrdenPago_op.ToString();
                    else
                        OP_CtbeCble = OP_CtbeCble + "/" + item.IdOrdenPago_op.ToString();
                }

                lbl_OP_x_CbteCble.Text = OP_CtbeCble;

                listDataRpt = repbus.GetData(IdEmpresa, IdCbteCble, IdTipoCbte, ref mensaje);
                this.DataSource = listDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt018_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt018_Rpt) };
            }
        }

        private void ref_xban_rpt019_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                ((XRSubreport)sender).ReportSource.Parameters["PIdEmpresa"].Value = IdEmpresa;
                ((XRSubreport)sender).ReportSource.Parameters["PIdCbteCble"].Value = IdCbteCble;
                ((XRSubreport)sender).ReportSource.Parameters["PIdTipo_Cbte"].Value = IdTipoCbte;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "set_parametros", ex.Message), ex) { EntityType = typeof(XBAN_Rpt018_Rpt) };
            }
        }
    }
}
