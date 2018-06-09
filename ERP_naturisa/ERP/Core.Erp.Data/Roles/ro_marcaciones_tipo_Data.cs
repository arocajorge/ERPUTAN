using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Roles
{
    public class ro_marcaciones_tipo_Data
    {
        string mensaje = "";

        public List<ro_marcaciones_tipo_Info> Get_List_marcaciones_tipo()
        {
            List<ro_marcaciones_tipo_Info> listado = new List<ro_marcaciones_tipo_Info>();
            try
            {
                using (EntitiesRoles oEn = new EntitiesRoles())
                {
                    IQueryable<ro_marcaciones_tipo_Info> Consulta = from q in oEn.ro_marcaciones_tipo
                                                                    select new ro_marcaciones_tipo_Info
                                                                      {
                                                                           IdTipoMarcaciones = q.IdTipoMarcaciones,
                                                                           ma_descripcion = q.ma_descripcion   
                                                                      };
                    listado = Consulta.ToList();
                }
                return listado;
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

        public Boolean GrabarDB(ro_marcaciones_tipo_Info info)
        {
            try
            {
                using (EntitiesRoles Context = new EntitiesRoles())
                {
                    ro_marcaciones_tipo address = new ro_marcaciones_tipo();
                    address.ma_descripcion = info.ma_descripcion;
                    address.IdTipoMarcaciones = info.IdTipoMarcaciones;
                    Context.ro_marcaciones_tipo.Add(address);
                    Context.SaveChanges();
                }
                return true;
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
