
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.Roles;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Bancos;
using Core.Erp.Business.Bancos;
namespace Core.Erp.Business.Roles
{
  public class ro_Archivos_Bancos_Generacion_Bus
    {
      ro_Archivos_Bancos_Generacion_Data oData = new ro_Archivos_Bancos_Generacion_Data();
      tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
      cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
       
      string mensaje = "";
      ro_Archivo_Bancos_Generacion_Detalle_Bus oRo_Archivo_Bancos_Generacion_Detalle_Bus = new ro_Archivo_Bancos_Generacion_Detalle_Bus();
      public ro_Archivos_Bancos_Generacion_Bus() { }
     
      ba_Archivo_Transferencia_Info info_archivo = new ba_Archivo_Transferencia_Info();
      List<ba_Archivo_Transferencia_Det_Info> lista_archivo = new List<ba_Archivo_Transferencia_Det_Info>();
      ba_Archivo_Transferencia_Bus Archivo_Bus = new ba_Archivo_Transferencia_Bus();
      ro_archivos_bancos_generacion_x_empleado_Bus bus_detalle = new ro_archivos_bancos_generacion_x_empleado_Bus();

      public Boolean GrabarBD(ro_Archivos_Bancos_Generacion_Info info, ref decimal id, ref string mensaje)
      {
          try
          {
              Boolean valorDevolver=false;
              int ida=0;

             // bus_detalle.EliminarBD(info.IdEmpresa, info.IdArchivo, ref mensaje);

              if(oData.GetExiste(info, ref mensaje))
              {//MODIFICAR
                  info.UsuarioModifica= param.IdUsuario;
                  info.FechaModifica = param.Fecha_Transac;
                  valorDevolver = oData.ModificarBD(info, ref mensaje);
                  id=info.IdArchivo;


                  // grabando detalle

                  foreach (var item in info.oListRo_archivos_bancos_generacion_x_empleado_Info)
                  {
                      if(bus_detalle.SiExiste(info.IdEmpresa,info.IdNomina,info.IdNominaTipo,info.IdPeriodo,item.IdEmpleado))
                      {
                          bus_detalle.ActulizarDB(info.IdEmpresa, info.IdNomina, info.IdNominaTipo, info.IdPeriodo, item.IdEmpleado, item.Valor);
                      }
                      else
                      {
                      item.IdEmpresa = info.IdEmpresa;
                      item.IdArchivo = info.IdArchivo;
                      bus_detalle.GuardarBD(item, ref mensaje);
                      }
                  }
              }
              else
              {
                  //GRABAR
                  info.UsuarioIngresa = param.IdUsuario;
                  info.FechaIngresa = param.Fecha_Transac;
                  valorDevolver = oData.GrabarBD(info,ref id, ref mensaje);

                  // grabando detalle

                  foreach (var item in info.oListRo_archivos_bancos_generacion_x_empleado_Info)
                  {
                      


                      if (bus_detalle.SiExiste(info.IdEmpresa, info.IdNomina, info.IdNominaTipo, info.IdPeriodo, item.IdEmpleado))
                      {
                          bus_detalle.ActulizarDB(info.IdEmpresa, info.IdNomina, info.IdNominaTipo, info.IdPeriodo, item.IdEmpleado, item.Valor);
                      }
                      else
                      {
                          item.IdEmpresa = info.IdEmpresa;
                          item.IdArchivo = id;
                          bus_detalle.GuardarBD(item, ref mensaje);
                      }
                  }

                  
                  if (valorDevolver)
                  {
                    info_archivo=  Get_archivo(info);

                  valorDevolver=  Archivo_Bus.GrabarDB(info_archivo, ref ida);
                  }
                   
              }

            return valorDevolver;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GrabarBD", ex.Message), ex) { EntityType = typeof(ro_Archivos_Bancos_Generacion_Bus) };

          }
      }


      public List<ro_Archivos_Bancos_Generacion_Info> ConsultaArchivoBancoTransfe(int IdEmpresa, DateTime FechaInicio, DateTime Fecha_Fin)
      {
          try
          {
              return oData.Get_List_Archivos_Bancos_Generacion(IdEmpresa,FechaInicio,Fecha_Fin);
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ConsultaArchivoBancoTransfe", ex.Message), ex) { EntityType = typeof(ro_Archivos_Bancos_Generacion_Bus) };

          }

      }


