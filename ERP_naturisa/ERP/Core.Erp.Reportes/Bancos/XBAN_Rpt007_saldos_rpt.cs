using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Bancos
{
    public partial class XBAN_Rpt007_saldos_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        List<XBAN_Rpt007_saldos_Info> lstInfo = new List<XBAN_Rpt007_saldos_Info>();
        string _tipo_saldo = "";

        public XBAN_Rpt007_saldos_rpt()
        {
            InitializeComponent();
        }

        public void set_parametros(string tipo_saldo, List<XBAN_Rpt007_saldos_Info> lista)
        {
            try
            {
                lstInfo = lista;
                _tipo_saldo = tipo_saldo;
                Mostrar_Celdas(tipo_saldo);
               
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void Mostrar_Celdas(string Tipo_saldo)
        {
            try
            {
                float width_detalle = tbl_detalle.WidthF;
                float width_pie = tbl_pieInforme.WidthF;

                if (Tipo_saldo.Equals("INICIAL"))
                {
                    lblTipoSaldo.Text = "SALDO INICIAL";
                    float width_cel_det_cant = cel_det_saldo_inicial.WidthF + cel_det_saldo_final.WidthF;

                    //Saldo Final
                    if (tbl_detalle.Rows[0].Cells.Contains(cel_det_saldo_final))
                        tbl_detalle.Rows[0].Cells.Remove(cel_det_saldo_final);

                    //Total saldo final
                    if (tbl_pieInforme.Rows[0].Cells.Contains(cel_total_fin))
                        tbl_pieInforme.Rows[0].Cells.Remove(cel_total_fin);

                    //Saldo Inicial
                    if (!tbl_detalle.Rows[0].Cells.Contains(cel_det_saldo_inicial))
                        tbl_detalle.Rows[0].Cells.Add(cel_det_saldo_inicial);                    

                    //total saldo inicial
                    if (!tbl_pieInforme.Rows[0].Cells.Contains(cel_total_inicial))
                        tbl_pieInforme.Rows[0].Cells.Add(cel_total_inicial);

                    cel_det_saldo_inicial.WidthF = width_cel_det_cant;
                    cel_total_inicial.WidthF = width_cel_det_cant;
                    
                }
                else
                {
                    float width_cel_det_cant = cel_det_saldo_inicial.WidthF + cel_det_saldo_final.WidthF;
                    lblTipoSaldo.Text = "SALDO FINAL";
                    //Saldo Inicial
                    if (tbl_detalle.Rows[0].Cells.Contains(cel_det_saldo_inicial))
                        tbl_detalle.Rows[0].Cells.Remove(cel_det_saldo_inicial);

                    //total saldo inicial
                    if (tbl_pieInforme.Rows[0].Cells.Contains(cel_total_inicial))
                        tbl_pieInforme.Rows[0].Cells.Remove(cel_total_inicial);

                    //Saldo Final
                    if (!tbl_detalle.Rows[0].Cells.Contains(cel_det_saldo_final))
                        tbl_detalle.Rows[0].Cells.Add(cel_det_saldo_final);
                   
                    //Total saldo final
                    if (!tbl_pieInforme.Rows[0].Cells.Contains(cel_total_fin))
                        tbl_pieInforme.Rows[0].Cells.Add(cel_total_fin);

                    cel_det_saldo_final.WidthF = width_cel_det_cant;
                    cel_total_fin.WidthF = width_cel_det_cant;
                }

                tbl_detalle.WidthF = width_detalle;
                tbl_pieInforme.WidthF = width_pie;

            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };
            }
        }

        private void XBAN_Rpt007_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
              
                this.DataSource = lstInfo.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XBAN_Rpt007_rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XBAN_Rpt007_rpt) };   
            }
        }

    }
}
