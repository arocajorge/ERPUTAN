using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produccion_Talme;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_TipoParada_CusTalme_Data
    {
        string mensaje = "";
        public List<prod_TipoParada_CusTalme_Info> ObtenerLista() 
        {
                List<prod_TipoParada_CusTalme_Info> lista = new List<prod_TipoParada_CusTalme_Info>();
            try
            {
                using (EntitiesProduccion Oent = new EntitiesProduccion()) 
                {
                    var SQL = from q in Oent.prod_TipoParada_CusTalme
                              where q.Estado == "A"
                              select q;
                    foreach (var item in SQL )
                    {

                        prod_TipoParada_CusTalme_Info obj = new prod_TipoParada_CusTalme_Info();
                        obj.Descripcion = item.Descripcion;
                        obj.IdTipoParada = item.IdTipoParada;
                        obj.Estado = item.Estado;

                        lista.Add(obj);
                    }
                
                }
                return lista;
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
