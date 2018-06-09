using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Roles
{
    public class ro_Implemento_Trabajador_Data
    {
        string mensaje = "";

        public List<ro_Implemento_Trabajador_Info> Get_Lista_implementos(int idEmpresa)
        {
            try
            {
                List<ro_Implemento_Trabajador_Info> Lista = new List<ro_Implemento_Trabajador_Info>();

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    Lista = (from q in Conexion.ro_Implemento_Trabajador
                             where idEmpresa == q.IdEmpresa
                             select new ro_Implemento_Trabajador_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdImplemento = q.IdImplemento,
                                 descripcion = q.descripcion,
                                 IdProducto_Inv = q.IdProducto_Inv,
                                 IdTipoImplemento = q.IdTipoImplemento,
                                 FechaCompra = q.FechaCompra,
                                 CostoCompra = q.CostoCompra,
                                 Estado = q.Estado,
                                 Maneja_Invent = q.Maneja_Invent
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

        public List<ro_Implemento_Trabajador_Info> Get_Lista_implementos_x_tipo(int idEmpresa, int idTipoImplemento)
        {
            try
            {
                List<ro_Implemento_Trabajador_Info> Lista = new List<ro_Implemento_Trabajador_Info>();

                using (EntitiesRoles Conexion = new EntitiesRoles())
                {
                    Lista = (from q in Conexion.ro_Implemento_Trabajador
                             where idEmpresa == q.IdEmpresa && idTipoImplemento == q.IdTipoImplemento
                             select new ro_Implemento_Trabajador_Info
                             {
                                 IdEmpresa = q.IdEmpresa,
                                 IdImplemento = q.IdImplemento,
                                 descripcion = q.descripcion,
                                 IdProducto_Inv = q.IdProducto_Inv,
                                 IdTipoImplemento = q.IdTipoImplemento,
                                 FechaCompra = q.FechaCompra,
                                 CostoCompra = q.CostoCompra,
                                 Estado = q.Estado,
                                 Maneja_Invent = q.Maneja_Invent
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
