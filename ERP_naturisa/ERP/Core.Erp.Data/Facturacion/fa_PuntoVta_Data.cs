using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Facturacion;
using Core.Erp.Info.General;
using Core.Erp.Data.General;


namespace Core.Erp.Data.Facturacion
{
  public  class fa_PuntoVta_Data
    {
      string mensaje = "";
      List<fa_PuntoVta_Info> lista = new List<fa_PuntoVta_Info>();

      public List<fa_PuntoVta_Info> Get_List_PuntoVta(int IdEmpresa)
      {

          try
          {
              List<fa_PuntoVta_Info> Lst = new List<fa_PuntoVta_Info>();
              EntitiesFacturacion oEnti = new EntitiesFacturacion();

              var Query = from q in oEnti.vwfa_PuntoVta
                          where q.IdEmpresa==IdEmpresa
                          select q;

              foreach (var item in Query)
              {
                  fa_PuntoVta_Info Obj = new fa_PuntoVta_Info();
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdPuntoVta = item.IdPuntoVta;
                  Obj.cod_PuntoVta = item.cod_PuntoVta;
                  Obj.nom_PuntoVta = item.nom_PuntoVta;
                  Obj.nom_PuntoVta2 = "[" + item.IdPuntoVta.ToString() + "] " + item.nom_PuntoVta;
                  Obj.estado = item.estado;
                  Obj.IdBodega = item.IdBodega;
                  Obj.Su_Descripcion = item.Su_Descripcion;
                  Lst.Add(Obj);
              }
              lista = Lst;
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      public List<fa_PuntoVta_Info> Get_List_PuntoVta(int IdEmpresa, int IdSucursal)
      {

          try
          {
              List<fa_PuntoVta_Info> Lst = new List<fa_PuntoVta_Info>();
              EntitiesFacturacion oEnti = new EntitiesFacturacion();

              var Query = from q in oEnti.fa_PuntoVta
                          where q.IdEmpresa == IdEmpresa
                          && q.IdSucursal == IdSucursal
                          select q;

              foreach (var item in Query)
              {
                  fa_PuntoVta_Info Obj = new fa_PuntoVta_Info();
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdPuntoVta = item.IdPuntoVta;
                  Obj.cod_PuntoVta = item.cod_PuntoVta;
                  Obj.nom_PuntoVta = item.nom_PuntoVta;
                  Obj.nom_PuntoVta2 = "[" + item.IdPuntoVta.ToString() + "] " + item.nom_PuntoVta;
                  Obj.estado = item.estado;
                  Obj.IdBodega = item.IdBodega;
                  Lst.Add(Obj);
              }
              lista = Lst;
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      public bool GrabarDB(fa_PuntoVta_Info info, ref string msg)
      {
          try
          {
              using (EntitiesFacturacion context = new EntitiesFacturacion())
              {
                  var lst = from   q in context.fa_PuntoVta
                            where  q.IdEmpresa == info.IdEmpresa
                               &&  q.IdPuntoVta == info.IdPuntoVta
                               &&  q.IdSucursal == info.IdSucursal
                            select q;
                  if (lst.Count() == 0)
                  {
                      fa_PuntoVta entity = new fa_PuntoVta();
                      entity.IdEmpresa = info.IdEmpresa;
                      entity.IdSucursal = info.IdSucursal;
                      entity.IdPuntoVta = info.IdPuntoVta=Get_ID(info.IdEmpresa, info.IdSucursal);
                      entity.cod_PuntoVta = info.cod_PuntoVta == "" ? "S" + info.IdSucursal + "-" + info.IdPuntoVta : info.cod_PuntoVta;
                      entity.nom_PuntoVta = info.nom_PuntoVta;
                      entity.IdBodega = info.IdBodega;
                      entity.estado = true;
                      context.fa_PuntoVta.Add(entity);
                      context.SaveChanges();
                      msg = "Punto de venta #: " + info.IdPuntoVta.ToString() + " registrado exitosamente.";
                  }
                  else
                  {
                      msg = "El punto de venta Ingresado ya existe por favor ingresar uno diferente";
                      return false;
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      public bool ModificarDB(fa_PuntoVta_Info info, ref string msg)
      {
          try
          {
              using (EntitiesFacturacion context = new EntitiesFacturacion())
              {
                  fa_PuntoVta entity = context.fa_PuntoVta.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdPuntoVta == info.IdPuntoVta);
                  if (entity != null)
                  {
                      entity.cod_PuntoVta = info.cod_PuntoVta == "" ? "S"+info.IdSucursal+"-"+info.IdPuntoVta : info.cod_PuntoVta;
                      entity.nom_PuntoVta = info.nom_PuntoVta;
                      entity.IdBodega = info.IdBodega;
                      context.SaveChanges();
                      msg = "Punto de venta # " + info.IdPuntoVta.ToString() + " sucursal # " + info.IdSucursal.ToString() + " actualizado exitosamente";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      public bool AnularDB(fa_PuntoVta_Info info, ref string msg)
      {
          try
          {
              using (EntitiesFacturacion context = new EntitiesFacturacion())
              {
                  fa_PuntoVta entity = context.fa_PuntoVta.FirstOrDefault(q => q.IdEmpresa == info.IdEmpresa && q.IdSucursal == info.IdSucursal && q.IdPuntoVta == info.IdPuntoVta);
                  if (entity != null)
                  {
                      entity.estado = false;
                      context.SaveChanges();
                      msg = "Punto de venta # " + info.IdPuntoVta.ToString() + " sucursal # " + info.IdSucursal.ToString()+ " anulado exitosamente";
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }

      private int Get_ID(int IdEmpresa, int IdSucursal)
      {
          try
          {
              int ID = 0;

              using (EntitiesFacturacion Context = new EntitiesFacturacion())
              {
                  var lst = from q in Context.fa_PuntoVta
                            where q.IdEmpresa == IdEmpresa
                            && q.IdSucursal == IdSucursal
                            select q;

                  if (lst.Count() == 0)
                  {
                      ID = 1;
                  }
                  else
                      ID = lst.Max(q => q.IdPuntoVta) + 1;
              }

              return ID;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              mensaje = ex.ToString();
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(ex.ToString());
          }
      }
    }
}
