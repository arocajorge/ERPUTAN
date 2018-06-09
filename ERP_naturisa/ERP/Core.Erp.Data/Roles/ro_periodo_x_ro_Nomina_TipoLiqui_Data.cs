
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Roles
{
   public class ro_periodo_x_ro_Nomina_TipoLiqui_Data
   {
       string mensaje = "";
       public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaGeneralPerNomTipLiq(int IdEmpresa)
       { 
           List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {
              
               EntitiesRoles oEnti = new EntitiesRoles();
               //var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
               //            where q.IdEmpresa == IdEmpresa 
               //            select q;

               var Query = from q in oEnti.vwro_periodo_x_ro_Nomina_TipoLiqui_Asignado
                           where q.IdEmpresa == IdEmpresa
                           select q;

               foreach (var item in Query)
               {
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                   Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   Obj.IdPeriodo = item.IdPeriodo;
                   Obj.Cerrado = item.Cerrado;
                   Obj.Procesado= item.Procesado;
                   Obj.Contabilizado = item.Contabilizado;
                   Obj.Tipo = item.Tipo;
                   

                    Lst.Add(Obj);
               }
               return Lst;
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

       // haac 13/01/2014

       public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui)
       {
               List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {

               EntitiesRoles oEnti = new EntitiesRoles();
             //  var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
                         var Query = from q in oEnti.vwRo_periodo_x_ro_Nomina_TipoLiqui
                           where q.IdEmpresa == IdEmpresa &&q.IdNomina_Tipo==IdNomina_Tipo  && q.IdNomina_TipoLiqui == IdNomina_TipoLiqui
                           select q;

               foreach (var item in Query)
               {
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                   Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   Obj.IdPeriodo = item.IdPeriodo;
                   Obj.Cerrado = item.Cerrado;
                   Obj.Procesado = item.Procesado;
                   Obj.Contabilizado = item.Contabilizado;
                   Obj.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                   Obj.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
//                   Obj.pe_Descripcion = "[" + item.IdPeriodo + "]" + " - "  + item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();
                   Obj.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();

                   Lst.Add(Obj);
               }
               return Lst;
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
       } // haac 13/01/2014



       // haac 24/02/2014
       public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_Asignado(int IdEmpresa, int IdNomina, int IdProceso)
       {         
           List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {

               EntitiesRoles oEnti = new EntitiesRoles();
               //  var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
               var Query = from q in oEnti.vwro_periodo_x_ro_Nomina_TipoLiqui_Asignado
                           where q.IdEmpresa == IdEmpresa && q.IdNomina_Tipo == IdNomina && q.IdNomina_TipoLiqui == IdProceso
                           && q.Tipo=="NO_AsignadoPeriodo"
                           select q;

            

               foreach (var item in Query)
               {
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                   Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   Obj.IdPeriodo = item.IdPeriodo;
                   Obj.Cerrado = item.Cerrado;
                   Obj.Procesado = item.Procesado;
                   Obj.Contabilizado = item.Contabilizado;
                
                   Obj.Tipo = item.Tipo;
                
                   Lst.Add(Obj);
               }
               return Lst;
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
       } // 24/02/2014


       // haac 24/02/2014
       public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_Asignado_x_Empresa(int IdEmpresa)
       {      
           List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {
 
               EntitiesRoles oEnti = new EntitiesRoles();
               //  var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
               var Query = from q in oEnti.vwro_periodo_x_ro_Nomina_TipoLiqui_Asignado
                           where q.IdEmpresa == IdEmpresa 
                           && q.Tipo == "NO_AsignadoPeriodo"
                           select q;

               foreach (var item in Query)
               {
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                   Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   Obj.IdPeriodo = item.IdPeriodo;
                   Obj.Cerrado = item.Cerrado;
                   Obj.Procesado = item.Procesado;
                   Obj.Contabilizado = item.Contabilizado;               
                   Obj.Tipo = item.Tipo;

                   Lst.Add(Obj);
               }
               return Lst;
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
       } // 24/02/2014
       
       
       
       // haac 15/01/2014 

       public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq_x_Periodo(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {         
           List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {

               EntitiesRoles oEnti = new EntitiesRoles();
                var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
              // var Query = from q in oEnti.vwRo_periodo_x_ro_Nomina_TipoLiqui
                           where q.IdEmpresa == IdEmpresa && q.IdNomina_Tipo == IdNomina_Tipo && q.IdNomina_TipoLiqui == IdNomina_TipoLiqui
                           && q.IdPeriodo==IdPeriodo
                           select q;

               foreach (var item in Query)
               {
                   ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                   Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                   Obj.IdPeriodo = item.IdPeriodo;
                   Obj.Cerrado = item.Cerrado;
                   Obj.Procesado = item.Procesado;
                   Obj.Contabilizado = item.Contabilizado;


                   Lst.Add(Obj);
               }
               return Lst;
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
       } // haac 15/01/2014   


       public Boolean GuardarDB(ro_periodo_x_ro_Nomina_TipoLiqui_Info Info)
       {         
           List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
           try
           {

               using (EntitiesRoles Context = new EntitiesRoles())
               {

                   ro_periodo_x_ro_Nomina_TipoLiqui Data = new ro_periodo_x_ro_Nomina_TipoLiqui();

                   Data.IdEmpresa = Info.IdEmpresa;
                   Data.IdNomina_Tipo = Info.IdNomina_Tipo;
                   Data.IdNomina_TipoLiqui = Info.IdNomina_TipoLiqui;
                   Data.IdPeriodo = Info.IdPeriodo;
                   Data.Cerrado = "N";
                   Data.Procesado = "N";
                   Data.Contabilizado = "N";
                  
                  // Data.orden = getId(Info.IdEmpresa);             
                   Context.ro_periodo_x_ro_Nomina_TipoLiqui.Add(Data);
                   Context.SaveChanges();

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

       public Boolean ModificarDB(ro_periodo_x_ro_Nomina_TipoLiqui_Info info)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdPeriodo == info.IdPeriodo
                       && minfo.IdNomina_Tipo==info.IdNomina_Tipo && minfo.IdNomina_TipoLiqui==info.IdNomina_TipoLiqui);

                   //contact.IdEmpresa = info.IdEmpresa;
                   //contact.IdNomina_Tipo = info.IdNomina_Tipo;
                   //contact.IdNomina_TipoLiqui = info.IdNomina_TipoLiqui;
                   //contact.IdPeriodo = info.IdPeriodo;
                   contact.Cerrado = info.Cerrado;
                   contact.Procesado = info.Procesado;
                   contact.Contabilizado = info.Contabilizado;

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

// haac 13/01/2014
       public Boolean ModificarPeriodo_Cerrado_S(int IdEmpresa, int IdNomina_Tipo,int IdNomina_TipoLiqui,int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);
                             
                   contact.Cerrado= "S";              
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
       }// haac 13/01/2014

       // haac 14/01/2014


    
     

       // haac 13/01/2014  
       public Boolean ModificarPeriodo_Reverso_N(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);

                   contact.Cerrado = "N";

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
       }// haac 13/01/2014




       public Boolean Borrar(ro_periodo_x_ro_Nomina_TipoLiqui_Info Info ,ref string mensaje)
       {
           try
           {

               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == Info.IdEmpresa && minfo.IdPeriodo == Info.IdPeriodo
                       && minfo.IdNomina_Tipo== Info.IdNomina_Tipo && minfo.IdNomina_TipoLiqui==Info.IdNomina_TipoLiqui /*&& minfo.Cerrado=="N"*/);

                   if (contact.Cerrado == "S" && contact.IdEmpresa==Info.IdEmpresa && contact.IdNomina_Tipo==Info.IdNomina_Tipo && contact.IdNomina_TipoLiqui==Info.IdNomina_TipoLiqui && contact.IdPeriodo==Info.IdPeriodo)
                   {
                       mensaje = "El periodo " + Info.IdPeriodo + " ya se encuentra cerrado, no se puede eliminar  ";
                       return false;
                   }
                   else
                   {
                       context.ro_periodo_x_ro_Nomina_TipoLiqui.Remove(contact);
                       context.SaveChanges();
                       context.Dispose();
                   }
                 
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

      
       // haac 14/01/2014 
       public ro_periodo_x_ro_Nomina_TipoLiqui_Info ObtenerPeriodoAnterior(int IdEmpresa,int IdPeriodo,int IdNomina_Tipo,int IdNomina_TipoLiqui)
       {
           try
           {
               using (EntitiesRoles entity = new EntitiesRoles())
               {

                   spRo_ObtenerPeriodoAnterior_Result q = entity.spRo_ObtenerPeriodoAnterior(IdEmpresa, IdPeriodo, IdNomina_Tipo, IdNomina_TipoLiqui).First() ;

                   return new ro_periodo_x_ro_Nomina_TipoLiqui_Info() { IdEmpresa =q.IdEmpresa ,IdNomina_Tipo=q.IdNomina_Tipo,IdNomina_TipoLiqui=q.IdNomina_TipoLiqui, IdPeriodo = q.IdPeriodo, Cerrado = q.Cerrado, Procesado= q.Procesado};
               }
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
       } // haac 14/01/2014 

       public ro_periodo_x_ro_Nomina_TipoLiqui_Info ObtenerPeriodoDespues(int IdEmpresa, int IdPeriodo, int IdNomina_Tipo, int IdNomina_TipoLiqui)
       {
           try
           {
               using (EntitiesRoles entity = new EntitiesRoles())
               {

                   spRo_ObtenerPeriodoDespues_Result q = entity.spRo_ObtenerPeriodoDespues(IdEmpresa, IdPeriodo, IdNomina_Tipo, IdNomina_TipoLiqui).First();

                   return new ro_periodo_x_ro_Nomina_TipoLiqui_Info() { IdEmpresa = q.IdEmpresa, IdNomina_Tipo = q.IdNomina_Tipo, IdNomina_TipoLiqui = q.IdNomina_TipoLiqui, IdPeriodo = q.IdPeriodo, Cerrado = q.Cerrado, Procesado = q.Procesado };
               }
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
       } // haac 14/0


       //CJimenez 
       public Boolean ValidarCerrado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);
                   if (contact.Cerrado == "N" && contact.IdEmpresa == IdEmpresa && contact.IdNomina_Tipo == IdNomina_Tipo && contact.IdNomina_TipoLiqui == IdNomina_TipoLiqui && contact.IdPeriodo == IdPeriodo)
                   {
                       return false;
                   }

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
       }//CJimenez  15.01.14 

       public Boolean ValidarContabilizado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);
                   if (contact.Contabilizado == "N" && contact.IdEmpresa == IdEmpresa && contact.IdNomina_Tipo == IdNomina_Tipo && contact.IdNomina_TipoLiqui == IdNomina_TipoLiqui && contact.IdPeriodo == IdPeriodo)
                   {
                       return false;
                   }

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
       }//CJimenez 15.01.14 


       public Boolean ValidarProcesado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);
                   if (contact.Procesado == "N" && contact.IdEmpresa == IdEmpresa && contact.IdNomina_Tipo == IdNomina_Tipo && contact.IdNomina_TipoLiqui == IdNomina_TipoLiqui && contact.IdPeriodo == IdPeriodo)
                   {
                       return false;
                   }

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
           }//CJimenez 15.01.14 
       }

       public int ObtenerPrimeroNoContabilizado(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);
                   if (contact.Contabilizado == "N" && contact.IdEmpresa == IdEmpresa && contact.IdNomina_Tipo == IdNomina_Tipo && contact.IdNomina_TipoLiqui == IdNomina_TipoLiqui && contact.IdPeriodo == IdPeriodo)
                   {
                       return contact.IdPeriodo;
                   }

               }
               return 0;
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
       }//CJimenez 15.01.14 

       public Boolean ActualizarContabilizacion(int IdEmpresa, int IdNomina_Tipo, int IdNomina_TipoLiqui, int IdPeriodo)
       {
           try
           {
               using (EntitiesRoles context = new EntitiesRoles())
               {
                   var contact = context.ro_periodo_x_ro_Nomina_TipoLiqui.First(minfo => minfo.IdEmpresa == IdEmpresa && minfo.IdPeriodo == IdPeriodo
                       && minfo.IdNomina_Tipo == IdNomina_Tipo && minfo.IdNomina_TipoLiqui == IdNomina_TipoLiqui);

                   contact.Contabilizado = "S";
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

       }//CJimenez 15.01.14 


       public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoAnterior(int idEmpresa,  int idNominaTipo, int idNominaTipoLiqui,int idPeriodo)
       {
           try
           {
               ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_periodo_x_ro_Nomina_TipoLiqui
                                where a.IdEmpresa==idEmpresa && a.IdNomina_Tipo==idNominaTipo && a.IdNomina_TipoLiqui == idNominaTipoLiqui
                                && a.IdPeriodo<idPeriodo
                                orderby a.IdPeriodo descending
                                select a).Take(1);

                   foreach (var item in datos)
                   {
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       info.IdPeriodo = item.IdPeriodo;
                       info.Cerrado = item.Cerrado;
                       info.Procesado = item.Procesado;
                       info.Contabilizado = item.Contabilizado;
                   }
               }

               return info;
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

       public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoDespues(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, int idPeriodo)
       {
           try
           {
               ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_periodo_x_ro_Nomina_TipoLiqui
                                where a.IdEmpresa == idEmpresa && a.IdNomina_Tipo == idNominaTipo && a.IdNomina_TipoLiqui == idNominaTipoLiqui
                                && a.IdPeriodo > idPeriodo
                                orderby a.IdPeriodo ascending
                                select a).Take(1);

                   foreach (var item in datos)
                   {
                       info.IdEmpresa = item.IdEmpresa;
                       info.IdNomina_Tipo = item.IdNomina_Tipo;
                       info.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       info.IdPeriodo = item.IdPeriodo;
                       info.Cerrado = item.Cerrado;
                       info.Procesado = item.Procesado;
                       info.Contabilizado = item.Contabilizado;
                   }
               }

               return info;
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

       public Boolean GetExiste(ro_periodo_x_ro_Nomina_TipoLiqui_Info info, ref string msg)
       {
           try
           {
               Boolean valorRetornar = false;
               using (EntitiesRoles db = new EntitiesRoles())
               {
                   int cont = (from a in db.ro_periodo_x_ro_Nomina_TipoLiqui
                               where a.IdEmpresa == info.IdEmpresa && a.IdNomina_Tipo == info.IdNomina_Tipo
                               && a.IdNomina_TipoLiqui == info.IdNomina_TipoLiqui && a.IdPeriodo==info.IdPeriodo
                               select a).Count();

                   if (cont > 0) { valorRetornar = true; }
                   else { valorRetornar = false; }
               }
               return valorRetornar;
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


       public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoPeriodoActual(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, ref string msg)
       {
           try
           {
              

               ro_periodo_x_ro_Nomina_TipoLiqui_Info info = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var datos = (from a in db.ro_periodo_x_ro_Nomina_TipoLiqui
                                where a.IdEmpresa == idEmpresa && a.IdNomina_Tipo == idNominaTipo
                                && a.IdNomina_TipoLiqui == idNominaTipoLiqui
                                && a.Cerrado == "N"
                                orderby a.IdPeriodo ascending
                                select a).FirstOrDefault();

                    if (datos!=null){
                        info.IdEmpresa = datos.IdEmpresa;
                        info.IdNomina_Tipo = datos.IdNomina_Tipo;
                        info.IdNomina_TipoLiqui = datos.IdNomina_TipoLiqui;
                        info.IdPeriodo = datos.IdPeriodo;
                        info.Cerrado = datos.Cerrado;
                        info.Procesado = datos.Procesado;
                        info.Contabilizado = datos.Contabilizado;
                    }
               }
               return info;
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


      public ro_periodo_x_ro_Nomina_TipoLiqui_Info GetInfoConsultaPeriodoPorFecha(int idEmpresa, int idNominaTipo, int idNominaTipoLiqui, DateTime fecha, ref string msg)
       {
           try
           {
               ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();

               using (EntitiesRoles db = new EntitiesRoles())
               {
                   var item = (from a in db.vwRo_periodo_x_ro_Nomina_TipoLiqui
                               where a.IdEmpresa == idEmpresa && a.IdNomina_Tipo==idNominaTipo
                               && a.IdNomina_TipoLiqui==idNominaTipoLiqui
                               && ((fecha>=a.pe_FechaIni) && (fecha<=a.pe_FechaFin))
                               select a).FirstOrDefault();

                   if (item != null)
                   {
                       Obj.IdEmpresa = item.IdEmpresa;
                       Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                       Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                       Obj.IdPeriodo = item.IdPeriodo;
                       Obj.Cerrado = item.Cerrado;
                       Obj.Procesado = item.Procesado;
                       Obj.Contabilizado = item.Contabilizado;
                       Obj.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                       Obj.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
                       Obj.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();

                   }

               }
               return Obj;
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






      public List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> ConsultaPerNomTipLiq(int IdEmpresa)
      {
          List<ro_periodo_x_ro_Nomina_TipoLiqui_Info> Lst = new List<ro_periodo_x_ro_Nomina_TipoLiqui_Info>();
          try
          {

              EntitiesRoles oEnti = new EntitiesRoles();
              //  var Query = from q in oEnti.ro_periodo_x_ro_Nomina_TipoLiqui
              var Query = from q in oEnti.vwRo_periodo_x_ro_Nomina_TipoLiqui
                          where q.IdEmpresa == IdEmpresa && q.Cerrado == "N" && q.Contabilizado=="N"
                          select q;

              foreach (var item in Query)
              {
                  ro_periodo_x_ro_Nomina_TipoLiqui_Info Obj = new ro_periodo_x_ro_Nomina_TipoLiqui_Info();
                  Obj.IdEmpresa = item.IdEmpresa;
                  Obj.IdNomina_Tipo = item.IdNomina_Tipo;
                  Obj.IdNomina_TipoLiqui = item.IdNomina_TipoLiqui;
                  Obj.IdPeriodo = item.IdPeriodo;
                  Obj.Cerrado = item.Cerrado;
                  Obj.Procesado = item.Procesado;
                  Obj.Contabilizado = item.Contabilizado;
                  Obj.pe_FechaIni = Convert.ToDateTime(item.pe_FechaIni.ToShortDateString());
                  Obj.pe_FechaFin = Convert.ToDateTime(item.pe_FechaFin.ToShortDateString());
                  //                   Obj.pe_Descripcion = "[" + item.IdPeriodo + "]" + " - "  + item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();
                  Obj.pe_Descripcion = item.pe_FechaIni.ToShortDateString() + " - " + item.pe_FechaFin.ToShortDateString();

                  Lst.Add(Obj);
              }
              return Lst;
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
