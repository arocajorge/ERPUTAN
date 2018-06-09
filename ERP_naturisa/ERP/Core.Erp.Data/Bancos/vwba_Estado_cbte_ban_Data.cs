using Core.Erp.Data.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Bancos
{
    public class vwba_Estado_cbte_ban_Data
    {
        string mensaje = string.Empty;
        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban_Todos()
        {
            try
            {
                List<vwba_Estado_cbte_ban_Info> Lista = new List<vwba_Estado_cbte_ban_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    Lista = (from q in Conexion.vwba_Estado_cbte_ban
                             select new vwba_Estado_cbte_ban_Info
                             {
                                 IdEstado_cbte_ban = q.IdEstado_cbte_ban,
                                 IdTipoCatalogo = q.IdTipoCatalogo,
                                 ca_descripcion = q.ca_descripcion,
                                 ca_estado = q.ca_estado,
                                 ca_orden = q.ca_orden
                             }).ToList();
                }
                vwba_Estado_cbte_ban_Info Info = new vwba_Estado_cbte_ban_Info();
                Info.ca_descripcion = "Todos";
                Info.ca_estado = "A";
                Info.IdEstado_cbte_ban = "";
                
                Lista.Add(Info);

                return Lista.OrderBy(q => q.IdEstado_cbte_ban).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
        public List<vwba_Estado_cbte_ban_Info> Get_Lista_Estado_cbte_ban()
        {
            try
            {
                List<vwba_Estado_cbte_ban_Info> Lista = new List<vwba_Estado_cbte_ban_Info>();

                using (EntitiesBanco Conexion = new EntitiesBanco())
                {
                    Lista = (from q in Conexion.vwba_Estado_cbte_ban
                             select new vwba_Estado_cbte_ban_Info
                             {
                                 IdEstado_cbte_ban = q.IdEstado_cbte_ban,
                                 IdTipoCatalogo = q.IdTipoCatalogo,
                                 ca_descripcion = q.ca_descripcion,
                                 ca_estado = q.ca_estado,
                                 ca_orden = q.ca_orden
                             }).ToList();
                }
                return Lista.OrderBy(q => q.IdEstado_cbte_ban).ToList();
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }

    }
}
