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
    public partial class XBAN_Rpt005_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XBAN_Rpt005_rpt()
        {
            InitializeComponent();
        }

        private void XBAN_Rpt005_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XBAN_Rpt005_Bus repbus = new XBAN_Rpt005_Bus();
                List<XBAN_Rpt005_Info> listDataRpt = new List<XBAN_Rpt005_Info>();
                List<XBAN_Rpt005_Info> listDataRpt_agrupado_x_cta = new List<XBAN_Rpt005_Info>();

                string mensaje = "";
                string OP_CtbeCble = "";
                int IdEmpresa = 0;
                int IdTipoCbte = 0;
                decimal IdCbteCble = 0;
                
                IdEmpresa = Convert.ToInt32(this.PIdEmpresa.Value);
                IdCbteCble = Convert.ToDecimal(this.PIdCbteCble.Value);
                IdTipoCbte = Convert.ToInt32(this.PIdTipo.Value);

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

                lbl_OP_x_CbteCble.Text = "Orden de Pago:" + OP_CtbeCble;

                listDataRpt = repbus.GetData(IdEmpresa, IdCbteCble, IdTipoCbte, ref mensaje);

                var qGrupo = from Cb in listDataRpt
                             group Cb by new
                             {
                                 Cb.IdEmpresa,
                                 Cb.IdCbteCble,
                                 Cb.IdTipocbte,
                                 Cb.Cod_Cbtecble,
                                 Cb.cb_Observacion,
                                 Cb.cb_secuencia,
                                 Cb.cb_Valor,
                                 Cb.cb_Cheque,
                                 Cb.cb_ChequeImpreso,
                                 Cb.cb_FechaCheque,
                                 Cb.Fecha_Transac,
                                 Cb.Estado,
                                 Cb.cb_giradoA,
                                 Cb.cb_ciudadChq,
                                 Cb.CodTipoCbteBan,
                                 Cb.cb_Fecha,
                                 Cb.con_Fecha,
                                 Cb.con_Valor,
                                 Cb.con_Observacion,
                                 Cb.con_IdCbteCble,
                                 Cb.IdCtaCble,
                                 Cb.pc_Cuenta,
                                 Cb.ValorEnLetras,
                                 Cb.nom_ciudad
                             }
                                 into grouping
                                 select new { grouping.Key, totaldebidoxCta = grouping.Sum(p => p.dc_ValorDebe), totalcreditoxCta = grouping.Sum(p => p.dc_ValorHaber) };

                foreach (var item in qGrupo)
                {
                    XBAN_Rpt005_Info InfoD = new XBAN_Rpt005_Info();
                    
                    InfoD.cb_Valor = item.Key.cb_Valor;
                    InfoD.IdCbteCble = item.Key.IdCbteCble;
                    InfoD.cb_Cheque = item.Key.cb_Cheque;
                    InfoD.cb_Observacion = item.Key.cb_Observacion;
                    InfoD.con_Fecha = item.Key.con_Fecha;
                    InfoD.cb_FechaCheque = item.Key.cb_FechaCheque;
                    InfoD.cb_giradoA = item.Key.cb_giradoA;
                    InfoD.ValorEnLetras = item.Key.ValorEnLetras;
                    InfoD.dc_ValorDebe = item.totaldebidoxCta;
                    InfoD.dc_ValorHaber = item.totalcreditoxCta;
                    InfoD.con_Valor = item.Key.con_Valor;
                    InfoD.con_Observacion = item.Key.con_Observacion;
                    InfoD.IdCtaCble = item.Key.IdCtaCble; 
                    InfoD.pc_Cuenta = item.Key.pc_Cuenta;
                    InfoD.ValorEnLetras = item.Key.ValorEnLetras;
                    InfoD.cb_ciudadChq = item.Key.cb_ciudadChq;
                    InfoD.nom_ciudad = item.Key.nom_ciudad;

                    listDataRpt_agrupado_x_cta.Add(InfoD);
                }

                this.DataSource = listDataRpt_agrupado_x_cta.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt005_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt005_rpt) };
            }
        }
    }
}
