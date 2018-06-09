using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Bus
  {
      string mensaje = "";
      ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Data data = new ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Data();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
      ro_Parametro_calculo_Horas_Extras_Bus bus_parametros = new ro_Parametro_calculo_Horas_Extras_Bus();
      ro_Parametro_calculo_Horas_Extras_Info info_parametro = new ro_Parametro_calculo_Horas_Extras_Info();
        public bool GuardarDB(ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info info)
        {
            try
            {


                return data.GuardarDB(info);

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

        public List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> Get_lista_horas_extras_x_aproba(int IdEmpresa, DateTime Fechainicio, DateTime FechaFin)
        {
            try
            {
                return data.Get_lista_horas_extras_x_aproba(IdEmpresa, Fechainicio, FechaFin);
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

        public bool GuardarNovedad(List<ro_empleado_Novedad_x_horasExtras_Pendiente_Aprobar_Info> lista)
        {
            try
            {
                decimal id_nov = 0;

                ro_Empleado_Novedad_Bus BUS_NOVEDAD = new ro_Empleado_Novedad_Bus();
                info_parametro = bus_parametros.Get_info(param.IdEmpresa);
                foreach (var item in lista)
                {
                // creo la cabecera de la novedad
                    ro_Empleado_Novedad_Info info = new ro_Empleado_Novedad_Info();
                    ro_Empleado_Novedad_Det_Info info_Detalle = new ro_Empleado_Novedad_Det_Info();

                    info.IdEmpresa = item.IdEmpresa;
                    info.IdEmpleado = item.IdEmpleado;
                    info.IdNomina_Tipo = item.IdTipoNomina;
                    info.IdNomina_TipoLiqui = item.IdNomina_tipo;
                    info.TotalValor =(Convert.ToDouble( item.SueldoActual / item.Calculo_Horas_extras_Sobre)*2)*item.Max_num_horas_sab_dom;
                    if (Convert.ToDateTime(item.es_fecha_registro).Day > info_parametro.Corte_Horas_extras)
                    {
                        info.Fecha_PrimerPago = item.FechaPago.AddMonths(1);
                        info.Fecha = item.FechaPago;
                    }
                    else
                    {
                        info.Fecha_PrimerPago =item.FechaPago;
                        info.Fecha = item.es_fecha_registro;

                    }
                    info.NumCoutas = 1;
                    info.Num_Horas = item.Max_num_horas_sab_dom;
                    info.Fecha_Transac = DateTime.Now;
                    info.IdUsuario = param.IdUsuario;
                    info.IdCalendario = item.es_fecha_registro.Year.ToString() + item.es_fecha_registro.Month.ToString().PadLeft(2, '0') + item.es_fecha_registro.Day.ToString().PadLeft(2, '0');
                    // creo el detalle 
                    info_Detalle.IdEmpleado = param.IdEmpresa;
                    info_Detalle.IdEmpleado = item.IdEmpleado;
                    info_Detalle.Secuencia = 1;
                    info_Detalle.IdRubro = "9";
                    if (Convert.ToDateTime(item.es_fecha_registro).Day >= info_parametro.Corte_Horas_extras)
                    {
                        info_Detalle.FechaPago = item.FechaPago.AddMonths(1);
                    }
                    else
                    {
                        info_Detalle.FechaPago = item.FechaPago;

                    }
                    info_Detalle.Valor = (Convert.ToDouble(item.SueldoActual / item.Calculo_Horas_extras_Sobre) * 2) * item.Max_num_horas_sab_dom;
                    info_Detalle.EstadoCobro = "PEN";
                    info_Detalle.Observacion = "Horas extras al 100% correspondiente al"+item.es_fecha_registro.ToString();
                    info_Detalle.NumHoras = item.Max_num_horas_sab_dom;
                    info_Detalle.Estado = "A";
                    info_Detalle.IdCalendario = item.es_fecha_registro.Year.ToString() + item.es_fecha_registro.Month.ToString().PadLeft(2, '0') + item.es_fecha_registro.Day.ToString().PadLeft(2, '0');

                    info.InfoNovedadDet = info_Detalle;
                    BUS_NOVEDAD.GrabarDB(info, ref id_nov);
                }

                data.ModificarDB(lista);// modifico el valor de estado aprobado
                return true;
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