      public string pu_GenerarNombreArchivo(decimal secuencia, ba_Banco_Cuenta_Info Banco,tb_banco_procesos_bancarios_x_empresa_Info Proceso_Bancario, DateTime fechaGeneracion, string division = "")
      {
          try
          {
              string valorDevolver = "";
              string secuenci_file = "";
              ro_Archivo_Bancos_Generacion_Detalle_Bus  oRo_Archivo_Bancos_Generacion_Detalle_Bus=new ro_Archivo_Bancos_Generacion_Detalle_Bus();
              string sec=oRo_Archivo_Bancos_Generacion_Detalle_Bus.pu_RellenarCaracter(secuencia.ToString(),"0",5);
              tb_Empresa_Bus oTb_Empresa_Bus = new tb_Empresa_Bus();
              tb_Empresa_Info EmpreInfo = new tb_Empresa_Info();
              EmpreInfo = oTb_Empresa_Bus.Get_Info_Empresa(param.IdEmpresa);
              switch (Banco.CodigoLegal)
              { 
                  case "34":   //BANCO BOLIVARIANO
                     
                      valorDevolver = EmpreInfo.em_nombre + fechaGeneracion.ToString("yyyyMMdd") +Convert.ToInt32( sec ) + ".BIZ";
                break;

                  case "30":   //BANCO PACIFICO
                
                EmpreInfo = oTb_Empresa_Bus.Get_Info_Empresa(param.IdEmpresa);
                valorDevolver = EmpreInfo.em_nombre + fechaGeneracion.ToString("yyyyMMdd") + Convert.ToInt32(sec) + ".txt";
                break;


                  case "17":   //BANCO GUAYAQUIL
                    
                     switch (Proceso_Bancario.cod_Proceso)
	                    {
                            case ebanco_procesos_bancarios_tipo.NCR:
                                 secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, fechaGeneracion).ToString();
                                valorDevolver = Proceso_Bancario.Iniciales_Archivo + secuenci_file.Substring(0, 8) + Proceso_Bancario.Codigo_Empresa + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
                                valorDevolver = valorDevolver.Replace(" ", "");
                                break;
                            case ebanco_procesos_bancarios_tipo.PAGOS_MULTICASH:
                             EmpreInfo = oTb_Empresa_Bus.Get_Info_Empresa(param.IdEmpresa);
                             valorDevolver = Proceso_Bancario.Iniciales_Archivo +"_"+ fechaGeneracion.Year.ToString() + fechaGeneracion.Month.ToString().PadLeft(2, '0') + fechaGeneracion.Day.ToString().PadLeft(2, '0') +"_"+ secuencia.ToString().PadLeft(2,'0') + ".txt";
                             break;
                            case ebanco_procesos_bancarios_tipo.ROL_ELECTRONICO_BG:
                              secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, fechaGeneracion).ToString();
                             string codigo_empresa = Proceso_Bancario.Codigo_Empresa;
                             valorDevolver = Proceso_Bancario.Iniciales_Archivo + secuenci_file.Substring(0, 8) + codigo_empresa + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
                             break;
                           


                         default:
                                break;
	                    }
                break;
                  case "10":   //BANCO PICHINCHA

                switch (Proceso_Bancario.cod_Proceso)
                {
                    case ebanco_procesos_bancarios_tipo.TRANSF_BANCARIA_BP:
                         secuenci_file = Archivo_Bus.GetId_codigoArchivo(param.IdEmpresa, fechaGeneracion).ToString();
                        valorDevolver = Proceso_Bancario.Iniciales_Archivo + secuenci_file.Substring(0, 8) + Proceso_Bancario.cod_banco + "_" + secuenci_file.Substring(9, secuenci_file.Length - 9);
   break;
                    
                    default:
                        break;
                }
                break;
              
                  default:
                break;
              }



