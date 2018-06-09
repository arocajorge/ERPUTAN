using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using System.Windows.Forms;
using System.Data;

namespace Core.Erp.Reportes.Contabilidad
{
    public partial class XCONTA_Rpt006_rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        public  List<string> P_ListIdCtasCbles { get; set; }

        public bool Visible_col_CentroCosto 
        { 
            set {
                try
                {
                    if (value == false)
                    {
                        xrTableRow1.Cells.Remove(xrTableCellCentroCosto_Cab);
                        xrTableRowDet.Cells.Remove(xrTableCellCentroCosto_det);
                    }
                    else
                    {
                        xrTableCellCentroCosto_Cab.WidthF = 120;
                        xrTableCellCentroCosto_det.WidthF = 120;
                    }
                }
                catch (Exception ex)
                {

                }
                
            } 
        }

        public bool Visible_col_PuntoCargo
        {
            set
            {
                try
                {
                    if (value == false)
                    {
                        xrTableRow1.Cells.Remove(xrTableCellPuntoCargo_cab);
                        xrTableRowDet.Cells.Remove(xrTableCellPuntoCargo_det);
                    }
                    else
                    {
                        xrTableCellPuntoCargo_cab.WidthF = 120;
                        xrTableCellPuntoCargo_det.WidthF = 120;
                    }


                }
                catch (Exception ex)
                {

                }
            }
        }

        public XCONTA_Rpt006_rpt()
        {
            InitializeComponent();
            lblfechaHoy.Text = DateTime.Now.ToString();
            lblusuario.Text = param.IdUsuario;
        }

        private void xrTableCell8_PreviewDoubleClick(object sender, PreviewMouseEventArgs e)
        {
            
        }

        private void xrPictureBox1_PreviewClick(object sender, PreviewMouseEventArgs e)
        {
           
        }

        private void xrTableCell15_PreviewDoubleClick(object sender, PreviewMouseEventArgs e)
        {
           
        }

        private void xrTableCell8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        }

        private void XCONTA_Rpt006_rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                XCONTA_Rpt006_Bus BusReporte = new XCONTA_Rpt006_Bus();
                List<XCONTA_Rpt006_Info> lista = new List<XCONTA_Rpt006_Info>();
                List<XCONTA_Rpt006_Info> lista_Aux = new List<XCONTA_Rpt006_Info>();

                
                int IdEmpresa = 0;
                string IdCtaCble = "";
                
                int IdPuntoCargo = 0;
                int IdPuntoCargo_Grupo = 0;
                DateTime FechaIni;
                DateTime FechaFin;
                string msg="";
                string IdCentro_Costo = "";
                Boolean Mostrar_Asiento_cierre = false;

                IdEmpresa = Convert.ToInt32(P_IdEmpresa.Value);
                IdCtaCble = Convert.ToString(P_IdCtaCble.Value);
                IdCentro_Costo = Convert.ToString(P_IdCentro_Costo.Value);
                
                IdPuntoCargo = Convert.ToInt32(P_IdPuntoCargo.Value);
                IdPuntoCargo_Grupo = Convert.ToInt32(P_IdPuntoCargo_Grupo.Value);
                FechaIni = Convert.ToDateTime(P_FechaIni.Value);
                FechaFin = Convert.ToDateTime(P_FechaFin.Value);
                Mostrar_Asiento_cierre = Convert.ToBoolean(P_Mostrar_Asiento_cierre.Value);

                if (P_ListIdCtasCbles == null)
                {
                    lista = BusReporte.Get_Data_Reporte(IdEmpresa, IdCtaCble,IdCentro_Costo, FechaIni, FechaFin, IdPuntoCargo_Grupo, IdPuntoCargo,Mostrar_Asiento_cierre, ref msg);
                }
                else
                {
                    if (P_ListIdCtasCbles.Count > 0)
                    {
                        foreach (var item in P_ListIdCtasCbles)
                        {
                            lista_Aux = new List<XCONTA_Rpt006_Info>();
                            lista_Aux = BusReporte.Get_Data_Reporte(IdEmpresa, item,IdCentro_Costo, FechaIni, FechaFin, IdPuntoCargo_Grupo, IdPuntoCargo,Mostrar_Asiento_cierre, ref msg);

                            foreach (var item2 in lista_Aux)
                            {
                                lista.Add(item2);
                            }
                            
                        }
                    }
                }


                this.DataSource = lista;

            }
            catch (Exception ex)
            {

            }

        }
    }
}
