using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_tipoDocumento_tipoValor_Data
    {
        string mensaje = "";
        public List<tb_sis_tipoDocumento_tipoValor_Info> ObtenerTipoDocumento(string Idtipodoc)
        {
            try
            {
                List<tb_sis_tipoDocumento_tipoValor_Info> lm = new List<tb_sis_tipoDocumento_tipoValor_Info>();
                //EntitiesGeneral OEGeneral = new EntitiesGeneral();
                //var q = from A in OEGeneral.tb_sis_tipoDocumento_tipoValor
                //        where A.IdTipoDocumento == Idtipodoc
                //        orderby A.Posicion
                //        select A;
                //foreach (var item in q)
                //{
                //    tb_sis_tipoDocumento_tipoValor_Info info = new tb_sis_tipoDocumento_tipoValor_Info();
                //    info.IdTipoValor = item.IdTipoValor.Trim();
                //    info.IdTipoDocumento = item.IdTipoDocumento.Trim();
                //    info.Descripcion = item.Descripcion.Trim();
                //    info.Posicion = item.Posicion;
                //    info.Estado = (item.Estado=="A");
                //    lm.Add(info);
                //}
                return lm;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                    "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.ToString() + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }

        public tb_sis_tipoDocumento_tipoValor_Data() { }
    }
}
