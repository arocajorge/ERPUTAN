using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Facturacion_Fj
{
  public  class fa_tarifario_facturacion_x_cliente_Data
    {
      string MensajeError = "";

      public bool Guardar(fa_tarifario_facturacion_x_cliente_Info info, ref int idtarifario)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  fa_tarifario_facturacion_x_cliente add = new fa_tarifario_facturacion_x_cliente();
                  add.IdEmpresa = info.IdEmpresa;
                  add.IdTarifario = info.IdTarifario = GetId(info.IdEmpresa);
                  add.IdCliente = info.IdCliente;
                  add.codTarifario = info.codTarifario == "" || info.codTarifario == null ? info.IdTarifario.ToString() : info.codTarifario;
                  add.nom_tarifario = info.nom_tarifario;
                  add.observacion = info.observacion;
                  add.fecha = info.fecha;
                  add.fecha_inicio = info.fecha_inicio;
                  add.fecha_fin = info.fecha_fin;
                  add.IdUsuario = info.IdUsuario;
                  add.Estado = "A";
                  add.IdEstadoVigencia_cat = info.IdEstadoVigencia_cat;
                  add.Movilizacion = info.Movilizacion;
                  add.se_fact_depreciacion = info.se_fact_depreciacion;
                  add.se_fact_egreso_bodega = info.se_fact_egreso_bodega;
                  add.se_fact_gatos = info.se_fact_gatos;
                  add.se_fact_horometro = info.se_fact_horometro;
                  add.se_fact_margen_ganacia = info.se_fact_margen_ganacia;
                  add.se_fact_movilizacion = info.se_fact_movilizacion;
                  add.se_fact_seguro = info.se_fact_seguro;
                  add.se_factura_gastos_roles = info.se_factura_gastos_roles;
                  add.se_fact_horas_minimas = info.se_fact_horas_minimas;
                  add.se_fact_otros = info.se_fact_otros;
                  add.Porcentaje_recargo_iteres_poliza = info.Porcentaje_recargo_iteres_poliza;
                  add.se_fact_recargo_interes = info.se_fact_recargo_interes;
                  model.fa_tarifario_facturacion_x_cliente.Add(add);
                  model.SaveChanges();
                  idtarifario = Convert.ToInt32(add.IdTarifario);
                  return true;

              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool Modificar(fa_tarifario_facturacion_x_cliente_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var add = model.fa_tarifario_facturacion_x_cliente.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdTarifario == info.IdTarifario);
                  if (add!=null)
                  {
                      add.nom_tarifario = info.nom_tarifario;
                      add.observacion = info.observacion;
                      add.fecha = info.fecha;
                      add.fecha_inicio = info.fecha_inicio;
                      add.fecha_fin = info.fecha_fin;
                      add.Movilizacion = info.Movilizacion;
                      add.IdUsuarioUltMod = info.IdUsuarioUltMod;
                      add.FechaUltMod = info.FechaUltMod;
                      add.IdEstadoVigencia_cat = info.IdEstadoVigencia_cat;
                      add.se_fact_depreciacion = info.se_fact_depreciacion;
                      add.se_fact_egreso_bodega = info.se_fact_egreso_bodega;
                      add.se_fact_gatos = info.se_fact_gatos;
                      add.se_fact_horometro = info.se_fact_horometro;
                      add.se_fact_margen_ganacia = info.se_fact_margen_ganacia;
                      add.se_fact_movilizacion = info.se_fact_movilizacion;
                      add.se_fact_seguro = info.se_fact_seguro;
                      add.se_factura_gastos_roles = info.se_factura_gastos_roles;
                      add.se_fact_horas_minimas = info.se_fact_horas_minimas;
                      add.se_fact_otros = info.se_fact_otros;
                      add.Porcentaje_recargo_iteres_poliza = info.Porcentaje_recargo_iteres_poliza;
                      add.se_fact_recargo_interes = info.se_fact_recargo_interes;
                      model.SaveChanges();    
                  }
                  return true;
              }
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public bool Anular(fa_tarifario_facturacion_x_cliente_Info info)
      {
          try
          {
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var add = model.fa_tarifario_facturacion_x_cliente.FirstOrDefault(cot => cot.IdEmpresa == info.IdEmpresa && cot.IdTarifario == info.IdTarifario);

                  add.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                  add.Fecha_UltAnu = info.Fecha_UltAnu;
                  add.Estado = "I";
                  add.MotiAnula = info.MotiAnula;
                  add.IdEstadoVigencia_cat = "EST_VIG_VIGENTE";
                  model.SaveChanges();
                  return true;
              }
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public List<fa_tarifario_facturacion_x_cliente_Info> Get_List_Tarifarios(int idempresa,DateTime fecha_inicio ,DateTime fecha_fin)
      {
          try
          {
              List<fa_tarifario_facturacion_x_cliente_Info> lista = new List<fa_tarifario_facturacion_x_cliente_Info>();
              using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
              {
                  var query = from q in model.vwfa_tarifario_facturacion_x_cliente
                              where q.IdEmpresa == idempresa
                              && fecha_inicio <= q.fecha  
                              && q.fecha<=fecha_fin
                              select q;

                  foreach (var item in query)
                  {
                      fa_tarifario_facturacion_x_cliente_Info info = new fa_tarifario_facturacion_x_cliente_Info();
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTarifario = item.IdTarifario;
                      info.codTarifario = item.codTarifario;
                      info.IdCliente = item.IdCliente;
                      info.observacion = item.observacion;
                      info.nom_tarifario = item.nom_tarifario;
                      info.fecha_inicio = item.fecha_inicio;
                      info.fecha_fin = item.fecha_fin;
                      info.fecha = item.fecha;
                      info.Estado = item.Estado;
                      info.pe_nombreCompleto = item.pe_nombreCompleto;
                      info.IdEstadoVigencia_cat = item.IdEstadoVigencia_cat;
                      info.nom_EstadoVigencia_cat = item.nom_EstadoVigencia_cat;
                      info.Movilizacion = item.Movilizacion==null ? 0 : (double)item.Movilizacion;
                      info.se_fact_depreciacion = item.se_fact_depreciacion;
                      info.se_fact_egreso_bodega = item.se_fact_egreso_bodega;
                      info.se_fact_gatos = item.se_fact_gatos;
                      info.se_fact_horometro = item.se_fact_horometro;
                      info.se_fact_margen_ganacia = item.se_fact_margen_ganacia;
                      info.se_fact_movilizacion = item.se_fact_movilizacion;
                      info.se_fact_seguro = item.se_fact_seguro;
                      info.se_factura_gastos_roles = item.se_factura_gastos_roles;
                      info.se_fact_horas_minimas = item.se_fact_horas_minimas;
                      info.se_fact_otros = item.se_fact_otros;
                      info.Porcentaje_recargo_iteres_poliza = item.Porcentaje_recargo_iteres_poliza;
                      info.se_fact_recargo_interes = item.se_fact_recargo_interes;
                      lista.Add(info);
                  }
                  return lista;

              }

          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public fa_tarifario_facturacion_x_cliente_Info Get_Info(int idEmpresa, decimal idTarifario)
      {
          try
          {
              fa_tarifario_facturacion_x_cliente_Info info = new fa_tarifario_facturacion_x_cliente_Info();

              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  var lst = from q in Context.fa_tarifario_facturacion_x_cliente
                            where idEmpresa == q.IdEmpresa && q.IdTarifario==idTarifario
                            select q;

                  foreach (var item in lst)
                  {
                      info.IdEmpresa = item.IdEmpresa;
                      info.IdTarifario = item.IdTarifario;
                      info.codTarifario = item.codTarifario;
                      info.nom_tarifario = item.nom_tarifario;
                      info.observacion = item.observacion;
                      info.fecha = item.fecha;
                      info.fecha_inicio = item.fecha_inicio;
                      info.fecha_fin = item.fecha_fin;
                      info.IdCliente = item.IdCliente;
                      info.Estado = item.Estado;
                      info.IdUsuario = item.IdUsuario;
                      info.nom_pc = item.nom_pc;
                      info.ip = item.ip;
                      info.IdUsuarioUltMod = item.IdUsuarioUltMod;
                      info.FechaUltMod = item.FechaUltMod;
                      info.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                      info.Fecha_UltAnu = item.Fecha_UltAnu;
                      info.MotiAnula = item.MotiAnula;
                      info.se_fact_depreciacion = item.se_fact_depreciacion;
                      info.se_fact_egreso_bodega = item.se_fact_egreso_bodega;
                      info.se_fact_gatos = item.se_fact_gatos;
                      info.se_fact_horometro = item.se_fact_horometro;
                      info.se_fact_margen_ganacia = item.se_fact_margen_ganacia;
                      info.se_fact_movilizacion = item.se_fact_movilizacion;
                      info.se_fact_seguro = item.se_fact_seguro;
                      info.se_factura_gastos_roles = item.se_factura_gastos_roles;
                      info.IdEstadoVigencia_cat = item.IdEstadoVigencia_cat;
                      info.Movilizacion = item.Movilizacion == null ? 0 : (double)item.Movilizacion;
                      info.se_fact_depreciacion = item.se_fact_depreciacion;
                      info.se_fact_egreso_bodega = item.se_fact_egreso_bodega;
                      info.se_fact_gatos = item.se_fact_gatos;
                      info.se_fact_horometro = item.se_fact_horometro;
                      info.se_fact_margen_ganacia = item.se_fact_margen_ganacia;
                      info.se_fact_movilizacion = item.se_fact_movilizacion;
                      info.se_fact_seguro = item.se_fact_seguro;
                      info.se_factura_gastos_roles = item.se_factura_gastos_roles;
                      info.se_fact_horas_minimas = item.se_fact_horas_minimas;
                      info.se_fact_otros = item.se_fact_otros;
                      info.Porcentaje_recargo_iteres_poliza = item.Porcentaje_recargo_iteres_poliza;
                      info.se_fact_recargo_interes = item.se_fact_recargo_interes;

                  }
              }

              return info;
          }
          catch (Exception ex)
          {

              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public int GetId(int idEmpresa)
      {
          try
          {
              int Id;
              Entity_Facturacion_FJ db = new Entity_Facturacion_FJ();

              var selecte = db.fa_tarifario_facturacion_x_cliente.Count(q => q.IdEmpresa == idEmpresa);

              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in db.fa_tarifario_facturacion_x_cliente
                                   where q.IdEmpresa == idEmpresa
                                   select q.IdTarifario).Max();
                  Id = Convert.ToInt32(select_em.ToString()) + 1;
              }

              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }


      }
    }
}
