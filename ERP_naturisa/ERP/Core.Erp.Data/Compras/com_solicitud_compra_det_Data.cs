using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
  public  class com_solicitud_compra_det_Data
    {
      string mensaje = "";

      public Boolean GuardarDB(List<com_solicitud_compra_det_Info> LstInfo)
      {
          try
          {
              int sec = 0;

              foreach (var item in LstInfo)
              {
                  using (EntitiesCompras Context = new EntitiesCompras())
                  {

                      sec = sec + 1;

                      com_solicitud_compra_det Address = new com_solicitud_compra_det();

                      Address.IdEmpresa = item.IdEmpresa;
                      Address.IdSucursal = item.IdSucursal;
                      Address.IdSolicitudCompra = item.IdSolicitudCompra;
                      Address.Secuencia = item.Secuencia = sec;                    
                      Address.IdProducto = item.IdProducto == 0 ? null : item.IdProducto;
                      Address.do_Cantidad = item.do_Cantidad;
                      Address.NomProducto = item.NomProducto;
                      Address.IdCentroCosto = item.IdCentroCosto;
                      Address.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                      Address.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                      Address.IdPunto_cargo = item.IdPunto_cargo;
                      Address.IdUnidadMedida = item.IdUnidadMedida;

                      Address.do_observacion = item.do_observacion;

                      Context.com_solicitud_compra_det.Add(Address);
                      Context.SaveChanges();

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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean EliminarDB(com_solicitud_compra_Info Info)
      {
          try
          {
            
              EntitiesCompras Oent = new EntitiesCompras();

              var Consulta = Oent.Database.ExecuteSqlCommand("delete from com_solicitud_compra_det where IdEmpresa = " + Info.IdEmpresa + " and IdSucursal =" + Info.IdSucursal + " and IdSolicitudCompra= " + Info.IdSolicitudCompra + "");

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

      public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, decimal idsolicitud)
      {

          List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
          EntitiesCompras oEnti = new EntitiesCompras();
          try
          {
              var Query = from q in oEnti.vwcom_solicitud_compra_det
                          where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.IdSolicitudCompra == idsolicitud
                          select q;
              foreach (var item in Query)
              {

                  com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
                  Obj.IdEmpresa = item.IdEmpresa;

                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                  Obj.Secuencia = item.Secuencia;
                  Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                  Obj.do_Cantidad = item.do_Cantidad;
                  Obj.NomProducto = item.NomProducto;
               
                  Obj.pr_descripcion = item.NomProducto;
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.IdPunto_cargo = item.IdPunto_cargo;

                  Obj.IdUnidadMedida = item.IdUnidadMedida;

                  Obj.nom_punto_cargo = item.nom_punto_cargo;
                  Obj.NomCentroCosto= item.Nom_Centro_costo;
                  Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                  Obj.cod_producto = item.cod_producto;
                  Obj.nom_producto_princ = item.nom_producto_princ;
                  Obj.pr_stock = Convert.ToDecimal(item.pr_stock);

                  Obj.do_observacion = item.do_observacion;

                  

                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }

      }

      public List<com_solicitud_compra_det_Info> Get_list_DetalleLstSolicitudCompra(int idempresa, int idsucursal, DateTime FechaIni, DateTime FechaFin, string IdEstadoAprobacion, ref string mensaje)
      {

          FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
          FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

          List<com_solicitud_compra_det_Info> Lst = new List<com_solicitud_compra_det_Info>();
          EntitiesCompras oEnti = new EntitiesCompras();
          try
          {
              var Query = from q in oEnti.vwcom_solicitud_compra_det
                          where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal && q.fecha >= FechaIni && q.fecha <= FechaFin
                           && q.IdEstadoAprobacion.Contains(IdEstadoAprobacion)
                          select q;
              foreach (var item in Query)
              {

                  com_solicitud_compra_det_Info Obj = new com_solicitud_compra_det_Info();
                  Obj.IdEmpresa = item.IdEmpresa;

                  Obj.IdSucursal = item.IdSucursal;
                  Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                  Obj.Secuencia = item.Secuencia;
                  Obj.IdProducto = Convert.ToDecimal(item.IdProducto);
                  Obj.do_Cantidad = item.do_Cantidad;
                  Obj.NomProducto = item.NomProducto;

                  Obj.pr_descripcion = item.NomProducto;
                  Obj.IdCentroCosto = item.IdCentroCosto;
                  Obj.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                  Obj.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                  Obj.IdPunto_cargo = item.IdPunto_cargo;

                  Obj.IdUnidadMedida = item.IdUnidadMedida;

                  Obj.nom_punto_cargo = item.nom_punto_cargo;
                  Obj.NomCentroCosto = item.Nom_Centro_costo;
                  Obj.Nomsub_centro_costo = item.Nom_SubCentroCosto;
                  Obj.cod_producto = item.cod_producto;
                  Obj.nom_producto_princ = item.nom_producto_princ;
                  Obj.pr_stock = Convert.ToDecimal(item.pr_stock);
                  Obj.nom_Sucursal = item.nom_Sucursal;
                  Obj.nom_Unidad = item.nom_Unidad;

                  Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;

                  Obj.IdEstadoAprobacion_AUX = item.IdEstadoAprobacion;

                  Obj.fecha = item.fecha;

                  Obj.do_observacion = item.do_observacion;


                  Lst.Add(Obj);
              }
              return Lst;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }

      }

      public Boolean Actualizar_Producto_Creado(int IdEmpresa, int IdSucursal,decimal IdSolicitudCompra,int Secuencia, decimal IdProducto,string nom_producto, ref string mensaje)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {
                  var contact = context.com_solicitud_compra_det.FirstOrDefault(VProdu => VProdu.IdEmpresa == IdEmpresa && VProdu.IdSolicitudCompra == IdSolicitudCompra && VProdu.IdSucursal == IdSucursal && VProdu.Secuencia == Secuencia);

                  if (contact != null)
                  {

                      contact.IdProducto = IdProducto;
                      contact.NomProducto = nom_producto;

                      context.SaveChanges();

                      mensaje = "Se ha procedido a Actualizar la Información Exitosamente...";
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarEstadoAproba_DetSolCom(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra, int Secuencia, decimal IdProducto,string IdEstadoAprobacion, ref string mensaje)
      {
          try
          {
              using (EntitiesCompras context = new EntitiesCompras())
              {
                  var contact = context.com_solicitud_compra_det.FirstOrDefault(VProdu => VProdu.IdEmpresa == IdEmpresa 
                      && VProdu.IdSolicitudCompra == IdSolicitudCompra 
                      && VProdu.IdSucursal == IdSucursal && VProdu.Secuencia == Secuencia);
                  if (contact != null)
                  {

                      context.SaveChanges();
                      mensaje = "Actualización ok...";
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
              mensaje = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }
    }
}
