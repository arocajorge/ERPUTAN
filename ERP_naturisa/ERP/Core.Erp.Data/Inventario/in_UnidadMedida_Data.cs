using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Inventario;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.Inventario
{
   public  class in_UnidadMedida_Data
    {
       in_UnidadMedida_Info InfoUniMe = new in_UnidadMedida_Info();
       string mensaje = "";

       public List<in_UnidadMedida_Info> Get_list_UnidadMedida()
       {
           try
           {
               List<in_UnidadMedida_Info> lM = new List<in_UnidadMedida_Info>();
               EntitiesInventario OECbtecble_Info = new EntitiesInventario();
               
               var selectCbtecble = from C in OECbtecble_Info.in_UnidadMedida
                                    select C;

               foreach (var item in selectCbtecble)
               {
                   in_UnidadMedida_Info prd = new in_UnidadMedida_Info();
                   prd.IdUnidadMedida = item.IdUnidadMedida;
                   prd.cod_alterno = item.cod_alterno;
                   prd.Descripcion = item.Descripcion;
                   prd.Usado_en_Movimiento = item.Usado_en_Movimiento;
                   prd.Estado = item.Estado;
                   prd.Descripcion2 = "[" + item.IdUnidadMedida + "] " + item.Descripcion;
                   lM.Add(prd);
               }
               return (lM);

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public List<in_UnidadMedida_Info> Get_list_UnidadMedida_equivalencia(string IdUnidadMedida)
       {
           try
           {
               List<in_UnidadMedida_Info> lM = new List<in_UnidadMedida_Info>();
               EntitiesInventario OECbtecble_Info = new EntitiesInventario();

               var selectCbtecble = from C in OECbtecble_Info.vwin_UnidadMedida_Equivalencia
                                    where C.IdUnidadMedida == IdUnidadMedida
                                    select C;

               foreach (var item in selectCbtecble)
               {
                   in_UnidadMedida_Info prd = new in_UnidadMedida_Info();
                   prd.IdUnidadMedida = item.IdUnidadMedida_equiva;
                   prd.cod_alterno = item.cod_alterno;
                   prd.Descripcion = item.Descripcion;
                   prd.Descripcion2 = "[" + item.IdUnidadMedida + "] " + item.Descripcion;
                   lM.Add(prd);
               }
               return (lM);

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public Boolean GrabarDB(in_UnidadMedida_Info prI,ref string IdUnidadMedida, ref string mensaje)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {
                   EntitiesInventario EDB = new EntitiesInventario();

                   var existe = (from per in EDB.in_UnidadMedida
                                 where per.IdUnidadMedida == prI.IdUnidadMedida
                                 select per).ToList().Count();

                   if (existe != 0)
                   {
                       mensaje = "El Codigo ingresado ya existe por favor ingresar uno distinto";
                       return false;
                   }


                   var Q = from per in EDB.in_UnidadMedida
                           where per.IdUnidadMedida == prI.IdUnidadMedida
                           select per;

                   string codigo = "";
    

                   if (Q.ToList().Count == 0)
                   {

                        var address = new in_UnidadMedida();


                        if (prI.IdUnidadMedida == "")
                        { codigo = getIdUnidadMedida();  }
                        else
                        { codigo = prI.IdUnidadMedida; }
                       
                        address.IdUnidadMedida = codigo;

                        if (prI.cod_alterno == "")
                        { prI.cod_alterno = codigo; }

                       address.cod_alterno= prI.cod_alterno;
                       
                       address.Descripcion= prI.Descripcion;
                        address.Usado_en_Movimiento= prI.Usado_en_Movimiento;
                        address.Estado = prI.Estado;

                        context.in_UnidadMedida.Add(address);
                        context.SaveChanges();

                        mensaje = "Grabacion ok..";
                        IdUnidadMedida = codigo;

                   }
                   else
                       return false;
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               mensaje = "Error al Grabar .." + ex.Message;

               throw new Exception(mensaje);
           }
       }

       public Boolean ModificarDB(in_UnidadMedida_Info prI, ref string mensaje)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {

                   var contact = context.in_UnidadMedida.FirstOrDefault(VProdu => VProdu.IdUnidadMedida == prI.IdUnidadMedida);
                   if (contact != null)
                   {
                       if (prI.cod_alterno == "")
                       { prI.cod_alterno = prI.IdUnidadMedida; }

                       contact.cod_alterno = prI.cod_alterno;
                       contact.Descripcion = prI.Descripcion;
                       contact.Usado_en_Movimiento = prI.Usado_en_Movimiento;
                       contact.Estado = prI.Estado;
                       context.SaveChanges();
                       mensaje = "Grabacion ok...";
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               mensaje = "Error al Grabar" + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public Boolean AnularDB(in_UnidadMedida_Info UniInfo, ref  string mensaje)
       {
           try
           {
               using (EntitiesInventario context = new EntitiesInventario())
               {
                   var contact = context.in_UnidadMedida.FirstOrDefault(prod1 => prod1.IdUnidadMedida == UniInfo.IdUnidadMedida);
                   if (contact != null)
                   {
                       contact.Estado = "I"; //cambio el estado de activo por inactivo
                       contact.IdUsuarioUltAnu = UniInfo.IdUsuarioUltAnu;
                       contact.Fecha_UltAnu = DateTime.Now;
                       contact.Fecha_UltMod = DateTime.Now;
                       contact.IdUsuarioUltMod = UniInfo.IdUsuarioUltMod;
                       context.SaveChanges();

                       mensaje = "Anulacion Exitosa..";
                   }
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               mensaje = "Error al Anular:  " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public string getIdUnidadMedida()
       {
           try
           {
               string IdcbteCble;
               EntitiesInventario OECbtecble = new EntitiesInventario();
               OECbtecble = new EntitiesInventario();
               var selectCbtecble = (from CbtCble in OECbtecble.in_UnidadMedida
                                     select CbtCble.IdUnidadMedida).Count();

               IdcbteCble = selectCbtecble.ToString() + "01";
               return "UNI_"+ IdcbteCble.ToString();

           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               return "00000";
           }
       }

       public Boolean Existe_IdUnidadMedida(string IdUnidaMedida)
       {
           try
           {
               decimal Count = 0;
               Boolean Existe = false;

               EntitiesInventario OECbtecble = new EntitiesInventario();


               OECbtecble = new EntitiesInventario();
               var selectCbtecble = (from CbtCble in OECbtecble.in_UnidadMedida
                                     select CbtCble.IdUnidadMedida).Count();

               Count = Convert.ToDecimal(selectCbtecble.ToString());

               if (Count == 0)
               { Existe = false; }
               else
               { Existe = true; }

               return Existe;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString() + " " + ex.Message;
               throw new Exception(mensaje);
           }
       }

       public in_UnidadMedida_Data()
       {
       }
    }
}
