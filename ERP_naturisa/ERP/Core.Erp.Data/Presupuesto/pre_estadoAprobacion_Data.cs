using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Presupuesto;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


//8-5-2013
namespace Core.Erp.Data.Presupuesto
{
    public class pre_estadoAprobacion_Data
    {
        string mensaje = "";
        public List<pre_estadoAprobacion_Info> obtenerList()
        {
            try
            {
                List<pre_estadoAprobacion_Info> lista = new List<pre_estadoAprobacion_Info>();
                EntitiesPresupuesto pre = new EntitiesPresupuesto();
                var select = from q in pre.pre_estadoAprobacion
                             select q;
                foreach (var item in select)
                {
                    pre_estadoAprobacion_Info Obj = new pre_estadoAprobacion_Info();
                    Obj.CodEstado = item.CodEstado;
                    Obj.Descripcion  = item.Descripcion;

                    lista.Add(Obj);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public pre_estadoAprobacion_Data()
        {
            
        }
    }
}
