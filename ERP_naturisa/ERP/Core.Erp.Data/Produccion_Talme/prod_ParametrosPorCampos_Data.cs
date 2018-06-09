using Core.Erp.Info.Produccion_Talme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Produccion_Talme
{
    public class prod_ParametrosPorCampos_Data
    {
        string mensaje = "";
        public List<prod_ParametrosPorCampos_Info> Consulta(int IdEmpresa)
        {
            try
            {
                using (EntitiesProduccion Entity = new EntitiesProduccion())
                {

                    return (from q in Entity.prod_ParametrosPorCampos where q.IdEmpresa == IdEmpresa select new prod_ParametrosPorCampos_Info { IdEmpresa = q.IdEmpresa, IdProducto = q.IdProducto, NombreLaber = q.NombreLaber, NompreCampo = q.NompreCampo, Secuencia = q.Secuencia, TipoModeloProduccion = q.TipoModeloProduccion }).ToList();

                }
                
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
