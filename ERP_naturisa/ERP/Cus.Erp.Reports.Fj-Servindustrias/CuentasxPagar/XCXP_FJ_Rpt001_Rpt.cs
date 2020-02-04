using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;

namespace Cus.Erp.Reports.FJ.CuentasxPagar
{
    public partial class XCXP_FJ_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XCXP_FJ_Rpt001_Bus oBus = new XCXP_FJ_Rpt001_Bus();
        List<XCXP_FJ_Rpt001_Info> LstInfo = new List<XCXP_FJ_Rpt001_Info>();

        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_FJ_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_FJ_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                lblRazonSocialEmpresa.Text = param.InfoEmpresa.RazonSocial;
                lblRuc.Text = param.InfoEmpresa.em_ruc;

                int idEmpresa = 1;
                int idSucursalOrigen = 0;
                int idBodegaOrigen = 0;
                int idSucursalDest = 0;
                int idBodegaDest = 0;
                decimal idGuia = 0;
                decimal idTransferencia = 0;

                idEmpresa = param.IdEmpresa;
               
                idGuia = Convert.ToDecimal(this.Parameters["idGuia"].Value);
                
                LstInfo = oBus.Get_Lista_Reporte(idEmpresa, idTransferencia, idGuia, idSucursalOrigen, idSucursalDest, idBodegaOrigen, idBodegaDest);

                foreach (XCXP_FJ_Rpt001_Info item in LstInfo)
                {
                    switch (item.Motivo_traslado)
                    {
                        case "VENTA": VENTA.Visible = true;
                            break;
                        case "COMPRA": COMPRA.Visible = true;
                            break;
                        case "TRANSFORMACIÓN": TRANSFORMACION.Visible = true;
                            break;
                        case "CONSIGNACIÓN": CONSIGNACION.Visible = true;
                            break;
                        case "TRASLADO ENTRE ESTABLECIMIENTOS DE LA MISMA EMPRESA": TRASLADO_ENTRE_ESTABLECIMIENTOS_DE_LA_MISMA_EMPRESA.Visible = true;
                            break;
                        case "TRASLADO POR EMISIÓN ITINERANTE DE COMPROBANTE DE VENTA": TRASLADO_POR_EMISION_ITINERANTE_DE_COMPROBANTE_DE_VENTA.Visible = true;
                            break;
                        case "DEVOLUCIÓN": DEVOLUCION.Visible = true;
                            break;
                        case "IMPORTACIÓN": IMPORTACION.Visible = true;
                            break;
                        case "EXPORTACIÓN": EXPORTACION.Visible = true;
                            break;
                        default:
                            OTROS.Visible = true;
                            break;
                    }
                    break;
                }
                this.DataSource = LstInfo;
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }

    }
}
