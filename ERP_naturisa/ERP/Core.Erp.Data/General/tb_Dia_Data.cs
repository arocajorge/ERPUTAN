using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_Dia_Data
    {
        string mensaje = "";
        public List<tb_Dia_Info> Get_List_Dia() {
            try
            {
                List<tb_Dia_Info> Lst = new List<tb_Dia_Info>();
                using (EntitiesGeneral dbGeneral = new EntitiesGeneral())
                {
                    var dia = from q in dbGeneral.tb_dia
                              select q;
                    foreach (var item in dia)
                    {
                        tb_Dia_Info info = new tb_Dia_Info();
                        info.idDia = item.idDia;
                        info.sdia = item.sdia;
                        info.nemonico = item.nemonico;
                        info.sdiaIngles = item.sdiaIngles;
                        Lst.Add(info);
                    }
                    return Lst;
                }

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
