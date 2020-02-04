using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Collections;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using System.Linq;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public partial class XACTF_FJ_Rpt002_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        public XACTF_FJ_Rpt002_Rpt()
        {
            InitializeComponent();
        }

        private void XACTF_FJ_Rpt002_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                DateTime fechaInicial = Convert.ToDateTime(Parameters["fechaInicial"].Value);
                DateTime fechaFinal = Convert.ToDateTime(Parameters["fechaFinal"].Value);
                int idcategoria = Convert.ToInt32(Parameters["id_categoria"].Value);
 


                XACTF_FJ_Rpt002_Bus bus = new XACTF_FJ_Rpt002_Bus();
                List<XACTF_FJ_Rpt002_Info> lista = new List<XACTF_FJ_Rpt002_Info>();
                if (idcategoria > 0)
                {
                    lista = bus.Get_List_Activos_Prendados(param.IdEmpresa, idcategoria, fechaInicial, fechaFinal);
                }
                else
                {
                    lista = bus.Get_List_Activos_Prendados(param.IdEmpresa, fechaInicial, fechaFinal);

                }

                if (lista.Count > 0)
                {
                    int totalA_ctivos = 0;
                    double total_adquisicion = 0;
                    total_adquisicion = lista.Sum(v => v.Costo_Compra);
                    totalA_ctivos = lista.Select(v => v.IdActivoFijo).Count();


                    foreach (var item in lista)
                    {
                        item.porcentaje_prendado = item.Costo_Compra/total_adquisicion;
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
