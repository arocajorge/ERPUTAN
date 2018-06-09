using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SRI;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.SRI
{
    public class sri_tipo_Gasto_Data
    {
        string mensaje = "";
        public List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> ConsultaSRITipoGasto() 
        {
            List<ro_empleado_x_Proyeccion_Gastos_Personales_Info> Lst = new List<ro_empleado_x_Proyeccion_Gastos_Personales_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.ro_tipo_gastos_personales
                                   select q;
                    foreach (var item in Consulta)
                    {
                        ro_empleado_x_Proyeccion_Gastos_Personales_Info info = new ro_empleado_x_Proyeccion_Gastos_Personales_Info();
                        info.IdTipoGasto = item.IdTipoGasto;
                        info.nom_tipo_gasto = item.nom_tipo_gasto;

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
