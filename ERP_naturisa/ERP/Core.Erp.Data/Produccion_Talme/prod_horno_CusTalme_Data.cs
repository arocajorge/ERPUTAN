using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_horno_CusTalme_Data
    {
        string mensaje = "";
        public List<prod_horno_CusTalme_Info> Get_List_horno_CusTalme()
        {
                List<prod_horno_CusTalme_Info> Lst = new List<prod_horno_CusTalme_Info>();
                EntitiesProduccion oEnti = new EntitiesProduccion();
            try
            {
                var Query = from q in oEnti.prod_horno_CusTalme
                            select q;
                foreach (var item in Query)
                {
                    prod_horno_CusTalme_Info Obj = new prod_horno_CusTalme_Info();
                    Obj.IdHorno = item.IdHorno;
                    Obj.descripcion = item.descripcion;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.ToString() + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.ToString());
            }
        }
    }
}
