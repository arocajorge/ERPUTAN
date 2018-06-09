using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Banco_Parametros_Data
    {
        string mensaje = "";
        
        public List<ba_Banco_Parametros_Info> Get_List_Banco_Parametros(int IdEmpresa)
        {
                List<ba_Banco_Parametros_Info> lM = new List<ba_Banco_Parametros_Info>();
                EntitiesBanco param_Info = new EntitiesBanco();
            try
            {
                var selectBaParam = from C in param_Info.ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo
                                    where C.IdEmpresa == IdEmpresa
                                    
                                    select C;
                foreach (var item in selectBaParam)
                {
                    ba_Banco_Parametros_Info Cbt =new ba_Banco_Parametros_Info();
                    
                    Cbt.CodTipoCbteBan = item.CodTipoCbteBan;
                    Cbt.IdTipoCbteCble = item.IdTipoCbteCble;
                    Cbt.IdTipoCbteCble_Anu = item.IdTipoCbteCble_Anu;
                    Cbt.IdCtaCble = item.IdCtaCble;
                    Cbt.Tipo_DebCred = item.Tipo_DebCred;
                    Cbt.IdEmpresa = item.IdEmpresa;

                    

                    

                    lM.Add(Cbt);
                }
                return (lM);
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
        
        public Boolean ModificarDiarioModif(ba_parametros_Info info) {
            try
            {
                using (EntitiesBanco Contex = new EntitiesBanco())
                {
                    EntitiesBanco ba = new EntitiesBanco();
                    var selectBaParam = (from C in ba.ba_parametros
                                         where C.IdEmpresa == info.IdEmpresa
                                         select C).Count();

                    if (selectBaParam == 0)
                    {
                            var address = new ba_parametros();
                            address.IdEmpresa = info.IdEmpresa;
                            address.El_Diario_Contable_es_modificable=info.El_Diario_Contable_es_modificable;
                            address.IdTipoCbte_x_Prestamo = info.IdTipoCbte_x_Prestamo;
                            address.IdTipoNota_ND_Can_Cuotas = info.IdTipoNota_ND_Can_Cuotas;
                            address.IdUsuario=info.IdUsuario;
                            address.nom_pc=info.nom_pc;
                            address.ip = info.ip;

                            address.Ruta_descarga_fila_x_PreAviso_cheq = info.Ruta_descarga_fila_x_PreAviso_cheq;

                            Contex.ba_parametros.Add(address);
                            Contex.SaveChanges();
                    }
                    else
                    {
                        using (EntitiesBanco context = new EntitiesBanco())
                        {
                            var contact = context.ba_parametros.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa);
                            if (contact != null)
                            {
                                contact.El_Diario_Contable_es_modificable = info.El_Diario_Contable_es_modificable;
                                contact.FechaUltMod = info.FechaUltMod;
                                contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                                context.SaveChanges();
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
        
        public Boolean ModificarDB(List<ba_Banco_Parametros_Info> lista, int IdEmpresa)
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

        public ba_parametros_Info Get_Info_parametros(int IdEmpresa)
        {
                ba_parametros_Info lM = new ba_parametros_Info();
                EntitiesBanco param_Info = new EntitiesBanco(); 
            try
            {                
                var selectBaParam = from C in param_Info.ba_parametros
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in selectBaParam)
                {
                    lM.IdEmpresa = item.IdEmpresa;
                    lM.El_Diario_Contable_es_modificable = item.El_Diario_Contable_es_modificable;
                    lM.IdTipoNota_ND_Can_Cuotas = item.IdTipoNota_ND_Can_Cuotas;
                    lM.IdTipoCbte_x_Prestamo = item.IdTipoCbte_x_Prestamo;
                    lM.IdUsuario = item.IdUsuario;
                    lM.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    lM.FechaUltMod = Convert.ToDateTime(item.FechaUltMod);
                    lM.nom_pc = item.nom_pc;
                    lM.ip = item.ip;

                    lM.Ruta_descarga_fila_x_PreAviso_cheq = item.Ruta_descarga_fila_x_PreAviso_cheq;

                }
                return lM;
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
