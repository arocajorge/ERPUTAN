using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion;
using Core.Erp.Data.General;
using Core.Erp.Info.General;



namespace Core.Erp.Data.Facturacion
{
   public class fa_motivo_venta_Data
    {
       string mensaje = "";
       
       public int GetId_Motivo_Venta(int IdEmpresa)
       {
           int Id = 0;
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   int select = (from q in context.fa_motivo_venta where q.IdEmpresa == IdEmpresa select q ).Count();

                   if (select == 0)
                       Id = 1;
                   else
                   {
                       var selec = (from q in context.fa_motivo_venta where q.IdEmpresa == IdEmpresa select q.IdMotivo_Vta).Max();
                       Id = Convert.ToInt32(select.ToString()) + 1;
                   }
               }
               return Id;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
       }

       public List<fa_motivo_venta_Info> Get_List_fa_motivo_venta(int IdEmpresa)
       {
           try
           {
               List<fa_motivo_venta_Info> Lst = new List<fa_motivo_venta_Info>();

               EntitiesFacturacion oEnti = new EntitiesFacturacion();
               var Query = from q in oEnti.fa_motivo_venta
                           where q.IdEmpresa==IdEmpresa
                           select q;

               
               foreach (var item in Query)
               {
                   fa_motivo_venta_Info Obj = new fa_motivo_venta_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.IdMotivo_Vta = item.IdMotivo_Vta;
                   Obj.codMotivo_Vta = item.codMotivo_Vta;
                   Obj.Estado = item.Estado;
                   Obj.descripcion_motivo_vta = item.descripcion_motivo_vta;
                   Obj.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                   Obj.FechaCreacion = Convert.ToDateTime(item.FechaCreacion);
                   Obj.UsuarioModificacion = item.UsuarioModificacion;
                   Obj.UsuarioCreacion = item.UsuarioCreacion;
                   Obj.FechaAnulacion = Convert.ToDateTime(item.FechaAnulacion);
                   Obj.UsuarioAnulacion = item.UsuarioAnulacion;
                   Obj.MotivoAnulacion = item.MotivoAnulacion;                  
                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               mensaje = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               throw new Exception(ex.ToString());
           }
       }

       public Boolean Get_List_fa_motivo_venta_Existe(fa_motivo_venta_Info Info, ref string mensaje)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var select = from q in context.fa_motivo_venta
                                where q.codMotivo_Vta == Info.codMotivo_Vta
                                select q;

                   if (select.Count() > 0)
                       return false;
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
                string MensajeError = string.Empty;
                tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                MensajeError = ex.ToString();
                oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
                throw new Exception(ex.ToString());
            }
       }

       public Boolean GrabarDB(fa_motivo_venta_Info Info, ref int idMotivo, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var lst = from q in context.fa_motivo_venta
                             where q.IdEmpresa == Info.IdEmpresa
                             && q.IdMotivo_Vta == Info.IdMotivo_Vta
                             select q;

                   if (lst.Count()==0)
                   {
                       fa_motivo_venta address = new fa_motivo_venta();
                       idMotivo = GetId_Motivo_Venta(Info.IdEmpresa);
                       address.IdEmpresa = Info.IdEmpresa;
                       address.IdMotivo_Vta = idMotivo;
                       address.codMotivo_Vta = string.IsNullOrEmpty(Info.codMotivo_Vta) ? Convert.ToString(idMotivo) : Info.codMotivo_Vta.Trim();
                       address.descripcion_motivo_vta = Info.descripcion_motivo_vta.Trim();
                       address.Estado = Info.Estado;
                       address.FechaCreacion = DateTime.Now;
                       address.UsuarioCreacion = Info.UsuarioCreacion;
                       context.fa_motivo_venta.Add(address);
                       context.SaveChanges();
                       msg = "El nuevo registro: " + address.IdMotivo_Vta.ToString() + " se grabo satisfactoriamente";
                   }                   
               }
               return true;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               msg = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
               msg = "Se ha producido el siguiente error: " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean ModificarDB(fa_motivo_venta_Info Info, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var motivo = context.fa_motivo_venta.FirstOrDefault(v => v.IdMotivo_Vta == Info.IdMotivo_Vta);
                   if (motivo != null)
                   {
                       motivo.codMotivo_Vta = Info.codMotivo_Vta;
                       motivo.descripcion_motivo_vta = Info.descripcion_motivo_vta;
                       motivo.Estado = Info.Estado;
                       motivo.FechaModificacion = DateTime.Now;
                       motivo.UsuarioModificacion = Info.UsuarioModificacion;
                       context.SaveChanges();
                       msg = "El registro se modifico: " + Info.IdMotivo_Vta.ToString() + " se modifico con exito.";
                   }
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               msg = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
               msg = "Se ha producido el siguiente error: " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }

       public Boolean AnularDB(fa_motivo_venta_Info Info, ref string msg)
       {
           try
           {
               using (EntitiesFacturacion context = new EntitiesFacturacion())
               {
                   var motivo = context.fa_motivo_venta.FirstOrDefault(v => v.IdMotivo_Vta == Info.IdMotivo_Vta);
                   if (motivo != null)
                   {
                       motivo.Estado = "I";
                       motivo.UsuarioAnulacion = Info.UsuarioAnulacion;
                       motivo.FechaAnulacion = DateTime.Now;
                       motivo.MotivoAnulacion = Info.MotivoAnulacion;
                       context.SaveChanges();
                       msg = "Se ha eliminado el registro: " + Info.IdMotivo_Vta.ToString() + " con exito";
                   }
                   return true;
               }
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               msg = ex.ToString();
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref msg);
               msg = "Se ha producido el siguiente error: " + ex.Message;
               throw new Exception(ex.ToString());
           }
       }
    }
}
