using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SRI;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.SRI
{
    public class sri_tipoIdentificacion_Data
    {
        string mensaje = "";

        public List<sri_tipoIdentificacion_Info> ConsultaSRITipoIdentificacion() 
        {
            List<sri_tipoIdentificacion_Info> Lst = new List<sri_tipoIdentificacion_Info>();
            try
            {
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.sri_tipoIdentificacion
                                   select q;
                    foreach (var item in Consulta)
                    {
                        sri_tipoIdentificacion_Info info = new sri_tipoIdentificacion_Info();
                        info.IdTipoIdenti = item.IdTipoIdenti;
                        info.descripcion = item.descripcion;
                        info.Estado = item.Estado;
                        info.IdCodigo2 = item.IdCodigo2;

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
