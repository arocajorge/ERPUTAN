using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Data
    {
        string mensaje = "";
        public List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> Get_List_Cbte_Ban_tipo_x_ct_CbteCble_tipo(int Idempresa) 
        {
            try
            {

                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lista = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();


                using (EntitiesBanco Entity = new EntitiesBanco())
                {

                    var Consulta = from q in Entity.vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo
                                   where q.IdEmpresa == Idempresa
                                   select q;

                    foreach (var item in Consulta)
                    {
                        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

                        info.CodTipoCbteBan = item.CodTipoCbteBan;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbteCble = (item.IdTipoCbteCble == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble);
                        info.IdTipoCbteCble_Anu = (item.IdTipoCbteCble_Anu == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble_Anu);
                        info.Tipo_DebCred = item.Tipo_DebCred;
                        info.nom_TipoCbteBan = item.nom_TipoCbteBan;

                        lista.Add(info);
                    }


                    return lista;
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

        public ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info Get_info_Cbte_Ban_tipo_x_ct_CbteCble_tipo(int Idempresa,string CodCbte)
        {
            try
            {

                ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();


                using (EntitiesBanco Entity = new EntitiesBanco())
                {

                    var Consulta = from q in Entity.vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo
                                   where q.IdEmpresa == Idempresa
                                   && q.CodTipoCbteBan == CodCbte
                                   select q;

                    foreach (var item in Consulta)
                    {
                        
                        info.CodTipoCbteBan = item.CodTipoCbteBan;
                        info.IdCtaCble = item.IdCtaCble;
                        info.IdEmpresa = item.IdEmpresa;
                        info.IdTipoCbteCble = (item.IdTipoCbteCble == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble);
                        info.IdTipoCbteCble_Anu = (item.IdTipoCbteCble_Anu == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble_Anu);
                        info.Tipo_DebCred = item.Tipo_DebCred;
                        info.nom_TipoCbteBan = item.nom_TipoCbteBan;

                    }


                    return info;
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

        
        public Boolean ModificarDB(List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lista, int IdEmpresa)
        {
            try
            {
                using (EntitiesBanco Contex = new EntitiesBanco())
                {
                    EntitiesBanco param_Info = new EntitiesBanco();
                    foreach (var item in lista)
                    {
                        var selectBaParam = (from C in param_Info.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo
                                             where C.IdEmpresa == IdEmpresa && C.CodTipoCbteBan == item.CodTipoCbteBan
                                             select C).Count();
                        if (selectBaParam == 0)
                        {
                            var address = new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo();
                            address.IdEmpresa = IdEmpresa;
                            address.CodTipoCbteBan = item.CodTipoCbteBan;
                            address.IdTipoCbteCble = item.IdTipoCbteCble;
                            address.IdTipoCbteCble_Anu = item.IdTipoCbteCble_Anu;
                            address.IdCtaCble = item.IdCtaCble;
                            address.Tipo_DebCred = item.Tipo_DebCred;




                            Contex.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.Add(address);


                            Contex.SaveChanges();
                        }
                        else
                        {
                            var contact = Contex.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.CodTipoCbteBan == item.CodTipoCbteBan);
                            if (contact != null)
                            {
                                contact.IdTipoCbteCble = item.IdTipoCbteCble;
                                contact.IdTipoCbteCble_Anu = item.IdTipoCbteCble_Anu;
                                contact.IdCtaCble = item.IdCtaCble;
                                contact.Tipo_DebCred = item.Tipo_DebCred;



                                Contex.SaveChanges();
                            }
                        }
                    }
                }
                return true;
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



        public List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> Get_List_Banco_Parametros(int Idempresa) 
        {
            try
            {

                List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info> lista = new List<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info>();


                using (EntitiesBanco Entity = new EntitiesBanco())
                {

                    var Consulta = from q in Entity.vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo
                                                                                    where q.IdEmpresa == Idempresa
                                                                                    select q;

                    foreach (var item in Consulta)
                    {
                        ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info info=new ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo_Info();

                            info.CodTipoCbteBan = item.CodTipoCbteBan;
                            info.IdCtaCble = item.IdCtaCble;
                            info.IdEmpresa = item.IdEmpresa;
                            info.IdTipoCbteCble = (item.IdTipoCbteCble == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble);
                            info.IdTipoCbteCble_Anu = (item.IdTipoCbteCble_Anu == null) ? 0 : Convert.ToInt32(item.IdTipoCbteCble_Anu);
                            info.Tipo_DebCred = item.Tipo_DebCred;
                            info.nom_TipoCbteBan = item.nom_TipoCbteBan;

                        lista.Add(info);
                    }


                    return lista;
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
