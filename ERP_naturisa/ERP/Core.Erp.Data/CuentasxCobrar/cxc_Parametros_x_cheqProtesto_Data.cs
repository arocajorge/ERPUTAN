using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.CuentasxCobrar;
using Core.Erp.Info.General;
using Core.Erp.Data.General;

namespace Core.Erp.Data.CuentasxCobrar
{
   public class cxc_Parametros_x_cheqProtesto_Data
    {
       string mensaje = "";
       public Boolean GuardarDB(cxc_Parametros_x_cheqProtesto_Info Info)
       {
           try
           {
               using (EntitiesCuentas_x_Cobrar Context = new EntitiesCuentas_x_Cobrar())
               {

                       var Address = new cxc_Parametros_x_cheqProtesto();

                       Address.IdEmpresa = Info.IdEmpresa;
                       Address.secuencia = Info.secuencia;
                       Address.pa_IdSucursal_x_default_x_cheqProtes = Info.pa_IdSucursal_x_default_x_cheqProtes;
                       Address.pa_IdBodega_x_default_x_cheqProtes = Info.pa_IdBodega_x_default_x_cheqProtes;
                       Address.pa_IdProducto_x_ND_x_CheqProtes = (Info.pa_IdProducto_x_ND_x_CheqProtes == 0) ? null : Info.pa_IdProducto_x_ND_x_CheqProtes;
                       Address.pa_IdProducto_x_NC_x_Cobro = (Info.pa_IdProducto_x_NC_x_Cobro == 0) ? null : Info.pa_IdProducto_x_NC_x_Cobro;
                       Context.cxc_Parametros_x_cheqProtesto.Add(Address);
                       Context.SaveChanges(); 

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
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public Boolean GuardarDB(List<cxc_Parametros_x_cheqProtesto_Info> lst,int IdEmpresa)
       {
           try
           {
               int secu = 0;
               using (EntitiesCuentas_x_Cobrar context = new EntitiesCuentas_x_Cobrar())
               {
                    context.Database.ExecuteSqlCommand("delete from cxc_Parametros_x_cheqProtesto where IdEmpresa =" + IdEmpresa);
                    context.SaveChanges();
               }

               foreach (var item in lst)
               {
                   secu = secu + 1;
                   item.secuencia = secu;
                   GuardarDB(item);
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
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public List<cxc_Parametros_x_cheqProtesto_Info> Get_List_Parametros_x_cheqProtesto(int IdEmpresa)
       {
           try
           {
               List<cxc_Parametros_x_cheqProtesto_Info> Lst = new List<cxc_Parametros_x_cheqProtesto_Info>();
               EntitiesCuentas_x_Cobrar oEnti = new EntitiesCuentas_x_Cobrar();
               var Query = from q in oEnti.vwcxc_Parametros_x_cheqProtesto
                           where q.IdEmpresa == IdEmpresa
                           select q;
               foreach (var item in Query)
               {
                   cxc_Parametros_x_cheqProtesto_Info Obj = new cxc_Parametros_x_cheqProtesto_Info();
                   Obj.IdEmpresa = item.IdEmpresa;
                   Obj.secuencia = item.secuencia;
                   Obj.pa_IdSucursal_x_default_x_cheqProtes = item.pa_IdSucursal_x_default_x_cheqProtes;
                   Obj.pa_IdBodega_x_default_x_cheqProtes = item.pa_IdBodega_x_default_x_cheqProtes;
                   Obj.Bodega = item.bo_Descripcion;
                   Obj.pa_IdProducto_x_ND_x_CheqProtes = item.pa_IdProducto_x_ND_x_CheqProtes;
                   Obj.ProductoND=item.ProductoND;
                   Obj.pa_IdProducto_x_NC_x_Cobro = item.pa_IdProducto_x_NC_x_Cobro;
                   Obj.ProductoNC = item.ProductoNC;

                   Lst.Add(Obj);
               }
               return Lst;
           }
           catch (Exception ex)
           {
               string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
               mensaje = ex.InnerException + " " + ex.Message;
               throw new Exception(ex.InnerException.ToString());
           }
       }

       public cxc_Parametros_x_cheqProtesto_Data(){}
    }
}
