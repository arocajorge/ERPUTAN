using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Roles;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_descuento_no_planificados_Bus
  {
      string mensaje = "";
      ro_descuento_no_planificados_Data data = new ro_descuento_no_planificados_Data();
      ro_descuento_no_planificados_Det_Bus bus_detalle = new ro_descuento_no_planificados_Det_Bus();


      ro_Empleado_Novedad_Bus bus_novedad = new ro_Empleado_Novedad_Bus();
      ro_Empleado_Novedad_Det_Bus bus_novedad_Det = new ro_Empleado_Novedad_Det_Bus();


      public bool Guardar_DB(ro_descuento_no_planificados_Info info, ref int idgrupo)
      {
          try
          {
              return  data.Guardar_DB(info, ref idgrupo);
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }

      public bool Modificar_DB(ro_descuento_no_planificados_Info info)
      {
          try
          {
              return data.Modificar_DB(info);
          }
          catch (Exception ex)
          {
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
             
          }
      }

      public bool Anular_DB(ro_descuento_no_planificados_Info info)
      {
          try
          {
              return data.Anular_DB(info);
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }

      public List<ro_descuento_no_planificados_Info> listado_Descuento(int IdEmpresa, DateTime fecha_inicio, DateTime fecha_fin)
      {
          try
          {
              return data.listado_Descuento(IdEmpresa, fecha_inicio,fecha_fin);
          }
          catch (Exception ex)
          {
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
              
          }
      }
      public List<ro_descuento_no_planificados_Info> listado_Descuento_sin_planificacion(int IdEmpresa, DateTime Fecha_inicio, DateTime Fecha_Fin)
      {
          try
          {
              return data.listado_Descuento_sin_planificacion(IdEmpresa, Fecha_inicio, Fecha_Fin);
          }
          catch (Exception ex)
          {
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);

          }
      }
      public List<ro_descuento_no_planificados_Info> listado_Descuento(int IdEmpresa, int IdNomina_Tipo, int IdEmpleado)
      {
          try
          {
              return data.listado_Descuento(IdEmpresa, IdNomina_Tipo, IdEmpleado);
          }
          catch (Exception ex)
          {
              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);

          }
      }


      public bool Guardar_DB(ro_descuento_no_planificados_Info info)
      {
          try
          {
              string msg="";
              decimal idNovedad = 0;
              int sec = 0;
              bool ba = false;
              if (info.IdNovedad == null || info.IdNovedad == 0)
              {
                  if (bus_novedad.GrabarDB(Get_Novedad(info), ref idNovedad))
                  {
                      info.IdNovedad = Convert.ToInt32(idNovedad);
                      if (data.Modificar_DB(info))
                      {
                          foreach (var item in info.lista)
                          {
                              sec++;
                              item.IdDescuento = info.IdDescuento;
                              item.Secuencia = sec;
                          }
                          ba = bus_detalle.Guardar_DB(info.lista);
                      }

                  }
              }
              else// modificar
              {
                  if (bus_novedad.ModificarDB(Get_Novedad(info)))
                  {

                      if (bus_novedad_Det.EliminarDB(info.IdEmpresa, info.IdNomina_Tipo, info.IdEmpleado, Convert.ToDecimal(info.IdNovedad)))
                      {
                          foreach (var item in Get_Novedad(info).LstDetalle)
                          {
                              bus_novedad_Det.GrabarDB(item, ref msg);
                          }
                          info.IdNovedad = Convert.ToInt32(info.IdNovedad);
                          if (data.Modificar_DB(info))
                          {

                              
                              foreach (var item in info.lista)
                              {
                                  sec++;
                                  item.IdDescuento = info.IdDescuento;
                                  item.Secuencia = sec;
                              }
                              ba = bus_detalle.Guardar_DB(info.lista);
                          }
                      }

                  }
              }

              return ba;
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }

      private ro_Empleado_Novedad_Info Get_Novedad(ro_descuento_no_planificados_Info info)
      {
          try
          {
              int secuencia = 0;
              ro_Empleado_Novedad_Info info_novedad = new ro_Empleado_Novedad_Info();

              info_novedad.IdEmpresa = info.IdEmpresa;
              info_novedad.IdEmpleado = info.IdEmpleado;
              info_novedad.IdNomina_Tipo = info.IdNomina_Tipo;
              if(info.lista.Count()>0)
              info_novedad.IdNomina_TipoLiqui = info.lista.FirstOrDefault().IdNomina_Tipo_Liq;
              if(info.IdNovedad!=null)
              info_novedad.IdNovedad =Convert.ToDecimal( info.IdNovedad);
              info_novedad.IdUsuario = info.IdUsuario;
              info_novedad.Fecha = info.Fecha_Incidente;
              info_novedad.Fecha_Transac = DateTime.Now;
              info_novedad.TotalValor = info.Valor;
              info_novedad.Fecha_PrimerPago = info.Fecha_Incidente;
              info_novedad.NumCoutas = info.lista.Count();
              info_novedad.Estado = "A";

              foreach (var item in info.lista)
              {
                  ro_Empleado_Novedad_Det_Info info_det = new ro_Empleado_Novedad_Det_Info();
                  secuencia++;
                  info_det.IdEmpresa = item.IdEmpresa;
                  info_det.IdNomina = item.IdNomina_Tipo;
                  info_det.IdNominaLiqui = item.IdNomina_Tipo_Liq;
                  info_det.IdEmpleado = item.IdEmpleado;
                  info_det.IdNovedad = info_novedad.IdNovedad;
                  info_det.IdRubro = item.IdRubro;
                  info_det.FechaPago = item.Fecha_Descuento;
                  info_det.EstadoCobro = "PEN";
                  info_det.Valor = item.Valor;
                  info_det.Observacion = item.Observacion;
                  info_det.Estado = "A";
                  info_det.Secuencia = secuencia;
                  info_novedad.LstDetalle.Add(info_det);
 
              }






              return info_novedad;
              
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
     
    }
}
