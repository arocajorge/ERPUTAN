using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_PeriodoDepreciacion_Data
    {
        string mensaje = "";
        public List<Af_PeriodoDepreciacion_Info> Get_List_PeriodoDepreciacion()
        {
            List<Af_PeriodoDepreciacion_Info> lista = new List<Af_PeriodoDepreciacion_Info>();
            EntitiesActivoFijo oEnt = new EntitiesActivoFijo();
            try
            {
                var select = from q in oEnt.Af_PeriodoDepreciacion
                             select q;

                foreach (var item in select)
                {
                    Af_PeriodoDepreciacion_Info info = new Af_PeriodoDepreciacion_Info();
                    info.IdPeriodoDeprec = item.IdPeriodoDeprec;
                    info.Descripcion = item.Descripcion;
                    info.Valor_Ciclo_Anual = Convert.ToInt32(item.Valor_Ciclo_Anual);
                    lista.Add(info);
                }
                return lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.InnerException.ToString());
            }
        }
    }
}
