using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt002_Bus
    {
        XACTF_FJ_Rpt002_Data data = new XACTF_FJ_Rpt002_Data();
        public List<XACTF_FJ_Rpt002_Info> Get_List_Activos_Prendados(int idempresa, int idcategoria,DateTime Fecha_Inicio,DateTime Fecha_Fin)
        {
            try
            {


             return data.Get_List_Activos_Prendados(idempresa, idcategoria,Fecha_Inicio,Fecha_Fin);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt002_Info>();
                
            }
        }
        public List<XACTF_FJ_Rpt002_Info> Get_List_Activos_Prendados(int idempresa, DateTime Fecha_Inicio, DateTime Fecha_Fin)
        {
            try
            {


                return data.Get_List_Activos_Prendados(idempresa, Fecha_Inicio, Fecha_Fin);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt002_Info>();

            }

        }
    }
}
