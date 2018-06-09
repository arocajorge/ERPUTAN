using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
namespace Cus.Erp.Reports.FJ.Facturacion
{
   public class XFAC_FJ_Rpt008_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XFAC_FJ_Rpt008_Info> Get_List(int idEmpresa, int IdPeriodo, int anio, int mes)
       {
           try
           {
               List<XFAC_FJ_Rpt008_Info> Lista = new List<XFAC_FJ_Rpt008_Info>();

               fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data data_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data();
               fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();

               info_parametro = data_parametro.Get_Info_marge_ganacia_RRHH(idEmpresa, anio, mes);
               info_parametro.Porcentaje_Calculo_BS = info_parametro.Porcentaje_Calculo_BS / 100;
               info_parametro.Porcentaje_Calculo_MO = info_parametro.Porcentaje_Calculo_MO / 100;
               Cbt = empresaData.Get_Info_Empresa(idEmpresa);

               using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
               {
                   var lst = from q in Context.vwFAC_FJ_Rpt008
                             where q.IdEmpresa == idEmpresa
                             && q.IdPeriodo == IdPeriodo
                           //  && q.IdPreFacturacion == IdPrefacturacion
                             select q;

                   foreach (var item in lst)
                   {
                       XFAC_FJ_Rpt008_Info info = new XFAC_FJ_Rpt008_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdPeriodo = item.IdPeriodo;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.IdEmpleado = item.IdEmpleado;
                       info.Nombres = item.Nombres;
                       info.ca_descripcion = item.ca_descripcion;
                       info.zo_descripcion = item.zo_descripcion;
                       info.ru_descripcion = item.Descripcion;
                       info.Orden = item.Orden;
                       info.ca_descripcion = item.ca_descripcion;
                       info.Valor = item.Valor;
                       info.rub_visible_reporte = item.rub_visible_reporte;
                       info.em_fecha_ingreso = item.em_fecha_ingreso;
                       info.em_fechaSalida = item.em_fechaSalida;
                       info.SueldoActual = item.SueldoActual;
                       info.de_descripcion = item.de_descripcion;
                       info.ru_descripcion = item.ru_descripcion;
                       info.Periodo = "LIQUIDACIÓN DE MANO DE OBRA " + item.pe_mes + "/" + item.IdanioFiscal;
                       info.pe_FechaIni = item.pe_FechaIni;
                       Lista.Add(info);

                   }
               }
               return Lista;
           }
           catch (Exception ex)
           {
               string mensaje = "";
               mensaje = ex.ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(mensaje);
           }
       }
   
    }
}
