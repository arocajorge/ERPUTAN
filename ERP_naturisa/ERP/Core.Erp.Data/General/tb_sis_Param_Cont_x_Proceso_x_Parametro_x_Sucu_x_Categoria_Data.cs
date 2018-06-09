using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

//Derek 22/01/2014
namespace Core.Erp.Data.General
{
    public class tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Data
    {
        //string mensaje = "";
        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>Consultar (int IdEmpresa, int IdSucursal , string IdproceSoConta)
        //{
        //    try
        //    {
        //        //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //{
        //        //    IQueryable<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> COnsulta = 
        //        //                                    from q in Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria
        //        //                                    where q.IdProcesoConta == IdproceSoConta && q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal
        //        //                                    select new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info { Dbcr = q.Dbcr, IdCategoria= q.IdCategoria, IdCtaCble=q.IdCtaCble
        //        //                                                                                                                 , IdEmpresa = q.IdEmpresa, IdParametro = q.IdParametro, IdProcesoConta = q.IdProcesoConta, IdSucursal = q.IdSucursal, IdCentroCosto= q.IdCentroCosto, Modificado="N"};
        //        //    return COnsulta.ToList();
        //        //}

        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //}

        //public Boolean ValidarSiExiste(int IdEmpresa, string IdCategoria, string IdParametro, int IdSucursal, string IdProcesoConta, ref string mensaje)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        //var address = from q in context.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria
        //        //              where q.IdSucursal == IdSucursal && q.IdProcesoConta == IdProcesoConta && q.IdEmpresa == IdEmpresa &&
        //        //                    q.IdParametro == IdParametro && q.IdCategoria == IdCategoria
        //        //              select q;

        //        //if (address.ToList().Count > 0)
        //        //{
        //        //    ret = false;
        //        //}
        //        //else
        //        //{
        //        //    ret = true;
        //        //}


        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //    }
        //    return ret;
        //}

        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> ConsultaGeneral(int IdEmpresa)
        //{
        //    try
        //    {
        //        //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //{
        //        //    IQueryable<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> COnsulta =
        //        //                                    from q in Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria
        //        //                                    where  q.IdEmpresa == IdEmpresa 
        //        //                                    select new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info
        //        //                                    {
        //        //                                        Dbcr = q.Dbcr,
        //        //                                        IdCategoria = q.IdCategoria,
        //        //                                        IdCtaCble = q.IdCtaCble,
        //        //                                        IdEmpresa = q.IdEmpresa,
        //        //                                        IdParametro = q.IdParametro,
        //        //                                        IdProcesoConta = q.IdProcesoConta,
        //        //                                        IdSucursal = q.IdSucursal,
        //        //                                         IdCentroCosto = q.IdCentroCosto,
        //        //                                         Modificado ="N"
        //        //                                    };
        //        //    return COnsulta.ToList();
        //        //}
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //}

        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> Consulta_x_Proceso(int IdEmpresa,string IdProcesoConta)
        //{
        //    try
        //    {
        //        //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //{
        //        //    IQueryable<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> COnsulta =
        //        //                                    from q in Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria
        //        //                                    where q.IdEmpresa == IdEmpresa && q.IdProcesoConta == IdProcesoConta
        //        //                                    select new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info
        //        //                                    {
        //        //                                        Dbcr = q.Dbcr,
        //        //                                        IdCategoria = q.IdCategoria,
        //        //                                        IdCtaCble = q.IdCtaCble,
        //        //                                        IdEmpresa = q.IdEmpresa,
        //        //                                        IdParametro = q.IdParametro,
        //        //                                        IdProcesoConta = q.IdProcesoConta,
        //        //                                        IdSucursal = q.IdSucursal,
        //        //                                        IdCentroCosto = q.IdCentroCosto,
        //        //                                        Modificado = "N",
        //        //                                        Viene_Base="S"
        //        //                                    };
        //        //    return COnsulta.ToList();
        //        //}

        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();

        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //}
        //public Boolean Modificar(tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info item)
        //{
        //    try
        //    {
               
        //            //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //            //{

        //            //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria Consulta = Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria.First(v => v.IdEmpresa == item.IdEmpresa && v.IdProcesoConta == item.IdProcesoConta && v.IdSucursal == item.IdSucursal && v.IdParametro == item.IdParametro && v.IdCategoria== item.IdCategoria);
        //            //    Consulta.IdCtaCble = item.IdCtaCble;
        //            //    Consulta.IdCentroCosto = item.IdCentroCosto;
        //            //    Consulta.Dbcr = item.Dbcr[0].ToString();
        //            //    Entity.SaveChanges();


        //            //}
               

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //}

        //public Boolean Guardar(List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> lst, ref string mensaje)
        //{
        //    try
        //    {
                
        //        //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //{
        //        //    foreach (var item in lst)
        //        //    {
        //        //        var nuevo = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria();
        //        //        nuevo.IdEmpresa = item.IdEmpresa; 
        //        //        nuevo.IdProcesoConta = item.IdProcesoConta;
        //        //        nuevo.IdSucursal = item.IdSucursal;
        //        //        nuevo.IdParametro = item.IdParametro;
        //        //        nuevo.IdCategoria = item.IdCategoria;
        //        //        nuevo.IdCtaCble = item.IdCtaCble;
        //        //        nuevo.IdCentroCosto = item.IdCentroCosto;
        //        //        nuevo.Dbcr = item.Dbcr[0].ToString();
        //        //        Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria.Add(nuevo);
        //        //        Entity.SaveChanges();
        //        //    }
        //        //}



        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //             "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //}

        
        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> ConsultaEpecifica(int IdEmpresa, string IdProcesoConta, ref string mensaje)
        //{
        //    try
        //    {
        //        List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> lista = new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();

        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        //var x = from q in context.vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria
        //        //        where q.IdEmpresa == IdEmpresa && q.IdProcesoConta == IdProcesoConta
        //        //        select q;
        //        //foreach (var item in x)
        //        //{
        //        //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info info = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info();
        //        //    info.IdEmpresa = item.IdEmpresa;
        //        //    info.IdSucursal = item.IdSucursal;
        //        //    info.IdCtaCble = item.IdCtaCble;
        //        //    info.Dbcr = item.Dbcr;
        //        //    info.IdCategoria = item.IdCategoria;
        //        //    info.IdParametro = item.IdParametro;
        //        //    info.IdProcesoConta = item.IdProcesoConta;
        //        //    info.IdCentroCosto = item.IdCentroCosto;
        //        //    info.Viene_Base = item.Ya_Existe_BASE;
        //        //    //info.Su_Descripcion = item.Su_Descripcion;
        //        //    //info.ca_Categoria = item.ca_Categoria;
        //        //    lista.Add(info);
        //        //}
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info>();
        //    }
        //}

        //public Boolean ModificarPSC(List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria_Info> Lst , ref string mensaje)
        //{
        //    try
        //    {
        //        //foreach (var item in Lst)
        //        //{
        //        //    EntitiesGeneral Entity = new EntitiesGeneral();
                    

        //        //        var Consulta = Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_Categoria.First(v => v.IdEmpresa == item.IdEmpresa && v.IdProcesoConta == item.IdProcesoConta && v.IdSucursal == item.IdSucursal && v.IdParametro == item.IdParametro && v.IdCategoria == item.IdCategoria);
        //        //        Consulta.IdCtaCble = item.IdCtaCble;
        //        //        Consulta.IdCentroCosto = item.IdCentroCosto;
        //        //        Consulta.Dbcr = item.Dbcr.Trim();
        //        //        Entity.SaveChanges();
                    
        //        //}

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //}
    }
}
