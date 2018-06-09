using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxPagar;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.CuentasxPagar
{
    public class cp_catalogo_Data
    {
        string mensaje = "";
        public List<cp_catalogo_Info> Get_List_catalogo(string IdCatalogo_tipo)
        {
            try
            {
                List<cp_catalogo_Info> Lst = new List<cp_catalogo_Info>();
                using (EntitiesCuentasxPagar CxP = new EntitiesCuentasxPagar())
                {
                    var consultar = from q in CxP.cp_catalogo
                                    where q.IdCatalogo_tipo == IdCatalogo_tipo
                                    select q;

                    foreach (var item in consultar)
                    {
                        cp_catalogo_Info info = new cp_catalogo_Info();
                        info.IdCatalogo = item.IdCatalogo;
                        info.IdCatalogo_tipo = item.IdCatalogo_tipo;
                        info.Nombre = item.Nombre;
                        info.Estado = item.Estado;
                        info.Abrebiatura = item.Abrebiatura;
                        info.NombreIngles = item.NombreIngles;
                        info.Orden = Convert.ToInt32(item.Orden);
                        info.IdUsuario = item.IdUsuario;
                        info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                        info.FechaUltMod = Convert.ToDateTime(item.FechaUltMod);
                        info.nom_pc = item.nom_pc;
                        info.ip = item.ip;
                        Lst.Add(info);
                    }
                }
                return Lst;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
