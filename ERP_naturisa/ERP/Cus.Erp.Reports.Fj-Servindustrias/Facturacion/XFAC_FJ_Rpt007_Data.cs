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
   public class XFAC_FJ_Rpt007_Data
   {
       tb_Empresa_Info Cbt = new tb_Empresa_Info();
       tb_Empresa_Data empresaData = new tb_Empresa_Data();

       public List<XFAC_FJ_Rpt007_Info> Get_List(int idEmpresa, int IdPeriodo, int anio, int mes)
       {
           try
           {
               List<XFAC_FJ_Rpt007_Info> Lista = new List<XFAC_FJ_Rpt007_Info>();

               fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data data_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data();
               fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();

               info_parametro = data_parametro.Get_Info_marge_ganacia_RRHH(idEmpresa, anio, mes);
               info_parametro.Porcentaje_Calculo_BS = info_parametro.Porcentaje_Calculo_BS / 100;
               info_parametro.Porcentaje_Calculo_MO = info_parametro.Porcentaje_Calculo_MO / 100;
               Cbt = empresaData.Get_Info_Empresa(idEmpresa);

               using (EntitiesFacturacion_FJ_Rpt Context = new EntitiesFacturacion_FJ_Rpt())
               {
                   var lst = from q in Context.vwFAC_FJ_Rpt007
                             where q.IdEmpresa == idEmpresa
                             && q.IdPeriodo == IdPeriodo
                           //  && q.IdPreFacturacion == IdPrefacturacion
                             select q;

                   foreach (var item in lst)
                   {
                       XFAC_FJ_Rpt007_Info info = new XFAC_FJ_Rpt007_Info();
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdPreFacturacion = item.IdPreFacturacion;
                       info.IdPeriodo = item.IdPeriodo;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdEmpleado = item.IdEmpleado;
                       info.IdCargo = item.IdCargo;
                       info.Centro_costo = item.Centro_costo;
                       info.IdCentroCosto_sub_centro_costo = item.IdCentroCosto_sub_centro_costo;
                       info.IdCentroCosto = item.IdCentroCosto;
                       info.pe_cedulaRuc = item.pe_cedulaRuc;
                       info.pe_nombreCompleto = item.pe_nombreCompleto;
                       info.ca_descripcion = item.ca_descripcion;
                       info.SALARIO = item.SALARIO;
                       info.H_EXTRAS = item.H_EXTRAS;
                       info.ALIMENTACION = item.ALIMENTACION;
                       info.Total_Ingreso = item.SALARIO + item.H_EXTRAS;
                       info.Total_mas_Beneficio =Convert.ToDouble( info.Total_Ingreso*Convert.ToDouble( info_parametro.Porcentaje_Calculo_BS));
                       info.total_ManoObra = info.Total_mas_Beneficio;
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
