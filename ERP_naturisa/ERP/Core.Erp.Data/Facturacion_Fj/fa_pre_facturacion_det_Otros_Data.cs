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
   public class fa_pre_facturacion_det_Otros_Data
   {
       tb_sis_Log_Error_Vzen oDataLog = new tb_sis_Log_Error_Vzen();
       string MensajeError = "";
       public bool GuardarDB(List<fa_pre_facturacion_det_Otros_Info> lista)
       {
           try
           {
               int secuencia = 0;
               using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
               {
                   foreach (var item in lista)
                   {
                       fa_pre_facturacion_det_Otros add = new fa_pre_facturacion_det_Otros();
                       secuencia++;
                       add.IdEmpresa = item.IdEmpresa;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.secuencia = secuencia;
                       add.Valor = item.Valor;
                       add.Nombre_Cobro = item.Nombre_Cobro;
                       add.Observacion = item.Observacion;
                       database.fa_pre_facturacion_det_Otros.Add(add);
                       database.SaveChanges();

                   }


               }
               return true;

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
       public bool EliminarDB(int IdEmpresa, int IdLiquidaciones)
       {
           try
           {
               using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
               {

                   string SQL = "delete Fj_servindustrias.fa_pre_facturacion_det_Otros where IdEmpresa='" + IdEmpresa + "' and IdPreFacturacion='" + IdLiquidaciones + "'";
                   database.Database.ExecuteSqlCommand(SQL);
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
       public List<fa_pre_facturacion_det_Otros_Info> Get_Lids( int IdEmpres, int IdPrefacturacion)
       {
           try
           {
               List<fa_pre_facturacion_det_Otros_Info> lista = new List<fa_pre_facturacion_det_Otros_Info>();

               int secuencia = 0;
               using (Entity_Facturacion_FJ database = new Entity_Facturacion_FJ())
               {

                   var lst = from q in database.fa_pre_facturacion_det_Otros
                             where q.IdEmpresa == IdEmpres
                             && q.IdPreFacturacion >= IdPrefacturacion
                             select q;

                   foreach (var item in lst)
                   {
                       fa_pre_facturacion_det_Otros_Info add = new fa_pre_facturacion_det_Otros_Info();
                       secuencia++;
                       add.IdEmpresa = item.IdEmpresa;
                       add.IdPreFacturacion = item.IdPreFacturacion;
                       add.secuencia = secuencia;
                       add.Valor = item.Valor;
                       add.Nombre_Cobro = item.Nombre_Cobro;
                       add.Observacion = item.Observacion;
                       lista.Add(add);
                   }


               }
               return lista;

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
