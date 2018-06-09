using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Bancos
{
    public class ba_Cbte_Ban_tipo_Data
    {
        string mensaje = "";
        
        public List<ba_Cbte_Ban_tipo_Info> Get_list_Cbte_Ban_Tipo_x_NCBA_NDBA()
        {
            try
            {
                List<ba_Cbte_Ban_tipo_Info> lst = new List<ba_Cbte_Ban_tipo_Info>();
                ba_Cbte_Ban_tipo_Info Info;
                EntitiesBanco context = new EntitiesBanco();
                var address = from q in context.ba_Cbte_Ban_tipo
                              where q.CodTipoCbteBan == "NCBA" || q.CodTipoCbteBan == "NDBA"
                              select q;                  
                foreach(var item in address)
                {
                    Info = new ba_Cbte_Ban_tipo_Info();
                    Info.CodTipoCbteBan = item.CodTipoCbteBan;
                    Info.Descripcion = item.Descripcion;
                    Info.Signo = item.Signo;
                    Info.Orden = item.orden;
                    lst.Add(Info);
                }
                return lst;
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

        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo()
        {
            try
            {
                List<ba_Cbte_Ban_tipo_Info> lst = new List<ba_Cbte_Ban_tipo_Info>();
                ba_Cbte_Ban_tipo_Info Info;
                EntitiesBanco context = new EntitiesBanco();
                var address = from q in context.ba_Cbte_Ban_tipo
                              select q;
                foreach (var item in address)
                {
                    Info = new ba_Cbte_Ban_tipo_Info();
                    Info.CodTipoCbteBan = item.CodTipoCbteBan;
                    Info.Descripcion = item.Descripcion;
                    Info.Signo = item.Signo;
                    Info.Orden = item.orden;
                    lst.Add(Info);
                }
                return lst;
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

        public List<ba_Cbte_Ban_tipo_Info> Get_List_Cbte_Ban_tipo_Todos()
        {
            try
            {
                List<ba_Cbte_Ban_tipo_Info> lst = new List<ba_Cbte_Ban_tipo_Info>();
                ba_Cbte_Ban_tipo_Info Info;
                EntitiesBanco context = new EntitiesBanco();
                var address = from q in context.ba_Cbte_Ban_tipo
                              select q;

                Info = new ba_Cbte_Ban_tipo_Info();
                Info.CodTipoCbteBan = "";
                Info.Descripcion = "Todos";
                Info.Signo = "";
                Info.Orden = 0;
                lst.Add(Info);
                foreach (var item in address)
                {
                    Info = new ba_Cbte_Ban_tipo_Info();
                    Info.CodTipoCbteBan = item.CodTipoCbteBan;
                    Info.Descripcion = item.Descripcion;
                    Info.Signo = item.Signo;
                    Info.Orden = item.orden;
                    lst.Add(Info);
                }
                return lst;
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
