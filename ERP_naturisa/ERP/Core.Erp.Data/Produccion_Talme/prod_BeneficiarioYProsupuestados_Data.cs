using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_BeneficiarioYProsupuestados_Data
    {
        string mensaje = "";
        public List<prod_BeneficiarioYProsupuestados_Info> Get_List_BeneficiarioYProsupuestados(int IdEmpresa) 
        {

            try
            {
                using (EntitiesProduccion Entities = new EntitiesProduccion())
                {
                    string qy = "select * from prod_BeneficiarioYProsupuestados where IdEmpresa = " + IdEmpresa;
                    return Entities.Database.SqlQuery<prod_BeneficiarioYProsupuestados_Info>(qy).ToList();
                }
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
