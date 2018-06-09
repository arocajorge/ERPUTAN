using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SRI;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.SRI
{
    public class sri_provincia_Data
    {
        string mensaje = "";
        public List<sri_provincia_Info> ConsultaGeneralProv() 
        {
               List<sri_provincia_Info> Lst = new List<sri_provincia_Info>();
            try
            {
 
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.sri_provincia
                                   orderby q.descripcion
                                   select q;
                    foreach (var item in Consulta)
                    {
                        sri_provincia_Info info = new sri_provincia_Info();                        
                        info.IdProvincia = item.IdProvincia;
                        info.descripcion = item.descripcion;
                        info.estado = item.estado;
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
