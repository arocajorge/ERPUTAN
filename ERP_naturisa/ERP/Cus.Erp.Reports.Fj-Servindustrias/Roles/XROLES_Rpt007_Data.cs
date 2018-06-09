using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.Roles;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Business.Roles_Fj;
namespace Cus.Erp.Reports.FJ.Roles
{
  public  class XROLES_Rpt007_Data
  {
      tb_Empresa_Info Cbt = new tb_Empresa_Info();
      tb_Empresa_Data empresaData = new tb_Empresa_Data();

      public List<XROLES_Rpt007_Info> Get_Mano_Obra(ro_periodo_x_ro_Nomina_TipoLiqui_Info info_periodo)
      {
          List<XROLES_Rpt007_Info> lista = new List<XROLES_Rpt007_Info>();
          List<XROLES_Rpt007_Info> lista_tmp = new List<XROLES_Rpt007_Info>();

         XROLES_Rpt007_Info info ;

          fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info info_parametro = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();
          fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus bus_parametros = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Bus();
          List<ro_fuerza_Info> list_fuerza = new List<ro_fuerza_Info>();
          ro_fuerza_Bus bus_fuerza = new ro_fuerza_Bus();
          info_parametro = bus_parametros.Get_List_Get_Info_marge_ganacia_RRHH(info_periodo.IdEmpresa, info_periodo.pe_FechaIni.Year, info_periodo.pe_FechaIni.Month);
          list_fuerza = bus_fuerza.Get_List_Fuerza(info_periodo.IdEmpresa);

          try
          {
         

              using (Entities_Roles_Fj_Rpt db = new Entities_Roles_Fj_Rpt())
              {
                  var query = from q in db.spROLES_Rpt007(info_periodo.IdEmpresa,info_periodo.IdNomina_Tipo,info_periodo.IdNomina_TipoLiqui, info_periodo.IdPeriodo, info_periodo.pe_FechaIni, info_periodo.pe_FechaFin)
                             
                            
                              select q;

                  foreach (var item in query)
                  {
                      info = new XROLES_Rpt007_Info();

                      info.fu_descripcion = item.fu_descripcion; 
                      info.zo_descripcion = item.zo_descripcion;
                      info.em_fecha_ingreso = item.em_fecha_ingreso;
                      info.pe_cedulaRuc = item.pe_cedulaRuc;
                      info.pe_nombre = item.pe_nombre+" "+item.pe_apellido;
                      info.pe_apellido = item.pe_apellido;
                      info.pe_nombre = item.pe_nombre;
                      info.pe_FechaIni = info_periodo.pe_FechaIni;
                      info.ca_descripcion = item.ca_descripcion;
                      info.ca_descripcion = item.ca_descripcion;
                      info.pe_apellido = item.pe_apellido+" "+item.pe_nombre;
                      info.Cargo = item.Cargo;
                      info.SUELDOACTUAL = item.SueldoActual;
                      info.zo_descripcion = item.zo_descripcion;                     
                      info.DIAS = item.Dias;
                      info.Falta = item.Falta;
                      info.VACACIONES = item.Vacaciones;
                      if (item.Permiso_IESS == null)
                          item.Permiso_IESS = 0;
                      info.PERMISO_IESS = item.Permiso_IESS;
                      if (item.Dias_Efectivos > 30)
                          info.DIAS_EFECTIVOS = 30;
                      else
                      info.DIAS_EFECTIVOS = item.Dias_Efectivos;
                      info.SUELDO_X_DIAS_TRABAJADOS = item.SUELDO_X_DIAS_TRABAJADOS;
                      info.HORAS_25 = item.HORAS__25_;
                      info.HORAS_50 = item.HORAS_50_;
                      info.HORAS_100 = item.HORAS_100_;
                      info.TRANSPORTE = item.TRANSPORTE;
                      info.ALIMENTACION = item.ALIMENTACION;
                      info.BONIFICACIÓN = item.BONIFICACIÓN;
                      info.TOTAL_SOBRETIEMPO =Convert.ToDouble( item.HORAS__25_ + item.HORAS_50_ + item.HORAS_100_);
                      info.tot_ingreso =Convert.ToDouble( item.SUELDO_X_DIAS_TRABAJADOS + info.TOTAL_SOBRETIEMPO);
                      info.T_MAS_BENEFICIOS = Convert.ToDouble(info.tot_ingreso) *Convert.ToDouble( info_parametro.Porcentaje_Calculo_MO);
                      info.TOTAL_MO =Convert.ToDouble( item.TRANSPORTE + item.ALIMENTACION + info.T_MAS_BENEFICIOS);
                      info.DIA_TRABAJADO =Convert.ToInt32( item.Dias - item.Vacaciones - item.Permiso_IESS - item.Falta);
                      lista.Add(info);
                  }




                  // extraigo la fuerza

                  foreach (var item in list_fuerza)
                  {
                      info = new XROLES_Rpt007_Info();

                      decimal tota = 0;
                      tota =Convert.ToDecimal( lista.Where(v => v.fu_descripcion == item.fu_descripcion).Sum(v => v.TOTAL_MO));
                      info.TOTAL_MO =Convert.ToDouble( tota *info_parametro.Porcentaje_Calculo_BS);
                      info.fu_descripcion = item.fu_descripcion;
                      if(tota>0)
                      lista.Add(info);
                  }
              
              }
              return lista;
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
