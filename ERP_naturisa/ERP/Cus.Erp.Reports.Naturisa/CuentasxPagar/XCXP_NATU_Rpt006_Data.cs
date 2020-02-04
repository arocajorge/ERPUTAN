using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Cus.Erp.Reports.Naturisa;


namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public class XCXP_NATU_Rpt006_Data
    {
        public List<XCXP_NATU_Rpt006_Info> consultaGeneral(int IdEmpresa, DateTime co_fechaOg_Ini, DateTime co_fechaOg_Fin)
        {
            try
            {
                List<XCXP_NATU_Rpt006_Info> listadedatos = new List<XCXP_NATU_Rpt006_Info>();

                DateTime FechaIni = Convert.ToDateTime(co_fechaOg_Ini.ToShortDateString());
                DateTime FechaFin = Convert.ToDateTime(co_fechaOg_Fin.ToShortDateString());

              //  string SNombreProveedorFiltro = "";

                using (EntitiesCXP_Rpt_Naturisa clasedeproveedor = new EntitiesCXP_Rpt_Naturisa())
                {
                    var select = from h in clasedeproveedor.vwCXP_NATU_Rpt006
                                 where h.IdEmpresa == IdEmpresa 
                                 //&& h.co_fechaOg >= FechaIni && h.co_fechaOg <= FechaFin
                                 select h;

                    foreach (var item in select)
                    {
                        XCXP_NATU_Rpt006_Info itemInfo = new XCXP_NATU_Rpt006_Info();
                        itemInfo.IdEmpresa = item.IdEmpresa;
                

                        listadedatos.Add(itemInfo);
                    }
                }
                return listadedatos;
            }
            catch (Exception ex)
            {

                return new List<XCXP_NATU_Rpt006_Info>();
            }

        
        }
      


    }
}