              return valorDevolver;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarNombreArchivo", ex.Message), ex) { EntityType = typeof(ro_Archivos_Bancos_Generacion_Bus) };

          }
      
      }


 

      public Boolean pu_GenerarArchivo(ro_Archivos_Bancos_Generacion_Info info,string Codigo_empresa, ref string msg) {
          try 
          {
            

              if (info.ro_rol_detalle.Count>0)
              {

                  //if (!oRo_Archivo_Bancos_Generacion_Detalle_Bus.GrabarBD(info.ro_rol_detalle, _Info.IdBanco, info.rutaArchivo, "",Codigo_empresa, ref mensaje))
                  //    {
                  //        return false;
                  //    }
                                         
              }
              
              return true;
          }
          catch (Exception ex)
          {
              Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarArchivoBolivarianoSAT", ex.Message), ex) { EntityType = typeof(ro_Archivos_Bancos_Generacion_Bus) };

          }
      }


      private ba_Archivo_Transferencia_Info Get_archivo(ro_Archivos_Bancos_Generacion_Info info_)
      {
          try
          {

              tb_Calendario_Bus bus_calendario = new tb_Calendario_Bus();
              tb_Calendario_Info info_calendario = new tb_Calendario_Info();
              info_calendario = bus_calendario.Get_Info_Calendario(Convert.ToDateTime( info_.pe_FechaIni));
              lista_archivo = new List<ba_Archivo_Transferencia_Det_Info>();
              info_archivo = new ba_Archivo_Transferencia_Info();
              info_archivo.IdEmpresa = info_.IdEmpresa;
              info_archivo.IdArchivo = 0;
              info_archivo.cod_archivo = info_.cod_archivo;
              info_archivo.IdBanco =Convert.ToInt32( info_.IdBanco);
              info_archivo.IdProceso_bancario = info_.IdProceso_Bancario;
              info_archivo.Origen_Archivo = "RRHH";
              info_archivo.Cod_Empresa = info_.Cod_Empresa;
              info_archivo.Nom_Archivo = info_.Nom_Archivo;
              info_archivo.Fecha =Convert.ToDateTime( info_.Fecha_Genera);
              info_archivo.Archivo = info_.Archivo;
              info_archivo.Estado = true;
              info_archivo.IdEstadoArchivo_cat = "FIL_EMITID";
              info_archivo.IdMotivoArchivo_cat = "MTFI_TRNS";
              info_archivo.IdUsuario = info_.UsuarioIngresa;
              info_archivo.Fecha_Transac = DateTime.Now;

              if (info_.IdNominaTipo == 1)
              {
                  info_archivo.Observacion = "QUINCENA " + info_calendario.NombreMes.ToUpper();
              }
              else
              {
                  info_archivo.Observacion = "FIN DE  " + info_calendario.NombreMes.ToUpper();

              }
              foreach (var item in info_.oListRo_archivos_bancos_generacion_x_empleado_Info)
              {
                  ba_Archivo_Transferencia_Det_Info info_det = new ba_Archivo_Transferencia_Det_Info();
                  info_det.IdEmpresa = info_archivo.IdEmpresa;
                  info_det.IdProceso_bancario = info_archivo.IdProceso_bancario;
                  info_det.IdEstadoRegistro_cat = "REG_EMITI";
                  info_det.Estado = true;
                  info_det.Valor =Convert.ToDecimal( item.Valor);
                  info_det.IdEmpresaNomina = info_archivo.IdEmpresa;
                  info_det.IdNominaTipo = info_.IdNomina;
                  info_det.IdNominaTipoLiqui = info_.IdNominaTipo;
                  info_det.IdPeriodo = info_.IdPeriodo;
                  info_det.IdEmpleado =Convert.ToInt32( item.IdEmpleado);
                  info_det.IdRubro = "950";
                  info_det.IdRubro = null;

                  lista_archivo.Add(info_det);
              }
              info_archivo.Lst_Archivo_Transferencia_Det = lista_archivo;
              return info_archivo;
          }
          catch (Exception ex)
          {
              
            Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
              throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "pu_GenerarArchivoBolivarianoSAT", ex.Message), ex) { EntityType = typeof(ro_Archivos_Bancos_Generacion_Bus) };

          }
      }





    }
}
