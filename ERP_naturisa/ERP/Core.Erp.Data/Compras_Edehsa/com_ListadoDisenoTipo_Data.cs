using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras_Edehsa
{
    public class com_ListadoDisenoTipo_Data
    {
        string mensaje = "";
        public List<com_ListadoDisenoTipo_Info> ObtenerListaDisenoTipo(int IdEmpresa)
        {
            List<com_ListadoDisenoTipo_Info> Lst = new List<com_ListadoDisenoTipo_Info>();
            try
            {

                using (EntitiesCompras_Edehsa tipo = new EntitiesCompras_Edehsa())
                {
                    var Consulta = from q in tipo.com_ListadoDisenoTipo
                                   where q.IdEmpresa == IdEmpresa
                                   select q;
                    foreach (var item in Consulta)
                    {
                        com_ListadoDisenoTipo_Info info = new com_ListadoDisenoTipo_Info();
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoListadoDiseno = item.IdTipoListadoDiseno;
                        info.TipoListadoDiseno = item.TipoListadoDiseno;
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
