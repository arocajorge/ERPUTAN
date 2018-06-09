using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
///Prog: Héctor Ayauca
///V 10.13 22022014
///

namespace Core.Erp.Data.Roles
{
    /// <summary>
    /// version 23122013 1521
    /// </summary>
    public class ro_calculos_formula_IESS_Data
    {
        string mensaje="";
     
        public List<ro_Config_Rubros_ParametrosGenerales_Info> Get_List_Config_Rubros_ParametrosGenerales()
        {
            List<ro_Config_Rubros_ParametrosGenerales_Info> Listado = new List<ro_Config_Rubros_ParametrosGenerales_Info>();
            try
            {
                string qry = "select fo.*, ru.ru_tipo from ro_Config_Rubros_ParametrosGenerales fo inner join ro_rubro_tipo ru " +
                        " on fo.IdRubro = ru.IdRubro";

                using (EntitiesRoles Entity = new EntitiesRoles())
                {
                    Listado = Entity.Database.SqlQuery<ro_Config_Rubros_ParametrosGenerales_Info>(qry).ToList();
                }
                return Listado;
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