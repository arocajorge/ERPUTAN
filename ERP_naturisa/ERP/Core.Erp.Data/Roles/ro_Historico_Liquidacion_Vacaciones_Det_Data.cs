using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Roles;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Data.Roles
{
 public   class ro_Historico_Liquidacion_Vacaciones_Det_Data
 {
     public bool Guardar_DB(ro_Historico_Liquidacion_Vacaciones_Det_Info info)
     {
         try
         {
             using (EntitiesRoles db = new EntitiesRoles())
             {
                 ro_Historico_Liquidacion_Vacaciones_Det add = new ro_Historico_Liquidacion_Vacaciones_Det();
                 add.IdEmpresa = info.IdEmpresa;
                 add.IdNominatipo = info.IdNominatipo;
                 add.IdEmpleado = info.IdEmpleado;
                 add.IdSolicitud_Vacaciones = info.IdSolicitud_Vacaciones;
                 add.Anio = info.Anio;
                 add.Mes = info.Mes;
                 add.Total_Remuneracion = info.Total_Remuneracion;
                 add.Total_Vacaciones = info.Total_Vacaciones;
                 add.Valor_Cancelar = info.Valor_Cancelar;
                 add.Sec = info.Sec;
                 db.ro_Historico_Liquidacion_Vacaciones_Det.Add(add);
                 db.SaveChanges();
                 return true;
             }
         }
         catch (Exception ex)
         {

             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
            
             throw new Exception(ex.ToString());
         }
     }

     public bool Eliminar(ro_Historico_Liquidacion_Vacaciones_Det_Info info)
     {
         string mensaje = "";
         try
         {

             using (EntitiesRoles db = new EntitiesRoles())
             {
                 db.Database.ExecuteSqlCommand(" delete ro_Historico_Liquidacion_Vacaciones_Det where IdEmpresa='" + info.IdEmpresa + "'  and IdNominatipo='" + info.IdNominatipo + "'  and IdEmpleado='" + info.IdEmpleado + "'  and IdSolicitud_Vacaciones ='" + info.IdSolicitud_Vacaciones + "'");
                 return true;
             }
         }
         catch (Exception ex)
         {

             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
             mensaje = ex.InnerException + " " + ex.Message;
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
             throw new Exception(ex.InnerException.ToString());
         }
     }

     public List<ro_Historico_Liquidacion_Vacaciones_Det_Info> Get_Lis(int IdEmpresa, int idempleado, int idsolicitud)
     {
         List<ro_Historico_Liquidacion_Vacaciones_Det_Info> Lst = new List<ro_Historico_Liquidacion_Vacaciones_Det_Info>();
         EntitiesRoles oEnti = new EntitiesRoles();
         try
         {
             var Query = from q in oEnti.ro_Historico_Liquidacion_Vacaciones_Det
                         where q.IdEmpresa == IdEmpresa
                         && q.IdEmpleado==idempleado
                         && q.IdSolicitud_Vacaciones==idsolicitud
                         select q;
             foreach (var item in Query)
             {

                 ro_Historico_Liquidacion_Vacaciones_Det_Info add = new ro_Historico_Liquidacion_Vacaciones_Det_Info();
                 add.IdEmpresa = item.IdEmpresa;
                 add.IdNominatipo = item.IdNominatipo;
                 add.IdEmpleado = item.IdEmpleado;
                 add.IdSolicitud_Vacaciones = item.IdSolicitud_Vacaciones;
                 add.Anio = item.Anio;
                 add.Mes = item.Mes;
                 add.Total_Remuneracion = item.Total_Remuneracion;
                 add.Total_Vacaciones = item.Total_Vacaciones;
                 add.Valor_Cancelar = item.Valor_Cancelar;

                 Lst.Add(add);
             }
             return Lst;
         }
         catch (Exception ex)
         {
             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                 "", "", "", "", DateTime.Now);
             throw new Exception(ex.ToString());
         }

     }

    }
}
