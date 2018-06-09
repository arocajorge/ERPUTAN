using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
    public class ro_implemento_Trabajador_Tipo_Data
    {
        string mensaje = "";

        public List<ro_implemento_Trabajador_Tipo_Info> Get_Lista_tipo_implemento(int idEmpresa)
        {
            try
            {
                List<ro_implemento_Trabajador_Tipo_Info> Lista = new List<ro_implemento_Trabajador_Tipo_Info>();

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    Lista = (from q in Conexion.ro_implemento_Trabajador_Tipo
                             where idEmpresa == q.IdEmpresa
                             select new ro_implemento_Trabajador_Tipo_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdTipoImplemento = q.IdTipoImplemento,
                                 descripcion = q.descripcion,
                                 Estado = q.Estado
                             }).ToList();    
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                mensaje = ex.InnerException + " " + ex.Message;
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
