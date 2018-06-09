using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
  public  class in_Ingreso_varios_Data
    {
     
      string mensaje = "";

      //public decimal getId(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo)
      //{
      //    decimal Id = 0;
      //    try
      //    {
                          
      //        EntitiesInventario contex = new EntitiesInventario();
      //        var selecte = contex.in_Ingreso_varios.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdBodega == IdBodega && q.IdMovi_inven_tipo == IdMovi_inven_tipo);

      //        if (selecte == 0)
      //        {
      //            Id = 1;
      //        }
      //        else
      //        {
      //            var select_em = (from q in contex.in_Ingreso_varios
      //                             where q.IdEmpresa == IdEmpresa
      //                             select q.IdNumMovi).Max();
      //            Id = Convert.ToDecimal(select_em.ToString()) + 1;
      //        }

      //        return Id;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
      //        mensaje = ex.InnerException + " " + ex.Message;
      //        return 0;
      //    }
      //}

      //public Boolean GuardarDB(in_Ingreso_varios_Info info ,ref decimal IdNumMovi, ref string mensaje)
      //{
      //    try
      //    {
      //        using (EntitiesInventario Context = new EntitiesInventario())
      //        {
      //            var Address = new in_Ingreso_varios();

      //             Address.IdEmpresa = info.IdEmpresa;
      //             Address.IdSucursal = info.IdSucursal;
      //             Address.IdBodega = info.IdBodega;
      //             Address.IdNumMovi = info.IdNumMovi = getId(info.IdEmpresa, info.IdSucursal, info.IdBodega, info.IdMovi_inven_tipo);

      //             IdNumMovi = info.IdNumMovi;
      //             Address.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
      //             Address.CodMoviInven = (info.CodMoviInven == "") ? IdNumMovi.ToString() : info.CodMoviInven;
      //             Address.cm_observacion = (info.cm_observacion == "") ? "" : info.cm_observacion;
      //             Address.cm_fecha = Convert.ToDateTime(info.cm_fecha.ToShortDateString());
      //             Address.IdUsuario = info.IdUsuario;
      //             Address.Fecha_Transac = info.Fecha_Transac;                                                              
      //             Address.nom_pc = info.nom_pc;
      //             Address.ip = info.ip;
      //             Address.Estado = "A";
      //             Address.IdCentroCosto = info.IdCentroCosto;
      //             Address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                                               
      //            Context.in_Ingreso_varios.Add(Address);
      //            Context.SaveChanges();

      //            //Graba Detalle  in_Ingreso_varios_det
      //            if (info.listIngVarios.Count() != 0)
      //            {
      //                foreach (var item in info.listIngVarios)
      //                {
      //                    item.IdEmpresa = info.IdEmpresa;
      //                    item.IdSucursal = info.IdSucursal;
      //                    item.IdBodega = info.IdBodega;
      //                    item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
      //                    item.IdNumMovi = IdNumMovi;
      //                }

      //                in_Ingreso_varios_det_Data odata = new in_Ingreso_varios_det_Data();
      //                odata.GuardarDB(info.listIngVarios);
      //            }

      //            mensaje = "Grabación ok..";
      //        }
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

      //public Boolean ModificarDB(in_Ingreso_varios_Info info, ref string msgs)
      //{
      //    try
      //    {
      //        using (EntitiesInventario context = new EntitiesInventario())
      //        {
      //            var contact = context.in_Ingreso_varios.First(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega==info.IdBodega && q.IdMovi_inven_tipo==info.IdMovi_inven_tipo && q.IdNumMovi==info.IdNumMovi);

      //            contact.cm_fecha = info.cm_fecha;
      //            contact.cm_observacion = info.cm_observacion;
      //            contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
      //            contact.Fecha_UltMod = info.Fecha_UltMod;


      //            context.SaveChanges();

      //            msgs = "Actualización ok...";
      //        }
      //        return true;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        msgs = ex.InnerException + " " + ex.Message;
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
      //        return false;
      //    }
      //}

      //public Boolean AnularDB(in_Ingreso_varios_Info info, ref string msgs)
      //{
      //    try
      //    {
      //        using (EntitiesInventario context = new EntitiesInventario())
      //        {
      //            var contact = context.in_Ingreso_varios.First(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);

      //            contact.Estado = "I";
      //            contact.IdusuarioUltAnu = info.IdusuarioUltAnu;
      //            contact.Fecha_UltAnu= info.Fecha_UltAnu;


      //            context.SaveChanges();

      //            msgs = "Anulación ok...";
      //        }
      //        return true;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        msgs = ex.InnerException + " " + ex.Message;
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
      //        return false;
      //    }
      //}


      //public List<in_Ingreso_varios_Info> Consulta_IngreVarios(int IdEmpresa, int IdSucursal, int IdBodega, DateTime FechaIni, DateTime FechaFin)
      //{
      //    List<in_Ingreso_varios_Info> Lst = new List<in_Ingreso_varios_Info>();
      //    try
      //    {
      //        FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
      //        FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
      //        EntitiesInventario oEnti = new EntitiesInventario();

      //        if (IdSucursal != 0 && IdBodega!=0)
      //        {
      //            var Query = from q in oEnti.vwin_Ingreso_varios
      //                        where q.IdEmpresa == IdEmpresa
      //                        && q.IdSucursal == IdSucursal
      //                        && q.IdBodega == IdBodega
      //                        && q.cm_fecha >= FechaIni
      //                        && q.cm_fecha <= FechaFin

      //                        select q;

      //            foreach (var item in Query)
      //            {
      //                in_Ingreso_varios_Info Obj = new in_Ingreso_varios_Info();

      //                Obj.IdEmpresa = item.IdEmpresa;
      //                Obj.IdSucursal = item.IdSucursal;
      //                Obj.IdBodega = item.IdBodega;
      //                Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
      //                Obj.IdNumMovi = item.IdNumMovi;
      //                Obj.CodMoviInven = item.CodMoviInven;
      //                Obj.cm_observacion = item.cm_observacion;
      //                Obj.cm_fecha = item.cm_fecha;
      //                Obj.Estado = item.Estado;
      //                Obj.IdEmpresa_inv = Convert.ToInt32(item.IdEmpresa_inv);
      //                Obj.IdSucursal_inv = Convert.ToInt32(item.IdSucursal_inv);
      //                Obj.IdBodega_inv = Convert.ToInt32(item.IdBodega_inv);
      //                Obj.IdMovi_inven_tipo_inv = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
      //                Obj.IdNumMovi_inv = Convert.ToDecimal(item.IdNumMovi_inv);
      //                Obj.IdCentroCosto = item.IdCentroCosto;
      //                Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
      //                Obj.Su_Descripcion = item.Su_Descripcion;
      //                Obj.bo_Descripcion = item.bo_Descripcion;
      //                Obj.tm_descripcion = item.tm_descripcion;
      //                Obj.IdEstadoAproba = item.IdEstadoAproba;

      //                Lst.Add(Obj);
      //            }
              
      //        }
      //        else
      //        {
      //            var Query = from q in oEnti.vwin_Ingreso_varios
      //                        where q.IdEmpresa == IdEmpresa                            
      //                        && q.cm_fecha >= FechaIni
      //                        && q.cm_fecha <= FechaFin

      //                        select q;

      //            foreach (var item in Query)
      //            {
      //                in_Ingreso_varios_Info Obj = new in_Ingreso_varios_Info();

      //                Obj.IdEmpresa = item.IdEmpresa;
      //                Obj.IdSucursal = item.IdSucursal;
      //                Obj.IdBodega = item.IdBodega;
      //                Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
      //                Obj.IdNumMovi = item.IdNumMovi;
      //                Obj.CodMoviInven = item.CodMoviInven;
      //                Obj.cm_observacion = item.cm_observacion;
      //                Obj.cm_fecha = item.cm_fecha;
      //                Obj.Estado = item.Estado;
      //                Obj.IdEmpresa_inv = Convert.ToInt32(item.IdEmpresa_inv);
      //                Obj.IdSucursal_inv = Convert.ToInt32(item.IdSucursal_inv);
      //                Obj.IdBodega_inv = Convert.ToInt32(item.IdBodega_inv);
      //                Obj.IdMovi_inven_tipo_inv = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
      //                Obj.IdNumMovi_inv = Convert.ToDecimal(item.IdNumMovi_inv);
      //                Obj.IdCentroCosto = item.IdCentroCosto;
      //                Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
      //                Obj.Su_Descripcion = item.Su_Descripcion;
      //                Obj.bo_Descripcion = item.bo_Descripcion;
      //                Obj.tm_descripcion = item.tm_descripcion;
      //                Obj.IdEstadoAproba = item.IdEstadoAproba;

      //                Lst.Add(Obj);
      //            }
              
      //        }
              
              
            

      //        return Lst;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
      //        mensaje = ex.InnerException + " " + ex.Message;
      //        return new List<in_Ingreso_varios_Info>();
      //    }
      //}


      //public in_Ingreso_varios_Info ConsultaInfo_IngreVarios(int IdEmpresa, int IdSucursal, int IdBodega, int IdMovi_inven_tipo, decimal IdNumMovi)
      //{       
      //    try
      //    {
      //        in_Ingreso_varios_Info Obj = new in_Ingreso_varios_Info();            
      //        EntitiesInventario oEnti = new EntitiesInventario();

      //        var Query = from q in oEnti.vwin_Ingreso_varios
      //                    where q.IdEmpresa == IdEmpresa
      //                    && q.IdSucursal == IdSucursal
      //                    && q.IdBodega == IdBodega
      //                    && q.IdMovi_inven_tipo == IdMovi_inven_tipo
      //                    && q.IdNumMovi == IdNumMovi
      //                    select q;
      //        foreach (var item in Query)
      //        {
                  
      //            Obj.IdEmpresa = item.IdEmpresa;
      //            Obj.IdSucursal = item.IdSucursal;
      //            Obj.IdBodega = item.IdBodega;
      //            Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
      //            Obj.IdNumMovi = item.IdNumMovi;
      //            Obj.CodMoviInven = item.CodMoviInven;
      //            Obj.cm_observacion = item.cm_observacion;
      //            Obj.cm_fecha = item.cm_fecha;
      //            Obj.Estado = item.Estado;
      //            Obj.IdEmpresa_inv = Convert.ToInt32(item.IdEmpresa_inv);
      //            Obj.IdSucursal_inv = Convert.ToInt32(item.IdSucursal_inv);
      //            Obj.IdBodega_inv = Convert.ToInt32(item.IdBodega_inv);
      //            Obj.IdMovi_inven_tipo_inv = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
      //            Obj.IdNumMovi_inv = Convert.ToDecimal(item.IdNumMovi_inv);
      //            Obj.IdCentroCosto = item.IdCentroCosto;
      //            Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
      //            Obj.Su_Descripcion = item.Su_Descripcion;
      //            Obj.bo_Descripcion = item.bo_Descripcion;
      //            Obj.tm_descripcion = item.tm_descripcion;
      //            Obj.IdEstadoAproba = item.IdEstadoAproba;               
      //        }

      //        return Obj;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
      //        mensaje = ex.InnerException + " " + ex.Message;
      //        return new in_Ingreso_varios_Info();
      //    }
      //}

      //public Boolean ModificarCabecera_IngVarios(in_Ingreso_varios_Info info, ref string msgs)
      //{
      //    try
      //    {
      //        using (EntitiesInventario context = new EntitiesInventario())
      //        {
      //            var contact = context.in_Ingreso_varios.First(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdMovi_inven_tipo==info.IdMovi_inven_tipo && q.IdNumMovi==info.IdNumMovi);



      //            contact.IdEmpresa_inv = info.IdEmpresa_inv;
      //            contact.IdSucursal_inv = info.IdSucursal_inv;
      //            contact.IdBodega_inv = info.IdBodega_inv;
      //            contact.IdMovi_inven_tipo_inv = info.IdMovi_inven_tipo_inv;
      //            contact.IdNumMovi_inv = info.IdNumMovi_inv;

      //            context.SaveChanges();
      //        }
      //        return true;
      //    }
      //    catch (Exception ex)
      //    {
      //        string arreglo = ToString();
      //        tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
      //        tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
      //        msgs = ex.InnerException + " " + ex.Message;
      //        oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
      //        return false;
      //    }
      //}

    }
}
