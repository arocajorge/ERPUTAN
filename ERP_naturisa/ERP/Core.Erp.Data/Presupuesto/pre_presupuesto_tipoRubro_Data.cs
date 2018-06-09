using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
//

namespace Core.Erp.Data.Presupuesto
{
    public class pre_presupuesto_tipoRubro_Data
    {
        string mensaje = "";
        public List<pre_presupuesto_tipoRubro_Info> Get_List_pre_presupuesto_tipoRubro() {
            try
            {
                List<pre_presupuesto_tipoRubro_Info> lista = new List<pre_presupuesto_tipoRubro_Info>();
                EntitiesPresupuesto pre=new EntitiesPresupuesto();
                var select = from q in pre.pre_presupuesto_tipoRubro select q;
                foreach (var item in select)
                {
                    pre_presupuesto_tipoRubro_Info info = new pre_presupuesto_tipoRubro_Info();
                    info.IdTipoRubro = item.IdTipoRubro;
                    info.Descripcion = item.Descripcion;
                    info.Tabla = item.Tabla;
                    lista.Add(info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString()+ " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    }
}
