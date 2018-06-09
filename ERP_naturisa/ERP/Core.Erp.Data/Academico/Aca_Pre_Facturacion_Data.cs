using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Info.Academico;

namespace Core.Erp.Data.Academico
{
   public class Aca_Pre_Facturacion_Data
   {
       string mensaje = "";

       public int getId(int IdInstitucion)
       {
           try
           {
               int Id;
               Entities_Academico OEEmpleado = new Entities_Academico();
               var select = from q in OEEmpleado.Aca_Pre_Facturacion
                            where q.IdInstitucion == IdInstitucion
                            select q;

               if (select.ToList().Count() == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in OEEmpleado.Aca_Pre_Facturacion
                                    where q.IdInstitucion == IdInstitucion
                                    select q.IdPreFacturacion).Max();
                   Id = Convert.ToInt32(select_em.ToString()) + 1;
               }
               return Id;
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

       public Boolean ExistePeriodo(int IdInstitucion, int IdPeriodo)
       {
           try
           {
               Boolean Existe = false;
               Entities_Academico context = new Entities_Academico();

               var select = from A in context.Aca_Pre_Facturacion
                            where A.IdInstitucion == IdInstitucion
                            //&& A.ip == IdPeriodo
                            select A;

               if (select.Count() == 0)
                   return false;
               else
                   return true;
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

       public Boolean GrabarDB(Aca_Pre_Facturacion_Info Info, ref string msg)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {

                        Aca_Pre_Facturacion address = new Aca_Pre_Facturacion();
                       address.IdInstitucion = Info.IdInstitucion;
                       address.IdPreFacturacion = Info.IdPreFacturacion;
                       address.IdInstitucion_contrato = Info.IdInstitucion_contrato;
                       address.IdPeriodo = Info.IdPeriodo;
                       address.fecha_prefacturacion = Convert.ToDateTime(Info.fecha_prefacturacion);
                       address.IdEmpresa_fact = Convert.ToInt32(Info.IdEmpresa_fact);
                       address.IdSucursal_fact = Info.IdSucursal_fact;
                       address.IdBodega_fact = Info.IdBodega_fact;

                       address.IdCbteVta = Info.IdCbteVta;
                       address.IdPtoVta_fact = Info.IdPtoVta_fact;
                       address.vt_fecha_fact = Info.vt_fecha_fact;
                       address.vt_fech_venc = Info.vt_fech_venc;
                       address.observacion_fact = Info.observacion_fact;
                       address.IdBodega_fact = Info.IdBodega_fact;
                       address.Estado_Pre_factutacion_Cat = Info.Estado_Pre_factutacion_Cat
                           ;
                       context.Aca_Pre_Facturacion.Add(address);
                       context.SaveChanges();





                 
               }
               return true;
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

       public Boolean ModificarDB(Aca_Pre_Facturacion_Info Info, ref string msg)
       {
           try
           {
               Boolean resultado = false;
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_Pre_Facturacion.FirstOrDefault(
                         minfo => minfo.IdInstitucion == Info.IdInstitucion
                        && minfo.IdPreFacturacion == Info.IdPreFacturacion 
                                                                           );
                   if (address != null)
                   {
                       address.IdInstitucion_contrato = Info.IdInstitucion_contrato;
                       address.IdPeriodo = Info.IdPeriodo;
                       address.fecha_prefacturacion = Convert.ToDateTime(Info.fecha_prefacturacion);
                       address.IdEmpresa_fact = Convert.ToInt32(Info.IdEmpresa_fact);
                       address.IdSucursal_fact = Info.IdSucursal_fact;
                       address.IdBodega_fact = Info.IdBodega_fact;

                       address.IdCbteVta = Info.IdCbteVta;
                       address.IdPtoVta_fact = Info.IdPtoVta_fact;
                       address.vt_fecha_fact = Info.vt_fecha_fact;
                       address.vt_fech_venc = Info.vt_fech_venc;
                       address.observacion_fact = Info.observacion_fact;
                       address.IdBodega_fact = Info.IdBodega_fact;
                       address.Estado_Pre_factutacion_Cat = Info.Estado_Pre_factutacion_Cat ;
                       context.SaveChanges();
                       resultado = true;
                   }
                   else
                       msg = "No se pudo modificar, ya que la consulta regreso vacia";
               }
               return resultado;
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


       public List<Aca_Pre_Facturacion_Info> Get_List(int IdInstitucion)
       {
           List<Aca_Pre_Facturacion_Info> lstAspirante = new List<Aca_Pre_Facturacion_Info>();
           try
           {
               using (Entities_Academico Base = new Entities_Academico())
               {
                   var vaspirante = from a in Base.vwAca_Pre_Facturacion
                                    where a.IdInstitucion == IdInstitucion
                                    select a;

                   foreach (var item in vaspirante)
                   {
                       Aca_Pre_Facturacion_Info address = new Aca_Pre_Facturacion_Info();
                       address.IdInstitucion = item.IdInstitucion;
                       address.IdPreFacturacion = item.IdPreFacturacion;
                       address.IdInstitucion_contrato = item.IdInstitucion_contrato;
                       address.IdPeriodo = item.IdPeriodo;
                       address.fecha_prefacturacion = Convert.ToDateTime(item.fecha_prefacturacion);
                       address.IdEmpresa_fact = Convert.ToInt32(item.IdEmpresa_fact);
                       address.IdSucursal_fact = item.IdSucursal_fact;
                       address.IdBodega_fact =Convert.ToInt32( item.IdBodega_fact);
                       address.IdCbteVta = item.IdCbteVta;
                       address.IdPtoVta_fact = item.IdPtoVta_fact;
                       address.vt_fecha_fact = item.vt_fecha_fact;
                       address.vt_fech_venc = item.vt_fech_venc;
                       address.observacion_fact = item.observacion_fact;
                       address.IdBodega_fact =Convert.ToInt32( item.IdBodega_fact);

                       address.Descripcion = item.Descripcion;
                       address.pe_FechaIni =item.pe_FechaIni;
                       address.pe_FechaFin = item.pe_FechaFin;
                       address.pe_estado = item.pe_estado;
                       address.IdAnioLectivo = item.IdAnioLectivo;
                       address.Ruc = item.Ruc;
                       address.codInstitucion = item.codInstitucion;
                       address.Nombre = item.Nombre;
                       address.Estado_Pre_factutacion_Cat = item.Estado_Pre_factutacion_Cat;
                       lstAspirante.Add(address);
                   }

               }
               return lstAspirante;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               string MensajeError = string.Empty;
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               MensajeError = ex.InnerException + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);

               throw new Exception(ex.InnerException.ToString());
           }

       }

       public Boolean Procesar_Pre_Fact(Aca_Pre_Facturacion_Info Info, int IdSede, ref string msg)
       {
           try
           {
               using (Entities_Academico context = new Entities_Academico())
               {

                   context.spACA_Pre_facturar_x_periodo(Info.IdEmpresa_fact, Info.IdInstitucion, IdSede,  Info.IdAnioLectivo, Info.IdPeriodo, Info.IdPreFacturacion, Info.fecha_prefacturacion, Info.Estado_Pre_factutacion_Cat, Info.observacion_fact);
               }
               return true;
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

       public int getId_pre_Facturacion(int IdAnioLectivo, int idPeriodo)
       {
           try
           {
               int Id=0;
               //string anio = IdAnioLectivo.ToString();
               int anio = IdAnioLectivo;

               Entities_Academico OEEmpleado = new Entities_Academico();
               var select = from q in OEEmpleado.vwAca_Pre_Facturacion
                            where q.IdAnioLectivo == anio
                            && q.IdPeriodo==idPeriodo
                            select q;
               if(select.Count()>0)
               Id=Convert.ToInt32( select.FirstOrDefault().IdPreFacturacion);
               return Id;
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

       public Boolean Modificar_Estado_Prefacturacion_DB(Aca_Pre_Facturacion_Info Info, ref string msg)
       {
           try
           {
               Boolean resultado = false;
               using (Entities_Academico context = new Entities_Academico())
               {
                   var address = context.Aca_Pre_Facturacion.FirstOrDefault(
                         minfo => minfo.IdInstitucion == Info.IdInstitucion
                        && minfo.IdPreFacturacion == Info.IdPreFacturacion
                                                                           );
                   if (address != null)
                   {

                       address.Estado_Pre_factutacion_Cat = "FAC";
                       context.SaveChanges();
                       resultado = true;
                   }
                   else
                       msg = "No se pudo modificar, ya que la consulta regreso vacia";
               }
               return resultado;
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
