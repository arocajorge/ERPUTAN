using Core.Erp.Info.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Bancos
{
    public class ba_parametros_Data
    {
        string mensaje = "";

        public ba_parametros_Info Get_List_parametros(int IdEmpresa) 
        {
            try
            {
                using (EntitiesBanco entity = new EntitiesBanco())
                {
                    ba_parametros parametros = entity.ba_parametros.FirstOrDefault(v => v.IdEmpresa == IdEmpresa);
                    if (parametros != null)
                    {
                        return new ba_parametros_Info()
                        { 
                            CiudadDefaultParaCrearCheques = parametros.CiudadDefaultParaCrearCheques, 
                            El_Diario_Contable_es_modificable = parametros.El_Diario_Contable_es_modificable,
                            IdTipoCbte_x_Prestamo = parametros.IdTipoCbte_x_Prestamo,
                            IdTipoNota_ND_Can_Cuotas=parametros.IdTipoNota_ND_Can_Cuotas,
                            IdEmpresa = parametros.IdEmpresa ,
                            Ruta_descarga_fila_x_PreAviso_cheq = parametros.Ruta_descarga_fila_x_PreAviso_cheq,
                            IdCtaCble_Interes=parametros.IdCtaCble_Interes,
                            IdCtaCble_prestamos=parametros.IdCtaCble_prestamos
                        };
                    }
                    else
                        return new ba_parametros_Info();
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

        public List<ba_parametros_Info> Get_List_Banco_otros_Parametros(int IdEmpresa)
        {
            List<ba_parametros_Info> lM = new List<ba_parametros_Info>();
            EntitiesBanco param_Info = new EntitiesBanco();
            try
            {
                var selectBaParam = from C in param_Info.ba_parametros
                                    where C.IdEmpresa == IdEmpresa
                                    select C;
                foreach (var item in selectBaParam)
                {
                    ba_parametros_Info Cbt = new ba_parametros_Info();

                    Cbt.IdEmpresa = item.IdEmpresa;

                    Cbt.IdEmpresa = item.IdEmpresa;
                    Cbt.El_Diario_Contable_es_modificable = item.El_Diario_Contable_es_modificable;
                    Cbt.CiudadDefaultParaCrearCheques = item.CiudadDefaultParaCrearCheques;
                    Cbt.IdTipoNota_ND_Can_Cuotas = item.IdTipoNota_ND_Can_Cuotas;
                    Cbt.IdTipoCbte_x_Prestamo = item.IdTipoCbte_x_Prestamo;
                    Cbt.Ruta_descarga_fila_x_PreAviso_cheq = item.Ruta_descarga_fila_x_PreAviso_cheq;

                    Cbt.IdUsuario = item.IdUsuario;
                    Cbt.nom_pc = item.nom_pc;
                    Cbt.ip = item.ip;
                    Cbt.IdCtaCble_Interes = item.IdCtaCble_Interes;
                    Cbt.IdCtaCble_prestamos = item.IdCtaCble_prestamos;

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

        public Boolean ModificarDiarioModif(ba_parametros_Info info)
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
                        address.Ruta_descarga_fila_x_PreAviso_cheq = info.Ruta_descarga_fila_x_PreAviso_cheq;


                        address.IdUsuario = info.IdUsuario;
                        address.nom_pc = info.nom_pc;
                        address.ip = info.ip;
                        address.IdCtaCble_Interes = info.IdCtaCble_Interes;
                        address.IdCtaCble_prestamos = info.IdCtaCble_prestamos;

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
                                contact.Ruta_descarga_fila_x_PreAviso_cheq = info.Ruta_descarga_fila_x_PreAviso_cheq;
                                contact.IdCtaCble_Interes = info.IdCtaCble_Interes;
                                contact.IdCtaCble_prestamos = info.IdCtaCble_prestamos;

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


        public Boolean ModificarDB(ba_parametros_Info Info, int IdEmpresa)
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
                        address.Ruta_descarga_fila_x_PreAviso_cheq = "";
                     
                        Contex.ba_parametros.Add(address);
                        Contex.SaveChanges();
                    }
                    else
                    {
                        
                            var contact = Contex.ba_parametros.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa);
                            if (contact != null)
                            {
                                contact.El_Diario_Contable_es_modificable = Info.El_Diario_Contable_es_modificable;
                                contact.CiudadDefaultParaCrearCheques = Info.CiudadDefaultParaCrearCheques;
                                contact.IdTipoCbte_x_Prestamo = Info.IdTipoCbte_x_Prestamo;
                                contact.IdTipoNota_ND_Can_Cuotas = Info.IdTipoNota_ND_Can_Cuotas;
                                contact.Ruta_descarga_fila_x_PreAviso_cheq = Info.Ruta_descarga_fila_x_PreAviso_cheq;
                                contact.IdCtaCble_Interes = Info.IdCtaCble_Interes;
                                contact.IdCtaCble_prestamos = Info.IdCtaCble_prestamos;

                                contact.IdUsuario = Info.IdUsuario;
                                contact.nom_pc = Info.nom_pc;
                                contact.ip = Info.ip;
                                Contex.SaveChanges();
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

        public ba_parametros_Info Get_Info_Banco_Otros_Parametros(int IdEmpresa)
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
                    lM.IdTipoCbte_x_Prestamo = item.IdTipoCbte_x_Prestamo;
                    lM.IdTipoNota_ND_Can_Cuotas = item.IdTipoNota_ND_Can_Cuotas;
                    lM.Ruta_descarga_fila_x_PreAviso_cheq = item.Ruta_descarga_fila_x_PreAviso_cheq;
                    lM.CiudadDefaultParaCrearCheques = item.CiudadDefaultParaCrearCheques;

                    lM.IdUsuario = item.IdUsuario;
                    lM.IdUsuarioUltMod = item.IdUsuarioUltMod;
                    lM.FechaUltMod = Convert.ToDateTime(item.FechaUltMod);
                    lM.nom_pc = item.nom_pc;
                    lM.ip = item.ip;
                    lM.IdCtaCble_Interes = item.IdCtaCble_Interes;
                    lM.IdCtaCble_prestamos = item.IdCtaCble_prestamos;

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
                    lM.IdCtaCble_Interes = item.IdCtaCble_Interes;
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
