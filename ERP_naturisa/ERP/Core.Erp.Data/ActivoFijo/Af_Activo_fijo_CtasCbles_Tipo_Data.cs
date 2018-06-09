using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.ActivoFijo;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.ActivoFijo
{
    public class Af_Activo_fijo_CtasCbles_Tipo_Data
    {
        string mensaje = "";
        public List<Af_Activo_fijo_CtasCbles_Tipo_Info> Get_List_Activo_fijo_CtasCbles_Tipo()
        {
            List<Af_Activo_fijo_CtasCbles_Tipo_Info> lM = new List<Af_Activo_fijo_CtasCbles_Tipo_Info>();
            EntitiesActivoFijo OEPActivoFijo = new EntitiesActivoFijo();
            try
            {
                var select = (from A in OEPActivoFijo.Af_Activo_fijo_CtasCbles_Tipo
                          select A).ToList();
                foreach (Af_Activo_fijo_CtasCbles_Tipo item in select)
                {                  
                    Af_Activo_fijo_CtasCbles_Tipo_Info info = new Af_Activo_fijo_CtasCbles_Tipo_Info();
                    info.Descripcion = item.Descripcion;
                    info.IdTipoCuenta = item.IdTipoCuenta;
                  
                    lM.Add(info);
                }
                return (lM);
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                mensaje = ex.InnerException + " " + ex.Message;
                throw new Exception(ex.ToString());
            }
        }
    
    
    }
}
