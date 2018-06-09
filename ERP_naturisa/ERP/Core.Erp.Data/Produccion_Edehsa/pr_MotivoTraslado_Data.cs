using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Produccion_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Produccion_Edehsa
{
    public class pr_MotivoTraslado_Data
    {
        string mensaje = "";
        public List<prd_MotivoTraslado_Info> ObtenerMotivoTraslado(int IdEmpresa)
        {
            List<prd_MotivoTraslado_Info> Lst = new List<prd_MotivoTraslado_Info>();
            try
            {

                using (EntitiesProduccion_Edehsa tipo = new EntitiesProduccion_Edehsa())
                {
                    var Consulta = from q in tipo.prd_motivo_traslado
                                   where q.IdEmpresa == IdEmpresa
                                   select q;
                    foreach (var item in Consulta)
                    {
                        prd_MotivoTraslado_Info info = new prd_MotivoTraslado_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdMotivo_traslado = item.IdMotivo_traslado;
                        info.descripcion_motivo_traslado = item.descripcion_motivo_traslado;
                        info.Estado = item.Estado;

                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string array = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
