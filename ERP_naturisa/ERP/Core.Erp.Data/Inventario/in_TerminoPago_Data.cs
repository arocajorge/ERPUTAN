using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Inventario
{
    public class in_TerminoPago_Data
    {
        string mensaje = "";
        public List<in_TerminoPago_Info> ObtenerListaTermPago()
        {
            try
            {
                List<in_TerminoPago_Info> ls = new List<in_TerminoPago_Info>();
                //EntitiesInventario OEInventario = new EntitiesInventario();
                //var select = from A in OEInventario.in_TerminoPago
                //             select A;

                //foreach (var item in select)
                //{
                //    in_TerminoPago_Info info = new in_TerminoPago_Info();
                //    info.IdTerminoPago = item.IdTerminoPago;
                //    info.Descripcion = item.Descripcion;
                //    info.Dias = item.Dias;
                //    info.Estado = item.Estado;

                //    ls.Add(info);
                //}
                return ls;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(mensaje);
            }
        }
    
    }
}
