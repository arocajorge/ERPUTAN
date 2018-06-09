using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
  public  class ro_ObtenerReporte_Data
    {
      string mensaje = "";
      //Reporte Rol de Pago
      public List<tbROL_Rpt002_Info> OptenerData_spROL_Rpt002(int IdEmpresa, decimal IdEmpleado,int Idperiodo,int IdNomina_Tipo,int IdNomina_TipoLiqui ,
          int IdDepartamento, string tipoConsulta, string IdUsuario, string nom_pc, int secuencia, string OrgCopy)
      {
        List<tbROL_Rpt002_Info> ListData = new List<tbROL_Rpt002_Info>();
          try
          {
            //using (EntitiesRoles base_ = new EntitiesRoles())
            //  {
              //    base_.spROL_Rpt002(IdEmpresa, IdEmpleado, Idperiodo, IdNomina_Tipo,IdNomina_TipoLiqui,IdDepartamento, tipoConsulta ,IdUsuario, nom_pc, secuencia, OrgCopy);
                 
              //  var q = from C in base_.tbROL_Rpt002
              //            where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
              //            select C;

              //    foreach (var item in q)
              //    {
              //        tbROL_Rpt002_Info info = new tbROL_Rpt002_Info();
              //        info.IdEmpresa = item.IdEmpresa;
              //        info.IdEmpleado = item.IdEmpleado;
              //        info.IdPeriodo = item.IdPeriodo;
              //        info.IdRubro = item.IdRubro;
              //        info.IdNomina_Tipo = item.IdNomina_Tipo;
              //        info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
              //        info.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
              //        info.Valor = item.Valor;


              //        if (info.Valor > 0)
              //            info.Ingreso = info.Valor;
              //        else if (info.Valor < 0)
              //            info.Descuento = info.Valor *-1;
                         
              //        info.IdUsuario = item.IdUsuario;
              //        info.pe_nombreCompleto = item.pe_nombreCompleto;
              //        info.Departamento = item.Departamento;
              //        info.pe_FechaFin = item.pe_FechaFin;
              //        info.Fecha_Transac = Convert.ToDateTime(item.Fecha_Transac);
              //        info.em_nombre = item.em_nombre;
              //        info.nom_pc = item.nom_pc;
              //        info.ru_descripcion = item.ru_descripcion;
              //        info.ru_tipo = item.ru_tipo;

              //        info.dias_trabajo = Convert.ToInt32(item.dias_trabajo);
              //        info.dias_vacaciones = Convert.ToInt32(item.dias_vacaciones);
              //        info.dias_maternidad = Convert.ToInt32(item.dias_maternidad);

              //       // 15/11/2013
              //        info.totIng = Convert.ToDouble(item.totIng);
              //        info.totEgr = Convert.ToDouble(item.totEgr)*-1;
              //        info.totalNeto = Convert.ToDouble(item.totalNeto);

              //        info.secuencia = Convert.ToInt32(item.secuencia);
              //        info.OrgCopy = item.OrgCopy;                   

              //        ListData.Add(info);
              //    }
              //}
              return ListData;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }


      //Reporte Prestamo
      public List<tbROL_Rpt003_Info> OptenerData_spROL_Rpt003(int IdEmpresa, decimal IdPrestamo, int IdNomina_Tipo, string IdRubro, decimal IdEmpleado,   
          string IdUsuario, string nom_pc)
      {
        List<tbROL_Rpt003_Info> ListData = new List<tbROL_Rpt003_Info>();
          try
          {
              //using (EntitiesRoles base_ = new EntitiesRoles())
              //{
              //    base_.spROL_Rpt003(IdEmpresa,IdPrestamo, IdNomina_Tipo ,IdRubro,IdEmpleado, IdUsuario, nom_pc);
              //    var q = from C in base_.tbROL_Rpt003
              //            where C.IdUsuario == IdUsuario && C.nom_pc == nom_pc
              //            select C;

              //    foreach (var item in q)
              //    {
              //        tbROL_Rpt003_Info info = new tbROL_Rpt003_Info();
              //        info.IdEmpresa = item.IdEmpresa;
              //        info.IdPrestamo = item.IdPrestamo;
              //        info.IdNomina_Tipo = item.IdNomina_Tipo;
              //        info.nomi_descripcion = item.nomi_descripcion;
              //        info.IdEmpleado = item.IdEmpleado;
              //        info.pe_nombre = item.pe_nombre;
              //        info.pe_apellido = item.pe_apellido;
              //        info.IdRubro = item.IdRubro;
              //        info.ru_descripcion = item.ru_descripcion;
              //        info.IdEmpleado_Aprueba = item.IdEmpleado_Aprueba;
              //        info.pe_nombre_apru = item.pe_nombre_apru;
              //        info.pe_apellido_apru = item.pe_apellido_apru;
              //        info.codigo = item.codigo;
              //        info.ca_descripcion = item.ca_descripcion;
              //        info.estado = info.estado;

              //        info.Fecha = Convert.ToDateTime(item.Fecha);

              //        info.MontoSol = Convert.ToDouble(item.MontoSol);
              //        info.TasaInteres = Convert.ToDouble(item.TasaInteres);
              //        info.NumCuotas = item.NumCuotas;
              //        info.cod_pago = item.cod_pago;
              //        info.peri_pago = item.peri_pago;
              //        info.Fecha_PriPago = item.Fecha_PriPago;
              //        info.Observacion = item.Observacion;
              //        info.TotalPrestado = Convert.ToDouble(item.TotalPrestado);
              //        info.TotalCobrado = Convert.ToDouble(item.TotalCobrado);
              //        info.SaldoPrestado = Convert.ToDouble(item.SaldoPrestado);                   
              //        info.NumCuotaDet = item.NumCuotaDet;
              //        info.SaldoInicial = Convert.ToDouble(item.SaldoInicial);
              //        info.Interes = Convert.ToDouble(item.Interes);
              //        info.AbonoCapital = Convert.ToDouble(item.AbonoCapital);
              //        info.TotalCuota = Convert.ToDouble(item.TotalCuota);
              //        info.Saldo = Convert.ToDouble(item.Saldo);
              //        info.FechaPago = item.FechaPago;
              //        info.EstadoPago = item.EstadoPago;
              //        info.Observacion_det = item.Observacion_det;
              //        info.Estado_Det = item.Estado_Det;
              //        info.Fecha_Transac = item.Fecha_Transac;
              //        info.IdUsuario = item.IdUsuario;
              //        info.nom_pc = item.nom_pc;

              //       ListData.Add(info);
              //    }
              //}


              return ListData;

          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }

      public List<tbROL_NominaGeneral_Info> OptenerData_spROL_NominaGeneral(int IdEmpresa, int Idperiodo, int IdNomina_Tipo, int IdNomina_TipoLiqui,
            int IdDivisionIni, int IdDivisionFin, decimal IdEmpleadoIni, decimal IdEmpleadoFin, string IdUsuario, string nom_pc)
      {
          List<tbROL_NominaGeneral_Info> ListData = new List<tbROL_NominaGeneral_Info>();

          try
          {
             

              //using (EntitiesRoles base_ = new EntitiesRoles())
              //{
              //    base_.spROL_NominaGeneral(IdEmpresa,IdUsuario,nom_pc,IdNomina_Tipo,IdNomina_TipoLiqui, Idperiodo,IdDivisionIni,IdDivisionFin,IdEmpleadoIni,IdEmpleadoFin);
                 
              //    string query = "select * from tbROL_NominaGeneral where IdUsuario ='"+IdUsuario+"' and nom_pc = '" +nom_pc +"'";

              //    var listado = base_.Database.SqlQuery<tbROL_NominaGeneral_Info>(query);
              //    ListData = listado.ToList(); 
              //}


              return ListData;
          }
          catch (Exception ex)
          {
              string array = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", array, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.InnerException + " " + ex.Message;
              throw new Exception(ex.InnerException.ToString());
          }
      }
    }
}
