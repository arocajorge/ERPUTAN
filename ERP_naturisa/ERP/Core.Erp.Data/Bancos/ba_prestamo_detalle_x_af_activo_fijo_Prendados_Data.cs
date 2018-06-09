using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Bancos;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
namespace Core.Erp.Data.Bancos
{
   public class ba_prestamo_detalle_x_af_activo_fijo_Prendados_Data
    {
       tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
       string mensaje = "";
       public bool GrabarDB(List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> lista)
       {
           try
           {
               using (EntitiesBanco db= new EntitiesBanco())
               {
                   foreach (var item in lista)
                   {
                       ba_prestamo_detalle_x_af_activo_fijo_Prendados add = new ba_prestamo_detalle_x_af_activo_fijo_Prendados();
                       add.IdEmpresa = item.IdEmpresa;
                       add.IdPrestamo = item.IdPrestamo;
                       add.IdActivoFijo = item.IdActivoFijo;
                       if(item.Garantia_Bancaria>0)
                       add.Garantia_Bancaria =Convert.ToDouble( item.Garantia_Bancaria);
                       db.ba_prestamo_detalle_x_af_activo_fijo_Prendados.Add(add);
                       db.SaveChanges();
                       
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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }
       public bool EliminarDB( int IdEmpresa, int IdPrestamo)
       {
           try
           {
               using (EntitiesBanco db = new EntitiesBanco())
               {
                   string SQL = " delete ba_prestamo_detalle_x_af_activo_fijo_Prendados where IdEmpresa='" + IdEmpresa + "' and IdPrestamo='"+ IdPrestamo +"'";
                   db.Database.ExecuteSqlCommand(SQL);

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
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> Get_list_activos_prendados(int Idempresa, int IdPrestamo)
       {
           try
           {
               List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info> lista = new List<ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info>();
               using (EntitiesBanco db = new EntitiesBanco())
               {

                   var datos = (from a in db.vwba_ba_prestamo_detalle_x_af_activo_fijo_Prendados
                                where a.IdEmpresa == Idempresa
                                && a.IdPrestamo == IdPrestamo                                
                                select a);

                   foreach (var item in datos)
                   {
                       ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info info = new ba_prestamo_detalle_x_af_activo_fijo_Prendados_Info();
                   info.IdEmpresa = item.IdEmpresa;
                   info.IdPrestamo = item.IdPrestamo;
                   info.IdActivoFijo = item.IdActivoFijo;
                   info.Garantia_Bancaria = item.Garantia_Bancaria;
                   info.Af_costo_compra = item.Af_costo_compra;
                   lista.Add(info);

                   }
                   return lista;
               }
           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                   "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

    }
}
