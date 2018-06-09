using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Produc_Cirdesus
{
   public class prd_GrupoTrabajo_Data
    {
       string mensaje = "";
       public List<prd_GrupoTrabajo_Info> ObtenerGrupoTrabajoCab(int idempresa)
       {
           try
           {
               EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
               List<prd_GrupoTrabajo_Info> lM = new List<prd_GrupoTrabajo_Info>();
               var select = from C in OEProduccion.prd_GruposTrabajo
                            where C.IdEmpresa == idempresa
                            orderby C.IdGrupoTrabajo ascending
                            select C;
               
               foreach (var item in select)
               {
                   prd_GrupoTrabajo_Info info = new prd_GrupoTrabajo_Info();
                   info.IdEmpresa = idempresa;
                   info.IdSucursal = item.IdSucursal;
                   info.IdGrupoTrabajo = item.IdGrupoTrabajo;
                   info.Descripcion = item.Descripcion;
                   info.Fecha = item.Fecha;
                   info.AreaProduccion = item.AreaProduccion;
                   info.Estado = item.Estado;
                   info.Usuario = item.Usuario;
                   lM.Add(info);
               }
               return lM;
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


       public bool GrabarCabeceraDB(prd_GrupoTrabajo_Info Info)
       {
           try
           {
               using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
               {

                   var address = new prd_GruposTrabajo();

                   address.IdEmpresa = Info.IdEmpresa;
                   address.IdSucursal = Info.IdSucursal;
                   address.IdGrupoTrabajo = getId(Info.IdEmpresa, Info.IdSucursal);
                   address.Descripcion = Info.Descripcion;
                   address.AreaProduccion = Info.AreaProduccion;
                   address.Fecha = Info.Fecha;
                   address.Estado = Info.Estado;
                   address.Usuario = Info.Usuario;
                   context.prd_GruposTrabajo.Add(address);
                   context.SaveChanges();
                   return true;
               }
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

       public bool ModificarDB(prd_GrupoTrabajo_Info Info)
       {
           try
           {
               using (EntitiesProduccion_Cidersus context = new EntitiesProduccion_Cidersus())
               {

                   var address = new prd_GruposTrabajo();

                   address.IdEmpresa = Info.IdEmpresa;
                   address.IdSucursal = Info.IdSucursal;
                   address.IdGrupoTrabajo = getId(Info.IdEmpresa,Info.IdSucursal);
                   address.Descripcion = Info.Descripcion;
                   address.AreaProduccion = Info.AreaProduccion;
                   address.Fecha = Info.Fecha;
                   address.Estado = Info.Estado;
                   address.Usuario = Info.Usuario;
                   context.prd_GruposTrabajo.Add(address);
                   context.SaveChanges();
                   return true;
               }
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




       public int getId(int idempresa, int idsucursal)
       {
           try
           {
               int Id;
               EntitiesProduccion_Cidersus OEProduccion = new EntitiesProduccion_Cidersus();
               var select = from q in OEProduccion.prd_GruposTrabajo
                            where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                            select q;

               if (select.ToList().Count < 1)
               {
                   Id = 1;
               }
               else
               {
                   var select_pv = (from q in OEProduccion.prd_GruposTrabajo
                                    where q.IdEmpresa == idempresa && q.IdSucursal == idsucursal
                                    select q.IdGrupoTrabajo).Max();
                   Id = Convert.ToInt32(select_pv.ToString()) + 1;
               }
               return Id;
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
    }
}
