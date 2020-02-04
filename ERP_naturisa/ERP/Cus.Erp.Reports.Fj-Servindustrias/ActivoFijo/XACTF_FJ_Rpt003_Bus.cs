using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.ActivoFijo
{
    public class XACTF_FJ_Rpt003_Bus
    {
        XACTF_FJ_Rpt003_Data data = new XACTF_FJ_Rpt003_Data();

        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, int idcategoria)
        {
            try
            {


             return data.Get_List_Activos(idempresa, idcategoria);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();
                
            }
        }

        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa)
        {
            try
            {


                return data.Get_List_Activos(idempresa);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }

        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto)
        {
            try
            {


                return data.Get_List_Activos(idempresa, IdCentroCosto);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }


        public List<XACTF_FJ_Rpt003_Info> Get_List_Activos(int idempresa, string IdCentroCosto,string IdSubCentroCosto)
        {
            try
            {


                return data.Get_List_Activos(idempresa, IdCentroCosto, IdSubCentroCosto);

            }
            catch (Exception ex)
            {

                return new List<XACTF_FJ_Rpt003_Info>();

            }
        }
    }
}
