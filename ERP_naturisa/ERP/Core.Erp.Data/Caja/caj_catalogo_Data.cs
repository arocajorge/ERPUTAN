using Core.Erp.Data.General;
using Core.Erp.Info.Caja;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Caja
{
    public class caj_catalogo_Data
    {


        public List<caj_catalogo_Info> Lista_catalogo()
        {
            List<caj_catalogo_Info> lista = new List<caj_catalogo_Info>();
            try
            {

                EntitiesCaja conex = new EntitiesCaja();

                var querry = from c in conex.caj_catalogo
                             select c;

                foreach (var item in querry)
                {
                    caj_catalogo_Info info = new caj_catalogo_Info();
                    info.IdCatalogo_cj = item.IdCatalogo_cj;
                    info.IdCatalogo_cj_tipo = item.IdCatalogo_cj_tipo;
                    info.nom_Catalogo_cj = item.nom_Catalogo_cj;
                    lista.Add(info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string mensaje = "";
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                     "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
