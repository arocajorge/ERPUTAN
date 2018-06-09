using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Inventario;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Erp.Data.Inventario
{
  public  class in_Ing_Egr_Inven_Data
    {
      
      string mensaje = "";

      public decimal GetId(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo)
      {
          decimal Id = 0;
          try
          {

              EntitiesInventario contex = new EntitiesInventario();
              var selecte = contex.in_Ing_Egr_Inven.Count(q => q.IdEmpresa == IdEmpresa && q.IdSucursal == IdSucursal && q.IdMovi_inven_tipo == IdMovi_inven_tipo);

              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in contex.in_Ing_Egr_Inven
                                   where q.IdEmpresa == IdEmpresa
                                   && q.IdSucursal == IdSucursal
                                   && q.IdMovi_inven_tipo==IdMovi_inven_tipo
                                   select q.IdNumMovi).Max();
                  Id = Convert.ToDecimal(select_em.ToString()) + 1;
              }

              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean GuardarDB(in_Ing_Egr_Inven_Info info, ref decimal IdNumMovi, ref string mensaje)
      {
          try
          {
              try
              {
                  using (EntitiesInventario Context = new EntitiesInventario())
                  {
                      var Address = new in_Ing_Egr_Inven();

                      Address.IdEmpresa = info.IdEmpresa;
                      Address.IdSucursal = info.IdSucursal;
                      Address.IdBodega = info.IdBodega;
                      Address.IdNumMovi = info.IdNumMovi = GetId(info.IdEmpresa, info.IdSucursal, info.IdMovi_inven_tipo);
                      Address.signo = info.signo;
                      Address.IdMotivo_oc = info.IdMotivo_oc == 0 ? null : info.IdMotivo_oc;
                      Address.IdMotivo_Inv = info.IdMotivo_Inv == 0 ? null : info.IdMotivo_Inv;
                      IdNumMovi = info.IdNumMovi;
                      Address.IdMovi_inven_tipo = info.IdMovi_inven_tipo;
                      Address.CodMoviInven = (info.CodMoviInven == "" || info.CodMoviInven == null) ? IdNumMovi.ToString() : info.CodMoviInven;
                      Address.cm_observacion = (info.cm_observacion == "") ? "" : info.cm_observacion;
                      Address.cm_fecha = info.cm_fecha == null ? DateTime.Now : info.cm_fecha.Date;
                      Address.IdUsuario = info.IdUsuario;
                      Address.Fecha_Transac = DateTime.Now;
                      Address.nom_pc = info.nom_pc;
                      Address.ip = info.ip;
                      Address.Estado = "A";
                      Address.IdCentroCosto = info.IdCentroCosto;
                      Address.IdCentroCosto_sub_centro_costo = info.IdCentroCosto_sub_centro_costo;
                      Address.IdResponsable = info.IdResponsable;
                      Context.in_Ing_Egr_Inven.Add(Address);
                      Context.SaveChanges();
                      
                      //Graba Detalle  in_Ing_Egr_Inven_det
                      if (info.listIng_Egr.Count() != 0)
                      {
                          int sec = 0;

                          foreach (var item in info.listIng_Egr)
                          {
                              sec = sec + 1;
                              item.IdEmpresa = info.IdEmpresa;
                              item.IdSucursal = info.IdSucursal;
                              item.IdMovi_inven_tipo = info.IdMovi_inven_tipo;

                              if (item.IdBodega == null || item.IdBodega == 0)
                              {
                                  item.IdBodega = Convert.ToInt32(info.IdBodega);
                              }

                              item.IdNumMovi = IdNumMovi;
                              item.Secuencia = sec;
                          }


                          in_Ing_Egr_Inven_det_Data odata = new in_Ing_Egr_Inven_det_Data();
                          odata.GuardarDB(info.listIng_Egr);
                      }

                      mensaje = "Grabación ok..";
                  }
                  return true;
              }
              catch (DbEntityValidationException ex)
              {
                  string arreglo = ToString();
                  tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                  oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                  mensaje = ex.ToString() + " " + ex.Message;
                  mensaje = "Error al Grabar" + ex.Message;
                  throw new Exception(ex.ToString());
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

      public Boolean ModificarDB(in_Ing_Egr_Inven_Info info, ref string msgs)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa
                      && q.IdSucursal == info.IdSucursal && q.IdNumMovi == info.IdNumMovi && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo);
                  if (contact != null)
                  {
                      contact.CodMoviInven = info.CodMoviInven;
                      contact.cm_fecha = info.cm_fecha == null ? DateTime.Now : info.cm_fecha.Date; 
                      contact.cm_observacion = info.cm_observacion;
                      contact.IdUsuarioUltModi = info.IdUsuarioUltModi;
                      contact.Fecha_UltMod = DateTime.Now;
                      context.SaveChanges();
                      msgs = "Se ha procedido a modificar el registro de Egreso Varios  #: " + info.IdNumMovi.ToString() + " exitosamente";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

              msgs = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean AnularDB(in_Ing_Egr_Inven_Info info, ref string msgs)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal                      
                      && q.IdNumMovi == info.IdNumMovi && info.IdMovi_inven_tipo==q.IdMovi_inven_tipo);
                  if (contact != null)
                  {
                      contact.Estado = "I";
                      contact.IdusuarioUltAnu = info.IdusuarioUltAnu;
                      contact.Fecha_UltAnu = DateTime.Now;
                      contact.MotivoAnulacion = info.MotivoAnulacion;
                      contact.cm_observacion = "**Anulado**" + info.cm_observacion;
                      context.SaveChanges();
                      msgs = "Se ha procedido a anular el registro Egreso varios  #: " + info.IdNumMovi.ToString() + " exitosamente";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);

              msgs = "Se ha producido el siguiente error: " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarCabecera_IdMovi_Inven_x_IngEgr(in_Ing_Egr_Inven_Info info, ref string msgs)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal 
                      && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                  if (contact != null)
                  {
                      //contact.IdEmpresa_inv = info.IdEmpresa_inv;
                      //contact.IdSucursal_inv = info.IdSucursal_inv;
                      //contact.IdBodega_inv = info.IdBodega_inv;
                      //contact.IdMovi_inven_tipo_inv = info.IdMovi_inven_tipo_inv;
                      //contact.IdNumMovi_inv = info.IdNumMovi_inv;
                      context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              msgs = ex.ToString() + " " + ex.Message;
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref msgs);
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
           int IdBodegaIni, int IdBodegaFin, DateTime FechaIni, DateTime FechaFin, int IdMovi_inven_tipo)
      {
          List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();

              IQueryable<vwin_Ing_Egr_Inven> Query;
              if (IdBodegaIni == 0)
                  Query = from q in oEnti.vwin_Ing_Egr_Inven
                          where q.IdEmpresa == IdEmpresa
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                          && q.IdSucursal >= IdSucursalIni
                          && q.IdSucursal <= IdSucursalFin
                          && q.IdBodega >= IdBodegaIni
                          && q.IdBodega <= IdBodegaFin
                          || q.IdBodega == null
                          select q;
              else
                  Query = from q in oEnti.vwin_Ing_Egr_Inven
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal >= IdSucursalIni
                          && q.IdSucursal <= IdSucursalFin
                          && q.IdBodega >= IdBodegaIni
                          && q.IdBodega <= IdBodegaFin
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                          select q;

              foreach (var item in Query)
              {
                  in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdBodega = item.IdBodega;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.CodMoviInven = item.CodMoviInven;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
                  Obj.Estado = item.Estado;
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  Obj.signo = item.signo;
                  Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                  Obj.nom_bodega = item.nom_bodega;
                  Obj.nom_sucursal = item.nom_sucursal;
                  Obj.Desc_mov_inv = item.Desc_mov_inv;
                  Obj.nom_tipo_inv = item.nom_tipo_inv;
                  Obj.cod_tipo_inv = item.cod_tipo_inv;
                  Obj.signo_tipo_inv = item.signo_tipo_inv;
                  Obj.IdOrdenCompra = item.IdOrdenCompra;
                  Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                  Obj.IdResponsable = item.IdResponsable;
                  Obj.IdEstadoAproba = item.IdEstadoAproba;
                  Obj.nom_EstadoAproba = item.nom_EstadoAproba;
                  Obj.IdEstadoDespacho_cat = item.IdEstadoDespacho_cat;
                  Obj.Fecha_registro = item.Fecha_registro;
                  Obj.co_factura = item.co_factura;
                  Obj.nom_proveedor = item.pr_nombre;
                  Obj.nom_estado_cierre_oc = item.Descripcion;
                  Obj.IdEstadoCierre_oc = item.IdEstado_cierre;
                  Lst.Add(Obj);
              }

              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
          int IdBodegaIni, int IdBodegaFin,   DateTime FechaIni, DateTime FechaFin,string Tipo_ing_egr)
      {      
          List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();

              IQueryable<vwin_Ing_Egr_Inven> Query;
              if(IdBodegaIni == 0)
              Query = from q in oEnti.vwin_Ing_Egr_Inven
                              where q.IdEmpresa == IdEmpresa
                              && q.cm_fecha >= FechaIni
                              && q.cm_fecha <= FechaFin
                              && q.signo_tipo_inv.Contains(Tipo_ing_egr)
                              && q.IdSucursal >= IdSucursalIni
                              && q.IdSucursal <= IdSucursalFin
                              && q.IdBodega >=IdBodegaIni
                              && q.IdBodega <= IdBodegaFin                              
                              || q.IdBodega == null
                              select q;
              else
                  Query = from q in oEnti.vwin_Ing_Egr_Inven
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal >= IdSucursalIni
                          && q.IdSucursal <= IdSucursalFin
                          && q.IdBodega >= IdBodegaIni
                          && q.IdBodega <= IdBodegaFin
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.signo_tipo_inv.Contains(Tipo_ing_egr)
                          select q;

                  foreach (var item in Query)
                  {
                      in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                      Obj.IdEmpresa = item.IdEmpresa;
                      Obj.IdSucursal = item.IdSucursal;
                      Obj.IdBodega = item.IdBodega;
                      Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                      Obj.IdNumMovi = item.IdNumMovi;
                      Obj.CodMoviInven = item.CodMoviInven;
                      Obj.cm_observacion = item.cm_observacion;
                      Obj.cm_fecha = item.cm_fecha;
                      Obj.Estado = item.Estado;
                      Obj.IdCentroCosto = item.IdCentroCosto;
                      Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                      Obj.signo = item.signo;
                      Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                      Obj.nom_bodega = item.nom_bodega;
                      Obj.nom_sucursal = item.nom_sucursal;
                      Obj.Desc_mov_inv = item.Desc_mov_inv;
                      Obj.nom_tipo_inv = item.nom_tipo_inv;
                      Obj.cod_tipo_inv = item.cod_tipo_inv;
                      Obj.signo_tipo_inv = item.signo_tipo_inv;
                      Obj.IdOrdenCompra = item.IdOrdenCompra;
                      Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                      Obj.IdResponsable = item.IdResponsable;
                      Obj.IdEstadoAproba = item.IdEstadoAproba;
                      Obj.nom_EstadoAproba = item.nom_EstadoAproba;
                      Obj.IdEstadoDespacho_cat = item.IdEstadoDespacho_cat;
                      Obj.Fecha_registro = item.Fecha_registro;
                      Obj.co_factura = item.co_factura;
                      Obj.nom_proveedor = item.pr_nombre;
                      Obj.nom_estado_cierre_oc = item.Descripcion;
                      Obj.IdEstadoCierre_oc = item.IdEstado_cierre;
                      Obj.CodMoviInven = item.CodMoviInven;
                      Lst.Add(Obj);
                  } 
                                                                      
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
      {
          List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();

              var Query = from q in oEnti.vwin_Ing_Egr_Inven_x_in_movi_inve
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal 
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.signo.Contains(Tipo_ing_egr)                          
                          select q;

              foreach (var item in Query)
              {
                  in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.signo = item.signo;
                  Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                  Obj.Desc_mov_inv = item.Desc_mov_inv;
                  Obj.tm_descripcion = item.tm_descripcion;
                  Obj.cm_descripcionCorta = item.cm_descripcionCorta;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
                  Obj.Genera_Movi_Inven = item.Genera_Movi_Inven;
                  

                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven_x_in_movi_inve(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi)
      {
          try
          {
              in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

              EntitiesInventario oEnti = new EntitiesInventario();

              var Query = from q in oEnti.vwin_Ing_Egr_Inven_x_in_movi_inve
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          && q.IdMovi_inven_tipo == IdMovi_inve_tipo
                          && q.IdNumMovi == IdNumMovi
                          select q;

              foreach (var item in Query)
              {
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.signo = item.signo;
                  Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                  Obj.Desc_mov_inv = item.Desc_mov_inv;
                  Obj.tm_descripcion = item.tm_descripcion;
                  Obj.cm_descripcionCorta = item.cm_descripcionCorta;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
              }
              return Obj;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean Reversar_Aprobacion(int IdEmpresa, int IdSucursal, int IdMovi_inve_tipo, decimal IdNumMovi, string Genera_movi_inven)
      {
          try
          {
              using (EntitiesInventario Context = new EntitiesInventario())
              {
                  if (Genera_movi_inven == "S")
                  {
                      Context.spSys_inv_Reversar_aprobacion(IdEmpresa, IdSucursal, IdMovi_inve_tipo, IdNumMovi, true);
                  }
                  else
                  {
                      string comando = "update in_Ing_Egr_Inven_det set IdEstadoAproba = 'PEND' where IdEmpresa = "+IdEmpresa+" and IdSucursal = "+IdSucursal+" and IdMovi_inven_tipo = "+IdMovi_inve_tipo+" and IdNumMovi = "+IdNumMovi;
                      Context.Database.ExecuteSqlCommand(comando);
                  }
              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_multi_bodega(int IdEmpresa, int IdSucursalIni, int IdSucursalFin,
         DateTime FechaIni, DateTime FechaFin, string Tipo_ing_egr)
      {
          List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
          try
          {
              FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
              FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
              EntitiesInventario oEnti = new EntitiesInventario();

              IQueryable<vwin_Ing_Egr_Inven> Query;
              
                  Query = from q in oEnti.vwin_Ing_Egr_Inven
                          where q.IdEmpresa == IdEmpresa
                          && q.cm_fecha >= FechaIni
                          && q.cm_fecha <= FechaFin
                          && q.signo_tipo_inv.Contains(Tipo_ing_egr)
                          && q.IdSucursal >= IdSucursalIni
                          && q.IdSucursal <= IdSucursalFin
                          && q.IdBodega == null
                          select q;
              
              foreach (var item in Query)
              {
                  in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdBodega = item.IdBodega;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.CodMoviInven = item.CodMoviInven;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
                  Obj.Estado = item.Estado;
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  Obj.signo = item.signo;
                  Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                  Obj.nom_bodega = item.nom_bodega;
                  Obj.nom_sucursal = item.nom_sucursal;
                  Obj.Desc_mov_inv = item.Desc_mov_inv;
                  Obj.nom_tipo_inv = item.nom_tipo_inv;
                  Obj.cod_tipo_inv = item.cod_tipo_inv;
                  Obj.signo_tipo_inv = item.signo_tipo_inv;
                  Obj.IdOrdenCompra = item.IdOrdenCompra;
                  Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                  Obj.IdEstadoAproba = item.IdEstadoAproba;
                  Obj.nom_EstadoAproba = item.nom_EstadoAproba;
                  Obj.IdEstadoDespacho_cat = item.IdEstadoDespacho_cat;
                  Obj.Fecha_registro = item.Fecha_registro;
                  Obj.co_factura = item.co_factura;
                  Lst.Add(Obj);
              }

              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdBodega, int IdTipoMovi, string Tipo_ing_egr)
      {
          try
          {
              List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
              int IdSucursalIni = IdSucursal;
              int IdSucursalFin = IdSucursal == 0 ? 9999 : IdSucursal;
              int IdBodegaIni = IdBodega;
              int IdBodegaFin = IdBodega == 0 ? 9999 : IdBodega;
              int IdTipoMovi_Ini = IdTipoMovi;
              int IdTipoMovi_Fin = IdTipoMovi == 0 ? 9999 : IdTipoMovi;

              using (EntitiesInventario oEnti = new EntitiesInventario())
              {

                  var Query = from q in oEnti.vwin_Ing_Egr_Inven
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal >= IdSucursalIni
                              && q.IdSucursal <= IdSucursalFin
                                  && q.IdBodega >= IdBodegaIni
                                  && q.IdBodega <= IdBodegaFin
                                  && IdTipoMovi_Ini <= q.IdMovi_inven_tipo 
                                  && q.IdMovi_inven_tipo <= IdTipoMovi_Fin
                              && q.signo_tipo_inv.Contains(Tipo_ing_egr)
                              && q.IdEstadoAproba.Equals("PEND")
                              select q;

                  foreach (var item in Query)
                  {
                      in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                      Obj.IdEmpresa = item.IdEmpresa;
                      Obj.IdSucursal = item.IdSucursal;
                      Obj.IdBodega = item.IdBodega;
                      Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                      Obj.IdNumMovi = item.IdNumMovi;
                      Obj.CodMoviInven = item.CodMoviInven;
                      Obj.cm_observacion = item.cm_observacion;
                      Obj.cm_fecha = item.cm_fecha;
                      Obj.Estado = item.Estado;
                      Obj.IdCentroCosto = item.IdCentroCosto;
                      Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                      Obj.signo = item.signo;
                      Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                      Obj.nom_bodega = item.nom_bodega;
                      Obj.nom_sucursal = item.nom_sucursal;
                      Obj.Desc_mov_inv = item.Desc_mov_inv;
                      Obj.nom_tipo_inv = item.nom_tipo_inv;
                      Obj.cod_tipo_inv = item.cod_tipo_inv;
                      Obj.signo_tipo_inv = item.signo_tipo_inv;

                      Obj.IdMotivo_Inv = item.IdMotivo_Inv;
                      Obj.IdEstadoAproba = item.IdEstadoAproba;
                      Obj.nom_EstadoAproba = item.nom_EstadoAproba;
                      Obj.Checked = false;
                      Obj.Fecha_registro = item.Fecha_registro;
                      Obj.co_factura = item.co_factura;
                      Lst.Add(Obj);
                  }
              }

              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public List<in_Ing_Egr_Inven_Info> Get_List_Ing_Egr_Inven_para_devolucion(int IdEmpresa, int IdSucursal, int IdTipoMovi, string signo, DateTime Fecha_ini, DateTime Fecha_fin)
      {
          try
          {
              List<in_Ing_Egr_Inven_Info> Lst = new List<in_Ing_Egr_Inven_Info>();
              int IdSucursalIni = IdSucursal;
              int IdSucursalFin = IdSucursal == 0 ? 9999 : IdSucursal;
              int IdTipoMovi_Ini = IdTipoMovi;
              int IdTipoMovi_Fin = IdTipoMovi == 0 ? 9999 : IdTipoMovi;
              Fecha_ini = Fecha_ini.Date;
              Fecha_fin = Fecha_fin.Date;

              using (EntitiesInventario oEnti = new EntitiesInventario())
              {

                  var Query = from q in oEnti.vwin_Ing_Egr_Inven_para_devolucion
                              where q.IdEmpresa == IdEmpresa
                              && q.IdSucursal >= IdSucursalIni
                              && q.IdSucursal <= IdSucursalFin
                                  && IdTipoMovi_Ini <= q.IdMovi_inven_tipo
                                  && q.IdMovi_inven_tipo <= IdTipoMovi_Fin
                                  && Fecha_ini <= q.cm_fecha && q.cm_fecha <= Fecha_fin
                              && q.signo.Contains(signo)                              
                              select q;

                  foreach (var item in Query)
                  {
                      in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();

                      Obj.IdEmpresa = item.IdEmpresa;
                      Obj.IdSucursal = item.IdSucursal;
                      Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                      Obj.IdNumMovi = item.IdNumMovi;
                      Obj.cm_observacion = item.cm_observacion;
                      Obj.cm_fecha = item.cm_fecha;
                      Obj.signo = item.signo;
                      Obj.nom_sucursal = item.Su_Descripcion;
                      Obj.nom_tipo_inv = item.tm_descripcion;
                      Obj.CodMoviInven = item.CodMoviInven;
                     
                      Lst.Add(Obj);
                  }
              }

              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public in_Ing_Egr_Inven_Info Get_Info_Ing_Egr_Inven(int IdEmpresa, int IdSucursal, int IdMovi_inven_tipo, decimal IdNumMovi)
      {
          try
          {
              in_Ing_Egr_Inven_Info Obj = new in_Ing_Egr_Inven_Info();
              EntitiesInventario oEnti = new EntitiesInventario();
              IQueryable<vwin_Ing_Egr_Inven> Querry;
              
                  Querry = from q in oEnti.vwin_Ing_Egr_Inven
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          && q.IdMovi_inven_tipo == IdMovi_inven_tipo
                          && q.IdNumMovi == IdNumMovi
                          select q;            


              foreach (var item in Querry)
              {

                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdBodega = item.IdBodega;
                  Obj.IdMovi_inven_tipo = item.IdMovi_inven_tipo;
                  Obj.IdNumMovi = item.IdNumMovi;
                  Obj.CodMoviInven = item.CodMoviInven;
                  Obj.cm_observacion = item.cm_observacion;
                  Obj.cm_fecha = item.cm_fecha;
                  Obj.Estado = item.Estado;                 
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;                                  
                  Obj.signo = item.signo;
                  Obj.IdMotivo_oc = Convert.ToInt32(item.IdMotivo_oc);
                  Obj.nom_bodega = item.nom_bodega;
                  Obj.nom_sucursal = item.nom_sucursal;
                  Obj.nom_motivo = item.nom_motivo;
                  Obj.nom_tipo_inv = item.nom_tipo_inv;
                  Obj.cod_tipo_inv = item.cod_tipo_inv;
                  Obj.signo_tipo_inv = item.signo_tipo_inv;
                  Obj.co_factura = item.co_factura;
                  Obj.IdMotivo_Inv = item.IdMotivo_Inv;
              }

              return Obj;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }     

      public Boolean ModificarDB_desde_transferencia(in_Ing_Egr_Inven_Info info)
      {
          try
          {
              using (EntitiesInventario Context = new EntitiesInventario())
              {
                  in_Ing_Egr_Inven Entity = Context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdBodega == info.IdBodega && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                  
                  if (Entity != null)
                  {
                      Entity.cm_fecha = info.cm_fecha;
                      Entity.cm_observacion = info.cm_observacion;
                      Context.SaveChanges();
                  }
              }

              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDB_proceso_cerrado(in_Ing_Egr_Inven_Info info, ref string msgs)
      {
          try
          {
              using (EntitiesInventario Context = new EntitiesInventario())
              {
                  in_Ing_Egr_Inven Entity = Context.in_Ing_Egr_Inven.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdMovi_inven_tipo == info.IdMovi_inven_tipo && q.IdNumMovi == info.IdNumMovi);
                  if (Entity != null)
                  {
                      Entity.cm_observacion = info.cm_observacion;
                      Entity.cm_fecha = info.cm_fecha.Date;
                      Entity.CodMoviInven = info.CodMoviInven;
                      Entity.IdMotivo_Inv = info.IdMotivo_Inv;
                      
                      Context.SaveChanges();
                      foreach (var item in info.listIng_Egr)
                      {
                          if (item.IdEmpresa_inv != null)
                          {
                              in_movi_inve_Info info_movi = new in_movi_inve_Info();
                              info_movi.IdEmpresa = Convert.ToInt32(item.IdEmpresa_inv);
                              info_movi.IdSucursal = Convert.ToInt32(item.IdSucursal_inv);
                              info_movi.IdBodega = Convert.ToInt32(item.IdBodega_inv);
                              info_movi.IdMovi_inven_tipo = Convert.ToInt32(item.IdMovi_inven_tipo_inv);
                              info_movi.IdNumMovi = Convert.ToDecimal(item.IdNumMovi_inv);
                              info_movi.cm_observacion = info.cm_observacion;
                              info_movi.cm_fecha = info.cm_fecha;
                              info_movi.CodMoviInven = info.CodMoviInven;

                              in_movi_inve_Data data_movi = new in_movi_inve_Data();
                              data_movi.ModificarDB_proceso_cerrado(info_movi, ref msgs);
                          }
                          else
                          {
                              in_Ing_Egr_Inven_det_Data odata = new in_Ing_Egr_Inven_det_Data();                              
                              
                              if (info.IdBodega != null)
                              {
                                  item.IdBodega = info.IdBodega;
                                  odata.ModificarDB_proceso_cerrado(item);
                                  Entity.IdBodega = info.IdBodega;
                                  Context.SaveChanges();
                              }
                              
                              msgs = "Se actualizó la transacción exitosamente.";                              
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
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
  }
}
