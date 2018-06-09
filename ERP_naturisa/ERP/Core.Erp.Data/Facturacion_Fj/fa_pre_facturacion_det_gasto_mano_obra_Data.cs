using Core.Erp.Data.General;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.Facturacion_Fj
{
  public  class fa_pre_facturacion_det_gasto_mano_obra_Data
  {
      public List<fa_pre_facturacion_det_gasto_mano_obra_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion, DateTime Fecha)
      {
          try
          {
              List<fa_pre_facturacion_det_gasto_mano_obra_Info> Lista = new List<fa_pre_facturacion_det_gasto_mano_obra_Info>();
              fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data data_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data();
              fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();

              info_parametro = data_parametro.Get_Info_marge_ganacia_RRHH(IdEmpresa,Fecha.Year,Fecha.Month);
              info_parametro.Porcentaje_Calculo_BS = info_parametro.Porcentaje_Calculo_BS / 100;
              info_parametro.Porcentaje_Calculo_MO = info_parametro.Porcentaje_Calculo_MO / 100;
              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  var lst = from q in Context.vwfa_pre_facturacion_det_gasto_mano_obra
                            where IdEmpresa == q.IdEmpresa && q.IdPreFacturacion == IdPrefacturacion
                            select q;

                  foreach (var item in lst)
                  {
                      fa_pre_facturacion_det_gasto_mano_obra_Info info = new fa_pre_facturacion_det_gasto_mano_obra_Info();
                        info. IdEmpresa =item.IdEmpresa;
                        info.IdPreFacturacion =item.IdPreFacturacion;
                        info. IdPeriodo =item.IdPeriodo;
                        info. IdNomina_Tipo =item.IdNomina_Tipo;
                        info. IdEmpleado =item.IdEmpleado;
                        info. IdCargo =item.IdCargo;
                        info. IdCentroCosto =item.IdCentroCosto;
                        info. IdCentroCosto_sub_centro_costo =item.IdCentroCosto_sub_centro_costo;
                        info. pe_cedulaRuc =item.pe_cedulaRuc;
                        info. pe_nombreCompleto =item.pe_nombreCompleto;
                        info. ca_descripcion =item.ca_descripcion;
                        info. SALARIO =item.SALARIO;
                        info. H_EXTRAS =item.H_EXTRAS;
                        info.ALIMENTACION = item.ALIMENTACION;
                        info.TOTAL_INGRESOS =Convert.ToDouble( item.SALARIO  + item.H_EXTRAS);
                        info.T_BENEFICIOS = (Convert.ToDouble(info.TOTAL_INGRESOS * Convert.ToDouble("1.1") * Convert.ToDouble(info_parametro.Porcentaje_Calculo_BS)));
                        info.TOTAL_M_O = info.T_BENEFICIOS + info.ALIMENTACION;
                        Lista.Add(info);
                  }
              }

              return Lista;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean GuardarDB(List<fa_pre_facturacion_det_gasto_mano_obra_Info> Lista)
      {
          try
          {
              foreach (var item in Lista)
              {
                  using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
                  {
                      
                      Context.SaveChanges();
                  }
              }
              return true;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
              MensajeError = ex.ToString();
              throw new Exception(ex.ToString());
          }
      }

      public Boolean EliminarDB(fa_pre_facturacion_Info Info)
      {
          try
          {
              using (Entity_Facturacion_FJ Context = new Entity_Facturacion_FJ())
              {
                  Context.Database.ExecuteSqlCommand("delete Fj_servindustrias.fa_pre_facturacion_det_cobro_x_Poliza where IdEmpresa = " + Info.IdEmpresa + " and IdPrefacturacion = " + Info.IdPreFacturacion);
              }

              return true;
          }
          catch (Exception ex)
          {
              string MensajeError = "";
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
