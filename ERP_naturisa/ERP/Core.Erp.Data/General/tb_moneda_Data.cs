using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_moneda_Data
    {
        string mensaje = "";
        public List<tb_moneda_info> Get_List_Moneda() 
        {
            try
            {
                List<tb_moneda_info> Lista = new List<tb_moneda_info>();

                EntitiesGeneral oEntities = new EntitiesGeneral();

                var select = from q in oEntities.tb_moneda
                             select q;

                foreach (var item in select)
                {
                    tb_moneda_info info = new tb_moneda_info();
                    info.IdMoneda = item.IdMoneda;
                    info.im_descripcion = item.im_descripcion +" "+ item.im_simbolo;
                    info.im_nemonico = item.im_nemonico;
                    Lista.Add(info);
                }
            return Lista;
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
    }
}
