using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Produc_Cirdesus;
using Core.Erp.Data.Produc_Cirdesus;
using Core.Erp.Business.General;


namespace Core.Erp.Business.Produc_Cirdesus
{        
   public class prd_OrdenesComprasPendientes_Bus
   {
       tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
       string mensaje = "";
       prd_OrdenCompras_Pendientes_Data data = new prd_OrdenCompras_Pendientes_Data();

       public List<prd_OrdenesComprasPendientes_Info> Get_lisOrdenesPendientesAprobar(int IdEmpresa, string IdStado, DateTime Fdesde, DateTime Fhasta)
       {
           try
           {
               return data.Get_lisOrdenesPendientesAprobar(IdEmpresa,IdStado,Fdesde,Fhasta);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_lisOrdenesPendientesAprobar", ex.Message), ex) { EntityType = typeof(prd_OrdenesComprasPendientes_Bus) };
               
           }
       }




       public bool AprobarOrdenesCompras(List<prd_OrdenesComprasPendientes_Info> ListadosOCAprobar)
       {
           try
           {
               return data.AprobarOrdenesCompras(ListadosOCAprobar);
           }
           catch (Exception ex)
           {

               Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
               throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "AprobarOrdenesCompras", ex.Message), ex) { EntityType = typeof(prd_OrdenesComprasPendientes_Bus) };
               
           }

       }


    }
}
