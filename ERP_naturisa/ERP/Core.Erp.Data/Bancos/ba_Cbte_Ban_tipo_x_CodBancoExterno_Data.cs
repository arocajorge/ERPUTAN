using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Cbte_Ban_tipo_x_CodBancoExterno_Data
    {
        string mensaje = "";

        public List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info> Get_List_Cbte_Ban_tipo_x_CodBancoExterno()
        {
            List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info> Lstinfo = new List<ba_Cbte_Ban_tipo_x_CodBancoExterno_Info>();
            try
            {
                try
                    {
                        EntitiesBanco oEnt = new EntitiesBanco();
                        var select = from C in oEnt.ba_Cbte_Ban_tipo_x_CodBancoExterno
                                        select C;

                        foreach (var item in select)
                        {
                            ba_Cbte_Ban_tipo_x_CodBancoExterno_Info info = new ba_Cbte_Ban_tipo_x_CodBancoExterno_Info();
                            info.CodBanco = item.CodBanco;
                            info.CodTipoCbteBan = item.CodTipoCbteBan;
                            Lstinfo.Add(info);
                        }
                        return Lstinfo;
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
