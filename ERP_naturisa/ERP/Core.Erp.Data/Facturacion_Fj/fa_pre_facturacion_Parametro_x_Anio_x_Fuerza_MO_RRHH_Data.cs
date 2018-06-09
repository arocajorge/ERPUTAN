using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
namespace Core.Erp.Data.Facturacion_Fj
{
   public class fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Data
   {
       string MensajeError = "";
       public bool Guardar(List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista)
       {
           try
           {
               using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
               {
                   foreach (var item in lista)
                   {

                       var query = from q in model.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH
                                   where q.IdEmpresa == item.IdEmpresa
                                     && q.Anio == item.Anio
                                     && q.Mes == item.Mes
                                     && q.IdFuerza == item.IdFuerza
                                   select q;

                       if (query.Count() == 0)
                       {
                           fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH add = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH();
                           add.IdEmpresa = item.IdEmpresa;
                           add.Anio = item.Anio;
                           add.Mes = item.Mes;
                           add.IdFuerza = item.IdFuerza;
                           add.Porcentaje_Calculo_MO = item.Porcentaje_Calculo_MO;
                           add.Porcentaje_Calculo_BS = item.Porcentaje_Calculo_BS;
                           add.Fecha_Fin = item.Fecha_Fin;
                           add.Fecha_Inicio = item.Fecha_Inicio;
                           model.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH.Add(add);
                           model.SaveChanges();
                       }
                       else
                       {
                           var modifi = model.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH.FirstOrDefault(q => q.IdEmpresa == item.IdEmpresa
                                     && q.Anio == item.Anio
                                     && q.Mes == item.Mes
                                     && q.IdFuerza == item.IdFuerza);
                           modifi.Porcentaje_Calculo_MO = item.Porcentaje_Calculo_MO;
                           modifi.Porcentaje_Calculo_BS = item.Porcentaje_Calculo_BS;
                           modifi.Fecha_Fin = item.Fecha_Fin;
                           modifi.Fecha_Inicio = item.Fecha_Inicio;
                           model.SaveChanges();
                       }
                   }

                   return true;

               }

           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
       public List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> Get_List_marge_ganacia_RRHH(int IdEmpresa, DateTime Fecha_Inicio, DateTime Fecha_Fin, int IdFuerza)
       {
           try
           {
               List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista = new List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info>();
               using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
               {
                   var query = from q in model.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH
                               where 
                               q.IdEmpresa == IdEmpresa
                               && q.IdFuerza == IdFuerza
                               && q.Fecha_Fin==Fecha_Fin
                               && q.Fecha_Inicio==Fecha_Inicio

                               select q;

                   foreach (var item in query)
                   {
                       fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info add = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();
                       add.IdEmpresa = item.IdEmpresa;
                       add.Anio = item.Anio;
                       add.Mes = item.Mes;
                       add.IdFuerza = item.IdFuerza;
                       add.Porcentaje_Calculo_MO = item.Porcentaje_Calculo_MO;
                       add.Porcentaje_Calculo_BS = item.Porcentaje_Calculo_BS; 
                       add.Fecha_Fin = item.Fecha_Fin;
                       add.Fecha_Inicio = item.Fecha_Inicio;
                       lista.Add(add);
                   }
                   return lista;

               }

           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
       public List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> Get_List_marge_ganacia_RRHH(int IdEmpresa, int IdFuerza)
       {
           try
           {
               List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info> lista = new List<fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info>();
               using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
               {
                   var query = from q in model.vwfa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH
                               where
                               q.IdEmpresa == IdEmpresa
                               && q.IdFuerza == IdFuerza                             
                               select q;

                   foreach (var item in query)
                   {
                       fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info add = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();
                       add.IdEmpresa = item.IdEmpresa;                       
                       add.IdFuerza = item.IdFuerza;                      
                       add.Fecha_Fin = item.Fecha_Fin;
                       add.Fecha_Inicio = item.Fecha_Inicio;
                       add.periodo = item.Fecha_Inicio.ToString().Substring(0, 10) + " al" + item.Fecha_Fin.ToString().Substring(0, 10);
                       lista.Add(add);
                   }
                   return lista;

               }

           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }
       public fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info Get_Info_marge_ganacia_RRHH(int IdEmpresa, int Anio,int Mes)
       {
           try
           {
               fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info add = new fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH_Info();

               using (Entity_Facturacion_FJ model = new Entity_Facturacion_FJ())
               {
                   var query = from q in model.fa_pre_facturacion_Parametro_x_Anio_x_Fuerza_MO_RRHH
                               where
                               q.IdEmpresa == IdEmpresa
                               && q.Anio == Anio
                               && q.Mes==Mes
                               select q;

                   foreach (var item in query)
                   {
                       add.Porcentaje_Calculo_MO = item.Porcentaje_Calculo_MO;
                       add.Porcentaje_Calculo_BS = item.Porcentaje_Calculo_BS;
                   }
                   return add;

               }

           }
           catch (Exception ex)
           {

               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               MensajeError = ex.ToString();
               throw new Exception(ex.ToString());
           }
       }

    }
}
