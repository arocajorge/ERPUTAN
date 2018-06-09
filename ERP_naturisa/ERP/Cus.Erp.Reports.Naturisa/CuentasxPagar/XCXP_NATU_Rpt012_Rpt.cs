using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using Core.Erp.Business.General;
using System.Linq;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt012_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        XCXP_NATU_Rpt012_Bus bus_rpt = new XCXP_NATU_Rpt012_Bus();
        List<XCXP_NATU_Rpt012_Info> lst_rpt = new List<XCXP_NATU_Rpt012_Info>();
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XCXP_NATU_Rpt012_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt012_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                List<XCXP_NATU_Rpt012_Info> lst = new List<XCXP_NATU_Rpt012_Info>();
                lblEmpresa.Text = param.NombreEmpresa;
                DateTime Fecha_ini = DateTime.Now;
                DateTime Fecha_fin = DateTime.Now;
                bool Mostrar_agrupado = false;


                Fecha_ini = Convert.ToDateTime(P_Fecha_ini.Value);
                Fecha_fin = Convert.ToDateTime(P_Fecha_fin.Value);
                Mostrar_agrupado = Convert.ToBoolean(P_Mostrar_agrupado.Value);

                lst_rpt = bus_rpt.Get_list(param.IdEmpresa, Fecha_ini, Fecha_fin, Mostrar_agrupado);
                /*
                if (!Convert.ToBoolean(P_Mostrar_agrupado.Value))
                {
                    lst = (from q in lst_rpt
                           group q by new
                           {
                               q.IdEmpresa,
                               q.IdTipoCbte_Ogiro,
                               q.IdCbteCble_Ogiro,
                               q.pe_cedulaRuc,
                               q.pr_nombre,
                               q.IdOrden_giro_Tipo,
                               q.Documento,
                               q.Descripcion,
                               q.serie_fact,
                               q.num_factura,
                               q.NAutorizacion,
                               q.NumRetencion,
                               q.co_FechaFactura,
                               q.Num_Autorizacion_OG,
                               q.subtotal_iva,
                               q.subtotal_sin_iva
                           }
                               into grouping
                               select new XCXP_NATU_Rpt012_Info
                               {
                                   IdEmpresa = grouping.Key.IdEmpresa,
                                   IdTipoCbte_Ogiro = grouping.Key.IdTipoCbte_Ogiro,
                                   IdCbteCble_Ogiro = grouping.Key.IdCbteCble_Ogiro,
                                   pe_cedulaRuc = grouping.Key.pe_cedulaRuc,
                                   pr_nombre = grouping.Key.pr_nombre,
                                   IdOrden_giro_Tipo = grouping.Key.IdOrden_giro_Tipo,
                                   Descripcion = grouping.Key.Descripcion,
                                   serie_fact = grouping.Key.serie_fact,
                                   num_factura = grouping.Key.num_factura,
                                   NAutorizacion = grouping.Key.NAutorizacion,
                                   NumRetencion = grouping.Key.NumRetencion,
                                   co_FechaFactura = grouping.Key.co_FechaFactura,
                                   Documento = grouping.Key.Documento,

                                   subtotal_iva = grouping.Key.subtotal_iva,
                                   subtotal_sin_iva = grouping.Key.subtotal_sin_iva,
                                   valor_iva = grouping.Sum(q => q.valor_iva),
                                   Num_Autorizacion_OG = grouping.Key.Num_Autorizacion_OG,

                                   RIVA_0 = grouping.Sum(q => q.RIVA_0),
                                   RIVA_10 = grouping.Sum(q => q.RIVA_10),
                                   RIVA_20 = grouping.Sum(q => q.RIVA_20),
                                   RIVA_30 = grouping.Sum(q => q.RIVA_30),
                                   RIVA_70 = grouping.Sum(q => q.RIVA_70),
                                   RIVA_100 = grouping.Sum(q => q.RIVA_100),

                                   RTF_0 = grouping.Sum(q => q.RTF_0),
                                   RTF_0_1 = grouping.Sum(q => q.RTF_0_1),
                                   RTF_1 = grouping.Sum(q => q.RTF_1),
                                   RTF_10 = grouping.Sum(q => q.RTF_10),
                                   RTF_2 = grouping.Sum(q => q.RTF_2),
                                   RTF_8 = grouping.Sum(q => q.RTF_8),
                                   RTF_100 = grouping.Sum(q => q.RTF_100)

                               }).ToList();


                }
                else
                    lst = lst_rpt;
                */
                this.DataSource = lst_rpt;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void GroupFooter_Codigo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_agrupado.Value))
            {
                e.Cancel = true;
            }  
        }

        private void GroupHeader_Codigo_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (!Convert.ToBoolean(P_Mostrar_agrupado.Value))
            {
                e.Cancel = true;
            }  
        }       
    }
}
