using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.General
{
   public  class tb_sis_Documento_Tipo_Talonario_Data
    {
       string mensajeErrorLog = "";
       string mensaje = "";

       public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_DocTipoxSecTalonario(int IdEmpresa)
       {
           try
           {
               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var q = from A in OEGeneral.vwGe_tb_sis_Documento_Tipo_Talonario
                       where A.IdEmpresa == IdEmpresa
                       select A;
               foreach (var item in q)
               {
                   tb_sis_Documento_Tipo_Talonario_Info info = new tb_sis_Documento_Tipo_Talonario_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.CodDocumentoTipo = item.CodDocumentoTipo;
                   info.PuntoEmision = item.PuntoEmision;
                   info.NumDocumento = item.NumDocumento;
                   info.Establecimiento = item.Establecimiento;
                   info.FechaCaducidad = item.FechaCaducidad;
                   info.Usado = Convert.ToBoolean(item.Usado);
                   info.Estado = item.Estado;
                   info.IdSucursal = item.IdSucursal;
                   info.NumAutorizacion = item.NumAutorizacion;
                   info.NombreSucursal = item.Su_Descripcion;
                   info.NombreEmpresa = item.em_nombre;
                   info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                   
                   lm.Add(info);
               }
               return lm;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

      

       public List<tb_sis_Documento_Tipo_Talonario_Info> Get_List_Docu_Tipo_Talonario_x_TipoDocu
           (int IdEmpresa,string TipoDocu,bool Es_Documento_Electronico)
       {
           try
           {
               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var q = from A in OEGeneral.vwGe_tb_sis_Documento_Tipo_Talonario
                       where A.IdEmpresa == IdEmpresa && A.CodDocumentoTipo == TipoDocu
                       && A.es_Documento_Electronico == Es_Documento_Electronico
                       select A;
               foreach (var item in q)
               {
                   tb_sis_Documento_Tipo_Talonario_Info info = new tb_sis_Documento_Tipo_Talonario_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.CodDocumentoTipo = item.CodDocumentoTipo;
                   info.PuntoEmision = item.PuntoEmision;
                   info.NumDocumento = item.NumDocumento;
                   info.Establecimiento = item.Establecimiento;
                   info.FechaCaducidad = item.FechaCaducidad;
                   info.Usado = Convert.ToBoolean(item.Usado);
                   info.Estado = item.Estado;
                   info.IdSucursal = item.IdSucursal;
                   info.NumAutorizacion = item.NumAutorizacion;
                   info.NombreSucursal = item.Su_Descripcion;
                   info.NombreEmpresa = item.em_nombre;
                   info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);

                   lm.Add(info);
               }
               return lm;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento
           (int IdEmpresa, string puntoemision, string establecimiento, string tipodoc)
       {
           try
           {
               tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                        where A.IdEmpresa == IdEmpresa
                        && A.PuntoEmision == puntoemision
                        && A.CodDocumentoTipo == tipodoc
                        && A.Establecimiento == establecimiento
                        && A.Estado == "A"
                        select A.NumDocumento).Max();

               string UltRegistro = "";

               if (q == null)
               {
                   UltRegistro = "000000000";
               }
               else
               {
                   UltRegistro = q.ToString();
               }

               var querry = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                            where A.IdEmpresa == IdEmpresa
                            && A.PuntoEmision == puntoemision
                            && A.CodDocumentoTipo == tipodoc
                            && A.Establecimiento == establecimiento
                            && A.NumDocumento == UltRegistro
                            select A;

               if (querry != null)
               {
                   foreach (var item in querry)
                   {
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdSucursal = item.IdSucursal;
                       Info.CodDocumentoTipo = item.CodDocumentoTipo;
                       Info.Establecimiento = item.Establecimiento;
                       Info.Estado = item.Estado;
                       Info.FechaCaducidad = item.FechaCaducidad;
                       Info.NumAutorizacion = item.NumAutorizacion;
                       Info.NumDocumento = item.NumDocumento;
                       Info.PuntoEmision = item.PuntoEmision;
                       Info.Usado = item.Usado;
                       Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                   }
               }
               else
               {
                   Info.IdEmpresa = IdEmpresa;
                   Info.IdSucursal = 0;
                   Info.CodDocumentoTipo = tipodoc;
                   Info.Establecimiento = establecimiento;
                   Info.Estado ="A";
                   Info.FechaCaducidad = DateTime.Now;
                   Info.NumAutorizacion = "0000000000000";
                   Info.NumDocumento = "000000000";
                   Info.PuntoEmision = puntoemision;
                   Info.Usado = false;
               }

               return Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }



       public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Documento_Tipo_Talonario
           (int IdEmpresa, string tipodoc, string establecimiento, string puntoemision, string NumDocumento)
       {
           try
           {
               tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();

               
               var querry = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                            where A.IdEmpresa == IdEmpresa
                            && A.Establecimiento == establecimiento
                            && A.PuntoEmision == puntoemision
                            && A.CodDocumentoTipo == tipodoc
                            && A.NumDocumento == NumDocumento
                            select A;

               if (querry != null)
               {
                   foreach (var item in querry)
                   {
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdSucursal = item.IdSucursal;
                       Info.CodDocumentoTipo = item.CodDocumentoTipo;
                       Info.Establecimiento = item.Establecimiento;
                       Info.Estado = item.Estado;
                       Info.FechaCaducidad = item.FechaCaducidad;
                       Info.NumAutorizacion = item.NumAutorizacion;
                       Info.NumDocumento = item.NumDocumento;
                       Info.PuntoEmision = item.PuntoEmision;
                       Info.Usado = item.Usado;
                       Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                   }
               }
               
               return Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }

       public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Ult_Documento_no_usado
           (int IdEmpresa, string puntoemision, string establecimiento, string tipodoc,bool Es_Documento_Electronico)
       {
           try
           {
               tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                       where A.IdEmpresa == IdEmpresa
                       //&& A.PuntoEmision == puntoemision 
                       && A.CodDocumentoTipo == tipodoc 
                       && A.Establecimiento == establecimiento 
                       && A.es_Documento_Electronico==Es_Documento_Electronico
                       &&  A.Usado==false
                       && A.Estado=="A"
                      select A.NumDocumento).Max();
               if (q!=null)
               {
                   string UltRegistro = q.ToString();
                   var querry = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                                where A.IdEmpresa == IdEmpresa
                                    //&& A.PuntoEmision == puntoemision 
                                && A.CodDocumentoTipo == tipodoc
                                && A.Establecimiento == establecimiento
                                && A.Usado == false
                                && A.NumDocumento == UltRegistro
                                select A;

                   foreach (var item in querry)
                   {
                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdSucursal = item.IdSucursal;
                       Info.CodDocumentoTipo = item.CodDocumentoTipo;
                       Info.Establecimiento = item.Establecimiento;
                       Info.Estado = item.Estado;
                       Info.FechaCaducidad = item.FechaCaducidad;
                       Info.NumAutorizacion = item.NumAutorizacion;
                       Info.NumDocumento = item.NumDocumento;
                       Info.PuntoEmision = item.PuntoEmision;
                       Info.Usado = item.Usado;
                       Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                   }

               }     
               return Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);               
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }


       public Boolean Verificar_NumTalonario(int IdEmpresa, string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, ref string mensaje)
       {
           try
           {
               Boolean Existe;
               mensaje = "";
               Existe = false;

               EntitiesGeneral OEGeneral = new EntitiesGeneral();
             
               var consulta = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                              where A.IdEmpresa == IdEmpresa
                              && A.PuntoEmision == puntoEmision
                              && A.CodDocumentoTipo == codDocuTipo
                              && A.Establecimiento == establecimiento
                              && A.NumDocumento == numDocumento

                              select A;

                   foreach (var item in consulta)
                   {
                      
                       Existe = true;
                   }

                   if (Existe==false)
                  {
                      mensaje = "El número de Documento : " + establecimiento + " - " + puntoEmision + " - " + numDocumento + ". No existe en la Base de Datos ";
                  
                  }
              
               return Existe;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
              
       public tb_sis_Documento_Tipo_Talonario_Info Get_Info_Primer_Documento_no_usado(int IdEmpresa, string establecimiento, string puntoemision, string tipodoc,bool Es_Documento_Electronico, bool Considerar_punto_emision)
       {
           try
           {

               tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();


               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               string q;
               IQueryable<tb_sis_Documento_Tipo_Talonario> querry;

               if (!Considerar_punto_emision)
               {
                   q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                        where A.IdEmpresa == IdEmpresa
                            //&& A.PuntoEmision == puntoemision
                        && A.CodDocumentoTipo == tipodoc
                        && A.Establecimiento == establecimiento
                        && A.es_Documento_Electronico == Es_Documento_Electronico
                        && A.Usado == false
                        && A.Estado == "A"

                        select A.NumDocumento).Min();
                   if (q != null)
                   {
                       string UltRegistro = q.ToString();


                       querry = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                                where A.IdEmpresa == IdEmpresa
                                    //&& A.PuntoEmision == puntoemision
                                && A.CodDocumentoTipo == tipodoc
                                && A.Establecimiento == establecimiento
                                && A.Usado == false
                                && A.NumDocumento == UltRegistro
                                select A;

                       foreach (var item in querry)
                       {
                           Info.IdEmpresa = item.IdEmpresa;
                           Info.IdSucursal = item.IdSucursal;
                           Info.CodDocumentoTipo = item.CodDocumentoTipo;
                           Info.Establecimiento = item.Establecimiento;
                           Info.Estado = item.Estado;
                           Info.FechaCaducidad = item.FechaCaducidad;
                           Info.NumAutorizacion = item.NumAutorizacion;
                           Info.NumDocumento = item.NumDocumento;
                           Info.PuntoEmision = item.PuntoEmision;
                           Info.Usado = item.Usado;
                           Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                       }
                   }
               }
                   else
                   {
                    q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                        where A.IdEmpresa == IdEmpresa
                        && A.PuntoEmision == puntoemision
                        && A.CodDocumentoTipo == tipodoc
                        && A.Establecimiento == establecimiento
                        && A.es_Documento_Electronico == Es_Documento_Electronico
                        && A.Usado == false
                        && A.Estado == "A"

                        select A.NumDocumento).Min();
                   if (q != null)
                   {
                       string UltRegistro = q.ToString();


                       querry = from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                                where A.IdEmpresa == IdEmpresa
                                && A.PuntoEmision == puntoemision
                                && A.CodDocumentoTipo == tipodoc
                                && A.Establecimiento == establecimiento
                                && A.Usado == false
                                && A.NumDocumento == UltRegistro
                                select A;

                       foreach (var item in querry)
                       {
                           Info.IdEmpresa = item.IdEmpresa;
                           Info.IdSucursal = item.IdSucursal;
                           Info.CodDocumentoTipo = item.CodDocumentoTipo;
                           Info.Establecimiento = item.Establecimiento;
                           Info.Estado = item.Estado;
                           Info.FechaCaducidad = item.FechaCaducidad;
                           Info.NumAutorizacion = item.NumAutorizacion;
                           Info.NumDocumento = item.NumDocumento;
                           Info.PuntoEmision = item.PuntoEmision;
                           Info.Usado = item.Usado;
                           Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                       }
                   }

               }


                   
               
               return Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Guardar(Info.General.tb_sis_Documento_Tipo_Talonario_Info Info)
       {
           
           try
           {
               using (EntitiesGeneral Context = new EntitiesGeneral())
               {
                   var lst = from q in Context.tb_sis_Documento_Tipo_Talonario
                             where q.IdEmpresa == Info.IdEmpresa
                             && q.CodDocumentoTipo == Info.CodDocumentoTipo
                             && q.Establecimiento == Info.Establecimiento
                             && q.PuntoEmision == Info.PuntoEmision
                             && q.NumDocumento == Info.NumDocumento
                             select q;

                   if (lst.Count()==0)
                   {
                       var Address = new tb_sis_Documento_Tipo_Talonario();
                       Address.IdEmpresa = Info.IdEmpresa;
                       Address.CodDocumentoTipo = Info.CodDocumentoTipo;
                       Address.Establecimiento = Info.Establecimiento;
                       Address.PuntoEmision = Info.PuntoEmision;
                       Address.NumDocumento = Info.NumDocumento;
                       Address.FechaCaducidad = Convert.ToDateTime(Info.FechaCaducidad);
                       Address.Usado = Info.Usado;
                       Address.Estado = "A";
                       Address.IdSucursal = Info.IdSucursal;
                       Address.NumAutorizacion = Info.NumAutorizacion;
                       Address.es_Documento_Electronico = Info.es_Documento_electronico;
                       Context.tb_sis_Documento_Tipo_Talonario.Add(Address);
                       Context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Modificar(Info.General.tb_sis_Documento_Tipo_Talonario_Info Info)
       {
           try
           {

               using (EntitiesGeneral Context = new EntitiesGeneral())
               {

                   var Address = Context.tb_sis_Documento_Tipo_Talonario.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.CodDocumentoTipo == Info.CodDocumentoTipo && cot.IdSucursal == Info.IdSucursal && cot.NumDocumento == Info.NumDocumento );
                   if (Address != null)
                   {
                       Address.CodDocumentoTipo = Info.CodDocumentoTipo;
                       Address.Establecimiento = Info.Establecimiento;
                       Address.PuntoEmision = Info.PuntoEmision;
                       Address.NumDocumento = Info.NumDocumento;
                       Address.FechaCaducidad = Convert.ToDateTime(Info.FechaCaducidad);
                       Address.Usado = Info.Usado;
                       Address.Estado = Info.Estado;
                       Address.NumAutorizacion = Info.NumAutorizacion;
                       Address.es_Documento_Electronico = Info.es_Documento_electronico;
                       Context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Modificar_Estado_Usado(Info.General.tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensajeError)
       {
           try
           {

               using (EntitiesGeneral Context = new EntitiesGeneral())
               {
                   var Address = Context.tb_sis_Documento_Tipo_Talonario.FirstOrDefault(cot => cot.IdEmpresa == Info.IdEmpresa && cot.CodDocumentoTipo == Info.CodDocumentoTipo && cot.Establecimiento == Info.Establecimiento && cot.PuntoEmision==Info.PuntoEmision && cot.NumDocumento == Info.NumDocumento);
                   if (Address != null)
                   {
                       Address.Usado = true;
                       Context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               mensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Documento_talonario_esta_Usado(tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensajeError, ref string mensajeDocumentoDupli)
       {
           try
           {
               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var q = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                        where A.IdEmpresa == Info.IdEmpresa
                        && A.PuntoEmision == Info.PuntoEmision
                        && A.CodDocumentoTipo == Info.CodDocumentoTipo
                        && A.Establecimiento == Info.Establecimiento
                        && A.NumDocumento == Info.NumDocumento
                        && A.Usado == true
                        select A);

               if (q.Count() != 0)
               {
                   mensajeDocumentoDupli = "El numero de documento ya se encuentra en uso";
                   return true;
               }
               else {
                   mensajeDocumentoDupli = "";
                   return false;
               }

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               mensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public tb_sis_Documento_Tipo_Talonario_Info Verificar_DocumentoElectronico(int IdEmpresa, string codDocuTipo, string establecimiento, string puntoEmision, string numDocumento, tb_sis_Documento_Tipo_Talonario_Info Info, ref string mensaje)
       {
           try
           {
               
               EntitiesGeneral OEGeneral = new EntitiesGeneral();
                var consulta = from A in OEGeneral.vwGe_tb_sis_Documento_Tipo_Talonario
                              where A.PuntoEmision == puntoEmision
                              && A.CodDocumentoTipo == codDocuTipo
                              && A.Establecimiento == establecimiento
                              && A.NumDocumento == numDocumento
                              && A.IdEmpresa == IdEmpresa
                              select A;

                foreach (var item in consulta)
                {
                    Info.Establecimiento = item.Establecimiento;
                    Info.PuntoEmision = item.PuntoEmision;
                    Info.NumDocumento = item.NumDocumento;
                   Info.es_Documento_electronico = (bool)item.es_Documento_Electronico;
                }
                return Info;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public List< tb_sis_Documento_Tipo_Talonario_Info> Get_List_Doc_disponible(int IdEmpresa, string puntoemision, string establecimiento, string tipodoc, bool Es_Documento_Electronico)
       {

           try
           {

               List<tb_sis_Documento_Tipo_Talonario_Info> lm = new List<tb_sis_Documento_Tipo_Talonario_Info>();

               EntitiesGeneral OEGeneral = new EntitiesGeneral();
               var querry = (from A in OEGeneral.tb_sis_Documento_Tipo_Talonario
                        where A.IdEmpresa == IdEmpresa
                        && A.CodDocumentoTipo == tipodoc
                        && A.Establecimiento == establecimiento
                        && A.PuntoEmision==puntoemision
                        && A.es_Documento_Electronico == Es_Documento_Electronico
                        && A.Usado == false
                        select A);
               
                   foreach (var item in querry)
                   {               tb_sis_Documento_Tipo_Talonario_Info Info = new tb_sis_Documento_Tipo_Talonario_Info();

                       Info.IdEmpresa = item.IdEmpresa;
                       Info.IdSucursal = item.IdSucursal;
                       Info.CodDocumentoTipo = item.CodDocumentoTipo;
                       Info.Establecimiento = item.Establecimiento;
                       Info.Estado = item.Estado;
                       Info.FechaCaducidad = item.FechaCaducidad;
                       Info.NumAutorizacion = item.NumAutorizacion;
                       Info.NumDocumento = item.NumDocumento;
                       Info.PuntoEmision = item.PuntoEmision;
                       Info.Usado = item.Usado;
                       Info.es_Documento_electronico = Convert.ToBoolean(item.es_Documento_Electronico);
                       lm.Add(Info);
                   }
               
               return  lm;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Modificar_Estado_Usado(int IdEmpresa, string CodDocumentoTipo, string Establecimiento, string PuntoEmision,string NumDocumento, ref string mensajeError)
       {
           try
           {

               using (EntitiesGeneral Context = new EntitiesGeneral())
               {
                   var Address = Context.tb_sis_Documento_Tipo_Talonario.FirstOrDefault(cot => cot.IdEmpresa == IdEmpresa && cot.CodDocumentoTipo == CodDocumentoTipo && cot.Establecimiento == Establecimiento && cot.PuntoEmision == PuntoEmision && cot.NumDocumento == NumDocumento);
                   if (Address != null)
                   {
                       Address.Usado = true;
                       Context.SaveChanges();
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensajeErrorLog);
               mensajeError = ex.ToString() + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


    }
}
