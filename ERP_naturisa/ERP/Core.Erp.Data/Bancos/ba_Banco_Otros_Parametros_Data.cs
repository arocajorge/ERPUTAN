using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Bancos;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_Banco_Otros_Parametros_Data
    {
        string mensaje = "";

        public List<ba_Banco_Otros_Parametros_Info> Get_List_Banco_otros_Parametros(int IdEmpresa)
        {
            List<ba_Banco_Otros_Parametros_Info> lM = new List<ba_Banco_Otros_Parametros_Info>();
            EntitiesBanco param_Info = new EntitiesBanco();
            try
            {
                var selectBaParam = from C in param_Info.ba_parametros
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in selectBaParam)
                {
                    ba_Banco_Otros_Parametros_Info Cbt = new ba_Banco_Otros_Parametros_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.El_Diario_Contable_es_modificable = item.El_Diario_Contable_es_modificable;
                    Cbt.CiudadDefaultParaCrearCheques = item.CiudadDefaultParaCrearCheques;
                    Cbt.IdUsuario = item.IdUsuario;
                    Cbt.nom_pc = item.nom_pc;
                    Cbt.ip = item.ip;
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

        public Boolean ModificarDiarioModif(ba_Banco_Otros_Parametros_Info info)
        {
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
                        address.El_Diario_Contable_es_modificable = info.El_Diario_Contable_es_modificable;
                        address.CiudadDefaultParaCrearCheques = info.CiudadDefaultParaCrearCheques;
                        address.IdUsuario = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
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

        public Boolean ModificarDB(List<ba_Banco_Otros_Parametros_Info> lista, int IdEmpresa)
        {
            try
            {
                using (EntitiesBanco Contex = new EntitiesBanco())
                {
                    EntitiesBanco param_Info = new EntitiesBanco();

                    var selectBaParam = (from C in param_Info.ba_parametros
                                         where C.IdEmpresa == IdEmpresa
                                         select C).Count();
                 if (selectBaParam == 0)
                        {
                            var address = new ba_parametros();
                            address.IdEmpresa = IdEmpresa;
                            address.El_Diario_Contable_es_modificable = true;
                            address.CiudadDefaultParaCrearCheques = "GUAYAQUIL";
                            Contex.ba_parametros.Add(address);
                            Contex.SaveChanges();
                        }
                    else
                    {
                        foreach (var item in lista)
                        {
                            var contact = Contex.ba_parametros.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa);
                            if (contact != null)
                            {
                                contact.El_Diario_Contable_es_modificable = item.El_Diario_Contable_es_modificable;
                                contact.CiudadDefaultParaCrearCheques = item.CiudadDefaultParaCrearCheques;
                                contact.IdUsuario = item.IdUsuario;
                                contact.nom_pc = item.nom_pc;
                                contact.ip = item.ip;
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

        public ba_Banco_Otros_Parametros_Info Get_Info_Banco_Otros_Parametros(int IdEmpresa)
        {
            ba_Banco_Otros_Parametros_Info lM = new ba_Banco_Otros_Parametros_Info();
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
                    lM.IdUsuario = item.IdUsuario;
                    lM.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    lM.FechaUltMod = Convert.ToDateTime(item.FechaUltMod);
                    lM.nom_pc = item.nom_pc;
                    lM.ip = item.ip;
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
