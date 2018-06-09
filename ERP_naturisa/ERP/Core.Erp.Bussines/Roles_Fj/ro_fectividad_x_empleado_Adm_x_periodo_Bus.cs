using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Info.Roles;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
namespace Core.Erp.Business.Roles_Fj
{
   public class ro_fectividad_x_empleado_Adm_x_periodo_Bus
   {
       cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;

       string mensaje = "";
       ro_fectividad_x_empleado_Adm_x_periodo_Data data = new ro_fectividad_x_empleado_Adm_x_periodo_Data();
       ro_fectividad_x_empleado_Adm_x_periodo_Det_Bus Bus_Detalle = new ro_fectividad_x_empleado_Adm_x_periodo_Det_Bus();

       ro_Empleado_Novedad_Bus bus_novedad = new ro_Empleado_Novedad_Bus();
       ro_Empleado_Novedad_Det_Bus bus_detalle_novedad = new ro_Empleado_Novedad_Det_Bus();
       ro_Empleado_Novedad_Det_Info info_detalle = new ro_Empleado_Novedad_Det_Info();



       public bool Guardar_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
       {
           bool bandera=false;
           decimal id_nov = 0;
           try
           {
               if(data.Guardar_DB(info))
               {
                   if (Bus_Detalle.Guardar_DB(info.detalle))
                   {
                       foreach (var item in Get_Novedades(info.detalle))
                       {
                         bandera=  bus_novedad.GrabarDB(item, ref id_nov);
                       }
                   }

               }

               return bandera;
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

       public bool Modificar_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
       {
           bool bandera = false;
           decimal id_nov = 0;

           try
           {
               if (data.Modificar_DB(info))
               {
                   if (Bus_Detalle.Modificar_DB(info.detalle))
                   {
                       
                       foreach (var item in Get_Novedades(info.detalle))
                       {

                           info_detalle = bus_detalle_novedad.get_si_existe_novedad(item.IdEmpresa, item.IdEmpleado, item.IdRubro, item.IdCalendario);
                           if (info_detalle != null)
                           {
                               item.IdNovedad = info_detalle.IdNovedad;
                               bandera = bus_novedad.ModificarDB(item);

                           }
                           else
                           {
                               bandera = bus_novedad.GrabarDB(item, ref id_nov);

                          }
                       }
                   }
               }

               return bandera;
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

       public bool Anular_DB(ro_fectividad_x_empleado_Adm_x_periodo_Info info)
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

       public List<ro_fectividad_x_empleado_Adm_x_periodo_Info> lista_Efectividad_x_periodod(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_fin)
       {
           try
           {
               return data.lista_Efectividad_x_periodod(IdEmpresa, Fecha_Inicio, Fecha_fin);

           

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


       private List<ro_Empleado_Novedad_Info> Get_Novedades(List<ro_fectividad_x_empleado_Adm_x_periodo_Det_Info> lista)
       {

           try
           {


               List<ro_Empleado_Novedad_Info> listado_novedades = new List<ro_Empleado_Novedad_Info>();

               foreach (var item in lista)
               {

                   if (item.valor_ganado > 0)
                   {
                       ro_Empleado_Novedad_Info info_novedad = new ro_Empleado_Novedad_Info();
                       info_novedad.IdEmpresa = item.IdEmpresa;
                       info_novedad.IdNomina_Tipo = item.IdNomina_Tipo;
                       info_novedad.IdNomina_TipoLiqui = item.IdNomina_Tipo_Liq;
                       info_novedad.IdEmpleado = item.IdEmpleado;
                       info_novedad.Fecha =item.fechaPago;
                       info_novedad.TotalValor = Convert.ToDouble(item.valor_ganado);
                       info_novedad.Fecha_PrimerPago = DateTime.Now;
                       info_novedad.NumCoutas = 1;
                       info_novedad.IdUsuario = param.IdUsuario;
                       info_novedad.Fecha_Transac = DateTime.Now;
                       info_novedad.Estado = "A";
                       info_novedad.IdCalendario = item.IdPeriodo.ToString();


                       // detalle de la novedad 

                       ro_Empleado_Novedad_Det_Info info_detalle = new ro_Empleado_Novedad_Det_Info();
                       info_detalle.IdEmpresa = item.IdEmpresa;
                       info_detalle.IdEmpleado = item.IdEmpleado;
                       info_detalle.Secuencia = 1;
                       info_detalle.IdRol = null;
                       info_detalle.IdRubro = item.IdRubro;
                       info_detalle.FechaPago = item.fechaPago;
                       info_detalle.Valor = Convert.ToDouble(item.valor_ganado);
                       info_detalle.Observacion = "Novedad generada por procesos del sistema del periodo " + item.IdPeriodo;
                       info_detalle.EstadoCobro = "PEN";
                       info_detalle.Estado = "A";
                       info_detalle.IdCalendario = item.IdPeriodo.ToString();
                       info_novedad.InfoNovedadDet=info_detalle;
                       listado_novedades.Add(info_novedad);
                   }
               }

               return listado_novedades;



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
