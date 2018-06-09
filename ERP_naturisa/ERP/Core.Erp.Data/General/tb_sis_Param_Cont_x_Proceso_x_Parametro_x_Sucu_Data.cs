using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.General
{
    public class tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Data
    {
        //string mensaje = "";
        //#region CJimenez
        //public Boolean ValidarSiExiste(tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info _Info)
        //{
        //    bool ret = false;
        //    try
        //    {
        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        //var address = from q in context.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu
        //        //              where q.IdSucursal == _Info.IdSucursal && q.IdProcesoConta == _Info.IdProcesoConta && q.IdEmpresa == _Info.IdEmpresa &&
        //        //                    q.IdParametro == _Info.IdParametro
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
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //    return ret;
        //}

        //public Boolean GuardarLista(List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Lst)
        //{
        //    try
        //    {
        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        //foreach (var item in Lst)
        //        //{
        //        //    var info = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu();
        //        //    info.IdEmpresa = item.IdEmpresa;
        //        //    info.IdSucursal = item.IdSucursal;
        //        //    info.IdCtaCble = item.IdCtaCble;
        //        //    if (item.Dbcr == null)
        //        //    {
        //        //        item.Dbcr = "D";
        //        //    }
        //        //    info.Dbcr = item.Dbcr;
        //        //    info.IdParametro = item.IdParametro;
        //        //    info.IdProcesoConta = item.IdProcesoConta;
        //        //    info.IdCentroCosto = item.IdCentroCosto;

        //        //    context.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu.Add(info);
        //        //    context.SaveChanges();
        //        //}
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

        //#endregion

        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Obtener(int IdEmpresa, int IdSucursal, string IdProcesoConta)
        //{
        //    try
        //    {
        //        List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> lista = new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();

        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        //var x = from q in context.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdProcesoConta == IdProcesoConta select q;
        //        //foreach (var item in x)
        //        //{
        //        //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info info = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info();
        //        //    info.IdEmpresa = item.IdEmpresa;
        //        //    info.IdSucursal = item.IdEmpresa;
        //        //    info.IdCtaCble = item.IdCtaCble;
        //        //    info.Dbcr = item.Dbcr;
        //        //    info.IdParametro = item.IdParametro;
        //        //    info.IdProcesoConta = item.IdProcesoConta;
        //        //    info.IdCentroCosto = item.IdCentroCosto;
        //        //    lista.Add(info);
        //        //}
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();
        //    }
        //}


        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> ConsultaGeneral(int IdEmpresa)
        //{
        //    try
        //    {
        //        //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //{

        //        //    IQueryable<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Consulta = from q in Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu
        //        //                                                                               where q.IdEmpresa == IdEmpresa
        //        //                                                                               select new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info { Dbcr = q.Dbcr, IdCtaCble = q.IdCtaCble, IdEmpresa = q.IdEmpresa, IdParametro = q.IdParametro, IdProcesoConta = q.IdProcesoConta, IdSucursal = q.IdSucursal, IdCentroCosto = q.IdCentroCosto };

        //        //    return Consulta.ToList();
        //        //}

        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();
        //    }
        //}


        //public Boolean Modificar(tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info item)
        //{
        //    try
        //    {
        //        //foreach (var item in Lst)
        //        //{
        //            //using (EntitiesGeneral Entity = new EntitiesGeneral())
        //            //{
        //            //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu Consulta = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu();
        //            //    try
        //            //    {
        //            //        Consulta = Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu.First(v => v.IdEmpresa == item.IdEmpresa && v.IdProcesoConta == item.IdProcesoConta && v.IdSucursal == item.IdSucursal && v.IdParametro == item.IdParametro);
        //            //    }
        //            //    catch (Exception ex)
        //            //    {
        //            //        string arreglo = ToString();
        //            //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //            //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //            //                            "", "", "", "", DateTime.Now);
        //            //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //            //        mensaje = ex.InnerException + " " + ex.Message;

        //            //    }
        //            //    Consulta.IdCtaCble = item.IdCtaCble;
        //            //    Consulta.IdCentroCosto = item.IdCentroCosto;
        //            //    Consulta.Dbcr = item.Dbcr[0].ToString();
        //            //    Entity.SaveChanges();
        //            //}
        //        //}

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

        ////DEREK 21/01/2014
        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> ConsultaEpecifica(int IdEmpresa, string IdProcesoConta)
        //{
        //    try
        //    {
        //        List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> lista = new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();

        //        //EntitiesGeneral context = new EntitiesGeneral();
        //        ////var x = from q in context.vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_x_tb_sucursal 
        //        ////        where q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdProcesoConta == IdProcesoConta 
        //        ////        select q;
        //        //var x = from q in context.vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu
        //        //        where q.IdEmpresa == IdEmpresa && q.IdProcesoConta == IdProcesoConta
        //        //        select q;
        //        //foreach (var item in x)
        //        //{
        //        //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info info = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info();
        //        //    info.IdEmpresa = item.IdEmpresa;
        //        //    info.IdSucursal = item.IdSucursal;
        //        //    info.IdCtaCble = item.IdCtaCble;
        //        //    info.Dbcr = item.Dbcr;
        //        //    info.IdParametro = item.IdParametro;
        //        //    info.IdProcesoConta = item.IdProcesoConta;
        //        //    info.IdCentroCosto = item.IdCentroCosto;
        //        //    info.Ya_Existe_Base = item.Ya_Existe_Base;
        //        //    lista.Add(info);
        //        //}
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();
        //    }
        //}

        //public List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Consulta_X_Sucursal(int IdEmpresa,int IdSucursal, string IdProcesoConta)
        //{
        //    try
        //    {
        //        List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> lista = new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();

        //        //EntitiesGeneral context = new EntitiesGeneral();
              
        //        //var x = from q in context.vwtb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu
        //        //        where q.IdEmpresa == IdEmpresa && q.IdProcesoConta == IdProcesoConta
        //        //        && q.IdSucursal == IdSucursal
        //        //        select q;
        //        //foreach (var item in x)
        //        //{
        //        //    tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info info = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info();
        //        //    info.IdEmpresa = item.IdEmpresa;
        //        //    info.IdSucursal = item.IdSucursal;
        //        //    info.IdCtaCble = item.IdCtaCble;
        //        //    info.Dbcr = item.Dbcr;
        //        //    info.IdParametro = item.IdParametro;
        //        //    info.IdProcesoConta = item.IdProcesoConta;
        //        //    info.IdCentroCosto = item.IdCentroCosto;
        //        //    info.Ya_Existe_Base = item.Ya_Existe_Base;
        //        //    lista.Add(info);
        //        //}
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        string arreglo = ToString();
        //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
        //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return new List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info>();
        //    }
        //}


        //public Boolean ModificarPS(List<tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu_Info> Lst)
        //{
        //    try
        //    {
        //        //foreach (var item in Lst)
        //        //{
        //        //    using (EntitiesGeneral Entity = new EntitiesGeneral())
        //        //    {
        //        //        tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu Consulta = new tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu();
        //        //        try
        //        //        {
        //        //            Consulta = Entity.tb_sis_Param_Cont_x_Proceso_x_Parametro_x_Sucu.First(v => v.IdEmpresa == item.IdEmpresa && v.IdProcesoConta == item.IdProcesoConta && v.IdSucursal == item.IdSucursal && v.IdParametro == item.IdParametro);
        //        //        }
        //        //        catch (Exception)
        //        //        { }
        //        //        Consulta.IdCtaCble = item.IdCtaCble;
        //        //        Consulta.IdCentroCosto = item.IdCentroCosto;
        //        //        Consulta.Dbcr = item.Dbcr[0].ToString();
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
        //                            "", "", "", "", DateTime.Now);
        //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
        //        mensaje = ex.InnerException + " " + ex.Message;
        //        return false;
        //    }
        //}
    }
}
