using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Compras
{
   public  class com_parametro_Data
    {

       string mensaje = "";

       public com_parametro_Info Get_Info_parametro(int IdEmpresa)
       {
               try
               {
                   using (EntitiesCompras db = new EntitiesCompras())
                   {
                       com_parametro_Info Obj = db.com_parametro.Where(q => q.IdEmpresa == IdEmpresa).Select(q => new com_parametro_Info
                       {
                           IdEmpresa = q.IdEmpresa,
                           IdEstadoAprobacion_OC = q.IdEstadoAprobacion_OC,
                           IdMovi_inven_tipo_OC = q.IdMovi_inven_tipo_OC,
                           IdEstadoAnulacion_OC = q.IdEstadoAprobacion_OC,
                           IdMovi_inven_tipo_dev_compra = q.IdMovi_inven_tipo_dev_compra,
                           IdEstadoAprobacion_SolCompra = q.IdEstadoAprobacion_SolCompra,
                           IdSucursal_x_Aprob_x_SolComp = q.IdSucursal_x_Aprob_x_SolComp,
                           IdEstado_cierre = q.IdEstado_cierre,

                           UbicacionArchivosPedido = q.UbicacionArchivosPedido,
                           Correo = q.Correo,
                           Contrasenia = q.Contrasenia,
                           Dominio = q.Dominio,
                           PemitirSSL = q.PemitirSSL ?? false,
                           CorreosCopia = q.CorreosCopia,

                           FileUsuario = q.FileUsuario,
                           FileContrasenia = q.FileContrasenia,
                           FileDominio = q.FileDominio,
                           Asunto = q.Asunto,
                           CuerpoCorreo = q.CuerpoCorreo
                       }).FirstOrDefault();

                       return Obj ?? new com_parametro_Info();
                   }
               }
               catch (Exception ex)
               {
                   string arreglo = ToString();
                   tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                   tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                       "", "", "", "", DateTime.Now);
                   oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                   mensaje = ex.ToString();
                   throw new Exception(ex.ToString());
               }
       }

       public List<com_parametro_Info> Get_List_parametro(int IdEmpresa)
       {
           try
           {

               List<com_parametro_Info> list = new List<com_parametro_Info>();
               EntitiesCompras oEnti = new EntitiesCompras();

               com_parametro_Info Obj = new com_parametro_Info();


               var Query = from q in oEnti.com_parametro
                           where q.IdEmpresa == IdEmpresa
                           select q;
               foreach (var item in Query)
               {


                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdEstadoAprobacion_OC = item.IdEstadoAprobacion_OC;
                   Obj.IdMovi_inven_tipo_OC = item.IdMovi_inven_tipo_OC;
                   Obj.IdEstadoAnulacion_OC = item.IdEstadoAnulacion_OC;
                   Obj.IdMovi_inven_tipo_dev_compra = item.IdMovi_inven_tipo_dev_compra;
                   Obj.IdEstadoAprobacion_SolCompra = item.IdEstadoAprobacion_SolCompra;
                   Obj.IdSucursal_x_Aprob_x_SolComp = Convert.ToInt32(item.IdSucursal_x_Aprob_x_SolComp);
                   Obj.IdEstado_cierre = item.IdEstado_cierre;
                   Obj.Asunto = item.Asunto;
                   Obj.CuerpoCorreo = item.CuerpoCorreo;

                   list.Add(Obj);

               }
               return list;

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public Boolean GuardarDB(com_parametro_Info info, ref string msg)
       {
           try
           {

               
               using (EntitiesCompras Context = new EntitiesCompras())
               {
                   var Address = new com_parametro
                   {
                       IdEmpresa = info.IdEmpresa,
                       IdEstadoAprobacion_OC = info.IdEstadoAprobacion_OC,
                       IdMovi_inven_tipo_OC = info.IdMovi_inven_tipo_OC,
                       IdEstadoAnulacion_OC = info.IdEstadoAprobacion_OC,
                       IdMovi_inven_tipo_dev_compra = info.IdMovi_inven_tipo_dev_compra,
                       IdEstadoAprobacion_SolCompra = info.IdEstadoAprobacion_SolCompra,
                       IdSucursal_x_Aprob_x_SolComp = info.IdSucursal_x_Aprob_x_SolComp,
                       IdEstado_cierre = info.IdEstado_cierre,

                       UbicacionArchivosPedido = info.UbicacionArchivosPedido,
                       Correo = info.Correo,
                       Contrasenia = info.Contrasenia,
                       Dominio = info.Dominio,
                       PemitirSSL = info.PemitirSSL,
                       CorreosCopia = info.CorreosCopia,

                       FileUsuario = info.FileUsuario,
                       FileContrasenia = info.FileContrasenia,
                       FileDominio = info.FileDominio,
                       CuerpoCorreo = info.CuerpoCorreo,
                       Asunto = info.Asunto
                   };
                   Context.com_parametro.Add(Address);
                   Context.SaveChanges();
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
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(com_parametro_Info Info, ref  string msg)
       {
           try
           {

               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_parametro.FirstOrDefault(obj => obj.IdEmpresa == Info.IdEmpresa);
                   if (contact != null)
                   {
                       contact.IdEmpresa = Info.IdEmpresa;
                       contact.IdEstadoAprobacion_OC = Info.IdEstadoAprobacion_OC;
                       contact.IdMovi_inven_tipo_OC = Info.IdMovi_inven_tipo_OC;
                       contact.IdEstadoAnulacion_OC = Info.IdEstadoAnulacion_OC;
                       contact.IdMovi_inven_tipo_dev_compra = Info.IdMovi_inven_tipo_dev_compra;
                       contact.IdEstadoAprobacion_SolCompra = Info.IdEstadoAprobacion_SolCompra;
                       contact.IdSucursal_x_Aprob_x_SolComp = Info.IdSucursal_x_Aprob_x_SolComp;
                       contact.IdEstado_cierre = Info.IdEstado_cierre;

                       contact.UbicacionArchivosPedido = Info.UbicacionArchivosPedido;
                       contact.Correo = Info.Correo;
                       contact.Contrasenia = Info.Contrasenia;
                       contact.Dominio = Info.Dominio;
                       contact.PemitirSSL = Info.PemitirSSL;
                       contact.CorreosCopia = Info.CorreosCopia;
                       contact.FileUsuario = Info.FileUsuario;
                       contact.FileContrasenia = Info.FileContrasenia;
                       contact.FileDominio = Info.FileDominio;
                       contact.Asunto = Info.Asunto;

                       context.SaveChanges();
                       msg = "Se ha procedido a modificar el registro exitosamente";
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
               mensaje = ex.ToString();

               msg = "Se ha producido el siguiente error: " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public com_parametro_Data()
       {

       }
    }
}
