using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Caja;

using Core.Erp.Data.General;
using Core.Erp.Info.General;


namespace Core.Erp.Data.Caja
{
   public class caj_Caja_Data
    {
       
       public List<caj_Caja_Info> Get_list_caja(int IdEmpresa, ref string MensajeError)
       {
               List<caj_Caja_Info> lM = new List<caj_Caja_Info>();
               EntitiesCaja db = new EntitiesCaja();
           try
           {
               var select_ = from T in db.vwcaj_caj_Caja 
                             where T.IdEmpresa == IdEmpresa
                             select T;
                         

               foreach (var item in select_)
               {
                    caj_Caja_Info dat = new caj_Caja_Info();
                    dat.IdEmpresa  = item.IdEmpresa;
                    dat.IdCaja= item.IdCaja;
                    dat.ca_Codigo= item.ca_Codigo;
                    dat.ca_Descripcion= item.ca_Descripcion;
                    dat.ca_Descripcion2 = "[" + item.IdCaja + "] " + item.ca_Descripcion;
                    dat.ca_Moneda= item.ca_Moneda;
                    dat.IdCtaCble= item.IdCtaCble;
                    dat.IdUsuario= item.IdUsuario;
                    dat.Fecha_Transac= item.Fecha_Transac;
                    dat.IdUsuarioUltMod= item.IdUsuarioUltMod;
                    dat.Fecha_UltMod= item.Fecha_UltMod;
                    dat.nom_pc= item.nom_pc;
                    dat.ip= item.ip;
                    dat.Estado= item.Estado;
                    dat.IdUsuario_Responsable= item.IdUsuario_Responsable;
                    dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                    dat.Fecha_UltAnu = item.Fecha_UltAnu;
                    dat.MotivoAnu = item.MotivoAnu;
                   dat.N_usuarioResponsable = (item.Nombre!=null)?item.Nombre.Trim():"";
                   dat.IdSucursal = item.IdSucursal;
                   dat.NSucursal = item.Su_Descripcion.Trim();
                   dat.IdMoneda = Convert.ToInt32(item.IdMoneda);
                   dat.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   dat.IdPunto_cargo = item.IdPunto_cargo;
                   lM.Add(dat);
               }
               return (lM);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
      
       public caj_Caja_Info Get_Info_Caja(int IdEmpresa, int IdCaja, ref string MensajeError)
       {
               caj_Caja_Info dat = new caj_Caja_Info();
               EntitiesCaja db = new EntitiesCaja();
           try
           {
               var select_ = from T in db.vwcaj_caj_Caja

                             where T.IdEmpresa == IdEmpresa && T.IdCaja == IdCaja 
                             select T;

               foreach (var item in select_)
               {
                   
                   dat.IdEmpresa = item.IdEmpresa;
                   dat.IdCaja = item.IdCaja;
                   dat.ca_Codigo = item.ca_Codigo;
                   dat.ca_Descripcion = item.ca_Descripcion;
                   dat.ca_Descripcion2 = "[" + item.IdCaja + "] " + item.ca_Descripcion;
                   dat.ca_Moneda = item.ca_Moneda;
                   dat.IdCtaCble = item.IdCtaCble;
                   dat.IdUsuario = item.IdUsuario;
                   dat.Fecha_Transac = item.Fecha_Transac;
                   dat.IdUsuarioUltMod = item.IdUsuarioUltMod;
                   dat.Fecha_UltMod = item.Fecha_UltMod;
                   dat.nom_pc = item.nom_pc;
                   dat.ip = item.ip;
                   dat.Estado = item.Estado;
                   dat.IdUsuario_Responsable = item.IdUsuario_Responsable;
                   dat.IdUsuarioUltAnu = item.IdUsuarioUltAnu;
                   dat.Fecha_UltAnu = item.Fecha_UltAnu;
                   dat.MotivoAnu = item.MotivoAnu;
                   dat.N_usuarioResponsable = (item.Nombre != null) ? item.Nombre.Trim() : "";
                   dat.IdSucursal = item.IdSucursal;
                   dat.NSucursal = item.Su_Descripcion.Trim();
                   dat.IdMoneda = item.IdMoneda;
                   dat.IdPunto_cargo = item.IdPunto_cargo;
                   dat.IdPunto_cargo_grupo = item.IdPunto_cargo_grupo;
                   
               }
               return (dat);
           }
           catch (Exception ex)
           {
               string mensaje = "";
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                    "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public int GetId(int IdEmpresa, ref string MensajeError)
       {
           try
           {
               int Id;
               EntitiesCaja base_ = new EntitiesCaja();

               var q = from C in base_.caj_Caja 
                       where C.IdEmpresa == IdEmpresa
                       select C;
               if (q.ToList().Count == 0)
                   return 1;
               else
               {
                   var select_ = (from CbtCble in base_.caj_Caja 
                                  where CbtCble.IdEmpresa == IdEmpresa
                                  select CbtCble.IdCaja).Max();
                   Id = select_ + 1;
                   return Id;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }

       }

       public Boolean GrabarDB(caj_Caja_Info info, ref int idCaja, ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja context = new EntitiesCaja())
               {
                   EntitiesCaja EDB = new EntitiesCaja();

                   //var contact = caj_Caja.Createcaj_Caja(0,0,"","","","");
                   var address = new caj_Caja();

                   idCaja = GetId(info.IdEmpresa, ref  MensajeError);
                   address.IdEmpresa = info.IdEmpresa;
                   address.IdCaja = idCaja;
                   address.ca_Codigo = (info.ca_Codigo == null || info.ca_Codigo == "") ? address.IdCaja.ToString() : info.ca_Codigo;
                   address.ca_Descripcion = info.ca_Descripcion;
                   address.ca_Moneda = info.ca_Moneda;
                   address.IdCtaCble = info.IdCtaCble;
                   address.IdUsuario = info.IdUsuario;
                   address.Fecha_Transac = info.Fecha_Transac;
                   address.nom_pc = info.nom_pc;
                   address.ip = info.ip;
                   address.Estado = info.Estado;
                   address.IdUsuario_Responsable = info.IdUsuario_Responsable;
                   address.IdSucursal = info.IdSucursal;
                   address.IdMoneda = info.IdMoneda;
                   address.IdPunto_cargo = info.IdPunto_cargo;
                   address.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo;

                   context.caj_Caja.Add(address);
                   context.SaveChanges();
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(caj_Caja_Info info, ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja context = new EntitiesCaja())
               {
                   var contact = context.caj_Caja.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCaja == info.IdCaja );

                   if (contact != null)
                   {

                       contact.ca_Codigo = (info.ca_Codigo == null || info.ca_Codigo == "") ? info.IdCaja.ToString() : info.ca_Codigo;
                       contact.ca_Descripcion = info.ca_Descripcion;
                       contact.ca_Moneda = info.ca_Moneda;
                       contact.IdCtaCble = info.IdCtaCble;
                       contact.Estado = info.Estado;
                       contact.IdUsuario_Responsable = info.IdUsuario_Responsable;
                       contact.Fecha_UltMod = info.Fecha_UltMod;
                       contact.IdUsuarioUltMod = info.IdUsuarioUltMod;
                       contact.IdSucursal = info.IdSucursal;
                       contact.IdMoneda = info.IdMoneda;
                       contact.IdPunto_cargo = info.IdPunto_cargo;
                       contact.IdPunto_cargo_grupo = info.IdPunto_cargo_grupo;
                       context.SaveChanges();
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean AnularDB(caj_Caja_Info info, ref string MensajeError)
       {
           try
           {
               using (EntitiesCaja context = new EntitiesCaja())
               {
                   var contact = context.caj_Caja.FirstOrDefault(minfo => minfo.IdEmpresa == info.IdEmpresa && minfo.IdCaja == info.IdCaja );

                   if (contact != null)
                   {
                       contact.Estado = "I";
                       contact.Fecha_UltAnu = info.Fecha_UltAnu;
                       contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                       contact.MotivoAnu = info.MotivoAnu;

                       context.SaveChanges();
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
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }


       public caj_Caja_Data(){}
    }
}
