using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Compras
{
   public class com_Motivo_Orden_Compra_Data
    {
       string mensaje = "";

       public List<com_Motivo_Orden_Compra_Info> Get_List_Motivo_Orden_Compra(int IdEmpresa)
        {
            try
            {
                List<com_Motivo_Orden_Compra_Info> Lst = new List<com_Motivo_Orden_Compra_Info>();
                EntitiesCompras oEnti = new EntitiesCompras();

                var Query = from q in oEnti.com_Motivo_Orden_Compra
                            where q.IdEmpresa == IdEmpresa
                            select q;
                foreach (var item in Query)
                {
                    com_Motivo_Orden_Compra_Info Obj = new com_Motivo_Orden_Compra_Info();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.IdMotivo = item.IdMotivo;
                    Obj.Cod_Motivo = item.Cod_Motivo;
                    Obj.Descripcion = item.Descripcion;                   
                    Obj.estado = item.estado;
                    Obj.SEstado = (item.estado == "A") ? "ACTIVO" : "*ANULADO*";
                    Lst.Add(Obj);
                }
                return Lst;
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

       public com_Motivo_Orden_Compra_Info Get_Info_Motivo_Orden_Compra(int IdEmpresa, int idMotivo_oc)
       {

           try
           {
               com_Motivo_Orden_Compra_Info Obj = new com_Motivo_Orden_Compra_Info();

               EntitiesCompras oEnti = new EntitiesCompras();

               var Query = from q in oEnti.com_Motivo_Orden_Compra
                           where q.IdEmpresa == IdEmpresa
                           && q.IdMotivo == idMotivo_oc
                           select q;
               foreach (var item in Query)
               {
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdMotivo = item.IdMotivo;
                   Obj.Cod_Motivo = item.Cod_Motivo;
                   Obj.Descripcion = item.Descripcion;
                   Obj.estado = item.estado;
               }
               return Obj;
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

       public Boolean GuardarDB(com_Motivo_Orden_Compra_Info info,ref int IdMotivo,ref string msg)
       {
           try
           {
               using (EntitiesCompras Context = new EntitiesCompras())
               {
                   var Address = new com_Motivo_Orden_Compra();
                    Address.IdEmpresa = info.IdEmpresa;
                    Address.IdMotivo = info.IdMotivo = GetId(info.IdEmpresa);
                    Address.Cod_Motivo = info.Cod_Motivo;
                    Address.Descripcion = info.Descripcion;
                    Address.estado = info.estado;
                   Context.com_Motivo_Orden_Compra.Add(Address);
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

       public Boolean ModificarDB(com_Motivo_Orden_Compra_Info info,ref string msg)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_Motivo_Orden_Compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdMotivo == info.IdMotivo);

                   if (contact != null)
                   {
                       contact.Descripcion = info.Descripcion;
                       contact.Cod_Motivo = info.Cod_Motivo;
                       contact.estado = info.estado;
                       context.SaveChanges();
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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean AnularDB(com_Motivo_Orden_Compra_Info info,ref string msg)
       {
           try
           {
               using (EntitiesCompras context = new EntitiesCompras())
               {
                   var contact = context.com_Motivo_Orden_Compra.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdMotivo == info.IdMotivo);

                   if (contact != null)
                   {
                       contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                       contact.MotivoAnulacion = info.MotivoAnulacion;
                       contact.FechaHoraAnul = DateTime.Now;
                       contact.estado = "I";
                       context.SaveChanges();
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
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

       public int GetId(int IdEmpresa)
       {
           int Id = 0;
           try
           {
               EntitiesCompras contex = new EntitiesCompras();
               var selecte = contex.com_Motivo_Orden_Compra.Count(q => q.IdEmpresa == IdEmpresa);

               if (selecte == 0)
               {
                   Id = 1;
               }
               else
               {
                   var select_em = (from q in contex.com_Motivo_Orden_Compra
                                    where q.IdEmpresa == IdEmpresa
                                    select q.IdMotivo).Max();
                   Id = Convert.ToInt32(select_em.ToString()) + 1;
               }
               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
    }
}
