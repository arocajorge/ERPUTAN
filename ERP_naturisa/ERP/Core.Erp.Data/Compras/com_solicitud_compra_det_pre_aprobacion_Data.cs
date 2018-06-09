using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Compras
{
  public  class com_solicitud_compra_det_pre_aprobacion_Data
    {

      string mensaje = "";
      com_solicitud_compra_det_aprobacion_Data dataApro = new com_solicitud_compra_det_aprobacion_Data();

     
      
      public Boolean GuardarDB(List<com_solicitud_compra_det_pre_aprobacion_Info> LstInfo)
      {
          try
          {
              foreach (var item in LstInfo)
              {
                  using (EntitiesCompras Context = new EntitiesCompras())
                  {
                      var select = from q in Context.com_solicitud_compra_det_pre_aprobacion
                                   where q.IdEmpresa == item.IdEmpresa
                                   && q.IdSucursal_SC == item.IdSucursal_SC && q.IdSolicitudCompra == item.IdSolicitudCompra
                                   && q.Secuencia_SC == item.Secuencia_SC
                                   select q;

                      if (select.Count() == 0)
                      {
                          com_solicitud_compra_det_pre_aprobacion Address = new com_solicitud_compra_det_pre_aprobacion();
                          Address.IdEmpresa = item.IdEmpresa;
                          Address.IdSucursal_SC = item.IdSucursal_SC;
                          Address.IdSolicitudCompra = item.IdSolicitudCompra;
                          Address.Secuencia_SC = item.Secuencia_SC;
                          Address.IdEstadoAprobacion = item.IdEstadoAprobacion;
                          Address.IdUsuarioAprueba = item.IdUsuarioAprueba;
                          Address.FechaHoraAprobacion = item.FechaHoraAprobacion;
                          Address.do_observacion = item.do_observacion;
                          Context.com_solicitud_compra_det_pre_aprobacion.Add(Address);
                          Context.SaveChanges();
                      }
                      else
                      {
                          var contact = Context.com_solicitud_compra_det_pre_aprobacion.First(q => q.IdEmpresa == item.IdEmpresa
                                       && q.IdSucursal_SC == item.IdSucursal_SC && q.IdSolicitudCompra == item.IdSolicitudCompra
                                       && q.Secuencia_SC == item.Secuencia_SC);

                          contact.IdEmpresa = item.IdEmpresa;
                          contact.IdSolicitudCompra = item.IdSolicitudCompra;
                          contact.Secuencia_SC = item.Secuencia_SC;
                          contact.IdSucursal_SC = item.IdSucursal_SC;
                          contact.IdEstadoAprobacion = item.IdEstadoAprobacion;
                          contact.IdUsuarioAprueba = item.IdUsuarioAprueba;
                          contact.FechaHoraAprobacion = item.FechaHoraAprobacion;
                          contact.do_observacion = item.do_observacion;
                          Context.SaveChanges();
                      }

                      dataApro.Actualizar_EstadoPreAprobacion(item.IdEmpresa, item.IdSucursal_SC, item.IdSolicitudCompra, item.Secuencia_SC, item.IdEstadoAprobacion, ref mensaje);
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




      public List<com_solicitud_compra_det_pre_aprobacion_Info> Get_List_solicitud_compra_det_Pre_aprobacion(int IdEmpresa, int IdSurcursal, decimal IdSoliComp)
      {
          List<com_solicitud_compra_det_pre_aprobacion_Info> Lst = new List<com_solicitud_compra_det_pre_aprobacion_Info>();
          EntitiesCompras oEnti = new EntitiesCompras();
          try
          {
              var Query = from q in oEnti.com_solicitud_compra_det_pre_aprobacion 
                          where q.IdEmpresa == IdEmpresa && q.IdSucursal_SC == IdSurcursal && q.IdSolicitudCompra == IdSoliComp
                          select q;
              foreach (var item in Query)
              {
                  com_solicitud_compra_det_pre_aprobacion_Info Obj = new com_solicitud_compra_det_pre_aprobacion_Info();
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdSucursal_SC = item.IdSucursal_SC;
                  Obj.IdSolicitudCompra = item.IdSolicitudCompra;
                  Obj.Secuencia_SC = item.Secuencia_SC;
                  Obj.IdEstadoAprobacion = item.IdEstadoAprobacion;
                  Obj.IdUsuarioAprueba = item.IdUsuarioAprueba;
                  Obj.FechaHoraAprobacion = Convert.ToDateTime(item.FechaHoraAprobacion);
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


      public Boolean EliminarDB(int IdEmpresa, int IdSucursal, decimal IdSolicitudCompra)
      {
          try
          {

              EntitiesCompras Oent = new EntitiesCompras();

              var Consulta = Oent.Database.ExecuteSqlCommand("delete from com_solicitud_compra_det_pre_aprobacion where IdEmpresa = " + IdEmpresa + " and IdSucursal_SC =" + IdSucursal + " and IdSolicitudCompra= " + IdSolicitudCompra + "");

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
  
  }
}
