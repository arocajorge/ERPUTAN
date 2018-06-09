using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.SRI;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.SRI
{
    public class sri_ciudad_Data
    {
        string mensaje = "";
        public List<sri_ciudad_Info> ConsultaGeneralCiu()
        {
           List<sri_ciudad_Info> Lst = new List<sri_ciudad_Info>();
            try
            {

                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.sri_ciudad
                                   orderby q.Descripcion
                                   select q;
                    foreach (var item in Consulta)
                    {
                        sri_ciudad_Info info = new sri_ciudad_Info();
                        info.IdCiudad = item.IdCiudad;
                        info.IdPais = item.IdPais;
                        info.Descripcion = item.Descripcion;
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

        public List<sri_ciudad_Info> ConsultaGeneralCiuxProv(String Provincia)
        {
           List<sri_ciudad_Info> Lst = new List<sri_ciudad_Info>();
            try
            {
 
                using (EntitiesRoles rol = new EntitiesRoles())
                {
                    var Consulta = from q in rol.sri_ciudad
                                   where q.IdPais == Provincia
                                   orderby q.Descripcion
                                   select q;
                    foreach (var item in Consulta)
                    {
                        sri_ciudad_Info info = new sri_ciudad_Info();
                        info.IdCiudad = item.IdCiudad;
                        info.IdPais = item.IdPais;
                        info.Descripcion = item.Descripcion;
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
